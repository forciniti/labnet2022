import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Shippers } from './Models/Shippers';
import { ShippersService } from './Services/shippers.service';
import * as $ from 'jquery';
import Swal from 'sweetalert2';
@Component({
  selector: 'app-shippers',
  templateUrl: './shippers.component.html',
  styleUrls: ['./shippers.component.scss']
})
export class ShippersComponent implements OnInit {
  toDel = false;
  form = this.fb.group({
    id: ['', Validators.required],
    CompanyName: ['', Validators.required],
    Phone: ['', Validators.required]
  });
  ShippersList: Shippers[] = [];

  constructor(private fb: FormBuilder, private ShippersService: ShippersService) { }

  ngOnInit(): void {
    this.ShippersService.FindShippers().subscribe(resp => { this.ShippersList = resp });
    $("#idInput").prop('disabled', true);
    $("#idCompanyAndPhone").prop('disabled', false);
  }

  ActivateID() {
    $("#idInput").prop('disabled', false);
    $("#idCompanyAndPhone").prop('disabled', false);
    this.toDel = false;
  }

  DesactivateID() {
    $("#idInput").prop('disabled', true);
    $("#idCompanyAndPhone").prop('disabled', false);
    $("#idInputForm").val("");
    this.toDel = false;
  }

  DesactivateAllExceptId() {
    $("#idInput").prop('disabled', false);
    $("#idCompanyAndPhone").prop('disabled', true);
    $("#idInputForm").val("");
    this.toDel = true;
    $("#idCompanyNameForm").val("");
    $("#idPhoneForm").val("");
  }

  Save() {

    var Shipper = new Shippers();
    var name = this.form.get('CompanyName')?.value;
    var phone = this.form.get('Phone')?.value;
    var id = this.form.get('id')?.value;

    //INSERT
    if ($('input:radio[name=options]:checked').val() == "Insert") {
      if (!((phone == "") || (name == "")|| (phone == null) || (name == null))) {
        Shipper.companyName = name;
        Shipper.phone = phone;
          this.ShippersService.InsertShipper(Shipper).subscribe(resp => {
            Swal.fire({
              position: 'center',
              icon: 'success',
              title: 'Saved Successfully!',
              showConfirmButton: false,
              timer: 1500
            })
            this.form.reset();
          }
       )
      } else {
        Swal.fire({
          title: 'EMPTY FIELDS!',
          showClass: {
            popup: 'animate__animated animate__fadeInDown'
          },
          hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
          }
        })
      }
    }

    //UPDATE
    if ($('input:radio[name=options]:checked').val() == "Update") {
      if (!((phone == "") || (name == "") || (id == "") || (id == null)|| (phone == null) || (name == null))) {
          Shipper.companyName = name;
          Shipper.phone = phone;
          this.ShippersService.UpdateShippers(Shipper, id).subscribe(resp => {
            Swal.fire({
              position: 'center',
              icon: 'success',
              title: 'Updated Successfully!',
              showConfirmButton: false,
              timer: 1500
            })
            this.form.reset();
          },
            error => Swal.fire({
              title: 'ERROR : ' + error.status +'! ',
              showClass: {
                popup: 'animate__animated animate__fadeInDown'
              },
              hideClass: {
                popup: 'animate__animated animate__fadeOutUp'
              }
            }))
            this.form.controls['id'].setValue("");

      } else {
        Swal.fire({
          title: 'EMPTY FIELDS!',
          showClass: {
            popup: 'animate__animated animate__fadeInDown'
          },
          hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
          }
        })
      }
    }

    //DELETE
    if ($('input:radio[name=options]:checked').val() == "Delete") {
      if (!((id == "" || id == null))) {

        Swal.fire({
          title: 'Are you sure?',
          text: "You won't be able to revert this!",
          icon: 'warning',
          showCancelButton: true,
          confirmButtonColor: '#3085d6',
          cancelButtonColor: '#d33',
          confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
          if (result.isConfirmed) {
            this.ShippersService.DeleteShippers(id).subscribe(resp => {
              this.form.reset();
            },
              error => Swal.fire({
                title: 'ERROR : ' + error.status +'!',
                showClass: {
                  popup: 'animate__animated animate__fadeInDown'
                },
                hideClass: {
                  popup: 'animate__animated animate__fadeOutUp'
                }
              })
              );

            Swal.fire(
              'Deleted!',
              'Your file has been deleted.',
              'success'
            )
          }

        }
        )
      } else {
        Swal.fire({
          title: 'ID FIELD IS EMPTY!',
          showClass: {
            popup: 'animate__animated animate__fadeInDown'
          },
          hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
          }
        })
      }
    }
  }
  reload(){
    location.reload();
  }
}
