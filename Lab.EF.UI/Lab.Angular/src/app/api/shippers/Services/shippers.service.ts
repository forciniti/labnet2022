import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Shippers } from '../Models/Shippers';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {
  endpoint: string = 'api/ShippersApi';
  constructor(private http: HttpClient) { }

  InsertShipper(request:Shippers) : Observable<any>{
    return this.http.post(environment.ShippersApi + this.endpoint, request);
  }

  FindShippers() : Observable<Shippers[]>{
    return this.http.get<Shippers[]>(environment.ShippersApi + this.endpoint);
  }
  UpdateShippers(request:Shippers, id : String) : Observable<any>{
    return this.http.put(environment.ShippersApi + this.endpoint + '/' + id , request);
  }

  DeleteShippers( id : String) : Observable<any>{
    return this.http.delete(environment.ShippersApi + this.endpoint + '/' + id);
  }
}
