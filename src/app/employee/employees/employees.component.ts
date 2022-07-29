import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { map } from 'rxjs';
import { EmployeeGrid } from 'src/app/models/EmployeeGrid';
import { EmployeeService } from 'src/app/Services/employee.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css'],
})
export class EmployeesComponent implements OnInit {
  dataSource!: any;
  displayedColumns: string[] = ['firstName', 'LastName', 'Status'];
  constructor(private empService: EmployeeService) {}

  ngOnInit(): void {
    this.getEmployee();
  }

  getEmployee() {
    this.empService.getEmployees().subscribe((response) => {
      this.dataSource = new MatTableDataSource<EmployeeGrid>(response);
      console.log(this.dataSource);
    });
  }
}
