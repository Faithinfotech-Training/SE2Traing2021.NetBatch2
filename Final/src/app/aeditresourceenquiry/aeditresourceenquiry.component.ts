import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder } from '@angular/forms';
import { CRMService } from '../shared/crm.service';
import { ActivatedRoute, Router } from '@angular/router';
import {HttpClient} from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-aeditresourceenquiry',
  templateUrl: './aeditresourceenquiry.component.html',
  styleUrls: ['./aeditresourceenquiry.component.css']
})
export class AeditresourceenquiryComponent implements OnInit {
  url="http://localhost:25083/api/ResourceEnquiry/UpdateResourceEnquiry";

  resourceenquiryForm = new FormGroup({
    name: new FormControl(''),
    email: new FormControl(''),
    phone:new FormControl(''),
    enquiryDate:new FormControl(''),
    resourceId:new FormControl(''),
    resEnquiryStatus:new FormControl(''),
    // role:['',Validators.required],
    rEnquiryId:new FormControl(''),
  })

  constructor(private crmservice:CRMService,private routerer:Router,private toastr: ToastrService,private formBuilder: FormBuilder,private router:ActivatedRoute,private http:HttpClient) { }

  ngOnInit(): void {
    this.crmservice.getCurrentData1(this.router.snapshot.params.resourceId).subscribe((data)=>
    {
      console.log("KB",this.router.snapshot.params.resourceId)
     this.resourceenquiryForm = new FormGroup({
       name: new FormControl(''),
       email: new FormControl(''),
       phone:new FormControl(''),
       enquiryDate:new FormControl(''),
       resEnquiryStatus:new FormControl(''),
       resourceId:new FormControl(''),
       rEnquiryId:new FormControl('')
      })
    });
  }
  onSubmit()
  {
    console.log("EnquiryForm");
    console.log(this.resourceenquiryForm.value)
    this.http.put(this.url,this.resourceenquiryForm.value).subscribe((data)=>{
      console.warn(data)
    });
    this.toastr.success('successfully !!!','Enquiry Is Updated');
    this.routerer.navigate(["/aresource"]);
  }

}
