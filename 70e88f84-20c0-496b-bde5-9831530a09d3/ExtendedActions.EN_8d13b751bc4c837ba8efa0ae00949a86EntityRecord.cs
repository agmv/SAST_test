using System.Diagnostics;
namespace ssRuntimeDestroyerLib {
public partial class ExtendedActions {
/// <summary>
/// Action: GetHttpMethod
/// </summary>

public static async Task<RC_f7a56746c7bb090f072113e146ed4d38> GetHttpMethod(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_f7a56746c7bb090f072113e146ed4d38 outParamRecord = default;
outParamRecord = new RC_f7a56746c7bb090f072113e146ed4d38();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetHttpMethod", "37468222-cab0-44f0-b809-1da6464301d0.#GetEntity", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3");
try {
outParamRecord = ENHttpMethodEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("HttpMethod", "inParamId");
}
return outParamRecord;
}

}
}
