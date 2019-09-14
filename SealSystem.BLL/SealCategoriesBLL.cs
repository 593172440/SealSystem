using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    /// <summary>
    /// 印章类型规格表
    /// </summary>
    public class SealCategoriesBLL
    {
        /// <summary>
        /// 根据印章类型和印章规格查询相应的id号是多少
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sealSpecifications"></param>
        /// <returns></returns>
        public static int GetSelected(string name,string sealSpecifications)
        {
            using (var db = new DAL.SealCategoriesDAL())
            {
                return db.GetAll().First(m => m.Name == name && m.SealSpecifications == sealSpecifications).Id;
            }
        }
        /// <summary>
        /// 根据id获取测试印章图片地址
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async  Task<string> GetTestImagePathForId(int id)
        {
            using (var db = new DAL.SealCategoriesDAL())
            {
                return (await db.GetAll().FirstAsync(m => m.Id == id)).TestImagePath;
            }
        }
    }
}
