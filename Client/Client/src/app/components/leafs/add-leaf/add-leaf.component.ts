import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-leaf',
  templateUrl: './add-leaf.component.html',
  styleUrls: ['./add-leaf.component.css']
})
export class AddLeafComponent implements OnInit {

  addLeafRequest: LeafAdd = {
    name: '',
    parentId: ''
  }
  constructor(private leafService: LeafService, private router: Router) { }

  ngOnInit(): void {
  }

  addLeaf(){
    this.leafService.addLeaf(this.addLeafRequest)
    .subscribe({
      next: (leaf) => {
        this.router.navigate(['leafs']);
      }
    });
  }

}

