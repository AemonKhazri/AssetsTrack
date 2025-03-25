using ATA.CoreBusiness;
using ATA.UseCases.Interfaces;
using ATA.UseCases.PluginInterfaces;

namespace ATA.UseCases
{
    public class ViewAssetsByNameUseCase : IViewAssetsByNameUseCase
    {
        public readonly IAssetRepository assetRepository;   
        public ViewAssetsByNameUseCase(IAssetRepository assetRepository)
        {
            this.assetRepository = assetRepository;
        }

        public async Task<IEnumerable<Asset>> ExecuteAsync(string name = "")
        {
            return await this.assetRepository.GetAssetsByName(name);
        }
    }
}
