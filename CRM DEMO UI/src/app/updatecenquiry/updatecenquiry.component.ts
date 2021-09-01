import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { CRMService } from '../shared/crm.service';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-updatecenquiry',
  templateUrl: './updatecenquiry.component.html',
  styleUrls: ['./updatecenquiry.component.css']
})
export class UpdatecenquiryComponent implements OnInit {
  url="http://localhost:25083/api/CourseEnquiry/UpdateCourseEnquiry";

  enquiryForm = new FormGroup({
    name: new FormControl('hbghj'),
    email: new FormControl('dfdsf'),
    phone:new FormControl('788'),
    qualification:new FormControl('sdf'),
    age:new FormControl('34'),
    testScore:new FormControl('70'),
    enquityStatus:new FormControl(''),
    enquiryDate:new FormControl('2021-08-30'),
    courseId:new FormControl('2'),
    cEnquiryId:new FormControl('')
    // role:['',Validators.required],
  });

  constructor(private crmservice:CRMService,private router:ActivatedRoute,private httpclient:HttpClient) { }

  ngOnInit(): void {
    this.crmservice.getCurrentData2(this.router.snapshot.params.cEnquiryId).subscribe((data)=>
     {
       console.log("KB",this.router.snapshot.params.courseId)
      this.enquiryForm = new FormGroup({  
      name: new FormControl('hjk'),
      email: new FormControl('hjk'),
      phone:new FormControl('786'),
      qualification:new FormControl('ghj'),
      age:new FormControl('45'),
      testScore:new FormControl('70'),
      enquityStatus:new FormControl(''),
      enquiryDate:new FormControl('2021-08-30'),
      courseId:new FormControl('2'),
      cEnquiryId:new FormControl('')
        
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
