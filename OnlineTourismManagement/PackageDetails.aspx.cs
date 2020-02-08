using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TourismManagement.BL;
using TourismManagement.Entity;

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
            DataTable table = PackageBL.ShowPackage();
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
            PackageBL.DeletePackage(packageId);
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
            PackageBL.UpdatePackage(packageId, packagePrice);
            GridPackageDetails.EditIndex = -1;
            BindData();

        }
        protected void linkInsert_Click(object sender, EventArgs e)
        {
            TextBox name =(GridPackageDetails.FooterRow.FindControl("txtPackageName") as TextBox);
            TextBox type= (GridPackageDetails.FooterRow.FindControl("txtPackageType") as TextBox);
            TextBox price = GridPackageDetails.FooterRow.FindControl("txtPackagePrice") as TextBox;
            string packageName = name.Text;
            string packageType = type.Text;
            int packagePrice= Convert.ToInt32((price.Text).ToString());
            Package package = new Package(packageName, packageType, packagePrice);
            PackageBL.InsertPackage(package);
            BindData();
        }
    }
}