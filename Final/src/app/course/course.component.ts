import { Component, OnInit } from '@angular/core';
import { CRMService } from '../shared/crm.service';

@Component({
  selector: 'app-course',
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css']
})
export class CourseComponent implements OnInit {
  courses:any;
  adminenquiry:any;

  constructor(private crmservice:CRMService) { }

  ngOnInit(): void {
    this.crmservice.getCourses().subscribe((data)=>{
      this.courses=data;
      console.log("getCourses=",this.courses)
    });
    this.crmservice.getAdminEnquiry().subscribe((data)=>{
      this.adminenquiry=data;
      console.log("getAdminEnquiry=",this.adminenquiry)
    });
  }

}
