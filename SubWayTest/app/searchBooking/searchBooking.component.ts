import { Input, Component } from '@angular/core';
import { SearchBookingService, Status } from './searchBooking.service';
import { TranslateService } from 'ng2-translate';

@Component({
    selector: 'searchBooking',
    templateUrl: './app/searchBooking/searchBooking.html',
    providers: [SearchBookingService]
})
export class SearchBookingComponent {
    Status = Status;
    status: Status = Status.Search;

    constructor(private translate: TranslateService) {
        translate.addLangs(["en", "zh-tw"]);
        translate.setDefaultLang('zh-tw');
        let browserLang = translate.getBrowserLang();
        translate.use(browserLang.match(/en|zh-tw/) ? browserLang : 'zh-tw');
    }

    checkValidation() {
        let errorMessage: string[] = [];
        if ($('input').eq(0).val() == '')
            errorMessage.push("請輸入身份證字號");
        if ($('input').eq(1).val() == '')
            errorMessage.push("請輸入電腦代碼");
        return errorMessage.join('\n');
    }

    goToStatusResult() {
        let errorMessage = this.checkValidation();
        if (errorMessage.length == 0)
            this.status = Status.Result;
        else
            alert(errorMessage);
    }
}