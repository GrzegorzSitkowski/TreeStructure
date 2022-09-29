import { Component, OnInit } from '@angular/core';
import { NodesService } from 'src/app/services/nodes.service';

@Component({
  selector: 'app-nodes-list',
  templateUrl: './nodes-list.component.html',
  styleUrls: ['./nodes-list.component.css']
})
export class NodesListComponent implements OnInit {

  nodes: Node[] = [];
  constructor(private nodesService: NodesService) { }

  ngOnInit(): void {
    this.nodesService.getAllNodes()
    .subscribe({
      next: (nodes) =>{
        this.nodes = nodes;
      },
      error: (response) => {
        console.log(response);
      }
    })

    this.nodesService.getFirstNode()
    .subscribe({
      next: (nodes) =>{
        this.nodes = nodes;
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

}
