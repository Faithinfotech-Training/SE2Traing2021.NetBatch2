import { Component, OnInit, ViewChild } from '@angular/core';
import { CRMService } from '../shared/crm.service';
import { updateStatus } from '../aresourceenquiry/updatestatus';
import { FormControl } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-acourseenquiry',
  templateUrl: './acourseenquiry.component.html',
  styleUrls: ['./acourseenquiry.component.css']
})
export class AcourseenquiryComponent implements OnInit {
  courses: any;
  registrationViewModel: updateStatus= new updateStatus();
  @ViewChild("registrationForm")
  form: FormControl = new FormControl;


  constructor(private crmservice:CRMService,private router:ActivatedRoute,private toastr: ToastrService) { }

  ngOnInit(): void {
    this.crmservice.getCourseEnquiry().subscribe((data)=>{
      this.courses=data;
      console.log("getCourses=",this.courses)
    });
  }
  
  statusUpdate(): void{
    this.crmservice.updateone(this.registrationViewModel.Id,this.registrationViewModel.EnquiryStatus).subscribe(
      (item) => {
        alert(`Updated Successfully`);
        this.toastr.success('Updated Success', 'Status');

      },
      (error) => {
        this.toastr.error('Updated Failed', 'Status');

      }
      
    )
    
  }

  

}
