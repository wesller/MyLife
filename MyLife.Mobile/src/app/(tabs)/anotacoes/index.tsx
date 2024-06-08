import DatabaseInit from "@/database/database-init";
import { Link, Stack } from "expo-router";
import { useEffect, useState } from "react";
import { FlatList, Pressable, StyleSheet, Text, View } from "react-native";
import * as SQLite from 'expo-sqlite';
import DatabaseService from "@/database/database-service";
import { Anotacao } from "@/database/models/anotacao";
import anotacao from "@/database/models";

const Anotacoes = () => {
  let [anotacoes, setAnotacoes] = useState([]);
  
  let dados : Anotacao[] = [];
  function add(a : Anotacao) {
    dados.push(a);
  }
  
  useEffect(() => {
    const dbInit = new DatabaseInit();
    const dbservice = new DatabaseService();
    
    
    let dados = Array<Anotacao>;
    dbservice.Select().then(function (result) {
      console.debug('result: ==>' + result.toString());
      result.forEach(r => {add(r);});
      }).catch(erro => console.debug('erro no promise::' + erro));
  }, []);

  const renderItem = ({ item }: { item: any }) => (
    <Link href={`/anotacoes/${item.id}`} asChild>
      <Pressable style={styles.itemContainer}>
        <View style={styles.textContainer}>
          <Text style={styles.nameText}>{item.descricao}</Text>
        </View>
      </Pressable> 
    </Link>
  );

  return (
    <View>
   <Stack.Screen options={{ title: "Lista de Anotações" }} />
      <FlatList
        data={dados}
        renderItem={renderItem}
      />
    </View>
  );
};

export default Anotacoes;

const styles = StyleSheet.create({
  itemContainer: {
    flex: 1,
    flexDirection: "row",
    alignItems: "center",
    padding: 12,
    borderBottomWidth: 1,
    borderBottomColor: "#eee",
    color: "#000",
    fontSize: 20
  },
  textContainer: {
    marginLeft: 16,
  },
  nameText: {
    fontSize: 16,
    fontWeight: "bold",
  },
});
