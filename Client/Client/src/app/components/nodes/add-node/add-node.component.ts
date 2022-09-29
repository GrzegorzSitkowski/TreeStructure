import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-node',
  templateUrl: './add-node.component.html',
  styleUrls: ['./add-node.component.css']
})
export class AddNodeComponent implements OnInit {

  addNodeRequest: NodeAdd = {
    name: '',
    parentId: 0,
    leafs: 0,
    children: 0
  }
  constructor(private nodesService: NodesService, private router: Router) { }

  ngOnInit(): void {
  }

  addNode(){
    this.nodesService.addNode(this.addNodeRequest)
    .subscribe({
      next: (node) => {
        this.router.navigate(['nodes']);
      }
    });
  }

}