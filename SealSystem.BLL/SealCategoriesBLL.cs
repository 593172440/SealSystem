using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    /// <summary>
    /// 印章类型BLL
    /// </summary>
    public class SealCategoriesBLL
    {
        /// <summary>
        /// 根据印章类型和印章规格查询相应的id号是多少
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sealSpecifications"></param>
        /// <returns></returns>
        public int GetSelected(string name,string sealSpecifications)
        {
            using (var db = new DAL.SealCategoriesDAL())
            {
                return db.GetAll().First(m => m.Name == name && m.SealSpecifications == sealSpecifications).Id;
            }
        }
    }
}
