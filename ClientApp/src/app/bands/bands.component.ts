import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-bands',
  templateUrl: './bands.component.html'
})
export class BandsComponent {
  public bands: Band[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Band[]>(baseUrl + 'bands').subscribe(result => {
      this.bands = result;
    }, error => console.error(error));
  }
}

export class Band {
  public name: string = "";
  public songs: Song[] = [];
}

export class Song {
  public title: string = "";
  public album!: Album;
}

export class Album {
  public title: string = "";
}
