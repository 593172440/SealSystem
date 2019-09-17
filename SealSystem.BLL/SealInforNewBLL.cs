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
        /// 获取数据库中最大的id值
        /// </summary>
        /// <returns></returns>
        public static async Task<int> GetMaxId()
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                 return (await db.GetAll().OrderByDescending(m => m.Id).FirstAsync()).Id;
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
        /// 获取所有数据,包括外键信息
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.SealInforNew>> GetAllDetailed()
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                var sealInforNews = db._db.SealInforNews.Include(s => s.SealCategory).Include(s => s.SealUseUnitInfor);
                return await sealInforNews.ToListAsync();
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
        public static async Task AddAsync(Models.SealInforNew model)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                await db.AddAsync(model);
            }
        }
        /// <summary>
        /// 根据订单号获取所有印章信息
        /// </summary>
        /// <param name="theOrders_TheOrderCode">订单号</param>
        /// <returns></returns>
        public static async Task<List<Models.SealInforNew>> GetAllForTheOrders_TheOrderCode(string theOrders_TheOrderCode)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                return await db.GetAll().Where(m => m.TheOrders_TheOrderCode == theOrders_TheOrderCode).ToListAsync();
            }
        }

        /// <summary>
        /// 根据印章编码修改印章信息数据
        /// </summary>
        /// <param name="sealInforNum">印章编码</param>
        /// <returns></returns>
        public static async Task EditAsync(string sealInforNum, Models.SealInforNew model)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.SealInforNum == sealInforNum);
                data.EngravingLevel = model.EngravingLevel;
                data.EngravingType = model.EngravingType;
                data.ForeignLanguageContent = model.ForeignLanguageContent;
                data.MakeWay = model.MakeWay;
                data.Note = model.Note;
                data.RegistrationCategory = model.RegistrationCategory;
                data.SealCategory_Id_Code = model.SealCategory_Id_Code;
                data.SealContent = model.SealContent;
                data.SealInforNum = model.SealInforNum;
                data.SealMaterial = model.SealMaterial;
                data.SealShape = model.SealShape;
                data.User_Id = model.User_Id;
                data.SealState = model.SealState;
                data.SealUseUnitInfor_Id_UnitNumber = model.SealUseUnitInfor_Id_UnitNumber;
                data.TheProducer = model.TheProducer;
             
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 根据印章id伪删除印章信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task DeletedAsync(int id)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                await db.RemoveAsync(id);
            }
        }
        /// <summary>
        /// 根据id修改状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sealState"></param>
        /// <returns></returns>
        public static async Task SetForSealState(int id, string sealState)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                var data = await db.GetOneAsync(id);
                data.SealState = sealState;
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 修改:根据印章编码修改状态
        /// </summary>
        /// <param name="SealInforNum"></param>
        /// <param name="sealState"></param>
        /// <returns></returns>
        public static async Task SetForSealInforNum(string sealInforNum, string sealState)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.SealInforNum == sealInforNum);
                data.SealState = sealState;
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 根据id修改备案信息_id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sealApprovalUnitInfor_Id"></param>
        /// <returns></returns>
        //public static async Task SetForIdForSealApprovalUnitInfor_Id(int id, int sealApprovalUnitInfor_Id)
        //{
        //    using (var db = new DAL.SealInforNewDAL())
        //    {
        //        var data = await db.GetOneAsync(id);
        //        data.SealApprovalUnitInfor_Id = sealApprovalUnitInfor_Id;
        //        await db.EditAsync(data);
        //    }
        //}
        /// <summary>
        /// 根据订单号修改所有的备案信息_id
        /// </summary>
        /// <param name="theOrders_TheOrderCode"></param>
        /// <returns></returns>
        //public static async Task SetForTheOrders_TheOrderCodeForSealApprovalUnitInfor_Id(string theOrders_TheOrderCode, int id)
        //{
        //    using (var db = new DAL.SealInforNewDAL())
        //    {
        //        var data = await db.GetAll().Where(m => m.TheOrders_TheOrderCode == theOrders_TheOrderCode).ToListAsync();
        //        foreach (var item in data)
        //        {
        //            item.SealApprovalUnitInfor_Id = id;
        //            await db.EditAsync(item);
        //        }
        //    }
        //}
        /// <summary>
        /// 根据id获取测试/正式印章图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<string> GetTestImagePathForId(int id)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                var data = await db._db.SealInforNews.Include(s => s.SealCategory).FirstAsync(m => m.Id == id);
                return data.SealCategory.TestImagePath;
            }
        }
        /// <summary>
        /// 根据印章编码获取测试/正式印章图片
        /// </summary>
        /// <param name="sealInforNum"></param>
        /// <returns></returns>
        public static async Task<string> GetTestImagePathForSealInforNum(string sealInforNum)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                var data = await db._db.SealInforNews.Include(s => s.SealCategory).FirstAsync(m => m.SealInforNum == sealInforNum);
                return data.SealCategory.TestImagePath;
            }
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageSize">每页有多少条数据</param>
        /// <param name="pageIndex">有多少页</param>
        /// <returns></returns>
        public static async Task<List<Models.SealInforNew>> GetAllPage(int pageSize, int pageIndex)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                return await db.GetAllByPage(pageSize, pageIndex).ToListAsync();
            }
        }
        /// <summary>
        /// 分页加排序
        /// </summary>
        /// <param name="pageSize">每页有多少条数据</param>
        /// <param name="pageIndex">有多少页</param>
        /// <param name="asc">排序</param>
        /// <returns></returns>
        public static async Task<List<Models.SealInforNew>> GetAllPage(int pageSize, int pageIndex, bool asc)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                return await db.GetAllBypageOrder(pageSize, pageIndex, asc).ToListAsync();
            }
        }

        /// <summary>
        /// 修改:根据印章编码修改印章信息,
        /// </summary>
        /// <param name="sealInforNum"></param>
        /// <param name="models"></param>
        /// <returns></returns>
        public static async Task SetForTheOrders_TheOrderCode(string sealInforNum, Models.SealInforNew models)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                //根据订单号获取所有的信息包括外键信息
                //List<Models.SealInforNew> data = await db._db.SealInforNews.Include(s => s.SealCategory).Include(s => s.SealUseUnitInfor).Where(m => m.TheOrders_TheOrderCode == theOrders_TheOrderCode).ToListAsync();
                var data = await db.GetAll().FirstAsync(m => m.SealInforNum == sealInforNum);
                data.MakeWay = models.MakeWay;//制作方式
                data.Note = models.Note;//备注
                data.SealMaterial = models.SealMaterial;//章体材料代码(标准：GA 241.2)(在SealUseUnitInforList表中定义)
                await db.EditAsync(data);

            }
        }
    }
}
