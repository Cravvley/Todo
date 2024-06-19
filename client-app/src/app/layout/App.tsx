import { useEffect, useState } from "react";
import axios from "axios";
import { Container } from "semantic-ui-react";
import { TodoItem } from "../models/todoItem";
import NavBar from "./NavBar";
import TodosList from "../../features/todos/TodosList";

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
        <TodosList todos={todos} />
      </Container>
    </>
  );
}

export default App;
