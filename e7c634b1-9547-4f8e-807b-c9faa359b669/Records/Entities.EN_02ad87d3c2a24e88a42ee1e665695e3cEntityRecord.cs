using System.Diagnostics;
namespace ssRuntimeDestroyer {

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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "httpm_jf1oovmiqpmoh6tqciomvpj3");
}
}
} // ENHttpMethodEntity
partial class ENHttpMethodEntity : InMemoryStaticEntityRuntime<EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord, string> {
    

    private static ENHttpMethodEntity instance = new();
    public static ENHttpMethodEntity GetInstance() => instance;

    public static EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("ZWw1N5J0ZUSfBmDZucJefA"), "PUT" },
{ ObjectKey.Parse("tyuGOGC_XEKW7ooXPd7F9w"), "POST" },
{ ObjectKey.Parse("Hrru19tC0UaNx9VNz1Pnhw"), "DELETE" },
{ ObjectKey.Parse("nsGI_2iSDkGfLLR9BIddaQ"), "GET" },

    };

    protected override Dictionary<string, EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"PUT", new() {
ssId = "PUT",
ssLabel = "PUT",
ssOrder = 3,
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
{"GET", new() {
ssId = "GET",
ssLabel = "GET",
ssOrder = 1,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<string, EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

