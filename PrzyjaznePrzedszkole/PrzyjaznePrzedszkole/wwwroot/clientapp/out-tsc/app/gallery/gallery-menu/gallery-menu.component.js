"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var GalleryMenuComponent = /** @class */ (function () {
    function GalleryMenuComponent() {
    }
    GalleryMenuComponent.prototype.ngOnInit = function () {
    };
    GalleryMenuComponent = __decorate([
        core_1.Component({
            selector: 'app-gallery-menu',
            template: "\n    <app-gallery-item></app-gallery-item>\n    <app-gallery-item></app-gallery-item>\n    <app-gallery-item></app-gallery-item>\n    <app-create-gallery></app-create-gallery>\n  ",
            styles: []
        }),
        __metadata("design:paramtypes", [])
    ], GalleryMenuComponent);
    return GalleryMenuComponent;
}());
exports.GalleryMenuComponent = GalleryMenuComponent;
//# sourceMappingURL=gallery-menu.component.js.map