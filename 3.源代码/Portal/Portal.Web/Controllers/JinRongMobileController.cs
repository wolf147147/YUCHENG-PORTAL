using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Web.Controllers
{
    public class JinRongMobileController : Controller
    {
        // GET: JinRongMobile

        #region 主页（视图）
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region 按揭贷款（视图）
        public ActionResult MortgageLoan()
        {
            return View();
        }
        #endregion

        #region 代办过户（视图）
        public ActionResult ChargeTransfer()
        {
            return View();
        }
        #endregion

        #region 红本抵押（视图）
        public ActionResult RedMortgage()
        {
            return View();
        }
        #endregion

        #region 现金赎楼（视图）
        public ActionResult CashRedemptionFloor()
        {
            return View();
        }
        #endregion

        #region 交易赎楼（视图）
        public ActionResult TradingForeclosureFloor()
        {
            return View();
        }
        #endregion




    }
}