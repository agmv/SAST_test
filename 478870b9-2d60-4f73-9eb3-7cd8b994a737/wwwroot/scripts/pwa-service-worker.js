(function (global, factory) {
    typeof exports === 'object' && typeof module !== 'undefined' ? factory(exports) :
    typeof define === 'function' && define.amd ? define(['exports'], factory) :
    (global = typeof globalThis !== 'undefined' ? globalThis : global || self, factory(global["@outsystems/pwa-service-worker-js"] = {}));
})(this, (function (exports) { 'use strict';

    /******************************************************************************
    Copyright (c) Microsoft Corporation.

    Permission to use, copy, modify, and/or distribute this software for any
    purpose with or without fee is hereby granted.

    THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
    REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY
    AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
    INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM
    LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR
    OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR
    PERFORMANCE OF THIS SOFTWARE.
    ***************************************************************************** */
    /* global Reflect, Promise, SuppressedError, Symbol, Iterator */


    function __awaiter(thisArg, _arguments, P, generator) {
        function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
        return new (P || (P = Promise))(function (resolve, reject) {
            function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
            function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
            function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
            step((generator = generator.apply(thisArg, _arguments || [])).next());
        });
    }

    function __classPrivateFieldGet(receiver, state, kind, f) {
        if (kind === "a" && !f) throw new TypeError("Private accessor was defined without a getter");
        if (typeof state === "function" ? receiver !== state || !f : !state.has(receiver)) throw new TypeError("Cannot read private member from an object whose class did not declare it");
        return kind === "m" ? f : kind === "a" ? f.call(receiver) : f ? f.value : state.get(receiver);
    }

    function __classPrivateFieldSet(receiver, state, value, kind, f) {
        if (kind === "m") throw new TypeError("Private method is not writable");
        if (kind === "a" && !f) throw new TypeError("Private accessor was defined without a setter");
        if (typeof state === "function" ? receiver !== state || !f : !state.has(receiver)) throw new TypeError("Cannot write private member to an object whose class did not declare it");
        return (kind === "a" ? f.call(receiver, value) : f ? f.value = value : state.set(receiver, value)), value;
    }

    typeof SuppressedError === "function" ? SuppressedError : function (error, suppressed, message) {
        var e = new Error(message);
        return e.name = "SuppressedError", e.error = error, e.suppressed = suppressed, e;
    };

    var _Logger_instances, _Logger_swScope, _Logger_console, _Logger_log, _Logger_getClient;
    class Logger {
        constructor({ workerScope, console = globalThis.console, }) {
            _Logger_instances.add(this);
            _Logger_swScope.set(this, void 0);
            _Logger_console.set(this, void 0);
            __classPrivateFieldSet(this, _Logger_swScope, workerScope, "f");
            __classPrivateFieldSet(this, _Logger_console, console, "f");
        }
        debug(message) {
            return __classPrivateFieldGet(this, _Logger_instances, "m", _Logger_log).call(this, message, "debug");
        }
        error(message, error) {
            return __classPrivateFieldGet(this, _Logger_instances, "m", _Logger_log).call(this, `${message}: ${error}`, "error");
        }
    }
    _Logger_swScope = new WeakMap(), _Logger_console = new WeakMap(), _Logger_instances = new WeakSet(), _Logger_log = function _Logger_log(message, severity) {
        return __awaiter(this, void 0, void 0, function* () {
            const client = yield __classPrivateFieldGet(this, _Logger_instances, "m", _Logger_getClient).call(this);
            if (client) {
                client.postMessage({
                    kind: "log",
                    severity,
                    message,
                });
            }
            else {
                __classPrivateFieldGet(this, _Logger_console, "f")[severity](message);
            }
        });
    }, _Logger_getClient = function _Logger_getClient() {
        return __awaiter(this, void 0, void 0, function* () {
            try {
                const allClients = yield __classPrivateFieldGet(this, _Logger_swScope, "f").clients.matchAll({ type: "window" });
                const visible = allClients.filter((client) => client.visibilityState === "visible");
                if (visible.length === 1) {
                    return visible[0];
                }
            }
            catch (e) {
                __classPrivateFieldGet(this, _Logger_console, "f").error(`Error getting client: ${e}`);
            }
            return undefined;
        });
    };

    const TIMESTAMP_QUERYPARAM = "_ts";
    const installHandler = (_a) => __awaiter(void 0, [_a], void 0, function* ({ workerScope, cacheStorage, appName, cacheName, appUrls, logger = new Logger({ workerScope }), }) {
        const cache = yield cacheStorage.open(cacheName);
        logger.debug(`[install] ${cacheName}/${appName} adding all core components to cache`);
        yield cache.addAll(appUrls);
        return workerScope.skipWaiting();
    });
    const fetchHandler = (_a) => __awaiter(void 0, [_a], void 0, function* ({ request, cacheStorage, cacheName, urlMappings, uncacheableUrls, logger, }) {
        const cache = yield cacheStorage.open(cacheName);
        const requestURL = new URL(request.url);
        const requestPath = requestURL.pathname;
        const req = requestPath in urlMappings ? urlMappings[requestPath] : request;
        const forceFetch = requestURL.searchParams.has(TIMESTAMP_QUERYPARAM);
        if (forceFetch || uncacheableUrls.includes(requestPath)) {
            console.debug(`[fetch] Skipping cache behavior for ${requestPath}`);
            return yield fetch(request);
        }
        else {
            try {
                const match = yield cache.match(req);
                if (match) {
                    logger === null || logger === void 0 ? void 0 : logger.debug(`[fetch] Returning from ${cacheName} cache: ${requestPath}`);
                    return match;
                }
                logger === null || logger === void 0 ? void 0 : logger.debug(`[fetch] Returning from server: ${requestPath}`);
                return yield fetch(request);
            }
            catch (e) {
                logger === null || logger === void 0 ? void 0 : logger.error(`[fetch] Error trying to use cache. ${e}`);
                throw e;
            }
        }
    });
    const activateHandler = (_a) => __awaiter(void 0, [_a], void 0, function* ({ workerScope, cacheStorage, appName, versionToken, cacheName, logger = new Logger({ workerScope }), }) {
        try {
            const keys = yield cacheStorage.keys();
            const toDelete = keys
                .filter((key) => key.startsWith(appName) && key !== cacheName)
                .map((key) => {
                logger.debug(`[activate] deleting old cache key: ${key}`);
                return cacheStorage.delete(key);
            });
            yield Promise.all(toDelete);
            logger.debug(`[activate] ${appName} activated with version token: ${versionToken}`);
            yield workerScope.clients.claim();
        }
        catch (e) {
            console.error(`[activate] Error in ${appName} activation. ${e === null || e === void 0 ? void 0 : e.toString()}`);
        }
    });

    const uncacheableUrls = ["/v1/logs", "/v2/logs"];
    const mapUncacheableUrlsList = (moduleName) => {
        return uncacheableUrls.map((current) => `/${moduleName}${current}`);
    };

    var _PWAServiceWorker_workerScope, _PWAServiceWorker_cacheStorage, _PWAServiceWorker_appName, _PWAServiceWorker_cacheName, _PWAServiceWorker_versionToken, _PWAServiceWorker_appUrls, _PWAServiceWorker_appUrlMappings, _PWAServiceWorker_logger;
    class PWAServiceWorker {
        constructor({ workerScope, cacheStorage, appName, versionToken, appUrls, appUrlMappings, }) {
            _PWAServiceWorker_workerScope.set(this, void 0);
            _PWAServiceWorker_cacheStorage.set(this, void 0);
            _PWAServiceWorker_appName.set(this, void 0);
            _PWAServiceWorker_cacheName.set(this, void 0);
            _PWAServiceWorker_versionToken.set(this, void 0);
            _PWAServiceWorker_appUrls.set(this, void 0);
            _PWAServiceWorker_appUrlMappings.set(this, void 0);
            _PWAServiceWorker_logger.set(this, void 0);
            __classPrivateFieldSet(this, _PWAServiceWorker_workerScope, workerScope, "f");
            __classPrivateFieldSet(this, _PWAServiceWorker_cacheStorage, cacheStorage, "f");
            __classPrivateFieldSet(this, _PWAServiceWorker_appName, appName, "f");
            __classPrivateFieldSet(this, _PWAServiceWorker_versionToken, versionToken, "f");
            __classPrivateFieldSet(this, _PWAServiceWorker_cacheName, `${appName}-${versionToken}`, "f");
            __classPrivateFieldSet(this, _PWAServiceWorker_appUrls, appUrls, "f");
            __classPrivateFieldSet(this, _PWAServiceWorker_appUrlMappings, appUrlMappings, "f");
            __classPrivateFieldSet(this, _PWAServiceWorker_logger, new Logger({ workerScope }), "f");
        }
        install(event_1) {
            return __awaiter(this, arguments, void 0, function* (event, handleInstall = installHandler) {
                try {
                    event.waitUntil(handleInstall({
                        workerScope: __classPrivateFieldGet(this, _PWAServiceWorker_workerScope, "f"),
                        cacheStorage: __classPrivateFieldGet(this, _PWAServiceWorker_cacheStorage, "f"),
                        appName: __classPrivateFieldGet(this, _PWAServiceWorker_appName, "f"),
                        cacheName: __classPrivateFieldGet(this, _PWAServiceWorker_cacheName, "f"),
                        appUrls: __classPrivateFieldGet(this, _PWAServiceWorker_appUrls, "f"),
                        logger: __classPrivateFieldGet(this, _PWAServiceWorker_logger, "f"),
                    }));
                }
                catch (e) {
                    __classPrivateFieldGet(this, _PWAServiceWorker_logger, "f").error("Error installing service worker", e);
                }
            });
        }
        fetch(event_1) {
            return __awaiter(this, arguments, void 0, function* (event, handleFetch = fetchHandler) {
                try {
                    event.respondWith(handleFetch({
                        request: event.request,
                        cacheStorage: __classPrivateFieldGet(this, _PWAServiceWorker_cacheStorage, "f"),
                        cacheName: __classPrivateFieldGet(this, _PWAServiceWorker_cacheName, "f"),
                        urlMappings: __classPrivateFieldGet(this, _PWAServiceWorker_appUrlMappings, "f"),
                        uncacheableUrls: mapUncacheableUrlsList(__classPrivateFieldGet(this, _PWAServiceWorker_appName, "f")),
                        logger: __classPrivateFieldGet(this, _PWAServiceWorker_logger, "f"),
                    }));
                }
                catch (e) {
                    console.error(e);
                }
            });
        }
        activate(event_1) {
            return __awaiter(this, arguments, void 0, function* (event, handleActivate = activateHandler) {
                try {
                    event.waitUntil(handleActivate({
                        workerScope: __classPrivateFieldGet(this, _PWAServiceWorker_workerScope, "f"),
                        cacheStorage: __classPrivateFieldGet(this, _PWAServiceWorker_cacheStorage, "f"),
                        appName: __classPrivateFieldGet(this, _PWAServiceWorker_appName, "f"),
                        versionToken: __classPrivateFieldGet(this, _PWAServiceWorker_versionToken, "f"),
                        cacheName: __classPrivateFieldGet(this, _PWAServiceWorker_cacheName, "f"),
                        logger: __classPrivateFieldGet(this, _PWAServiceWorker_logger, "f"),
                    }));
                }
                catch (e) {
                    __classPrivateFieldGet(this, _PWAServiceWorker_logger, "f").error("Error activating service worker", e);
                }
            });
        }
    }
    _PWAServiceWorker_workerScope = new WeakMap(), _PWAServiceWorker_cacheStorage = new WeakMap(), _PWAServiceWorker_appName = new WeakMap(), _PWAServiceWorker_cacheName = new WeakMap(), _PWAServiceWorker_versionToken = new WeakMap(), _PWAServiceWorker_appUrls = new WeakMap(), _PWAServiceWorker_appUrlMappings = new WeakMap(), _PWAServiceWorker_logger = new WeakMap();

    const startServiceWorker = ({ workerScope, cacheStorage, appName, versionToken, appUrls, appUrlMappings, }) => {
        const worker = new PWAServiceWorker({
            workerScope,
            cacheStorage,
            appName,
            versionToken,
            appUrls,
            appUrlMappings,
        });
        workerScope.addEventListener("install", (event) => {
            worker.install(event);
        });
        workerScope.addEventListener("fetch", (event) => {
            worker.fetch(event);
        });
        workerScope.addEventListener("activate", (event) => {
            worker.activate(event);
        });
    };

    var commonjsGlobal = typeof globalThis !== 'undefined' ? globalThis : typeof window !== 'undefined' ? window : typeof global !== 'undefined' ? global : typeof self !== 'undefined' ? self : {};

    function commonjsRequire(path) {
    	throw new Error('Could not dynamically require "' + path + '". Please configure the dynamicRequireTargets or/and ignoreDynamicRequires option of @rollup/plugin-commonjs appropriately for this require call to work.');
    }

    var dist$2 = {};

    (function (exports) {
    	(function (global, factory) {
    	  {
    	    factory(exports);
    	  }
    	})(typeof globalThis !== "undefined" ? globalThis : typeof self !== "undefined" ? self : commonjsGlobal, function (_exports) {

    	  Object.defineProperty(_exports, "__esModule", {
    	    value: true
    	  });
    	  _exports.Version = _exports.PathFilter = _exports.NativeHttpClient = _exports.LoggerHttpClient = _exports.HttpClientWithHealthCheck = _exports.HttpClient = _exports.FetchHttpClient = _exports.ErrorCodes = _exports.DebuggerHttpClient = _exports.ContentType = _exports.CommunicationError = _exports.AbortRequest = void 0;
    	  _exports.isNetworkOrServerError = isNetworkOrServerError;
    	  /******************************************************************************
    	  Copyright (c) Microsoft Corporation.
    	  
    	  Permission to use, copy, modify, and/or distribute this software for any
    	  purpose with or without fee is hereby granted.
    	  
    	  THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
    	  REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY
    	  AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
    	  INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM
    	  LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR
    	  OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR
    	  PERFORMANCE OF THIS SOFTWARE.
    	  ***************************************************************************** */
    	  /* global Reflect, Promise, SuppressedError, Symbol, Iterator */

    	  function __awaiter(thisArg, _arguments, P, generator) {
    	    function adopt(value) {
    	      return value instanceof P ? value : new P(function (resolve) {
    	        resolve(value);
    	      });
    	    }
    	    return new (P || (P = Promise))(function (resolve, reject) {
    	      function fulfilled(value) {
    	        try {
    	          step(generator.next(value));
    	        } catch (e) {
    	          reject(e);
    	        }
    	      }
    	      function rejected(value) {
    	        try {
    	          step(generator["throw"](value));
    	        } catch (e) {
    	          reject(e);
    	        }
    	      }
    	      function step(result) {
    	        result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected);
    	      }
    	      step((generator = generator.apply(thisArg, _arguments || [])).next());
    	    });
    	  }
    	  function __classPrivateFieldGet(receiver, state, kind, f) {
    	    if (kind === "a" && !f) throw new TypeError("Private accessor was defined without a getter");
    	    if (typeof state === "function" ? receiver !== state || !f : !state.has(receiver)) throw new TypeError("Cannot read private member from an object whose class did not declare it");
    	    return kind === "m" ? f : kind === "a" ? f.call(receiver) : f ? f.value : state.get(receiver);
    	  }
    	  function __classPrivateFieldSet(receiver, state, value, kind, f) {
    	    if (typeof state === "function" ? receiver !== state || true : !state.has(receiver)) throw new TypeError("Cannot write private member to an object whose class did not declare it");
    	    return state.set(receiver, value), value;
    	  }
    	  typeof SuppressedError === "function" ? SuppressedError : function (error, suppressed, message) {
    	    var e = new Error(message);
    	    return e.name = "SuppressedError", e.error = error, e.suppressed = suppressed, e;
    	  };
    	  class CommunicationError extends Error {
    	    constructor(message, errorCode, status, response, category) {
    	      super(message);
    	      this.errorCode = errorCode;
    	      this.status = status ? `${status}` : "";
    	      this.response = response;
    	      this.category = category;
    	    }
    	  }
    	  _exports.CommunicationError = CommunicationError;
    	  var ErrorCodes;
    	  (function (ErrorCodes) {
    	    ErrorCodes["Communication_Default"] = "OS-CLRT-60900";
    	    ErrorCodes["Communication_Bad_Request"] = "OS-CLRT-60901";
    	    ErrorCodes["Communication_Unauthorized"] = "OS-CLRT-60902";
    	    ErrorCodes["Communication_Forbidden"] = "OS-CLRT-60903";
    	    ErrorCodes["Communication_Not_Found"] = "OS-CLRT-60904";
    	    ErrorCodes["Communication_Timeout"] = "OS-CLRT-60905";
    	    ErrorCodes["Communication_Internal_Server_Error"] = "OS-CLRT-60906";
    	    ErrorCodes["Communication_Unavailable"] = "OS-CLRT-60907";
    	    ErrorCodes["Communication_Aborted"] = "OS-CLRT-60908";
    	  })(ErrorCodes || (_exports.ErrorCodes = ErrorCodes = {}));
    	  const errorCodeMap = {
    	    ["400"]: ErrorCodes.Communication_Bad_Request,
    	    ["401"]: ErrorCodes.Communication_Unauthorized,
    	    ["403"]: ErrorCodes.Communication_Forbidden,
    	    ["404"]: ErrorCodes.Communication_Not_Found,
    	    ["408"]: ErrorCodes.Communication_Timeout,
    	    ["500"]: ErrorCodes.Communication_Internal_Server_Error,
    	    ["503"]: ErrorCodes.Communication_Unavailable
    	  };
    	  const mapErrorCodeFromStatusCode = statusCode => {
    	    var _a;
    	    return (_a = errorCodeMap[`${statusCode}`]) !== null && _a !== void 0 ? _a : ErrorCodes.Communication_Default;
    	  };
    	  const HEADER_NAME_TRACE = "traceparent";
    	  const HEADER_NAME_TRACE_STATE = "tracestate";
    	  const HEADER_NAME_TRACE_BAGGAGE = "baggage";
    	  const HEADER_LENGTH_TRACE_STATE = 512;
    	  const ATTRIBUTES_TO_SHARE = ["code.function", "outsystems.function.key", "outsystems.function.type", "outsystems.runtime.screen", "outsystems.otel.access.visibility"];
    	  function addTraceHeaders() {
    	    return __awaiter(this, arguments, void 0, function () {
    	      let base = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : {};
    	      let loadTrace = arguments.length > 1 ? arguments[1] : undefined;
    	      return function* () {
    	        if (!loadTrace) {
    	          return base;
    	        }
    	        const trace = yield loadTrace();
    	        if (!trace) {
    	          return base;
    	        }
    	        return insertTraceHeader(trace, base);
    	      }();
    	    });
    	  }
    	  function insertTraceHeader(info, base) {
    	    const headers = Object.assign(Object.assign({}, base), {
    	      [HEADER_NAME_TRACE]: buildTraceHeader(info)
    	    });
    	    if (info.attributes) {
    	      const value = buildTraceState(info.attributes);
    	      const headerName = value.length > HEADER_LENGTH_TRACE_STATE ? HEADER_NAME_TRACE_BAGGAGE : HEADER_NAME_TRACE_STATE;
    	      headers[headerName] = value;
    	    }
    	    return headers;
    	  }
    	  function buildTraceHeader(info) {
    	    return `00-${info.traceId}-${info.spanId}-${info.sampled ? "01" : "00"}`;
    	  }
    	  function buildTraceState(info) {
    	    return ATTRIBUTES_TO_SHARE.map(key => info[key] ? `${key}=${info[key]}` : undefined).filter(value => value !== undefined).join(",");
    	  }
    	  var ContentType;
    	  (function (ContentType) {
    	    ContentType["FormUrlEncoded"] = "application/x-www-form-urlencoded";
    	    ContentType["Json"] = "application/json";
    	  })(ContentType || (ContentType = {}));
    	  var ContentType$1 = _exports.ContentType = ContentType;
    	  var RequestError;
    	  (function (RequestError) {
    	    RequestError[RequestError["Unknown"] = 0] = "Unknown";
    	    RequestError[RequestError["Timeout"] = 1] = "Timeout";
    	    RequestError[RequestError["Unauthorized"] = 2] = "Unauthorized";
    	    RequestError[RequestError["Aborted"] = 3] = "Aborted";
    	  })(RequestError || (RequestError = {}));
    	  var RequestError$1 = RequestError;
    	  var commonjsGlobal$1 = typeof globalThis !== 'undefined' ? globalThis : typeof window !== 'undefined' ? window : typeof commonjsGlobal !== 'undefined' ? commonjsGlobal : typeof self !== 'undefined' ? self : {};
    	  function getDefaultExportFromCjs(x) {
    	    return x && x.__esModule && Object.prototype.hasOwnProperty.call(x, 'default') ? x['default'] : x;
    	  }
    	  function getAugmentedNamespace(n) {
    	    if (n.__esModule) return n;
    	    var f = n.default;
    	    if (typeof f == "function") {
    	      var a = function a() {
    	        if (this instanceof a) {
    	          return Reflect.construct(f, arguments, this.constructor);
    	        }
    	        return f.apply(this, arguments);
    	      };
    	      a.prototype = f.prototype;
    	    } else a = {};
    	    Object.defineProperty(a, '__esModule', {
    	      value: true
    	    });
    	    Object.keys(n).forEach(function (k) {
    	      var d = Object.getOwnPropertyDescriptor(n, k);
    	      Object.defineProperty(a, k, d.get ? d : {
    	        enumerable: true,
    	        get: function () {
    	          return n[k];
    	        }
    	      });
    	    });
    	    return a;
    	  }

    	  /** @type {import('./type')} */
    	  var type = TypeError;
    	  var _nodeResolve_empty = {};
    	  var _nodeResolve_empty$1 = /*#__PURE__*/Object.freeze({
    	    __proto__: null,
    	    default: _nodeResolve_empty
    	  });
    	  var require$$0 = /*@__PURE__*/getAugmentedNamespace(_nodeResolve_empty$1);
    	  var hasMap = typeof Map === 'function' && Map.prototype;
    	  var mapSizeDescriptor = Object.getOwnPropertyDescriptor && hasMap ? Object.getOwnPropertyDescriptor(Map.prototype, 'size') : null;
    	  var mapSize = hasMap && mapSizeDescriptor && typeof mapSizeDescriptor.get === 'function' ? mapSizeDescriptor.get : null;
    	  var mapForEach = hasMap && Map.prototype.forEach;
    	  var hasSet = typeof Set === 'function' && Set.prototype;
    	  var setSizeDescriptor = Object.getOwnPropertyDescriptor && hasSet ? Object.getOwnPropertyDescriptor(Set.prototype, 'size') : null;
    	  var setSize = hasSet && setSizeDescriptor && typeof setSizeDescriptor.get === 'function' ? setSizeDescriptor.get : null;
    	  var setForEach = hasSet && Set.prototype.forEach;
    	  var hasWeakMap = typeof WeakMap === 'function' && WeakMap.prototype;
    	  var weakMapHas = hasWeakMap ? WeakMap.prototype.has : null;
    	  var hasWeakSet = typeof WeakSet === 'function' && WeakSet.prototype;
    	  var weakSetHas = hasWeakSet ? WeakSet.prototype.has : null;
    	  var hasWeakRef = typeof WeakRef === 'function' && WeakRef.prototype;
    	  var weakRefDeref = hasWeakRef ? WeakRef.prototype.deref : null;
    	  var booleanValueOf = Boolean.prototype.valueOf;
    	  var objectToString = Object.prototype.toString;
    	  var functionToString = Function.prototype.toString;
    	  var $match = String.prototype.match;
    	  var $slice = String.prototype.slice;
    	  var $replace$1 = String.prototype.replace;
    	  var $toUpperCase = String.prototype.toUpperCase;
    	  var $toLowerCase = String.prototype.toLowerCase;
    	  var $test = RegExp.prototype.test;
    	  var $concat$1 = Array.prototype.concat;
    	  var $join = Array.prototype.join;
    	  var $arrSlice = Array.prototype.slice;
    	  var $floor = Math.floor;
    	  var bigIntValueOf = typeof BigInt === 'function' ? BigInt.prototype.valueOf : null;
    	  var gOPS = Object.getOwnPropertySymbols;
    	  var symToString = typeof Symbol === 'function' && typeof Symbol.iterator === 'symbol' ? Symbol.prototype.toString : null;
    	  var hasShammedSymbols = typeof Symbol === 'function' && typeof Symbol.iterator === 'object';
    	  // ie, `has-tostringtag/shams
    	  var toStringTag = typeof Symbol === 'function' && Symbol.toStringTag && (typeof Symbol.toStringTag === hasShammedSymbols ? 'object' : 'symbol') ? Symbol.toStringTag : null;
    	  var isEnumerable = Object.prototype.propertyIsEnumerable;
    	  var gPO = (typeof Reflect === 'function' ? Reflect.getPrototypeOf : Object.getPrototypeOf) || ([].__proto__ === Array.prototype // eslint-disable-line no-proto
    	  ? function (O) {
    	    return O.__proto__; // eslint-disable-line no-proto
    	  } : null);
    	  function addNumericSeparator(num, str) {
    	    if (num === Infinity || num === -Infinity || num !== num || num && num > -1e3 && num < 1000 || $test.call(/e/, str)) {
    	      return str;
    	    }
    	    var sepRegex = /[0-9](?=(?:[0-9]{3})+(?![0-9]))/g;
    	    if (typeof num === 'number') {
    	      var int = num < 0 ? -$floor(-num) : $floor(num); // trunc(num)
    	      if (int !== num) {
    	        var intStr = String(int);
    	        var dec = $slice.call(str, intStr.length + 1);
    	        return $replace$1.call(intStr, sepRegex, '$&_') + '.' + $replace$1.call($replace$1.call(dec, /([0-9]{3})/g, '$&_'), /_$/, '');
    	      }
    	    }
    	    return $replace$1.call(str, sepRegex, '$&_');
    	  }
    	  var utilInspect = require$$0;
    	  var inspectCustom = utilInspect.custom;
    	  var inspectSymbol = isSymbol(inspectCustom) ? inspectCustom : null;
    	  var quotes = {
    	    __proto__: null,
    	    'double': '"',
    	    single: "'"
    	  };
    	  var quoteREs = {
    	    __proto__: null,
    	    'double': /(["\\])/g,
    	    single: /(['\\])/g
    	  };
    	  var objectInspect = function inspect_(obj, options, depth, seen) {
    	    var opts = options || {};
    	    if (has$3(opts, 'quoteStyle') && !has$3(quotes, opts.quoteStyle)) {
    	      throw new TypeError('option "quoteStyle" must be "single" or "double"');
    	    }
    	    if (has$3(opts, 'maxStringLength') && (typeof opts.maxStringLength === 'number' ? opts.maxStringLength < 0 && opts.maxStringLength !== Infinity : opts.maxStringLength !== null)) {
    	      throw new TypeError('option "maxStringLength", if provided, must be a positive integer, Infinity, or `null`');
    	    }
    	    var customInspect = has$3(opts, 'customInspect') ? opts.customInspect : true;
    	    if (typeof customInspect !== 'boolean' && customInspect !== 'symbol') {
    	      throw new TypeError('option "customInspect", if provided, must be `true`, `false`, or `\'symbol\'`');
    	    }
    	    if (has$3(opts, 'indent') && opts.indent !== null && opts.indent !== '\t' && !(parseInt(opts.indent, 10) === opts.indent && opts.indent > 0)) {
    	      throw new TypeError('option "indent" must be "\\t", an integer > 0, or `null`');
    	    }
    	    if (has$3(opts, 'numericSeparator') && typeof opts.numericSeparator !== 'boolean') {
    	      throw new TypeError('option "numericSeparator", if provided, must be `true` or `false`');
    	    }
    	    var numericSeparator = opts.numericSeparator;
    	    if (typeof obj === 'undefined') {
    	      return 'undefined';
    	    }
    	    if (obj === null) {
    	      return 'null';
    	    }
    	    if (typeof obj === 'boolean') {
    	      return obj ? 'true' : 'false';
    	    }
    	    if (typeof obj === 'string') {
    	      return inspectString(obj, opts);
    	    }
    	    if (typeof obj === 'number') {
    	      if (obj === 0) {
    	        return Infinity / obj > 0 ? '0' : '-0';
    	      }
    	      var str = String(obj);
    	      return numericSeparator ? addNumericSeparator(obj, str) : str;
    	    }
    	    if (typeof obj === 'bigint') {
    	      var bigIntStr = String(obj) + 'n';
    	      return numericSeparator ? addNumericSeparator(obj, bigIntStr) : bigIntStr;
    	    }
    	    var maxDepth = typeof opts.depth === 'undefined' ? 5 : opts.depth;
    	    if (typeof depth === 'undefined') {
    	      depth = 0;
    	    }
    	    if (depth >= maxDepth && maxDepth > 0 && typeof obj === 'object') {
    	      return isArray$3(obj) ? '[Array]' : '[Object]';
    	    }
    	    var indent = getIndent(opts, depth);
    	    if (typeof seen === 'undefined') {
    	      seen = [];
    	    } else if (indexOf(seen, obj) >= 0) {
    	      return '[Circular]';
    	    }
    	    function inspect(value, from, noIndent) {
    	      if (from) {
    	        seen = $arrSlice.call(seen);
    	        seen.push(from);
    	      }
    	      if (noIndent) {
    	        var newOpts = {
    	          depth: opts.depth
    	        };
    	        if (has$3(opts, 'quoteStyle')) {
    	          newOpts.quoteStyle = opts.quoteStyle;
    	        }
    	        return inspect_(value, newOpts, depth + 1, seen);
    	      }
    	      return inspect_(value, opts, depth + 1, seen);
    	    }
    	    if (typeof obj === 'function' && !isRegExp$1(obj)) {
    	      // in older engines, regexes are callable
    	      var name = nameOf(obj);
    	      var keys = arrObjKeys(obj, inspect);
    	      return '[Function' + (name ? ': ' + name : ' (anonymous)') + ']' + (keys.length > 0 ? ' { ' + $join.call(keys, ', ') + ' }' : '');
    	    }
    	    if (isSymbol(obj)) {
    	      var symString = hasShammedSymbols ? $replace$1.call(String(obj), /^(Symbol\(.*\))_[^)]*$/, '$1') : symToString.call(obj);
    	      return typeof obj === 'object' && !hasShammedSymbols ? markBoxed(symString) : symString;
    	    }
    	    if (isElement(obj)) {
    	      var s = '<' + $toLowerCase.call(String(obj.nodeName));
    	      var attrs = obj.attributes || [];
    	      for (var i = 0; i < attrs.length; i++) {
    	        s += ' ' + attrs[i].name + '=' + wrapQuotes(quote(attrs[i].value), 'double', opts);
    	      }
    	      s += '>';
    	      if (obj.childNodes && obj.childNodes.length) {
    	        s += '...';
    	      }
    	      s += '</' + $toLowerCase.call(String(obj.nodeName)) + '>';
    	      return s;
    	    }
    	    if (isArray$3(obj)) {
    	      if (obj.length === 0) {
    	        return '[]';
    	      }
    	      var xs = arrObjKeys(obj, inspect);
    	      if (indent && !singleLineValues(xs)) {
    	        return '[' + indentedJoin(xs, indent) + ']';
    	      }
    	      return '[ ' + $join.call(xs, ', ') + ' ]';
    	    }
    	    if (isError(obj)) {
    	      var parts = arrObjKeys(obj, inspect);
    	      if (!('cause' in Error.prototype) && 'cause' in obj && !isEnumerable.call(obj, 'cause')) {
    	        return '{ [' + String(obj) + '] ' + $join.call($concat$1.call('[cause]: ' + inspect(obj.cause), parts), ', ') + ' }';
    	      }
    	      if (parts.length === 0) {
    	        return '[' + String(obj) + ']';
    	      }
    	      return '{ [' + String(obj) + '] ' + $join.call(parts, ', ') + ' }';
    	    }
    	    if (typeof obj === 'object' && customInspect) {
    	      if (inspectSymbol && typeof obj[inspectSymbol] === 'function' && utilInspect) {
    	        return utilInspect(obj, {
    	          depth: maxDepth - depth
    	        });
    	      } else if (customInspect !== 'symbol' && typeof obj.inspect === 'function') {
    	        return obj.inspect();
    	      }
    	    }
    	    if (isMap(obj)) {
    	      var mapParts = [];
    	      if (mapForEach) {
    	        mapForEach.call(obj, function (value, key) {
    	          mapParts.push(inspect(key, obj, true) + ' => ' + inspect(value, obj));
    	        });
    	      }
    	      return collectionOf('Map', mapSize.call(obj), mapParts, indent);
    	    }
    	    if (isSet(obj)) {
    	      var setParts = [];
    	      if (setForEach) {
    	        setForEach.call(obj, function (value) {
    	          setParts.push(inspect(value, obj));
    	        });
    	      }
    	      return collectionOf('Set', setSize.call(obj), setParts, indent);
    	    }
    	    if (isWeakMap(obj)) {
    	      return weakCollectionOf('WeakMap');
    	    }
    	    if (isWeakSet(obj)) {
    	      return weakCollectionOf('WeakSet');
    	    }
    	    if (isWeakRef(obj)) {
    	      return weakCollectionOf('WeakRef');
    	    }
    	    if (isNumber(obj)) {
    	      return markBoxed(inspect(Number(obj)));
    	    }
    	    if (isBigInt(obj)) {
    	      return markBoxed(inspect(bigIntValueOf.call(obj)));
    	    }
    	    if (isBoolean(obj)) {
    	      return markBoxed(booleanValueOf.call(obj));
    	    }
    	    if (isString(obj)) {
    	      return markBoxed(inspect(String(obj)));
    	    }
    	    // note: in IE 8, sometimes `global !== window` but both are the prototypes of each other
    	    /* eslint-env browser */
    	    if (typeof window !== 'undefined' && obj === window) {
    	      return '{ [object Window] }';
    	    }
    	    if (typeof globalThis !== 'undefined' && obj === globalThis || typeof commonjsGlobal$1 !== 'undefined' && obj === commonjsGlobal$1) {
    	      return '{ [object globalThis] }';
    	    }
    	    if (!isDate(obj) && !isRegExp$1(obj)) {
    	      var ys = arrObjKeys(obj, inspect);
    	      var isPlainObject = gPO ? gPO(obj) === Object.prototype : obj instanceof Object || obj.constructor === Object;
    	      var protoTag = obj instanceof Object ? '' : 'null prototype';
    	      var stringTag = !isPlainObject && toStringTag && Object(obj) === obj && toStringTag in obj ? $slice.call(toStr(obj), 8, -1) : protoTag ? 'Object' : '';
    	      var constructorTag = isPlainObject || typeof obj.constructor !== 'function' ? '' : obj.constructor.name ? obj.constructor.name + ' ' : '';
    	      var tag = constructorTag + (stringTag || protoTag ? '[' + $join.call($concat$1.call([], stringTag || [], protoTag || []), ': ') + '] ' : '');
    	      if (ys.length === 0) {
    	        return tag + '{}';
    	      }
    	      if (indent) {
    	        return tag + '{' + indentedJoin(ys, indent) + '}';
    	      }
    	      return tag + '{ ' + $join.call(ys, ', ') + ' }';
    	    }
    	    return String(obj);
    	  };
    	  function wrapQuotes(s, defaultStyle, opts) {
    	    var style = opts.quoteStyle || defaultStyle;
    	    var quoteChar = quotes[style];
    	    return quoteChar + s + quoteChar;
    	  }
    	  function quote(s) {
    	    return $replace$1.call(String(s), /"/g, '&quot;');
    	  }
    	  function canTrustToString(obj) {
    	    return !toStringTag || !(typeof obj === 'object' && (toStringTag in obj || typeof obj[toStringTag] !== 'undefined'));
    	  }
    	  function isArray$3(obj) {
    	    return toStr(obj) === '[object Array]' && canTrustToString(obj);
    	  }
    	  function isDate(obj) {
    	    return toStr(obj) === '[object Date]' && canTrustToString(obj);
    	  }
    	  function isRegExp$1(obj) {
    	    return toStr(obj) === '[object RegExp]' && canTrustToString(obj);
    	  }
    	  function isError(obj) {
    	    return toStr(obj) === '[object Error]' && canTrustToString(obj);
    	  }
    	  function isString(obj) {
    	    return toStr(obj) === '[object String]' && canTrustToString(obj);
    	  }
    	  function isNumber(obj) {
    	    return toStr(obj) === '[object Number]' && canTrustToString(obj);
    	  }
    	  function isBoolean(obj) {
    	    return toStr(obj) === '[object Boolean]' && canTrustToString(obj);
    	  }

    	  // Symbol and BigInt do have Symbol.toStringTag by spec, so that can't be used to eliminate false positives
    	  function isSymbol(obj) {
    	    if (hasShammedSymbols) {
    	      return obj && typeof obj === 'object' && obj instanceof Symbol;
    	    }
    	    if (typeof obj === 'symbol') {
    	      return true;
    	    }
    	    if (!obj || typeof obj !== 'object' || !symToString) {
    	      return false;
    	    }
    	    try {
    	      symToString.call(obj);
    	      return true;
    	    } catch (e) {}
    	    return false;
    	  }
    	  function isBigInt(obj) {
    	    if (!obj || typeof obj !== 'object' || !bigIntValueOf) {
    	      return false;
    	    }
    	    try {
    	      bigIntValueOf.call(obj);
    	      return true;
    	    } catch (e) {}
    	    return false;
    	  }
    	  var hasOwn$1 = Object.prototype.hasOwnProperty || function (key) {
    	    return key in this;
    	  };
    	  function has$3(obj, key) {
    	    return hasOwn$1.call(obj, key);
    	  }
    	  function toStr(obj) {
    	    return objectToString.call(obj);
    	  }
    	  function nameOf(f) {
    	    if (f.name) {
    	      return f.name;
    	    }
    	    var m = $match.call(functionToString.call(f), /^function\s*([\w$]+)/);
    	    if (m) {
    	      return m[1];
    	    }
    	    return null;
    	  }
    	  function indexOf(xs, x) {
    	    if (xs.indexOf) {
    	      return xs.indexOf(x);
    	    }
    	    for (var i = 0, l = xs.length; i < l; i++) {
    	      if (xs[i] === x) {
    	        return i;
    	      }
    	    }
    	    return -1;
    	  }
    	  function isMap(x) {
    	    if (!mapSize || !x || typeof x !== 'object') {
    	      return false;
    	    }
    	    try {
    	      mapSize.call(x);
    	      try {
    	        setSize.call(x);
    	      } catch (s) {
    	        return true;
    	      }
    	      return x instanceof Map; // core-js workaround, pre-v2.5.0
    	    } catch (e) {}
    	    return false;
    	  }
    	  function isWeakMap(x) {
    	    if (!weakMapHas || !x || typeof x !== 'object') {
    	      return false;
    	    }
    	    try {
    	      weakMapHas.call(x, weakMapHas);
    	      try {
    	        weakSetHas.call(x, weakSetHas);
    	      } catch (s) {
    	        return true;
    	      }
    	      return x instanceof WeakMap; // core-js workaround, pre-v2.5.0
    	    } catch (e) {}
    	    return false;
    	  }
    	  function isWeakRef(x) {
    	    if (!weakRefDeref || !x || typeof x !== 'object') {
    	      return false;
    	    }
    	    try {
    	      weakRefDeref.call(x);
    	      return true;
    	    } catch (e) {}
    	    return false;
    	  }
    	  function isSet(x) {
    	    if (!setSize || !x || typeof x !== 'object') {
    	      return false;
    	    }
    	    try {
    	      setSize.call(x);
    	      try {
    	        mapSize.call(x);
    	      } catch (m) {
    	        return true;
    	      }
    	      return x instanceof Set; // core-js workaround, pre-v2.5.0
    	    } catch (e) {}
    	    return false;
    	  }
    	  function isWeakSet(x) {
    	    if (!weakSetHas || !x || typeof x !== 'object') {
    	      return false;
    	    }
    	    try {
    	      weakSetHas.call(x, weakSetHas);
    	      try {
    	        weakMapHas.call(x, weakMapHas);
    	      } catch (s) {
    	        return true;
    	      }
    	      return x instanceof WeakSet; // core-js workaround, pre-v2.5.0
    	    } catch (e) {}
    	    return false;
    	  }
    	  function isElement(x) {
    	    if (!x || typeof x !== 'object') {
    	      return false;
    	    }
    	    if (typeof HTMLElement !== 'undefined' && x instanceof HTMLElement) {
    	      return true;
    	    }
    	    return typeof x.nodeName === 'string' && typeof x.getAttribute === 'function';
    	  }
    	  function inspectString(str, opts) {
    	    if (str.length > opts.maxStringLength) {
    	      var remaining = str.length - opts.maxStringLength;
    	      var trailer = '... ' + remaining + ' more character' + (remaining > 1 ? 's' : '');
    	      return inspectString($slice.call(str, 0, opts.maxStringLength), opts) + trailer;
    	    }
    	    var quoteRE = quoteREs[opts.quoteStyle || 'single'];
    	    quoteRE.lastIndex = 0;
    	    // eslint-disable-next-line no-control-regex
    	    var s = $replace$1.call($replace$1.call(str, quoteRE, '\\$1'), /[\x00-\x1f]/g, lowbyte);
    	    return wrapQuotes(s, 'single', opts);
    	  }
    	  function lowbyte(c) {
    	    var n = c.charCodeAt(0);
    	    var x = {
    	      8: 'b',
    	      9: 't',
    	      10: 'n',
    	      12: 'f',
    	      13: 'r'
    	    }[n];
    	    if (x) {
    	      return '\\' + x;
    	    }
    	    return '\\x' + (n < 0x10 ? '0' : '') + $toUpperCase.call(n.toString(16));
    	  }
    	  function markBoxed(str) {
    	    return 'Object(' + str + ')';
    	  }
    	  function weakCollectionOf(type) {
    	    return type + ' { ? }';
    	  }
    	  function collectionOf(type, size, entries, indent) {
    	    var joinedEntries = indent ? indentedJoin(entries, indent) : $join.call(entries, ', ');
    	    return type + ' (' + size + ') {' + joinedEntries + '}';
    	  }
    	  function singleLineValues(xs) {
    	    for (var i = 0; i < xs.length; i++) {
    	      if (indexOf(xs[i], '\n') >= 0) {
    	        return false;
    	      }
    	    }
    	    return true;
    	  }
    	  function getIndent(opts, depth) {
    	    var baseIndent;
    	    if (opts.indent === '\t') {
    	      baseIndent = '\t';
    	    } else if (typeof opts.indent === 'number' && opts.indent > 0) {
    	      baseIndent = $join.call(Array(opts.indent + 1), ' ');
    	    } else {
    	      return null;
    	    }
    	    return {
    	      base: baseIndent,
    	      prev: $join.call(Array(depth + 1), baseIndent)
    	    };
    	  }
    	  function indentedJoin(xs, indent) {
    	    if (xs.length === 0) {
    	      return '';
    	    }
    	    var lineJoiner = '\n' + indent.prev + indent.base;
    	    return lineJoiner + $join.call(xs, ',' + lineJoiner) + '\n' + indent.prev;
    	  }
    	  function arrObjKeys(obj, inspect) {
    	    var isArr = isArray$3(obj);
    	    var xs = [];
    	    if (isArr) {
    	      xs.length = obj.length;
    	      for (var i = 0; i < obj.length; i++) {
    	        xs[i] = has$3(obj, i) ? inspect(obj[i], obj) : '';
    	      }
    	    }
    	    var syms = typeof gOPS === 'function' ? gOPS(obj) : [];
    	    var symMap;
    	    if (hasShammedSymbols) {
    	      symMap = {};
    	      for (var k = 0; k < syms.length; k++) {
    	        symMap['$' + syms[k]] = syms[k];
    	      }
    	    }
    	    for (var key in obj) {
    	      // eslint-disable-line no-restricted-syntax
    	      if (!has$3(obj, key)) {
    	        continue;
    	      } // eslint-disable-line no-restricted-syntax, no-continue
    	      if (isArr && String(Number(key)) === key && key < obj.length) {
    	        continue;
    	      } // eslint-disable-line no-restricted-syntax, no-continue
    	      if (hasShammedSymbols && symMap['$' + key] instanceof Symbol) {
    	        // this is to prevent shammed Symbols, which are stored as strings, from being included in the string key section
    	        continue; // eslint-disable-line no-restricted-syntax, no-continue
    	      } else if ($test.call(/[^\w$]/, key)) {
    	        xs.push(inspect(key, obj) + ': ' + inspect(obj[key], obj));
    	      } else {
    	        xs.push(key + ': ' + inspect(obj[key], obj));
    	      }
    	    }
    	    if (typeof gOPS === 'function') {
    	      for (var j = 0; j < syms.length; j++) {
    	        if (isEnumerable.call(obj, syms[j])) {
    	          xs.push('[' + inspect(syms[j]) + ']: ' + inspect(obj[syms[j]], obj));
    	        }
    	      }
    	    }
    	    return xs;
    	  }
    	  var inspect$3 = objectInspect;
    	  var $TypeError$5 = type;

    	  /*
    	  * This function traverses the list returning the node corresponding to the given key.
    	  *
    	  * That node is also moved to the head of the list, so that if it's accessed again we don't need to traverse the whole list.
    	  * By doing so, all the recently used nodes can be accessed relatively quickly.
    	  */
    	  /** @type {import('./list.d.ts').listGetNode} */
    	  // eslint-disable-next-line consistent-return
    	  var listGetNode = function (list, key, isDelete) {
    	    /** @type {typeof list | NonNullable<(typeof list)['next']>} */
    	    var prev = list;
    	    /** @type {(typeof list)['next']} */
    	    var curr;
    	    // eslint-disable-next-line eqeqeq
    	    for (; (curr = prev.next) != null; prev = curr) {
    	      if (curr.key === key) {
    	        prev.next = curr.next;
    	        if (!isDelete) {
    	          // eslint-disable-next-line no-extra-parens
    	          curr.next = /** @type {NonNullable<typeof list.next>} */list.next;
    	          list.next = curr; // eslint-disable-line no-param-reassign
    	        }
    	        return curr;
    	      }
    	    }
    	  };

    	  /** @type {import('./list.d.ts').listGet} */
    	  var listGet = function (objects, key) {
    	    if (!objects) {
    	      return void undefined;
    	    }
    	    var node = listGetNode(objects, key);
    	    return node && node.value;
    	  };
    	  /** @type {import('./list.d.ts').listSet} */
    	  var listSet = function (objects, key, value) {
    	    var node = listGetNode(objects, key);
    	    if (node) {
    	      node.value = value;
    	    } else {
    	      // Prepend the new node to the beginning of the list
    	      objects.next = /** @type {import('./list.d.ts').ListNode<typeof value, typeof key>} */{
    	        // eslint-disable-line no-param-reassign, no-extra-parens
    	        key: key,
    	        next: objects.next,
    	        value: value
    	      };
    	    }
    	  };
    	  /** @type {import('./list.d.ts').listHas} */
    	  var listHas = function (objects, key) {
    	    if (!objects) {
    	      return false;
    	    }
    	    return !!listGetNode(objects, key);
    	  };
    	  /** @type {import('./list.d.ts').listDelete} */
    	  // eslint-disable-next-line consistent-return
    	  var listDelete = function (objects, key) {
    	    if (objects) {
    	      return listGetNode(objects, key, true);
    	    }
    	  };

    	  /** @type {import('.')} */
    	  var sideChannelList = function getSideChannelList() {
    	    /** @typedef {ReturnType<typeof getSideChannelList>} Channel */
    	    /** @typedef {Parameters<Channel['get']>[0]} K */
    	    /** @typedef {Parameters<Channel['set']>[1]} V */

    	    /** @type {import('./list.d.ts').RootNode<V, K> | undefined} */var $o;

    	    /** @type {Channel} */
    	    var channel = {
    	      assert: function (key) {
    	        if (!channel.has(key)) {
    	          throw new $TypeError$5('Side channel does not contain ' + inspect$3(key));
    	        }
    	      },
    	      'delete': function (key) {
    	        var root = $o && $o.next;
    	        var deletedNode = listDelete($o, key);
    	        if (deletedNode && root && root === deletedNode) {
    	          $o = void undefined;
    	        }
    	        return !!deletedNode;
    	      },
    	      get: function (key) {
    	        return listGet($o, key);
    	      },
    	      has: function (key) {
    	        return listHas($o, key);
    	      },
    	      set: function (key, value) {
    	        if (!$o) {
    	          // Initialize the linked list as an empty node, so that we don't have to special-case handling of the first node: we can always refer to it as (previous node).next, instead of something like (list).head
    	          $o = {
    	            next: void undefined
    	          };
    	        }
    	        // eslint-disable-next-line no-extra-parens
    	        listSet(/** @type {NonNullable<typeof $o>} */$o, key, value);
    	      }
    	    };
    	    // @ts-expect-error TODO: figure out why this is erroring
    	    return channel;
    	  };

    	  /** @type {import('.')} */
    	  var esObjectAtoms = Object;

    	  /** @type {import('.')} */
    	  var esErrors = Error;

    	  /** @type {import('./eval')} */
    	  var _eval = EvalError;

    	  /** @type {import('./range')} */
    	  var range = RangeError;

    	  /** @type {import('./ref')} */
    	  var ref = ReferenceError;

    	  /** @type {import('./syntax')} */
    	  var syntax = SyntaxError;

    	  /** @type {import('./uri')} */
    	  var uri = URIError;

    	  /** @type {import('./abs')} */
    	  var abs$1 = Math.abs;

    	  /** @type {import('./floor')} */
    	  var floor$1 = Math.floor;

    	  /** @type {import('./max')} */
    	  var max$1 = Math.max;

    	  /** @type {import('./min')} */
    	  var min$1 = Math.min;

    	  /** @type {import('./pow')} */
    	  var pow$1 = Math.pow;

    	  /** @type {import('./round')} */
    	  var round$1 = Math.round;

    	  /** @type {import('./isNaN')} */
    	  var _isNaN = Number.isNaN || function isNaN(a) {
    	    return a !== a;
    	  };
    	  var $isNaN = _isNaN;

    	  /** @type {import('./sign')} */
    	  var sign$1 = function sign(number) {
    	    if ($isNaN(number) || number === 0) {
    	      return number;
    	    }
    	    return number < 0 ? -1 : 1;
    	  };

    	  /** @type {import('./gOPD')} */
    	  var gOPD = Object.getOwnPropertyDescriptor;

    	  /** @type {import('.')} */
    	  var $gOPD$1 = gOPD;
    	  if ($gOPD$1) {
    	    try {
    	      $gOPD$1([], 'length');
    	    } catch (e) {
    	      // IE 8 has a broken gOPD
    	      $gOPD$1 = null;
    	    }
    	  }
    	  var gopd = $gOPD$1;

    	  /** @type {import('.')} */
    	  var $defineProperty$1 = Object.defineProperty || false;
    	  if ($defineProperty$1) {
    	    try {
    	      $defineProperty$1({}, 'a', {
    	        value: 1
    	      });
    	    } catch (e) {
    	      // IE 8 has a broken defineProperty
    	      $defineProperty$1 = false;
    	    }
    	  }
    	  var esDefineProperty = $defineProperty$1;
    	  var shams;
    	  var hasRequiredShams;
    	  function requireShams() {
    	    if (hasRequiredShams) return shams;
    	    hasRequiredShams = 1;

    	    /** @type {import('./shams')} */
    	    /* eslint complexity: [2, 18], max-statements: [2, 33] */
    	    shams = function hasSymbols() {
    	      if (typeof Symbol !== 'function' || typeof Object.getOwnPropertySymbols !== 'function') {
    	        return false;
    	      }
    	      if (typeof Symbol.iterator === 'symbol') {
    	        return true;
    	      }

    	      /** @type {{ [k in symbol]?: unknown }} */
    	      var obj = {};
    	      var sym = Symbol('test');
    	      var symObj = Object(sym);
    	      if (typeof sym === 'string') {
    	        return false;
    	      }
    	      if (Object.prototype.toString.call(sym) !== '[object Symbol]') {
    	        return false;
    	      }
    	      if (Object.prototype.toString.call(symObj) !== '[object Symbol]') {
    	        return false;
    	      }

    	      // temp disabled per https://github.com/ljharb/object.assign/issues/17
    	      // if (sym instanceof Symbol) { return false; }
    	      // temp disabled per https://github.com/WebReflection/get-own-property-symbols/issues/4
    	      // if (!(symObj instanceof Symbol)) { return false; }

    	      // if (typeof Symbol.prototype.toString !== 'function') { return false; }
    	      // if (String(sym) !== Symbol.prototype.toString.call(sym)) { return false; }

    	      var symVal = 42;
    	      obj[sym] = symVal;
    	      for (var _ in obj) {
    	        return false;
    	      } // eslint-disable-line no-restricted-syntax, no-unreachable-loop
    	      if (typeof Object.keys === 'function' && Object.keys(obj).length !== 0) {
    	        return false;
    	      }
    	      if (typeof Object.getOwnPropertyNames === 'function' && Object.getOwnPropertyNames(obj).length !== 0) {
    	        return false;
    	      }
    	      var syms = Object.getOwnPropertySymbols(obj);
    	      if (syms.length !== 1 || syms[0] !== sym) {
    	        return false;
    	      }
    	      if (!Object.prototype.propertyIsEnumerable.call(obj, sym)) {
    	        return false;
    	      }
    	      if (typeof Object.getOwnPropertyDescriptor === 'function') {
    	        // eslint-disable-next-line no-extra-parens
    	        var descriptor = /** @type {PropertyDescriptor} */Object.getOwnPropertyDescriptor(obj, sym);
    	        if (descriptor.value !== symVal || descriptor.enumerable !== true) {
    	          return false;
    	        }
    	      }
    	      return true;
    	    };
    	    return shams;
    	  }
    	  var hasSymbols$1;
    	  var hasRequiredHasSymbols;
    	  function requireHasSymbols() {
    	    if (hasRequiredHasSymbols) return hasSymbols$1;
    	    hasRequiredHasSymbols = 1;
    	    var origSymbol = typeof Symbol !== 'undefined' && Symbol;
    	    var hasSymbolSham = requireShams();

    	    /** @type {import('.')} */
    	    hasSymbols$1 = function hasNativeSymbols() {
    	      if (typeof origSymbol !== 'function') {
    	        return false;
    	      }
    	      if (typeof Symbol !== 'function') {
    	        return false;
    	      }
    	      if (typeof origSymbol('foo') !== 'symbol') {
    	        return false;
    	      }
    	      if (typeof Symbol('bar') !== 'symbol') {
    	        return false;
    	      }
    	      return hasSymbolSham();
    	    };
    	    return hasSymbols$1;
    	  }
    	  var Reflect_getPrototypeOf;
    	  var hasRequiredReflect_getPrototypeOf;
    	  function requireReflect_getPrototypeOf() {
    	    if (hasRequiredReflect_getPrototypeOf) return Reflect_getPrototypeOf;
    	    hasRequiredReflect_getPrototypeOf = 1;

    	    /** @type {import('./Reflect.getPrototypeOf')} */
    	    Reflect_getPrototypeOf = typeof Reflect !== 'undefined' && Reflect.getPrototypeOf || null;
    	    return Reflect_getPrototypeOf;
    	  }
    	  var Object_getPrototypeOf;
    	  var hasRequiredObject_getPrototypeOf;
    	  function requireObject_getPrototypeOf() {
    	    if (hasRequiredObject_getPrototypeOf) return Object_getPrototypeOf;
    	    hasRequiredObject_getPrototypeOf = 1;
    	    var $Object = esObjectAtoms;

    	    /** @type {import('./Object.getPrototypeOf')} */
    	    Object_getPrototypeOf = $Object.getPrototypeOf || null;
    	    return Object_getPrototypeOf;
    	  }
    	  var implementation;
    	  var hasRequiredImplementation;
    	  function requireImplementation() {
    	    if (hasRequiredImplementation) return implementation;
    	    hasRequiredImplementation = 1;

    	    /* eslint no-invalid-this: 1 */

    	    var ERROR_MESSAGE = 'Function.prototype.bind called on incompatible ';
    	    var toStr = Object.prototype.toString;
    	    var max = Math.max;
    	    var funcType = '[object Function]';
    	    var concatty = function concatty(a, b) {
    	      var arr = [];
    	      for (var i = 0; i < a.length; i += 1) {
    	        arr[i] = a[i];
    	      }
    	      for (var j = 0; j < b.length; j += 1) {
    	        arr[j + a.length] = b[j];
    	      }
    	      return arr;
    	    };
    	    var slicy = function slicy(arrLike, offset) {
    	      var arr = [];
    	      for (var i = offset, j = 0; i < arrLike.length; i += 1, j += 1) {
    	        arr[j] = arrLike[i];
    	      }
    	      return arr;
    	    };
    	    var joiny = function (arr, joiner) {
    	      var str = '';
    	      for (var i = 0; i < arr.length; i += 1) {
    	        str += arr[i];
    	        if (i + 1 < arr.length) {
    	          str += joiner;
    	        }
    	      }
    	      return str;
    	    };
    	    implementation = function bind(that) {
    	      var target = this;
    	      if (typeof target !== 'function' || toStr.apply(target) !== funcType) {
    	        throw new TypeError(ERROR_MESSAGE + target);
    	      }
    	      var args = slicy(arguments, 1);
    	      var bound;
    	      var binder = function () {
    	        if (this instanceof bound) {
    	          var result = target.apply(this, concatty(args, arguments));
    	          if (Object(result) === result) {
    	            return result;
    	          }
    	          return this;
    	        }
    	        return target.apply(that, concatty(args, arguments));
    	      };
    	      var boundLength = max(0, target.length - args.length);
    	      var boundArgs = [];
    	      for (var i = 0; i < boundLength; i++) {
    	        boundArgs[i] = '$' + i;
    	      }
    	      bound = Function('binder', 'return function (' + joiny(boundArgs, ',') + '){ return binder.apply(this,arguments); }')(binder);
    	      if (target.prototype) {
    	        var Empty = function Empty() {};
    	        Empty.prototype = target.prototype;
    	        bound.prototype = new Empty();
    	        Empty.prototype = null;
    	      }
    	      return bound;
    	    };
    	    return implementation;
    	  }
    	  var functionBind;
    	  var hasRequiredFunctionBind;
    	  function requireFunctionBind() {
    	    if (hasRequiredFunctionBind) return functionBind;
    	    hasRequiredFunctionBind = 1;
    	    var implementation = requireImplementation();
    	    functionBind = Function.prototype.bind || implementation;
    	    return functionBind;
    	  }
    	  var functionCall;
    	  var hasRequiredFunctionCall;
    	  function requireFunctionCall() {
    	    if (hasRequiredFunctionCall) return functionCall;
    	    hasRequiredFunctionCall = 1;

    	    /** @type {import('./functionCall')} */
    	    functionCall = Function.prototype.call;
    	    return functionCall;
    	  }
    	  var functionApply;
    	  var hasRequiredFunctionApply;
    	  function requireFunctionApply() {
    	    if (hasRequiredFunctionApply) return functionApply;
    	    hasRequiredFunctionApply = 1;

    	    /** @type {import('./functionApply')} */
    	    functionApply = Function.prototype.apply;
    	    return functionApply;
    	  }

    	  /** @type {import('./reflectApply')} */
    	  var reflectApply = typeof Reflect !== 'undefined' && Reflect && Reflect.apply;
    	  var bind$2 = requireFunctionBind();
    	  var $apply$1 = requireFunctionApply();
    	  var $call$2 = requireFunctionCall();
    	  var $reflectApply = reflectApply;

    	  /** @type {import('./actualApply')} */
    	  var actualApply = $reflectApply || bind$2.call($call$2, $apply$1);
    	  var bind$1 = requireFunctionBind();
    	  var $TypeError$4 = type;
    	  var $call$1 = requireFunctionCall();
    	  var $actualApply = actualApply;

    	  /** @type {(args: [Function, thisArg?: unknown, ...args: unknown[]]) => Function} TODO FIXME, find a way to use import('.') */
    	  var callBindApplyHelpers = function callBindBasic(args) {
    	    if (args.length < 1 || typeof args[0] !== 'function') {
    	      throw new $TypeError$4('a function is required');
    	    }
    	    return $actualApply(bind$1, $call$1, args);
    	  };
    	  var get;
    	  var hasRequiredGet;
    	  function requireGet() {
    	    if (hasRequiredGet) return get;
    	    hasRequiredGet = 1;
    	    var callBind = callBindApplyHelpers;
    	    var gOPD = gopd;
    	    var hasProtoAccessor;
    	    try {
    	      // eslint-disable-next-line no-extra-parens, no-proto
    	      hasProtoAccessor = /** @type {{ __proto__?: typeof Array.prototype }} */[].__proto__ === Array.prototype;
    	    } catch (e) {
    	      if (!e || typeof e !== 'object' || !('code' in e) || e.code !== 'ERR_PROTO_ACCESS') {
    	        throw e;
    	      }
    	    }

    	    // eslint-disable-next-line no-extra-parens
    	    var desc = !!hasProtoAccessor && gOPD && gOPD(Object.prototype, /** @type {keyof typeof Object.prototype} */'__proto__');
    	    var $Object = Object;
    	    var $getPrototypeOf = $Object.getPrototypeOf;

    	    /** @type {import('./get')} */
    	    get = desc && typeof desc.get === 'function' ? callBind([desc.get]) : typeof $getPrototypeOf === 'function' ? /** @type {import('./get')} */function getDunder(value) {
    	      // eslint-disable-next-line eqeqeq
    	      return $getPrototypeOf(value == null ? value : $Object(value));
    	    } : false;
    	    return get;
    	  }
    	  var getProto$1;
    	  var hasRequiredGetProto;
    	  function requireGetProto() {
    	    if (hasRequiredGetProto) return getProto$1;
    	    hasRequiredGetProto = 1;
    	    var reflectGetProto = requireReflect_getPrototypeOf();
    	    var originalGetProto = requireObject_getPrototypeOf();
    	    var getDunderProto = requireGet();

    	    /** @type {import('.')} */
    	    getProto$1 = reflectGetProto ? function getProto(O) {
    	      // @ts-expect-error TS can't narrow inside a closure, for some reason
    	      return reflectGetProto(O);
    	    } : originalGetProto ? function getProto(O) {
    	      if (!O || typeof O !== 'object' && typeof O !== 'function') {
    	        throw new TypeError('getProto: not an object');
    	      }
    	      // @ts-expect-error TS can't narrow inside a closure, for some reason
    	      return originalGetProto(O);
    	    } : getDunderProto ? function getProto(O) {
    	      // @ts-expect-error TS can't narrow inside a closure, for some reason
    	      return getDunderProto(O);
    	    } : null;
    	    return getProto$1;
    	  }
    	  var hasown;
    	  var hasRequiredHasown;
    	  function requireHasown() {
    	    if (hasRequiredHasown) return hasown;
    	    hasRequiredHasown = 1;
    	    var call = Function.prototype.call;
    	    var $hasOwn = Object.prototype.hasOwnProperty;
    	    var bind = requireFunctionBind();

    	    /** @type {import('.')} */
    	    hasown = bind.call(call, $hasOwn);
    	    return hasown;
    	  }
    	  var undefined$1;
    	  var $Object = esObjectAtoms;
    	  var $Error = esErrors;
    	  var $EvalError = _eval;
    	  var $RangeError = range;
    	  var $ReferenceError = ref;
    	  var $SyntaxError = syntax;
    	  var $TypeError$3 = type;
    	  var $URIError = uri;
    	  var abs = abs$1;
    	  var floor = floor$1;
    	  var max = max$1;
    	  var min = min$1;
    	  var pow = pow$1;
    	  var round = round$1;
    	  var sign = sign$1;
    	  var $Function = Function;

    	  // eslint-disable-next-line consistent-return
    	  var getEvalledConstructor = function (expressionSyntax) {
    	    try {
    	      return $Function('"use strict"; return (' + expressionSyntax + ').constructor;')();
    	    } catch (e) {}
    	  };
    	  var $gOPD = gopd;
    	  var $defineProperty = esDefineProperty;
    	  var throwTypeError = function () {
    	    throw new $TypeError$3();
    	  };
    	  var ThrowTypeError = $gOPD ? function () {
    	    try {
    	      // eslint-disable-next-line no-unused-expressions, no-caller, no-restricted-properties
    	      arguments.callee; // IE 8 does not throw here
    	      return throwTypeError;
    	    } catch (calleeThrows) {
    	      try {
    	        // IE 8 throws on Object.getOwnPropertyDescriptor(arguments, '')
    	        return $gOPD(arguments, 'callee').get;
    	      } catch (gOPDthrows) {
    	        return throwTypeError;
    	      }
    	    }
    	  }() : throwTypeError;
    	  var hasSymbols = requireHasSymbols()();
    	  var getProto = requireGetProto();
    	  var $ObjectGPO = requireObject_getPrototypeOf();
    	  var $ReflectGPO = requireReflect_getPrototypeOf();
    	  var $apply = requireFunctionApply();
    	  var $call = requireFunctionCall();
    	  var needsEval = {};
    	  var TypedArray = typeof Uint8Array === 'undefined' || !getProto ? undefined$1 : getProto(Uint8Array);
    	  var INTRINSICS = {
    	    __proto__: null,
    	    '%AggregateError%': typeof AggregateError === 'undefined' ? undefined$1 : AggregateError,
    	    '%Array%': Array,
    	    '%ArrayBuffer%': typeof ArrayBuffer === 'undefined' ? undefined$1 : ArrayBuffer,
    	    '%ArrayIteratorPrototype%': hasSymbols && getProto ? getProto([][Symbol.iterator]()) : undefined$1,
    	    '%AsyncFromSyncIteratorPrototype%': undefined$1,
    	    '%AsyncFunction%': needsEval,
    	    '%AsyncGenerator%': needsEval,
    	    '%AsyncGeneratorFunction%': needsEval,
    	    '%AsyncIteratorPrototype%': needsEval,
    	    '%Atomics%': typeof Atomics === 'undefined' ? undefined$1 : Atomics,
    	    '%BigInt%': typeof BigInt === 'undefined' ? undefined$1 : BigInt,
    	    '%BigInt64Array%': typeof BigInt64Array === 'undefined' ? undefined$1 : BigInt64Array,
    	    '%BigUint64Array%': typeof BigUint64Array === 'undefined' ? undefined$1 : BigUint64Array,
    	    '%Boolean%': Boolean,
    	    '%DataView%': typeof DataView === 'undefined' ? undefined$1 : DataView,
    	    '%Date%': Date,
    	    '%decodeURI%': decodeURI,
    	    '%decodeURIComponent%': decodeURIComponent,
    	    '%encodeURI%': encodeURI,
    	    '%encodeURIComponent%': encodeURIComponent,
    	    '%Error%': $Error,
    	    '%eval%': eval,
    	    // eslint-disable-line no-eval
    	    '%EvalError%': $EvalError,
    	    '%Float16Array%': typeof Float16Array === 'undefined' ? undefined$1 : Float16Array,
    	    '%Float32Array%': typeof Float32Array === 'undefined' ? undefined$1 : Float32Array,
    	    '%Float64Array%': typeof Float64Array === 'undefined' ? undefined$1 : Float64Array,
    	    '%FinalizationRegistry%': typeof FinalizationRegistry === 'undefined' ? undefined$1 : FinalizationRegistry,
    	    '%Function%': $Function,
    	    '%GeneratorFunction%': needsEval,
    	    '%Int8Array%': typeof Int8Array === 'undefined' ? undefined$1 : Int8Array,
    	    '%Int16Array%': typeof Int16Array === 'undefined' ? undefined$1 : Int16Array,
    	    '%Int32Array%': typeof Int32Array === 'undefined' ? undefined$1 : Int32Array,
    	    '%isFinite%': isFinite,
    	    '%isNaN%': isNaN,
    	    '%IteratorPrototype%': hasSymbols && getProto ? getProto(getProto([][Symbol.iterator]())) : undefined$1,
    	    '%JSON%': typeof JSON === 'object' ? JSON : undefined$1,
    	    '%Map%': typeof Map === 'undefined' ? undefined$1 : Map,
    	    '%MapIteratorPrototype%': typeof Map === 'undefined' || !hasSymbols || !getProto ? undefined$1 : getProto(new Map()[Symbol.iterator]()),
    	    '%Math%': Math,
    	    '%Number%': Number,
    	    '%Object%': $Object,
    	    '%Object.getOwnPropertyDescriptor%': $gOPD,
    	    '%parseFloat%': parseFloat,
    	    '%parseInt%': parseInt,
    	    '%Promise%': typeof Promise === 'undefined' ? undefined$1 : Promise,
    	    '%Proxy%': typeof Proxy === 'undefined' ? undefined$1 : Proxy,
    	    '%RangeError%': $RangeError,
    	    '%ReferenceError%': $ReferenceError,
    	    '%Reflect%': typeof Reflect === 'undefined' ? undefined$1 : Reflect,
    	    '%RegExp%': RegExp,
    	    '%Set%': typeof Set === 'undefined' ? undefined$1 : Set,
    	    '%SetIteratorPrototype%': typeof Set === 'undefined' || !hasSymbols || !getProto ? undefined$1 : getProto(new Set()[Symbol.iterator]()),
    	    '%SharedArrayBuffer%': typeof SharedArrayBuffer === 'undefined' ? undefined$1 : SharedArrayBuffer,
    	    '%String%': String,
    	    '%StringIteratorPrototype%': hasSymbols && getProto ? getProto(''[Symbol.iterator]()) : undefined$1,
    	    '%Symbol%': hasSymbols ? Symbol : undefined$1,
    	    '%SyntaxError%': $SyntaxError,
    	    '%ThrowTypeError%': ThrowTypeError,
    	    '%TypedArray%': TypedArray,
    	    '%TypeError%': $TypeError$3,
    	    '%Uint8Array%': typeof Uint8Array === 'undefined' ? undefined$1 : Uint8Array,
    	    '%Uint8ClampedArray%': typeof Uint8ClampedArray === 'undefined' ? undefined$1 : Uint8ClampedArray,
    	    '%Uint16Array%': typeof Uint16Array === 'undefined' ? undefined$1 : Uint16Array,
    	    '%Uint32Array%': typeof Uint32Array === 'undefined' ? undefined$1 : Uint32Array,
    	    '%URIError%': $URIError,
    	    '%WeakMap%': typeof WeakMap === 'undefined' ? undefined$1 : WeakMap,
    	    '%WeakRef%': typeof WeakRef === 'undefined' ? undefined$1 : WeakRef,
    	    '%WeakSet%': typeof WeakSet === 'undefined' ? undefined$1 : WeakSet,
    	    '%Function.prototype.call%': $call,
    	    '%Function.prototype.apply%': $apply,
    	    '%Object.defineProperty%': $defineProperty,
    	    '%Object.getPrototypeOf%': $ObjectGPO,
    	    '%Math.abs%': abs,
    	    '%Math.floor%': floor,
    	    '%Math.max%': max,
    	    '%Math.min%': min,
    	    '%Math.pow%': pow,
    	    '%Math.round%': round,
    	    '%Math.sign%': sign,
    	    '%Reflect.getPrototypeOf%': $ReflectGPO
    	  };
    	  if (getProto) {
    	    try {
    	      null.error; // eslint-disable-line no-unused-expressions
    	    } catch (e) {
    	      // https://github.com/tc39/proposal-shadowrealm/pull/384#issuecomment-1364264229
    	      var errorProto = getProto(getProto(e));
    	      INTRINSICS['%Error.prototype%'] = errorProto;
    	    }
    	  }
    	  var doEval = function doEval(name) {
    	    var value;
    	    if (name === '%AsyncFunction%') {
    	      value = getEvalledConstructor('async function () {}');
    	    } else if (name === '%GeneratorFunction%') {
    	      value = getEvalledConstructor('function* () {}');
    	    } else if (name === '%AsyncGeneratorFunction%') {
    	      value = getEvalledConstructor('async function* () {}');
    	    } else if (name === '%AsyncGenerator%') {
    	      var fn = doEval('%AsyncGeneratorFunction%');
    	      if (fn) {
    	        value = fn.prototype;
    	      }
    	    } else if (name === '%AsyncIteratorPrototype%') {
    	      var gen = doEval('%AsyncGenerator%');
    	      if (gen && getProto) {
    	        value = getProto(gen.prototype);
    	      }
    	    }
    	    INTRINSICS[name] = value;
    	    return value;
    	  };
    	  var LEGACY_ALIASES = {
    	    __proto__: null,
    	    '%ArrayBufferPrototype%': ['ArrayBuffer', 'prototype'],
    	    '%ArrayPrototype%': ['Array', 'prototype'],
    	    '%ArrayProto_entries%': ['Array', 'prototype', 'entries'],
    	    '%ArrayProto_forEach%': ['Array', 'prototype', 'forEach'],
    	    '%ArrayProto_keys%': ['Array', 'prototype', 'keys'],
    	    '%ArrayProto_values%': ['Array', 'prototype', 'values'],
    	    '%AsyncFunctionPrototype%': ['AsyncFunction', 'prototype'],
    	    '%AsyncGenerator%': ['AsyncGeneratorFunction', 'prototype'],
    	    '%AsyncGeneratorPrototype%': ['AsyncGeneratorFunction', 'prototype', 'prototype'],
    	    '%BooleanPrototype%': ['Boolean', 'prototype'],
    	    '%DataViewPrototype%': ['DataView', 'prototype'],
    	    '%DatePrototype%': ['Date', 'prototype'],
    	    '%ErrorPrototype%': ['Error', 'prototype'],
    	    '%EvalErrorPrototype%': ['EvalError', 'prototype'],
    	    '%Float32ArrayPrototype%': ['Float32Array', 'prototype'],
    	    '%Float64ArrayPrototype%': ['Float64Array', 'prototype'],
    	    '%FunctionPrototype%': ['Function', 'prototype'],
    	    '%Generator%': ['GeneratorFunction', 'prototype'],
    	    '%GeneratorPrototype%': ['GeneratorFunction', 'prototype', 'prototype'],
    	    '%Int8ArrayPrototype%': ['Int8Array', 'prototype'],
    	    '%Int16ArrayPrototype%': ['Int16Array', 'prototype'],
    	    '%Int32ArrayPrototype%': ['Int32Array', 'prototype'],
    	    '%JSONParse%': ['JSON', 'parse'],
    	    '%JSONStringify%': ['JSON', 'stringify'],
    	    '%MapPrototype%': ['Map', 'prototype'],
    	    '%NumberPrototype%': ['Number', 'prototype'],
    	    '%ObjectPrototype%': ['Object', 'prototype'],
    	    '%ObjProto_toString%': ['Object', 'prototype', 'toString'],
    	    '%ObjProto_valueOf%': ['Object', 'prototype', 'valueOf'],
    	    '%PromisePrototype%': ['Promise', 'prototype'],
    	    '%PromiseProto_then%': ['Promise', 'prototype', 'then'],
    	    '%Promise_all%': ['Promise', 'all'],
    	    '%Promise_reject%': ['Promise', 'reject'],
    	    '%Promise_resolve%': ['Promise', 'resolve'],
    	    '%RangeErrorPrototype%': ['RangeError', 'prototype'],
    	    '%ReferenceErrorPrototype%': ['ReferenceError', 'prototype'],
    	    '%RegExpPrototype%': ['RegExp', 'prototype'],
    	    '%SetPrototype%': ['Set', 'prototype'],
    	    '%SharedArrayBufferPrototype%': ['SharedArrayBuffer', 'prototype'],
    	    '%StringPrototype%': ['String', 'prototype'],
    	    '%SymbolPrototype%': ['Symbol', 'prototype'],
    	    '%SyntaxErrorPrototype%': ['SyntaxError', 'prototype'],
    	    '%TypedArrayPrototype%': ['TypedArray', 'prototype'],
    	    '%TypeErrorPrototype%': ['TypeError', 'prototype'],
    	    '%Uint8ArrayPrototype%': ['Uint8Array', 'prototype'],
    	    '%Uint8ClampedArrayPrototype%': ['Uint8ClampedArray', 'prototype'],
    	    '%Uint16ArrayPrototype%': ['Uint16Array', 'prototype'],
    	    '%Uint32ArrayPrototype%': ['Uint32Array', 'prototype'],
    	    '%URIErrorPrototype%': ['URIError', 'prototype'],
    	    '%WeakMapPrototype%': ['WeakMap', 'prototype'],
    	    '%WeakSetPrototype%': ['WeakSet', 'prototype']
    	  };
    	  var bind = requireFunctionBind();
    	  var hasOwn = requireHasown();
    	  var $concat = bind.call($call, Array.prototype.concat);
    	  var $spliceApply = bind.call($apply, Array.prototype.splice);
    	  var $replace = bind.call($call, String.prototype.replace);
    	  var $strSlice = bind.call($call, String.prototype.slice);
    	  var $exec = bind.call($call, RegExp.prototype.exec);

    	  /* adapted from https://github.com/lodash/lodash/blob/4.17.15/dist/lodash.js#L6735-L6744 */
    	  var rePropName = /[^%.[\]]+|\[(?:(-?\d+(?:\.\d+)?)|(["'])((?:(?!\2)[^\\]|\\.)*?)\2)\]|(?=(?:\.|\[\])(?:\.|\[\]|%$))/g;
    	  var reEscapeChar = /\\(\\)?/g; /** Used to match backslashes in property paths. */
    	  var stringToPath = function stringToPath(string) {
    	    var first = $strSlice(string, 0, 1);
    	    var last = $strSlice(string, -1);
    	    if (first === '%' && last !== '%') {
    	      throw new $SyntaxError('invalid intrinsic syntax, expected closing `%`');
    	    } else if (last === '%' && first !== '%') {
    	      throw new $SyntaxError('invalid intrinsic syntax, expected opening `%`');
    	    }
    	    var result = [];
    	    $replace(string, rePropName, function (match, number, quote, subString) {
    	      result[result.length] = quote ? $replace(subString, reEscapeChar, '$1') : number || match;
    	    });
    	    return result;
    	  };
    	  /* end adaptation */

    	  var getBaseIntrinsic = function getBaseIntrinsic(name, allowMissing) {
    	    var intrinsicName = name;
    	    var alias;
    	    if (hasOwn(LEGACY_ALIASES, intrinsicName)) {
    	      alias = LEGACY_ALIASES[intrinsicName];
    	      intrinsicName = '%' + alias[0] + '%';
    	    }
    	    if (hasOwn(INTRINSICS, intrinsicName)) {
    	      var value = INTRINSICS[intrinsicName];
    	      if (value === needsEval) {
    	        value = doEval(intrinsicName);
    	      }
    	      if (typeof value === 'undefined' && !allowMissing) {
    	        throw new $TypeError$3('intrinsic ' + name + ' exists, but is not available. Please file an issue!');
    	      }
    	      return {
    	        alias: alias,
    	        name: intrinsicName,
    	        value: value
    	      };
    	    }
    	    throw new $SyntaxError('intrinsic ' + name + ' does not exist!');
    	  };
    	  var getIntrinsic = function GetIntrinsic(name, allowMissing) {
    	    if (typeof name !== 'string' || name.length === 0) {
    	      throw new $TypeError$3('intrinsic name must be a non-empty string');
    	    }
    	    if (arguments.length > 1 && typeof allowMissing !== 'boolean') {
    	      throw new $TypeError$3('"allowMissing" argument must be a boolean');
    	    }
    	    if ($exec(/^%?[^%]*%?$/, name) === null) {
    	      throw new $SyntaxError('`%` may not be present anywhere but at the beginning and end of the intrinsic name');
    	    }
    	    var parts = stringToPath(name);
    	    var intrinsicBaseName = parts.length > 0 ? parts[0] : '';
    	    var intrinsic = getBaseIntrinsic('%' + intrinsicBaseName + '%', allowMissing);
    	    var intrinsicRealName = intrinsic.name;
    	    var value = intrinsic.value;
    	    var skipFurtherCaching = false;
    	    var alias = intrinsic.alias;
    	    if (alias) {
    	      intrinsicBaseName = alias[0];
    	      $spliceApply(parts, $concat([0, 1], alias));
    	    }
    	    for (var i = 1, isOwn = true; i < parts.length; i += 1) {
    	      var part = parts[i];
    	      var first = $strSlice(part, 0, 1);
    	      var last = $strSlice(part, -1);
    	      if ((first === '"' || first === "'" || first === '`' || last === '"' || last === "'" || last === '`') && first !== last) {
    	        throw new $SyntaxError('property names with quotes must have matching quotes');
    	      }
    	      if (part === 'constructor' || !isOwn) {
    	        skipFurtherCaching = true;
    	      }
    	      intrinsicBaseName += '.' + part;
    	      intrinsicRealName = '%' + intrinsicBaseName + '%';
    	      if (hasOwn(INTRINSICS, intrinsicRealName)) {
    	        value = INTRINSICS[intrinsicRealName];
    	      } else if (value != null) {
    	        if (!(part in value)) {
    	          if (!allowMissing) {
    	            throw new $TypeError$3('base intrinsic for ' + name + ' exists, but the property is not available.');
    	          }
    	          return void undefined$1;
    	        }
    	        if ($gOPD && i + 1 >= parts.length) {
    	          var desc = $gOPD(value, part);
    	          isOwn = !!desc;

    	          // By convention, when a data property is converted to an accessor
    	          // property to emulate a data property that does not suffer from
    	          // the override mistake, that accessor's getter is marked with
    	          // an `originalValue` property. Here, when we detect this, we
    	          // uphold the illusion by pretending to see that original data
    	          // property, i.e., returning the value rather than the getter
    	          // itself.
    	          if (isOwn && 'get' in desc && !('originalValue' in desc.get)) {
    	            value = desc.get;
    	          } else {
    	            value = value[part];
    	          }
    	        } else {
    	          isOwn = hasOwn(value, part);
    	          value = value[part];
    	        }
    	        if (isOwn && !skipFurtherCaching) {
    	          INTRINSICS[intrinsicRealName] = value;
    	        }
    	      }
    	    }
    	    return value;
    	  };
    	  var GetIntrinsic$2 = getIntrinsic;
    	  var callBindBasic = callBindApplyHelpers;

    	  /** @type {(thisArg: string, searchString: string, position?: number) => number} */
    	  var $indexOf = callBindBasic([GetIntrinsic$2('%String.prototype.indexOf%')]);

    	  /** @type {import('.')} */
    	  var callBound$2 = function callBoundIntrinsic(name, allowMissing) {
    	    /* eslint no-extra-parens: 0 */

    	    var intrinsic = /** @type {(this: unknown, ...args: unknown[]) => unknown} */GetIntrinsic$2(name, !!allowMissing);
    	    if (typeof intrinsic === 'function' && $indexOf(name, '.prototype.') > -1) {
    	      return callBindBasic(/** @type {const} */[intrinsic]);
    	    }
    	    return intrinsic;
    	  };
    	  var GetIntrinsic$1 = getIntrinsic;
    	  var callBound$1 = callBound$2;
    	  var inspect$2 = objectInspect;
    	  var $TypeError$2 = type;
    	  var $Map = GetIntrinsic$1('%Map%', true);

    	  /** @type {<K, V>(thisArg: Map<K, V>, key: K) => V} */
    	  var $mapGet = callBound$1('Map.prototype.get', true);
    	  /** @type {<K, V>(thisArg: Map<K, V>, key: K, value: V) => void} */
    	  var $mapSet = callBound$1('Map.prototype.set', true);
    	  /** @type {<K, V>(thisArg: Map<K, V>, key: K) => boolean} */
    	  var $mapHas = callBound$1('Map.prototype.has', true);
    	  /** @type {<K, V>(thisArg: Map<K, V>, key: K) => boolean} */
    	  var $mapDelete = callBound$1('Map.prototype.delete', true);
    	  /** @type {<K, V>(thisArg: Map<K, V>) => number} */
    	  var $mapSize = callBound$1('Map.prototype.size', true);

    	  /** @type {import('.')} */
    	  var sideChannelMap = !!$Map && /** @type {Exclude<import('.'), false>} */function getSideChannelMap() {
    	    /** @typedef {ReturnType<typeof getSideChannelMap>} Channel */
    	    /** @typedef {Parameters<Channel['get']>[0]} K */
    	    /** @typedef {Parameters<Channel['set']>[1]} V */

    	    /** @type {Map<K, V> | undefined} */var $m;

    	    /** @type {Channel} */
    	    var channel = {
    	      assert: function (key) {
    	        if (!channel.has(key)) {
    	          throw new $TypeError$2('Side channel does not contain ' + inspect$2(key));
    	        }
    	      },
    	      'delete': function (key) {
    	        if ($m) {
    	          var result = $mapDelete($m, key);
    	          if ($mapSize($m) === 0) {
    	            $m = void undefined;
    	          }
    	          return result;
    	        }
    	        return false;
    	      },
    	      get: function (key) {
    	        // eslint-disable-line consistent-return
    	        if ($m) {
    	          return $mapGet($m, key);
    	        }
    	      },
    	      has: function (key) {
    	        if ($m) {
    	          return $mapHas($m, key);
    	        }
    	        return false;
    	      },
    	      set: function (key, value) {
    	        if (!$m) {
    	          // @ts-expect-error TS can't handle narrowing a variable inside a closure
    	          $m = new $Map();
    	        }
    	        $mapSet($m, key, value);
    	      }
    	    };

    	    // @ts-expect-error TODO: figure out why TS is erroring here
    	    return channel;
    	  };
    	  var GetIntrinsic = getIntrinsic;
    	  var callBound = callBound$2;
    	  var inspect$1 = objectInspect;
    	  var getSideChannelMap$1 = sideChannelMap;
    	  var $TypeError$1 = type;
    	  var $WeakMap = GetIntrinsic('%WeakMap%', true);

    	  /** @type {<K extends object, V>(thisArg: WeakMap<K, V>, key: K) => V} */
    	  var $weakMapGet = callBound('WeakMap.prototype.get', true);
    	  /** @type {<K extends object, V>(thisArg: WeakMap<K, V>, key: K, value: V) => void} */
    	  var $weakMapSet = callBound('WeakMap.prototype.set', true);
    	  /** @type {<K extends object, V>(thisArg: WeakMap<K, V>, key: K) => boolean} */
    	  var $weakMapHas = callBound('WeakMap.prototype.has', true);
    	  /** @type {<K extends object, V>(thisArg: WeakMap<K, V>, key: K) => boolean} */
    	  var $weakMapDelete = callBound('WeakMap.prototype.delete', true);

    	  /** @type {import('.')} */
    	  var sideChannelWeakmap = $WeakMap ? /** @type {Exclude<import('.'), false>} */function getSideChannelWeakMap() {
    	    /** @typedef {ReturnType<typeof getSideChannelWeakMap>} Channel */
    	    /** @typedef {Parameters<Channel['get']>[0]} K */
    	    /** @typedef {Parameters<Channel['set']>[1]} V */

    	    /** @type {WeakMap<K & object, V> | undefined} */var $wm;
    	    /** @type {Channel | undefined} */
    	    var $m;

    	    /** @type {Channel} */
    	    var channel = {
    	      assert: function (key) {
    	        if (!channel.has(key)) {
    	          throw new $TypeError$1('Side channel does not contain ' + inspect$1(key));
    	        }
    	      },
    	      'delete': function (key) {
    	        if ($WeakMap && key && (typeof key === 'object' || typeof key === 'function')) {
    	          if ($wm) {
    	            return $weakMapDelete($wm, key);
    	          }
    	        } else if (getSideChannelMap$1) {
    	          if ($m) {
    	            return $m['delete'](key);
    	          }
    	        }
    	        return false;
    	      },
    	      get: function (key) {
    	        if ($WeakMap && key && (typeof key === 'object' || typeof key === 'function')) {
    	          if ($wm) {
    	            return $weakMapGet($wm, key);
    	          }
    	        }
    	        return $m && $m.get(key);
    	      },
    	      has: function (key) {
    	        if ($WeakMap && key && (typeof key === 'object' || typeof key === 'function')) {
    	          if ($wm) {
    	            return $weakMapHas($wm, key);
    	          }
    	        }
    	        return !!$m && $m.has(key);
    	      },
    	      set: function (key, value) {
    	        if ($WeakMap && key && (typeof key === 'object' || typeof key === 'function')) {
    	          if (!$wm) {
    	            $wm = new $WeakMap();
    	          }
    	          $weakMapSet($wm, key, value);
    	        } else if (getSideChannelMap$1) {
    	          if (!$m) {
    	            $m = getSideChannelMap$1();
    	          }
    	          // eslint-disable-next-line no-extra-parens
    	          /** @type {NonNullable<typeof $m>} */
    	          $m.set(key, value);
    	        }
    	      }
    	    };

    	    // @ts-expect-error TODO: figure out why this is erroring
    	    return channel;
    	  } : getSideChannelMap$1;
    	  var $TypeError = type;
    	  var inspect = objectInspect;
    	  var getSideChannelList = sideChannelList;
    	  var getSideChannelMap = sideChannelMap;
    	  var getSideChannelWeakMap = sideChannelWeakmap;
    	  var makeChannel = getSideChannelWeakMap || getSideChannelMap || getSideChannelList;

    	  /** @type {import('.')} */
    	  var sideChannel = function getSideChannel() {
    	    /** @typedef {ReturnType<typeof getSideChannel>} Channel */

    	    /** @type {Channel | undefined} */var $channelData;

    	    /** @type {Channel} */
    	    var channel = {
    	      assert: function (key) {
    	        if (!channel.has(key)) {
    	          throw new $TypeError('Side channel does not contain ' + inspect(key));
    	        }
    	      },
    	      'delete': function (key) {
    	        return !!$channelData && $channelData['delete'](key);
    	      },
    	      get: function (key) {
    	        return $channelData && $channelData.get(key);
    	      },
    	      has: function (key) {
    	        return !!$channelData && $channelData.has(key);
    	      },
    	      set: function (key, value) {
    	        if (!$channelData) {
    	          $channelData = makeChannel();
    	        }
    	        $channelData.set(key, value);
    	      }
    	    };
    	    // @ts-expect-error TODO: figure out why this is erroring
    	    return channel;
    	  };
    	  var replace = String.prototype.replace;
    	  var percentTwenties = /%20/g;
    	  var Format = {
    	    RFC1738: 'RFC1738',
    	    RFC3986: 'RFC3986'
    	  };
    	  var formats$3 = {
    	    'default': Format.RFC3986,
    	    formatters: {
    	      RFC1738: function (value) {
    	        return replace.call(value, percentTwenties, '+');
    	      },
    	      RFC3986: function (value) {
    	        return String(value);
    	      }
    	    },
    	    RFC1738: Format.RFC1738,
    	    RFC3986: Format.RFC3986
    	  };
    	  var formats$2 = formats$3;
    	  var has$2 = Object.prototype.hasOwnProperty;
    	  var isArray$2 = Array.isArray;
    	  var hexTable = function () {
    	    var array = [];
    	    for (var i = 0; i < 256; ++i) {
    	      array.push('%' + ((i < 16 ? '0' : '') + i.toString(16)).toUpperCase());
    	    }
    	    return array;
    	  }();
    	  var compactQueue = function compactQueue(queue) {
    	    while (queue.length > 1) {
    	      var item = queue.pop();
    	      var obj = item.obj[item.prop];
    	      if (isArray$2(obj)) {
    	        var compacted = [];
    	        for (var j = 0; j < obj.length; ++j) {
    	          if (typeof obj[j] !== 'undefined') {
    	            compacted.push(obj[j]);
    	          }
    	        }
    	        item.obj[item.prop] = compacted;
    	      }
    	    }
    	  };
    	  var arrayToObject = function arrayToObject(source, options) {
    	    var obj = options && options.plainObjects ? {
    	      __proto__: null
    	    } : {};
    	    for (var i = 0; i < source.length; ++i) {
    	      if (typeof source[i] !== 'undefined') {
    	        obj[i] = source[i];
    	      }
    	    }
    	    return obj;
    	  };
    	  var merge = function merge(target, source, options) {
    	    /* eslint no-param-reassign: 0 */
    	    if (!source) {
    	      return target;
    	    }
    	    if (typeof source !== 'object' && typeof source !== 'function') {
    	      if (isArray$2(target)) {
    	        target.push(source);
    	      } else if (target && typeof target === 'object') {
    	        if (options && (options.plainObjects || options.allowPrototypes) || !has$2.call(Object.prototype, source)) {
    	          target[source] = true;
    	        }
    	      } else {
    	        return [target, source];
    	      }
    	      return target;
    	    }
    	    if (!target || typeof target !== 'object') {
    	      return [target].concat(source);
    	    }
    	    var mergeTarget = target;
    	    if (isArray$2(target) && !isArray$2(source)) {
    	      mergeTarget = arrayToObject(target, options);
    	    }
    	    if (isArray$2(target) && isArray$2(source)) {
    	      source.forEach(function (item, i) {
    	        if (has$2.call(target, i)) {
    	          var targetItem = target[i];
    	          if (targetItem && typeof targetItem === 'object' && item && typeof item === 'object') {
    	            target[i] = merge(targetItem, item, options);
    	          } else {
    	            target.push(item);
    	          }
    	        } else {
    	          target[i] = item;
    	        }
    	      });
    	      return target;
    	    }
    	    return Object.keys(source).reduce(function (acc, key) {
    	      var value = source[key];
    	      if (has$2.call(acc, key)) {
    	        acc[key] = merge(acc[key], value, options);
    	      } else {
    	        acc[key] = value;
    	      }
    	      return acc;
    	    }, mergeTarget);
    	  };
    	  var assign = function assignSingleSource(target, source) {
    	    return Object.keys(source).reduce(function (acc, key) {
    	      acc[key] = source[key];
    	      return acc;
    	    }, target);
    	  };
    	  var decode = function (str, defaultDecoder, charset) {
    	    var strWithoutPlus = str.replace(/\+/g, ' ');
    	    if (charset === 'iso-8859-1') {
    	      // unescape never throws, no try...catch needed:
    	      return strWithoutPlus.replace(/%[0-9a-f]{2}/gi, unescape);
    	    }
    	    // utf-8
    	    try {
    	      return decodeURIComponent(strWithoutPlus);
    	    } catch (e) {
    	      return strWithoutPlus;
    	    }
    	  };
    	  var limit = 1024;

    	  /* eslint operator-linebreak: [2, "before"] */

    	  var encode = function encode(str, defaultEncoder, charset, kind, format) {
    	    // This code was originally written by Brian White (mscdex) for the io.js core querystring library.
    	    // It has been adapted here for stricter adherence to RFC 3986
    	    if (str.length === 0) {
    	      return str;
    	    }
    	    var string = str;
    	    if (typeof str === 'symbol') {
    	      string = Symbol.prototype.toString.call(str);
    	    } else if (typeof str !== 'string') {
    	      string = String(str);
    	    }
    	    if (charset === 'iso-8859-1') {
    	      return escape(string).replace(/%u[0-9a-f]{4}/gi, function ($0) {
    	        return '%26%23' + parseInt($0.slice(2), 16) + '%3B';
    	      });
    	    }
    	    var out = '';
    	    for (var j = 0; j < string.length; j += limit) {
    	      var segment = string.length >= limit ? string.slice(j, j + limit) : string;
    	      var arr = [];
    	      for (var i = 0; i < segment.length; ++i) {
    	        var c = segment.charCodeAt(i);
    	        if (c === 0x2D // -
    	        || c === 0x2E // .
    	        || c === 0x5F // _
    	        || c === 0x7E // ~
    	        || c >= 0x30 && c <= 0x39 // 0-9
    	        || c >= 0x41 && c <= 0x5A // a-z
    	        || c >= 0x61 && c <= 0x7A // A-Z
    	        || format === formats$2.RFC1738 && (c === 0x28 || c === 0x29) // ( )
    	        ) {
    	          arr[arr.length] = segment.charAt(i);
    	          continue;
    	        }
    	        if (c < 0x80) {
    	          arr[arr.length] = hexTable[c];
    	          continue;
    	        }
    	        if (c < 0x800) {
    	          arr[arr.length] = hexTable[0xC0 | c >> 6] + hexTable[0x80 | c & 0x3F];
    	          continue;
    	        }
    	        if (c < 0xD800 || c >= 0xE000) {
    	          arr[arr.length] = hexTable[0xE0 | c >> 12] + hexTable[0x80 | c >> 6 & 0x3F] + hexTable[0x80 | c & 0x3F];
    	          continue;
    	        }
    	        i += 1;
    	        c = 0x10000 + ((c & 0x3FF) << 10 | segment.charCodeAt(i) & 0x3FF);
    	        arr[arr.length] = hexTable[0xF0 | c >> 18] + hexTable[0x80 | c >> 12 & 0x3F] + hexTable[0x80 | c >> 6 & 0x3F] + hexTable[0x80 | c & 0x3F];
    	      }
    	      out += arr.join('');
    	    }
    	    return out;
    	  };
    	  var compact = function compact(value) {
    	    var queue = [{
    	      obj: {
    	        o: value
    	      },
    	      prop: 'o'
    	    }];
    	    var refs = [];
    	    for (var i = 0; i < queue.length; ++i) {
    	      var item = queue[i];
    	      var obj = item.obj[item.prop];
    	      var keys = Object.keys(obj);
    	      for (var j = 0; j < keys.length; ++j) {
    	        var key = keys[j];
    	        var val = obj[key];
    	        if (typeof val === 'object' && val !== null && refs.indexOf(val) === -1) {
    	          queue.push({
    	            obj: obj,
    	            prop: key
    	          });
    	          refs.push(val);
    	        }
    	      }
    	    }
    	    compactQueue(queue);
    	    return value;
    	  };
    	  var isRegExp = function isRegExp(obj) {
    	    return Object.prototype.toString.call(obj) === '[object RegExp]';
    	  };
    	  var isBuffer = function isBuffer(obj) {
    	    if (!obj || typeof obj !== 'object') {
    	      return false;
    	    }
    	    return !!(obj.constructor && obj.constructor.isBuffer && obj.constructor.isBuffer(obj));
    	  };
    	  var combine = function combine(a, b) {
    	    return [].concat(a, b);
    	  };
    	  var maybeMap = function maybeMap(val, fn) {
    	    if (isArray$2(val)) {
    	      var mapped = [];
    	      for (var i = 0; i < val.length; i += 1) {
    	        mapped.push(fn(val[i]));
    	      }
    	      return mapped;
    	    }
    	    return fn(val);
    	  };
    	  var utils$2 = {
    	    arrayToObject: arrayToObject,
    	    assign: assign,
    	    combine: combine,
    	    compact: compact,
    	    decode: decode,
    	    encode: encode,
    	    isBuffer: isBuffer,
    	    isRegExp: isRegExp,
    	    maybeMap: maybeMap,
    	    merge: merge
    	  };
    	  var getSideChannel = sideChannel;
    	  var utils$1 = utils$2;
    	  var formats$1 = formats$3;
    	  var has$1 = Object.prototype.hasOwnProperty;
    	  var arrayPrefixGenerators = {
    	    brackets: function brackets(prefix) {
    	      return prefix + '[]';
    	    },
    	    comma: 'comma',
    	    indices: function indices(prefix, key) {
    	      return prefix + '[' + key + ']';
    	    },
    	    repeat: function repeat(prefix) {
    	      return prefix;
    	    }
    	  };
    	  var isArray$1 = Array.isArray;
    	  var push = Array.prototype.push;
    	  var pushToArray = function (arr, valueOrArray) {
    	    push.apply(arr, isArray$1(valueOrArray) ? valueOrArray : [valueOrArray]);
    	  };
    	  var toISO = Date.prototype.toISOString;
    	  var defaultFormat = formats$1['default'];
    	  var defaults$1 = {
    	    addQueryPrefix: false,
    	    allowDots: false,
    	    allowEmptyArrays: false,
    	    arrayFormat: 'indices',
    	    charset: 'utf-8',
    	    charsetSentinel: false,
    	    commaRoundTrip: false,
    	    delimiter: '&',
    	    encode: true,
    	    encodeDotInKeys: false,
    	    encoder: utils$1.encode,
    	    encodeValuesOnly: false,
    	    filter: void undefined,
    	    format: defaultFormat,
    	    formatter: formats$1.formatters[defaultFormat],
    	    // deprecated
    	    indices: false,
    	    serializeDate: function serializeDate(date) {
    	      return toISO.call(date);
    	    },
    	    skipNulls: false,
    	    strictNullHandling: false
    	  };
    	  var isNonNullishPrimitive = function isNonNullishPrimitive(v) {
    	    return typeof v === 'string' || typeof v === 'number' || typeof v === 'boolean' || typeof v === 'symbol' || typeof v === 'bigint';
    	  };
    	  var sentinel = {};
    	  var stringify$1 = function stringify(object, prefix, generateArrayPrefix, commaRoundTrip, allowEmptyArrays, strictNullHandling, skipNulls, encodeDotInKeys, encoder, filter, sort, allowDots, serializeDate, format, formatter, encodeValuesOnly, charset, sideChannel) {
    	    var obj = object;
    	    var tmpSc = sideChannel;
    	    var step = 0;
    	    var findFlag = false;
    	    while ((tmpSc = tmpSc.get(sentinel)) !== void undefined && !findFlag) {
    	      // Where object last appeared in the ref tree
    	      var pos = tmpSc.get(object);
    	      step += 1;
    	      if (typeof pos !== 'undefined') {
    	        if (pos === step) {
    	          throw new RangeError('Cyclic object value');
    	        } else {
    	          findFlag = true; // Break while
    	        }
    	      }
    	      if (typeof tmpSc.get(sentinel) === 'undefined') {
    	        step = 0;
    	      }
    	    }
    	    if (typeof filter === 'function') {
    	      obj = filter(prefix, obj);
    	    } else if (obj instanceof Date) {
    	      obj = serializeDate(obj);
    	    } else if (generateArrayPrefix === 'comma' && isArray$1(obj)) {
    	      obj = utils$1.maybeMap(obj, function (value) {
    	        if (value instanceof Date) {
    	          return serializeDate(value);
    	        }
    	        return value;
    	      });
    	    }
    	    if (obj === null) {
    	      if (strictNullHandling) {
    	        return encoder && !encodeValuesOnly ? encoder(prefix, defaults$1.encoder, charset, 'key', format) : prefix;
    	      }
    	      obj = '';
    	    }
    	    if (isNonNullishPrimitive(obj) || utils$1.isBuffer(obj)) {
    	      if (encoder) {
    	        var keyValue = encodeValuesOnly ? prefix : encoder(prefix, defaults$1.encoder, charset, 'key', format);
    	        return [formatter(keyValue) + '=' + formatter(encoder(obj, defaults$1.encoder, charset, 'value', format))];
    	      }
    	      return [formatter(prefix) + '=' + formatter(String(obj))];
    	    }
    	    var values = [];
    	    if (typeof obj === 'undefined') {
    	      return values;
    	    }
    	    var objKeys;
    	    if (generateArrayPrefix === 'comma' && isArray$1(obj)) {
    	      // we need to join elements in
    	      if (encodeValuesOnly && encoder) {
    	        obj = utils$1.maybeMap(obj, encoder);
    	      }
    	      objKeys = [{
    	        value: obj.length > 0 ? obj.join(',') || null : void undefined
    	      }];
    	    } else if (isArray$1(filter)) {
    	      objKeys = filter;
    	    } else {
    	      var keys = Object.keys(obj);
    	      objKeys = sort ? keys.sort(sort) : keys;
    	    }
    	    var encodedPrefix = encodeDotInKeys ? String(prefix).replace(/\./g, '%2E') : String(prefix);
    	    var adjustedPrefix = commaRoundTrip && isArray$1(obj) && obj.length === 1 ? encodedPrefix + '[]' : encodedPrefix;
    	    if (allowEmptyArrays && isArray$1(obj) && obj.length === 0) {
    	      return adjustedPrefix + '[]';
    	    }
    	    for (var j = 0; j < objKeys.length; ++j) {
    	      var key = objKeys[j];
    	      var value = typeof key === 'object' && key && typeof key.value !== 'undefined' ? key.value : obj[key];
    	      if (skipNulls && value === null) {
    	        continue;
    	      }
    	      var encodedKey = allowDots && encodeDotInKeys ? String(key).replace(/\./g, '%2E') : String(key);
    	      var keyPrefix = isArray$1(obj) ? typeof generateArrayPrefix === 'function' ? generateArrayPrefix(adjustedPrefix, encodedKey) : adjustedPrefix : adjustedPrefix + (allowDots ? '.' + encodedKey : '[' + encodedKey + ']');
    	      sideChannel.set(object, step);
    	      var valueSideChannel = getSideChannel();
    	      valueSideChannel.set(sentinel, sideChannel);
    	      pushToArray(values, stringify(value, keyPrefix, generateArrayPrefix, commaRoundTrip, allowEmptyArrays, strictNullHandling, skipNulls, encodeDotInKeys, generateArrayPrefix === 'comma' && encodeValuesOnly && isArray$1(obj) ? null : encoder, filter, sort, allowDots, serializeDate, format, formatter, encodeValuesOnly, charset, valueSideChannel));
    	    }
    	    return values;
    	  };
    	  var normalizeStringifyOptions = function normalizeStringifyOptions(opts) {
    	    if (!opts) {
    	      return defaults$1;
    	    }
    	    if (typeof opts.allowEmptyArrays !== 'undefined' && typeof opts.allowEmptyArrays !== 'boolean') {
    	      throw new TypeError('`allowEmptyArrays` option can only be `true` or `false`, when provided');
    	    }
    	    if (typeof opts.encodeDotInKeys !== 'undefined' && typeof opts.encodeDotInKeys !== 'boolean') {
    	      throw new TypeError('`encodeDotInKeys` option can only be `true` or `false`, when provided');
    	    }
    	    if (opts.encoder !== null && typeof opts.encoder !== 'undefined' && typeof opts.encoder !== 'function') {
    	      throw new TypeError('Encoder has to be a function.');
    	    }
    	    var charset = opts.charset || defaults$1.charset;
    	    if (typeof opts.charset !== 'undefined' && opts.charset !== 'utf-8' && opts.charset !== 'iso-8859-1') {
    	      throw new TypeError('The charset option must be either utf-8, iso-8859-1, or undefined');
    	    }
    	    var format = formats$1['default'];
    	    if (typeof opts.format !== 'undefined') {
    	      if (!has$1.call(formats$1.formatters, opts.format)) {
    	        throw new TypeError('Unknown format option provided.');
    	      }
    	      format = opts.format;
    	    }
    	    var formatter = formats$1.formatters[format];
    	    var filter = defaults$1.filter;
    	    if (typeof opts.filter === 'function' || isArray$1(opts.filter)) {
    	      filter = opts.filter;
    	    }
    	    var arrayFormat;
    	    if (opts.arrayFormat in arrayPrefixGenerators) {
    	      arrayFormat = opts.arrayFormat;
    	    } else if ('indices' in opts) {
    	      arrayFormat = opts.indices ? 'indices' : 'repeat';
    	    } else {
    	      arrayFormat = defaults$1.arrayFormat;
    	    }
    	    if ('commaRoundTrip' in opts && typeof opts.commaRoundTrip !== 'boolean') {
    	      throw new TypeError('`commaRoundTrip` must be a boolean, or absent');
    	    }
    	    var allowDots = typeof opts.allowDots === 'undefined' ? opts.encodeDotInKeys === true ? true : defaults$1.allowDots : !!opts.allowDots;
    	    return {
    	      addQueryPrefix: typeof opts.addQueryPrefix === 'boolean' ? opts.addQueryPrefix : defaults$1.addQueryPrefix,
    	      allowDots: allowDots,
    	      allowEmptyArrays: typeof opts.allowEmptyArrays === 'boolean' ? !!opts.allowEmptyArrays : defaults$1.allowEmptyArrays,
    	      arrayFormat: arrayFormat,
    	      charset: charset,
    	      charsetSentinel: typeof opts.charsetSentinel === 'boolean' ? opts.charsetSentinel : defaults$1.charsetSentinel,
    	      commaRoundTrip: !!opts.commaRoundTrip,
    	      delimiter: typeof opts.delimiter === 'undefined' ? defaults$1.delimiter : opts.delimiter,
    	      encode: typeof opts.encode === 'boolean' ? opts.encode : defaults$1.encode,
    	      encodeDotInKeys: typeof opts.encodeDotInKeys === 'boolean' ? opts.encodeDotInKeys : defaults$1.encodeDotInKeys,
    	      encoder: typeof opts.encoder === 'function' ? opts.encoder : defaults$1.encoder,
    	      encodeValuesOnly: typeof opts.encodeValuesOnly === 'boolean' ? opts.encodeValuesOnly : defaults$1.encodeValuesOnly,
    	      filter: filter,
    	      format: format,
    	      formatter: formatter,
    	      serializeDate: typeof opts.serializeDate === 'function' ? opts.serializeDate : defaults$1.serializeDate,
    	      skipNulls: typeof opts.skipNulls === 'boolean' ? opts.skipNulls : defaults$1.skipNulls,
    	      sort: typeof opts.sort === 'function' ? opts.sort : null,
    	      strictNullHandling: typeof opts.strictNullHandling === 'boolean' ? opts.strictNullHandling : defaults$1.strictNullHandling
    	    };
    	  };
    	  var stringify_1 = function (object, opts) {
    	    var obj = object;
    	    var options = normalizeStringifyOptions(opts);
    	    var objKeys;
    	    var filter;
    	    if (typeof options.filter === 'function') {
    	      filter = options.filter;
    	      obj = filter('', obj);
    	    } else if (isArray$1(options.filter)) {
    	      filter = options.filter;
    	      objKeys = filter;
    	    }
    	    var keys = [];
    	    if (typeof obj !== 'object' || obj === null) {
    	      return '';
    	    }
    	    var generateArrayPrefix = arrayPrefixGenerators[options.arrayFormat];
    	    var commaRoundTrip = generateArrayPrefix === 'comma' && options.commaRoundTrip;
    	    if (!objKeys) {
    	      objKeys = Object.keys(obj);
    	    }
    	    if (options.sort) {
    	      objKeys.sort(options.sort);
    	    }
    	    var sideChannel = getSideChannel();
    	    for (var i = 0; i < objKeys.length; ++i) {
    	      var key = objKeys[i];
    	      var value = obj[key];
    	      if (options.skipNulls && value === null) {
    	        continue;
    	      }
    	      pushToArray(keys, stringify$1(value, key, generateArrayPrefix, commaRoundTrip, options.allowEmptyArrays, options.strictNullHandling, options.skipNulls, options.encodeDotInKeys, options.encode ? options.encoder : null, options.filter, options.sort, options.allowDots, options.serializeDate, options.format, options.formatter, options.encodeValuesOnly, options.charset, sideChannel));
    	    }
    	    var joined = keys.join(options.delimiter);
    	    var prefix = options.addQueryPrefix === true ? '?' : '';
    	    if (options.charsetSentinel) {
    	      if (options.charset === 'iso-8859-1') {
    	        // encodeURIComponent('&#10003;'), the "numeric entity" representation of a checkmark
    	        prefix += 'utf8=%26%2310003%3B&';
    	      } else {
    	        // encodeURIComponent('✓')
    	        prefix += 'utf8=%E2%9C%93&';
    	      }
    	    }
    	    return joined.length > 0 ? prefix + joined : '';
    	  };
    	  var utils = utils$2;
    	  var has = Object.prototype.hasOwnProperty;
    	  var isArray = Array.isArray;
    	  var defaults = {
    	    allowDots: false,
    	    allowEmptyArrays: false,
    	    allowPrototypes: false,
    	    allowSparse: false,
    	    arrayLimit: 20,
    	    charset: 'utf-8',
    	    charsetSentinel: false,
    	    comma: false,
    	    decodeDotInKeys: false,
    	    decoder: utils.decode,
    	    delimiter: '&',
    	    depth: 5,
    	    duplicates: 'combine',
    	    ignoreQueryPrefix: false,
    	    interpretNumericEntities: false,
    	    parameterLimit: 1000,
    	    parseArrays: true,
    	    plainObjects: false,
    	    strictDepth: false,
    	    strictNullHandling: false,
    	    throwOnLimitExceeded: false
    	  };
    	  var interpretNumericEntities = function (str) {
    	    return str.replace(/&#(\d+);/g, function ($0, numberStr) {
    	      return String.fromCharCode(parseInt(numberStr, 10));
    	    });
    	  };
    	  var parseArrayValue = function (val, options, currentArrayLength) {
    	    if (val && typeof val === 'string' && options.comma && val.indexOf(',') > -1) {
    	      return val.split(',');
    	    }
    	    if (options.throwOnLimitExceeded && currentArrayLength >= options.arrayLimit) {
    	      throw new RangeError('Array limit exceeded. Only ' + options.arrayLimit + ' element' + (options.arrayLimit === 1 ? '' : 's') + ' allowed in an array.');
    	    }
    	    return val;
    	  };

    	  // This is what browsers will submit when the ✓ character occurs in an
    	  // application/x-www-form-urlencoded body and the encoding of the page containing
    	  // the form is iso-8859-1, or when the submitted form has an accept-charset
    	  // attribute of iso-8859-1. Presumably also with other charsets that do not contain
    	  // the ✓ character, such as us-ascii.
    	  var isoSentinel = 'utf8=%26%2310003%3B'; // encodeURIComponent('&#10003;')

    	  // These are the percent-encoded utf-8 octets representing a checkmark, indicating that the request actually is utf-8 encoded.
    	  var charsetSentinel = 'utf8=%E2%9C%93'; // encodeURIComponent('✓')

    	  var parseValues = function parseQueryStringValues(str, options) {
    	    var obj = {
    	      __proto__: null
    	    };
    	    var cleanStr = options.ignoreQueryPrefix ? str.replace(/^\?/, '') : str;
    	    cleanStr = cleanStr.replace(/%5B/gi, '[').replace(/%5D/gi, ']');
    	    var limit = options.parameterLimit === Infinity ? undefined : options.parameterLimit;
    	    var parts = cleanStr.split(options.delimiter, options.throwOnLimitExceeded ? limit + 1 : limit);
    	    if (options.throwOnLimitExceeded && parts.length > limit) {
    	      throw new RangeError('Parameter limit exceeded. Only ' + limit + ' parameter' + (limit === 1 ? '' : 's') + ' allowed.');
    	    }
    	    var skipIndex = -1; // Keep track of where the utf8 sentinel was found
    	    var i;
    	    var charset = options.charset;
    	    if (options.charsetSentinel) {
    	      for (i = 0; i < parts.length; ++i) {
    	        if (parts[i].indexOf('utf8=') === 0) {
    	          if (parts[i] === charsetSentinel) {
    	            charset = 'utf-8';
    	          } else if (parts[i] === isoSentinel) {
    	            charset = 'iso-8859-1';
    	          }
    	          skipIndex = i;
    	          i = parts.length; // The eslint settings do not allow break;
    	        }
    	      }
    	    }
    	    for (i = 0; i < parts.length; ++i) {
    	      if (i === skipIndex) {
    	        continue;
    	      }
    	      var part = parts[i];
    	      var bracketEqualsPos = part.indexOf(']=');
    	      var pos = bracketEqualsPos === -1 ? part.indexOf('=') : bracketEqualsPos + 1;
    	      var key;
    	      var val;
    	      if (pos === -1) {
    	        key = options.decoder(part, defaults.decoder, charset, 'key');
    	        val = options.strictNullHandling ? null : '';
    	      } else {
    	        key = options.decoder(part.slice(0, pos), defaults.decoder, charset, 'key');
    	        val = utils.maybeMap(parseArrayValue(part.slice(pos + 1), options, isArray(obj[key]) ? obj[key].length : 0), function (encodedVal) {
    	          return options.decoder(encodedVal, defaults.decoder, charset, 'value');
    	        });
    	      }
    	      if (val && options.interpretNumericEntities && charset === 'iso-8859-1') {
    	        val = interpretNumericEntities(String(val));
    	      }
    	      if (part.indexOf('[]=') > -1) {
    	        val = isArray(val) ? [val] : val;
    	      }
    	      var existing = has.call(obj, key);
    	      if (existing && options.duplicates === 'combine') {
    	        obj[key] = utils.combine(obj[key], val);
    	      } else if (!existing || options.duplicates === 'last') {
    	        obj[key] = val;
    	      }
    	    }
    	    return obj;
    	  };
    	  var parseObject = function (chain, val, options, valuesParsed) {
    	    var currentArrayLength = 0;
    	    if (chain.length > 0 && chain[chain.length - 1] === '[]') {
    	      var parentKey = chain.slice(0, -1).join('');
    	      currentArrayLength = Array.isArray(val) && val[parentKey] ? val[parentKey].length : 0;
    	    }
    	    var leaf = valuesParsed ? val : parseArrayValue(val, options, currentArrayLength);
    	    for (var i = chain.length - 1; i >= 0; --i) {
    	      var obj;
    	      var root = chain[i];
    	      if (root === '[]' && options.parseArrays) {
    	        obj = options.allowEmptyArrays && (leaf === '' || options.strictNullHandling && leaf === null) ? [] : utils.combine([], leaf);
    	      } else {
    	        obj = options.plainObjects ? {
    	          __proto__: null
    	        } : {};
    	        var cleanRoot = root.charAt(0) === '[' && root.charAt(root.length - 1) === ']' ? root.slice(1, -1) : root;
    	        var decodedRoot = options.decodeDotInKeys ? cleanRoot.replace(/%2E/g, '.') : cleanRoot;
    	        var index = parseInt(decodedRoot, 10);
    	        if (!options.parseArrays && decodedRoot === '') {
    	          obj = {
    	            0: leaf
    	          };
    	        } else if (!isNaN(index) && root !== decodedRoot && String(index) === decodedRoot && index >= 0 && options.parseArrays && index <= options.arrayLimit) {
    	          obj = [];
    	          obj[index] = leaf;
    	        } else if (decodedRoot !== '__proto__') {
    	          obj[decodedRoot] = leaf;
    	        }
    	      }
    	      leaf = obj;
    	    }
    	    return leaf;
    	  };
    	  var parseKeys = function parseQueryStringKeys(givenKey, val, options, valuesParsed) {
    	    if (!givenKey) {
    	      return;
    	    }

    	    // Transform dot notation to bracket notation
    	    var key = options.allowDots ? givenKey.replace(/\.([^.[]+)/g, '[$1]') : givenKey;

    	    // The regex chunks

    	    var brackets = /(\[[^[\]]*])/;
    	    var child = /(\[[^[\]]*])/g;

    	    // Get the parent

    	    var segment = options.depth > 0 && brackets.exec(key);
    	    var parent = segment ? key.slice(0, segment.index) : key;

    	    // Stash the parent if it exists

    	    var keys = [];
    	    if (parent) {
    	      // If we aren't using plain objects, optionally prefix keys that would overwrite object prototype properties
    	      if (!options.plainObjects && has.call(Object.prototype, parent)) {
    	        if (!options.allowPrototypes) {
    	          return;
    	        }
    	      }
    	      keys.push(parent);
    	    }

    	    // Loop through children appending to the array until we hit depth

    	    var i = 0;
    	    while (options.depth > 0 && (segment = child.exec(key)) !== null && i < options.depth) {
    	      i += 1;
    	      if (!options.plainObjects && has.call(Object.prototype, segment[1].slice(1, -1))) {
    	        if (!options.allowPrototypes) {
    	          return;
    	        }
    	      }
    	      keys.push(segment[1]);
    	    }

    	    // If there's a remainder, check strictDepth option for throw, else just add whatever is left

    	    if (segment) {
    	      if (options.strictDepth === true) {
    	        throw new RangeError('Input depth exceeded depth option of ' + options.depth + ' and strictDepth is true');
    	      }
    	      keys.push('[' + key.slice(segment.index) + ']');
    	    }
    	    return parseObject(keys, val, options, valuesParsed);
    	  };
    	  var normalizeParseOptions = function normalizeParseOptions(opts) {
    	    if (!opts) {
    	      return defaults;
    	    }
    	    if (typeof opts.allowEmptyArrays !== 'undefined' && typeof opts.allowEmptyArrays !== 'boolean') {
    	      throw new TypeError('`allowEmptyArrays` option can only be `true` or `false`, when provided');
    	    }
    	    if (typeof opts.decodeDotInKeys !== 'undefined' && typeof opts.decodeDotInKeys !== 'boolean') {
    	      throw new TypeError('`decodeDotInKeys` option can only be `true` or `false`, when provided');
    	    }
    	    if (opts.decoder !== null && typeof opts.decoder !== 'undefined' && typeof opts.decoder !== 'function') {
    	      throw new TypeError('Decoder has to be a function.');
    	    }
    	    if (typeof opts.charset !== 'undefined' && opts.charset !== 'utf-8' && opts.charset !== 'iso-8859-1') {
    	      throw new TypeError('The charset option must be either utf-8, iso-8859-1, or undefined');
    	    }
    	    if (typeof opts.throwOnLimitExceeded !== 'undefined' && typeof opts.throwOnLimitExceeded !== 'boolean') {
    	      throw new TypeError('`throwOnLimitExceeded` option must be a boolean');
    	    }
    	    var charset = typeof opts.charset === 'undefined' ? defaults.charset : opts.charset;
    	    var duplicates = typeof opts.duplicates === 'undefined' ? defaults.duplicates : opts.duplicates;
    	    if (duplicates !== 'combine' && duplicates !== 'first' && duplicates !== 'last') {
    	      throw new TypeError('The duplicates option must be either combine, first, or last');
    	    }
    	    var allowDots = typeof opts.allowDots === 'undefined' ? opts.decodeDotInKeys === true ? true : defaults.allowDots : !!opts.allowDots;
    	    return {
    	      allowDots: allowDots,
    	      allowEmptyArrays: typeof opts.allowEmptyArrays === 'boolean' ? !!opts.allowEmptyArrays : defaults.allowEmptyArrays,
    	      allowPrototypes: typeof opts.allowPrototypes === 'boolean' ? opts.allowPrototypes : defaults.allowPrototypes,
    	      allowSparse: typeof opts.allowSparse === 'boolean' ? opts.allowSparse : defaults.allowSparse,
    	      arrayLimit: typeof opts.arrayLimit === 'number' ? opts.arrayLimit : defaults.arrayLimit,
    	      charset: charset,
    	      charsetSentinel: typeof opts.charsetSentinel === 'boolean' ? opts.charsetSentinel : defaults.charsetSentinel,
    	      comma: typeof opts.comma === 'boolean' ? opts.comma : defaults.comma,
    	      decodeDotInKeys: typeof opts.decodeDotInKeys === 'boolean' ? opts.decodeDotInKeys : defaults.decodeDotInKeys,
    	      decoder: typeof opts.decoder === 'function' ? opts.decoder : defaults.decoder,
    	      delimiter: typeof opts.delimiter === 'string' || utils.isRegExp(opts.delimiter) ? opts.delimiter : defaults.delimiter,
    	      // eslint-disable-next-line no-implicit-coercion, no-extra-parens
    	      depth: typeof opts.depth === 'number' || opts.depth === false ? +opts.depth : defaults.depth,
    	      duplicates: duplicates,
    	      ignoreQueryPrefix: opts.ignoreQueryPrefix === true,
    	      interpretNumericEntities: typeof opts.interpretNumericEntities === 'boolean' ? opts.interpretNumericEntities : defaults.interpretNumericEntities,
    	      parameterLimit: typeof opts.parameterLimit === 'number' ? opts.parameterLimit : defaults.parameterLimit,
    	      parseArrays: opts.parseArrays !== false,
    	      plainObjects: typeof opts.plainObjects === 'boolean' ? opts.plainObjects : defaults.plainObjects,
    	      strictDepth: typeof opts.strictDepth === 'boolean' ? !!opts.strictDepth : defaults.strictDepth,
    	      strictNullHandling: typeof opts.strictNullHandling === 'boolean' ? opts.strictNullHandling : defaults.strictNullHandling,
    	      throwOnLimitExceeded: typeof opts.throwOnLimitExceeded === 'boolean' ? opts.throwOnLimitExceeded : false
    	    };
    	  };
    	  var parse$1 = function (str, opts) {
    	    var options = normalizeParseOptions(opts);
    	    if (str === '' || str === null || typeof str === 'undefined') {
    	      return options.plainObjects ? {
    	        __proto__: null
    	      } : {};
    	    }
    	    var tempObj = typeof str === 'string' ? parseValues(str, options) : str;
    	    var obj = options.plainObjects ? {
    	      __proto__: null
    	    } : {};

    	    // Iterate over the keys and setup the new object

    	    var keys = Object.keys(tempObj);
    	    for (var i = 0; i < keys.length; ++i) {
    	      var key = keys[i];
    	      var newObj = parseKeys(key, tempObj[key], options, typeof str === 'string');
    	      obj = utils.merge(obj, newObj, options);
    	    }
    	    if (options.allowSparse === true) {
    	      return obj;
    	    }
    	    return utils.compact(obj);
    	  };
    	  var stringify = stringify_1;
    	  var parse = parse$1;
    	  var formats = formats$3;
    	  var lib = {
    	    formats: formats,
    	    parse: parse,
    	    stringify: stringify
    	  };
    	  var qs = /*@__PURE__*/getDefaultExportFromCjs(lib);
    	  const missingContentType = _ref => {
    	    let {
    	      payload,
    	      headers
    	    } = _ref;
    	    return !!(payload && !(headers === null || headers === void 0 ? void 0 : headers["content-type"]));
    	  };
    	  const getEffectiveContentType = (contentType, headers) => {
    	    const headerContentType = headers === null || headers === void 0 ? void 0 : headers["content-type"];
    	    if (!headerContentType) {
    	      return contentType;
    	    } else if (headerContentType.toLowerCase().includes(ContentType$1.FormUrlEncoded.toLowerCase())) {
    	      return ContentType$1.FormUrlEncoded;
    	    } else if (headerContentType.toLowerCase().includes(ContentType$1.Json.toLowerCase())) {
    	      return ContentType$1.Json;
    	    } else {
    	      return undefined;
    	    }
    	  };
    	  const stringifyPayload = _ref2 => {
    	    let {
    	      payload,
    	      contentType
    	    } = _ref2;
    	    if (contentType === ContentType$1.FormUrlEncoded) {
    	      return qs.stringify(payload);
    	    } else if (contentType === ContentType$1.Json) {
    	      return JSON.stringify(payload);
    	    } else {
    	      return payload;
    	    }
    	  };
    	  const objectFromEntries = entries => [...entries].reduce((map, _ref3) => {
    	    let [key, value] = _ref3;
    	    map[key] = value;
    	    return map;
    	  }, {});
    	  const updateLocale = _ref4 => {
    	    let {
    	      responseHeaders,
    	      localeHeader,
    	      currentLocale,
    	      setLocale
    	    } = _ref4;
    	    const targetHeader = localeHeader.toLowerCase();
    	    const newLocaleKey = Object.keys(responseHeaders).find(key => key.toLowerCase() === targetHeader);
    	    const newLocale = newLocaleKey ? responseHeaders[newLocaleKey] : undefined;
    	    if (newLocale && currentLocale && newLocale !== currentLocale) {
    	      setLocale === null || setLocale === void 0 ? void 0 : setLocale(newLocale);
    	    }
    	  };
    	  const replaceNativeRequestProtocol = url => {
    	    return url === null || url === void 0 ? void 0 : url.replace("outsystems://", "https://");
    	  };
    	  const tryParseResponse = (responseText, logger, loggerCategory) => {
    	    var _a;
    	    let parsedResponse = undefined;
    	    try {
    	      if (responseText) {
    	        parsedResponse = JSON.parse(responseText);
    	      }
    	    } catch (e) {
    	      (_a = logger === null || logger === void 0 ? void 0 : logger.clientError) === null || _a === void 0 ? void 0 : _a.call(logger, {
    	        error: e,
    	        category: loggerCategory,
    	        clientMessage: `Could not parse response: ${responseText}`,
    	        internalMessage: `Could not parse response.`
    	      });
    	    }
    	    return parsedResponse;
    	  };
    	  const appendQueryStringParams = (url, params) => {
    	    if (!params) {
    	      return url;
    	    }
    	    const queryString = qs.stringify(params);
    	    if (queryString) {
    	      const separator = url.includes("?") ? "&" : "?";
    	      return `${url}${separator}${queryString}`;
    	    }
    	    return url;
    	  };
    	  function getGlobalScope() {
    	    if (typeof window !== "undefined") {
    	      return window;
    	    }
    	    if (typeof commonjsGlobal !== "undefined") {
    	      return commonjsGlobal;
    	    }
    	    if (typeof globalThis !== "undefined") {
    	      return globalThis;
    	    }
    	    if (typeof self !== "undefined") {
    	      return self;
    	    }
    	    throw new Error("unable to locate global object");
    	  }
    	  function doWithSpan(logger, name, action) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      if (logger === null || logger === void 0 ? void 0 : logger.startActiveClientSpan) {
    	        return logger.startActiveClientSpan(name, span => __awaiter(this, void 0, void 0, function* () {
    	          try {
    	            return yield action();
    	          } finally {
    	            span === null || span === void 0 ? void 0 : span.end();
    	          }
    	        }));
    	      } else {
    	        return action();
    	      }
    	    });
    	  }
    	  const AUTH_RETRY_HEADER = "os-auth-retry";
    	  const injectAuthInterceptors = _ref5 => {
    	    let {
    	      fetchClient,
    	      getToken,
    	      retryOnUnauthorizedResponse = true
    	    } = _ref5;
    	    let result = fetchClient;
    	    if (getToken) {
    	      result = (input, init) => __awaiter(void 0, void 0, void 0, function* () {
    	        yield setAccessTokenInRequestHeaders({
    	          config: init,
    	          getToken
    	        });
    	        let response = yield fetchClient(input, init);
    	        if (retryOnUnauthorizedResponse) {
    	          if (!response.ok) {
    	            response = yield retryOnUnauthorized({
    	              response,
    	              fetchClient,
    	              config: Object.assign({}, init),
    	              getToken
    	            });
    	          }
    	        }
    	        return response;
    	      });
    	    }
    	    return result;
    	  };
    	  const setAccessTokenInRequestHeaders = _a => __awaiter(void 0, [_a], void 0, function (_ref6) {
    	    let {
    	      config = {},
    	      getToken
    	    } = _ref6;
    	    return function* () {
    	      var _b;
    	      const token = yield getToken();
    	      if (token) {
    	        config.headers = Object.assign(Object.assign({}, (_b = config.headers) !== null && _b !== void 0 ? _b : {}), {
    	          Authorization: token
    	        });
    	      }
    	      return config;
    	    }();
    	  });
    	  const retryOnUnauthorized = _a => __awaiter(void 0, [_a], void 0, function (_ref7) {
    	    let {
    	      response,
    	      fetchClient,
    	      config = {},
    	      getToken
    	    } = _ref7;
    	    return function* () {
    	      var _b;
    	      if (response.status !== 401 || response.headers.get(AUTH_RETRY_HEADER) === "true") {
    	        return response;
    	      }
    	      const token = yield getToken(true);
    	      if (token) {
    	        config.headers = Object.assign(Object.assign({}, (_b = config.headers) !== null && _b !== void 0 ? _b : {}), {
    	          Authorization: token,
    	          [AUTH_RETRY_HEADER]: "true"
    	        });
    	        return fetchClient(response.url, config);
    	      }
    	      return response;
    	    }();
    	  });
    	  var _a, _b;
    	  var _FetchHttpClient_instances, _FetchHttpClient_fetchClient, _FetchHttpClient_baseUrl, _FetchHttpClient_headers, _FetchHttpClient_localeHeader, _FetchHttpClient_getLocale, _FetchHttpClient_setLocale, _FetchHttpClient_loadTrace, _FetchHttpClient_logger, _FetchHttpClient_composeUrl, _FetchHttpClient_handleFetchTimeout, _FetchHttpClient_getResponse, _FetchHttpClient_updateLocale, _FetchHttpClient_parseError, _FetchHttpClient_processFetchError, _FetchHttpClient_processResponseError, _FetchHttpClient_parseResponseData, _FetchHttpClient_buildHeaders, _FetchHttpClient_insertTraceHeaders;
    	  const BASE_URL$1 = "";
    	  const DEFAULT_TIMEOUT = 10000;
    	  const LOCALE_HEADER$2 = "";
    	  const LOG_CATEGORY$3 = "FetchHttpClient";
    	  const readResponseJson = response => __awaiter(void 0, void 0, void 0, function* () {
    	    const textData = yield response.text();
    	    return textData === "" ? undefined : JSON.parse(textData);
    	  });
    	  (_a = AbortSignal.timeout) !== null && _a !== void 0 ? _a : AbortSignal.timeout = function timeout(ms) {
    	    const ctrl = new AbortController();
    	    setTimeout(() => ctrl.abort(), ms);
    	    return ctrl.signal;
    	  };
    	  (_b = AbortSignal.any) !== null && _b !== void 0 ? _b : AbortSignal.any = function any(iterable) {
    	    const controller = new AbortController();
    	    function abort() {
    	      controller.abort();
    	      clean();
    	    }
    	    function clean() {
    	      for (const signal of iterable) signal.removeEventListener("abort", abort);
    	    }
    	    for (const signal of iterable) if (signal.aborted) {
    	      controller.abort(signal.reason);
    	      break;
    	    } else signal.addEventListener("abort", abort);
    	    return controller.signal;
    	  };
    	  let FetchHttpClient$1 = _exports.HttpClient = _exports.FetchHttpClient = class FetchHttpClient {
    	    constructor() {
    	      let {
    	        baseUrl = BASE_URL$1,
    	        headers = {},
    	        localeHeader = LOCALE_HEADER$2,
    	        getLocale,
    	        setLocale,
    	        fetchClient = getGlobalScope().fetch,
    	        logger,
    	        loadTrace,
    	        getToken = () => Promise.resolve(undefined)
    	      } = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : {};
    	      _FetchHttpClient_instances.add(this);
    	      _FetchHttpClient_fetchClient.set(this, void 0);
    	      _FetchHttpClient_baseUrl.set(this, void 0);
    	      _FetchHttpClient_headers.set(this, void 0);
    	      _FetchHttpClient_localeHeader.set(this, void 0);
    	      _FetchHttpClient_getLocale.set(this, void 0);
    	      _FetchHttpClient_setLocale.set(this, void 0);
    	      _FetchHttpClient_loadTrace.set(this, void 0);
    	      _FetchHttpClient_logger.set(this, void 0);
    	      __classPrivateFieldSet(this, _FetchHttpClient_baseUrl, baseUrl);
    	      __classPrivateFieldSet(this, _FetchHttpClient_headers, headers);
    	      __classPrivateFieldSet(this, _FetchHttpClient_localeHeader, localeHeader);
    	      __classPrivateFieldSet(this, _FetchHttpClient_getLocale, getLocale);
    	      __classPrivateFieldSet(this, _FetchHttpClient_setLocale, setLocale);
    	      __classPrivateFieldSet(this, _FetchHttpClient_logger, logger);
    	      __classPrivateFieldSet(this, _FetchHttpClient_loadTrace, loadTrace);
    	      __classPrivateFieldSet(this, _FetchHttpClient_fetchClient, this.addAuthInterceptors(fetchClient, getToken));
    	    }
    	    addAuthInterceptors(fetchClient, getToken) {
    	      return injectAuthInterceptors({
    	        fetchClient,
    	        getToken
    	      });
    	    }
    	    post(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref8) {
    	        var _this = this;
    	        let {
    	          url,
    	          payload,
    	          params,
    	          headers,
    	          contentType = ContentType$1.FormUrlEncoded,
    	          timeout,
    	          timeoutHandler,
    	          useLocaleInfo = false,
    	          baseURL,
    	          abortCommand,
    	          userCancelController = new AbortController(),
    	          responseHandler
    	        } = _ref8;
    	        return function* () {
    	          var _b, _c, _d, _e, _f, _g, _h;
    	          (_c = (_b = __classPrivateFieldGet(_this, _FetchHttpClient_logger, "f")) === null || _b === void 0 ? void 0 : _b.setActiveSpanAsNonAggregable) === null || _c === void 0 ? void 0 : _c.call(_b);
    	          const locale = useLocaleInfo ? (_d = __classPrivateFieldGet(_this, _FetchHttpClient_getLocale, "f")) === null || _d === void 0 ? void 0 : _d.call(_this) : undefined;
    	          const [fullUrl, urlForLogging] = __classPrivateFieldGet(_this, _FetchHttpClient_instances, "m", _FetchHttpClient_composeUrl).call(_this, url, baseURL, params);
    	          if (abortCommand) {
    	            abortCommand.onAbort = () => {
    	              userCancelController.abort();
    	            };
    	          }
    	          try {
    	            (_f = (_e = __classPrivateFieldGet(_this, _FetchHttpClient_logger, "f")) === null || _e === void 0 ? void 0 : _e.debug) === null || _f === void 0 ? void 0 : _f.call(_e, {
    	              category: LOG_CATEGORY$3,
    	              message: `POST ${urlForLogging}`
    	            });
    	            const effectiveContentType = getEffectiveContentType(contentType, headers);
    	            const requestInit = {
    	              body: payload ? stringifyPayload({
    	                payload,
    	                contentType: effectiveContentType
    	              }) : undefined,
    	              headers: yield __classPrivateFieldGet(_this, _FetchHttpClient_instances, "m", _FetchHttpClient_buildHeaders).call(_this, headers, locale, missingContentType({
    	                payload,
    	                headers
    	              }) ? contentType : undefined),
    	              method: "POST",
    	              signal: AbortSignal.any([userCancelController.signal, AbortSignal.timeout(timeout ? timeout * 1000 : DEFAULT_TIMEOUT)])
    	            };
    	            const fetch = () => __awaiter(_this, void 0, void 0, function* () {
    	              return __classPrivateFieldGet(this, _FetchHttpClient_fetchClient, "f").call(this, fullUrl, requestInit);
    	            });
    	            const response = yield doWithSpan(__classPrivateFieldGet(_this, _FetchHttpClient_logger, "f"), "POST", fetch);
    	            if (!response.ok) {
    	              throw yield __classPrivateFieldGet(_this, _FetchHttpClient_instances, "m", _FetchHttpClient_processResponseError).call(_this, response, url, "POST", timeoutHandler, userCancelController);
    	            }
    	            const data = yield readResponseJson(response);
    	            __classPrivateFieldGet(_this, _FetchHttpClient_instances, "m", _FetchHttpClient_updateLocale).call(_this, response, useLocaleInfo, locale);
    	            if (typeof responseHandler === "function") {
    	              try {
    	                const responseHeaders = {};
    	                response.headers.forEach((value, key) => responseHeaders[key] = value);
    	                responseHandler({
    	                  data,
    	                  responseHeaders
    	                });
    	              } catch (e) {
    	                (_h = (_g = __classPrivateFieldGet(_this, _FetchHttpClient_logger, "f")) === null || _g === void 0 ? void 0 : _g.error) === null || _h === void 0 ? void 0 : _h.call(_g, {
    	                  category: LOG_CATEGORY$3,
    	                  message: `Handler Error: POST ${urlForLogging}`,
    	                  errorCode: ErrorCodes.Communication_Default,
    	                  error: e
    	                });
    	              }
    	            }
    	            return data;
    	          } catch (error) {
    	            throw error instanceof CommunicationError ? error : yield __classPrivateFieldGet(_this, _FetchHttpClient_instances, "m", _FetchHttpClient_processFetchError).call(_this, error, url, "POST", timeoutHandler);
    	          }
    	        }();
    	      });
    	    }
    	    get(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref9) {
    	        var _this2 = this;
    	        let {
    	          url,
    	          params,
    	          headers,
    	          useLocaleInfo,
    	          timeout,
    	          timeoutHandler,
    	          responseType = "json",
    	          baseURL
    	        } = _ref9;
    	        return function* () {
    	          const response = yield __classPrivateFieldGet(_this2, _FetchHttpClient_instances, "m", _FetchHttpClient_getResponse).call(_this2, {
    	            url,
    	            params,
    	            headers,
    	            useLocaleInfo,
    	            timeout,
    	            timeoutHandler,
    	            baseURL
    	          });
    	          try {
    	            if (responseType === "blob") {
    	              return yield response.blob();
    	            } else if (responseType === "json") {
    	              return yield readResponseJson(response);
    	            } else {
    	              return Promise.resolve();
    	            }
    	          } catch (error) {
    	            throw error instanceof CommunicationError ? error : yield __classPrivateFieldGet(_this2, _FetchHttpClient_instances, "m", _FetchHttpClient_processFetchError).call(_this2, error, url, "GET", timeoutHandler);
    	          }
    	        }();
    	      });
    	    }
    	    getResponseUrl(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref0) {
    	        var _this3 = this;
    	        let {
    	          url,
    	          params,
    	          headers,
    	          useLocaleInfo,
    	          timeout,
    	          timeoutHandler,
    	          baseURL
    	        } = _ref0;
    	        return function* () {
    	          const response = yield __classPrivateFieldGet(_this3, _FetchHttpClient_instances, "m", _FetchHttpClient_getResponse).call(_this3, {
    	            url,
    	            params,
    	            headers,
    	            useLocaleInfo,
    	            timeout,
    	            timeoutHandler,
    	            baseURL
    	          });
    	          return response.url;
    	        }();
    	      });
    	    }
    	  };
    	  _FetchHttpClient_fetchClient = new WeakMap(), _FetchHttpClient_baseUrl = new WeakMap(), _FetchHttpClient_headers = new WeakMap(), _FetchHttpClient_localeHeader = new WeakMap(), _FetchHttpClient_getLocale = new WeakMap(), _FetchHttpClient_setLocale = new WeakMap(), _FetchHttpClient_loadTrace = new WeakMap(), _FetchHttpClient_logger = new WeakMap(), _FetchHttpClient_instances = new WeakSet(), _FetchHttpClient_composeUrl = function _FetchHttpClient_composeUrl(url, baseURL, params) {
    	    var _a;
    	    const finalUrl = (_a = replaceNativeRequestProtocol(url)) !== null && _a !== void 0 ? _a : "";
    	    const finalBaseURL = replaceNativeRequestProtocol(baseURL || __classPrivateFieldGet(this, _FetchHttpClient_baseUrl, "f"));
    	    const parsedUrl = finalBaseURL && !url.includes("://") ? `${finalBaseURL.replace(/\/$/, "")}/${url.replace(/^\/+/, "")}` : finalUrl;
    	    return [appendQueryStringParams(parsedUrl, params), finalUrl];
    	  }, _FetchHttpClient_handleFetchTimeout = function _FetchHttpClient_handleFetchTimeout(error, timeoutHandler) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      if (error === RequestError$1.Timeout && timeoutHandler) {
    	        yield timeoutHandler();
    	      }
    	    });
    	  }, _FetchHttpClient_getResponse = function _FetchHttpClient_getResponse(_a) {
    	    return __awaiter(this, arguments, void 0, function (_ref1) {
    	      var _this4 = this;
    	      let {
    	        url,
    	        params,
    	        headers,
    	        useLocaleInfo = false,
    	        timeout,
    	        timeoutHandler,
    	        baseURL
    	      } = _ref1;
    	      return function* () {
    	        var _b, _c, _d, _e, _f;
    	        (_c = (_b = __classPrivateFieldGet(_this4, _FetchHttpClient_logger, "f")) === null || _b === void 0 ? void 0 : _b.setActiveSpanAsNonAggregable) === null || _c === void 0 ? void 0 : _c.call(_b);
    	        const locale = useLocaleInfo ? (_d = __classPrivateFieldGet(_this4, _FetchHttpClient_getLocale, "f")) === null || _d === void 0 ? void 0 : _d.call(_this4) : undefined;
    	        const [fullUrl, urlForLogging] = __classPrivateFieldGet(_this4, _FetchHttpClient_instances, "m", _FetchHttpClient_composeUrl).call(_this4, url, baseURL, params);
    	        try {
    	          (_f = (_e = __classPrivateFieldGet(_this4, _FetchHttpClient_logger, "f")) === null || _e === void 0 ? void 0 : _e.debug) === null || _f === void 0 ? void 0 : _f.call(_e, {
    	            category: LOG_CATEGORY$3,
    	            message: `GET ${urlForLogging}`
    	          });
    	          const requestInit = {
    	            headers: yield __classPrivateFieldGet(_this4, _FetchHttpClient_instances, "m", _FetchHttpClient_buildHeaders).call(_this4, headers, locale),
    	            signal: AbortSignal.timeout(timeout ? timeout * 1000 : DEFAULT_TIMEOUT)
    	          };
    	          const fetch = () => __awaiter(_this4, void 0, void 0, function* () {
    	            return __classPrivateFieldGet(this, _FetchHttpClient_fetchClient, "f").call(this, fullUrl, requestInit);
    	          });
    	          const response = yield doWithSpan(__classPrivateFieldGet(_this4, _FetchHttpClient_logger, "f"), "GET", fetch);
    	          if (!response.ok) {
    	            throw yield __classPrivateFieldGet(_this4, _FetchHttpClient_instances, "m", _FetchHttpClient_processResponseError).call(_this4, response, url, "GET", timeoutHandler);
    	          }
    	          __classPrivateFieldGet(_this4, _FetchHttpClient_instances, "m", _FetchHttpClient_updateLocale).call(_this4, response, useLocaleInfo, locale);
    	          return response;
    	        } catch (error) {
    	          throw error instanceof CommunicationError ? error : yield __classPrivateFieldGet(_this4, _FetchHttpClient_instances, "m", _FetchHttpClient_processFetchError).call(_this4, error, url, "GET", timeoutHandler);
    	        }
    	      }();
    	    });
    	  }, _FetchHttpClient_updateLocale = function _FetchHttpClient_updateLocale(response, useLocaleInfo, locale) {
    	    if (useLocaleInfo && __classPrivateFieldGet(this, _FetchHttpClient_setLocale, "f") && (response === null || response === void 0 ? void 0 : response.headers)) {
    	      updateLocale({
    	        responseHeaders: objectFromEntries(response.headers.entries()),
    	        localeHeader: __classPrivateFieldGet(this, _FetchHttpClient_localeHeader, "f"),
    	        currentLocale: locale,
    	        setLocale: __classPrivateFieldGet(this, _FetchHttpClient_setLocale, "f")
    	      });
    	    }
    	  }, _FetchHttpClient_parseError = function _FetchHttpClient_parseError(error, userCancelController, status) {
    	    if ((error === null || error === void 0 ? void 0 : error.name) === "TimeoutError" || (error === null || error === void 0 ? void 0 : error.name) === "AbortError" && !(userCancelController === null || userCancelController === void 0 ? void 0 : userCancelController.signal.aborted) || status === 408) {
    	      return RequestError$1.Timeout;
    	    }
    	    if (status === 401) {
    	      return RequestError$1.Unauthorized;
    	    }
    	    if ((error === null || error === void 0 ? void 0 : error.name) === "AbortError" && (userCancelController === null || userCancelController === void 0 ? void 0 : userCancelController.signal.aborted) === true) {
    	      return RequestError$1.Aborted;
    	    }
    	    return RequestError$1.Unknown;
    	  }, _FetchHttpClient_processFetchError = function _FetchHttpClient_processFetchError(error, url, method, timeoutHandler) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      var _a, _b;
    	      const reqError = __classPrivateFieldGet(this, _FetchHttpClient_instances, "m", _FetchHttpClient_parseError).call(this, error);
    	      yield __classPrivateFieldGet(this, _FetchHttpClient_instances, "m", _FetchHttpClient_handleFetchTimeout).call(this, reqError, timeoutHandler);
    	      let errorCode = ErrorCodes.Communication_Default;
    	      if (reqError === RequestError$1.Timeout) {
    	        errorCode = ErrorCodes.Communication_Timeout;
    	      } else if (reqError === RequestError$1.Unauthorized) {
    	        errorCode = ErrorCodes.Communication_Unauthorized;
    	      } else if (reqError === RequestError$1.Aborted) {
    	        errorCode = ErrorCodes.Communication_Aborted;
    	      }
    	      (_b = (_a = __classPrivateFieldGet(this, _FetchHttpClient_logger, "f")) === null || _a === void 0 ? void 0 : _a.error) === null || _b === void 0 ? void 0 : _b.call(_a, {
    	        category: LOG_CATEGORY$3,
    	        message: `${method} ${url} - ${error.message}`,
    	        errorCode,
    	        error
    	      });
    	      return new CommunicationError(`${method} ${url} - ${error.message}`, errorCode, undefined, undefined, LOG_CATEGORY$3);
    	    });
    	  }, _FetchHttpClient_processResponseError = function _FetchHttpClient_processResponseError(response, url, method, timeoutHandler, userCancelController) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      var _a, _b, _c;
    	      const reqError = __classPrivateFieldGet(this, _FetchHttpClient_instances, "m", _FetchHttpClient_parseError).call(this, undefined, userCancelController, response.status);
    	      yield __classPrivateFieldGet(this, _FetchHttpClient_instances, "m", _FetchHttpClient_handleFetchTimeout).call(this, reqError, timeoutHandler);
    	      const errorCode = mapErrorCodeFromStatusCode((_a = response.status) !== null && _a !== void 0 ? _a : "");
    	      const responseData = yield __classPrivateFieldGet(this, _FetchHttpClient_instances, "m", _FetchHttpClient_parseResponseData).call(this, response);
    	      (_c = (_b = __classPrivateFieldGet(this, _FetchHttpClient_logger, "f")) === null || _b === void 0 ? void 0 : _b.error) === null || _c === void 0 ? void 0 : _c.call(_b, {
    	        category: LOG_CATEGORY$3,
    	        message: `${method} ${url} - ${response.status} ${response.statusText}`,
    	        errorCode,
    	        error: new Error(`Fetch ${method} Error - ${response.status} ${response.statusText}`)
    	      });
    	      return new CommunicationError(`${method} ${url} - ${response.status} ${response.statusText}`, errorCode, response.status, responseData, LOG_CATEGORY$3);
    	    });
    	  }, _FetchHttpClient_parseResponseData = function _FetchHttpClient_parseResponseData(response) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      try {
    	        const jsonContentType = /application\/.*json/i;
    	        const contentType = response.headers.get("content-type");
    	        if (contentType && jsonContentType.test(contentType)) {
    	          return yield response.json();
    	        } else {
    	          return yield response.text();
    	        }
    	      } catch (e) {
    	        return undefined;
    	      }
    	    });
    	  }, _FetchHttpClient_buildHeaders = function _FetchHttpClient_buildHeaders(headers, locale) {
    	    let contentType = arguments.length > 2 && arguments[2] !== undefined ? arguments[2] : undefined;
    	    var _a;
    	    const reqHeaders = Object.assign(Object.assign(Object.assign(Object.assign({}, __classPrivateFieldGet(this, _FetchHttpClient_headers, "f")), headers), locale ? {
    	      [__classPrivateFieldGet(this, _FetchHttpClient_localeHeader, "f")]: locale
    	    } : {}), (headers === null || headers === void 0 ? void 0 : headers["content-type"]) || contentType ? {
    	      ["content-type"]: (_a = headers === null || headers === void 0 ? void 0 : headers["content-type"]) !== null && _a !== void 0 ? _a : contentType
    	    } : {});
    	    if (contentType) {
    	      reqHeaders["content-type"] = contentType;
    	    }
    	    return __classPrivateFieldGet(this, _FetchHttpClient_instances, "m", _FetchHttpClient_insertTraceHeaders).call(this, reqHeaders);
    	  }, _FetchHttpClient_insertTraceHeaders = function _FetchHttpClient_insertTraceHeaders(headers) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      var _a, _b;
    	      try {
    	        return yield addTraceHeaders(headers, () => {
    	          var _a;
    	          return (_a = __classPrivateFieldGet(this, _FetchHttpClient_loadTrace, "f")) === null || _a === void 0 ? void 0 : _a.call(this);
    	        });
    	      } catch (e) {
    	        (_b = (_a = __classPrivateFieldGet(this, _FetchHttpClient_logger, "f")) === null || _a === void 0 ? void 0 : _a.error) === null || _b === void 0 ? void 0 : _b.call(_a, {
    	          category: LOG_CATEGORY$3,
    	          message: `Error loading trace information`,
    	          errorCode: ErrorCodes.Communication_Default,
    	          error: e
    	        });
    	      }
    	      return headers;
    	    });
    	  };
    	  class LoggerHttpClient extends FetchHttpClient$1 {
    	    addAuthInterceptors(fetchClient, getToken) {
    	      return injectAuthInterceptors({
    	        fetchClient,
    	        getToken,
    	        retryOnUnauthorizedResponse: false
    	      });
    	    }
    	  }
    	  _exports.LoggerHttpClient = LoggerHttpClient;
    	  const buildUrl = (url, baseURL, params) => {
    	    try {
    	      return buildAbsoluteUrl(url, baseURL, params);
    	    } catch (_a) {
    	      return buildRelativeUrl(url, baseURL, params);
    	    }
    	  };
    	  const isUrlValid = url => {
    	    try {
    	      new URL(url);
    	      return true;
    	    } catch (_a) {
    	      return false;
    	    }
    	  };
    	  const buildAbsoluteUrl = (url, baseURL, params) => {
    	    const requestUrl = isUrlValid(baseURL !== null && baseURL !== void 0 ? baseURL : "") ? new URL(url, baseURL) : new URL(url);
    	    Object.entries(params !== null && params !== void 0 ? params : {}).forEach(_ref10 => {
    	      let [key, value] = _ref10;
    	      requestUrl.searchParams.append(key, value !== null && value !== void 0 ? value : "");
    	    });
    	    return requestUrl.toString();
    	  };
    	  const buildRelativeUrl = (url, baseURL, params) => {
    	    const finalUrl = `${baseURL ? baseURL : ""}/${url}${params ? "?" : ""}`;
    	    let queryParams = "";
    	    Object.entries(params !== null && params !== void 0 ? params : {}).forEach(_ref11 => {
    	      let [key, value] = _ref11;
    	      queryParams += `${queryParams ? "&" : ""}${key}=${encodeURIComponent(value)}`;
    	    });
    	    return `${finalUrl}${queryParams}`.replace(/\/+/g, "/");
    	  };
    	  var _NativeHttpClient_instances, _NativeHttpClient_localeHeader, _NativeHttpClient_getLocale, _NativeHttpClient_setLocale, _NativeHttpClient_logger, _NativeHttpClient_getToken, _NativeHttpClient_loadTrace, _NativeHttpClient_baseUrl, _NativeHttpClient_headers, _NativeHttpClient_onErrorHandler, _NativeHttpClient_executeRequest, _NativeHttpClient_buildHeaders, _NativeHttpClient_insertTraceHeaders;
    	  const BASE_URL = "";
    	  const LOG_CATEGORY$2 = "NativeHttpClient";
    	  const LOCALE_HEADER$1 = "";
    	  class NativeHttpClient {
    	    constructor(_ref12) {
    	      let {
    	        baseUrl = BASE_URL,
    	        headers = {},
    	        localeHeader = LOCALE_HEADER$1,
    	        getLocale,
    	        setLocale,
    	        httpClientInstance,
    	        logger,
    	        loadTrace,
    	        getToken
    	      } = _ref12;
    	      _NativeHttpClient_instances.add(this);
    	      _NativeHttpClient_localeHeader.set(this, void 0);
    	      _NativeHttpClient_getLocale.set(this, void 0);
    	      _NativeHttpClient_setLocale.set(this, void 0);
    	      _NativeHttpClient_logger.set(this, void 0);
    	      _NativeHttpClient_getToken.set(this, void 0);
    	      _NativeHttpClient_loadTrace.set(this, void 0);
    	      _NativeHttpClient_baseUrl.set(this, void 0);
    	      _NativeHttpClient_headers.set(this, void 0);
    	      __classPrivateFieldSet(this, _NativeHttpClient_localeHeader, localeHeader);
    	      __classPrivateFieldSet(this, _NativeHttpClient_getLocale, getLocale);
    	      __classPrivateFieldSet(this, _NativeHttpClient_setLocale, setLocale);
    	      __classPrivateFieldSet(this, _NativeHttpClient_logger, logger);
    	      this.httpClientInstance = httpClientInstance;
    	      __classPrivateFieldSet(this, _NativeHttpClient_baseUrl, baseUrl);
    	      __classPrivateFieldSet(this, _NativeHttpClient_headers, headers);
    	      __classPrivateFieldSet(this, _NativeHttpClient_loadTrace, loadTrace);
    	      __classPrivateFieldSet(this, _NativeHttpClient_getToken, getToken !== null && getToken !== void 0 ? getToken : () => Promise.resolve(undefined));
    	    }
    	    post(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref13) {
    	        var _this5 = this;
    	        let {
    	          url,
    	          payload,
    	          params,
    	          headers,
    	          contentType = ContentType$1.FormUrlEncoded,
    	          timeout,
    	          timeoutHandler,
    	          useLocaleInfo,
    	          baseURL,
    	          abortCommand,
    	          responseHandler
    	        } = _ref13;
    	        return function* () {
    	          var _b, _c, _d;
    	          const reqPayload = stringifyPayload({
    	            payload,
    	            contentType
    	          });
    	          const fetch = () => __classPrivateFieldGet(_this5, _NativeHttpClient_instances, "m", _NativeHttpClient_executeRequest).call(_this5, {
    	            method: "POST",
    	            url,
    	            params,
    	            baseURL,
    	            headers,
    	            timeout,
    	            timeoutHandler,
    	            useLocaleInfo,
    	            contentType,
    	            payload: reqPayload,
    	            abortControler: abortCommand
    	          });
    	          const response = yield doWithSpan(__classPrivateFieldGet(_this5, _NativeHttpClient_logger, "f"), "POST", fetch);
    	          const data = tryParseResponse(response.responseText, __classPrivateFieldGet(_this5, _NativeHttpClient_logger, "f"), LOG_CATEGORY$2);
    	          if (typeof responseHandler === "function") {
    	            try {
    	              responseHandler({
    	                data,
    	                responseHeaders: (_b = response.responseHeaders) !== null && _b !== void 0 ? _b : {}
    	              });
    	            } catch (e) {
    	              (_d = (_c = __classPrivateFieldGet(_this5, _NativeHttpClient_logger, "f")) === null || _c === void 0 ? void 0 : _c.error) === null || _d === void 0 ? void 0 : _d.call(_c, {
    	                category: LOG_CATEGORY$2,
    	                message: `Handler Error: Post ${response.responseUrl}`,
    	                errorCode: ErrorCodes.Communication_Default,
    	                error: e
    	              });
    	            }
    	          }
    	          return data;
    	        }();
    	      });
    	    }
    	    get(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref14) {
    	        var _this6 = this;
    	        let {
    	          url,
    	          params,
    	          headers,
    	          responseType = "json",
    	          useLocaleInfo,
    	          timeout,
    	          timeoutHandler,
    	          baseURL
    	        } = _ref14;
    	        return function* () {
    	          const isBlobResponse = responseType === "blob";
    	          const fetch = () => __classPrivateFieldGet(_this6, _NativeHttpClient_instances, "m", _NativeHttpClient_executeRequest).call(_this6, {
    	            method: "GET",
    	            url,
    	            params,
    	            baseURL,
    	            headers,
    	            timeout,
    	            timeoutHandler,
    	            useLocaleInfo,
    	            responseType: isBlobResponse ? "blob" : undefined
    	          });
    	          const response = yield doWithSpan(__classPrivateFieldGet(_this6, _NativeHttpClient_logger, "f"), "GET", fetch);
    	          if (isBlobResponse) {
    	            return response.response;
    	          }
    	          return responseType !== "none" ? tryParseResponse(response.responseText, __classPrivateFieldGet(_this6, _NativeHttpClient_logger, "f"), LOG_CATEGORY$2) : undefined;
    	        }();
    	      });
    	    }
    	    getResponseUrl(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref15) {
    	        var _this7 = this;
    	        let {
    	          url,
    	          params,
    	          headers,
    	          useLocaleInfo,
    	          timeout,
    	          timeoutHandler,
    	          baseURL
    	        } = _ref15;
    	        return function* () {
    	          var _b, _c;
    	          const fetch = () => __classPrivateFieldGet(_this7, _NativeHttpClient_instances, "m", _NativeHttpClient_executeRequest).call(_this7, {
    	            method: "GET",
    	            url,
    	            params,
    	            baseURL,
    	            headers,
    	            timeout,
    	            timeoutHandler,
    	            useLocaleInfo
    	          });
    	          const response = yield doWithSpan(__classPrivateFieldGet(_this7, _NativeHttpClient_logger, "f"), "GET", fetch);
    	          if (!response.responseUrl) {
    	            const error = new Error("Successful request came without a response URL");
    	            (_c = (_b = __classPrivateFieldGet(_this7, _NativeHttpClient_logger, "f")) === null || _b === void 0 ? void 0 : _b.error) === null || _c === void 0 ? void 0 : _c.call(_b, {
    	              error,
    	              category: LOG_CATEGORY$2,
    	              message: "Successful request came without a response URL",
    	              errorCode: ErrorCodes.Communication_Default
    	            });
    	            throw error;
    	          }
    	          return response.responseUrl;
    	        }();
    	      });
    	    }
    	  }
    	  _exports.NativeHttpClient = NativeHttpClient;
    	  _NativeHttpClient_localeHeader = new WeakMap(), _NativeHttpClient_getLocale = new WeakMap(), _NativeHttpClient_setLocale = new WeakMap(), _NativeHttpClient_logger = new WeakMap(), _NativeHttpClient_getToken = new WeakMap(), _NativeHttpClient_loadTrace = new WeakMap(), _NativeHttpClient_baseUrl = new WeakMap(), _NativeHttpClient_headers = new WeakMap(), _NativeHttpClient_instances = new WeakSet(), _NativeHttpClient_onErrorHandler = function _NativeHttpClient_onErrorHandler(method, request, isRetry, requestUrl, retry) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      var _a, _b, _c, _d, _e, _f, _g, _h;
    	      if (request.status === 401 && !isRetry) {
    	        const token = yield __classPrivateFieldGet(this, _NativeHttpClient_getToken, "f").call(this, true);
    	        if (token) {
    	          return retry();
    	        } else {
    	          const error = new Error("Unable to retrieve an authorization token");
    	          (_b = (_a = __classPrivateFieldGet(this, _NativeHttpClient_logger, "f")) === null || _a === void 0 ? void 0 : _a.error) === null || _b === void 0 ? void 0 : _b.call(_a, {
    	            error,
    	            category: LOG_CATEGORY$2,
    	            message: `${method} ${requestUrl}`,
    	            errorCode: ErrorCodes.Communication_Unauthorized
    	          });
    	          throw error;
    	        }
    	      } else {
    	        const status = (_e = (_d = (_c = request.status) === null || _c === void 0 ? void 0 : _c.toString) === null || _d === void 0 ? void 0 : _d.call(_c)) !== null && _e !== void 0 ? _e : "";
    	        const errorCode = mapErrorCodeFromStatusCode(status);
    	        const error = new CommunicationError((_f = request.responseText) !== null && _f !== void 0 ? _f : "Network Error", errorCode, status, tryParseResponse(request.responseText, __classPrivateFieldGet(this, _NativeHttpClient_logger, "f"), LOG_CATEGORY$2), LOG_CATEGORY$2);
    	        (_h = (_g = __classPrivateFieldGet(this, _NativeHttpClient_logger, "f")) === null || _g === void 0 ? void 0 : _g.error) === null || _h === void 0 ? void 0 : _h.call(_g, {
    	          error,
    	          category: LOG_CATEGORY$2,
    	          message: `${method} ${requestUrl}`,
    	          errorCode
    	        });
    	        throw error;
    	      }
    	    });
    	  }, _NativeHttpClient_executeRequest = function _NativeHttpClient_executeRequest(requestOptions) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      var _a, _b, _c;
    	      (_b = (_a = __classPrivateFieldGet(this, _NativeHttpClient_logger, "f")) === null || _a === void 0 ? void 0 : _a.setActiveSpanAsNonAggregable) === null || _b === void 0 ? void 0 : _b.call(_a);
    	      const {
    	        method,
    	        url,
    	        params,
    	        baseURL,
    	        payload,
    	        headers,
    	        useLocaleInfo,
    	        timeout,
    	        timeoutHandler,
    	        isRetry,
    	        contentType,
    	        responseType
    	      } = requestOptions;
    	      const requestUrl = buildUrl(url, baseURL !== null && baseURL !== void 0 ? baseURL : __classPrivateFieldGet(this, _NativeHttpClient_baseUrl, "f"), params);
    	      const locale = useLocaleInfo ? (_c = __classPrivateFieldGet(this, _NativeHttpClient_getLocale, "f")) === null || _c === void 0 ? void 0 : _c.call(this) : undefined;
    	      const requestHeaders = yield __classPrivateFieldGet(this, _NativeHttpClient_instances, "m", _NativeHttpClient_buildHeaders).call(this, {
    	        headers,
    	        locale,
    	        contentType
    	      });
    	      return new Promise((resolve, reject) => {
    	        var _a, _b;
    	        const request = this.httpClientInstance.createRequest(method, requestUrl);
    	        request.onError = errRequest => __awaiter(this, void 0, void 0, function* () {
    	          try {
    	            const res = yield __classPrivateFieldGet(this, _NativeHttpClient_instances, "m", _NativeHttpClient_onErrorHandler).call(this, method, errRequest, !!isRetry, requestUrl, () => __classPrivateFieldGet(this, _NativeHttpClient_instances, "m", _NativeHttpClient_executeRequest).call(this, Object.assign(Object.assign({}, requestOptions), {
    	              isRetry: true
    	            })));
    	            resolve(res);
    	          } catch (e) {
    	            reject(e);
    	          }
    	        });
    	        request.onTimeout = () => {
    	          var _a, _b;
    	          try {
    	            timeoutHandler === null || timeoutHandler === void 0 ? void 0 : timeoutHandler();
    	          } catch (error) {
    	            reject(error);
    	          }
    	          const error = new Error(`Request timed out: ${requestUrl}`);
    	          (_b = (_a = __classPrivateFieldGet(this, _NativeHttpClient_logger, "f")) === null || _a === void 0 ? void 0 : _a.error) === null || _b === void 0 ? void 0 : _b.call(_a, {
    	            category: LOG_CATEGORY$2,
    	            message: `POST ${requestUrl}`,
    	            errorCode: ErrorCodes.Communication_Timeout,
    	            error
    	          });
    	          reject(error);
    	        };
    	        request.onSuccess = response => {
    	          if (useLocaleInfo && __classPrivateFieldGet(this, _NativeHttpClient_setLocale, "f") && response.responseHeaders) {
    	            updateLocale({
    	              responseHeaders: response.responseHeaders,
    	              localeHeader: __classPrivateFieldGet(this, _NativeHttpClient_localeHeader, "f"),
    	              currentLocale: locale,
    	              setLocale: __classPrivateFieldGet(this, _NativeHttpClient_setLocale, "f")
    	            });
    	          }
    	          resolve(response);
    	        };
    	        request.onAbort = () => {
    	          var _a, _b;
    	          const error = new Error(`Request was aborted: ${requestUrl}`);
    	          (_b = (_a = __classPrivateFieldGet(this, _NativeHttpClient_logger, "f")) === null || _a === void 0 ? void 0 : _a.error) === null || _b === void 0 ? void 0 : _b.call(_a, {
    	            category: LOG_CATEGORY$2,
    	            message: `POST ${requestUrl}`,
    	            errorCode: ErrorCodes.Communication_Aborted,
    	            error
    	          });
    	          reject(error);
    	        };
    	        Object.entries(requestHeaders).forEach(_ref16 => {
    	          let [key, value] = _ref16;
    	          request.setHeader(key, value);
    	        });
    	        if (timeout) {
    	          request.setTimeout(timeout * 1000);
    	        }
    	        if (payload) {
    	          request.setBody(payload);
    	        }
    	        if (responseType === "blob") {
    	          request.responseType = "blob";
    	        }
    	        (_b = (_a = __classPrivateFieldGet(this, _NativeHttpClient_logger, "f")) === null || _a === void 0 ? void 0 : _a.debug) === null || _b === void 0 ? void 0 : _b.call(_a, {
    	          category: LOG_CATEGORY$2,
    	          message: `${method} ${url}`
    	        });
    	        if (requestOptions.abortControler) {
    	          requestOptions.abortControler.onAbort = () => {
    	            request.abort();
    	          };
    	        }
    	        request.send();
    	      });
    	    });
    	  }, _NativeHttpClient_buildHeaders = function _NativeHttpClient_buildHeaders(_a) {
    	    return __awaiter(this, arguments, void 0, function (_ref17) {
    	      var _this8 = this;
    	      let {
    	        headers,
    	        locale,
    	        contentType
    	      } = _ref17;
    	      return function* () {
    	        var _b;
    	        const requestHeaders = Object.assign(Object.assign(Object.assign({}, (_b = __classPrivateFieldGet(_this8, _NativeHttpClient_headers, "f")) !== null && _b !== void 0 ? _b : {}), headers), locale ? {
    	          [__classPrivateFieldGet(_this8, _NativeHttpClient_localeHeader, "f")]: locale
    	        } : {});
    	        if (contentType && !requestHeaders["content-type"]) {
    	          requestHeaders["content-type"] = contentType;
    	        }
    	        const token = yield __classPrivateFieldGet(_this8, _NativeHttpClient_getToken, "f").call(_this8);
    	        if (token) {
    	          requestHeaders["authorization"] = token;
    	        }
    	        return yield __classPrivateFieldGet(_this8, _NativeHttpClient_instances, "m", _NativeHttpClient_insertTraceHeaders).call(_this8, requestHeaders);
    	      }();
    	    });
    	  }, _NativeHttpClient_insertTraceHeaders = function _NativeHttpClient_insertTraceHeaders(headers) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      var _a, _b;
    	      try {
    	        return yield addTraceHeaders(headers, () => {
    	          var _a;
    	          return (_a = __classPrivateFieldGet(this, _NativeHttpClient_loadTrace, "f")) === null || _a === void 0 ? void 0 : _a.call(this);
    	        });
    	      } catch (e) {
    	        (_b = (_a = __classPrivateFieldGet(this, _NativeHttpClient_logger, "f")) === null || _a === void 0 ? void 0 : _a.error) === null || _b === void 0 ? void 0 : _b.call(_a, {
    	          category: LOG_CATEGORY$2,
    	          message: `Error loading trace information`,
    	          errorCode: ErrorCodes.Communication_Default,
    	          error: e
    	        });
    	      }
    	      return headers;
    	    });
    	  };

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  /** Error thrown when an HTTP request fails. */
    	  class HttpError extends Error {
    	    /** Constructs a new instance of {@link @microsoft/signalr.HttpError}.
    	     *
    	     * @param {string} errorMessage A descriptive error message.
    	     * @param {number} statusCode The HTTP status code represented by this error.
    	     */
    	    constructor(errorMessage, statusCode) {
    	      const trueProto = new.target.prototype;
    	      super(`${errorMessage}: Status code '${statusCode}'`);
    	      this.statusCode = statusCode;
    	      // Workaround issue in Typescript compiler
    	      // https://github.com/Microsoft/TypeScript/issues/13965#issuecomment-278570200
    	      this.__proto__ = trueProto;
    	    }
    	  }
    	  /** Error thrown when a timeout elapses. */
    	  class TimeoutError extends Error {
    	    /** Constructs a new instance of {@link @microsoft/signalr.TimeoutError}.
    	     *
    	     * @param {string} errorMessage A descriptive error message.
    	     */
    	    constructor() {
    	      let errorMessage = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : "A timeout occurred.";
    	      const trueProto = new.target.prototype;
    	      super(errorMessage);
    	      // Workaround issue in Typescript compiler
    	      // https://github.com/Microsoft/TypeScript/issues/13965#issuecomment-278570200
    	      this.__proto__ = trueProto;
    	    }
    	  }
    	  /** Error thrown when an action is aborted. */
    	  class AbortError extends Error {
    	    /** Constructs a new instance of {@link AbortError}.
    	     *
    	     * @param {string} errorMessage A descriptive error message.
    	     */
    	    constructor() {
    	      let errorMessage = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : "An abort occurred.";
    	      const trueProto = new.target.prototype;
    	      super(errorMessage);
    	      // Workaround issue in Typescript compiler
    	      // https://github.com/Microsoft/TypeScript/issues/13965#issuecomment-278570200
    	      this.__proto__ = trueProto;
    	    }
    	  }
    	  /** Error thrown when the selected transport is unsupported by the browser. */
    	  /** @private */
    	  class UnsupportedTransportError extends Error {
    	    /** Constructs a new instance of {@link @microsoft/signalr.UnsupportedTransportError}.
    	     *
    	     * @param {string} message A descriptive error message.
    	     * @param {HttpTransportType} transport The {@link @microsoft/signalr.HttpTransportType} this error occurred on.
    	     */
    	    constructor(message, transport) {
    	      const trueProto = new.target.prototype;
    	      super(message);
    	      this.transport = transport;
    	      this.errorType = 'UnsupportedTransportError';
    	      // Workaround issue in Typescript compiler
    	      // https://github.com/Microsoft/TypeScript/issues/13965#issuecomment-278570200
    	      this.__proto__ = trueProto;
    	    }
    	  }
    	  /** Error thrown when the selected transport is disabled by the browser. */
    	  /** @private */
    	  class DisabledTransportError extends Error {
    	    /** Constructs a new instance of {@link @microsoft/signalr.DisabledTransportError}.
    	     *
    	     * @param {string} message A descriptive error message.
    	     * @param {HttpTransportType} transport The {@link @microsoft/signalr.HttpTransportType} this error occurred on.
    	     */
    	    constructor(message, transport) {
    	      const trueProto = new.target.prototype;
    	      super(message);
    	      this.transport = transport;
    	      this.errorType = 'DisabledTransportError';
    	      // Workaround issue in Typescript compiler
    	      // https://github.com/Microsoft/TypeScript/issues/13965#issuecomment-278570200
    	      this.__proto__ = trueProto;
    	    }
    	  }
    	  /** Error thrown when the selected transport cannot be started. */
    	  /** @private */
    	  class FailedToStartTransportError extends Error {
    	    /** Constructs a new instance of {@link @microsoft/signalr.FailedToStartTransportError}.
    	     *
    	     * @param {string} message A descriptive error message.
    	     * @param {HttpTransportType} transport The {@link @microsoft/signalr.HttpTransportType} this error occurred on.
    	     */
    	    constructor(message, transport) {
    	      const trueProto = new.target.prototype;
    	      super(message);
    	      this.transport = transport;
    	      this.errorType = 'FailedToStartTransportError';
    	      // Workaround issue in Typescript compiler
    	      // https://github.com/Microsoft/TypeScript/issues/13965#issuecomment-278570200
    	      this.__proto__ = trueProto;
    	    }
    	  }
    	  /** Error thrown when the negotiation with the server failed to complete. */
    	  /** @private */
    	  class FailedToNegotiateWithServerError extends Error {
    	    /** Constructs a new instance of {@link @microsoft/signalr.FailedToNegotiateWithServerError}.
    	     *
    	     * @param {string} message A descriptive error message.
    	     */
    	    constructor(message) {
    	      const trueProto = new.target.prototype;
    	      super(message);
    	      this.errorType = 'FailedToNegotiateWithServerError';
    	      // Workaround issue in Typescript compiler
    	      // https://github.com/Microsoft/TypeScript/issues/13965#issuecomment-278570200
    	      this.__proto__ = trueProto;
    	    }
    	  }
    	  /** Error thrown when multiple errors have occurred. */
    	  /** @private */
    	  class AggregateErrors extends Error {
    	    /** Constructs a new instance of {@link @microsoft/signalr.AggregateErrors}.
    	     *
    	     * @param {string} message A descriptive error message.
    	     * @param {Error[]} innerErrors The collection of errors this error is aggregating.
    	     */
    	    constructor(message, innerErrors) {
    	      const trueProto = new.target.prototype;
    	      super(message);
    	      this.innerErrors = innerErrors;
    	      // Workaround issue in Typescript compiler
    	      // https://github.com/Microsoft/TypeScript/issues/13965#issuecomment-278570200
    	      this.__proto__ = trueProto;
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  /** Represents an HTTP response. */
    	  class HttpResponse {
    	    constructor(statusCode, statusText, content) {
    	      this.statusCode = statusCode;
    	      this.statusText = statusText;
    	      this.content = content;
    	    }
    	  }
    	  /** Abstraction over an HTTP client.
    	   *
    	   * This class provides an abstraction over an HTTP client so that a different implementation can be provided on different platforms.
    	   */
    	  class HttpClient {
    	    get(url, options) {
    	      return this.send({
    	        ...options,
    	        method: "GET",
    	        url
    	      });
    	    }
    	    post(url, options) {
    	      return this.send({
    	        ...options,
    	        method: "POST",
    	        url
    	      });
    	    }
    	    delete(url, options) {
    	      return this.send({
    	        ...options,
    	        method: "DELETE",
    	        url
    	      });
    	    }
    	    /** Gets all cookies that apply to the specified URL.
    	     *
    	     * @param url The URL that the cookies are valid for.
    	     * @returns {string} A string containing all the key-value cookie pairs for the specified URL.
    	     */
    	    // @ts-ignore
    	    getCookieString(url) {
    	      return "";
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  // These values are designed to match the ASP.NET Log Levels since that's the pattern we're emulating here.
    	  /** Indicates the severity of a log message.
    	   *
    	   * Log Levels are ordered in increasing severity. So `Debug` is more severe than `Trace`, etc.
    	   */
    	  var LogLevel;
    	  (function (LogLevel) {
    	    /** Log level for very low severity diagnostic messages. */
    	    LogLevel[LogLevel["Trace"] = 0] = "Trace";
    	    /** Log level for low severity diagnostic messages. */
    	    LogLevel[LogLevel["Debug"] = 1] = "Debug";
    	    /** Log level for informational diagnostic messages. */
    	    LogLevel[LogLevel["Information"] = 2] = "Information";
    	    /** Log level for diagnostic messages that indicate a non-fatal problem. */
    	    LogLevel[LogLevel["Warning"] = 3] = "Warning";
    	    /** Log level for diagnostic messages that indicate a failure in the current operation. */
    	    LogLevel[LogLevel["Error"] = 4] = "Error";
    	    /** Log level for diagnostic messages that indicate a failure that will terminate the entire application. */
    	    LogLevel[LogLevel["Critical"] = 5] = "Critical";
    	    /** The highest possible log level. Used when configuring logging to indicate that no log messages should be emitted. */
    	    LogLevel[LogLevel["None"] = 6] = "None";
    	  })(LogLevel || (LogLevel = {}));

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  /** A logger that does nothing when log messages are sent to it. */
    	  class NullLogger {
    	    constructor() {}
    	    /** @inheritDoc */
    	    // eslint-disable-next-line
    	    log(_logLevel, _message) {}
    	  }
    	  /** The singleton instance of the {@link @microsoft/signalr.NullLogger}. */
    	  NullLogger.instance = new NullLogger();

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  // Version token that will be replaced by the prepack command
    	  /** The version of the SignalR client. */
    	  const VERSION = "7.0.12";
    	  /** @private */
    	  class Arg {
    	    static isRequired(val, name) {
    	      if (val === null || val === undefined) {
    	        throw new Error(`The '${name}' argument is required.`);
    	      }
    	    }
    	    static isNotEmpty(val, name) {
    	      if (!val || val.match(/^\s*$/)) {
    	        throw new Error(`The '${name}' argument should not be empty.`);
    	      }
    	    }
    	    static isIn(val, values, name) {
    	      // TypeScript enums have keys for **both** the name and the value of each enum member on the type itself.
    	      if (!(val in values)) {
    	        throw new Error(`Unknown ${name} value: ${val}.`);
    	      }
    	    }
    	  }
    	  /** @private */
    	  class Platform {
    	    // react-native has a window but no document so we should check both
    	    static get isBrowser() {
    	      return typeof window === "object" && typeof window.document === "object";
    	    }
    	    // WebWorkers don't have a window object so the isBrowser check would fail
    	    static get isWebWorker() {
    	      return typeof self === "object" && "importScripts" in self;
    	    }
    	    // react-native has a window but no document
    	    static get isReactNative() {
    	      return typeof window === "object" && typeof window.document === "undefined";
    	    }
    	    // Node apps shouldn't have a window object, but WebWorkers don't either
    	    // so we need to check for both WebWorker and window
    	    static get isNode() {
    	      return !this.isBrowser && !this.isWebWorker && !this.isReactNative;
    	    }
    	  }
    	  /** @private */
    	  function getDataDetail(data, includeContent) {
    	    let detail = "";
    	    if (isArrayBuffer(data)) {
    	      detail = `Binary data of length ${data.byteLength}`;
    	      if (includeContent) {
    	        detail += `. Content: '${formatArrayBuffer(data)}'`;
    	      }
    	    } else if (typeof data === "string") {
    	      detail = `String data of length ${data.length}`;
    	      if (includeContent) {
    	        detail += `. Content: '${data}'`;
    	      }
    	    }
    	    return detail;
    	  }
    	  /** @private */
    	  function formatArrayBuffer(data) {
    	    const view = new Uint8Array(data);
    	    // Uint8Array.map only supports returning another Uint8Array?
    	    let str = "";
    	    view.forEach(num => {
    	      const pad = num < 16 ? "0" : "";
    	      str += `0x${pad}${num.toString(16)} `;
    	    });
    	    // Trim of trailing space.
    	    return str.substr(0, str.length - 1);
    	  }
    	  // Also in signalr-protocol-msgpack/Utils.ts
    	  /** @private */
    	  function isArrayBuffer(val) {
    	    return val && typeof ArrayBuffer !== "undefined" && (val instanceof ArrayBuffer ||
    	    // Sometimes we get an ArrayBuffer that doesn't satisfy instanceof
    	    val.constructor && val.constructor.name === "ArrayBuffer");
    	  }
    	  /** @private */
    	  async function sendMessage(logger, transportName, httpClient, url, content, options) {
    	    const headers = {};
    	    const [name, value] = getUserAgentHeader();
    	    headers[name] = value;
    	    logger.log(LogLevel.Trace, `(${transportName} transport) sending data. ${getDataDetail(content, options.logMessageContent)}.`);
    	    const responseType = isArrayBuffer(content) ? "arraybuffer" : "text";
    	    const response = await httpClient.post(url, {
    	      content,
    	      headers: {
    	        ...headers,
    	        ...options.headers
    	      },
    	      responseType,
    	      timeout: options.timeout,
    	      withCredentials: options.withCredentials
    	    });
    	    logger.log(LogLevel.Trace, `(${transportName} transport) request complete. Response status: ${response.statusCode}.`);
    	  }
    	  /** @private */
    	  function createLogger(logger) {
    	    if (logger === undefined) {
    	      return new ConsoleLogger(LogLevel.Information);
    	    }
    	    if (logger === null) {
    	      return NullLogger.instance;
    	    }
    	    if (logger.log !== undefined) {
    	      return logger;
    	    }
    	    return new ConsoleLogger(logger);
    	  }
    	  /** @private */
    	  class SubjectSubscription {
    	    constructor(subject, observer) {
    	      this._subject = subject;
    	      this._observer = observer;
    	    }
    	    dispose() {
    	      const index = this._subject.observers.indexOf(this._observer);
    	      if (index > -1) {
    	        this._subject.observers.splice(index, 1);
    	      }
    	      if (this._subject.observers.length === 0 && this._subject.cancelCallback) {
    	        this._subject.cancelCallback().catch(_ => {});
    	      }
    	    }
    	  }
    	  /** @private */
    	  class ConsoleLogger {
    	    constructor(minimumLogLevel) {
    	      this._minLevel = minimumLogLevel;
    	      this.out = console;
    	    }
    	    log(logLevel, message) {
    	      if (logLevel >= this._minLevel) {
    	        const msg = `[${new Date().toISOString()}] ${LogLevel[logLevel]}: ${message}`;
    	        switch (logLevel) {
    	          case LogLevel.Critical:
    	          case LogLevel.Error:
    	            this.out.error(msg);
    	            break;
    	          case LogLevel.Warning:
    	            this.out.warn(msg);
    	            break;
    	          case LogLevel.Information:
    	            this.out.info(msg);
    	            break;
    	          default:
    	            // console.debug only goes to attached debuggers in Node, so we use console.log for Trace and Debug
    	            this.out.log(msg);
    	            break;
    	        }
    	      }
    	    }
    	  }
    	  /** @private */
    	  function getUserAgentHeader() {
    	    let userAgentHeaderName = "X-SignalR-User-Agent";
    	    if (Platform.isNode) {
    	      userAgentHeaderName = "User-Agent";
    	    }
    	    return [userAgentHeaderName, constructUserAgent(VERSION, getOsName(), getRuntime(), getRuntimeVersion())];
    	  }
    	  /** @private */
    	  function constructUserAgent(version, os, runtime, runtimeVersion) {
    	    // Microsoft SignalR/[Version] ([Detailed Version]; [Operating System]; [Runtime]; [Runtime Version])
    	    let userAgent = "Microsoft SignalR/";
    	    const majorAndMinor = version.split(".");
    	    userAgent += `${majorAndMinor[0]}.${majorAndMinor[1]}`;
    	    userAgent += ` (${version}; `;
    	    if (os && os !== "") {
    	      userAgent += `${os}; `;
    	    } else {
    	      userAgent += "Unknown OS; ";
    	    }
    	    userAgent += `${runtime}`;
    	    if (runtimeVersion) {
    	      userAgent += `; ${runtimeVersion}`;
    	    } else {
    	      userAgent += "; Unknown Runtime Version";
    	    }
    	    userAgent += ")";
    	    return userAgent;
    	  }
    	  // eslint-disable-next-line spaced-comment
    	  function getOsName() {
    	    if (Platform.isNode) {
    	      switch (process.platform) {
    	        case "win32":
    	          return "Windows NT";
    	        case "darwin":
    	          return "macOS";
    	        case "linux":
    	          return "Linux";
    	        default:
    	          return process.platform;
    	      }
    	    } else {
    	      return "";
    	    }
    	  }
    	  // eslint-disable-next-line spaced-comment
    	  function getRuntimeVersion() {
    	    if (Platform.isNode) {
    	      return process.versions.node;
    	    }
    	    return undefined;
    	  }
    	  function getRuntime() {
    	    if (Platform.isNode) {
    	      return "NodeJS";
    	    } else {
    	      return "Browser";
    	    }
    	  }
    	  /** @private */
    	  function getErrorString(e) {
    	    if (e.stack) {
    	      return e.stack;
    	    } else if (e.message) {
    	      return e.message;
    	    }
    	    return `${e}`;
    	  }
    	  /** @private */
    	  function getGlobalThis() {
    	    // globalThis is semi-new and not available in Node until v12
    	    if (typeof globalThis !== "undefined") {
    	      return globalThis;
    	    }
    	    if (typeof self !== "undefined") {
    	      return self;
    	    }
    	    if (typeof window !== "undefined") {
    	      return window;
    	    }
    	    if (typeof commonjsGlobal !== "undefined") {
    	      return commonjsGlobal;
    	    }
    	    throw new Error("could not find global");
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  class FetchHttpClient extends HttpClient {
    	    constructor(logger) {
    	      super();
    	      this._logger = logger;
    	      if (typeof fetch === "undefined") {
    	        // In order to ignore the dynamic require in webpack builds we need to do this magic
    	        // @ts-ignore: TS doesn't know about these names
    	        const requireFunc = typeof __webpack_require__ === "function" ? __non_webpack_require__ : commonjsRequire;
    	        // Cookies aren't automatically handled in Node so we need to add a CookieJar to preserve cookies across requests
    	        this._jar = new (requireFunc("tough-cookie").CookieJar)();
    	        this._fetchType = requireFunc("node-fetch");
    	        // node-fetch doesn't have a nice API for getting and setting cookies
    	        // fetch-cookie will wrap a fetch implementation with a default CookieJar or a provided one
    	        this._fetchType = requireFunc("fetch-cookie")(this._fetchType, this._jar);
    	      } else {
    	        this._fetchType = fetch.bind(getGlobalThis());
    	      }
    	      if (typeof AbortController === "undefined") {
    	        // In order to ignore the dynamic require in webpack builds we need to do this magic
    	        // @ts-ignore: TS doesn't know about these names
    	        const requireFunc = typeof __webpack_require__ === "function" ? __non_webpack_require__ : commonjsRequire;
    	        // Node needs EventListener methods on AbortController which our custom polyfill doesn't provide
    	        this._abortControllerType = requireFunc("abort-controller");
    	      } else {
    	        this._abortControllerType = AbortController;
    	      }
    	    }
    	    /** @inheritDoc */
    	    async send(request) {
    	      // Check that abort was not signaled before calling send
    	      if (request.abortSignal && request.abortSignal.aborted) {
    	        throw new AbortError();
    	      }
    	      if (!request.method) {
    	        throw new Error("No method defined.");
    	      }
    	      if (!request.url) {
    	        throw new Error("No url defined.");
    	      }
    	      const abortController = new this._abortControllerType();
    	      let error;
    	      // Hook our abortSignal into the abort controller
    	      if (request.abortSignal) {
    	        request.abortSignal.onabort = () => {
    	          abortController.abort();
    	          error = new AbortError();
    	        };
    	      }
    	      // If a timeout has been passed in, setup a timeout to call abort
    	      // Type needs to be any to fit window.setTimeout and NodeJS.setTimeout
    	      let timeoutId = null;
    	      if (request.timeout) {
    	        const msTimeout = request.timeout;
    	        timeoutId = setTimeout(() => {
    	          abortController.abort();
    	          this._logger.log(LogLevel.Warning, `Timeout from HTTP request.`);
    	          error = new TimeoutError();
    	        }, msTimeout);
    	      }
    	      if (request.content === "") {
    	        request.content = undefined;
    	      }
    	      if (request.content) {
    	        // Explicitly setting the Content-Type header for React Native on Android platform.
    	        request.headers = request.headers || {};
    	        if (isArrayBuffer(request.content)) {
    	          request.headers["Content-Type"] = "application/octet-stream";
    	        } else {
    	          request.headers["Content-Type"] = "text/plain;charset=UTF-8";
    	        }
    	      }
    	      let response;
    	      try {
    	        response = await this._fetchType(request.url, {
    	          body: request.content,
    	          cache: "no-cache",
    	          credentials: request.withCredentials === true ? "include" : "same-origin",
    	          headers: {
    	            "X-Requested-With": "XMLHttpRequest",
    	            ...request.headers
    	          },
    	          method: request.method,
    	          mode: "cors",
    	          redirect: "follow",
    	          signal: abortController.signal
    	        });
    	      } catch (e) {
    	        if (error) {
    	          throw error;
    	        }
    	        this._logger.log(LogLevel.Warning, `Error from HTTP request. ${e}.`);
    	        throw e;
    	      } finally {
    	        if (timeoutId) {
    	          clearTimeout(timeoutId);
    	        }
    	        if (request.abortSignal) {
    	          request.abortSignal.onabort = null;
    	        }
    	      }
    	      if (!response.ok) {
    	        const errorMessage = await deserializeContent(response, "text");
    	        throw new HttpError(errorMessage || response.statusText, response.status);
    	      }
    	      const content = deserializeContent(response, request.responseType);
    	      const payload = await content;
    	      return new HttpResponse(response.status, response.statusText, payload);
    	    }
    	    getCookieString(url) {
    	      let cookies = "";
    	      if (Platform.isNode && this._jar) {
    	        // @ts-ignore: unused variable
    	        this._jar.getCookies(url, (e, c) => cookies = c.join("; "));
    	      }
    	      return cookies;
    	    }
    	  }
    	  function deserializeContent(response, responseType) {
    	    let content;
    	    switch (responseType) {
    	      case "arraybuffer":
    	        content = response.arrayBuffer();
    	        break;
    	      case "text":
    	        content = response.text();
    	        break;
    	      case "blob":
    	      case "document":
    	      case "json":
    	        throw new Error(`${responseType} is not supported.`);
    	      default:
    	        content = response.text();
    	        break;
    	    }
    	    return content;
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  class XhrHttpClient extends HttpClient {
    	    constructor(logger) {
    	      super();
    	      this._logger = logger;
    	    }
    	    /** @inheritDoc */
    	    send(request) {
    	      // Check that abort was not signaled before calling send
    	      if (request.abortSignal && request.abortSignal.aborted) {
    	        return Promise.reject(new AbortError());
    	      }
    	      if (!request.method) {
    	        return Promise.reject(new Error("No method defined."));
    	      }
    	      if (!request.url) {
    	        return Promise.reject(new Error("No url defined."));
    	      }
    	      return new Promise((resolve, reject) => {
    	        const xhr = new XMLHttpRequest();
    	        xhr.open(request.method, request.url, true);
    	        xhr.withCredentials = request.withCredentials === undefined ? true : request.withCredentials;
    	        xhr.setRequestHeader("X-Requested-With", "XMLHttpRequest");
    	        if (request.content === "") {
    	          request.content = undefined;
    	        }
    	        if (request.content) {
    	          // Explicitly setting the Content-Type header for React Native on Android platform.
    	          if (isArrayBuffer(request.content)) {
    	            xhr.setRequestHeader("Content-Type", "application/octet-stream");
    	          } else {
    	            xhr.setRequestHeader("Content-Type", "text/plain;charset=UTF-8");
    	          }
    	        }
    	        const headers = request.headers;
    	        if (headers) {
    	          Object.keys(headers).forEach(header => {
    	            xhr.setRequestHeader(header, headers[header]);
    	          });
    	        }
    	        if (request.responseType) {
    	          xhr.responseType = request.responseType;
    	        }
    	        if (request.abortSignal) {
    	          request.abortSignal.onabort = () => {
    	            xhr.abort();
    	            reject(new AbortError());
    	          };
    	        }
    	        if (request.timeout) {
    	          xhr.timeout = request.timeout;
    	        }
    	        xhr.onload = () => {
    	          if (request.abortSignal) {
    	            request.abortSignal.onabort = null;
    	          }
    	          if (xhr.status >= 200 && xhr.status < 300) {
    	            resolve(new HttpResponse(xhr.status, xhr.statusText, xhr.response || xhr.responseText));
    	          } else {
    	            reject(new HttpError(xhr.response || xhr.responseText || xhr.statusText, xhr.status));
    	          }
    	        };
    	        xhr.onerror = () => {
    	          this._logger.log(LogLevel.Warning, `Error from HTTP request. ${xhr.status}: ${xhr.statusText}.`);
    	          reject(new HttpError(xhr.statusText, xhr.status));
    	        };
    	        xhr.ontimeout = () => {
    	          this._logger.log(LogLevel.Warning, `Timeout from HTTP request.`);
    	          reject(new TimeoutError());
    	        };
    	        xhr.send(request.content);
    	      });
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  /** Default implementation of {@link @microsoft/signalr.HttpClient}. */
    	  class DefaultHttpClient extends HttpClient {
    	    /** Creates a new instance of the {@link @microsoft/signalr.DefaultHttpClient}, using the provided {@link @microsoft/signalr.ILogger} to log messages. */
    	    constructor(logger) {
    	      super();
    	      if (typeof fetch !== "undefined" || Platform.isNode) {
    	        this._httpClient = new FetchHttpClient(logger);
    	      } else if (typeof XMLHttpRequest !== "undefined") {
    	        this._httpClient = new XhrHttpClient(logger);
    	      } else {
    	        throw new Error("No usable HttpClient found.");
    	      }
    	    }
    	    /** @inheritDoc */
    	    send(request) {
    	      // Check that abort was not signaled before calling send
    	      if (request.abortSignal && request.abortSignal.aborted) {
    	        return Promise.reject(new AbortError());
    	      }
    	      if (!request.method) {
    	        return Promise.reject(new Error("No method defined."));
    	      }
    	      if (!request.url) {
    	        return Promise.reject(new Error("No url defined."));
    	      }
    	      return this._httpClient.send(request);
    	    }
    	    getCookieString(url) {
    	      return this._httpClient.getCookieString(url);
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  // Not exported from index
    	  /** @private */
    	  class TextMessageFormat {
    	    static write(output) {
    	      return `${output}${TextMessageFormat.RecordSeparator}`;
    	    }
    	    static parse(input) {
    	      if (input[input.length - 1] !== TextMessageFormat.RecordSeparator) {
    	        throw new Error("Message is incomplete.");
    	      }
    	      const messages = input.split(TextMessageFormat.RecordSeparator);
    	      messages.pop();
    	      return messages;
    	    }
    	  }
    	  TextMessageFormat.RecordSeparatorCode = 0x1e;
    	  TextMessageFormat.RecordSeparator = String.fromCharCode(TextMessageFormat.RecordSeparatorCode);

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  /** @private */
    	  class HandshakeProtocol {
    	    // Handshake request is always JSON
    	    writeHandshakeRequest(handshakeRequest) {
    	      return TextMessageFormat.write(JSON.stringify(handshakeRequest));
    	    }
    	    parseHandshakeResponse(data) {
    	      let messageData;
    	      let remainingData;
    	      if (isArrayBuffer(data)) {
    	        // Format is binary but still need to read JSON text from handshake response
    	        const binaryData = new Uint8Array(data);
    	        const separatorIndex = binaryData.indexOf(TextMessageFormat.RecordSeparatorCode);
    	        if (separatorIndex === -1) {
    	          throw new Error("Message is incomplete.");
    	        }
    	        // content before separator is handshake response
    	        // optional content after is additional messages
    	        const responseLength = separatorIndex + 1;
    	        messageData = String.fromCharCode.apply(null, Array.prototype.slice.call(binaryData.slice(0, responseLength)));
    	        remainingData = binaryData.byteLength > responseLength ? binaryData.slice(responseLength).buffer : null;
    	      } else {
    	        const textData = data;
    	        const separatorIndex = textData.indexOf(TextMessageFormat.RecordSeparator);
    	        if (separatorIndex === -1) {
    	          throw new Error("Message is incomplete.");
    	        }
    	        // content before separator is handshake response
    	        // optional content after is additional messages
    	        const responseLength = separatorIndex + 1;
    	        messageData = textData.substring(0, responseLength);
    	        remainingData = textData.length > responseLength ? textData.substring(responseLength) : null;
    	      }
    	      // At this point we should have just the single handshake message
    	      const messages = TextMessageFormat.parse(messageData);
    	      const response = JSON.parse(messages[0]);
    	      if (response.type) {
    	        throw new Error("Expected a handshake response from the server.");
    	      }
    	      const responseMessage = response;
    	      // multiple messages could have arrived with handshake
    	      // return additional data to be parsed as usual, or null if all parsed
    	      return [remainingData, responseMessage];
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  /** Defines the type of a Hub Message. */
    	  var MessageType;
    	  (function (MessageType) {
    	    /** Indicates the message is an Invocation message and implements the {@link @microsoft/signalr.InvocationMessage} interface. */
    	    MessageType[MessageType["Invocation"] = 1] = "Invocation";
    	    /** Indicates the message is a StreamItem message and implements the {@link @microsoft/signalr.StreamItemMessage} interface. */
    	    MessageType[MessageType["StreamItem"] = 2] = "StreamItem";
    	    /** Indicates the message is a Completion message and implements the {@link @microsoft/signalr.CompletionMessage} interface. */
    	    MessageType[MessageType["Completion"] = 3] = "Completion";
    	    /** Indicates the message is a Stream Invocation message and implements the {@link @microsoft/signalr.StreamInvocationMessage} interface. */
    	    MessageType[MessageType["StreamInvocation"] = 4] = "StreamInvocation";
    	    /** Indicates the message is a Cancel Invocation message and implements the {@link @microsoft/signalr.CancelInvocationMessage} interface. */
    	    MessageType[MessageType["CancelInvocation"] = 5] = "CancelInvocation";
    	    /** Indicates the message is a Ping message and implements the {@link @microsoft/signalr.PingMessage} interface. */
    	    MessageType[MessageType["Ping"] = 6] = "Ping";
    	    /** Indicates the message is a Close message and implements the {@link @microsoft/signalr.CloseMessage} interface. */
    	    MessageType[MessageType["Close"] = 7] = "Close";
    	  })(MessageType || (MessageType = {}));

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  /** Stream implementation to stream items to the server. */
    	  class Subject {
    	    constructor() {
    	      this.observers = [];
    	    }
    	    next(item) {
    	      for (const observer of this.observers) {
    	        observer.next(item);
    	      }
    	    }
    	    error(err) {
    	      for (const observer of this.observers) {
    	        if (observer.error) {
    	          observer.error(err);
    	        }
    	      }
    	    }
    	    complete() {
    	      for (const observer of this.observers) {
    	        if (observer.complete) {
    	          observer.complete();
    	        }
    	      }
    	    }
    	    subscribe(observer) {
    	      this.observers.push(observer);
    	      return new SubjectSubscription(this, observer);
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  const DEFAULT_TIMEOUT_IN_MS = 30 * 1000;
    	  const DEFAULT_PING_INTERVAL_IN_MS = 15 * 1000;
    	  /** Describes the current state of the {@link HubConnection} to the server. */
    	  var HubConnectionState;
    	  (function (HubConnectionState) {
    	    /** The hub connection is disconnected. */
    	    HubConnectionState["Disconnected"] = "Disconnected";
    	    /** The hub connection is connecting. */
    	    HubConnectionState["Connecting"] = "Connecting";
    	    /** The hub connection is connected. */
    	    HubConnectionState["Connected"] = "Connected";
    	    /** The hub connection is disconnecting. */
    	    HubConnectionState["Disconnecting"] = "Disconnecting";
    	    /** The hub connection is reconnecting. */
    	    HubConnectionState["Reconnecting"] = "Reconnecting";
    	  })(HubConnectionState || (HubConnectionState = {}));
    	  /** Represents a connection to a SignalR Hub. */
    	  class HubConnection {
    	    constructor(connection, logger, protocol, reconnectPolicy) {
    	      this._nextKeepAlive = 0;
    	      this._freezeEventListener = () => {
    	        this._logger.log(LogLevel.Warning, "The page is being frozen, this will likely lead to the connection being closed and messages being lost. For more information see the docs at https://docs.microsoft.com/aspnet/core/signalr/javascript-client#bsleep");
    	      };
    	      Arg.isRequired(connection, "connection");
    	      Arg.isRequired(logger, "logger");
    	      Arg.isRequired(protocol, "protocol");
    	      this.serverTimeoutInMilliseconds = DEFAULT_TIMEOUT_IN_MS;
    	      this.keepAliveIntervalInMilliseconds = DEFAULT_PING_INTERVAL_IN_MS;
    	      this._logger = logger;
    	      this._protocol = protocol;
    	      this.connection = connection;
    	      this._reconnectPolicy = reconnectPolicy;
    	      this._handshakeProtocol = new HandshakeProtocol();
    	      this.connection.onreceive = data => this._processIncomingData(data);
    	      this.connection.onclose = error => this._connectionClosed(error);
    	      this._callbacks = {};
    	      this._methods = {};
    	      this._closedCallbacks = [];
    	      this._reconnectingCallbacks = [];
    	      this._reconnectedCallbacks = [];
    	      this._invocationId = 0;
    	      this._receivedHandshakeResponse = false;
    	      this._connectionState = HubConnectionState.Disconnected;
    	      this._connectionStarted = false;
    	      this._cachedPingMessage = this._protocol.writeMessage({
    	        type: MessageType.Ping
    	      });
    	    }
    	    /** @internal */
    	    // Using a public static factory method means we can have a private constructor and an _internal_
    	    // create method that can be used by HubConnectionBuilder. An "internal" constructor would just
    	    // be stripped away and the '.d.ts' file would have no constructor, which is interpreted as a
    	    // public parameter-less constructor.
    	    static create(connection, logger, protocol, reconnectPolicy) {
    	      return new HubConnection(connection, logger, protocol, reconnectPolicy);
    	    }
    	    /** Indicates the state of the {@link HubConnection} to the server. */
    	    get state() {
    	      return this._connectionState;
    	    }
    	    /** Represents the connection id of the {@link HubConnection} on the server. The connection id will be null when the connection is either
    	     *  in the disconnected state or if the negotiation step was skipped.
    	     */
    	    get connectionId() {
    	      return this.connection ? this.connection.connectionId || null : null;
    	    }
    	    /** Indicates the url of the {@link HubConnection} to the server. */
    	    get baseUrl() {
    	      return this.connection.baseUrl || "";
    	    }
    	    /**
    	     * Sets a new url for the HubConnection. Note that the url can only be changed when the connection is in either the Disconnected or
    	     * Reconnecting states.
    	     * @param {string} url The url to connect to.
    	     */
    	    set baseUrl(url) {
    	      if (this._connectionState !== HubConnectionState.Disconnected && this._connectionState !== HubConnectionState.Reconnecting) {
    	        throw new Error("The HubConnection must be in the Disconnected or Reconnecting state to change the url.");
    	      }
    	      if (!url) {
    	        throw new Error("The HubConnection url must be a valid url.");
    	      }
    	      this.connection.baseUrl = url;
    	    }
    	    /** Starts the connection.
    	     *
    	     * @returns {Promise<void>} A Promise that resolves when the connection has been successfully established, or rejects with an error.
    	     */
    	    start() {
    	      this._startPromise = this._startWithStateTransitions();
    	      return this._startPromise;
    	    }
    	    async _startWithStateTransitions() {
    	      if (this._connectionState !== HubConnectionState.Disconnected) {
    	        return Promise.reject(new Error("Cannot start a HubConnection that is not in the 'Disconnected' state."));
    	      }
    	      this._connectionState = HubConnectionState.Connecting;
    	      this._logger.log(LogLevel.Debug, "Starting HubConnection.");
    	      try {
    	        await this._startInternal();
    	        if (Platform.isBrowser) {
    	          // Log when the browser freezes the tab so users know why their connection unexpectedly stopped working
    	          window.document.addEventListener("freeze", this._freezeEventListener);
    	        }
    	        this._connectionState = HubConnectionState.Connected;
    	        this._connectionStarted = true;
    	        this._logger.log(LogLevel.Debug, "HubConnection connected successfully.");
    	      } catch (e) {
    	        this._connectionState = HubConnectionState.Disconnected;
    	        this._logger.log(LogLevel.Debug, `HubConnection failed to start successfully because of error '${e}'.`);
    	        return Promise.reject(e);
    	      }
    	    }
    	    async _startInternal() {
    	      this._stopDuringStartError = undefined;
    	      this._receivedHandshakeResponse = false;
    	      // Set up the promise before any connection is (re)started otherwise it could race with received messages
    	      const handshakePromise = new Promise((resolve, reject) => {
    	        this._handshakeResolver = resolve;
    	        this._handshakeRejecter = reject;
    	      });
    	      await this.connection.start(this._protocol.transferFormat);
    	      try {
    	        const handshakeRequest = {
    	          protocol: this._protocol.name,
    	          version: this._protocol.version
    	        };
    	        this._logger.log(LogLevel.Debug, "Sending handshake request.");
    	        await this._sendMessage(this._handshakeProtocol.writeHandshakeRequest(handshakeRequest));
    	        this._logger.log(LogLevel.Information, `Using HubProtocol '${this._protocol.name}'.`);
    	        // defensively cleanup timeout in case we receive a message from the server before we finish start
    	        this._cleanupTimeout();
    	        this._resetTimeoutPeriod();
    	        this._resetKeepAliveInterval();
    	        await handshakePromise;
    	        // It's important to check the stopDuringStartError instead of just relying on the handshakePromise
    	        // being rejected on close, because this continuation can run after both the handshake completed successfully
    	        // and the connection was closed.
    	        if (this._stopDuringStartError) {
    	          // It's important to throw instead of returning a rejected promise, because we don't want to allow any state
    	          // transitions to occur between now and the calling code observing the exceptions. Returning a rejected promise
    	          // will cause the calling continuation to get scheduled to run later.
    	          // eslint-disable-next-line @typescript-eslint/no-throw-literal
    	          throw this._stopDuringStartError;
    	        }
    	        if (!this.connection.features.inherentKeepAlive) {
    	          await this._sendMessage(this._cachedPingMessage);
    	        }
    	      } catch (e) {
    	        this._logger.log(LogLevel.Debug, `Hub handshake failed with error '${e}' during start(). Stopping HubConnection.`);
    	        this._cleanupTimeout();
    	        this._cleanupPingTimer();
    	        // HttpConnection.stop() should not complete until after the onclose callback is invoked.
    	        // This will transition the HubConnection to the disconnected state before HttpConnection.stop() completes.
    	        await this.connection.stop(e);
    	        throw e;
    	      }
    	    }
    	    /** Stops the connection.
    	     *
    	     * @returns {Promise<void>} A Promise that resolves when the connection has been successfully terminated, or rejects with an error.
    	     */
    	    async stop() {
    	      // Capture the start promise before the connection might be restarted in an onclose callback.
    	      const startPromise = this._startPromise;
    	      this._stopPromise = this._stopInternal();
    	      await this._stopPromise;
    	      try {
    	        // Awaiting undefined continues immediately
    	        await startPromise;
    	      } catch (e) {
    	        // This exception is returned to the user as a rejected Promise from the start method.
    	      }
    	    }
    	    _stopInternal(error) {
    	      if (this._connectionState === HubConnectionState.Disconnected) {
    	        this._logger.log(LogLevel.Debug, `Call to HubConnection.stop(${error}) ignored because it is already in the disconnected state.`);
    	        return Promise.resolve();
    	      }
    	      if (this._connectionState === HubConnectionState.Disconnecting) {
    	        this._logger.log(LogLevel.Debug, `Call to HttpConnection.stop(${error}) ignored because the connection is already in the disconnecting state.`);
    	        return this._stopPromise;
    	      }
    	      this._connectionState = HubConnectionState.Disconnecting;
    	      this._logger.log(LogLevel.Debug, "Stopping HubConnection.");
    	      if (this._reconnectDelayHandle) {
    	        // We're in a reconnect delay which means the underlying connection is currently already stopped.
    	        // Just clear the handle to stop the reconnect loop (which no one is waiting on thankfully) and
    	        // fire the onclose callbacks.
    	        this._logger.log(LogLevel.Debug, "Connection stopped during reconnect delay. Done reconnecting.");
    	        clearTimeout(this._reconnectDelayHandle);
    	        this._reconnectDelayHandle = undefined;
    	        this._completeClose();
    	        return Promise.resolve();
    	      }
    	      this._cleanupTimeout();
    	      this._cleanupPingTimer();
    	      this._stopDuringStartError = error || new AbortError("The connection was stopped before the hub handshake could complete.");
    	      // HttpConnection.stop() should not complete until after either HttpConnection.start() fails
    	      // or the onclose callback is invoked. The onclose callback will transition the HubConnection
    	      // to the disconnected state if need be before HttpConnection.stop() completes.
    	      return this.connection.stop(error);
    	    }
    	    /** Invokes a streaming hub method on the server using the specified name and arguments.
    	     *
    	     * @typeparam T The type of the items returned by the server.
    	     * @param {string} methodName The name of the server method to invoke.
    	     * @param {any[]} args The arguments used to invoke the server method.
    	     * @returns {IStreamResult<T>} An object that yields results from the server as they are received.
    	     */
    	    stream(methodName) {
    	      for (var _len = arguments.length, args = new Array(_len > 1 ? _len - 1 : 0), _key = 1; _key < _len; _key++) {
    	        args[_key - 1] = arguments[_key];
    	      }
    	      const [streams, streamIds] = this._replaceStreamingParams(args);
    	      const invocationDescriptor = this._createStreamInvocation(methodName, args, streamIds);
    	      // eslint-disable-next-line prefer-const
    	      let promiseQueue;
    	      const subject = new Subject();
    	      subject.cancelCallback = () => {
    	        const cancelInvocation = this._createCancelInvocation(invocationDescriptor.invocationId);
    	        delete this._callbacks[invocationDescriptor.invocationId];
    	        return promiseQueue.then(() => {
    	          return this._sendWithProtocol(cancelInvocation);
    	        });
    	      };
    	      this._callbacks[invocationDescriptor.invocationId] = (invocationEvent, error) => {
    	        if (error) {
    	          subject.error(error);
    	          return;
    	        } else if (invocationEvent) {
    	          // invocationEvent will not be null when an error is not passed to the callback
    	          if (invocationEvent.type === MessageType.Completion) {
    	            if (invocationEvent.error) {
    	              subject.error(new Error(invocationEvent.error));
    	            } else {
    	              subject.complete();
    	            }
    	          } else {
    	            subject.next(invocationEvent.item);
    	          }
    	        }
    	      };
    	      promiseQueue = this._sendWithProtocol(invocationDescriptor).catch(e => {
    	        subject.error(e);
    	        delete this._callbacks[invocationDescriptor.invocationId];
    	      });
    	      this._launchStreams(streams, promiseQueue);
    	      return subject;
    	    }
    	    _sendMessage(message) {
    	      this._resetKeepAliveInterval();
    	      return this.connection.send(message);
    	    }
    	    /**
    	     * Sends a js object to the server.
    	     * @param message The js object to serialize and send.
    	     */
    	    _sendWithProtocol(message) {
    	      return this._sendMessage(this._protocol.writeMessage(message));
    	    }
    	    /** Invokes a hub method on the server using the specified name and arguments. Does not wait for a response from the receiver.
    	     *
    	     * The Promise returned by this method resolves when the client has sent the invocation to the server. The server may still
    	     * be processing the invocation.
    	     *
    	     * @param {string} methodName The name of the server method to invoke.
    	     * @param {any[]} args The arguments used to invoke the server method.
    	     * @returns {Promise<void>} A Promise that resolves when the invocation has been successfully sent, or rejects with an error.
    	     */
    	    send(methodName) {
    	      for (var _len2 = arguments.length, args = new Array(_len2 > 1 ? _len2 - 1 : 0), _key2 = 1; _key2 < _len2; _key2++) {
    	        args[_key2 - 1] = arguments[_key2];
    	      }
    	      const [streams, streamIds] = this._replaceStreamingParams(args);
    	      const sendPromise = this._sendWithProtocol(this._createInvocation(methodName, args, true, streamIds));
    	      this._launchStreams(streams, sendPromise);
    	      return sendPromise;
    	    }
    	    /** Invokes a hub method on the server using the specified name and arguments.
    	     *
    	     * The Promise returned by this method resolves when the server indicates it has finished invoking the method. When the promise
    	     * resolves, the server has finished invoking the method. If the server method returns a result, it is produced as the result of
    	     * resolving the Promise.
    	     *
    	     * @typeparam T The expected return type.
    	     * @param {string} methodName The name of the server method to invoke.
    	     * @param {any[]} args The arguments used to invoke the server method.
    	     * @returns {Promise<T>} A Promise that resolves with the result of the server method (if any), or rejects with an error.
    	     */
    	    invoke(methodName) {
    	      for (var _len3 = arguments.length, args = new Array(_len3 > 1 ? _len3 - 1 : 0), _key3 = 1; _key3 < _len3; _key3++) {
    	        args[_key3 - 1] = arguments[_key3];
    	      }
    	      const [streams, streamIds] = this._replaceStreamingParams(args);
    	      const invocationDescriptor = this._createInvocation(methodName, args, false, streamIds);
    	      const p = new Promise((resolve, reject) => {
    	        // invocationId will always have a value for a non-blocking invocation
    	        this._callbacks[invocationDescriptor.invocationId] = (invocationEvent, error) => {
    	          if (error) {
    	            reject(error);
    	            return;
    	          } else if (invocationEvent) {
    	            // invocationEvent will not be null when an error is not passed to the callback
    	            if (invocationEvent.type === MessageType.Completion) {
    	              if (invocationEvent.error) {
    	                reject(new Error(invocationEvent.error));
    	              } else {
    	                resolve(invocationEvent.result);
    	              }
    	            } else {
    	              reject(new Error(`Unexpected message type: ${invocationEvent.type}`));
    	            }
    	          }
    	        };
    	        const promiseQueue = this._sendWithProtocol(invocationDescriptor).catch(e => {
    	          reject(e);
    	          // invocationId will always have a value for a non-blocking invocation
    	          delete this._callbacks[invocationDescriptor.invocationId];
    	        });
    	        this._launchStreams(streams, promiseQueue);
    	      });
    	      return p;
    	    }
    	    on(methodName, newMethod) {
    	      if (!methodName || !newMethod) {
    	        return;
    	      }
    	      methodName = methodName.toLowerCase();
    	      if (!this._methods[methodName]) {
    	        this._methods[methodName] = [];
    	      }
    	      // Preventing adding the same handler multiple times.
    	      if (this._methods[methodName].indexOf(newMethod) !== -1) {
    	        return;
    	      }
    	      this._methods[methodName].push(newMethod);
    	    }
    	    off(methodName, method) {
    	      if (!methodName) {
    	        return;
    	      }
    	      methodName = methodName.toLowerCase();
    	      const handlers = this._methods[methodName];
    	      if (!handlers) {
    	        return;
    	      }
    	      if (method) {
    	        const removeIdx = handlers.indexOf(method);
    	        if (removeIdx !== -1) {
    	          handlers.splice(removeIdx, 1);
    	          if (handlers.length === 0) {
    	            delete this._methods[methodName];
    	          }
    	        }
    	      } else {
    	        delete this._methods[methodName];
    	      }
    	    }
    	    /** Registers a handler that will be invoked when the connection is closed.
    	     *
    	     * @param {Function} callback The handler that will be invoked when the connection is closed. Optionally receives a single argument containing the error that caused the connection to close (if any).
    	     */
    	    onclose(callback) {
    	      if (callback) {
    	        this._closedCallbacks.push(callback);
    	      }
    	    }
    	    /** Registers a handler that will be invoked when the connection starts reconnecting.
    	     *
    	     * @param {Function} callback The handler that will be invoked when the connection starts reconnecting. Optionally receives a single argument containing the error that caused the connection to start reconnecting (if any).
    	     */
    	    onreconnecting(callback) {
    	      if (callback) {
    	        this._reconnectingCallbacks.push(callback);
    	      }
    	    }
    	    /** Registers a handler that will be invoked when the connection successfully reconnects.
    	     *
    	     * @param {Function} callback The handler that will be invoked when the connection successfully reconnects.
    	     */
    	    onreconnected(callback) {
    	      if (callback) {
    	        this._reconnectedCallbacks.push(callback);
    	      }
    	    }
    	    _processIncomingData(data) {
    	      this._cleanupTimeout();
    	      if (!this._receivedHandshakeResponse) {
    	        data = this._processHandshakeResponse(data);
    	        this._receivedHandshakeResponse = true;
    	      }
    	      // Data may have all been read when processing handshake response
    	      if (data) {
    	        // Parse the messages
    	        const messages = this._protocol.parseMessages(data, this._logger);
    	        for (const message of messages) {
    	          switch (message.type) {
    	            case MessageType.Invocation:
    	              // eslint-disable-next-line @typescript-eslint/no-floating-promises
    	              this._invokeClientMethod(message);
    	              break;
    	            case MessageType.StreamItem:
    	            case MessageType.Completion:
    	              {
    	                const callback = this._callbacks[message.invocationId];
    	                if (callback) {
    	                  if (message.type === MessageType.Completion) {
    	                    delete this._callbacks[message.invocationId];
    	                  }
    	                  try {
    	                    callback(message);
    	                  } catch (e) {
    	                    this._logger.log(LogLevel.Error, `Stream callback threw error: ${getErrorString(e)}`);
    	                  }
    	                }
    	                break;
    	              }
    	            case MessageType.Ping:
    	              // Don't care about pings
    	              break;
    	            case MessageType.Close:
    	              {
    	                this._logger.log(LogLevel.Information, "Close message received from server.");
    	                const error = message.error ? new Error("Server returned an error on close: " + message.error) : undefined;
    	                if (message.allowReconnect === true) {
    	                  // It feels wrong not to await connection.stop() here, but processIncomingData is called as part of an onreceive callback which is not async,
    	                  // this is already the behavior for serverTimeout(), and HttpConnection.Stop() should catch and log all possible exceptions.
    	                  // eslint-disable-next-line @typescript-eslint/no-floating-promises
    	                  this.connection.stop(error);
    	                } else {
    	                  // We cannot await stopInternal() here, but subsequent calls to stop() will await this if stopInternal() is still ongoing.
    	                  this._stopPromise = this._stopInternal(error);
    	                }
    	                break;
    	              }
    	            default:
    	              this._logger.log(LogLevel.Warning, `Invalid message type: ${message.type}.`);
    	              break;
    	          }
    	        }
    	      }
    	      this._resetTimeoutPeriod();
    	    }
    	    _processHandshakeResponse(data) {
    	      let responseMessage;
    	      let remainingData;
    	      try {
    	        [remainingData, responseMessage] = this._handshakeProtocol.parseHandshakeResponse(data);
    	      } catch (e) {
    	        const message = "Error parsing handshake response: " + e;
    	        this._logger.log(LogLevel.Error, message);
    	        const error = new Error(message);
    	        this._handshakeRejecter(error);
    	        throw error;
    	      }
    	      if (responseMessage.error) {
    	        const message = "Server returned handshake error: " + responseMessage.error;
    	        this._logger.log(LogLevel.Error, message);
    	        const error = new Error(message);
    	        this._handshakeRejecter(error);
    	        throw error;
    	      } else {
    	        this._logger.log(LogLevel.Debug, "Server handshake complete.");
    	      }
    	      this._handshakeResolver();
    	      return remainingData;
    	    }
    	    _resetKeepAliveInterval() {
    	      if (this.connection.features.inherentKeepAlive) {
    	        return;
    	      }
    	      // Set the time we want the next keep alive to be sent
    	      // Timer will be setup on next message receive
    	      this._nextKeepAlive = new Date().getTime() + this.keepAliveIntervalInMilliseconds;
    	      this._cleanupPingTimer();
    	    }
    	    _resetTimeoutPeriod() {
    	      if (!this.connection.features || !this.connection.features.inherentKeepAlive) {
    	        // Set the timeout timer
    	        this._timeoutHandle = setTimeout(() => this.serverTimeout(), this.serverTimeoutInMilliseconds);
    	        // Set keepAlive timer if there isn't one
    	        if (this._pingServerHandle === undefined) {
    	          let nextPing = this._nextKeepAlive - new Date().getTime();
    	          if (nextPing < 0) {
    	            nextPing = 0;
    	          }
    	          // The timer needs to be set from a networking callback to avoid Chrome timer throttling from causing timers to run once a minute
    	          this._pingServerHandle = setTimeout(async () => {
    	            if (this._connectionState === HubConnectionState.Connected) {
    	              try {
    	                await this._sendMessage(this._cachedPingMessage);
    	              } catch {
    	                // We don't care about the error. It should be seen elsewhere in the client.
    	                // The connection is probably in a bad or closed state now, cleanup the timer so it stops triggering
    	                this._cleanupPingTimer();
    	              }
    	            }
    	          }, nextPing);
    	        }
    	      }
    	    }
    	    // eslint-disable-next-line @typescript-eslint/naming-convention
    	    serverTimeout() {
    	      // The server hasn't talked to us in a while. It doesn't like us anymore ... :(
    	      // Terminate the connection, but we don't need to wait on the promise. This could trigger reconnecting.
    	      // eslint-disable-next-line @typescript-eslint/no-floating-promises
    	      this.connection.stop(new Error("Server timeout elapsed without receiving a message from the server."));
    	    }
    	    async _invokeClientMethod(invocationMessage) {
    	      const methodName = invocationMessage.target.toLowerCase();
    	      const methods = this._methods[methodName];
    	      if (!methods) {
    	        this._logger.log(LogLevel.Warning, `No client method with the name '${methodName}' found.`);
    	        // No handlers provided by client but the server is expecting a response still, so we send an error
    	        if (invocationMessage.invocationId) {
    	          this._logger.log(LogLevel.Warning, `No result given for '${methodName}' method and invocation ID '${invocationMessage.invocationId}'.`);
    	          await this._sendWithProtocol(this._createCompletionMessage(invocationMessage.invocationId, "Client didn't provide a result.", null));
    	        }
    	        return;
    	      }
    	      // Avoid issues with handlers removing themselves thus modifying the list while iterating through it
    	      const methodsCopy = methods.slice();
    	      // Server expects a response
    	      const expectsResponse = invocationMessage.invocationId ? true : false;
    	      // We preserve the last result or exception but still call all handlers
    	      let res;
    	      let exception;
    	      let completionMessage;
    	      for (const m of methodsCopy) {
    	        try {
    	          const prevRes = res;
    	          res = await m.apply(this, invocationMessage.arguments);
    	          if (expectsResponse && res && prevRes) {
    	            this._logger.log(LogLevel.Error, `Multiple results provided for '${methodName}'. Sending error to server.`);
    	            completionMessage = this._createCompletionMessage(invocationMessage.invocationId, `Client provided multiple results.`, null);
    	          }
    	          // Ignore exception if we got a result after, the exception will be logged
    	          exception = undefined;
    	        } catch (e) {
    	          exception = e;
    	          this._logger.log(LogLevel.Error, `A callback for the method '${methodName}' threw error '${e}'.`);
    	        }
    	      }
    	      if (completionMessage) {
    	        await this._sendWithProtocol(completionMessage);
    	      } else if (expectsResponse) {
    	        // If there is an exception that means either no result was given or a handler after a result threw
    	        if (exception) {
    	          completionMessage = this._createCompletionMessage(invocationMessage.invocationId, `${exception}`, null);
    	        } else if (res !== undefined) {
    	          completionMessage = this._createCompletionMessage(invocationMessage.invocationId, null, res);
    	        } else {
    	          this._logger.log(LogLevel.Warning, `No result given for '${methodName}' method and invocation ID '${invocationMessage.invocationId}'.`);
    	          // Client didn't provide a result or throw from a handler, server expects a response so we send an error
    	          completionMessage = this._createCompletionMessage(invocationMessage.invocationId, "Client didn't provide a result.", null);
    	        }
    	        await this._sendWithProtocol(completionMessage);
    	      } else {
    	        if (res) {
    	          this._logger.log(LogLevel.Error, `Result given for '${methodName}' method but server is not expecting a result.`);
    	        }
    	      }
    	    }
    	    _connectionClosed(error) {
    	      this._logger.log(LogLevel.Debug, `HubConnection.connectionClosed(${error}) called while in state ${this._connectionState}.`);
    	      // Triggering this.handshakeRejecter is insufficient because it could already be resolved without the continuation having run yet.
    	      this._stopDuringStartError = this._stopDuringStartError || error || new AbortError("The underlying connection was closed before the hub handshake could complete.");
    	      // If the handshake is in progress, start will be waiting for the handshake promise, so we complete it.
    	      // If it has already completed, this should just noop.
    	      if (this._handshakeResolver) {
    	        this._handshakeResolver();
    	      }
    	      this._cancelCallbacksWithError(error || new Error("Invocation canceled due to the underlying connection being closed."));
    	      this._cleanupTimeout();
    	      this._cleanupPingTimer();
    	      if (this._connectionState === HubConnectionState.Disconnecting) {
    	        this._completeClose(error);
    	      } else if (this._connectionState === HubConnectionState.Connected && this._reconnectPolicy) {
    	        // eslint-disable-next-line @typescript-eslint/no-floating-promises
    	        this._reconnect(error);
    	      } else if (this._connectionState === HubConnectionState.Connected) {
    	        this._completeClose(error);
    	      }
    	      // If none of the above if conditions were true were called the HubConnection must be in either:
    	      // 1. The Connecting state in which case the handshakeResolver will complete it and stopDuringStartError will fail it.
    	      // 2. The Reconnecting state in which case the handshakeResolver will complete it and stopDuringStartError will fail the current reconnect attempt
    	      //    and potentially continue the reconnect() loop.
    	      // 3. The Disconnected state in which case we're already done.
    	    }
    	    _completeClose(error) {
    	      if (this._connectionStarted) {
    	        this._connectionState = HubConnectionState.Disconnected;
    	        this._connectionStarted = false;
    	        if (Platform.isBrowser) {
    	          window.document.removeEventListener("freeze", this._freezeEventListener);
    	        }
    	        try {
    	          this._closedCallbacks.forEach(c => c.apply(this, [error]));
    	        } catch (e) {
    	          this._logger.log(LogLevel.Error, `An onclose callback called with error '${error}' threw error '${e}'.`);
    	        }
    	      }
    	    }
    	    async _reconnect(error) {
    	      const reconnectStartTime = Date.now();
    	      let previousReconnectAttempts = 0;
    	      let retryError = error !== undefined ? error : new Error("Attempting to reconnect due to a unknown error.");
    	      let nextRetryDelay = this._getNextRetryDelay(previousReconnectAttempts++, 0, retryError);
    	      if (nextRetryDelay === null) {
    	        this._logger.log(LogLevel.Debug, "Connection not reconnecting because the IRetryPolicy returned null on the first reconnect attempt.");
    	        this._completeClose(error);
    	        return;
    	      }
    	      this._connectionState = HubConnectionState.Reconnecting;
    	      if (error) {
    	        this._logger.log(LogLevel.Information, `Connection reconnecting because of error '${error}'.`);
    	      } else {
    	        this._logger.log(LogLevel.Information, "Connection reconnecting.");
    	      }
    	      if (this._reconnectingCallbacks.length !== 0) {
    	        try {
    	          this._reconnectingCallbacks.forEach(c => c.apply(this, [error]));
    	        } catch (e) {
    	          this._logger.log(LogLevel.Error, `An onreconnecting callback called with error '${error}' threw error '${e}'.`);
    	        }
    	        // Exit early if an onreconnecting callback called connection.stop().
    	        if (this._connectionState !== HubConnectionState.Reconnecting) {
    	          this._logger.log(LogLevel.Debug, "Connection left the reconnecting state in onreconnecting callback. Done reconnecting.");
    	          return;
    	        }
    	      }
    	      while (nextRetryDelay !== null) {
    	        this._logger.log(LogLevel.Information, `Reconnect attempt number ${previousReconnectAttempts} will start in ${nextRetryDelay} ms.`);
    	        await new Promise(resolve => {
    	          this._reconnectDelayHandle = setTimeout(resolve, nextRetryDelay);
    	        });
    	        this._reconnectDelayHandle = undefined;
    	        if (this._connectionState !== HubConnectionState.Reconnecting) {
    	          this._logger.log(LogLevel.Debug, "Connection left the reconnecting state during reconnect delay. Done reconnecting.");
    	          return;
    	        }
    	        try {
    	          await this._startInternal();
    	          this._connectionState = HubConnectionState.Connected;
    	          this._logger.log(LogLevel.Information, "HubConnection reconnected successfully.");
    	          if (this._reconnectedCallbacks.length !== 0) {
    	            try {
    	              this._reconnectedCallbacks.forEach(c => c.apply(this, [this.connection.connectionId]));
    	            } catch (e) {
    	              this._logger.log(LogLevel.Error, `An onreconnected callback called with connectionId '${this.connection.connectionId}; threw error '${e}'.`);
    	            }
    	          }
    	          return;
    	        } catch (e) {
    	          this._logger.log(LogLevel.Information, `Reconnect attempt failed because of error '${e}'.`);
    	          if (this._connectionState !== HubConnectionState.Reconnecting) {
    	            this._logger.log(LogLevel.Debug, `Connection moved to the '${this._connectionState}' from the reconnecting state during reconnect attempt. Done reconnecting.`);
    	            // The TypeScript compiler thinks that connectionState must be Connected here. The TypeScript compiler is wrong.
    	            if (this._connectionState === HubConnectionState.Disconnecting) {
    	              this._completeClose();
    	            }
    	            return;
    	          }
    	          retryError = e instanceof Error ? e : new Error(e.toString());
    	          nextRetryDelay = this._getNextRetryDelay(previousReconnectAttempts++, Date.now() - reconnectStartTime, retryError);
    	        }
    	      }
    	      this._logger.log(LogLevel.Information, `Reconnect retries have been exhausted after ${Date.now() - reconnectStartTime} ms and ${previousReconnectAttempts} failed attempts. Connection disconnecting.`);
    	      this._completeClose();
    	    }
    	    _getNextRetryDelay(previousRetryCount, elapsedMilliseconds, retryReason) {
    	      try {
    	        return this._reconnectPolicy.nextRetryDelayInMilliseconds({
    	          elapsedMilliseconds,
    	          previousRetryCount,
    	          retryReason
    	        });
    	      } catch (e) {
    	        this._logger.log(LogLevel.Error, `IRetryPolicy.nextRetryDelayInMilliseconds(${previousRetryCount}, ${elapsedMilliseconds}) threw error '${e}'.`);
    	        return null;
    	      }
    	    }
    	    _cancelCallbacksWithError(error) {
    	      const callbacks = this._callbacks;
    	      this._callbacks = {};
    	      Object.keys(callbacks).forEach(key => {
    	        const callback = callbacks[key];
    	        try {
    	          callback(null, error);
    	        } catch (e) {
    	          this._logger.log(LogLevel.Error, `Stream 'error' callback called with '${error}' threw error: ${getErrorString(e)}`);
    	        }
    	      });
    	    }
    	    _cleanupPingTimer() {
    	      if (this._pingServerHandle) {
    	        clearTimeout(this._pingServerHandle);
    	        this._pingServerHandle = undefined;
    	      }
    	    }
    	    _cleanupTimeout() {
    	      if (this._timeoutHandle) {
    	        clearTimeout(this._timeoutHandle);
    	      }
    	    }
    	    _createInvocation(methodName, args, nonblocking, streamIds) {
    	      if (nonblocking) {
    	        if (streamIds.length !== 0) {
    	          return {
    	            arguments: args,
    	            streamIds,
    	            target: methodName,
    	            type: MessageType.Invocation
    	          };
    	        } else {
    	          return {
    	            arguments: args,
    	            target: methodName,
    	            type: MessageType.Invocation
    	          };
    	        }
    	      } else {
    	        const invocationId = this._invocationId;
    	        this._invocationId++;
    	        if (streamIds.length !== 0) {
    	          return {
    	            arguments: args,
    	            invocationId: invocationId.toString(),
    	            streamIds,
    	            target: methodName,
    	            type: MessageType.Invocation
    	          };
    	        } else {
    	          return {
    	            arguments: args,
    	            invocationId: invocationId.toString(),
    	            target: methodName,
    	            type: MessageType.Invocation
    	          };
    	        }
    	      }
    	    }
    	    _launchStreams(streams, promiseQueue) {
    	      if (streams.length === 0) {
    	        return;
    	      }
    	      // Synchronize stream data so they arrive in-order on the server
    	      if (!promiseQueue) {
    	        promiseQueue = Promise.resolve();
    	      }
    	      // We want to iterate over the keys, since the keys are the stream ids
    	      // eslint-disable-next-line guard-for-in
    	      for (const streamId in streams) {
    	        streams[streamId].subscribe({
    	          complete: () => {
    	            promiseQueue = promiseQueue.then(() => this._sendWithProtocol(this._createCompletionMessage(streamId)));
    	          },
    	          error: err => {
    	            let message;
    	            if (err instanceof Error) {
    	              message = err.message;
    	            } else if (err && err.toString) {
    	              message = err.toString();
    	            } else {
    	              message = "Unknown error";
    	            }
    	            promiseQueue = promiseQueue.then(() => this._sendWithProtocol(this._createCompletionMessage(streamId, message)));
    	          },
    	          next: item => {
    	            promiseQueue = promiseQueue.then(() => this._sendWithProtocol(this._createStreamItemMessage(streamId, item)));
    	          }
    	        });
    	      }
    	    }
    	    _replaceStreamingParams(args) {
    	      const streams = [];
    	      const streamIds = [];
    	      for (let i = 0; i < args.length; i++) {
    	        const argument = args[i];
    	        if (this._isObservable(argument)) {
    	          const streamId = this._invocationId;
    	          this._invocationId++;
    	          // Store the stream for later use
    	          streams[streamId] = argument;
    	          streamIds.push(streamId.toString());
    	          // remove stream from args
    	          args.splice(i, 1);
    	        }
    	      }
    	      return [streams, streamIds];
    	    }
    	    _isObservable(arg) {
    	      // This allows other stream implementations to just work (like rxjs)
    	      return arg && arg.subscribe && typeof arg.subscribe === "function";
    	    }
    	    _createStreamInvocation(methodName, args, streamIds) {
    	      const invocationId = this._invocationId;
    	      this._invocationId++;
    	      if (streamIds.length !== 0) {
    	        return {
    	          arguments: args,
    	          invocationId: invocationId.toString(),
    	          streamIds,
    	          target: methodName,
    	          type: MessageType.StreamInvocation
    	        };
    	      } else {
    	        return {
    	          arguments: args,
    	          invocationId: invocationId.toString(),
    	          target: methodName,
    	          type: MessageType.StreamInvocation
    	        };
    	      }
    	    }
    	    _createCancelInvocation(id) {
    	      return {
    	        invocationId: id,
    	        type: MessageType.CancelInvocation
    	      };
    	    }
    	    _createStreamItemMessage(id, item) {
    	      return {
    	        invocationId: id,
    	        item,
    	        type: MessageType.StreamItem
    	      };
    	    }
    	    _createCompletionMessage(id, error, result) {
    	      if (error) {
    	        return {
    	          error,
    	          invocationId: id,
    	          type: MessageType.Completion
    	        };
    	      }
    	      return {
    	        invocationId: id,
    	        result,
    	        type: MessageType.Completion
    	      };
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  // 0, 2, 10, 30 second delays before reconnect attempts.
    	  const DEFAULT_RETRY_DELAYS_IN_MILLISECONDS = [0, 2000, 10000, 30000, null];
    	  /** @private */
    	  class DefaultReconnectPolicy {
    	    constructor(retryDelays) {
    	      this._retryDelays = retryDelays !== undefined ? [...retryDelays, null] : DEFAULT_RETRY_DELAYS_IN_MILLISECONDS;
    	    }
    	    nextRetryDelayInMilliseconds(retryContext) {
    	      return this._retryDelays[retryContext.previousRetryCount];
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  class HeaderNames {}
    	  HeaderNames.Authorization = "Authorization";
    	  HeaderNames.Cookie = "Cookie";

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  /** @private */
    	  class AccessTokenHttpClient extends HttpClient {
    	    constructor(innerClient, accessTokenFactory) {
    	      super();
    	      this._innerClient = innerClient;
    	      this._accessTokenFactory = accessTokenFactory;
    	    }
    	    async send(request) {
    	      let allowRetry = true;
    	      if (this._accessTokenFactory && (!this._accessToken || request.url && request.url.indexOf("/negotiate?") > 0)) {
    	        // don't retry if the request is a negotiate or if we just got a potentially new token from the access token factory
    	        allowRetry = false;
    	        this._accessToken = await this._accessTokenFactory();
    	      }
    	      this._setAuthorizationHeader(request);
    	      const response = await this._innerClient.send(request);
    	      if (allowRetry && response.statusCode === 401 && this._accessTokenFactory) {
    	        this._accessToken = await this._accessTokenFactory();
    	        this._setAuthorizationHeader(request);
    	        return await this._innerClient.send(request);
    	      }
    	      return response;
    	    }
    	    _setAuthorizationHeader(request) {
    	      if (!request.headers) {
    	        request.headers = {};
    	      }
    	      if (this._accessToken) {
    	        request.headers[HeaderNames.Authorization] = `Bearer ${this._accessToken}`;
    	      }
    	      // don't remove the header if there isn't an access token factory, the user manually added the header in this case
    	      else if (this._accessTokenFactory) {
    	        if (request.headers[HeaderNames.Authorization]) {
    	          delete request.headers[HeaderNames.Authorization];
    	        }
    	      }
    	    }
    	    getCookieString(url) {
    	      return this._innerClient.getCookieString(url);
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  // This will be treated as a bit flag in the future, so we keep it using power-of-two values.
    	  /** Specifies a specific HTTP transport type. */
    	  var HttpTransportType;
    	  (function (HttpTransportType) {
    	    /** Specifies no transport preference. */
    	    HttpTransportType[HttpTransportType["None"] = 0] = "None";
    	    /** Specifies the WebSockets transport. */
    	    HttpTransportType[HttpTransportType["WebSockets"] = 1] = "WebSockets";
    	    /** Specifies the Server-Sent Events transport. */
    	    HttpTransportType[HttpTransportType["ServerSentEvents"] = 2] = "ServerSentEvents";
    	    /** Specifies the Long Polling transport. */
    	    HttpTransportType[HttpTransportType["LongPolling"] = 4] = "LongPolling";
    	  })(HttpTransportType || (HttpTransportType = {}));
    	  /** Specifies the transfer format for a connection. */
    	  var TransferFormat;
    	  (function (TransferFormat) {
    	    /** Specifies that only text data will be transmitted over the connection. */
    	    TransferFormat[TransferFormat["Text"] = 1] = "Text";
    	    /** Specifies that binary data will be transmitted over the connection. */
    	    TransferFormat[TransferFormat["Binary"] = 2] = "Binary";
    	  })(TransferFormat || (TransferFormat = {}));

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  // Rough polyfill of https://developer.mozilla.org/en-US/docs/Web/API/AbortController
    	  // We don't actually ever use the API being polyfilled, we always use the polyfill because
    	  // it's a very new API right now.
    	  // Not exported from index.
    	  /** @private */
    	  let AbortController$1 = class AbortController {
    	    constructor() {
    	      this._isAborted = false;
    	      this.onabort = null;
    	    }
    	    abort() {
    	      if (!this._isAborted) {
    	        this._isAborted = true;
    	        if (this.onabort) {
    	          this.onabort();
    	        }
    	      }
    	    }
    	    get signal() {
    	      return this;
    	    }
    	    get aborted() {
    	      return this._isAborted;
    	    }
    	  };

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  // Not exported from 'index', this type is internal.
    	  /** @private */
    	  class LongPollingTransport {
    	    constructor(httpClient, logger, options) {
    	      this._httpClient = httpClient;
    	      this._logger = logger;
    	      this._pollAbort = new AbortController$1();
    	      this._options = options;
    	      this._running = false;
    	      this.onreceive = null;
    	      this.onclose = null;
    	    }
    	    // This is an internal type, not exported from 'index' so this is really just internal.
    	    get pollAborted() {
    	      return this._pollAbort.aborted;
    	    }
    	    async connect(url, transferFormat) {
    	      Arg.isRequired(url, "url");
    	      Arg.isRequired(transferFormat, "transferFormat");
    	      Arg.isIn(transferFormat, TransferFormat, "transferFormat");
    	      this._url = url;
    	      this._logger.log(LogLevel.Trace, "(LongPolling transport) Connecting.");
    	      // Allow binary format on Node and Browsers that support binary content (indicated by the presence of responseType property)
    	      if (transferFormat === TransferFormat.Binary && typeof XMLHttpRequest !== "undefined" && typeof new XMLHttpRequest().responseType !== "string") {
    	        throw new Error("Binary protocols over XmlHttpRequest not implementing advanced features are not supported.");
    	      }
    	      const [name, value] = getUserAgentHeader();
    	      const headers = {
    	        [name]: value,
    	        ...this._options.headers
    	      };
    	      const pollOptions = {
    	        abortSignal: this._pollAbort.signal,
    	        headers,
    	        timeout: 100000,
    	        withCredentials: this._options.withCredentials
    	      };
    	      if (transferFormat === TransferFormat.Binary) {
    	        pollOptions.responseType = "arraybuffer";
    	      }
    	      // Make initial long polling request
    	      // Server uses first long polling request to finish initializing connection and it returns without data
    	      const pollUrl = `${url}&_=${Date.now()}`;
    	      this._logger.log(LogLevel.Trace, `(LongPolling transport) polling: ${pollUrl}.`);
    	      const response = await this._httpClient.get(pollUrl, pollOptions);
    	      if (response.statusCode !== 200) {
    	        this._logger.log(LogLevel.Error, `(LongPolling transport) Unexpected response code: ${response.statusCode}.`);
    	        // Mark running as false so that the poll immediately ends and runs the close logic
    	        this._closeError = new HttpError(response.statusText || "", response.statusCode);
    	        this._running = false;
    	      } else {
    	        this._running = true;
    	      }
    	      this._receiving = this._poll(this._url, pollOptions);
    	    }
    	    async _poll(url, pollOptions) {
    	      try {
    	        while (this._running) {
    	          try {
    	            const pollUrl = `${url}&_=${Date.now()}`;
    	            this._logger.log(LogLevel.Trace, `(LongPolling transport) polling: ${pollUrl}.`);
    	            const response = await this._httpClient.get(pollUrl, pollOptions);
    	            if (response.statusCode === 204) {
    	              this._logger.log(LogLevel.Information, "(LongPolling transport) Poll terminated by server.");
    	              this._running = false;
    	            } else if (response.statusCode !== 200) {
    	              this._logger.log(LogLevel.Error, `(LongPolling transport) Unexpected response code: ${response.statusCode}.`);
    	              // Unexpected status code
    	              this._closeError = new HttpError(response.statusText || "", response.statusCode);
    	              this._running = false;
    	            } else {
    	              // Process the response
    	              if (response.content) {
    	                this._logger.log(LogLevel.Trace, `(LongPolling transport) data received. ${getDataDetail(response.content, this._options.logMessageContent)}.`);
    	                if (this.onreceive) {
    	                  this.onreceive(response.content);
    	                }
    	              } else {
    	                // This is another way timeout manifest.
    	                this._logger.log(LogLevel.Trace, "(LongPolling transport) Poll timed out, reissuing.");
    	              }
    	            }
    	          } catch (e) {
    	            if (!this._running) {
    	              // Log but disregard errors that occur after stopping
    	              this._logger.log(LogLevel.Trace, `(LongPolling transport) Poll errored after shutdown: ${e.message}`);
    	            } else {
    	              if (e instanceof TimeoutError) {
    	                // Ignore timeouts and reissue the poll.
    	                this._logger.log(LogLevel.Trace, "(LongPolling transport) Poll timed out, reissuing.");
    	              } else {
    	                // Close the connection with the error as the result.
    	                this._closeError = e;
    	                this._running = false;
    	              }
    	            }
    	          }
    	        }
    	      } finally {
    	        this._logger.log(LogLevel.Trace, "(LongPolling transport) Polling complete.");
    	        // We will reach here with pollAborted==false when the server returned a response causing the transport to stop.
    	        // If pollAborted==true then client initiated the stop and the stop method will raise the close event after DELETE is sent.
    	        if (!this.pollAborted) {
    	          this._raiseOnClose();
    	        }
    	      }
    	    }
    	    async send(data) {
    	      if (!this._running) {
    	        return Promise.reject(new Error("Cannot send until the transport is connected"));
    	      }
    	      return sendMessage(this._logger, "LongPolling", this._httpClient, this._url, data, this._options);
    	    }
    	    async stop() {
    	      this._logger.log(LogLevel.Trace, "(LongPolling transport) Stopping polling.");
    	      // Tell receiving loop to stop, abort any current request, and then wait for it to finish
    	      this._running = false;
    	      this._pollAbort.abort();
    	      try {
    	        await this._receiving;
    	        // Send DELETE to clean up long polling on the server
    	        this._logger.log(LogLevel.Trace, `(LongPolling transport) sending DELETE request to ${this._url}.`);
    	        const headers = {};
    	        const [name, value] = getUserAgentHeader();
    	        headers[name] = value;
    	        const deleteOptions = {
    	          headers: {
    	            ...headers,
    	            ...this._options.headers
    	          },
    	          timeout: this._options.timeout,
    	          withCredentials: this._options.withCredentials
    	        };
    	        await this._httpClient.delete(this._url, deleteOptions);
    	        this._logger.log(LogLevel.Trace, "(LongPolling transport) DELETE request sent.");
    	      } finally {
    	        this._logger.log(LogLevel.Trace, "(LongPolling transport) Stop finished.");
    	        // Raise close event here instead of in polling
    	        // It needs to happen after the DELETE request is sent
    	        this._raiseOnClose();
    	      }
    	    }
    	    _raiseOnClose() {
    	      if (this.onclose) {
    	        let logMessage = "(LongPolling transport) Firing onclose event.";
    	        if (this._closeError) {
    	          logMessage += " Error: " + this._closeError;
    	        }
    	        this._logger.log(LogLevel.Trace, logMessage);
    	        this.onclose(this._closeError);
    	      }
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  /** @private */
    	  class ServerSentEventsTransport {
    	    constructor(httpClient, accessToken, logger, options) {
    	      this._httpClient = httpClient;
    	      this._accessToken = accessToken;
    	      this._logger = logger;
    	      this._options = options;
    	      this.onreceive = null;
    	      this.onclose = null;
    	    }
    	    async connect(url, transferFormat) {
    	      Arg.isRequired(url, "url");
    	      Arg.isRequired(transferFormat, "transferFormat");
    	      Arg.isIn(transferFormat, TransferFormat, "transferFormat");
    	      this._logger.log(LogLevel.Trace, "(SSE transport) Connecting.");
    	      // set url before accessTokenFactory because this._url is only for send and we set the auth header instead of the query string for send
    	      this._url = url;
    	      if (this._accessToken) {
    	        url += (url.indexOf("?") < 0 ? "?" : "&") + `access_token=${encodeURIComponent(this._accessToken)}`;
    	      }
    	      return new Promise((resolve, reject) => {
    	        let opened = false;
    	        if (transferFormat !== TransferFormat.Text) {
    	          reject(new Error("The Server-Sent Events transport only supports the 'Text' transfer format"));
    	          return;
    	        }
    	        let eventSource;
    	        if (Platform.isBrowser || Platform.isWebWorker) {
    	          eventSource = new this._options.EventSource(url, {
    	            withCredentials: this._options.withCredentials
    	          });
    	        } else {
    	          // Non-browser passes cookies via the dictionary
    	          const cookies = this._httpClient.getCookieString(url);
    	          const headers = {};
    	          headers.Cookie = cookies;
    	          const [name, value] = getUserAgentHeader();
    	          headers[name] = value;
    	          eventSource = new this._options.EventSource(url, {
    	            withCredentials: this._options.withCredentials,
    	            headers: {
    	              ...headers,
    	              ...this._options.headers
    	            }
    	          });
    	        }
    	        try {
    	          eventSource.onmessage = e => {
    	            if (this.onreceive) {
    	              try {
    	                this._logger.log(LogLevel.Trace, `(SSE transport) data received. ${getDataDetail(e.data, this._options.logMessageContent)}.`);
    	                this.onreceive(e.data);
    	              } catch (error) {
    	                this._close(error);
    	                return;
    	              }
    	            }
    	          };
    	          // @ts-ignore: not using event on purpose
    	          eventSource.onerror = e => {
    	            // EventSource doesn't give any useful information about server side closes.
    	            if (opened) {
    	              this._close();
    	            } else {
    	              reject(new Error("EventSource failed to connect. The connection could not be found on the server," + " either the connection ID is not present on the server, or a proxy is refusing/buffering the connection." + " If you have multiple servers check that sticky sessions are enabled."));
    	            }
    	          };
    	          eventSource.onopen = () => {
    	            this._logger.log(LogLevel.Information, `SSE connected to ${this._url}`);
    	            this._eventSource = eventSource;
    	            opened = true;
    	            resolve();
    	          };
    	        } catch (e) {
    	          reject(e);
    	          return;
    	        }
    	      });
    	    }
    	    async send(data) {
    	      if (!this._eventSource) {
    	        return Promise.reject(new Error("Cannot send until the transport is connected"));
    	      }
    	      return sendMessage(this._logger, "SSE", this._httpClient, this._url, data, this._options);
    	    }
    	    stop() {
    	      this._close();
    	      return Promise.resolve();
    	    }
    	    _close(e) {
    	      if (this._eventSource) {
    	        this._eventSource.close();
    	        this._eventSource = undefined;
    	        if (this.onclose) {
    	          this.onclose(e);
    	        }
    	      }
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  /** @private */
    	  class WebSocketTransport {
    	    constructor(httpClient, accessTokenFactory, logger, logMessageContent, webSocketConstructor, headers) {
    	      this._logger = logger;
    	      this._accessTokenFactory = accessTokenFactory;
    	      this._logMessageContent = logMessageContent;
    	      this._webSocketConstructor = webSocketConstructor;
    	      this._httpClient = httpClient;
    	      this.onreceive = null;
    	      this.onclose = null;
    	      this._headers = headers;
    	    }
    	    async connect(url, transferFormat) {
    	      Arg.isRequired(url, "url");
    	      Arg.isRequired(transferFormat, "transferFormat");
    	      Arg.isIn(transferFormat, TransferFormat, "transferFormat");
    	      this._logger.log(LogLevel.Trace, "(WebSockets transport) Connecting.");
    	      let token;
    	      if (this._accessTokenFactory) {
    	        token = await this._accessTokenFactory();
    	      }
    	      return new Promise((resolve, reject) => {
    	        url = url.replace(/^http/, "ws");
    	        let webSocket;
    	        const cookies = this._httpClient.getCookieString(url);
    	        let opened = false;
    	        if (Platform.isNode || Platform.isReactNative) {
    	          const headers = {};
    	          const [name, value] = getUserAgentHeader();
    	          headers[name] = value;
    	          if (token) {
    	            headers[HeaderNames.Authorization] = `Bearer ${token}`;
    	          }
    	          if (cookies) {
    	            headers[HeaderNames.Cookie] = cookies;
    	          }
    	          // Only pass headers when in non-browser environments
    	          webSocket = new this._webSocketConstructor(url, undefined, {
    	            headers: {
    	              ...headers,
    	              ...this._headers
    	            }
    	          });
    	        } else {
    	          if (token) {
    	            url += (url.indexOf("?") < 0 ? "?" : "&") + `access_token=${encodeURIComponent(token)}`;
    	          }
    	        }
    	        if (!webSocket) {
    	          // Chrome is not happy with passing 'undefined' as protocol
    	          webSocket = new this._webSocketConstructor(url);
    	        }
    	        if (transferFormat === TransferFormat.Binary) {
    	          webSocket.binaryType = "arraybuffer";
    	        }
    	        webSocket.onopen = _event => {
    	          this._logger.log(LogLevel.Information, `WebSocket connected to ${url}.`);
    	          this._webSocket = webSocket;
    	          opened = true;
    	          resolve();
    	        };
    	        webSocket.onerror = event => {
    	          let error = null;
    	          // ErrorEvent is a browser only type we need to check if the type exists before using it
    	          if (typeof ErrorEvent !== "undefined" && event instanceof ErrorEvent) {
    	            error = event.error;
    	          } else {
    	            error = "There was an error with the transport";
    	          }
    	          this._logger.log(LogLevel.Information, `(WebSockets transport) ${error}.`);
    	        };
    	        webSocket.onmessage = message => {
    	          this._logger.log(LogLevel.Trace, `(WebSockets transport) data received. ${getDataDetail(message.data, this._logMessageContent)}.`);
    	          if (this.onreceive) {
    	            try {
    	              this.onreceive(message.data);
    	            } catch (error) {
    	              this._close(error);
    	              return;
    	            }
    	          }
    	        };
    	        webSocket.onclose = event => {
    	          // Don't call close handler if connection was never established
    	          // We'll reject the connect call instead
    	          if (opened) {
    	            this._close(event);
    	          } else {
    	            let error = null;
    	            // ErrorEvent is a browser only type we need to check if the type exists before using it
    	            if (typeof ErrorEvent !== "undefined" && event instanceof ErrorEvent) {
    	              error = event.error;
    	            } else {
    	              error = "WebSocket failed to connect. The connection could not be found on the server," + " either the endpoint may not be a SignalR endpoint," + " the connection ID is not present on the server, or there is a proxy blocking WebSockets." + " If you have multiple servers check that sticky sessions are enabled.";
    	            }
    	            reject(new Error(error));
    	          }
    	        };
    	      });
    	    }
    	    send(data) {
    	      if (this._webSocket && this._webSocket.readyState === this._webSocketConstructor.OPEN) {
    	        this._logger.log(LogLevel.Trace, `(WebSockets transport) sending data. ${getDataDetail(data, this._logMessageContent)}.`);
    	        this._webSocket.send(data);
    	        return Promise.resolve();
    	      }
    	      return Promise.reject("WebSocket is not in the OPEN state");
    	    }
    	    stop() {
    	      if (this._webSocket) {
    	        // Manually invoke onclose callback inline so we know the HttpConnection was closed properly before returning
    	        // This also solves an issue where websocket.onclose could take 18+ seconds to trigger during network disconnects
    	        this._close(undefined);
    	      }
    	      return Promise.resolve();
    	    }
    	    _close(event) {
    	      // webSocket will be null if the transport did not start successfully
    	      if (this._webSocket) {
    	        // Clear websocket handlers because we are considering the socket closed now
    	        this._webSocket.onclose = () => {};
    	        this._webSocket.onmessage = () => {};
    	        this._webSocket.onerror = () => {};
    	        this._webSocket.close();
    	        this._webSocket = undefined;
    	      }
    	      this._logger.log(LogLevel.Trace, "(WebSockets transport) socket closed.");
    	      if (this.onclose) {
    	        if (this._isCloseEvent(event) && (event.wasClean === false || event.code !== 1000)) {
    	          this.onclose(new Error(`WebSocket closed with status code: ${event.code} (${event.reason || "no reason given"}).`));
    	        } else if (event instanceof Error) {
    	          this.onclose(event);
    	        } else {
    	          this.onclose();
    	        }
    	      }
    	    }
    	    _isCloseEvent(event) {
    	      return event && typeof event.wasClean === "boolean" && typeof event.code === "number";
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  const MAX_REDIRECTS = 100;
    	  /** @private */
    	  class HttpConnection {
    	    constructor(url) {
    	      let options = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : {};
    	      this._stopPromiseResolver = () => {};
    	      this.features = {};
    	      this._negotiateVersion = 1;
    	      Arg.isRequired(url, "url");
    	      this._logger = createLogger(options.logger);
    	      this.baseUrl = this._resolveUrl(url);
    	      options = options || {};
    	      options.logMessageContent = options.logMessageContent === undefined ? false : options.logMessageContent;
    	      if (typeof options.withCredentials === "boolean" || options.withCredentials === undefined) {
    	        options.withCredentials = options.withCredentials === undefined ? true : options.withCredentials;
    	      } else {
    	        throw new Error("withCredentials option was not a 'boolean' or 'undefined' value");
    	      }
    	      options.timeout = options.timeout === undefined ? 100 * 1000 : options.timeout;
    	      let webSocketModule = null;
    	      let eventSourceModule = null;
    	      if (Platform.isNode && typeof commonjsRequire !== "undefined") {
    	        // In order to ignore the dynamic require in webpack builds we need to do this magic
    	        // @ts-ignore: TS doesn't know about these names
    	        const requireFunc = typeof __webpack_require__ === "function" ? __non_webpack_require__ : commonjsRequire;
    	        webSocketModule = requireFunc("ws");
    	        eventSourceModule = requireFunc("eventsource");
    	      }
    	      if (!Platform.isNode && typeof WebSocket !== "undefined" && !options.WebSocket) {
    	        options.WebSocket = WebSocket;
    	      } else if (Platform.isNode && !options.WebSocket) {
    	        if (webSocketModule) {
    	          options.WebSocket = webSocketModule;
    	        }
    	      }
    	      if (!Platform.isNode && typeof EventSource !== "undefined" && !options.EventSource) {
    	        options.EventSource = EventSource;
    	      } else if (Platform.isNode && !options.EventSource) {
    	        if (typeof eventSourceModule !== "undefined") {
    	          options.EventSource = eventSourceModule;
    	        }
    	      }
    	      this._httpClient = new AccessTokenHttpClient(options.httpClient || new DefaultHttpClient(this._logger), options.accessTokenFactory);
    	      this._connectionState = "Disconnected" /* Disconnected */;
    	      this._connectionStarted = false;
    	      this._options = options;
    	      this.onreceive = null;
    	      this.onclose = null;
    	    }
    	    async start(transferFormat) {
    	      transferFormat = transferFormat || TransferFormat.Binary;
    	      Arg.isIn(transferFormat, TransferFormat, "transferFormat");
    	      this._logger.log(LogLevel.Debug, `Starting connection with transfer format '${TransferFormat[transferFormat]}'.`);
    	      if (this._connectionState !== "Disconnected" /* Disconnected */) {
    	        return Promise.reject(new Error("Cannot start an HttpConnection that is not in the 'Disconnected' state."));
    	      }
    	      this._connectionState = "Connecting" /* Connecting */;
    	      this._startInternalPromise = this._startInternal(transferFormat);
    	      await this._startInternalPromise;
    	      // The TypeScript compiler thinks that connectionState must be Connecting here. The TypeScript compiler is wrong.
    	      if (this._connectionState === "Disconnecting" /* Disconnecting */) {
    	        // stop() was called and transitioned the client into the Disconnecting state.
    	        const message = "Failed to start the HttpConnection before stop() was called.";
    	        this._logger.log(LogLevel.Error, message);
    	        // We cannot await stopPromise inside startInternal since stopInternal awaits the startInternalPromise.
    	        await this._stopPromise;
    	        return Promise.reject(new AbortError(message));
    	      } else if (this._connectionState !== "Connected" /* Connected */) {
    	        // stop() was called and transitioned the client into the Disconnecting state.
    	        const message = "HttpConnection.startInternal completed gracefully but didn't enter the connection into the connected state!";
    	        this._logger.log(LogLevel.Error, message);
    	        return Promise.reject(new AbortError(message));
    	      }
    	      this._connectionStarted = true;
    	    }
    	    send(data) {
    	      if (this._connectionState !== "Connected" /* Connected */) {
    	        return Promise.reject(new Error("Cannot send data if the connection is not in the 'Connected' State."));
    	      }
    	      if (!this._sendQueue) {
    	        this._sendQueue = new TransportSendQueue(this.transport);
    	      }
    	      // Transport will not be null if state is connected
    	      return this._sendQueue.send(data);
    	    }
    	    async stop(error) {
    	      if (this._connectionState === "Disconnected" /* Disconnected */) {
    	        this._logger.log(LogLevel.Debug, `Call to HttpConnection.stop(${error}) ignored because the connection is already in the disconnected state.`);
    	        return Promise.resolve();
    	      }
    	      if (this._connectionState === "Disconnecting" /* Disconnecting */) {
    	        this._logger.log(LogLevel.Debug, `Call to HttpConnection.stop(${error}) ignored because the connection is already in the disconnecting state.`);
    	        return this._stopPromise;
    	      }
    	      this._connectionState = "Disconnecting" /* Disconnecting */;
    	      this._stopPromise = new Promise(resolve => {
    	        // Don't complete stop() until stopConnection() completes.
    	        this._stopPromiseResolver = resolve;
    	      });
    	      // stopInternal should never throw so just observe it.
    	      await this._stopInternal(error);
    	      await this._stopPromise;
    	    }
    	    async _stopInternal(error) {
    	      // Set error as soon as possible otherwise there is a race between
    	      // the transport closing and providing an error and the error from a close message
    	      // We would prefer the close message error.
    	      this._stopError = error;
    	      try {
    	        await this._startInternalPromise;
    	      } catch (e) {
    	        // This exception is returned to the user as a rejected Promise from the start method.
    	      }
    	      // The transport's onclose will trigger stopConnection which will run our onclose event.
    	      // The transport should always be set if currently connected. If it wasn't set, it's likely because
    	      // stop was called during start() and start() failed.
    	      if (this.transport) {
    	        try {
    	          await this.transport.stop();
    	        } catch (e) {
    	          this._logger.log(LogLevel.Error, `HttpConnection.transport.stop() threw error '${e}'.`);
    	          this._stopConnection();
    	        }
    	        this.transport = undefined;
    	      } else {
    	        this._logger.log(LogLevel.Debug, "HttpConnection.transport is undefined in HttpConnection.stop() because start() failed.");
    	      }
    	    }
    	    async _startInternal(transferFormat) {
    	      // Store the original base url and the access token factory since they may change
    	      // as part of negotiating
    	      let url = this.baseUrl;
    	      this._accessTokenFactory = this._options.accessTokenFactory;
    	      this._httpClient._accessTokenFactory = this._accessTokenFactory;
    	      try {
    	        if (this._options.skipNegotiation) {
    	          if (this._options.transport === HttpTransportType.WebSockets) {
    	            // No need to add a connection ID in this case
    	            this.transport = this._constructTransport(HttpTransportType.WebSockets);
    	            // We should just call connect directly in this case.
    	            // No fallback or negotiate in this case.
    	            await this._startTransport(url, transferFormat);
    	          } else {
    	            throw new Error("Negotiation can only be skipped when using the WebSocket transport directly.");
    	          }
    	        } else {
    	          let negotiateResponse = null;
    	          let redirects = 0;
    	          do {
    	            negotiateResponse = await this._getNegotiationResponse(url);
    	            // the user tries to stop the connection when it is being started
    	            if (this._connectionState === "Disconnecting" /* Disconnecting */ || this._connectionState === "Disconnected" /* Disconnected */) {
    	              throw new AbortError("The connection was stopped during negotiation.");
    	            }
    	            if (negotiateResponse.error) {
    	              throw new Error(negotiateResponse.error);
    	            }
    	            if (negotiateResponse.ProtocolVersion) {
    	              throw new Error("Detected a connection attempt to an ASP.NET SignalR Server. This client only supports connecting to an ASP.NET Core SignalR Server. See https://aka.ms/signalr-core-differences for details.");
    	            }
    	            if (negotiateResponse.url) {
    	              url = negotiateResponse.url;
    	            }
    	            if (negotiateResponse.accessToken) {
    	              // Replace the current access token factory with one that uses
    	              // the returned access token
    	              const accessToken = negotiateResponse.accessToken;
    	              this._accessTokenFactory = () => accessToken;
    	              // set the factory to undefined so the AccessTokenHttpClient won't retry with the same token, since we know it won't change until a connection restart
    	              this._httpClient._accessToken = accessToken;
    	              this._httpClient._accessTokenFactory = undefined;
    	            }
    	            redirects++;
    	          } while (negotiateResponse.url && redirects < MAX_REDIRECTS);
    	          if (redirects === MAX_REDIRECTS && negotiateResponse.url) {
    	            throw new Error("Negotiate redirection limit exceeded.");
    	          }
    	          await this._createTransport(url, this._options.transport, negotiateResponse, transferFormat);
    	        }
    	        if (this.transport instanceof LongPollingTransport) {
    	          this.features.inherentKeepAlive = true;
    	        }
    	        if (this._connectionState === "Connecting" /* Connecting */) {
    	          // Ensure the connection transitions to the connected state prior to completing this.startInternalPromise.
    	          // start() will handle the case when stop was called and startInternal exits still in the disconnecting state.
    	          this._logger.log(LogLevel.Debug, "The HttpConnection connected successfully.");
    	          this._connectionState = "Connected" /* Connected */;
    	        }
    	        // stop() is waiting on us via this.startInternalPromise so keep this.transport around so it can clean up.
    	        // This is the only case startInternal can exit in neither the connected nor disconnected state because stopConnection()
    	        // will transition to the disconnected state. start() will wait for the transition using the stopPromise.
    	      } catch (e) {
    	        this._logger.log(LogLevel.Error, "Failed to start the connection: " + e);
    	        this._connectionState = "Disconnected" /* Disconnected */;
    	        this.transport = undefined;
    	        // if start fails, any active calls to stop assume that start will complete the stop promise
    	        this._stopPromiseResolver();
    	        return Promise.reject(e);
    	      }
    	    }
    	    async _getNegotiationResponse(url) {
    	      const headers = {};
    	      const [name, value] = getUserAgentHeader();
    	      headers[name] = value;
    	      const negotiateUrl = this._resolveNegotiateUrl(url);
    	      this._logger.log(LogLevel.Debug, `Sending negotiation request: ${negotiateUrl}.`);
    	      try {
    	        const response = await this._httpClient.post(negotiateUrl, {
    	          content: "",
    	          headers: {
    	            ...headers,
    	            ...this._options.headers
    	          },
    	          timeout: this._options.timeout,
    	          withCredentials: this._options.withCredentials
    	        });
    	        if (response.statusCode !== 200) {
    	          return Promise.reject(new Error(`Unexpected status code returned from negotiate '${response.statusCode}'`));
    	        }
    	        const negotiateResponse = JSON.parse(response.content);
    	        if (!negotiateResponse.negotiateVersion || negotiateResponse.negotiateVersion < 1) {
    	          // Negotiate version 0 doesn't use connectionToken
    	          // So we set it equal to connectionId so all our logic can use connectionToken without being aware of the negotiate version
    	          negotiateResponse.connectionToken = negotiateResponse.connectionId;
    	        }
    	        return negotiateResponse;
    	      } catch (e) {
    	        let errorMessage = "Failed to complete negotiation with the server: " + e;
    	        if (e instanceof HttpError) {
    	          if (e.statusCode === 404) {
    	            errorMessage = errorMessage + " Either this is not a SignalR endpoint or there is a proxy blocking the connection.";
    	          }
    	        }
    	        this._logger.log(LogLevel.Error, errorMessage);
    	        return Promise.reject(new FailedToNegotiateWithServerError(errorMessage));
    	      }
    	    }
    	    _createConnectUrl(url, connectionToken) {
    	      if (!connectionToken) {
    	        return url;
    	      }
    	      return url + (url.indexOf("?") === -1 ? "?" : "&") + `id=${connectionToken}`;
    	    }
    	    async _createTransport(url, requestedTransport, negotiateResponse, requestedTransferFormat) {
    	      let connectUrl = this._createConnectUrl(url, negotiateResponse.connectionToken);
    	      if (this._isITransport(requestedTransport)) {
    	        this._logger.log(LogLevel.Debug, "Connection was provided an instance of ITransport, using that directly.");
    	        this.transport = requestedTransport;
    	        await this._startTransport(connectUrl, requestedTransferFormat);
    	        this.connectionId = negotiateResponse.connectionId;
    	        return;
    	      }
    	      const transportExceptions = [];
    	      const transports = negotiateResponse.availableTransports || [];
    	      let negotiate = negotiateResponse;
    	      for (const endpoint of transports) {
    	        const transportOrError = this._resolveTransportOrError(endpoint, requestedTransport, requestedTransferFormat);
    	        if (transportOrError instanceof Error) {
    	          // Store the error and continue, we don't want to cause a re-negotiate in these cases
    	          transportExceptions.push(`${endpoint.transport} failed:`);
    	          transportExceptions.push(transportOrError);
    	        } else if (this._isITransport(transportOrError)) {
    	          this.transport = transportOrError;
    	          if (!negotiate) {
    	            try {
    	              negotiate = await this._getNegotiationResponse(url);
    	            } catch (ex) {
    	              return Promise.reject(ex);
    	            }
    	            connectUrl = this._createConnectUrl(url, negotiate.connectionToken);
    	          }
    	          try {
    	            await this._startTransport(connectUrl, requestedTransferFormat);
    	            this.connectionId = negotiate.connectionId;
    	            return;
    	          } catch (ex) {
    	            this._logger.log(LogLevel.Error, `Failed to start the transport '${endpoint.transport}': ${ex}`);
    	            negotiate = undefined;
    	            transportExceptions.push(new FailedToStartTransportError(`${endpoint.transport} failed: ${ex}`, HttpTransportType[endpoint.transport]));
    	            if (this._connectionState !== "Connecting" /* Connecting */) {
    	              const message = "Failed to select transport before stop() was called.";
    	              this._logger.log(LogLevel.Debug, message);
    	              return Promise.reject(new AbortError(message));
    	            }
    	          }
    	        }
    	      }
    	      if (transportExceptions.length > 0) {
    	        return Promise.reject(new AggregateErrors(`Unable to connect to the server with any of the available transports. ${transportExceptions.join(" ")}`, transportExceptions));
    	      }
    	      return Promise.reject(new Error("None of the transports supported by the client are supported by the server."));
    	    }
    	    _constructTransport(transport) {
    	      switch (transport) {
    	        case HttpTransportType.WebSockets:
    	          if (!this._options.WebSocket) {
    	            throw new Error("'WebSocket' is not supported in your environment.");
    	          }
    	          return new WebSocketTransport(this._httpClient, this._accessTokenFactory, this._logger, this._options.logMessageContent, this._options.WebSocket, this._options.headers || {});
    	        case HttpTransportType.ServerSentEvents:
    	          if (!this._options.EventSource) {
    	            throw new Error("'EventSource' is not supported in your environment.");
    	          }
    	          return new ServerSentEventsTransport(this._httpClient, this._httpClient._accessToken, this._logger, this._options);
    	        case HttpTransportType.LongPolling:
    	          return new LongPollingTransport(this._httpClient, this._logger, this._options);
    	        default:
    	          throw new Error(`Unknown transport: ${transport}.`);
    	      }
    	    }
    	    _startTransport(url, transferFormat) {
    	      this.transport.onreceive = this.onreceive;
    	      this.transport.onclose = e => this._stopConnection(e);
    	      return this.transport.connect(url, transferFormat);
    	    }
    	    _resolveTransportOrError(endpoint, requestedTransport, requestedTransferFormat) {
    	      const transport = HttpTransportType[endpoint.transport];
    	      if (transport === null || transport === undefined) {
    	        this._logger.log(LogLevel.Debug, `Skipping transport '${endpoint.transport}' because it is not supported by this client.`);
    	        return new Error(`Skipping transport '${endpoint.transport}' because it is not supported by this client.`);
    	      } else {
    	        if (transportMatches(requestedTransport, transport)) {
    	          const transferFormats = endpoint.transferFormats.map(s => TransferFormat[s]);
    	          if (transferFormats.indexOf(requestedTransferFormat) >= 0) {
    	            if (transport === HttpTransportType.WebSockets && !this._options.WebSocket || transport === HttpTransportType.ServerSentEvents && !this._options.EventSource) {
    	              this._logger.log(LogLevel.Debug, `Skipping transport '${HttpTransportType[transport]}' because it is not supported in your environment.'`);
    	              return new UnsupportedTransportError(`'${HttpTransportType[transport]}' is not supported in your environment.`, transport);
    	            } else {
    	              this._logger.log(LogLevel.Debug, `Selecting transport '${HttpTransportType[transport]}'.`);
    	              try {
    	                return this._constructTransport(transport);
    	              } catch (ex) {
    	                return ex;
    	              }
    	            }
    	          } else {
    	            this._logger.log(LogLevel.Debug, `Skipping transport '${HttpTransportType[transport]}' because it does not support the requested transfer format '${TransferFormat[requestedTransferFormat]}'.`);
    	            return new Error(`'${HttpTransportType[transport]}' does not support ${TransferFormat[requestedTransferFormat]}.`);
    	          }
    	        } else {
    	          this._logger.log(LogLevel.Debug, `Skipping transport '${HttpTransportType[transport]}' because it was disabled by the client.`);
    	          return new DisabledTransportError(`'${HttpTransportType[transport]}' is disabled by the client.`, transport);
    	        }
    	      }
    	    }
    	    _isITransport(transport) {
    	      return transport && typeof transport === "object" && "connect" in transport;
    	    }
    	    _stopConnection(error) {
    	      this._logger.log(LogLevel.Debug, `HttpConnection.stopConnection(${error}) called while in state ${this._connectionState}.`);
    	      this.transport = undefined;
    	      // If we have a stopError, it takes precedence over the error from the transport
    	      error = this._stopError || error;
    	      this._stopError = undefined;
    	      if (this._connectionState === "Disconnected" /* Disconnected */) {
    	        this._logger.log(LogLevel.Debug, `Call to HttpConnection.stopConnection(${error}) was ignored because the connection is already in the disconnected state.`);
    	        return;
    	      }
    	      if (this._connectionState === "Connecting" /* Connecting */) {
    	        this._logger.log(LogLevel.Warning, `Call to HttpConnection.stopConnection(${error}) was ignored because the connection is still in the connecting state.`);
    	        throw new Error(`HttpConnection.stopConnection(${error}) was called while the connection is still in the connecting state.`);
    	      }
    	      if (this._connectionState === "Disconnecting" /* Disconnecting */) {
    	        // A call to stop() induced this call to stopConnection and needs to be completed.
    	        // Any stop() awaiters will be scheduled to continue after the onclose callback fires.
    	        this._stopPromiseResolver();
    	      }
    	      if (error) {
    	        this._logger.log(LogLevel.Error, `Connection disconnected with error '${error}'.`);
    	      } else {
    	        this._logger.log(LogLevel.Information, "Connection disconnected.");
    	      }
    	      if (this._sendQueue) {
    	        this._sendQueue.stop().catch(e => {
    	          this._logger.log(LogLevel.Error, `TransportSendQueue.stop() threw error '${e}'.`);
    	        });
    	        this._sendQueue = undefined;
    	      }
    	      this.connectionId = undefined;
    	      this._connectionState = "Disconnected" /* Disconnected */;
    	      if (this._connectionStarted) {
    	        this._connectionStarted = false;
    	        try {
    	          if (this.onclose) {
    	            this.onclose(error);
    	          }
    	        } catch (e) {
    	          this._logger.log(LogLevel.Error, `HttpConnection.onclose(${error}) threw error '${e}'.`);
    	        }
    	      }
    	    }
    	    _resolveUrl(url) {
    	      // startsWith is not supported in IE
    	      if (url.lastIndexOf("https://", 0) === 0 || url.lastIndexOf("http://", 0) === 0) {
    	        return url;
    	      }
    	      if (!Platform.isBrowser) {
    	        throw new Error(`Cannot resolve '${url}'.`);
    	      }
    	      // Setting the url to the href propery of an anchor tag handles normalization
    	      // for us. There are 3 main cases.
    	      // 1. Relative path normalization e.g "b" -> "http://localhost:5000/a/b"
    	      // 2. Absolute path normalization e.g "/a/b" -> "http://localhost:5000/a/b"
    	      // 3. Networkpath reference normalization e.g "//localhost:5000/a/b" -> "http://localhost:5000/a/b"
    	      const aTag = window.document.createElement("a");
    	      aTag.href = url;
    	      this._logger.log(LogLevel.Information, `Normalizing '${url}' to '${aTag.href}'.`);
    	      return aTag.href;
    	    }
    	    _resolveNegotiateUrl(url) {
    	      const index = url.indexOf("?");
    	      let negotiateUrl = url.substring(0, index === -1 ? url.length : index);
    	      if (negotiateUrl[negotiateUrl.length - 1] !== "/") {
    	        negotiateUrl += "/";
    	      }
    	      negotiateUrl += "negotiate";
    	      negotiateUrl += index === -1 ? "" : url.substring(index);
    	      if (negotiateUrl.indexOf("negotiateVersion") === -1) {
    	        negotiateUrl += index === -1 ? "?" : "&";
    	        negotiateUrl += "negotiateVersion=" + this._negotiateVersion;
    	      }
    	      return negotiateUrl;
    	    }
    	  }
    	  function transportMatches(requestedTransport, actualTransport) {
    	    return !requestedTransport || (actualTransport & requestedTransport) !== 0;
    	  }
    	  /** @private */
    	  class TransportSendQueue {
    	    constructor(_transport) {
    	      this._transport = _transport;
    	      this._buffer = [];
    	      this._executing = true;
    	      this._sendBufferedData = new PromiseSource();
    	      this._transportResult = new PromiseSource();
    	      this._sendLoopPromise = this._sendLoop();
    	    }
    	    send(data) {
    	      this._bufferData(data);
    	      if (!this._transportResult) {
    	        this._transportResult = new PromiseSource();
    	      }
    	      return this._transportResult.promise;
    	    }
    	    stop() {
    	      this._executing = false;
    	      this._sendBufferedData.resolve();
    	      return this._sendLoopPromise;
    	    }
    	    _bufferData(data) {
    	      if (this._buffer.length && typeof this._buffer[0] !== typeof data) {
    	        throw new Error(`Expected data to be of type ${typeof this._buffer} but was of type ${typeof data}`);
    	      }
    	      this._buffer.push(data);
    	      this._sendBufferedData.resolve();
    	    }
    	    async _sendLoop() {
    	      while (true) {
    	        await this._sendBufferedData.promise;
    	        if (!this._executing) {
    	          if (this._transportResult) {
    	            this._transportResult.reject("Connection stopped.");
    	          }
    	          break;
    	        }
    	        this._sendBufferedData = new PromiseSource();
    	        const transportResult = this._transportResult;
    	        this._transportResult = undefined;
    	        const data = typeof this._buffer[0] === "string" ? this._buffer.join("") : TransportSendQueue._concatBuffers(this._buffer);
    	        this._buffer.length = 0;
    	        try {
    	          await this._transport.send(data);
    	          transportResult.resolve();
    	        } catch (error) {
    	          transportResult.reject(error);
    	        }
    	      }
    	    }
    	    static _concatBuffers(arrayBuffers) {
    	      const totalLength = arrayBuffers.map(b => b.byteLength).reduce((a, b) => a + b);
    	      const result = new Uint8Array(totalLength);
    	      let offset = 0;
    	      for (const item of arrayBuffers) {
    	        result.set(new Uint8Array(item), offset);
    	        offset += item.byteLength;
    	      }
    	      return result.buffer;
    	    }
    	  }
    	  class PromiseSource {
    	    constructor() {
    	      this.promise = new Promise((resolve, reject) => [this._resolver, this._rejecter] = [resolve, reject]);
    	    }
    	    resolve() {
    	      this._resolver();
    	    }
    	    reject(reason) {
    	      this._rejecter(reason);
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  const JSON_HUB_PROTOCOL_NAME = "json";
    	  /** Implements the JSON Hub Protocol. */
    	  class JsonHubProtocol {
    	    constructor() {
    	      /** @inheritDoc */
    	      this.name = JSON_HUB_PROTOCOL_NAME;
    	      /** @inheritDoc */
    	      this.version = 1;
    	      /** @inheritDoc */
    	      this.transferFormat = TransferFormat.Text;
    	    }
    	    /** Creates an array of {@link @microsoft/signalr.HubMessage} objects from the specified serialized representation.
    	     *
    	     * @param {string} input A string containing the serialized representation.
    	     * @param {ILogger} logger A logger that will be used to log messages that occur during parsing.
    	     */
    	    parseMessages(input, logger) {
    	      // The interface does allow "ArrayBuffer" to be passed in, but this implementation does not. So let's throw a useful error.
    	      if (typeof input !== "string") {
    	        throw new Error("Invalid input for JSON hub protocol. Expected a string.");
    	      }
    	      if (!input) {
    	        return [];
    	      }
    	      if (logger === null) {
    	        logger = NullLogger.instance;
    	      }
    	      // Parse the messages
    	      const messages = TextMessageFormat.parse(input);
    	      const hubMessages = [];
    	      for (const message of messages) {
    	        const parsedMessage = JSON.parse(message);
    	        if (typeof parsedMessage.type !== "number") {
    	          throw new Error("Invalid payload.");
    	        }
    	        switch (parsedMessage.type) {
    	          case MessageType.Invocation:
    	            this._isInvocationMessage(parsedMessage);
    	            break;
    	          case MessageType.StreamItem:
    	            this._isStreamItemMessage(parsedMessage);
    	            break;
    	          case MessageType.Completion:
    	            this._isCompletionMessage(parsedMessage);
    	            break;
    	          case MessageType.Ping:
    	            // Single value, no need to validate
    	            break;
    	          case MessageType.Close:
    	            // All optional values, no need to validate
    	            break;
    	          default:
    	            // Future protocol changes can add message types, old clients can ignore them
    	            logger.log(LogLevel.Information, "Unknown message type '" + parsedMessage.type + "' ignored.");
    	            continue;
    	        }
    	        hubMessages.push(parsedMessage);
    	      }
    	      return hubMessages;
    	    }
    	    /** Writes the specified {@link @microsoft/signalr.HubMessage} to a string and returns it.
    	     *
    	     * @param {HubMessage} message The message to write.
    	     * @returns {string} A string containing the serialized representation of the message.
    	     */
    	    writeMessage(message) {
    	      return TextMessageFormat.write(JSON.stringify(message));
    	    }
    	    _isInvocationMessage(message) {
    	      this._assertNotEmptyString(message.target, "Invalid payload for Invocation message.");
    	      if (message.invocationId !== undefined) {
    	        this._assertNotEmptyString(message.invocationId, "Invalid payload for Invocation message.");
    	      }
    	    }
    	    _isStreamItemMessage(message) {
    	      this._assertNotEmptyString(message.invocationId, "Invalid payload for StreamItem message.");
    	      if (message.item === undefined) {
    	        throw new Error("Invalid payload for StreamItem message.");
    	      }
    	    }
    	    _isCompletionMessage(message) {
    	      if (message.result && message.error) {
    	        throw new Error("Invalid payload for Completion message.");
    	      }
    	      if (!message.result && message.error) {
    	        this._assertNotEmptyString(message.error, "Invalid payload for Completion message.");
    	      }
    	      this._assertNotEmptyString(message.invocationId, "Invalid payload for Completion message.");
    	    }
    	    _assertNotEmptyString(value, errorMessage) {
    	      if (typeof value !== "string" || value === "") {
    	        throw new Error(errorMessage);
    	      }
    	    }
    	  }

    	  // Licensed to the .NET Foundation under one or more agreements.
    	  // The .NET Foundation licenses this file to you under the MIT license.
    	  const LogLevelNameMapping = {
    	    trace: LogLevel.Trace,
    	    debug: LogLevel.Debug,
    	    info: LogLevel.Information,
    	    information: LogLevel.Information,
    	    warn: LogLevel.Warning,
    	    warning: LogLevel.Warning,
    	    error: LogLevel.Error,
    	    critical: LogLevel.Critical,
    	    none: LogLevel.None
    	  };
    	  function parseLogLevel(name) {
    	    // Case-insensitive matching via lower-casing
    	    // Yes, I know case-folding is a complicated problem in Unicode, but we only support
    	    // the ASCII strings defined in LogLevelNameMapping anyway, so it's fine -anurse.
    	    const mapping = LogLevelNameMapping[name.toLowerCase()];
    	    if (typeof mapping !== "undefined") {
    	      return mapping;
    	    } else {
    	      throw new Error(`Unknown log level: ${name}`);
    	    }
    	  }
    	  /** A builder for configuring {@link @microsoft/signalr.HubConnection} instances. */
    	  class HubConnectionBuilder {
    	    configureLogging(logging) {
    	      Arg.isRequired(logging, "logging");
    	      if (isLogger(logging)) {
    	        this.logger = logging;
    	      } else if (typeof logging === "string") {
    	        const logLevel = parseLogLevel(logging);
    	        this.logger = new ConsoleLogger(logLevel);
    	      } else {
    	        this.logger = new ConsoleLogger(logging);
    	      }
    	      return this;
    	    }
    	    withUrl(url, transportTypeOrOptions) {
    	      Arg.isRequired(url, "url");
    	      Arg.isNotEmpty(url, "url");
    	      this.url = url;
    	      // Flow-typing knows where it's at. Since HttpTransportType is a number and IHttpConnectionOptions is guaranteed
    	      // to be an object, we know (as does TypeScript) this comparison is all we need to figure out which overload was called.
    	      if (typeof transportTypeOrOptions === "object") {
    	        this.httpConnectionOptions = {
    	          ...this.httpConnectionOptions,
    	          ...transportTypeOrOptions
    	        };
    	      } else {
    	        this.httpConnectionOptions = {
    	          ...this.httpConnectionOptions,
    	          transport: transportTypeOrOptions
    	        };
    	      }
    	      return this;
    	    }
    	    /** Configures the {@link @microsoft/signalr.HubConnection} to use the specified Hub Protocol.
    	     *
    	     * @param {IHubProtocol} protocol The {@link @microsoft/signalr.IHubProtocol} implementation to use.
    	     */
    	    withHubProtocol(protocol) {
    	      Arg.isRequired(protocol, "protocol");
    	      this.protocol = protocol;
    	      return this;
    	    }
    	    withAutomaticReconnect(retryDelaysOrReconnectPolicy) {
    	      if (this.reconnectPolicy) {
    	        throw new Error("A reconnectPolicy has already been set.");
    	      }
    	      if (!retryDelaysOrReconnectPolicy) {
    	        this.reconnectPolicy = new DefaultReconnectPolicy();
    	      } else if (Array.isArray(retryDelaysOrReconnectPolicy)) {
    	        this.reconnectPolicy = new DefaultReconnectPolicy(retryDelaysOrReconnectPolicy);
    	      } else {
    	        this.reconnectPolicy = retryDelaysOrReconnectPolicy;
    	      }
    	      return this;
    	    }
    	    /** Creates a {@link @microsoft/signalr.HubConnection} from the configuration options specified in this builder.
    	     *
    	     * @returns {HubConnection} The configured {@link @microsoft/signalr.HubConnection}.
    	     */
    	    build() {
    	      // If httpConnectionOptions has a logger, use it. Otherwise, override it with the one
    	      // provided to configureLogger
    	      const httpConnectionOptions = this.httpConnectionOptions || {};
    	      // If it's 'null', the user **explicitly** asked for null, don't mess with it.
    	      if (httpConnectionOptions.logger === undefined) {
    	        // If our logger is undefined or null, that's OK, the HttpConnection constructor will handle it.
    	        httpConnectionOptions.logger = this.logger;
    	      }
    	      // Now create the connection
    	      if (!this.url) {
    	        throw new Error("The 'HubConnectionBuilder.withUrl' method must be called before building the connection.");
    	      }
    	      const connection = new HttpConnection(this.url, httpConnectionOptions);
    	      return HubConnection.create(connection, this.logger || NullLogger.instance, this.protocol || new JsonHubProtocol(), this.reconnectPolicy);
    	    }
    	  }
    	  function isLogger(logger) {
    	    return logger.log !== undefined;
    	  }
    	  function ensureTokenString(getToken) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      var _a;
    	      if (!getToken) return "";
    	      return (_a = yield getToken()) !== null && _a !== void 0 ? _a : "";
    	    });
    	  }
    	  const createHubConnection = _ref18 => {
    	    let {
    	      builder = new HubConnectionBuilder(),
    	      hubEndpoint,
    	      appUrl,
    	      logger,
    	      getToken
    	    } = _ref18;
    	    if (!appUrl) {
    	      throw new Error("The AppUrl and HubEndpoint must be defined in order to use SignalR communications");
    	    }
    	    const hubConnectionBuilder = builder.withUrl(new URL(hubEndpoint, appUrl).href, {
    	      accessTokenFactory: () => __awaiter(void 0, void 0, void 0, function* () {
    	        const authToken = yield ensureTokenString(getToken);
    	        const strippedAuthToken = authToken.replace("Bearer ", "");
    	        return strippedAuthToken;
    	      })
    	    }).withAutomaticReconnect();
    	    if (logger) {
    	      hubConnectionBuilder.configureLogging({
    	        log: (logLevel, message) => {
    	          var _a, _b;
    	          switch (logLevel) {
    	            case LogLevel.Information:
    	            case LogLevel.Trace:
    	            case LogLevel.Debug:
    	            case LogLevel.Warning:
    	              (_a = logger.debug) === null || _a === void 0 ? void 0 : _a.call(logger, {
    	                category: "SignalRHttpClient",
    	                message: `HubConnection ${message}`
    	              });
    	              break;
    	            case LogLevel.Error:
    	            case LogLevel.Critical:
    	              (_b = logger.error) === null || _b === void 0 ? void 0 : _b.call(logger, {
    	                category: "SignalRHttpClient",
    	                message: `Handler Error: HubConnection ${message}`,
    	                errorCode: ErrorCodes.Communication_Default,
    	                error: new Error(message)
    	              });
    	              break;
    	          }
    	        }
    	      });
    	    }
    	    return hubConnectionBuilder.build();
    	  };
    	  var _SignalRClient_instances, _SignalRClient_localeHeader, _SignalRClient_getLocale, _SignalRClient_setLocale, _SignalRClient_logger, _SignalRClient_appUrl, _SignalRClient_getToken, _SignalRClient_processError;
    	  const HUB_ENDPOINT = "moduleservices/debugger/requestshub";
    	  const LOCALE_HEADER = "";
    	  const LOG_CATEGORY$1 = "SignalRHttpClient";
    	  class SignalRClient {
    	    constructor(_ref19) {
    	      let {
    	        appUrl,
    	        localeHeader = LOCALE_HEADER,
    	        getLocale,
    	        setLocale,
    	        logger,
    	        getToken
    	      } = _ref19;
    	      _SignalRClient_instances.add(this);
    	      _SignalRClient_localeHeader.set(this, void 0);
    	      _SignalRClient_getLocale.set(this, void 0);
    	      _SignalRClient_setLocale.set(this, void 0);
    	      _SignalRClient_logger.set(this, void 0);
    	      _SignalRClient_appUrl.set(this, void 0);
    	      _SignalRClient_getToken.set(this, void 0);
    	      __classPrivateFieldSet(this, _SignalRClient_appUrl, replaceNativeRequestProtocol(appUrl));
    	      __classPrivateFieldSet(this, _SignalRClient_localeHeader, localeHeader);
    	      __classPrivateFieldSet(this, _SignalRClient_getLocale, getLocale);
    	      __classPrivateFieldSet(this, _SignalRClient_setLocale, setLocale);
    	      __classPrivateFieldSet(this, _SignalRClient_logger, logger);
    	      __classPrivateFieldSet(this, _SignalRClient_getToken, getToken);
    	    }
    	    executeRequest(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref20) {
    	        var _this9 = this;
    	        let {
    	          url,
    	          payload,
    	          headers,
    	          contentType = ContentType$1.FormUrlEncoded,
    	          useLocaleInfo = false,
    	          abortCommand,
    	          responseHandler,
    	          hubConnectionBuilder = new HubConnectionBuilder()
    	        } = _ref20;
    	        return function* () {
    	          var _b, _c, _d, _e, _f, _g, _h, _j, _k, _l, _m, _o, _p, _q;
    	          if (abortCommand) {
    	            abortCommand.onAbort = () => {
    	              hasAborted = true;
    	            };
    	          }
    	          let hasAborted = false;
    	          (_c = (_b = __classPrivateFieldGet(_this9, _SignalRClient_logger, "f")) === null || _b === void 0 ? void 0 : _b.setActiveSpanAsNonAggregable) === null || _c === void 0 ? void 0 : _c.call(_b);
    	          const hubConnectionInstance = createHubConnection({
    	            builder: hubConnectionBuilder,
    	            hubEndpoint: HUB_ENDPOINT,
    	            appUrl: __classPrivateFieldGet(_this9, _SignalRClient_appUrl, "f"),
    	            logger: __classPrivateFieldGet(_this9, _SignalRClient_logger, "f"),
    	            getToken: __classPrivateFieldGet(_this9, _SignalRClient_getToken, "f")
    	          });
    	          const locale = useLocaleInfo ? (_d = __classPrivateFieldGet(_this9, _SignalRClient_getLocale, "f")) === null || _d === void 0 ? void 0 : _d.call(_this9) : undefined;
    	          const requestHeaders = Object.assign(Object.assign(Object.assign({}, headers), locale ? {
    	            [__classPrivateFieldGet(_this9, _SignalRClient_localeHeader, "f")]: locale
    	          } : {}), missingContentType({
    	            payload,
    	            headers
    	          }) ? {
    	            "content-type": contentType
    	          } : {});
    	          try {
    	            const requestPayload = payload ? stringifyPayload({
    	              payload,
    	              contentType
    	            }) : undefined;
    	            yield hubConnectionInstance.start();
    	            const response = yield hubConnectionInstance.invoke("ExecuteRequest", new URL(url, __classPrivateFieldGet(_this9, _SignalRClient_appUrl, "f")).pathname, requestPayload, requestHeaders);
    	            yield hubConnectionInstance.stop();
    	            (_f = (_e = __classPrivateFieldGet(_this9, _SignalRClient_logger, "f")) === null || _e === void 0 ? void 0 : _e.debug) === null || _f === void 0 ? void 0 : _f.call(_e, {
    	              category: LOG_CATEGORY$1,
    	              message: `ExecuteRequest ${url}`
    	            });
    	            const responseBody = tryParseResponse(response === null || response === void 0 ? void 0 : response.ResponseBody, __classPrivateFieldGet(_this9, _SignalRClient_logger, "f"), LOG_CATEGORY$1);
    	            if (!(response === null || response === void 0 ? void 0 : response.ResponseStatusCode) || response.ResponseStatusCode < 200 || response.ResponseStatusCode > 299) {
    	              const status = (_j = (_h = (_g = response === null || response === void 0 ? void 0 : response.ResponseStatusCode) === null || _g === void 0 ? void 0 : _g.toString) === null || _h === void 0 ? void 0 : _h.call(_g)) !== null && _j !== void 0 ? _j : "";
    	              const errorCode = mapErrorCodeFromStatusCode(status);
    	              throw new CommunicationError((_l = (_k = responseBody === null || responseBody === void 0 ? void 0 : responseBody.exception) === null || _k === void 0 ? void 0 : _k.message) !== null && _l !== void 0 ? _l : "Network Error", (_o = (_m = responseBody === null || responseBody === void 0 ? void 0 : responseBody.exception) === null || _m === void 0 ? void 0 : _m.errorCode) !== null && _o !== void 0 ? _o : errorCode, status, responseBody, LOG_CATEGORY$1);
    	            }
    	            if (hasAborted) {
    	              throw new CommunicationError("Client Aborted", ErrorCodes.Communication_Aborted, responseBody, LOG_CATEGORY$1);
    	            }
    	            if (useLocaleInfo && __classPrivateFieldGet(_this9, _SignalRClient_setLocale, "f") && (response === null || response === void 0 ? void 0 : response.ResponseHeaders)) {
    	              updateLocale({
    	                responseHeaders: response.ResponseHeaders,
    	                localeHeader: __classPrivateFieldGet(_this9, _SignalRClient_localeHeader, "f"),
    	                currentLocale: locale,
    	                setLocale: __classPrivateFieldGet(_this9, _SignalRClient_setLocale, "f")
    	              });
    	            }
    	            if (typeof responseHandler === "function") {
    	              try {
    	                responseHandler({
    	                  data: responseBody,
    	                  responseHeaders: response === null || response === void 0 ? void 0 : response.ResponseHeaders
    	                });
    	              } catch (e) {
    	                (_q = (_p = __classPrivateFieldGet(_this9, _SignalRClient_logger, "f")) === null || _p === void 0 ? void 0 : _p.error) === null || _q === void 0 ? void 0 : _q.call(_p, {
    	                  category: LOG_CATEGORY$1,
    	                  message: `ExecuteRequest ${url}`,
    	                  errorCode: ErrorCodes.Communication_Default,
    	                  error: e
    	                });
    	              }
    	            }
    	            return responseBody;
    	          } catch (e) {
    	            yield hubConnectionInstance === null || hubConnectionInstance === void 0 ? void 0 : hubConnectionInstance.stop();
    	            throw __classPrivateFieldGet(_this9, _SignalRClient_instances, "m", _SignalRClient_processError).call(_this9, e, url);
    	          }
    	        }();
    	      });
    	    }
    	  }
    	  _SignalRClient_localeHeader = new WeakMap(), _SignalRClient_getLocale = new WeakMap(), _SignalRClient_setLocale = new WeakMap(), _SignalRClient_logger = new WeakMap(), _SignalRClient_appUrl = new WeakMap(), _SignalRClient_getToken = new WeakMap(), _SignalRClient_instances = new WeakSet(), _SignalRClient_processError = function _SignalRClient_processError(error, url) {
    	    var _a, _b, _c, _d;
    	    let errorCode = ErrorCodes.Communication_Default;
    	    let communicationError;
    	    if (error instanceof CommunicationError) {
    	      errorCode = mapErrorCodeFromStatusCode((_a = error.status) !== null && _a !== void 0 ? _a : "");
    	      communicationError = error;
    	    } else {
    	      communicationError = new CommunicationError(`ExecuteRequest ${url}`, errorCode, undefined, undefined, LOG_CATEGORY$1);
    	    }
    	    (_c = (_b = __classPrivateFieldGet(this, _SignalRClient_logger, "f")) === null || _b === void 0 ? void 0 : _b.error) === null || _c === void 0 ? void 0 : _c.call(_b, {
    	      category: LOG_CATEGORY$1,
    	      message: `ExecuteRequest ${url} - ${(_d = error === null || error === void 0 ? void 0 : error.message) !== null && _d !== void 0 ? _d : ""}`,
    	      errorCode,
    	      error
    	    });
    	    return communicationError;
    	  };
    	  var _DebuggerHttpClient_signalRClientInstance, _DebuggerHttpClient_alternateHttpClientInstance, _DebuggerHttpClient_logger;
    	  const createSignalRInstance = _ref21 => {
    	    let {
    	      appUrl,
    	      localeHeader,
    	      getLocale,
    	      setLocale,
    	      logger,
    	      getToken
    	    } = _ref21;
    	    return new SignalRClient({
    	      appUrl,
    	      localeHeader,
    	      getLocale,
    	      setLocale,
    	      logger,
    	      getToken
    	    });
    	  };
    	  class DebuggerHttpClient {
    	    constructor(_ref22) {
    	      let {
    	        appUrl,
    	        localeHeader,
    	        getLocale,
    	        setLocale,
    	        logger,
    	        getToken,
    	        signalRClientInstance = createSignalRInstance({
    	          appUrl,
    	          localeHeader,
    	          getLocale,
    	          setLocale,
    	          logger,
    	          getToken
    	        }),
    	        alternateHttpClientInstance
    	      } = _ref22;
    	      _DebuggerHttpClient_signalRClientInstance.set(this, void 0);
    	      _DebuggerHttpClient_alternateHttpClientInstance.set(this, void 0);
    	      _DebuggerHttpClient_logger.set(this, void 0);
    	      __classPrivateFieldSet(this, _DebuggerHttpClient_signalRClientInstance, signalRClientInstance);
    	      __classPrivateFieldSet(this, _DebuggerHttpClient_alternateHttpClientInstance, alternateHttpClientInstance);
    	      __classPrivateFieldSet(this, _DebuggerHttpClient_logger, logger);
    	    }
    	    post(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref23) {
    	        var _this0 = this;
    	        let {
    	          url,
    	          payload,
    	          headers,
    	          contentType,
    	          timeout,
    	          timeoutHandler,
    	          useLocaleInfo,
    	          abortCommand,
    	          responseHandler
    	        } = _ref23;
    	        return function* () {
    	          const fetch = () => __classPrivateFieldGet(_this0, _DebuggerHttpClient_signalRClientInstance, "f").executeRequest({
    	            url,
    	            payload,
    	            headers,
    	            contentType,
    	            useLocaleInfo,
    	            timeout,
    	            timeoutHandler,
    	            abortCommand,
    	            responseHandler
    	          });
    	          return doWithSpan(__classPrivateFieldGet(_this0, _DebuggerHttpClient_logger, "f"), "POST", fetch);
    	        }();
    	      });
    	    }
    	    get(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref24) {
    	        var _this1 = this;
    	        let {
    	          url,
    	          params,
    	          headers,
    	          responseType,
    	          useLocaleInfo,
    	          timeout,
    	          timeoutHandler,
    	          baseURL
    	        } = _ref24;
    	        return function* () {
    	          return __classPrivateFieldGet(_this1, _DebuggerHttpClient_alternateHttpClientInstance, "f").get({
    	            url,
    	            params,
    	            headers,
    	            responseType,
    	            useLocaleInfo,
    	            timeout,
    	            timeoutHandler,
    	            baseURL
    	          });
    	        }();
    	      });
    	    }
    	    getResponseUrl(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref25) {
    	        var _this10 = this;
    	        let {
    	          url,
    	          params,
    	          headers,
    	          useLocaleInfo,
    	          timeout,
    	          timeoutHandler,
    	          baseURL
    	        } = _ref25;
    	        return function* () {
    	          return __classPrivateFieldGet(_this10, _DebuggerHttpClient_alternateHttpClientInstance, "f").getResponseUrl({
    	            url,
    	            params,
    	            headers,
    	            useLocaleInfo,
    	            timeout,
    	            timeoutHandler,
    	            baseURL
    	          });
    	        }();
    	      });
    	    }
    	  }
    	  _exports.DebuggerHttpClient = DebuggerHttpClient;
    	  _DebuggerHttpClient_signalRClientInstance = new WeakMap(), _DebuggerHttpClient_alternateHttpClientInstance = new WeakMap(), _DebuggerHttpClient_logger = new WeakMap();
    	  var _HttpClientWithHealthCheck_instances, _HttpClientWithHealthCheck_httpClient, _HttpClientWithHealthCheck_healthCheckIntervalInMilliseconds, _HttpClientWithHealthCheck_healthCheckEndpoint, _HttpClientWithHealthCheck_healingTimeoutDelayInSeconds, _HttpClientWithHealthCheck_healthCheckNeededPathFilter, _HttpClientWithHealthCheck_lastHealthinessTimestamp, _HttpClientWithHealthCheck_logger, _HttpClientWithHealthCheck_needsHealthCheck, _HttpClientWithHealthCheck_isHealthy, _HttpClientWithHealthCheck_getEffectiveTimeout, _HttpClientWithHealthCheck_doWithHealthManagement;
    	  const LOG_CATEGORY = "HttpClientWithHealthCheck";
    	  const DEFAULT_HEALTH_CHECK_INTERVAL_IN_SECONDS = 30 * 60;
    	  const DEFAULT_HEALTH_CHECK_ENDPOINT = "ping";
    	  const DEFAULT_HEALING_TIMEOUT_DELAY_IN_SECONDS = 30;
    	  class HttpClientWithHealthCheck {
    	    constructor(httpClient) {
    	      let {
    	        isHealthy = false,
    	        healthCheckIntervalInSeconds = DEFAULT_HEALTH_CHECK_INTERVAL_IN_SECONDS,
    	        healthCheckEndpoint = DEFAULT_HEALTH_CHECK_ENDPOINT,
    	        healingTimeoutDelayInSeconds = DEFAULT_HEALING_TIMEOUT_DELAY_IN_SECONDS,
    	        healthCheckNeededPathFilter,
    	        logger
    	      } = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : {};
    	      _HttpClientWithHealthCheck_instances.add(this);
    	      _HttpClientWithHealthCheck_httpClient.set(this, void 0);
    	      _HttpClientWithHealthCheck_healthCheckIntervalInMilliseconds.set(this, void 0);
    	      _HttpClientWithHealthCheck_healthCheckEndpoint.set(this, void 0);
    	      _HttpClientWithHealthCheck_healingTimeoutDelayInSeconds.set(this, void 0);
    	      _HttpClientWithHealthCheck_healthCheckNeededPathFilter.set(this, void 0);
    	      _HttpClientWithHealthCheck_lastHealthinessTimestamp.set(this, void 0);
    	      _HttpClientWithHealthCheck_logger.set(this, void 0);
    	      __classPrivateFieldSet(this, _HttpClientWithHealthCheck_httpClient, httpClient);
    	      __classPrivateFieldSet(this, _HttpClientWithHealthCheck_healthCheckIntervalInMilliseconds, healthCheckIntervalInSeconds * 1000);
    	      __classPrivateFieldSet(this, _HttpClientWithHealthCheck_healthCheckEndpoint, healthCheckEndpoint);
    	      __classPrivateFieldSet(this, _HttpClientWithHealthCheck_healingTimeoutDelayInSeconds, healingTimeoutDelayInSeconds);
    	      __classPrivateFieldSet(this, _HttpClientWithHealthCheck_healthCheckNeededPathFilter, healthCheckNeededPathFilter);
    	      if (isHealthy) {
    	        __classPrivateFieldSet(this, _HttpClientWithHealthCheck_lastHealthinessTimestamp, Date.now());
    	      }
    	      __classPrivateFieldSet(this, _HttpClientWithHealthCheck_logger, logger);
    	    }
    	    setHealthCheckInterval(intervalInSeconds) {
    	      __classPrivateFieldSet(this, _HttpClientWithHealthCheck_healthCheckIntervalInMilliseconds, intervalInSeconds * 1000);
    	    }
    	    post(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref26) {
    	        var _this11 = this;
    	        let {
    	          url,
    	          payload,
    	          params,
    	          headers,
    	          contentType,
    	          timeout,
    	          timeoutHandler,
    	          useLocaleInfo,
    	          baseURL,
    	          abortCommand,
    	          responseHandler
    	        } = _ref26;
    	        return function* () {
    	          return __classPrivateFieldGet(_this11, _HttpClientWithHealthCheck_instances, "m", _HttpClientWithHealthCheck_doWithHealthManagement).call(_this11, effectiveTimeout => __classPrivateFieldGet(_this11, _HttpClientWithHealthCheck_httpClient, "f").post({
    	            url,
    	            payload,
    	            params,
    	            headers,
    	            contentType,
    	            timeout: effectiveTimeout,
    	            timeoutHandler,
    	            useLocaleInfo,
    	            baseURL,
    	            abortCommand,
    	            responseHandler
    	          }), url, baseURL, timeout);
    	        }();
    	      });
    	    }
    	    get(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref27) {
    	        var _this12 = this;
    	        let {
    	          url,
    	          params,
    	          headers,
    	          useLocaleInfo,
    	          timeout,
    	          timeoutHandler,
    	          responseType,
    	          baseURL
    	        } = _ref27;
    	        return function* () {
    	          return __classPrivateFieldGet(_this12, _HttpClientWithHealthCheck_instances, "m", _HttpClientWithHealthCheck_doWithHealthManagement).call(_this12, effectiveTimeout => __classPrivateFieldGet(_this12, _HttpClientWithHealthCheck_httpClient, "f").get({
    	            url,
    	            params,
    	            headers,
    	            useLocaleInfo,
    	            timeout: effectiveTimeout,
    	            timeoutHandler,
    	            responseType,
    	            baseURL
    	          }), url, baseURL, timeout);
    	        }();
    	      });
    	    }
    	    getResponseUrl(_a) {
    	      return __awaiter(this, arguments, void 0, function (_ref28) {
    	        var _this13 = this;
    	        let {
    	          url,
    	          params,
    	          headers,
    	          useLocaleInfo,
    	          timeout,
    	          timeoutHandler,
    	          baseURL
    	        } = _ref28;
    	        return function* () {
    	          return __classPrivateFieldGet(_this13, _HttpClientWithHealthCheck_instances, "m", _HttpClientWithHealthCheck_doWithHealthManagement).call(_this13, effectiveTimeout => __classPrivateFieldGet(_this13, _HttpClientWithHealthCheck_httpClient, "f").getResponseUrl({
    	            url,
    	            params,
    	            headers,
    	            useLocaleInfo,
    	            timeout: effectiveTimeout,
    	            timeoutHandler,
    	            baseURL
    	          }), url, baseURL, timeout);
    	        }();
    	      });
    	    }
    	  }
    	  _exports.HttpClientWithHealthCheck = HttpClientWithHealthCheck;
    	  _HttpClientWithHealthCheck_httpClient = new WeakMap(), _HttpClientWithHealthCheck_healthCheckIntervalInMilliseconds = new WeakMap(), _HttpClientWithHealthCheck_healthCheckEndpoint = new WeakMap(), _HttpClientWithHealthCheck_healingTimeoutDelayInSeconds = new WeakMap(), _HttpClientWithHealthCheck_healthCheckNeededPathFilter = new WeakMap(), _HttpClientWithHealthCheck_lastHealthinessTimestamp = new WeakMap(), _HttpClientWithHealthCheck_logger = new WeakMap(), _HttpClientWithHealthCheck_instances = new WeakSet(), _HttpClientWithHealthCheck_needsHealthCheck = function _HttpClientWithHealthCheck_needsHealthCheck(url, baseURL) {
    	    var _a, _b;
    	    const isPathAcceptable = (_b = (_a = __classPrivateFieldGet(this, _HttpClientWithHealthCheck_healthCheckNeededPathFilter, "f")) === null || _a === void 0 ? void 0 : _a.isPathAcceptable(url, baseURL)) !== null && _b !== void 0 ? _b : true;
    	    const hasIntervalElapsed = !__classPrivateFieldGet(this, _HttpClientWithHealthCheck_lastHealthinessTimestamp, "f") || Date.now() - __classPrivateFieldGet(this, _HttpClientWithHealthCheck_lastHealthinessTimestamp, "f") > __classPrivateFieldGet(this, _HttpClientWithHealthCheck_healthCheckIntervalInMilliseconds, "f");
    	    return isPathAcceptable && hasIntervalElapsed;
    	  }, _HttpClientWithHealthCheck_isHealthy = function _HttpClientWithHealthCheck_isHealthy() {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      var _a, _b;
    	      (_b = (_a = __classPrivateFieldGet(this, _HttpClientWithHealthCheck_logger, "f")) === null || _a === void 0 ? void 0 : _a.debug) === null || _b === void 0 ? void 0 : _b.call(_a, {
    	        category: LOG_CATEGORY,
    	        message: `Checking healthiness at ${__classPrivateFieldGet(this, _HttpClientWithHealthCheck_healthCheckEndpoint, "f")}`
    	      });
    	      try {
    	        yield __classPrivateFieldGet(this, _HttpClientWithHealthCheck_httpClient, "f").get({
    	          url: __classPrivateFieldGet(this, _HttpClientWithHealthCheck_healthCheckEndpoint, "f"),
    	          timeout: 2
    	        });
    	        __classPrivateFieldSet(this, _HttpClientWithHealthCheck_lastHealthinessTimestamp, Date.now(), "f");
    	        return true;
    	      } catch (_) {
    	        return false;
    	      }
    	    });
    	  }, _HttpClientWithHealthCheck_getEffectiveTimeout = function _HttpClientWithHealthCheck_getEffectiveTimeout(url, baseURL, timeout) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      if (timeout === undefined) {
    	        return timeout;
    	      }
    	      const isHealthy = __classPrivateFieldGet(this, _HttpClientWithHealthCheck_instances, "m", _HttpClientWithHealthCheck_needsHealthCheck).call(this, url, baseURL) ? yield __classPrivateFieldGet(this, _HttpClientWithHealthCheck_instances, "m", _HttpClientWithHealthCheck_isHealthy).call(this) : true;
    	      return isHealthy ? timeout : timeout + __classPrivateFieldGet(this, _HttpClientWithHealthCheck_healingTimeoutDelayInSeconds, "f");
    	    });
    	  }, _HttpClientWithHealthCheck_doWithHealthManagement = function _HttpClientWithHealthCheck_doWithHealthManagement(action, url, baseURL, timeout) {
    	    return __awaiter(this, void 0, void 0, function* () {
    	      const effectiveTimeout = yield __classPrivateFieldGet(this, _HttpClientWithHealthCheck_instances, "m", _HttpClientWithHealthCheck_getEffectiveTimeout).call(this, url, baseURL, timeout);
    	      try {
    	        return yield action(effectiveTimeout);
    	      } finally {
    	        __classPrivateFieldSet(this, _HttpClientWithHealthCheck_lastHealthinessTimestamp, Date.now());
    	      }
    	    });
    	  };
    	  class AbortRequest {
    	    abort() {
    	      var _a;
    	      (_a = this.onAbort) === null || _a === void 0 ? void 0 : _a.call(this);
    	    }
    	  }
    	  _exports.AbortRequest = AbortRequest;
    	  function isNetworkOrServerError(error) {
    	    return error.errorCode === ErrorCodes.Communication_Timeout || error.errorCode === ErrorCodes.Communication_Unavailable || error.errorCode === ErrorCodes.Communication_Internal_Server_Error || error.errorCode === ErrorCodes.Communication_Aborted;
    	  }
    	  var _PathFilter_instances, _PathFilter_acceptionRules, _PathFilter_rejectionRules, _PathFilter_isMatch;
    	  class PathFilter {
    	    constructor() {
    	      let {
    	        acceptionRules = [],
    	        rejectionRules = []
    	      } = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : {};
    	      _PathFilter_instances.add(this);
    	      _PathFilter_acceptionRules.set(this, void 0);
    	      _PathFilter_rejectionRules.set(this, void 0);
    	      __classPrivateFieldSet(this, _PathFilter_acceptionRules, acceptionRules);
    	      __classPrivateFieldSet(this, _PathFilter_rejectionRules, rejectionRules);
    	    }
    	    isPathAcceptable(url, baseURL) {
    	      const path = (baseURL ? `${baseURL}/${url}` : url).replace(/\/+/g, "/");
    	      const isAcceptable = __classPrivateFieldGet(this, _PathFilter_acceptionRules, "f").length === 0 || __classPrivateFieldGet(this, _PathFilter_acceptionRules, "f").some(rule => __classPrivateFieldGet(this, _PathFilter_instances, "m", _PathFilter_isMatch).call(this, rule, path));
    	      const isRejectable = __classPrivateFieldGet(this, _PathFilter_rejectionRules, "f").some(rule => __classPrivateFieldGet(this, _PathFilter_instances, "m", _PathFilter_isMatch).call(this, rule, path));
    	      return isAcceptable && !isRejectable;
    	    }
    	  }
    	  _exports.PathFilter = PathFilter;
    	  _PathFilter_acceptionRules = new WeakMap(), _PathFilter_rejectionRules = new WeakMap(), _PathFilter_instances = new WeakSet(), _PathFilter_isMatch = function _PathFilter_isMatch(rule, path) {
    	    if (rule instanceof RegExp) {
    	      return rule.test(path);
    	    } else if (rule) {
    	      return path.startsWith(rule);
    	    } else {
    	      return false;
    	    }
    	  };
    	  _exports.Version = "1.13.0";
    	}); 
    } (dist$2));

    var dist$1 = {};

    var dist = {};

    var hasRequiredDist;

    function requireDist () {
    	if (hasRequiredDist) return dist;
    	hasRequiredDist = 1;
    	(function (exports) {
    		(function (global, factory) {
    		  {
    		    factory(exports);
    		  }
    		})(typeof globalThis !== "undefined" ? globalThis : typeof self !== "undefined" ? self : commonjsGlobal, function (_exports) {

    		  Object.defineProperty(_exports, "__esModule", {
    		    value: true
    		  });
    		  _exports.Version = _exports.FeaturesManager = _exports.FeatureKeys = void 0;
    		  var FeatureKeys;
    		  (function (FeatureKeys) {
    		    FeatureKeys["WebHttpClientForNative"] = "WebHttpClientForNative";
    		    FeatureKeys["NoInstrumentationFactoryLogs"] = "NoInstrumentationFactoryLogs";
    		    FeatureKeys["WriteLogsOnConsoles"] = "WriteLogsOnConsoles";
    		    FeatureKeys["ServiceWorkerTraces"] = "ServiceWorkerTraces";
    		    FeatureKeys["EnableOTLV2TraceFormat"] = "EnableOTLV2TraceFormat";
    		    FeatureKeys["ReadAuthConfigsFromSettings"] = "ReadAuthConfigsFromSettings";
    		  })(FeatureKeys || (_exports.FeatureKeys = FeatureKeys = {}));
    		  const FEATURE_DEFAULTS = {
    		    ServiceWorkerTraces: "true",
    		    EnableOTLV2TraceFormat: "true"
    		  };
    		  const FEATURE_GUARDS = {};
    		  function getGlobalScope() {
    		    if (typeof window !== "undefined") {
    		      return window;
    		    }
    		    if (typeof commonjsGlobal !== "undefined") {
    		      return commonjsGlobal;
    		    }
    		    if (typeof globalThis !== "undefined") {
    		      return globalThis;
    		    }
    		    if (typeof self !== "undefined") {
    		      return self;
    		    }
    		    throw new Error("unable to locate global object");
    		  }
    		  const FEATURE_SUFFIX = "ft-";
    		  const defaultStorage = getGlobalScope().sessionStorage;
    		  const featureCache = new Map();
    		  class FeaturesManager {
    		    static getGuard(featureKey, guards) {
    		      var _a;
    		      return (_a = guards[featureKey]) !== null && _a !== void 0 ? _a : () => ({
    		        value: "inherit"
    		      });
    		    }
    		    static readValue(featureKey) {
    		      let featuresStorage = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : defaultStorage;
    		      var _a;
    		      return (_a = featuresStorage === null || featuresStorage === void 0 ? void 0 : featuresStorage.getItem(this.getFeatureKey(featureKey))) !== null && _a !== void 0 ? _a : undefined;
    		    }
    		    static isEnabled(featureKey) {
    		      let {
    		        featuresStorage = defaultStorage,
    		        cache = featureCache,
    		        defaultValues = FEATURE_DEFAULTS,
    		        guards = FEATURE_GUARDS,
    		        logMethod = console.warn
    		      } = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : {};
    		      var _a;
    		      const cachedValue = cache.get(featureKey);
    		      if (cachedValue !== undefined) {
    		        return cachedValue;
    		      }
    		      const guardedValue = this.getGuard(featureKey, guards)();
    		      if (guardedValue.value !== "inherit") {
    		        const enabledStatus = guardedValue.value === "forceTrue";
    		        logMethod(`FeaturesManager: Experimental flag "${featureKey}" is forced to value "${enabledStatus}"${guardedValue.reason ? `: ${guardedValue.reason}` : "."}`);
    		        cache.set(featureKey, enabledStatus);
    		        return enabledStatus;
    		      }
    		      const defaultValue = defaultValues[featureKey];
    		      const featureValue = (_a = this.readValue(featureKey, featuresStorage)) !== null && _a !== void 0 ? _a : defaultValue;
    		      const enabledStatus = (featureValue === null || featureValue === void 0 ? void 0 : featureValue.toLowerCase()) === "true";
    		      const valueIsOverriden = enabledStatus !== ((defaultValue === null || defaultValue === void 0 ? void 0 : defaultValue.toLowerCase()) === "true");
    		      if (valueIsOverriden) {
    		        logMethod(`FeaturesManager: Experimental flag "${featureKey}" is overridden with value "${featureValue}"`);
    		      }
    		      cache.set(featureKey, enabledStatus);
    		      return enabledStatus;
    		    }
    		  }
    		  _exports.FeaturesManager = FeaturesManager;
    		  FeaturesManager.getFeatureKey = featureKey => `${FEATURE_SUFFIX}${featureKey}`;
    		  _exports.Version = "1.7.0";
    		}); 
    	} (dist));
    	return dist;
    }

    (function (exports) {
    	(function(global,factory){{factory(exports,requireDist(),dist$2);}})(typeof globalThis!=="undefined"?globalThis:typeof self!=="undefined"?self:commonjsGlobal,function(_exports,_settingsJs,_communicationJs){Object.defineProperty(_exports,"__esModule",{value:true});_exports.Visibility=_exports.Version=_exports.Tracer=_exports.SpanKind=_exports.Logger=_exports.LogType=_exports.Log=_exports.KnownAttributes=_exports.InstrumentationFactory=void 0;var _process$release;function _defineProperty2(e,r,t){return (r=_toPropertyKey(r))in e?Object.defineProperty(e,r,{value:t,enumerable:true,configurable:true,writable:true}):e[r]=t,e;}function _toPropertyKey(t){var i=_toPrimitive(t,"string");return "symbol"==typeof i?i:i+"";}function _toPrimitive(t,r){if("object"!=typeof t||!t)return t;var e=t[Symbol.toPrimitive];if(void 0!==e){var i=e.call(t,r);if("object"!=typeof i)return i;throw new TypeError("@@toPrimitive must return a primitive value.");}return ("string"===r?String:Number)(t);}/******************************************************************************
    	Copyright (c) Microsoft Corporation.

    	Permission to use, copy, modify, and/or distribute this software for any
    	purpose with or without fee is hereby granted.

    	THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
    	REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY
    	AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
    	INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM
    	LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR
    	OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR
    	PERFORMANCE OF THIS SOFTWARE.
    	***************************************************************************** *//* global Reflect, Promise, SuppressedError, Symbol, Iterator */function __awaiter$3(thisArg,_arguments,P,generator){function adopt(value){return value instanceof P?value:new P(function(resolve){resolve(value);});}return new(P||(P=Promise))(function(resolve,reject){function fulfilled(value){try{step(generator.next(value));}catch(e){reject(e);}}function rejected(value){try{step(generator["throw"](value));}catch(e){reject(e);}}function step(result){result.done?resolve(result.value):adopt(result.value).then(fulfilled,rejected);}step((generator=generator.apply(thisArg,_arguments||[])).next());});}function __classPrivateFieldGet(receiver,state,kind,f){if(kind==="a"&&!f)throw new TypeError("Private accessor was defined without a getter");if(typeof state==="function"?receiver!==state||!f:!state.has(receiver))throw new TypeError("Cannot read private member from an object whose class did not declare it");return kind==="m"?f:kind==="a"?f.call(receiver):f?f.value:state.get(receiver);}function __classPrivateFieldSet(receiver,state,value,kind,f){if(typeof state==="function"?receiver!==state||true:!state.has(receiver))throw new TypeError("Cannot write private member to an object whose class did not declare it");return state.set(receiver,value),value;}typeof SuppressedError==="function"?SuppressedError:function(error,suppressed,message){var e=new Error(message);return e.name="SuppressedError",e.error=error,e.suppressed=suppressed,e;};/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Updates to this file should also be replicated to @opentelemetry/core too.
    	/**
    	 * - globalThis (New standard)
    	 * - self (Will return the current window instance for supported browsers)
    	 * - window (fallback for older browser implementations)
    	 * - global (NodeJS implementation)
    	 * - <object> (When all else fails)
    	 *//** only globals that common to node and browsers are allowed */// eslint-disable-next-line node/no-unsupported-features/es-builtins, no-undef
    	var _globalThis$3=typeof globalThis==='object'?globalThis:typeof self==='object'?self:typeof window==='object'?window:typeof commonjsGlobal==='object'?commonjsGlobal:{};/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// this is autogenerated file, see scripts/version-update.js
    	var VERSION$3='1.9.0';/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var re=/^(\d+)\.(\d+)\.(\d+)(-(.+))?$/;/**
    	 * Create a function to test an API version to see if it is compatible with the provided ownVersion.
    	 *
    	 * The returned function has the following semantics:
    	 * - Exact match is always compatible
    	 * - Major versions must match exactly
    	 *    - 1.x package cannot use global 2.x package
    	 *    - 2.x package cannot use global 1.x package
    	 * - The minor version of the API module requesting access to the global API must be less than or equal to the minor version of this API
    	 *    - 1.3 package may use 1.4 global because the later global contains all functions 1.3 expects
    	 *    - 1.4 package may NOT use 1.3 global because it may try to call functions which don't exist on 1.3
    	 * - If the major version is 0, the minor version is treated as the major and the patch is treated as the minor
    	 * - Patch and build tag differences are not considered at this time
    	 *
    	 * @param ownVersion version which should be checked against
    	 */function _makeCompatibilityCheck(ownVersion){var acceptedVersions=new Set([ownVersion]);var rejectedVersions=new Set();var myVersionMatch=ownVersion.match(re);if(!myVersionMatch){// we cannot guarantee compatibility so we always return noop
    	return function(){return false;};}var ownVersionParsed={major:+myVersionMatch[1],minor:+myVersionMatch[2],patch:+myVersionMatch[3],prerelease:myVersionMatch[4]};// if ownVersion has a prerelease tag, versions must match exactly
    	if(ownVersionParsed.prerelease!=null){return function isExactmatch(globalVersion){return globalVersion===ownVersion;};}function _reject(v){rejectedVersions.add(v);return false;}function _accept(v){acceptedVersions.add(v);return true;}return function isCompatible(globalVersion){if(acceptedVersions.has(globalVersion)){return true;}if(rejectedVersions.has(globalVersion)){return false;}var globalVersionMatch=globalVersion.match(re);if(!globalVersionMatch){// cannot parse other version
    	// we cannot guarantee compatibility so we always noop
    	return _reject(globalVersion);}var globalVersionParsed={major:+globalVersionMatch[1],minor:+globalVersionMatch[2],patch:+globalVersionMatch[3],prerelease:globalVersionMatch[4]};// if globalVersion has a prerelease tag, versions must match exactly
    	if(globalVersionParsed.prerelease!=null){return _reject(globalVersion);}// major versions must match
    	if(ownVersionParsed.major!==globalVersionParsed.major){return _reject(globalVersion);}if(ownVersionParsed.major===0){if(ownVersionParsed.minor===globalVersionParsed.minor&&ownVersionParsed.patch<=globalVersionParsed.patch){return _accept(globalVersion);}return _reject(globalVersion);}if(ownVersionParsed.minor<=globalVersionParsed.minor){return _accept(globalVersion);}return _reject(globalVersion);};}/**
    	 * Test an API version to see if it is compatible with this API.
    	 *
    	 * - Exact match is always compatible
    	 * - Major versions must match exactly
    	 *    - 1.x package cannot use global 2.x package
    	 *    - 2.x package cannot use global 1.x package
    	 * - The minor version of the API module requesting access to the global API must be less than or equal to the minor version of this API
    	 *    - 1.3 package may use 1.4 global because the later global contains all functions 1.3 expects
    	 *    - 1.4 package may NOT use 1.3 global because it may try to call functions which don't exist on 1.3
    	 * - If the major version is 0, the minor version is treated as the major and the patch is treated as the minor
    	 * - Patch and build tag differences are not considered at this time
    	 *
    	 * @param version version of the API requesting an instance of the global API
    	 */var isCompatible=_makeCompatibilityCheck(VERSION$3);/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var major=VERSION$3.split('.')[0];var GLOBAL_OPENTELEMETRY_API_KEY=Symbol.for("opentelemetry.js.api."+major);var _global$2=_globalThis$3;function registerGlobal(type,instance,diag,allowOverride){var _a;if(allowOverride===void 0){allowOverride=false;}var api=_global$2[GLOBAL_OPENTELEMETRY_API_KEY]=(_a=_global$2[GLOBAL_OPENTELEMETRY_API_KEY])!==null&&_a!==void 0?_a:{version:VERSION$3};if(!allowOverride&&api[type]){// already registered an API of this type
    	var err=new Error("@opentelemetry/api: Attempted duplicate registration of API: "+type);diag.error(err.stack||err.message);return false;}if(api.version!==VERSION$3){// All registered APIs must be of the same version exactly
    	var err=new Error("@opentelemetry/api: Registration of version v"+api.version+" for "+type+" does not match previously registered API v"+VERSION$3);diag.error(err.stack||err.message);return false;}api[type]=instance;diag.debug("@opentelemetry/api: Registered a global for "+type+" v"+VERSION$3+".");return true;}function getGlobal(type){var _a,_b;var globalVersion=(_a=_global$2[GLOBAL_OPENTELEMETRY_API_KEY])===null||_a===void 0?void 0:_a.version;if(!globalVersion||!isCompatible(globalVersion)){return;}return (_b=_global$2[GLOBAL_OPENTELEMETRY_API_KEY])===null||_b===void 0?void 0:_b[type];}function unregisterGlobal(type,diag){diag.debug("@opentelemetry/api: Unregistering a global for "+type+" v"+VERSION$3+".");var api=_global$2[GLOBAL_OPENTELEMETRY_API_KEY];if(api){delete api[type];}}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __read$a=function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-->0)&&!(r=i.next()).done)ar.push(r.value);}catch(error){e={error:error};}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i);}finally{if(e)throw e.error;}}return ar;};var __spreadArray$6=function(to,from,pack){if(pack||arguments.length===2)for(var i=0,l=from.length,ar;i<l;i++){if(ar||!(i in from)){if(!ar)ar=Array.prototype.slice.call(from,0,i);ar[i]=from[i];}}return to.concat(ar||Array.prototype.slice.call(from));};/**
    	 * Component Logger which is meant to be used as part of any component which
    	 * will add automatically additional namespace in front of the log message.
    	 * It will then forward all message to global diag logger
    	 * @example
    	 * const cLogger = diag.createComponentLogger({ namespace: '@opentelemetry/instrumentation-http' });
    	 * cLogger.debug('test');
    	 * // @opentelemetry/instrumentation-http test
    	 */var DiagComponentLogger=/** @class */function(){function DiagComponentLogger(props){this._namespace=props.namespace||'DiagComponentLogger';}DiagComponentLogger.prototype.debug=function(){var args=[];for(var _i=0;_i<arguments.length;_i++){args[_i]=arguments[_i];}return logProxy('debug',this._namespace,args);};DiagComponentLogger.prototype.error=function(){var args=[];for(var _i=0;_i<arguments.length;_i++){args[_i]=arguments[_i];}return logProxy('error',this._namespace,args);};DiagComponentLogger.prototype.info=function(){var args=[];for(var _i=0;_i<arguments.length;_i++){args[_i]=arguments[_i];}return logProxy('info',this._namespace,args);};DiagComponentLogger.prototype.warn=function(){var args=[];for(var _i=0;_i<arguments.length;_i++){args[_i]=arguments[_i];}return logProxy('warn',this._namespace,args);};DiagComponentLogger.prototype.verbose=function(){var args=[];for(var _i=0;_i<arguments.length;_i++){args[_i]=arguments[_i];}return logProxy('verbose',this._namespace,args);};return DiagComponentLogger;}();function logProxy(funcName,namespace,args){var logger=getGlobal('diag');// shortcut if logger not set
    	if(!logger){return;}args.unshift(namespace);return logger[funcName].apply(logger,__spreadArray$6([],__read$a(args),false));}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * Defines the available internal logging levels for the diagnostic logger, the numeric values
    	 * of the levels are defined to match the original values from the initial LogLevel to avoid
    	 * compatibility/migration issues for any implementation that assume the numeric ordering.
    	 */var DiagLogLevel;(function(DiagLogLevel){/** Diagnostic Logging level setting to disable all logging (except and forced logs) */DiagLogLevel[DiagLogLevel["NONE"]=0]="NONE";/** Identifies an error scenario */DiagLogLevel[DiagLogLevel["ERROR"]=30]="ERROR";/** Identifies a warning scenario */DiagLogLevel[DiagLogLevel["WARN"]=50]="WARN";/** General informational log message */DiagLogLevel[DiagLogLevel["INFO"]=60]="INFO";/** General debug log message */DiagLogLevel[DiagLogLevel["DEBUG"]=70]="DEBUG";/**
    	     * Detailed trace level logging should only be used for development, should only be set
    	     * in a development environment.
    	     */DiagLogLevel[DiagLogLevel["VERBOSE"]=80]="VERBOSE";/** Used to set the logging level to include all logging */DiagLogLevel[DiagLogLevel["ALL"]=9999]="ALL";})(DiagLogLevel||(DiagLogLevel={}));/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */function createLogLevelDiagLogger(maxLevel,logger){if(maxLevel<DiagLogLevel.NONE){maxLevel=DiagLogLevel.NONE;}else if(maxLevel>DiagLogLevel.ALL){maxLevel=DiagLogLevel.ALL;}// In case the logger is null or undefined
    	logger=logger||{};function _filterFunc(funcName,theLevel){var theFunc=logger[funcName];if(typeof theFunc==='function'&&maxLevel>=theLevel){return theFunc.bind(logger);}return function(){};}return {error:_filterFunc('error',DiagLogLevel.ERROR),warn:_filterFunc('warn',DiagLogLevel.WARN),info:_filterFunc('info',DiagLogLevel.INFO),debug:_filterFunc('debug',DiagLogLevel.DEBUG),verbose:_filterFunc('verbose',DiagLogLevel.VERBOSE)};}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __read$9=function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-->0)&&!(r=i.next()).done)ar.push(r.value);}catch(error){e={error:error};}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i);}finally{if(e)throw e.error;}}return ar;};var __spreadArray$5=function(to,from,pack){if(pack||arguments.length===2)for(var i=0,l=from.length,ar;i<l;i++){if(ar||!(i in from)){if(!ar)ar=Array.prototype.slice.call(from,0,i);ar[i]=from[i];}}return to.concat(ar||Array.prototype.slice.call(from));};var API_NAME$4='diag';/**
    	 * Singleton object which represents the entry point to the OpenTelemetry internal
    	 * diagnostic API
    	 */var DiagAPI=/** @class */function(){/**
    	     * Private internal constructor
    	     * @private
    	     */function DiagAPI(){function _logProxy(funcName){return function(){var args=[];for(var _i=0;_i<arguments.length;_i++){args[_i]=arguments[_i];}var logger=getGlobal('diag');// shortcut if logger not set
    	if(!logger)return;return logger[funcName].apply(logger,__spreadArray$5([],__read$9(args),false));};}// Using self local variable for minification purposes as 'this' cannot be minified
    	var self=this;// DiagAPI specific functions
    	var setLogger=function(logger,optionsOrLogLevel){var _a,_b,_c;if(optionsOrLogLevel===void 0){optionsOrLogLevel={logLevel:DiagLogLevel.INFO};}if(logger===self){// There isn't much we can do here.
    	// Logging to the console might break the user application.
    	// Try to log to self. If a logger was previously registered it will receive the log.
    	var err=new Error('Cannot use diag as the logger for itself. Please use a DiagLogger implementation like ConsoleDiagLogger or a custom implementation');self.error((_a=err.stack)!==null&&_a!==void 0?_a:err.message);return false;}if(typeof optionsOrLogLevel==='number'){optionsOrLogLevel={logLevel:optionsOrLogLevel};}var oldLogger=getGlobal('diag');var newLogger=createLogLevelDiagLogger((_b=optionsOrLogLevel.logLevel)!==null&&_b!==void 0?_b:DiagLogLevel.INFO,logger);// There already is an logger registered. We'll let it know before overwriting it.
    	if(oldLogger&&!optionsOrLogLevel.suppressOverrideMessage){var stack=(_c=new Error().stack)!==null&&_c!==void 0?_c:'<failed to generate stacktrace>';oldLogger.warn("Current logger will be overwritten from "+stack);newLogger.warn("Current logger will overwrite one already registered from "+stack);}return registerGlobal('diag',newLogger,self,true);};self.setLogger=setLogger;self.disable=function(){unregisterGlobal(API_NAME$4,self);};self.createComponentLogger=function(options){return new DiagComponentLogger(options);};self.verbose=_logProxy('verbose');self.debug=_logProxy('debug');self.info=_logProxy('info');self.warn=_logProxy('warn');self.error=_logProxy('error');}/** Get the singleton instance of the DiagAPI API */DiagAPI.instance=function(){if(!this._instance){this._instance=new DiagAPI();}return this._instance;};return DiagAPI;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __read$8=function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-->0)&&!(r=i.next()).done)ar.push(r.value);}catch(error){e={error:error};}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i);}finally{if(e)throw e.error;}}return ar;};var __values$4=function(o){var s=typeof Symbol==="function"&&Symbol.iterator,m=s&&o[s],i=0;if(m)return m.call(o);if(o&&typeof o.length==="number")return {next:function(){if(o&&i>=o.length)o=void 0;return {value:o&&o[i++],done:!o};}};throw new TypeError(s?"Object is not iterable.":"Symbol.iterator is not defined.");};var BaggageImpl=/** @class */function(){function BaggageImpl(entries){this._entries=entries?new Map(entries):new Map();}BaggageImpl.prototype.getEntry=function(key){var entry=this._entries.get(key);if(!entry){return undefined;}return Object.assign({},entry);};BaggageImpl.prototype.getAllEntries=function(){return Array.from(this._entries.entries()).map(function(_a){var _b=__read$8(_a,2),k=_b[0],v=_b[1];return [k,v];});};BaggageImpl.prototype.setEntry=function(key,entry){var newBaggage=new BaggageImpl(this._entries);newBaggage._entries.set(key,entry);return newBaggage;};BaggageImpl.prototype.removeEntry=function(key){var newBaggage=new BaggageImpl(this._entries);newBaggage._entries.delete(key);return newBaggage;};BaggageImpl.prototype.removeEntries=function(){var e_1,_a;var keys=[];for(var _i=0;_i<arguments.length;_i++){keys[_i]=arguments[_i];}var newBaggage=new BaggageImpl(this._entries);try{for(var keys_1=__values$4(keys),keys_1_1=keys_1.next();!keys_1_1.done;keys_1_1=keys_1.next()){var key=keys_1_1.value;newBaggage._entries.delete(key);}}catch(e_1_1){e_1={error:e_1_1};}finally{try{if(keys_1_1&&!keys_1_1.done&&(_a=keys_1.return))_a.call(keys_1);}finally{if(e_1)throw e_1.error;}}return newBaggage;};BaggageImpl.prototype.clear=function(){return new BaggageImpl();};return BaggageImpl;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * Symbol used to make BaggageEntryMetadata an opaque type
    	 */var baggageEntryMetadataSymbol=Symbol('BaggageEntryMetadata');/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var diag$1=DiagAPI.instance();/**
    	 * Create a new Baggage with optional entries
    	 *
    	 * @param entries An array of baggage entries the new baggage should contain
    	 */function createBaggage(entries){if(entries===void 0){entries={};}return new BaggageImpl(new Map(Object.entries(entries)));}/**
    	 * Create a serializable BaggageEntryMetadata object from a string.
    	 *
    	 * @param str string metadata. Format is currently not defined by the spec and has no special meaning.
    	 *
    	 */function baggageEntryMetadataFromString(str){if(typeof str!=='string'){diag$1.error("Cannot create baggage metadata from unknown type: "+typeof str);str='';}return {__TYPE__:baggageEntryMetadataSymbol,toString:function(){return str;}};}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//** Get a key to uniquely identify a context value */function createContextKey(description){// The specification states that for the same input, multiple calls should
    	// return different keys. Due to the nature of the JS dependency management
    	// system, this creates problems where multiple versions of some package
    	// could hold different keys for the same property.
    	//
    	// Therefore, we use Symbol.for which returns the same key for the same input.
    	return Symbol.for(description);}var BaseContext=/** @class */function(){/**
    	     * Construct a new context which inherits values from an optional parent context.
    	     *
    	     * @param parentContext a context from which to inherit values
    	     */function BaseContext(parentContext){// for minification
    	var self=this;self._currentContext=parentContext?new Map(parentContext):new Map();self.getValue=function(key){return self._currentContext.get(key);};self.setValue=function(key,value){var context=new BaseContext(self._currentContext);context._currentContext.set(key,value);return context;};self.deleteValue=function(key){var context=new BaseContext(self._currentContext);context._currentContext.delete(key);return context;};}return BaseContext;}();/** The root context is used as the default parent context when there is no active context */var ROOT_CONTEXT=new BaseContext();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __extends$2=function(){var extendStatics=function(d,b){extendStatics=Object.setPrototypeOf||{__proto__:[]}instanceof Array&&function(d,b){d.__proto__=b;}||function(d,b){for(var p in b)if(Object.prototype.hasOwnProperty.call(b,p))d[p]=b[p];};return extendStatics(d,b);};return function(d,b){if(typeof b!=="function"&&b!==null)throw new TypeError("Class extends value "+String(b)+" is not a constructor or null");extendStatics(d,b);function __(){this.constructor=d;}d.prototype=b===null?Object.create(b):(__.prototype=b.prototype,new __());};}();/**
    	 * NoopMeter is a noop implementation of the {@link Meter} interface. It reuses
    	 * constant NoopMetrics for all of its methods.
    	 */var NoopMeter=/** @class */function(){function NoopMeter(){}/**
    	     * @see {@link Meter.createGauge}
    	     */NoopMeter.prototype.createGauge=function(_name,_options){return NOOP_GAUGE_METRIC;};/**
    	     * @see {@link Meter.createHistogram}
    	     */NoopMeter.prototype.createHistogram=function(_name,_options){return NOOP_HISTOGRAM_METRIC;};/**
    	     * @see {@link Meter.createCounter}
    	     */NoopMeter.prototype.createCounter=function(_name,_options){return NOOP_COUNTER_METRIC;};/**
    	     * @see {@link Meter.createUpDownCounter}
    	     */NoopMeter.prototype.createUpDownCounter=function(_name,_options){return NOOP_UP_DOWN_COUNTER_METRIC;};/**
    	     * @see {@link Meter.createObservableGauge}
    	     */NoopMeter.prototype.createObservableGauge=function(_name,_options){return NOOP_OBSERVABLE_GAUGE_METRIC;};/**
    	     * @see {@link Meter.createObservableCounter}
    	     */NoopMeter.prototype.createObservableCounter=function(_name,_options){return NOOP_OBSERVABLE_COUNTER_METRIC;};/**
    	     * @see {@link Meter.createObservableUpDownCounter}
    	     */NoopMeter.prototype.createObservableUpDownCounter=function(_name,_options){return NOOP_OBSERVABLE_UP_DOWN_COUNTER_METRIC;};/**
    	     * @see {@link Meter.addBatchObservableCallback}
    	     */NoopMeter.prototype.addBatchObservableCallback=function(_callback,_observables){};/**
    	     * @see {@link Meter.removeBatchObservableCallback}
    	     */NoopMeter.prototype.removeBatchObservableCallback=function(_callback){};return NoopMeter;}();var NoopMetric=/** @class */function(){function NoopMetric(){}return NoopMetric;}();var NoopCounterMetric=/** @class */function(_super){__extends$2(NoopCounterMetric,_super);function NoopCounterMetric(){return _super!==null&&_super.apply(this,arguments)||this;}NoopCounterMetric.prototype.add=function(_value,_attributes){};return NoopCounterMetric;}(NoopMetric);var NoopUpDownCounterMetric=/** @class */function(_super){__extends$2(NoopUpDownCounterMetric,_super);function NoopUpDownCounterMetric(){return _super!==null&&_super.apply(this,arguments)||this;}NoopUpDownCounterMetric.prototype.add=function(_value,_attributes){};return NoopUpDownCounterMetric;}(NoopMetric);var NoopGaugeMetric=/** @class */function(_super){__extends$2(NoopGaugeMetric,_super);function NoopGaugeMetric(){return _super!==null&&_super.apply(this,arguments)||this;}NoopGaugeMetric.prototype.record=function(_value,_attributes){};return NoopGaugeMetric;}(NoopMetric);var NoopHistogramMetric=/** @class */function(_super){__extends$2(NoopHistogramMetric,_super);function NoopHistogramMetric(){return _super!==null&&_super.apply(this,arguments)||this;}NoopHistogramMetric.prototype.record=function(_value,_attributes){};return NoopHistogramMetric;}(NoopMetric);var NoopObservableMetric=/** @class */function(){function NoopObservableMetric(){}NoopObservableMetric.prototype.addCallback=function(_callback){};NoopObservableMetric.prototype.removeCallback=function(_callback){};return NoopObservableMetric;}();var NoopObservableCounterMetric=/** @class */function(_super){__extends$2(NoopObservableCounterMetric,_super);function NoopObservableCounterMetric(){return _super!==null&&_super.apply(this,arguments)||this;}return NoopObservableCounterMetric;}(NoopObservableMetric);var NoopObservableGaugeMetric=/** @class */function(_super){__extends$2(NoopObservableGaugeMetric,_super);function NoopObservableGaugeMetric(){return _super!==null&&_super.apply(this,arguments)||this;}return NoopObservableGaugeMetric;}(NoopObservableMetric);var NoopObservableUpDownCounterMetric=/** @class */function(_super){__extends$2(NoopObservableUpDownCounterMetric,_super);function NoopObservableUpDownCounterMetric(){return _super!==null&&_super.apply(this,arguments)||this;}return NoopObservableUpDownCounterMetric;}(NoopObservableMetric);var NOOP_METER=new NoopMeter();// Synchronous instruments
    	var NOOP_COUNTER_METRIC=new NoopCounterMetric();var NOOP_GAUGE_METRIC=new NoopGaugeMetric();var NOOP_HISTOGRAM_METRIC=new NoopHistogramMetric();var NOOP_UP_DOWN_COUNTER_METRIC=new NoopUpDownCounterMetric();// Asynchronous instruments
    	var NOOP_OBSERVABLE_COUNTER_METRIC=new NoopObservableCounterMetric();var NOOP_OBSERVABLE_GAUGE_METRIC=new NoopObservableGaugeMetric();var NOOP_OBSERVABLE_UP_DOWN_COUNTER_METRIC=new NoopObservableUpDownCounterMetric();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var defaultTextMapGetter={get:function(carrier,key){if(carrier==null){return undefined;}return carrier[key];},keys:function(carrier){if(carrier==null){return [];}return Object.keys(carrier);}};var defaultTextMapSetter={set:function(carrier,key,value){if(carrier==null){return;}carrier[key]=value;}};/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __read$7=function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-->0)&&!(r=i.next()).done)ar.push(r.value);}catch(error){e={error:error};}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i);}finally{if(e)throw e.error;}}return ar;};var __spreadArray$4=function(to,from,pack){if(pack||arguments.length===2)for(var i=0,l=from.length,ar;i<l;i++){if(ar||!(i in from)){if(!ar)ar=Array.prototype.slice.call(from,0,i);ar[i]=from[i];}}return to.concat(ar||Array.prototype.slice.call(from));};var NoopContextManager=/** @class */function(){function NoopContextManager(){}NoopContextManager.prototype.active=function(){return ROOT_CONTEXT;};NoopContextManager.prototype.with=function(_context,fn,thisArg){var args=[];for(var _i=3;_i<arguments.length;_i++){args[_i-3]=arguments[_i];}return fn.call.apply(fn,__spreadArray$4([thisArg],__read$7(args),false));};NoopContextManager.prototype.bind=function(_context,target){return target;};NoopContextManager.prototype.enable=function(){return this;};NoopContextManager.prototype.disable=function(){return this;};return NoopContextManager;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __read$6=function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-->0)&&!(r=i.next()).done)ar.push(r.value);}catch(error){e={error:error};}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i);}finally{if(e)throw e.error;}}return ar;};var __spreadArray$3=function(to,from,pack){if(pack||arguments.length===2)for(var i=0,l=from.length,ar;i<l;i++){if(ar||!(i in from)){if(!ar)ar=Array.prototype.slice.call(from,0,i);ar[i]=from[i];}}return to.concat(ar||Array.prototype.slice.call(from));};var API_NAME$3='context';var NOOP_CONTEXT_MANAGER=new NoopContextManager();/**
    	 * Singleton object which represents the entry point to the OpenTelemetry Context API
    	 */var ContextAPI=/** @class */function(){/** Empty private constructor prevents end users from constructing a new instance of the API */function ContextAPI(){}/** Get the singleton instance of the Context API */ContextAPI.getInstance=function(){if(!this._instance){this._instance=new ContextAPI();}return this._instance;};/**
    	     * Set the current context manager.
    	     *
    	     * @returns true if the context manager was successfully registered, else false
    	     */ContextAPI.prototype.setGlobalContextManager=function(contextManager){return registerGlobal(API_NAME$3,contextManager,DiagAPI.instance());};/**
    	     * Get the currently active context
    	     */ContextAPI.prototype.active=function(){return this._getContextManager().active();};/**
    	     * Execute a function with an active context
    	     *
    	     * @param context context to be active during function execution
    	     * @param fn function to execute in a context
    	     * @param thisArg optional receiver to be used for calling fn
    	     * @param args optional arguments forwarded to fn
    	     */ContextAPI.prototype.with=function(context,fn,thisArg){var _a;var args=[];for(var _i=3;_i<arguments.length;_i++){args[_i-3]=arguments[_i];}return (_a=this._getContextManager()).with.apply(_a,__spreadArray$3([context,fn,thisArg],__read$6(args),false));};/**
    	     * Bind a context to a target function or event emitter
    	     *
    	     * @param context context to bind to the event emitter or function. Defaults to the currently active context
    	     * @param target function or event emitter to bind
    	     */ContextAPI.prototype.bind=function(context,target){return this._getContextManager().bind(context,target);};ContextAPI.prototype._getContextManager=function(){return getGlobal(API_NAME$3)||NOOP_CONTEXT_MANAGER;};/** Disable and remove the global context manager */ContextAPI.prototype.disable=function(){this._getContextManager().disable();unregisterGlobal(API_NAME$3,DiagAPI.instance());};return ContextAPI;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var TraceFlags;(function(TraceFlags){/** Represents no flag set. */TraceFlags[TraceFlags["NONE"]=0]="NONE";/** Bit to represent whether trace is sampled in trace flags. */TraceFlags[TraceFlags["SAMPLED"]=1]="SAMPLED";})(TraceFlags||(TraceFlags={}));/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var INVALID_SPANID='0000000000000000';var INVALID_TRACEID='00000000000000000000000000000000';var INVALID_SPAN_CONTEXT={traceId:INVALID_TRACEID,spanId:INVALID_SPANID,traceFlags:TraceFlags.NONE};/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * The NonRecordingSpan is the default {@link Span} that is used when no Span
    	 * implementation is available. All operations are no-op including context
    	 * propagation.
    	 */var NonRecordingSpan=/** @class */function(){function NonRecordingSpan(_spanContext){if(_spanContext===void 0){_spanContext=INVALID_SPAN_CONTEXT;}this._spanContext=_spanContext;}// Returns a SpanContext.
    	NonRecordingSpan.prototype.spanContext=function(){return this._spanContext;};// By default does nothing
    	NonRecordingSpan.prototype.setAttribute=function(_key,_value){return this;};// By default does nothing
    	NonRecordingSpan.prototype.setAttributes=function(_attributes){return this;};// By default does nothing
    	NonRecordingSpan.prototype.addEvent=function(_name,_attributes){return this;};NonRecordingSpan.prototype.addLink=function(_link){return this;};NonRecordingSpan.prototype.addLinks=function(_links){return this;};// By default does nothing
    	NonRecordingSpan.prototype.setStatus=function(_status){return this;};// By default does nothing
    	NonRecordingSpan.prototype.updateName=function(_name){return this;};// By default does nothing
    	NonRecordingSpan.prototype.end=function(_endTime){};// isRecording always returns false for NonRecordingSpan.
    	NonRecordingSpan.prototype.isRecording=function(){return false;};// By default does nothing
    	NonRecordingSpan.prototype.recordException=function(_exception,_time){};return NonRecordingSpan;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * span key
    	 */var SPAN_KEY=createContextKey('OpenTelemetry Context Key SPAN');/**
    	 * Return the span if one exists
    	 *
    	 * @param context context to get span from
    	 */function getSpan(context){return context.getValue(SPAN_KEY)||undefined;}/**
    	 * Gets the span from the current context, if one exists.
    	 */function getActiveSpan(){return getSpan(ContextAPI.getInstance().active());}/**
    	 * Set the span on a context
    	 *
    	 * @param context context to use as parent
    	 * @param span span to set active
    	 */function setSpan(context,span){return context.setValue(SPAN_KEY,span);}/**
    	 * Remove current span stored in the context
    	 *
    	 * @param context context to delete span from
    	 */function deleteSpan(context){return context.deleteValue(SPAN_KEY);}/**
    	 * Wrap span context in a NoopSpan and set as span in a new
    	 * context
    	 *
    	 * @param context context to set active span on
    	 * @param spanContext span context to be wrapped
    	 */function setSpanContext(context,spanContext){return setSpan(context,new NonRecordingSpan(spanContext));}/**
    	 * Get the span context of the span if it exists.
    	 *
    	 * @param context context to get values from
    	 */function getSpanContext(context){var _a;return (_a=getSpan(context))===null||_a===void 0?void 0:_a.spanContext();}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var VALID_TRACEID_REGEX=/^([0-9a-f]{32})$/i;var VALID_SPANID_REGEX=/^[0-9a-f]{16}$/i;function isValidTraceId(traceId){return VALID_TRACEID_REGEX.test(traceId)&&traceId!==INVALID_TRACEID;}function isValidSpanId(spanId){return VALID_SPANID_REGEX.test(spanId)&&spanId!==INVALID_SPANID;}/**
    	 * Returns true if this {@link SpanContext} is valid.
    	 * @return true if this {@link SpanContext} is valid.
    	 */function isSpanContextValid(spanContext){return isValidTraceId(spanContext.traceId)&&isValidSpanId(spanContext.spanId);}/**
    	 * Wrap the given {@link SpanContext} in a new non-recording {@link Span}
    	 *
    	 * @param spanContext span context to be wrapped
    	 * @returns a new non-recording {@link Span} with the provided context
    	 */function wrapSpanContext(spanContext){return new NonRecordingSpan(spanContext);}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var contextApi=ContextAPI.getInstance();/**
    	 * No-op implementations of {@link Tracer}.
    	 */var NoopTracer=/** @class */function(){function NoopTracer(){}// startSpan starts a noop span.
    	NoopTracer.prototype.startSpan=function(name,options,context){if(context===void 0){context=contextApi.active();}var root=Boolean(options===null||options===void 0?void 0:options.root);if(root){return new NonRecordingSpan();}var parentFromContext=context&&getSpanContext(context);if(isSpanContext(parentFromContext)&&isSpanContextValid(parentFromContext)){return new NonRecordingSpan(parentFromContext);}else {return new NonRecordingSpan();}};NoopTracer.prototype.startActiveSpan=function(name,arg2,arg3,arg4){var opts;var ctx;var fn;if(arguments.length<2){return;}else if(arguments.length===2){fn=arg2;}else if(arguments.length===3){opts=arg2;fn=arg3;}else {opts=arg2;ctx=arg3;fn=arg4;}var parentContext=ctx!==null&&ctx!==void 0?ctx:contextApi.active();var span=this.startSpan(name,opts,parentContext);var contextWithSpanSet=setSpan(parentContext,span);return contextApi.with(contextWithSpanSet,fn,undefined,span);};return NoopTracer;}();function isSpanContext(spanContext){return typeof spanContext==='object'&&typeof spanContext['spanId']==='string'&&typeof spanContext['traceId']==='string'&&typeof spanContext['traceFlags']==='number';}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var NOOP_TRACER=new NoopTracer();/**
    	 * Proxy tracer provided by the proxy tracer provider
    	 */var ProxyTracer=/** @class */function(){function ProxyTracer(_provider,name,version,options){this._provider=_provider;this.name=name;this.version=version;this.options=options;}ProxyTracer.prototype.startSpan=function(name,options,context){return this._getTracer().startSpan(name,options,context);};ProxyTracer.prototype.startActiveSpan=function(_name,_options,_context,_fn){var tracer=this._getTracer();return Reflect.apply(tracer.startActiveSpan,tracer,arguments);};/**
    	     * Try to get a tracer from the proxy tracer provider.
    	     * If the proxy tracer provider has no delegate, return a noop tracer.
    	     */ProxyTracer.prototype._getTracer=function(){if(this._delegate){return this._delegate;}var tracer=this._provider.getDelegateTracer(this.name,this.version,this.options);if(!tracer){return NOOP_TRACER;}this._delegate=tracer;return this._delegate;};return ProxyTracer;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * An implementation of the {@link TracerProvider} which returns an impotent
    	 * Tracer for all calls to `getTracer`.
    	 *
    	 * All operations are no-op.
    	 */var NoopTracerProvider=/** @class */function(){function NoopTracerProvider(){}NoopTracerProvider.prototype.getTracer=function(_name,_version,_options){return new NoopTracer();};return NoopTracerProvider;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var NOOP_TRACER_PROVIDER=new NoopTracerProvider();/**
    	 * Tracer provider which provides {@link ProxyTracer}s.
    	 *
    	 * Before a delegate is set, tracers provided are NoOp.
    	 *   When a delegate is set, traces are provided from the delegate.
    	 *   When a delegate is set after tracers have already been provided,
    	 *   all tracers already provided will use the provided delegate implementation.
    	 */var ProxyTracerProvider=/** @class */function(){function ProxyTracerProvider(){}/**
    	     * Get a {@link ProxyTracer}
    	     */ProxyTracerProvider.prototype.getTracer=function(name,version,options){var _a;return (_a=this.getDelegateTracer(name,version,options))!==null&&_a!==void 0?_a:new ProxyTracer(this,name,version,options);};ProxyTracerProvider.prototype.getDelegate=function(){var _a;return (_a=this._delegate)!==null&&_a!==void 0?_a:NOOP_TRACER_PROVIDER;};/**
    	     * Set the delegate tracer provider
    	     */ProxyTracerProvider.prototype.setDelegate=function(delegate){this._delegate=delegate;};ProxyTracerProvider.prototype.getDelegateTracer=function(name,version,options){var _a;return (_a=this._delegate)===null||_a===void 0?void 0:_a.getTracer(name,version,options);};return ProxyTracerProvider;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * @deprecated use the one declared in @opentelemetry/sdk-trace-base instead.
    	 * A sampling decision that determines how a {@link Span} will be recorded
    	 * and collected.
    	 */var SamplingDecision$1;(function(SamplingDecision){/**
    	     * `Span.isRecording() === false`, span will not be recorded and all events
    	     * and attributes will be dropped.
    	     */SamplingDecision[SamplingDecision["NOT_RECORD"]=0]="NOT_RECORD";/**
    	     * `Span.isRecording() === true`, but `Sampled` flag in {@link TraceFlags}
    	     * MUST NOT be set.
    	     */SamplingDecision[SamplingDecision["RECORD"]=1]="RECORD";/**
    	     * `Span.isRecording() === true` AND `Sampled` flag in {@link TraceFlags}
    	     * MUST be set.
    	     */SamplingDecision[SamplingDecision["RECORD_AND_SAMPLED"]=2]="RECORD_AND_SAMPLED";})(SamplingDecision$1||(SamplingDecision$1={}));/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var SpanKind$1;(function(SpanKind){/** Default value. Indicates that the span is used internally. */SpanKind[SpanKind["INTERNAL"]=0]="INTERNAL";/**
    	     * Indicates that the span covers server-side handling of an RPC or other
    	     * remote request.
    	     */SpanKind[SpanKind["SERVER"]=1]="SERVER";/**
    	     * Indicates that the span covers the client-side wrapper around an RPC or
    	     * other remote request.
    	     */SpanKind[SpanKind["CLIENT"]=2]="CLIENT";/**
    	     * Indicates that the span describes producer sending a message to a
    	     * broker. Unlike client and server, there is no direct critical path latency
    	     * relationship between producer and consumer spans.
    	     */SpanKind[SpanKind["PRODUCER"]=3]="PRODUCER";/**
    	     * Indicates that the span describes consumer receiving a message from a
    	     * broker. Unlike client and server, there is no direct critical path latency
    	     * relationship between producer and consumer spans.
    	     */SpanKind[SpanKind["CONSUMER"]=4]="CONSUMER";})(SpanKind$1||(SpanKind$1={}));/**
    	 * An enumeration of status codes.
    	 */var SpanStatusCode;(function(SpanStatusCode){/**
    	     * The default status.
    	     */SpanStatusCode[SpanStatusCode["UNSET"]=0]="UNSET";/**
    	     * The operation has been validated by an Application developer or
    	     * Operator to have completed successfully.
    	     */SpanStatusCode[SpanStatusCode["OK"]=1]="OK";/**
    	     * The operation contains an error.
    	     */SpanStatusCode[SpanStatusCode["ERROR"]=2]="ERROR";})(SpanStatusCode||(SpanStatusCode={}));/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Split module-level variable definition into separate files to allow
    	// tree-shaking on each api instance.
    	/** Entrypoint for context API */var context=ContextAPI.getInstance();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Split module-level variable definition into separate files to allow
    	// tree-shaking on each api instance.
    	/**
    	 * Entrypoint for Diag API.
    	 * Defines Diagnostic handler used for internal diagnostic logging operations.
    	 * The default provides a Noop DiagLogger implementation which may be changed via the
    	 * diag.setLogger(logger: DiagLogger) function.
    	 */var diag=DiagAPI.instance();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * An implementation of the {@link MeterProvider} which returns an impotent Meter
    	 * for all calls to `getMeter`
    	 */var NoopMeterProvider=/** @class */function(){function NoopMeterProvider(){}NoopMeterProvider.prototype.getMeter=function(_name,_version,_options){return NOOP_METER;};return NoopMeterProvider;}();var NOOP_METER_PROVIDER=new NoopMeterProvider();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var API_NAME$2='metrics';/**
    	 * Singleton object which represents the entry point to the OpenTelemetry Metrics API
    	 */var MetricsAPI=/** @class */function(){/** Empty private constructor prevents end users from constructing a new instance of the API */function MetricsAPI(){}/** Get the singleton instance of the Metrics API */MetricsAPI.getInstance=function(){if(!this._instance){this._instance=new MetricsAPI();}return this._instance;};/**
    	     * Set the current global meter provider.
    	     * Returns true if the meter provider was successfully registered, else false.
    	     */MetricsAPI.prototype.setGlobalMeterProvider=function(provider){return registerGlobal(API_NAME$2,provider,DiagAPI.instance());};/**
    	     * Returns the global meter provider.
    	     */MetricsAPI.prototype.getMeterProvider=function(){return getGlobal(API_NAME$2)||NOOP_METER_PROVIDER;};/**
    	     * Returns a meter from the global meter provider.
    	     */MetricsAPI.prototype.getMeter=function(name,version,options){return this.getMeterProvider().getMeter(name,version,options);};/** Remove the global meter provider */MetricsAPI.prototype.disable=function(){unregisterGlobal(API_NAME$2,DiagAPI.instance());};return MetricsAPI;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Split module-level variable definition into separate files to allow
    	// tree-shaking on each api instance.
    	/** Entrypoint for metrics API */var metrics=MetricsAPI.getInstance();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * No-op implementations of {@link TextMapPropagator}.
    	 */var NoopTextMapPropagator=/** @class */function(){function NoopTextMapPropagator(){}/** Noop inject function does nothing */NoopTextMapPropagator.prototype.inject=function(_context,_carrier){};/** Noop extract function does nothing and returns the input context */NoopTextMapPropagator.prototype.extract=function(context,_carrier){return context;};NoopTextMapPropagator.prototype.fields=function(){return [];};return NoopTextMapPropagator;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * Baggage key
    	 */var BAGGAGE_KEY=createContextKey('OpenTelemetry Baggage Key');/**
    	 * Retrieve the current baggage from the given context
    	 *
    	 * @param {Context} Context that manage all context values
    	 * @returns {Baggage} Extracted baggage from the context
    	 */function getBaggage(context){return context.getValue(BAGGAGE_KEY)||undefined;}/**
    	 * Retrieve the current baggage from the active/current context
    	 *
    	 * @returns {Baggage} Extracted baggage from the context
    	 */function getActiveBaggage(){return getBaggage(ContextAPI.getInstance().active());}/**
    	 * Store a baggage in the given context
    	 *
    	 * @param {Context} Context that manage all context values
    	 * @param {Baggage} baggage that will be set in the actual context
    	 */function setBaggage(context,baggage){return context.setValue(BAGGAGE_KEY,baggage);}/**
    	 * Delete the baggage stored in the given context
    	 *
    	 * @param {Context} Context that manage all context values
    	 */function deleteBaggage(context){return context.deleteValue(BAGGAGE_KEY);}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var API_NAME$1='propagation';var NOOP_TEXT_MAP_PROPAGATOR=new NoopTextMapPropagator();/**
    	 * Singleton object which represents the entry point to the OpenTelemetry Propagation API
    	 */var PropagationAPI=/** @class */function(){/** Empty private constructor prevents end users from constructing a new instance of the API */function PropagationAPI(){this.createBaggage=createBaggage;this.getBaggage=getBaggage;this.getActiveBaggage=getActiveBaggage;this.setBaggage=setBaggage;this.deleteBaggage=deleteBaggage;}/** Get the singleton instance of the Propagator API */PropagationAPI.getInstance=function(){if(!this._instance){this._instance=new PropagationAPI();}return this._instance;};/**
    	     * Set the current propagator.
    	     *
    	     * @returns true if the propagator was successfully registered, else false
    	     */PropagationAPI.prototype.setGlobalPropagator=function(propagator){return registerGlobal(API_NAME$1,propagator,DiagAPI.instance());};/**
    	     * Inject context into a carrier to be propagated inter-process
    	     *
    	     * @param context Context carrying tracing data to inject
    	     * @param carrier carrier to inject context into
    	     * @param setter Function used to set values on the carrier
    	     */PropagationAPI.prototype.inject=function(context,carrier,setter){if(setter===void 0){setter=defaultTextMapSetter;}return this._getGlobalPropagator().inject(context,carrier,setter);};/**
    	     * Extract context from a carrier
    	     *
    	     * @param context Context which the newly created context will inherit from
    	     * @param carrier Carrier to extract context from
    	     * @param getter Function used to extract keys from a carrier
    	     */PropagationAPI.prototype.extract=function(context,carrier,getter){if(getter===void 0){getter=defaultTextMapGetter;}return this._getGlobalPropagator().extract(context,carrier,getter);};/**
    	     * Return a list of all fields which may be used by the propagator.
    	     */PropagationAPI.prototype.fields=function(){return this._getGlobalPropagator().fields();};/** Remove the global propagator */PropagationAPI.prototype.disable=function(){unregisterGlobal(API_NAME$1,DiagAPI.instance());};PropagationAPI.prototype._getGlobalPropagator=function(){return getGlobal(API_NAME$1)||NOOP_TEXT_MAP_PROPAGATOR;};return PropagationAPI;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Split module-level variable definition into separate files to allow
    	// tree-shaking on each api instance.
    	/** Entrypoint for propagation API */var propagation=PropagationAPI.getInstance();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var API_NAME='trace';/**
    	 * Singleton object which represents the entry point to the OpenTelemetry Tracing API
    	 */var TraceAPI=/** @class */function(){/** Empty private constructor prevents end users from constructing a new instance of the API */function TraceAPI(){this._proxyTracerProvider=new ProxyTracerProvider();this.wrapSpanContext=wrapSpanContext;this.isSpanContextValid=isSpanContextValid;this.deleteSpan=deleteSpan;this.getSpan=getSpan;this.getActiveSpan=getActiveSpan;this.getSpanContext=getSpanContext;this.setSpan=setSpan;this.setSpanContext=setSpanContext;}/** Get the singleton instance of the Trace API */TraceAPI.getInstance=function(){if(!this._instance){this._instance=new TraceAPI();}return this._instance;};/**
    	     * Set the current global tracer.
    	     *
    	     * @returns true if the tracer provider was successfully registered, else false
    	     */TraceAPI.prototype.setGlobalTracerProvider=function(provider){var success=registerGlobal(API_NAME,this._proxyTracerProvider,DiagAPI.instance());if(success){this._proxyTracerProvider.setDelegate(provider);}return success;};/**
    	     * Returns the global tracer provider.
    	     */TraceAPI.prototype.getTracerProvider=function(){return getGlobal(API_NAME)||this._proxyTracerProvider;};/**
    	     * Returns a tracer from the global tracer provider.
    	     */TraceAPI.prototype.getTracer=function(name,version){return this.getTracerProvider().getTracer(name,version);};/** Remove the global tracer provider */TraceAPI.prototype.disable=function(){unregisterGlobal(API_NAME,DiagAPI.instance());this._proxyTracerProvider=new ProxyTracerProvider();};return TraceAPI;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Split module-level variable definition into separate files to allow
    	// tree-shaking on each api instance.
    	/** Entrypoint for trace API */var trace=TraceAPI.getInstance();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var SUPPRESS_TRACING_KEY=createContextKey('OpenTelemetry SDK Context Key SUPPRESS_TRACING');function suppressTracing(context){return context.setValue(SUPPRESS_TRACING_KEY,true);}function isTracingSuppressed(context){return context.getValue(SUPPRESS_TRACING_KEY)===true;}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var BAGGAGE_KEY_PAIR_SEPARATOR='=';var BAGGAGE_PROPERTIES_SEPARATOR=';';var BAGGAGE_ITEMS_SEPARATOR=',';// Name of the http header used to propagate the baggage
    	var BAGGAGE_HEADER='baggage';// Maximum number of name-value pairs allowed by w3c spec
    	var BAGGAGE_MAX_NAME_VALUE_PAIRS=180;// Maximum number of bytes per a single name-value pair allowed by w3c spec
    	var BAGGAGE_MAX_PER_NAME_VALUE_PAIRS=4096;// Maximum total length of all name-value pairs allowed by w3c spec
    	var BAGGAGE_MAX_TOTAL_LENGTH=8192;var __read$5=function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-->0)&&!(r=i.next()).done)ar.push(r.value);}catch(error){e={error:error};}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i);}finally{if(e)throw e.error;}}return ar;};function serializeKeyPairs(keyPairs){return keyPairs.reduce(function(hValue,current){var value=""+hValue+(hValue!==''?BAGGAGE_ITEMS_SEPARATOR:'')+current;return value.length>BAGGAGE_MAX_TOTAL_LENGTH?hValue:value;},'');}function getKeyPairs(baggage){return baggage.getAllEntries().map(function(_a){var _b=__read$5(_a,2),key=_b[0],value=_b[1];var entry=encodeURIComponent(key)+"="+encodeURIComponent(value.value);// include opaque metadata if provided
    	// NOTE: we intentionally don't URI-encode the metadata - that responsibility falls on the metadata implementation
    	if(value.metadata!==undefined){entry+=BAGGAGE_PROPERTIES_SEPARATOR+value.metadata.toString();}return entry;});}function parsePairKeyValue(entry){var valueProps=entry.split(BAGGAGE_PROPERTIES_SEPARATOR);if(valueProps.length<=0)return;var keyPairPart=valueProps.shift();if(!keyPairPart)return;var separatorIndex=keyPairPart.indexOf(BAGGAGE_KEY_PAIR_SEPARATOR);if(separatorIndex<=0)return;var key=decodeURIComponent(keyPairPart.substring(0,separatorIndex).trim());var value=decodeURIComponent(keyPairPart.substring(separatorIndex+1).trim());var metadata;if(valueProps.length>0){metadata=baggageEntryMetadataFromString(valueProps.join(BAGGAGE_PROPERTIES_SEPARATOR));}return {key:key,value:value,metadata:metadata};}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * Propagates {@link Baggage} through Context format propagation.
    	 *
    	 * Based on the Baggage specification:
    	 * https://w3c.github.io/baggage/
    	 */var W3CBaggagePropagator=/** @class */function(){function W3CBaggagePropagator(){}W3CBaggagePropagator.prototype.inject=function(context,carrier,setter){var baggage=propagation.getBaggage(context);if(!baggage||isTracingSuppressed(context))return;var keyPairs=getKeyPairs(baggage).filter(function(pair){return pair.length<=BAGGAGE_MAX_PER_NAME_VALUE_PAIRS;}).slice(0,BAGGAGE_MAX_NAME_VALUE_PAIRS);var headerValue=serializeKeyPairs(keyPairs);if(headerValue.length>0){setter.set(carrier,BAGGAGE_HEADER,headerValue);}};W3CBaggagePropagator.prototype.extract=function(context,carrier,getter){var headerValue=getter.get(carrier,BAGGAGE_HEADER);var baggageString=Array.isArray(headerValue)?headerValue.join(BAGGAGE_ITEMS_SEPARATOR):headerValue;if(!baggageString)return context;var baggage={};if(baggageString.length===0){return context;}var pairs=baggageString.split(BAGGAGE_ITEMS_SEPARATOR);pairs.forEach(function(entry){var keyPair=parsePairKeyValue(entry);if(keyPair){var baggageEntry={value:keyPair.value};if(keyPair.metadata){baggageEntry.metadata=keyPair.metadata;}baggage[keyPair.key]=baggageEntry;}});if(Object.entries(baggage).length===0){return context;}return propagation.setBaggage(context,propagation.createBaggage(baggage));};W3CBaggagePropagator.prototype.fields=function(){return [BAGGAGE_HEADER];};return W3CBaggagePropagator;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __values$3=function(o){var s=typeof Symbol==="function"&&Symbol.iterator,m=s&&o[s],i=0;if(m)return m.call(o);if(o&&typeof o.length==="number")return {next:function(){if(o&&i>=o.length)o=void 0;return {value:o&&o[i++],done:!o};}};throw new TypeError(s?"Object is not iterable.":"Symbol.iterator is not defined.");};var __read$4=function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-->0)&&!(r=i.next()).done)ar.push(r.value);}catch(error){e={error:error};}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i);}finally{if(e)throw e.error;}}return ar;};function sanitizeAttributes(attributes){var e_1,_a;var out={};if(typeof attributes!=='object'||attributes==null){return out;}try{for(var _b=__values$3(Object.entries(attributes)),_c=_b.next();!_c.done;_c=_b.next()){var _d=__read$4(_c.value,2),key=_d[0],val=_d[1];if(!isAttributeKey(key)){diag.warn("Invalid attribute key: "+key);continue;}if(!isAttributeValue(val)){diag.warn("Invalid attribute value set for key: "+key);continue;}if(Array.isArray(val)){out[key]=val.slice();}else {out[key]=val;}}}catch(e_1_1){e_1={error:e_1_1};}finally{try{if(_c&&!_c.done&&(_a=_b.return))_a.call(_b);}finally{if(e_1)throw e_1.error;}}return out;}function isAttributeKey(key){return typeof key==='string'&&key.length>0;}function isAttributeValue(val){if(val==null){return true;}if(Array.isArray(val)){return isHomogeneousAttributeValueArray(val);}return isValidPrimitiveAttributeValue(val);}function isHomogeneousAttributeValueArray(arr){var e_2,_a;var type;try{for(var arr_1=__values$3(arr),arr_1_1=arr_1.next();!arr_1_1.done;arr_1_1=arr_1.next()){var element=arr_1_1.value;// null/undefined elements are allowed
    	if(element==null)continue;if(!type){if(isValidPrimitiveAttributeValue(element)){type=typeof element;continue;}// encountered an invalid primitive
    	return false;}if(typeof element===type){continue;}return false;}}catch(e_2_1){e_2={error:e_2_1};}finally{try{if(arr_1_1&&!arr_1_1.done&&(_a=arr_1.return))_a.call(arr_1);}finally{if(e_2)throw e_2.error;}}return true;}function isValidPrimitiveAttributeValue(val){switch(typeof val){case 'number':case 'boolean':case 'string':return true;}return false;}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * Returns a function that logs an error using the provided logger, or a
    	 * console logger if one was not provided.
    	 */function loggingErrorHandler(){return function(ex){diag.error(stringifyException(ex));};}/**
    	 * Converts an exception into a string representation
    	 * @param {Exception} ex
    	 */function stringifyException(ex){if(typeof ex==='string'){return ex;}else {return JSON.stringify(flattenException(ex));}}/**
    	 * Flattens an exception into key-value pairs by traversing the prototype chain
    	 * and coercing values to strings. Duplicate properties will not be overwritten;
    	 * the first insert wins.
    	 */function flattenException(ex){var result={};var current=ex;while(current!==null){Object.getOwnPropertyNames(current).forEach(function(propertyName){if(result[propertyName])return;var value=current[propertyName];if(value){result[propertyName]=String(value);}});current=Object.getPrototypeOf(current);}return result;}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//** The global error handler delegate */var delegateHandler=loggingErrorHandler();/**
    	 * Return the global error handler
    	 * @param {Exception} ex
    	 */function globalErrorHandler(ex){try{delegateHandler(ex);}catch(_a){}// eslint-disable-line no-empty
    	}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var TracesSamplerValues;(function(TracesSamplerValues){TracesSamplerValues["AlwaysOff"]="always_off";TracesSamplerValues["AlwaysOn"]="always_on";TracesSamplerValues["ParentBasedAlwaysOff"]="parentbased_always_off";TracesSamplerValues["ParentBasedAlwaysOn"]="parentbased_always_on";TracesSamplerValues["ParentBasedTraceIdRatio"]="parentbased_traceidratio";TracesSamplerValues["TraceIdRatio"]="traceidratio";})(TracesSamplerValues||(TracesSamplerValues={}));/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var DEFAULT_LIST_SEPARATOR=',';/**
    	 * Environment interface to define all names
    	 */var ENVIRONMENT_BOOLEAN_KEYS=['OTEL_SDK_DISABLED'];function isEnvVarABoolean(key){return ENVIRONMENT_BOOLEAN_KEYS.indexOf(key)>-1;}var ENVIRONMENT_NUMBERS_KEYS=['OTEL_BSP_EXPORT_TIMEOUT','OTEL_BSP_MAX_EXPORT_BATCH_SIZE','OTEL_BSP_MAX_QUEUE_SIZE','OTEL_BSP_SCHEDULE_DELAY','OTEL_BLRP_EXPORT_TIMEOUT','OTEL_BLRP_MAX_EXPORT_BATCH_SIZE','OTEL_BLRP_MAX_QUEUE_SIZE','OTEL_BLRP_SCHEDULE_DELAY','OTEL_ATTRIBUTE_VALUE_LENGTH_LIMIT','OTEL_ATTRIBUTE_COUNT_LIMIT','OTEL_SPAN_ATTRIBUTE_VALUE_LENGTH_LIMIT','OTEL_SPAN_ATTRIBUTE_COUNT_LIMIT','OTEL_LOGRECORD_ATTRIBUTE_VALUE_LENGTH_LIMIT','OTEL_LOGRECORD_ATTRIBUTE_COUNT_LIMIT','OTEL_SPAN_EVENT_COUNT_LIMIT','OTEL_SPAN_LINK_COUNT_LIMIT','OTEL_SPAN_ATTRIBUTE_PER_EVENT_COUNT_LIMIT','OTEL_SPAN_ATTRIBUTE_PER_LINK_COUNT_LIMIT','OTEL_EXPORTER_OTLP_TIMEOUT','OTEL_EXPORTER_OTLP_TRACES_TIMEOUT','OTEL_EXPORTER_OTLP_METRICS_TIMEOUT','OTEL_EXPORTER_OTLP_LOGS_TIMEOUT','OTEL_EXPORTER_JAEGER_AGENT_PORT'];function isEnvVarANumber(key){return ENVIRONMENT_NUMBERS_KEYS.indexOf(key)>-1;}var ENVIRONMENT_LISTS_KEYS=['OTEL_NO_PATCH_MODULES','OTEL_PROPAGATORS'];function isEnvVarAList(key){return ENVIRONMENT_LISTS_KEYS.indexOf(key)>-1;}var DEFAULT_ATTRIBUTE_VALUE_LENGTH_LIMIT=Infinity;var DEFAULT_ATTRIBUTE_COUNT_LIMIT=128;var DEFAULT_SPAN_ATTRIBUTE_PER_EVENT_COUNT_LIMIT=128;var DEFAULT_SPAN_ATTRIBUTE_PER_LINK_COUNT_LIMIT=128;/**
    	 * Default environment variables
    	 */var DEFAULT_ENVIRONMENT={OTEL_SDK_DISABLED:false,CONTAINER_NAME:'',ECS_CONTAINER_METADATA_URI_V4:'',ECS_CONTAINER_METADATA_URI:'',HOSTNAME:'',KUBERNETES_SERVICE_HOST:'',NAMESPACE:'',OTEL_BSP_EXPORT_TIMEOUT:30000,OTEL_BSP_MAX_EXPORT_BATCH_SIZE:512,OTEL_BSP_MAX_QUEUE_SIZE:2048,OTEL_BSP_SCHEDULE_DELAY:5000,OTEL_BLRP_EXPORT_TIMEOUT:30000,OTEL_BLRP_MAX_EXPORT_BATCH_SIZE:512,OTEL_BLRP_MAX_QUEUE_SIZE:2048,OTEL_BLRP_SCHEDULE_DELAY:5000,OTEL_EXPORTER_JAEGER_AGENT_HOST:'',OTEL_EXPORTER_JAEGER_AGENT_PORT:6832,OTEL_EXPORTER_JAEGER_ENDPOINT:'',OTEL_EXPORTER_JAEGER_PASSWORD:'',OTEL_EXPORTER_JAEGER_USER:'',OTEL_EXPORTER_OTLP_ENDPOINT:'',OTEL_EXPORTER_OTLP_TRACES_ENDPOINT:'',OTEL_EXPORTER_OTLP_METRICS_ENDPOINT:'',OTEL_EXPORTER_OTLP_LOGS_ENDPOINT:'',OTEL_EXPORTER_OTLP_HEADERS:'',OTEL_EXPORTER_OTLP_TRACES_HEADERS:'',OTEL_EXPORTER_OTLP_METRICS_HEADERS:'',OTEL_EXPORTER_OTLP_LOGS_HEADERS:'',OTEL_EXPORTER_OTLP_TIMEOUT:10000,OTEL_EXPORTER_OTLP_TRACES_TIMEOUT:10000,OTEL_EXPORTER_OTLP_METRICS_TIMEOUT:10000,OTEL_EXPORTER_OTLP_LOGS_TIMEOUT:10000,OTEL_EXPORTER_ZIPKIN_ENDPOINT:'http://localhost:9411/api/v2/spans',OTEL_LOG_LEVEL:DiagLogLevel.INFO,OTEL_NO_PATCH_MODULES:[],OTEL_PROPAGATORS:['tracecontext','baggage'],OTEL_RESOURCE_ATTRIBUTES:'',OTEL_SERVICE_NAME:'',OTEL_ATTRIBUTE_VALUE_LENGTH_LIMIT:DEFAULT_ATTRIBUTE_VALUE_LENGTH_LIMIT,OTEL_ATTRIBUTE_COUNT_LIMIT:DEFAULT_ATTRIBUTE_COUNT_LIMIT,OTEL_SPAN_ATTRIBUTE_VALUE_LENGTH_LIMIT:DEFAULT_ATTRIBUTE_VALUE_LENGTH_LIMIT,OTEL_SPAN_ATTRIBUTE_COUNT_LIMIT:DEFAULT_ATTRIBUTE_COUNT_LIMIT,OTEL_LOGRECORD_ATTRIBUTE_VALUE_LENGTH_LIMIT:DEFAULT_ATTRIBUTE_VALUE_LENGTH_LIMIT,OTEL_LOGRECORD_ATTRIBUTE_COUNT_LIMIT:DEFAULT_ATTRIBUTE_COUNT_LIMIT,OTEL_SPAN_EVENT_COUNT_LIMIT:128,OTEL_SPAN_LINK_COUNT_LIMIT:128,OTEL_SPAN_ATTRIBUTE_PER_EVENT_COUNT_LIMIT:DEFAULT_SPAN_ATTRIBUTE_PER_EVENT_COUNT_LIMIT,OTEL_SPAN_ATTRIBUTE_PER_LINK_COUNT_LIMIT:DEFAULT_SPAN_ATTRIBUTE_PER_LINK_COUNT_LIMIT,OTEL_TRACES_EXPORTER:'',OTEL_TRACES_SAMPLER:TracesSamplerValues.ParentBasedAlwaysOn,OTEL_TRACES_SAMPLER_ARG:'',OTEL_LOGS_EXPORTER:'',OTEL_EXPORTER_OTLP_INSECURE:'',OTEL_EXPORTER_OTLP_TRACES_INSECURE:'',OTEL_EXPORTER_OTLP_METRICS_INSECURE:'',OTEL_EXPORTER_OTLP_LOGS_INSECURE:'',OTEL_EXPORTER_OTLP_CERTIFICATE:'',OTEL_EXPORTER_OTLP_TRACES_CERTIFICATE:'',OTEL_EXPORTER_OTLP_METRICS_CERTIFICATE:'',OTEL_EXPORTER_OTLP_LOGS_CERTIFICATE:'',OTEL_EXPORTER_OTLP_COMPRESSION:'',OTEL_EXPORTER_OTLP_TRACES_COMPRESSION:'',OTEL_EXPORTER_OTLP_METRICS_COMPRESSION:'',OTEL_EXPORTER_OTLP_LOGS_COMPRESSION:'',OTEL_EXPORTER_OTLP_CLIENT_KEY:'',OTEL_EXPORTER_OTLP_TRACES_CLIENT_KEY:'',OTEL_EXPORTER_OTLP_METRICS_CLIENT_KEY:'',OTEL_EXPORTER_OTLP_LOGS_CLIENT_KEY:'',OTEL_EXPORTER_OTLP_CLIENT_CERTIFICATE:'',OTEL_EXPORTER_OTLP_TRACES_CLIENT_CERTIFICATE:'',OTEL_EXPORTER_OTLP_METRICS_CLIENT_CERTIFICATE:'',OTEL_EXPORTER_OTLP_LOGS_CLIENT_CERTIFICATE:'',OTEL_EXPORTER_OTLP_PROTOCOL:'http/protobuf',OTEL_EXPORTER_OTLP_TRACES_PROTOCOL:'http/protobuf',OTEL_EXPORTER_OTLP_METRICS_PROTOCOL:'http/protobuf',OTEL_EXPORTER_OTLP_LOGS_PROTOCOL:'http/protobuf',OTEL_EXPORTER_OTLP_METRICS_TEMPORALITY_PREFERENCE:'cumulative'};/**
    	 * @param key
    	 * @param environment
    	 * @param values
    	 */function parseBoolean(key,environment,values){if(typeof values[key]==='undefined'){return;}var value=String(values[key]);// support case-insensitive "true"
    	environment[key]=value.toLowerCase()==='true';}/**
    	 * Parses a variable as number with number validation
    	 * @param name
    	 * @param environment
    	 * @param values
    	 * @param min
    	 * @param max
    	 */function parseNumber(name,environment,values,min,max){if(min===void 0){min=-Infinity;}if(max===void 0){max=Infinity;}if(typeof values[name]!=='undefined'){var value=Number(values[name]);if(!isNaN(value)){if(value<min){environment[name]=min;}else if(value>max){environment[name]=max;}else {environment[name]=value;}}}}/**
    	 * Parses list-like strings from input into output.
    	 * @param name
    	 * @param environment
    	 * @param values
    	 * @param separator
    	 */function parseStringList(name,output,input,separator){if(separator===void 0){separator=DEFAULT_LIST_SEPARATOR;}var givenValue=input[name];if(typeof givenValue==='string'){output[name]=givenValue.split(separator).map(function(v){return v.trim();});}}// The support string -> DiagLogLevel mappings
    	var logLevelMap={ALL:DiagLogLevel.ALL,VERBOSE:DiagLogLevel.VERBOSE,DEBUG:DiagLogLevel.DEBUG,INFO:DiagLogLevel.INFO,WARN:DiagLogLevel.WARN,ERROR:DiagLogLevel.ERROR,NONE:DiagLogLevel.NONE};/**
    	 * Environmentally sets log level if valid log level string is provided
    	 * @param key
    	 * @param environment
    	 * @param values
    	 */function setLogLevelFromEnv(key,environment,values){var value=values[key];if(typeof value==='string'){var theLevel=logLevelMap[value.toUpperCase()];if(theLevel!=null){environment[key]=theLevel;}}}/**
    	 * Parses environment values
    	 * @param values
    	 */function parseEnvironment(values){var environment={};for(var env in DEFAULT_ENVIRONMENT){var key=env;switch(key){case 'OTEL_LOG_LEVEL':setLogLevelFromEnv(key,environment,values);break;default:if(isEnvVarABoolean(key)){parseBoolean(key,environment,values);}else if(isEnvVarANumber(key)){parseNumber(key,environment,values);}else if(isEnvVarAList(key)){parseStringList(key,environment,values);}else {var value=values[key];if(typeof value!=='undefined'&&value!==null){environment[key]=String(value);}}}}return environment;}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Updates to this file should also be replicated to @opentelemetry/api too.
    	/**
    	 * - globalThis (New standard)
    	 * - self (Will return the current window instance for supported browsers)
    	 * - window (fallback for older browser implementations)
    	 * - global (NodeJS implementation)
    	 * - <object> (When all else fails)
    	 *//** only globals that common to node and browsers are allowed */// eslint-disable-next-line node/no-unsupported-features/es-builtins, no-undef
    	var _globalThis$2=typeof globalThis==='object'?globalThis:typeof self==='object'?self:typeof window==='object'?window:typeof commonjsGlobal==='object'?commonjsGlobal:{};/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * Gets the environment variables
    	 */function getEnv(){var globalEnv=parseEnvironment(_globalThis$2);return Object.assign({},DEFAULT_ENVIRONMENT,globalEnv);}function getEnvWithoutDefaults(){return parseEnvironment(_globalThis$2);}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var otperformance$1=performance;/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// this is autogenerated file, see scripts/version-update.js
    	var VERSION$2='1.26.0';/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var TMP_EXCEPTION_TYPE='exception.type';var TMP_EXCEPTION_MESSAGE='exception.message';var TMP_EXCEPTION_STACKTRACE='exception.stacktrace';/**
    	 * The type of the exception (its fully-qualified class name, if applicable). The dynamic type of the exception should be preferred over the static type in languages that support it.
    	 *
    	 * @deprecated use ATTR_EXCEPTION_TYPE
    	 */var SEMATTRS_EXCEPTION_TYPE=TMP_EXCEPTION_TYPE;/**
    	 * The exception message.
    	 *
    	 * @deprecated use ATTR_EXCEPTION_MESSAGE
    	 */var SEMATTRS_EXCEPTION_MESSAGE=TMP_EXCEPTION_MESSAGE;/**
    	 * A stacktrace as a string in the natural representation for the language runtime. The representation is to be determined and documented by each language SIG.
    	 *
    	 * @deprecated use ATTR_EXCEPTION_STACKTRACE
    	 */var SEMATTRS_EXCEPTION_STACKTRACE=TMP_EXCEPTION_STACKTRACE;/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var TMP_PROCESS_RUNTIME_NAME='process.runtime.name';var TMP_SERVICE_NAME='service.name';var TMP_TELEMETRY_SDK_NAME='telemetry.sdk.name';var TMP_TELEMETRY_SDK_LANGUAGE='telemetry.sdk.language';var TMP_TELEMETRY_SDK_VERSION='telemetry.sdk.version';/**
    	 * The name of the runtime of this process. For compiled native binaries, this SHOULD be the name of the compiler.
    	 *
    	 * @deprecated use ATTR_PROCESS_RUNTIME_NAME
    	 */var SEMRESATTRS_PROCESS_RUNTIME_NAME=TMP_PROCESS_RUNTIME_NAME;/**
    	 * Logical name of the service.
    	 *
    	 * Note: MUST be the same for all instances of horizontally scaled services. If the value was not specified, SDKs MUST fallback to `unknown_service:` concatenated with [`process.executable.name`](process.md#process), e.g. `unknown_service:bash`. If `process.executable.name` is not available, the value MUST be set to `unknown_service`.
    	 *
    	 * @deprecated use ATTR_SERVICE_NAME
    	 */var SEMRESATTRS_SERVICE_NAME=TMP_SERVICE_NAME;/**
    	 * The name of the telemetry SDK as defined above.
    	 *
    	 * @deprecated use ATTR_TELEMETRY_SDK_NAME
    	 */var SEMRESATTRS_TELEMETRY_SDK_NAME=TMP_TELEMETRY_SDK_NAME;/**
    	 * The language of the telemetry SDK.
    	 *
    	 * @deprecated use ATTR_TELEMETRY_SDK_LANGUAGE
    	 */var SEMRESATTRS_TELEMETRY_SDK_LANGUAGE=TMP_TELEMETRY_SDK_LANGUAGE;/**
    	 * The version string of the telemetry SDK.
    	 *
    	 * @deprecated use ATTR_TELEMETRY_SDK_VERSION
    	 */var SEMRESATTRS_TELEMETRY_SDK_VERSION=TMP_TELEMETRY_SDK_VERSION;var TMP_TELEMETRYSDKLANGUAGEVALUES_WEBJS='webjs';/**
    	 * The language of the telemetry SDK.
    	 *
    	 * @deprecated Use TELEMETRY_SDK_LANGUAGE_VALUE_WEBJS.
    	 */var TELEMETRYSDKLANGUAGEVALUES_WEBJS=TMP_TELEMETRYSDKLANGUAGEVALUES_WEBJS;/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var _a$1;/** Constants describing the SDK in use */var SDK_INFO=(_a$1={},_a$1[SEMRESATTRS_TELEMETRY_SDK_NAME]='opentelemetry',_a$1[SEMRESATTRS_PROCESS_RUNTIME_NAME]='browser',_a$1[SEMRESATTRS_TELEMETRY_SDK_LANGUAGE]=TELEMETRYSDKLANGUAGEVALUES_WEBJS,_a$1[SEMRESATTRS_TELEMETRY_SDK_VERSION]=VERSION$2,_a$1);/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */function unrefTimer(_timer){}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var NANOSECOND_DIGITS$1=9;var NANOSECOND_DIGITS_IN_MILLIS$1=6;var MILLISECONDS_TO_NANOSECONDS$1=Math.pow(10,NANOSECOND_DIGITS_IN_MILLIS$1);var SECOND_TO_NANOSECONDS$1=Math.pow(10,NANOSECOND_DIGITS$1);/**
    	 * Converts a number of milliseconds from epoch to HrTime([seconds, remainder in nanoseconds]).
    	 * @param epochMillis
    	 */function millisToHrTime$1(epochMillis){var epochSeconds=epochMillis/1000;// Decimals only.
    	var seconds=Math.trunc(epochSeconds);// Round sub-nanosecond accuracy to nanosecond.
    	var nanos=Math.round(epochMillis%1000*MILLISECONDS_TO_NANOSECONDS$1);return [seconds,nanos];}function getTimeOrigin$1(){var timeOrigin=otperformance$1.timeOrigin;if(typeof timeOrigin!=='number'){var perf=otperformance$1;timeOrigin=perf.timing&&perf.timing.fetchStart;}return timeOrigin;}/**
    	 * Returns an hrtime calculated via performance component.
    	 * @param performanceNow
    	 */function hrTime$1(performanceNow){var timeOrigin=millisToHrTime$1(getTimeOrigin$1());var now=millisToHrTime$1(typeof performanceNow==='number'?performanceNow:otperformance$1.now());return addHrTimes$1(timeOrigin,now);}/**
    	 * Returns a duration of two hrTime.
    	 * @param startTime
    	 * @param endTime
    	 */function hrTimeDuration(startTime,endTime){var seconds=endTime[0]-startTime[0];var nanos=endTime[1]-startTime[1];// overflow
    	if(nanos<0){seconds-=1;// negate
    	nanos+=SECOND_TO_NANOSECONDS$1;}return [seconds,nanos];}/**
    	 * Convert hrTime to timestamp, for example "2019-05-14T17:00:00.000123456Z"
    	 * @param time
    	 */function hrTimeToTimeStamp(time){var precision=NANOSECOND_DIGITS$1;var tmp=""+'0'.repeat(precision)+time[1]+"Z";var nanoString=tmp.substr(tmp.length-precision-1);var date=new Date(time[0]*1000).toISOString();return date.replace('000Z',nanoString);}/**
    	 * Convert hrTime to nanoseconds.
    	 * @param time
    	 */function hrTimeToNanoseconds$1(time){return time[0]*SECOND_TO_NANOSECONDS$1+time[1];}/**
    	 * check if time is HrTime
    	 * @param value
    	 */function isTimeInputHrTime$1(value){return Array.isArray(value)&&value.length===2&&typeof value[0]==='number'&&typeof value[1]==='number';}/**
    	 * check if input value is a correct types.TimeInput
    	 * @param value
    	 */function isTimeInput(value){return isTimeInputHrTime$1(value)||typeof value==='number'||value instanceof Date;}/**
    	 * Given 2 HrTime formatted times, return their sum as an HrTime.
    	 */function addHrTimes$1(time1,time2){var out=[time1[0]+time2[0],time1[1]+time2[1]];// Nanoseconds
    	if(out[1]>=SECOND_TO_NANOSECONDS$1){out[1]-=SECOND_TO_NANOSECONDS$1;out[0]+=1;}return out;}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var ExportResultCode;(function(ExportResultCode){ExportResultCode[ExportResultCode["SUCCESS"]=0]="SUCCESS";ExportResultCode[ExportResultCode["FAILED"]=1]="FAILED";})(ExportResultCode||(ExportResultCode={}));/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __values$2=function(o){var s=typeof Symbol==="function"&&Symbol.iterator,m=s&&o[s],i=0;if(m)return m.call(o);if(o&&typeof o.length==="number")return {next:function(){if(o&&i>=o.length)o=void 0;return {value:o&&o[i++],done:!o};}};throw new TypeError(s?"Object is not iterable.":"Symbol.iterator is not defined.");};/** Combines multiple propagators into a single propagator. */var CompositePropagator=/** @class */function(){/**
    	     * Construct a composite propagator from a list of propagators.
    	     *
    	     * @param [config] Configuration object for composite propagator
    	     */function CompositePropagator(config){if(config===void 0){config={};}var _a;this._propagators=(_a=config.propagators)!==null&&_a!==void 0?_a:[];this._fields=Array.from(new Set(this._propagators// older propagators may not have fields function, null check to be sure
    	.map(function(p){return typeof p.fields==='function'?p.fields():[];}).reduce(function(x,y){return x.concat(y);},[])));}/**
    	     * Run each of the configured propagators with the given context and carrier.
    	     * Propagators are run in the order they are configured, so if multiple
    	     * propagators write the same carrier key, the propagator later in the list
    	     * will "win".
    	     *
    	     * @param context Context to inject
    	     * @param carrier Carrier into which context will be injected
    	     */CompositePropagator.prototype.inject=function(context,carrier,setter){var e_1,_a;try{for(var _b=__values$2(this._propagators),_c=_b.next();!_c.done;_c=_b.next()){var propagator=_c.value;try{propagator.inject(context,carrier,setter);}catch(err){diag.warn("Failed to inject with "+propagator.constructor.name+". Err: "+err.message);}}}catch(e_1_1){e_1={error:e_1_1};}finally{try{if(_c&&!_c.done&&(_a=_b.return))_a.call(_b);}finally{if(e_1)throw e_1.error;}}};/**
    	     * Run each of the configured propagators with the given context and carrier.
    	     * Propagators are run in the order they are configured, so if multiple
    	     * propagators write the same context key, the propagator later in the list
    	     * will "win".
    	     *
    	     * @param context Context to add values to
    	     * @param carrier Carrier from which to extract context
    	     */CompositePropagator.prototype.extract=function(context,carrier,getter){return this._propagators.reduce(function(ctx,propagator){try{return propagator.extract(ctx,carrier,getter);}catch(err){diag.warn("Failed to inject with "+propagator.constructor.name+". Err: "+err.message);}return ctx;},context);};CompositePropagator.prototype.fields=function(){// return a new array so our fields cannot be modified
    	return this._fields.slice();};return CompositePropagator;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var VALID_KEY_CHAR_RANGE='[_0-9a-z-*/]';var VALID_KEY="[a-z]"+VALID_KEY_CHAR_RANGE+"{0,255}";var VALID_VENDOR_KEY="[a-z0-9]"+VALID_KEY_CHAR_RANGE+"{0,240}@[a-z]"+VALID_KEY_CHAR_RANGE+"{0,13}";var VALID_KEY_REGEX=new RegExp("^(?:"+VALID_KEY+"|"+VALID_VENDOR_KEY+")$");var VALID_VALUE_BASE_REGEX=/^[ -~]{0,255}[!-~]$/;var INVALID_VALUE_COMMA_EQUAL_REGEX=/,|=/;/**
    	 * Key is opaque string up to 256 characters printable. It MUST begin with a
    	 * lowercase letter, and can only contain lowercase letters a-z, digits 0-9,
    	 * underscores _, dashes -, asterisks *, and forward slashes /.
    	 * For multi-tenant vendor scenarios, an at sign (@) can be used to prefix the
    	 * vendor name. Vendors SHOULD set the tenant ID at the beginning of the key.
    	 * see https://www.w3.org/TR/trace-context/#key
    	 */function validateKey(key){return VALID_KEY_REGEX.test(key);}/**
    	 * Value is opaque string up to 256 characters printable ASCII RFC0020
    	 * characters (i.e., the range 0x20 to 0x7E) except comma , and =.
    	 */function validateValue(value){return VALID_VALUE_BASE_REGEX.test(value)&&!INVALID_VALUE_COMMA_EQUAL_REGEX.test(value);}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var MAX_TRACE_STATE_ITEMS=32;var MAX_TRACE_STATE_LEN=512;var LIST_MEMBERS_SEPARATOR=',';var LIST_MEMBER_KEY_VALUE_SPLITTER='=';/**
    	 * TraceState must be a class and not a simple object type because of the spec
    	 * requirement (https://www.w3.org/TR/trace-context/#tracestate-field).
    	 *
    	 * Here is the list of allowed mutations:
    	 * - New key-value pair should be added into the beginning of the list
    	 * - The value of any key can be updated. Modified keys MUST be moved to the
    	 * beginning of the list.
    	 */var TraceState=/** @class */function(){function TraceState(rawTraceState){this._internalState=new Map();if(rawTraceState)this._parse(rawTraceState);}TraceState.prototype.set=function(key,value){// TODO: Benchmark the different approaches(map vs list) and
    	// use the faster one.
    	var traceState=this._clone();if(traceState._internalState.has(key)){traceState._internalState.delete(key);}traceState._internalState.set(key,value);return traceState;};TraceState.prototype.unset=function(key){var traceState=this._clone();traceState._internalState.delete(key);return traceState;};TraceState.prototype.get=function(key){return this._internalState.get(key);};TraceState.prototype.serialize=function(){var _this=this;return this._keys().reduce(function(agg,key){agg.push(key+LIST_MEMBER_KEY_VALUE_SPLITTER+_this.get(key));return agg;},[]).join(LIST_MEMBERS_SEPARATOR);};TraceState.prototype._parse=function(rawTraceState){if(rawTraceState.length>MAX_TRACE_STATE_LEN)return;this._internalState=rawTraceState.split(LIST_MEMBERS_SEPARATOR).reverse()// Store in reverse so new keys (.set(...)) will be placed at the beginning
    	.reduce(function(agg,part){var listMember=part.trim();// Optional Whitespace (OWS) handling
    	var i=listMember.indexOf(LIST_MEMBER_KEY_VALUE_SPLITTER);if(i!==-1){var key=listMember.slice(0,i);var value=listMember.slice(i+1,part.length);if(validateKey(key)&&validateValue(value)){agg.set(key,value);}}return agg;},new Map());// Because of the reverse() requirement, trunc must be done after map is created
    	if(this._internalState.size>MAX_TRACE_STATE_ITEMS){this._internalState=new Map(Array.from(this._internalState.entries()).reverse()// Use reverse same as original tracestate parse chain
    	.slice(0,MAX_TRACE_STATE_ITEMS));}};TraceState.prototype._keys=function(){return Array.from(this._internalState.keys()).reverse();};TraceState.prototype._clone=function(){var traceState=new TraceState();traceState._internalState=new Map(this._internalState);return traceState;};return TraceState;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var TRACE_PARENT_HEADER='traceparent';var TRACE_STATE_HEADER='tracestate';var VERSION$1='00';var VERSION_PART='(?!ff)[\\da-f]{2}';var TRACE_ID_PART='(?![0]{32})[\\da-f]{32}';var PARENT_ID_PART='(?![0]{16})[\\da-f]{16}';var FLAGS_PART='[\\da-f]{2}';var TRACE_PARENT_REGEX=new RegExp("^\\s?("+VERSION_PART+")-("+TRACE_ID_PART+")-("+PARENT_ID_PART+")-("+FLAGS_PART+")(-.*)?\\s?$");/**
    	 * Parses information from the [traceparent] span tag and converts it into {@link SpanContext}
    	 * @param traceParent - A meta property that comes from server.
    	 *     It should be dynamically generated server side to have the server's request trace Id,
    	 *     a parent span Id that was set on the server's request span,
    	 *     and the trace flags to indicate the server's sampling decision
    	 *     (01 = sampled, 00 = not sampled).
    	 *     for example: '{version}-{traceId}-{spanId}-{sampleDecision}'
    	 *     For more information see {@link https://www.w3.org/TR/trace-context/}
    	 */function parseTraceParent(traceParent){var match=TRACE_PARENT_REGEX.exec(traceParent);if(!match)return null;// According to the specification the implementation should be compatible
    	// with future versions. If there are more parts, we only reject it if it's using version 00
    	// See https://www.w3.org/TR/trace-context/#versioning-of-traceparent
    	if(match[1]==='00'&&match[5])return null;return {traceId:match[2],spanId:match[3],traceFlags:parseInt(match[4],16)};}/**
    	 * Propagates {@link SpanContext} through Trace Context format propagation.
    	 *
    	 * Based on the Trace Context specification:
    	 * https://www.w3.org/TR/trace-context/
    	 */var W3CTraceContextPropagator=/** @class */function(){function W3CTraceContextPropagator(){}W3CTraceContextPropagator.prototype.inject=function(context,carrier,setter){var spanContext=trace.getSpanContext(context);if(!spanContext||isTracingSuppressed(context)||!isSpanContextValid(spanContext))return;var traceParent=VERSION$1+"-"+spanContext.traceId+"-"+spanContext.spanId+"-0"+Number(spanContext.traceFlags||TraceFlags.NONE).toString(16);setter.set(carrier,TRACE_PARENT_HEADER,traceParent);if(spanContext.traceState){setter.set(carrier,TRACE_STATE_HEADER,spanContext.traceState.serialize());}};W3CTraceContextPropagator.prototype.extract=function(context,carrier,getter){var traceParentHeader=getter.get(carrier,TRACE_PARENT_HEADER);if(!traceParentHeader)return context;var traceParent=Array.isArray(traceParentHeader)?traceParentHeader[0]:traceParentHeader;if(typeof traceParent!=='string')return context;var spanContext=parseTraceParent(traceParent);if(!spanContext)return context;spanContext.isRemote=true;var traceStateHeader=getter.get(carrier,TRACE_STATE_HEADER);if(traceStateHeader){// If more than one `tracestate` header is found, we merge them into a
    	// single header.
    	var state=Array.isArray(traceStateHeader)?traceStateHeader.join(','):traceStateHeader;spanContext.traceState=new TraceState(typeof state==='string'?state:undefined);}return trace.setSpanContext(context,spanContext);};W3CTraceContextPropagator.prototype.fields=function(){return [TRACE_PARENT_HEADER,TRACE_STATE_HEADER];};return W3CTraceContextPropagator;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//* eslint-disable @typescript-eslint/no-explicit-any *//**
    	 * based on lodash in order to support esm builds without esModuleInterop.
    	 * lodash is using MIT License.
    	 **/var objectTag$3='[object Object]';var nullTag$1='[object Null]';var undefinedTag$1='[object Undefined]';var funcProto$2=Function.prototype;var funcToString$2=funcProto$2.toString;var objectCtorString=funcToString$2.call(Object);var getPrototype$2=overArg$3(Object.getPrototypeOf,Object);var objectProto$e=Object.prototype;var hasOwnProperty$b=objectProto$e.hasOwnProperty;var symToStringTag$2=Symbol?Symbol.toStringTag:undefined;var nativeObjectToString$2=objectProto$e.toString;/**
    	 * Creates a unary function that invokes `func` with its argument transformed.
    	 *
    	 * @private
    	 * @param {Function} func The function to wrap.
    	 * @param {Function} transform The argument transform.
    	 * @returns {Function} Returns the new function.
    	 */function overArg$3(func,transform){return function(arg){return func(transform(arg));};}/**
    	 * Checks if `value` is a plain object, that is, an object created by the
    	 * `Object` constructor or one with a `[[Prototype]]` of `null`.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 0.8.0
    	 * @category Lang
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is a plain object, else `false`.
    	 * @example
    	 *
    	 * function Foo() {
    	 *   this.a = 1;
    	 * }
    	 *
    	 * _.isPlainObject(new Foo);
    	 * // => false
    	 *
    	 * _.isPlainObject([1, 2, 3]);
    	 * // => false
    	 *
    	 * _.isPlainObject({ 'x': 0, 'y': 0 });
    	 * // => true
    	 *
    	 * _.isPlainObject(Object.create(null));
    	 * // => true
    	 */function isPlainObject(value){if(!isObjectLike$6(value)||baseGetTag$6(value)!==objectTag$3){return false;}var proto=getPrototype$2(value);if(proto===null){return true;}var Ctor=hasOwnProperty$b.call(proto,'constructor')&&proto.constructor;return typeof Ctor=='function'&&Ctor instanceof Ctor&&funcToString$2.call(Ctor)===objectCtorString;}/**
    	 * Checks if `value` is object-like. A value is object-like if it's not `null`
    	 * and has a `typeof` result of "object".
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 4.0.0
    	 * @category Lang
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is object-like, else `false`.
    	 * @example
    	 *
    	 * _.isObjectLike({});
    	 * // => true
    	 *
    	 * _.isObjectLike([1, 2, 3]);
    	 * // => true
    	 *
    	 * _.isObjectLike(_.noop);
    	 * // => false
    	 *
    	 * _.isObjectLike(null);
    	 * // => false
    	 */function isObjectLike$6(value){return value!=null&&typeof value=='object';}/**
    	 * The base implementation of `getTag` without fallbacks for buggy environments.
    	 *
    	 * @private
    	 * @param {*} value The value to query.
    	 * @returns {string} Returns the `toStringTag`.
    	 */function baseGetTag$6(value){if(value==null){return value===undefined?undefinedTag$1:nullTag$1;}return symToStringTag$2&&symToStringTag$2 in Object(value)?getRawTag$2(value):objectToString$2(value);}/**
    	 * A specialized version of `baseGetTag` which ignores `Symbol.toStringTag` values.
    	 *
    	 * @private
    	 * @param {*} value The value to query.
    	 * @returns {string} Returns the raw `toStringTag`.
    	 */function getRawTag$2(value){var isOwn=hasOwnProperty$b.call(value,symToStringTag$2),tag=value[symToStringTag$2];var unmasked=false;try{value[symToStringTag$2]=undefined;unmasked=true;}catch(e){// silence
    	}var result=nativeObjectToString$2.call(value);if(unmasked){if(isOwn){value[symToStringTag$2]=tag;}else {delete value[symToStringTag$2];}}return result;}/**
    	 * Converts `value` to a string using `Object.prototype.toString`.
    	 *
    	 * @private
    	 * @param {*} value The value to convert.
    	 * @returns {string} Returns the converted string.
    	 */function objectToString$2(value){return nativeObjectToString$2.call(value);}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//* eslint-disable @typescript-eslint/no-explicit-any */var MAX_LEVEL=20;/**
    	 * Merges objects together
    	 * @param args - objects / values to be merged
    	 */function merge(){var args=[];for(var _i=0;_i<arguments.length;_i++){args[_i]=arguments[_i];}var result=args.shift();var objects=new WeakMap();while(args.length>0){result=mergeTwoObjects(result,args.shift(),0,objects);}return result;}function takeValue(value){if(isArray$9(value)){return value.slice();}return value;}/**
    	 * Merges two objects
    	 * @param one - first object
    	 * @param two - second object
    	 * @param level - current deep level
    	 * @param objects - objects holder that has been already referenced - to prevent
    	 * cyclic dependency
    	 */function mergeTwoObjects(one,two,level,objects){if(level===void 0){level=0;}var result;if(level>MAX_LEVEL){return undefined;}level++;if(isPrimitive(one)||isPrimitive(two)||isFunction$4(two)){result=takeValue(two);}else if(isArray$9(one)){result=one.slice();if(isArray$9(two)){for(var i=0,j=two.length;i<j;i++){result.push(takeValue(two[i]));}}else if(isObject$6(two)){var keys=Object.keys(two);for(var i=0,j=keys.length;i<j;i++){var key=keys[i];result[key]=takeValue(two[key]);}}}else if(isObject$6(one)){if(isObject$6(two)){if(!shouldMerge(one,two)){return two;}result=Object.assign({},one);var keys=Object.keys(two);for(var i=0,j=keys.length;i<j;i++){var key=keys[i];var twoValue=two[key];if(isPrimitive(twoValue)){if(typeof twoValue==='undefined'){delete result[key];}else {// result[key] = takeValue(twoValue);
    	result[key]=twoValue;}}else {var obj1=result[key];var obj2=twoValue;if(wasObjectReferenced(one,key,objects)||wasObjectReferenced(two,key,objects)){delete result[key];}else {if(isObject$6(obj1)&&isObject$6(obj2)){var arr1=objects.get(obj1)||[];var arr2=objects.get(obj2)||[];arr1.push({obj:one,key:key});arr2.push({obj:two,key:key});objects.set(obj1,arr1);objects.set(obj2,arr2);}result[key]=mergeTwoObjects(result[key],twoValue,level,objects);}}}}else {result=two;}}return result;}/**
    	 * Function to check if object has been already reference
    	 * @param obj
    	 * @param key
    	 * @param objects
    	 */function wasObjectReferenced(obj,key,objects){var arr=objects.get(obj[key])||[];for(var i=0,j=arr.length;i<j;i++){var info=arr[i];if(info.key===key&&info.obj===obj){return true;}}return false;}function isArray$9(value){return Array.isArray(value);}function isFunction$4(value){return typeof value==='function';}function isObject$6(value){return !isPrimitive(value)&&!isArray$9(value)&&!isFunction$4(value)&&typeof value==='object';}function isPrimitive(value){return typeof value==='string'||typeof value==='number'||typeof value==='boolean'||typeof value==='undefined'||value instanceof Date||value instanceof RegExp||value===null;}function shouldMerge(one,two){if(!isPlainObject(one)||!isPlainObject(two)){return false;}return true;}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var Deferred=/** @class */function(){function Deferred(){var _this=this;this._promise=new Promise(function(resolve,reject){_this._resolve=resolve;_this._reject=reject;});}Object.defineProperty(Deferred.prototype,"promise",{get:function(){return this._promise;},enumerable:false,configurable:true});Deferred.prototype.resolve=function(val){this._resolve(val);};Deferred.prototype.reject=function(err){this._reject(err);};return Deferred;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __read$3=function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-->0)&&!(r=i.next()).done)ar.push(r.value);}catch(error){e={error:error};}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i);}finally{if(e)throw e.error;}}return ar;};var __spreadArray$2=function(to,from,pack){if(pack||arguments.length===2)for(var i=0,l=from.length,ar;i<l;i++){if(ar||!(i in from)){if(!ar)ar=Array.prototype.slice.call(from,0,i);ar[i]=from[i];}}return to.concat(ar||Array.prototype.slice.call(from));};/**
    	 * Bind the callback and only invoke the callback once regardless how many times `BindOnceFuture.call` is invoked.
    	 */var BindOnceFuture=/** @class */function(){function BindOnceFuture(_callback,_that){this._callback=_callback;this._that=_that;this._isCalled=false;this._deferred=new Deferred();}Object.defineProperty(BindOnceFuture.prototype,"isCalled",{get:function(){return this._isCalled;},enumerable:false,configurable:true});Object.defineProperty(BindOnceFuture.prototype,"promise",{get:function(){return this._deferred.promise;},enumerable:false,configurable:true});BindOnceFuture.prototype.call=function(){var _a;var _this=this;var args=[];for(var _i=0;_i<arguments.length;_i++){args[_i]=arguments[_i];}if(!this._isCalled){this._isCalled=true;try{Promise.resolve((_a=this._callback).call.apply(_a,__spreadArray$2([this._that],__read$3(args),false))).then(function(val){return _this._deferred.resolve(val);},function(err){return _this._deferred.reject(err);});}catch(err){this._deferred.reject(err);}}return this._deferred.promise;};return BindOnceFuture;}();class Instant{constructor(){let initialValue=arguments.length>0&&arguments[0]!==undefined?arguments[0]:hrTime$1();this.instant=initialValue;}static toISOString(instant){return hrTimeToTimeStamp(instant.instant);}static toNanoSeconds(instant){return hrTimeToNanoseconds$1(instant.instant);}}var commonjsGlobal$1=typeof globalThis!=='undefined'?globalThis:typeof window!=='undefined'?window:typeof commonjsGlobal!=='undefined'?commonjsGlobal:typeof self!=='undefined'?self:{};function getDefaultExportFromCjs(x){return x&&x.__esModule&&Object.prototype.hasOwnProperty.call(x,'default')?x['default']:x;}var errorStackParser={exports:{}};var stackframe={exports:{}};var hasRequiredStackframe;function requireStackframe(){if(hasRequiredStackframe)return stackframe.exports;hasRequiredStackframe=1;(function(module,exports){(function(root,factory){// Universal Module Definition (UMD) to support AMD, CommonJS/Node.js, Rhino, and browsers.
    	/* istanbul ignore next */{module.exports=factory();}})(commonjsGlobal$1,function(){function _isNumber(n){return !isNaN(parseFloat(n))&&isFinite(n);}function _capitalize(str){return str.charAt(0).toUpperCase()+str.substring(1);}function _getter(p){return function(){return this[p];};}var booleanProps=['isConstructor','isEval','isNative','isToplevel'];var numericProps=['columnNumber','lineNumber'];var stringProps=['fileName','functionName','source'];var arrayProps=['args'];var objectProps=['evalOrigin'];var props=booleanProps.concat(numericProps,stringProps,arrayProps,objectProps);function StackFrame(obj){if(!obj)return;for(var i=0;i<props.length;i++){if(obj[props[i]]!==undefined){this['set'+_capitalize(props[i])](obj[props[i]]);}}}StackFrame.prototype={getArgs:function(){return this.args;},setArgs:function(v){if(Object.prototype.toString.call(v)!=='[object Array]'){throw new TypeError('Args must be an Array');}this.args=v;},getEvalOrigin:function(){return this.evalOrigin;},setEvalOrigin:function(v){if(v instanceof StackFrame){this.evalOrigin=v;}else if(v instanceof Object){this.evalOrigin=new StackFrame(v);}else {throw new TypeError('Eval Origin must be an Object or StackFrame');}},toString:function(){var fileName=this.getFileName()||'';var lineNumber=this.getLineNumber()||'';var columnNumber=this.getColumnNumber()||'';var functionName=this.getFunctionName()||'';if(this.getIsEval()){if(fileName){return '[eval] ('+fileName+':'+lineNumber+':'+columnNumber+')';}return '[eval]:'+lineNumber+':'+columnNumber;}if(functionName){return functionName+' ('+fileName+':'+lineNumber+':'+columnNumber+')';}return fileName+':'+lineNumber+':'+columnNumber;}};StackFrame.fromString=function StackFrame$$fromString(str){var argsStartIndex=str.indexOf('(');var argsEndIndex=str.lastIndexOf(')');var functionName=str.substring(0,argsStartIndex);var args=str.substring(argsStartIndex+1,argsEndIndex).split(',');var locationString=str.substring(argsEndIndex+1);if(locationString.indexOf('@')===0){var parts=/@(.+?)(?::(\d+))?(?::(\d+))?$/.exec(locationString,'');var fileName=parts[1];var lineNumber=parts[2];var columnNumber=parts[3];}return new StackFrame({functionName:functionName,args:args||undefined,fileName:fileName,lineNumber:lineNumber||undefined,columnNumber:columnNumber||undefined});};for(var i=0;i<booleanProps.length;i++){StackFrame.prototype['get'+_capitalize(booleanProps[i])]=_getter(booleanProps[i]);StackFrame.prototype['set'+_capitalize(booleanProps[i])]=function(p){return function(v){this[p]=Boolean(v);};}(booleanProps[i]);}for(var j=0;j<numericProps.length;j++){StackFrame.prototype['get'+_capitalize(numericProps[j])]=_getter(numericProps[j]);StackFrame.prototype['set'+_capitalize(numericProps[j])]=function(p){return function(v){if(!_isNumber(v)){throw new TypeError(p+' must be a Number');}this[p]=Number(v);};}(numericProps[j]);}for(var k=0;k<stringProps.length;k++){StackFrame.prototype['get'+_capitalize(stringProps[k])]=_getter(stringProps[k]);StackFrame.prototype['set'+_capitalize(stringProps[k])]=function(p){return function(v){this[p]=String(v);};}(stringProps[k]);}return StackFrame;});})(stackframe);return stackframe.exports;}(function(module,exports){(function(root,factory){// Universal Module Definition (UMD) to support AMD, CommonJS/Node.js, Rhino, and browsers.
    	/* istanbul ignore next */{module.exports=factory(requireStackframe());}})(commonjsGlobal$1,function ErrorStackParser(StackFrame){var FIREFOX_SAFARI_STACK_REGEXP=/(^|@)\S+:\d+/;var CHROME_IE_STACK_REGEXP=/^\s*at .*(\S+:\d+|\(native\))/m;var SAFARI_NATIVE_CODE_REGEXP=/^(eval@)?(\[native code])?$/;return {/**
    		         * Given an Error object, extract the most information from it.
    		         *
    		         * @param {Error} error object
    		         * @return {Array} of StackFrames
    		         */parse:function ErrorStackParser$$parse(error){if(typeof error.stacktrace!=='undefined'||typeof error['opera#sourceloc']!=='undefined'){return this.parseOpera(error);}else if(error.stack&&error.stack.match(CHROME_IE_STACK_REGEXP)){return this.parseV8OrIE(error);}else if(error.stack){return this.parseFFOrSafari(error);}else {throw new Error('Cannot parse given Error object');}},// Separate line and column numbers from a string of the form: (URI:Line:Column)
    	extractLocation:function ErrorStackParser$$extractLocation(urlLike){// Fail-fast but return locations like "(native)"
    	if(urlLike.indexOf(':')===-1){return [urlLike];}var regExp=/(.+?)(?::(\d+))?(?::(\d+))?$/;var parts=regExp.exec(urlLike.replace(/[()]/g,''));return [parts[1],parts[2]||undefined,parts[3]||undefined];},parseV8OrIE:function ErrorStackParser$$parseV8OrIE(error){var filtered=error.stack.split('\n').filter(function(line){return !!line.match(CHROME_IE_STACK_REGEXP);},this);return filtered.map(function(line){if(line.indexOf('(eval ')>-1){// Throw away eval information until we implement stacktrace.js/stackframe#8
    	line=line.replace(/eval code/g,'eval').replace(/(\(eval at [^()]*)|(,.*$)/g,'');}var sanitizedLine=line.replace(/^\s+/,'').replace(/\(eval code/g,'(').replace(/^.*?\s+/,'');// capture and preseve the parenthesized location "(/foo/my bar.js:12:87)" in
    	// case it has spaces in it, as the string is split on \s+ later on
    	var location=sanitizedLine.match(/ (\(.+\)$)/);// remove the parenthesized location from the line, if it was matched
    	sanitizedLine=location?sanitizedLine.replace(location[0],''):sanitizedLine;// if a location was matched, pass it to extractLocation() otherwise pass all sanitizedLine
    	// because this line doesn't have function name
    	var locationParts=this.extractLocation(location?location[1]:sanitizedLine);var functionName=location&&sanitizedLine||undefined;var fileName=['eval','<anonymous>'].indexOf(locationParts[0])>-1?undefined:locationParts[0];return new StackFrame({functionName:functionName,fileName:fileName,lineNumber:locationParts[1],columnNumber:locationParts[2],source:line});},this);},parseFFOrSafari:function ErrorStackParser$$parseFFOrSafari(error){var filtered=error.stack.split('\n').filter(function(line){return !line.match(SAFARI_NATIVE_CODE_REGEXP);},this);return filtered.map(function(line){// Throw away eval information until we implement stacktrace.js/stackframe#8
    	if(line.indexOf(' > eval')>-1){line=line.replace(/ line (\d+)(?: > eval line \d+)* > eval:\d+:\d+/g,':$1');}if(line.indexOf('@')===-1&&line.indexOf(':')===-1){// Safari eval frames only have function names and nothing else
    	return new StackFrame({functionName:line});}else {var functionNameRegex=/((.*".+"[^@]*)?[^@]*)(?:@)/;var matches=line.match(functionNameRegex);var functionName=matches&&matches[1]?matches[1]:undefined;var locationParts=this.extractLocation(line.replace(functionNameRegex,''));return new StackFrame({functionName:functionName,fileName:locationParts[0],lineNumber:locationParts[1],columnNumber:locationParts[2],source:line});}},this);},parseOpera:function ErrorStackParser$$parseOpera(e){if(!e.stacktrace||e.message.indexOf('\n')>-1&&e.message.split('\n').length>e.stacktrace.split('\n').length){return this.parseOpera9(e);}else if(!e.stack){return this.parseOpera10(e);}else {return this.parseOpera11(e);}},parseOpera9:function ErrorStackParser$$parseOpera9(e){var lineRE=/Line (\d+).*script (?:in )?(\S+)/i;var lines=e.message.split('\n');var result=[];for(var i=2,len=lines.length;i<len;i+=2){var match=lineRE.exec(lines[i]);if(match){result.push(new StackFrame({fileName:match[2],lineNumber:match[1],source:lines[i]}));}}return result;},parseOpera10:function ErrorStackParser$$parseOpera10(e){var lineRE=/Line (\d+).*script (?:in )?(\S+)(?:: In function (\S+))?$/i;var lines=e.stacktrace.split('\n');var result=[];for(var i=0,len=lines.length;i<len;i+=2){var match=lineRE.exec(lines[i]);if(match){result.push(new StackFrame({functionName:match[3]||undefined,fileName:match[2],lineNumber:match[1],source:lines[i]}));}}return result;},// Opera 10.65+ Error.stack very similar to FF/Safari
    	parseOpera11:function ErrorStackParser$$parseOpera11(error){var filtered=error.stack.split('\n').filter(function(line){return !!line.match(FIREFOX_SAFARI_STACK_REGEXP)&&!line.match(/^Error created at/);},this);return filtered.map(function(line){var tokens=line.split('@');var locationParts=this.extractLocation(tokens.pop());var functionCall=tokens.shift()||'';var functionName=functionCall.replace(/<anonymous function(: (\w+))?>/,'$2').replace(/\([^)]*\)/g,'')||undefined;var argsRaw;if(functionCall.match(/\(([^)]*)\)/)){argsRaw=functionCall.replace(/^[^(]+\(([^)]*)\)$/,'$1');}var args=argsRaw===undefined||argsRaw==='[arguments not available]'?undefined:argsRaw.split(',');return new StackFrame({functionName:functionName,args:args,fileName:locationParts[0],lineNumber:locationParts[1],columnNumber:locationParts[2],source:line});},this);}};});})(errorStackParser);var errorStackParserExports=errorStackParser.exports;var ErrorStackParser=/*@__PURE__*/getDefaultExportFromCjs(errorStackParserExports);var _a,_ErrorRecord_sanitizeErrorStack;class ErrorRecord{constructor(error){this.name=error.name;this.message=error.message;if(error.stack){this.stack=__classPrivateFieldGet(_a,_a,"m",_ErrorRecord_sanitizeErrorStack).call(_a,error);}}}_a=ErrorRecord,_ErrorRecord_sanitizeErrorStack=function _ErrorRecord_sanitizeErrorStack(error){const stackParsed=ErrorStackParser.parse(error);const customError=error;const extraStack=(customError===null||customError===void 0?void 0:customError.extraStack)?`ExtraStack: ${customError.extraStack}`:"";const stackString=stackParsed.map(stackframe=>stackframe.source).join("\n");return `${error.name}: ${error.message}\n${stackString}\n${extraStack}`;};class Log{constructor(_ref){let{type,category,message,error,visibility,timestamp=new Instant(),span,errorCode,attributes}=_ref;this.type=type;this.category=category;this.message=message;if(error){this.error=new ErrorRecord(error);}this.visibility=visibility;this.timestamp=timestamp;this.span=span;this.errorCode=errorCode;this.attributes=attributes;}}_exports.Log=Log;var _CircuitBreakerRunner_instances,_CircuitBreakerRunner_openCircuits,_CircuitBreakerRunner_openCircuit,_CircuitBreakerRunner_runClosedCircuit,_CircuitBreakerRunner_runOpenedCircuit;const RETRY_FACTOR=5;const MAX_ITERATIONS_UNTIL_RETRY=10;class CircuitBreakerRunner{constructor(){let openCircuits=arguments.length>0&&arguments[0]!==undefined?arguments[0]:new Map();_CircuitBreakerRunner_instances.add(this);_CircuitBreakerRunner_openCircuits.set(this,void 0);__classPrivateFieldSet(this,_CircuitBreakerRunner_openCircuits,openCircuits);}closeCircuit(id){__classPrivateFieldGet(this,_CircuitBreakerRunner_openCircuits,"f").delete(id);}run(id,task){return __awaiter$3(this,void 0,void 0,function*(){const circuit=__classPrivateFieldGet(this,_CircuitBreakerRunner_openCircuits,"f").get(id);if(circuit===undefined){return __classPrivateFieldGet(this,_CircuitBreakerRunner_instances,"m",_CircuitBreakerRunner_runClosedCircuit).call(this,id,task);}else if(circuit.iterationsUntilRetry>0){circuit.iterationsUntilRetry--;return 2;}else {return __classPrivateFieldGet(this,_CircuitBreakerRunner_instances,"m",_CircuitBreakerRunner_runOpenedCircuit).call(this,id,circuit,task);}});}}_CircuitBreakerRunner_openCircuits=new WeakMap(),_CircuitBreakerRunner_instances=new WeakSet(),_CircuitBreakerRunner_openCircuit=function _CircuitBreakerRunner_openCircuit(id){__classPrivateFieldGet(this,_CircuitBreakerRunner_openCircuits,"f").set(id,{retriesFailed:0,iterationsUntilRetry:RETRY_FACTOR});},_CircuitBreakerRunner_runClosedCircuit=function _CircuitBreakerRunner_runClosedCircuit(id,task){return __awaiter$3(this,void 0,void 0,function*(){try{yield task();return 0;}catch(e){__classPrivateFieldGet(this,_CircuitBreakerRunner_instances,"m",_CircuitBreakerRunner_openCircuit).call(this,id);console.debug(`Circuit breaker ${id} was opened: ${e}`);return 1;}});},_CircuitBreakerRunner_runOpenedCircuit=function _CircuitBreakerRunner_runOpenedCircuit(id,circuit,task){return __awaiter$3(this,void 0,void 0,function*(){try{yield task();this.closeCircuit(id);console.debug(`Circuit breaker ${id} was closed`);return 0;}catch(_a){circuit.retriesFailed++;circuit.iterationsUntilRetry=Math.min(circuit.retriesFailed*RETRY_FACTOR,MAX_ITERATIONS_UNTIL_RETRY);return 1;}});};const E_CANCELED=new Error('request for lock canceled');var __awaiter$2=function(thisArg,_arguments,P,generator){function adopt(value){return value instanceof P?value:new P(function(resolve){resolve(value);});}return new(P||(P=Promise))(function(resolve,reject){function fulfilled(value){try{step(generator.next(value));}catch(e){reject(e);}}function rejected(value){try{step(generator["throw"](value));}catch(e){reject(e);}}function step(result){result.done?resolve(result.value):adopt(result.value).then(fulfilled,rejected);}step((generator=generator.apply(thisArg,_arguments||[])).next());});};class Semaphore{constructor(_value){let _cancelError=arguments.length>1&&arguments[1]!==undefined?arguments[1]:E_CANCELED;this._value=_value;this._cancelError=_cancelError;this._queue=[];this._weightedWaiters=[];}acquire(){let weight=arguments.length>0&&arguments[0]!==undefined?arguments[0]:1;let priority=arguments.length>1&&arguments[1]!==undefined?arguments[1]:0;if(weight<=0)throw new Error(`invalid weight ${weight}: must be positive`);return new Promise((resolve,reject)=>{const task={resolve,reject,weight,priority};const i=findIndexFromEnd(this._queue,other=>priority<=other.priority);if(i===-1&&weight<=this._value){// Needs immediate dispatch, skip the queue
    	this._dispatchItem(task);}else {this._queue.splice(i+1,0,task);}});}runExclusive(callback_1){return __awaiter$2(this,arguments,void 0,function(callback){var _this2=this;let weight=arguments.length>1&&arguments[1]!==undefined?arguments[1]:1;let priority=arguments.length>2&&arguments[2]!==undefined?arguments[2]:0;return function*(){const[value,release]=yield _this2.acquire(weight,priority);try{return yield callback(value);}finally{release();}}();});}waitForUnlock(){let weight=arguments.length>0&&arguments[0]!==undefined?arguments[0]:1;let priority=arguments.length>1&&arguments[1]!==undefined?arguments[1]:0;if(weight<=0)throw new Error(`invalid weight ${weight}: must be positive`);if(this._couldLockImmediately(weight,priority)){return Promise.resolve();}else {return new Promise(resolve=>{if(!this._weightedWaiters[weight-1])this._weightedWaiters[weight-1]=[];insertSorted(this._weightedWaiters[weight-1],{resolve,priority});});}}isLocked(){return this._value<=0;}getValue(){return this._value;}setValue(value){this._value=value;this._dispatchQueue();}release(){let weight=arguments.length>0&&arguments[0]!==undefined?arguments[0]:1;if(weight<=0)throw new Error(`invalid weight ${weight}: must be positive`);this._value+=weight;this._dispatchQueue();}cancel(){this._queue.forEach(entry=>entry.reject(this._cancelError));this._queue=[];}_dispatchQueue(){this._drainUnlockWaiters();while(this._queue.length>0&&this._queue[0].weight<=this._value){this._dispatchItem(this._queue.shift());this._drainUnlockWaiters();}}_dispatchItem(item){const previousValue=this._value;this._value-=item.weight;item.resolve([previousValue,this._newReleaser(item.weight)]);}_newReleaser(weight){let called=false;return ()=>{if(called)return;called=true;this.release(weight);};}_drainUnlockWaiters(){if(this._queue.length===0){for(let weight=this._value;weight>0;weight--){const waiters=this._weightedWaiters[weight-1];if(!waiters)continue;waiters.forEach(waiter=>waiter.resolve());this._weightedWaiters[weight-1]=[];}}else {const queuedPriority=this._queue[0].priority;for(let weight=this._value;weight>0;weight--){const waiters=this._weightedWaiters[weight-1];if(!waiters)continue;const i=waiters.findIndex(waiter=>waiter.priority<=queuedPriority);(i===-1?waiters:waiters.splice(0,i)).forEach(waiter=>waiter.resolve());}}}_couldLockImmediately(weight,priority){return (this._queue.length===0||this._queue[0].priority<priority)&&weight<=this._value;}}function insertSorted(a,v){const i=findIndexFromEnd(a,other=>v.priority<=other.priority);a.splice(i+1,0,v);}function findIndexFromEnd(a,predicate){for(let i=a.length-1;i>=0;i--){if(predicate(a[i])){return i;}}return  -1;}var __awaiter$1=function(thisArg,_arguments,P,generator){function adopt(value){return value instanceof P?value:new P(function(resolve){resolve(value);});}return new(P||(P=Promise))(function(resolve,reject){function fulfilled(value){try{step(generator.next(value));}catch(e){reject(e);}}function rejected(value){try{step(generator["throw"](value));}catch(e){reject(e);}}function step(result){result.done?resolve(result.value):adopt(result.value).then(fulfilled,rejected);}step((generator=generator.apply(thisArg,_arguments||[])).next());});};class Mutex{constructor(cancelError){this._semaphore=new Semaphore(1,cancelError);}acquire(){return __awaiter$1(this,arguments,void 0,function(){var _this3=this;let priority=arguments.length>0&&arguments[0]!==undefined?arguments[0]:0;return function*(){const[,releaser]=yield _this3._semaphore.acquire(1,priority);return releaser;}();});}runExclusive(callback){let priority=arguments.length>1&&arguments[1]!==undefined?arguments[1]:0;return this._semaphore.runExclusive(()=>callback(),1,priority);}isLocked(){return this._semaphore.isLocked();}waitForUnlock(){let priority=arguments.length>0&&arguments[0]!==undefined?arguments[0]:0;return this._semaphore.waitForUnlock(1,priority);}release(){if(this._semaphore.isLocked())this._semaphore.release();}cancel(){return this._semaphore.cancel();}}var LogType;(function(LogType){LogType[LogType["Debug"]=1]="Debug";LogType[LogType["Info"]=2]="Info";LogType[LogType["Warning"]=3]="Warning";LogType[LogType["Error"]=4]="Error";LogType[LogType["Trace"]=5]="Trace";})(LogType||(LogType={}));const mapKeyToLogType={Debug:LogType.Debug,Info:LogType.Info,Warning:LogType.Warning,Error:LogType.Error,Trace:LogType.Trace};var LogType$1=_exports.LogType=LogType;class LogRecord{constructor(logId,log,logType,transportId){this.logId=logId;this.log=log;this.logType=logType;this.transportId=transportId;}}const DB_NAME="logger-offline-db";const DB_LOGS_TABLE_NAME="logs";const DB_TRACES_TABLE_NAME="spans";const DB_INDEX_BY_LOG_TYPE="byLogType";const DB_INDEX_BY_TRANSPORT_ID="byTransportId";const DB_INDEX_BY_AGGREGATE_SIGNATURE="byAggregateSignature";const DB_INDEX_BY_PARENT_ID="byParentId";const DB_FIELD_LOG_TYPE="logType";const DB_FIELD_TRANSPORT_ID="transportId";const DB_FIELD_AGGREGATE_SIGNATURE="aggregateSignature";const DB_FIELD_PARENT_ID="parentId";const instanceOfAny=(object,constructors)=>constructors.some(c=>object instanceof c);let idbProxyableTypes;let cursorAdvanceMethods;// This is a function to prevent it throwing up in node environments.
    	function getIdbProxyableTypes(){return idbProxyableTypes||(idbProxyableTypes=[IDBDatabase,IDBObjectStore,IDBIndex,IDBCursor,IDBTransaction]);}// This is a function to prevent it throwing up in node environments.
    	function getCursorAdvanceMethods(){return cursorAdvanceMethods||(cursorAdvanceMethods=[IDBCursor.prototype.advance,IDBCursor.prototype.continue,IDBCursor.prototype.continuePrimaryKey]);}const cursorRequestMap=new WeakMap();const transactionDoneMap=new WeakMap();const transactionStoreNamesMap=new WeakMap();const transformCache=new WeakMap();const reverseTransformCache=new WeakMap();function promisifyRequest(request){const promise=new Promise((resolve,reject)=>{const unlisten=()=>{request.removeEventListener('success',success);request.removeEventListener('error',error);};const success=()=>{resolve(wrap$1(request.result));unlisten();};const error=()=>{reject(request.error);unlisten();};request.addEventListener('success',success);request.addEventListener('error',error);});promise.then(value=>{// Since cursoring reuses the IDBRequest (*sigh*), we cache it for later retrieval
    	// (see wrapFunction).
    	if(value instanceof IDBCursor){cursorRequestMap.set(value,request);}// Catching to avoid "Uncaught Promise exceptions"
    	}).catch(()=>{});// This mapping exists in reverseTransformCache but doesn't doesn't exist in transformCache. This
    	// is because we create many promises from a single IDBRequest.
    	reverseTransformCache.set(promise,request);return promise;}function cacheDonePromiseForTransaction(tx){// Early bail if we've already created a done promise for this transaction.
    	if(transactionDoneMap.has(tx))return;const done=new Promise((resolve,reject)=>{const unlisten=()=>{tx.removeEventListener('complete',complete);tx.removeEventListener('error',error);tx.removeEventListener('abort',error);};const complete=()=>{resolve();unlisten();};const error=()=>{reject(tx.error||new DOMException('AbortError','AbortError'));unlisten();};tx.addEventListener('complete',complete);tx.addEventListener('error',error);tx.addEventListener('abort',error);});// Cache it for later retrieval.
    	transactionDoneMap.set(tx,done);}let idbProxyTraps={get(target,prop,receiver){if(target instanceof IDBTransaction){// Special handling for transaction.done.
    	if(prop==='done')return transactionDoneMap.get(target);// Polyfill for objectStoreNames because of Edge.
    	if(prop==='objectStoreNames'){return target.objectStoreNames||transactionStoreNamesMap.get(target);}// Make tx.store return the only store in the transaction, or undefined if there are many.
    	if(prop==='store'){return receiver.objectStoreNames[1]?undefined:receiver.objectStore(receiver.objectStoreNames[0]);}}// Else transform whatever we get back.
    	return wrap$1(target[prop]);},set(target,prop,value){target[prop]=value;return true;},has(target,prop){if(target instanceof IDBTransaction&&(prop==='done'||prop==='store')){return true;}return prop in target;}};function replaceTraps(callback){idbProxyTraps=callback(idbProxyTraps);}function wrapFunction(func){// Due to expected object equality (which is enforced by the caching in `wrap`), we
    	// only create one new func per func.
    	// Edge doesn't support objectStoreNames (booo), so we polyfill it here.
    	if(func===IDBDatabase.prototype.transaction&&!('objectStoreNames'in IDBTransaction.prototype)){return function(storeNames){for(var _len=arguments.length,args=new Array(_len>1?_len-1:0),_key2=1;_key2<_len;_key2++){args[_key2-1]=arguments[_key2];}const tx=func.call(unwrap$1(this),storeNames,...args);transactionStoreNamesMap.set(tx,storeNames.sort?storeNames.sort():[storeNames]);return wrap$1(tx);};}// Cursor methods are special, as the behaviour is a little more different to standard IDB. In
    	// IDB, you advance the cursor and wait for a new 'success' on the IDBRequest that gave you the
    	// cursor. It's kinda like a promise that can resolve with many values. That doesn't make sense
    	// with real promises, so each advance methods returns a new promise for the cursor object, or
    	// undefined if the end of the cursor has been reached.
    	if(getCursorAdvanceMethods().includes(func)){return function(){for(var _len2=arguments.length,args=new Array(_len2),_key3=0;_key3<_len2;_key3++){args[_key3]=arguments[_key3];}// Calling the original function with the proxy as 'this' causes ILLEGAL INVOCATION, so we use
    	// the original object.
    	func.apply(unwrap$1(this),args);return wrap$1(cursorRequestMap.get(this));};}return function(){for(var _len3=arguments.length,args=new Array(_len3),_key4=0;_key4<_len3;_key4++){args[_key4]=arguments[_key4];}// Calling the original function with the proxy as 'this' causes ILLEGAL INVOCATION, so we use
    	// the original object.
    	return wrap$1(func.apply(unwrap$1(this),args));};}function transformCachableValue(value){if(typeof value==='function')return wrapFunction(value);// This doesn't return, it just creates a 'done' promise for the transaction,
    	// which is later returned for transaction.done (see idbObjectHandler).
    	if(value instanceof IDBTransaction)cacheDonePromiseForTransaction(value);if(instanceOfAny(value,getIdbProxyableTypes()))return new Proxy(value,idbProxyTraps);// Return the same value back if we're not going to transform it.
    	return value;}function wrap$1(value){// We sometimes generate multiple promises from a single IDBRequest (eg when cursoring), because
    	// IDB is weird and a single IDBRequest can yield many responses, so these can't be cached.
    	if(value instanceof IDBRequest)return promisifyRequest(value);// If we've already transformed this value before, reuse the transformed value.
    	// This is faster, but it also provides object equality.
    	if(transformCache.has(value))return transformCache.get(value);const newValue=transformCachableValue(value);// Not all types are transformed.
    	// These may be primitive types, so they can't be WeakMap keys.
    	if(newValue!==value){transformCache.set(value,newValue);reverseTransformCache.set(newValue,value);}return newValue;}const unwrap$1=value=>reverseTransformCache.get(value);/**
    	 * Open a database.
    	 *
    	 * @param name Name of the database.
    	 * @param version Schema version.
    	 * @param callbacks Additional callbacks.
    	 */function openDB(name,version){let{blocked,upgrade,blocking,terminated}=arguments.length>2&&arguments[2]!==undefined?arguments[2]:{};const request=indexedDB.open(name,version);const openPromise=wrap$1(request);if(upgrade){request.addEventListener('upgradeneeded',event=>{upgrade(wrap$1(request.result),event.oldVersion,event.newVersion,wrap$1(request.transaction),event);});}if(blocked){request.addEventListener('blocked',event=>blocked(// Casting due to https://github.com/microsoft/TypeScript-DOM-lib-generator/pull/1405
    	event.oldVersion,event.newVersion,event));}openPromise.then(db=>{if(terminated)db.addEventListener('close',()=>terminated());if(blocking){db.addEventListener('versionchange',event=>blocking(event.oldVersion,event.newVersion,event));}}).catch(()=>{});return openPromise;}const readMethods=['get','getKey','getAll','getAllKeys','count'];const writeMethods=['put','add','delete','clear'];const cachedMethods=new Map();function getMethod(target,prop){if(!(target instanceof IDBDatabase&&!(prop in target)&&typeof prop==='string')){return;}if(cachedMethods.get(prop))return cachedMethods.get(prop);const targetFuncName=prop.replace(/FromIndex$/,'');const useIndex=prop!==targetFuncName;const isWrite=writeMethods.includes(targetFuncName);if(// Bail if the target doesn't exist on the target. Eg, getAll isn't in Edge.
    	!(targetFuncName in(useIndex?IDBIndex:IDBObjectStore).prototype)||!(isWrite||readMethods.includes(targetFuncName))){return;}const method=async function(storeName){// isWrite ? 'readwrite' : undefined gzipps better, but fails in Edge :(
    	const tx=this.transaction(storeName,isWrite?'readwrite':'readonly');let target=tx.store;for(var _len4=arguments.length,args=new Array(_len4>1?_len4-1:0),_key5=1;_key5<_len4;_key5++){args[_key5-1]=arguments[_key5];}if(useIndex)target=target.index(args.shift());// Must reject if op rejects.
    	// If it's a write operation, must reject if tx.done rejects.
    	// Must reject with op rejection first.
    	// Must resolve with op value.
    	// Must handle both promises (no unhandled rejections)
    	return (await Promise.all([target[targetFuncName](...args),isWrite&&tx.done]))[0];};cachedMethods.set(prop,method);return method;}replaceTraps(oldTraps=>({...oldTraps,get:(target,prop,receiver)=>getMethod(target,prop)||oldTraps.get(target,prop,receiver),has:(target,prop)=>!!getMethod(target,prop)||oldTraps.has(target,prop)}));var _IndexedDB_instances,_IndexedDB_dbName,_IndexedDB_tableName,_IndexedDB_propertyKey,_IndexedDB_version,_IndexedDB_indices,_IndexedDB_cursorToRecord,_IndexedDB_mapCursorToRecords,_IndexedDB_deleteWithCursor;const BATCH_SIZE=100;const SORT_ASC="next";const SORT_DESC="prev";class IndexedDB{constructor(_ref2){let{dbName,tableName,version,indices,cursorToRecord,propertyKey}=_ref2;_IndexedDB_instances.add(this);_IndexedDB_dbName.set(this,void 0);_IndexedDB_tableName.set(this,void 0);_IndexedDB_propertyKey.set(this,void 0);_IndexedDB_version.set(this,void 0);_IndexedDB_indices.set(this,void 0);_IndexedDB_cursorToRecord.set(this,void 0);__classPrivateFieldSet(this,_IndexedDB_dbName,dbName);__classPrivateFieldSet(this,_IndexedDB_tableName,tableName);__classPrivateFieldSet(this,_IndexedDB_version,version);__classPrivateFieldSet(this,_IndexedDB_indices,indices);__classPrivateFieldSet(this,_IndexedDB_cursorToRecord,cursorToRecord);__classPrivateFieldSet(this,_IndexedDB_propertyKey,propertyKey);}open(){return __awaiter$3(this,void 0,void 0,function*(){const tableName=__classPrivateFieldGet(this,_IndexedDB_tableName,"f");const indices=__classPrivateFieldGet(this,_IndexedDB_indices,"f");const createStoreOptions={keyPath:__classPrivateFieldGet(this,_IndexedDB_propertyKey,"f"),autoIncrement:!__classPrivateFieldGet(this,_IndexedDB_propertyKey,"f")};return openDB(__classPrivateFieldGet(this,_IndexedDB_dbName,"f"),__classPrivateFieldGet(this,_IndexedDB_version,"f"),{upgrade(db,oldVersion){if(oldVersion<1){const logsStore=db.createObjectStore(tableName,createStoreOptions);for(const index of indices){logsStore.createIndex(index.name,index.field);}}}});});}getAll(){return __awaiter$3(this,arguments,void 0,function(){var _this4=this;let{maxRecords=BATCH_SIZE,sortAsc=true}=arguments.length>0&&arguments[0]!==undefined?arguments[0]:{};return function*(){const db=yield _this4.open();try{const tx=db.transaction(__classPrivateFieldGet(_this4,_IndexedDB_tableName,"f"));const store=tx.objectStore(__classPrivateFieldGet(_this4,_IndexedDB_tableName,"f"));return yield __classPrivateFieldGet(_this4,_IndexedDB_instances,"m",_IndexedDB_mapCursorToRecords).call(_this4,yield store.openCursor(null,sortAsc?SORT_ASC:SORT_DESC),maxRecords);}finally{db.close();}}();});}getByIndex(index_1,value_1){return __awaiter$3(this,arguments,void 0,function(index,value){var _this5=this;let maxRecords=arguments.length>2&&arguments[2]!==undefined?arguments[2]:BATCH_SIZE;let condition=arguments.length>3?arguments[3]:undefined;return function*(){const db=yield _this5.open();try{const tx=db.transaction(__classPrivateFieldGet(_this5,_IndexedDB_tableName,"f"));const store=tx.objectStore(__classPrivateFieldGet(_this5,_IndexedDB_tableName,"f"));return yield __classPrivateFieldGet(_this5,_IndexedDB_instances,"m",_IndexedDB_mapCursorToRecords).call(_this5,yield store.index(index).openCursor(value),maxRecords,condition);}finally{db.close();}}();});}put(values){return __awaiter$3(this,void 0,void 0,function*(){const db=yield this.open();try{const tx=db.transaction(__classPrivateFieldGet(this,_IndexedDB_tableName,"f"),"readwrite");const store=tx.objectStore(__classPrivateFieldGet(this,_IndexedDB_tableName,"f"));for(const value of values){yield store.put(value);}}finally{db.close();}});}count(){return __awaiter$3(this,void 0,void 0,function*(){const db=yield this.open();try{return yield db.count(__classPrivateFieldGet(this,_IndexedDB_tableName,"f"));}finally{db.close();}});}delete(key){return __awaiter$3(this,void 0,void 0,function*(){const db=yield this.open();try{yield db.delete(__classPrivateFieldGet(this,_IndexedDB_tableName,"f"),key);}finally{db.close();}});}deleteMultiple(keys){return __awaiter$3(this,void 0,void 0,function*(){const db=yield this.open();try{const deleteTasks=keys.map(key=>db.delete(__classPrivateFieldGet(this,_IndexedDB_tableName,"f"),key));yield Promise.all(deleteTasks);}finally{db.close();}});}deleteByIndex(index_1,value_1){return __awaiter$3(this,arguments,void 0,function(index,value){var _this6=this;let maxRecords=arguments.length>2&&arguments[2]!==undefined?arguments[2]:BATCH_SIZE;return function*(){const db=yield _this6.open();try{const tx=db.transaction(__classPrivateFieldGet(_this6,_IndexedDB_tableName,"f"),"readwrite");const store=tx.objectStore(__classPrivateFieldGet(_this6,_IndexedDB_tableName,"f"));return yield __classPrivateFieldGet(_this6,_IndexedDB_instances,"m",_IndexedDB_deleteWithCursor).call(_this6,yield store.index(index).openCursor(value),maxRecords);}finally{db.close();}}();});}deleteRecords(){return __awaiter$3(this,arguments,void 0,function(){var _this7=this;let maxRecords=arguments.length>0&&arguments[0]!==undefined?arguments[0]:BATCH_SIZE;return function*(){const db=yield _this7.open();try{const tx=db.transaction(__classPrivateFieldGet(_this7,_IndexedDB_tableName,"f"),"readwrite");const store=tx.objectStore(__classPrivateFieldGet(_this7,_IndexedDB_tableName,"f"));return yield __classPrivateFieldGet(_this7,_IndexedDB_instances,"m",_IndexedDB_deleteWithCursor).call(_this7,yield store.openCursor(null,SORT_ASC),maxRecords);}finally{db.close();}}();});}}_IndexedDB_dbName=new WeakMap(),_IndexedDB_tableName=new WeakMap(),_IndexedDB_propertyKey=new WeakMap(),_IndexedDB_version=new WeakMap(),_IndexedDB_indices=new WeakMap(),_IndexedDB_cursorToRecord=new WeakMap(),_IndexedDB_instances=new WeakSet(),_IndexedDB_mapCursorToRecords=function _IndexedDB_mapCursorToRecords(cursor_1){return __awaiter$3(this,arguments,void 0,function(cursor){var _this8=this;let maxRecords=arguments.length>1&&arguments[1]!==undefined?arguments[1]:BATCH_SIZE;let condition=arguments.length>2?arguments[2]:undefined;return function*(){const result=[];while(cursor&&result.length<maxRecords){const record=__classPrivateFieldGet(_this8,_IndexedDB_cursorToRecord,"f").call(_this8,cursor);if(!condition||condition(record)){result.push(record);}cursor=yield cursor.continue();}return result;}();});},_IndexedDB_deleteWithCursor=function _IndexedDB_deleteWithCursor(cursor,maxRecords){return __awaiter$3(this,void 0,void 0,function*(){let deletedRecords=0;while(cursor&&deletedRecords<maxRecords){yield cursor.delete();deletedRecords++;cursor=yield cursor.continue();}return deletedRecords;});};const DB_VERSION$1=1;class LogsIndexedDB extends IndexedDB{constructor(){let dbName=arguments.length>0&&arguments[0]!==undefined?arguments[0]:DB_NAME;super({dbName,tableName:DB_LOGS_TABLE_NAME,cursorToRecord:cursor=>new LogRecord(cursor.primaryKey,cursor.value.log,cursor.value.logType,cursor.value.transportId),indices:[{name:DB_INDEX_BY_TRANSPORT_ID,field:DB_FIELD_TRANSPORT_ID},{name:DB_INDEX_BY_LOG_TYPE,field:DB_FIELD_LOG_TYPE}],version:DB_VERSION$1});}getByTransportId(transportId,maxRecords){return __awaiter$3(this,void 0,void 0,function*(){return this.getByIndex("byTransportId",transportId,maxRecords);});}getByLogType(logType,maxRecords){return __awaiter$3(this,void 0,void 0,function*(){return this.getByIndex("byLogType",logType,maxRecords);});}putLog(log,transportId){return __awaiter$3(this,void 0,void 0,function*(){return this.put([{log,logType:log.type,transportId}]);});}deleteByLogType(logType,maxRecords){return __awaiter$3(this,void 0,void 0,function*(){return this.deleteByIndex("byLogType",logType,maxRecords);});}}var _LogsStorage_database;const NR_LOGS_TO_DISCARD=200;const MAX_RECORDS$1=10000;class LogsStorage{constructor(_ref3){let{databaseName,database=new LogsIndexedDB(databaseName)}=_ref3;_LogsStorage_database.set(this,void 0);__classPrivateFieldSet(this,_LogsStorage_database,database);}readLogs(maxRecords){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_LogsStorage_database,"f").getAll({sortAsc:true,maxRecords});});}readLogsByTransport(transportId,maxRecords){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_LogsStorage_database,"f").getByTransportId(transportId,maxRecords);});}removeLogs(logKeys){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_LogsStorage_database,"f").deleteMultiple(logKeys);});}insertLog(log,transportId){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_LogsStorage_database,"f").putLog(log,transportId);});}countLogs(){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_LogsStorage_database,"f").count();});}isFull(){return __awaiter$3(this,void 0,void 0,function*(){const logsCount=yield __classPrivateFieldGet(this,_LogsStorage_database,"f").count();return logsCount>=MAX_RECORDS$1;});}discardLogs(){return __awaiter$3(this,arguments,void 0,function(){var _this9=this;let maxLogsToDiscard=arguments.length>0&&arguments[0]!==undefined?arguments[0]:NR_LOGS_TO_DISCARD;return function*(){const logTypesKeys=Object.keys(LogType$1).filter(key=>isNaN(Number(key)));let logsLeftToDiscard=maxLogsToDiscard;for(const logTypeKey of logTypesKeys){const logType=mapKeyToLogType[logTypeKey];const logsDeleted=yield __classPrivateFieldGet(_this9,_LogsStorage_database,"f").deleteByLogType(logType,logsLeftToDiscard);logsLeftToDiscard-=logsDeleted;if(logsLeftToDiscard<=0){break;}}return logsLeftToDiscard;}();});}}_LogsStorage_database=new WeakMap();var AggregationAttributes;(function(AggregationAttributes){AggregationAttributes["IsAggregateProxy"]="outsystems.aggregation.proxy";AggregationAttributes["AggregationSize"]="outsystems.aggregation.size";AggregationAttributes["IsOutlier"]="outsystems.aggregation.outlier";AggregationAttributes["AverageDuration"]="outsystems.aggregation.duration.average";AggregationAttributes["MaxDuration"]="outsystems.aggregation.duration.max";AggregationAttributes["MinDuration"]="outsystems.aggregation.duration.min";AggregationAttributes["IsNonAggregable"]="osinternal.spanIsNonAggregable";AggregationAttributes["ChildrenNames"]="osinternal.childrenNames";AggregationAttributes["functionKey"]="outsystems.function.key";})(AggregationAttributes||(AggregationAttributes={}));const NON_AGGREGABLE_PREFIX="NonAggregable";function compareStrings(a,b){if(a<b){return  -1;}else if(b<a){return 1;}else {return 0;}}function defaultGetSpanObjectId(span){return span.attributes[AggregationAttributes.functionKey];}function makeAggregateSignature(span,transportId,getSpanObjectId){var _a;const name=span.name;const objectId=getSpanObjectId===null||getSpanObjectId===void 0?void 0:getSpanObjectId(span);const children=(_a=span.attributes[AggregationAttributes.ChildrenNames])!==null&&_a!==void 0?_a:[];children.sort(compareStrings);const nonAggregable=span.attributes[AggregationAttributes.IsNonAggregable]?`${NON_AGGREGABLE_PREFIX}.`:"";return `${nonAggregable}${transportId}.${name}.${objectId}(${children.join(",")})`;}function canAggregateSpan(span,children){return !(span.attributes[AggregationAttributes.IsNonAggregable]||children.some(child=>child.attributes[AggregationAttributes.IsNonAggregable]));}const thresholds={absolute:(_ref4,value)=>{let{min,max}=_ref4;const under=typeof min==="number"&&value<min;const over=typeof max==="number"&&value>max;return under||over;},relative:(_ref5,value,baseline)=>{let{min,max}=_ref5;return thresholds.absolute({min:typeof min==="number"?baseline+min:undefined,max:typeof max==="number"?baseline+max:undefined},value);},ratio:(_ref6,value,baseline)=>{let{lower,upper,max,min}=_ref6;return thresholds.relative({min:typeof lower==="number"?Math.min(baseline*lower,min!==null&&min!==void 0?min:Infinity):undefined,max:typeof upper==="number"?Math.max(baseline*upper,max!==null&&max!==void 0?max:-Infinity):undefined},value,baseline);}};function applyThreshold(params,value,baseline){return thresholds[params.type](params,value,baseline);}var _ThresholdOutlierDetector_thresholds;class ThresholdOutlierDetector{constructor(thresholds){_ThresholdOutlierDetector_thresholds.set(this,void 0);__classPrivateFieldSet(this,_ThresholdOutlierDetector_thresholds,thresholds);}isOutlier(span,proxy){for(const[attribute,params]of Object.entries(__classPrivateFieldGet(this,_ThresholdOutlierDetector_thresholds,"f"))){const value=span.attributes[attribute];const baseline=proxy.attributes[attribute];if(value===undefined&&baseline===undefined){continue;}if(value===undefined||baseline===undefined||applyThreshold(params,value,baseline)){return true;}}return false;}}_ThresholdOutlierDetector_thresholds=new WeakMap();var _SpanAggregator_instances,_SpanAggregator_storage,_SpanAggregator_outlierDetector,_SpanAggregator_getSpanObjectId,_SpanAggregator_findProxy,_SpanAggregator_updateProxy,_SpanAggregator_createEnrichedSpan,_SpanAggregator_toOutlierSpan,_SpanAggregator_toNonAggregableSpan,_SpanAggregator_adopt;class SpanAggregator{constructor(_ref7){let{storage,outlierDetector=new ThresholdOutlierDetector({[AggregationAttributes.AverageDuration]:{type:"ratio",upper:0.1,max:50e6}}),getSpanObjectId=defaultGetSpanObjectId}=_ref7;_SpanAggregator_instances.add(this);_SpanAggregator_storage.set(this,void 0);_SpanAggregator_outlierDetector.set(this,void 0);_SpanAggregator_getSpanObjectId.set(this,void 0);__classPrivateFieldSet(this,_SpanAggregator_storage,storage);__classPrivateFieldSet(this,_SpanAggregator_outlierDetector,outlierDetector);__classPrivateFieldSet(this,_SpanAggregator_getSpanObjectId,getSpanObjectId);}aggregate(span,transportId){return __awaiter$3(this,void 0,void 0,function*(){const children=yield __classPrivateFieldGet(this,_SpanAggregator_storage,"f").readSpansByParentId(span.spanId);const enrichedSpan=__classPrivateFieldGet(this,_SpanAggregator_instances,"m",_SpanAggregator_createEnrichedSpan).call(this,span);const canAggregate=canAggregateSpan(enrichedSpan,children);if(!canAggregate){yield __classPrivateFieldGet(this,_SpanAggregator_storage,"f").insertSpans([__classPrivateFieldGet(this,_SpanAggregator_instances,"m",_SpanAggregator_toNonAggregableSpan).call(this,enrichedSpan)],transportId);return;}const proxy=yield __classPrivateFieldGet(this,_SpanAggregator_instances,"m",_SpanAggregator_findProxy).call(this,enrichedSpan,transportId);if(!proxy){yield __classPrivateFieldGet(this,_SpanAggregator_storage,"f").insertSpans([enrichedSpan],transportId);}else if(__classPrivateFieldGet(this,_SpanAggregator_outlierDetector,"f").isOutlier(enrichedSpan,proxy)){yield __classPrivateFieldGet(this,_SpanAggregator_storage,"f").insertSpans([__classPrivateFieldGet(this,_SpanAggregator_instances,"m",_SpanAggregator_toOutlierSpan).call(this,enrichedSpan)],transportId);}else {const newProxy=__classPrivateFieldGet(this,_SpanAggregator_instances,"m",_SpanAggregator_updateProxy).call(this,span,proxy);const adoptedChildren=__classPrivateFieldGet(this,_SpanAggregator_instances,"m",_SpanAggregator_adopt).call(this,children,newProxy);yield __classPrivateFieldGet(this,_SpanAggregator_storage,"f").insertSpans([newProxy,...adoptedChildren],transportId);}});}}_SpanAggregator_storage=new WeakMap(),_SpanAggregator_outlierDetector=new WeakMap(),_SpanAggregator_getSpanObjectId=new WeakMap(),_SpanAggregator_instances=new WeakSet(),_SpanAggregator_findProxy=function _SpanAggregator_findProxy(span,transportId){return __awaiter$3(this,void 0,void 0,function*(){const signature=makeAggregateSignature(span,transportId,__classPrivateFieldGet(this,_SpanAggregator_getSpanObjectId,"f"));const[proxy]=yield __classPrivateFieldGet(this,_SpanAggregator_storage,"f").readSpansByAggregateSignature(signature);return proxy;});},_SpanAggregator_updateProxy=function _SpanAggregator_updateProxy(span,proxy){var _a;const oldSize=(_a=proxy.attributes[AggregationAttributes.AggregationSize])!==null&&_a!==void 0?_a:1;const oldAverage=proxy.attributes[AggregationAttributes.AverageDuration];const oldMax=proxy.attributes[AggregationAttributes.MaxDuration];const oldMin=proxy.attributes[AggregationAttributes.MinDuration];const spanDuration=span.endTimeUnixNano-span.startTimeUnixNano;return Object.assign(Object.assign({},proxy),{attributes:Object.assign(Object.assign({},proxy.attributes),{[AggregationAttributes.IsAggregateProxy]:true,[AggregationAttributes.AggregationSize]:oldSize+1,[AggregationAttributes.AverageDuration]:(oldAverage*oldSize+spanDuration)/(oldSize+1),[AggregationAttributes.MaxDuration]:Math.max(oldMax,spanDuration),[AggregationAttributes.MinDuration]:Math.min(oldMin,spanDuration)}),parentSpanId:proxy.parentSpanId===span.spanId?span.parentSpanId:proxy.parentSpanId});},_SpanAggregator_createEnrichedSpan=function _SpanAggregator_createEnrichedSpan(span){const duration=span.endTimeUnixNano-span.startTimeUnixNano;return Object.assign(Object.assign({},span),{attributes:Object.assign(Object.assign({},span.attributes),{[AggregationAttributes.IsAggregateProxy]:false,[AggregationAttributes.AverageDuration]:duration,[AggregationAttributes.MaxDuration]:duration,[AggregationAttributes.MinDuration]:duration})});},_SpanAggregator_toOutlierSpan=function _SpanAggregator_toOutlierSpan(span){return Object.assign(Object.assign({},span),{attributes:Object.assign(Object.assign({},span.attributes),{[AggregationAttributes.IsOutlier]:true,[AggregationAttributes.IsNonAggregable]:true})});},_SpanAggregator_toNonAggregableSpan=function _SpanAggregator_toNonAggregableSpan(span){return Object.assign(Object.assign({},span),{attributes:Object.assign(Object.assign({},span.attributes),{[AggregationAttributes.IsNonAggregable]:true})});},_SpanAggregator_adopt=function _SpanAggregator_adopt(children,newParent){return children.flatMap(child=>child.spanId!==newParent.spanId?[Object.assign(Object.assign({},child),{parentSpanId:newParent.spanId})]:[]);};class SpanRecord{constructor(_ref8){let{spanId,span,transportId,aggregateSignature}=_ref8;this.spanId=spanId;this.span=span;this.transportId=transportId;this.parentId=span.parentSpanId;this.aggregateSignature=aggregateSignature!==null&&aggregateSignature!==void 0?aggregateSignature:"";}}var _TracesIndexedDB_instances,_TracesIndexedDB_spanToRecord;const DB_VERSION=1;class TracesIndexedDB extends IndexedDB{constructor(){let dbName=arguments.length>0&&arguments[0]!==undefined?arguments[0]:DB_NAME;let propertyKey=arguments.length>1?arguments[1]:undefined;super({dbName,tableName:DB_TRACES_TABLE_NAME,version:DB_VERSION,propertyKey,cursorToRecord:cursor=>new SpanRecord({spanId:cursor.primaryKey,span:cursor.value.span,transportId:cursor.value.transportId,aggregateSignature:cursor.value.aggregateSignature}),indices:[{name:DB_INDEX_BY_TRANSPORT_ID,field:DB_FIELD_TRANSPORT_ID},{name:DB_INDEX_BY_AGGREGATE_SIGNATURE,field:DB_FIELD_AGGREGATE_SIGNATURE},{name:DB_INDEX_BY_PARENT_ID,field:DB_FIELD_PARENT_ID}]});_TracesIndexedDB_instances.add(this);}getByAggregateSignature(aggregateSignature,maxRecords){return this.getByIndex("byAggregateSignature",aggregateSignature,maxRecords);}getByParentId(parentId,maxRecords){return this.getByIndex("byParentId",parentId,maxRecords);}getByTransportId(transportId,maxRecords){return this.getByIndex("byTransportId",transportId,maxRecords);}getTopLevelByTransportId(transportId,maxRecords){return this.getByIndex("byTransportId",transportId,maxRecords,record=>record.parentId===undefined);}putSpans(spans,transportId){return this.put(spans.map(span=>__classPrivateFieldGet(this,_TracesIndexedDB_instances,"m",_TracesIndexedDB_spanToRecord).call(this,span,transportId)));}}_TracesIndexedDB_instances=new WeakSet(),_TracesIndexedDB_spanToRecord=function _TracesIndexedDB_spanToRecord(span,transportId){return {span,transportId,spanId:span.spanId,aggregateSignature:makeAggregateSignature(span,transportId,span=>span.attributes["outsystems.function.key"]),parentId:span.parentSpanId};};var _TracesStorage_database;const NR_SPANS_TO_DISCARD=200;const MAX_RECORDS=10000;class TracesStorage{constructor(_ref9){let{databaseName,autoincrement=true,database=autoincrement?new TracesIndexedDB(databaseName):new TracesIndexedDB(databaseName,"spanId")}=_ref9;_TracesStorage_database.set(this,void 0);__classPrivateFieldSet(this,_TracesStorage_database,database);}readSpans(maxRecords){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_TracesStorage_database,"f").getAll({sortAsc:true,maxRecords});});}readSpansByTransport(transportId,maxRecords){return __awaiter$3(this,void 0,void 0,function*(){const topLevelSpans=yield __classPrivateFieldGet(this,_TracesStorage_database,"f").getTopLevelByTransportId(transportId,maxRecords);return topLevelSpans.length>0?topLevelSpans:__classPrivateFieldGet(this,_TracesStorage_database,"f").getByTransportId(transportId,maxRecords);});}readSpansByParentId(parentId,maxRecords){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_TracesStorage_database,"f").getByParentId(parentId,maxRecords);});}readSpansByAggregateSignature(aggregateSignature,maxRecords){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_TracesStorage_database,"f").getByAggregateSignature(aggregateSignature,maxRecords);});}removeSpans(spanKeys){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_TracesStorage_database,"f").deleteMultiple(spanKeys);});}insertSpan(span,transportId){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_TracesStorage_database,"f").putSpans([span],transportId);});}insertSerializableSpans(spans,transportId){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_TracesStorage_database,"f").putSpans(spans,transportId);});}countSpans(){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_TracesStorage_database,"f").count();});}isFull(){return __awaiter$3(this,void 0,void 0,function*(){const spansCount=yield __classPrivateFieldGet(this,_TracesStorage_database,"f").count();return spansCount>=MAX_RECORDS;});}discardSpans(){return __awaiter$3(this,arguments,void 0,function(){var _this0=this;let maxSpansToDiscard=arguments.length>0&&arguments[0]!==undefined?arguments[0]:NR_SPANS_TO_DISCARD;return function*(){return __classPrivateFieldGet(_this0,_TracesStorage_database,"f").deleteRecords(maxSpansToDiscard);}();});}}_TracesStorage_database=new WeakMap();function makeSpanAggregator(storage){return new SpanAggregator({storage:{insertSpans:(spans,transportId)=>__awaiter$3(this,void 0,void 0,function*(){yield storage.insertSerializableSpans(spans,transportId);}),readSpansByAggregateSignature:aggregateSignature=>__awaiter$3(this,void 0,void 0,function*(){const records=yield storage.readSpansByAggregateSignature(aggregateSignature);return records.map(record=>record.span);}),readSpansByParentId:parentId=>__awaiter$3(this,void 0,void 0,function*(){const records=yield storage.readSpansByParentId(parentId);return records.map(record=>record.span);})},getSpanObjectId:span=>span.attributes["outsystems.function.key"]});}var _OfflineManager_offlineLogsStorage,_OfflineManager_offlineTracesStorage,_OfflineManager_legacyOfflineTracesStorage,_OfflineManager_hasLegacySpans,_OfflineManager_isOnline,_OfflineManager_aggregateSpans,_OfflineManager_spanAggregator,_OfflineManager_mutexDispatchOnWriteSpans,_OfflineManager_mutexDispatchOnWriteLogs;const LOG_BATCH_SIZE=100;const SPAN_BATCH_SIZE=1000;const mutexDispatchOnWriteLogs=new Mutex();const mutexDispatchOnWriteSpans=new Mutex();const LOGS_DB_NAME="logs";const TRACES_DB_NAME="spans_v2";const TRACES_DB_NAME_LEGACY="spans";class OfflineManager{constructor(_ref0){let{databaseNameSuffix,isOnline=()=>true,offlineLogsStorage=new LogsStorage({databaseName:`${LOGS_DB_NAME}-${databaseNameSuffix}`}),offlineTracesStorage=new TracesStorage({databaseName:`${TRACES_DB_NAME}-${databaseNameSuffix}`,autoincrement:false}),legacyOfflineTracesStorage=new TracesStorage({databaseName:`${TRACES_DB_NAME_LEGACY}-${databaseNameSuffix}`}),flushLegacyTraces=false,aggregateSpans=false,spanAggregator=makeSpanAggregator(offlineTracesStorage),mutexDispatchLogs=mutexDispatchOnWriteLogs,mutexDispatchSpans=mutexDispatchOnWriteSpans}=_ref0;_OfflineManager_offlineLogsStorage.set(this,void 0);_OfflineManager_offlineTracesStorage.set(this,void 0);_OfflineManager_legacyOfflineTracesStorage.set(this,void 0);_OfflineManager_hasLegacySpans.set(this,true);_OfflineManager_isOnline.set(this,void 0);_OfflineManager_aggregateSpans.set(this,void 0);_OfflineManager_spanAggregator.set(this,void 0);_OfflineManager_mutexDispatchOnWriteSpans.set(this,void 0);_OfflineManager_mutexDispatchOnWriteLogs.set(this,void 0);__classPrivateFieldSet(this,_OfflineManager_offlineLogsStorage,offlineLogsStorage);__classPrivateFieldSet(this,_OfflineManager_offlineTracesStorage,offlineTracesStorage);__classPrivateFieldSet(this,_OfflineManager_legacyOfflineTracesStorage,legacyOfflineTracesStorage);__classPrivateFieldSet(this,_OfflineManager_isOnline,isOnline);__classPrivateFieldSet(this,_OfflineManager_hasLegacySpans,flushLegacyTraces);__classPrivateFieldSet(this,_OfflineManager_aggregateSpans,aggregateSpans);__classPrivateFieldSet(this,_OfflineManager_spanAggregator,spanAggregator);__classPrivateFieldSet(this,_OfflineManager_mutexDispatchOnWriteLogs,mutexDispatchLogs);__classPrivateFieldSet(this,_OfflineManager_mutexDispatchOnWriteSpans,mutexDispatchSpans);}setAggregateSpansStatus(value){__classPrivateFieldSet(this,_OfflineManager_aggregateSpans,value);}writeLog(log_1,transport_1){return __awaiter$3(this,arguments,void 0,function(log,transport){var _this1=this;let logsBatchSize=arguments.length>2&&arguments[2]!==undefined?arguments[2]:LOG_BATCH_SIZE;return function*(){try{const isStorageFull=yield __classPrivateFieldGet(_this1,_OfflineManager_offlineLogsStorage,"f").isFull();if(isStorageFull){yield __classPrivateFieldGet(_this1,_OfflineManager_offlineLogsStorage,"f").discardLogs();}yield __classPrivateFieldGet(_this1,_OfflineManager_offlineLogsStorage,"f").insertLog(log,transport.getTransportId());if((yield __classPrivateFieldGet(_this1,_OfflineManager_offlineLogsStorage,"f").countLogs())>=logsBatchSize){yield _this1.flushTransportLogs(transport);}}catch(e){console.debug("Error writing log to storage",e);}}();});}writeSpan(span_1,transport_1){return __awaiter$3(this,arguments,void 0,function(span,transport){var _this10=this;let logsBatchSize=arguments.length>2&&arguments[2]!==undefined?arguments[2]:SPAN_BATCH_SIZE;return function*(){try{const isStorageFull=yield __classPrivateFieldGet(_this10,_OfflineManager_offlineTracesStorage,"f").isFull();if(isStorageFull){yield __classPrivateFieldGet(_this10,_OfflineManager_offlineTracesStorage,"f").discardSpans();}yield __classPrivateFieldGet(_this10,_OfflineManager_mutexDispatchOnWriteSpans,"f").runExclusive(()=>__awaiter$3(_this10,void 0,void 0,function*(){if(__classPrivateFieldGet(this,_OfflineManager_aggregateSpans,"f")){yield __classPrivateFieldGet(this,_OfflineManager_spanAggregator,"f").aggregate(span,transport.getTransportId());}else {yield __classPrivateFieldGet(this,_OfflineManager_offlineTracesStorage,"f").insertSpan(span,transport.getTransportId());}}));if((yield __classPrivateFieldGet(_this10,_OfflineManager_offlineTracesStorage,"f").countSpans())>=logsBatchSize){yield _this10.flushTransportSpans(transport);}}catch(e){console.debug("Error writing trace to storage",e);}}();});}processTransportLogs(transport_1){return __awaiter$3(this,arguments,void 0,function(transport){var _this11=this;let logsBatchSize=arguments.length>1&&arguments[1]!==undefined?arguments[1]:LOG_BATCH_SIZE;return function*(){yield __classPrivateFieldGet(_this11,_OfflineManager_mutexDispatchOnWriteLogs,"f").runExclusive(()=>__awaiter$3(_this11,void 0,void 0,function*(){yield this.internalLogProcess(transport,logsBatchSize,true);}));}();});}flushTransportLogs(transport_1){return __awaiter$3(this,arguments,void 0,function(transport){var _this12=this;let logsBatchSize=arguments.length>1&&arguments[1]!==undefined?arguments[1]:LOG_BATCH_SIZE;return function*(){yield __classPrivateFieldGet(_this12,_OfflineManager_mutexDispatchOnWriteLogs,"f").runExclusive(()=>__awaiter$3(_this12,void 0,void 0,function*(){yield this.internalLogProcess(transport,logsBatchSize,false);}));}();});}internalLogProcess(transport,logsBatchSize,processCompleteBatchOnly){return __awaiter$3(this,void 0,void 0,function*(){if(transport.requiresConnectivity()&&!__classPrivateFieldGet(this,_OfflineManager_isOnline,"f").call(this)){return;}try{const batchSizeThreshold=processCompleteBatchOnly?logsBatchSize:1;let logsToProcess=yield __classPrivateFieldGet(this,_OfflineManager_offlineLogsStorage,"f").readLogsByTransport(transport.getTransportId(),logsBatchSize);while(logsToProcess.length>=batchSizeThreshold){yield transport.writeAll(logsToProcess.map(record=>record.log));yield __classPrivateFieldGet(this,_OfflineManager_offlineLogsStorage,"f").removeLogs(logsToProcess.map(record=>record.logId));logsToProcess=yield __classPrivateFieldGet(this,_OfflineManager_offlineLogsStorage,"f").readLogsByTransport(transport.getTransportId(),logsBatchSize);}}catch(e){console.debug("Error in internal log processing",e);throw e;}});}processTransportSpans(transport_1){return __awaiter$3(this,arguments,void 0,function(transport){var _this13=this;let spansBatchSize=arguments.length>1&&arguments[1]!==undefined?arguments[1]:SPAN_BATCH_SIZE;return function*(){yield __classPrivateFieldGet(_this13,_OfflineManager_mutexDispatchOnWriteSpans,"f").runExclusive(()=>__awaiter$3(_this13,void 0,void 0,function*(){yield this.internalSpanProcess(transport,spansBatchSize,true);}));}();});}flushTransportSpans(transport_1){return __awaiter$3(this,arguments,void 0,function(transport){var _this14=this;let spansBatchSize=arguments.length>1&&arguments[1]!==undefined?arguments[1]:SPAN_BATCH_SIZE;return function*(){yield __classPrivateFieldGet(_this14,_OfflineManager_mutexDispatchOnWriteSpans,"f").runExclusive(()=>__awaiter$3(_this14,void 0,void 0,function*(){yield this.internalSpanProcess(transport,spansBatchSize,false);}));}();});}internalSpanProcess(transport,spansBatchSize,processCompleteBatchOnly){return __awaiter$3(this,void 0,void 0,function*(){if(transport.requiresConnectivity()&&!__classPrivateFieldGet(this,_OfflineManager_isOnline,"f").call(this)){return;}if(__classPrivateFieldGet(this,_OfflineManager_hasLegacySpans,"f")){try{const pending=yield this.writeSpansToTransport({transport,spansBatchSize,storage:__classPrivateFieldGet(this,_OfflineManager_legacyOfflineTracesStorage,"f"),processCompleteBatchOnly:false});__classPrivateFieldSet(this,_OfflineManager_hasLegacySpans,pending>0,"f");}catch(e){console.warn("Error in processing legacy spans",e);}}yield this.writeSpansToTransport({transport,spansBatchSize,processCompleteBatchOnly,storage:__classPrivateFieldGet(this,_OfflineManager_offlineTracesStorage,"f")});});}writeSpansToTransport(_a){return __awaiter$3(this,arguments,void 0,function(_ref1){let{transport,spansBatchSize,processCompleteBatchOnly,storage}=_ref1;return function*(){try{const batchSizeThreshold=processCompleteBatchOnly?spansBatchSize:1;let spansToProcess=yield storage.readSpansByTransport(transport.getTransportId(),spansBatchSize);if(spansToProcess.length===0){return 0;}while(spansToProcess.length>=batchSizeThreshold){yield transport.writeAll(spansToProcess.map(record=>record.span));yield storage.removeSpans(spansToProcess.map(record=>record.spanId));spansToProcess=yield storage.readSpansByTransport(transport.getTransportId(),spansBatchSize);}return yield storage.countSpans();}catch(e){console.debug("Error processing spans",e);throw e;}}();});}}_OfflineManager_offlineLogsStorage=new WeakMap(),_OfflineManager_offlineTracesStorage=new WeakMap(),_OfflineManager_legacyOfflineTracesStorage=new WeakMap(),_OfflineManager_hasLegacySpans=new WeakMap(),_OfflineManager_isOnline=new WeakMap(),_OfflineManager_aggregateSpans=new WeakMap(),_OfflineManager_spanAggregator=new WeakMap(),_OfflineManager_mutexDispatchOnWriteSpans=new WeakMap(),_OfflineManager_mutexDispatchOnWriteLogs=new WeakMap();const TIMER_INTERVAL=60000;class TaskScheduler{constructor(){let timerInterval=arguments.length>0&&arguments[0]!==undefined?arguments[0]:TIMER_INTERVAL;this.timerInterval=timerInterval;this.tasksToRun=new Map();}scheduleNextRun(){if(this.currentTaskTimeout){clearTimeout(this.currentTaskTimeout);}this.currentTaskTimeout=setTimeout(()=>this.runTask(),this.timerInterval);}runTask(){return __awaiter$3(this,void 0,void 0,function*(){if(this.currentTaskTimeout){this.stop();const tasks=Array.from(this.tasksToRun.values());const taskPromises=tasks.map(task=>task());yield Promise.all(taskPromises);this.scheduleNextRun();}});}start(){this.scheduleNextRun();}stop(){if(this.currentTaskTimeout){clearTimeout(this.currentTaskTimeout);this.currentTaskTimeout=undefined;}}addTask(id,task){this.tasksToRun.set(id,task);}deleteTask(id){this.tasksToRun.delete(id);}getTask(id){return this.tasksToRun.get(id);}setTimerInterval(timerInterval){this.timerInterval=timerInterval;this.start();}}class TransportManager{constructor(_ref10){let{logTransports=[],traceTransports=[],databaseNameSuffix,isOnline,aggregateSpans,offlineManager=new OfflineManager({databaseNameSuffix,isOnline,flushLegacyTraces:true,aggregateSpans}),taskScheduler=new TaskScheduler(),circuitBreakerRunner=new CircuitBreakerRunner()}=_ref10;this.logTransports=logTransports;this.traceTransports=traceTransports;this.offlineManager=offlineManager;this.taskScheduler=taskScheduler;this.circuitBreakerRunner=circuitBreakerRunner;this.taskScheduler.addTask("flush-logs",()=>__awaiter$3(this,void 0,void 0,function*(){return this.flushLogs();}));this.taskScheduler.addTask("flush-spans",()=>__awaiter$3(this,void 0,void 0,function*(){return this.flushSpans();}));this.taskScheduler.start();}addLogTransport(transport){const newTransportId=transport.getTransportId();const predicate=element=>element.getTransportId()===newTransportId;if(!this.logTransports.some(predicate)){this.logTransports.push(transport);}}addTraceTransport(transport){const newTransportId=transport.getTransportId();const predicate=element=>element.getTransportId()===newTransportId;if(!this.traceTransports.some(predicate)){this.traceTransports.push(transport);}}removeLogTransport(transportId){const predicate=element=>element.getTransportId()===transportId;const transportIndex=this.logTransports.findIndex(predicate);if(transportIndex!==-1){this.logTransports.splice(transportIndex,1);this.circuitBreakerRunner.closeCircuit(transportId);}}removeTraceTransport(transportId){const predicate=element=>element.getTransportId()===transportId;const transportIndex=this.traceTransports.findIndex(predicate);if(transportIndex!==-1){this.traceTransports.splice(transportIndex,1);this.circuitBreakerRunner.closeCircuit(transportId);}}setAllLogTypeBaselines(logType){for(const transport of this.logTransports){transport.setLogTypeBaseline(logType);}}setTagId(tagId){var _a,_b;for(const transport of this.traceTransports){(_a=transport.setTagId)===null||_a===void 0?void 0:_a.call(transport,tagId);}for(const transport of this.logTransports){(_b=transport.setTagId)===null||_b===void 0?void 0:_b.call(transport,tagId);}}setResourceAttributes(attributes){var _a,_b;for(const transport of this.traceTransports){(_a=transport.setResourceAttributes)===null||_a===void 0?void 0:_a.call(transport,attributes);}for(const transport of this.logTransports){(_b=transport.setResourceAttributes)===null||_b===void 0?void 0:_b.call(transport,attributes);}}enableTracing(){for(const transport of this.traceTransports){transport.enableTracing();}}disableTracing(){for(const transport of this.traceTransports){transport.disableTracing();}}flushLogs(){return __awaiter$3(this,void 0,void 0,function*(){const promises=this.logTransports.map(transport=>__awaiter$3(this,void 0,void 0,function*(){const transportId=transport.getTransportId();yield this.circuitBreakerRunner.run(transportId,()=>this.offlineManager.flushTransportLogs(transport));}));yield Promise.all(promises);});}flushSpans(){return __awaiter$3(this,void 0,void 0,function*(){const promises=this.traceTransports.map(transport=>__awaiter$3(this,void 0,void 0,function*(){const transportId=transport.getTransportId();yield this.circuitBreakerRunner.run(transportId,()=>{if(!transport.hasWriteBuffer()&&typeof transport.flush==="function"){return transport.flush();}return this.offlineManager.flushTransportSpans(transport);});}));yield Promise.all(promises);});}processLog(log){return __awaiter$3(this,void 0,void 0,function*(){const transportsAboveLogBaseline=this.logTransports.filter(transport=>transport.getLogTypeBaseline()<=log.type);for(const transport of transportsAboveLogBaseline){if(transport.hasWriteBuffer()){yield this.offlineManager.writeLog(log,transport);}else {const transportId=transport.getTransportId();const runResult=yield this.circuitBreakerRunner.run(transportId,()=>transport.write(log));if(runResult!==0){yield this.offlineManager.writeLog(log,transport);}}}});}processSpan(span){return __awaiter$3(this,void 0,void 0,function*(){const transportWithTracingEnabled=this.traceTransports.filter(transport=>transport.isTracingEnabled());for(const transport of transportWithTracingEnabled){if(transport.hasWriteBuffer()){yield this.offlineManager.writeSpan(span,transport);}else {const transportId=transport.getTransportId();const runResult=yield this.circuitBreakerRunner.run(transportId,()=>transport.write(span));if(runResult!==0){yield this.offlineManager.writeSpan(span,transport);}}}});}setSchedulerTimerInterval(timerInterval){this.taskScheduler.setTimerInterval(timerInterval);}setAggregateSpansStatus(value){this.offlineManager.setAggregateSpansStatus(value);}}var Visibility;(function(Visibility){Visibility[Visibility["Internal"]=0]="Internal";Visibility[Visibility["External"]=1]="External";Visibility[Visibility["Client"]=2]="Client";})(Visibility||(Visibility={}));var Visibility$1=_exports.Visibility=Visibility;/** Detect free variable `global` from Node.js. */var freeGlobal$1=typeof commonjsGlobal$1=='object'&&commonjsGlobal$1&&commonjsGlobal$1.Object===Object&&commonjsGlobal$1;var _freeGlobal=freeGlobal$1;var freeGlobal=_freeGlobal;/** Detect free variable `self`. */var freeSelf=typeof self=='object'&&self&&self.Object===Object&&self;/** Used as a reference to the global object. */var root$8=freeGlobal||freeSelf||Function('return this')();var _root=root$8;var root$7=_root;/** Built-in value references. */var Symbol$5=root$7.Symbol;var _Symbol=Symbol$5;var Symbol$4=_Symbol;/** Used for built-in method references. */var objectProto$d=Object.prototype;/** Used to check objects for own properties. */var hasOwnProperty$a=objectProto$d.hasOwnProperty;/**
    	 * Used to resolve the
    	 * [`toStringTag`](http://ecma-international.org/ecma-262/7.0/#sec-object.prototype.tostring)
    	 * of values.
    	 */var nativeObjectToString$1=objectProto$d.toString;/** Built-in value references. */var symToStringTag$1=Symbol$4?Symbol$4.toStringTag:undefined;/**
    	 * A specialized version of `baseGetTag` which ignores `Symbol.toStringTag` values.
    	 *
    	 * @private
    	 * @param {*} value The value to query.
    	 * @returns {string} Returns the raw `toStringTag`.
    	 */function getRawTag$1(value){var isOwn=hasOwnProperty$a.call(value,symToStringTag$1),tag=value[symToStringTag$1];try{value[symToStringTag$1]=undefined;var unmasked=true;}catch(e){}var result=nativeObjectToString$1.call(value);if(unmasked){if(isOwn){value[symToStringTag$1]=tag;}else {delete value[symToStringTag$1];}}return result;}var _getRawTag=getRawTag$1;/** Used for built-in method references. */var objectProto$c=Object.prototype;/**
    	 * Used to resolve the
    	 * [`toStringTag`](http://ecma-international.org/ecma-262/7.0/#sec-object.prototype.tostring)
    	 * of values.
    	 */var nativeObjectToString=objectProto$c.toString;/**
    	 * Converts `value` to a string using `Object.prototype.toString`.
    	 *
    	 * @private
    	 * @param {*} value The value to convert.
    	 * @returns {string} Returns the converted string.
    	 */function objectToString$1(value){return nativeObjectToString.call(value);}var _objectToString=objectToString$1;var Symbol$3=_Symbol,getRawTag=_getRawTag,objectToString=_objectToString;/** `Object#toString` result references. */var nullTag='[object Null]',undefinedTag='[object Undefined]';/** Built-in value references. */var symToStringTag=Symbol$3?Symbol$3.toStringTag:undefined;/**
    	 * The base implementation of `getTag` without fallbacks for buggy environments.
    	 *
    	 * @private
    	 * @param {*} value The value to query.
    	 * @returns {string} Returns the `toStringTag`.
    	 */function baseGetTag$5(value){if(value==null){return value===undefined?undefinedTag:nullTag;}return symToStringTag&&symToStringTag in Object(value)?getRawTag(value):objectToString(value);}var _baseGetTag=baseGetTag$5;/**
    	 * Checks if `value` is the
    	 * [language type](http://www.ecma-international.org/ecma-262/7.0/#sec-ecmascript-language-types)
    	 * of `Object`. (e.g. arrays, functions, objects, regexes, `new Number(0)`, and `new String('')`)
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 0.1.0
    	 * @category Lang
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is an object, else `false`.
    	 * @example
    	 *
    	 * _.isObject({});
    	 * // => true
    	 *
    	 * _.isObject([1, 2, 3]);
    	 * // => true
    	 *
    	 * _.isObject(_.noop);
    	 * // => true
    	 *
    	 * _.isObject(null);
    	 * // => false
    	 */function isObject$5(value){var type=typeof value;return value!=null&&(type=='object'||type=='function');}var isObject_1=isObject$5;var baseGetTag$4=_baseGetTag,isObject$4=isObject_1;/** `Object#toString` result references. */var asyncTag='[object AsyncFunction]',funcTag$1='[object Function]',genTag='[object GeneratorFunction]',proxyTag='[object Proxy]';/**
    	 * Checks if `value` is classified as a `Function` object.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 0.1.0
    	 * @category Lang
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is a function, else `false`.
    	 * @example
    	 *
    	 * _.isFunction(_);
    	 * // => true
    	 *
    	 * _.isFunction(/abc/);
    	 * // => false
    	 */function isFunction$3(value){if(!isObject$4(value)){return false;}// The use of `Object#toString` avoids issues with the `typeof` operator
    	// in Safari 9 which returns 'object' for typed arrays and other constructors.
    	var tag=baseGetTag$4(value);return tag==funcTag$1||tag==genTag||tag==asyncTag||tag==proxyTag;}var isFunction_1=isFunction$3;var root$6=_root;/** Used to detect overreaching core-js shims. */var coreJsData$1=root$6['__core-js_shared__'];var _coreJsData=coreJsData$1;var coreJsData=_coreJsData;/** Used to detect methods masquerading as native. */var maskSrcKey=function(){var uid=/[^.]+$/.exec(coreJsData&&coreJsData.keys&&coreJsData.keys.IE_PROTO||'');return uid?'Symbol(src)_1.'+uid:'';}();/**
    	 * Checks if `func` has its source masked.
    	 *
    	 * @private
    	 * @param {Function} func The function to check.
    	 * @returns {boolean} Returns `true` if `func` is masked, else `false`.
    	 */function isMasked$1(func){return !!maskSrcKey&&maskSrcKey in func;}var _isMasked=isMasked$1;/** Used for built-in method references. */var funcProto$1=Function.prototype;/** Used to resolve the decompiled source of functions. */var funcToString$1=funcProto$1.toString;/**
    	 * Converts `func` to its source code.
    	 *
    	 * @private
    	 * @param {Function} func The function to convert.
    	 * @returns {string} Returns the source code.
    	 */function toSource$2(func){if(func!=null){try{return funcToString$1.call(func);}catch(e){}try{return func+'';}catch(e){}}return '';}var _toSource=toSource$2;var isFunction$2=isFunction_1,isMasked=_isMasked,isObject$3=isObject_1,toSource$1=_toSource;/**
    	 * Used to match `RegExp`
    	 * [syntax characters](http://ecma-international.org/ecma-262/7.0/#sec-patterns).
    	 */var reRegExpChar=/[\\^$.*+?()[\]{}|]/g;/** Used to detect host constructors (Safari). */var reIsHostCtor=/^\[object .+?Constructor\]$/;/** Used for built-in method references. */var funcProto=Function.prototype,objectProto$b=Object.prototype;/** Used to resolve the decompiled source of functions. */var funcToString=funcProto.toString;/** Used to check objects for own properties. */var hasOwnProperty$9=objectProto$b.hasOwnProperty;/** Used to detect if a method is native. */var reIsNative=RegExp('^'+funcToString.call(hasOwnProperty$9).replace(reRegExpChar,'\\$&').replace(/hasOwnProperty|(function).*?(?=\\\()| for .+?(?=\\\])/g,'$1.*?')+'$');/**
    	 * The base implementation of `_.isNative` without bad shim checks.
    	 *
    	 * @private
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is a native function,
    	 *  else `false`.
    	 */function baseIsNative$1(value){if(!isObject$3(value)||isMasked(value)){return false;}var pattern=isFunction$2(value)?reIsNative:reIsHostCtor;return pattern.test(toSource$1(value));}var _baseIsNative=baseIsNative$1;/**
    	 * Gets the value at `key` of `object`.
    	 *
    	 * @private
    	 * @param {Object} [object] The object to query.
    	 * @param {string} key The key of the property to get.
    	 * @returns {*} Returns the property value.
    	 */function getValue$1(object,key){return object==null?undefined:object[key];}var _getValue=getValue$1;var baseIsNative=_baseIsNative,getValue=_getValue;/**
    	 * Gets the native function at `key` of `object`.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @param {string} key The key of the method to get.
    	 * @returns {*} Returns the function if it's native, else `undefined`.
    	 */function getNative$7(object,key){var value=getValue(object,key);return baseIsNative(value)?value:undefined;}var _getNative=getNative$7;var getNative$6=_getNative;var defineProperty$2=function(){try{var func=getNative$6(Object,'defineProperty');func({},'',{});return func;}catch(e){}}();var _defineProperty=defineProperty$2;var defineProperty$1=_defineProperty;/**
    	 * The base implementation of `assignValue` and `assignMergeValue` without
    	 * value checks.
    	 *
    	 * @private
    	 * @param {Object} object The object to modify.
    	 * @param {string} key The key of the property to assign.
    	 * @param {*} value The value to assign.
    	 */function baseAssignValue$2(object,key,value){if(key=='__proto__'&&defineProperty$1){defineProperty$1(object,key,{'configurable':true,'enumerable':true,'value':value,'writable':true});}else {object[key]=value;}}var _baseAssignValue=baseAssignValue$2;/**
    	 * Creates a base function for methods like `_.forIn` and `_.forOwn`.
    	 *
    	 * @private
    	 * @param {boolean} [fromRight] Specify iterating from right to left.
    	 * @returns {Function} Returns the new base function.
    	 */function createBaseFor$1(fromRight){return function(object,iteratee,keysFunc){var index=-1,iterable=Object(object),props=keysFunc(object),length=props.length;while(length--){var key=props[fromRight?length:++index];if(iteratee(iterable[key],key,iterable)===false){break;}}return object;};}var _createBaseFor=createBaseFor$1;var createBaseFor=_createBaseFor;/**
    	 * The base implementation of `baseForOwn` which iterates over `object`
    	 * properties returned by `keysFunc` and invokes `iteratee` for each property.
    	 * Iteratee functions may exit iteration early by explicitly returning `false`.
    	 *
    	 * @private
    	 * @param {Object} object The object to iterate over.
    	 * @param {Function} iteratee The function invoked per iteration.
    	 * @param {Function} keysFunc The function to get the keys of `object`.
    	 * @returns {Object} Returns `object`.
    	 */var baseFor$1=createBaseFor();var _baseFor=baseFor$1;/**
    	 * The base implementation of `_.times` without support for iteratee shorthands
    	 * or max array length checks.
    	 *
    	 * @private
    	 * @param {number} n The number of times to invoke `iteratee`.
    	 * @param {Function} iteratee The function invoked per iteration.
    	 * @returns {Array} Returns the array of results.
    	 */function baseTimes$1(n,iteratee){var index=-1,result=Array(n);while(++index<n){result[index]=iteratee(index);}return result;}var _baseTimes=baseTimes$1;/**
    	 * Checks if `value` is object-like. A value is object-like if it's not `null`
    	 * and has a `typeof` result of "object".
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 4.0.0
    	 * @category Lang
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is object-like, else `false`.
    	 * @example
    	 *
    	 * _.isObjectLike({});
    	 * // => true
    	 *
    	 * _.isObjectLike([1, 2, 3]);
    	 * // => true
    	 *
    	 * _.isObjectLike(_.noop);
    	 * // => false
    	 *
    	 * _.isObjectLike(null);
    	 * // => false
    	 */function isObjectLike$5(value){return value!=null&&typeof value=='object';}var isObjectLike_1=isObjectLike$5;var baseGetTag$3=_baseGetTag,isObjectLike$4=isObjectLike_1;/** `Object#toString` result references. */var argsTag$2='[object Arguments]';/**
    	 * The base implementation of `_.isArguments`.
    	 *
    	 * @private
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is an `arguments` object,
    	 */function baseIsArguments$1(value){return isObjectLike$4(value)&&baseGetTag$3(value)==argsTag$2;}var _baseIsArguments=baseIsArguments$1;var baseIsArguments=_baseIsArguments,isObjectLike$3=isObjectLike_1;/** Used for built-in method references. */var objectProto$a=Object.prototype;/** Used to check objects for own properties. */var hasOwnProperty$8=objectProto$a.hasOwnProperty;/** Built-in value references. */var propertyIsEnumerable$1=objectProto$a.propertyIsEnumerable;/**
    	 * Checks if `value` is likely an `arguments` object.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 0.1.0
    	 * @category Lang
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is an `arguments` object,
    	 *  else `false`.
    	 * @example
    	 *
    	 * _.isArguments(function() { return arguments; }());
    	 * // => true
    	 *
    	 * _.isArguments([1, 2, 3]);
    	 * // => false
    	 */var isArguments$2=baseIsArguments(function(){return arguments;}())?baseIsArguments:function(value){return isObjectLike$3(value)&&hasOwnProperty$8.call(value,'callee')&&!propertyIsEnumerable$1.call(value,'callee');};var isArguments_1=isArguments$2;/**
    	 * Checks if `value` is classified as an `Array` object.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 0.1.0
    	 * @category Lang
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is an array, else `false`.
    	 * @example
    	 *
    	 * _.isArray([1, 2, 3]);
    	 * // => true
    	 *
    	 * _.isArray(document.body.children);
    	 * // => false
    	 *
    	 * _.isArray('abc');
    	 * // => false
    	 *
    	 * _.isArray(_.noop);
    	 * // => false
    	 */var isArray$8=Array.isArray;var isArray_1=isArray$8;var isBuffer$2={exports:{}};/**
    	 * This method returns `false`.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 4.13.0
    	 * @category Util
    	 * @returns {boolean} Returns `false`.
    	 * @example
    	 *
    	 * _.times(2, _.stubFalse);
    	 * // => [false, false]
    	 */function stubFalse(){return false;}var stubFalse_1=stubFalse;isBuffer$2.exports;(function(module,exports){var root=_root,stubFalse=stubFalse_1;/** Detect free variable `exports`. */var freeExports=exports&&!exports.nodeType&&exports;/** Detect free variable `module`. */var freeModule=freeExports&&'object'=='object'&&module&&!module.nodeType&&module;/** Detect the popular CommonJS extension `module.exports`. */var moduleExports=freeModule&&freeModule.exports===freeExports;/** Built-in value references. */var Buffer=moduleExports?root.Buffer:undefined;/* Built-in method references for those with the same name as other `lodash` methods. */var nativeIsBuffer=Buffer?Buffer.isBuffer:undefined;/**
    		 * Checks if `value` is a buffer.
    		 *
    		 * @static
    		 * @memberOf _
    		 * @since 4.3.0
    		 * @category Lang
    		 * @param {*} value The value to check.
    		 * @returns {boolean} Returns `true` if `value` is a buffer, else `false`.
    		 * @example
    		 *
    		 * _.isBuffer(new Buffer(2));
    		 * // => true
    		 *
    		 * _.isBuffer(new Uint8Array(2));
    		 * // => false
    		 */var isBuffer=nativeIsBuffer||stubFalse;module.exports=isBuffer;})(isBuffer$2,isBuffer$2.exports);var isBufferExports=isBuffer$2.exports;/** Used as references for various `Number` constants. */var MAX_SAFE_INTEGER$1=9007199254740991;/** Used to detect unsigned integer values. */var reIsUint=/^(?:0|[1-9]\d*)$/;/**
    	 * Checks if `value` is a valid array-like index.
    	 *
    	 * @private
    	 * @param {*} value The value to check.
    	 * @param {number} [length=MAX_SAFE_INTEGER] The upper bounds of a valid index.
    	 * @returns {boolean} Returns `true` if `value` is a valid index, else `false`.
    	 */function isIndex$3(value,length){var type=typeof value;length=length==null?MAX_SAFE_INTEGER$1:length;return !!length&&(type=='number'||type!='symbol'&&reIsUint.test(value))&&value>-1&&value%1==0&&value<length;}var _isIndex=isIndex$3;/** Used as references for various `Number` constants. */var MAX_SAFE_INTEGER=9007199254740991;/**
    	 * Checks if `value` is a valid array-like length.
    	 *
    	 * **Note:** This method is loosely based on
    	 * [`ToLength`](http://ecma-international.org/ecma-262/7.0/#sec-tolength).
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 4.0.0
    	 * @category Lang
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is a valid length, else `false`.
    	 * @example
    	 *
    	 * _.isLength(3);
    	 * // => true
    	 *
    	 * _.isLength(Number.MIN_VALUE);
    	 * // => false
    	 *
    	 * _.isLength(Infinity);
    	 * // => false
    	 *
    	 * _.isLength('3');
    	 * // => false
    	 */function isLength$3(value){return typeof value=='number'&&value>-1&&value%1==0&&value<=MAX_SAFE_INTEGER;}var isLength_1=isLength$3;var baseGetTag$2=_baseGetTag,isLength$2=isLength_1,isObjectLike$2=isObjectLike_1;/** `Object#toString` result references. */var argsTag$1='[object Arguments]',arrayTag$1='[object Array]',boolTag$1='[object Boolean]',dateTag$1='[object Date]',errorTag$1='[object Error]',funcTag='[object Function]',mapTag$2='[object Map]',numberTag$1='[object Number]',objectTag$2='[object Object]',regexpTag$1='[object RegExp]',setTag$2='[object Set]',stringTag$1='[object String]',weakMapTag$1='[object WeakMap]';var arrayBufferTag$1='[object ArrayBuffer]',dataViewTag$2='[object DataView]',float32Tag='[object Float32Array]',float64Tag='[object Float64Array]',int8Tag='[object Int8Array]',int16Tag='[object Int16Array]',int32Tag='[object Int32Array]',uint8Tag='[object Uint8Array]',uint8ClampedTag='[object Uint8ClampedArray]',uint16Tag='[object Uint16Array]',uint32Tag='[object Uint32Array]';/** Used to identify `toStringTag` values of typed arrays. */var typedArrayTags={};typedArrayTags[float32Tag]=typedArrayTags[float64Tag]=typedArrayTags[int8Tag]=typedArrayTags[int16Tag]=typedArrayTags[int32Tag]=typedArrayTags[uint8Tag]=typedArrayTags[uint8ClampedTag]=typedArrayTags[uint16Tag]=typedArrayTags[uint32Tag]=true;typedArrayTags[argsTag$1]=typedArrayTags[arrayTag$1]=typedArrayTags[arrayBufferTag$1]=typedArrayTags[boolTag$1]=typedArrayTags[dataViewTag$2]=typedArrayTags[dateTag$1]=typedArrayTags[errorTag$1]=typedArrayTags[funcTag]=typedArrayTags[mapTag$2]=typedArrayTags[numberTag$1]=typedArrayTags[objectTag$2]=typedArrayTags[regexpTag$1]=typedArrayTags[setTag$2]=typedArrayTags[stringTag$1]=typedArrayTags[weakMapTag$1]=false;/**
    	 * The base implementation of `_.isTypedArray` without Node.js optimizations.
    	 *
    	 * @private
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is a typed array, else `false`.
    	 */function baseIsTypedArray$1(value){return isObjectLike$2(value)&&isLength$2(value.length)&&!!typedArrayTags[baseGetTag$2(value)];}var _baseIsTypedArray=baseIsTypedArray$1;/**
    	 * The base implementation of `_.unary` without support for storing metadata.
    	 *
    	 * @private
    	 * @param {Function} func The function to cap arguments for.
    	 * @returns {Function} Returns the new capped function.
    	 */function baseUnary$1(func){return function(value){return func(value);};}var _baseUnary=baseUnary$1;var _nodeUtil={exports:{}};_nodeUtil.exports;(function(module,exports){var freeGlobal=_freeGlobal;/** Detect free variable `exports`. */var freeExports=exports&&!exports.nodeType&&exports;/** Detect free variable `module`. */var freeModule=freeExports&&'object'=='object'&&module&&!module.nodeType&&module;/** Detect the popular CommonJS extension `module.exports`. */var moduleExports=freeModule&&freeModule.exports===freeExports;/** Detect free variable `process` from Node.js. */var freeProcess=moduleExports&&freeGlobal.process;/** Used to access faster Node.js helpers. */var nodeUtil=function(){try{// Use `util.types` for Node.js 10+.
    	var types=freeModule&&freeModule.require&&freeModule.require('util').types;if(types){return types;}// Legacy `process.binding('util')` for Node.js < 10.
    	return freeProcess&&freeProcess.binding&&freeProcess.binding('util');}catch(e){}}();module.exports=nodeUtil;})(_nodeUtil,_nodeUtil.exports);var _nodeUtilExports=_nodeUtil.exports;var baseIsTypedArray=_baseIsTypedArray,baseUnary=_baseUnary,nodeUtil=_nodeUtilExports;/* Node.js helper references. */var nodeIsTypedArray=nodeUtil&&nodeUtil.isTypedArray;/**
    	 * Checks if `value` is classified as a typed array.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 3.0.0
    	 * @category Lang
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is a typed array, else `false`.
    	 * @example
    	 *
    	 * _.isTypedArray(new Uint8Array);
    	 * // => true
    	 *
    	 * _.isTypedArray([]);
    	 * // => false
    	 */var isTypedArray$2=nodeIsTypedArray?baseUnary(nodeIsTypedArray):baseIsTypedArray;var isTypedArray_1=isTypedArray$2;var baseTimes=_baseTimes,isArguments$1=isArguments_1,isArray$7=isArray_1,isBuffer$1=isBufferExports,isIndex$2=_isIndex,isTypedArray$1=isTypedArray_1;/** Used for built-in method references. */var objectProto$9=Object.prototype;/** Used to check objects for own properties. */var hasOwnProperty$7=objectProto$9.hasOwnProperty;/**
    	 * Creates an array of the enumerable property names of the array-like `value`.
    	 *
    	 * @private
    	 * @param {*} value The value to query.
    	 * @param {boolean} inherited Specify returning inherited property names.
    	 * @returns {Array} Returns the array of property names.
    	 */function arrayLikeKeys$2(value,inherited){var isArr=isArray$7(value),isArg=!isArr&&isArguments$1(value),isBuff=!isArr&&!isArg&&isBuffer$1(value),isType=!isArr&&!isArg&&!isBuff&&isTypedArray$1(value),skipIndexes=isArr||isArg||isBuff||isType,result=skipIndexes?baseTimes(value.length,String):[],length=result.length;for(var key in value){if((inherited||hasOwnProperty$7.call(value,key))&&!(skipIndexes&&(// Safari 9 has enumerable `arguments.length` in strict mode.
    	key=='length'||// Node.js 0.10 has enumerable non-index properties on buffers.
    	isBuff&&(key=='offset'||key=='parent')||// PhantomJS 2 has enumerable non-index properties on typed arrays.
    	isType&&(key=='buffer'||key=='byteLength'||key=='byteOffset')||// Skip index properties.
    	isIndex$2(key,length)))){result.push(key);}}return result;}var _arrayLikeKeys=arrayLikeKeys$2;/** Used for built-in method references. */var objectProto$8=Object.prototype;/**
    	 * Checks if `value` is likely a prototype object.
    	 *
    	 * @private
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is a prototype, else `false`.
    	 */function isPrototype$2(value){var Ctor=value&&value.constructor,proto=typeof Ctor=='function'&&Ctor.prototype||objectProto$8;return value===proto;}var _isPrototype=isPrototype$2;/**
    	 * Creates a unary function that invokes `func` with its argument transformed.
    	 *
    	 * @private
    	 * @param {Function} func The function to wrap.
    	 * @param {Function} transform The argument transform.
    	 * @returns {Function} Returns the new function.
    	 */function overArg$2(func,transform){return function(arg){return func(transform(arg));};}var _overArg=overArg$2;var overArg$1=_overArg;/* Built-in method references for those with the same name as other `lodash` methods. */var nativeKeys$1=overArg$1(Object.keys,Object);var _nativeKeys=nativeKeys$1;var isPrototype$1=_isPrototype,nativeKeys=_nativeKeys;/** Used for built-in method references. */var objectProto$7=Object.prototype;/** Used to check objects for own properties. */var hasOwnProperty$6=objectProto$7.hasOwnProperty;/**
    	 * The base implementation of `_.keys` which doesn't treat sparse arrays as dense.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @returns {Array} Returns the array of property names.
    	 */function baseKeys$1(object){if(!isPrototype$1(object)){return nativeKeys(object);}var result=[];for(var key in Object(object)){if(hasOwnProperty$6.call(object,key)&&key!='constructor'){result.push(key);}}return result;}var _baseKeys=baseKeys$1;var isFunction$1=isFunction_1,isLength$1=isLength_1;/**
    	 * Checks if `value` is array-like. A value is considered array-like if it's
    	 * not a function and has a `value.length` that's an integer greater than or
    	 * equal to `0` and less than or equal to `Number.MAX_SAFE_INTEGER`.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 4.0.0
    	 * @category Lang
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is array-like, else `false`.
    	 * @example
    	 *
    	 * _.isArrayLike([1, 2, 3]);
    	 * // => true
    	 *
    	 * _.isArrayLike(document.body.children);
    	 * // => true
    	 *
    	 * _.isArrayLike('abc');
    	 * // => true
    	 *
    	 * _.isArrayLike(_.noop);
    	 * // => false
    	 */function isArrayLike$2(value){return value!=null&&isLength$1(value.length)&&!isFunction$1(value);}var isArrayLike_1=isArrayLike$2;var arrayLikeKeys$1=_arrayLikeKeys,baseKeys=_baseKeys,isArrayLike$1=isArrayLike_1;/**
    	 * Creates an array of the own enumerable property names of `object`.
    	 *
    	 * **Note:** Non-object values are coerced to objects. See the
    	 * [ES spec](http://ecma-international.org/ecma-262/7.0/#sec-object.keys)
    	 * for more details.
    	 *
    	 * @static
    	 * @since 0.1.0
    	 * @memberOf _
    	 * @category Object
    	 * @param {Object} object The object to query.
    	 * @returns {Array} Returns the array of property names.
    	 * @example
    	 *
    	 * function Foo() {
    	 *   this.a = 1;
    	 *   this.b = 2;
    	 * }
    	 *
    	 * Foo.prototype.c = 3;
    	 *
    	 * _.keys(new Foo);
    	 * // => ['a', 'b'] (iteration order is not guaranteed)
    	 *
    	 * _.keys('hi');
    	 * // => ['0', '1']
    	 */function keys$3(object){return isArrayLike$1(object)?arrayLikeKeys$1(object):baseKeys(object);}var keys_1=keys$3;var baseFor=_baseFor,keys$2=keys_1;/**
    	 * The base implementation of `_.forOwn` without support for iteratee shorthands.
    	 *
    	 * @private
    	 * @param {Object} object The object to iterate over.
    	 * @param {Function} iteratee The function invoked per iteration.
    	 * @returns {Object} Returns `object`.
    	 */function baseForOwn$1(object,iteratee){return object&&baseFor(object,iteratee,keys$2);}var _baseForOwn=baseForOwn$1;/**
    	 * Removes all key-value entries from the list cache.
    	 *
    	 * @private
    	 * @name clear
    	 * @memberOf ListCache
    	 */function listCacheClear$1(){this.__data__=[];this.size=0;}var _listCacheClear=listCacheClear$1;/**
    	 * Performs a
    	 * [`SameValueZero`](http://ecma-international.org/ecma-262/7.0/#sec-samevaluezero)
    	 * comparison between two values to determine if they are equivalent.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 4.0.0
    	 * @category Lang
    	 * @param {*} value The value to compare.
    	 * @param {*} other The other value to compare.
    	 * @returns {boolean} Returns `true` if the values are equivalent, else `false`.
    	 * @example
    	 *
    	 * var object = { 'a': 1 };
    	 * var other = { 'a': 1 };
    	 *
    	 * _.eq(object, object);
    	 * // => true
    	 *
    	 * _.eq(object, other);
    	 * // => false
    	 *
    	 * _.eq('a', 'a');
    	 * // => true
    	 *
    	 * _.eq('a', Object('a'));
    	 * // => false
    	 *
    	 * _.eq(NaN, NaN);
    	 * // => true
    	 */function eq$3(value,other){return value===other||value!==value&&other!==other;}var eq_1=eq$3;var eq$2=eq_1;/**
    	 * Gets the index at which the `key` is found in `array` of key-value pairs.
    	 *
    	 * @private
    	 * @param {Array} array The array to inspect.
    	 * @param {*} key The key to search for.
    	 * @returns {number} Returns the index of the matched value, else `-1`.
    	 */function assocIndexOf$4(array,key){var length=array.length;while(length--){if(eq$2(array[length][0],key)){return length;}}return  -1;}var _assocIndexOf=assocIndexOf$4;var assocIndexOf$3=_assocIndexOf;/** Used for built-in method references. */var arrayProto=Array.prototype;/** Built-in value references. */var splice=arrayProto.splice;/**
    	 * Removes `key` and its value from the list cache.
    	 *
    	 * @private
    	 * @name delete
    	 * @memberOf ListCache
    	 * @param {string} key The key of the value to remove.
    	 * @returns {boolean} Returns `true` if the entry was removed, else `false`.
    	 */function listCacheDelete$1(key){var data=this.__data__,index=assocIndexOf$3(data,key);if(index<0){return false;}var lastIndex=data.length-1;if(index==lastIndex){data.pop();}else {splice.call(data,index,1);}--this.size;return true;}var _listCacheDelete=listCacheDelete$1;var assocIndexOf$2=_assocIndexOf;/**
    	 * Gets the list cache value for `key`.
    	 *
    	 * @private
    	 * @name get
    	 * @memberOf ListCache
    	 * @param {string} key The key of the value to get.
    	 * @returns {*} Returns the entry value.
    	 */function listCacheGet$1(key){var data=this.__data__,index=assocIndexOf$2(data,key);return index<0?undefined:data[index][1];}var _listCacheGet=listCacheGet$1;var assocIndexOf$1=_assocIndexOf;/**
    	 * Checks if a list cache value for `key` exists.
    	 *
    	 * @private
    	 * @name has
    	 * @memberOf ListCache
    	 * @param {string} key The key of the entry to check.
    	 * @returns {boolean} Returns `true` if an entry for `key` exists, else `false`.
    	 */function listCacheHas$1(key){return assocIndexOf$1(this.__data__,key)>-1;}var _listCacheHas=listCacheHas$1;var assocIndexOf=_assocIndexOf;/**
    	 * Sets the list cache `key` to `value`.
    	 *
    	 * @private
    	 * @name set
    	 * @memberOf ListCache
    	 * @param {string} key The key of the value to set.
    	 * @param {*} value The value to set.
    	 * @returns {Object} Returns the list cache instance.
    	 */function listCacheSet$1(key,value){var data=this.__data__,index=assocIndexOf(data,key);if(index<0){++this.size;data.push([key,value]);}else {data[index][1]=value;}return this;}var _listCacheSet=listCacheSet$1;var listCacheClear=_listCacheClear,listCacheDelete=_listCacheDelete,listCacheGet=_listCacheGet,listCacheHas=_listCacheHas,listCacheSet=_listCacheSet;/**
    	 * Creates an list cache object.
    	 *
    	 * @private
    	 * @constructor
    	 * @param {Array} [entries] The key-value pairs to cache.
    	 */function ListCache$4(entries){var index=-1,length=entries==null?0:entries.length;this.clear();while(++index<length){var entry=entries[index];this.set(entry[0],entry[1]);}}// Add methods to `ListCache`.
    	ListCache$4.prototype.clear=listCacheClear;ListCache$4.prototype['delete']=listCacheDelete;ListCache$4.prototype.get=listCacheGet;ListCache$4.prototype.has=listCacheHas;ListCache$4.prototype.set=listCacheSet;var _ListCache=ListCache$4;var ListCache$3=_ListCache;/**
    	 * Removes all key-value entries from the stack.
    	 *
    	 * @private
    	 * @name clear
    	 * @memberOf Stack
    	 */function stackClear$1(){this.__data__=new ListCache$3();this.size=0;}var _stackClear=stackClear$1;/**
    	 * Removes `key` and its value from the stack.
    	 *
    	 * @private
    	 * @name delete
    	 * @memberOf Stack
    	 * @param {string} key The key of the value to remove.
    	 * @returns {boolean} Returns `true` if the entry was removed, else `false`.
    	 */function stackDelete$1(key){var data=this.__data__,result=data['delete'](key);this.size=data.size;return result;}var _stackDelete=stackDelete$1;/**
    	 * Gets the stack value for `key`.
    	 *
    	 * @private
    	 * @name get
    	 * @memberOf Stack
    	 * @param {string} key The key of the value to get.
    	 * @returns {*} Returns the entry value.
    	 */function stackGet$1(key){return this.__data__.get(key);}var _stackGet=stackGet$1;/**
    	 * Checks if a stack value for `key` exists.
    	 *
    	 * @private
    	 * @name has
    	 * @memberOf Stack
    	 * @param {string} key The key of the entry to check.
    	 * @returns {boolean} Returns `true` if an entry for `key` exists, else `false`.
    	 */function stackHas$1(key){return this.__data__.has(key);}var _stackHas=stackHas$1;var getNative$5=_getNative,root$5=_root;/* Built-in method references that are verified to be native. */var Map$4=getNative$5(root$5,'Map');var _Map=Map$4;var getNative$4=_getNative;/* Built-in method references that are verified to be native. */var nativeCreate$4=getNative$4(Object,'create');var _nativeCreate=nativeCreate$4;var nativeCreate$3=_nativeCreate;/**
    	 * Removes all key-value entries from the hash.
    	 *
    	 * @private
    	 * @name clear
    	 * @memberOf Hash
    	 */function hashClear$1(){this.__data__=nativeCreate$3?nativeCreate$3(null):{};this.size=0;}var _hashClear=hashClear$1;/**
    	 * Removes `key` and its value from the hash.
    	 *
    	 * @private
    	 * @name delete
    	 * @memberOf Hash
    	 * @param {Object} hash The hash to modify.
    	 * @param {string} key The key of the value to remove.
    	 * @returns {boolean} Returns `true` if the entry was removed, else `false`.
    	 */function hashDelete$1(key){var result=this.has(key)&&delete this.__data__[key];this.size-=result?1:0;return result;}var _hashDelete=hashDelete$1;var nativeCreate$2=_nativeCreate;/** Used to stand-in for `undefined` hash values. */var HASH_UNDEFINED$2='__lodash_hash_undefined__';/** Used for built-in method references. */var objectProto$6=Object.prototype;/** Used to check objects for own properties. */var hasOwnProperty$5=objectProto$6.hasOwnProperty;/**
    	 * Gets the hash value for `key`.
    	 *
    	 * @private
    	 * @name get
    	 * @memberOf Hash
    	 * @param {string} key The key of the value to get.
    	 * @returns {*} Returns the entry value.
    	 */function hashGet$1(key){var data=this.__data__;if(nativeCreate$2){var result=data[key];return result===HASH_UNDEFINED$2?undefined:result;}return hasOwnProperty$5.call(data,key)?data[key]:undefined;}var _hashGet=hashGet$1;var nativeCreate$1=_nativeCreate;/** Used for built-in method references. */var objectProto$5=Object.prototype;/** Used to check objects for own properties. */var hasOwnProperty$4=objectProto$5.hasOwnProperty;/**
    	 * Checks if a hash value for `key` exists.
    	 *
    	 * @private
    	 * @name has
    	 * @memberOf Hash
    	 * @param {string} key The key of the entry to check.
    	 * @returns {boolean} Returns `true` if an entry for `key` exists, else `false`.
    	 */function hashHas$1(key){var data=this.__data__;return nativeCreate$1?data[key]!==undefined:hasOwnProperty$4.call(data,key);}var _hashHas=hashHas$1;var nativeCreate=_nativeCreate;/** Used to stand-in for `undefined` hash values. */var HASH_UNDEFINED$1='__lodash_hash_undefined__';/**
    	 * Sets the hash `key` to `value`.
    	 *
    	 * @private
    	 * @name set
    	 * @memberOf Hash
    	 * @param {string} key The key of the value to set.
    	 * @param {*} value The value to set.
    	 * @returns {Object} Returns the hash instance.
    	 */function hashSet$1(key,value){var data=this.__data__;this.size+=this.has(key)?0:1;data[key]=nativeCreate&&value===undefined?HASH_UNDEFINED$1:value;return this;}var _hashSet=hashSet$1;var hashClear=_hashClear,hashDelete=_hashDelete,hashGet=_hashGet,hashHas=_hashHas,hashSet=_hashSet;/**
    	 * Creates a hash object.
    	 *
    	 * @private
    	 * @constructor
    	 * @param {Array} [entries] The key-value pairs to cache.
    	 */function Hash$1(entries){var index=-1,length=entries==null?0:entries.length;this.clear();while(++index<length){var entry=entries[index];this.set(entry[0],entry[1]);}}// Add methods to `Hash`.
    	Hash$1.prototype.clear=hashClear;Hash$1.prototype['delete']=hashDelete;Hash$1.prototype.get=hashGet;Hash$1.prototype.has=hashHas;Hash$1.prototype.set=hashSet;var _Hash=Hash$1;var Hash=_Hash,ListCache$2=_ListCache,Map$3=_Map;/**
    	 * Removes all key-value entries from the map.
    	 *
    	 * @private
    	 * @name clear
    	 * @memberOf MapCache
    	 */function mapCacheClear$1(){this.size=0;this.__data__={'hash':new Hash(),'map':new(Map$3||ListCache$2)(),'string':new Hash()};}var _mapCacheClear=mapCacheClear$1;/**
    	 * Checks if `value` is suitable for use as unique object key.
    	 *
    	 * @private
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is suitable, else `false`.
    	 */function isKeyable$1(value){var type=typeof value;return type=='string'||type=='number'||type=='symbol'||type=='boolean'?value!=='__proto__':value===null;}var _isKeyable=isKeyable$1;var isKeyable=_isKeyable;/**
    	 * Gets the data for `map`.
    	 *
    	 * @private
    	 * @param {Object} map The map to query.
    	 * @param {string} key The reference key.
    	 * @returns {*} Returns the map data.
    	 */function getMapData$4(map,key){var data=map.__data__;return isKeyable(key)?data[typeof key=='string'?'string':'hash']:data.map;}var _getMapData=getMapData$4;var getMapData$3=_getMapData;/**
    	 * Removes `key` and its value from the map.
    	 *
    	 * @private
    	 * @name delete
    	 * @memberOf MapCache
    	 * @param {string} key The key of the value to remove.
    	 * @returns {boolean} Returns `true` if the entry was removed, else `false`.
    	 */function mapCacheDelete$1(key){var result=getMapData$3(this,key)['delete'](key);this.size-=result?1:0;return result;}var _mapCacheDelete=mapCacheDelete$1;var getMapData$2=_getMapData;/**
    	 * Gets the map value for `key`.
    	 *
    	 * @private
    	 * @name get
    	 * @memberOf MapCache
    	 * @param {string} key The key of the value to get.
    	 * @returns {*} Returns the entry value.
    	 */function mapCacheGet$1(key){return getMapData$2(this,key).get(key);}var _mapCacheGet=mapCacheGet$1;var getMapData$1=_getMapData;/**
    	 * Checks if a map value for `key` exists.
    	 *
    	 * @private
    	 * @name has
    	 * @memberOf MapCache
    	 * @param {string} key The key of the entry to check.
    	 * @returns {boolean} Returns `true` if an entry for `key` exists, else `false`.
    	 */function mapCacheHas$1(key){return getMapData$1(this,key).has(key);}var _mapCacheHas=mapCacheHas$1;var getMapData=_getMapData;/**
    	 * Sets the map `key` to `value`.
    	 *
    	 * @private
    	 * @name set
    	 * @memberOf MapCache
    	 * @param {string} key The key of the value to set.
    	 * @param {*} value The value to set.
    	 * @returns {Object} Returns the map cache instance.
    	 */function mapCacheSet$1(key,value){var data=getMapData(this,key),size=data.size;data.set(key,value);this.size+=data.size==size?0:1;return this;}var _mapCacheSet=mapCacheSet$1;var mapCacheClear=_mapCacheClear,mapCacheDelete=_mapCacheDelete,mapCacheGet=_mapCacheGet,mapCacheHas=_mapCacheHas,mapCacheSet=_mapCacheSet;/**
    	 * Creates a map cache object to store key-value pairs.
    	 *
    	 * @private
    	 * @constructor
    	 * @param {Array} [entries] The key-value pairs to cache.
    	 */function MapCache$3(entries){var index=-1,length=entries==null?0:entries.length;this.clear();while(++index<length){var entry=entries[index];this.set(entry[0],entry[1]);}}// Add methods to `MapCache`.
    	MapCache$3.prototype.clear=mapCacheClear;MapCache$3.prototype['delete']=mapCacheDelete;MapCache$3.prototype.get=mapCacheGet;MapCache$3.prototype.has=mapCacheHas;MapCache$3.prototype.set=mapCacheSet;var _MapCache=MapCache$3;var ListCache$1=_ListCache,Map$2=_Map,MapCache$2=_MapCache;/** Used as the size to enable large array optimizations. */var LARGE_ARRAY_SIZE=200;/**
    	 * Sets the stack `key` to `value`.
    	 *
    	 * @private
    	 * @name set
    	 * @memberOf Stack
    	 * @param {string} key The key of the value to set.
    	 * @param {*} value The value to set.
    	 * @returns {Object} Returns the stack cache instance.
    	 */function stackSet$1(key,value){var data=this.__data__;if(data instanceof ListCache$1){var pairs=data.__data__;if(!Map$2||pairs.length<LARGE_ARRAY_SIZE-1){pairs.push([key,value]);this.size=++data.size;return this;}data=this.__data__=new MapCache$2(pairs);}data.set(key,value);this.size=data.size;return this;}var _stackSet=stackSet$1;var ListCache=_ListCache,stackClear=_stackClear,stackDelete=_stackDelete,stackGet=_stackGet,stackHas=_stackHas,stackSet=_stackSet;/**
    	 * Creates a stack cache object to store key-value pairs.
    	 *
    	 * @private
    	 * @constructor
    	 * @param {Array} [entries] The key-value pairs to cache.
    	 */function Stack$2(entries){var data=this.__data__=new ListCache(entries);this.size=data.size;}// Add methods to `Stack`.
    	Stack$2.prototype.clear=stackClear;Stack$2.prototype['delete']=stackDelete;Stack$2.prototype.get=stackGet;Stack$2.prototype.has=stackHas;Stack$2.prototype.set=stackSet;var _Stack=Stack$2;/** Used to stand-in for `undefined` hash values. */var HASH_UNDEFINED='__lodash_hash_undefined__';/**
    	 * Adds `value` to the array cache.
    	 *
    	 * @private
    	 * @name add
    	 * @memberOf SetCache
    	 * @alias push
    	 * @param {*} value The value to cache.
    	 * @returns {Object} Returns the cache instance.
    	 */function setCacheAdd$1(value){this.__data__.set(value,HASH_UNDEFINED);return this;}var _setCacheAdd=setCacheAdd$1;/**
    	 * Checks if `value` is in the array cache.
    	 *
    	 * @private
    	 * @name has
    	 * @memberOf SetCache
    	 * @param {*} value The value to search for.
    	 * @returns {number} Returns `true` if `value` is found, else `false`.
    	 */function setCacheHas$1(value){return this.__data__.has(value);}var _setCacheHas=setCacheHas$1;var MapCache$1=_MapCache,setCacheAdd=_setCacheAdd,setCacheHas=_setCacheHas;/**
    	 *
    	 * Creates an array cache object to store unique values.
    	 *
    	 * @private
    	 * @constructor
    	 * @param {Array} [values] The values to cache.
    	 */function SetCache$1(values){var index=-1,length=values==null?0:values.length;this.__data__=new MapCache$1();while(++index<length){this.add(values[index]);}}// Add methods to `SetCache`.
    	SetCache$1.prototype.add=SetCache$1.prototype.push=setCacheAdd;SetCache$1.prototype.has=setCacheHas;var _SetCache=SetCache$1;/**
    	 * A specialized version of `_.some` for arrays without support for iteratee
    	 * shorthands.
    	 *
    	 * @private
    	 * @param {Array} [array] The array to iterate over.
    	 * @param {Function} predicate The function invoked per iteration.
    	 * @returns {boolean} Returns `true` if any element passes the predicate check,
    	 *  else `false`.
    	 */function arraySome$1(array,predicate){var index=-1,length=array==null?0:array.length;while(++index<length){if(predicate(array[index],index,array)){return true;}}return false;}var _arraySome=arraySome$1;/**
    	 * Checks if a `cache` value for `key` exists.
    	 *
    	 * @private
    	 * @param {Object} cache The cache to query.
    	 * @param {string} key The key of the entry to check.
    	 * @returns {boolean} Returns `true` if an entry for `key` exists, else `false`.
    	 */function cacheHas$1(cache,key){return cache.has(key);}var _cacheHas=cacheHas$1;var SetCache=_SetCache,arraySome=_arraySome,cacheHas=_cacheHas;/** Used to compose bitmasks for value comparisons. */var COMPARE_PARTIAL_FLAG$5=1,COMPARE_UNORDERED_FLAG$3=2;/**
    	 * A specialized version of `baseIsEqualDeep` for arrays with support for
    	 * partial deep comparisons.
    	 *
    	 * @private
    	 * @param {Array} array The array to compare.
    	 * @param {Array} other The other array to compare.
    	 * @param {number} bitmask The bitmask flags. See `baseIsEqual` for more details.
    	 * @param {Function} customizer The function to customize comparisons.
    	 * @param {Function} equalFunc The function to determine equivalents of values.
    	 * @param {Object} stack Tracks traversed `array` and `other` objects.
    	 * @returns {boolean} Returns `true` if the arrays are equivalent, else `false`.
    	 */function equalArrays$2(array,other,bitmask,customizer,equalFunc,stack){var isPartial=bitmask&COMPARE_PARTIAL_FLAG$5,arrLength=array.length,othLength=other.length;if(arrLength!=othLength&&!(isPartial&&othLength>arrLength)){return false;}// Check that cyclic values are equal.
    	var arrStacked=stack.get(array);var othStacked=stack.get(other);if(arrStacked&&othStacked){return arrStacked==other&&othStacked==array;}var index=-1,result=true,seen=bitmask&COMPARE_UNORDERED_FLAG$3?new SetCache():undefined;stack.set(array,other);stack.set(other,array);// Ignore non-index properties.
    	while(++index<arrLength){var arrValue=array[index],othValue=other[index];if(customizer){var compared=isPartial?customizer(othValue,arrValue,index,other,array,stack):customizer(arrValue,othValue,index,array,other,stack);}if(compared!==undefined){if(compared){continue;}result=false;break;}// Recursively compare arrays (susceptible to call stack limits).
    	if(seen){if(!arraySome(other,function(othValue,othIndex){if(!cacheHas(seen,othIndex)&&(arrValue===othValue||equalFunc(arrValue,othValue,bitmask,customizer,stack))){return seen.push(othIndex);}})){result=false;break;}}else if(!(arrValue===othValue||equalFunc(arrValue,othValue,bitmask,customizer,stack))){result=false;break;}}stack['delete'](array);stack['delete'](other);return result;}var _equalArrays=equalArrays$2;var root$4=_root;/** Built-in value references. */var Uint8Array$1=root$4.Uint8Array;var _Uint8Array=Uint8Array$1;/**
    	 * Converts `map` to its key-value pairs.
    	 *
    	 * @private
    	 * @param {Object} map The map to convert.
    	 * @returns {Array} Returns the key-value pairs.
    	 */function mapToArray$1(map){var index=-1,result=Array(map.size);map.forEach(function(value,key){result[++index]=[key,value];});return result;}var _mapToArray=mapToArray$1;/**
    	 * Converts `set` to an array of its values.
    	 *
    	 * @private
    	 * @param {Object} set The set to convert.
    	 * @returns {Array} Returns the values.
    	 */function setToArray$1(set){var index=-1,result=Array(set.size);set.forEach(function(value){result[++index]=value;});return result;}var _setToArray=setToArray$1;var Symbol$2=_Symbol,Uint8Array=_Uint8Array,eq$1=eq_1,equalArrays$1=_equalArrays,mapToArray=_mapToArray,setToArray=_setToArray;/** Used to compose bitmasks for value comparisons. */var COMPARE_PARTIAL_FLAG$4=1,COMPARE_UNORDERED_FLAG$2=2;/** `Object#toString` result references. */var boolTag='[object Boolean]',dateTag='[object Date]',errorTag='[object Error]',mapTag$1='[object Map]',numberTag='[object Number]',regexpTag='[object RegExp]',setTag$1='[object Set]',stringTag='[object String]',symbolTag$1='[object Symbol]';var arrayBufferTag='[object ArrayBuffer]',dataViewTag$1='[object DataView]';/** Used to convert symbols to primitives and strings. */var symbolProto$1=Symbol$2?Symbol$2.prototype:undefined,symbolValueOf=symbolProto$1?symbolProto$1.valueOf:undefined;/**
    	 * A specialized version of `baseIsEqualDeep` for comparing objects of
    	 * the same `toStringTag`.
    	 *
    	 * **Note:** This function only supports comparing values with tags of
    	 * `Boolean`, `Date`, `Error`, `Number`, `RegExp`, or `String`.
    	 *
    	 * @private
    	 * @param {Object} object The object to compare.
    	 * @param {Object} other The other object to compare.
    	 * @param {string} tag The `toStringTag` of the objects to compare.
    	 * @param {number} bitmask The bitmask flags. See `baseIsEqual` for more details.
    	 * @param {Function} customizer The function to customize comparisons.
    	 * @param {Function} equalFunc The function to determine equivalents of values.
    	 * @param {Object} stack Tracks traversed `object` and `other` objects.
    	 * @returns {boolean} Returns `true` if the objects are equivalent, else `false`.
    	 */function equalByTag$1(object,other,tag,bitmask,customizer,equalFunc,stack){switch(tag){case dataViewTag$1:if(object.byteLength!=other.byteLength||object.byteOffset!=other.byteOffset){return false;}object=object.buffer;other=other.buffer;case arrayBufferTag:if(object.byteLength!=other.byteLength||!equalFunc(new Uint8Array(object),new Uint8Array(other))){return false;}return true;case boolTag:case dateTag:case numberTag:// Coerce booleans to `1` or `0` and dates to milliseconds.
    	// Invalid dates are coerced to `NaN`.
    	return eq$1(+object,+other);case errorTag:return object.name==other.name&&object.message==other.message;case regexpTag:case stringTag:// Coerce regexes to strings and treat strings, primitives and objects,
    	// as equal. See http://www.ecma-international.org/ecma-262/7.0/#sec-regexp.prototype.tostring
    	// for more details.
    	return object==other+'';case mapTag$1:var convert=mapToArray;case setTag$1:var isPartial=bitmask&COMPARE_PARTIAL_FLAG$4;convert||(convert=setToArray);if(object.size!=other.size&&!isPartial){return false;}// Assume cyclic values are equal.
    	var stacked=stack.get(object);if(stacked){return stacked==other;}bitmask|=COMPARE_UNORDERED_FLAG$2;// Recursively compare objects (susceptible to call stack limits).
    	stack.set(object,other);var result=equalArrays$1(convert(object),convert(other),bitmask,customizer,equalFunc,stack);stack['delete'](object);return result;case symbolTag$1:if(symbolValueOf){return symbolValueOf.call(object)==symbolValueOf.call(other);}}return false;}var _equalByTag=equalByTag$1;/**
    	 * Appends the elements of `values` to `array`.
    	 *
    	 * @private
    	 * @param {Array} array The array to modify.
    	 * @param {Array} values The values to append.
    	 * @returns {Array} Returns `array`.
    	 */function arrayPush$2(array,values){var index=-1,length=values.length,offset=array.length;while(++index<length){array[offset+index]=values[index];}return array;}var _arrayPush=arrayPush$2;var arrayPush$1=_arrayPush,isArray$6=isArray_1;/**
    	 * The base implementation of `getAllKeys` and `getAllKeysIn` which uses
    	 * `keysFunc` and `symbolsFunc` to get the enumerable property names and
    	 * symbols of `object`.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @param {Function} keysFunc The function to get the keys of `object`.
    	 * @param {Function} symbolsFunc The function to get the symbols of `object`.
    	 * @returns {Array} Returns the array of property names and symbols.
    	 */function baseGetAllKeys$2(object,keysFunc,symbolsFunc){var result=keysFunc(object);return isArray$6(object)?result:arrayPush$1(result,symbolsFunc(object));}var _baseGetAllKeys=baseGetAllKeys$2;/**
    	 * A specialized version of `_.filter` for arrays without support for
    	 * iteratee shorthands.
    	 *
    	 * @private
    	 * @param {Array} [array] The array to iterate over.
    	 * @param {Function} predicate The function invoked per iteration.
    	 * @returns {Array} Returns the new filtered array.
    	 */function arrayFilter$1(array,predicate){var index=-1,length=array==null?0:array.length,resIndex=0,result=[];while(++index<length){var value=array[index];if(predicate(value,index,array)){result[resIndex++]=value;}}return result;}var _arrayFilter=arrayFilter$1;/**
    	 * This method returns a new empty array.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 4.13.0
    	 * @category Util
    	 * @returns {Array} Returns the new empty array.
    	 * @example
    	 *
    	 * var arrays = _.times(2, _.stubArray);
    	 *
    	 * console.log(arrays);
    	 * // => [[], []]
    	 *
    	 * console.log(arrays[0] === arrays[1]);
    	 * // => false
    	 */function stubArray$2(){return [];}var stubArray_1=stubArray$2;var arrayFilter=_arrayFilter,stubArray$1=stubArray_1;/** Used for built-in method references. */var objectProto$4=Object.prototype;/** Built-in value references. */var propertyIsEnumerable=objectProto$4.propertyIsEnumerable;/* Built-in method references for those with the same name as other `lodash` methods. */var nativeGetSymbols$1=Object.getOwnPropertySymbols;/**
    	 * Creates an array of the own enumerable symbols of `object`.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @returns {Array} Returns the array of symbols.
    	 */var getSymbols$2=!nativeGetSymbols$1?stubArray$1:function(object){if(object==null){return [];}object=Object(object);return arrayFilter(nativeGetSymbols$1(object),function(symbol){return propertyIsEnumerable.call(object,symbol);});};var _getSymbols=getSymbols$2;var baseGetAllKeys$1=_baseGetAllKeys,getSymbols$1=_getSymbols,keys$1=keys_1;/**
    	 * Creates an array of own enumerable property names and symbols of `object`.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @returns {Array} Returns the array of property names and symbols.
    	 */function getAllKeys$1(object){return baseGetAllKeys$1(object,keys$1,getSymbols$1);}var _getAllKeys=getAllKeys$1;var getAllKeys=_getAllKeys;/** Used to compose bitmasks for value comparisons. */var COMPARE_PARTIAL_FLAG$3=1;/** Used for built-in method references. */var objectProto$3=Object.prototype;/** Used to check objects for own properties. */var hasOwnProperty$3=objectProto$3.hasOwnProperty;/**
    	 * A specialized version of `baseIsEqualDeep` for objects with support for
    	 * partial deep comparisons.
    	 *
    	 * @private
    	 * @param {Object} object The object to compare.
    	 * @param {Object} other The other object to compare.
    	 * @param {number} bitmask The bitmask flags. See `baseIsEqual` for more details.
    	 * @param {Function} customizer The function to customize comparisons.
    	 * @param {Function} equalFunc The function to determine equivalents of values.
    	 * @param {Object} stack Tracks traversed `object` and `other` objects.
    	 * @returns {boolean} Returns `true` if the objects are equivalent, else `false`.
    	 */function equalObjects$1(object,other,bitmask,customizer,equalFunc,stack){var isPartial=bitmask&COMPARE_PARTIAL_FLAG$3,objProps=getAllKeys(object),objLength=objProps.length,othProps=getAllKeys(other),othLength=othProps.length;if(objLength!=othLength&&!isPartial){return false;}var index=objLength;while(index--){var key=objProps[index];if(!(isPartial?key in other:hasOwnProperty$3.call(other,key))){return false;}}// Check that cyclic values are equal.
    	var objStacked=stack.get(object);var othStacked=stack.get(other);if(objStacked&&othStacked){return objStacked==other&&othStacked==object;}var result=true;stack.set(object,other);stack.set(other,object);var skipCtor=isPartial;while(++index<objLength){key=objProps[index];var objValue=object[key],othValue=other[key];if(customizer){var compared=isPartial?customizer(othValue,objValue,key,other,object,stack):customizer(objValue,othValue,key,object,other,stack);}// Recursively compare objects (susceptible to call stack limits).
    	if(!(compared===undefined?objValue===othValue||equalFunc(objValue,othValue,bitmask,customizer,stack):compared)){result=false;break;}skipCtor||(skipCtor=key=='constructor');}if(result&&!skipCtor){var objCtor=object.constructor,othCtor=other.constructor;// Non `Object` object instances with different constructors are not equal.
    	if(objCtor!=othCtor&&'constructor'in object&&'constructor'in other&&!(typeof objCtor=='function'&&objCtor instanceof objCtor&&typeof othCtor=='function'&&othCtor instanceof othCtor)){result=false;}}stack['delete'](object);stack['delete'](other);return result;}var _equalObjects=equalObjects$1;var getNative$3=_getNative,root$3=_root;/* Built-in method references that are verified to be native. */var DataView$1=getNative$3(root$3,'DataView');var _DataView=DataView$1;var getNative$2=_getNative,root$2=_root;/* Built-in method references that are verified to be native. */var Promise$2=getNative$2(root$2,'Promise');var _Promise=Promise$2;var getNative$1=_getNative,root$1=_root;/* Built-in method references that are verified to be native. */var Set$2=getNative$1(root$1,'Set');var _Set=Set$2;var getNative=_getNative,root=_root;/* Built-in method references that are verified to be native. */var WeakMap$2=getNative(root,'WeakMap');var _WeakMap=WeakMap$2;var DataView=_DataView,Map$1=_Map,Promise$1=_Promise,Set$1=_Set,WeakMap$1=_WeakMap,baseGetTag$1=_baseGetTag,toSource=_toSource;/** `Object#toString` result references. */var mapTag='[object Map]',objectTag$1='[object Object]',promiseTag='[object Promise]',setTag='[object Set]',weakMapTag='[object WeakMap]';var dataViewTag='[object DataView]';/** Used to detect maps, sets, and weakmaps. */var dataViewCtorString=toSource(DataView),mapCtorString=toSource(Map$1),promiseCtorString=toSource(Promise$1),setCtorString=toSource(Set$1),weakMapCtorString=toSource(WeakMap$1);/**
    	 * Gets the `toStringTag` of `value`.
    	 *
    	 * @private
    	 * @param {*} value The value to query.
    	 * @returns {string} Returns the `toStringTag`.
    	 */var getTag$1=baseGetTag$1;// Fallback for data views, maps, sets, and weak maps in IE 11 and promises in Node.js < 6.
    	if(DataView&&getTag$1(new DataView(new ArrayBuffer(1)))!=dataViewTag||Map$1&&getTag$1(new Map$1())!=mapTag||Promise$1&&getTag$1(Promise$1.resolve())!=promiseTag||Set$1&&getTag$1(new Set$1())!=setTag||WeakMap$1&&getTag$1(new WeakMap$1())!=weakMapTag){getTag$1=function(value){var result=baseGetTag$1(value),Ctor=result==objectTag$1?value.constructor:undefined,ctorString=Ctor?toSource(Ctor):'';if(ctorString){switch(ctorString){case dataViewCtorString:return dataViewTag;case mapCtorString:return mapTag;case promiseCtorString:return promiseTag;case setCtorString:return setTag;case weakMapCtorString:return weakMapTag;}}return result;};}var _getTag=getTag$1;var Stack$1=_Stack,equalArrays=_equalArrays,equalByTag=_equalByTag,equalObjects=_equalObjects,getTag=_getTag,isArray$5=isArray_1,isBuffer=isBufferExports,isTypedArray=isTypedArray_1;/** Used to compose bitmasks for value comparisons. */var COMPARE_PARTIAL_FLAG$2=1;/** `Object#toString` result references. */var argsTag='[object Arguments]',arrayTag='[object Array]',objectTag='[object Object]';/** Used for built-in method references. */var objectProto$2=Object.prototype;/** Used to check objects for own properties. */var hasOwnProperty$2=objectProto$2.hasOwnProperty;/**
    	 * A specialized version of `baseIsEqual` for arrays and objects which performs
    	 * deep comparisons and tracks traversed objects enabling objects with circular
    	 * references to be compared.
    	 *
    	 * @private
    	 * @param {Object} object The object to compare.
    	 * @param {Object} other The other object to compare.
    	 * @param {number} bitmask The bitmask flags. See `baseIsEqual` for more details.
    	 * @param {Function} customizer The function to customize comparisons.
    	 * @param {Function} equalFunc The function to determine equivalents of values.
    	 * @param {Object} [stack] Tracks traversed `object` and `other` objects.
    	 * @returns {boolean} Returns `true` if the objects are equivalent, else `false`.
    	 */function baseIsEqualDeep$1(object,other,bitmask,customizer,equalFunc,stack){var objIsArr=isArray$5(object),othIsArr=isArray$5(other),objTag=objIsArr?arrayTag:getTag(object),othTag=othIsArr?arrayTag:getTag(other);objTag=objTag==argsTag?objectTag:objTag;othTag=othTag==argsTag?objectTag:othTag;var objIsObj=objTag==objectTag,othIsObj=othTag==objectTag,isSameTag=objTag==othTag;if(isSameTag&&isBuffer(object)){if(!isBuffer(other)){return false;}objIsArr=true;objIsObj=false;}if(isSameTag&&!objIsObj){stack||(stack=new Stack$1());return objIsArr||isTypedArray(object)?equalArrays(object,other,bitmask,customizer,equalFunc,stack):equalByTag(object,other,objTag,bitmask,customizer,equalFunc,stack);}if(!(bitmask&COMPARE_PARTIAL_FLAG$2)){var objIsWrapped=objIsObj&&hasOwnProperty$2.call(object,'__wrapped__'),othIsWrapped=othIsObj&&hasOwnProperty$2.call(other,'__wrapped__');if(objIsWrapped||othIsWrapped){var objUnwrapped=objIsWrapped?object.value():object,othUnwrapped=othIsWrapped?other.value():other;stack||(stack=new Stack$1());return equalFunc(objUnwrapped,othUnwrapped,bitmask,customizer,stack);}}if(!isSameTag){return false;}stack||(stack=new Stack$1());return equalObjects(object,other,bitmask,customizer,equalFunc,stack);}var _baseIsEqualDeep=baseIsEqualDeep$1;var baseIsEqualDeep=_baseIsEqualDeep,isObjectLike$1=isObjectLike_1;/**
    	 * The base implementation of `_.isEqual` which supports partial comparisons
    	 * and tracks traversed objects.
    	 *
    	 * @private
    	 * @param {*} value The value to compare.
    	 * @param {*} other The other value to compare.
    	 * @param {boolean} bitmask The bitmask flags.
    	 *  1 - Unordered comparison
    	 *  2 - Partial comparison
    	 * @param {Function} [customizer] The function to customize comparisons.
    	 * @param {Object} [stack] Tracks traversed `value` and `other` objects.
    	 * @returns {boolean} Returns `true` if the values are equivalent, else `false`.
    	 */function baseIsEqual$2(value,other,bitmask,customizer,stack){if(value===other){return true;}if(value==null||other==null||!isObjectLike$1(value)&&!isObjectLike$1(other)){return value!==value&&other!==other;}return baseIsEqualDeep(value,other,bitmask,customizer,baseIsEqual$2,stack);}var _baseIsEqual=baseIsEqual$2;var Stack=_Stack,baseIsEqual$1=_baseIsEqual;/** Used to compose bitmasks for value comparisons. */var COMPARE_PARTIAL_FLAG$1=1,COMPARE_UNORDERED_FLAG$1=2;/**
    	 * The base implementation of `_.isMatch` without support for iteratee shorthands.
    	 *
    	 * @private
    	 * @param {Object} object The object to inspect.
    	 * @param {Object} source The object of property values to match.
    	 * @param {Array} matchData The property names, values, and compare flags to match.
    	 * @param {Function} [customizer] The function to customize comparisons.
    	 * @returns {boolean} Returns `true` if `object` is a match, else `false`.
    	 */function baseIsMatch$1(object,source,matchData,customizer){var index=matchData.length,length=index,noCustomizer=!customizer;if(object==null){return !length;}object=Object(object);while(index--){var data=matchData[index];if(noCustomizer&&data[2]?data[1]!==object[data[0]]:!(data[0]in object)){return false;}}while(++index<length){data=matchData[index];var key=data[0],objValue=object[key],srcValue=data[1];if(noCustomizer&&data[2]){if(objValue===undefined&&!(key in object)){return false;}}else {var stack=new Stack();if(customizer){var result=customizer(objValue,srcValue,key,object,source,stack);}if(!(result===undefined?baseIsEqual$1(srcValue,objValue,COMPARE_PARTIAL_FLAG$1|COMPARE_UNORDERED_FLAG$1,customizer,stack):result)){return false;}}}return true;}var _baseIsMatch=baseIsMatch$1;var isObject$2=isObject_1;/**
    	 * Checks if `value` is suitable for strict equality comparisons, i.e. `===`.
    	 *
    	 * @private
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` if suitable for strict
    	 *  equality comparisons, else `false`.
    	 */function isStrictComparable$2(value){return value===value&&!isObject$2(value);}var _isStrictComparable=isStrictComparable$2;var isStrictComparable$1=_isStrictComparable,keys=keys_1;/**
    	 * Gets the property names, values, and compare flags of `object`.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @returns {Array} Returns the match data of `object`.
    	 */function getMatchData$1(object){var result=keys(object),length=result.length;while(length--){var key=result[length],value=object[key];result[length]=[key,value,isStrictComparable$1(value)];}return result;}var _getMatchData=getMatchData$1;/**
    	 * A specialized version of `matchesProperty` for source values suitable
    	 * for strict equality comparisons, i.e. `===`.
    	 *
    	 * @private
    	 * @param {string} key The key of the property to get.
    	 * @param {*} srcValue The value to match.
    	 * @returns {Function} Returns the new spec function.
    	 */function matchesStrictComparable$2(key,srcValue){return function(object){if(object==null){return false;}return object[key]===srcValue&&(srcValue!==undefined||key in Object(object));};}var _matchesStrictComparable=matchesStrictComparable$2;var baseIsMatch=_baseIsMatch,getMatchData=_getMatchData,matchesStrictComparable$1=_matchesStrictComparable;/**
    	 * The base implementation of `_.matches` which doesn't clone `source`.
    	 *
    	 * @private
    	 * @param {Object} source The object of property values to match.
    	 * @returns {Function} Returns the new spec function.
    	 */function baseMatches$1(source){var matchData=getMatchData(source);if(matchData.length==1&&matchData[0][2]){return matchesStrictComparable$1(matchData[0][0],matchData[0][1]);}return function(object){return object===source||baseIsMatch(object,source,matchData);};}var _baseMatches=baseMatches$1;var baseGetTag=_baseGetTag,isObjectLike=isObjectLike_1;/** `Object#toString` result references. */var symbolTag='[object Symbol]';/**
    	 * Checks if `value` is classified as a `Symbol` primitive or object.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 4.0.0
    	 * @category Lang
    	 * @param {*} value The value to check.
    	 * @returns {boolean} Returns `true` if `value` is a symbol, else `false`.
    	 * @example
    	 *
    	 * _.isSymbol(Symbol.iterator);
    	 * // => true
    	 *
    	 * _.isSymbol('abc');
    	 * // => false
    	 */function isSymbol$3(value){return typeof value=='symbol'||isObjectLike(value)&&baseGetTag(value)==symbolTag;}var isSymbol_1=isSymbol$3;var isArray$4=isArray_1,isSymbol$2=isSymbol_1;/** Used to match property names within property paths. */var reIsDeepProp=/\.|\[(?:[^[\]]*|(["'])(?:(?!\1)[^\\]|\\.)*?\1)\]/,reIsPlainProp=/^\w*$/;/**
    	 * Checks if `value` is a property name and not a property path.
    	 *
    	 * @private
    	 * @param {*} value The value to check.
    	 * @param {Object} [object] The object to query keys on.
    	 * @returns {boolean} Returns `true` if `value` is a property name, else `false`.
    	 */function isKey$3(value,object){if(isArray$4(value)){return false;}var type=typeof value;if(type=='number'||type=='symbol'||type=='boolean'||value==null||isSymbol$2(value)){return true;}return reIsPlainProp.test(value)||!reIsDeepProp.test(value)||object!=null&&value in Object(object);}var _isKey=isKey$3;var MapCache=_MapCache;/** Error message constants. */var FUNC_ERROR_TEXT='Expected a function';/**
    	 * Creates a function that memoizes the result of `func`. If `resolver` is
    	 * provided, it determines the cache key for storing the result based on the
    	 * arguments provided to the memoized function. By default, the first argument
    	 * provided to the memoized function is used as the map cache key. The `func`
    	 * is invoked with the `this` binding of the memoized function.
    	 *
    	 * **Note:** The cache is exposed as the `cache` property on the memoized
    	 * function. Its creation may be customized by replacing the `_.memoize.Cache`
    	 * constructor with one whose instances implement the
    	 * [`Map`](http://ecma-international.org/ecma-262/7.0/#sec-properties-of-the-map-prototype-object)
    	 * method interface of `clear`, `delete`, `get`, `has`, and `set`.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 0.1.0
    	 * @category Function
    	 * @param {Function} func The function to have its output memoized.
    	 * @param {Function} [resolver] The function to resolve the cache key.
    	 * @returns {Function} Returns the new memoized function.
    	 * @example
    	 *
    	 * var object = { 'a': 1, 'b': 2 };
    	 * var other = { 'c': 3, 'd': 4 };
    	 *
    	 * var values = _.memoize(_.values);
    	 * values(object);
    	 * // => [1, 2]
    	 *
    	 * values(other);
    	 * // => [3, 4]
    	 *
    	 * object.a = 2;
    	 * values(object);
    	 * // => [1, 2]
    	 *
    	 * // Modify the result cache.
    	 * values.cache.set(object, ['a', 'b']);
    	 * values(object);
    	 * // => ['a', 'b']
    	 *
    	 * // Replace `_.memoize.Cache`.
    	 * _.memoize.Cache = WeakMap;
    	 */function memoize$1(func,resolver){if(typeof func!='function'||resolver!=null&&typeof resolver!='function'){throw new TypeError(FUNC_ERROR_TEXT);}var memoized=function(){var args=arguments,key=resolver?resolver.apply(this,args):args[0],cache=memoized.cache;if(cache.has(key)){return cache.get(key);}var result=func.apply(this,args);memoized.cache=cache.set(key,result)||cache;return result;};memoized.cache=new(memoize$1.Cache||MapCache)();return memoized;}// Expose `MapCache`.
    	memoize$1.Cache=MapCache;var memoize_1=memoize$1;var memoize=memoize_1;/** Used as the maximum memoize cache size. */var MAX_MEMOIZE_SIZE=500;/**
    	 * A specialized version of `_.memoize` which clears the memoized function's
    	 * cache when it exceeds `MAX_MEMOIZE_SIZE`.
    	 *
    	 * @private
    	 * @param {Function} func The function to have its output memoized.
    	 * @returns {Function} Returns the new memoized function.
    	 */function memoizeCapped$1(func){var result=memoize(func,function(key){if(cache.size===MAX_MEMOIZE_SIZE){cache.clear();}return key;});var cache=result.cache;return result;}var _memoizeCapped=memoizeCapped$1;var memoizeCapped=_memoizeCapped;/** Used to match property names within property paths. */var rePropName=/[^.[\]]+|\[(?:(-?\d+(?:\.\d+)?)|(["'])((?:(?!\2)[^\\]|\\.)*?)\2)\]|(?=(?:\.|\[\])(?:\.|\[\]|$))/g;/** Used to match backslashes in property paths. */var reEscapeChar=/\\(\\)?/g;/**
    	 * Converts `string` to a property path array.
    	 *
    	 * @private
    	 * @param {string} string The string to convert.
    	 * @returns {Array} Returns the property path array.
    	 */var stringToPath$1=memoizeCapped(function(string){var result=[];if(string.charCodeAt(0)===46/* . */){result.push('');}string.replace(rePropName,function(match,number,quote,subString){result.push(quote?subString.replace(reEscapeChar,'$1'):number||match);});return result;});var _stringToPath=stringToPath$1;/**
    	 * A specialized version of `_.map` for arrays without support for iteratee
    	 * shorthands.
    	 *
    	 * @private
    	 * @param {Array} [array] The array to iterate over.
    	 * @param {Function} iteratee The function invoked per iteration.
    	 * @returns {Array} Returns the new mapped array.
    	 */function arrayMap$2(array,iteratee){var index=-1,length=array==null?0:array.length,result=Array(length);while(++index<length){result[index]=iteratee(array[index],index,array);}return result;}var _arrayMap=arrayMap$2;var Symbol$1=_Symbol,arrayMap$1=_arrayMap,isArray$3=isArray_1,isSymbol$1=isSymbol_1;/** Used to convert symbols to primitives and strings. */var symbolProto=Symbol$1?Symbol$1.prototype:undefined,symbolToString=symbolProto?symbolProto.toString:undefined;/**
    	 * The base implementation of `_.toString` which doesn't convert nullish
    	 * values to empty strings.
    	 *
    	 * @private
    	 * @param {*} value The value to process.
    	 * @returns {string} Returns the string.
    	 */function baseToString$1(value){// Exit early for strings to avoid a performance hit in some environments.
    	if(typeof value=='string'){return value;}if(isArray$3(value)){// Recursively convert values (susceptible to call stack limits).
    	return arrayMap$1(value,baseToString$1)+'';}if(isSymbol$1(value)){return symbolToString?symbolToString.call(value):'';}var result=value+'';return result=='0'&&1/value==-Infinity?'-0':result;}var _baseToString=baseToString$1;var baseToString=_baseToString;/**
    	 * Converts `value` to a string. An empty string is returned for `null`
    	 * and `undefined` values. The sign of `-0` is preserved.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 4.0.0
    	 * @category Lang
    	 * @param {*} value The value to convert.
    	 * @returns {string} Returns the converted string.
    	 * @example
    	 *
    	 * _.toString(null);
    	 * // => ''
    	 *
    	 * _.toString(-0);
    	 * // => '-0'
    	 *
    	 * _.toString([1, 2, 3]);
    	 * // => '1,2,3'
    	 */function toString$1(value){return value==null?'':baseToString(value);}var toString_1=toString$1;var isArray$2=isArray_1,isKey$2=_isKey,stringToPath=_stringToPath,toString=toString_1;/**
    	 * Casts `value` to a path array if it's not one.
    	 *
    	 * @private
    	 * @param {*} value The value to inspect.
    	 * @param {Object} [object] The object to query keys on.
    	 * @returns {Array} Returns the cast property path array.
    	 */function castPath$4(value,object){if(isArray$2(value)){return value;}return isKey$2(value,object)?[value]:stringToPath(toString(value));}var _castPath=castPath$4;var isSymbol=isSymbol_1;/**
    	 * Converts `value` to a string key if it's not a string or symbol.
    	 *
    	 * @private
    	 * @param {*} value The value to inspect.
    	 * @returns {string|symbol} Returns the key.
    	 */function toKey$5(value){if(typeof value=='string'||isSymbol(value)){return value;}var result=value+'';return result=='0'&&1/value==-Infinity?'-0':result;}var _toKey=toKey$5;var castPath$3=_castPath,toKey$4=_toKey;/**
    	 * The base implementation of `_.get` without support for default values.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @param {Array|string} path The path of the property to get.
    	 * @returns {*} Returns the resolved value.
    	 */function baseGet$3(object,path){path=castPath$3(path,object);var index=0,length=path.length;while(object!=null&&index<length){object=object[toKey$4(path[index++])];}return index&&index==length?object:undefined;}var _baseGet=baseGet$3;var baseGet$2=_baseGet;/**
    	 * Gets the value at `path` of `object`. If the resolved value is
    	 * `undefined`, the `defaultValue` is returned in its place.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 3.7.0
    	 * @category Object
    	 * @param {Object} object The object to query.
    	 * @param {Array|string} path The path of the property to get.
    	 * @param {*} [defaultValue] The value returned for `undefined` resolved values.
    	 * @returns {*} Returns the resolved value.
    	 * @example
    	 *
    	 * var object = { 'a': [{ 'b': { 'c': 3 } }] };
    	 *
    	 * _.get(object, 'a[0].b.c');
    	 * // => 3
    	 *
    	 * _.get(object, ['a', '0', 'b', 'c']);
    	 * // => 3
    	 *
    	 * _.get(object, 'a.b.c', 'default');
    	 * // => 'default'
    	 */function get$1(object,path,defaultValue){var result=object==null?undefined:baseGet$2(object,path);return result===undefined?defaultValue:result;}var get_1=get$1;/**
    	 * The base implementation of `_.hasIn` without support for deep paths.
    	 *
    	 * @private
    	 * @param {Object} [object] The object to query.
    	 * @param {Array|string} key The key to check.
    	 * @returns {boolean} Returns `true` if `key` exists, else `false`.
    	 */function baseHasIn$1(object,key){return object!=null&&key in Object(object);}var _baseHasIn=baseHasIn$1;var castPath$2=_castPath,isArguments=isArguments_1,isArray$1=isArray_1,isIndex$1=_isIndex,isLength=isLength_1,toKey$3=_toKey;/**
    	 * Checks if `path` exists on `object`.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @param {Array|string} path The path to check.
    	 * @param {Function} hasFunc The function to check properties.
    	 * @returns {boolean} Returns `true` if `path` exists, else `false`.
    	 */function hasPath$1(object,path,hasFunc){path=castPath$2(path,object);var index=-1,length=path.length,result=false;while(++index<length){var key=toKey$3(path[index]);if(!(result=object!=null&&hasFunc(object,key))){break;}object=object[key];}if(result||++index!=length){return result;}length=object==null?0:object.length;return !!length&&isLength(length)&&isIndex$1(key,length)&&(isArray$1(object)||isArguments(object));}var _hasPath=hasPath$1;var baseHasIn=_baseHasIn,hasPath=_hasPath;/**
    	 * Checks if `path` is a direct or inherited property of `object`.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 4.0.0
    	 * @category Object
    	 * @param {Object} object The object to query.
    	 * @param {Array|string} path The path to check.
    	 * @returns {boolean} Returns `true` if `path` exists, else `false`.
    	 * @example
    	 *
    	 * var object = _.create({ 'a': _.create({ 'b': 2 }) });
    	 *
    	 * _.hasIn(object, 'a');
    	 * // => true
    	 *
    	 * _.hasIn(object, 'a.b');
    	 * // => true
    	 *
    	 * _.hasIn(object, ['a', 'b']);
    	 * // => true
    	 *
    	 * _.hasIn(object, 'b');
    	 * // => false
    	 */function hasIn$1(object,path){return object!=null&&hasPath(object,path,baseHasIn);}var hasIn_1=hasIn$1;var baseIsEqual=_baseIsEqual,get=get_1,hasIn=hasIn_1,isKey$1=_isKey,isStrictComparable=_isStrictComparable,matchesStrictComparable=_matchesStrictComparable,toKey$2=_toKey;/** Used to compose bitmasks for value comparisons. */var COMPARE_PARTIAL_FLAG=1,COMPARE_UNORDERED_FLAG=2;/**
    	 * The base implementation of `_.matchesProperty` which doesn't clone `srcValue`.
    	 *
    	 * @private
    	 * @param {string} path The path of the property to get.
    	 * @param {*} srcValue The value to match.
    	 * @returns {Function} Returns the new spec function.
    	 */function baseMatchesProperty$1(path,srcValue){if(isKey$1(path)&&isStrictComparable(srcValue)){return matchesStrictComparable(toKey$2(path),srcValue);}return function(object){var objValue=get(object,path);return objValue===undefined&&objValue===srcValue?hasIn(object,path):baseIsEqual(srcValue,objValue,COMPARE_PARTIAL_FLAG|COMPARE_UNORDERED_FLAG);};}var _baseMatchesProperty=baseMatchesProperty$1;/**
    	 * This method returns the first argument it receives.
    	 *
    	 * @static
    	 * @since 0.1.0
    	 * @memberOf _
    	 * @category Util
    	 * @param {*} value Any value.
    	 * @returns {*} Returns `value`.
    	 * @example
    	 *
    	 * var object = { 'a': 1 };
    	 *
    	 * console.log(_.identity(object) === object);
    	 * // => true
    	 */function identity$1(value){return value;}var identity_1=identity$1;/**
    	 * The base implementation of `_.property` without support for deep paths.
    	 *
    	 * @private
    	 * @param {string} key The key of the property to get.
    	 * @returns {Function} Returns the new accessor function.
    	 */function baseProperty$1(key){return function(object){return object==null?undefined:object[key];};}var _baseProperty=baseProperty$1;var baseGet$1=_baseGet;/**
    	 * A specialized version of `baseProperty` which supports deep paths.
    	 *
    	 * @private
    	 * @param {Array|string} path The path of the property to get.
    	 * @returns {Function} Returns the new accessor function.
    	 */function basePropertyDeep$1(path){return function(object){return baseGet$1(object,path);};}var _basePropertyDeep=basePropertyDeep$1;var baseProperty=_baseProperty,basePropertyDeep=_basePropertyDeep,isKey=_isKey,toKey$1=_toKey;/**
    	 * Creates a function that returns the value at `path` of a given object.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 2.4.0
    	 * @category Util
    	 * @param {Array|string} path The path of the property to get.
    	 * @returns {Function} Returns the new accessor function.
    	 * @example
    	 *
    	 * var objects = [
    	 *   { 'a': { 'b': 2 } },
    	 *   { 'a': { 'b': 1 } }
    	 * ];
    	 *
    	 * _.map(objects, _.property('a.b'));
    	 * // => [2, 1]
    	 *
    	 * _.map(_.sortBy(objects, _.property(['a', 'b'])), 'a.b');
    	 * // => [1, 2]
    	 */function property$1(path){return isKey(path)?baseProperty(toKey$1(path)):basePropertyDeep(path);}var property_1=property$1;var baseMatches=_baseMatches,baseMatchesProperty=_baseMatchesProperty,identity=identity_1,isArray=isArray_1,property=property_1;/**
    	 * The base implementation of `_.iteratee`.
    	 *
    	 * @private
    	 * @param {*} [value=_.identity] The value to convert to an iteratee.
    	 * @returns {Function} Returns the iteratee.
    	 */function baseIteratee$2(value){// Don't store the `typeof` result in a variable to avoid a JIT bug in Safari 9.
    	// See https://bugs.webkit.org/show_bug.cgi?id=156034 for more details.
    	if(typeof value=='function'){return value;}if(value==null){return identity;}if(typeof value=='object'){return isArray(value)?baseMatchesProperty(value[0],value[1]):baseMatches(value);}return property(value);}var _baseIteratee=baseIteratee$2;var baseAssignValue$1=_baseAssignValue,baseForOwn=_baseForOwn,baseIteratee$1=_baseIteratee;/**
    	 * Creates an object with the same keys as `object` and values generated
    	 * by running each own enumerable string keyed property of `object` thru
    	 * `iteratee`. The iteratee is invoked with three arguments:
    	 * (value, key, object).
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 2.4.0
    	 * @category Object
    	 * @param {Object} object The object to iterate over.
    	 * @param {Function} [iteratee=_.identity] The function invoked per iteration.
    	 * @returns {Object} Returns the new mapped object.
    	 * @see _.mapKeys
    	 * @example
    	 *
    	 * var users = {
    	 *   'fred':    { 'user': 'fred',    'age': 40 },
    	 *   'pebbles': { 'user': 'pebbles', 'age': 1 }
    	 * };
    	 *
    	 * _.mapValues(users, function(o) { return o.age; });
    	 * // => { 'fred': 40, 'pebbles': 1 } (iteration order is not guaranteed)
    	 *
    	 * // The `_.property` iteratee shorthand.
    	 * _.mapValues(users, 'age');
    	 * // => { 'fred': 40, 'pebbles': 1 } (iteration order is not guaranteed)
    	 */function mapValues(object,iteratee){var result={};iteratee=baseIteratee$1(iteratee);baseForOwn(object,function(value,key,object){baseAssignValue$1(result,key,iteratee(value,key,object));});return result;}var mapValues_1=mapValues;var mapValues$1=/*@__PURE__*/getDefaultExportFromCjs(mapValues_1);var baseAssignValue=_baseAssignValue,eq=eq_1;/** Used for built-in method references. */var objectProto$1=Object.prototype;/** Used to check objects for own properties. */var hasOwnProperty$1=objectProto$1.hasOwnProperty;/**
    	 * Assigns `value` to `key` of `object` if the existing value is not equivalent
    	 * using [`SameValueZero`](http://ecma-international.org/ecma-262/7.0/#sec-samevaluezero)
    	 * for equality comparisons.
    	 *
    	 * @private
    	 * @param {Object} object The object to modify.
    	 * @param {string} key The key of the property to assign.
    	 * @param {*} value The value to assign.
    	 */function assignValue$1(object,key,value){var objValue=object[key];if(!(hasOwnProperty$1.call(object,key)&&eq(objValue,value))||value===undefined&&!(key in object)){baseAssignValue(object,key,value);}}var _assignValue=assignValue$1;var assignValue=_assignValue,castPath$1=_castPath,isIndex=_isIndex,isObject$1=isObject_1,toKey=_toKey;/**
    	 * The base implementation of `_.set`.
    	 *
    	 * @private
    	 * @param {Object} object The object to modify.
    	 * @param {Array|string} path The path of the property to set.
    	 * @param {*} value The value to set.
    	 * @param {Function} [customizer] The function to customize path creation.
    	 * @returns {Object} Returns `object`.
    	 */function baseSet$1(object,path,value,customizer){if(!isObject$1(object)){return object;}path=castPath$1(path,object);var index=-1,length=path.length,lastIndex=length-1,nested=object;while(nested!=null&&++index<length){var key=toKey(path[index]),newValue=value;if(key==='__proto__'||key==='constructor'||key==='prototype'){return object;}if(index!=lastIndex){var objValue=nested[key];newValue=customizer?customizer(objValue,key,nested):undefined;if(newValue===undefined){newValue=isObject$1(objValue)?objValue:isIndex(path[index+1])?[]:{};}}assignValue(nested,key,newValue);nested=nested[key];}return object;}var _baseSet=baseSet$1;var baseGet=_baseGet,baseSet=_baseSet,castPath=_castPath;/**
    	 * The base implementation of  `_.pickBy` without support for iteratee shorthands.
    	 *
    	 * @private
    	 * @param {Object} object The source object.
    	 * @param {string[]} paths The property paths to pick.
    	 * @param {Function} predicate The function invoked per property.
    	 * @returns {Object} Returns the new object.
    	 */function basePickBy$1(object,paths,predicate){var index=-1,length=paths.length,result={};while(++index<length){var path=paths[index],value=baseGet(object,path);if(predicate(value,path)){baseSet(result,castPath(path,object),value);}}return result;}var _basePickBy=basePickBy$1;var overArg=_overArg;/** Built-in value references. */var getPrototype$1=overArg(Object.getPrototypeOf,Object);var _getPrototype=getPrototype$1;var arrayPush=_arrayPush,getPrototype=_getPrototype,getSymbols=_getSymbols,stubArray=stubArray_1;/* Built-in method references for those with the same name as other `lodash` methods. */var nativeGetSymbols=Object.getOwnPropertySymbols;/**
    	 * Creates an array of the own and inherited enumerable symbols of `object`.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @returns {Array} Returns the array of symbols.
    	 */var getSymbolsIn$1=!nativeGetSymbols?stubArray:function(object){var result=[];while(object){arrayPush(result,getSymbols(object));object=getPrototype(object);}return result;};var _getSymbolsIn=getSymbolsIn$1;/**
    	 * This function is like
    	 * [`Object.keys`](http://ecma-international.org/ecma-262/7.0/#sec-object.keys)
    	 * except that it includes inherited enumerable properties.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @returns {Array} Returns the array of property names.
    	 */function nativeKeysIn$1(object){var result=[];if(object!=null){for(var key in Object(object)){result.push(key);}}return result;}var _nativeKeysIn=nativeKeysIn$1;var isObject=isObject_1,isPrototype=_isPrototype,nativeKeysIn=_nativeKeysIn;/** Used for built-in method references. */var objectProto=Object.prototype;/** Used to check objects for own properties. */var hasOwnProperty=objectProto.hasOwnProperty;/**
    	 * The base implementation of `_.keysIn` which doesn't treat sparse arrays as dense.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @returns {Array} Returns the array of property names.
    	 */function baseKeysIn$1(object){if(!isObject(object)){return nativeKeysIn(object);}var isProto=isPrototype(object),result=[];for(var key in object){if(!(key=='constructor'&&(isProto||!hasOwnProperty.call(object,key)))){result.push(key);}}return result;}var _baseKeysIn=baseKeysIn$1;var arrayLikeKeys=_arrayLikeKeys,baseKeysIn=_baseKeysIn,isArrayLike=isArrayLike_1;/**
    	 * Creates an array of the own and inherited enumerable property names of `object`.
    	 *
    	 * **Note:** Non-object values are coerced to objects.
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 3.0.0
    	 * @category Object
    	 * @param {Object} object The object to query.
    	 * @returns {Array} Returns the array of property names.
    	 * @example
    	 *
    	 * function Foo() {
    	 *   this.a = 1;
    	 *   this.b = 2;
    	 * }
    	 *
    	 * Foo.prototype.c = 3;
    	 *
    	 * _.keysIn(new Foo);
    	 * // => ['a', 'b', 'c'] (iteration order is not guaranteed)
    	 */function keysIn$1(object){return isArrayLike(object)?arrayLikeKeys(object,true):baseKeysIn(object);}var keysIn_1=keysIn$1;var baseGetAllKeys=_baseGetAllKeys,getSymbolsIn=_getSymbolsIn,keysIn=keysIn_1;/**
    	 * Creates an array of own and inherited enumerable property names and
    	 * symbols of `object`.
    	 *
    	 * @private
    	 * @param {Object} object The object to query.
    	 * @returns {Array} Returns the array of property names and symbols.
    	 */function getAllKeysIn$1(object){return baseGetAllKeys(object,keysIn,getSymbolsIn);}var _getAllKeysIn=getAllKeysIn$1;var arrayMap=_arrayMap,baseIteratee=_baseIteratee,basePickBy=_basePickBy,getAllKeysIn=_getAllKeysIn;/**
    	 * Creates an object composed of the `object` properties `predicate` returns
    	 * truthy for. The predicate is invoked with two arguments: (value, key).
    	 *
    	 * @static
    	 * @memberOf _
    	 * @since 4.0.0
    	 * @category Object
    	 * @param {Object} object The source object.
    	 * @param {Function} [predicate=_.identity] The function invoked per property.
    	 * @returns {Object} Returns the new object.
    	 * @example
    	 *
    	 * var object = { 'a': 1, 'b': '2', 'c': 3 };
    	 *
    	 * _.pickBy(object, _.isNumber);
    	 * // => { 'a': 1, 'c': 3 }
    	 */function pickBy(object,predicate){if(object==null){return {};}var props=arrayMap(getAllKeysIn(object),function(prop){return [prop];});predicate=baseIteratee(predicate);return basePickBy(object,props,function(value,path){return predicate(value,path[0]);});}var pickBy_1=pickBy;var pickBy$1=/*@__PURE__*/getDefaultExportFromCjs(pickBy_1);const DefaultErrorCode="OS-CLRT-00000";const evaluateObjFuncValues=objFuncValues=>{const fullLogAttributes=mapValues$1(objFuncValues,getFieldValue=>getFieldValue());const filteredLogAttributes=pickBy$1(fullLogAttributes,fieldValue=>fieldValue!==undefined&&fieldValue!==null);return filteredLogAttributes;};const mapVisibilityToNumber={[Visibility$1.Internal]:1,[Visibility$1.External]:2,[Visibility$1.Client]:3};const getExceptionAttributes=log=>{var _a,_b,_c;const exceptionAttributes={};if(log.type===LogType$1.Error&&log.error){exceptionAttributes["exception.type"]=log.error.name;exceptionAttributes["exception.message"]=removeQueryParametersUrl(log.error.message);exceptionAttributes["exception.stacktrace"]=(_a=log.error.stack)!==null&&_a!==void 0?_a:"";exceptionAttributes["outsystems.error.code"]=(_c=(_b=log.errorCode)===null||_b===void 0?void 0:_b.toString())!==null&&_c!==void 0?_c:DefaultErrorCode.toString();}return exceptionAttributes;};const getTraceFields=log=>{const traceAttributes={};const trace=log.span;if(trace){traceAttributes["traceId"]=trace.traceId;traceAttributes["spanId"]=trace.spanId;}return traceAttributes;};const convertObjectToAttributesList=attributes=>{const mapTypeToValueName=value=>{if(typeof value==="boolean"){return "boolValue";}if(typeof value==="number"){if(value%1===0){return "intValue";}return "doubleValue";}return "stringValue";};const attributesList=Object.entries(attributes).map(_ref11=>{let[key,value]=_ref11;return {key,value:{[mapTypeToValueName(value)]:value}};});return attributesList;};const sanitizeUrlAttribute=attributes=>{if(attributes["http.url"]){attributes["http.url"]=removeQueryParametersUrl(attributes["http.url"]);}return attributes;};const removeQueryParametersUrl=url=>{return url.replace(/((outsystems|https|http):\/\/[^ ]*?)\?[^ ]*/g,"$1");};var _Logger_transportManager,_Logger_getTimestamp,_Logger_baseAttributes;class Logger{constructor(_ref12){let{baseAttributes={},transportManager,getTimestamp}=_ref12;_Logger_transportManager.set(this,void 0);_Logger_getTimestamp.set(this,void 0);_Logger_baseAttributes.set(this,void 0);__classPrivateFieldSet(this,_Logger_transportManager,transportManager);__classPrivateFieldSet(this,_Logger_getTimestamp,getTimestamp);__classPrivateFieldSet(this,_Logger_baseAttributes,baseAttributes);}static build(_a){return __awaiter$3(this,arguments,void 0,function(_ref13){let{transports=[],baseAttributes,databaseNameSuffix,transportManager=new TransportManager({databaseNameSuffix,logTransports:transports}),getTimestamp=()=>new Instant()}=_ref13;return function*(){return new Logger({baseAttributes,transportManager,getTimestamp});}();});}addTransport(transport){__classPrivateFieldGet(this,_Logger_transportManager,"f").addLogTransport(transport);}removeTransport(transportId){__classPrivateFieldGet(this,_Logger_transportManager,"f").removeLogTransport(transportId);}setLogTypeBaseline(){let logType=arguments.length>0&&arguments[0]!==undefined?arguments[0]:LogType$1.Error;__classPrivateFieldGet(this,_Logger_transportManager,"f").setAllLogTypeBaselines(logType);}flush(){return __awaiter$3(this,void 0,void 0,function*(){__classPrivateFieldGet(this,_Logger_transportManager,"f").flushLogs();});}setSchedulerTimerInterval(timerInterval){__classPrivateFieldGet(this,_Logger_transportManager,"f").setSchedulerTimerInterval(timerInterval);}error(_ref14){let{category,message,error,errorCode,visibility=Visibility$1.Internal,span,attributes}=_ref14;const errorLog=new Log({type:LogType$1.Error,category,message,error,visibility,timestamp:__classPrivateFieldGet(this,_Logger_getTimestamp,"f").call(this),errorCode,span,attributes:Object.assign(Object.assign({},evaluateObjFuncValues(__classPrivateFieldGet(this,_Logger_baseAttributes,"f"))),attributes)});__classPrivateFieldGet(this,_Logger_transportManager,"f").processLog(errorLog);}warning(_ref15){let{category,message,visibility=Visibility$1.Internal,span,attributes}=_ref15;const warningLog=new Log({type:LogType$1.Warning,category,message,visibility,timestamp:__classPrivateFieldGet(this,_Logger_getTimestamp,"f").call(this),span,attributes:Object.assign(Object.assign({},evaluateObjFuncValues(__classPrivateFieldGet(this,_Logger_baseAttributes,"f"))),attributes)});__classPrivateFieldGet(this,_Logger_transportManager,"f").processLog(warningLog);}info(_ref16){let{category,message,visibility=Visibility$1.External,span,attributes}=_ref16;const infoLog=new Log({type:LogType$1.Info,category,message,visibility,timestamp:__classPrivateFieldGet(this,_Logger_getTimestamp,"f").call(this),span,attributes:Object.assign(Object.assign({},evaluateObjFuncValues(__classPrivateFieldGet(this,_Logger_baseAttributes,"f"))),attributes)});__classPrivateFieldGet(this,_Logger_transportManager,"f").processLog(infoLog);}debug(_ref17){let{category,message,visibility=Visibility$1.Internal,span,attributes}=_ref17;const debugLog=new Log({type:LogType$1.Debug,category,message,visibility,timestamp:__classPrivateFieldGet(this,_Logger_getTimestamp,"f").call(this),span,attributes:Object.assign(Object.assign({},evaluateObjFuncValues(__classPrivateFieldGet(this,_Logger_baseAttributes,"f"))),attributes)});__classPrivateFieldGet(this,_Logger_transportManager,"f").processLog(debugLog);}log(logObject){return __awaiter$3(this,void 0,void 0,function*(){yield __classPrivateFieldGet(this,_Logger_transportManager,"f").processLog(logObject);});}}_exports.Logger=Logger;_Logger_transportManager=new WeakMap(),_Logger_getTimestamp=new WeakMap(),_Logger_baseAttributes=new WeakMap();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * check if an object has addEventListener and removeEventListener functions then it will return true.
    	 * Generally only called with a `TargetWithEvents` but may be called with an unknown / any.
    	 * @param obj - The object to check.
    	 */function isListenerObject(obj){if(obj===void 0){obj={};}return typeof obj.addEventListener==='function'&&typeof obj.removeEventListener==='function';}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//// <reference types="zone.js" />
    	/* Key name to be used to save a context reference in Zone */var ZONE_CONTEXT_KEY='OT_ZONE_CONTEXT';/**
    	 * ZoneContextManager
    	 * This module provides an easy functionality for tracing action between asynchronous operations in web.
    	 * It was not possible with standard [StackContextManager]{@link https://github.com/open-telemetry/opentelemetry-js/blob/main/packages/opentelemetry-sdk-trace-web/src/StackContextManager.ts}.
    	 * It heavily depends on [zone.js]{@link https://www.npmjs.com/package/zone.js}.
    	 * It stores the information about context in zone. Each Context will have always new Zone;
    	 * It also supports binding a certain Span to a target that has "addEventListener" and "removeEventListener".
    	 * When this happens a new zone is being created and the provided Span is being assigned to this zone.
    	 */var ZoneContextManager=/** @class */function(){function ZoneContextManager(){/**
    	         * whether the context manager is enabled or not
    	         */this._enabled=false;/**
    	         * Helps to create a unique name for the zones - part of zone name
    	         */this._zoneCounter=0;}/**
    	     * Returns the active context from certain zone name
    	     * @param activeZone
    	     */ZoneContextManager.prototype._activeContextFromZone=function(activeZone){return activeZone&&activeZone.get(ZONE_CONTEXT_KEY)||ROOT_CONTEXT;};/**
    	     * @param context A context (span) to be executed within target function
    	     * @param target Function to be executed within the context
    	     */// eslint-disable-next-line @typescript-eslint/ban-types
    	ZoneContextManager.prototype._bindFunction=function(context,target){var manager=this;var contextWrapper=function(){var _this=this;var args=[];for(var _i=0;_i<arguments.length;_i++){args[_i]=arguments[_i];}return manager.with(context,function(){return target.apply(_this,args);});};Object.defineProperty(contextWrapper,'length',{enumerable:false,configurable:true,writable:false,value:target.length});return contextWrapper;};/**
    	     * @param context A context (span) to be bind to target
    	     * @param obj target object on which the listeners will be patched
    	     */ZoneContextManager.prototype._bindListener=function(context,obj){var target=obj;if(target.__ot_listeners!==undefined){return obj;}target.__ot_listeners={};if(typeof target.addEventListener==='function'){target.addEventListener=this._patchAddEventListener(target,target.addEventListener,context);}if(typeof target.removeEventListener==='function'){target.removeEventListener=this._patchRemoveEventListener(target,target.removeEventListener);}return obj;};/**
    	     * Creates a new unique zone name
    	     */ZoneContextManager.prototype._createZoneName=function(){this._zoneCounter++;var random=Math.random();return this._zoneCounter+"-"+random;};/**
    	     * Creates a new zone
    	     * @param zoneName zone name
    	     * @param context A context (span) to be bind with Zone
    	     */ZoneContextManager.prototype._createZone=function(zoneName,context){var _a;return Zone.current.fork({name:zoneName,properties:(_a={},_a[ZONE_CONTEXT_KEY]=context,_a)});};/**
    	     * Returns the active zone
    	     */ZoneContextManager.prototype._getActiveZone=function(){return Zone.current;};/**
    	     * Patches addEventListener method
    	     * @param target any target that has "addEventListener" method
    	     * @param original reference to the patched method
    	     * @param [context] context to be bind to the listener
    	     */ZoneContextManager.prototype._patchAddEventListener=function(target,original,context){var contextManager=this;return function(event,listener,opts){if(target.__ot_listeners===undefined){target.__ot_listeners={};}var listeners=target.__ot_listeners[event];if(listeners===undefined){listeners=new WeakMap();target.__ot_listeners[event]=listeners;}var patchedListener=contextManager.bind(context,listener);// store a weak reference of the user listener to ours
    	listeners.set(listener,patchedListener);return original.call(this,event,patchedListener,opts);};};/**
    	     * Patches removeEventListener method
    	     * @param target any target that has "removeEventListener" method
    	     * @param original reference to the patched method
    	     */ZoneContextManager.prototype._patchRemoveEventListener=function(target,original){return function(event,listener){if(target.__ot_listeners===undefined||target.__ot_listeners[event]===undefined){return original.call(this,event,listener);}var events=target.__ot_listeners[event];var patchedListener=events.get(listener);events.delete(listener);return original.call(this,event,patchedListener||listener);};};/**
    	     * Returns the active context
    	     */ZoneContextManager.prototype.active=function(){if(!this._enabled){return ROOT_CONTEXT;}var activeZone=this._getActiveZone();var active=this._activeContextFromZone(activeZone);if(active){return active;}return ROOT_CONTEXT;};/**
    	     * Binds a the certain context or the active one to the target function and then returns the target
    	     * @param context A context (span) to be bind to target
    	     * @param target a function or event emitter. When target or one of its callbacks is called,
    	     *  the provided context will be used as the active context for the duration of the call.
    	     */ZoneContextManager.prototype.bind=function(context,target){// if no specific context to propagate is given, we use the current one
    	if(context===undefined){context=this.active();}if(typeof target==='function'){return this._bindFunction(context,target);}else if(isListenerObject(target)){this._bindListener(context,target);}return target;};/**
    	     * Disable the context manager (clears all the contexts)
    	     */ZoneContextManager.prototype.disable=function(){this._enabled=false;return this;};/**
    	     * Enables the context manager and creates a default(root) context
    	     */ZoneContextManager.prototype.enable=function(){this._enabled=true;return this;};/**
    	     * Calls the callback function [fn] with the provided [context].
    	     *     If [context] is undefined then it will use the active context.
    	     *     The context will be set as active
    	     * @param context A context (span) to be called with provided callback
    	     * @param fn Callback function
    	     * @param thisArg optional receiver to be used for calling fn
    	     * @param args optional arguments forwarded to fn
    	     */ZoneContextManager.prototype.with=function(context,fn,thisArg){var args=[];for(var _i=3;_i<arguments.length;_i++){args[_i-3]=arguments[_i];}var zoneName=this._createZoneName();var newZone=this._createZone(zoneName,context);return newZone.run(fn,thisArg,args);};return ZoneContextManager;}();/**
    	 * @license Angular v<unknown>
    	 * (c) 2010-2024 Google LLC. https://angular.io/
    	 * License: MIT
    	 */const global$1=globalThis;// __Zone_symbol_prefix global can be used to override the default zone
    	// symbol prefix with a custom one if needed.
    	function __symbol__(name){const symbolPrefix=global$1['__Zone_symbol_prefix']||'__zone_symbol__';return symbolPrefix+name;}function initZone(){var _ZoneImpl;const performance=global$1['performance'];function mark(name){performance&&performance['mark']&&performance['mark'](name);}function performanceMeasure(name,label){performance&&performance['measure']&&performance['measure'](name,label);}mark('Zone');class ZoneImpl{static assertZonePatched(){if(global$1['Promise']!==patches['ZoneAwarePromise']){throw new Error('Zone.js has detected that ZoneAwarePromise `(window|global).Promise` '+'has been overwritten.\n'+'Most likely cause is that a Promise polyfill has been loaded '+'after Zone.js (Polyfilling Promise api is not necessary when zone.js is loaded. '+'If you must load one, do so before loading zone.js.)');}}static get root(){let zone=ZoneImpl.current;while(zone.parent){zone=zone.parent;}return zone;}static get current(){return _currentZoneFrame.zone;}static get currentTask(){return _currentTask;}// tslint:disable-next-line:require-internal-with-underscore
    	static __load_patch(name,fn){let ignoreDuplicate=arguments.length>2&&arguments[2]!==undefined?arguments[2]:false;if(patches.hasOwnProperty(name)){// `checkDuplicate` option is defined from global variable
    	// so it works for all modules.
    	// `ignoreDuplicate` can work for the specified module
    	const checkDuplicate=global$1[__symbol__('forceDuplicateZoneCheck')]===true;if(!ignoreDuplicate&&checkDuplicate){throw Error('Already loaded patch: '+name);}}else if(!global$1['__Zone_disable_'+name]){const perfName='Zone:'+name;mark(perfName);patches[name]=fn(global$1,ZoneImpl,_api);performanceMeasure(perfName,perfName);}}get parent(){return this._parent;}get name(){return this._name;}constructor(parent,zoneSpec){this._parent=parent;this._name=zoneSpec?zoneSpec.name||'unnamed':'<root>';this._properties=zoneSpec&&zoneSpec.properties||{};this._zoneDelegate=new _ZoneDelegate(this,this._parent&&this._parent._zoneDelegate,zoneSpec);}get(key){const zone=this.getZoneWith(key);if(zone)return zone._properties[key];}getZoneWith(key){let current=this;while(current){if(current._properties.hasOwnProperty(key)){return current;}current=current._parent;}return null;}fork(zoneSpec){if(!zoneSpec)throw new Error('ZoneSpec required!');return this._zoneDelegate.fork(this,zoneSpec);}wrap(callback,source){if(typeof callback!=='function'){throw new Error('Expecting function got: '+callback);}const _callback=this._zoneDelegate.intercept(this,callback,source);const zone=this;return function(){return zone.runGuarded(_callback,this,arguments,source);};}run(callback,applyThis,applyArgs,source){_currentZoneFrame={parent:_currentZoneFrame,zone:this};try{return this._zoneDelegate.invoke(this,callback,applyThis,applyArgs,source);}finally{_currentZoneFrame=_currentZoneFrame.parent;}}runGuarded(callback){let applyThis=arguments.length>1&&arguments[1]!==undefined?arguments[1]:null;let applyArgs=arguments.length>2?arguments[2]:undefined;let source=arguments.length>3?arguments[3]:undefined;_currentZoneFrame={parent:_currentZoneFrame,zone:this};try{try{return this._zoneDelegate.invoke(this,callback,applyThis,applyArgs,source);}catch(error){if(this._zoneDelegate.handleError(this,error)){throw error;}}}finally{_currentZoneFrame=_currentZoneFrame.parent;}}runTask(task,applyThis,applyArgs){if(task.zone!=this){throw new Error('A task can only be run in the zone of creation! (Creation: '+(task.zone||NO_ZONE).name+'; Execution: '+this.name+')');}const zoneTask=task;// https://github.com/angular/zone.js/issues/778, sometimes eventTask
    	// will run in notScheduled(canceled) state, we should not try to
    	// run such kind of task but just return
    	const{type,data:{isPeriodic=false,isRefreshable=false}={}}=task;if(task.state===notScheduled&&(type===eventTask||type===macroTask)){return;}const reEntryGuard=task.state!=running;reEntryGuard&&zoneTask._transitionTo(running,scheduled);const previousTask=_currentTask;_currentTask=zoneTask;_currentZoneFrame={parent:_currentZoneFrame,zone:this};try{if(type==macroTask&&task.data&&!isPeriodic&&!isRefreshable){task.cancelFn=undefined;}try{return this._zoneDelegate.invokeTask(this,zoneTask,applyThis,applyArgs);}catch(error){if(this._zoneDelegate.handleError(this,error)){throw error;}}}finally{// if the task's state is notScheduled or unknown, then it has already been cancelled
    	// we should not reset the state to scheduled
    	const state=task.state;if(state!==notScheduled&&state!==unknown){if(type==eventTask||isPeriodic||isRefreshable&&state===scheduling){reEntryGuard&&zoneTask._transitionTo(scheduled,running,scheduling);}else {const zoneDelegates=zoneTask._zoneDelegates;this._updateTaskCount(zoneTask,-1);reEntryGuard&&zoneTask._transitionTo(notScheduled,running,notScheduled);if(isRefreshable){zoneTask._zoneDelegates=zoneDelegates;}}}_currentZoneFrame=_currentZoneFrame.parent;_currentTask=previousTask;}}scheduleTask(task){if(task.zone&&task.zone!==this){// check if the task was rescheduled, the newZone
    	// should not be the children of the original zone
    	let newZone=this;while(newZone){if(newZone===task.zone){throw Error(`can not reschedule task to ${this.name} which is descendants of the original zone ${task.zone.name}`);}newZone=newZone.parent;}}task._transitionTo(scheduling,notScheduled);const zoneDelegates=[];task._zoneDelegates=zoneDelegates;task._zone=this;try{task=this._zoneDelegate.scheduleTask(this,task);}catch(err){// should set task's state to unknown when scheduleTask throw error
    	// because the err may from reschedule, so the fromState maybe notScheduled
    	task._transitionTo(unknown,scheduling,notScheduled);// TODO: @JiaLiPassion, should we check the result from handleError?
    	this._zoneDelegate.handleError(this,err);throw err;}if(task._zoneDelegates===zoneDelegates){// we have to check because internally the delegate can reschedule the task.
    	this._updateTaskCount(task,1);}if(task.state==scheduling){task._transitionTo(scheduled,scheduling);}return task;}scheduleMicroTask(source,callback,data,customSchedule){return this.scheduleTask(new ZoneTask(microTask,source,callback,data,customSchedule,undefined));}scheduleMacroTask(source,callback,data,customSchedule,customCancel){return this.scheduleTask(new ZoneTask(macroTask,source,callback,data,customSchedule,customCancel));}scheduleEventTask(source,callback,data,customSchedule,customCancel){return this.scheduleTask(new ZoneTask(eventTask,source,callback,data,customSchedule,customCancel));}cancelTask(task){if(task.zone!=this)throw new Error('A task can only be cancelled in the zone of creation! (Creation: '+(task.zone||NO_ZONE).name+'; Execution: '+this.name+')');if(task.state!==scheduled&&task.state!==running){return;}task._transitionTo(canceling,scheduled,running);try{this._zoneDelegate.cancelTask(this,task);}catch(err){// if error occurs when cancelTask, transit the state to unknown
    	task._transitionTo(unknown,canceling);this._zoneDelegate.handleError(this,err);throw err;}this._updateTaskCount(task,-1);task._transitionTo(notScheduled,canceling);task.runCount=-1;return task;}_updateTaskCount(task,count){const zoneDelegates=task._zoneDelegates;if(count==-1){task._zoneDelegates=null;}for(let i=0;i<zoneDelegates.length;i++){zoneDelegates[i]._updateTaskCount(task.type,count);}}}_ZoneImpl=ZoneImpl;// tslint:disable-next-line:require-internal-with-underscore
    	_ZoneImpl.__symbol__=__symbol__;const DELEGATE_ZS={name:'',onHasTask:(delegate,_,target,hasTaskState)=>delegate.hasTask(target,hasTaskState),onScheduleTask:(delegate,_,target,task)=>delegate.scheduleTask(target,task),onInvokeTask:(delegate,_,target,task,applyThis,applyArgs)=>delegate.invokeTask(target,task,applyThis,applyArgs),onCancelTask:(delegate,_,target,task)=>delegate.cancelTask(target,task)};class _ZoneDelegate{get zone(){return this._zone;}constructor(zone,parentDelegate,zoneSpec){this._taskCounts={'microTask':0,'macroTask':0,'eventTask':0};this._zone=zone;this._parentDelegate=parentDelegate;this._forkZS=zoneSpec&&(zoneSpec&&zoneSpec.onFork?zoneSpec:parentDelegate._forkZS);this._forkDlgt=zoneSpec&&(zoneSpec.onFork?parentDelegate:parentDelegate._forkDlgt);this._forkCurrZone=zoneSpec&&(zoneSpec.onFork?this._zone:parentDelegate._forkCurrZone);this._interceptZS=zoneSpec&&(zoneSpec.onIntercept?zoneSpec:parentDelegate._interceptZS);this._interceptDlgt=zoneSpec&&(zoneSpec.onIntercept?parentDelegate:parentDelegate._interceptDlgt);this._interceptCurrZone=zoneSpec&&(zoneSpec.onIntercept?this._zone:parentDelegate._interceptCurrZone);this._invokeZS=zoneSpec&&(zoneSpec.onInvoke?zoneSpec:parentDelegate._invokeZS);this._invokeDlgt=zoneSpec&&(zoneSpec.onInvoke?parentDelegate:parentDelegate._invokeDlgt);this._invokeCurrZone=zoneSpec&&(zoneSpec.onInvoke?this._zone:parentDelegate._invokeCurrZone);this._handleErrorZS=zoneSpec&&(zoneSpec.onHandleError?zoneSpec:parentDelegate._handleErrorZS);this._handleErrorDlgt=zoneSpec&&(zoneSpec.onHandleError?parentDelegate:parentDelegate._handleErrorDlgt);this._handleErrorCurrZone=zoneSpec&&(zoneSpec.onHandleError?this._zone:parentDelegate._handleErrorCurrZone);this._scheduleTaskZS=zoneSpec&&(zoneSpec.onScheduleTask?zoneSpec:parentDelegate._scheduleTaskZS);this._scheduleTaskDlgt=zoneSpec&&(zoneSpec.onScheduleTask?parentDelegate:parentDelegate._scheduleTaskDlgt);this._scheduleTaskCurrZone=zoneSpec&&(zoneSpec.onScheduleTask?this._zone:parentDelegate._scheduleTaskCurrZone);this._invokeTaskZS=zoneSpec&&(zoneSpec.onInvokeTask?zoneSpec:parentDelegate._invokeTaskZS);this._invokeTaskDlgt=zoneSpec&&(zoneSpec.onInvokeTask?parentDelegate:parentDelegate._invokeTaskDlgt);this._invokeTaskCurrZone=zoneSpec&&(zoneSpec.onInvokeTask?this._zone:parentDelegate._invokeTaskCurrZone);this._cancelTaskZS=zoneSpec&&(zoneSpec.onCancelTask?zoneSpec:parentDelegate._cancelTaskZS);this._cancelTaskDlgt=zoneSpec&&(zoneSpec.onCancelTask?parentDelegate:parentDelegate._cancelTaskDlgt);this._cancelTaskCurrZone=zoneSpec&&(zoneSpec.onCancelTask?this._zone:parentDelegate._cancelTaskCurrZone);this._hasTaskZS=null;this._hasTaskDlgt=null;this._hasTaskDlgtOwner=null;this._hasTaskCurrZone=null;const zoneSpecHasTask=zoneSpec&&zoneSpec.onHasTask;const parentHasTask=parentDelegate&&parentDelegate._hasTaskZS;if(zoneSpecHasTask||parentHasTask){// If we need to report hasTask, than this ZS needs to do ref counting on tasks. In such
    	// a case all task related interceptors must go through this ZD. We can't short circuit it.
    	this._hasTaskZS=zoneSpecHasTask?zoneSpec:DELEGATE_ZS;this._hasTaskDlgt=parentDelegate;this._hasTaskDlgtOwner=this;this._hasTaskCurrZone=this._zone;if(!zoneSpec.onScheduleTask){this._scheduleTaskZS=DELEGATE_ZS;this._scheduleTaskDlgt=parentDelegate;this._scheduleTaskCurrZone=this._zone;}if(!zoneSpec.onInvokeTask){this._invokeTaskZS=DELEGATE_ZS;this._invokeTaskDlgt=parentDelegate;this._invokeTaskCurrZone=this._zone;}if(!zoneSpec.onCancelTask){this._cancelTaskZS=DELEGATE_ZS;this._cancelTaskDlgt=parentDelegate;this._cancelTaskCurrZone=this._zone;}}}fork(targetZone,zoneSpec){return this._forkZS?this._forkZS.onFork(this._forkDlgt,this.zone,targetZone,zoneSpec):new ZoneImpl(targetZone,zoneSpec);}intercept(targetZone,callback,source){return this._interceptZS?this._interceptZS.onIntercept(this._interceptDlgt,this._interceptCurrZone,targetZone,callback,source):callback;}invoke(targetZone,callback,applyThis,applyArgs,source){return this._invokeZS?this._invokeZS.onInvoke(this._invokeDlgt,this._invokeCurrZone,targetZone,callback,applyThis,applyArgs,source):callback.apply(applyThis,applyArgs);}handleError(targetZone,error){return this._handleErrorZS?this._handleErrorZS.onHandleError(this._handleErrorDlgt,this._handleErrorCurrZone,targetZone,error):true;}scheduleTask(targetZone,task){let returnTask=task;if(this._scheduleTaskZS){if(this._hasTaskZS){returnTask._zoneDelegates.push(this._hasTaskDlgtOwner);}returnTask=this._scheduleTaskZS.onScheduleTask(this._scheduleTaskDlgt,this._scheduleTaskCurrZone,targetZone,task);if(!returnTask)returnTask=task;}else {if(task.scheduleFn){task.scheduleFn(task);}else if(task.type==microTask){scheduleMicroTask(task);}else {throw new Error('Task is missing scheduleFn.');}}return returnTask;}invokeTask(targetZone,task,applyThis,applyArgs){return this._invokeTaskZS?this._invokeTaskZS.onInvokeTask(this._invokeTaskDlgt,this._invokeTaskCurrZone,targetZone,task,applyThis,applyArgs):task.callback.apply(applyThis,applyArgs);}cancelTask(targetZone,task){let value;if(this._cancelTaskZS){value=this._cancelTaskZS.onCancelTask(this._cancelTaskDlgt,this._cancelTaskCurrZone,targetZone,task);}else {if(!task.cancelFn){throw Error('Task is not cancelable');}value=task.cancelFn(task);}return value;}hasTask(targetZone,isEmpty){// hasTask should not throw error so other ZoneDelegate
    	// can still trigger hasTask callback
    	try{this._hasTaskZS&&this._hasTaskZS.onHasTask(this._hasTaskDlgt,this._hasTaskCurrZone,targetZone,isEmpty);}catch(err){this.handleError(targetZone,err);}}// tslint:disable-next-line:require-internal-with-underscore
    	_updateTaskCount(type,count){const counts=this._taskCounts;const prev=counts[type];const next=counts[type]=prev+count;if(next<0){throw new Error('More tasks executed then were scheduled.');}if(prev==0||next==0){const isEmpty={microTask:counts['microTask']>0,macroTask:counts['macroTask']>0,eventTask:counts['eventTask']>0,change:type};this.hasTask(this._zone,isEmpty);}}}class ZoneTask{constructor(type,source,callback,options,scheduleFn,cancelFn){// tslint:disable-next-line:require-internal-with-underscore
    	this._zone=null;this.runCount=0;// tslint:disable-next-line:require-internal-with-underscore
    	this._zoneDelegates=null;// tslint:disable-next-line:require-internal-with-underscore
    	this._state='notScheduled';this.type=type;this.source=source;this.data=options;this.scheduleFn=scheduleFn;this.cancelFn=cancelFn;if(!callback){throw new Error('callback is not defined');}this.callback=callback;const self=this;// TODO: @JiaLiPassion options should have interface
    	if(type===eventTask&&options&&options.useG){this.invoke=ZoneTask.invokeTask;}else {this.invoke=function(){return ZoneTask.invokeTask.call(global$1,self,this,arguments);};}}static invokeTask(task,target,args){if(!task){task=this;}_numberOfNestedTaskFrames++;try{task.runCount++;return task.zone.runTask(task,target,args);}finally{if(_numberOfNestedTaskFrames==1){drainMicroTaskQueue();}_numberOfNestedTaskFrames--;}}get zone(){return this._zone;}get state(){return this._state;}cancelScheduleRequest(){this._transitionTo(notScheduled,scheduling);}// tslint:disable-next-line:require-internal-with-underscore
    	_transitionTo(toState,fromState1,fromState2){if(this._state===fromState1||this._state===fromState2){this._state=toState;if(toState==notScheduled){this._zoneDelegates=null;}}else {throw new Error(`${this.type} '${this.source}': can not transition to '${toState}', expecting state '${fromState1}'${fromState2?" or '"+fromState2+"'":''}, was '${this._state}'.`);}}toString(){if(this.data&&typeof this.data.handleId!=='undefined'){return this.data.handleId.toString();}else {return Object.prototype.toString.call(this);}}// add toJSON method to prevent cyclic error when
    	// call JSON.stringify(zoneTask)
    	toJSON(){return {type:this.type,state:this.state,source:this.source,zone:this.zone.name,runCount:this.runCount};}}//////////////////////////////////////////////////////
    	//////////////////////////////////////////////////////
    	///  MICROTASK QUEUE
    	//////////////////////////////////////////////////////
    	//////////////////////////////////////////////////////
    	const symbolSetTimeout=__symbol__('setTimeout');const symbolPromise=__symbol__('Promise');const symbolThen=__symbol__('then');let _microTaskQueue=[];let _isDrainingMicrotaskQueue=false;let nativeMicroTaskQueuePromise;function nativeScheduleMicroTask(func){if(!nativeMicroTaskQueuePromise){if(global$1[symbolPromise]){nativeMicroTaskQueuePromise=global$1[symbolPromise].resolve(0);}}if(nativeMicroTaskQueuePromise){let nativeThen=nativeMicroTaskQueuePromise[symbolThen];if(!nativeThen){// native Promise is not patchable, we need to use `then` directly
    	// issue 1078
    	nativeThen=nativeMicroTaskQueuePromise['then'];}nativeThen.call(nativeMicroTaskQueuePromise,func);}else {global$1[symbolSetTimeout](func,0);}}function scheduleMicroTask(task){// if we are not running in any task, and there has not been anything scheduled
    	// we must bootstrap the initial task creation by manually scheduling the drain
    	if(_numberOfNestedTaskFrames===0&&_microTaskQueue.length===0){// We are not running in Task, so we need to kickstart the microtask queue.
    	nativeScheduleMicroTask(drainMicroTaskQueue);}task&&_microTaskQueue.push(task);}function drainMicroTaskQueue(){if(!_isDrainingMicrotaskQueue){_isDrainingMicrotaskQueue=true;while(_microTaskQueue.length){const queue=_microTaskQueue;_microTaskQueue=[];for(let i=0;i<queue.length;i++){const task=queue[i];try{task.zone.runTask(task,null,null);}catch(error){_api.onUnhandledError(error);}}}_api.microtaskDrainDone();_isDrainingMicrotaskQueue=false;}}//////////////////////////////////////////////////////
    	//////////////////////////////////////////////////////
    	///  BOOTSTRAP
    	//////////////////////////////////////////////////////
    	//////////////////////////////////////////////////////
    	const NO_ZONE={name:'NO ZONE'};const notScheduled='notScheduled',scheduling='scheduling',scheduled='scheduled',running='running',canceling='canceling',unknown='unknown';const microTask='microTask',macroTask='macroTask',eventTask='eventTask';const patches={};const _api={symbol:__symbol__,currentZoneFrame:()=>_currentZoneFrame,onUnhandledError:noop,microtaskDrainDone:noop,scheduleMicroTask:scheduleMicroTask,showUncaughtError:()=>!ZoneImpl[__symbol__('ignoreConsoleErrorUncaughtError')],patchEventTarget:()=>[],patchOnProperties:noop,patchMethod:()=>noop,bindArguments:()=>[],patchThen:()=>noop,patchMacroTask:()=>noop,patchEventPrototype:()=>noop,isIEOrEdge:()=>false,getGlobalObjects:()=>undefined,ObjectDefineProperty:()=>noop,ObjectGetOwnPropertyDescriptor:()=>undefined,ObjectCreate:()=>undefined,ArraySlice:()=>[],patchClass:()=>noop,wrapWithCurrentZone:()=>noop,filterProperties:()=>[],attachOriginToPatched:()=>noop,_redefineProperty:()=>noop,patchCallbacks:()=>noop,nativeScheduleMicroTask:nativeScheduleMicroTask};let _currentZoneFrame={parent:null,zone:new ZoneImpl(null,null)};let _currentTask=null;let _numberOfNestedTaskFrames=0;function noop(){}performanceMeasure('Zone','Zone');return ZoneImpl;}function loadZone(){var _Zone,_global$_Zone;// if global['Zone'] already exists (maybe zone.js was already loaded or
    	// some other lib also registered a global object named Zone), we may need
    	// to throw an error, but sometimes user may not want this error.
    	// For example,
    	// we have two web pages, page1 includes zone.js, page2 doesn't.
    	// and the 1st time user load page1 and page2, everything work fine,
    	// but when user load page2 again, error occurs because global['Zone'] already exists.
    	// so we add a flag to let user choose whether to throw this error or not.
    	// By default, if existing Zone is from zone.js, we will not throw the error.
    	const global=globalThis;const checkDuplicate=global[__symbol__('forceDuplicateZoneCheck')]===true;if(global['Zone']&&(checkDuplicate||typeof global['Zone'].__symbol__!=='function')){throw new Error('Zone already loaded.');}// Initialize global `Zone` constant.
    	(_global$_Zone=global[_Zone='Zone'])!==null&&_global$_Zone!==void 0?_global$_Zone:global[_Zone]=initZone();return global['Zone'];}/**
    	 * Suppress closure compiler errors about unknown 'Zone' variable
    	 * @fileoverview
    	 * @suppress {undefinedVars,globalThis,missingRequire}
    	 */// issue #989, to reduce bundle size, use short name
    	/** Object.getOwnPropertyDescriptor */const ObjectGetOwnPropertyDescriptor=Object.getOwnPropertyDescriptor;/** Object.defineProperty */const ObjectDefineProperty=Object.defineProperty;/** Object.getPrototypeOf */const ObjectGetPrototypeOf=Object.getPrototypeOf;/** Object.create */const ObjectCreate=Object.create;/** Array.prototype.slice */const ArraySlice=Array.prototype.slice;/** addEventListener string const */const ADD_EVENT_LISTENER_STR='addEventListener';/** removeEventListener string const */const REMOVE_EVENT_LISTENER_STR='removeEventListener';/** zoneSymbol addEventListener */const ZONE_SYMBOL_ADD_EVENT_LISTENER=__symbol__(ADD_EVENT_LISTENER_STR);/** zoneSymbol removeEventListener */const ZONE_SYMBOL_REMOVE_EVENT_LISTENER=__symbol__(REMOVE_EVENT_LISTENER_STR);/** true string const */const TRUE_STR='true';/** false string const */const FALSE_STR='false';/** Zone symbol prefix string const. */const ZONE_SYMBOL_PREFIX=__symbol__('');function wrapWithCurrentZone(callback,source){return Zone.current.wrap(callback,source);}function scheduleMacroTaskWithCurrentZone(source,callback,data,customSchedule,customCancel){return Zone.current.scheduleMacroTask(source,callback,data,customSchedule,customCancel);}const zoneSymbol=__symbol__;const isWindowExists=typeof window!=='undefined';const internalWindow=isWindowExists?window:undefined;const _global$1=isWindowExists&&internalWindow||globalThis;const REMOVE_ATTRIBUTE='removeAttribute';function bindArguments(args,source){for(let i=args.length-1;i>=0;i--){if(typeof args[i]==='function'){args[i]=wrapWithCurrentZone(args[i],source+'_'+i);}}return args;}function patchPrototype(prototype,fnNames){const source=prototype.constructor['name'];for(let i=0;i<fnNames.length;i++){const name=fnNames[i];const delegate=prototype[name];if(delegate){const prototypeDesc=ObjectGetOwnPropertyDescriptor(prototype,name);if(!isPropertyWritable(prototypeDesc)){continue;}prototype[name]=(delegate=>{const patched=function(){return delegate.apply(this,bindArguments(arguments,source+'.'+name));};attachOriginToPatched(patched,delegate);return patched;})(delegate);}}}function isPropertyWritable(propertyDesc){if(!propertyDesc){return true;}if(propertyDesc.writable===false){return false;}return !(typeof propertyDesc.get==='function'&&typeof propertyDesc.set==='undefined');}const isWebWorker=typeof WorkerGlobalScope!=='undefined'&&self instanceof WorkerGlobalScope;// Make sure to access `process` through `_global` so that WebPack does not accidentally browserify
    	// this code.
    	const isNode$1=!('nw'in _global$1)&&typeof _global$1.process!=='undefined'&&_global$1.process.toString()==='[object process]';const isBrowser=!isNode$1&&!isWebWorker&&!!(isWindowExists&&internalWindow['HTMLElement']);// we are in electron of nw, so we are both browser and nodejs
    	// Make sure to access `process` through `_global` so that WebPack does not accidentally browserify
    	// this code.
    	const isMix=typeof _global$1.process!=='undefined'&&_global$1.process.toString()==='[object process]'&&!isWebWorker&&!!(isWindowExists&&internalWindow['HTMLElement']);const zoneSymbolEventNames$1={};const enableBeforeunloadSymbol=zoneSymbol('enable_beforeunload');const wrapFn=function(event){// https://github.com/angular/zone.js/issues/911, in IE, sometimes
    	// event will be undefined, so we need to use window.event
    	event=event||_global$1.event;if(!event){return;}let eventNameSymbol=zoneSymbolEventNames$1[event.type];if(!eventNameSymbol){eventNameSymbol=zoneSymbolEventNames$1[event.type]=zoneSymbol('ON_PROPERTY'+event.type);}const target=this||event.target||_global$1;const listener=target[eventNameSymbol];let result;if(isBrowser&&target===internalWindow&&event.type==='error'){// window.onerror have different signature
    	// https://developer.mozilla.org/en-US/docs/Web/API/GlobalEventHandlers/onerror#window.onerror
    	// and onerror callback will prevent default when callback return true
    	const errorEvent=event;result=listener&&listener.call(this,errorEvent.message,errorEvent.filename,errorEvent.lineno,errorEvent.colno,errorEvent.error);if(result===true){event.preventDefault();}}else {result=listener&&listener.apply(this,arguments);if(// https://github.com/angular/angular/issues/47579
    	// https://www.w3.org/TR/2011/WD-html5-20110525/history.html#beforeunloadevent
    	// This is the only specific case we should check for. The spec defines that the
    	// `returnValue` attribute represents the message to show the user. When the event
    	// is created, this attribute must be set to the empty string.
    	event.type==='beforeunload'&&// To prevent any breaking changes resulting from this change, given that
    	// it was already causing a significant number of failures in G3, we have hidden
    	// that behavior behind a global configuration flag. Consumers can enable this
    	// flag explicitly if they want the `beforeunload` event to be handled as defined
    	// in the specification.
    	_global$1[enableBeforeunloadSymbol]&&// The IDL event definition is `attribute DOMString returnValue`, so we check whether
    	// `typeof result` is a string.
    	typeof result==='string'){event.returnValue=result;}else if(result!=undefined&&!result){event.preventDefault();}}return result;};function patchProperty(obj,prop,prototype){let desc=ObjectGetOwnPropertyDescriptor(obj,prop);if(!desc&&prototype){// when patch window object, use prototype to check prop exist or not
    	const prototypeDesc=ObjectGetOwnPropertyDescriptor(prototype,prop);if(prototypeDesc){desc={enumerable:true,configurable:true};}}// if the descriptor not exists or is not configurable
    	// just return
    	if(!desc||!desc.configurable){return;}const onPropPatchedSymbol=zoneSymbol('on'+prop+'patched');if(obj.hasOwnProperty(onPropPatchedSymbol)&&obj[onPropPatchedSymbol]){return;}// A property descriptor cannot have getter/setter and be writable
    	// deleting the writable and value properties avoids this error:
    	//
    	// TypeError: property descriptors must not specify a value or be writable when a
    	// getter or setter has been specified
    	delete desc.writable;delete desc.value;const originalDescGet=desc.get;const originalDescSet=desc.set;// slice(2) cuz 'onclick' -> 'click', etc
    	const eventName=prop.slice(2);let eventNameSymbol=zoneSymbolEventNames$1[eventName];if(!eventNameSymbol){eventNameSymbol=zoneSymbolEventNames$1[eventName]=zoneSymbol('ON_PROPERTY'+eventName);}desc.set=function(newValue){// in some of windows's onproperty callback, this is undefined
    	// so we need to check it
    	let target=this;if(!target&&obj===_global$1){target=_global$1;}if(!target){return;}const previousValue=target[eventNameSymbol];if(typeof previousValue==='function'){target.removeEventListener(eventName,wrapFn);}// issue #978, when onload handler was added before loading zone.js
    	// we should remove it with originalDescSet
    	originalDescSet&&originalDescSet.call(target,null);target[eventNameSymbol]=newValue;if(typeof newValue==='function'){target.addEventListener(eventName,wrapFn,false);}};// The getter would return undefined for unassigned properties but the default value of an
    	// unassigned property is null
    	desc.get=function(){// in some of windows's onproperty callback, this is undefined
    	// so we need to check it
    	let target=this;if(!target&&obj===_global$1){target=_global$1;}if(!target){return null;}const listener=target[eventNameSymbol];if(listener){return listener;}else if(originalDescGet){// result will be null when use inline event attribute,
    	// such as <button onclick="func();">OK</button>
    	// because the onclick function is internal raw uncompiled handler
    	// the onclick will be evaluated when first time event was triggered or
    	// the property is accessed, https://github.com/angular/zone.js/issues/525
    	// so we should use original native get to retrieve the handler
    	let value=originalDescGet.call(this);if(value){desc.set.call(this,value);if(typeof target[REMOVE_ATTRIBUTE]==='function'){target.removeAttribute(prop);}return value;}}return null;};ObjectDefineProperty(obj,prop,desc);obj[onPropPatchedSymbol]=true;}function patchOnProperties(obj,properties,prototype){if(properties){for(let i=0;i<properties.length;i++){patchProperty(obj,'on'+properties[i],prototype);}}else {const onProperties=[];for(const prop in obj){if(prop.slice(0,2)=='on'){onProperties.push(prop);}}for(let j=0;j<onProperties.length;j++){patchProperty(obj,onProperties[j],prototype);}}}const originalInstanceKey=zoneSymbol('originalInstance');// wrap some native API on `window`
    	function patchClass(className){const OriginalClass=_global$1[className];if(!OriginalClass)return;// keep original class in global
    	_global$1[zoneSymbol(className)]=OriginalClass;_global$1[className]=function(){const a=bindArguments(arguments,className);switch(a.length){case 0:this[originalInstanceKey]=new OriginalClass();break;case 1:this[originalInstanceKey]=new OriginalClass(a[0]);break;case 2:this[originalInstanceKey]=new OriginalClass(a[0],a[1]);break;case 3:this[originalInstanceKey]=new OriginalClass(a[0],a[1],a[2]);break;case 4:this[originalInstanceKey]=new OriginalClass(a[0],a[1],a[2],a[3]);break;default:throw new Error('Arg list too long.');}};// attach original delegate to patched function
    	attachOriginToPatched(_global$1[className],OriginalClass);const instance=new OriginalClass(function(){});let prop;for(prop in instance){// https://bugs.webkit.org/show_bug.cgi?id=44721
    	if(className==='XMLHttpRequest'&&prop==='responseBlob')continue;(function(prop){if(typeof instance[prop]==='function'){_global$1[className].prototype[prop]=function(){return this[originalInstanceKey][prop].apply(this[originalInstanceKey],arguments);};}else {ObjectDefineProperty(_global$1[className].prototype,prop,{set:function(fn){if(typeof fn==='function'){this[originalInstanceKey][prop]=wrapWithCurrentZone(fn,className+'.'+prop);// keep callback in wrapped function so we can
    	// use it in Function.prototype.toString to return
    	// the native one.
    	attachOriginToPatched(this[originalInstanceKey][prop],fn);}else {this[originalInstanceKey][prop]=fn;}},get:function(){return this[originalInstanceKey][prop];}});}})(prop);}for(prop in OriginalClass){if(prop!=='prototype'&&OriginalClass.hasOwnProperty(prop)){_global$1[className][prop]=OriginalClass[prop];}}}function patchMethod(target,name,patchFn){let proto=target;while(proto&&!proto.hasOwnProperty(name)){proto=ObjectGetPrototypeOf(proto);}if(!proto&&target[name]){// somehow we did not find it, but we can see it. This happens on IE for Window properties.
    	proto=target;}const delegateName=zoneSymbol(name);let delegate=null;if(proto&&(!(delegate=proto[delegateName])||!proto.hasOwnProperty(delegateName))){delegate=proto[delegateName]=proto[name];// check whether proto[name] is writable
    	// some property is readonly in safari, such as HtmlCanvasElement.prototype.toBlob
    	const desc=proto&&ObjectGetOwnPropertyDescriptor(proto,name);if(isPropertyWritable(desc)){const patchDelegate=patchFn(delegate,delegateName,name);proto[name]=function(){return patchDelegate(this,arguments);};attachOriginToPatched(proto[name],delegate);}}return delegate;}// TODO: @JiaLiPassion, support cancel task later if necessary
    	function patchMacroTask(obj,funcName,metaCreator){let setNative=null;function scheduleTask(task){const data=task.data;data.args[data.cbIdx]=function(){task.invoke.apply(this,arguments);};setNative.apply(data.target,data.args);return task;}setNative=patchMethod(obj,funcName,delegate=>function(self,args){const meta=metaCreator(self,args);if(meta.cbIdx>=0&&typeof args[meta.cbIdx]==='function'){return scheduleMacroTaskWithCurrentZone(meta.name,args[meta.cbIdx],meta,scheduleTask);}else {// cause an error by calling it directly.
    	return delegate.apply(self,args);}});}function attachOriginToPatched(patched,original){patched[zoneSymbol('OriginalDelegate')]=original;}let isDetectedIEOrEdge=false;let ieOrEdge=false;function isIE(){try{const ua=internalWindow.navigator.userAgent;if(ua.indexOf('MSIE ')!==-1||ua.indexOf('Trident/')!==-1){return true;}}catch(error){}return false;}function isIEOrEdge(){if(isDetectedIEOrEdge){return ieOrEdge;}isDetectedIEOrEdge=true;try{const ua=internalWindow.navigator.userAgent;if(ua.indexOf('MSIE ')!==-1||ua.indexOf('Trident/')!==-1||ua.indexOf('Edge/')!==-1){ieOrEdge=true;}}catch(error){}return ieOrEdge;}function isFunction(value){return typeof value==='function';}function isNumber(value){return typeof value==='number';}/**
    	 * @fileoverview
    	 * @suppress {missingRequire}
    	 */// Note that passive event listeners are now supported by most modern browsers,
    	// including Chrome, Firefox, Safari, and Edge. There's a pending change that
    	// would remove support for legacy browsers by zone.js. Removing `passiveSupported`
    	// from the codebase will reduce the final code size for existing apps that still use zone.js.
    	let passiveSupported=false;if(typeof window!=='undefined'){try{const options=Object.defineProperty({},'passive',{get:function(){passiveSupported=true;}});// Note: We pass the `options` object as the event handler too. This is not compatible with the
    	// signature of `addEventListener` or `removeEventListener` but enables us to remove the handler
    	// without an actual handler.
    	window.addEventListener('test',options,options);window.removeEventListener('test',options,options);}catch(err){passiveSupported=false;}}// an identifier to tell ZoneTask do not create a new invoke closure
    	const OPTIMIZED_ZONE_EVENT_TASK_DATA={useG:true};const zoneSymbolEventNames={};const globalSources={};const EVENT_NAME_SYMBOL_REGX=new RegExp('^'+ZONE_SYMBOL_PREFIX+'(\\w+)(true|false)$');const IMMEDIATE_PROPAGATION_SYMBOL=zoneSymbol('propagationStopped');function prepareEventNames(eventName,eventNameToString){const falseEventName=(eventNameToString?eventNameToString(eventName):eventName)+FALSE_STR;const trueEventName=(eventNameToString?eventNameToString(eventName):eventName)+TRUE_STR;const symbol=ZONE_SYMBOL_PREFIX+falseEventName;const symbolCapture=ZONE_SYMBOL_PREFIX+trueEventName;zoneSymbolEventNames[eventName]={};zoneSymbolEventNames[eventName][FALSE_STR]=symbol;zoneSymbolEventNames[eventName][TRUE_STR]=symbolCapture;}function patchEventTarget(_global,api,apis,patchOptions){const ADD_EVENT_LISTENER=patchOptions&&patchOptions.add||ADD_EVENT_LISTENER_STR;const REMOVE_EVENT_LISTENER=patchOptions&&patchOptions.rm||REMOVE_EVENT_LISTENER_STR;const LISTENERS_EVENT_LISTENER=patchOptions&&patchOptions.listeners||'eventListeners';const REMOVE_ALL_LISTENERS_EVENT_LISTENER=patchOptions&&patchOptions.rmAll||'removeAllListeners';const zoneSymbolAddEventListener=zoneSymbol(ADD_EVENT_LISTENER);const ADD_EVENT_LISTENER_SOURCE='.'+ADD_EVENT_LISTENER+':';const PREPEND_EVENT_LISTENER='prependListener';const PREPEND_EVENT_LISTENER_SOURCE='.'+PREPEND_EVENT_LISTENER+':';const invokeTask=function(task,target,event){// for better performance, check isRemoved which is set
    	// by removeEventListener
    	if(task.isRemoved){return;}const delegate=task.callback;if(typeof delegate==='object'&&delegate.handleEvent){// create the bind version of handleEvent when invoke
    	task.callback=event=>delegate.handleEvent(event);task.originalDelegate=delegate;}// invoke static task.invoke
    	// need to try/catch error here, otherwise, the error in one event listener
    	// will break the executions of the other event listeners. Also error will
    	// not remove the event listener when `once` options is true.
    	let error;try{task.invoke(task,target,[event]);}catch(err){error=err;}const options=task.options;if(options&&typeof options==='object'&&options.once){// if options.once is true, after invoke once remove listener here
    	// only browser need to do this, nodejs eventEmitter will cal removeListener
    	// inside EventEmitter.once
    	const delegate=task.originalDelegate?task.originalDelegate:task.callback;target[REMOVE_EVENT_LISTENER].call(target,event.type,delegate,options);}return error;};function globalCallback(context,event,isCapture){// https://github.com/angular/zone.js/issues/911, in IE, sometimes
    	// event will be undefined, so we need to use window.event
    	event=event||_global.event;if(!event){return;}// event.target is needed for Samsung TV and SourceBuffer
    	// || global is needed https://github.com/angular/zone.js/issues/190
    	const target=context||event.target||_global;const tasks=target[zoneSymbolEventNames[event.type][isCapture?TRUE_STR:FALSE_STR]];if(tasks){const errors=[];// invoke all tasks which attached to current target with given event.type and capture = false
    	// for performance concern, if task.length === 1, just invoke
    	if(tasks.length===1){const err=invokeTask(tasks[0],target,event);err&&errors.push(err);}else {// https://github.com/angular/zone.js/issues/836
    	// copy the tasks array before invoke, to avoid
    	// the callback will remove itself or other listener
    	const copyTasks=tasks.slice();for(let i=0;i<copyTasks.length;i++){if(event&&event[IMMEDIATE_PROPAGATION_SYMBOL]===true){break;}const err=invokeTask(copyTasks[i],target,event);err&&errors.push(err);}}// Since there is only one error, we don't need to schedule microTask
    	// to throw the error.
    	if(errors.length===1){throw errors[0];}else {for(let i=0;i<errors.length;i++){const err=errors[i];api.nativeScheduleMicroTask(()=>{throw err;});}}}}// global shared zoneAwareCallback to handle all event callback with capture = false
    	const globalZoneAwareCallback=function(event){return globalCallback(this,event,false);};// global shared zoneAwareCallback to handle all event callback with capture = true
    	const globalZoneAwareCaptureCallback=function(event){return globalCallback(this,event,true);};function patchEventTargetMethods(obj,patchOptions){if(!obj){return false;}let useGlobalCallback=true;if(patchOptions&&patchOptions.useG!==undefined){useGlobalCallback=patchOptions.useG;}const validateHandler=patchOptions&&patchOptions.vh;let checkDuplicate=true;if(patchOptions&&patchOptions.chkDup!==undefined){checkDuplicate=patchOptions.chkDup;}let returnTarget=false;if(patchOptions&&patchOptions.rt!==undefined){returnTarget=patchOptions.rt;}let proto=obj;while(proto&&!proto.hasOwnProperty(ADD_EVENT_LISTENER)){proto=ObjectGetPrototypeOf(proto);}if(!proto&&obj[ADD_EVENT_LISTENER]){// somehow we did not find it, but we can see it. This happens on IE for Window properties.
    	proto=obj;}if(!proto){return false;}if(proto[zoneSymbolAddEventListener]){return false;}const eventNameToString=patchOptions&&patchOptions.eventNameToString;// We use a shared global `taskData` to pass data for `scheduleEventTask`,
    	// eliminating the need to create a new object solely for passing data.
    	// WARNING: This object has a static lifetime, meaning it is not created
    	// each time `addEventListener` is called. It is instantiated only once
    	// and captured by reference inside the `addEventListener` and
    	// `removeEventListener` functions. Do not add any new properties to this
    	// object, as doing so would necessitate maintaining the information
    	// between `addEventListener` calls.
    	const taskData={};const nativeAddEventListener=proto[zoneSymbolAddEventListener]=proto[ADD_EVENT_LISTENER];const nativeRemoveEventListener=proto[zoneSymbol(REMOVE_EVENT_LISTENER)]=proto[REMOVE_EVENT_LISTENER];const nativeListeners=proto[zoneSymbol(LISTENERS_EVENT_LISTENER)]=proto[LISTENERS_EVENT_LISTENER];const nativeRemoveAllListeners=proto[zoneSymbol(REMOVE_ALL_LISTENERS_EVENT_LISTENER)]=proto[REMOVE_ALL_LISTENERS_EVENT_LISTENER];let nativePrependEventListener;if(patchOptions&&patchOptions.prepend){nativePrependEventListener=proto[zoneSymbol(patchOptions.prepend)]=proto[patchOptions.prepend];}/**
    	         * This util function will build an option object with passive option
    	         * to handle all possible input from the user.
    	         */function buildEventListenerOptions(options,passive){if(!passiveSupported&&typeof options==='object'&&options){// doesn't support passive but user want to pass an object as options.
    	// this will not work on some old browser, so we just pass a boolean
    	// as useCapture parameter
    	return !!options.capture;}if(!passiveSupported||!passive){return options;}if(typeof options==='boolean'){return {capture:options,passive:true};}if(!options){return {passive:true};}if(typeof options==='object'&&options.passive!==false){return {...options,passive:true};}return options;}const customScheduleGlobal=function(task){// if there is already a task for the eventName + capture,
    	// just return, because we use the shared globalZoneAwareCallback here.
    	if(taskData.isExisting){return;}return nativeAddEventListener.call(taskData.target,taskData.eventName,taskData.capture?globalZoneAwareCaptureCallback:globalZoneAwareCallback,taskData.options);};/**
    	         * In the context of events and listeners, this function will be
    	         * called at the end by `cancelTask`, which, in turn, calls `task.cancelFn`.
    	         * Cancelling a task is primarily used to remove event listeners from
    	         * the task target.
    	         */const customCancelGlobal=function(task){// if task is not marked as isRemoved, this call is directly
    	// from Zone.prototype.cancelTask, we should remove the task
    	// from tasksList of target first
    	if(!task.isRemoved){const symbolEventNames=zoneSymbolEventNames[task.eventName];let symbolEventName;if(symbolEventNames){symbolEventName=symbolEventNames[task.capture?TRUE_STR:FALSE_STR];}const existingTasks=symbolEventName&&task.target[symbolEventName];if(existingTasks){for(let i=0;i<existingTasks.length;i++){const existingTask=existingTasks[i];if(existingTask===task){existingTasks.splice(i,1);// set isRemoved to data for faster invokeTask check
    	task.isRemoved=true;if(task.removeAbortListener){task.removeAbortListener();task.removeAbortListener=null;}if(existingTasks.length===0){// all tasks for the eventName + capture have gone,
    	// remove globalZoneAwareCallback and remove the task cache from target
    	task.allRemoved=true;task.target[symbolEventName]=null;}break;}}}}// if all tasks for the eventName + capture have gone,
    	// we will really remove the global event callback,
    	// if not, return
    	if(!task.allRemoved){return;}return nativeRemoveEventListener.call(task.target,task.eventName,task.capture?globalZoneAwareCaptureCallback:globalZoneAwareCallback,task.options);};const customScheduleNonGlobal=function(task){return nativeAddEventListener.call(taskData.target,taskData.eventName,task.invoke,taskData.options);};const customSchedulePrepend=function(task){return nativePrependEventListener.call(taskData.target,taskData.eventName,task.invoke,taskData.options);};const customCancelNonGlobal=function(task){return nativeRemoveEventListener.call(task.target,task.eventName,task.invoke,task.options);};const customSchedule=useGlobalCallback?customScheduleGlobal:customScheduleNonGlobal;const customCancel=useGlobalCallback?customCancelGlobal:customCancelNonGlobal;const compareTaskCallbackVsDelegate=function(task,delegate){const typeOfDelegate=typeof delegate;return typeOfDelegate==='function'&&task.callback===delegate||typeOfDelegate==='object'&&task.originalDelegate===delegate;};const compare=patchOptions&&patchOptions.diff?patchOptions.diff:compareTaskCallbackVsDelegate;const unpatchedEvents=Zone[zoneSymbol('UNPATCHED_EVENTS')];const passiveEvents=_global[zoneSymbol('PASSIVE_EVENTS')];function copyEventListenerOptions(options){if(typeof options==='object'&&options!==null){// We need to destructure the target `options` object since it may
    	// be frozen or sealed (possibly provided implicitly by a third-party
    	// library), or its properties may be readonly.
    	const newOptions={...options};// The `signal` option was recently introduced, which caused regressions in
    	// third-party scenarios where `AbortController` was directly provided to
    	// `addEventListener` as options. For instance, in cases like
    	// `document.addEventListener('keydown', callback, abortControllerInstance)`,
    	// which is valid because `AbortController` includes a `signal` getter, spreading
    	// `{...options}` wouldn't copy the `signal`. Additionally, using `Object.create`
    	// isn't feasible since `AbortController` is a built-in object type, and attempting
    	// to create a new object directly with it as the prototype might result in
    	// unexpected behavior.
    	if(options.signal){newOptions.signal=options.signal;}return newOptions;}return options;}const makeAddListener=function(nativeListener,addSource,customScheduleFn,customCancelFn){let returnTarget=arguments.length>4&&arguments[4]!==undefined?arguments[4]:false;let prepend=arguments.length>5&&arguments[5]!==undefined?arguments[5]:false;return function(){const target=this||_global;let eventName=arguments[0];if(patchOptions&&patchOptions.transferEventName){eventName=patchOptions.transferEventName(eventName);}let delegate=arguments[1];if(!delegate){return nativeListener.apply(this,arguments);}if(isNode$1&&eventName==='uncaughtException'){// don't patch uncaughtException of nodejs to prevent endless loop
    	return nativeListener.apply(this,arguments);}// don't create the bind delegate function for handleEvent
    	// case here to improve addEventListener performance
    	// we will create the bind delegate when invoke
    	let isHandleEvent=false;if(typeof delegate!=='function'){if(!delegate.handleEvent){return nativeListener.apply(this,arguments);}isHandleEvent=true;}if(validateHandler&&!validateHandler(nativeListener,delegate,target,arguments)){return;}const passive=passiveSupported&&!!passiveEvents&&passiveEvents.indexOf(eventName)!==-1;const options=copyEventListenerOptions(buildEventListenerOptions(arguments[2],passive));const signal=options===null||options===void 0?void 0:options.signal;if(signal!==null&&signal!==void 0&&signal.aborted){// the signal is an aborted one, just return without attaching the event listener.
    	return;}if(unpatchedEvents){// check unpatched list
    	for(let i=0;i<unpatchedEvents.length;i++){if(eventName===unpatchedEvents[i]){if(passive){return nativeListener.call(target,eventName,delegate,options);}else {return nativeListener.apply(this,arguments);}}}}const capture=!options?false:typeof options==='boolean'?true:options.capture;const once=options&&typeof options==='object'?options.once:false;const zone=Zone.current;let symbolEventNames=zoneSymbolEventNames[eventName];if(!symbolEventNames){prepareEventNames(eventName,eventNameToString);symbolEventNames=zoneSymbolEventNames[eventName];}const symbolEventName=symbolEventNames[capture?TRUE_STR:FALSE_STR];let existingTasks=target[symbolEventName];let isExisting=false;if(existingTasks){// already have task registered
    	isExisting=true;if(checkDuplicate){for(let i=0;i<existingTasks.length;i++){if(compare(existingTasks[i],delegate)){// same callback, same capture, same event name, just return
    	return;}}}}else {existingTasks=target[symbolEventName]=[];}let source;const constructorName=target.constructor['name'];const targetSource=globalSources[constructorName];if(targetSource){source=targetSource[eventName];}if(!source){source=constructorName+addSource+(eventNameToString?eventNameToString(eventName):eventName);}// In the code below, `options` should no longer be reassigned; instead, it
    	// should only be mutated. This is because we pass that object to the native
    	// `addEventListener`.
    	// It's generally recommended to use the same object reference for options.
    	// This ensures consistency and avoids potential issues.
    	taskData.options=options;if(once){// When using `addEventListener` with the `once` option, we don't pass
    	// the `once` option directly to the native `addEventListener` method.
    	// Instead, we keep the `once` setting and handle it ourselves.
    	taskData.options.once=false;}taskData.target=target;taskData.capture=capture;taskData.eventName=eventName;taskData.isExisting=isExisting;const data=useGlobalCallback?OPTIMIZED_ZONE_EVENT_TASK_DATA:undefined;// keep taskData into data to allow onScheduleEventTask to access the task information
    	if(data){data.taskData=taskData;}if(signal){// When using `addEventListener` with the `signal` option, we don't pass
    	// the `signal` option directly to the native `addEventListener` method.
    	// Instead, we keep the `signal` setting and handle it ourselves.
    	taskData.options.signal=undefined;}// The `scheduleEventTask` function will ultimately call `customScheduleGlobal`,
    	// which in turn calls the native `addEventListener`. This is why `taskData.options`
    	// is updated before scheduling the task, as `customScheduleGlobal` uses
    	// `taskData.options` to pass it to the native `addEventListener`.
    	const task=zone.scheduleEventTask(source,delegate,data,customScheduleFn,customCancelFn);if(signal){// after task is scheduled, we need to store the signal back to task.options
    	taskData.options.signal=signal;// Wrapping `task` in a weak reference would not prevent memory leaks. Weak references are
    	// primarily used for preventing strong references cycles. `onAbort` is always reachable
    	// as it's an event listener, so its closure retains a strong reference to the `task`.
    	const onAbort=()=>task.zone.cancelTask(task);nativeListener.call(signal,'abort',onAbort,{once:true});// We need to remove the `abort` listener when the event listener is going to be removed,
    	// as it creates a closure that captures `task`. This closure retains a reference to the
    	// `task` object even after it goes out of scope, preventing `task` from being garbage
    	// collected.
    	task.removeAbortListener=()=>signal.removeEventListener('abort',onAbort);}// should clear taskData.target to avoid memory leak
    	// issue, https://github.com/angular/angular/issues/20442
    	taskData.target=null;// need to clear up taskData because it is a global object
    	if(data){data.taskData=null;}// have to save those information to task in case
    	// application may call task.zone.cancelTask() directly
    	if(once){taskData.options.once=true;}if(!(!passiveSupported&&typeof task.options==='boolean')){// if not support passive, and we pass an option object
    	// to addEventListener, we should save the options to task
    	task.options=options;}task.target=target;task.capture=capture;task.eventName=eventName;if(isHandleEvent){// save original delegate for compare to check duplicate
    	task.originalDelegate=delegate;}if(!prepend){existingTasks.push(task);}else {existingTasks.unshift(task);}if(returnTarget){return target;}};};proto[ADD_EVENT_LISTENER]=makeAddListener(nativeAddEventListener,ADD_EVENT_LISTENER_SOURCE,customSchedule,customCancel,returnTarget);if(nativePrependEventListener){proto[PREPEND_EVENT_LISTENER]=makeAddListener(nativePrependEventListener,PREPEND_EVENT_LISTENER_SOURCE,customSchedulePrepend,customCancel,returnTarget,true);}proto[REMOVE_EVENT_LISTENER]=function(){const target=this||_global;let eventName=arguments[0];if(patchOptions&&patchOptions.transferEventName){eventName=patchOptions.transferEventName(eventName);}const options=arguments[2];const capture=!options?false:typeof options==='boolean'?true:options.capture;const delegate=arguments[1];if(!delegate){return nativeRemoveEventListener.apply(this,arguments);}if(validateHandler&&!validateHandler(nativeRemoveEventListener,delegate,target,arguments)){return;}const symbolEventNames=zoneSymbolEventNames[eventName];let symbolEventName;if(symbolEventNames){symbolEventName=symbolEventNames[capture?TRUE_STR:FALSE_STR];}const existingTasks=symbolEventName&&target[symbolEventName];// `existingTasks` may not exist if the `addEventListener` was called before
    	// it was patched by zone.js. Please refer to the attached issue for
    	// clarification, particularly after the `if` condition, before calling
    	// the native `removeEventListener`.
    	if(existingTasks){for(let i=0;i<existingTasks.length;i++){const existingTask=existingTasks[i];if(compare(existingTask,delegate)){existingTasks.splice(i,1);// set isRemoved to data for faster invokeTask check
    	existingTask.isRemoved=true;if(existingTasks.length===0){// all tasks for the eventName + capture have gone,
    	// remove globalZoneAwareCallback and remove the task cache from target
    	existingTask.allRemoved=true;target[symbolEventName]=null;// in the target, we have an event listener which is added by on_property
    	// such as target.onclick = function() {}, so we need to clear this internal
    	// property too if all delegates with capture=false were removed
    	// https:// github.com/angular/angular/issues/31643
    	// https://github.com/angular/angular/issues/54581
    	if(!capture&&typeof eventName==='string'){const onPropertySymbol=ZONE_SYMBOL_PREFIX+'ON_PROPERTY'+eventName;target[onPropertySymbol]=null;}}// In all other conditions, when `addEventListener` is called after being
    	// patched by zone.js, we would always find an event task on the `EventTarget`.
    	// This will trigger `cancelFn` on the `existingTask`, leading to `customCancelGlobal`,
    	// which ultimately removes an event listener and cleans up the abort listener
    	// (if an `AbortSignal` was provided when scheduling a task).
    	existingTask.zone.cancelTask(existingTask);if(returnTarget){return target;}return;}}}// https://github.com/angular/zone.js/issues/930
    	// We may encounter a situation where the `addEventListener` was
    	// called on the event target before zone.js is loaded, resulting
    	// in no task being stored on the event target due to its invocation
    	// of the native implementation. In this scenario, we simply need to
    	// invoke the native `removeEventListener`.
    	return nativeRemoveEventListener.apply(this,arguments);};proto[LISTENERS_EVENT_LISTENER]=function(){const target=this||_global;let eventName=arguments[0];if(patchOptions&&patchOptions.transferEventName){eventName=patchOptions.transferEventName(eventName);}const listeners=[];const tasks=findEventTasks(target,eventNameToString?eventNameToString(eventName):eventName);for(let i=0;i<tasks.length;i++){const task=tasks[i];let delegate=task.originalDelegate?task.originalDelegate:task.callback;listeners.push(delegate);}return listeners;};proto[REMOVE_ALL_LISTENERS_EVENT_LISTENER]=function(){const target=this||_global;let eventName=arguments[0];if(!eventName){const keys=Object.keys(target);for(let i=0;i<keys.length;i++){const prop=keys[i];const match=EVENT_NAME_SYMBOL_REGX.exec(prop);let evtName=match&&match[1];// in nodejs EventEmitter, removeListener event is
    	// used for monitoring the removeListener call,
    	// so just keep removeListener eventListener until
    	// all other eventListeners are removed
    	if(evtName&&evtName!=='removeListener'){this[REMOVE_ALL_LISTENERS_EVENT_LISTENER].call(this,evtName);}}// remove removeListener listener finally
    	this[REMOVE_ALL_LISTENERS_EVENT_LISTENER].call(this,'removeListener');}else {if(patchOptions&&patchOptions.transferEventName){eventName=patchOptions.transferEventName(eventName);}const symbolEventNames=zoneSymbolEventNames[eventName];if(symbolEventNames){const symbolEventName=symbolEventNames[FALSE_STR];const symbolCaptureEventName=symbolEventNames[TRUE_STR];const tasks=target[symbolEventName];const captureTasks=target[symbolCaptureEventName];if(tasks){const removeTasks=tasks.slice();for(let i=0;i<removeTasks.length;i++){const task=removeTasks[i];let delegate=task.originalDelegate?task.originalDelegate:task.callback;this[REMOVE_EVENT_LISTENER].call(this,eventName,delegate,task.options);}}if(captureTasks){const removeTasks=captureTasks.slice();for(let i=0;i<removeTasks.length;i++){const task=removeTasks[i];let delegate=task.originalDelegate?task.originalDelegate:task.callback;this[REMOVE_EVENT_LISTENER].call(this,eventName,delegate,task.options);}}}}if(returnTarget){return this;}};// for native toString patch
    	attachOriginToPatched(proto[ADD_EVENT_LISTENER],nativeAddEventListener);attachOriginToPatched(proto[REMOVE_EVENT_LISTENER],nativeRemoveEventListener);if(nativeRemoveAllListeners){attachOriginToPatched(proto[REMOVE_ALL_LISTENERS_EVENT_LISTENER],nativeRemoveAllListeners);}if(nativeListeners){attachOriginToPatched(proto[LISTENERS_EVENT_LISTENER],nativeListeners);}return true;}let results=[];for(let i=0;i<apis.length;i++){results[i]=patchEventTargetMethods(apis[i],patchOptions);}return results;}function findEventTasks(target,eventName){if(!eventName){const foundTasks=[];for(let prop in target){const match=EVENT_NAME_SYMBOL_REGX.exec(prop);let evtName=match&&match[1];if(evtName&&(!eventName||evtName===eventName)){const tasks=target[prop];if(tasks){for(let i=0;i<tasks.length;i++){foundTasks.push(tasks[i]);}}}}return foundTasks;}let symbolEventName=zoneSymbolEventNames[eventName];if(!symbolEventName){prepareEventNames(eventName);symbolEventName=zoneSymbolEventNames[eventName];}const captureFalseTasks=target[symbolEventName[FALSE_STR]];const captureTrueTasks=target[symbolEventName[TRUE_STR]];if(!captureFalseTasks){return captureTrueTasks?captureTrueTasks.slice():[];}else {return captureTrueTasks?captureFalseTasks.concat(captureTrueTasks):captureFalseTasks.slice();}}function patchEventPrototype(global,api){const Event=global['Event'];if(Event&&Event.prototype){api.patchMethod(Event.prototype,'stopImmediatePropagation',delegate=>function(self,args){self[IMMEDIATE_PROPAGATION_SYMBOL]=true;// we need to call the native stopImmediatePropagation
    	// in case in some hybrid application, some part of
    	// application will be controlled by zone, some are not
    	delegate&&delegate.apply(self,args);});}}/**
    	 * @fileoverview
    	 * @suppress {missingRequire}
    	 */function patchQueueMicrotask(global,api){api.patchMethod(global,'queueMicrotask',delegate=>{return function(self,args){Zone.current.scheduleMicroTask('queueMicrotask',args[0]);};});}/**
    	 * @fileoverview
    	 * @suppress {missingRequire}
    	 */const taskSymbol=zoneSymbol('zoneTask');function patchTimer(window,setName,cancelName,nameSuffix){let setNative=null;let clearNative=null;setName+=nameSuffix;cancelName+=nameSuffix;const tasksByHandleId={};function scheduleTask(task){const data=task.data;data.args[0]=function(){return task.invoke.apply(this,arguments);};const handleOrId=setNative.apply(window,data.args);// Whlist on Node.js when get can the ID by using `[Symbol.toPrimitive]()` we do
    	// to this so that we do not cause potentally leaks when using `setTimeout`
    	// since this can be periodic when using `.refresh`.
    	if(isNumber(handleOrId)){data.handleId=handleOrId;}else {data.handle=handleOrId;// On Node.js a timeout and interval can be restarted over and over again by using the `.refresh` method.
    	data.isRefreshable=isFunction(handleOrId.refresh);}return task;}function clearTask(task){const{handle,handleId}=task.data;return clearNative.call(window,handle!==null&&handle!==void 0?handle:handleId);}setNative=patchMethod(window,setName,delegate=>function(self,args){if(isFunction(args[0])){var _ref18;const options={isRefreshable:false,isPeriodic:nameSuffix==='Interval',delay:nameSuffix==='Timeout'||nameSuffix==='Interval'?args[1]||0:undefined,args:args};const callback=args[0];args[0]=function timer(){try{return callback.apply(this,arguments);}finally{// issue-934, task will be cancelled
    	// even it is a periodic task such as
    	// setInterval
    	// https://github.com/angular/angular/issues/40387
    	// Cleanup tasksByHandleId should be handled before scheduleTask
    	// Since some zoneSpec may intercept and doesn't trigger
    	// scheduleFn(scheduleTask) provided here.
    	const{handle,handleId,isPeriodic,isRefreshable}=options;if(!isPeriodic&&!isRefreshable){if(handleId){// in non-nodejs env, we remove timerId
    	// from local cache
    	delete tasksByHandleId[handleId];}else if(handle){// Node returns complex objects as handleIds
    	// we remove task reference from timer object
    	handle[taskSymbol]=null;}}}};const task=scheduleMacroTaskWithCurrentZone(setName,args[0],options,scheduleTask,clearTask);if(!task){return task;}// Node.js must additionally support the ref and unref functions.
    	const{handleId,handle,isRefreshable,isPeriodic}=task.data;if(handleId){// for non nodejs env, we save handleId: task
    	// mapping in local cache for clearTimeout
    	tasksByHandleId[handleId]=task;}else if(handle){// for nodejs env, we save task
    	// reference in timerId Object for clearTimeout
    	handle[taskSymbol]=task;if(isRefreshable&&!isPeriodic){const originalRefresh=handle.refresh;handle.refresh=function(){const{zone,state}=task;if(state==='notScheduled'){task._state='scheduled';zone._updateTaskCount(task,1);}else if(state==='running'){task._state='scheduling';}return originalRefresh.call(this);};}}return (_ref18=handle!==null&&handle!==void 0?handle:handleId)!==null&&_ref18!==void 0?_ref18:task;}else {// cause an error by calling it directly.
    	return delegate.apply(window,args);}});clearNative=patchMethod(window,cancelName,delegate=>function(self,args){var _task;const id=args[0];let task;if(isNumber(id)){// non nodejs env.
    	task=tasksByHandleId[id];delete tasksByHandleId[id];}else {// nodejs env ?? other environments.
    	task=id===null||id===void 0?void 0:id[taskSymbol];if(task){id[taskSymbol]=null;}else {task=id;}}if((_task=task)!==null&&_task!==void 0&&_task.type){if(task.cancelFn){// Do not cancel already canceled functions
    	task.zone.cancelTask(task);}}else {// cause an error by calling it directly.
    	delegate.apply(window,args);}});}function patchCustomElements(_global,api){const{isBrowser,isMix}=api.getGlobalObjects();if(!isBrowser&&!isMix||!_global['customElements']||!('customElements'in _global)){return;}// https://html.spec.whatwg.org/multipage/custom-elements.html#concept-custom-element-definition-lifecycle-callbacks
    	const callbacks=['connectedCallback','disconnectedCallback','adoptedCallback','attributeChangedCallback','formAssociatedCallback','formDisabledCallback','formResetCallback','formStateRestoreCallback'];api.patchCallbacks(api,_global.customElements,'customElements','define',callbacks);}function eventTargetPatch(_global,api){if(Zone[api.symbol('patchEventTarget')]){// EventTarget is already patched.
    	return;}const{eventNames,zoneSymbolEventNames,TRUE_STR,FALSE_STR,ZONE_SYMBOL_PREFIX}=api.getGlobalObjects();//  predefine all __zone_symbol__ + eventName + true/false string
    	for(let i=0;i<eventNames.length;i++){const eventName=eventNames[i];const falseEventName=eventName+FALSE_STR;const trueEventName=eventName+TRUE_STR;const symbol=ZONE_SYMBOL_PREFIX+falseEventName;const symbolCapture=ZONE_SYMBOL_PREFIX+trueEventName;zoneSymbolEventNames[eventName]={};zoneSymbolEventNames[eventName][FALSE_STR]=symbol;zoneSymbolEventNames[eventName][TRUE_STR]=symbolCapture;}const EVENT_TARGET=_global['EventTarget'];if(!EVENT_TARGET||!EVENT_TARGET.prototype){return;}api.patchEventTarget(_global,api,[EVENT_TARGET&&EVENT_TARGET.prototype]);return true;}function patchEvent(global,api){api.patchEventPrototype(global,api);}/**
    	 * @fileoverview
    	 * @suppress {globalThis}
    	 */function filterProperties(target,onProperties,ignoreProperties){if(!ignoreProperties||ignoreProperties.length===0){return onProperties;}const tip=ignoreProperties.filter(ip=>ip.target===target);if(!tip||tip.length===0){return onProperties;}const targetIgnoreProperties=tip[0].ignoreProperties;return onProperties.filter(op=>targetIgnoreProperties.indexOf(op)===-1);}function patchFilteredProperties(target,onProperties,ignoreProperties,prototype){// check whether target is available, sometimes target will be undefined
    	// because different browser or some 3rd party plugin.
    	if(!target){return;}const filteredProperties=filterProperties(target,onProperties,ignoreProperties);patchOnProperties(target,filteredProperties,prototype);}/**
    	 * Get all event name properties which the event name startsWith `on`
    	 * from the target object itself, inherited properties are not considered.
    	 */function getOnEventNames(target){return Object.getOwnPropertyNames(target).filter(name=>name.startsWith('on')&&name.length>2).map(name=>name.substring(2));}function propertyDescriptorPatch(api,_global){if(isNode$1&&!isMix){return;}if(Zone[api.symbol('patchEvents')]){// events are already been patched by legacy patch.
    	return;}const ignoreProperties=_global['__Zone_ignore_on_properties'];// for browsers that we can patch the descriptor:  Chrome & Firefox
    	let patchTargets=[];if(isBrowser){const internalWindow=window;patchTargets=patchTargets.concat(['Document','SVGElement','Element','HTMLElement','HTMLBodyElement','HTMLMediaElement','HTMLFrameSetElement','HTMLFrameElement','HTMLIFrameElement','HTMLMarqueeElement','Worker']);const ignoreErrorProperties=isIE()?[{target:internalWindow,ignoreProperties:['error']}]:[];// in IE/Edge, onProp not exist in window object, but in WindowPrototype
    	// so we need to pass WindowPrototype to check onProp exist or not
    	patchFilteredProperties(internalWindow,getOnEventNames(internalWindow),ignoreProperties?ignoreProperties.concat(ignoreErrorProperties):ignoreProperties,ObjectGetPrototypeOf(internalWindow));}patchTargets=patchTargets.concat(['XMLHttpRequest','XMLHttpRequestEventTarget','IDBIndex','IDBRequest','IDBOpenDBRequest','IDBDatabase','IDBTransaction','IDBCursor','WebSocket']);for(let i=0;i<patchTargets.length;i++){const target=_global[patchTargets[i]];target&&target.prototype&&patchFilteredProperties(target.prototype,getOnEventNames(target.prototype),ignoreProperties);}}/**
    	 * @fileoverview
    	 * @suppress {missingRequire}
    	 */function patchBrowser(Zone){Zone.__load_patch('legacy',global=>{const legacyPatch=global[Zone.__symbol__('legacyPatch')];if(legacyPatch){legacyPatch();}});Zone.__load_patch('timers',global=>{const set='set';const clear='clear';patchTimer(global,set,clear,'Timeout');patchTimer(global,set,clear,'Interval');patchTimer(global,set,clear,'Immediate');});Zone.__load_patch('requestAnimationFrame',global=>{patchTimer(global,'request','cancel','AnimationFrame');patchTimer(global,'mozRequest','mozCancel','AnimationFrame');patchTimer(global,'webkitRequest','webkitCancel','AnimationFrame');});Zone.__load_patch('blocking',(global,Zone)=>{const blockingMethods=['alert','prompt','confirm'];for(let i=0;i<blockingMethods.length;i++){const name=blockingMethods[i];patchMethod(global,name,(delegate,symbol,name)=>{return function(s,args){return Zone.current.run(delegate,global,args,name);};});}});Zone.__load_patch('EventTarget',(global,Zone,api)=>{patchEvent(global,api);eventTargetPatch(global,api);// patch XMLHttpRequestEventTarget's addEventListener/removeEventListener
    	const XMLHttpRequestEventTarget=global['XMLHttpRequestEventTarget'];if(XMLHttpRequestEventTarget&&XMLHttpRequestEventTarget.prototype){api.patchEventTarget(global,api,[XMLHttpRequestEventTarget.prototype]);}});Zone.__load_patch('MutationObserver',(global,Zone,api)=>{patchClass('MutationObserver');patchClass('WebKitMutationObserver');});Zone.__load_patch('IntersectionObserver',(global,Zone,api)=>{patchClass('IntersectionObserver');});Zone.__load_patch('FileReader',(global,Zone,api)=>{patchClass('FileReader');});Zone.__load_patch('on_property',(global,Zone,api)=>{propertyDescriptorPatch(api,global);});Zone.__load_patch('customElements',(global,Zone,api)=>{patchCustomElements(global,api);});Zone.__load_patch('XHR',(global,Zone)=>{// Treat XMLHttpRequest as a macrotask.
    	patchXHR(global);const XHR_TASK=zoneSymbol('xhrTask');const XHR_SYNC=zoneSymbol('xhrSync');const XHR_LISTENER=zoneSymbol('xhrListener');const XHR_SCHEDULED=zoneSymbol('xhrScheduled');const XHR_URL=zoneSymbol('xhrURL');const XHR_ERROR_BEFORE_SCHEDULED=zoneSymbol('xhrErrorBeforeScheduled');function patchXHR(window){const XMLHttpRequest=window['XMLHttpRequest'];if(!XMLHttpRequest){// XMLHttpRequest is not available in service worker
    	return;}const XMLHttpRequestPrototype=XMLHttpRequest.prototype;function findPendingTask(target){return target[XHR_TASK];}let oriAddListener=XMLHttpRequestPrototype[ZONE_SYMBOL_ADD_EVENT_LISTENER];let oriRemoveListener=XMLHttpRequestPrototype[ZONE_SYMBOL_REMOVE_EVENT_LISTENER];if(!oriAddListener){const XMLHttpRequestEventTarget=window['XMLHttpRequestEventTarget'];if(XMLHttpRequestEventTarget){const XMLHttpRequestEventTargetPrototype=XMLHttpRequestEventTarget.prototype;oriAddListener=XMLHttpRequestEventTargetPrototype[ZONE_SYMBOL_ADD_EVENT_LISTENER];oriRemoveListener=XMLHttpRequestEventTargetPrototype[ZONE_SYMBOL_REMOVE_EVENT_LISTENER];}}const READY_STATE_CHANGE='readystatechange';const SCHEDULED='scheduled';function scheduleTask(task){const data=task.data;const target=data.target;target[XHR_SCHEDULED]=false;target[XHR_ERROR_BEFORE_SCHEDULED]=false;// remove existing event listener
    	const listener=target[XHR_LISTENER];if(!oriAddListener){oriAddListener=target[ZONE_SYMBOL_ADD_EVENT_LISTENER];oriRemoveListener=target[ZONE_SYMBOL_REMOVE_EVENT_LISTENER];}if(listener){oriRemoveListener.call(target,READY_STATE_CHANGE,listener);}const newListener=target[XHR_LISTENER]=()=>{if(target.readyState===target.DONE){// sometimes on some browsers XMLHttpRequest will fire onreadystatechange with
    	// readyState=4 multiple times, so we need to check task state here
    	if(!data.aborted&&target[XHR_SCHEDULED]&&task.state===SCHEDULED){// check whether the xhr has registered onload listener
    	// if that is the case, the task should invoke after all
    	// onload listeners finish.
    	// Also if the request failed without response (status = 0), the load event handler
    	// will not be triggered, in that case, we should also invoke the placeholder callback
    	// to close the XMLHttpRequest::send macroTask.
    	// https://github.com/angular/angular/issues/38795
    	const loadTasks=target[Zone.__symbol__('loadfalse')];if(target.status!==0&&loadTasks&&loadTasks.length>0){const oriInvoke=task.invoke;task.invoke=function(){// need to load the tasks again, because in other
    	// load listener, they may remove themselves
    	const loadTasks=target[Zone.__symbol__('loadfalse')];for(let i=0;i<loadTasks.length;i++){if(loadTasks[i]===task){loadTasks.splice(i,1);}}if(!data.aborted&&task.state===SCHEDULED){oriInvoke.call(task);}};loadTasks.push(task);}else {task.invoke();}}else if(!data.aborted&&target[XHR_SCHEDULED]===false){// error occurs when xhr.send()
    	target[XHR_ERROR_BEFORE_SCHEDULED]=true;}}};oriAddListener.call(target,READY_STATE_CHANGE,newListener);const storedTask=target[XHR_TASK];if(!storedTask){target[XHR_TASK]=task;}sendNative.apply(target,data.args);target[XHR_SCHEDULED]=true;return task;}function placeholderCallback(){}function clearTask(task){const data=task.data;// Note - ideally, we would call data.target.removeEventListener here, but it's too late
    	// to prevent it from firing. So instead, we store info for the event listener.
    	data.aborted=true;return abortNative.apply(data.target,data.args);}const openNative=patchMethod(XMLHttpRequestPrototype,'open',()=>function(self,args){self[XHR_SYNC]=args[2]==false;self[XHR_URL]=args[1];return openNative.apply(self,args);});const XMLHTTPREQUEST_SOURCE='XMLHttpRequest.send';const fetchTaskAborting=zoneSymbol('fetchTaskAborting');const fetchTaskScheduling=zoneSymbol('fetchTaskScheduling');const sendNative=patchMethod(XMLHttpRequestPrototype,'send',()=>function(self,args){if(Zone.current[fetchTaskScheduling]===true){// a fetch is scheduling, so we are using xhr to polyfill fetch
    	// and because we already schedule macroTask for fetch, we should
    	// not schedule a macroTask for xhr again
    	return sendNative.apply(self,args);}if(self[XHR_SYNC]){// if the XHR is sync there is no task to schedule, just execute the code.
    	return sendNative.apply(self,args);}else {const options={target:self,url:self[XHR_URL],isPeriodic:false,args:args,aborted:false};const task=scheduleMacroTaskWithCurrentZone(XMLHTTPREQUEST_SOURCE,placeholderCallback,options,scheduleTask,clearTask);if(self&&self[XHR_ERROR_BEFORE_SCHEDULED]===true&&!options.aborted&&task.state===SCHEDULED){// xhr request throw error when send
    	// we should invoke task instead of leaving a scheduled
    	// pending macroTask
    	task.invoke();}}});const abortNative=patchMethod(XMLHttpRequestPrototype,'abort',()=>function(self,args){const task=findPendingTask(self);if(task&&typeof task.type=='string'){// If the XHR has already completed, do nothing.
    	// If the XHR has already been aborted, do nothing.
    	// Fix #569, call abort multiple times before done will cause
    	// macroTask task count be negative number
    	if(task.cancelFn==null||task.data&&task.data.aborted){return;}task.zone.cancelTask(task);}else if(Zone.current[fetchTaskAborting]===true){// the abort is called from fetch polyfill, we need to call native abort of XHR.
    	return abortNative.apply(self,args);}// Otherwise, we are trying to abort an XHR which has not yet been sent, so there is no
    	// task
    	// to cancel. Do nothing.
    	});}});Zone.__load_patch('geolocation',global=>{/// GEO_LOCATION
    	if(global['navigator']&&global['navigator'].geolocation){patchPrototype(global['navigator'].geolocation,['getCurrentPosition','watchPosition']);}});Zone.__load_patch('PromiseRejectionEvent',(global,Zone)=>{// handle unhandled promise rejection
    	function findPromiseRejectionHandler(evtName){return function(e){const eventTasks=findEventTasks(global,evtName);eventTasks.forEach(eventTask=>{// windows has added unhandledrejection event listener
    	// trigger the event listener
    	const PromiseRejectionEvent=global['PromiseRejectionEvent'];if(PromiseRejectionEvent){const evt=new PromiseRejectionEvent(evtName,{promise:e.promise,reason:e.rejection});eventTask.invoke(evt);}});};}if(global['PromiseRejectionEvent']){Zone[zoneSymbol('unhandledPromiseRejectionHandler')]=findPromiseRejectionHandler('unhandledrejection');Zone[zoneSymbol('rejectionHandledHandler')]=findPromiseRejectionHandler('rejectionhandled');}});Zone.__load_patch('queueMicrotask',(global,Zone,api)=>{patchQueueMicrotask(global,api);});}function patchPromise(Zone){Zone.__load_patch('ZoneAwarePromise',(global,Zone,api)=>{const ObjectGetOwnPropertyDescriptor=Object.getOwnPropertyDescriptor;const ObjectDefineProperty=Object.defineProperty;function readableObjectToString(obj){if(obj&&obj.toString===Object.prototype.toString){const className=obj.constructor&&obj.constructor.name;return (className?className:'')+': '+JSON.stringify(obj);}return obj?obj.toString():Object.prototype.toString.call(obj);}const __symbol__=api.symbol;const _uncaughtPromiseErrors=[];const isDisableWrappingUncaughtPromiseRejection=global[__symbol__('DISABLE_WRAPPING_UNCAUGHT_PROMISE_REJECTION')]!==false;const symbolPromise=__symbol__('Promise');const symbolThen=__symbol__('then');const creationTrace='__creationTrace__';api.onUnhandledError=e=>{if(api.showUncaughtError()){const rejection=e&&e.rejection;if(rejection){console.error('Unhandled Promise rejection:',rejection instanceof Error?rejection.message:rejection,'; Zone:',e.zone.name,'; Task:',e.task&&e.task.source,'; Value:',rejection,rejection instanceof Error?rejection.stack:undefined);}else {console.error(e);}}};api.microtaskDrainDone=()=>{while(_uncaughtPromiseErrors.length){const uncaughtPromiseError=_uncaughtPromiseErrors.shift();try{uncaughtPromiseError.zone.runGuarded(()=>{if(uncaughtPromiseError.throwOriginal){throw uncaughtPromiseError.rejection;}throw uncaughtPromiseError;});}catch(error){handleUnhandledRejection(error);}}};const UNHANDLED_PROMISE_REJECTION_HANDLER_SYMBOL=__symbol__('unhandledPromiseRejectionHandler');function handleUnhandledRejection(e){api.onUnhandledError(e);try{const handler=Zone[UNHANDLED_PROMISE_REJECTION_HANDLER_SYMBOL];if(typeof handler==='function'){handler.call(this,e);}}catch(err){}}function isThenable(value){return value&&value.then;}function forwardResolution(value){return value;}function forwardRejection(rejection){return ZoneAwarePromise.reject(rejection);}const symbolState=__symbol__('state');const symbolValue=__symbol__('value');const symbolFinally=__symbol__('finally');const symbolParentPromiseValue=__symbol__('parentPromiseValue');const symbolParentPromiseState=__symbol__('parentPromiseState');const source='Promise.then';const UNRESOLVED=null;const RESOLVED=true;const REJECTED=false;const REJECTED_NO_CATCH=0;function makeResolver(promise,state){return v=>{try{resolvePromise(promise,state,v);}catch(err){resolvePromise(promise,false,err);}// Do not return value or you will break the Promise spec.
    	};}const once=function(){let wasCalled=false;return function wrapper(wrappedFunction){return function(){if(wasCalled){return;}wasCalled=true;wrappedFunction.apply(null,arguments);};};};const TYPE_ERROR='Promise resolved with itself';const CURRENT_TASK_TRACE_SYMBOL=__symbol__('currentTaskTrace');// Promise Resolution
    	function resolvePromise(promise,state,value){const onceWrapper=once();if(promise===value){throw new TypeError(TYPE_ERROR);}if(promise[symbolState]===UNRESOLVED){// should only get value.then once based on promise spec.
    	let then=null;try{if(typeof value==='object'||typeof value==='function'){then=value&&value.then;}}catch(err){onceWrapper(()=>{resolvePromise(promise,false,err);})();return promise;}// if (value instanceof ZoneAwarePromise) {
    	if(state!==REJECTED&&value instanceof ZoneAwarePromise&&value.hasOwnProperty(symbolState)&&value.hasOwnProperty(symbolValue)&&value[symbolState]!==UNRESOLVED){clearRejectedNoCatch(value);resolvePromise(promise,value[symbolState],value[symbolValue]);}else if(state!==REJECTED&&typeof then==='function'){try{then.call(value,onceWrapper(makeResolver(promise,state)),onceWrapper(makeResolver(promise,false)));}catch(err){onceWrapper(()=>{resolvePromise(promise,false,err);})();}}else {promise[symbolState]=state;const queue=promise[symbolValue];promise[symbolValue]=value;if(promise[symbolFinally]===symbolFinally){// the promise is generated by Promise.prototype.finally
    	if(state===RESOLVED){// the state is resolved, should ignore the value
    	// and use parent promise value
    	promise[symbolState]=promise[symbolParentPromiseState];promise[symbolValue]=promise[symbolParentPromiseValue];}}// record task information in value when error occurs, so we can
    	// do some additional work such as render longStackTrace
    	if(state===REJECTED&&value instanceof Error){// check if longStackTraceZone is here
    	const trace=Zone.currentTask&&Zone.currentTask.data&&Zone.currentTask.data[creationTrace];if(trace){// only keep the long stack trace into error when in longStackTraceZone
    	ObjectDefineProperty(value,CURRENT_TASK_TRACE_SYMBOL,{configurable:true,enumerable:false,writable:true,value:trace});}}for(let i=0;i<queue.length;){scheduleResolveOrReject(promise,queue[i++],queue[i++],queue[i++],queue[i++]);}if(queue.length==0&&state==REJECTED){promise[symbolState]=REJECTED_NO_CATCH;let uncaughtPromiseError=value;try{// Here we throws a new Error to print more readable error log
    	// and if the value is not an error, zone.js builds an `Error`
    	// Object here to attach the stack information.
    	throw new Error('Uncaught (in promise): '+readableObjectToString(value)+(value&&value.stack?'\n'+value.stack:''));}catch(err){uncaughtPromiseError=err;}if(isDisableWrappingUncaughtPromiseRejection){// If disable wrapping uncaught promise reject
    	// use the value instead of wrapping it.
    	uncaughtPromiseError.throwOriginal=true;}uncaughtPromiseError.rejection=value;uncaughtPromiseError.promise=promise;uncaughtPromiseError.zone=Zone.current;uncaughtPromiseError.task=Zone.currentTask;_uncaughtPromiseErrors.push(uncaughtPromiseError);api.scheduleMicroTask();// to make sure that it is running
    	}}}// Resolving an already resolved promise is a noop.
    	return promise;}const REJECTION_HANDLED_HANDLER=__symbol__('rejectionHandledHandler');function clearRejectedNoCatch(promise){if(promise[symbolState]===REJECTED_NO_CATCH){// if the promise is rejected no catch status
    	// and queue.length > 0, means there is a error handler
    	// here to handle the rejected promise, we should trigger
    	// windows.rejectionhandled eventHandler or nodejs rejectionHandled
    	// eventHandler
    	try{const handler=Zone[REJECTION_HANDLED_HANDLER];if(handler&&typeof handler==='function'){handler.call(this,{rejection:promise[symbolValue],promise:promise});}}catch(err){}promise[symbolState]=REJECTED;for(let i=0;i<_uncaughtPromiseErrors.length;i++){if(promise===_uncaughtPromiseErrors[i].promise){_uncaughtPromiseErrors.splice(i,1);}}}}function scheduleResolveOrReject(promise,zone,chainPromise,onFulfilled,onRejected){clearRejectedNoCatch(promise);const promiseState=promise[symbolState];const delegate=promiseState?typeof onFulfilled==='function'?onFulfilled:forwardResolution:typeof onRejected==='function'?onRejected:forwardRejection;zone.scheduleMicroTask(source,()=>{try{const parentPromiseValue=promise[symbolValue];const isFinallyPromise=!!chainPromise&&symbolFinally===chainPromise[symbolFinally];if(isFinallyPromise){// if the promise is generated from finally call, keep parent promise's state and value
    	chainPromise[symbolParentPromiseValue]=parentPromiseValue;chainPromise[symbolParentPromiseState]=promiseState;}// should not pass value to finally callback
    	const value=zone.run(delegate,undefined,isFinallyPromise&&delegate!==forwardRejection&&delegate!==forwardResolution?[]:[parentPromiseValue]);resolvePromise(chainPromise,true,value);}catch(error){// if error occurs, should always return this error
    	resolvePromise(chainPromise,false,error);}},chainPromise);}const ZONE_AWARE_PROMISE_TO_STRING='function ZoneAwarePromise() { [native code] }';const noop=function(){};const AggregateError=global.AggregateError;class ZoneAwarePromise{static toString(){return ZONE_AWARE_PROMISE_TO_STRING;}static resolve(value){if(value instanceof ZoneAwarePromise){return value;}return resolvePromise(new this(null),RESOLVED,value);}static reject(error){return resolvePromise(new this(null),REJECTED,error);}static withResolvers(){const result={};result.promise=new ZoneAwarePromise((res,rej)=>{result.resolve=res;result.reject=rej;});return result;}static any(values){if(!values||typeof values[Symbol.iterator]!=='function'){return Promise.reject(new AggregateError([],'All promises were rejected'));}const promises=[];let count=0;try{for(let v of values){count++;promises.push(ZoneAwarePromise.resolve(v));}}catch(err){return Promise.reject(new AggregateError([],'All promises were rejected'));}if(count===0){return Promise.reject(new AggregateError([],'All promises were rejected'));}let finished=false;const errors=[];return new ZoneAwarePromise((resolve,reject)=>{for(let i=0;i<promises.length;i++){promises[i].then(v=>{if(finished){return;}finished=true;resolve(v);},err=>{errors.push(err);count--;if(count===0){finished=true;reject(new AggregateError(errors,'All promises were rejected'));}});}});}static race(values){let resolve;let reject;let promise=new this((res,rej)=>{resolve=res;reject=rej;});function onResolve(value){resolve(value);}function onReject(error){reject(error);}for(let value of values){if(!isThenable(value)){value=this.resolve(value);}value.then(onResolve,onReject);}return promise;}static all(values){return ZoneAwarePromise.allWithCallback(values);}static allSettled(values){const P=this&&this.prototype instanceof ZoneAwarePromise?this:ZoneAwarePromise;return P.allWithCallback(values,{thenCallback:value=>({status:'fulfilled',value}),errorCallback:err=>({status:'rejected',reason:err})});}static allWithCallback(values,callback){let resolve;let reject;let promise=new this((res,rej)=>{resolve=res;reject=rej;});// Start at 2 to prevent prematurely resolving if .then is called immediately.
    	let unresolvedCount=2;let valueIndex=0;const resolvedValues=[];for(let value of values){if(!isThenable(value)){value=this.resolve(value);}const curValueIndex=valueIndex;try{value.then(value=>{resolvedValues[curValueIndex]=callback?callback.thenCallback(value):value;unresolvedCount--;if(unresolvedCount===0){resolve(resolvedValues);}},err=>{if(!callback){reject(err);}else {resolvedValues[curValueIndex]=callback.errorCallback(err);unresolvedCount--;if(unresolvedCount===0){resolve(resolvedValues);}}});}catch(thenErr){reject(thenErr);}unresolvedCount++;valueIndex++;}// Make the unresolvedCount zero-based again.
    	unresolvedCount-=2;if(unresolvedCount===0){resolve(resolvedValues);}return promise;}constructor(executor){const promise=this;if(!(promise instanceof ZoneAwarePromise)){throw new Error('Must be an instanceof Promise.');}promise[symbolState]=UNRESOLVED;promise[symbolValue]=[];// queue;
    	try{const onceWrapper=once();executor&&executor(onceWrapper(makeResolver(promise,RESOLVED)),onceWrapper(makeResolver(promise,REJECTED)));}catch(error){resolvePromise(promise,false,error);}}get[Symbol.toStringTag](){return 'Promise';}get[Symbol.species](){return ZoneAwarePromise;}then(onFulfilled,onRejected){var _this$constructor;// We must read `Symbol.species` safely because `this` may be anything. For instance, `this`
    	// may be an object without a prototype (created through `Object.create(null)`); thus
    	// `this.constructor` will be undefined. One of the use cases is SystemJS creating
    	// prototype-less objects (modules) via `Object.create(null)`. The SystemJS creates an empty
    	// object and copies promise properties into that object (within the `getOrCreateLoad`
    	// function). The zone.js then checks if the resolved value has the `then` method and
    	// invokes it with the `value` context. Otherwise, this will throw an error: `TypeError:
    	// Cannot read properties of undefined (reading 'Symbol(Symbol.species)')`.
    	let C=(_this$constructor=this.constructor)===null||_this$constructor===void 0?void 0:_this$constructor[Symbol.species];if(!C||typeof C!=='function'){C=this.constructor||ZoneAwarePromise;}const chainPromise=new C(noop);const zone=Zone.current;if(this[symbolState]==UNRESOLVED){this[symbolValue].push(zone,chainPromise,onFulfilled,onRejected);}else {scheduleResolveOrReject(this,zone,chainPromise,onFulfilled,onRejected);}return chainPromise;}catch(onRejected){return this.then(null,onRejected);}finally(onFinally){var _this$constructor2;// See comment on the call to `then` about why thee `Symbol.species` is safely accessed.
    	let C=(_this$constructor2=this.constructor)===null||_this$constructor2===void 0?void 0:_this$constructor2[Symbol.species];if(!C||typeof C!=='function'){C=ZoneAwarePromise;}const chainPromise=new C(noop);chainPromise[symbolFinally]=symbolFinally;const zone=Zone.current;if(this[symbolState]==UNRESOLVED){this[symbolValue].push(zone,chainPromise,onFinally,onFinally);}else {scheduleResolveOrReject(this,zone,chainPromise,onFinally,onFinally);}return chainPromise;}}// Protect against aggressive optimizers dropping seemingly unused properties.
    	// E.g. Closure Compiler in advanced mode.
    	ZoneAwarePromise['resolve']=ZoneAwarePromise.resolve;ZoneAwarePromise['reject']=ZoneAwarePromise.reject;ZoneAwarePromise['race']=ZoneAwarePromise.race;ZoneAwarePromise['all']=ZoneAwarePromise.all;const NativePromise=global[symbolPromise]=global['Promise'];global['Promise']=ZoneAwarePromise;const symbolThenPatched=__symbol__('thenPatched');function patchThen(Ctor){const proto=Ctor.prototype;const prop=ObjectGetOwnPropertyDescriptor(proto,'then');if(prop&&(prop.writable===false||!prop.configurable)){// check Ctor.prototype.then propertyDescriptor is writable or not
    	// in meteor env, writable is false, we should ignore such case
    	return;}const originalThen=proto.then;// Keep a reference to the original method.
    	proto[symbolThen]=originalThen;Ctor.prototype.then=function(onResolve,onReject){const wrapped=new ZoneAwarePromise((resolve,reject)=>{originalThen.call(this,resolve,reject);});return wrapped.then(onResolve,onReject);};Ctor[symbolThenPatched]=true;}api.patchThen=patchThen;function zoneify(fn){return function(self,args){let resultPromise=fn.apply(self,args);if(resultPromise instanceof ZoneAwarePromise){return resultPromise;}let ctor=resultPromise.constructor;if(!ctor[symbolThenPatched]){patchThen(ctor);}return resultPromise;};}if(NativePromise){patchThen(NativePromise);patchMethod(global,'fetch',delegate=>zoneify(delegate));}// This is not part of public API, but it is useful for tests, so we expose it.
    	Promise[Zone.__symbol__('uncaughtPromiseErrors')]=_uncaughtPromiseErrors;return ZoneAwarePromise;});}function patchToString(Zone){// override Function.prototype.toString to make zone.js patched function
    	// look like native function
    	Zone.__load_patch('toString',global=>{// patch Func.prototype.toString to let them look like native
    	const originalFunctionToString=Function.prototype.toString;const ORIGINAL_DELEGATE_SYMBOL=zoneSymbol('OriginalDelegate');const PROMISE_SYMBOL=zoneSymbol('Promise');const ERROR_SYMBOL=zoneSymbol('Error');const newFunctionToString=function toString(){if(typeof this==='function'){const originalDelegate=this[ORIGINAL_DELEGATE_SYMBOL];if(originalDelegate){if(typeof originalDelegate==='function'){return originalFunctionToString.call(originalDelegate);}else {return Object.prototype.toString.call(originalDelegate);}}if(this===Promise){const nativePromise=global[PROMISE_SYMBOL];if(nativePromise){return originalFunctionToString.call(nativePromise);}}if(this===Error){const nativeError=global[ERROR_SYMBOL];if(nativeError){return originalFunctionToString.call(nativeError);}}}return originalFunctionToString.call(this);};newFunctionToString[ORIGINAL_DELEGATE_SYMBOL]=originalFunctionToString;Function.prototype.toString=newFunctionToString;// patch Object.prototype.toString to let them look like native
    	const originalObjectToString=Object.prototype.toString;const PROMISE_OBJECT_TO_STRING='[object Promise]';Object.prototype.toString=function(){if(typeof Promise==='function'&&this instanceof Promise){return PROMISE_OBJECT_TO_STRING;}return originalObjectToString.call(this);};});}function patchCallbacks(api,target,targetName,method,callbacks){const symbol=Zone.__symbol__(method);if(target[symbol]){return;}const nativeDelegate=target[symbol]=target[method];target[method]=function(name,opts,options){if(opts&&opts.prototype){callbacks.forEach(function(callback){const source=`${targetName}.${method}::`+callback;const prototype=opts.prototype;// Note: the `patchCallbacks` is used for patching the `document.registerElement` and
    	// `customElements.define`. We explicitly wrap the patching code into try-catch since
    	// callbacks may be already patched by other web components frameworks (e.g. LWC), and they
    	// make those properties non-writable. This means that patching callback will throw an error
    	// `cannot assign to read-only property`. See this code as an example:
    	// https://github.com/salesforce/lwc/blob/master/packages/@lwc/engine-core/src/framework/base-bridge-element.ts#L180-L186
    	// We don't want to stop the application rendering if we couldn't patch some
    	// callback, e.g. `attributeChangedCallback`.
    	try{if(prototype.hasOwnProperty(callback)){const descriptor=api.ObjectGetOwnPropertyDescriptor(prototype,callback);if(descriptor&&descriptor.value){descriptor.value=api.wrapWithCurrentZone(descriptor.value,source);api._redefineProperty(opts.prototype,callback,descriptor);}else if(prototype[callback]){prototype[callback]=api.wrapWithCurrentZone(prototype[callback],source);}}else if(prototype[callback]){prototype[callback]=api.wrapWithCurrentZone(prototype[callback],source);}}catch{// Note: we leave the catch block empty since there's no way to handle the error related
    	// to non-writable property.
    	}});}return nativeDelegate.call(target,name,opts,options);};api.attachOriginToPatched(target[method],nativeDelegate);}function patchUtil(Zone){Zone.__load_patch('util',(global,Zone,api)=>{// Collect native event names by looking at properties
    	// on the global namespace, e.g. 'onclick'.
    	const eventNames=getOnEventNames(global);api.patchOnProperties=patchOnProperties;api.patchMethod=patchMethod;api.bindArguments=bindArguments;api.patchMacroTask=patchMacroTask;// In earlier version of zone.js (<0.9.0), we use env name `__zone_symbol__BLACK_LISTED_EVENTS`
    	// to define which events will not be patched by `Zone.js`. In newer version (>=0.9.0), we
    	// change the env name to `__zone_symbol__UNPATCHED_EVENTS` to keep the name consistent with
    	// angular repo. The  `__zone_symbol__BLACK_LISTED_EVENTS` is deprecated, but it is still be
    	// supported for backwards compatibility.
    	const SYMBOL_BLACK_LISTED_EVENTS=Zone.__symbol__('BLACK_LISTED_EVENTS');const SYMBOL_UNPATCHED_EVENTS=Zone.__symbol__('UNPATCHED_EVENTS');if(global[SYMBOL_UNPATCHED_EVENTS]){global[SYMBOL_BLACK_LISTED_EVENTS]=global[SYMBOL_UNPATCHED_EVENTS];}if(global[SYMBOL_BLACK_LISTED_EVENTS]){Zone[SYMBOL_BLACK_LISTED_EVENTS]=Zone[SYMBOL_UNPATCHED_EVENTS]=global[SYMBOL_BLACK_LISTED_EVENTS];}api.patchEventPrototype=patchEventPrototype;api.patchEventTarget=patchEventTarget;api.isIEOrEdge=isIEOrEdge;api.ObjectDefineProperty=ObjectDefineProperty;api.ObjectGetOwnPropertyDescriptor=ObjectGetOwnPropertyDescriptor;api.ObjectCreate=ObjectCreate;api.ArraySlice=ArraySlice;api.patchClass=patchClass;api.wrapWithCurrentZone=wrapWithCurrentZone;api.filterProperties=filterProperties;api.attachOriginToPatched=attachOriginToPatched;api._redefineProperty=Object.defineProperty;api.patchCallbacks=patchCallbacks;api.getGlobalObjects=()=>({globalSources,zoneSymbolEventNames,eventNames,isBrowser,isMix,isNode:isNode$1,TRUE_STR,FALSE_STR,ZONE_SYMBOL_PREFIX,ADD_EVENT_LISTENER_STR,REMOVE_EVENT_LISTENER_STR});});}function patchCommon(Zone){patchPromise(Zone);patchToString(Zone);patchUtil(Zone);}const Zone$1=loadZone();patchCommon(Zone$1);patchBrowser(Zone$1);/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */class NoopLogger{emit(_logRecord){}}const NOOP_LOGGER=new NoopLogger();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */class NoopLoggerProvider{getLogger(_name,_version,_options){return new NoopLogger();}}const NOOP_LOGGER_PROVIDER=new NoopLoggerProvider();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */class ProxyLogger{constructor(_provider,name,version,options){this._provider=_provider;this.name=name;this.version=version;this.options=options;}/**
    	     * Emit a log record. This method should only be used by log appenders.
    	     *
    	     * @param logRecord
    	     */emit(logRecord){this._getLogger().emit(logRecord);}/**
    	     * Try to get a logger from the proxy logger provider.
    	     * If the proxy logger provider has no delegate, return a noop logger.
    	     */_getLogger(){if(this._delegate){return this._delegate;}const logger=this._provider._getDelegateLogger(this.name,this.version,this.options);if(!logger){return NOOP_LOGGER;}this._delegate=logger;return this._delegate;}}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */class ProxyLoggerProvider{getLogger(name,version,options){var _a;return (_a=this._getDelegateLogger(name,version,options))!==null&&_a!==void 0?_a:new ProxyLogger(this,name,version,options);}/**
    	     * Get the delegate logger provider.
    	     * Used by tests only.
    	     * @internal
    	     */_getDelegate(){var _a;return (_a=this._delegate)!==null&&_a!==void 0?_a:NOOP_LOGGER_PROVIDER;}/**
    	     * Set the delegate logger provider
    	     * @internal
    	     */_setDelegate(delegate){this._delegate=delegate;}/**
    	     * @internal
    	     */_getDelegateLogger(name,version,options){var _a;return (_a=this._delegate)===null||_a===void 0?void 0:_a.getLogger(name,version,options);}}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Updates to this file should also be replicated to @opentelemetry/api and
    	// @opentelemetry/core too.
    	/**
    	 * - globalThis (New standard)
    	 * - self (Will return the current window instance for supported browsers)
    	 * - window (fallback for older browser implementations)
    	 * - global (NodeJS implementation)
    	 * - <object> (When all else fails)
    	 *//** only globals that common to node and browsers are allowed */// eslint-disable-next-line n/no-unsupported-features/es-builtins, no-undef
    	const _globalThis$1=typeof globalThis==='object'?globalThis:typeof self==='object'?self:typeof window==='object'?window:typeof commonjsGlobal==='object'?commonjsGlobal:{};/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */const GLOBAL_LOGS_API_KEY=Symbol.for('io.opentelemetry.js.api.logs');const _global=_globalThis$1;/**
    	 * Make a function which accepts a version integer and returns the instance of an API if the version
    	 * is compatible, or a fallback version (usually NOOP) if it is not.
    	 *
    	 * @param requiredVersion Backwards compatibility version which is required to return the instance
    	 * @param instance Instance which should be returned if the required version is compatible
    	 * @param fallback Fallback instance, usually NOOP, which will be returned if the required version is not compatible
    	 */function makeGetter(requiredVersion,instance,fallback){return version=>version===requiredVersion?instance:fallback;}/**
    	 * A number which should be incremented each time a backwards incompatible
    	 * change is made to the API. This number is used when an API package
    	 * attempts to access the global API to ensure it is getting a compatible
    	 * version. If the global API is not compatible with the API package
    	 * attempting to get it, a NOOP API implementation will be returned.
    	 */const API_BACKWARDS_COMPATIBILITY_VERSION=1;/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */class LogsAPI{constructor(){this._proxyLoggerProvider=new ProxyLoggerProvider();}static getInstance(){if(!this._instance){this._instance=new LogsAPI();}return this._instance;}setGlobalLoggerProvider(provider){if(_global[GLOBAL_LOGS_API_KEY]){return this.getLoggerProvider();}_global[GLOBAL_LOGS_API_KEY]=makeGetter(API_BACKWARDS_COMPATIBILITY_VERSION,provider,NOOP_LOGGER_PROVIDER);this._proxyLoggerProvider._setDelegate(provider);return provider;}/**
    	     * Returns the global logger provider.
    	     *
    	     * @returns LoggerProvider
    	     */getLoggerProvider(){var _a,_b;return (_b=(_a=_global[GLOBAL_LOGS_API_KEY])===null||_a===void 0?void 0:_a.call(_global,API_BACKWARDS_COMPATIBILITY_VERSION))!==null&&_b!==void 0?_b:this._proxyLoggerProvider;}/**
    	     * Returns a logger from the global logger provider.
    	     *
    	     * @returns Logger
    	     */getLogger(name,version,options){return this.getLoggerProvider().getLogger(name,version,options);}/** Remove the global logger provider */disable(){delete _global[GLOBAL_LOGS_API_KEY];this._proxyLoggerProvider=new ProxyLoggerProvider();}}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */const logs=LogsAPI.getInstance();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Default to complaining loudly when things don't go according to plan.
    	// eslint-disable-next-line no-console
    	let logger=console.error.bind(console);// Sets a property on an object, preserving its enumerability.
    	// This function assumes that the property is already writable.
    	function defineProperty(obj,name,value){const enumerable=!!obj[name]&&Object.prototype.propertyIsEnumerable.call(obj,name);Object.defineProperty(obj,name,{configurable:true,enumerable,writable:true,value});}const wrap=(nodule,name,wrapper)=>{if(!nodule||!nodule[name]){logger('no original function '+String(name)+' to wrap');return;}if(!wrapper){logger('no wrapper function');logger(new Error().stack);return;}const original=nodule[name];if(typeof original!=='function'||typeof wrapper!=='function'){logger('original object and wrapper must be functions');return;}const wrapped=wrapper(original,name);defineProperty(wrapped,'__original',original);defineProperty(wrapped,'__unwrap',()=>{if(nodule[name]===wrapped){defineProperty(nodule,name,original);}});defineProperty(wrapped,'__wrapped',true);defineProperty(nodule,name,wrapped);return wrapped;};const massWrap=(nodules,names,wrapper)=>{if(!nodules){logger('must provide one or more modules to patch');logger(new Error().stack);return;}else if(!Array.isArray(nodules)){nodules=[nodules];}if(!(names&&Array.isArray(names))){logger('must provide one or more functions to wrap on modules');return;}nodules.forEach(nodule=>{names.forEach(name=>{wrap(nodule,name,wrapper);});});};const unwrap=(nodule,name)=>{if(!nodule||!nodule[name]){logger('no function to unwrap.');logger(new Error().stack);return;}const wrapped=nodule[name];if(!wrapped.__unwrap){logger('no original to unwrap to -- has '+String(name)+' already been unwrapped?');}else {wrapped.__unwrap();return;}};const massUnwrap=(nodules,names)=>{if(!nodules){logger('must provide one or more modules to patch');logger(new Error().stack);return;}else if(!Array.isArray(nodules)){nodules=[nodules];}if(!(names&&Array.isArray(names))){logger('must provide one or more functions to unwrap on modules');return;}nodules.forEach(nodule=>{names.forEach(name=>{unwrap(nodule,name);});});};/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * Base abstract internal class for instrumenting node and web plugins
    	 */class InstrumentationAbstract{constructor(instrumentationName,instrumentationVersion,config){_defineProperty2(this,"instrumentationName",void 0);_defineProperty2(this,"instrumentationVersion",void 0);_defineProperty2(this,"_config",{});_defineProperty2(this,"_tracer",void 0);_defineProperty2(this,"_meter",void 0);_defineProperty2(this,"_logger",void 0);_defineProperty2(this,"_diag",void 0);/* Api to wrap instrumented method */_defineProperty2(this,"_wrap",wrap);/* Api to unwrap instrumented methods */_defineProperty2(this,"_unwrap",unwrap);/* Api to mass wrap instrumented method */_defineProperty2(this,"_massWrap",massWrap);/* Api to mass unwrap instrumented methods */_defineProperty2(this,"_massUnwrap",massUnwrap);this.instrumentationName=instrumentationName;this.instrumentationVersion=instrumentationVersion;this.setConfig(config);this._diag=diag.createComponentLogger({namespace:instrumentationName});this._tracer=trace.getTracer(instrumentationName,instrumentationVersion);this._meter=metrics.getMeter(instrumentationName,instrumentationVersion);this._logger=logs.getLogger(instrumentationName,instrumentationVersion);this._updateMetricInstruments();}/* Returns meter */get meter(){return this._meter;}/**
    	     * Sets MeterProvider to this plugin
    	     * @param meterProvider
    	     */setMeterProvider(meterProvider){this._meter=meterProvider.getMeter(this.instrumentationName,this.instrumentationVersion);this._updateMetricInstruments();}/* Returns logger */get logger(){return this._logger;}/**
    	     * Sets LoggerProvider to this plugin
    	     * @param loggerProvider
    	     */setLoggerProvider(loggerProvider){this._logger=loggerProvider.getLogger(this.instrumentationName,this.instrumentationVersion);}/**
    	     * @experimental
    	     *
    	     * Get module definitions defined by {@link init}.
    	     * This can be used for experimental compile-time instrumentation.
    	     *
    	     * @returns an array of {@link InstrumentationModuleDefinition}
    	     */getModuleDefinitions(){var _this$init;const initResult=(_this$init=this.init())!==null&&_this$init!==void 0?_this$init:[];if(!Array.isArray(initResult)){return [initResult];}return initResult;}/**
    	     * Sets the new metric instruments with the current Meter.
    	     */_updateMetricInstruments(){return;}/* Returns InstrumentationConfig */getConfig(){return this._config;}/**
    	     * Sets InstrumentationConfig to this plugin
    	     * @param config
    	     */setConfig(config){// copy config first level properties to ensure they are immutable.
    	// nested properties are not copied, thus are mutable from the outside.
    	this._config={enabled:true,...config};}/**
    	     * Sets TraceProvider to this plugin
    	     * @param tracerProvider
    	     */setTracerProvider(tracerProvider){this._tracer=tracerProvider.getTracer(this.instrumentationName,this.instrumentationVersion);}/* Returns tracer */get tracer(){return this._tracer;}/**
    	     * Execute span customization hook, if configured, and log any errors.
    	     * Any semantics of the trigger and info are defined by the specific instrumentation.
    	     * @param hookHandler The optional hook handler which the user has configured via instrumentation config
    	     * @param triggerName The name of the trigger for executing the hook for logging purposes
    	     * @param span The span to which the hook should be applied
    	     * @param info The info object to be passed to the hook, with useful data the hook may use
    	     */_runSpanCustomizationHook(hookHandler,triggerName,span,info){if(!hookHandler){return;}try{hookHandler(span,info);}catch(e){this._diag.error(`Error running span customization hook due to exception in handler`,{triggerName},e);}}}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * Base abstract class for instrumenting web plugins
    	 */class InstrumentationBase extends InstrumentationAbstract{constructor(instrumentationName,instrumentationVersion,config){super(instrumentationName,instrumentationVersion,config);if(this._config.enabled){this.enable();}}}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * function to execute patched function and being able to catch errors
    	 * @param execute - function to be executed
    	 * @param onFinish - callback to run when execute finishes
    	 */function safeExecuteInTheMiddle(execute,onFinish,preventThrowingError){let error;let result;try{result=execute();}catch(e){error=e;}finally{onFinish(error,result);// eslint-disable-next-line no-unsafe-finally
    	return result;}}/**
    	 * Checks if certain function has been already wrapped
    	 * @param func
    	 */function isWrapped(func){return typeof func==='function'&&typeof func.__original==='function'&&typeof func.__unwrap==='function'&&func.__wrapped===true;}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var SemconvStability;(function(SemconvStability){/** Emit only stable semantic conventions. */SemconvStability[SemconvStability["STABLE"]=1]="STABLE";/** Emit only old semantic conventions. */SemconvStability[SemconvStability["OLD"]=2]="OLD";/** Emit both stable and old semantic conventions. */SemconvStability[SemconvStability["DUPLICATE"]=3]="DUPLICATE";})(SemconvStability||(SemconvStability={}));/**
    	 * Determine the appropriate semconv stability for the given namespace.
    	 *
    	 * This will parse the given string of comma-separated values (often
    	 * `process.env.OTEL_SEMCONV_STABILITY_OPT_IN`) looking for the `${namespace}`
    	 * or `${namespace}/dup` tokens. This is a pattern defined by a number of
    	 * non-normative semconv documents.
    	 *
    	 * For example:
    	 * - namespace 'http': https://opentelemetry.io/docs/specs/semconv/non-normative/http-migration/
    	 * - namespace 'database': https://opentelemetry.io/docs/specs/semconv/non-normative/database-migration/
    	 * - namespace 'k8s': https://opentelemetry.io/docs/specs/semconv/non-normative/k8s-migration/
    	 *
    	 * Usage:
    	 *
    	 *  import {SemconvStability, semconvStabilityFromStr} from '@opentelemetry/instrumentation';
    	 *
    	 *  export class FooInstrumentation extends InstrumentationBase<FooInstrumentationConfig> {
    	 *    private _semconvStability: SemconvStability;
    	 *    constructor(config: FooInstrumentationConfig = {}) {
    	 *      super('@opentelemetry/instrumentation-foo', VERSION, config);
    	 *
    	 *      // When supporting the OTEL_SEMCONV_STABILITY_OPT_IN envvar
    	 *      this._semconvStability = semconvStabilityFromStr(
    	 *        'http',
    	 *        process.env.OTEL_SEMCONV_STABILITY_OPT_IN
    	 *      );
    	 *
    	 *      // or when supporting a `semconvStabilityOptIn` config option (e.g. for
    	 *      // the web where there are no envvars).
    	 *      this._semconvStability = semconvStabilityFromStr(
    	 *        'http',
    	 *        config?.semconvStabilityOptIn
    	 *      );
    	 *    }
    	 *  }
    	 *
    	 *  // Then, to apply semconv, use the following or similar:
    	 *  if (this._semconvStability & SemconvStability.OLD) {
    	 *    // ...
    	 *  }
    	 *  if (this._semconvStability & SemconvStability.STABLE) {
    	 *    // ...
    	 *  }
    	 *
    	 */function semconvStabilityFromStr(namespace,str){let semconvStability=SemconvStability.OLD;// The same parsing of `str` as `getStringListFromEnv` from the core pkg.
    	const entries=str===null||str===void 0?void 0:str.split(',').map(v=>v.trim()).filter(s=>s!=='');for(const entry of entries!==null&&entries!==void 0?entries:[]){if(entry.toLowerCase()===namespace+'/dup'){// DUPLICATE takes highest precedence.
    	semconvStability=SemconvStability.DUPLICATE;break;}else if(entry.toLowerCase()===namespace){semconvStability=SemconvStability.STABLE;}}return semconvStability;}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Updates to this file should also be replicated to @opentelemetry/api too.
    	/**
    	 * - globalThis (New standard)
    	 * - self (Will return the current window instance for supported browsers)
    	 * - window (fallback for older browser implementations)
    	 * - global (NodeJS implementation)
    	 * - <object> (When all else fails)
    	 *//** only globals that common to node and browsers are allowed */// eslint-disable-next-line n/no-unsupported-features/es-builtins, no-undef
    	const _globalThis=typeof globalThis==='object'?globalThis:typeof self==='object'?self:typeof window==='object'?window:typeof commonjsGlobal==='object'?commonjsGlobal:{};/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */const otperformance=performance;/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *///----------------------------------------------------------------------------------------------------------
    	// DO NOT EDIT, this is an Auto-generated file from scripts/semconv/templates/registry/stable/attributes.ts.j2
    	//----------------------------------------------------------------------------------------------------------
    	/**
    	 * ASP.NET Core exception middleware handling result.
    	 *
    	 * @example handled
    	 * @example unhandled
    	 *//**
    	 * Describes a class of error the operation ended with.
    	 *
    	 * @example timeout
    	 * @example java.net.UnknownHostException
    	 * @example server_certificate_invalid
    	 * @example 500
    	 *
    	 * @note The `error.type` **SHOULD** be predictable, and **SHOULD** have low cardinality.
    	 *
    	 * When `error.type` is set to a type (e.g., an exception type), its
    	 * canonical class name identifying the type within the artifact **SHOULD** be used.
    	 *
    	 * Instrumentations **SHOULD** document the list of errors they report.
    	 *
    	 * The cardinality of `error.type` within one instrumentation library **SHOULD** be low.
    	 * Telemetry consumers that aggregate data from multiple instrumentation libraries and applications
    	 * should be prepared for `error.type` to have high cardinality at query time when no
    	 * additional filters are applied.
    	 *
    	 * If the operation has completed successfully, instrumentations **SHOULD NOT** set `error.type`.
    	 *
    	 * If a specific domain defines its own set of error identifiers (such as HTTP or gRPC status codes),
    	 * it's **RECOMMENDED** to:
    	 *
    	 *   - Use a domain-specific attribute
    	 *   - Set `error.type` to capture all errors, regardless of whether they are defined within the domain-specific set or not.
    	 */const ATTR_ERROR_TYPE='error.type';/**
    	 * HTTP request method.
    	 *
    	 * @example GET
    	 * @example POST
    	 * @example HEAD
    	 *
    	 * @note HTTP request method value **SHOULD** be "known" to the instrumentation.
    	 * By default, this convention defines "known" methods as the ones listed in [RFC9110](https://www.rfc-editor.org/rfc/rfc9110.html#name-methods)
    	 * and the PATCH method defined in [RFC5789](https://www.rfc-editor.org/rfc/rfc5789.html).
    	 *
    	 * If the HTTP request method is not known to instrumentation, it **MUST** set the `http.request.method` attribute to `_OTHER`.
    	 *
    	 * If the HTTP instrumentation could end up converting valid HTTP request methods to `_OTHER`, then it **MUST** provide a way to override
    	 * the list of known HTTP methods. If this override is done via environment variable, then the environment variable **MUST** be named
    	 * OTEL_INSTRUMENTATION_HTTP_KNOWN_METHODS and support a comma-separated list of case-sensitive known HTTP methods
    	 * (this list **MUST** be a full override of the default known method, it is not a list of known methods in addition to the defaults).
    	 *
    	 * HTTP method names are case-sensitive and `http.request.method` attribute value **MUST** match a known HTTP method name exactly.
    	 * Instrumentations for specific web frameworks that consider HTTP methods to be case insensitive, **SHOULD** populate a canonical equivalent.
    	 * Tracing instrumentations that do so, **MUST** also set `http.request.method_original` to the original value.
    	 */const ATTR_HTTP_REQUEST_METHOD='http.request.method';/**
    	 * Original HTTP method sent by the client in the request line.
    	 *
    	 * @example GeT
    	 * @example ACL
    	 * @example foo
    	 */const ATTR_HTTP_REQUEST_METHOD_ORIGINAL='http.request.method_original';/**
    	 * [HTTP response status code](https://tools.ietf.org/html/rfc7231#section-6).
    	 *
    	 * @example 200
    	 */const ATTR_HTTP_RESPONSE_STATUS_CODE='http.response.status_code';/**
    	 * Server domain name if available without reverse DNS lookup; otherwise, IP address or Unix domain socket name.
    	 *
    	 * @example example.com
    	 * @example 10.1.2.80
    	 * @example /tmp/my.sock
    	 *
    	 * @note When observed from the client side, and when communicating through an intermediary, `server.address` **SHOULD** represent the server address behind any intermediaries, for example proxies, if it's available.
    	 */const ATTR_SERVER_ADDRESS='server.address';/**
    	 * Server port number.
    	 *
    	 * @example 80
    	 * @example 8080
    	 * @example 443
    	 *
    	 * @note When observed from the client side, and when communicating through an intermediary, `server.port` **SHOULD** represent the server port behind any intermediaries, for example proxies, if it's available.
    	 */const ATTR_SERVER_PORT='server.port';/**
    	 * Absolute URL describing a network resource according to [RFC3986](https://www.rfc-editor.org/rfc/rfc3986)
    	 *
    	 * @example https://www.foo.bar/search?q=OpenTelemetry#SemConv
    	 * @example //localhost
    	 *
    	 * @note For network calls, URL usually has `scheme://host[:port][path][?query][#fragment]` format, where the fragment
    	 * is not transmitted over HTTP, but if it is known, it **SHOULD** be included nevertheless.
    	 *
    	 * `url.full` **MUST NOT** contain credentials passed via URL in form of `https://username:password@www.example.com/`.
    	 * In such case username and password **SHOULD** be redacted and attribute's value **SHOULD** be `https://REDACTED:REDACTED@www.example.com/`.
    	 *
    	 * `url.full` **SHOULD** capture the absolute URL when it is available (or can be reconstructed).
    	 *
    	 * Sensitive content provided in `url.full` **SHOULD** be scrubbed when instrumentations can identify it.
    	 *
    	 *
    	 * Query string values for the following keys **SHOULD** be redacted by default and replaced by the
    	 * value `REDACTED`:
    	 *
    	 *   - [`AWSAccessKeyId`](https://docs.aws.amazon.com/AmazonS3/latest/userguide/RESTAuthentication.html#RESTAuthenticationQueryStringAuth)
    	 *   - [`Signature`](https://docs.aws.amazon.com/AmazonS3/latest/userguide/RESTAuthentication.html#RESTAuthenticationQueryStringAuth)
    	 *   - [`sig`](https://learn.microsoft.com/azure/storage/common/storage-sas-overview#sas-token)
    	 *   - [`X-Goog-Signature`](https://cloud.google.com/storage/docs/access-control/signed-urls)
    	 *
    	 * This list is subject to change over time.
    	 *
    	 * When a query string value is redacted, the query string key **SHOULD** still be preserved, e.g.
    	 * `https://www.example.com/path?color=blue&sig=REDACTED`.
    	 */const ATTR_URL_FULL='url.full';/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */const NANOSECOND_DIGITS=9;const NANOSECOND_DIGITS_IN_MILLIS=6;const MILLISECONDS_TO_NANOSECONDS=Math.pow(10,NANOSECOND_DIGITS_IN_MILLIS);const SECOND_TO_NANOSECONDS=Math.pow(10,NANOSECOND_DIGITS);/**
    	 * Converts a number of milliseconds from epoch to HrTime([seconds, remainder in nanoseconds]).
    	 * @param epochMillis
    	 */function millisToHrTime(epochMillis){const epochSeconds=epochMillis/1000;// Decimals only.
    	const seconds=Math.trunc(epochSeconds);// Round sub-nanosecond accuracy to nanosecond.
    	const nanos=Math.round(epochMillis%1000*MILLISECONDS_TO_NANOSECONDS);return [seconds,nanos];}function getTimeOrigin(){let timeOrigin=otperformance.timeOrigin;if(typeof timeOrigin!=='number'){const perf=otperformance;timeOrigin=perf.timing&&perf.timing.fetchStart;}return timeOrigin;}/**
    	 * Returns an hrtime calculated via performance component.
    	 * @param performanceNow
    	 */function hrTime(performanceNow){const timeOrigin=millisToHrTime(getTimeOrigin());const now=millisToHrTime(typeof performanceNow==='number'?performanceNow:otperformance.now());return addHrTimes(timeOrigin,now);}/**
    	 *
    	 * Converts a TimeInput to an HrTime, defaults to _hrtime().
    	 * @param time
    	 */function timeInputToHrTime(time){// process.hrtime
    	if(isTimeInputHrTime(time)){return time;}else if(typeof time==='number'){// Must be a performance.now() if it's smaller than process start time.
    	if(time<getTimeOrigin()){return hrTime(time);}else {// epoch milliseconds or performance.timeOrigin
    	return millisToHrTime(time);}}else if(time instanceof Date){return millisToHrTime(time.getTime());}else {throw TypeError('Invalid input type');}}/**
    	 * Convert hrTime to nanoseconds.
    	 * @param time
    	 */function hrTimeToNanoseconds(time){return time[0]*SECOND_TO_NANOSECONDS+time[1];}/**
    	 * check if time is HrTime
    	 * @param value
    	 */function isTimeInputHrTime(value){return Array.isArray(value)&&value.length===2&&typeof value[0]==='number'&&typeof value[1]==='number';}/**
    	 * Given 2 HrTime formatted times, return their sum as an HrTime.
    	 */function addHrTimes(time1,time2){const out=[time1[0]+time2[0],time1[1]+time2[1]];// Nanoseconds
    	if(out[1]>=SECOND_TO_NANOSECONDS){out[1]-=SECOND_TO_NANOSECONDS;out[0]+=1;}return out;}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */function urlMatches(url,urlToMatch){if(typeof urlToMatch==='string'){return url===urlToMatch;}else {return !!url.match(urlToMatch);}}/**
    	 * Check if {@param url} should be ignored when comparing against {@param ignoredUrls}
    	 * @param url
    	 * @param ignoredUrls
    	 */function isUrlIgnored(url,ignoredUrls){if(!ignoredUrls){return false;}for(const ignoreUrl of ignoredUrls){if(urlMatches(url,ignoreUrl)){return true;}}return false;}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var PerformanceTimingNames;(function(PerformanceTimingNames){PerformanceTimingNames["CONNECT_END"]="connectEnd";PerformanceTimingNames["CONNECT_START"]="connectStart";PerformanceTimingNames["DECODED_BODY_SIZE"]="decodedBodySize";PerformanceTimingNames["DOM_COMPLETE"]="domComplete";PerformanceTimingNames["DOM_CONTENT_LOADED_EVENT_END"]="domContentLoadedEventEnd";PerformanceTimingNames["DOM_CONTENT_LOADED_EVENT_START"]="domContentLoadedEventStart";PerformanceTimingNames["DOM_INTERACTIVE"]="domInteractive";PerformanceTimingNames["DOMAIN_LOOKUP_END"]="domainLookupEnd";PerformanceTimingNames["DOMAIN_LOOKUP_START"]="domainLookupStart";PerformanceTimingNames["ENCODED_BODY_SIZE"]="encodedBodySize";PerformanceTimingNames["FETCH_START"]="fetchStart";PerformanceTimingNames["LOAD_EVENT_END"]="loadEventEnd";PerformanceTimingNames["LOAD_EVENT_START"]="loadEventStart";PerformanceTimingNames["NAVIGATION_START"]="navigationStart";PerformanceTimingNames["REDIRECT_END"]="redirectEnd";PerformanceTimingNames["REDIRECT_START"]="redirectStart";PerformanceTimingNames["REQUEST_START"]="requestStart";PerformanceTimingNames["RESPONSE_END"]="responseEnd";PerformanceTimingNames["RESPONSE_START"]="responseStart";PerformanceTimingNames["SECURE_CONNECTION_START"]="secureConnectionStart";PerformanceTimingNames["START_TIME"]="startTime";PerformanceTimingNames["UNLOAD_EVENT_END"]="unloadEventEnd";PerformanceTimingNames["UNLOAD_EVENT_START"]="unloadEventStart";})(PerformanceTimingNames||(PerformanceTimingNames={}));/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//*
    	 * This file contains a copy of unstable semantic convention definitions
    	 * used by this package.
    	 * @see https://github.com/open-telemetry/opentelemetry-js/tree/main/semantic-conventions#unstable-semconv
    	 *//**
    	 * Deprecated, use `http.response.header.<key>` instead.
    	 *
    	 * @example 3495
    	 *
    	 * @experimental This attribute is experimental and is subject to breaking changes in minor releases of `@opentelemetry/semantic-conventions`.
    	 *
    	 * @deprecated Replaced by `http.response.header.<key>`.
    	 */const ATTR_HTTP_RESPONSE_CONTENT_LENGTH='http.response_content_length';/**
    	 * Deprecated, use `http.response.body.size` instead.
    	 *
    	 * @example 5493
    	 *
    	 * @experimental This attribute is experimental and is subject to breaking changes in minor releases of `@opentelemetry/semantic-conventions`.
    	 *
    	 * @deprecated Replace by `http.response.body.size`.
    	 */const ATTR_HTTP_RESPONSE_CONTENT_LENGTH_UNCOMPRESSED='http.response_content_length_uncompressed';/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Used to normalize relative URLs
    	let urlNormalizingAnchor;function getUrlNormalizingAnchor(){if(!urlNormalizingAnchor){urlNormalizingAnchor=document.createElement('a');}return urlNormalizingAnchor;}/**
    	 * Helper function to be able to use enum as typed key in type and in interface when using forEach
    	 * @param obj
    	 * @param key
    	 */function hasKey(obj,key){return key in obj;}/**
    	 * Helper function for starting an event on span based on {@link PerformanceEntries}
    	 * @param span
    	 * @param performanceName name of performance entry for time start
    	 * @param entries
    	 * @param ignoreZeros
    	 */function addSpanNetworkEvent(span,performanceName,entries){let ignoreZeros=arguments.length>3&&arguments[3]!==undefined?arguments[3]:true;if(hasKey(entries,performanceName)&&typeof entries[performanceName]==='number'&&!(ignoreZeros&&entries[performanceName]===0)){return span.addEvent(performanceName,entries[performanceName]);}return undefined;}/**
    	 * Helper function for adding network events and content length attributes.
    	 */function addSpanNetworkEvents(span,resource){let ignoreNetworkEvents=arguments.length>2&&arguments[2]!==undefined?arguments[2]:false;let ignoreZeros=arguments.length>3?arguments[3]:undefined;let skipOldSemconvContentLengthAttrs=arguments.length>4?arguments[4]:undefined;if(ignoreZeros===undefined){ignoreZeros=resource[PerformanceTimingNames.START_TIME]!==0;}if(!ignoreNetworkEvents){addSpanNetworkEvent(span,PerformanceTimingNames.FETCH_START,resource,ignoreZeros);addSpanNetworkEvent(span,PerformanceTimingNames.DOMAIN_LOOKUP_START,resource,ignoreZeros);addSpanNetworkEvent(span,PerformanceTimingNames.DOMAIN_LOOKUP_END,resource,ignoreZeros);addSpanNetworkEvent(span,PerformanceTimingNames.CONNECT_START,resource,ignoreZeros);addSpanNetworkEvent(span,PerformanceTimingNames.SECURE_CONNECTION_START,resource,ignoreZeros);addSpanNetworkEvent(span,PerformanceTimingNames.CONNECT_END,resource,ignoreZeros);addSpanNetworkEvent(span,PerformanceTimingNames.REQUEST_START,resource,ignoreZeros);addSpanNetworkEvent(span,PerformanceTimingNames.RESPONSE_START,resource,ignoreZeros);addSpanNetworkEvent(span,PerformanceTimingNames.RESPONSE_END,resource,ignoreZeros);}if(!skipOldSemconvContentLengthAttrs){// This block adds content-length-related span attributes using the
    	// *old* HTTP semconv (v1.7.0).
    	const encodedLength=resource[PerformanceTimingNames.ENCODED_BODY_SIZE];if(encodedLength!==undefined){span.setAttribute(ATTR_HTTP_RESPONSE_CONTENT_LENGTH,encodedLength);}const decodedLength=resource[PerformanceTimingNames.DECODED_BODY_SIZE];// Spec: Not set if transport encoding not used (in which case encoded and decoded sizes match)
    	if(decodedLength!==undefined&&encodedLength!==decodedLength){span.setAttribute(ATTR_HTTP_RESPONSE_CONTENT_LENGTH_UNCOMPRESSED,decodedLength);}}}/**
    	 * sort resources by startTime
    	 * @param filteredResources
    	 */function sortResources(filteredResources){return filteredResources.slice().sort((a,b)=>{const valueA=a[PerformanceTimingNames.FETCH_START];const valueB=b[PerformanceTimingNames.FETCH_START];if(valueA>valueB){return 1;}else if(valueA<valueB){return  -1;}return 0;});}/** Returns the origin if present (if in browser context). */function getOrigin(){return typeof location!=='undefined'?location.origin:undefined;}/**
    	 * Get closest performance resource ignoring the resources that have been
    	 * already used.
    	 * @param spanUrl
    	 * @param startTimeHR
    	 * @param endTimeHR
    	 * @param resources
    	 * @param ignoredResources
    	 * @param initiatorType
    	 */function getResource(spanUrl,startTimeHR,endTimeHR,resources){let ignoredResources=arguments.length>4&&arguments[4]!==undefined?arguments[4]:new WeakSet();let initiatorType=arguments.length>5?arguments[5]:undefined;// de-relativize the URL before usage (does no harm to absolute URLs)
    	const parsedSpanUrl=parseUrl(spanUrl);spanUrl=parsedSpanUrl.toString();const filteredResources=filterResourcesForSpan(spanUrl,startTimeHR,endTimeHR,resources,ignoredResources,initiatorType);if(filteredResources.length===0){return {mainRequest:undefined};}if(filteredResources.length===1){return {mainRequest:filteredResources[0]};}const sorted=sortResources(filteredResources);if(parsedSpanUrl.origin!==getOrigin()&&sorted.length>1){let corsPreFlightRequest=sorted[0];let mainRequest=findMainRequest(sorted,corsPreFlightRequest[PerformanceTimingNames.RESPONSE_END],endTimeHR);const responseEnd=corsPreFlightRequest[PerformanceTimingNames.RESPONSE_END];const fetchStart=mainRequest[PerformanceTimingNames.FETCH_START];// no corsPreFlightRequest
    	if(fetchStart<responseEnd){mainRequest=corsPreFlightRequest;corsPreFlightRequest=undefined;}return {corsPreFlightRequest,mainRequest};}else {return {mainRequest:filteredResources[0]};}}/**
    	 * Will find the main request skipping the cors pre flight requests
    	 * @param resources
    	 * @param corsPreFlightRequestEndTime
    	 * @param spanEndTimeHR
    	 */function findMainRequest(resources,corsPreFlightRequestEndTime,spanEndTimeHR){const spanEndTime=hrTimeToNanoseconds(spanEndTimeHR);const minTime=hrTimeToNanoseconds(timeInputToHrTime(corsPreFlightRequestEndTime));let mainRequest=resources[1];let bestGap;const length=resources.length;for(let i=1;i<length;i++){const resource=resources[i];const resourceStartTime=hrTimeToNanoseconds(timeInputToHrTime(resource[PerformanceTimingNames.FETCH_START]));const resourceEndTime=hrTimeToNanoseconds(timeInputToHrTime(resource[PerformanceTimingNames.RESPONSE_END]));const currentGap=spanEndTime-resourceEndTime;if(resourceStartTime>=minTime&&(!bestGap||currentGap<bestGap)){bestGap=currentGap;mainRequest=resource;}}return mainRequest;}/**
    	 * Filter all resources that has started and finished according to span start time and end time.
    	 *     It will return the closest resource to a start time
    	 * @param spanUrl
    	 * @param startTimeHR
    	 * @param endTimeHR
    	 * @param resources
    	 * @param ignoredResources
    	 */function filterResourcesForSpan(spanUrl,startTimeHR,endTimeHR,resources,ignoredResources,initiatorType){const startTime=hrTimeToNanoseconds(startTimeHR);const endTime=hrTimeToNanoseconds(endTimeHR);let filteredResources=resources.filter(resource=>{const resourceStartTime=hrTimeToNanoseconds(timeInputToHrTime(resource[PerformanceTimingNames.FETCH_START]));const resourceEndTime=hrTimeToNanoseconds(timeInputToHrTime(resource[PerformanceTimingNames.RESPONSE_END]));return resource.initiatorType.toLowerCase()===initiatorType&&resource.name===spanUrl&&resourceStartTime>=startTime&&resourceEndTime<=endTime;});if(filteredResources.length>0){filteredResources=filteredResources.filter(resource=>{return !ignoredResources.has(resource);});}return filteredResources;}/**
    	 * Parses url using URL constructor or fallback to anchor element.
    	 * @param url
    	 */function parseUrl(url){if(typeof URL==='function'){return new URL(url,typeof document!=='undefined'?document.baseURI:typeof location!=='undefined'// Some JS runtimes (e.g. Deno) don't define this
    	?location.href:undefined);}const element=getUrlNormalizingAnchor();element.href=url;return element;}/**
    	 * Checks if trace headers should be propagated
    	 * @param spanUrl
    	 * @private
    	 */function shouldPropagateTraceHeaders(spanUrl,propagateTraceHeaderCorsUrls){let propagateTraceHeaderUrls=propagateTraceHeaderCorsUrls||[];if(typeof propagateTraceHeaderUrls==='string'||propagateTraceHeaderUrls instanceof RegExp){propagateTraceHeaderUrls=[propagateTraceHeaderUrls];}const parsedSpanUrl=parseUrl(spanUrl);if(parsedSpanUrl.origin===getOrigin()){return true;}else {return propagateTraceHeaderUrls.some(propagateTraceHeaderUrl=>urlMatches(spanUrl,propagateTraceHeaderUrl));}}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * https://github.com/open-telemetry/opentelemetry-specification/blob/master/specification/trace/semantic_conventions/http.md
    	 */var AttributeNames;(function(AttributeNames){AttributeNames["COMPONENT"]="component";AttributeNames["HTTP_STATUS_TEXT"]="http.status_text";})(AttributeNames||(AttributeNames={}));/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//*
    	 * This file contains a copy of unstable semantic convention definitions
    	 * used by this package.
    	 * @see https://github.com/open-telemetry/opentelemetry-js/tree/main/semantic-conventions#unstable-semconv
    	 *//**
    	 * Deprecated, use one of `server.address`, `client.address` or `http.request.header.host` instead, depending on the usage.
    	 *
    	 * @example www.example.org
    	 *
    	 * @experimental This attribute is experimental and is subject to breaking changes in minor releases of `@opentelemetry/semantic-conventions`.
    	 *
    	 * @deprecated Replaced by one of `server.address`, `client.address` or `http.request.header.host`, depending on the usage.
    	 */const ATTR_HTTP_HOST='http.host';/**
    	 * Deprecated, use `http.request.method` instead.
    	 *
    	 * @example GET
    	 * @example POST
    	 * @example HEAD
    	 *
    	 * @experimental This attribute is experimental and is subject to breaking changes in minor releases of `@opentelemetry/semantic-conventions`.
    	 *
    	 * @deprecated Replaced by `http.request.method`.
    	 */const ATTR_HTTP_METHOD='http.method';/**
    	 * The size of the request payload body in bytes. This is the number of bytes transferred excluding headers and is often, but not always, present as the [Content-Length](https://www.rfc-editor.org/rfc/rfc9110.html#field.content-length) header. For requests using transport encoding, this should be the compressed size.
    	 *
    	 * @example 3495
    	 *
    	 * @experimental This attribute is experimental and is subject to breaking changes in minor releases of `@opentelemetry/semantic-conventions`.
    	 */const ATTR_HTTP_REQUEST_BODY_SIZE='http.request.body.size';/**
    	 * Deprecated, use `http.request.body.size` instead.
    	 *
    	 * @example 5493
    	 *
    	 * @experimental This attribute is experimental and is subject to breaking changes in minor releases of `@opentelemetry/semantic-conventions`.
    	 *
    	 * @deprecated Replaced by `http.request.body.size`.
    	 */const ATTR_HTTP_REQUEST_CONTENT_LENGTH_UNCOMPRESSED='http.request_content_length_uncompressed';/**
    	 * Deprecated, use `url.scheme` instead.
    	 *
    	 * @example http
    	 * @example https
    	 *
    	 * @experimental This attribute is experimental and is subject to breaking changes in minor releases of `@opentelemetry/semantic-conventions`.
    	 *
    	 * @deprecated Replaced by `url.scheme` instead.
    	 */const ATTR_HTTP_SCHEME='http.scheme';/**
    	 * Deprecated, use `http.response.status_code` instead.
    	 *
    	 * @example 200
    	 *
    	 * @experimental This attribute is experimental and is subject to breaking changes in minor releases of `@opentelemetry/semantic-conventions`.
    	 *
    	 * @deprecated Replaced by `http.response.status_code`.
    	 */const ATTR_HTTP_STATUS_CODE='http.status_code';/**
    	 * Deprecated, use `url.full` instead.
    	 *
    	 * @example https://www.foo.bar/search?q=OpenTelemetry#SemConv
    	 *
    	 * @experimental This attribute is experimental and is subject to breaking changes in minor releases of `@opentelemetry/semantic-conventions`.
    	 *
    	 * @deprecated Replaced by `url.full`.
    	 */const ATTR_HTTP_URL='http.url';/**
    	 * Deprecated, use `user_agent.original` instead.
    	 *
    	 * @example CERN-LineMode/2.15 libwww/2.17b3
    	 * @example Mozilla/5.0 (iPhone; CPU iPhone OS 14_7_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/14.1.2 Mobile/15E148 Safari/604.1
    	 *
    	 * @experimental This attribute is experimental and is subject to breaking changes in minor releases of `@opentelemetry/semantic-conventions`.
    	 *
    	 * @deprecated Replaced by `user_agent.original`.
    	 */const ATTR_HTTP_USER_AGENT='http.user_agent';/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Much of the logic here overlaps with the same utils file in opentelemetry-instrumentation-xml-http-request
    	// These may be unified in the future.
    	const DIAG_LOGGER=diag.createComponentLogger({namespace:'@opentelemetry/opentelemetry-instrumentation-fetch/utils'});/**
    	 * Helper function to determine payload content length for fetch requests
    	 *
    	 * The fetch API is kinda messy: there are a couple of ways the body can be passed in.
    	 *
    	 * In all cases, the body param can be some variation of ReadableStream,
    	 * and ReadableStreams can only be read once! We want to avoid consuming the body here,
    	 * because that would mean that the body never gets sent with the actual fetch request.
    	 *
    	 * Either the first arg is a Request object, which can be cloned
    	 *   so we can clone that object and read the body of the clone
    	 *   without disturbing the original argument
    	 *   However, reading the body here can only be done async; the body() method returns a promise
    	 *   this means this entire function has to return a promise
    	 *
    	 * OR the first arg is a url/string
    	 *   in which case the second arg has type RequestInit
    	 *   RequestInit is NOT cloneable, but RequestInit.body is writable
    	 *   so we can chain it into ReadableStream.pipeThrough()
    	 *
    	 *   ReadableStream.pipeThrough() lets us process a stream and returns a new stream
    	 *   So we can measure the body length as it passes through the pie, but need to attach
    	 *   the new stream to the original request
    	 *   so that the browser still has access to the body.
    	 *
    	 * @param body
    	 * @returns promise that resolves to the content length of the body
    	 */function getFetchBodyLength(){if((arguments.length<=0?undefined:arguments[0])instanceof URL||typeof(arguments.length<=0?undefined:arguments[0])==='string'){const requestInit=arguments.length<=1?undefined:arguments[1];if(!(requestInit!==null&&requestInit!==void 0&&requestInit.body)){return Promise.resolve();}if(requestInit.body instanceof ReadableStream){const{body,length}=_getBodyNonDestructively(requestInit.body);requestInit.body=body;return length;}else {return Promise.resolve(getXHRBodyLength(requestInit.body));}}else {const info=arguments.length<=0?undefined:arguments[0];if(!(info!==null&&info!==void 0&&info.body)){return Promise.resolve();}return info.clone().text().then(t=>getByteLength(t));}}function _getBodyNonDestructively(body){// can't read a ReadableStream without destroying it
    	// but we CAN pipe it through and return a new ReadableStream
    	// some (older) platforms don't expose the pipeThrough method and in that scenario, we're out of luck;
    	//   there's no way to read the stream without consuming it.
    	if(!body.pipeThrough){DIAG_LOGGER.warn('Platform has ReadableStream but not pipeThrough!');return {body,length:Promise.resolve(undefined)};}let length=0;let resolveLength;const lengthPromise=new Promise(resolve=>{resolveLength=resolve;});const transform=new TransformStream({start(){},async transform(chunk,controller){const bytearray=await chunk;length+=bytearray.byteLength;controller.enqueue(chunk);},flush(){resolveLength(length);}});return {body:body.pipeThrough(transform),length:lengthPromise};}function isDocument(value){return typeof Document!=='undefined'&&value instanceof Document;}/**
    	 * Helper function to determine payload content length for XHR requests
    	 * @param body
    	 * @returns content length
    	 */function getXHRBodyLength(body){if(isDocument(body)){return new XMLSerializer().serializeToString(document).length;}// XMLHttpRequestBodyInit expands to the following:
    	if(typeof body==='string'){return getByteLength(body);}if(body instanceof Blob){return body.size;}if(body instanceof FormData){return getFormDataSize(body);}if(body instanceof URLSearchParams){return getByteLength(body.toString());}// ArrayBuffer | ArrayBufferView
    	if(body.byteLength!==undefined){return body.byteLength;}DIAG_LOGGER.warn('unknown body type');return undefined;}const TEXT_ENCODER=new TextEncoder();function getByteLength(s){return TEXT_ENCODER.encode(s).byteLength;}function getFormDataSize(formData){let size=0;for(const[key,value]of formData.entries()){size+=key.length;if(value instanceof Blob){size+=value.size;}else {size+=value.length;}}return size;}/**
    	 * Normalize an HTTP request method string per `http.request.method` spec
    	 * https://github.com/open-telemetry/semantic-conventions/blob/main/docs/http/http-spans.md#http-client-span
    	 */function normalizeHttpRequestMethod(method){const knownMethods=getKnownMethods();const methUpper=method.toUpperCase();if(methUpper in knownMethods){return methUpper;}else {return '_OTHER';}}const DEFAULT_KNOWN_METHODS={CONNECT:true,DELETE:true,GET:true,HEAD:true,OPTIONS:true,PATCH:true,POST:true,PUT:true,TRACE:true};let knownMethods;function getKnownMethods(){if(knownMethods===undefined){{knownMethods=DEFAULT_KNOWN_METHODS;}}return knownMethods;}const HTTP_PORT_FROM_PROTOCOL={'https:':'443','http:':'80'};function serverPortFromUrl(url){const serverPort=Number(url.port||HTTP_PORT_FROM_PROTOCOL[url.protocol]);// Guard with `if (serverPort)` because `Number('') === 0`.
    	if(serverPort&&!isNaN(serverPort)){return serverPort;}else {return undefined;}}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// this is autogenerated file, see scripts/version-update.js
    	const VERSION='0.206.0';/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// how long to wait for observer to collect information about resources
    	// this is needed as event "load" is called before observer
    	// hard to say how long it should really wait, seems like 300ms is
    	// safe enough
    	const OBSERVER_WAIT_TIME_MS=300;const isNode=typeof process==='object'&&((_process$release=process.release)===null||_process$release===void 0?void 0:_process$release.name)==='node';/**
    	 * This class represents a fetch plugin for auto instrumentation
    	 */class FetchInstrumentation extends InstrumentationBase{constructor(){let config=arguments.length>0&&arguments[0]!==undefined?arguments[0]:{};super('@opentelemetry/instrumentation-fetch',VERSION,config);_defineProperty2(this,"component",'fetch');_defineProperty2(this,"version",VERSION);_defineProperty2(this,"moduleName",this.component);_defineProperty2(this,"_usedResources",new WeakSet());_defineProperty2(this,"_tasksCount",0);_defineProperty2(this,"_semconvStability",void 0);this._semconvStability=semconvStabilityFromStr('http',config===null||config===void 0?void 0:config.semconvStabilityOptIn);}init(){}/**
    	     * Add cors pre flight child span
    	     * @param span
    	     * @param corsPreFlightRequest
    	     */_addChildSpan(span,corsPreFlightRequest){const childSpan=this.tracer.startSpan('CORS Preflight',{startTime:corsPreFlightRequest[PerformanceTimingNames.FETCH_START]},trace.setSpan(context.active(),span));const skipOldSemconvContentLengthAttrs=!(this._semconvStability&SemconvStability.OLD);addSpanNetworkEvents(childSpan,corsPreFlightRequest,this.getConfig().ignoreNetworkEvents,undefined,skipOldSemconvContentLengthAttrs);childSpan.end(corsPreFlightRequest[PerformanceTimingNames.RESPONSE_END]);}/**
    	     * Adds more attributes to span just before ending it
    	     * @param span
    	     * @param response
    	     */_addFinalSpanAttributes(span,response){const parsedUrl=parseUrl(response.url);if(this._semconvStability&SemconvStability.OLD){span.setAttribute(ATTR_HTTP_STATUS_CODE,response.status);if(response.statusText!=null){span.setAttribute(AttributeNames.HTTP_STATUS_TEXT,response.statusText);}span.setAttribute(ATTR_HTTP_HOST,parsedUrl.host);span.setAttribute(ATTR_HTTP_SCHEME,parsedUrl.protocol.replace(':',''));if(typeof navigator!=='undefined'){span.setAttribute(ATTR_HTTP_USER_AGENT,navigator.userAgent);}}if(this._semconvStability&SemconvStability.STABLE){span.setAttribute(ATTR_HTTP_RESPONSE_STATUS_CODE,response.status);// TODO: Set server.{address,port} at span creation for sampling decisions
    	// (a "SHOULD" requirement in semconv).
    	span.setAttribute(ATTR_SERVER_ADDRESS,parsedUrl.hostname);const serverPort=serverPortFromUrl(parsedUrl);if(serverPort){span.setAttribute(ATTR_SERVER_PORT,serverPort);}}}/**
    	     * Add headers
    	     * @param options
    	     * @param spanUrl
    	     */_addHeaders(options,spanUrl){if(!shouldPropagateTraceHeaders(spanUrl,this.getConfig().propagateTraceHeaderCorsUrls)){const headers={};propagation.inject(context.active(),headers);if(Object.keys(headers).length>0){this._diag.debug('headers inject skipped due to CORS policy');}return;}if(options instanceof Request){propagation.inject(context.active(),options.headers,{set:(h,k,v)=>h.set(k,typeof v==='string'?v:String(v))});}else if(options.headers instanceof Headers){propagation.inject(context.active(),options.headers,{set:(h,k,v)=>h.set(k,typeof v==='string'?v:String(v))});}else if(options.headers instanceof Map){propagation.inject(context.active(),options.headers,{set:(h,k,v)=>h.set(k,typeof v==='string'?v:String(v))});}else {const headers={};propagation.inject(context.active(),headers);options.headers=Object.assign({},headers,options.headers||{});}}/**
    	     * Clears the resource timings and all resources assigned with spans
    	     *     when {@link FetchPluginConfig.clearTimingResources} is
    	     *     set to true (default false)
    	     * @private
    	     */_clearResources(){if(this._tasksCount===0&&this.getConfig().clearTimingResources){performance.clearResourceTimings();this._usedResources=new WeakSet();}}/**
    	     * Creates a new span
    	     * @param url
    	     * @param options
    	     */_createSpan(url){let options=arguments.length>1&&arguments[1]!==undefined?arguments[1]:{};if(isUrlIgnored(url,this.getConfig().ignoreUrls)){this._diag.debug('ignoring span as url matches ignored url');return;}let name='';const attributes={};if(this._semconvStability&SemconvStability.OLD){const method=(options.method||'GET').toUpperCase();name=`HTTP ${method}`;attributes[AttributeNames.COMPONENT]=this.moduleName;attributes[ATTR_HTTP_METHOD]=method;attributes[ATTR_HTTP_URL]=url;}if(this._semconvStability&SemconvStability.STABLE){const origMethod=options.method;const normMethod=normalizeHttpRequestMethod(options.method||'GET');if(!name){// The "old" span name wins if emitting both old and stable semconv
    	// ('http/dup').
    	name=normMethod;}attributes[ATTR_HTTP_REQUEST_METHOD]=normMethod;if(normMethod!==origMethod){attributes[ATTR_HTTP_REQUEST_METHOD_ORIGINAL]=origMethod;}attributes[ATTR_URL_FULL]=url;}return this.tracer.startSpan(name,{kind:SpanKind$1.CLIENT,attributes});}/**
    	     * Finds appropriate resource and add network events to the span
    	     * @param span
    	     * @param resourcesObserver
    	     * @param endTime
    	     */_findResourceAndAddNetworkEvents(span,resourcesObserver,endTime){let resources=resourcesObserver.entries;if(!resources.length){if(!performance.getEntriesByType){return;}// fallback - either Observer is not available or it took longer
    	// then OBSERVER_WAIT_TIME_MS and observer didn't collect enough
    	// information
    	resources=performance.getEntriesByType('resource');}const resource=getResource(resourcesObserver.spanUrl,resourcesObserver.startTime,endTime,resources,this._usedResources,'fetch');if(resource.mainRequest){const mainRequest=resource.mainRequest;this._markResourceAsUsed(mainRequest);const corsPreFlightRequest=resource.corsPreFlightRequest;if(corsPreFlightRequest){this._addChildSpan(span,corsPreFlightRequest);this._markResourceAsUsed(corsPreFlightRequest);}const skipOldSemconvContentLengthAttrs=!(this._semconvStability&SemconvStability.OLD);addSpanNetworkEvents(span,mainRequest,this.getConfig().ignoreNetworkEvents,undefined,skipOldSemconvContentLengthAttrs);}}/**
    	     * Marks certain [resource]{@link PerformanceResourceTiming} when information
    	     * from this is used to add events to span.
    	     * This is done to avoid reusing the same resource again for next span
    	     * @param resource
    	     */_markResourceAsUsed(resource){this._usedResources.add(resource);}/**
    	     * Finish span, add attributes, network events etc.
    	     * @param span
    	     * @param spanData
    	     * @param response
    	     */_endSpan(span,spanData,response){const endTime=millisToHrTime(Date.now());const performanceEndTime=hrTime();this._addFinalSpanAttributes(span,response);if(this._semconvStability&SemconvStability.STABLE){// https://github.com/open-telemetry/semantic-conventions/blob/main/docs/http/http-spans.md#status
    	if(response.status>=400){span.setStatus({code:SpanStatusCode.ERROR});span.setAttribute(ATTR_ERROR_TYPE,String(response.status));}}setTimeout(()=>{var _spanData$observer;(_spanData$observer=spanData.observer)===null||_spanData$observer===void 0||_spanData$observer.disconnect();this._findResourceAndAddNetworkEvents(span,spanData,performanceEndTime);this._tasksCount--;this._clearResources();span.end(endTime);},OBSERVER_WAIT_TIME_MS);}/**
    	     * Patches the constructor of fetch
    	     */_patchConstructor(){return original=>{const plugin=this;return function patchConstructor(){const self=this;for(var _len5=arguments.length,args=new Array(_len5),_key6=0;_key6<_len5;_key6++){args[_key6]=arguments[_key6];}const url=parseUrl(args[0]instanceof Request?args[0].url:String(args[0])).href;const options=args[0]instanceof Request?args[0]:args[1]||{};const createdSpan=plugin._createSpan(url,options);if(!createdSpan){return original.apply(this,args);}const spanData=plugin._prepareSpanData(url);if(plugin.getConfig().measureRequestSize){getFetchBodyLength(...args).then(bodyLength=>{if(!bodyLength)return;if(plugin._semconvStability&SemconvStability.OLD){createdSpan.setAttribute(ATTR_HTTP_REQUEST_CONTENT_LENGTH_UNCOMPRESSED,bodyLength);}if(plugin._semconvStability&SemconvStability.STABLE){createdSpan.setAttribute(ATTR_HTTP_REQUEST_BODY_SIZE,bodyLength);}}).catch(error=>{plugin._diag.warn('getFetchBodyLength',error);});}function endSpanOnError(span,error){plugin._applyAttributesAfterFetch(span,options,error);plugin._endSpan(span,spanData,{status:error.status||0,statusText:error.message,url});}function endSpanOnSuccess(span,response){plugin._applyAttributesAfterFetch(span,options,response);if(response.status>=200&&response.status<400){plugin._endSpan(span,spanData,response);}else {plugin._endSpan(span,spanData,{status:response.status,statusText:response.statusText,url});}}function withCancelPropagation(body,readerClone){if(!body)return null;const reader=body.getReader();return new ReadableStream({async pull(controller){try{const{value,done}=await reader.read();if(done){reader.releaseLock();controller.close();}else {controller.enqueue(value);}}catch(err){controller.error(err);reader.cancel(err).catch(_=>{});try{reader.releaseLock();}catch{// Spec reference:
    	// https://streams.spec.whatwg.org/#default-reader-release-lock
    	//
    	// releaseLock() only throws if called on an invalid reader
    	// (i.e. reader.[[stream]] is undefined, meaning the lock is already released
    	// or the reader was never associated). In normal use this cannot happen.
    	// This catch is defensive only.
    	}}},cancel(reason){readerClone.cancel(reason).catch(_=>{});return reader.cancel(reason);}});}function onSuccess(span,resolve,response){let proxiedResponse=null;try{// TODO: Switch to a consumer-driven model and drop `resClone`.
    	// Keeping eager consumption here to preserve current behavior and avoid breaking existing tests.
    	// Context: discussion in PR #5894 → https://github.com/open-telemetry/opentelemetry-js/pull/5894
    	const resClone=response.clone();const body=resClone.body;if(body){const reader=body.getReader();const wrappedBody=withCancelPropagation(response.body,reader);proxiedResponse=new Response(wrappedBody,{status:response.status,statusText:response.statusText,headers:response.headers});const read=()=>{reader.read().then(_ref19=>{let{done}=_ref19;if(done){endSpanOnSuccess(span,response);}else {read();}},error=>{endSpanOnError(span,error);});};read();}else {// some older browsers don't have .body implemented
    	endSpanOnSuccess(span,response);}}finally{resolve(proxiedResponse!==null&&proxiedResponse!==void 0?proxiedResponse:response);}}function onError(span,reject,error){try{endSpanOnError(span,error);}finally{reject(error);}}return new Promise((resolve,reject)=>{return context.with(trace.setSpan(context.active(),createdSpan),()=>{plugin._addHeaders(options,url);plugin._callRequestHook(createdSpan,options);plugin._tasksCount++;return original.apply(self,options instanceof Request?[options]:[url,options]).then(onSuccess.bind(self,createdSpan,resolve),onError.bind(self,createdSpan,reject));});});};};}_applyAttributesAfterFetch(span,request,result){const applyCustomAttributesOnSpan=this.getConfig().applyCustomAttributesOnSpan;if(applyCustomAttributesOnSpan){safeExecuteInTheMiddle(()=>applyCustomAttributesOnSpan(span,request,result),error=>{if(!error){return;}this._diag.error('applyCustomAttributesOnSpan',error);});}}_callRequestHook(span,request){const requestHook=this.getConfig().requestHook;if(requestHook){safeExecuteInTheMiddle(()=>requestHook(span,request),error=>{if(!error){return;}this._diag.error('requestHook',error);});}}/**
    	     * Prepares a span data - needed later for matching appropriate network
    	     *     resources
    	     * @param spanUrl
    	     */_prepareSpanData(spanUrl){const startTime=hrTime();const entries=[];if(typeof PerformanceObserver!=='function'){return {entries,startTime,spanUrl};}const observer=new PerformanceObserver(list=>{const perfObsEntries=list.getEntries();perfObsEntries.forEach(entry=>{if(entry.initiatorType==='fetch'&&entry.name===spanUrl){entries.push(entry);}});});observer.observe({entryTypes:['resource']});return {entries,observer,startTime,spanUrl};}/**
    	     * implements enable function
    	     */enable(){if(isNode){// Node.js v18+ *does* have a global `fetch()`, but this package does not
    	// support instrumenting it.
    	this._diag.warn("this instrumentation is intended for web usage only, it does not instrument Node.js's fetch()");return;}if(isWrapped(fetch)){this._unwrap(_globalThis,'fetch');this._diag.debug('removing previous patch for constructor');}this._wrap(_globalThis,'fetch',this._patchConstructor());}/**
    	     * implements unpatch function
    	     */disable(){if(isNode){return;}this._unwrap(_globalThis,'fetch');this._usedResources=new WeakSet();}}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */// Event name definitions
    	var ExceptionEventName='exception';/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __values$1=function(o){var s=typeof Symbol==="function"&&Symbol.iterator,m=s&&o[s],i=0;if(m)return m.call(o);if(o&&typeof o.length==="number")return {next:function(){if(o&&i>=o.length)o=void 0;return {value:o&&o[i++],done:!o};}};throw new TypeError(s?"Object is not iterable.":"Symbol.iterator is not defined.");};var __read$2=function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-->0)&&!(r=i.next()).done)ar.push(r.value);}catch(error){e={error:error};}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i);}finally{if(e)throw e.error;}}return ar;};var __spreadArray$1=function(to,from,pack){if(pack||arguments.length===2)for(var i=0,l=from.length,ar;i<l;i++){if(ar||!(i in from)){if(!ar)ar=Array.prototype.slice.call(from,0,i);ar[i]=from[i];}}return to.concat(ar||Array.prototype.slice.call(from));};/**
    	 * This class represents a span.
    	 */var Span$1=/** @class */function(){/**
    	     * Constructs a new Span instance.
    	     *
    	     * @deprecated calling Span constructor directly is not supported. Please use tracer.startSpan.
    	     * */function Span(parentTracer,context,spanName,spanContext,kind,parentSpanId,links,startTime,_deprecatedClock,// keeping this argument even though it is unused to ensure backwards compatibility
    	attributes){if(links===void 0){links=[];}this.attributes={};this.links=[];this.events=[];this._droppedAttributesCount=0;this._droppedEventsCount=0;this._droppedLinksCount=0;this.status={code:SpanStatusCode.UNSET};this.endTime=[0,0];this._ended=false;this._duration=[-1,-1];this.name=spanName;this._spanContext=spanContext;this.parentSpanId=parentSpanId;this.kind=kind;this.links=links;var now=Date.now();this._performanceStartTime=otperformance$1.now();this._performanceOffset=now-(this._performanceStartTime+getTimeOrigin$1());this._startTimeProvided=startTime!=null;this.startTime=this._getTime(startTime!==null&&startTime!==void 0?startTime:now);this.resource=parentTracer.resource;this.instrumentationLibrary=parentTracer.instrumentationLibrary;this._spanLimits=parentTracer.getSpanLimits();this._attributeValueLengthLimit=this._spanLimits.attributeValueLengthLimit||0;if(attributes!=null){this.setAttributes(attributes);}this._spanProcessor=parentTracer.getActiveSpanProcessor();this._spanProcessor.onStart(this,context);}Span.prototype.spanContext=function(){return this._spanContext;};Span.prototype.setAttribute=function(key,value){if(value==null||this._isSpanEnded())return this;if(key.length===0){diag.warn("Invalid attribute key: "+key);return this;}if(!isAttributeValue(value)){diag.warn("Invalid attribute value set for key: "+key);return this;}if(Object.keys(this.attributes).length>=this._spanLimits.attributeCountLimit&&!Object.prototype.hasOwnProperty.call(this.attributes,key)){this._droppedAttributesCount++;return this;}this.attributes[key]=this._truncateToSize(value);return this;};Span.prototype.setAttributes=function(attributes){var e_1,_a;try{for(var _b=__values$1(Object.entries(attributes)),_c=_b.next();!_c.done;_c=_b.next()){var _d=__read$2(_c.value,2),k=_d[0],v=_d[1];this.setAttribute(k,v);}}catch(e_1_1){e_1={error:e_1_1};}finally{try{if(_c&&!_c.done&&(_a=_b.return))_a.call(_b);}finally{if(e_1)throw e_1.error;}}return this;};/**
    	     *
    	     * @param name Span Name
    	     * @param [attributesOrStartTime] Span attributes or start time
    	     *     if type is {@type TimeInput} and 3rd param is undefined
    	     * @param [timeStamp] Specified time stamp for the event
    	     */Span.prototype.addEvent=function(name,attributesOrStartTime,timeStamp){if(this._isSpanEnded())return this;if(this._spanLimits.eventCountLimit===0){diag.warn('No events allowed.');this._droppedEventsCount++;return this;}if(this.events.length>=this._spanLimits.eventCountLimit){if(this._droppedEventsCount===0){diag.debug('Dropping extra events.');}this.events.shift();this._droppedEventsCount++;}if(isTimeInput(attributesOrStartTime)){if(!isTimeInput(timeStamp)){timeStamp=attributesOrStartTime;}attributesOrStartTime=undefined;}var attributes=sanitizeAttributes(attributesOrStartTime);this.events.push({name:name,attributes:attributes,time:this._getTime(timeStamp),droppedAttributesCount:0});return this;};Span.prototype.addLink=function(link){this.links.push(link);return this;};Span.prototype.addLinks=function(links){var _a;(_a=this.links).push.apply(_a,__spreadArray$1([],__read$2(links),false));return this;};Span.prototype.setStatus=function(status){if(this._isSpanEnded())return this;this.status=status;return this;};Span.prototype.updateName=function(name){if(this._isSpanEnded())return this;this.name=name;return this;};Span.prototype.end=function(endTime){if(this._isSpanEnded()){diag.error(this.name+" "+this._spanContext.traceId+"-"+this._spanContext.spanId+" - You can only call end() on a span once.");return;}this._ended=true;this.endTime=this._getTime(endTime);this._duration=hrTimeDuration(this.startTime,this.endTime);if(this._duration[0]<0){diag.warn('Inconsistent start and end time, startTime > endTime. Setting span duration to 0ms.',this.startTime,this.endTime);this.endTime=this.startTime.slice();this._duration=[0,0];}if(this._droppedEventsCount>0){diag.warn("Dropped "+this._droppedEventsCount+" events because eventCountLimit reached");}this._spanProcessor.onEnd(this);};Span.prototype._getTime=function(inp){if(typeof inp==='number'&&inp<otperformance$1.now()){// must be a performance timestamp
    	// apply correction and convert to hrtime
    	return hrTime$1(inp+this._performanceOffset);}if(typeof inp==='number'){return millisToHrTime$1(inp);}if(inp instanceof Date){return millisToHrTime$1(inp.getTime());}if(isTimeInputHrTime$1(inp)){return inp;}if(this._startTimeProvided){// if user provided a time for the start manually
    	// we can't use duration to calculate event/end times
    	return millisToHrTime$1(Date.now());}var msDuration=otperformance$1.now()-this._performanceStartTime;return addHrTimes$1(this.startTime,millisToHrTime$1(msDuration));};Span.prototype.isRecording=function(){return this._ended===false;};Span.prototype.recordException=function(exception,time){var attributes={};if(typeof exception==='string'){attributes[SEMATTRS_EXCEPTION_MESSAGE]=exception;}else if(exception){if(exception.code){attributes[SEMATTRS_EXCEPTION_TYPE]=exception.code.toString();}else if(exception.name){attributes[SEMATTRS_EXCEPTION_TYPE]=exception.name;}if(exception.message){attributes[SEMATTRS_EXCEPTION_MESSAGE]=exception.message;}if(exception.stack){attributes[SEMATTRS_EXCEPTION_STACKTRACE]=exception.stack;}}// these are minimum requirements from spec
    	if(attributes[SEMATTRS_EXCEPTION_TYPE]||attributes[SEMATTRS_EXCEPTION_MESSAGE]){this.addEvent(ExceptionEventName,attributes,time);}else {diag.warn("Failed to record an exception "+exception);}};Object.defineProperty(Span.prototype,"duration",{get:function(){return this._duration;},enumerable:false,configurable:true});Object.defineProperty(Span.prototype,"ended",{get:function(){return this._ended;},enumerable:false,configurable:true});Object.defineProperty(Span.prototype,"droppedAttributesCount",{get:function(){return this._droppedAttributesCount;},enumerable:false,configurable:true});Object.defineProperty(Span.prototype,"droppedEventsCount",{get:function(){return this._droppedEventsCount;},enumerable:false,configurable:true});Object.defineProperty(Span.prototype,"droppedLinksCount",{get:function(){return this._droppedLinksCount;},enumerable:false,configurable:true});Span.prototype._isSpanEnded=function(){if(this._ended){diag.warn("Can not execute the operation on ended Span {traceId: "+this._spanContext.traceId+", spanId: "+this._spanContext.spanId+"}");}return this._ended;};// Utility function to truncate given value within size
    	// for value type of string, will truncate to given limit
    	// for type of non-string, will return same value
    	Span.prototype._truncateToLimitUtil=function(value,limit){if(value.length<=limit){return value;}return value.substr(0,limit);};/**
    	     * If the given attribute value is of type string and has more characters than given {@code attributeValueLengthLimit} then
    	     * return string with truncated to {@code attributeValueLengthLimit} characters
    	     *
    	     * If the given attribute value is array of strings then
    	     * return new array of strings with each element truncated to {@code attributeValueLengthLimit} characters
    	     *
    	     * Otherwise return same Attribute {@code value}
    	     *
    	     * @param value Attribute value
    	     * @returns truncated attribute value if required, otherwise same value
    	     */Span.prototype._truncateToSize=function(value){var _this=this;var limit=this._attributeValueLengthLimit;// Check limit
    	if(limit<=0){// Negative values are invalid, so do not truncate
    	diag.warn("Attribute value limit must be positive, got "+limit);return value;}// String
    	if(typeof value==='string'){return this._truncateToLimitUtil(value,limit);}// Array of strings
    	if(Array.isArray(value)){return value.map(function(val){return typeof val==='string'?_this._truncateToLimitUtil(val,limit):val;});}// Other types, no need to apply value length limit
    	return value;};return Span;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * A sampling decision that determines how a {@link Span} will be recorded
    	 * and collected.
    	 */var SamplingDecision;(function(SamplingDecision){/**
    	     * `Span.isRecording() === false`, span will not be recorded and all events
    	     * and attributes will be dropped.
    	     */SamplingDecision[SamplingDecision["NOT_RECORD"]=0]="NOT_RECORD";/**
    	     * `Span.isRecording() === true`, but `Sampled` flag in {@link TraceFlags}
    	     * MUST NOT be set.
    	     */SamplingDecision[SamplingDecision["RECORD"]=1]="RECORD";/**
    	     * `Span.isRecording() === true` AND `Sampled` flag in {@link TraceFlags}
    	     * MUST be set.
    	     */SamplingDecision[SamplingDecision["RECORD_AND_SAMPLED"]=2]="RECORD_AND_SAMPLED";})(SamplingDecision||(SamplingDecision={}));/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//** Sampler that samples no traces. */var AlwaysOffSampler=/** @class */function(){function AlwaysOffSampler(){}AlwaysOffSampler.prototype.shouldSample=function(){return {decision:SamplingDecision.NOT_RECORD};};AlwaysOffSampler.prototype.toString=function(){return 'AlwaysOffSampler';};return AlwaysOffSampler;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//** Sampler that samples all traces. */var AlwaysOnSampler=/** @class */function(){function AlwaysOnSampler(){}AlwaysOnSampler.prototype.shouldSample=function(){return {decision:SamplingDecision.RECORD_AND_SAMPLED};};AlwaysOnSampler.prototype.toString=function(){return 'AlwaysOnSampler';};return AlwaysOnSampler;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * A composite sampler that either respects the parent span's sampling decision
    	 * or delegates to `delegateSampler` for root spans.
    	 */var ParentBasedSampler=/** @class */function(){function ParentBasedSampler(config){var _a,_b,_c,_d;this._root=config.root;if(!this._root){globalErrorHandler(new Error('ParentBasedSampler must have a root sampler configured'));this._root=new AlwaysOnSampler();}this._remoteParentSampled=(_a=config.remoteParentSampled)!==null&&_a!==void 0?_a:new AlwaysOnSampler();this._remoteParentNotSampled=(_b=config.remoteParentNotSampled)!==null&&_b!==void 0?_b:new AlwaysOffSampler();this._localParentSampled=(_c=config.localParentSampled)!==null&&_c!==void 0?_c:new AlwaysOnSampler();this._localParentNotSampled=(_d=config.localParentNotSampled)!==null&&_d!==void 0?_d:new AlwaysOffSampler();}ParentBasedSampler.prototype.shouldSample=function(context,traceId,spanName,spanKind,attributes,links){var parentContext=trace.getSpanContext(context);if(!parentContext||!isSpanContextValid(parentContext)){return this._root.shouldSample(context,traceId,spanName,spanKind,attributes,links);}if(parentContext.isRemote){if(parentContext.traceFlags&TraceFlags.SAMPLED){return this._remoteParentSampled.shouldSample(context,traceId,spanName,spanKind,attributes,links);}return this._remoteParentNotSampled.shouldSample(context,traceId,spanName,spanKind,attributes,links);}if(parentContext.traceFlags&TraceFlags.SAMPLED){return this._localParentSampled.shouldSample(context,traceId,spanName,spanKind,attributes,links);}return this._localParentNotSampled.shouldSample(context,traceId,spanName,spanKind,attributes,links);};ParentBasedSampler.prototype.toString=function(){return "ParentBased{root="+this._root.toString()+", remoteParentSampled="+this._remoteParentSampled.toString()+", remoteParentNotSampled="+this._remoteParentNotSampled.toString()+", localParentSampled="+this._localParentSampled.toString()+", localParentNotSampled="+this._localParentNotSampled.toString()+"}";};return ParentBasedSampler;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//** Sampler that samples a given fraction of traces based of trace id deterministically. */var TraceIdRatioBasedSampler=/** @class */function(){function TraceIdRatioBasedSampler(_ratio){if(_ratio===void 0){_ratio=0;}this._ratio=_ratio;this._ratio=this._normalize(_ratio);this._upperBound=Math.floor(this._ratio*0xffffffff);}TraceIdRatioBasedSampler.prototype.shouldSample=function(context,traceId){return {decision:isValidTraceId(traceId)&&this._accumulate(traceId)<this._upperBound?SamplingDecision.RECORD_AND_SAMPLED:SamplingDecision.NOT_RECORD};};TraceIdRatioBasedSampler.prototype.toString=function(){return "TraceIdRatioBased{"+this._ratio+"}";};TraceIdRatioBasedSampler.prototype._normalize=function(ratio){if(typeof ratio!=='number'||isNaN(ratio))return 0;return ratio>=1?1:ratio<=0?0:ratio;};TraceIdRatioBasedSampler.prototype._accumulate=function(traceId){var accumulation=0;for(var i=0;i<traceId.length/8;i++){var pos=i*8;var part=parseInt(traceId.slice(pos,pos+8),16);accumulation=(accumulation^part)>>>0;}return accumulation;};return TraceIdRatioBasedSampler;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var env=getEnv();var FALLBACK_OTEL_TRACES_SAMPLER=TracesSamplerValues.AlwaysOn;var DEFAULT_RATIO=1;/**
    	 * Load default configuration. For fields with primitive values, any user-provided
    	 * value will override the corresponding default value. For fields with
    	 * non-primitive values (like `spanLimits`), the user-provided value will be
    	 * used to extend the default value.
    	 */// object needs to be wrapped in this function and called when needed otherwise
    	// envs are parsed before tests are ran - causes tests using these envs to fail
    	function loadDefaultConfig(){var _env=getEnv();return {sampler:buildSamplerFromEnv(env),forceFlushTimeoutMillis:30000,generalLimits:{attributeValueLengthLimit:_env.OTEL_ATTRIBUTE_VALUE_LENGTH_LIMIT,attributeCountLimit:_env.OTEL_ATTRIBUTE_COUNT_LIMIT},spanLimits:{attributeValueLengthLimit:_env.OTEL_SPAN_ATTRIBUTE_VALUE_LENGTH_LIMIT,attributeCountLimit:_env.OTEL_SPAN_ATTRIBUTE_COUNT_LIMIT,linkCountLimit:_env.OTEL_SPAN_LINK_COUNT_LIMIT,eventCountLimit:_env.OTEL_SPAN_EVENT_COUNT_LIMIT,attributePerEventCountLimit:_env.OTEL_SPAN_ATTRIBUTE_PER_EVENT_COUNT_LIMIT,attributePerLinkCountLimit:_env.OTEL_SPAN_ATTRIBUTE_PER_LINK_COUNT_LIMIT}};}/**
    	 * Based on environment, builds a sampler, complies with specification.
    	 * @param environment optional, by default uses getEnv(), but allows passing a value to reuse parsed environment
    	 */function buildSamplerFromEnv(environment){if(environment===void 0){environment=getEnv();}switch(environment.OTEL_TRACES_SAMPLER){case TracesSamplerValues.AlwaysOn:return new AlwaysOnSampler();case TracesSamplerValues.AlwaysOff:return new AlwaysOffSampler();case TracesSamplerValues.ParentBasedAlwaysOn:return new ParentBasedSampler({root:new AlwaysOnSampler()});case TracesSamplerValues.ParentBasedAlwaysOff:return new ParentBasedSampler({root:new AlwaysOffSampler()});case TracesSamplerValues.TraceIdRatio:return new TraceIdRatioBasedSampler(getSamplerProbabilityFromEnv(environment));case TracesSamplerValues.ParentBasedTraceIdRatio:return new ParentBasedSampler({root:new TraceIdRatioBasedSampler(getSamplerProbabilityFromEnv(environment))});default:diag.error("OTEL_TRACES_SAMPLER value \""+environment.OTEL_TRACES_SAMPLER+" invalid, defaulting to "+FALLBACK_OTEL_TRACES_SAMPLER+"\".");return new AlwaysOnSampler();}}function getSamplerProbabilityFromEnv(environment){if(environment.OTEL_TRACES_SAMPLER_ARG===undefined||environment.OTEL_TRACES_SAMPLER_ARG===''){diag.error("OTEL_TRACES_SAMPLER_ARG is blank, defaulting to "+DEFAULT_RATIO+".");return DEFAULT_RATIO;}var probability=Number(environment.OTEL_TRACES_SAMPLER_ARG);if(isNaN(probability)){diag.error("OTEL_TRACES_SAMPLER_ARG="+environment.OTEL_TRACES_SAMPLER_ARG+" was given, but it is invalid, defaulting to "+DEFAULT_RATIO+".");return DEFAULT_RATIO;}if(probability<0||probability>1){diag.error("OTEL_TRACES_SAMPLER_ARG="+environment.OTEL_TRACES_SAMPLER_ARG+" was given, but it is out of range ([0..1]), defaulting to "+DEFAULT_RATIO+".");return DEFAULT_RATIO;}return probability;}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * Function to merge Default configuration (as specified in './config') with
    	 * user provided configurations.
    	 */function mergeConfig(userConfig){var perInstanceDefaults={sampler:buildSamplerFromEnv()};var DEFAULT_CONFIG=loadDefaultConfig();var target=Object.assign({},DEFAULT_CONFIG,perInstanceDefaults,userConfig);target.generalLimits=Object.assign({},DEFAULT_CONFIG.generalLimits,userConfig.generalLimits||{});target.spanLimits=Object.assign({},DEFAULT_CONFIG.spanLimits,userConfig.spanLimits||{});return target;}/**
    	 * When general limits are provided and model specific limits are not,
    	 * configures the model specific limits by using the values from the general ones.
    	 * @param userConfig User provided tracer configuration
    	 */function reconfigureLimits(userConfig){var _a,_b,_c,_d,_e,_f,_g,_h,_j,_k,_l,_m;var spanLimits=Object.assign({},userConfig.spanLimits);var parsedEnvConfig=getEnvWithoutDefaults();/**
    	     * Reassign span attribute count limit to use first non null value defined by user or use default value
    	     */spanLimits.attributeCountLimit=(_f=(_e=(_d=(_b=(_a=userConfig.spanLimits)===null||_a===void 0?void 0:_a.attributeCountLimit)!==null&&_b!==void 0?_b:(_c=userConfig.generalLimits)===null||_c===void 0?void 0:_c.attributeCountLimit)!==null&&_d!==void 0?_d:parsedEnvConfig.OTEL_SPAN_ATTRIBUTE_COUNT_LIMIT)!==null&&_e!==void 0?_e:parsedEnvConfig.OTEL_ATTRIBUTE_COUNT_LIMIT)!==null&&_f!==void 0?_f:DEFAULT_ATTRIBUTE_COUNT_LIMIT;/**
    	     * Reassign span attribute value length limit to use first non null value defined by user or use default value
    	     */spanLimits.attributeValueLengthLimit=(_m=(_l=(_k=(_h=(_g=userConfig.spanLimits)===null||_g===void 0?void 0:_g.attributeValueLengthLimit)!==null&&_h!==void 0?_h:(_j=userConfig.generalLimits)===null||_j===void 0?void 0:_j.attributeValueLengthLimit)!==null&&_k!==void 0?_k:parsedEnvConfig.OTEL_SPAN_ATTRIBUTE_VALUE_LENGTH_LIMIT)!==null&&_l!==void 0?_l:parsedEnvConfig.OTEL_ATTRIBUTE_VALUE_LENGTH_LIMIT)!==null&&_m!==void 0?_m:DEFAULT_ATTRIBUTE_VALUE_LENGTH_LIMIT;return Object.assign({},userConfig,{spanLimits:spanLimits});}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * Implementation of the {@link SpanProcessor} that batches spans exported by
    	 * the SDK then pushes them to the exporter pipeline.
    	 */var BatchSpanProcessorBase=/** @class */function(){function BatchSpanProcessorBase(_exporter,config){this._exporter=_exporter;this._isExporting=false;this._finishedSpans=[];this._droppedSpansCount=0;var env=getEnv();this._maxExportBatchSize=typeof(config===null||config===void 0?void 0:config.maxExportBatchSize)==='number'?config.maxExportBatchSize:env.OTEL_BSP_MAX_EXPORT_BATCH_SIZE;this._maxQueueSize=typeof(config===null||config===void 0?void 0:config.maxQueueSize)==='number'?config.maxQueueSize:env.OTEL_BSP_MAX_QUEUE_SIZE;this._scheduledDelayMillis=typeof(config===null||config===void 0?void 0:config.scheduledDelayMillis)==='number'?config.scheduledDelayMillis:env.OTEL_BSP_SCHEDULE_DELAY;this._exportTimeoutMillis=typeof(config===null||config===void 0?void 0:config.exportTimeoutMillis)==='number'?config.exportTimeoutMillis:env.OTEL_BSP_EXPORT_TIMEOUT;this._shutdownOnce=new BindOnceFuture(this._shutdown,this);if(this._maxExportBatchSize>this._maxQueueSize){diag.warn('BatchSpanProcessor: maxExportBatchSize must be smaller or equal to maxQueueSize, setting maxExportBatchSize to match maxQueueSize');this._maxExportBatchSize=this._maxQueueSize;}}BatchSpanProcessorBase.prototype.forceFlush=function(){if(this._shutdownOnce.isCalled){return this._shutdownOnce.promise;}return this._flushAll();};// does nothing.
    	BatchSpanProcessorBase.prototype.onStart=function(_span,_parentContext){};BatchSpanProcessorBase.prototype.onEnd=function(span){if(this._shutdownOnce.isCalled){return;}if((span.spanContext().traceFlags&TraceFlags.SAMPLED)===0){return;}this._addToBuffer(span);};BatchSpanProcessorBase.prototype.shutdown=function(){return this._shutdownOnce.call();};BatchSpanProcessorBase.prototype._shutdown=function(){var _this=this;return Promise.resolve().then(function(){return _this.onShutdown();}).then(function(){return _this._flushAll();}).then(function(){return _this._exporter.shutdown();});};/** Add a span in the buffer. */BatchSpanProcessorBase.prototype._addToBuffer=function(span){if(this._finishedSpans.length>=this._maxQueueSize){// limit reached, drop span
    	if(this._droppedSpansCount===0){diag.debug('maxQueueSize reached, dropping spans');}this._droppedSpansCount++;return;}if(this._droppedSpansCount>0){// some spans were dropped, log once with count of spans dropped
    	diag.warn("Dropped "+this._droppedSpansCount+" spans because maxQueueSize reached");this._droppedSpansCount=0;}this._finishedSpans.push(span);this._maybeStartTimer();};/**
    	     * Send all spans to the exporter respecting the batch size limit
    	     * This function is used only on forceFlush or shutdown,
    	     * for all other cases _flush should be used
    	     * */BatchSpanProcessorBase.prototype._flushAll=function(){var _this=this;return new Promise(function(resolve,reject){var promises=[];// calculate number of batches
    	var count=Math.ceil(_this._finishedSpans.length/_this._maxExportBatchSize);for(var i=0,j=count;i<j;i++){promises.push(_this._flushOneBatch());}Promise.all(promises).then(function(){resolve();}).catch(reject);});};BatchSpanProcessorBase.prototype._flushOneBatch=function(){var _this=this;this._clearTimer();if(this._finishedSpans.length===0){return Promise.resolve();}return new Promise(function(resolve,reject){var timer=setTimeout(function(){// don't wait anymore for export, this way the next batch can start
    	reject(new Error('Timeout'));},_this._exportTimeoutMillis);// prevent downstream exporter calls from generating spans
    	context.with(suppressTracing(context.active()),function(){// Reset the finished spans buffer here because the next invocations of the _flush method
    	// could pass the same finished spans to the exporter if the buffer is cleared
    	// outside the execution of this callback.
    	var spans;if(_this._finishedSpans.length<=_this._maxExportBatchSize){spans=_this._finishedSpans;_this._finishedSpans=[];}else {spans=_this._finishedSpans.splice(0,_this._maxExportBatchSize);}var doExport=function(){return _this._exporter.export(spans,function(result){var _a;clearTimeout(timer);if(result.code===ExportResultCode.SUCCESS){resolve();}else {reject((_a=result.error)!==null&&_a!==void 0?_a:new Error('BatchSpanProcessor: span export failed'));}});};var pendingResources=null;for(var i=0,len=spans.length;i<len;i++){var span=spans[i];if(span.resource.asyncAttributesPending&&span.resource.waitForAsyncAttributes){pendingResources!==null&&pendingResources!==void 0?pendingResources:pendingResources=[];pendingResources.push(span.resource.waitForAsyncAttributes());}}// Avoid scheduling a promise to make the behavior more predictable and easier to test
    	if(pendingResources===null){doExport();}else {Promise.all(pendingResources).then(doExport,function(err){globalErrorHandler(err);reject(err);});}});});};BatchSpanProcessorBase.prototype._maybeStartTimer=function(){var _this=this;if(this._isExporting)return;var flush=function(){_this._isExporting=true;_this._flushOneBatch().finally(function(){_this._isExporting=false;if(_this._finishedSpans.length>0){_this._clearTimer();_this._maybeStartTimer();}}).catch(function(e){_this._isExporting=false;globalErrorHandler(e);});};// we only wait if the queue doesn't have enough elements yet
    	if(this._finishedSpans.length>=this._maxExportBatchSize){return flush();}if(this._timer!==undefined)return;this._timer=setTimeout(function(){return flush();},this._scheduledDelayMillis);unrefTimer(this._timer);};BatchSpanProcessorBase.prototype._clearTimer=function(){if(this._timer!==undefined){clearTimeout(this._timer);this._timer=undefined;}};return BatchSpanProcessorBase;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __extends$1=function(){var extendStatics=function(d,b){extendStatics=Object.setPrototypeOf||{__proto__:[]}instanceof Array&&function(d,b){d.__proto__=b;}||function(d,b){for(var p in b)if(Object.prototype.hasOwnProperty.call(b,p))d[p]=b[p];};return extendStatics(d,b);};return function(d,b){if(typeof b!=="function"&&b!==null)throw new TypeError("Class extends value "+String(b)+" is not a constructor or null");extendStatics(d,b);function __(){this.constructor=d;}d.prototype=b===null?Object.create(b):(__.prototype=b.prototype,new __());};}();var BatchSpanProcessor=/** @class */function(_super){__extends$1(BatchSpanProcessor,_super);function BatchSpanProcessor(_exporter,config){var _this=_super.call(this,_exporter,config)||this;_this.onInit(config);return _this;}BatchSpanProcessor.prototype.onInit=function(config){var _this=this;if((config===null||config===void 0?void 0:config.disableAutoFlushOnDocumentHide)!==true&&typeof document!=='undefined'){this._visibilityChangeListener=function(){if(document.visibilityState==='hidden'){void _this.forceFlush();}};this._pageHideListener=function(){void _this.forceFlush();};document.addEventListener('visibilitychange',this._visibilityChangeListener);// use 'pagehide' event as a fallback for Safari; see https://bugs.webkit.org/show_bug.cgi?id=116769
    	document.addEventListener('pagehide',this._pageHideListener);}};BatchSpanProcessor.prototype.onShutdown=function(){if(typeof document!=='undefined'){if(this._visibilityChangeListener){document.removeEventListener('visibilitychange',this._visibilityChangeListener);}if(this._pageHideListener){document.removeEventListener('pagehide',this._pageHideListener);}}};return BatchSpanProcessor;}(BatchSpanProcessorBase);/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var SPAN_ID_BYTES=8;var TRACE_ID_BYTES=16;var RandomIdGenerator=/** @class */function(){function RandomIdGenerator(){/**
    	         * Returns a random 16-byte trace ID formatted/encoded as a 32 lowercase hex
    	         * characters corresponding to 128 bits.
    	         */this.generateTraceId=getIdGenerator(TRACE_ID_BYTES);/**
    	         * Returns a random 8-byte span ID formatted/encoded as a 16 lowercase hex
    	         * characters corresponding to 64 bits.
    	         */this.generateSpanId=getIdGenerator(SPAN_ID_BYTES);}return RandomIdGenerator;}();var SHARED_CHAR_CODES_ARRAY=Array(32);function getIdGenerator(bytes){return function generateId(){for(var i=0;i<bytes*2;i++){SHARED_CHAR_CODES_ARRAY[i]=Math.floor(Math.random()*16)+48;// valid hex characters in the range 48-57 and 97-102
    	if(SHARED_CHAR_CODES_ARRAY[i]>=58){SHARED_CHAR_CODES_ARRAY[i]+=39;}}return String.fromCharCode.apply(null,SHARED_CHAR_CODES_ARRAY.slice(0,bytes*2));};}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//**
    	 * This class represents a basic tracer.
    	 */var Tracer$1=/** @class */function(){/**
    	     * Constructs a new Tracer instance.
    	     */function Tracer(instrumentationLibrary,config,_tracerProvider){this._tracerProvider=_tracerProvider;var localConfig=mergeConfig(config);this._sampler=localConfig.sampler;this._generalLimits=localConfig.generalLimits;this._spanLimits=localConfig.spanLimits;this._idGenerator=config.idGenerator||new RandomIdGenerator();this.resource=_tracerProvider.resource;this.instrumentationLibrary=instrumentationLibrary;}/**
    	     * Starts a new Span or returns the default NoopSpan based on the sampling
    	     * decision.
    	     */Tracer.prototype.startSpan=function(name,options,context$1){var _a,_b,_c;if(options===void 0){options={};}if(context$1===void 0){context$1=context.active();}// remove span from context in case a root span is requested via options
    	if(options.root){context$1=trace.deleteSpan(context$1);}var parentSpan=trace.getSpan(context$1);if(isTracingSuppressed(context$1)){diag.debug('Instrumentation suppressed, returning Noop Span');var nonRecordingSpan=trace.wrapSpanContext(INVALID_SPAN_CONTEXT);return nonRecordingSpan;}var parentSpanContext=parentSpan===null||parentSpan===void 0?void 0:parentSpan.spanContext();var spanId=this._idGenerator.generateSpanId();var traceId;var traceState;var parentSpanId;if(!parentSpanContext||!trace.isSpanContextValid(parentSpanContext)){// New root span.
    	traceId=this._idGenerator.generateTraceId();}else {// New child span.
    	traceId=parentSpanContext.traceId;traceState=parentSpanContext.traceState;parentSpanId=parentSpanContext.spanId;}var spanKind=(_a=options.kind)!==null&&_a!==void 0?_a:SpanKind$1.INTERNAL;var links=((_b=options.links)!==null&&_b!==void 0?_b:[]).map(function(link){return {context:link.context,attributes:sanitizeAttributes(link.attributes)};});var attributes=sanitizeAttributes(options.attributes);// make sampling decision
    	var samplingResult=this._sampler.shouldSample(context$1,traceId,name,spanKind,attributes,links);traceState=(_c=samplingResult.traceState)!==null&&_c!==void 0?_c:traceState;var traceFlags=samplingResult.decision===SamplingDecision$1.RECORD_AND_SAMPLED?TraceFlags.SAMPLED:TraceFlags.NONE;var spanContext={traceId:traceId,spanId:spanId,traceFlags:traceFlags,traceState:traceState};if(samplingResult.decision===SamplingDecision$1.NOT_RECORD){diag.debug('Recording is off, propagating context in a non-recording span');var nonRecordingSpan=trace.wrapSpanContext(spanContext);return nonRecordingSpan;}// Set initial span attributes. The attributes object may have been mutated
    	// by the sampler, so we sanitize the merged attributes before setting them.
    	var initAttributes=sanitizeAttributes(Object.assign(attributes,samplingResult.attributes));var span=new Span$1(this,context$1,name,spanContext,spanKind,parentSpanId,links,options.startTime,undefined,initAttributes);return span;};Tracer.prototype.startActiveSpan=function(name,arg2,arg3,arg4){var opts;var ctx;var fn;if(arguments.length<2){return;}else if(arguments.length===2){fn=arg2;}else if(arguments.length===3){opts=arg2;fn=arg3;}else {opts=arg2;ctx=arg3;fn=arg4;}var parentContext=ctx!==null&&ctx!==void 0?ctx:context.active();var span=this.startSpan(name,opts,parentContext);var contextWithSpanSet=trace.setSpan(parentContext,span);return context.with(contextWithSpanSet,fn,undefined,span);};/** Returns the active {@link GeneralLimits}. */Tracer.prototype.getGeneralLimits=function(){return this._generalLimits;};/** Returns the active {@link SpanLimits}. */Tracer.prototype.getSpanLimits=function(){return this._spanLimits;};Tracer.prototype.getActiveSpanProcessor=function(){return this._tracerProvider.getActiveSpanProcessor();};return Tracer;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */function defaultServiceName(){return 'unknown_service';}/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __assign=function(){__assign=Object.assign||function(t){for(var s,i=1,n=arguments.length;i<n;i++){s=arguments[i];for(var p in s)if(Object.prototype.hasOwnProperty.call(s,p))t[p]=s[p];}return t;};return __assign.apply(this,arguments);};var __awaiter=function(thisArg,_arguments,P,generator){function adopt(value){return value instanceof P?value:new P(function(resolve){resolve(value);});}return new(P||(P=Promise))(function(resolve,reject){function fulfilled(value){try{step(generator.next(value));}catch(e){reject(e);}}function rejected(value){try{step(generator["throw"](value));}catch(e){reject(e);}}function step(result){result.done?resolve(result.value):adopt(result.value).then(fulfilled,rejected);}step((generator=generator.apply(thisArg,_arguments||[])).next());});};var __generator=function(thisArg,body){var _={label:0,sent:function(){if(t[0]&1)throw t[1];return t[1];},trys:[],ops:[]},f,y,t,g;return g={next:verb(0),"throw":verb(1),"return":verb(2)},typeof Symbol==="function"&&(g[Symbol.iterator]=function(){return this;}),g;function verb(n){return function(v){return step([n,v]);};}function step(op){if(f)throw new TypeError("Generator is already executing.");while(_)try{if(f=1,y&&(t=op[0]&2?y["return"]:op[0]?y["throw"]||((t=y["return"])&&t.call(y),0):y.next)&&!(t=t.call(y,op[1])).done)return t;if(y=0,t)op=[op[0]&2,t.value];switch(op[0]){case 0:case 1:t=op;break;case 4:_.label++;return {value:op[1],done:false};case 5:_.label++;y=op[1];op=[0];continue;case 7:op=_.ops.pop();_.trys.pop();continue;default:if(!(t=_.trys,t=t.length>0&&t[t.length-1])&&(op[0]===6||op[0]===2)){_=0;continue;}if(op[0]===3&&(!t||op[1]>t[0]&&op[1]<t[3])){_.label=op[1];break;}if(op[0]===6&&_.label<t[1]){_.label=t[1];t=op;break;}if(t&&_.label<t[2]){_.label=t[2];_.ops.push(op);break;}if(t[2])_.ops.pop();_.trys.pop();continue;}op=body.call(thisArg,_);}catch(e){op=[6,e];y=0;}finally{f=t=0;}if(op[0]&5)throw op[1];return {value:op[0]?op[1]:void 0,done:true};}};var __read$1=function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-->0)&&!(r=i.next()).done)ar.push(r.value);}catch(error){e={error:error};}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i);}finally{if(e)throw e.error;}}return ar;};/**
    	 * A Resource describes the entity for which a signals (metrics or trace) are
    	 * collected.
    	 */var Resource=/** @class */function(){function Resource(/**
    	     * A dictionary of attributes with string keys and values that provide
    	     * information about the entity as numbers, strings or booleans
    	     * TODO: Consider to add check/validation on attributes.
    	     */attributes,asyncAttributesPromise){var _this=this;var _a;this._attributes=attributes;this.asyncAttributesPending=asyncAttributesPromise!=null;this._syncAttributes=(_a=this._attributes)!==null&&_a!==void 0?_a:{};this._asyncAttributesPromise=asyncAttributesPromise===null||asyncAttributesPromise===void 0?void 0:asyncAttributesPromise.then(function(asyncAttributes){_this._attributes=Object.assign({},_this._attributes,asyncAttributes);_this.asyncAttributesPending=false;return asyncAttributes;},function(err){diag.debug("a resource's async attributes promise rejected: %s",err);_this.asyncAttributesPending=false;return {};});}/**
    	     * Returns an empty Resource
    	     */Resource.empty=function(){return Resource.EMPTY;};/**
    	     * Returns a Resource that identifies the SDK in use.
    	     */Resource.default=function(){var _a;return new Resource((_a={},_a[SEMRESATTRS_SERVICE_NAME]=defaultServiceName(),_a[SEMRESATTRS_TELEMETRY_SDK_LANGUAGE]=SDK_INFO[SEMRESATTRS_TELEMETRY_SDK_LANGUAGE],_a[SEMRESATTRS_TELEMETRY_SDK_NAME]=SDK_INFO[SEMRESATTRS_TELEMETRY_SDK_NAME],_a[SEMRESATTRS_TELEMETRY_SDK_VERSION]=SDK_INFO[SEMRESATTRS_TELEMETRY_SDK_VERSION],_a));};Object.defineProperty(Resource.prototype,"attributes",{get:function(){var _a;if(this.asyncAttributesPending){diag.error('Accessing resource attributes before async attributes settled');}return (_a=this._attributes)!==null&&_a!==void 0?_a:{};},enumerable:false,configurable:true});/**
    	     * Returns a promise that will never be rejected. Resolves when all async attributes have finished being added to
    	     * this Resource's attributes. This is useful in exporters to block until resource detection
    	     * has finished.
    	     */Resource.prototype.waitForAsyncAttributes=function(){return __awaiter(this,void 0,void 0,function(){return __generator(this,function(_a){switch(_a.label){case 0:if(!this.asyncAttributesPending)return [3/*break*/,2];return [4/*yield*/,this._asyncAttributesPromise];case 1:_a.sent();_a.label=2;case 2:return [2/*return*/];}});});};/**
    	     * Returns a new, merged {@link Resource} by merging the current Resource
    	     * with the other Resource. In case of a collision, other Resource takes
    	     * precedence.
    	     *
    	     * @param other the Resource that will be merged with this.
    	     * @returns the newly merged Resource.
    	     */Resource.prototype.merge=function(other){var _this=this;var _a;if(!other)return this;// SpanAttributes from other resource overwrite attributes from this resource.
    	var mergedSyncAttributes=__assign(__assign({},this._syncAttributes),(_a=other._syncAttributes)!==null&&_a!==void 0?_a:other.attributes);if(!this._asyncAttributesPromise&&!other._asyncAttributesPromise){return new Resource(mergedSyncAttributes);}var mergedAttributesPromise=Promise.all([this._asyncAttributesPromise,other._asyncAttributesPromise]).then(function(_a){var _b;var _c=__read$1(_a,2),thisAsyncAttributes=_c[0],otherAsyncAttributes=_c[1];return __assign(__assign(__assign(__assign({},_this._syncAttributes),thisAsyncAttributes),(_b=other._syncAttributes)!==null&&_b!==void 0?_b:other.attributes),otherAsyncAttributes);});return new Resource(mergedSyncAttributes,mergedAttributesPromise);};Resource.EMPTY=new Resource({});return Resource;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __values=function(o){var s=typeof Symbol==="function"&&Symbol.iterator,m=s&&o[s],i=0;if(m)return m.call(o);if(o&&typeof o.length==="number")return {next:function(){if(o&&i>=o.length)o=void 0;return {value:o&&o[i++],done:!o};}};throw new TypeError(s?"Object is not iterable.":"Symbol.iterator is not defined.");};/**
    	 * Implementation of the {@link SpanProcessor} that simply forwards all
    	 * received events to a list of {@link SpanProcessor}s.
    	 */var MultiSpanProcessor=/** @class */function(){function MultiSpanProcessor(_spanProcessors){this._spanProcessors=_spanProcessors;}MultiSpanProcessor.prototype.forceFlush=function(){var e_1,_a;var promises=[];try{for(var _b=__values(this._spanProcessors),_c=_b.next();!_c.done;_c=_b.next()){var spanProcessor=_c.value;promises.push(spanProcessor.forceFlush());}}catch(e_1_1){e_1={error:e_1_1};}finally{try{if(_c&&!_c.done&&(_a=_b.return))_a.call(_b);}finally{if(e_1)throw e_1.error;}}return new Promise(function(resolve){Promise.all(promises).then(function(){resolve();}).catch(function(error){globalErrorHandler(error||new Error('MultiSpanProcessor: forceFlush failed'));resolve();});});};MultiSpanProcessor.prototype.onStart=function(span,context){var e_2,_a;try{for(var _b=__values(this._spanProcessors),_c=_b.next();!_c.done;_c=_b.next()){var spanProcessor=_c.value;spanProcessor.onStart(span,context);}}catch(e_2_1){e_2={error:e_2_1};}finally{try{if(_c&&!_c.done&&(_a=_b.return))_a.call(_b);}finally{if(e_2)throw e_2.error;}}};MultiSpanProcessor.prototype.onEnd=function(span){var e_3,_a;try{for(var _b=__values(this._spanProcessors),_c=_b.next();!_c.done;_c=_b.next()){var spanProcessor=_c.value;spanProcessor.onEnd(span);}}catch(e_3_1){e_3={error:e_3_1};}finally{try{if(_c&&!_c.done&&(_a=_b.return))_a.call(_b);}finally{if(e_3)throw e_3.error;}}};MultiSpanProcessor.prototype.shutdown=function(){var e_4,_a;var promises=[];try{for(var _b=__values(this._spanProcessors),_c=_b.next();!_c.done;_c=_b.next()){var spanProcessor=_c.value;promises.push(spanProcessor.shutdown());}}catch(e_4_1){e_4={error:e_4_1};}finally{try{if(_c&&!_c.done&&(_a=_b.return))_a.call(_b);}finally{if(e_4)throw e_4.error;}}return new Promise(function(resolve,reject){Promise.all(promises).then(function(){resolve();},reject);});};return MultiSpanProcessor;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 *//** No-op implementation of SpanProcessor */var NoopSpanProcessor=/** @class */function(){function NoopSpanProcessor(){}NoopSpanProcessor.prototype.onStart=function(_span,_context){};NoopSpanProcessor.prototype.onEnd=function(_span){};NoopSpanProcessor.prototype.shutdown=function(){return Promise.resolve();};NoopSpanProcessor.prototype.forceFlush=function(){return Promise.resolve();};return NoopSpanProcessor;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var ForceFlushState;(function(ForceFlushState){ForceFlushState[ForceFlushState["resolved"]=0]="resolved";ForceFlushState[ForceFlushState["timeout"]=1]="timeout";ForceFlushState[ForceFlushState["error"]=2]="error";ForceFlushState[ForceFlushState["unresolved"]=3]="unresolved";})(ForceFlushState||(ForceFlushState={}));/**
    	 * This class represents a basic tracer provider which platform libraries can extend
    	 */var BasicTracerProvider=/** @class */function(){function BasicTracerProvider(config){if(config===void 0){config={};}var _a;this._registeredSpanProcessors=[];this._tracers=new Map();var mergedConfig=merge({},loadDefaultConfig(),reconfigureLimits(config));this.resource=(_a=mergedConfig.resource)!==null&&_a!==void 0?_a:Resource.empty();this.resource=Resource.default().merge(this.resource);this._config=Object.assign({},mergedConfig,{resource:this.resource});var defaultExporter=this._buildExporterFromEnv();if(defaultExporter!==undefined){var batchProcessor=new BatchSpanProcessor(defaultExporter);this.activeSpanProcessor=batchProcessor;}else {this.activeSpanProcessor=new NoopSpanProcessor();}}BasicTracerProvider.prototype.getTracer=function(name,version,options){var key=name+"@"+(version||'')+":"+((options===null||options===void 0?void 0:options.schemaUrl)||'');if(!this._tracers.has(key)){this._tracers.set(key,new Tracer$1({name:name,version:version,schemaUrl:options===null||options===void 0?void 0:options.schemaUrl},this._config,this));}// eslint-disable-next-line @typescript-eslint/no-non-null-assertion
    	return this._tracers.get(key);};/**
    	     * Adds a new {@link SpanProcessor} to this tracer.
    	     * @param spanProcessor the new SpanProcessor to be added.
    	     */BasicTracerProvider.prototype.addSpanProcessor=function(spanProcessor){if(this._registeredSpanProcessors.length===0){// since we might have enabled by default a batchProcessor, we disable it
    	// before adding the new one
    	this.activeSpanProcessor.shutdown().catch(function(err){return diag.error('Error while trying to shutdown current span processor',err);});}this._registeredSpanProcessors.push(spanProcessor);this.activeSpanProcessor=new MultiSpanProcessor(this._registeredSpanProcessors);};BasicTracerProvider.prototype.getActiveSpanProcessor=function(){return this.activeSpanProcessor;};/**
    	     * Register this TracerProvider for use with the OpenTelemetry API.
    	     * Undefined values may be replaced with defaults, and
    	     * null values will be skipped.
    	     *
    	     * @param config Configuration object for SDK registration
    	     */BasicTracerProvider.prototype.register=function(config){if(config===void 0){config={};}trace.setGlobalTracerProvider(this);if(config.propagator===undefined){config.propagator=this._buildPropagatorFromEnv();}if(config.contextManager){context.setGlobalContextManager(config.contextManager);}if(config.propagator){propagation.setGlobalPropagator(config.propagator);}};BasicTracerProvider.prototype.forceFlush=function(){var timeout=this._config.forceFlushTimeoutMillis;var promises=this._registeredSpanProcessors.map(function(spanProcessor){return new Promise(function(resolve){var state;var timeoutInterval=setTimeout(function(){resolve(new Error("Span processor did not completed within timeout period of "+timeout+" ms"));state=ForceFlushState.timeout;},timeout);spanProcessor.forceFlush().then(function(){clearTimeout(timeoutInterval);if(state!==ForceFlushState.timeout){state=ForceFlushState.resolved;resolve(state);}}).catch(function(error){clearTimeout(timeoutInterval);state=ForceFlushState.error;resolve(error);});});});return new Promise(function(resolve,reject){Promise.all(promises).then(function(results){var errors=results.filter(function(result){return result!==ForceFlushState.resolved;});if(errors.length>0){reject(errors);}else {resolve();}}).catch(function(error){return reject([error]);});});};BasicTracerProvider.prototype.shutdown=function(){return this.activeSpanProcessor.shutdown();};/**
    	     * TS cannot yet infer the type of this.constructor:
    	     * https://github.com/Microsoft/TypeScript/issues/3841#issuecomment-337560146
    	     * There is no need to override either of the getters in your child class.
    	     * The type of the registered component maps should be the same across all
    	     * classes in the inheritance tree.
    	     */BasicTracerProvider.prototype._getPropagator=function(name){var _a;return (_a=this.constructor._registeredPropagators.get(name))===null||_a===void 0?void 0:_a();};BasicTracerProvider.prototype._getSpanExporter=function(name){var _a;return (_a=this.constructor._registeredExporters.get(name))===null||_a===void 0?void 0:_a();};BasicTracerProvider.prototype._buildPropagatorFromEnv=function(){var _this=this;// per spec, propagators from env must be deduplicated
    	var uniquePropagatorNames=Array.from(new Set(getEnv().OTEL_PROPAGATORS));var propagators=uniquePropagatorNames.map(function(name){var propagator=_this._getPropagator(name);if(!propagator){diag.warn("Propagator \""+name+"\" requested through environment variable is unavailable.");}return propagator;});var validPropagators=propagators.reduce(function(list,item){if(item){list.push(item);}return list;},[]);if(validPropagators.length===0){return;}else if(uniquePropagatorNames.length===1){return validPropagators[0];}else {return new CompositePropagator({propagators:validPropagators});}};BasicTracerProvider.prototype._buildExporterFromEnv=function(){var exporterName=getEnv().OTEL_TRACES_EXPORTER;if(exporterName==='none'||exporterName==='')return;var exporter=this._getSpanExporter(exporterName);if(!exporter){diag.error("Exporter \""+exporterName+"\" requested through environment variable is unavailable.");}return exporter;};BasicTracerProvider._registeredPropagators=new Map([['tracecontext',function(){return new W3CTraceContextPropagator();}],['baggage',function(){return new W3CBaggagePropagator();}]]);BasicTracerProvider._registeredExporters=new Map();return BasicTracerProvider;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __read=function(o,n){var m=typeof Symbol==="function"&&o[Symbol.iterator];if(!m)return o;var i=m.call(o),r,ar=[],e;try{while((n===void 0||n-->0)&&!(r=i.next()).done)ar.push(r.value);}catch(error){e={error:error};}finally{try{if(r&&!r.done&&(m=i["return"]))m.call(i);}finally{if(e)throw e.error;}}return ar;};var __spreadArray=function(to,from,pack){if(pack||arguments.length===2)for(var i=0,l=from.length,ar;i<l;i++){if(ar||!(i in from)){if(!ar)ar=Array.prototype.slice.call(from,0,i);ar[i]=from[i];}}return to.concat(ar||Array.prototype.slice.call(from));};/**
    	 * Stack Context Manager for managing the state in web
    	 * it doesn't fully support the async calls though
    	 */var StackContextManager=/** @class */function(){function StackContextManager(){/**
    	         * whether the context manager is enabled or not
    	         */this._enabled=false;/**
    	         * Keeps the reference to current context
    	         */this._currentContext=ROOT_CONTEXT;}/**
    	     *
    	     * @param context
    	     * @param target Function to be executed within the context
    	     */// eslint-disable-next-line @typescript-eslint/ban-types
    	StackContextManager.prototype._bindFunction=function(context,target){if(context===void 0){context=ROOT_CONTEXT;}var manager=this;var contextWrapper=function(){var _this=this;var args=[];for(var _i=0;_i<arguments.length;_i++){args[_i]=arguments[_i];}return manager.with(context,function(){return target.apply(_this,args);});};Object.defineProperty(contextWrapper,'length',{enumerable:false,configurable:true,writable:false,value:target.length});return contextWrapper;};/**
    	     * Returns the active context
    	     */StackContextManager.prototype.active=function(){return this._currentContext;};/**
    	     * Binds a the certain context or the active one to the target function and then returns the target
    	     * @param context A context (span) to be bind to target
    	     * @param target a function or event emitter. When target or one of its callbacks is called,
    	     *  the provided context will be used as the active context for the duration of the call.
    	     */StackContextManager.prototype.bind=function(context,target){// if no specific context to propagate is given, we use the current one
    	if(context===undefined){context=this.active();}if(typeof target==='function'){return this._bindFunction(context,target);}return target;};/**
    	     * Disable the context manager (clears the current context)
    	     */StackContextManager.prototype.disable=function(){this._currentContext=ROOT_CONTEXT;this._enabled=false;return this;};/**
    	     * Enables the context manager and creates a default(root) context
    	     */StackContextManager.prototype.enable=function(){if(this._enabled){return this;}this._enabled=true;this._currentContext=ROOT_CONTEXT;return this;};/**
    	     * Calls the callback function [fn] with the provided [context]. If [context] is undefined then it will use the window.
    	     * The context will be set as active
    	     * @param context
    	     * @param fn Callback function
    	     * @param thisArg optional receiver to be used for calling fn
    	     * @param args optional arguments forwarded to fn
    	     */StackContextManager.prototype.with=function(context,fn,thisArg){var args=[];for(var _i=3;_i<arguments.length;_i++){args[_i-3]=arguments[_i];}var previousContext=this._currentContext;this._currentContext=context||ROOT_CONTEXT;try{return fn.call.apply(fn,__spreadArray([thisArg],__read(args),false));}finally{this._currentContext=previousContext;}};return StackContextManager;}();/*
    	 * Copyright The OpenTelemetry Authors
    	 *
    	 * Licensed under the Apache License, Version 2.0 (the "License");
    	 * you may not use this file except in compliance with the License.
    	 * You may obtain a copy of the License at
    	 *
    	 *      https://www.apache.org/licenses/LICENSE-2.0
    	 *
    	 * Unless required by applicable law or agreed to in writing, software
    	 * distributed under the License is distributed on an "AS IS" BASIS,
    	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    	 * See the License for the specific language governing permissions and
    	 * limitations under the License.
    	 */var __extends=function(){var extendStatics=function(d,b){extendStatics=Object.setPrototypeOf||{__proto__:[]}instanceof Array&&function(d,b){d.__proto__=b;}||function(d,b){for(var p in b)if(Object.prototype.hasOwnProperty.call(b,p))d[p]=b[p];};return extendStatics(d,b);};return function(d,b){if(typeof b!=="function"&&b!==null)throw new TypeError("Class extends value "+String(b)+" is not a constructor or null");extendStatics(d,b);function __(){this.constructor=d;}d.prototype=b===null?Object.create(b):(__.prototype=b.prototype,new __());};}();/**
    	 * This class represents a web tracer with {@link StackContextManager}
    	 */var WebTracerProvider=/** @class */function(_super){__extends(WebTracerProvider,_super);/**
    	     * Constructs a new Tracer instance.
    	     * @param config Web Tracer config
    	     */function WebTracerProvider(config){if(config===void 0){config={};}var _this=_super.call(this,config)||this;if(config.contextManager){throw 'contextManager should be defined in register method not in'+' constructor';}if(config.propagator){throw 'propagator should be defined in register method not in constructor';}return _this;}/**
    	     * Register this TracerProvider for use with the OpenTelemetry API.
    	     * Undefined values may be replaced with defaults, and
    	     * null values will be skipped.
    	     *
    	     * @param config Configuration object for SDK registration
    	     */WebTracerProvider.prototype.register=function(config){if(config===void 0){config={};}if(config.contextManager===undefined){config.contextManager=new StackContextManager();}if(config.contextManager){config.contextManager.enable();}_super.prototype.register.call(this,config);};return WebTracerProvider;}(BasicTracerProvider);function serializeSpan(span){const spanInfo=span.getSpanInformation();const spanContext=span.getContext();return {traceId:spanContext.traceId,spanId:spanContext.spanId,parentSpanId:spanInfo.parentSpanId,name:spanInfo.name,startTimeUnixNano:spanInfo.startTime,endTimeUnixNano:spanInfo.endTime,attributes:spanContext.attributes,kind:spanInfo.kind,status:spanInfo.status};}var _MainTraceExporter_instances,_MainTraceExporter_transportManager,_MainTraceExporter_inProgress,_MainTraceExporter_progressCount,_MainTraceExporter_tracer,_MainTraceExporter_writeSpan;class MainTraceExporter{constructor(_ref20){let{transportManager,promiseMap=new Map(),tracer}=_ref20;_MainTraceExporter_instances.add(this);_MainTraceExporter_transportManager.set(this,void 0);_MainTraceExporter_inProgress.set(this,void 0);_MainTraceExporter_progressCount.set(this,0);_MainTraceExporter_tracer.set(this,void 0);__classPrivateFieldSet(this,_MainTraceExporter_transportManager,transportManager);__classPrivateFieldSet(this,_MainTraceExporter_inProgress,promiseMap);__classPrivateFieldSet(this,_MainTraceExporter_tracer,tracer);}shutdown(){return __awaiter$3(this,void 0,void 0,function*(){yield Promise.all(__classPrivateFieldGet(this,_MainTraceExporter_inProgress,"f").values());});}forceFlush(){return __awaiter$3(this,void 0,void 0,function*(){yield Promise.all(__classPrivateFieldGet(this,_MainTraceExporter_inProgress,"f").values());});}onStart(){}onEnd(otSpan){const span=__classPrivateFieldGet(this,_MainTraceExporter_tracer,"f").fromOTSpan(otSpan);__classPrivateFieldGet(this,_MainTraceExporter_instances,"m",_MainTraceExporter_writeSpan).call(this,span);}}_MainTraceExporter_transportManager=new WeakMap(),_MainTraceExporter_inProgress=new WeakMap(),_MainTraceExporter_progressCount=new WeakMap(),_MainTraceExporter_tracer=new WeakMap(),_MainTraceExporter_instances=new WeakSet(),_MainTraceExporter_writeSpan=function _MainTraceExporter_writeSpan(span){var _a,_b;const index=(__classPrivateFieldSet(this,_MainTraceExporter_progressCount,(_b=__classPrivateFieldGet(this,_MainTraceExporter_progressCount,"f"),_a=_b++,_b)),_a);const serializedSpan=serializeSpan(span);const work=()=>__awaiter$3(this,void 0,void 0,function*(){yield __classPrivateFieldGet(this,_MainTraceExporter_transportManager,"f").processSpan(serializedSpan);__classPrivateFieldGet(this,_MainTraceExporter_inProgress,"f").delete(index);});__classPrivateFieldGet(this,_MainTraceExporter_inProgress,"f").set(index,work());};function addChildSpanNameToParent(childSpanName,parent){var _a,_b;if(parent){const attribute=(_b=(_a=parent.getSpanInformation())===null||_a===void 0?void 0:_a.childrenNames)!==null&&_b!==void 0?_b:[];attribute.push(childSpanName);parent.setAttribute(AggregationAttributes.ChildrenNames,attribute);}}const KnownAttributes=_exports.KnownAttributes={Tag:"outsystems.log.message.tag",Visibility:"outsystems.otel.access.visibility",AccessType:"outsystems.otel.access.type",ChildrenNames:AggregationAttributes.ChildrenNames,IsNonAggregable:AggregationAttributes.IsNonAggregable};const InternalAttributes=[KnownAttributes.IsNonAggregable,KnownAttributes.ChildrenNames];var _Span_innerSpan,_Span_activateSpan,_Span_resolveEndedPromise,_Span_explicitChildren;class Span{constructor(_ref21){let{visibility,attributes={},span,activateSpan,explicitChildren=[]}=_ref21;_Span_innerSpan.set(this,void 0);_Span_activateSpan.set(this,void 0);_Span_resolveEndedPromise.set(this,void 0);_Span_explicitChildren.set(this,void 0);__classPrivateFieldSet(this,_Span_innerSpan,span);__classPrivateFieldSet(this,_Span_activateSpan,activateSpan);__classPrivateFieldSet(this,_Span_explicitChildren,explicitChildren);if(visibility!==undefined){__classPrivateFieldGet(this,_Span_innerSpan,"f").setAttribute(KnownAttributes.Visibility,mapVisibilityToNumber[visibility]);}__classPrivateFieldGet(this,_Span_innerSpan,"f").setAttributes(attributes);this.ended=new Promise(resolve=>{__classPrivateFieldSet(this,_Span_resolveEndedPromise,resolve);});}setAttribute(key,value){__classPrivateFieldGet(this,_Span_innerSpan,"f").setAttribute(key,value);}setStatus(status,message){__classPrivateFieldGet(this,_Span_innerSpan,"f").setStatus({code:status,message});}raiseError(ex,message){__classPrivateFieldGet(this,_Span_innerSpan,"f").recordException(ex);this.setStatus(2,message);}getContext(){const spanContext=__classPrivateFieldGet(this,_Span_innerSpan,"f").spanContext();return {spanId:spanContext.spanId,traceId:spanContext.traceId,attributes:__classPrivateFieldGet(this,_Span_innerSpan,"f").attributes,sampled:Boolean(spanContext.traceFlags&1)};}addEvent(name,attributes){__classPrivateFieldGet(this,_Span_innerSpan,"f").addEvent(name,attributes);}end(){return __awaiter$3(this,void 0,void 0,function*(){var _a;yield Promise.all(__classPrivateFieldGet(this,_Span_explicitChildren,"f").map(child=>child.ended));__classPrivateFieldGet(this,_Span_innerSpan,"f").end();(_a=__classPrivateFieldGet(this,_Span_resolveEndedPromise,"f"))===null||_a===void 0?void 0:_a.call(this);});}fail(){__classPrivateFieldGet(this,_Span_innerSpan,"f").setStatus({code:SpanStatusCode.ERROR});}getSpanInformation(){return {name:__classPrivateFieldGet(this,_Span_innerSpan,"f").name,kind:__classPrivateFieldGet(this,_Span_innerSpan,"f").kind,status:__classPrivateFieldGet(this,_Span_innerSpan,"f").status.code,parentSpanId:__classPrivateFieldGet(this,_Span_innerSpan,"f").parentSpanId,startTime:Instant.toNanoSeconds(new Instant(__classPrivateFieldGet(this,_Span_innerSpan,"f").startTime)),endTime:Instant.toNanoSeconds(new Instant(__classPrivateFieldGet(this,_Span_innerSpan,"f").endTime)),childrenNames:__classPrivateFieldGet(this,_Span_innerSpan,"f").attributes[AggregationAttributes.ChildrenNames]};}activate(){return __classPrivateFieldGet(this,_Span_activateSpan,"f").call(this);}addExplicitChild(child){__classPrivateFieldGet(this,_Span_explicitChildren,"f").push(child);}}_Span_innerSpan=new WeakMap(),_Span_activateSpan=new WeakMap(),_Span_resolveEndedPromise=new WeakMap(),_Span_explicitChildren=new WeakMap();var _Tracer_instances,_Tracer_transportManager,_Tracer_tracerProvider,_Tracer_enabled,_Tracer_innerTracer,_Tracer_contextManager,_Tracer_getActiveSpan,_Tracer_setSpan,_Tracer_baseAttributes,_Tracer_staticAttributes,_Tracer_handleStaticAttributes;class Tracer{constructor(_ref22){let{transports,baseAttributes={},staticAttributes=[],databaseNameSuffix,transportManager=new TransportManager({traceTransports:transports,databaseNameSuffix}),tracerProvider=new WebTracerProvider(),contextManager=new ZoneContextManager(),tracer=tracerProvider.getTracer("@outsystems/logger-js","3.4.1"),exporter,enabled=true,getActiveSpan=()=>trace.getActiveSpan(),setSpan=(ctx,span)=>trace.setSpan(ctx,span)}=_ref22;_Tracer_instances.add(this);_Tracer_transportManager.set(this,void 0);_Tracer_tracerProvider.set(this,void 0);_Tracer_enabled.set(this,void 0);_Tracer_innerTracer.set(this,void 0);_Tracer_contextManager.set(this,void 0);_Tracer_getActiveSpan.set(this,void 0);_Tracer_setSpan.set(this,void 0);_Tracer_baseAttributes.set(this,void 0);_Tracer_staticAttributes.set(this,void 0);__classPrivateFieldSet(this,_Tracer_transportManager,transportManager);__classPrivateFieldSet(this,_Tracer_innerTracer,tracer);__classPrivateFieldSet(this,_Tracer_enabled,enabled);__classPrivateFieldSet(this,_Tracer_getActiveSpan,getActiveSpan);__classPrivateFieldSet(this,_Tracer_tracerProvider,tracerProvider);__classPrivateFieldSet(this,_Tracer_setSpan,setSpan);__classPrivateFieldSet(this,_Tracer_contextManager,contextManager);__classPrivateFieldSet(this,_Tracer_baseAttributes,baseAttributes);__classPrivateFieldSet(this,_Tracer_staticAttributes,staticAttributes);const processor=exporter!==null&&exporter!==void 0?exporter:new MainTraceExporter({transportManager,tracer:this});__classPrivateFieldGet(this,_Tracer_tracerProvider,"f").register({contextManager});__classPrivateFieldGet(this,_Tracer_tracerProvider,"f").addSpanProcessor(processor);}addTransport(transport){__classPrivateFieldGet(this,_Tracer_transportManager,"f").addTraceTransport(transport);}removeTransport(transportId){__classPrivateFieldGet(this,_Tracer_transportManager,"f").removeTraceTransport(transportId);}startSpan(name,visibility,parent,kind){if(__classPrivateFieldGet(this,_Tracer_enabled,"f")){const parentSpan=parent!==null&&parent!==void 0?parent:__classPrivateFieldGet(this,_Tracer_getActiveSpan,"f").call(this)?this.fromOTSpan(__classPrivateFieldGet(this,_Tracer_getActiveSpan,"f").call(this)):undefined;addChildSpanNameToParent(name,parentSpan);const otSpan=parent?__classPrivateFieldGet(this,_Tracer_innerTracer,"f").startSpan(name,{attributes:{},kind:kind},parent.activate()):__classPrivateFieldGet(this,_Tracer_innerTracer,"f").startSpan(name,{kind:kind});const span=this.fromOTSpan(otSpan,visibility);parent===null||parent===void 0?void 0:parent.addExplicitChild(span);return span;}else {return undefined;}}startActiveSpan(name,fnWorker,visibility,parent,kind){if(__classPrivateFieldGet(this,_Tracer_enabled,"f")){const fn=otSpan=>{const span=this.fromOTSpan(otSpan,visibility);parent===null||parent===void 0?void 0:parent.addExplicitChild(span);return fnWorker(span);};const result=parent?__classPrivateFieldGet(this,_Tracer_innerTracer,"f").startActiveSpan(name,{attributes:{},kind:kind},parent.activate(),fn):__classPrivateFieldGet(this,_Tracer_innerTracer,"f").startActiveSpan(name,{kind:kind},fn);return result;}else {return fnWorker(undefined);}}getActiveSpan(){const otSpan=__classPrivateFieldGet(this,_Tracer_getActiveSpan,"f").call(this);return otSpan?this.fromOTSpan(otSpan):undefined;}setStatus(enabled){__classPrivateFieldSet(this,_Tracer_enabled,enabled);}addBaseSpanAttributes(attributes){__classPrivateFieldSet(this,_Tracer_baseAttributes,Object.assign(Object.assign({},__classPrivateFieldGet(this,_Tracer_baseAttributes,"f")),attributes));}enableFetchInstrumentation(){let fetchInstrumentation=arguments.length>0&&arguments[0]!==undefined?arguments[0]:new FetchInstrumentation();fetchInstrumentation.setTracerProvider(__classPrivateFieldGet(this,_Tracer_tracerProvider,"f"));}span(serializedSpan){return __awaiter$3(this,void 0,void 0,function*(){yield __classPrivateFieldGet(this,_Tracer_transportManager,"f").processSpan(serializedSpan);});}flush(){return __awaiter$3(this,void 0,void 0,function*(){__classPrivateFieldGet(this,_Tracer_transportManager,"f").flushSpans();});}setSchedulerTimerInterval(timerInterval){__classPrivateFieldGet(this,_Tracer_transportManager,"f").setSchedulerTimerInterval(timerInterval);}fromOTSpan(otSpan,visibility){const attributes=__classPrivateFieldGet(this,_Tracer_instances,"m",_Tracer_handleStaticAttributes).call(this,otSpan);return new Span({span:otSpan,attributes:evaluateObjFuncValues(attributes),activateSpan:()=>__classPrivateFieldGet(this,_Tracer_setSpan,"f").call(this,__classPrivateFieldGet(this,_Tracer_contextManager,"f").active(),otSpan),visibility});}}_exports.Tracer=Tracer;_Tracer_transportManager=new WeakMap(),_Tracer_tracerProvider=new WeakMap(),_Tracer_enabled=new WeakMap(),_Tracer_innerTracer=new WeakMap(),_Tracer_contextManager=new WeakMap(),_Tracer_getActiveSpan=new WeakMap(),_Tracer_setSpan=new WeakMap(),_Tracer_baseAttributes=new WeakMap(),_Tracer_staticAttributes=new WeakMap(),_Tracer_instances=new WeakSet(),_Tracer_handleStaticAttributes=function _Tracer_handleStaticAttributes(otSpan){const attributes=Object.assign({},__classPrivateFieldGet(this,_Tracer_baseAttributes,"f"));const isRootSpan=otSpan.parentSpanId===undefined;if(!isRootSpan){Object.keys(attributes).forEach(key=>{if(__classPrivateFieldGet(this,_Tracer_staticAttributes,"f").includes(key)){delete attributes[key];}});}return attributes;};var _ConsoleTransport_instances,_ConsoleTransport_shouldWriteLogsOnConsoles,_ConsoleTransport_canWriteOnConsole;const DEFAULT_CATEGORY="Application";class ConsoleTransport{constructor(_ref23){let{transportId,logTypeBaseline=LogType$1.Debug,formatter,transportConsole=console,shouldWriteLogsOnConsoles=()=>false}=_ref23;_ConsoleTransport_instances.add(this);_ConsoleTransport_shouldWriteLogsOnConsoles.set(this,void 0);this.formatConsoleLog=log=>{var _a,_b,_c,_d;const logOutput={errorCode:log.type===LogType$1.Error?(_a=log.errorCode)!==null&&_a!==void 0?_a:DefaultErrorCode:undefined,category:(_b=log.category)!==null&&_b!==void 0?_b:DEFAULT_CATEGORY,message:(_d=(_c=log===null||log===void 0?void 0:log.error)===null||_c===void 0?void 0:_c.message)!==null&&_d!==void 0?_d:log.message,timestamp:Instant.toISOString(log.timestamp)};return `${logOutput.timestamp}:${logOutput.errorCode?" "+logOutput.errorCode:""} [${logOutput.category}] ${logOutput.message}`;};this.transportId=transportId;this.logTypeBaseline=logTypeBaseline;this.formatter=formatter;this.transportConsole=transportConsole;__classPrivateFieldSet(this,_ConsoleTransport_shouldWriteLogsOnConsoles,shouldWriteLogsOnConsoles);}getTransportId(){return this.transportId;}requiresConnectivity(){return false;}hasWriteBuffer(){return false;}getLogTypeBaseline(){return this.logTypeBaseline;}setLogTypeBaseline(logType){this.logTypeBaseline=logType;}write(log){return __awaiter$3(this,void 0,void 0,function*(){if(!__classPrivateFieldGet(this,_ConsoleTransport_instances,"m",_ConsoleTransport_canWriteOnConsole).call(this,log)){return;}const logOutput=this.formatter?this.formatter.format(log):this.formatConsoleLog(log);switch(log.type){case LogType$1.Debug:this.transportConsole.debug(logOutput);break;case LogType$1.Info:this.transportConsole.log(logOutput);break;case LogType$1.Warning:this.transportConsole.warn(logOutput);break;case LogType$1.Error:this.transportConsole.error(logOutput,log.error);break;default:this.transportConsole.log(logOutput);}});}writeAll(logs){return __awaiter$3(this,void 0,void 0,function*(){for(const log of logs){yield this.write(log);}});}}_ConsoleTransport_shouldWriteLogsOnConsoles=new WeakMap(),_ConsoleTransport_instances=new WeakSet(),_ConsoleTransport_canWriteOnConsole=function _ConsoleTransport_canWriteOnConsole(log){return log.visibility===Visibility$1.External||__classPrivateFieldGet(this,_ConsoleTransport_shouldWriteLogsOnConsoles,"f").call(this);};function mapLogFieldToAttributes(log){const mappedLogAttributes={};if(log.category){mappedLogAttributes[KnownAttributes.Tag]=log.category;}return mappedLogAttributes;}class NativeLoggerFormatter{format(log){var _a,_b;const logVisibility=(_a=log.visibility)!==null&&_a!==void 0?_a:Visibility$1.External;const exceptionAttributes=getExceptionAttributes(log);const fieldAttributes=mapLogFieldToAttributes(log);const allLogAttributes=Object.assign(Object.assign(Object.assign({[KnownAttributes.Visibility]:mapVisibilityToNumber[logVisibility]},exceptionAttributes),fieldAttributes),log.attributes);const sanitizedAttributes=sanitizeUrlAttribute(allLogAttributes);const logTimestampISO=Instant.toISOString(log.timestamp);const nativeLoggerRecord={message:(_b=log.message)!==null&&_b!==void 0?_b:"",attributes:sanitizedAttributes,instant:logTimestampISO};return nativeLoggerRecord;}}const mapLogTypeToNativeLoggerMethod={[LogType$1.Debug]:"logDebug",[LogType$1.Info]:"logInfo",[LogType$1.Warning]:"logWarning",[LogType$1.Error]:"logError",[LogType$1.Trace]:"logTrace"};class NativeLoggerTransport{constructor(_ref24){let{transportId,logTypeBaseline,nativeLoggerV2,formatter=new NativeLoggerFormatter()}=_ref24;this.transportId=transportId;this.logTypeBaseline=logTypeBaseline;this.nativeLoggerV2=nativeLoggerV2;this.formatter=formatter;}getTransportId(){return this.transportId;}requiresConnectivity(){return false;}hasWriteBuffer(){return false;}getLogTypeBaseline(){return this.logTypeBaseline;}setLogTypeBaseline(logType){this.logTypeBaseline=logType;}write(log){return __awaiter$3(this,void 0,void 0,function*(){const payload=this.formatter.format(log);const loggerMethod=mapLogTypeToNativeLoggerMethod[log.type];const logResult=this.nativeLoggerV2[loggerMethod](payload);return logResult;});}writeAll(logs){return __awaiter$3(this,void 0,void 0,function*(){for(const log of logs){yield this.write(log);}});}}var _OpenTelemetryLogFormatter_resourceAttributes;const MESSAGE_MAX_LENGTH=2000;const mapLogTypeToSeverityNumber={[LogType$1.Trace]:1,[LogType$1.Debug]:5,[LogType$1.Info]:9,[LogType$1.Warning]:13,[LogType$1.Error]:17};const mapLogTypeToSeverityText={[LogType$1.Debug]:"Debug",[LogType$1.Info]:"Information",[LogType$1.Warning]:"Warning",[LogType$1.Error]:"Error",[LogType$1.Trace]:"Trace"};const getOptionalLogRecordFields=log=>{const optionalLogRecordFields={body:{stringValue:""}};if(log.message){const truncatedMessage=log.message.length>MESSAGE_MAX_LENGTH?`${log.message.substring(0,MESSAGE_MAX_LENGTH-3)}...`:log.message;optionalLogRecordFields.body={stringValue:truncatedMessage};}return optionalLogRecordFields;};class OpenTelemetryLogFormatter{constructor(){let{resourceAttributes={}}=arguments.length>0&&arguments[0]!==undefined?arguments[0]:{};_OpenTelemetryLogFormatter_resourceAttributes.set(this,void 0);__classPrivateFieldSet(this,_OpenTelemetryLogFormatter_resourceAttributes,resourceAttributes);}setResourceAttributes(attributes){__classPrivateFieldSet(this,_OpenTelemetryLogFormatter_resourceAttributes,attributes!==null&&attributes!==void 0?attributes:{});}format(log){return this.formatAll([log]);}formatAll(logs){const allResourceAttributes=Object.assign({[KnownAttributes.AccessType]:3},__classPrivateFieldGet(this,_OpenTelemetryLogFormatter_resourceAttributes,"f"));const resourcesPayload=convertObjectToAttributesList(allResourceAttributes);const logsFormatted=logs.map(log=>formatLog(log));return formatRequest$1(logsFormatted,resourcesPayload);}}_OpenTelemetryLogFormatter_resourceAttributes=new WeakMap();function formatRequest$1(logsFormatted,resourcesPayload){return {resourceLogs:[{resource:{attributes:resourcesPayload},scopeLogs:[{scope:{name:"@outsystems/logger-js",version:"3.4.1"},logRecords:logsFormatted}]}]};}function formatLog(log){var _a;const logVisibility=(_a=log.visibility)!==null&&_a!==void 0?_a:Visibility$1.External;const exceptionAttributes=getExceptionAttributes(log);const traceFields=getTraceFields(log);const mappedLogAttributes=mapLogFieldToAttributes(log);const allLogAttributes=Object.assign(Object.assign(Object.assign({[KnownAttributes.Visibility]:mapVisibilityToNumber[logVisibility]},exceptionAttributes),mappedLogAttributes),log.attributes);const sanitizedAttributes=sanitizeUrlAttribute(allLogAttributes);const attributesPayload=convertObjectToAttributesList(sanitizedAttributes);const severityNumber=mapLogTypeToSeverityNumber[log.type];const severityText=mapLogTypeToSeverityText[log.type];const timeUnixNanoSeconds=Instant.toNanoSeconds(log.timestamp);const optionalLogRecordFields=getOptionalLogRecordFields(log);return Object.assign(Object.assign(Object.assign({},optionalLogRecordFields),traceFields),{timeUnixNano:timeUnixNanoSeconds,severityNumber,severityText,attributes:attributesPayload});}var _OpenTelemetryLoggerTransport_instances,_OpenTelemetryLoggerTransport_tagId,_OpenTelemetryLoggerTransport_baseUrl,_OpenTelemetryLoggerTransport_postLogs;const LOGS_ENDPOINT_V2="/v2/logs";class OpenTelemetryLoggerTransport{constructor(_ref25){let{transportId,resourceAttributes,logTypeBaseline,logsEndpoint=LOGS_ENDPOINT_V2,logsCollectorBaseUrl,tagId,enableWriteBuffer=true,httpClient=new _communicationJs.HttpClient({baseUrl:logsCollectorBaseUrl,headers:tagId?{"api-key":tagId,"tag-id":tagId}:{}}),formatter=new OpenTelemetryLogFormatter({resourceAttributes})}=_ref25;_OpenTelemetryLoggerTransport_instances.add(this);_OpenTelemetryLoggerTransport_tagId.set(this,void 0);_OpenTelemetryLoggerTransport_baseUrl.set(this,void 0);this.transportId=transportId;this.logTypeBaseline=logTypeBaseline;this.logsEndpoint=logsEndpoint;this.enableWriteBuffer=enableWriteBuffer;this.httpClient=httpClient;this.formatter=formatter;__classPrivateFieldSet(this,_OpenTelemetryLoggerTransport_tagId,tagId);__classPrivateFieldSet(this,_OpenTelemetryLoggerTransport_baseUrl,logsCollectorBaseUrl);}getTransportId(){return this.transportId;}requiresConnectivity(){return true;}hasWriteBuffer(){return this.enableWriteBuffer;}getLogTypeBaseline(){return this.logTypeBaseline;}setLogTypeBaseline(logType){this.logTypeBaseline=logType;}setTagId(tagId){__classPrivateFieldSet(this,_OpenTelemetryLoggerTransport_tagId,tagId);}setResourceAttributes(resourceAttributes){var _a,_b;(_b=(_a=this.formatter).setResourceAttributes)===null||_b===void 0?void 0:_b.call(_a,resourceAttributes);}write(log){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_OpenTelemetryLoggerTransport_instances,"m",_OpenTelemetryLoggerTransport_postLogs).call(this,this.formatter.format(log));});}writeAll(logs){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_OpenTelemetryLoggerTransport_instances,"m",_OpenTelemetryLoggerTransport_postLogs).call(this,this.formatter.formatAll(logs));});}}_OpenTelemetryLoggerTransport_tagId=new WeakMap(),_OpenTelemetryLoggerTransport_baseUrl=new WeakMap(),_OpenTelemetryLoggerTransport_instances=new WeakSet(),_OpenTelemetryLoggerTransport_postLogs=function _OpenTelemetryLoggerTransport_postLogs(payload){return __awaiter$3(this,void 0,void 0,function*(){return this.httpClient.post({url:this.logsEndpoint,payload,contentType:_communicationJs.ContentType.Json,headers:__classPrivateFieldGet(this,_OpenTelemetryLoggerTransport_tagId,"f")?{"api-key":__classPrivateFieldGet(this,_OpenTelemetryLoggerTransport_tagId,"f"),"tag-id":__classPrivateFieldGet(this,_OpenTelemetryLoggerTransport_tagId,"f")}:{},baseURL:__classPrivateFieldGet(this,_OpenTelemetryLoggerTransport_baseUrl,"f")});});};var _OpenTelemetryTraceFormatter_instances,_OpenTelemetryTraceFormatter_resourceAttributes,_OpenTelemetryTraceFormatter_filterInternalAttributes;class OpenTelemetryTraceFormatter{constructor(){let{resourceAttributes={}}=arguments.length>0&&arguments[0]!==undefined?arguments[0]:{};_OpenTelemetryTraceFormatter_instances.add(this);_OpenTelemetryTraceFormatter_resourceAttributes.set(this,void 0);__classPrivateFieldSet(this,_OpenTelemetryTraceFormatter_resourceAttributes,resourceAttributes);}setResourceAttributes(attributes){__classPrivateFieldSet(this,_OpenTelemetryTraceFormatter_resourceAttributes,attributes!==null&&attributes!==void 0?attributes:{});}format(span){return this.formatAll([span]);}formatAll(spans){const allResourceAttributes=Object.assign({[KnownAttributes.AccessType]:3},__classPrivateFieldGet(this,_OpenTelemetryTraceFormatter_resourceAttributes,"f"));const resourcesPayload=convertObjectToAttributesList(allResourceAttributes);const spansPayload=spans.map(span=>{const allTraceAttributes=Object.assign({[KnownAttributes.Visibility]:mapVisibilityToNumber[Visibility$1.External]},__classPrivateFieldGet(this,_OpenTelemetryTraceFormatter_instances,"m",_OpenTelemetryTraceFormatter_filterInternalAttributes).call(this,span.attributes));const sanitizedAttributes=sanitizeUrlAttribute(allTraceAttributes);const spanAttributes=convertObjectToAttributesList(sanitizedAttributes);return Object.assign({traceId:span.traceId,spanId:span.spanId,parentSpanId:span.parentSpanId,name:span.name,startTimeUnixNano:span.startTimeUnixNano,endTimeUnixNano:span.endTimeUnixNano,status:{code:span.status!==0?span.status:1},attributes:spanAttributes},span.kind?{kind:span.kind}:{});});return formatRequest(spansPayload,resourcesPayload);}}_OpenTelemetryTraceFormatter_resourceAttributes=new WeakMap(),_OpenTelemetryTraceFormatter_instances=new WeakSet(),_OpenTelemetryTraceFormatter_filterInternalAttributes=function _OpenTelemetryTraceFormatter_filterInternalAttributes(attributes){return Object.entries(attributes).reduce((acc,_ref26)=>{let[key,value]=_ref26;if(!InternalAttributes.includes(key)){acc[key]=value;}return acc;},{});};function formatRequest(spansPayload,resourcesPayload){return {resourceSpans:[{resource:{attributes:resourcesPayload},scopeSpans:[{scope:{name:"@outsystems/logger-js",version:"3.4.1"},spans:spansPayload}]}]};}var _OpenTelemetryTracerTransport_instances,_OpenTelemetryTracerTransport_enabled,_OpenTelemetryTracerTransport_tagId,_OpenTelemetryTracerTransport_baseUrl,_OpenTelemetryTracerTransport_postSpans;const TRACES_ENDPOINT_V2="/v2/traces";class OpenTelemetryTracerTransport{constructor(_ref27){let{transportId,resourceAttributes,enabled=true,tracesEndpoint=TRACES_ENDPOINT_V2,tracesCollectorBaseUrl,tagId,enableWriteBuffer=true,httpClient=new _communicationJs.HttpClient({baseUrl:tracesCollectorBaseUrl,headers:tagId?{"api-key":tagId,"tag-id":tagId}:{}}),formatter=new OpenTelemetryTraceFormatter({resourceAttributes})}=_ref27;_OpenTelemetryTracerTransport_instances.add(this);_OpenTelemetryTracerTransport_enabled.set(this,void 0);_OpenTelemetryTracerTransport_tagId.set(this,void 0);_OpenTelemetryTracerTransport_baseUrl.set(this,void 0);this.transportId=transportId;__classPrivateFieldSet(this,_OpenTelemetryTracerTransport_enabled,enabled);this.tracesEndpoint=tracesEndpoint;this.enableWriteBuffer=enableWriteBuffer;this.httpClient=httpClient;this.formatter=formatter;__classPrivateFieldSet(this,_OpenTelemetryTracerTransport_tagId,tagId);__classPrivateFieldSet(this,_OpenTelemetryTracerTransport_baseUrl,tracesCollectorBaseUrl);}getTransportId(){return this.transportId;}isTracingEnabled(){return __classPrivateFieldGet(this,_OpenTelemetryTracerTransport_enabled,"f");}enableTracing(){__classPrivateFieldSet(this,_OpenTelemetryTracerTransport_enabled,true);}disableTracing(){__classPrivateFieldSet(this,_OpenTelemetryTracerTransport_enabled,false);}requiresConnectivity(){return true;}hasWriteBuffer(){return this.enableWriteBuffer;}setTagId(tagId){__classPrivateFieldSet(this,_OpenTelemetryTracerTransport_tagId,tagId);}setResourceAttributes(resourceAttributes){var _a,_b;(_b=(_a=this.formatter).setResourceAttributes)===null||_b===void 0?void 0:_b.call(_a,resourceAttributes);}write(span){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_OpenTelemetryTracerTransport_instances,"m",_OpenTelemetryTracerTransport_postSpans).call(this,this.formatter.format(span));});}writeAll(spans){return __awaiter$3(this,void 0,void 0,function*(){return __classPrivateFieldGet(this,_OpenTelemetryTracerTransport_instances,"m",_OpenTelemetryTracerTransport_postSpans).call(this,this.formatter.formatAll(spans));});}}_OpenTelemetryTracerTransport_enabled=new WeakMap(),_OpenTelemetryTracerTransport_tagId=new WeakMap(),_OpenTelemetryTracerTransport_baseUrl=new WeakMap(),_OpenTelemetryTracerTransport_instances=new WeakSet(),_OpenTelemetryTracerTransport_postSpans=function _OpenTelemetryTracerTransport_postSpans(payload){return __awaiter$3(this,void 0,void 0,function*(){return this.httpClient.post({url:this.tracesEndpoint,payload,contentType:_communicationJs.ContentType.Json,headers:__classPrivateFieldGet(this,_OpenTelemetryTracerTransport_tagId,"f")?{"api-key":__classPrivateFieldGet(this,_OpenTelemetryTracerTransport_tagId,"f"),"tag-id":__classPrivateFieldGet(this,_OpenTelemetryTracerTransport_tagId,"f")}:{},baseURL:__classPrivateFieldGet(this,_OpenTelemetryTracerTransport_baseUrl,"f")});});};var _ServiceWorkerTransport_sw,_ServiceWorkerTransport_container,_ServiceWorkerTransport_pendingMessages,_ServiceWorkerTransport_waitingForSW;class ServiceWorkerTransport{constructor(){let{sw,container=navigator.serviceWorker}=arguments.length>0&&arguments[0]!==undefined?arguments[0]:{};var _a;_ServiceWorkerTransport_sw.set(this,void 0);_ServiceWorkerTransport_container.set(this,void 0);_ServiceWorkerTransport_pendingMessages.set(this,[]);_ServiceWorkerTransport_waitingForSW.set(this,false);if(!container){throw new Error("No service worker container available");}__classPrivateFieldSet(this,_ServiceWorkerTransport_sw,(_a=sw!==null&&sw!==void 0?sw:container===null||container===void 0?void 0:container.controller)!==null&&_a!==void 0?_a:undefined);__classPrivateFieldSet(this,_ServiceWorkerTransport_container,container);this.waitForSW();}get pendingMessages(){return __classPrivateFieldGet(this,_ServiceWorkerTransport_pendingMessages,"f");}isServiceWorkerAvailable(){return !!__classPrivateFieldGet(this,_ServiceWorkerTransport_sw,"f")&&__classPrivateFieldGet(this,_ServiceWorkerTransport_sw,"f").state==="activated";}send(kind,data){this.sendMessage({kind,data});}sendMessage(message,options){var _a;if(this.isServiceWorkerAvailable()){(_a=__classPrivateFieldGet(this,_ServiceWorkerTransport_sw,"f"))===null||_a===void 0?void 0:_a.postMessage(message,options);}else {__classPrivateFieldGet(this,_ServiceWorkerTransport_pendingMessages,"f").push({message,options});this.waitForSW();}}waitForSW(){return __awaiter$3(this,void 0,void 0,function*(){if(this.isServiceWorkerAvailable()||__classPrivateFieldGet(this,_ServiceWorkerTransport_waitingForSW,"f")){return;}__classPrivateFieldSet(this,_ServiceWorkerTransport_waitingForSW,true);const{active}=yield __classPrivateFieldGet(this,_ServiceWorkerTransport_container,"f").ready;__classPrivateFieldSet(this,_ServiceWorkerTransport_sw,active!==null&&active!==void 0?active:undefined);__classPrivateFieldSet(this,_ServiceWorkerTransport_waitingForSW,false);this.flushMessages();});}flushMessages(){var _a;if(this.isServiceWorkerAvailable()){for(const{message,options}of __classPrivateFieldGet(this,_ServiceWorkerTransport_pendingMessages,"f")){(_a=__classPrivateFieldGet(this,_ServiceWorkerTransport_sw,"f"))===null||_a===void 0?void 0:_a.postMessage(message,options);}__classPrivateFieldSet(this,_ServiceWorkerTransport_pendingMessages,[]);}else {this.waitForSW();}}}_ServiceWorkerTransport_sw=new WeakMap(),_ServiceWorkerTransport_container=new WeakMap(),_ServiceWorkerTransport_pendingMessages=new WeakMap(),_ServiceWorkerTransport_waitingForSW=new WeakMap();var _ServiceWorkerTracerTransport_instances,_ServiceWorkerTracerTransport_transportId,_ServiceWorkerTracerTransport_swTransport,_ServiceWorkerTracerTransport_attributes,_ServiceWorkerTracerTransport_tagId,_ServiceWorkerTracerTransport_collectorBaseUrl,_ServiceWorkerTracerTransport_databaseSuffix,_ServiceWorkerTracerTransport_aggregateSpans,_ServiceWorkerTracerTransport_enabled,_ServiceWorkerTracerTransport_getMetadata;class ServiceWorkerTracerTransport{constructor(_ref28){let{transportId,tagId,collectorBaseUrl,databaseSuffix,swTransport=new ServiceWorkerTransport(),enabled=true,attributes={},aggregateSpans=false}=_ref28;_ServiceWorkerTracerTransport_instances.add(this);_ServiceWorkerTracerTransport_transportId.set(this,void 0);_ServiceWorkerTracerTransport_swTransport.set(this,void 0);_ServiceWorkerTracerTransport_attributes.set(this,void 0);_ServiceWorkerTracerTransport_tagId.set(this,void 0);_ServiceWorkerTracerTransport_collectorBaseUrl.set(this,void 0);_ServiceWorkerTracerTransport_databaseSuffix.set(this,void 0);_ServiceWorkerTracerTransport_aggregateSpans.set(this,void 0);_ServiceWorkerTracerTransport_enabled.set(this,void 0);__classPrivateFieldSet(this,_ServiceWorkerTracerTransport_transportId,transportId);__classPrivateFieldSet(this,_ServiceWorkerTracerTransport_swTransport,swTransport);__classPrivateFieldSet(this,_ServiceWorkerTracerTransport_enabled,enabled);__classPrivateFieldSet(this,_ServiceWorkerTracerTransport_attributes,attributes);__classPrivateFieldSet(this,_ServiceWorkerTracerTransport_tagId,tagId);__classPrivateFieldSet(this,_ServiceWorkerTracerTransport_collectorBaseUrl,collectorBaseUrl);__classPrivateFieldSet(this,_ServiceWorkerTracerTransport_databaseSuffix,databaseSuffix);__classPrivateFieldSet(this,_ServiceWorkerTracerTransport_aggregateSpans,aggregateSpans);}getTransportId(){return __classPrivateFieldGet(this,_ServiceWorkerTracerTransport_transportId,"f");}requiresConnectivity(){return false;}isTracingEnabled(){return __classPrivateFieldGet(this,_ServiceWorkerTracerTransport_enabled,"f");}enableTracing(){__classPrivateFieldSet(this,_ServiceWorkerTracerTransport_enabled,true);}disableTracing(){__classPrivateFieldSet(this,_ServiceWorkerTracerTransport_enabled,false);}hasWriteBuffer(){return false;}write(span){__classPrivateFieldGet(this,_ServiceWorkerTracerTransport_swTransport,"f").send("Span",{span,meta:__classPrivateFieldGet(this,_ServiceWorkerTracerTransport_instances,"m",_ServiceWorkerTracerTransport_getMetadata).call(this)});return Promise.resolve();}writeAll(spans){for(const span of spans){__classPrivateFieldGet(this,_ServiceWorkerTracerTransport_swTransport,"f").send("Span",{span,meta:__classPrivateFieldGet(this,_ServiceWorkerTracerTransport_instances,"m",_ServiceWorkerTracerTransport_getMetadata).call(this)});}return Promise.resolve();}flush(){__classPrivateFieldGet(this,_ServiceWorkerTracerTransport_swTransport,"f").send("Flush",{kind:"Spans",meta:__classPrivateFieldGet(this,_ServiceWorkerTracerTransport_instances,"m",_ServiceWorkerTracerTransport_getMetadata).call(this)});return Promise.resolve();}}_ServiceWorkerTracerTransport_transportId=new WeakMap(),_ServiceWorkerTracerTransport_swTransport=new WeakMap(),_ServiceWorkerTracerTransport_attributes=new WeakMap(),_ServiceWorkerTracerTransport_tagId=new WeakMap(),_ServiceWorkerTracerTransport_collectorBaseUrl=new WeakMap(),_ServiceWorkerTracerTransport_databaseSuffix=new WeakMap(),_ServiceWorkerTracerTransport_aggregateSpans=new WeakMap(),_ServiceWorkerTracerTransport_enabled=new WeakMap(),_ServiceWorkerTracerTransport_instances=new WeakSet(),_ServiceWorkerTracerTransport_getMetadata=function _ServiceWorkerTracerTransport_getMetadata(){return {databaseSuffix:__classPrivateFieldGet(this,_ServiceWorkerTracerTransport_databaseSuffix,"f"),resourceAttributes:__classPrivateFieldGet(this,_ServiceWorkerTracerTransport_attributes,"f"),collectorBaseUrl:__classPrivateFieldGet(this,_ServiceWorkerTracerTransport_collectorBaseUrl,"f"),apiKey:__classPrivateFieldGet(this,_ServiceWorkerTracerTransport_tagId,"f"),aggregateSpans:__classPrivateFieldGet(this,_ServiceWorkerTracerTransport_aggregateSpans,"f")};};var _InstrumentationFactory_instances,_InstrumentationFactory_transportManager,_InstrumentationFactory_tracerInstance,_InstrumentationFactory_loggerInstance,_InstrumentationFactory_shouldWriteLogsOnConsoles,_InstrumentationFactory_baseLogAttributes,_InstrumentationFactory_baseSpanAttributes,_InstrumentationFactory_staticSpanAttributes,_InstrumentationFactory_databaseNameSuffix,_InstrumentationFactory_getActiveSpanInfo;class InstrumentationFactory{constructor(_ref29){let{databaseNameSuffix,logTransports,traceTransports,baseLogAttributes={},baseSpanAttributes={},staticSpanAttributes=[],isOnline,aggregateSpans,transportManager=new TransportManager({databaseNameSuffix,logTransports,traceTransports,isOnline,aggregateSpans}),tracerInstance,loggerInstance}=_ref29;_InstrumentationFactory_instances.add(this);_InstrumentationFactory_transportManager.set(this,void 0);_InstrumentationFactory_tracerInstance.set(this,void 0);_InstrumentationFactory_loggerInstance.set(this,void 0);_InstrumentationFactory_shouldWriteLogsOnConsoles.set(this,void 0);_InstrumentationFactory_baseLogAttributes.set(this,void 0);_InstrumentationFactory_baseSpanAttributes.set(this,void 0);_InstrumentationFactory_staticSpanAttributes.set(this,void 0);_InstrumentationFactory_databaseNameSuffix.set(this,void 0);__classPrivateFieldSet(this,_InstrumentationFactory_transportManager,transportManager);__classPrivateFieldSet(this,_InstrumentationFactory_tracerInstance,tracerInstance);__classPrivateFieldSet(this,_InstrumentationFactory_loggerInstance,loggerInstance);__classPrivateFieldSet(this,_InstrumentationFactory_shouldWriteLogsOnConsoles,()=>_settingsJs.FeaturesManager.isEnabled(_settingsJs.FeatureKeys.WriteLogsOnConsoles));__classPrivateFieldSet(this,_InstrumentationFactory_baseLogAttributes,baseLogAttributes);__classPrivateFieldSet(this,_InstrumentationFactory_baseSpanAttributes,baseSpanAttributes);__classPrivateFieldSet(this,_InstrumentationFactory_staticSpanAttributes,staticSpanAttributes);__classPrivateFieldSet(this,_InstrumentationFactory_databaseNameSuffix,databaseNameSuffix);}init(){return __awaiter$3(this,void 0,void 0,function*(){yield this.getLogger();this.getTracer();});}getLogger(){return __awaiter$3(this,void 0,void 0,function*(){if(!__classPrivateFieldGet(this,_InstrumentationFactory_loggerInstance,"f")){__classPrivateFieldSet(this,_InstrumentationFactory_loggerInstance,yield Logger.build({transportManager:__classPrivateFieldGet(this,_InstrumentationFactory_transportManager,"f"),baseAttributes:__classPrivateFieldGet(this,_InstrumentationFactory_baseLogAttributes,"f")}));}return __classPrivateFieldGet(this,_InstrumentationFactory_loggerInstance,"f");});}getTracer(){if(!__classPrivateFieldGet(this,_InstrumentationFactory_tracerInstance,"f")){__classPrivateFieldSet(this,_InstrumentationFactory_tracerInstance,new Tracer({transportManager:__classPrivateFieldGet(this,_InstrumentationFactory_transportManager,"f"),baseAttributes:__classPrivateFieldGet(this,_InstrumentationFactory_baseSpanAttributes,"f"),staticAttributes:__classPrivateFieldGet(this,_InstrumentationFactory_staticSpanAttributes,"f")}));}return __classPrivateFieldGet(this,_InstrumentationFactory_tracerInstance,"f");}useNativeLoggerTransport(_a){return __awaiter$3(this,arguments,void 0,function(_ref30){var _this15=this;let{plugin,logTypeBaseline}=_ref30;return function*(){const loggerInstance=yield _this15.getLogger();loggerInstance.addTransport(new NativeLoggerTransport({transportId:"native-logger-transport",nativeLoggerV2:plugin,logTypeBaseline}));}();});}useOpenTelemetryLoggerTransport(_a){return __awaiter$3(this,arguments,void 0,function(_ref31){var _this16=this;let{resourceAttributes,logTypeBaseline,collectorBaseUrl,tagId,httpClient}=_ref31;return function*(){const loggerInstance=yield _this16.getLogger();loggerInstance.addTransport(new OpenTelemetryLoggerTransport({transportId:"otel-logger-transport",resourceAttributes,logTypeBaseline,logsCollectorBaseUrl:collectorBaseUrl,tagId,httpClient}));}();});}useConsoleLoggerTransport(logTypeBaseline){return __awaiter$3(this,void 0,void 0,function*(){const loggerInstance=yield this.getLogger();loggerInstance.addTransport(new ConsoleTransport({transportId:"console-transport",logTypeBaseline,shouldWriteLogsOnConsoles:__classPrivateFieldGet(this,_InstrumentationFactory_shouldWriteLogsOnConsoles,"f")}));});}useServiceWorkerTracerTransport(_ref32){let{resourceAttributes,enabled=true,collectorBaseUrl,tagId,swTransport,aggregateSpans=false}=_ref32;const tracerInstance=this.getTracer();const transporter=new ServiceWorkerTracerTransport({transportId:"sw-tracer-transport",attributes:resourceAttributes,enabled,tagId,collectorBaseUrl,databaseSuffix:__classPrivateFieldGet(this,_InstrumentationFactory_databaseNameSuffix,"f"),swTransport,aggregateSpans});tracerInstance.addTransport(transporter);}useOpenTelemetryTracerTransport(_ref33){let{resourceAttributes,enabled=true,collectorBaseUrl,tagId,httpClient}=_ref33;const tracerInstance=this.getTracer();const transporter=new OpenTelemetryTracerTransport({transportId:"otel-tracer-transport",resourceAttributes,enabled,tagId,tracesCollectorBaseUrl:collectorBaseUrl,httpClient});tracerInstance.addTransport(transporter);}useConsoleTracerTransport(){return __awaiter$3(this,void 0,void 0,function*(){throw new Error("Not implemented");});}useFetchInstrumentation(){const tracerInstance=this.getTracer();tracerInstance.enableFetchInstrumentation();}setLogLevel(logType){__classPrivateFieldGet(this,_InstrumentationFactory_transportManager,"f").setAllLogTypeBaselines(logType);}setTracerStatus(enabled){const tracerInstance=this.getTracer();tracerInstance.setStatus(enabled);}setTagId(tagId){__classPrivateFieldGet(this,_InstrumentationFactory_transportManager,"f").setTagId(tagId);}setAggregateSpansStatus(enabled){__classPrivateFieldGet(this,_InstrumentationFactory_transportManager,"f").setAggregateSpansStatus(enabled);}setResourceAttributes(resourceAttributes){__classPrivateFieldGet(this,_InstrumentationFactory_transportManager,"f").setResourceAttributes(resourceAttributes);}setSchedulerTimerInterval(timeInterval){__classPrivateFieldGet(this,_InstrumentationFactory_transportManager,"f").setSchedulerTimerInterval(timeInterval);}flushInstrumentationData(){return __awaiter$3(this,void 0,void 0,function*(){yield Promise.all([__classPrivateFieldGet(this,_InstrumentationFactory_transportManager,"f").flushLogs(),__classPrivateFieldGet(this,_InstrumentationFactory_transportManager,"f").flushSpans()]);});}logError(_a){return __awaiter$3(this,arguments,void 0,function(_ref34){var _this17=this;let{category,message,error,errorCode,visibility,failSpan=true,attributes}=_ref34;return function*(){if(failSpan){const tracerInstance=_this17.getTracer();const span=tracerInstance.getActiveSpan();span===null||span===void 0?void 0:span.fail();}const loggerInstance=yield _this17.getLogger();loggerInstance.error({category,message,error,errorCode,visibility,span:__classPrivateFieldGet(_this17,_InstrumentationFactory_instances,"m",_InstrumentationFactory_getActiveSpanInfo).call(_this17),attributes});}();});}logWarning(_a){return __awaiter$3(this,arguments,void 0,function(_ref35){var _this18=this;let{category,message,visibility,attributes}=_ref35;return function*(){const loggerInstance=yield _this18.getLogger();loggerInstance.warning({category,message,visibility,span:__classPrivateFieldGet(_this18,_InstrumentationFactory_instances,"m",_InstrumentationFactory_getActiveSpanInfo).call(_this18),attributes});}();});}logInfo(_a){return __awaiter$3(this,arguments,void 0,function(_ref36){var _this19=this;let{category,message,visibility,attributes}=_ref36;return function*(){const loggerInstance=yield _this19.getLogger();loggerInstance.info({category,message,visibility,span:__classPrivateFieldGet(_this19,_InstrumentationFactory_instances,"m",_InstrumentationFactory_getActiveSpanInfo).call(_this19),attributes});}();});}logDebug(_a){return __awaiter$3(this,arguments,void 0,function(_ref37){var _this20=this;let{category,message,visibility,attributes}=_ref37;return function*(){const loggerInstance=yield _this20.getLogger();loggerInstance.debug({category,message,visibility,span:__classPrivateFieldGet(_this20,_InstrumentationFactory_instances,"m",_InstrumentationFactory_getActiveSpanInfo).call(_this20),attributes});}();});}log(logObject){return __awaiter$3(this,void 0,void 0,function*(){const loggerInstance=yield this.getLogger();yield loggerInstance.log(logObject);});}span(serializedSpan){return __awaiter$3(this,void 0,void 0,function*(){const tracerInstance=this.getTracer();yield tracerInstance.span(serializedSpan);});}flushLogs(){return __awaiter$3(this,void 0,void 0,function*(){yield __classPrivateFieldGet(this,_InstrumentationFactory_transportManager,"f").flushLogs();});}flushSpans(){return __awaiter$3(this,void 0,void 0,function*(){yield __classPrivateFieldGet(this,_InstrumentationFactory_transportManager,"f").flushSpans();});}startSpan(name,visibility,parent,kind){const tracerInstance=this.getTracer();return tracerInstance.startSpan(name,visibility,parent,kind);}startActiveSpan(name,fnWorker,visibility,parent,kind){const tracerInstance=this.getTracer();return tracerInstance.startActiveSpan(name,fnWorker,visibility,parent,kind);}getActiveSpan(){const tracerInstance=this.getTracer();return tracerInstance.getActiveSpan();}}_exports.InstrumentationFactory=InstrumentationFactory;_InstrumentationFactory_transportManager=new WeakMap(),_InstrumentationFactory_tracerInstance=new WeakMap(),_InstrumentationFactory_loggerInstance=new WeakMap(),_InstrumentationFactory_shouldWriteLogsOnConsoles=new WeakMap(),_InstrumentationFactory_baseLogAttributes=new WeakMap(),_InstrumentationFactory_baseSpanAttributes=new WeakMap(),_InstrumentationFactory_staticSpanAttributes=new WeakMap(),_InstrumentationFactory_databaseNameSuffix=new WeakMap(),_InstrumentationFactory_instances=new WeakSet(),_InstrumentationFactory_getActiveSpanInfo=function _InstrumentationFactory_getActiveSpanInfo(){const tracer=this.getTracer();const activeSpan=tracer.getActiveSpan();return activeSpan?serializeSpan(activeSpan):undefined;};var SpanKind;(function(SpanKind){SpanKind[SpanKind["Internal"]=0]="Internal";SpanKind[SpanKind["Client"]=2]="Client";})(SpanKind||(_exports.SpanKind=SpanKind={}));_exports.Version="3.4.1";}); 
    } (dist$1));

    var ClientPayloadKind;
    (function (ClientPayloadKind) {
        ClientPayloadKind["Log"] = "Log";
        ClientPayloadKind["Span"] = "Span";
        ClientPayloadKind["Flush"] = "Flush";
    })(ClientPayloadKind || (ClientPayloadKind = {}));

    const registered = {};
    var ServiceNames;
    (function (ServiceNames) {
        ServiceNames["InstrumentationFactory"] = "InstrumentationFactory";
    })(ServiceNames || (ServiceNames = {}));
    function getInstance(service) {
        return registered[service];
    }
    function setInstance(service, implementation) {
        const serviceImplementation = implementation();
        registered[service] = serviceImplementation;
    }

    var _TracerWrapper_currentInstrumentationConfig;
    class TracerWrapper {
        constructor({ instrumentationConfig }) {
            _TracerWrapper_currentInstrumentationConfig.set(this, void 0);
            __classPrivateFieldSet(this, _TracerWrapper_currentInstrumentationConfig, instrumentationConfig, "f");
        }
        processClientMessage(_a) {
            return __awaiter(this, arguments, void 0, function* ({ payload, instrumentationFactory = getInstance(ServiceNames.InstrumentationFactory), startSpanInstrumentation = (payload) => this.startSpanInstrumentation({ payload }), processSpan = (span) => this.processSpan({ span }), }) {
                if (payload.kind === ClientPayloadKind.Span) {
                    const data = payload.data;
                    yield startSpanInstrumentation(data.meta);
                    yield processSpan(data.span);
                }
                else if (payload.kind === ClientPayloadKind.Flush) {
                    const data = payload.data;
                    if (data.kind === "Spans") {
                        yield startSpanInstrumentation(data.meta);
                        yield (instrumentationFactory === null || instrumentationFactory === void 0 ? void 0 : instrumentationFactory.flushSpans());
                    }
                    else if (data.kind === "All") {
                        yield startSpanInstrumentation(data.meta.span);
                        yield (instrumentationFactory === null || instrumentationFactory === void 0 ? void 0 : instrumentationFactory.flushSpans());
                    }
                }
            });
        }
        processSpan(_a) {
            return __awaiter(this, arguments, void 0, function* ({ span, instrumentationFactory = getInstance(ServiceNames.InstrumentationFactory), }) {
                yield instrumentationFactory.span(span);
            });
        }
        startSpanInstrumentation(_a) {
            return __awaiter(this, void 0, void 0, function* () {
                var _b;
                var { payload, fetchInstance = (_b = globalThis.fetch) === null || _b === void 0 ? void 0 : _b.bind(globalThis), factoryConfig = __classPrivateFieldGet(this, _TracerWrapper_currentInstrumentationConfig, "f"), createFactoryInstance = (config) => new dist$1.InstrumentationFactory({
                    databaseNameSuffix: config.databaseSuffix,
                    aggregateSpans: config.aggregateSpans,
                }), updateFactoryConfig = (newConfig) => {
                    __classPrivateFieldSet(this, _TracerWrapper_currentInstrumentationConfig, newConfig, "f");
                }, setFactoryInstance = setInstance, setTransport = (factory, payload, fetchInstance) => this.setTracerTransport(factory, payload, fetchInstance), processSpanFunction = (factory, span) => factory === null || factory === void 0 ? void 0 : factory.span(span), } = _a;
                if (JSON.stringify(payload) !== JSON.stringify(factoryConfig)) {
                    const instrumentationFactory = createFactoryInstance(payload);
                    setFactoryInstance(ServiceNames.InstrumentationFactory, () => instrumentationFactory);
                    setTransport(instrumentationFactory, payload, fetchInstance);
                    updateFactoryConfig(payload);
                }
            });
        }
        setTracerTransport(factory, payload, fetchInstance) {
            factory.useOpenTelemetryTracerTransport({
                resourceAttributes: payload.resourceAttributes,
                collectorBaseUrl: payload.collectorBaseUrl,
                tagId: payload.apiKey,
                enabled: true,
                httpClient: new dist$2.FetchHttpClient({
                    baseUrl: payload.collectorBaseUrl,
                    headers: payload.apiKey ? { "api-key": payload.apiKey, "tag-id": payload.apiKey } : {},
                    fetchClient: fetchInstance,
                }),
            });
        }
    }
    _TracerWrapper_currentInstrumentationConfig = new WeakMap();

    const startInstrumentationModule = ({ workerScope, logger = new Logger({ workerScope }), messageHandler = traceModuleMessageEvent, tracerWrapper = new TracerWrapper({}), }) => {
        workerScope.addEventListener("message", (event) => {
            messageHandler({ event, logger, traceHandler: traceMessageHandler, tracerWrapper });
        });
    };
    const traceModuleMessageEvent = ({ event, logger, traceHandler, tracerWrapper, }) => {
        try {
            event.waitUntil(traceHandler({ event, logger, tracerWrapper }));
        }
        catch (e) {
            logger.error("Error handling Traces module message", e);
        }
    };
    const traceMessageHandler = (_a) => __awaiter(void 0, [_a], void 0, function* ({ event, logger, tracerWrapper, }) {
        yield (tracerWrapper === null || tracerWrapper === void 0 ? void 0 : tracerWrapper.processClientMessage({ payload: event.data }));
    });

    const Version = "0.9.3";

    exports.Version = Version;
    exports.startInstrumentationModule = startInstrumentationModule;
    exports.startServiceWorker = startServiceWorker;

}));
