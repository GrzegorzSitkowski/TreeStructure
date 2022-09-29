import { Component, OnInit } from '@angular/core';
import { Leaf } from 'src/app/models/leaf.model';
import { LeafService } from 'src/app/services/leaf.service';

@Component({
  selector: 'app-leafs-list',
  templateUrl: './leafs-list.component.html',
  styleUrls: ['./leafs-list.component.css']
})
export class LeafsListComponent implements OnInit {

  leafs: Leaf[] = [];
  constructor(private leafService: LeafService) { }

  ngOnInit(): void {  
    this.leafService.getAllLeafs()
    .subscribe({
      next: (leafsApi) => {
        this.leafs = leafsApi as Leaf[];
        console.log(this.leafs);
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

}

