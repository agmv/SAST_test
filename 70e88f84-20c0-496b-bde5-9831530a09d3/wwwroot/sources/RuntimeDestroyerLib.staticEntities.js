import * as OS from "@outsystems/runtime-core-js";
var RuntimeDestroyerLibModel = {
staticEntities: {}
};
RuntimeDestroyerLibModel.staticEntities.httpMethod = {};
Object.defineProperty(RuntimeDestroyerLibModel.staticEntities.httpMethod, "gET", {
get: function () {
return "GET";
}
});

Object.defineProperty(RuntimeDestroyerLibModel.staticEntities.httpMethod, "pOST", {
get: function () {
return "POST";
}
});

Object.defineProperty(RuntimeDestroyerLibModel.staticEntities.httpMethod, "dELETE", {
get: function () {
return "DELETE";
}
});

Object.defineProperty(RuntimeDestroyerLibModel.staticEntities.httpMethod, "pUT", {
get: function () {
return "PUT";
}
});




export var staticEntities = RuntimeDestroyerLibModel.staticEntities;


