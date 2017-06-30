import { NgModule, ErrorHandler } from '@angular/core';
import { APP_BASE_HREF } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { Ng2Bs3ModalModule } from 'ng2-bs3-modal/ng2-bs3-modal';
import { HttpModule } from '@angular/http';
import { routing } from './app.routing';
import { UserComponent } from './components/user.component';
import { HomeComponent } from './components/home.component';
import { UserService } from './Service/user.service';
import { UserFilterPipe } from './Filter/user.pipe';
import { SearchComponent } from './Shared/search.component';
import AppErrorHandler from './Shared/errorhandler';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule, MdNativeDateModule } from '@angular/material';
@NgModule({
    imports: [BrowserModule, ReactiveFormsModule, HttpModule, routing, Ng2Bs3ModalModule, FormsModule, BrowserAnimationsModule, MaterialModule, MdNativeDateModule],
    declarations: [AppComponent, UserComponent, HomeComponent, UserFilterPipe, SearchComponent],
    providers: [{ provide: ErrorHandler, useClass: AppErrorHandler }, { provide: APP_BASE_HREF, useValue: '/' }, UserService],
    bootstrap: [AppComponent]

})
export class AppModule { }
