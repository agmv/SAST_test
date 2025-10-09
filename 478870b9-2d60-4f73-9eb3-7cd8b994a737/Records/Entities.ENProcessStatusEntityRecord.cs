using System.Diagnostics;
namespace ssSystem_ {

public sealed partial class ENProcessStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProcessStatusEntity).Namespace);
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
switch (locale == null ? "" : locale.ToLowerInvariant()) {
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(tenant, locale.Substring(0, pos)); //fallback
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
}
} // ENProcessStatusEntity
partial class ENProcessStatusEntity : InMemoryStaticEntityRuntime<ENProcessStatusEntityRecord, long> {
    

    private static ENProcessStatusEntity instance = new();
    public static ENProcessStatusEntity GetInstance() => instance;

    public static ENProcessStatusEntityRecord GetRecordById(long id) {
return instance.GetRecord(id);
}

    public static ENProcessStatusEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, long> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("HK7HI_G6S0elndZtDcw+GQ"), Convert.ToInt64(1) },
{ ObjectKey.Parse("MnrlLBHIHEG_dtKIhlB4EQ"), Convert.ToInt64(2) },
{ ObjectKey.Parse("A78nqezbL0qVedRsBQPioQ"), Convert.ToInt64(4) },
{ ObjectKey.Parse("lZ5puamKn0GSjJog96He1A"), Convert.ToInt64(3) },

    };

    protected override Dictionary<long, ENProcessStatusEntityRecord> RecordIdToRecordMap { get; } = new() {
        {Convert.ToInt64(1), new() {
ssId = Convert.ToInt64(1),
ssName = "Active",
}},
{Convert.ToInt64(2), new() {
ssId = Convert.ToInt64(2),
ssName = "ActiveWithErrors",
}},
{Convert.ToInt64(4), new() {
ssId = Convert.ToInt64(4),
ssName = "Terminated",
}},
{Convert.ToInt64(3), new() {
ssId = Convert.ToInt64(3),
ssName = "Done",
}},

    };

    protected override Dictionary<string, Dictionary<long, ENProcessStatusEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

