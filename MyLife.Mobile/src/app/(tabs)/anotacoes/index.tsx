import { Link, Stack } from "expo-router";
import { useEffect, useState } from "react";
import { FlatList, Pressable, StyleSheet, Text, View } from "react-native";

const Anotacoes = () => {
  const [anotacoes, setAnotacoes] = useState([]);

  useEffect(() => {
    fetch("https://10.0.2.2:7165/anotacao")
      .then((response) => response.json())
      .then((json) => {
        setAnotacoes(json);
      })
      .catch((error) => console.error(error));
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
        data={anotacoes}
        keyExtractor={({ id }) => id}
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
    padding: 16,
    borderBottomWidth: 1,
    borderBottomColor: "#eee",
  },
  textContainer: {
    marginLeft: 16,
  },
  nameText: {
    fontSize: 16,
    fontWeight: "bold",
  },
});