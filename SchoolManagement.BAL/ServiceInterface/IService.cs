using SchoolManagement.BAL.Dtos;
using SchoolManagement.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.BAL.ServiceInterface
{
    public interface IService
    {
        public Task<bool> AddPatient(PatientDto patientDetails);
        public Task<IEnumerable<PatientDto>> GetAllPatientDetail();
        public  Task<bool> DeletePatient(int id);
    }
}
