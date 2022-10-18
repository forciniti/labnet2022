import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ShippersComponent } from './api/shippers/shippers.component';

const routes: Routes = [
 { path:'api',
  component: ShippersComponent
  },
{ path:'',
  component: ShippersComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
