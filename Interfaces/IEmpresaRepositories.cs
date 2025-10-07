using AutoSchool.Models;

namespace AutoSchool.Repositories
{
    public interface IEmpresaRepositories
    {
        Task AddEmpresaAsync(Empresa empresa);
        Task DeleteEmpresaAsync(int id);
        Task<List<Empresa>> GetAllEmpresasAsync();
        Task<Empresa> GetEmpresaByIdAsync(int id);
        Task UpdateEmpresaAsync(Empresa empresa);
    }
}