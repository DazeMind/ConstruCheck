import React, { useState } from 'react';
import { Form, Button, Card } from 'react-bootstrap'
import Sidebar from '../components/Sidebar'

function Cotizacion() {

  const [elementos, setElementos] = useState([]);
  
  function agregarElemento(nuevoElemento) {
    setElementos([...elementos, nuevoElemento]);
  }
  
  function eliminarElemento(indice) {
    const nuevosElementos = elementos.filter((elemento, i) => i !== indice);
    setElementos(nuevosElementos);
  }
  
  function handleSubmit(evento) {
    evento.preventDefault();
    const nuevoElemento = evento.target.nuevoElemento.value;
    if (nuevoElemento.trim() !== '') {
      agregarElemento(nuevoElemento);
    }
    evento.target.reset();
  }

  return (
    <div className="main text-dark" >
      <Sidebar />
      <div className="container mt-5">
        <h1>Cotizaciones</h1>
        <p>Ingresa una lista de productos para cotizar (la cotizacion se realizara en Sodimac, easy y construmart) se haran 2 listas de valores, una con los precios mas bajos y otra con precios mas altos</p>
        <Card className='px-4 pb-4 pt-2 bordeform' >
          <Form onSubmit={handleSubmit} className="text-dark">
            <Form.Group className="mb-3 col-6" controlId="formBasicEmail">
              <Form.Label htmlFor="nuevoElemento">Nuevo producto:</Form.Label>
              <Form.Control id="nuevoElemento" type="text" placeholder="ej. Tornillo Volcanita Roscalata gruesa N°6 x 1 5/8'' CRS zincado 100 unidades" />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicEmail">
              <Button type="submit" className='btn btn-light'>Agregar producto +</Button>
            </Form.Group>
          </Form>
          <ul className="text-dark fs-5">
            <p>Listado de productos:</p>
            {elementos.map((elemento, indice) => (
              <ol key={indice}><span className='text-danger' onClick={() => eliminarElemento(indice)}><i class="bi bi-trash"></i></span> #{indice+1} {elemento} </ol>
            ))}
          </ul>
        </Card>
        
      </div>
    </div>
  )
}

export default Cotizacion
