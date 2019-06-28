import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GalleryMenuComponent } from './gallery-menu/gallery-menu.component';
import { CreateGalleryComponent } from './create-gallery/create-gallery.component';
import { GalleryItemComponent } from './gallery-item/gallery-item.component';

@NgModule({
  imports: [
    CommonModule
  ],
    declarations: [GalleryMenuComponent, CreateGalleryComponent, GalleryItemComponent],
    exports: [GalleryMenuComponent]
})
export class GalleryModule { }
