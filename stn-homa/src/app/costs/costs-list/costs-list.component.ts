import { Component, OnInit } from '@angular/core';
import { Cost } from '../../domain/costs/cost';
import { CostService } from '../../domain/costs/cost.service';

@Component({
  selector: 'stn-costs-list',
  templateUrl: './costs-list.component.html',
  styleUrls: ['./costs-list.component.css']
})
export class CostsListComponent implements OnInit {
  costs: Cost[];

  constructor(private costService: CostService) { }

  ngOnInit() {
    this.costs = this.costService.costs;
  }

}