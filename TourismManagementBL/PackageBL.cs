using System.Data;
using TourismManagement.DAL;
using TourismManagement.Entity;

namespace TourismManagement.BL
{
    public static class PackageBL
    {
        public static DataTable ShowPackage()
        {
            return AdminRepository.ViewPackage();
        }
        public static void DeletePackage(int id)
        {
            AdminRepository.DeletePackage(id);
        }
        public static void UpdatePackage(int packageId,int packagePrice)
        {
            AdminRepository.UpdatePackage(packageId, packagePrice);
        }
        public static void InsertPackage(Package package)
        {
            AdminRepository.InsertPackage(package);
        }
    }
}
