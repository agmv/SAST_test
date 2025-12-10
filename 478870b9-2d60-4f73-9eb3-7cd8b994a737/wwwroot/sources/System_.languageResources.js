import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
class MessagesProvider extends 
OS.LanguageResources.BaseMessagesProvider {
constructor(translationResources) {
super(translationResources);
this.setMessage("Validation.Mandatory", "Required field!");
this.setMessage("Validation.Integer", "Integer expected!");
this.setMessage("Validation.LongInteger", "Integer expected!");
this.setMessage("Validation.Decimal", "Decimal expected!");
this.setMessage("Validation.Currency", "Currency expected!");
this.setMessage("Validation.Date", "Date expected!");
this.setMessage("Validation.Time", "Time expected!");
this.setMessage("Validation.DateTime", "DateTime expected!");
this.setMessage("Validation.Text", "Text expected!");
this.setMessage("Validation.PhoneNumber", "Phone Number expected!");
this.setMessage("Validation.Email", "");
this.setMessage("UpgradeComplete", "Your application has been updated to the latest version.");
this.setMessage("AppInitError.Generic", "An error occurred while trying to update the app. If you want to retry the update, restart the app.");
this.setMessage("AppInitError.Resources", "An error occurred while trying to update the app. If you want to retry the update, restart the app.");
this.setMessage("AppInitError.DataModel", "An error occurred while trying to update the app. If you want to retry the update, restart the app. If the problem persists you can reinstall, but all local data will be lost.");
this.setMessage("UpgradeRequired", "Your application needs to be updated. Tap here to update.");
this.setMessage("UpgradeRequiredDataLoss", "Your application needs to be updated. Unsaved data will be lost. Tap here to update.");
}

}

export default new MessagesProvider();




