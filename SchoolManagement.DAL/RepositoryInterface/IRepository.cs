using SchoolManagement.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DAL.RepositoryInterface
{
    public interface IRepository
    {
        public Task<bool> InsertPatient(Patient patientDetails);
        public Task<IEnumerable<Patient>> GetAllPatientDetail();
        public  Task<bool> DeletePatient(int id);
    }
}
