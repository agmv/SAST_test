import * as OS from "@outsystems/runtime-core-js";
var System_Model = {
staticEntities: {}
};
System_Model.staticEntities.runtimeType = {};
Object.defineProperty(System_Model.staticEntities.runtimeType, "mobile", {
get: function () {
return "Mobile";
}
});

Object.defineProperty(System_Model.staticEntities.runtimeType, "mobileLibrary", {
get: function () {
return "MobileLibrary";
}
});

Object.defineProperty(System_Model.staticEntities.runtimeType, "service", {
get: function () {
return "Service";
}
});

Object.defineProperty(System_Model.staticEntities.runtimeType, "reactive", {
get: function () {
return "Reactive";
}
});

Object.defineProperty(System_Model.staticEntities.runtimeType, "unknown", {
get: function () {
return "Unknown";
}
});

Object.defineProperty(System_Model.staticEntities.runtimeType, "reactiveLibrary", {
get: function () {
return "ReactiveLibrary";
}
});



System_Model.staticEntities.processStatus = {};
Object.defineProperty(System_Model.staticEntities.processStatus, "active", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(1);
}
});

Object.defineProperty(System_Model.staticEntities.processStatus, "activeWithErrors", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(2);
}
});

Object.defineProperty(System_Model.staticEntities.processStatus, "terminated", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(4);
}
});

Object.defineProperty(System_Model.staticEntities.processStatus, "done", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(3);
}
});



System_Model.staticEntities.activityStatus = {};
Object.defineProperty(System_Model.staticEntities.activityStatus, "running", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(2);
}
});

Object.defineProperty(System_Model.staticEntities.activityStatus, "terminated", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(4);
}
});

Object.defineProperty(System_Model.staticEntities.activityStatus, "waiting", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(1);
}
});

Object.defineProperty(System_Model.staticEntities.activityStatus, "open", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(6);
}
});

Object.defineProperty(System_Model.staticEntities.activityStatus, "error", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(5);
}
});

Object.defineProperty(System_Model.staticEntities.activityStatus, "completed", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(3);
}
});



System_Model.staticEntities.activityKind = {};
Object.defineProperty(System_Model.staticEntities.activityKind, "terminate", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(8);
}
});

Object.defineProperty(System_Model.staticEntities.activityKind, "end", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(5);
}
});

Object.defineProperty(System_Model.staticEntities.activityKind, "conditionalStart", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(6);
}
});

Object.defineProperty(System_Model.staticEntities.activityKind, "wait", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(7);
}
});

Object.defineProperty(System_Model.staticEntities.activityKind, "decision", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(4);
}
});

Object.defineProperty(System_Model.staticEntities.activityKind, "humanActivity", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(3);
}
});

Object.defineProperty(System_Model.staticEntities.activityKind, "automaticActivity", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(2);
}
});

Object.defineProperty(System_Model.staticEntities.activityKind, "start", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(1);
}
});




export var staticEntities = System_Model.staticEntities;


