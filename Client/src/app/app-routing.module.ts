import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddNodeComponent } from './components/nodes/add-node/add-node.component';
import { NodesListComponent } from './components/nodes/nodes-list/nodes-list.component';

const routes: Routes = [
  {
    path: '',
    component: NodesListComponent
  },
  {
    path: 'nodes',
    component: NodesListComponent
  },
  {
    path: 'nodes/add',
    component: AddNodeComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
