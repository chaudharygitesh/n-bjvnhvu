using Microsoft.EntityFrameworkCore;
using SchoolManagement.DAL.DataContext;
using SchoolManagement.DAL.Model;
using SchoolManagement.DAL.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DAL.Repository
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContxt _applicationDbContxt;

        public Repository(ApplicationDbContxt applicationDbContxt)
        {
            _applicationDbContxt = applicationDbContxt;
        }

        public async Task<IEnumerable<Patient>> GetAllPatientDetail()
        {
            return await _applicationDbContxt.Gitesh_Patients.ToListAsync();
        }
        public async Task<bool> DeletePatient(int id)
        {
            var record = await _applicationDbContxt.Gitesh_Patients.FirstOrDefaultAsync(x => x.Id == id);
             _applicationDbContxt.Gitesh_Patients.Remove(record);

            await _applicationDbContxt.SaveChangesAsync();



            return true;
        }
        public async Task<bool> InsertPatient(Patient patientDetails)
        {
            await _applicationDbContxt.Gitesh_Patients.AddAsync(patientDetails);
            await _applicationDbContxt.SaveChangesAsync();
            return true;
        }
    }
}
