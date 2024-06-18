using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocGenerator.Client
{
    public interface IClientRepository
    {
        Task<ClientModel> GetClient(Guid idClient);
    }
}
