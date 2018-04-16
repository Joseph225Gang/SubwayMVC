import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { TranslateModule } from 'ng2-translate';
import { SearchBookingComponent } from './searchBooking.component';

@NgModule({
    imports: [BrowserModule, TranslateModule.forRoot()],
    declarations: [SearchBookingComponent],
    bootstrap: [SearchBookingComponent]
})
export class SearchBookingModule { }