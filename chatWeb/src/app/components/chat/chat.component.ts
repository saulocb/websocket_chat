import { Component, OnInit } from '@angular/core';
import { ChatService } from '../../provider/chat.service';
import { Message } from '../../Models/message';


@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent{
 chatText: string = "";
 listMsg: Array<Message> =  new Array<Message>();
  constructor(public chat_service: ChatService) { }

  chatSend(){
      try{
          var msClient =  new Message();
          msClient.texto =  this.chatText;
          msClient.date =  new Date();
          msClient.type = 0;
          this.listMsg.push(msClient);
        this.chat_service.Open(this.chatText).subscribe(res =>{
          var serve = new Message();
          serve.date = res.split(" : ")[0];
          serve.texto = res.split(" : ")[1];
          serve.type = 1;
          this.listMsg.push(serve);
          this.chat_service.Close();
          console.log(res);
        },err =>{
          console.log(err);
        })
      }catch(errr){
        console.log(errr);
      }
  }

}
