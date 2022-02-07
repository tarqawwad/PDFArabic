using Rotativa;
using Rotativa.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDFArabic.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        //By Tareq Awwad
        public ActionResult Index()
        {
            return View(PrepareData());
        }

        public List<PDFArabic.Models.StudentModel> PrepareData()
        {
            var Model = new List<PDFArabic.Models.StudentModel>();
           for(int i = 1; i <= 10; i++)
            {
                Model.Add(new Models.StudentModel
                {
                    StudentName =  "محمد أحمد" + i,
                    StudentDepartment = "علم حاسوب",
                    StudentAge = i/2==0?22:23,
                    StudentAVG = i+1,
                    StudentNumber = i
                });
            }
            return Model;
        }

        [HttpGet]
        [Route("DownloadPDF",Name = "DownloadPDF")]
        public ActionResult DownloadPDF()
        {
            string fileName = $"" + "Students" + ".pdf";

            return new ViewAsPdf("~/Views/Shared/ReportStudent.cshtml", PrepareData())
            {
                FileName = fileName,
                PageOrientation = Orientation.Portrait,
                PageSize = Rotativa.Options.Size.A4,
                PageMargins = new Rotativa.Options.Margins { Left = 0, Right = 0, Top = 0, Bottom = 0 },
            };
        }
        //By Tareq Awwad
    }
}