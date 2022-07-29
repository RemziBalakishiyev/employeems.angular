import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { ComboModel } from 'src/app/models/comboModel';
import { EmployeeAddModel } from 'src/app/models/employeeModel';
import { ComboService } from 'src/app/Services/combo.service';

import { EmployeeService } from 'src/app/Services/employee.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css'],
})
export class AddEmployeeComponent implements OnInit {
  departments!: ComboModel[];
  jobs!: ComboModel[];
  regions!: ComboModel[];
  employeeForm!: FormGroup;
  addEmployeeModel: EmployeeAddModel = new EmployeeAddModel();
  isValid: boolean = false;
  constructor(
    private fb: FormBuilder,
    private empService: EmployeeService,
    private cmbService: ComboService
  ) {}

  ngOnInit(): void {
    this.fillCombo();
    this.generateForm();
  }

  generateForm() {
    this.employeeForm = this.fb.group({
      firstName: [null, Validators.required],
      lastName: [null, Validators.required],
      department: [1],
      job: [1],
      region: [1],
    });
  }

  fillCombo() {
    this.cmbService.getDepartment().subscribe({
      next: (response) => {
        this.departments = response;
      },
    });

    this.cmbService.getJob().subscribe({
      next: (response) => {
        this.jobs = response;
      },
    });
    this.cmbService.getRegion().subscribe({
      next: (response) => {
        this.regions = response;
      },
    });
  }

  onCreate() {
    this.addEmployeeModel = this.employeeForm.getRawValue() as EmployeeAddModel;

    if (this.employeeForm.invalid) {
      this.isValid = true;
      return;
    }

    this.empService.addEmployee(this.addEmployeeModel).subscribe({
      next: (response) => {
        alert(response);
      },
    });
  }
}
