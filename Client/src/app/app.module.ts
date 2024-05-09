import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainBodyComponent } from './main-body/main-body.component';
import { NotificationMainpageComponent } from './notification-mainpage/notification-mainpage.component';
import {HttpClientModule} from '@angular/common/http';
import { CoreModule } from './core/core.module';

@NgModule({
  declarations: [
    AppComponent,
    MainBodyComponent,
    NotificationMainpageComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    CoreModule


  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
