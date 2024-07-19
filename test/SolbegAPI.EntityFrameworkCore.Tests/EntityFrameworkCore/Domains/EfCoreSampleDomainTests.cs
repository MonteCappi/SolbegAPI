using SolbegAPI.Samples;
using Xunit;

namespace SolbegAPI.EntityFrameworkCore.Domains;

[Collection(SolbegAPITestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SolbegAPIEntityFrameworkCoreTestModule>
{

}
