using BlogProject.DataAccess.Concrete;
using BlogProject.WebUI.Areas.Admin.Models;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        public IActionResult ExportStaticExcelArticleList()
        {
            using (var workbook= new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int articleRowCount = 2;
                foreach (var item in GetArticleList())
                {
                    worksheet.Cell(articleRowCount, 1).Value = item.ID;
                    worksheet.Cell(articleRowCount, 2).Value = item.ArticleName;
                    articleRowCount++;
                }

                using (var stream = new MemoryStream()) 
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","Calisma1.xlsx");
                }
            }
        }
        public List<ArticleModel> GetArticleList()
        {
            List<ArticleModel> articleModel = new List<ArticleModel>()
            {
                new ArticleModel{ID=1,ArticleName="C# Proglamlamaya Giriş"},
                new ArticleModel{ID=2,ArticleName="Tesla Araçları"},
                new ArticleModel{ID=3,ArticleName="2020 Olimpiyatları"},
            };
            return articleModel;
        }
        public IActionResult ArticleListExcel()
        {
            return View();
        }

        public IActionResult ExportDynamicExcelArticleList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int articleRowCount = 2;
                foreach (var item in ArticleTitleList())
                {
                    worksheet.Cell(articleRowCount, 1).Value = item.ID;
                    worksheet.Cell(articleRowCount, 2).Value = item.ArticleName;
                    articleRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }
            }
        }

        public List<ArticleModel2> ArticleTitleList()
        {
            List<ArticleModel2> articleModel2 = new List<ArticleModel2>();
            using (var projectContext = new ProjectContext()) 
            {
                articleModel2 = projectContext.Articles.Select(x => new ArticleModel2
                {
                    ID = x.ID,
                    ArticleName = x.Title
                }).ToList();
            }
            return articleModel2;
        }

        public IActionResult ArticleTitleListExcel()
        {
            return View();
        }
    }
}
