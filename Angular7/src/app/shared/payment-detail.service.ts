import { Injectable } from '@angular/core';
import { PaymentDetail } from './payment-detail.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {
  formData: PaymentDetail;
  readonly rootURL = 'http://localhost:58348/api';

  constructor(private http: HttpClient) { }

  PostSistemaDePago(formData: PaymentDetail) {
    return this.http.post(this.rootURL + '/SistemaDePago', formData);
  }
}
