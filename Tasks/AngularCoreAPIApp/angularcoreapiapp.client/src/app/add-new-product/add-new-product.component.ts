import { Component } from '@angular/core';
import { ProductService } from '../Service/product.service';

@Component({
  selector: 'app-add-new-product',
  standalone: false,
  templateUrl: './add-new-product.component.html',
  styleUrl: './add-new-product.component.css'
})
export class AddNewProductComponent {

  constructor(private _url: ProductService) { }

  product = {
    name: '',
    description: ''
  };


  nrOnInit() { }


  addProductComp() {
    this._url.addNewPro(this.product).subscribe(() => {
      alert("Product Added Successfully");
    })
  }

}
