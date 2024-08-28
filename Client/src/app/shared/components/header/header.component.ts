import { Router } from '@angular/router';
import { AuthService } from './../../../auth/services/auth.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})
export class HeaderComponent {
  username: string | null = "";
  isLoggedIn: boolean = false;
   
  constructor(
    private authService: AuthService,
    private router: Router) {}

  ngOnInit() {
    this.authService.loginStatusChange().subscribe(loggedIn => {
      this.isLoggedIn = loggedIn;
    });
    if (this.isLoggedIn) {
      this.username = this.authService.getUsername();
    }
  }
    
  logout() {
    this.authService.logout();
  }

  deleteUsers() {
    this.authService.deteleUsers().subscribe(
      response => {
        console.log(response);
        this.router.navigate(['/auth/register']);
      },
      error => {
        console.error('Error deleting users:', error);
      }
    );
  }
}
