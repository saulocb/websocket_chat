import { Injectable } from '@angular/core';
import {Config} from '../config/config';
import { Observer } from 'rxjs/Observer';
import {Observable, Subscriber} from 'rxjs/Rx';

@Injectable()
export class ChatService {
  private ws: WebSocket;
  public msg: string;

  createObservableSocket(url: string, openSubscriber: Subscriber<any>): Observable<any> {
    this.ws = new WebSocket(url);
    return new Observable(observer => {
      this.ws.onmessage = event => {
        observer.next(event.data);
      };
      this.ws.onerror = event => {
        observer.error(event);
      };
      this.ws.onclose = event => {
        observer.complete();
      };
      this.ws.onopen = event => {
        openSubscriber.next();
        openSubscriber.complete();
         this.Send();
      };
      return () => this.ws.close();
    });
  }

  Open(message: any) {
    this.msg = message;
   return this.createObservableSocket(Config.socketURI, new Subscriber());
  }

  Send(){
    this.ws.send(JSON.stringify(this.msg));
  }

  Close(){
    this.ws.close();
  }

}
