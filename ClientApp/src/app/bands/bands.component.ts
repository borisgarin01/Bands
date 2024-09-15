import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-bands',
  templateUrl: './bands.component.html'
})
export class BandsComponent {
  public bands: string[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<string[]>(baseUrl + 'bands').subscribe(result => {
      this.bands = result;
    }, error => console.error(error));
  }
}
