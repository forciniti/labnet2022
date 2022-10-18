import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShippersComponent } from './shippers/shippers.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {HttpClientModule} from'@angular/common/http';


@NgModule({
  declarations: [
    ShippersComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ]
})
export class ApiModule { }
