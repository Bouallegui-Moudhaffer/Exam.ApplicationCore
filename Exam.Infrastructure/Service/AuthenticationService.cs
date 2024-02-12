using Exam.ApplicationCore.Domain;
using Exam.DataPoint.Models;

namespace Exam.Infrastructure
{
    public class AuthenticationService
    {
        private readonly ApplicationDbContext _dbContext;

        public AuthenticationService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Utilisateur AuthenticateUser(LoginModel login)
        {
            // Retrieve the user from the database
            var user = _dbContext.Utilisateurs.FirstOrDefault(u => u.Username == login.Username);

            if (user != null)
            {
                return user;
            }

            return null;
        }
    }
}
