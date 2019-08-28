using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [Route("updata"),HttpPost]
        public IHttpActionResult UpFileData()//HttpPostedFileBase
        {
            List<string> savedFilePath = new List<string>();
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }
            var substringBin = AppDomain.CurrentDomain.BaseDirectory.IndexOf("bin");
            var path = AppDomain.CurrentDomain.BaseDirectory.Substring(0, substringBin);
            string rootPath = path + "upload";
            var provider = new MultipartFileStreamProvider(rootPath);
            var task = Request.Content.ReadAsMultipartAsync(provider).
                ContinueWith<HttpResponseMessage>(t =>
                {
                    if (t.IsCanceled || t.IsFaulted)
                    {
                        Request.CreateErrorResponse(HttpStatusCode.InternalServerError, t.Exception);
                    }
                    foreach (MultipartFileData item in provider.FileData)
                    {
                        try
                        {
                            string name = item.Headers.ContentDisposition.FileName.Replace("\"", "");
                            string newFileName = Guid.NewGuid().ToString("N") + Path.GetExtension(name);
                            File.Move(item.LocalFileName, Path.Combine(rootPath, newFileName));
                            //Request.RequestUri.PathAndQury为需要去掉域名的后面地址
                            //如上述请求为http://localhost:80824/api/upload/post，这就为api/upload/post
                            //Request.RequestUri.AbsoluteUri则为http://localhost:8084/api/upload/post
                            Uri baseuri = new Uri(Request.RequestUri.AbsoluteUri.Replace(Request.RequestUri.PathAndQuery, string.Empty));
                            string fileRelativePath = rootPath + "\\" + newFileName;
                            Uri fileFullPath = new Uri(baseuri, fileRelativePath);
                            savedFilePath.Add(fileFullPath.ToString());
                        }
                        catch (Exception ex)
                        {
                            string message = ex.Message;
                        }
                    }
                    return Request.CreateResponse(HttpStatusCode.Created, JsonConvert.SerializeObject(savedFilePath));
                });
            
return Ok(new Models.ResponseData() { code = 200, Data = task });

        }
        /// <summary>
        /// 添加文件/图像
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("add")]
        public async Task AddAsync(Models.FileAndImage.FileAndImageViewModel model)
        {
            await BLL.FileAndImageBLL.AddAsync(model.Name, model.NamePath, model.SealInforNew_Id, model.Note);
        }
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
        /// 根据印章编号获取相应的数据
        /// </summary>
        /// <param name="sealInforNew_Id"></param>
        /// <returns></returns>
        [Route("GetForSealInforNew_Id"),HttpGet]
        public async Task<List<SealSystem.Models.FileAndImage>> GetFileAndImageOneForSealInforNew_Id(int sealInforNew_Id)
        {
            return await BLL.FileAndImageBLL.GetFileAndImageOneForSealInforNew_Id(sealInforNew_Id);
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

}
