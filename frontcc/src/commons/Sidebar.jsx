import React from 'react';
import { Link } from 'react-router-dom';
import { Nav } from 'react-bootstrap';

const Sidebar = () => {
  return (
    <div className="sidebar">
      <Nav defaultActiveKey="/" className="flex-column">
        <Nav.Link as={Link} to="/">Inicio</Nav.Link>
        <Nav.Link as={Link} to="/proyectos">Proyectos</Nav.Link>
        <Nav.Link as={Link} to="/empleados">Empleados</Nav.Link>
        <Nav.Link as={Link} to="/pagos">Pagos</Nav.Link>
        <Nav.Link as={Link} to="/cotizaciones">Cotizaciones</Nav.Link>
      </Nav>
    </div>
  );
}

export default Sidebar;