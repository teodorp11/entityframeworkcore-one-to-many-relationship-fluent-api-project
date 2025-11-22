using entityframeworkcore_one_to_many_relationship_project.Data;
using entityframeworkcore_one_to_many_relationship_project.Models;
using Microsoft.EntityFrameworkCore;

namespace entityframeworkcore_one_to_many_relationship_project.Repo
{
    public class Repository
    {
        private readonly AppDbContext _appDbContext;
        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Doctor>> GetDoctors()
        {
            return await _appDbContext.Doctors.Include(d => d.Patients).ToListAsync();
        }

        public async Task AddDoctor(Doctor doctor)
        {
            await _appDbContext.Doctors.AddAsync(doctor);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task AddPatient(Patient patient)
        {
            await _appDbContext.Patients.AddAsync(patient);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Patient>> GetPatients()
        {
            return await _appDbContext.Patients.Include(p => p.Doctor).ToListAsync();
        }
    }
}