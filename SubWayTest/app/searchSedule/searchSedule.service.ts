import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response, URLSearchParams } from '@angular/http';
import { Observable } from 'rxjs/Rx';

@Injectable()
export class SearchSeduleService {
    private SearchApi: string = 'api/SubwayTicketApi';
    constructor(
        private http: Http
    ) { };

    asyncIndex() {
        let body = null;
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this.http.post(this.SearchApi + `/Index`, body, options).map((resp: Response) => {
            return resp.json();
        });
    }
}

export enum Status {
    Start = 1,
    Search = 2
}