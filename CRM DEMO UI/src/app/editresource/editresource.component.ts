import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder } from '@angular/forms';
import { CRMService } from '../shared/crm.service';
import { ActivatedRoute, Router } from '@angular/router';
import {HttpClient} from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-editresource',
  templateUrl: './editresource.component.html',
  styleUrls: ['./editresource.component.css']
})

export class EditresourceComponent implements OnInit {
  url="http://localhost:25083/api/Resource/UpdateResource";

  editresourceForm = new FormGroup({
    resourceId: new FormControl(''),
    resourceName: new FormControl(''),
    resourceStatus:new FormControl(''),
    resRecordDate:new FormControl(''),
    resourceType:new FormControl('')
    // role:['',Validators.required],
  })

  constructor(private crmservice:CRMService,private routerer:Router,private toastr: ToastrService,private formBuilder: FormBuilder,private router:ActivatedRoute,private http:HttpClient) { }

  ngOnInit(): void {
    this.crmservice.getCurrentData1(this.router.snapshot.params.resourceId).subscribe((data)=>
     {
       console.log("KB",this.router.snapshot.params.resourceId)
      this.editresourceForm = new FormGroup({  
          resourceName: new FormControl(''),
          resourceStatus:new FormControl(''),
          resRecordDate:new FormControl(''),
          resourceType:new FormControl(''),
          resourceId:new FormControl('')
         
       })
     });
  }


  onSubmit()
  {
    console.log("EnquiryForm");
    console.log(this.editresourceForm.value)
    this.http.put(this.url,this.editresourceForm.value).subscribe((data)=>{
      console.warn(data);
      this.toastr.success('successfully !!!','Resource Is Updated');
    });
    this.toastr.success('successfully !!!','Resource Is Updated');
    this.routerer.navigate(["/aresource"]);

  }

}










