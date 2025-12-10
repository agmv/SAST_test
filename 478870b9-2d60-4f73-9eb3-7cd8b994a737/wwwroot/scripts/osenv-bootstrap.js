(function () {
    function appendMetaTagAttributes(metaTag, attribute, values) {
        var elem = document.querySelector("meta[name=" + metaTag + "]");

        if (elem) {
            var attrContent = elem.getAttribute(attribute);
            elem.setAttribute(attribute, (attrContent ? attrContent + "," : "") + values.join(","));
        }
    }

    if (navigator && /OutSystemsApp/i.test(navigator.userAgent)) {
        // If this app is running on the native shell, we want to disable the zoom
        appendMetaTagAttributes("viewport", "content", ["user-scalable=no", "minimum-scale=1.0"]);
    }
})();
