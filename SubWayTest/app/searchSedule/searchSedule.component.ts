import { Input, Component, AfterViewInit } from '@angular/core';
import { SearchSeduleService, Status } from './searchSedule.service';
import { SubWayService } from '../subway/subway.service';
import { TranslateService } from 'ng2-translate';
import * as moment from 'moment';

@Component({
    selector: 'searchSedule',
    templateUrl: './app/searchSedule/searchSedule.html',
    providers: [SubWayService, SearchSeduleService]
})
export class SearchSeduleComponent implements AfterViewInit{
    Status = Status;
    status: Status = Status.Start;
    destination: any; 
    fromPlace: string;
    toPlace: string;
    ticketList: any[];

    constructor(private subwayService: SubWayService, private translate: TranslateService, private searchSeduleService : SearchSeduleService) {
        translate.addLangs(["en", "zh-tw"]);
        translate.setDefaultLang('zh-tw');
        let browserLang = translate.getBrowserLang();
        translate.use(browserLang.match(/en|zh-tw/) ? browserLang : 'zh-tw');
    }

    dateFormat(date: Date) {
        if (date != null)
            var result = moment(date).format('YYYY/MM/DD');
        return result;
    }

    ngAfterViewInit() {

        $('input').eq(0).datepicker();
        this.searchSeduleService.asyncIndex().subscribe(
            resp => {
                console.log(resp);
                this.ticketList = resp;
            },
            error => {
                alert(error.json().message);
            }
         )
        this.subwayService.asyncGetDestinationList().subscribe(
            resp => {
                this.destination = resp.Destination;
                console.log(resp);
                this.fromPlace = this.destination[0].destination;
                this.toPlace = this.destination[0].destination;
            },
            error => {
                alert(error.json().message);
            }
        )
    }

    backToSchedule() {
        this.fromPlace = this.destination[0].destination;
        this.toPlace = this.destination[0].destination;
        this.status = Status.Start;
    }

    findSchedule() {
        if (this.fromPlace == this.toPlace) {
            alert("目的地和出發點相同");
            return;
        }
        this.status = Status.Search;
    }
}