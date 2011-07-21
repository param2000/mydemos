using System;
using System.Web;
using System.Web.Security;
using System.IO;
using System.Web.SessionState;

namespace CustomFileHandlerDemo.Handlers
{
    /// <summary>
    /// Handles processing requests for protected web application files, such as reports/*.pdf
    /// The reports are checked by the user role to determine access.
    /// </summary>
    public class FileProtectionHandler : IHttpHandler
    {
        #region IHttpHandler Members

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            switch (context.Request.HttpMethod)
            {
                case "GET":
                {
                    // Is the user logged-in?
                    if (!context.User.Identity.IsAuthenticated)
                    {
                        FormsAuthentication.RedirectToLoginPage();
                        return;
                    }

                    string requestedFile = context.Server.MapPath(context.Request.FilePath);

                    // Verify the user has access to the User role.
                    if (context.User.IsInRole("User"))
                    {
                        SendContentTypeAndFile(context, requestedFile);
                    }
                    else
                    {
                        // Deny access, redirect to error page or back to login page.
                        context.Response.Redirect("~/User/AccessDenied.aspx");
                        //FormsAuthentication.RedirectToLoginPage();
                    }

                    break;
                }
            }
        }

        #endregion

        private HttpContext SendContentTypeAndFile(HttpContext context, String strFile)
        {
            context.Response.ContentType = GetContentType(strFile);
            context.Response.TransmitFile(strFile);
            context.Response.End();

            return context;
        }

        private string GetContentType(string filename)
        {
            // used to set the encoding for the reponse stream
            string res = null;
            FileInfo fileinfo = new FileInfo(filename);

            if (fileinfo.Exists)
            {
                switch (fileinfo.Extension.Remove(0, 1).ToLower())
                {
                    case "pdf":
                    {
                        res = "application/pdf";
                        break;
                    }
                }

                return res;
            }

            return null;
        }
    }
}
