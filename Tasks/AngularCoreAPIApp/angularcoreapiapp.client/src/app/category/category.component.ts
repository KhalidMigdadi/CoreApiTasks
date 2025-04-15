import { Component } from '@angular/core';
import { CategoryService } from '../Service/category.service';

@Component({
  selector: 'app-category',
  standalone: false,
  templateUrl: './category.component.html',
  styleUrl: './category.component.css'
})
export class CategoryComponent {
  constructor(private _url: CategoryService) { }

  ngOnInit() {
    this.getAllCategory();
  }

  categories: any;


  getAllCategory() {
    this._url.getCategories().subscribe((data) => {
      this.categories = data;
    })
  }




}
