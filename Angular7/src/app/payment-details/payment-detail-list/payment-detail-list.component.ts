import { Component, OnInit } from '@angular/core';
import { PaymentDetailService } from 'src/app/shared/payment-detail.service';
import { SistemaDePago } from 'src/app/shared/payment-detail.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-payment-detail-list',
  templateUrl: './payment-detail-list.component.html',
  styles: []
})
export class PaymentDetailListComponent implements OnInit {

  constructor(private service: PaymentDetailService, private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(pd: SistemaDePago) {
    this.service.formData = Object.assign({}, pd);
  }

  onDelete(Pago_ID) {
    if (confirm('Estas seguro que quiere eliminar este registro?')) {
      this.service.DeleteSistemaDePago(Pago_ID)
        .subscribe(res => {
          this.service.refreshList();
          this.toastr.warning('Eliminado satisfactoriamente', 'Registro de detalles de pago');
        },
          err => {
            console.log(err);
          })
    }
  }
}
