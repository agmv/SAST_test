using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: GetActivityKind
/// </summary>

public static async Task<RC_99e7afb0bae555fcf70d1cd06f23ae14> GetActivityKind(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_99e7afb0bae555fcf70d1cd06f23ae14 outParamRecord = default;
outParamRecord = new RC_99e7afb0bae555fcf70d1cd06f23ae14();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityKind", "d9b70551-21f0-8afd-57cd-ef2ebb4d7795.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
try {
outParamRecord = ENActivityKindEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("ActivityKind", "inParamId");
}
return outParamRecord;
}

}
}
