using System.Diagnostics;
namespace ssRuntimeDestroyer {

public sealed partial class ENAIContentTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAIContentTypeEntity).Namespace);
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "osvue_ai_content_type");
}
} // ENAIContentTypeEntity
partial class ENAIContentTypeEntity : InMemoryStaticEntityRuntime<ENAIContentTypeEntityRecord, long> {
    

    private static ENAIContentTypeEntity instance = new();
    public static ENAIContentTypeEntity GetInstance() => instance;

    public static ENAIContentTypeEntityRecord GetRecordById(long id) {
return instance.GetRecord(id);
}

    public static ENAIContentTypeEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, long> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("w473PMttLk27+28jYJTy+A"), Convert.ToInt64(1) },
{ ObjectKey.Parse("7OAvHe81qEaBE_fw3r_MsQ"), Convert.ToInt64(2) },
{ ObjectKey.Parse("cG_97wBseU2bjFUuShIdug"), Convert.ToInt64(3) },

    };

    protected override Dictionary<long, ENAIContentTypeEntityRecord> RecordIdToRecordMap { get; } = new() {
        {Convert.ToInt64(1), new() {
ssId = Convert.ToInt64(1),
ssName = "TextContent",
}},
{Convert.ToInt64(2), new() {
ssId = Convert.ToInt64(2),
ssName = "ImageURL",
}},
{Convert.ToInt64(3), new() {
ssId = Convert.ToInt64(3),
ssName = "ImageBinary",
}},

    };

    protected override Dictionary<string, Dictionary<long, ENAIContentTypeEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

