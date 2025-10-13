namespace ssRuntimeDestroyer;
public class Functions {
/// <summary>
/// Function <code>SumFunction</code> that represents the Service Studio function
///  <code>SumFunction</code> <p> Description: </p>
/// </summary>

public static async Task<int> ActionSumFunction(IRequestContext requestContext,int inParamX,int inParamY,int inParamZ,CancellationToken cancellationToken) {
int outParamResult;
outParamResult = await Actions.ActionSumFunction(requestContext,inParamX,inParamY,inParamZ,cancellationToken);

return outParamResult;
}

/// <summary>
/// Function <code>GetMethodFunction</code> that represents the Service Studio function
///  <code>GetMethodFunction</code> <p> Description: </p>
/// </summary>

public static async Task<string> ActionGetMethodFunction(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
string outParamLabel;
outParamLabel = await Actions.ActionGetMethodFunction(requestContext,inParamId,cancellationToken);

return outParamLabel;
}

/// <summary>
/// Function <code>GetSampleListGet</code> that represents the Service Studio function
///  <code>GetSampleListGet</code> <p> Description: </p>
/// </summary>

public static async Task<RC_49344a0c853da358d36b40a428b7e5a5> ssGetSampleListGet(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_49344a0c853da358d36b40a428b7e5a5.EnsureInitialized();
RC_49344a0c853da358d36b40a428b7e5a5 outParamRecord;
outParamRecord = await ExtendedActions.GetSampleListGet(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetHttpRequest</code> that represents the Service Studio function
///  <code>GetHttpRequest</code> <p> Description: </p>
/// </summary>

public static async Task<RC_1ba5183fe935decff47a51e639a147ac> ssGetHttpRequest(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1ba5183fe935decff47a51e639a147ac.EnsureInitialized();
RC_1ba5183fe935decff47a51e639a147ac outParamRecord;
outParamRecord = await ExtendedActions.GetHttpRequest(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSampleListEntity</code> that represents the Service Studio function
///  <code>GetSampleListEntity</code> <p> Description: </p>
/// </summary>

public static async Task<RC_f58af668359cdeaaa540e4e6dadabd34> ssGetSampleListEntity(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_f58af668359cdeaaa540e4e6dadabd34.EnsureInitialized();
RC_f58af668359cdeaaa540e4e6dadabd34 outParamRecord;
outParamRecord = await ExtendedActions.GetSampleListEntity(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetHttpMethod</code> that represents the Service Studio function
///  <code>GetHttpMethod</code> <p> Description: </p>
/// </summary>

public static async Task<RC_ee5350e5200eabac6362c9f03f6b7e3b> ssGetHttpMethod(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ee5350e5200eabac6362c9f03f6b7e3b.EnsureInitialized();
RC_ee5350e5200eabac6362c9f03f6b7e3b outParamRecord;
outParamRecord = await ExtendedActions.GetHttpMethod(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetEmployee</code> that represents the Service Studio function
///  <code>GetEmployee</code> <p> Description: </p>
/// </summary>

public static async Task<RC_3b55179c5be20c3d1041cf4a1dcf3f76> ssGetEmployee(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_3b55179c5be20c3d1041cf4a1dcf3f76.EnsureInitialized();
RC_3b55179c5be20c3d1041cf4a1dcf3f76 outParamRecord;
outParamRecord = await ExtendedActions.GetEmployee(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetWeekday</code> that represents the Service Studio function
///  <code>GetWeekday</code> <p> Description: </p>
/// </summary>

public static async Task<RC_37793b7d6834fb46c2d504f9d8c91d4a> ssGetWeekday(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_37793b7d6834fb46c2d504f9d8c91d4a.EnsureInitialized();
RC_37793b7d6834fb46c2d504f9d8c91d4a outParamRecord;
outParamRecord = await ExtendedActions.GetWeekday(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetEnum_color</code> that represents the Service Studio function
///  <code>GetEnum_color</code> <p> Description: </p>
/// </summary>

public static async Task<RC_8bd458d44b2829526bf34cf688a965a6> ssGetEnum_color(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_8bd458d44b2829526bf34cf688a965a6.EnsureInitialized();
RC_8bd458d44b2829526bf34cf688a965a6 outParamRecord;
outParamRecord = await ENEnum_colorEntity.GetEnum_color(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>CheckRuntimeDestroyerRole</code> that represents the Service Studio function
///  <code>CheckRuntimeDestroyerRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckRuntimeDestroyerRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckRuntimeDestroyerRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

}
