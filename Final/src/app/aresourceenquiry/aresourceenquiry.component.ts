import { Component, OnInit, ViewChild } from '@angular/core';
import { CRMService } from '../shared/crm.service';
import { ActivatedRoute } from '@angular/router';
import { updateStatus } from './updatestatus';
import { FormControl } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-aresourceenquiry',
  templateUrl: './aresourceenquiry.component.html',
  styleUrls: ['./aresourceenquiry.component.css']
})
export class AresourceenquiryComponent implements OnInit {
  courses: any;
  registrationViewModel: updateStatus= new updateStatus();
  @ViewChild("registrationForm")
  form: FormControl = new FormControl;
  constructor(private crmservice:CRMService,private router:ActivatedRoute,private toastr: ToastrService) { }

  ngOnInit(): void {
    this.crmservice.getResourceEnquiry().subscribe((data)=>{
      this.courses=data;
      console.log("getCourses=",this.courses)
    });
  }

  statusUpdate(): void{
    this.crmservice.update(this.registrationViewModel.Id,this.registrationViewModel.EnquiryStatus).subscribe(
      (item) => {
        alert(`Updated Successfully`);
        this.toastr.success('Updated Success', 'Status');

      },
      (error) => {
        this.toastr.error('Updated Failed', 'Status');

      }
      
    )
    
  }

  delete(id:number){
    this.crmservice.deleteresourceenq(id).subscribe();
  }
}