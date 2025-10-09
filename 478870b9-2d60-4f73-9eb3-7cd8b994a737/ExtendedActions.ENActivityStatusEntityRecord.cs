using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: GetActivityStatus
/// </summary>

public static async Task<RC_36a7d48575a55c39ace8b7f6b0cd3ac4> GetActivityStatus(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_36a7d48575a55c39ace8b7f6b0cd3ac4 outParamRecord = default;
outParamRecord = new RC_36a7d48575a55c39ace8b7f6b0cd3ac4();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityStatus", "438329de-5552-ca64-09a4-64376002d08e.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
try {
outParamRecord = ENActivityStatusEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("ActivityStatus", "inParamId");
}
return outParamRecord;
}

}
}
