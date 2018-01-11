import { Component, OnInit, Input } from '@angular/core';
import { Message } from '../../Models/message';


@Component({
  selector: 'app-message',
  templateUrl: './message.component.html',
  styleUrls: ['./message.component.css']
})
export class MessageComponent  {
  @Input() msg: Message;
}
