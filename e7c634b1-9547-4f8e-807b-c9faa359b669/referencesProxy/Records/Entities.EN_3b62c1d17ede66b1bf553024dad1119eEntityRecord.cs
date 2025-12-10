using System.Diagnostics;
namespace ssRuntimeDestroyer.ReferencesProxy {

public sealed partial class ENWeekdayEntity {
private static readonly ActivitySource activitySource = new(typeof(ENWeekdayEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}, {"label", "label"}, {"order", "order"}, {"is_active", "is_active"}};
public static System.Collections.Generic.Dictionary<string,string> AttributesToDatabaseNamesMap() {
return entityAttributes;
}
public static string AttributeDatabaseName(string attributeName) {
string databaseName;
entityAttributes.TryGetValue(attributeName, out databaseName);
return databaseName;
}
public static string LocalViewName(long? tenant, string locale) {
return ViewName(null,locale);
}
public static string ViewName(long? tenant, string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "weekd_2jhmh9kn2941g92kugwqdvh4");
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("24d2d33a-c3d6-4f27-b39a-cb3c0e2adda4");
} // ENWeekdayEntity
partial class ENWeekdayEntity : InMemoryStaticEntityRuntime<EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord, int> {
    

    private static ENWeekdayEntity instance = new();
    public static ENWeekdayEntity GetInstance() => instance;

    public static EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord();
var sql = $"SELECT \"id\" \"Weekday.Id\",\"label\" \"Weekday.Label\",\"order\" \"Weekday.Order\",\"is_active\" \"Weekday.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "weekd_2jhmh9kn2941g92kugwqdvh4")} WHERE Id = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetWeekday", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("Weekday", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("RJbwMj7vY0aPwtivXC7BEw"), 1 },
{ ObjectKey.Parse("goGHNKlxEUyEXjBrBRCBUQ"), 2 },
{ ObjectKey.Parse("OQYKvlYu90WYt8YvCen5aw"), 6 },
{ ObjectKey.Parse("q6iayduNuEKHUsjTzOPpHg"), 4 },
{ ObjectKey.Parse("8FHQ14tVWUud4yVgevJAhQ"), 5 },
{ ObjectKey.Parse("iXLg6INN9Uy65vCw_cnN4w"), 3 },
{ ObjectKey.Parse("Uv4J8JfmlEW848NGCL0E3A"), 7 },

    };

    protected override Dictionary<int, EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

