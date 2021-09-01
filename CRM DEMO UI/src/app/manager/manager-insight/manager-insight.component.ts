import { Component, OnInit } from '@angular/core';
import { InsightService } from './insight.service';
import Chart from 'chart.js/auto';
@Component({
  selector: 'app-manager-insight',
  templateUrl: './manager-insight.component.html',
  styleUrls: ['./manager-insight.component.css']
})
export class ManagerInsightComponent implements OnInit {

  insights:any;
   views:any=[];
   chart:any;
   pieChart:any;
  constructor(private service: InsightService,/* public insights: Map<String,number> */) { 
  }

  ngOnInit(): void {
    this.insights= new Map();
    this.service.getPageVisits().subscribe((res) =>{
        res
        .forEach((element: { page: any; views: string | number; }) => {
         if(!this.insights.has(element.page)){
           this.insights.set(element.page, element.views);
         }else{
         var views = this.insights.get(element.page);
         views += element.views;
         this.insights.set(element.page, views);
         }
        });
        
        this.chart= new Chart("canva",{

          type: 'bar',
          data: {
            labels:['Courses','Login','Register','Resources','CourseEnquiry','ResourceEnquiry'],
            
            datasets:[{
              
              data:[{page:'Courses', views:this.insights.get('Courses')},
              {page:'Login', views:this.insights.get('Login')},
              {page:'Register', views:this.insights.get('Register')},
              {page:'Resources', views:this.insights.get('Resources')},
              {page:'ResourceEnquiry', views:this.insights.get('ResourceEnquiry')},
              {page:'CourseEnquiry', views:this.insights.get('CourseEnquiry')}],
              backgroundColor: [
                'rgba(0,255, 0, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(201, 203, 207, 0.2)',
                'rgba(0 ,0 ,255 ,0.2)'
              ],
              borderColor: [
                'rgb(54, 162, 235)',
                'rgb(153, 102, 255)',
                'rgb(201, 203, 207)'
              ],
              borderWidth:1,
              barThickness:30
            }],
           
            
          },
          options:{
            responsive: true,
            parsing:{
              xAxisKey:'page',
              yAxisKey:'views'
            },
            scales:{
              y:{
                beginAtZero:true
              }
            },
            aspectRatio:3
            
          }
        })

        this.pieChart= new Chart('PieChart',{
          type:'pie',
          data:{
            labels:['Courses','Login','Register','Resources','CourseEnquiry','ResourceEnquiry'],

            datasets:[{

              data: [this.insights.get('Courses'), this.insights.get('Login'), this.insights.get('Register'),this.insights.get('Resources'),
              this.insights.get('CourseEnquiry'),this.insights.get('ResourceEnquiry')],

              backgroundColor: [
                'rgb(255, 99, 132)',
                'rgb(54, 162, 235)',
                'rgb(255, 205, 86)',
                'rgb(255,0,0)',
                'rgb(0,255,255)',
                'rgb(255,0,255)'
              ],
            }],
            
          },
          options:{
            responsive:true,
            aspectRatio:3,
            radius:'70%'
          }
            
          
          
        })
    })

  }
}