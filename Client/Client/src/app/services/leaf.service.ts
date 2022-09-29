import { Injectable } from '@angular/core';
import { Leaf } from '../models/leaf.model';

@Injectable({
  providedIn: 'root'
})
export class LeafService {

  baseApiUrl: string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getAllLeafs(): Observable<Leaf[]>{
    return this.http.get<Leaf[]>(this.baseApiUrl + '/api/leafs');
  }
  addLeaf(addLeafRequest: LeafAdd): Observable<LeafAdd>{
    return this.http.post<LeafAdd>(this.baseApiUrl + '/api/leafs', addLeafRequest);
  }

  getLeaf(id: string): Observable<LeafEdit>{
    return this.http.get<LeafEdit>(this.baseApiUrl + '/api/leafs/' + id);
  }

  updateLeaf(id: string, updateLeafRequest: LeafEdit): Observable<LeafEdit> {
    return this.http.put<LeafEdit>(this.baseApiUrl + '/api/leafs/' + id, updateLeafRequest);
  }

  deleteLeaf(id: string): Observable<LeafEdit>{
    return this.http.delete<LeafEdit>(this.baseApiUrl + '/api/leafs/' + id);
  }
}
