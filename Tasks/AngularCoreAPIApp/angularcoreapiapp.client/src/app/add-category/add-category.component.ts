import { Component } from '@angular/core';
import { CategoryService } from '../Service/category.service';

@Component({
  selector: 'app-add-category',
  standalone: false,
  templateUrl: './add-category.component.html',
  styleUrl: './add-category.component.css'
})
export class AddCategoryComponent {

  constructor(private _url: CategoryService) { }

  ngOnInit() {

  }

  newCategory: any = {
    name: '',
    description: ''
  };

  addNewCategory() {
    this._url.addCategories(this.newCategory).subscribe(() => {
      
      alert('Category added successfully');
      this.newCategory = { name: '', description: '' }; // Empty the form after added 

    })

  }
}
