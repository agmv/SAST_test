using System.Diagnostics;
namespace ssRuntimeDestroyer {

public sealed partial class ENEnum_colorEntity {
private static readonly ActivitySource activitySource = new(typeof(ENEnum_colorEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"value", "value"}, {"order", "order"}};
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
} // ENEnum_colorEntity
partial class ENEnum_colorEntity : InMemoryStaticEntityRuntime<EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord, string> {
    

    private static ENEnum_colorEntity instance = new();
    public static ENEnum_colorEntity GetInstance() => instance;

    public static EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("S_YdImXjJECSohfJCzEYMw"), "c1" },
{ ObjectKey.Parse("5lAiOuGx6UufY1AYz_3W0g"), "c2" },

    };

    protected override Dictionary<string, EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"c1", new() {
ssValue = "c1",
ssOrder = 1,
}},
{"c2", new() {
ssValue = "c2",
ssOrder = 2,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

