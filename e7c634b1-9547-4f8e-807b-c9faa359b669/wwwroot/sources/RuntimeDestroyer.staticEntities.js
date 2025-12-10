import * as OS from "@outsystems/runtime-core-js";
var RuntimeDestroyerModel = {
staticEntities: {}
};
RuntimeDestroyerModel.staticEntities.sampleListGet = {};
Object.defineProperty(RuntimeDestroyerModel.staticEntities.sampleListGet, "record1", {
get: function () {
return 1000;
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.sampleListGet, "record2", {
get: function () {
return 2000;
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.sampleListGet, "record3", {
get: function () {
return 3000;
}
});



RuntimeDestroyerModel.staticEntities.httpMethod = {};
Object.defineProperty(RuntimeDestroyerModel.staticEntities.httpMethod, "pUT", {
get: function () {
return "PUT";
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.httpMethod, "pOST", {
get: function () {
return "POST";
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.httpMethod, "dELETE", {
get: function () {
return "DELETE";
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.httpMethod, "gET", {
get: function () {
return "GET";
}
});



RuntimeDestroyerModel.staticEntities.enum_color = {};
Object.defineProperty(RuntimeDestroyerModel.staticEntities.enum_color, "c1", {
get: function () {
return "c1";
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.enum_color, "c2", {
get: function () {
return "c2";
}
});



RuntimeDestroyerModel.staticEntities.aIContentType = {};
Object.defineProperty(RuntimeDestroyerModel.staticEntities.aIContentType, "textContent", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(1);
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.aIContentType, "imageURL", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(2);
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.aIContentType, "imageBinary", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(3);
}
});



RuntimeDestroyerModel.staticEntities.aIRole = {};
Object.defineProperty(RuntimeDestroyerModel.staticEntities.aIRole, "system", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(1);
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.aIRole, "user", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(2);
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.aIRole, "assistant", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(3);
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.aIRole, "action", {
get: function () {
return OS.BuiltinFunctions.integerToLongInteger(4);
}
});



RuntimeDestroyerModel.staticEntities.weekday = {};
Object.defineProperty(RuntimeDestroyerModel.staticEntities.weekday, "monday", {
get: function () {
return 1;
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.weekday, "tuesday", {
get: function () {
return 2;
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.weekday, "saturday", {
get: function () {
return 6;
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.weekday, "thursday", {
get: function () {
return 4;
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.weekday, "friday", {
get: function () {
return 5;
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.weekday, "wednesday", {
get: function () {
return 3;
}
});

Object.defineProperty(RuntimeDestroyerModel.staticEntities.weekday, "sunday", {
get: function () {
return 7;
}
});




export var staticEntities = RuntimeDestroyerModel.staticEntities;


