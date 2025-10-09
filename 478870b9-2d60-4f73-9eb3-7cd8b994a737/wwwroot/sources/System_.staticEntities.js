import * as OS from "@outsystems/runtime-core-js";
var System_Model = {
staticEntities: {
runtimeType: Object.freeze({
mobile: "Mobile",
mobileLibrary: "MobileLibrary",
service: "Service",
reactive: "Reactive",
unknown: "Unknown",
reactiveLibrary: "ReactiveLibrary"
}),
processStatus: Object.freeze({
active: OS.BuiltinFunctions.integerToLongInteger(1),
activeWithErrors: OS.BuiltinFunctions.integerToLongInteger(2),
terminated: OS.BuiltinFunctions.integerToLongInteger(4),
done: OS.BuiltinFunctions.integerToLongInteger(3)
}),
activityStatus: Object.freeze({
running: OS.BuiltinFunctions.integerToLongInteger(2),
terminated: OS.BuiltinFunctions.integerToLongInteger(4),
waiting: OS.BuiltinFunctions.integerToLongInteger(1),
open: OS.BuiltinFunctions.integerToLongInteger(6),
error: OS.BuiltinFunctions.integerToLongInteger(5),
completed: OS.BuiltinFunctions.integerToLongInteger(3)
}),
activityKind: Object.freeze({
terminate: OS.BuiltinFunctions.integerToLongInteger(8),
end: OS.BuiltinFunctions.integerToLongInteger(5),
conditionalStart: OS.BuiltinFunctions.integerToLongInteger(6),
wait: OS.BuiltinFunctions.integerToLongInteger(7),
decision: OS.BuiltinFunctions.integerToLongInteger(4),
humanActivity: OS.BuiltinFunctions.integerToLongInteger(3),
automaticActivity: OS.BuiltinFunctions.integerToLongInteger(2),
start: OS.BuiltinFunctions.integerToLongInteger(1)
})
}
};
export var staticEntities = System_Model.staticEntities;


