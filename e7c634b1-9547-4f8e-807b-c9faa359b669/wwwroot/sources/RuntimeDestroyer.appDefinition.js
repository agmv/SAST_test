import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
export default {
applicationKey: "e7c634b1-9547-4f8e-807b-c9faa359b669",
applicationName: "RuntimeDestroyer",
userProviderName: "Users",
debugEnabled: false,
debugUseWebSockets: true,
homeModuleName: "RuntimeDestroyer",
homeModuleKey: "e7c634b1-9547-4f8e-807b-c9faa359b669",
homeModuleControllerName: "RuntimeDestroyer.controller",
homeModuleLanguageResourcesName: "RuntimeDestroyer.languageResources",
defaultScreenName: "ScreenAggregate",
defaultTransition: "Fade",
errorPageConfig: {
showExceptionStack: false
},
isWeb: true,
frontendBuildWorkerVersion: "v18.381.0",
buildSDKVersion: "v44.7.2.0",
clientRuntimeVersion: "6.49.9",
appVersion: "13",
homeModuleControllerImporter: async function () {
var {default: RuntimeDestroyerController} = await(import("./RuntimeDestroyer.controller.js"));
return RuntimeDestroyerController;

},
homeModuleLanguageResourcesImporter: async function () {
var {default: RuntimeDestroyerLanguageResources} = await(import("./RuntimeDestroyer.languageResources.js"));
return RuntimeDestroyerLanguageResources;

},
screensDefinition: [{
screenKey: "21006e5f-feb2-4f9b-a790-dcdee8c9a830",
screenName: "MainFlow.BuiltIns",
viewModuleName: "RuntimeDestroyer.MainFlow.BuiltIns.mvc$view",
modelModuleName: "RuntimeDestroyer.MainFlow.BuiltIns.mvc$model",
controllerModuleName: "RuntimeDestroyer.MainFlow.BuiltIns.mvc$controller",
webFlowControllerModuleName: "RuntimeDestroyer.MainFlow.controller"
}, {
screenKey: "8d62b898-9c3d-466b-8ca3-7e1d6928e389",
screenName: "MainFlow.ScreenAggregate",
viewModuleName: "RuntimeDestroyer.MainFlow.ScreenAggregate.mvc$view",
modelModuleName: "RuntimeDestroyer.MainFlow.ScreenAggregate.mvc$model",
controllerModuleName: "RuntimeDestroyer.MainFlow.ScreenAggregate.mvc$controller",
webFlowControllerModuleName: "RuntimeDestroyer.MainFlow.controller"
}, {
screenKey: "d45c5d2d-a17d-447d-a6b2-bca30eab61b1",
screenName: "MainFlow.FetchData",
viewModuleName: "RuntimeDestroyer.MainFlow.FetchData.mvc$view",
modelModuleName: "RuntimeDestroyer.MainFlow.FetchData.mvc$model",
controllerModuleName: "RuntimeDestroyer.MainFlow.FetchData.mvc$controller",
webFlowControllerModuleName: "RuntimeDestroyer.MainFlow.controller"
}]
};




