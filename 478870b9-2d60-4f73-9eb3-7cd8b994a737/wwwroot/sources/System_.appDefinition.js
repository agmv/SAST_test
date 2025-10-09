import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
export default {
applicationKey: "478870b9-2d60-4f73-9eb3-7cd8b994a737",
applicationName: "(System)",
userProviderName: "System_",
debugEnabled: false,
debugUseWebSockets: true,
homeModuleName: "System_",
homeModuleKey: "478870b9-2d60-4f73-9eb3-7cd8b994a737",
homeModuleControllerName: "System_.controller",
homeModuleLanguageResourcesName: "System_.languageResources",
defaultScreenName: "",
defaultTransition: "None",
errorPageConfig: {
showExceptionStack: false
},
isWeb: true,
frontendBuildWorkerVersion: "v18.367.0",
buildSDKVersion: "v44.7.2.0",
clientRuntimeVersion: "6.49.3",
appVersion: "1",
homeModuleControllerImporter: async function () {
var {default: System_Controller} = await(import("./System_.controller.js"));
return System_Controller;

},
homeModuleLanguageResourcesImporter: async function () {
var {default: System_LanguageResources} = await(import("./System_.languageResources.js"));
return System_LanguageResources;

},
screensDefinition: []
};




