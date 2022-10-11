import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {Node } from 'src/app/models/node.model'
import { NodesService } from 'src/app/services/nodes.service';

@Component({
  selector: 'app-add-node',
  templateUrl: './add-node.component.html',
  styleUrls: ['./add-node.component.css']
})
export class AddNodeComponent implements OnInit {

  addNodeRequest: Node = {
    id: '',
    name: '',
    parentId: ''
  };
  constructor(private nodeService: NodesService, private router: Router) { }

  ngOnInit(): void {
  }

  addNode(){
    this.nodeService.addNode(this.addNodeRequest)
    .subscribe({
      next: (node) => {
        this.router.navigate(['node']);
      }
    })
  }

}
