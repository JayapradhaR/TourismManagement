using System;
using TourismManagement.BL;
namespace OnlineTourismManagement
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            string username = textUserId.Text;
            string password = textPassword.Text;
            bool isValid = UserBL.LoginValidation(username, password);
            if (isValid)
                Response.Write("Sign in successfully completed");
            else
                Response.Write("<script language='javascript' > window.alert('Sign in not completed...Check your username or password'); window.location='LoginForm.aspx';</script>");
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUpForm.aspx");
        }
    }
}