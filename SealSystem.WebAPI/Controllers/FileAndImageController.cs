using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SealSystem.WebAPI.Controllers
{
    /// <summary>
    /// 印章文件和印章图像存储
    /// </summary>
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    [RoutePrefix("api/FileAndImage")]
    public class FileAndImageController : ApiController
    {
        /// <summary>
        /// 添加一张图片或文件
        /// </summary>
        /// <param name="sealInforNum">印章编码</param>
        /// <param name="note">备注</param>
        /// <returns></returns>
        [Route("updata"),HttpPost]
        public async Task<string> UploadFileStream(string sealInforNum, string note)
        {
            string orfilename = "";//上传的文件名称
            string returns = string.Empty;
            string fileType = DateTime.Now.ToString("yyyyMMdd");//要创建的子文件夹的名字
            var uploadPath = "~/upLoads";
            string filePath = System.Web.HttpContext.Current.Server.MapPath(uploadPath + "/" + fileType + "/");//绝对路径
            //string filePath = uploadPath + "\\" + fileType + "\\";  //E:\Fileup  居家
            if (Directory.Exists(filePath) == false)
            {
                Directory.CreateDirectory(filePath);
            }

            try
            {
                var provider = new ReNameMultipartFormDataStreamProvider(filePath);

                await Request.Content.ReadAsMultipartAsync(provider).ContinueWith(o =>
                {

                    foreach (var file in provider.FileData)
                    {
                        orfilename = file.Headers.ContentDisposition.FileName.TrimStart('"').TrimEnd('"');//待上传的文件名
                        FileInfo fileinfo = new FileInfo(file.LocalFileName);
                        //判断开始
                        int maxSize = 10000000;
                        string oldName = orfilename;//选择的文件的名称
                        if (fileinfo.Length <= 0)
                        {
                            //文件大小判断 未选择上传的图片 大小为零
                        }
                        else if (fileinfo.Length > maxSize)
                        {
                            //文件大小判断 上传文件是否超限制
                        }
                        else
                        {
                            //
                            string fileExt = orfilename.Substring(orfilename.LastIndexOf('.'));
                            string Extension = fileExt;
                            string CreateTime = DateTime.Now.ToString("yyyyMMddHHmmss");

                            //定义允许上传的文件扩展名 
                            String fileTypes = "gif,jpg,jpeg,png,bmp";
                            if (String.IsNullOrEmpty(fileExt) || Array.IndexOf(fileTypes.Split(','), fileExt.Substring(1).ToLower()) == -1)
                            {

                                returns = "上传的文件格式不是图片";
                            }
                            else
                            {
                                returns = string.Format(@"/Uploads/{0}/{1}", fileType, System.IO.Path.GetFileName(file.LocalFileName));
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                returns = ex.ToString();
            }
            //var id= BLL.SealInforNewBLL.GetSealInforOne(sealInforNum).Id;
            await BLL.FileAndImageBLL.AddAsync(orfilename, returns, sealInforNum, note);
            return returns;
        }
        /// <summary>
        /// 根据印章编号获取相应的数据
        /// </summary>
        /// <param name="sealInforNew_Id"></param>
        /// <returns></returns>
        [Route("GetForSealInforNew_Id"), HttpGet]
        public async Task<SealSystem.Models.FileAndImage> GetFileAndImageOneForSealInforNew_Id(string sealInforNew_Id)
        {
            return await BLL.FileAndImageBLL.GetFileAndImageOneForSealInforNew_Id(sealInforNew_Id);
        }
        /// <summary>
        /// 根据印章编码获取相应的文件/图像路径(postman测试通过)
        /// </summary>
        /// <param name="sealInforNew_SealInforNum">印章编码</param>
        /// <returns></returns>
        [Route("filePath"),HttpGet]
        public async Task<string> GetFileUrl(string sealInforNew_SealInforNum)
        {
            return await BLL.FileAndImageBLL.GetFileUrl(sealInforNew_SealInforNum);
        }
        ///// <summary>
        ///// 添加文件/图像
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //[Route("add")]
        //public async Task AddAsync(Models.FileAndImage.FileAndImageViewModel model)
        //{
        //    await BLL.FileAndImageBLL.AddAsync(model.Name, model.NamePath, model.SealInforNew_Id, model.Note);
        //}

        /// <summary>
        /// 获取所有的文件/图像数据
        /// </summary>
        /// <returns></returns>
        [Route("all")]
        public async Task<List<SealSystem.Models.FileAndImage>> GetAll()
        {
            return await BLL.FileAndImageBLL.GetAll();
        }
        /// <summary>
        /// 根据id获取相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetForId")]
        public async Task<SealSystem.Models.FileAndImage> GetFileAndImageOneForId(int id)
        {
            return await BLL.FileAndImageBLL.GetFileAndImageOneForId(id);
        }
        /// <summary>
        /// 根据文件/图像名获取相应的数据
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Route("GetForName"),HttpGet]
        public async Task<List<SealSystem.Models.FileAndImage>> GetFileAndImageOneForName(string name)
        {
            return await BLL.FileAndImageBLL.GetFileAndImageOneForName(name);
        }
        
        /// <summary>
        /// 根据id删除相应的数据
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [Route("delete"),HttpGet]
        public async Task RemoveAsync(int id)
        {
            await BLL.FileAndImageBLL.RemoveAsync(id);
        }
    }
    /// <summary>
    /// 重命名上传的文件
    /// </summary>
    public class ReNameMultipartFormDataStreamProvider : MultipartFormDataStreamProvider
    {
        public ReNameMultipartFormDataStreamProvider(string root)
            : base(root)
        { }

        public override string GetLocalFileName(System.Net.Http.Headers.HttpContentHeaders headers)
        {

            string extension = !string.IsNullOrWhiteSpace(headers.ContentDisposition.FileName) ? Path.GetExtension(GetValidFileName(headers.ContentDisposition.FileName)) : "";
            return Guid.NewGuid().ToString().Replace("-", "") + extension;
        }

        private string GetValidFileName(string filePath)
        {
            char[] invalids = System.IO.Path.GetInvalidFileNameChars();
            return String.Join("_", filePath.Split(invalids, StringSplitOptions.RemoveEmptyEntries)).TrimEnd('.');
        }

    }
}
