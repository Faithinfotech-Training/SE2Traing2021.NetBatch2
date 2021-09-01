import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { CRMService } from '../shared/crm.service';
import { Router } from '@angular/router';
import { Constants } from '../Helper/constants';
import { ToastrService } from 'ngx-toastr';
import { InsightService } from '../manager/manager-insight/insight.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  public loginForm=this.formBuilder.group({
    email:['',[Validators.email,Validators.required]],
    password:['',Validators.required]
  })

  constructor(private formBuilder:FormBuilder,private crmservice:CRMService,private router:Router,private toastr: ToastrService,private insight:InsightService) { }

  ngOnInit(): void {
   
  }

  onSubmit()
  {
    
    let email=this.loginForm.controls["email"].value;
    let password=this.loginForm.controls["password"].value;
    console.log("On Submit");
    this.crmservice.login(email,password).subscribe((data:any)=>{
      if(data.responseCode==1)
      {
        
        localStorage.setItem(Constants.USER_KEY,JSON.stringify(data.dateSet));
        this.toastr.success('Login', 'Is successful.');
        this.router.navigate(["/manager"]);
        
      }
      else
      {
        alert(data.responseMessage);
      }
      console.log("Response=",data);      
    },error=>{
      console.log("error",error);
      this.toastr.success('Login', 'Is successful.');
    })
  }

}
