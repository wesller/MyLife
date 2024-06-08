import { Tabs } from "expo-router";
import { Text } from "react-native";

export default function AppLayout() {
  return (
    <Tabs
      screenOptions={{
        headerShown: false,
      }}
    >
      <Tabs.Screen
        name="anotacoes"
        options={{
          title: "Anotações",
          tabBarIcon: () => <Text>&#9997;</Text>,
        }}
      />
      <Tabs.Screen
        name="biblia"
        options={{
          title: "Biblia Sagrada",
          tabBarIcon: () => <Text>&#10014;</Text>,
        }}
      />

      <Tabs.Screen
        name="treino"
        options={{
          title: "Treino",
          tabBarIcon: () => <Text>&#9977;</Text>,
        }}
      />
    </Tabs>
  );
}