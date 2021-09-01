import { Component, OnInit } from '@angular/core';
import { CRMService } from '../shared/crm.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-acourses',
  templateUrl: './acourses.component.html',
  styleUrls: ['./acourses.component.css']
})
export class ACoursesComponent implements OnInit {
  url="http://localhost:25083/api/Course/";

  courses:any;

  constructor(private crmservice:CRMService, httpclient:HttpClient) { }

  ngOnInit(): void {
    this.crmservice.getCourses().subscribe((data)=>{
      this.courses=data;
      console.log("getCourses=",this.courses)
    });
  }


  delete(id:number){
    this.crmservice.deletecourse(id).subscribe();
  }

}
