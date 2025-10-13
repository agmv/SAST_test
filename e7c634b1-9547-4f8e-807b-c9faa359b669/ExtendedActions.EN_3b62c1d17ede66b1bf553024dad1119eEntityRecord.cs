using System.Diagnostics;
namespace ssRuntimeDestroyer {
public partial class ExtendedActions {
/// <summary>
/// Action: GetWeekday
/// </summary>

public static async Task<RC_37793b7d6834fb46c2d504f9d8c91d4a> GetWeekday(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_37793b7d6834fb46c2d504f9d8c91d4a outParamRecord = default;
outParamRecord = new RC_37793b7d6834fb46c2d504f9d8c91d4a();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENWeekdayEntity.eSpaceKey;
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetWeekday", "650f9324-c830-4a94-84be-1c0eb5d3e775.#GetEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
try {
outParamRecord = ENWeekdayEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"label\"" +
", \"order\"" +
", \"is_active\"" +
" FROM " + ENWeekdayEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetWeekday", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENWeekdayEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
}
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
return outParamRecord;
}

}
}
