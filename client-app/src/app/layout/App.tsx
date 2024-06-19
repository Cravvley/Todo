import { useEffect, useState } from "react";
import axios from "axios";
import { List } from "semantic-ui-react";

function App() {
  const [todos, setTodos] = useState([]);

  useEffect(() => {
    axios.get("http://localhost:5000/TodoItems").then((response) => {
      setTodos(response.data);
    });
  });
  return (
    <>
      <List>
        {todos.map((todo: any) => (
          <List.Item key={todo.id}>{todo.title}</List.Item>
        ))}
      </List>
    </>
  );
}

export default App;
