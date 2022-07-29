export interface EmployeeGrid {
  employeeId: number;
  firstName: string;
  lastName: string;
  status: string;
}

export class EmployeeAddModel {
  firstName: string = '';
  lastName: string = '';
  departmentId: number = 0;
  regionId: number = 0;
  jobId: number = 0;
}
