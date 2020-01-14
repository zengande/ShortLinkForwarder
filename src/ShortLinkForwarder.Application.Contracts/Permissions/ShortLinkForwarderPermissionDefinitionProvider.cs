using ShortLinkForwarder.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ShortLinkForwarder.Permissions
{
    public class ShortLinkForwarderPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ShortLinkForwarderPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ShortLinkForwarderPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ShortLinkForwarderResource>(name);
        }
    }
}
