using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.Async.Controllers {

    public class SampleController : AsyncController {

        public void IndexAsync() {

            AsyncManager.OutstandingOperations.Increment(4);

            var task1 = Task<string>.Factory.StartNew(() => {

                return GetReponse1();
            });
            var task2 = Task<string>.Factory.StartNew(delegate {

                return GetResponse2();
            });
            var task3 = Task<string>.Factory.StartNew(delegate {

                return GetResponse3();
            });
            var task4 = Task<string>.Factory.StartNew(delegate {

                return GetResponse4();
            });

            task1.ContinueWith(t => {

                AsyncManager.Parameters["headers1"] = t.Result;
                AsyncManager.OutstandingOperations.Decrement();
            });

            task2.ContinueWith(t => {

                AsyncManager.Parameters["headers2"] = t.Result;
                AsyncManager.OutstandingOperations.Decrement();
            });

            task3.ContinueWith(t => {

                AsyncManager.Parameters["headers3"] = t.Result;
                AsyncManager.OutstandingOperations.Decrement();
            });

            task4.ContinueWith(t => {

                AsyncManager.Parameters["headers4"] = t.Result;
                AsyncManager.OutstandingOperations.Decrement();
            });

            task3.ContinueWith(t => {

                AsyncManager.OutstandingOperations.Decrement();

            }, TaskContinuationOptions.OnlyOnFaulted);
        }

        public ActionResult IndexCompleted(string headers1, string headers2, string headers3, string headers4) {

            ViewBag.Headers = string.Join("<br/><br/>", headers1, headers2, headers3, headers4);

            return View();
        }

        public ActionResult Index2() {

            ViewBag.Headers = string.Join("<br/><br/>", GetReponse1(), GetResponse2(), GetResponse3(), GetResponse4());

            return View();
        }

        #region helpers

        string GetReponse1() {

            var req = (HttpWebRequest)WebRequest.Create("http://www.tugberkugurlu.com");
            req.Method = "HEAD";

            var resp = (HttpWebResponse)req.GetResponse();

            return FormatHeaders(resp.Headers);
        }

        string GetResponse2() {

            var req2 = (HttpWebRequest)WebRequest.Create("http://asp.net");
            req2.Method = "HEAD";

            var resp2 = (HttpWebResponse)req2.GetResponse();

            return FormatHeaders(resp2.Headers);
        }

        string GetResponse3() {

            var req = (HttpWebRequest)WebRequest.Create("http://google.com");
            req.Method = "HEAD";

            var resp = (HttpWebResponse)req.GetResponse();

            return FormatHeaders(resp.Headers);
        }

        string GetResponse4() {

            var req = (HttpWebRequest)WebRequest.Create("http://koraltravel.com");
            req.Method = "HEAD";

            var resp = (HttpWebResponse)req.GetResponse();

            return FormatHeaders(resp.Headers);
        }

        private static string FormatHeaders(WebHeaderCollection headers) {

            var headerStrings = from header in headers.Keys.Cast<string>()
                                select string.Format("{0}: {1}", header, headers[header]);

            return string.Join("<br />", headerStrings.ToArray());
        }

        #endregion

    }
}