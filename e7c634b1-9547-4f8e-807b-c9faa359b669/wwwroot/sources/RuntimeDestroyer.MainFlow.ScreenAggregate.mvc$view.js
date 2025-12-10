import * as React from "react";
import * as OS from "@outsystems/runtime-core-js";
import * as OSView from "@outsystems/runtime-view-js";
import * as OSWidgets from "@outsystems/runtime-widgets-js";
import {default as ModelFactory} from "./RuntimeDestroyer.MainFlow.ScreenAggregate.mvc$model.js";
import {default as ControllerFactory} from "./RuntimeDestroyer.MainFlow.ScreenAggregate.mvc$controller.js";
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
return React.createElement("div", props.rootNodeProperties, React.createElement(OSWidgets.Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.bootstrapData$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Bootstrap"), React.createElement(OSWidgets.Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refresh$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Refresh", React.createElement("br")), React.createElement(OSWidgets.Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.deleteAll$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Delete All", React.createElement("br")), React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, React.createElement(OSWidgets.TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getEmployeesAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.getEmployeesAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new PlaceholderContent(function () {
return [React.createElement(OSWidgets.HeaderCell, {
sortAttribute: "Employee.Name",
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Name"), React.createElement(OSWidgets.HeaderCell, {
sortAttribute: "Employee.Age",
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Age")];
}),
row: new IteratorPlaceholderContent(function (idService, callContext) {
return [React.createElement(OSWidgets.RowCell, {
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getEmployeesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEmployeesAggr.listOut.getCurrent(callContext.iterationContext).employeeAttr.nameAttr)]
}, React.createElement(OSWidgets.Expression, {
value: model.variables.getEmployeesAggr.listOut.getCurrent(callContext.iterationContext).employeeAttr.nameAttr,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.getEmployeesAggr.dataFetchStatusAttr)
})), React.createElement(OSWidgets.RowCell, {
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getEmployeesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEmployeesAggr.listOut.getCurrent(callContext.iterationContext).employeeAttr.ageAttr)]
}, React.createElement(OSWidgets.Expression, {
value: model.variables.getEmployeesAggr.listOut.getCurrent(callContext.iterationContext).employeeAttr.ageAttr,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.getEmployeesAggr.dataFetchStatusAttr)
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getEmployeesAggr.dataFetchStatusAttr)]
}), React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "IsTableLoadingOrEmpty"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getEmployeesAggr.isDataFetchedAttr && model.variables.getEmployeesAggr.listOut.isEmpty), false, this, function () {
return [React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
style: "table-empty",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, "No items to show...")];
}, function () {
return [$if((!(model.variables.getEmployeesAggr.isDataFetchedAttr)), false, this, function () {
return [React.createElement(OSWidgets.Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
})];
}))), React.createElement(OSWidgets.Button, {
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
}, "Go to Weekday"), React.createElement(OSWidgets.Button, {
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
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Go to Check BuiltIns"), " ", " ");
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ScreenAggregate",
functionKey: "8d62b898-9c3d-466b-8ca3-7e1d6928e389",
functionOwnerName: "RuntimeDestroyer",
functionOwnerKey: "e7c634b1-9547-4f8e-807b-c9faa359b669",
screen: ""
};
},
displayName: "MainFlow.ScreenAggregate",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function () {
return "ScreenAggregate";
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
