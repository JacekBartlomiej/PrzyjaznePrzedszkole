import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-gallery-menu',
  template: `
    <app-gallery-item></app-gallery-item>
    <app-gallery-item></app-gallery-item>
    <app-gallery-item></app-gallery-item>
    <app-create-gallery></app-create-gallery>
  `,
  styles: []
})
export class GalleryMenuComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
