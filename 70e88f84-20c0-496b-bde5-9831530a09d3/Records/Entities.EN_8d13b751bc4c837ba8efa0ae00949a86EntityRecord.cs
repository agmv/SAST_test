using System.Diagnostics;
namespace ssRuntimeDestroyerLib {

public sealed partial class ENHttpMethodEntity {
private static readonly ActivitySource activitySource = new(typeof(ENHttpMethodEntity).Namespace);
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
switch (locale == null ? "" : locale.ToLowerInvariant()) {
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(tenant, locale.Substring(0, pos)); //fallback
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
}
} // ENHttpMethodEntity
partial class ENHttpMethodEntity : InMemoryStaticEntityRuntime<EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord, string> {
    

    private static ENHttpMethodEntity instance = new();
    public static ENHttpMethodEntity GetInstance() => instance;

    public static EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("ByF1BoUYjUqRQptRicAg2Q"), "GET" },
{ ObjectKey.Parse("yWx8oSM_90+_jhunkrNaSQ"), "POST" },
{ ObjectKey.Parse("KOlQv8lbg0Ga7T_XirWGFg"), "DELETE" },
{ ObjectKey.Parse("RHtJ32u8V02T0kjxHAAb9g"), "PUT" },

    };

    protected override Dictionary<string, EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord> RecordIdToRecordMap { get; } = new() {
        {"GET", new() {
ssId = "GET",
ssLabel = "GET",
ssOrder = 1,
ssIs_Active = true,
}},
{"POST", new() {
ssId = "POST",
ssLabel = "POST",
ssOrder = 2,
ssIs_Active = true,
}},
{"DELETE", new() {
ssId = "DELETE",
ssLabel = "DELETE",
ssOrder = 4,
ssIs_Active = true,
}},
{"PUT", new() {
ssId = "PUT",
ssLabel = "PUT",
ssOrder = 3,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

