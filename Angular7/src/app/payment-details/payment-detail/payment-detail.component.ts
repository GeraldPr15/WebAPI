import { Component, OnInit } from '@angular/core';
import { PaymentDetailService } from 'src/app/shared/payment-detail.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-payment-detail',
  templateUrl: './payment-detail.component.html',
  styles: []
})
export class PaymentDetailComponent implements OnInit {

  constructor(private service: PaymentDetailService, 
    private toastr: ToastrService) { }

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

  onSubmit(form: NgForm) {
    if (this.service.formData.Pago_ID == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.PostSistemaDePago().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.success('Enviado satisfactoriamente', 'Registro de detalles de pago');
        this.service.refreshList();
      },
      err => { console.log(err); }
    )
  }

  updateRecord(form: NgForm) {
    this.service.PutSistemaDePago().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.info('Enviado satisfactoriamente', 'Registro de detalles de pago');
        this.service.refreshList();
      },
      err => { console.log(err); }
    )
  }
}
