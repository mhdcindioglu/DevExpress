using DevExpress.Shared.VMs;
using Refit;

namespace DevExpress.Client.Services;

public interface ICustomerClient
{
    [Get("/Api/DimCustomers")]
    Task<List<DimCustomerVM>> GetDimCustomer();
    
    [Put("/Api/DimCustomers/{id}")]
    Task PutDimCustomer(int id, DimCustomerVM dimCustomer);
}
