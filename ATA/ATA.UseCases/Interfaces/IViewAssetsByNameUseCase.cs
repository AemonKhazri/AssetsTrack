using ATA.CoreBusiness;

namespace ATA.UseCases.Interfaces
{
    public interface IViewAssetsByNameUseCase
    {
        Task<IEnumerable<Asset>> ExecuteAsync(string name = "");
    }
}