using API.DTO;
using API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ICommissionRepository
    {
        void Update(UserCommission comm);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<CommissionDTO>> GetUserCommissionsAsync();
        Task<Sale?> GetUserCommission(int id);
    }
}
