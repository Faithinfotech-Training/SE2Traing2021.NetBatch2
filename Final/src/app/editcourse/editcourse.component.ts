import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { CRMService } from '../shared/crm.service';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-editcourse',
  templateUrl: './editcourse.component.html',
  styleUrls: ['./editcourse.component.css']
})
export class EditcourseComponent implements OnInit {
  url="http://localhost:25083/api/Course/UpdateCourse";

  editcourseForm = new FormGroup({
    courseName: new FormControl(''),
    courseDescription: new FormControl(''),
    courseDuration:new FormControl(''),
    couresStatus:new FormControl(''),
    
    couresId:new FormControl('')
    // role:['',Validators.required],
  });

  constructor(private crmservice:CRMService,private router:ActivatedRoute,private httpclient:HttpClient) { }

  ngOnInit(): void {
    this.crmservice.getCurrentData(this.router.snapshot.params.courseId).subscribe((data)=>
     {
       console.log("Ab",this.router.snapshot.params.courseId)
      this.editcourseForm = new FormGroup({
        couresId:new FormControl(''),  
        courseName: new FormControl('courseName'),
        courseDescription: new FormControl('courseDescription'),
        courseDuration:new FormControl('courseDuration'),
        courseStatus:new FormControl('courseStatus'),    
      
        
         // role:['',Validators.required],
       });
     });
  }

  onSubmit()
  {
    console.log("EnquiryForm");
    console.log("form data",this.editcourseForm.value)
    alert("Do you want to Update");
     this.httpclient.put(this.url,this.editcourseForm.value).subscribe((data)=>{
       console.log("asdasdfd",data)  
       alert("Do you want to Update");
  });
  }
}
