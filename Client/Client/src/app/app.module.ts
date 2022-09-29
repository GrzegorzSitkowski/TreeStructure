import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NodesListComponent } from './components/nodes/nodes-list/nodes-list.component';
import { AddNodeComponent } from './components/nodes/add-node/add-node.component';
import { EditNodeComponent } from './components/nodes/edit-node/edit-node.component';
import { LeafsListComponent } from './leafs-list/leafs-list.component';
import { AddLeafComponent } from './components/leafs/add-leaf/add-leaf.component';
import { EditLeafComponent } from './components/leafs/edit-leaf/edit-leaf.component';

@NgModule({
  declarations: [
    AppComponent,
    NodesListComponent,
    AddNodeComponent,
    EditNodeComponent,
    LeafsListComponent,
    AddLeafComponent,
    EditLeafComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
