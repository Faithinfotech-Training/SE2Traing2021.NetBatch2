import { Injectable } from '@angular/core';
import { CanActivate, Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Constants } from '../Helper/constants';
import { User } from '../Models/user';

@Injectable({
  providedIn: 'root'
})
export class AuthService implements CanActivate {
  constructor(private router:Router) { }
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean  {
    const user=JSON.parse(localStorage.getItem(Constants.USER_KEY)||'{}') as User;
    if(user && user.email)
    {
      return true;
    }else{
      this.router.navigate(["login"]);
      return false;
    }
  }

  
}
