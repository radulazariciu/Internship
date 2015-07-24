﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using CMSSite.Models.Catalog;

namespace CMSSite.Controllers
{
    public class NikeShoeVariantController : ContentController<NikeShoeVariant>
    {
        public ActionResult Index(NikeShoeVariant currentPage)
        {
            

            return View(currentPage);
        }
    }
}