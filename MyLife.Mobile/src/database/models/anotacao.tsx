export class Anotacao {
    constructor(id:number, descricao: string, texto: string) {
        console.debug(`Anotacao construtor: ${id}, ${descricao}, ${texto}`)
        this.id = id;
        this.descricao = descricao;
        this.texto = texto;
    }

    public id: number;
    public descricao: string;
    public texto: string;

    public toString() {
        return `id = ${this.id}, descricao = ${this.descricao}, texto = ${this.texto},`;
    }
}