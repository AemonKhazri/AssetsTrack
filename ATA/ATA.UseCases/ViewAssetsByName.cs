using ATA.CoreBusiness;
using ATA.UseCases.PluginInterfaces;

namespace ATA.UseCases
{
    public class ViewAssetsByName
    {
        public readonly IAssetRepository assetRepository;
        public ViewAssetsByName(IAssetRepository assetRepository)
        {
            this.assetRepository = assetRepository;
        }

        public async Task<IEnumerable<Asset>> ExecuteAsync(string name)
        {
            return await this.assetRepository.GetAssetsByName(name);
        }
    }
}
