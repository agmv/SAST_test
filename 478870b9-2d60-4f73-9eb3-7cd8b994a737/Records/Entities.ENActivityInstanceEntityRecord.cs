using System.Diagnostics;
namespace ssSystem_ {

public sealed partial class ENActivityInstanceEntity {
private static readonly ActivitySource activitySource = new(typeof(ENActivityInstanceEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}, {"activitydefinitionid", "activitydefinitionid"}, {"processinstanceid", "processinstanceid"}, {"processdefinitionid", "processdefinitionid"}, {"status", "status"}, {"startedon", "startedon"}, {"lastmodifiedon", "lastmodifiedon"}, {"hasexpired", "hasexpired"}};
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
} // ENActivityInstanceEntity

}

