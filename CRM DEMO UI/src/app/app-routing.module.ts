import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ManagerComponent } from './manager/manager.component';
import { AuthService } from './guards/auth.service';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { CourseComponent } from './course/course.component';
import { CourseEnquiryComponent } from './course-enquiry/course-enquiry.component';
import { ResourceComponent } from './resource/resource.component';
import { ResourceEnquiryComponent } from './resource-enquiry/resource-enquiry.component';
import { ACoursesComponent } from './acourses/acourses.component';
import { EditcourseComponent } from './editcourse/editcourse.component';
import { AresourcesComponent } from './aresources/aresources.component';
import { AddcourseComponent } from './addcourse/addcourse.component';
import { EditresourceComponent} from './editresource/editresource.component'
import { AddresourceComponent } from './addresource/addresource.component';
import { AcourseenquiryComponent } from './acourseenquiry/acourseenquiry.component';
import { UpdatecenquiryComponent } from './updatecenquiry/updatecenquiry.component';
import { McourseComponent } from './mcourse/mcourse.component';
import { AresourceenquiryComponent } from './aresourceenquiry/aresourceenquiry.component';
import { AeditresourceenquiryComponent } from './aeditresourceenquiry/aeditresourceenquiry.component';
import { ManagerInsightComponent } from './manager/manager-insight/manager-insight.component';
import { AllviewComponent } from './allview/allview.component';
import { AeditcourseenquiryComponent } from './aeditcourseenquiry/aeditcourseenquiry.component';
import { MinsightComponent } from './minsight/minsight.component';


const routes: Routes = [
  {path:"login",component:LoginComponent},
  {path:"register",component:RegisterComponent},
  {path:"manager",component:ManagerComponent,canActivate:[AuthService]},
  {path:"home",component:HomeComponent},
  {path:"course",component:CourseComponent,canActivate:[AuthService]},
  {path:"courseenquiry/:courseId",component:CourseEnquiryComponent},
  {path:"courseenquiry/:cEnquiryId",component:CourseEnquiryComponent},
  {path:"resource",component:ResourceComponent,canActivate:[AuthService]},
  {path:"resourceenquiry/:resourceId",component:ResourceEnquiryComponent},
  {path:"acourse",component:ACoursesComponent},
  {path:"acourseenquiry",component:AcourseenquiryComponent},
  {path:"aresourceenquiry",component:AresourceenquiryComponent},
  {path:"aeditresourceenquiry",component:AeditresourceenquiryComponent},
  {path:"aeditresourceenquiry/:rEnquiryId",component:AeditresourceenquiryComponent},
  {path:"aeditcourseenquiry",component:AeditcourseenquiryComponent},
  {path:"aeditcourseenquiry/:courseId",component:AeditcourseenquiryComponent},

  {path:"editcourse",component:EditcourseComponent},
  {path:"editcourse/:courseId",component:EditcourseComponent},
  {path:"aresource",component:AresourcesComponent},
  {path:"addcourse",component:AddcourseComponent},
  {path:"addcourse/:courseId",component:AddcourseComponent},
  {path:"editresource",component:EditresourceComponent},
  {path:"editresource/:resourceId",component:EditresourceComponent},
  {path:"addresource",component:AddresourceComponent},
  {path:"addresource/:resourceId",component:AddresourceComponent},
  {path:"updatecenquiry",component:UpdatecenquiryComponent},
  {path:"updatecenquiry/:cEnquiryId",component:AddresourceComponent},
  {path:"manager/course",component:McourseComponent},
  {path:"manager/insights",component:ManagerInsightComponent},
  {path:"allview",component:AllviewComponent},
  {path:"minsight",component:MinsightComponent}

  
  

  
  
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
