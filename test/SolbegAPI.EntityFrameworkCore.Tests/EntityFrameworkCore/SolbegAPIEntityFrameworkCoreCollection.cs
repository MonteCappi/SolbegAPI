using Xunit;

namespace SolbegAPI.EntityFrameworkCore;

[CollectionDefinition(SolbegAPITestConsts.CollectionDefinitionName)]
public class SolbegAPIEntityFrameworkCoreCollection : ICollectionFixture<SolbegAPIEntityFrameworkCoreFixture>
{

}
