import { Component } from '@angular/core';
import { ProductService } from '../Service/product.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-product-by-id',
  standalone: false,
  templateUrl: './product-by-id.component.html',
  styleUrl: './product-by-id.component.css'
})
export class ProductByIdComponent {

  constructor(private _url: ProductService, private _activate: ActivatedRoute) { }

  ngOnInit() {
    this.getProByIdComp();
  }

  productById: any;

  getProByIdComp() {
    let idd = this._activate.snapshot.paramMap.get('id');
    this._url.getProById(idd).subscribe((data) => {
      this.productById = data;
    })
  }

}
