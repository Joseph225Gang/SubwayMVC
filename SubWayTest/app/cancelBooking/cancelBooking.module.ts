import { NgModule } from '@angular/core';
import { TranslateModule } from 'ng2-translate';
import { BrowserModule } from '@angular/platform-browser';

import { CancelBookingComponent } from './cancelBooking.component';

@NgModule({
    imports: [BrowserModule, TranslateModule.forRoot()],
    declarations: [CancelBookingComponent],
    bootstrap: [CancelBookingComponent]
})
export class CancelBookingModule { }