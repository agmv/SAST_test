import * as OS from "@outsystems/runtime-core-js";
var RuntimeDestroyerModel = {
staticEntities: {
sampleListGet: Object.freeze({
record1: 1000,
record2: 2000,
record3: 3000
}),
httpMethod: Object.freeze({
pUT: "PUT",
pOST: "POST",
dELETE: "DELETE",
gET: "GET"
}),
enum_color: Object.freeze({
c1: "c1",
c2: "c2"
}),
aIContentType: Object.freeze({
textContent: OS.BuiltinFunctions.integerToLongInteger(1),
imageURL: OS.BuiltinFunctions.integerToLongInteger(2),
imageBinary: OS.BuiltinFunctions.integerToLongInteger(3)
}),
aIRole: Object.freeze({
system: OS.BuiltinFunctions.integerToLongInteger(1),
user: OS.BuiltinFunctions.integerToLongInteger(2),
assistant: OS.BuiltinFunctions.integerToLongInteger(3),
action: OS.BuiltinFunctions.integerToLongInteger(4)
}),
weekday: Object.freeze({
monday: 1,
tuesday: 2,
saturday: 6,
thursday: 4,
friday: 5,
wednesday: 3,
sunday: 7
})
}
};
export var staticEntities = RuntimeDestroyerModel.staticEntities;


