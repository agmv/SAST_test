using System.Diagnostics;
namespace ssRuntimeDestroyer {
public partial class ENEnum_colorEntity {
/// <summary>
/// Action: GetEnum_color
/// </summary>

public static async Task<RC_8bd458d44b2829526bf34cf688a965a6> GetEnum_color(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_8bd458d44b2829526bf34cf688a965a6 outParamRecord = default;
outParamRecord = new RC_8bd458d44b2829526bf34cf688a965a6();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetEnum_color", "378e5229-18e3-4acc-8c28-fc88604a97f7.#GetEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
try {
outParamRecord = ENEnum_colorEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"value\"" +
", \"order\"" +
" FROM " + ENEnum_colorEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"value\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetEnum_color", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENEnum_colorEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
}
return outParamRecord;
}

}
}
