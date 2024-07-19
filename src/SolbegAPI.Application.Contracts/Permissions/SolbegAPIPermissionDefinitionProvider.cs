using SolbegAPI.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SolbegAPI.Permissions;

public class SolbegAPIPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SolbegAPIPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SolbegAPIPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SolbegAPIResource>(name);
    }
}
