import { Component, OnInit } from '@angular/core';
import { CRMService } from '../shared/crm.service';
import { COURSE } from '../course/course';
import { HttpClient } from '@angular/common/http';
import { InsightService } from '../manager/manager-insight/insight.service';

@Component({
  selector: 'app-mcourse',
  templateUrl: './mcourse.component.html',
  styleUrls: ['./mcourse.component.css']
})
export class McourseComponent implements OnInit {
  courses:any;
  adminenquiry:any;

  constructor(private crmservice:CRMService,private insight:InsightService) { }

  ngOnInit(): void {
    this.crmservice.getCourses().subscribe(res=>{
      this.courses=res;
    });
    this.insight.Visited("Login").subscribe(
      (item) => {
        
      },
      (error) => {
        alert("PageVisits Error occured");
      }
      );
  }

  


}