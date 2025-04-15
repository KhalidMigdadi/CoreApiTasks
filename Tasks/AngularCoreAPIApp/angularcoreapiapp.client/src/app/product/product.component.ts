import { Component } from '@angular/core';
import { ProductService } from '../Service/product.service';

@Component({
  selector: 'app-product',
  standalone: false,
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {

  constructor(private _url: ProductService) { }

  ngOnInit() {
    this.getAllProComp();
  }

  AllProducts: any;

  getAllProComp() {
    this._url.getAllProduct().subscribe((data) => {
      this.AllProducts = data;
    })
  }
}
