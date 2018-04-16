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
var cancelBooking_service_1 = require("./cancelBooking.service");
var ng2_translate_1 = require("ng2-translate");
var CancelBookingComponent = (function () {
    function CancelBookingComponent(translate) {
        this.translate = translate;
        this.Status = cancelBooking_service_1.Status;
        this.status = cancelBooking_service_1.Status.Search;
        translate.addLangs(["en", "zh-tw"]);
        translate.setDefaultLang('zh-tw');
        var browserLang = translate.getBrowserLang();
        translate.use(browserLang.match(/en|zh-tw/) ? browserLang : 'zh-tw');
    }
    CancelBookingComponent.prototype.checkValidation = function () {
        var errorMessage = [];
        if ($('input').eq(0).val() == '')
            errorMessage.push("請輸入身份證字號");
        if ($('input').eq(1).val() == '')
            errorMessage.push("請輸入電腦代碼");
        return errorMessage.join('\n');
    };
    CancelBookingComponent.prototype.goToStatusResult = function () {
        var errorMessage = this.checkValidation();
        if (errorMessage.length == 0)
            this.status = cancelBooking_service_1.Status.Result;
        else
            alert(errorMessage);
    };
    CancelBookingComponent.prototype.removeBooking = function () {
        $("td").unbind("click");
        $('td').click(function () {
            var row_index = $(this).closest("tr").index();
            $('tr').eq(row_index + 1).remove();
        });
    };
    CancelBookingComponent = __decorate([
        core_1.Component({
            selector: 'cancelBooking',
            templateUrl: './app/cancelBooking/cancelBooking.html',
            providers: [cancelBooking_service_1.CancelBookingService]
        }),
        __metadata("design:paramtypes", [ng2_translate_1.TranslateService])
    ], CancelBookingComponent);
    return CancelBookingComponent;
}());
exports.CancelBookingComponent = CancelBookingComponent;
//# sourceMappingURL=cancelBooking.component.js.map