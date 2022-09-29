import { Component, OnInit } from '@angular/core';
import { LeafService } from 'src/app/services/leaf.service';

@Component({
  selector: 'app-edit-leaf',
  templateUrl: './edit-leaf.component.html',
  styleUrls: ['./edit-leaf.component.css']
})
export class EditLeafComponent implements OnInit {


  leafDetails: LeafEdit = {
    id: '',
    name: '',
    parentId: ''
  };

  constructor(private route: ActivatedRoute, private leafService: LeafService, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');
        if(id){
          this.leafService.getLeaf(id)
          .subscribe({
            next: (response) => {
              this.leafDetails = response;
            }
          });
        }
      }
    })
  }

  updateLeaf(){
    this.leafService.updateLeaf(this.leafDetails.id, this.leafDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['leafs']);
      }
    });
  }

  deleteleaf(id: string){
    this.leafService.deleteLeaf(id)
    .subscribe({
      next: (response) => {
        this.router.navigate(['leafs']);
      }
    })
  }

}
