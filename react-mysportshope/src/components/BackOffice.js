import { Col, Container, Row } from "react-bootstrap";
import { Outlet } from "react-router-dom";


function BackOffice() {
  return (
    <Container fluid>
      <Row>
        <Col md={3}>
        
        </Col>
        <Col md={9}>
          <h2>Welcome to the backoffice</h2>
          <Outlet />
        </Col>
      </Row>
    </Container>
  );
}

export default BackOffice;
