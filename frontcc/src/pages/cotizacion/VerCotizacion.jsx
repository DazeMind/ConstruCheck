import React from 'react'
import Sidebar from '../../components/Sidebar'
import Table from 'react-bootstrap/Table'

const VerCotizacion = () => {
  const productos = [
    {
      id: 1,
      nombre: 'Clavos 3"',
      precio: [1000],
      tienda: ['Sodimac']
    },
    {
      id: 2,
      nombre: 'Tornillos vulcanita',
      precio: [1500],
      tienda: ['Easy']
    },
    {
      id: 3,
      nombre: 'Madera de pino 3x2 3.2m',
      precio: [2500],
      tienda: ['Easy']
    },
    {
      id: 4,
      nombre: 'Vulcanita 5M',
      precio: [3500],
      tienda: ['Easy']
    },
    {
      id: 5,
      nombre: 'Conector coaxial',
      precio: [1500],
      tienda: ['Construmart']
    },
    {
      id: 6,
      nombre: 'Cable UTP 40M',
      precio: [7500],
      tienda: ['Sodimac']
    },
    {
      id: 7,
      nombre: 'Enchufe macho',
      precio: [2500],
      tienda: ['Sodimac']
    }
  ];
  // Agregar la propiedad "total" a cada objeto de cotizaciones al ingresar a la bsd se guardara la suma
  const productosConTotal = productos.map((productos) => ({
    ...productos,
    total: productos.precio.reduce((sum, precio) => sum + precio, 0)
  }));
  return (
    <div className='main '>
        <Sidebar />
        <div className='container mt-5 card '>
            <h1 className='text-dark my-4 ms-3'>Plaza Santa Rosa</h1>
            <Table striped bordered hover>
            <thead>
                <tr>
                <th colSpan={5} className="text-center">Cotizacion</th>
                </tr>
                <tr>
                <th>#ID</th>
                <th>Nombre</th>
                <th>Valor</th>
                <th>Casa Comercial</th>
                </tr>
            </thead>
            <tbody>
                {productosConTotal.map((cotizacion) => (
                    <tr key={cotizacion.id}>
                        <td>{cotizacion.id}</td>
                        <td>{cotizacion.nombre}</td>
                        <td>{cotizacion.precio.join(', ')}</td>
                        <td>{cotizacion.tienda.join(', ')}</td>
                    </tr>
                    ))}
            </tbody>
            </Table>
        </div>
    </div>
  );
};

export default VerCotizacion;
