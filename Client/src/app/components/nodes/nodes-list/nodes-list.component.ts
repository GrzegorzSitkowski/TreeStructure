import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import {Node } from 'src/app/models/node.model'
import { NodesService } from 'src/app/services/nodes.service';

@Component({
  selector: 'app-nodes-list',
  templateUrl: './nodes-list.component.html',
  styleUrls: ['./nodes-list.component.css']
})
export class NodesListComponent implements OnInit {

  nodes: Node[] = [];
  constructor(private nodesService: NodesService) { }

  ngOnInit(){
    this.nodesService.getAllNodes()
    .subscribe({
      next: (nodes) => {
        this.nodes = nodes as unknown as Node[];
        console.log(nodes);
      },
      error: (response) => {
        console.log(response);
      }
    })
  }
  }
