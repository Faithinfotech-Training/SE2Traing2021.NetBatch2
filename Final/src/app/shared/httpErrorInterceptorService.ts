import { HttpInterceptor, HttpRequest, HttpHandler } from '@angular/common/http';

export class HttpErrorInterceptor implements HttpInterceptor
{
    intercept(request:HttpRequest<any>,next:HttpHandler){
        console.log("HttpRequestStarted");
        return next.handle(request);
    }
}