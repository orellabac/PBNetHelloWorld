
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as Sample from './components/sample';

@NgModule({
  imports: [
    CommonModule,
    PowerComponentsModule,
    WebMapModule,
  ],
  exports: [
  Sample.DSampleListComponent,
  Sample.WSampleComponent,
    ],
  declarations: [
  Sample.DSampleListComponent,
  Sample.WSampleComponent,
    ],
  entryComponents: [
  Sample.DSampleListComponent,
  Sample.WSampleComponent,
    ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class SampleModule { }

