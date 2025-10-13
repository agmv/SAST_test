using System.Diagnostics;
namespace ssRuntimeDestroyer {
public partial class ExtendedActions {
/// <summary>
/// Action: GetHttpMethod
/// </summary>

public static async Task<RC_ee5350e5200eabac6362c9f03f6b7e3b> GetHttpMethod(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ee5350e5200eabac6362c9f03f6b7e3b outParamRecord = default;
outParamRecord = new RC_ee5350e5200eabac6362c9f03f6b7e3b();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetHttpMethod", "8edf1e2a-f15e-4adf-9362-5125800080c3.#GetEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
try {
outParamRecord = ENHttpMethodEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"label\"" +
", \"order\"" +
", \"is_active\"" +
" FROM " + ENHttpMethodEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetHttpMethod", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENHttpMethodEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
}
return outParamRecord;
}

}
}
