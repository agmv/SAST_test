using System.Diagnostics;
using Pair = OutSystems.RuntimeCommon.Pair;

namespace ssRuntimeDestroyer;
public partial class ExtendedActions {
private static readonly ActivitySource activitySource = new(typeof(ExtendedActions).Namespace);
public static readonly ObjectKey rRuntimeDestroyerKey = ObjectKey.Parse("OWsqqzAfIE+gac9dGLB29A");
public static readonly ObjectKey roRuntimeDestroyerOwnerEspaceKey = ObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ");
/// <summary>
/// Action: CheckRuntimeDestroyerRole
/// </summary>

public static async Task<bool> CheckRuntimeDestroyerRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = GenericExtendedActions.Check(requestContext, rRuntimeDestroyerKey.AsGuid, roRuntimeDestroyerOwnerEspaceKey.AsGuid);
} else {
outParamHasRole = GenericExtendedActions.Check(requestContext, rRuntimeDestroyerKey.AsGuid, roRuntimeDestroyerOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId));
}
return outParamHasRole;
}

/// <summary>
/// Action: GrantRuntimeDestroyerRole
/// </summary>

public static async Task GrantRuntimeDestroyerRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
if (string.IsNullOrEmpty(inParamUserId)){
GenericExtendedActions.Grant(requestContext, rRuntimeDestroyerKey.AsGuid, roRuntimeDestroyerOwnerEspaceKey.AsGuid);
} else {
GenericExtendedActions.Grant(requestContext, rRuntimeDestroyerKey.AsGuid, roRuntimeDestroyerOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId));
}
return;
}

/// <summary>
/// Action: RevokeRuntimeDestroyerRole
/// </summary>

public static async Task RevokeRuntimeDestroyerRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
if (string.IsNullOrEmpty(inParamUserId)){
GenericExtendedActions.Revoke(requestContext, rRuntimeDestroyerKey.AsGuid, roRuntimeDestroyerOwnerEspaceKey.AsGuid);
} else {
GenericExtendedActions.Revoke(requestContext, rRuntimeDestroyerKey.AsGuid, roRuntimeDestroyerOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId));
}
return;
}

/// <summary>
/// Action: CommitTransaction
/// </summary>

public static async Task CommitTransaction(IRequestContext requestContext,CancellationToken cancellationToken) {
#pragma warning disable 612,618 
DatabaseAccess.CommitAllTransactions();
#pragma warning restore 612,618 
return;
}

}
