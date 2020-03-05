import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { AppComponent } from './app.component';
import { WebMapModule, WebMapService, WEBMAP_CONFIG  } from '@mobilize/angularclient';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { SampleModule } from './sample.module';
const config = {
  useDynamicServerEvents: true,
  webMapVersion: 'v5',
  usePercentage: false,
  useBundleEvent: true
};

@NgModule({
declarations: [
AppComponent
],
imports: [
BrowserModule,
WebMapModule,
PowerComponentsModule,
SampleModule,
],
providers: [WebMapService, { provide: WEBMAP_CONFIG, useValue: config }
],
bootstrap: [AppComponent],
schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class AppModule { }

