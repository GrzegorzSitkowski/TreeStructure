export interface Node{
    id: string;
    name: string;
    parentId: number;
    leafs: string[];
    childrenId: string[];
}