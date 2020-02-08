using System;
using TourismManagement.BL;
using TourismManagement.Entity;
namespace OnlineTourismManagement
{
    public partial class SignUpForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Signup_Click(object sender, EventArgs e)
        {
            string firstName = textFirstName.Text;
            string lastName = textLastName.Text;
            long mobileNumber = long.Parse(textMobileNumber.Text);
            DateTime DOB = Convert.ToDateTime(textDOB.Text);
            string gender;
            if (rdoMale.Checked)
                gender = rdoMale.Text;
            else
                gender = rdoFemale.Text;
            string mailId = textMailId.Text;
            string password = textPassword.Text;
            int roleId = int.Parse(textRoleId.Text);
            UserDetails userDetails = new UserDetails(firstName, lastName, mobileNumber, DOB, gender, mailId, password,roleId);
            int rows = UserBL.AddUser(userDetails);
            if (rows >= 1)
                Response.Redirect("LoginForm.aspx");
        }
    }
}