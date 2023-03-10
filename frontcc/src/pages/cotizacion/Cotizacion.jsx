import React, { useState } from 'react';
import { Form, Button, Card, ListGroup } from 'react-bootstrap';
import Sidebar from '../../components/Sidebar';

function Cotizacion() {
  const [elementos, setElementos] = useState([]);

  const handleSubmit = (evento) => {
    evento.preventDefault();
    const nuevoElemento = evento.target.nuevoElemento.value;
    if (nuevoElemento.trim() !== '') {
      agregarElemento(nuevoElemento);
    }
    evento.target.reset();
  };

  const agregarElemento = (nuevoElemento) => {
    setElementos([...elementos, nuevoElemento]);
  };

  const eliminarElemento = (indice) => {
    const nuevosElementos = elementos.filter((_, i) => i !== indice);
    setElementos(nuevosElementos);
  };

  return (
    <div className="main">
      <Sidebar />
      <div className="container mt-5">
        <h1>Cotizaciones</h1>
        <p>
          Ingresa una lista de productos para cotizar (la cotización se
          realizará en Sodimac, easy y construmart) se harán 2 listas de valores,
          una con los precios más bajos y otra con precios más altos.
        </p>
        <Card className="px-4 pb-4 pt-2 bordeform">
          <Form onSubmit={handleSubmit} className="text-dark">
            <Form.Group controlId="nuevoElemento">
              <Form.Label>Nuevo producto:</Form.Label>
              <Form.Control
                type="text"
                placeholder="ej. Tornillo Volcanita Roscalata gruesa N°6 x 1 5/8'' CRS zincado 100 unidades"
              />
            </Form.Group>
            <Button type="submit" className="my-3 btn btn-light">
              Agregar producto +
            </Button>
          </Form>
          <Form>
            {elementos.length > 0 && (
              <ListGroup className="text-dark fs-5 rounded-4">
                <p className='mt-3'>Listado de productos:</p>
                {elementos.map((elemento, indice) => (
                  <ListGroup.Item key={indice} className="rounded-start-pill my-1 shadow-sm">
                    <span
                      className="text-danger"
                      onClick={() => eliminarElemento(indice)}
                    >
                      <i className="bi bi-trash"></i>
                    </span>{" "}
                    #{indice + 1} {elemento}
                  </ListGroup.Item>
                ))}
              </ListGroup>
            )}
            <Button type="submit" className="my-3 btn btn-primary">
              Cotizar
            </Button>
          </Form>
        </Card>
      </div>
    </div>
  );
}

export default Cotizacion;
