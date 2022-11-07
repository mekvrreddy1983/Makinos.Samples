import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Environment } from 'src/environments/environment';

@Injectable()
export class PersonService {

  public baseHtppUrl: string;
  constructor(private httpService: HttpClient) {
    this.baseHtppUrl = Environment.apiUrl;
  }

  Add(person: any): Observable<any> {
    const apiUrl = this.baseHtppUrl + 'person/saveperson';
    return this.httpService.post(apiUrl, person);
  }
}
