import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { EmployeeGrid } from '../models/EmployeeGrid';
import { EmployeeAddModel } from '../models/employeeModel';

@Injectable({
  providedIn: 'root',
})
export class EmployeeService {
  baseUrl: string = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getEmployees(): Observable<EmployeeGrid[]> {
    return this.http.get<EmployeeGrid[]>(this.baseUrl + '/Employees');
  }

  addEmployee(model: EmployeeAddModel): Observable<any> {
    return this.http.post<any>(this.baseUrl + '/Employees', model);
  }
}
