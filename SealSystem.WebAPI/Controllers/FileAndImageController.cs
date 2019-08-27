using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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
