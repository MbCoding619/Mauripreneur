import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-carousel',
  templateUrl: './carousel.component.html',
  styleUrls: ['./carousel.component.css']
})
export class CarouselComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

 // images = [944, 1012, 984].map((n) => `https://picsum.photos/id/${n}/900/500`);
 images = ["https://localhost:4200/assets/vector1.jpeg","https://localhost:4200/assets/vector1.jpeg","https://localhost:4200/assets/vector1.jpeg"]
}
