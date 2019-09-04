import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LoginComponent } from '../login/login.component';
import { AdminComponent  } from '../admin/admin.component';
import { RouterModule, Routes } from '@angular/router';



const routes: Routes = [
  { path: '', component: LoginComponent },
  { path: 'admin', component: AdminComponent },
];



@NgModule({
  declarations: [LoginComponent, AdminComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class CoreModuleModule { }
