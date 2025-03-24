using ATA.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATA.UseCases.PluginInterfaces
{
    public interface IAssetRepository
    {
        Task<IEnumerable<Asset>> GetAssetsByName(string name);

    }
}
