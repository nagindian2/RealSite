export interface IEmployee {
  id: number; // Required
  employee_name?: string; // optional, max length 200 (can be validated in Angular)
  employee_phone?: string;
  employee_email?: string;
}