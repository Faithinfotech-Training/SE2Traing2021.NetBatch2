import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ManagerService {
// formData: Manage = new Manage;
readonly rootURL="http://localhost:25083/api/";

constructor(private http:HttpClient) { }

getStatusBasedEnquiry(controller:string,status:string)
{
  return this.http.get(`${this.rootURL}${controller}/status/${status}`);
}
}
