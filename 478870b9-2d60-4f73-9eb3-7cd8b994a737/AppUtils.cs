using OutSystems.Application.ManifestGeneration;

namespace ssSystem_;

public sealed class AppUtils : BaseAppUtils {
    // Entity functions (<Entity>.LocalViewName, <Entity>.AttributeDatabaseName) by entity name.
    private static Dictionary<string, Tuple<Func<long?, string, string>, Func<string, string>>> entityFunctions;

    static AppUtils() {
        // Session
#pragma warning disable 0618
        SessionDefaults.SessionDefaultFunctions += StaticProperties.Instance.GetSessionDefault;
#pragma warning restore 0618
    }

    public static readonly AppUtils Instance = new();

    protected override long GetTenantId(IRequestContext requestContext) {
        return requestContext.AppInfo.Tenant.Id;
    }

    public override string GetImagePath(bool forInternalAccess = false, bool includeSessionIdIfNeeded = false, string nameOverride = null, bool skipSeo = false) {
        return "/System_/";
    }

    protected override string EntityToTablename(string entity, long tenantId) {
        string entityLC = entity.ToLowerInvariant();

        var entityFuncs = GetEntityFunctions(entityLC);

        if (entityFuncs != null) {
            return entityFuncs.Item1(App.Tenant.Id, BuiltInFunction.GetCurrentLocale()); // Item1 is LocalViewName method.
        }

        throw DatabaseErrorsHelper.UnknownEntity(entity);
    }

    protected override string EntityAttributeToColumnName(string entityName, string attributeName) {
        string entityNameLC = entityName.ToLowerInvariant();
        string columnName = null;

        var entityFuncs = GetEntityFunctions(entityNameLC);

        if (entityFuncs != null) {
            columnName = entityFuncs.Item2(attributeName); // Item2 is AttributeDatabaseName method.
        }

        if (string.IsNullOrEmpty(columnName)) {
            throw DatabaseErrorsHelper.UnknownAttribute(attributeName, entityName);
        }

        return columnName;
    }

    public string RuntimeEntityReplace(string entity, IRequestContext requestContext) {
        long tenantId = GetTenantId(requestContext);
        return EntityToTablename(entity, tenantId);
    }

    private static readonly Regex LinkRegex = new(@"@(?:\.?\w)+$", RegexOptions.Compiled | RegexOptions.CultureInvariant);
    public string RuntimeEntityReplaceLinkTable(string resolvedTableName, string attr) {
        if (!string.IsNullOrEmpty(attr)) {
            var linkMatch = LinkRegex.Match(resolvedTableName);
            if ((linkMatch != null) && linkMatch.Success) {
                string linkPart = linkMatch.Value;
                resolvedTableName = resolvedTableName.Remove(resolvedTableName.Length - linkPart.Length, linkPart.Length);
                return resolvedTableName + attr + linkPart;
            }
        }
        return resolvedTableName + attr;
    }

    public void RuntimeCheckReadOnlyEntity(string[] entitiesToCheck) {
        foreach (string entity in entitiesToCheck) {
            if (CheckReadOnlyInvalidOperations(entity)) {
                throw DatabaseErrorsHelper.EntityReadOnly(entity);
            }
        }
    }

    protected override bool CheckReadOnlyInvalidOperations(string entity) {
        string entityLC = entity.ToLowerInvariant();
if (entityLC == "runtimetype")
    return true;
if (entityLC == "processstatus")
    return true;
if (entityLC == "activitystatus")
    return true;
if (entityLC == "activitykind")
    return true;

        return false;
    }

    public static ObjectKey eSpaceId {
        get {
            return eSpaceKey;
        }
    }

    public static ObjectKey eSpaceKey {
        get {
            return StaticProperties.Instance.ESpaceKey;
        }
    }

    public static ISitePropertiesInfo SiteProperties {
        get {
            return App.Espace(eSpaceKey).EspaceSiteProperties;
        }
    }

    public static IAppInfo App {
        get {
            return AppInfo.GetAppInfo();
        }
    }

