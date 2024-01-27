import { ListGroup } from "react-bootstrap";
import { Link } from "react-router-dom";

function SidePanel() {
  return (
    <ListGroup>
      <ListGroup.Item as={Link} to="product">
      Product
      </ListGroup.Item>
    </ListGroup>
  );
}

export default SidePanel;
