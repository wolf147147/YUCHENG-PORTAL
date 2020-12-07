using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Web.Controllers
{
    public class PortalController : Controller
    {
        // GET: Portal
        public ActionResult Index()
        {
            return View();
        }

        #region 金融板块
        /// <summary>
        /// 金融板块门户页
        /// </summary>
        /// <returns></returns>
        public ActionResult JinRong()
        {
            return View();
        }

        /// <summary>
        /// 金融板块移动端门户页
        /// </summary>
        /// <returns></returns>
        public ActionResult JinRongMobile()
        {
            return View();
        }
        #endregion

        #region 科技板块
        /// <summary>
        /// 科技板块门户页
        /// </summary>
        /// <returns></returns>
        public ActionResult Technology()
        {
            return View();
        }

        /// <summary>
        /// 科技板块移动端门户页
        /// </summary>
        /// <returns></returns>
        public ActionResult TechnologyMobile()
        {
            return View();
        }
        #endregion
    }
}