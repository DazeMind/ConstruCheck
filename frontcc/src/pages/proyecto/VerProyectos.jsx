import Table from 'react-bootstrap/Table';
import Sidebar from '../../components/Sidebar';

function VerProyectos() {

  const proyectos = [
    {
      id: 1,
      nombre: 'Plaza Santa Rosa',
      fechaInicio: '2022-02-11',
      fechaTermino: '2023-02-11',
      metrosTotales: 3000,
      valorTotal: 12000000,
      interesado: 'Alcalde Juanito Perez',
      estado: 'En Proceso'
    },
    {
      id: 2,
      nombre: 'Edificio Los Pinos',
      fechaInicio: '2022-01-01',
      fechaTermino: '2023-01-01',
      metrosTotales: 5000,
      valorTotal: 20000000,
      interesado: 'Inversiones La Serena',
      estado: 'Finalizado'
    },
    {
      id: 3,
      nombre: 'Casa Valle del Sol',
      fechaInicio: '2022-03-01',
      fechaTermino: '2022-08-01',
      metrosTotales: 1500,
      valorTotal: 8000000,
      interesado: 'Familia González',
      estado: 'En Proceso'
    }
  ];

  return (
    <div className="main">
      <Sidebar />
      <div className=" container card my-5 ">
        <Table striped bordered hover className='mt-5'>
          <thead>
            <tr>
              <th></th>
              <th>#</th>
              <th>Nombre</th>
              <th>Fecha Inicio</th>
              <th>Fecha Termino</th>
              <th>Metros Totales</th>
              <th>Valor Total</th>
              <th>Interesado</th>
              <th>Estado</th>
            </tr>
          </thead>
          <tbody>
            {proyectos.map((proyecto) => (
              <tr key={proyecto.id}>
                <td><button className='btn btn-primary'>Ver Más</button></td>
                <td>{proyecto.id}</td>
                <td>{proyecto.nombre}</td>
                <td>{proyecto.fechaInicio}</td>
                <td>{proyecto.fechaTermino}</td>
                <td>{proyecto.metrosTotales}</td>
                <td>{proyecto.valorTotal}</td>
                <td>{proyecto.interesado}</td>
                <td>{proyecto.estado}</td>
              </tr>
            ))}
          </tbody>
        </Table>
      </div>
    </div>
  );
}

export default VerProyectos;