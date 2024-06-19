import { Grid, List } from "semantic-ui-react";
import { TodoItem } from "../../app/models/todoItem";
import "../../app/layout/styles.css";
interface Props {
  todos: TodoItem[];
}

export default function TodoList(props: Props) {
  return (
    <Grid className="m--lg">
      <Grid.Column width="10">
        <List>
          {props.todos.map((todo: TodoItem) => (
            <List.Item key={todo.id}>{todo.title}</List.Item>
          ))}
        </List>
      </Grid.Column>
    </Grid>
  );
}
