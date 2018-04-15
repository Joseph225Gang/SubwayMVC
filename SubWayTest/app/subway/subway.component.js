"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var ng2_translate_1 = require("ng2-translate");
var subway_service_1 = require("./subway.service");
var SubWayComponent = (function () {
    function SubWayComponent(translate) {
        this.translate = translate;
        this.Status = subway_service_1.Status;
        this.status = subway_service_1.Status.Start;
        this.numberTicket = 0;
        this.typeTicket = '';
        this.amount = 0;
        this.hHi = new HHi();
        this.hi = new Hi();
        translate.addLangs(["en", "zh-tw"]);
        translate.setDefaultLang('zh-tw');
        var browserLang = translate.getBrowserLang();
        translate.use(browserLang.match(/en|zh-tw/) ? browserLang : 'zh-tw');
    }
    SubWayComponent.prototype.gotoHome = function () {
        location.href = './Home';
    };
    SubWayComponent.prototype.enterBuyStatus = function () {
        this.status = subway_service_1.Status.Buy;
    };
    SubWayComponent.prototype.setDatePicker = function () {
        $('#destinationDate').datepicker();
        $('#homeDate').datepicker();
    };
    SubWayComponent.prototype.finializePurchaseStatus = function () {
        this.status = subway_service_1.Status.Finish;
        this.typeTicket = $('select').val().toString().substring(0, 3);
        this.amount = this.numberTicket * parseInt($('select').val().toString().substring(4, 7));
    };
    SubWayComponent.prototype.backtoStart = function () {
        location.reload();
    };
    SubWayComponent.prototype.choiceHello = function (callback, data, stackUpData) {
        alert(data.num);
        callback();
        stackUpData.push(data);
        console.log(stackUpData);
        console.log(this.hHi);
    };
    SubWayComponent.prototype.sayHello = function () {
        alert('hi');
    };
    SubWayComponent = __decorate([
        core_1.Component({
            selector: 'subwayComponent',
            templateUrl: './app/subway/subway.html'
        }),
        __metadata("design:paramtypes", [ng2_translate_1.TranslateService])
    ], SubWayComponent);
    return SubWayComponent;
}());
exports.SubWayComponent = SubWayComponent;
var Hi = (function () {
    function Hi() {
        this.num = 5;
    }
    return Hi;
}());
var HHi = (function () {
    function HHi() {
        this.hi = [];
    }
    return HHi;
}());
//# sourceMappingURL=subway.component.js.map