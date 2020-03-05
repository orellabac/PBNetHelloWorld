import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-w-sample",
   templateUrl : "w_sample.component.html",
   styleUrls : ["w_sample.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["samplew_sample"])
export class WSampleComponent extends BaseControlComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter) {
      super(changeDetector,render2,elem,lengthConverter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}