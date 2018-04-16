"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var ng2_translate_1 = require("ng2-translate");
var searchBooking_component_1 = require("./searchBooking.component");
var SearchBookingModule = (function () {
    function SearchBookingModule() {
    }
    SearchBookingModule = __decorate([
        core_1.NgModule({
            imports: [platform_browser_1.BrowserModule, ng2_translate_1.TranslateModule.forRoot()],
            declarations: [searchBooking_component_1.SearchBookingComponent],
            bootstrap: [searchBooking_component_1.SearchBookingComponent]
        })
    ], SearchBookingModule);
    return SearchBookingModule;
}());
exports.SearchBookingModule = SearchBookingModule;
//# sourceMappingURL=searchBooking.module.js.map