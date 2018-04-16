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
var searchSedule_service_1 = require("./searchSedule.service");
var subway_service_1 = require("../subway/subway.service");
var ng2_translate_1 = require("ng2-translate");
var SearchSeduleComponent = (function () {
    function SearchSeduleComponent(subwayService, translate) {
        this.subwayService = subwayService;
        this.translate = translate;
        this.Status = searchSedule_service_1.Status;
        this.status = searchSedule_service_1.Status.Start;
        translate.addLangs(["en", "zh-tw"]);
        translate.setDefaultLang('zh-tw');
        var browserLang = translate.getBrowserLang();
        translate.use(browserLang.match(/en|zh-tw/) ? browserLang : 'zh-tw');
    }
    SearchSeduleComponent.prototype.ngAfterViewInit = function () {
        var _this = this;
        $('input').eq(0).datepicker();
        this.subwayService.asyncGetDestinationList().subscribe(function (resp) {
            _this.destination = resp.Destination;
            console.log(resp);
            _this.fromPlace = _this.destination[0].destination;
            _this.toPlace = _this.destination[0].destination;
        }, function (error) {
            alert(error.json().message);
        });
    };
    SearchSeduleComponent.prototype.backToSchedule = function () {
        this.fromPlace = this.destination[0].destination;
        this.toPlace = this.destination[0].destination;
        this.status = searchSedule_service_1.Status.Start;
    };
    SearchSeduleComponent.prototype.findSchedule = function () {
        if (this.fromPlace == this.toPlace) {
            alert("目的地和出發點相同");
            return;
        }
        this.status = searchSedule_service_1.Status.Search;
    };
    SearchSeduleComponent = __decorate([
        core_1.Component({
            selector: 'searchSedule',
            templateUrl: './app/searchSedule/searchSedule.html',
            providers: [subway_service_1.SubWayService]
        }),
        __metadata("design:paramtypes", [subway_service_1.SubWayService, ng2_translate_1.TranslateService])
    ], SearchSeduleComponent);
    return SearchSeduleComponent;
}());
exports.SearchSeduleComponent = SearchSeduleComponent;
//# sourceMappingURL=searchSedule.component.js.map