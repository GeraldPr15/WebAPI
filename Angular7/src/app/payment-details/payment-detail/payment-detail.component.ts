import { Component, OnInit } from '@angular/core';
import { PaymentDetailService } from 'src/app/shared/payment-detail.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-payment-detail',
  templateUrl: './payment-detail.component.html',
  styles: []
})
export class PaymentDetailComponent implements OnInit {

  constructor(private service: PaymentDetailService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Pago_ID: 0,
      Nombre_Tarjeta: '',
      Numero_Tajerta: '',
      Dia_Expiracion: '',
      CVV: ''
    }
  }

  onSubmit(form:NgForm){
    this.service.PostSistemaDePago(form.value).subscribe(
      res => {this.resetForm(form)},
      err => {console.log(err);}
    )
  }
}
