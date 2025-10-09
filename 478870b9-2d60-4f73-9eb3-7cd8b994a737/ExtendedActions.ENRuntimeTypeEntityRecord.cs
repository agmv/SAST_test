using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: GetRuntimeType
/// </summary>

public static async Task<RC_3251af6c799b185d408b7cad31be3454> GetRuntimeType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3251af6c799b185d408b7cad31be3454 outParamRecord = default;
outParamRecord = new RC_3251af6c799b185d408b7cad31be3454();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRuntimeType", "070281eb-7979-4bc1-b152-15a5d546e4e0.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
try {
outParamRecord = ENRuntimeTypeEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("RuntimeType", "inParamId");
}
return outParamRecord;
}

}
}
