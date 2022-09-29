import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-edit-node',
  templateUrl: './edit-node.component.html',
  styleUrls: ['./edit-node.component.css']
})
export class EditNodeComponent implements OnInit {

  nodeDetails: NodeEdit = {
    id: '',
    name: '',
    parentId: 0,
    leafs: 0,
    children: 0
  };

  constructor(private route: ActivatedRoute, private nodesService: NodesService, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');
        if(id){
          this.nodesService.getNode(id)
          .subscribe({
            next: (response) => {
              this.nodeDetails = response;
              console.log('Id: ' + this.nodeDetails.id);
            }
          });
        }
      }
    })
  }

  updateNode(){
    this.nodesService.updateNode(this.nodeDetails.id, this.nodeDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['nodess']);
        console.log('Done!');
      }
    });
  }

  deleteNode(id: string){
    this.nodesService.deleteNode(id)
    .subscribe({
      next: (response) => {
        this.router.navigate(['nodes']);
      }
    })
  }

}
