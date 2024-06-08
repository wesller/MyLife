import DatabaseService from "@/database/database-service";
import { Anotacao } from "@/database/models/anotacao";
import { Stack, useLocalSearchParams } from "expo-router";
import { useEffect, useState } from "react";
import { StyleSheet, Text, View } from "react-native";

const AnotacaoDetails = () => {
  const [anotacao, setAnotacao] = useState<any>(null);
  const [isLoading, setIsLoading] = useState(true);
  const { id } = useLocalSearchParams();

  let dados = new Anotacao(0 , '', '');

  function add(a : Anotacao) {
    dados = a;
  }

  useEffect(() => {
    const dbservice = new DatabaseService();
    dbservice.SelectId(id).then(function (result) {
      add(result);
      setIsLoading(false);
      setAnotacao(dados);
      }).catch(erro => console.debug('erro no promise::' + erro));
  }, []);
  
  return (
    <View>
     <Stack.Screen
        options={{
          title: anotacao.descricao,
        }}
      />
      <View>
       <Text style={styles.name}>Id: {anotacao.id}</Text>
       <Text style={styles.text}>Descrição:{anotacao.descricao}</Text>
       <Text style={styles.text}>Texto: {anotacao.texto}</Text> 
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  name: {
    fontSize: 20,
    fontWeight: "bold",
    textAlign: "center",
    margin: 10,
  },
  text: {
    fontSize: 16,
    textAlign: "center",
    margin: 10,
  },
});

export default AnotacaoDetails;