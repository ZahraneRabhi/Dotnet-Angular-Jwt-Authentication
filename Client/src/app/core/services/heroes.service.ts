import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment.development';
import { Hero } from '../../shared/models/hero.model';

@Injectable({
  providedIn: 'root'
})
export class HeroesService {
  private apiUrl: string = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getHeroes(): Observable<Hero[]> {
    return this.http.get<Hero[]>(`${this.apiUrl}/secure/data`);
  }
}
