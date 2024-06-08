import { Anotacao } from './models/anotacao'
import * as SQLite from 'expo-sqlite';

export default class DatabaseService {

    public async Select() : Promise<Array<Anotacao>> {
        let db = await SQLite.openDatabaseAsync('MyLife.db');
        let anotacoes = new Array<Anotacao>;
        try
        {
            const allRows = await db.getAllAsync('SELECT * FROM anotacao;');
            allRows.forEach(i => anotacoes.push(i));
    
        } catch(err) {
            console.debug('Erro ao retornar dados: ' +err);
        }
        
        return anotacoes;
    }

    public async SelectId(id : number) : Promise<Anotacao> {
        let db = await SQLite.openDatabaseAsync('MyLife.db');
        let anotacao = null;
        try
        {   
            const ret = await db.getFirstAsync(`SELECT * FROM anotacao where id = ${id}`);
            anotacao = new Anotacao(ret.id, ret.descricao, ret.texto);
        } catch(err) {
            console.debug('Erro ao retornar dados 2: ' +err);
        }
        
        return anotacao;
    }

}