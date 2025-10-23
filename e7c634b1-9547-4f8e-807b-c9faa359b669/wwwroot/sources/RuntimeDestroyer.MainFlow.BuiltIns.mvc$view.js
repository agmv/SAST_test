import * as React from "react";
import * as OS from "@outsystems/runtime-core-js";
import * as OSView from "@outsystems/runtime-view-js";
import * as OSWidgets from "@outsystems/runtime-widgets-js";
import {default as ModelFactory} from "./RuntimeDestroyer.MainFlow.BuiltIns.mvc$model.js";
import {default as ControllerFactory} from "./RuntimeDestroyer.MainFlow.BuiltIns.mvc$controller.js";
import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as RuntimeDestroyerModel from "./RuntimeDestroyer.model.js";
import * as RuntimeDestroyerController from "./RuntimeDestroyer.controller.js";

var PlaceholderContent = OSView.Widget.PlaceholderContent;
var IteratorPlaceholderContent = OSView.Widget.IteratorPlaceholderContent;


var componentFactory = function () {
var ELEM = OSView.withBaseWebScreen(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var asPrimitiveValue = OSView.asPrimitiveValue;
var getTranslation = OSView.getTranslation;
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var $if = OSView.ifWidget;
var $text = OSView.textWidget;
var spanProvider = OSView.useTracing();
return React.createElement("div", props.rootNodeProperties, React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Check Math Builtins"), React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Check Abs: ", React.createElement(OSWidgets.Expression, {
value: model.getCachedValue(idService.getId("xVJMxwWN80WDvppSYK5+LQ.Value"), function () {
return (OS.BuiltinFunctions.abs(((new OS.DataTypes.Decimal("10.89")).neg())).equals((new OS.DataTypes.Decimal("10.89"))) ? "True" : "False");
}),
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
})), React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Check Mod: ", React.createElement(OSWidgets.Expression, {
value: model.getCachedValue(idService.getId("99SMeIV2yUSbPwEqNGk2eg.Value"), function () {
return (OS.BuiltinFunctions.mod(OS.BuiltinFunctions.integerToDecimal(4), (new OS.DataTypes.Decimal("3.5"))).equals((new OS.DataTypes.Decimal("0.5"))) ? "True" : "False");
}),
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
})), React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Check Power: ", React.createElement(OSWidgets.Expression, {
value: model.getCachedValue(idService.getId("jHMkW5dq4EaaRmGB3lrFXA.Value"), function () {
return (OS.BuiltinFunctions.power(OS.BuiltinFunctions.integerToDecimal(100), OS.BuiltinFunctions.integerToDecimal(2)).equals(OS.BuiltinFunctions.integerToDecimal(10000)) ? "True" : "False");
}),
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})), React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Check Round: ", React.createElement(OSWidgets.Expression, {
value: model.getCachedValue(idService.getId("GuQq_vHMBkiE4L2R4XgFLQ.Value"), function () {
return (OS.BuiltinFunctions.round(((new OS.DataTypes.Decimal("10.89")).neg()), 0).equals(OS.BuiltinFunctions.integerToDecimal((-11))) ? "True" : "False");
}),
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
})), React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Check Sqrt: ", React.createElement(OSWidgets.Expression, {
value: model.getCachedValue(idService.getId("GgRbkY_5EECtpmBDLYeiAw.Value"), function () {
return (OS.BuiltinFunctions.sqrt(OS.BuiltinFunctions.integerToDecimal(9)).equals(OS.BuiltinFunctions.integerToDecimal(3)) ? "True" : "False");
}),
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
})), React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Check Trunc: ", React.createElement(OSWidgets.Expression, {
value: model.getCachedValue(idService.getId("Oy_M2w_qKUS3GYQYT5+s8w.Value"), function () {
return (OS.BuiltinFunctions.trunc(((new OS.DataTypes.Decimal("10.89")).neg())).equals(OS.BuiltinFunctions.integerToDecimal((-10))) ? "True" : "False");
}),
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
})), React.createElement(OSWidgets.Button, {
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
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Go to ScreenAggregate"), React.createElement(OSWidgets.Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS.Navigation.navigateTo(OS.Navigation.generateScreenURL("RuntimeDestroyer", "FetchData", {}), OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default), null, true);
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
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Go to Fetch Data"));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "BuiltIns",
functionKey: "21006e5f-feb2-4f9b-a790-dcdee8c9a830",
functionOwnerName: "RuntimeDestroyer",
functionOwnerKey: "e7c634b1-9547-4f8e-807b-c9faa359b669",
screen: ""
};
},
displayName: "MainFlow.BuiltIns",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function () {
return "BuiltIns";
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
