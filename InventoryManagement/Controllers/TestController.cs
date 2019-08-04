using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagement.Models;

namespace InventoryManagement.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public JsonResult ImageUpload(ImageUploadModel img)
        {
            var file = img.ImageFile;
            if (file != null)
            {
                var filename = Path.GetFileName(file.FileName);
                file.SaveAs(Server.MapPath(img.PathtoSave + filename));
            }
            return Json(file.FileName, JsonRequestBehavior.AllowGet);
        }
    }
}