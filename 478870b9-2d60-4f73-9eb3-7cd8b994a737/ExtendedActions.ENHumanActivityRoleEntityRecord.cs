using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateHumanActivityRole
/// </summary>

public static async Task CreateHumanActivityRole(IRequestContext requestContext,RC_87c777c37ddf7c1355edbd72c4b71391 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateHumanActivityRole", "b9c7d011-35b4-4bf1-9cb7-d493679fb729.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENHumanActivityRoleEntityRecord ssENHumanActivityRole = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENHumanActivityRoleEntity.LocalViewName(null, null) + " (" +
" \"activityinstanceid\"" +
", \"roleid\"" +
" ) VALUES (" +
" @ssActivityInstanceId" +
", @ssRoleId" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENHumanActivityRole.ssActivityInstanceId==0L)) {
insertSqlCmd.CreateParameter("@ssActivityInstanceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssActivityInstanceId", DbType.Int64, ssENHumanActivityRole.ssActivityInstanceId);

}
if ((ssENHumanActivityRole.ssRoleId=="")) {
insertSqlCmd.CreateParameter("@ssRoleId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRoleId", DbType.String, ssENHumanActivityRole.ssRoleId);

}
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateHumanActivityRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllHumanActivityRole
/// </summary>

public static async Task DeleteAllHumanActivityRole(IRequestContext requestContext,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllHumanActivityRole", "b9c7d011-35b4-4bf1-9cb7-d493679fb729.#DeleteAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENHumanActivityRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteHumanActivityRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

}
}
