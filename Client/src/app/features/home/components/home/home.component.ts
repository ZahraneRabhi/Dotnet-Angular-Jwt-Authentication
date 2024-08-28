import { HeroesService } from './../../../../core/services/heroes.service';
import { Router } from '@angular/router';
import { AuthService } from './../../../../auth/services/auth.service';
import { Component } from '@angular/core';
import { Hero } from '../../../../shared/models/hero.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  userName: string | null = "";
  heroesList: Hero[] = [];
  
  constructor(
    private heroesService: HeroesService,
    private router: Router) {}
    
    ngOnInit() {
      this.heroesService.getHeroes().subscribe(heroes => {
        this.heroesList = heroes;
        console.log(this.heroesList);
      })
    }
}
