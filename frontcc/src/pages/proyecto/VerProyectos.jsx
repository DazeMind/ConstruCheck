import React,{useEffect, useState} from 'react';
import Table from 'react-bootstrap/Table';
import Sidebar from '../../components/Sidebar';
import axios from 'axios';
//const endpoint = 'https://api.checkub.cl/api'
const endpoint = 'http://127.0.0.1:8000/api'

function VerProyectos() {

  const [proyectos, setProyectos] = useState( [] ) 

  useEffect ( ()=> {
    getAllProyectos()
  },[])

  const getAllProyectos = async () => {
    const response = await axios.get(`${endpoint}/trabajadores`) 
    setProyectos(response.data)
  }

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
                <td><a href="/ver/proyecto"><button className='btn btn-primary'>Ver Más</button></a></td>
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