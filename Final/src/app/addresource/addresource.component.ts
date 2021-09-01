import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { CRMService } from '../shared/crm.service';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-addresource',
  templateUrl: './addresource.component.html',
  styleUrls: ['./addresource.component.css']
})
export class AddresourceComponent implements OnInit {
  url="http://localhost:25083/api/Resource/AddResource";

  editresourceForm = new FormGroup({
    resourceId:new FormControl('0'),
    resourceName: new FormControl(''),
    resourceStatus:new FormControl(''),
    resRecordDate:new FormControl(''),
    resourceType:new FormControl('')
    // role:['',Validators.required],
  })

  constructor(private crmservice:CRMService,private formBuilder: FormBuilder,private toastr: ToastrService,private router:ActivatedRoute,private http:HttpClient) { }

  ngOnInit(): void {
    this.crmservice.getCurrentData1(this.router.snapshot.params.resourceId).subscribe((data)=>
     {
       console.log("KB",this.router.snapshot.params.resourceId)
      this.editresourceForm = new FormGroup({
        
    resourceName: new FormControl(''),
    resourceStatus:new FormControl(''),
    resRecordDate:new FormControl(''),
    resourceType:new FormControl(''),
        resourceId:new FormControl('0')
         
       })
     });
  }

  onSubmit()
  {
    console.log("EnquiryForm");
    console.log(this.editresourceForm.value)
    this.http.post(this.url,this.editresourceForm.value).subscribe((data)=>{
      console.warn(data)
    })
    this.toastr.success('New Resource created!', 'Resource Reg successful.');

  }

}
