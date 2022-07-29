import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeesComponent } from './employees/employees.component';
import { MatTableModule } from '@angular/material/table';
import { EmployeeRoutingModule } from './employee-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { MatButton, MatButtonModule } from '@angular/material/button';
import { AddEmployeeComponent } from './employees/add-employee/add-employee.component';
import { EmployeeComponent } from './employee.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import InputValidationComponent from '../shared/input-validation/input-validation.component';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [EmployeesComponent, AddEmployeeComponent, EmployeeComponent],
  imports: [
    SharedModule,
    MatButtonModule,
    EmployeeRoutingModule,
    HttpClientModule,
  ],
  exports: [EmployeesComponent],
})
export class EmployeeModule {}
