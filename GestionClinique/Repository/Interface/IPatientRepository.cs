using System.Collections.Generic;
using GestionClinique.Models;

namespace GestionClinique.Repository.Interface
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetPatients(string query);
    }
}