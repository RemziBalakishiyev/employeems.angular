import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import InputValidationComponent from './input-validation/input-validation.component';
import { BrowserModule } from '@angular/platform-browser';
import { MatTableModule } from '@angular/material/table';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [InputValidationComponent],
  imports: [
    ReactiveFormsModule,
    FormsModule,
    CommonModule,
    MatTableModule,
    HttpClientModule,
    ReactiveFormsModule,
  ],
  exports: [
    InputValidationComponent,
    ReactiveFormsModule,
    CommonModule,
    MatTableModule,
    HttpClientModule,
    ReactiveFormsModule,
  ],
})
export class SharedModule {}
