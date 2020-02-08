using TourismManagement.DAL;
using TourismManagement.Entity;

namespace TourismManagement.BL
{
    public static class UserBL
    {
        public static int AddUser(UserDetails user)
        {
            return UserRepository.AddCustomer(user);
        }
        public static bool LoginValidation(string username,string password)
        {
            return UserRepository.ValidateLogin(username, password);
        }
    }
}
