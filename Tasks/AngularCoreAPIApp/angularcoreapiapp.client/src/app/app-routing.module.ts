import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoryComponent } from './category/category.component';
import { AddCategoryComponent } from './add-category/add-category.component';
import { ProductComponent } from './product/product.component';
import { ProductByIdComponent } from './product-by-id/product-by-id.component';
import { AddNewProductComponent } from './add-new-product/add-new-product.component';

const routes: Routes = [
  { path: 'category', component: CategoryComponent },
  { path: 'addCategory', component: AddCategoryComponent },
  { path: 'product', component: ProductComponent },
  { path: 'productById/:id', component: ProductByIdComponent },
  { path: 'addProduct', component: AddNewProductComponent },
  



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
