import React from 'react';
import { Container, Row, Col, Card } from 'react-bootstrap';
import Sidebar from '../commons/Sidebar.jsx';

const Landing = () => {
  return (
    <div className="landing">
      <Sidebar/>
      <Container>
        <Row>
          <Col>
            <h1 className="text-center">Construcheck</h1>
            <p className="text-center">La herramienta de seguimiento de proyectos y pagos para contratistas de construcción.</p>
          </Col>
        </Row>
        <Row className="mt-4">
          <Col>
            <h3>Características</h3>
          </Col>
        </Row>
        <Row className="mt-4">
          <Col md={4}>
            <Card className="bg-primary">
              <Card.Body>
                <Card.Title>Gestión de proyectos</Card.Title>
                <Card.Text>
                  Gestiona tus proyectos de construcción de manera fácil y eficiente.
                </Card.Text>
              </Card.Body>
            </Card>
          </Col>
          <Col md={4}>
            <Card className="bg-success">
              <Card.Body>
                <Card.Title>Seguimiento de pagos</Card.Title>
                <Card.Text>
                  Mantén un seguimiento claro y ordenado de los pagos de tus empleados y proveedores.
                </Card.Text>
              </Card.Body>
            </Card>
          </Col>
          <Col md={4}>
            <Card className="bg-warning">
              <Card.Body>
                <Card.Title>Gestión de empleados</Card.Title>
                <Card.Text>
                  Maneja fácilmente la información de tus empleados y genera reportes detallados.
                </Card.Text>
              </Card.Body>
            </Card>
          </Col>
        </Row>
      </Container>
    </div>
  );
}

export default Landing;
