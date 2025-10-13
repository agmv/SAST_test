using System.Diagnostics;
namespace ssRuntimeDestroyer {

public sealed partial class ENSampleListEntityEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSampleListEntityEntity).Namespace);
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "sampl_jf1oovmiqpmts9oi7sezxyk3");
}
} // ENSampleListEntityEntity

}

