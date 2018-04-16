import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { TranslateModule } from 'ng2-translate';
import { SearchSeduleComponent } from './searchSedule.component';

@NgModule({
    imports: [BrowserModule, TranslateModule.forRoot(), FormsModule],
    declarations: [SearchSeduleComponent],
    bootstrap: [SearchSeduleComponent]
})
export class SearchSeduleModule { }