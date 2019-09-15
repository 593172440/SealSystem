using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SealSystem.WebAPI.Controllers
{
    /// <summary>
    /// 印章类型规格表(印章类型,印章规格,测试印章图片地址)
    /// </summary>
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    [RoutePrefix("api/SealCategory")]
    public class SealCategoryController : ApiController
    {
        /// <summary>
        /// 根据id获取测试印章图片地址
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("testImagePathForId"),HttpGet]
        public async Task<string> GetTestImagePathForId(int id)
        {
            string data=await BLL.SealCategoriesBLL.GetTestImagePathForId(id);
            return "/images/SealImages/" + data;
        }

        ///// <summary>
        ///// 增加印章图片地址
        ///// </summary>
        ///// <param name="imagePath">图片地址</param>
        ///// <returns></returns>
        //[Route("addTestImagePath"), HttpGet]
        //public async Task<IHttpActionResult> AddTestImagePath(string imagePath)
        //{
        //    await BLL.SealCategoriesBLL.AddTestImagePath(imagePath);
        //    return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
        //}

        /// <summary>
        /// 添加图片
        /// </summary>
        /// <returns></returns>
        //[Route("updata"), HttpPost]
        //public async Task<string> UploadFileStream()
        //{
        //    string orfilename = "";//上传的文件名称
        //    string returns = string.Empty;
        //    string fileType = DateTime.Now.ToString("yyyyMMdd");//要创建的子文件夹的名字
        //    var uploadPath = "~/upLoads";
        //    string filePath = System.Web.HttpContext.Current.Server.MapPath(uploadPath + "/" + fileType + "/");//绝对路径
        //    //string filePath = uploadPath + "\\" + fileType + "\\";  //E:\Fileup  居家
        //    if (Directory.Exists(filePath) == false)
        //    {
        //        Directory.CreateDirectory(filePath);
        //    }

        //    try
        //    {
        //        var provider = new ReNameMultipartFormDataStreamProvider(filePath);

        //        await Request.Content.ReadAsMultipartAsync(provider).ContinueWith(o =>
        //        {

        //            foreach (var file in provider.FileData)
        //            {
        //                orfilename = file.Headers.ContentDisposition.FileName.TrimStart('"').TrimEnd('"');//待上传的文件名
        //                FileInfo fileinfo = new FileInfo(file.LocalFileName);
        //                //判断开始
        //                int maxSize = 10000000;
        //                string oldName = orfilename;//选择的文件的名称
        //                if (fileinfo.Length <= 0)
        //                {
        //                    //文件大小判断 未选择上传的图片 大小为零
        //                }
        //                else if (fileinfo.Length > maxSize)
        //                {
        //                    //文件大小判断 上传文件是否超限制
        //                }
        //                else
        //                {
        //                    //
        //                    string fileExt = orfilename.Substring(orfilename.LastIndexOf('.'));
        //                    string Extension = fileExt;
        //                    string CreateTime = DateTime.Now.ToString("yyyyMMddHHmmss");

        //                    //定义允许上传的文件扩展名 
        //                    String fileTypes = "gif,jpg,jpeg,png,bmp,doc,docx,txt";
        //                    if (String.IsNullOrEmpty(fileExt) || Array.IndexOf(fileTypes.Split(','), fileExt.Substring(1).ToLower()) == -1)
        //                    {

        //                        returns = "上传的文件格式不是图片";
        //                    }
        //                    else
        //                    {
        //                        returns = string.Format(@"/Uploads/{0}/{1}", fileType, System.IO.Path.GetFileName(file.LocalFileName));
        //                    }
        //                }
        //            }
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        returns = ex.ToString();
        //    }
        //    await BLL.SealCategoriesBLL.AddTestImagePath(returns);
        //    return returns;
        //}
    }
}
