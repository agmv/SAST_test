using System.Diagnostics;
namespace ssSystem_ {

public sealed partial class ENActivityKindEntity {
private static readonly ActivitySource activitySource = new(typeof(ENActivityKindEntity).Namespace);
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
} // ENActivityKindEntity
partial class ENActivityKindEntity : InMemoryStaticEntityRuntime<ENActivityKindEntityRecord, long> {
    

    private static ENActivityKindEntity instance = new();
    public static ENActivityKindEntity GetInstance() => instance;

    public static ENActivityKindEntityRecord GetRecordById(long id) {
return instance.GetRecord(id);
}

    public static ENActivityKindEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(null, ""), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, long> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("ZfJJFtNzQk2SzeXX8zudCQ"), Convert.ToInt64(8) },
{ ObjectKey.Parse("EklEHb5seEy80y6xUBpjJg"), Convert.ToInt64(5) },
{ ObjectKey.Parse("0F1dcV1Z9EG4LFZ9yMBPXQ"), Convert.ToInt64(6) },
{ ObjectKey.Parse("j0yIkmx8vkC4hStYogsnig"), Convert.ToInt64(7) },
{ ObjectKey.Parse("TnEBsvhPHE2sdOvUYDO15A"), Convert.ToInt64(4) },
{ ObjectKey.Parse("Z+xvshZTD0aUDkPeD2DC+w"), Convert.ToInt64(3) },
{ ObjectKey.Parse("1oMbzr8TrkqFC6_vVTr8gQ"), Convert.ToInt64(2) },
{ ObjectKey.Parse("O7Y29kD1yEuNv13UP6c_Ww"), Convert.ToInt64(1) },

    };

    protected override Dictionary<long, ENActivityKindEntityRecord> RecordIdToRecordMap { get; } = new() {
        {Convert.ToInt64(8), new() {
ssId = Convert.ToInt64(8),
ssName = "Terminate",
}},
{Convert.ToInt64(5), new() {
ssId = Convert.ToInt64(5),
ssName = "End",
}},
{Convert.ToInt64(6), new() {
ssId = Convert.ToInt64(6),
ssName = "ConditionalStart",
}},
{Convert.ToInt64(7), new() {
ssId = Convert.ToInt64(7),
ssName = "Wait",
}},
{Convert.ToInt64(4), new() {
ssId = Convert.ToInt64(4),
ssName = "Decision",
}},
{Convert.ToInt64(3), new() {
ssId = Convert.ToInt64(3),
ssName = "HumanActivity",
}},
{Convert.ToInt64(2), new() {
ssId = Convert.ToInt64(2),
ssName = "AutomaticActivity",
}},
{Convert.ToInt64(1), new() {
ssId = Convert.ToInt64(1),
ssName = "Start",
}},

    };

    protected override Dictionary<string, Dictionary<long, ENActivityKindEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

