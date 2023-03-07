import React from 'react';
import Sidebar from '../components/Sidebar';

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
    }
  ];

  return (
    <div className='main '>
      <Sidebar />
      <div className='container mt-5'>
        <h1>Mis Cotizaciones</h1>
        <table className='table  mt-3 text-light'>
          <thead>
            <tr>
              <th>ID</th>
              <th>Fecha</th>
              <th>Productos</th>
              <th>Precios</th>
              <th>Tiendas</th>
            </tr>
          </thead>
          <tbody>
            {cotizaciones.map((cotizacion) => (
              <tr key={cotizacion.id}>
                <td>{cotizacion.id}</td>
                <td>{cotizacion.fecha}</td>
                <td>{cotizacion.productos.join(', ')}</td>
                <td>{cotizacion.precios.join(', ')}</td>
                <td>{cotizacion.tiendas.join(', ')}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default MisCotizaciones;
