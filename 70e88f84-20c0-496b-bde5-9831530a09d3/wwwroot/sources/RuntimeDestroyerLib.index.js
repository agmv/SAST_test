import "./NullDebugger.js";
import {runPreInitialization, Injector, useBaseApplication, Format, useAuthConfigsManager, useSettingsManager, settingsUpdatedHandler, useVersionsManager, runPostInitialization, Interfaces, ErrorHandling, Application, Flow} from "@outsystems/runtime-core-js";
import {default as RuntimeDestroyerLibAppDefinition} from "./RuntimeDestroyerLib.appDefinition.js";
import {routerV6} from "@outsystems/runtime-view-js";
import {ROUTER_INFO, SPLASH_SCREEN_ROUTE} from "./router_info.js";
runPreInitialization(Injector, {
applicationDefinition: RuntimeDestroyerLibAppDefinition
}).then(function () {
return Promise.all([useBaseApplication(Injector, {
dateTimeFormat: new Format.DateTimeFormatInfo("yyyy-MM-dd", "HH:mm:ss"),
numberFormat: new Format.NumberFormatInfo(".", "")
}), useAuthConfigsManager(Injector), useSettingsManager(Injector, {
onSettingsUpdated: settingsUpdatedHandler
}), useVersionsManager()]);
}).then(function () {
return runPostInitialization({
initType: Interfaces.Application.InitializationType.Full
}).then(function (success) {
if(success) {
function initGlobalExceptionHandler() {
return new Promise(function (resolve) {
Application.default.registerDefaultErrorHandler(function () {
return function (error, callContext) {
return ErrorHandling.defaultErrorHandler(error, callContext);
};
});
resolve();
});
}
function initView() {
return new Promise(function (resolve, reject) {
try {routerV6.load(Application.default, undefined, {
staticScreenRoutes: ROUTER_INFO,
staticSplashRoute: SPLASH_SCREEN_ROUTE
});
resolve();
} catch (error) {
reject(error);
}

});
;
}
return initGlobalExceptionHandler().then(initView);

}

});
}).catch(function (error) {
ErrorHandling.handleError(error);
});

