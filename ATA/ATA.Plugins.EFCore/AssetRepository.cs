
using ATA.CoreBusiness;
using ATA.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;


namespace ATA.Plugins.EFCore
{
   
        public class AssetRepository : IAssetRepository
        {
        private readonly ATAContext db;

        public AssetRepository(ATAContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<Asset>> GetAssetsByName(string name)
            {

            return await this.db.Assets.Where(x => x.AssetName.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                            string.IsNullOrWhiteSpace(name)).ToListAsync();

            }
        }

    
}
