using System.Collections.Generic;
using System.Threading.Tasks;
using RustyDragon.Common.Model;

namespace RustyDragon.Common.Interface
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Cheese>> GetInventoryAsync();
    }
}
