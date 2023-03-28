import React from 'react'
import Sidebar from '../../components/Sidebar'
import Table from 'react-bootstrap/Table'
import Button from 'react-bootstrap/Button'


const MisCotizaciones = () => {
  const cotizaciones = [
    {
      id: 1,
      fecha: '10/03/2022',
      productos: ['Producto 1', 'Producto 2', 'Producto 3'],
      precios: [1000, 2000, 3000],
      tiendas: ['Sodimac', 'Easy', 'Construmart']
    },
    {
      id: 2,
      fecha: '15/03/2022',
      productos: ['Producto 4', 'Producto 5', 'Producto 6'],
      precios: [1500, 2500, 3500],
      tiendas: ['Sodimac', 'Easy', 'Construmart']
    },
    {
      id: 3,
      fecha: '15/03/2022',
      productos: ['Producto 4', 'Producto 5', 'Producto 6'],
      precios: [1500, 2500, 3500],
      tiendas: ['Sodimac', 'Easy', 'Construmart']
    },
    {
      id: 4,
      fecha: '15/03/2022',
      productos: ['Producto 4', 'Producto 5', 'Producto 6'],
      precios: [1500, 2500, 3500],
      tiendas: ['Sodimac', 'Easy', 'Construmart']
    },
    {
      id: 5,
      fecha: '11/03/2022',
      productos: ['Producto 4', 'Producto 5', 'Producto 6'],
      precios: [1500, 2500, 3500],
      tiendas: ['Sodimac', 'Easy', 'Construmart']
    },
    {
      id: 6,
      fecha: '16/03/2022',
      productos: ['Producto 4', 'Producto 5', 'Producto 6'],
      precios: [1500, 2500, 3500,7500],
      tiendas: ['Sodimac', 'Easy', 'Construmart']
    },
    {
      id: 7,
      fecha: '18/03/2022',
      productos: ['Producto 6', 'Producto 2', 'Producto 6'],
      precios: [1500, 2500, 3500],
      tiendas: ['Sodimac', 'Easy', 'Construmart']
    }
  ];
  // Agregar la propiedad "total" a cada objeto de cotizaciones al ingresar a la bsd se guardara la suma
  const cotizacionesConTotal = cotizaciones.map((cotizacion) => ({
    ...cotizacion,
    total: cotizacion.precios.reduce((sum, precio) => sum + precio, 0)
  }));
  return (
    <div className='main '>
      <Sidebar />
      <div className='container mt-5 card '>
        <h1 className='text-dark my-4 ms-3'>Mis Cotizaciones</h1>
        <Table striped bordered hover>
          <thead>
            <tr>
              <th></th>
              <th>#ID</th>
              <th>Fecha</th>
              <th>Productos</th>
              <th>Valores</th>
              <th>Total</th>
              <th>Casa Comercial</th>
            </tr>
          </thead>
          <tbody>
            {cotizacionesConTotal.map((cotizacion) => (
                  <tr key={cotizacion.id}>
                    <td><Button variant="primary">Ver Más</Button></td>
                    <td>{cotizacion.id}</td>
                    <td>{cotizacion.fecha}</td>
                    <td>{cotizacion.productos.join(', ')}</td>
                    <td>{cotizacion.precios.join(', ')}</td>
                    <td>{cotizacion.total}</td>
                    <td>{cotizacion.tiendas.join(', ')}</td>
                  </tr>
                ))}
          </tbody>
          </Table>
      </div>
    </div>
  );
};

export default MisCotizaciones;
