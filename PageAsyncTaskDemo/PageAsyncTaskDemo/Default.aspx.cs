using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageAsyncTaskDemo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Define the asynchronuous task.
            SlowTask slowTask1 = new SlowTask();
            SlowTask slowTask2 = new SlowTask();
            SlowTask slowTask3 = new SlowTask();

            PageAsyncTask asyncTask1 = new PageAsyncTask(slowTask1.OnBegin, slowTask1.OnEnd, slowTask1.OnTimeout, "Async1", true);
            PageAsyncTask asyncTask2 = new PageAsyncTask(slowTask2.OnBegin, slowTask2.OnEnd, slowTask2.OnTimeout, "Async2", true);
            PageAsyncTask asyncTask3 = new PageAsyncTask(slowTask3.OnBegin, slowTask3.OnEnd, slowTask3.OnTimeout, "Async3", true);

            // Register the asynchronous task.
            Page.RegisterAsyncTask(asyncTask1);
            Page.RegisterAsyncTask(asyncTask2);
            Page.RegisterAsyncTask(asyncTask3);

            // Execute the register asynchronous task.
            Trace.Write("Registering async tasks");
            Page.ExecuteRegisteredAsyncTasks();
            Trace.Write("Executed async tasks");

            TaskMessage.InnerHtml = slowTask1.GetAsyncTaskProgress() + "<br />" + slowTask2.GetAsyncTaskProgress() + "<br />" + slowTask3.GetAsyncTaskProgress();

        }
    }
}
