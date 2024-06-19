import { useEffect, useState } from "react";
import axios from "axios";
import { Container, List } from "semantic-ui-react";
import { TodoItem } from "../models/todoItem";
import NavBar from "./NavBar";

function App() {
  const [todos, setTodos] = useState<TodoItem[]>([]);

  useEffect(() => {
    axios.get("http://localhost:5000/TodoItems").then((response) => {
      setTodos(response.data);
    });
  });
  return (
    <>
      <NavBar />
      <Container>
        <List className="m--lg">
          {todos.map((todo: TodoItem) => (
            <List.Item key={todo.id}>{todo.title}</List.Item>
          ))}
        </List>
      </Container>
    </>
  );
}

export default App;
