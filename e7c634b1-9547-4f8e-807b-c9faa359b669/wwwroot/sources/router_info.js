import {ApplicationInfo} from "@outsystems/runtime-core-js";

function buildURL(url) {
var basePath = ApplicationInfo.getBasePath();
basePath = basePath.replace(/\/$/, "");
if(url) {
return ((basePath + "/") + url);
} else {
return basePath;
}

};
export const ROUTER_INFO = [{
get pathname() {return buildURL();
},
screenName: "MainFlow.ScreenAggregate",
forDefaultPath: true,
lazyComponentInfo: {
isStatic: true,
shallSaveStateOnLeave: true,
importer: function () {
return import("./RuntimeDestroyer.MainFlow.ScreenAggregate.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("BuiltIns");
},
screenName: "MainFlow.BuiltIns",
forDefaultPath: false,
lazyComponentInfo: {
isStatic: true,
shallSaveStateOnLeave: true,
importer: function () {
return import("./RuntimeDestroyer.MainFlow.BuiltIns.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ScreenAggregate");
},
screenName: "MainFlow.ScreenAggregate",
forDefaultPath: false,
lazyComponentInfo: {
isStatic: true,
shallSaveStateOnLeave: true,
importer: function () {
return import("./RuntimeDestroyer.MainFlow.ScreenAggregate.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("FetchData");
},
screenName: "MainFlow.FetchData",
forDefaultPath: false,
lazyComponentInfo: {
isStatic: true,
shallSaveStateOnLeave: true,
importer: function () {
return import("./RuntimeDestroyer.MainFlow.FetchData.mvc$screen.js");
}
}
}];
export const SPLASH_SCREEN_ROUTE = null;
