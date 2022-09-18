import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public count = 0;
  public counterBtnText = "Click me";

  public onCounterClicked() {
    this.count++;

    if (this.count == 1) {
      this.counterBtnText = `Clicked ${this.count} time`;
    } else {
      this.counterBtnText = `Clicked ${this.count} times`;
    }
  }
}
