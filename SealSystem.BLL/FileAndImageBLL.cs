using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    public class FileAndImageBLL
    {
        /// <summary>
        /// 添加文件/图像
        /// </summary>
        /// <param name="name">文件名称</param>
        /// <param name="namePath">文件路径</param>
        /// <param name="sealInforNew_Id">是哪个印章里面的相关文件编码</param>
        /// <param name="note">备注</param>
        /// <returns></returns>
        public static async Task AddAsync(string name, string namePath, string sealInforNew_SealInforNum, string note)
        {
            using (var db = new DAL.FileAndImageDAL())
            {
                await db.AddAsync(new Models.FileAndImage()
                {
                    Name = name,
                    NamePath = namePath,
                    SealInforNew_SealInforNum = sealInforNew_SealInforNum,
                    Note = note
                });
            }
        }
        /// <summary>
        /// 获取所有的文件/图像数据
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.FileAndImage>> GetAll()
        {
            using (var db = new DAL.FileAndImageDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 根据id获取相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<Models.FileAndImage> GetFileAndImageOneForId(int id)
        {
            using (var db = new DAL.FileAndImageDAL())
            {
                return await db.GetOneAsync(id);
            }
        }
        /// <summary>
        /// 根据文件/图像名获取相应的数据
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task<List<Models.FileAndImage>> GetFileAndImageOneForName(string name)
        {
            using (var db = new DAL.FileAndImageDAL())
            {
                return await db.GetAll().Where(m => m.Name == name).ToListAsync();
            }
        }
        /// <summary>
        /// 根据印章编号获取相应的数据
        /// </summary>
        /// <param name="sealInforNew_Id"></param>
        /// <returns></returns>
        public static async Task<Models.FileAndImage> GetFileAndImageOneForSealInforNew_Id(string sealInforNew_SealInforNum)
        {
            using (var db = new DAL.FileAndImageDAL())
            {
                return await db.GetAll().FirstAsync(m => m.SealInforNew_SealInforNum == sealInforNew_SealInforNum);
            }
        }
        /// <summary>
        /// 根据印章编号获取相应的文件/图像路径 
        /// </summary>
        /// <param name="sealInforNew_SealInforNum"></param>
        /// <returns></returns>
        public static async Task<string> GetFileUrl(string sealInforNew_SealInforNum)
        {
            using (var db = new DAL.FileAndImageDAL())
            {
                return (await db.GetAll().FirstAsync(m => m.SealInforNew_SealInforNum == sealInforNew_SealInforNum)).NamePath;
            }
        }
        /// <summary>
        /// 根据id删除相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task RemoveAsync(int id)
        {
            using (var db = new DAL.FileAndImageDAL())
            {
               await db.RemoveAsync(id);
            }
        }
    }
}
