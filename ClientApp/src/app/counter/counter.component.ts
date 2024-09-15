import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;
  public counterString = "My awesome counter - 0";

  public incrementCounter() {
    this.currentCount+=25;
    this.counterString = "My awesome counter - " + this.currentCount.toString();
  }
}
