using System;

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
            UserRepository user = new UserRepository();
            bool isValid = user.ValidateLogin(username, password);
            if (isValid)
                Response.Write("Sign in successfully completed");
            else
                Response.Write("Sign in not completed..Please create your account or check your password");
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUpForm.aspx");
        }
    }
}