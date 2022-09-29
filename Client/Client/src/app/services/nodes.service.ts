import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class NodesService {
  baseApiUrl: string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getAllNodes(): Observable<Node[]>{
    return this.http.get<Node[]>(this.baseApiUrl + '/api/nodes');
  }

  getFirstNode(): Observable<Node[]>{
    return this.http.get<Node[]>(this.baseApiUrl + '/api/withoutParents');
  }

  addNode(addNodeRequest: NodeAdd): Observable<NodeAdd>{
    return this.http.post<NodeAdd>(this.baseApiUrl + '/api/nodes', addNodeRequest);
  }

  getNode(id: string): Observable<NodeEdit>{
    return this.http.get<NodeEdit>(this.baseApiUrl + '/api/nodes/' + id);
  }

  updateNode(id: string, updateNodeRequest: NodeEdit): Observable<NodeEdit> {
    return this.http.put<NodeEdit>(this.baseApiUrl + '/api/nodes/' + id, updateNodeRequest);
  }

  deleteNode(id: string): Observable<NodeEdit>{
    return this.http.delete<NodeEdit>(this.baseApiUrl + '/api/nodes/' + id);
  }
}
