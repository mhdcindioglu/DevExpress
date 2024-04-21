using DevExpress.Client;
using DevExpress.Client.Services;
using DevExpress.Office.DigitalSignatures;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;
using System.Text.Json.Serialization;

namespace DevExpress.Client;
public class Program
{
    public static string TokenKey { get; set; } = string.Empty;
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


        var serializer = SystemTextJsonContentSerializer.GetDefaultJsonSerializerOptions();
        serializer.Converters.Remove(serializer.Converters.Single(x => x.GetType().Equals(typeof(JsonStringEnumConverter))));

        var refitSettings = new RefitSettings
        {
            AuthorizationHeaderValueGetter = (rq, ct) => Task.FromResult(TokenKey),
            ContentSerializer = new SystemTextJsonContentSerializer(serializer),
        };
        builder.Services.AddRefitClient<ICustomerClient>(refitSettings).ConfigureHttpClient(sp => sp.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));


        builder.Services.AddDevExpressBlazor(options => {
            options.BootstrapVersion = Blazor.BootstrapVersion.v5;
            options.SizeMode = Blazor.SizeMode.Medium;
            options.ShowValidationIcon = true;
        });
        
        await builder.Build().RunAsync();
    }
}
