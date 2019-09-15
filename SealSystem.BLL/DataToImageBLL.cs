using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    /// <summary>
    /// 印章图片表
    /// </summary>
    public class DataToImageBLL
    {
        /// <summary>
        /// 添加印章图片(判断印章编码是否存在,存在更新,不存在添加)
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
                var data = await db.GetAll().FirstOrDefaultAsync(m => m.SealInforNew_SealInforNum == sealInforNew_SealInforNum);
                if (data == null)//没有数据
                {
                    await db.AddAsync(new Models.DataToImage()
                    {
                        Name = name,
                        NamePath = namePath,
                        SealInforNew_SealInforNum = sealInforNew_SealInforNum,
                        Note = note
                    });
                }
                if(data!=null)
                {
                   var data2= await db.GetAll().FirstAsync(m => m.SealInforNew_SealInforNum == sealInforNew_SealInforNum);
                    data2.Name = name;
                    data2.NamePath = namePath;
                    data2.Note = note;
                    await db.EditAsync(data2);
                }




            }
        }
        /// <summary>
        /// 获取所有的图片
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.DataToImage>> GetAll()
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
        public static async Task<Models.DataToImage> GetFileAndImageOneForId(int id)
        {
            using (var db = new DAL.FileAndImageDAL())
            {
                return await db.GetOneAsync(id);
            }
        }
        /// <summary>
        /// 根据文件名获取印章图片信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task<Models.DataToImage> GetFileAndImageOneForName(string name)
        {
            using (var db = new DAL.FileAndImageDAL())
            {
                return await db.GetAll().FirstAsync(m => m.Name == name);
            }
        }
        /// <summary>
        /// 根据印章编号获取印章图片信息
        /// </summary>
        /// <param name="sealInforNew_Id"></param>
        /// <returns></returns>
        public static async Task<Models.DataToImage> GetFileAndImageOneForSealInforNew_Id(string sealInforNew_SealInforNum)
        {
            using (var db = new DAL.FileAndImageDAL())
            {
                return await db.GetAll().FirstAsync(m => m.SealInforNew_SealInforNum == sealInforNew_SealInforNum);
            }
        }
        /// <summary>
        /// 根据印章编号获取相应的图片路径 
        /// </summary>
        /// <param name="sealInforNew_SealInforNum"></param>
        /// <returns></returns>
        public static async Task<string> GetFileUrl(string sealInforNew_SealInforNum)
        {
            using (var db = new DAL.FileAndImageDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.SealInforNew_SealInforNum == sealInforNew_SealInforNum);
                return data.NamePath;
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
