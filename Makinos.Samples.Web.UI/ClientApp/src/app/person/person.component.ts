import { Component } from '@angular/core';
import { person } from 'src/app/models/person';
import { PersonService } from 'src/app/services/person.service'
@Component({
  selector: 'app-person-component',
  templateUrl: './person.component.html'
})
export class PersonComponent {
  public _person: person = new person();
  public personService: PersonService;
  constructor(private _personService: PersonService) {
    this.personService = _personService;
  }
  public Add() {
    this.personService.Add(this._person);
  }
}
