import { Component, OnInit, ViewChild } from '@angular/core';
import { Enquiry } from './enquiry';
import { FormControl } from '@angular/forms';
import { ManagerService } from '../shared/manager.service';

@Component({
  selector: 'app-minsight',
  templateUrl: './minsight.component.html',
  styleUrls: ['./minsight.component.css']
})
export class MinsightComponent implements OnInit {
  checkResponse:boolean=false;
  enquiries:any;
  registrationViewModel: Enquiry;
  courseEnquiry:any;

  @ViewChild("registrationForm")  form!: FormControl;

  constructor(private service:ManagerService) { 
    this.registrationViewModel = new Enquiry();
  }

  ngOnInit(): void {
  }

  submitRegistration():any{
    this.service.getStatusBasedEnquiry(this.registrationViewModel.controller,this.registrationViewModel.status).subscribe(res=>{
      this.checkResponse=true;
      this.enquiries=res;
    });
    if(this.registrationViewModel.controller.localeCompare("CourseEnquiry")==0){
      this.courseEnquiry=true;
    }
    else
    {
        this.courseEnquiry=false;
    }

  }

}