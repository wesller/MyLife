import { Stack, useLocalSearchParams } from "expo-router";
import { useEffect, useState } from "react";
import { StyleSheet, Text, View } from "react-native";

const AnotacaoDetails = () => {
  const [anotacao, setAnotacao] = useState<any>(null);
  const [isLoading, setIsLoading] = useState(true);
  const { id } = useLocalSearchParams();

  useEffect(() => {
    fetch(`https://10.0.2.2:7165/anotacao/${id}`)
      .then((response) => response.json())
      .then((json) => {
        setAnotacao(json);
        setIsLoading(false);
      })
      .catch((error) => console.error(error));
  }, []);

  if (isLoading) {
    return <Text>Loading...</Text>;
  }

  return (
    <View>
      <Stack.Screen
        options={{
          title: anotacao.name,
        }}
      />
      <View>
        <Text style={styles.name}>Id: {anotacao.name}</Text>
        <Text style={styles.text}>Descricao: {anotacao.descricao}</Text>
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