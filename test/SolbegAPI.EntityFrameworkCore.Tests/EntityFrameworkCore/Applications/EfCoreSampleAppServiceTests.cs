using SolbegAPI.Samples;
using Xunit;

namespace SolbegAPI.EntityFrameworkCore.Applications;

[Collection(SolbegAPITestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SolbegAPIEntityFrameworkCoreTestModule>
{

}
