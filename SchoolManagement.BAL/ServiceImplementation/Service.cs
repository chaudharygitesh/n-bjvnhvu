using Mapster;
using SchoolManagement.BAL.Dtos;
using SchoolManagement.BAL.ServiceInterface;
using SchoolManagement.DAL.Model;
using SchoolManagement.DAL.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.BAL.ServiceImplementation
{
    public class Service : IService
    {
        private readonly IRepository _repository;
        public Service(IRepository repository)
        {
           this._repository = repository;
        }

        public async Task<bool> AddPatient(PatientDto patientDetails)
        {
            var PatientEnitity = patientDetails.Adapt<Patient>();

            return await _repository.InsertPatient(PatientEnitity);
        }
        public async Task<bool> DeletePatient(int id)
        {

            
        }
        public async Task<IEnumerable<PatientDto>> GetAllPatientDetail()
        {

            var result = await _repository.GetAllPatientDetail();
            var convert = result.Adapt<IEnumerable<PatientDto>>();
            return convert;
        }
    }
}
