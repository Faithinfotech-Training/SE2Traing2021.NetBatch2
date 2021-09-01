import { Component, OnInit } from '@angular/core';
import { CRMService } from '../shared/crm.service';

@Component({
  selector: 'app-aresources',
  templateUrl: './aresources.component.html',
  styleUrls: ['./aresources.component.css']
})
export class AresourcesComponent implements OnInit {
  resources:any

  constructor(private crmservice:CRMService) { }

  ngOnInit(): void {
    this.crmservice.getResources().subscribe((data)=>{
      this.resources=data;
      console.log("getResources=",this.resources)
    });
  }

}
