import { Component } from '@angular/core';

@Component({
  selector: 'kd-app',
  template: `
    <h1>Welcome in kd-app!</h1>
    <app-gallery-menu></app-gallery-menu>
  `,
  styles: []
})
export class AppComponent {
  title = 'app';
}
