using System.Diagnostics;
namespace ssRuntimeDestroyer {

public sealed partial class ENSampleListGetEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSampleListGetEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}};
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "sampl_jf1oovmiqpmwd80zqtwtprb0");
}
} // ENSampleListGetEntity
partial class ENSampleListGetEntity : InMemoryStaticEntityRuntime<EN_80054628bf73dfa0a64914948a216302EntityRecord, int> {
    

    private static ENSampleListGetEntity instance = new();
    public static ENSampleListGetEntity GetInstance() => instance;

    public static EN_80054628bf73dfa0a64914948a216302EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_80054628bf73dfa0a64914948a216302EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("jN6lJcCJ8kCNHxWEOwVRig"), 1000 },
{ ObjectKey.Parse("gFkQtbZ+NEeUmEXQ83RIoQ"), 2000 },
{ ObjectKey.Parse("Y4ydvrK9Hk+tAsnC3FBrAA"), 3000 },

    };

    protected override Dictionary<int, EN_80054628bf73dfa0a64914948a216302EntityRecord> RecordIdToRecordMap { get; } = new() {
        {1000, new() {
ssId = 1000,
}},
{2000, new() {
ssId = 2000,
}},
{3000, new() {
ssId = 3000,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_80054628bf73dfa0a64914948a216302EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

