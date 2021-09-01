import { Component, OnInit } from '@angular/core';
import { CRMService } from '../shared/crm.service';
import { User } from '../Models/user';

@Component({
  selector: 'app-manager',
  templateUrl: './manager.component.html',
  styleUrls: ['./manager.component.css']
})
export class ManagerComponent implements OnInit {
  public userList:User[]=[];

  constructor(private crmservice:CRMService) { }

  ngOnInit(): void {
    this.crmservice.getAllUser().subscribe((data:User[])=>{
      this.userList=data;
      console.log(this.userList);

    })
  }

  getAllUser()
  {
    this.crmservice.getAllUser().subscribe((data)=>{
      this.userList=data;
      console.log(this.userList);

    })
  }

}
