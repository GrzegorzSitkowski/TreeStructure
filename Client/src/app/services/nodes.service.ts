import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class NodesService {

  baseApiUrl: string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getAllNodes(): Observable<Node[]>{
    return this.http.get<Node[]>(this.baseApiUrl + '/api/nodes').pipe(tap(console.log));
  }

  addNode(addNodeRequest: Node): Observable<Node>{
    return this.http.post<Node>(this.baseApiUrl + '/api/nodes', addNodeRequest);
  }
}
