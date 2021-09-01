import { Component, OnInit } from '@angular/core';
import { CRMService } from '../shared/crm.service';

@Component({
  selector: 'app-allview',
  templateUrl: './allview.component.html',
  styleUrls: ['./allview.component.css']
})
export class AllviewComponent implements OnInit {
  course: any;
  resource:any;
  constructor(private service:CRMService) { }

  ngOnInit(): void {
    this.service.getCourses().subscribe(res=>{
      this.course=res;
      // console.log(res);
    });

    this.service.getResources().subscribe(res=>{
      this.resource=res;
      // console.log(res);
    });
  }

}