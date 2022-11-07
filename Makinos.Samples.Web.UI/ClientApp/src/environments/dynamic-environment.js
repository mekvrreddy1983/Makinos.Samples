"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.DynamicEnvironment = void 0;
var DynamicEnvironment = /** @class */ (function () {
    function DynamicEnvironment() {
    }
    Object.defineProperty(DynamicEnvironment.prototype, "apiUrl", {
        get: function () {
            return window.config.apiUrl;
        },
        enumerable: false,
        configurable: true
    });
    return DynamicEnvironment;
}());
exports.DynamicEnvironment = DynamicEnvironment;
//# sourceMappingURL=dynamic-environment.js.map