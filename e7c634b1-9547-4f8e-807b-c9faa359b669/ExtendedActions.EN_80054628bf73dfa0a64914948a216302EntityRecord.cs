using System.Diagnostics;
namespace ssRuntimeDestroyer {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSampleListGet
/// </summary>

public static async Task<RC_49344a0c853da358d36b40a428b7e5a5> GetSampleListGet(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_49344a0c853da358d36b40a428b7e5a5 outParamRecord = default;
outParamRecord = new RC_49344a0c853da358d36b40a428b7e5a5();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSampleListGet", "154f49cb-6ede-4dc4-869d-0fdbf4000911.#GetEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
try {
outParamRecord = ENSampleListGetEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
" FROM " + ENSampleListGetEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetSampleListGet", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENSampleListGetEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
}
return outParamRecord;
}

}
}
