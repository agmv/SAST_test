using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: GetProcessStatus
/// </summary>

public static async Task<RC_a7be5795c4af08fa8098110e55d36aff> GetProcessStatus(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a7be5795c4af08fa8098110e55d36aff outParamRecord = default;
outParamRecord = new RC_a7be5795c4af08fa8098110e55d36aff();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessStatus", "315545a5-629a-986c-2082-c4074451815c.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
try {
outParamRecord = ENProcessStatusEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("ProcessStatus", "inParamId");
}
return outParamRecord;
}

}
}
