import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { CourseComponent } from './course/course.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ManagerComponent } from './manager/manager.component';
import { HomeComponent } from './home/home.component';
import { HttpErrorInterceptor } from './shared/httpErrorInterceptorService';
import { AdminComponent } from './admin/admin.component';
import { CourseEnquiryComponent } from './course-enquiry/course-enquiry.component';
import { ResourceComponent } from './resource/resource.component';

import { ResourceEnquiryComponent } from './resource-enquiry/resource-enquiry.component';
import { ACoursesComponent } from './acourses/acourses.component';
import { EditcourseComponent } from './editcourse/editcourse.component';
import { AresourcesComponent } from './aresources/aresources.component';
import { EditresourceComponent } from './editresource/editresource.component';
import { AddcourseComponent } from './addcourse/addcourse.component';
import { AddresourceComponent } from './addresource/addresource.component';
import { AcourseenquiryComponent } from './acourseenquiry/acourseenquiry.component';
import { UpdatecenquiryComponent } from './updatecenquiry/updatecenquiry.component';
import { McourseComponent } from './mcourse/mcourse.component';
import{TableModule} from 'primeng/table';
import { ToastrModule } from 'ngx-toastr';

import { AresourceenquiryComponent } from './aresourceenquiry/aresourceenquiry.component';
import { AeditresourceenquiryComponent } from './aeditresourceenquiry/aeditresourceenquiry.component';
import { ManagerInsightComponent } from './manager/manager-insight/manager-insight.component';
import { InsightService } from './manager/manager-insight/insight.service';
import { AllviewComponent } from './allview/allview.component';
import { AeditcourseenquiryComponent } from './aeditcourseenquiry/aeditcourseenquiry.component';
import { MinsightComponent } from './minsight/minsight.component';


@NgModule({
  declarations: [
    AppComponent,
    CourseComponent,
    LoginComponent,
    RegisterComponent,
    ManagerComponent,
    HomeComponent,
    AdminComponent,
    CourseEnquiryComponent,
    ResourceComponent,
    
    ResourceEnquiryComponent,
         ACoursesComponent,
         EditcourseComponent,
         AresourcesComponent,
         EditresourceComponent,
         AddcourseComponent,
         AddresourceComponent,
         AcourseenquiryComponent,
         UpdatecenquiryComponent,
         McourseComponent,
         AresourceenquiryComponent,
         AeditresourceenquiryComponent,
         ManagerInsightComponent,
         AllviewComponent,
         AeditcourseenquiryComponent,
         MinsightComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    TableModule,
    ToastrModule.forRoot(
      {progressBar:true}
    )
  ],
  providers: [{
    provide:HTTP_INTERCEPTORS,
    useClass:HttpErrorInterceptor,
    multi:true,

  },InsightService],
  bootstrap: [AppComponent],
  
})
export class AppModule { }
