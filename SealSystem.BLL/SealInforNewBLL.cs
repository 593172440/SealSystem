using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace SealSystem.BLL
{
    /// <summary>
    /// 印章信息
    /// </summary>
    public class SealInforNewBLL
    {
        /// <summary>
        /// 获取数据库中全部数据条数
        /// </summary>
        /// <returns></returns>
        public string GetAllCount()
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                int str = db.GetAll().Count() + 10;//100
                string strs = str.ToString();
                int j = str.ToString().Length;
                int k = 7 - j;
                if (j < 7)
                {
                    for (int i = 0; i < k; i++)
                    {
                        strs = "0" + strs;
                    }
                }
                return strs;
            }
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.SealInforNew>> GetAll()
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 根据印章编码获取印章信息
        /// </summary>
        /// <param name="sealInforNum"></param>
        /// <returns></returns>
        public static async Task<Models.SealInforNew> GetSealInforOne(string sealInforNum)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                return await db.GetAll().FirstAsync(m => m.SealInforNum == sealInforNum);
            }
        }
        /// <summary>
        /// 增加一条印章信息数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task AddAsync(Models.SealInforNew model)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                await db.AddAsync(model);
            }
        }
        /// <summary>
        /// 根据印章编码修改印章信息数据
        /// </summary>
        /// <param name="sealInforNum">印章编码</param>
        /// <returns></returns>
        public static async Task EditAsync(string sealInforNum,Models.SealInforNew model)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                var sealInfo=await db.GetAll().FirstAsync(m => m.SealInforNum == sealInforNum);
                sealInfo.Approval = model.Approval;
                sealInfo.ApprovalTime = model.ApprovalTime;
                sealInfo.Attention = model.Attention;
                sealInfo.AttentionIdCard = model.AttentionIdCard;
                sealInfo.Contact = model.Contact;
                sealInfo.EngravingLevel = model.EngravingLevel;
                sealInfo.EngravingType = model.EngravingType;
                sealInfo.ForeignLanguageContent = model.ForeignLanguageContent;
                sealInfo.MakeWay = model.MakeWay;
                sealInfo.Note = model.Note;
                sealInfo.RegistrationCategory = model.RegistrationCategory;
                sealInfo.SealApprovalUnitInfor_Id_ApprovalUnitCode = model.SealApprovalUnitInfor_Id_ApprovalUnitCode;
                sealInfo.SealCategory_Id_Code = model.SealCategory_Id_Code;
                sealInfo.SealContent = model.SealContent;
                sealInfo.SealInforNum = model.SealInforNum;
                sealInfo.SealMakingUnitInfor_Id_MakingUnitCode = model.SealMakingUnitInfor_Id_MakingUnitCode;
                sealInfo.SealMaterial_Id_Code = model.SealMaterial_Id_Code;
                sealInfo.SealShape = model.SealShape;
                sealInfo.SealState = model.SealState;
                sealInfo.SealUseUnitInfor_Id_UnitNumber = model.SealUseUnitInfor_Id_UnitNumber;
                sealInfo.TheProducer = model.TheProducer;
                await db.EditAsync(sealInfo);
            }
        }

    }
}
