import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
export default {
applicationKey: "70e88f84-20c0-496b-bde5-9831530a09d3",
applicationName: "RuntimeDestroyerLib",
userProviderName: "Users",
debugEnabled: false,
debugUseWebSockets: true,
homeModuleName: "RuntimeDestroyerLib",
homeModuleKey: "70e88f84-20c0-496b-bde5-9831530a09d3",
homeModuleControllerName: "RuntimeDestroyerLib.controller",
homeModuleLanguageResourcesName: "RuntimeDestroyerLib.languageResources",
defaultScreenName: "",
defaultTransition: "SlideFromRight",
errorPageConfig: {
showExceptionStack: false
},
isWeb: true,
frontendBuildWorkerVersion: "v18.367.0",
buildSDKVersion: "v44.7.2.0",
clientRuntimeVersion: "6.49.3",
appVersion: "1",
homeModuleControllerImporter: async function () {
var {default: RuntimeDestroyerLibController} = await(import("./RuntimeDestroyerLib.controller.js"));
return RuntimeDestroyerLibController;

},
homeModuleLanguageResourcesImporter: async function () {
var {default: RuntimeDestroyerLibLanguageResources} = await(import("./RuntimeDestroyerLib.languageResources.js"));
return RuntimeDestroyerLibLanguageResources;

},
screensDefinition: []
};




