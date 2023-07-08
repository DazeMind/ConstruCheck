import {React, useState, useEffect} from 'react'
import Sidebar from '../../components/Sidebar'
import Table from 'react-bootstrap/Table'
import axios from 'axios'
import {useNavigate} from "react-router-dom"

//const endpoint = 'https://api.checkub.cl/api'
const endpoint = 'http://www.apiconstrucheck.somee.com/api/worker/get'

const VerEmpleados = () => {

  const [trabajadores, setTrabajadores] = useState([]);

  useEffect(() => {
    getAllTrabajadores();
  }, []);

  const getAllTrabajadores = async () => {
    try {
      const response = await axios.get(`${endpoint}`);
      setTrabajadores(response.data);
    } catch (error) {
      console.error(error);
    }
  };

  let navigate = useNavigate(); 

  const verEmpleado = () => { 
    let path = `ver/empleado`; 
    navigate(path);
  }

  return (
    <div className='main'>
      <Sidebar />
      <div className='container mt-5 card '>
        <h1 className='text-dark my-4 ms-3'>Mis Empleado</h1>
        <Table striped bordered hover>
          <thead>
            <tr>
              <th>Nombre</th>
              <th>Rut</th>
              <th>Cumpleaños</th>
              <th>Correo</th>
              <th>AFP</th>
              <th>Prevision</th>
              <th>Cargas</th>
              <th>Talla Zapato</th>
              <th>Cargo</th>
              <th>Sueldo</th>
              <th>Ciclo de pago</th>
            </tr>
          </thead>
          <tbody>
            {trabajadores.map((empleado) => (
              <tr key={empleado.id} value={empleado.id} onClick={verEmpleado}>
                <td>{empleado.workerName}</td>
                <td>{empleado.rut}</td>
                <td>{empleado.dob}</td>
                <td>{empleado.email}</td>
                <td>{empleado.afp}</td>
                <td>{empleado.healthInsurance}</td>
                <td>{empleado.charges}</td>
                <td>{empleado.size}</td>
                <td>{empleado.job}</td>
                <td>{empleado.payment}</td>
                <td>{empleado.payFrequency}</td>                 
              </tr>
            ))}
          </tbody>
        </Table>
      </div>
    </div>
  );
};

export default VerEmpleados;
