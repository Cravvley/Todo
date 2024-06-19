import { Container, Menu, Button } from "semantic-ui-react";
import "./styles.css";

export default function NavBar() {
  return (
    <Menu inverted fixed="top">
      <Container>
        <Menu.Item header className="mr--sm">
          <img src="/assets/logo.webp" alt="logo" />
        </Menu.Item>
        <Menu.Item name="Add Todo">
          <Button positive content="Add Todo" />
        </Menu.Item>
        <Menu.Item name="Login" />
        <Menu.Item name="Logout" />
      </Container>
    </Menu>
  );
}
