using Exam.ApplicationCore.Domain;
using Exam.ApplicationCore.Interfaces;

namespace Exam.ApplicationCore.Services
{
    public class UtilisateurService : Service<Utilisateur>, IUtilisateur
    {
        public UtilisateurService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
