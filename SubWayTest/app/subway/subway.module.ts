import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { SubWayComponent } from './subway.component';
import { TranslateModule } from 'ng2-translate';
import { RouterModule, Routes } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
    imports: [BrowserModule, FormsModule, TranslateModule.forRoot(), BrowserAnimationsModule],
    declarations: [SubWayComponent],
    bootstrap: [SubWayComponent]
})
export class SubWayModule { }