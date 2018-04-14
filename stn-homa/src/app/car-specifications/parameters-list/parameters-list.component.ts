import { Component, OnInit } from '@angular/core';
import { Car } from '../../domain/cars/car';
import { CarService } from '../../domain/cars/car.service';

@Component({
  selector: 'stn-parameters-list',
  templateUrl: './parameters-list.component.html',
  styleUrls: ['./parameters-list.component.css']
})
export class ParametersListComponent implements OnInit {
  car: Car[];

  constructor(private carService: CarService) {
    this.car = [];
  }

  ngOnInit() {
    this.car = this.carService.selectedCar;
  }
}
