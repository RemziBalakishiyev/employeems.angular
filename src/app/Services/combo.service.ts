import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ComboModel } from '../models/comboModel';

@Injectable({
  providedIn: 'root',
})
export class ComboService {
  baseUrl: string = environment.apiUrl;
  constructor(private http: HttpClient) {}

  getDepartment(): Observable<ComboModel[]> {
    return this.http.get<ComboModel[]>(
      this.baseUrl + '/Employees/GetDepartment'
    );
  }

  getRegion(): Observable<ComboModel[]> {
    return this.http.get<ComboModel[]>(this.baseUrl + '/Employees/GetRegion');
  }
  getJob(): Observable<ComboModel[]> {
    return this.http.get<ComboModel[]>(this.baseUrl + '/Employees/GetJob');
  }
}
