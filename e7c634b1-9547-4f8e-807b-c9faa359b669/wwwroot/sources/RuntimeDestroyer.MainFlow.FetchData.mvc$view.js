import * as React from "react";
import * as OS from "@outsystems/runtime-core-js";
import * as OSView from "@outsystems/runtime-view-js";
import * as OSWidgets from "@outsystems/runtime-widgets-js";
import {default as ModelFactory} from "./RuntimeDestroyer.MainFlow.FetchData.mvc$model.js";
import {default as ControllerFactory} from "./RuntimeDestroyer.MainFlow.FetchData.mvc$controller.js";
import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as RuntimeDestroyerModel from "./RuntimeDestroyer.model.js";
import * as RuntimeDestroyerController from "./RuntimeDestroyer.controller.js";

var PlaceholderContent = OSView.Widget.PlaceholderContent;
var IteratorPlaceholderContent = OSView.Widget.IteratorPlaceholderContent;


var componentFactory = function () {
var ELEM = OSView.fc.withBaseWebScreen(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var asPrimitiveValue = OSView.fc.asPrimitiveValue;
var getTranslation = OSView.fc.getTranslation;
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var $if = OSView.fc.ifWidget;
var $text = OSView.fc.textWidget;
var spanProvider = OSView.fc.useTracing();
return React.createElement("div", props.rootNodeProperties, React.createElement(OSWidgets.Expression, {
value: model.variables.getWeekdayDataAct.out1Out,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.getWeekdayDataAct.dataFetchStatusAttr)
}), React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, React.createElement(OSWidgets.Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS.Navigation.navigateTo(OS.Navigation.generateScreenURL("RuntimeDestroyer", "ScreenAggregate", {}), OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default), null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Go to Screen Aggregate")), React.createElement(OSWidgets.Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS.Navigation.navigateTo(OS.Navigation.generateScreenURL("RuntimeDestroyer", "BuiltIns", {}), OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default), null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Go to Check BuiltIns"));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "FetchData",
functionKey: "d45c5d2d-a17d-447d-a6b2-bca30eab61b1",
functionOwnerName: "RuntimeDestroyer",
functionOwnerKey: "e7c634b1-9547-4f8e-807b-c9faa359b669",
screen: ""
};
},
displayName: "MainFlow.FetchData",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function () {
return "FetchData";
}
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
