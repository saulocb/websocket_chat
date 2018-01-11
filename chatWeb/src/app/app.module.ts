import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { LiviModule } from './livi.module';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import { ChatService } from './provider/chat.service';
import { QueueingSubject } from 'queueing-subject'


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    LiviModule
  ],
  providers: [
    ChatService,
    QueueingSubject
    
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
