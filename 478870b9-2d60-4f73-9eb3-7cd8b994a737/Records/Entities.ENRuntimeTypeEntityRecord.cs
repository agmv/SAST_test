using System.Diagnostics;
namespace ssSystem_ {

public sealed partial class ENRuntimeTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRuntimeTypeEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}, {"label", "label"}, {"order", "order"}, {"isactive", "isactive"}};
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
} // ENRuntimeTypeEntity
partial class ENRuntimeTypeEntity : InMemoryStaticEntityRuntime<ENRuntimeTypeEntityRecord, string> {
    

    private static ENRuntimeTypeEntity instance = new();
    public static ENRuntimeTypeEntity GetInstance() => instance;

    public static ENRuntimeTypeEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static ENRuntimeTypeEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("8JpJdpQyIUyWe96d4cOX4w"), "Mobile" },
{ ObjectKey.Parse("Es3ed8jV+0aHas7hulno2w"), "MobileLibrary" },
{ ObjectKey.Parse("myrPlj9wwEC0cZPgoMtXug"), "Service" },
{ ObjectKey.Parse("YMJat5ABCEOb7KDLtoHJZQ"), "Reactive" },
{ ObjectKey.Parse("dwmawAK3iEyN0a3+AKzJSA"), "Unknown" },
{ ObjectKey.Parse("+v5O1uONA0mpu9UceXc1xw"), "ReactiveLibrary" },

    };

    protected override Dictionary<string, ENRuntimeTypeEntityRecord> RecordIdToRecordMap { get; } = new() {
        {"Mobile", new() {
ssId = "Mobile",
ssLabel = "Mobile",
ssOrder = 2,
ssIsActive = true,
}},
{"MobileLibrary", new() {
ssId = "MobileLibrary",
ssLabel = "MobileLibrary",
ssOrder = 6,
ssIsActive = true,
}},
{"Service", new() {
ssId = "Service",
ssLabel = "Service",
ssOrder = 3,
ssIsActive = true,
}},
{"Reactive", new() {
ssId = "Reactive",
ssLabel = "Reactive",
ssOrder = 5,
ssIsActive = true,
}},
{"Unknown", new() {
ssId = "Unknown",
ssLabel = "Unknown",
ssOrder = 4,
ssIsActive = true,
}},
{"ReactiveLibrary", new() {
ssId = "ReactiveLibrary",
ssLabel = "ReactiveLibrary",
ssOrder = 7,
ssIsActive = true,
}},

    };

    protected override Dictionary<string, Dictionary<string, ENRuntimeTypeEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

