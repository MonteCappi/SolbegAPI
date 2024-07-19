using System.Threading.Tasks;

namespace SolbegAPI.Data;

public interface ISolbegAPIDbSchemaMigrator
{
    Task MigrateAsync();
}
