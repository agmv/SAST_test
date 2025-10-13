using System.Diagnostics;
namespace ssRuntimeDestroyer {

public sealed partial class ENAIRoleEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAIRoleEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}, {"name", "name"}};
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "osvue_ai_role");
}
} // ENAIRoleEntity
partial class ENAIRoleEntity : InMemoryStaticEntityRuntime<ENAIRoleEntityRecord, long> {
    

    private static ENAIRoleEntity instance = new();
    public static ENAIRoleEntity GetInstance() => instance;

    public static ENAIRoleEntityRecord GetRecordById(long id) {
return instance.GetRecord(id);
}

    public static ENAIRoleEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, long> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("wv0b7ITLJk+J5DarIx+Tqg"), Convert.ToInt64(1) },
{ ObjectKey.Parse("xZZYcFSwnk+t7Uxvr56EaQ"), Convert.ToInt64(2) },
{ ObjectKey.Parse("y7SHbBp6_0yDjsUxUxdDCQ"), Convert.ToInt64(3) },
{ ObjectKey.Parse("4nrw1R9mR0myylMnGeHFxQ"), Convert.ToInt64(4) },

    };

    protected override Dictionary<long, ENAIRoleEntityRecord> RecordIdToRecordMap { get; } = new() {
        {Convert.ToInt64(1), new() {
ssId = Convert.ToInt64(1),
ssName = "System",
}},
{Convert.ToInt64(2), new() {
ssId = Convert.ToInt64(2),
ssName = "User",
}},
{Convert.ToInt64(3), new() {
ssId = Convert.ToInt64(3),
ssName = "Assistant",
}},
{Convert.ToInt64(4), new() {
ssId = Convert.ToInt64(4),
ssName = "Action",
}},

    };

    protected override Dictionary<string, Dictionary<long, ENAIRoleEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

