
namespace TourismManagement.Entity
{
    public class Package
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string PackageType { get; set; }
        public int PackagePrice { get; set; }
        //public DateTime CreationDate { get; set; }
        //public DateTime UpdationDate { get; set; }
        public Package(string packageName, string packageType, int packagePrice)
        {
           // PackageId = packageId;
            PackageName = packageName;
            PackageType = packageType;
            PackagePrice = packagePrice;
            //CreationDate = creationDate;
            //UpdationDate = updationDate;
        }
    }
}
