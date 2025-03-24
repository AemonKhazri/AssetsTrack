
using ATA.CoreBusiness;
using ATA.UseCases.PluginInterfaces;


namespace ATA.Plugins.EFCore
{
   
        public class AssetRepository : IAssetRepository
        {
            public Task<IEnumerable<Asset>> GetAssetsByName(string name)
            {
                throw new NotImplementedException();
            }
        }

    
}
