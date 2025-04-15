import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  private apiUrl = 'https://localhost:7158/api/Category';
  private addUrl = 'https://localhost:7158/api/Category/add';
  constructor(private http: HttpClient) { }

  getCategories() {
    return this.http.get(this.apiUrl)
  }

  addCategories(category: any) {
    return this.http.post(this.addUrl, category);
  }

  //addCategories() {
  //  return this.http.post(this.apiUrl);
  //}
}
