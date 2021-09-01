import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder } from '@angular/forms';
import { CRMService } from '../shared/crm.service';
import { Courseenquiry } from '../shared/courseenquiry';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  public registerForm = this.formBuilder.group({
    fullName: ['', Validators.required],
    email: ['', [Validators.email, Validators.required]],
    password: ['', Validators.required],
    // role:['',Validators.required],
  })

  constructor(private formBuilder: FormBuilder, private crmservice: CRMService,private toastr: ToastrService) { }
  

  ngOnInit(): void {
  }

  onSubmit() {
    let fullName = this.registerForm.controls["fullName"].value;
    let email = this.registerForm.controls["email"].value;
    let password = this.registerForm.controls["password"].value;
    // let role =this.registerForm.controls["role"].value;
    console.log("On Submit");
    this.crmservice.register(fullName, email, password).subscribe((data) => {
      this.registerForm.controls["fullName"].setValue("");
      this.registerForm.controls["email"].setValue("");
      this.registerForm.controls["password"].setValue("");
      // this.registerForm.controls["role"].setValue("");
      if (data.responseCode != 1) {
        alert(data.dateSet);
        this.toastr.success('New user created!', 'Registration successful.');
      }
      else {
        alert(data.responseMessage);
        this.toastr.success('New user created!', 'Registration successful.');
      }
      console.log("Response=", data);
      this.toastr.success('New user created!', 'Registration successful.');

    }, error => {
      console.log("error", error);
    })
  }

}
