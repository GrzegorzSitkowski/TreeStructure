import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NodesListComponent } from './components/nodes/nodes-list/nodes-list.component';

const routes: Routes = [
  {
    path: '',
    component: NodesListComponent
  },
  {
    path: 'nodes',
    component: NodesListComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
