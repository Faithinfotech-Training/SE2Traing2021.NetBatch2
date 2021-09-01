import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { CRMService } from '../shared/crm.service';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-addcourse',
  templateUrl: './addcourse.component.html',
  styleUrls: ['./addcourse.component.css']
})
export class AddcourseComponent implements OnInit {
  url="http://localhost:25083/api/Course/AddCourse";

  editcourseForm = new FormGroup({
    couresId:new FormControl('0'),
    courseName: new FormControl(''),
    courseDescription: new FormControl(''),
    courseDuration:new FormControl(''),
    courseStatus:new FormControl(''),
    
  
    // role:['',Validators.required],
  });

  constructor(private crmservice:CRMService,private arouter:Router,private router:ActivatedRoute,private httpclient:HttpClient,private toastr: ToastrService) { }

  ngOnInit(): void {
    this.crmservice.getCurrentData(this.router.snapshot.params.courseId).subscribe((data)=>
     {
       console.log("Ab",this.router.snapshot.params.courseId)
      this.editcourseForm = new FormGroup({
        couresId:new FormControl('0'),  
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
    alert("Do you want to Add");
     this.httpclient.post(this.url,this.editcourseForm.value).subscribe((data)=>{
       console.log("asdasdfd",data)  
       
       this.arouter.navigate(["/acourse"]);
  });
  this.toastr.success('New Course created!', 'Course Reg successful.');
  }
}
