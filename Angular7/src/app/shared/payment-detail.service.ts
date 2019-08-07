import { Injectable } from '@angular/core';
import { SistemaDePago } from './payment-detail.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {
  formData: SistemaDePago;
  readonly rootURL = 'http://localhost:58348/api';
  list : SistemaDePago[];

  constructor(private http: HttpClient) { }

  PostSistemaDePago() {
    return this.http.post(this.rootURL + '/SistemaDePago', this.formData);
  }

  PutSistemaDePago() {
    return this.http.put(this.rootURL + '/SistemaDePago/' + this.formData.Pago_ID, this.formData);
  }

  DeleteSistemaDePago(id) {
    return this.http.delete(this.rootURL + '/SistemaDePago/' + id);
  }

  refreshList(){
    this.http.get(this.rootURL + '/SistemaDePago')
      .toPromise()
      .then(res => this.list = res as SistemaDePago[]);
  }
}
