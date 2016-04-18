namespace GuestService.Controllers.Html
{
    using System.Web.Mvc;
    using GuestService.Models;
    using Sm.System.Mvc.Language;
    using System;
    using Notifications;

    public class FeedbackFormController : BaseController
    {
        [AllowAnonymous, ActionName("index")]
        public ActionResult Index()
        {
            FeedbackFormContext model = new FeedbackFormContext();
            
            return base.View(model);
        }

        [AllowAnonymous, ActionName("Index"), HttpPost, ValidateAntiForgeryToken]
        public ActionResult Index(FeedbackFormContext model)
        {
            if (base.ModelState.IsValid)
            {
                try
                {
                    new SimpleEmailService().SendEmail<FeedbackFormContext>(Settings.EmailForCancellation,
                                                        "send_feedback",
                                                        "en",
                                                        model);

                    ((dynamic)base.ViewBag).success = true;
                }
                catch (Exception exception)
                {
                    base.ModelState.AddModelError("", exception);
                    ((dynamic)base.ViewBag).success = false;
                }
            }

            
            return base.View(model);
        }
    }
}
