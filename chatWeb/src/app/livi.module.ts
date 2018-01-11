import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from './app-routing.module';
import { MenuComponent } from './components/menu/menu.component';
import { ChatComponent } from './components/chat/chat.component';
import { FormsModule } from '@angular/forms';
import { MessageComponent } from './components/message/message.component';

@NgModule({
  imports: [
    CommonModule,
    AppRoutingModule,
    FormsModule,

  ],
  exports: [
    MenuComponent,
    MessageComponent,
    ChatComponent
  ],
  declarations: [MenuComponent, ChatComponent, MessageComponent]
})
export class LiviModule { }
