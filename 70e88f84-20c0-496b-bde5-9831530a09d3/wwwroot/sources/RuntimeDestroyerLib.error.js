import {runPreInitialization, Injector, useBaseApplication, Format, useAuthConfigsManager, useSettingsManager, settingsUpdatedHandler, useVersionsManager, runPostInitialization, Interfaces, ErrorScreen} from "@outsystems/runtime-core-js";
import {default as RuntimeDestroyerLibAppDefinition} from "./RuntimeDestroyerLib.appDefinition.js";
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
initType: Interfaces.Application.InitializationType.Minimal
}).then(function () {
function initView() {
ErrorScreen.renderErrorScreen(RuntimeDestroyerLibAppDefinition);
}
return initView();

});
}).catch(function (error) {
console.error(error);
});

