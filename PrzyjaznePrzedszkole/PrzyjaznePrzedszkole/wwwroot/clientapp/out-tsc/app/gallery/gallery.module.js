"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var common_1 = require("@angular/common");
var gallery_menu_component_1 = require("./gallery-menu/gallery-menu.component");
var create_gallery_component_1 = require("./create-gallery/create-gallery.component");
var gallery_item_component_1 = require("./gallery-item/gallery-item.component");
var GalleryModule = /** @class */ (function () {
    function GalleryModule() {
    }
    GalleryModule = __decorate([
        core_1.NgModule({
            imports: [
                common_1.CommonModule
            ],
            declarations: [gallery_menu_component_1.GalleryMenuComponent, create_gallery_component_1.CreateGalleryComponent, gallery_item_component_1.GalleryItemComponent],
            exports: [gallery_menu_component_1.GalleryMenuComponent]
        })
    ], GalleryModule);
    return GalleryModule;
}());
exports.GalleryModule = GalleryModule;
//# sourceMappingURL=gallery.module.js.map