    public static Tuple<Func<long?, string, string>, Func<string, string>> GetEntityFunctions(string entityName) {
        entityFunctions ??= new Dictionary<string, Tuple<Func<long?, string, string>, Func<string, string>>>() {
            			{ "activitydefinitionlink", new Tuple<Func<long?, string, string>, Func<string, string>>(ENActivityDefinitionLinkEntity.LocalViewName, ENActivityDefinitionLinkEntity.AttributeDatabaseName)}, 
			{ "runtimetype", new Tuple<Func<long?, string, string>, Func<string, string>>(ENRuntimeTypeEntity.LocalViewName, ENRuntimeTypeEntity.AttributeDatabaseName)}, 
			{ "activityoutput", new Tuple<Func<long?, string, string>, Func<string, string>>(ENActivityOutputEntity.LocalViewName, ENActivityOutputEntity.AttributeDatabaseName)}, 
			{ "processoutputdefinition", new Tuple<Func<long?, string, string>, Func<string, string>>(ENProcessOutputDefinitionEntity.LocalViewName, ENProcessOutputDefinitionEntity.AttributeDatabaseName)}, 
			{ "processinstance", new Tuple<Func<long?, string, string>, Func<string, string>>(ENProcessInstanceEntity.LocalViewName, ENProcessInstanceEntity.AttributeDatabaseName)}, 
			{ "processinputdefinition", new Tuple<Func<long?, string, string>, Func<string, string>>(ENProcessInputDefinitionEntity.LocalViewName, ENProcessInputDefinitionEntity.AttributeDatabaseName)}, 
			{ "processstatus", new Tuple<Func<long?, string, string>, Func<string, string>>(ENProcessStatusEntity.LocalViewName, ENProcessStatusEntity.AttributeDatabaseName)}, 
			{ "activitydefinition", new Tuple<Func<long?, string, string>, Func<string, string>>(ENActivityDefinitionEntity.LocalViewName, ENActivityDefinitionEntity.AttributeDatabaseName)}, 
			{ "humanactivityinstance", new Tuple<Func<long?, string, string>, Func<string, string>>(ENHumanActivityInstanceEntity.LocalViewName, ENHumanActivityInstanceEntity.AttributeDatabaseName)}, 
			{ "processdefinition", new Tuple<Func<long?, string, string>, Func<string, string>>(ENProcessDefinitionEntity.LocalViewName, ENProcessDefinitionEntity.AttributeDatabaseName)}, 
			{ "activitystatus", new Tuple<Func<long?, string, string>, Func<string, string>>(ENActivityStatusEntity.LocalViewName, ENActivityStatusEntity.AttributeDatabaseName)}, 
			{ "activityoutputdefinition", new Tuple<Func<long?, string, string>, Func<string, string>>(ENActivityOutputDefinitionEntity.LocalViewName, ENActivityOutputDefinitionEntity.AttributeDatabaseName)}, 
			{ "processinput", new Tuple<Func<long?, string, string>, Func<string, string>>(ENProcessInputEntity.LocalViewName, ENProcessInputEntity.AttributeDatabaseName)}, 
			{ "processoutput", new Tuple<Func<long?, string, string>, Func<string, string>>(ENProcessOutputEntity.LocalViewName, ENProcessOutputEntity.AttributeDatabaseName)}, 
			{ "user", new Tuple<Func<long?, string, string>, Func<string, string>>(ENUserEntity.LocalViewName, ENUserEntity.AttributeDatabaseName)}, 
			{ "humanactivityrole", new Tuple<Func<long?, string, string>, Func<string, string>>(ENHumanActivityRoleEntity.LocalViewName, ENHumanActivityRoleEntity.AttributeDatabaseName)}, 
			{ "tenant", new Tuple<Func<long?, string, string>, Func<string, string>>(ENTenantEntity.LocalViewName, ENTenantEntity.AttributeDatabaseName)}, 
			{ "activityinstance", new Tuple<Func<long?, string, string>, Func<string, string>>(ENActivityInstanceEntity.LocalViewName, ENActivityInstanceEntity.AttributeDatabaseName)}, 
			{ "activitydefinitionlanguage", new Tuple<Func<long?, string, string>, Func<string, string>>(ENActivityDefinitionLanguageEntity.LocalViewName, ENActivityDefinitionLanguageEntity.AttributeDatabaseName)}, 
			{ "processdefinitionlanguage", new Tuple<Func<long?, string, string>, Func<string, string>>(ENProcessDefinitionLanguageEntity.LocalViewName, ENProcessDefinitionLanguageEntity.AttributeDatabaseName)}, 
			{ "activitykind", new Tuple<Func<long?, string, string>, Func<string, string>>(ENActivityKindEntity.LocalViewName, ENActivityKindEntity.AttributeDatabaseName)}, 
			{ "activitydefinitionrole", new Tuple<Func<long?, string, string>, Func<string, string>>(ENActivityDefinitionRoleEntity.LocalViewName, ENActivityDefinitionRoleEntity.AttributeDatabaseName)}, 
			{ "email", new Tuple<Func<long?, string, string>, Func<string, string>>(ENEmailEntity.LocalViewName, ENEmailEntity.AttributeDatabaseName)}, 
			{ "entityattribute", new Tuple<Func<long?, string, string>, Func<string, string>>(ENEntityAttributeEntity.LocalViewName, ENEntityAttributeEntity.AttributeDatabaseName)}, 
			{ "role", new Tuple<Func<long?, string, string>, Func<string, string>>(ENRoleEntity.LocalViewName, ENRoleEntity.AttributeDatabaseName)}, 
			{ "application", new Tuple<Func<long?, string, string>, Func<string, string>>(ENApplicationEntity.LocalViewName, ENApplicationEntity.AttributeDatabaseName)}, 
			{ "entity", new Tuple<Func<long?, string, string>, Func<string, string>>(ENEntityEntity.LocalViewName, ENEntityEntity.AttributeDatabaseName)}
        };
        entityFunctions.TryGetValue(entityName, out Tuple<Func<long?, string, string>, Func<string, string>> result);
        return result;
    }

