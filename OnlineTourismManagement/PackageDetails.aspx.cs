using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace OnlineTourismManagement
{
    public partial class PackageDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        protected void BindData()
        {
            DataTable table = AdminRepository.ViewPackage();
            GridPackageDetails.DataSource = table;
            GridPackageDetails.DataBind();
        }

        protected void PackageDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridPackageDetails.EditIndex = -1;
            BindData();
        }

        protected void PackageDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int packageId = Convert.ToInt16(GridPackageDetails.DataKeys[e.RowIndex].Values["PackageId"].ToString());
            AdminRepository.DeletePackage(packageId);
            BindData();
        }

        protected void PackageDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

            GridPackageDetails.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void PackageDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox price = GridPackageDetails.Rows[e.RowIndex].FindControl("textPackagePrice") as TextBox;
            string priceValue = price.Text;
            int packagePrice = Convert.ToInt16((priceValue.ToString()));
            int packageId = Convert.ToInt16(GridPackageDetails.DataKeys[e.RowIndex].Values["PackageId"].ToString());
            AdminRepository.UpdatePackage(packageId, packagePrice);
            GridPackageDetails.EditIndex = -1;
            BindData();

        }

        protected void GridPackageDetails_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }

        protected void GridPackageDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridPackageDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}