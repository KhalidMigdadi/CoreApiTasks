import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private productAPI = 'https://localhost:7158/api/Product';
  private AddProductAPI = 'https://localhost:7158/api/Product/add';

  constructor(private http: HttpClient) { }

  ngOnInit() { }

  getAllProduct() {
    return this.http.get(this.productAPI)
  }


  getProById(id: any) {
    return this.http.get(`https://localhost:7158/api/Product/productId?id=${id}`)
  }

  addNewPro(data: any) {
    return this.http.post(this.AddProductAPI, data)
  }


}
