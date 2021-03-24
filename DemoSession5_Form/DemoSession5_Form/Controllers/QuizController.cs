using DemoSession5_Form.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession5_Form.Controllers
{
    [Route("quiz")]
    public class QuizController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            var questionmodel = new QuestionModel();
            ViewBag.questions = questionmodel.FindAll();
            return View();
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(IFormCollection formcollection)
        {
            int score = 0;
            var questionmodel = new QuestionModel();
            foreach (var question in questionmodel.FindAll())
            {
                string strAnswerId = formcollection["question_" + question.Id].ToString();
                if (!string.IsNullOrEmpty(strAnswerId))
                {
                    int answerId = int.Parse(strAnswerId);
                    if (questionmodel.CheckCorrect(question.Id, answerId))
                    {
                        score++;
                    }
                }
                Debug.WriteLine("stranswerid : " + strAnswerId);
            }
            return View();
        }
    }
}
