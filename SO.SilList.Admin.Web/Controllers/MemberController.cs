﻿using SO.SilList.Manager.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SO.SilList.Manager.Models.ValueObjects;

namespace SO.SilList.Admin.Web.Controllers
{
    public class MemberController : Controller
    {
        private MemberManager memberManager = new MemberManager();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _List()
        {
            var results = memberManager.getAll(null);
            return PartialView(results);
        }

        [HttpPost]
        public ActionResult Edit(int id, MemberVo input)
        {

            if (this.ModelState.IsValid)
            {
                if (input.lastLogin <= DateTime.MinValue)
                    input.lastLogin = DateTime.Now;

                var res = memberManager.update(input, id);
                return RedirectToAction("Index");
            }

            return View();

        }
        public ActionResult Edit(int id)
        {
            var result = memberManager.get(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Create(MemberVo input)
        {
            if (this.ModelState.IsValid)
            {
                if (input.siteId == null)
                {
                    input.siteId = memberManager.GetFirstAvailableSiteId();
                }

                //if ((DateTime)input.modified <= DateTime.MinValue)
                //    input.modified = input.created;
                if ((DateTime)input.lastLogin <= DateTime.MinValue)
                    input.lastLogin = DateTime.Now;
                var item = memberManager.insert(input);

                return RedirectToAction("Index");
            }


            return View();

        }

        public ActionResult Create()
        {
            MemberVo mv = new MemberVo();
            return View(mv);
        }

        public ActionResult Details(int id)
        {
            var result = memberManager.get(id);
            return View(result);
        }

        public ActionResult Menu()
        {
            return PartialView("_Menu");
        }

        public ActionResult Delete(int id)
        {
            memberManager.delete(id);
            return RedirectToAction("Index");
        }
    }
}