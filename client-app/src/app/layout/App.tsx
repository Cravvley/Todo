import { useEffect, useState } from "react";
import axios from "axios";
import { List } from "semantic-ui-react";
import { TodoItem } from "../models/todoItem";

function App() {
  const [todos, setTodos] = useState<TodoItem[]>([]);

  useEffect(() => {
    axios.get("http://localhost:5000/TodoItems").then((response) => {
      setTodos(response.data);
    });
  });
  return (
    <>
      <List>
        {todos.map((todo: TodoItem) => (
          <List.Item key={todo.id}>{todo.title}</List.Item>
        ))}
      </List>
    </>
  );
}

export default App;
