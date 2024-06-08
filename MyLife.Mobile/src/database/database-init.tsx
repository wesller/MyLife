import * as SQLite from 'expo-sqlite';

export default class DatabaseInit {

    constructor() {
        this.InitDb()
    }

    private async InitDb() {
        console.debug('Iniciando o banco de dados')
        try
        {
            const db = await SQLite.openDatabaseAsync('MyLife.db');
            console.debug('Banco de dados aberto.');
            (await db).execSync('PRAGMA foreign_keyas = ON;');
            (await db).execSync(`create table if not exists anotacao (
                    id integer primary key autoincrement,
                    descricao text,
                    texto text        
                    );`);
            (await db).execSync(`INSERT OR REPLACE INTO anotacao (id, descricao, texto) values(1, 'Anotacao 1', 'a');`);
            (await db).execSync(`INSERT OR REPLACE INTO anotacao (id, descricao, texto) values(2, 'Anotacao 2', 'aa');`);
            (await db).execSync(`INSERT OR REPLACE INTO anotacao (id, descricao, texto) values(3, 'Anotacao 3', 'aaa');`);
            (await db).execSync(`INSERT OR REPLACE INTO anotacao (id, descricao, texto) values(4, 'Anotacao 4', 'aaaa');`);

            // (await db).execAsync(`
            //     PRAGMA foreign_keyas = ON;
    
            //     create table if not exists anotacao (
            //         id integer primary key autoincrement,
            //         descricao text,
            //         texto text        
            //         );
    
            //     INSERT OR REPLACA INTO anotacao (id, descricao, text) values(1, 'Anotacao 1', 'a');
            //     INSERT OR REPLACA INTO anotacao (id, descricao, text) values(2, 'Anotacao 1', 'b');
            //     INSERT OR REPLACA INTO anotacao (id, descricao, text) values(3, 'Anotacao 1', 'c');
            //     INSERT OR REPLACA INTO anotacao (id, descricao, text) values(4, 'Anotacao 1', 'd');
            //    `);
        } catch(err) {
            console.debug(`Erro ao iniciar a base de dados: ${err}`);
        }
    }
}