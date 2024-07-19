using Microsoft.AspNetCore.Builder;
using SolbegAPI;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<SolbegAPIWebTestModule>();

public partial class Program
{
}
