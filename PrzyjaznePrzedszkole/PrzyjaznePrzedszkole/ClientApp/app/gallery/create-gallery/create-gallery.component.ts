import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-create-gallery',
  templateUrl: './create-gallery.component.html',
  styles: []
})
export class CreateGalleryComponent implements OnInit {

  urls = new Array<string>();

  detectFiles(event) {
    this.urls = [];
    let files = event.target.files;
    if (files) {
      for (let file of files) {
        let reader = new FileReader();
        reader.onload = (e: any) => {
          this.urls.push(e.target.result);
        }
        reader.readAsDataURL(file);
      }
    }
  }

  constructor() { }

  ngOnInit() {
  }

}
