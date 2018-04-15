import { Component, AfterViewInit } from '@angular/core';
import { TranslateService } from 'ng2-translate';
import { Status } from './subway.service';
import { Router } from '@angular/router';
import {
    trigger,
    state,
    style,
    animate,
    transition
} from '@angular/animations';

@Component({
    selector: 'subwayComponent',
    templateUrl: './app/subway/subway.html'
})

export class SubWayComponent{
    hi: Hi;
    hHi: HHi;
    constructor(private translate: TranslateService) {
        this.hHi = new HHi();
        this.hi = new Hi();
        translate.addLangs(["en", "zh-tw"]);
        translate.setDefaultLang('zh-tw');

        let browserLang = translate.getBrowserLang();
        translate.use(browserLang.match(/en|zh-tw/) ? browserLang : 'zh-tw');
    }
    Status = Status;
    status: Status = Status.Start;
    numberTicket: number = 0;
    typeTicket: string = '';
    amount: number = 0;

    gotoHome() {
        location.href = './Home';
    }

    enterBuyStatus() {
        this.status = Status.Buy;
    }

    setDatePicker() {
        $('#destinationDate').datepicker();
        $('#homeDate').datepicker();
    }
    finializePurchaseStatus() {
        this.status = Status.Finish;
        this.typeTicket = $('select').val().toString().substring(0, 3);
        this.amount = this.numberTicket * parseInt($('select').val().toString().substring(4, 7));
    }

    backtoStart() {
        location.reload();
    }

    choiceHello(callback: any, data: any, stackUpData: any) {
        alert(data.num);
        callback();
        stackUpData.push(data);
        console.log(stackUpData);
        console.log(this.hHi);
    }

    sayHello() {
        alert('hi');
    }
}

class Hi {
    num: number = 5;
}

class HHi {
    hi: Hi[] = [];
}