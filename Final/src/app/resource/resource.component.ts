import { Component, OnInit } from '@angular/core';
import { CRMService } from '../shared/crm.service';

@Component({
  selector: 'app-resource',
  templateUrl: './resource.component.html',
  styleUrls: ['./resource.component.css']
})
export class ResourceComponent implements OnInit {
  resources:any

  constructor(private crmservice:CRMService) { }

  ngOnInit(): void {
    this.crmservice.getResources().subscribe((data)=>{
      this.resources=data;
      console.log("getResources=",this.resources)
    });
  }

}