    private static readonly Lazy<IResourceManager> ResourceManager = new(() => new EmbeddedResourceManager($"{StaticProperties.Instance.ESpaceName}Language", Assembly.GetExecutingAssembly()));

    public static string GetStringResource(string key, string defaultValue) {
        var requestContext = AppInfo.GetAppInfo().RequestContext;
        return ResourceManager.Value.GetString(key, requestContext.CurrentCulture) ?? defaultValue;
    }

    public static string GetEffectiveLocale() {
        return GetStringResource("EffectiveLocale", "");
    }

    internal class StaticProperties : IModuleStaticProperties {
        private static readonly Lazy<StaticProperties> InstanceHolder = new(() => new StaticProperties());

        public static StaticProperties Instance {
            get {
                return InstanceHolder.Value;
            }
        }

        private static readonly ObjectKey eSpaceKey = ObjectKey.Parse("478870b9-2d60-4f73-9eb3-7cd8b994a737") ?? ObjectKey.Dummy;
        public ObjectKey ESpaceKey {
            get {
                return eSpaceKey;
            }
        }

        // The name of the eSpace, should be used for code generation purposes and identifiers.
        public string ESpaceName {
            get {
                return "System_";
            }
        }

        // The base URL path for the application, should be used for constructing URLs and path related stuff.
        public string ESpaceUrlBasePath {
            get {
                return "System_";
            }
        }

        public string UserProviderName {
            get {
                return "System_";
            }
        }

        private static readonly ObjectKey userProviderKey = ObjectKey.Parse("478870b9-2d60-4f73-9eb3-7cd8b994a737");
        public ObjectKey UserProviderKey {
            get {
                return userProviderKey;
            }
        }

        public bool IsMultitenant {
            get {
                return false;
            }
        }

        public bool DebugMode {
            get {
                return false;
            }
        }

        public string CustomHandleDir {
            get {
                return "/";
            }
        }

        public object GetSessionDefault(string varName) {
            return null;
        }

        public void RegisterLifecycleListeners() { }

        public void RunDebuggerEndRequest() {
            
        }

        public ObjectKey ESpaceId { get { return eSpaceId; } }

        public string CacheInvalidationSuffix { get { return AppUtils.Instance.CacheInvalidationSuffix; } }
    }

    public override string[] GetAjaxJQueryFileNames() {
        throw new NotImplementedException();
    }

    public override string GetGlobalJavaScriptInclude() {
        throw new NotImplementedException();
    }

    public override string CacheInvalidationPlatformSuffix {
        get { return ""; }
    }

    public override string CacheInvalidationSuffix {
        get { return ""; }
    }
}
