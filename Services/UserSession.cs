using QuanLyKho.Data;

namespace QuanLyKho.Services
{
    public class UserSession
    {
        public User? CurrentUser { get; private set; }

        public void SetUser(User user)
        {
            CurrentUser = user;
        }

        public void ClearUser()
        {
            CurrentUser = null;
        }

        public bool IsAdmin => CurrentUser?.Role == 1;
        public bool IsStaff => CurrentUser?.Role == 0;
        public bool IsLoggedIn => CurrentUser != null;
    }
}