import { Component, HostListener } from '@angular/core';
import { WebMapService } from '@mobilize/angularclient';
import { UpdateCurrentKeyService, UpdateScreenResolution } from '@mobilize/powercomponents';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';

  constructor(private webmapService: WebMapService,
    private updateCurrentKeyService: UpdateCurrentKeyService,
    private updateScreenService: UpdateScreenResolution) {
    webmapService.init();
    this.updateCurrentKeyService.registerEvent();
    this.updateScreenService.registerEvent();
  }

  @HostListener('document:keydown', ['$event'])
  onKeyDown(ev: KeyboardEvent) {
    this.updateCurrentKeyService.setCurrentKey(`${ev.which}`);
  }

  @HostListener('document:keyup', ['$event'])
  onKeyUp(ev: KeyboardEvent) {
    this.updateCurrentKeyService.clear();
  }
}
