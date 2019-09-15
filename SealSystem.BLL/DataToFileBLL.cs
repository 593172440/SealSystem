using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    /// <summary>
    /// 印章文件表
    /// </summary>
    public class DataToFileBLL
    {
        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="name">文件名称</param>
        /// <param name="namePath">文件路径</param>
        /// <param name="sealInforNew_Id">是哪个印章里面的相关文件编码</param>
        /// <param name="note">备注</param>
        /// <returns></returns>
        public static async Task AddAsync(string name, string namePath, string sealInforNew_SealInforNum, string note)
        {
            using (var db = new DAL.DataFileDAL())
            {
                await db.AddAsync(new Models.DataToFile()
                {
                    Name = name,
                    NamePath = namePath,
                    SealInforNew_SealInforNum = sealInforNew_SealInforNum,
                    Note = note
                });
            }
        }
        /// <summary>
        /// 获取所有的文件
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.DataToFile>> GetAll()
        {
            using (var db = new DAL.DataFileDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 根据id获取相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<Models.DataToFile> GetFileAndImageOneForId(int id)
        {
            using (var db = new DAL.DataFileDAL())
            {
                return await db.GetOneAsync(id);
            }
        }
        /// <summary>
        /// 根据文件名获取相应的数据(一条印章信息里面包括许多条文件)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task<List<Models.DataToFile>> GetFileAndImageOneForName(string name)
        {
            using (var db = new DAL.DataFileDAL())
            {
                return await db.GetAll().Where(m => m.Name == name).ToListAsync();
            }
        }
        /// <summary>
        /// 根据印章编号获取相应的数据(一条印章信息里面包括许多条文件)
        /// </summary>
        /// <param name="sealInforNew_Id"></param>
        /// <returns></returns>
        public static async Task<List<Models.DataToFile>> GetFileAndImageOneForSealInforNew_Id(string sealInforNew_SealInforNum)
        {
            using (var db = new DAL.DataFileDAL())
            {
                return await db.GetAll().Where(m => m.SealInforNew_SealInforNum == sealInforNew_SealInforNum).ToListAsync();
            }
        }
        /// <summary>
        /// 根据印章编号获取相应的文件路径 
        /// </summary>
        /// <param name="sealInforNew_SealInforNum"></param>
        /// <returns></returns>
        public static async Task<List<string>> GetFileUrl(string sealInforNew_SealInforNum)
        {
            using (var db = new DAL.DataFileDAL())
            {
                List<string> list = new List<string>();
                var data = await db.GetAll().Where(m => m.SealInforNew_SealInforNum == sealInforNew_SealInforNum).ToListAsync();
                foreach (var item in data)
                {
                    list.Add(item.NamePath);
                }
                return list;
            }
        }
        /// <summary>
        /// 根据id删除相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task RemoveAsync(int id)
        {
            using (var db = new DAL.DataFileDAL())
            {
               await db.RemoveAsync(id);
            }
        }
    }
}
