import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { CRMService } from '../shared/crm.service';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-aeditcourseenquiry',
  templateUrl: './aeditcourseenquiry.component.html',
  styleUrls: ['./aeditcourseenquiry.component.css']
})
export class AeditcourseenquiryComponent implements OnInit {
 
  adminenquiry:any;
  courses:any;
  url="http://localhost:25083/api/CourseEnquiry/UpdateCourseEnquiry";
  // enquiryForm:any;

   enquiryForm = new FormGroup({
    name: new FormControl(''),
    email: new FormControl(''),
    phone:new FormControl(''),
    qualification:new FormControl(''),
    age:new FormControl(''),
    testScore:new FormControl(''),
    enquityStatus:new FormControl(''),
    enquiryDate:new FormControl(''),
    courseId:new FormControl('')
    // role:['',Validators.required],
  });

  

  constructor(private crmservice:CRMService,private router:ActivatedRoute,private httpclient:HttpClient) { }

  
  ngOnInit(): void {
    this.crmservice.getAdminEnquiry().subscribe((data)=>{
      this.adminenquiry=data;
      console.log("getAdminEnquiry=",this.adminenquiry)
    });
    
     this.crmservice.getCurrentData(this.router.snapshot.params.courseId).subscribe((data)=>
     {
       console.log("KB",this.router.snapshot.params.courseId)
      this.enquiryForm = new FormGroup({  
      name: new FormControl(''),
      email: new FormControl(''),
      phone:new FormControl(''),
      qualification:new FormControl(''),
      age:new FormControl(''),
      testScore:new FormControl(''),
      enquityStatus:new FormControl(''),
      enquiryDate:new FormControl(''),
      courseId:new FormControl(''),
        
         // role:['',Validators.required],
       });

       
     });
    
  }

  onSubmit()
  {
    console.log("EnquiryForm");
    console.log("form data",this.enquiryForm.value)
    
     this.httpclient.put(this.url,this.enquiryForm.value).subscribe((data)=>{
       console.log("asdasdfd",data)  
  });
  
  
 
}
}

