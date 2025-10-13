using System.Diagnostics;
namespace ssSystem_ {

public sealed partial class ENActivityOutputDefinitionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENActivityOutputDefinitionEntity).Namespace);
private static readonly System.Collections.Generic.Dictionary<string,string> entityAttributes = new() {{"id", "id"}, {"key", "key"}, {"name", "name"}, {"description", "description"}, {"activitydefinitionid", "activitydefinitionid"}, {"isactive", "isactive"}, {"datatype", "datatype"}, {"isinput", "isinput"}, {"ismandatory", "ismandatory"}, {"defaultvalue", "defaultvalue"}, {"foreignkeyentityid", "foreignkeyentityid"}};
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
} // ENActivityOutputDefinitionEntity

}

