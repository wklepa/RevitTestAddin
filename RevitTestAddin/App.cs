#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace RevitTestAddin
{using System;
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            string msg_disp = "Hello " + string.Format(Environment.UserName) + "!";
            TaskDialog.Show("Messge", msg_disp);
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            TaskDialog.Show("Message", "Bye!");
            return Result.Succeeded;
        }
    }
}