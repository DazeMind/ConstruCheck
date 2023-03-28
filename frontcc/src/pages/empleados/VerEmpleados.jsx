import {React, useState, useEffect} from 'react'
import Sidebar from '../../components/Sidebar'
import Table from 'react-bootstrap/Table'
import axios from 'axios'
import {useNavigate} from "react-router-dom"

//const endpoint = 'https://api.checkub.cl/api'
const endpoint = 'http://127.0.0.1:8000/api'

const VerEmpleados = () => {

  const [trabajadores, setTrabajadores] = useState( [] ) 

  useEffect ( ()=> {
    getAllTrabajadores()
  },[])

  const getAllTrabajadores = async () => {
    const response = await axios.get(`${endpoint}/trabajadores`) 
    setTrabajadores(response.data)
  }


  const empleados = [
      {
        "id": 1,
        "nombreCompleto": "Juan Pérez",
        "cargo": "Desarrollador de software",
        "fechaTerminoContrato": "2023-12-31",
        "tipoContrato": "A plazo fijo",
        "salarioBase": 1000000,
        "horarioTrabajo": "Lunes a viernes de 9:00 a 18:00",
        "telefono": "+56987654321",
        "email": "juan.perez@empresa.com",
        "fechaNacimiento": "1990-06-20",
        "nacionalidad": "Chilena",
        "rut": "19.123.456-7",
        "estadoCivil": "Soltero(a)",
        "cargas": false,
        "cuentaBancaria": "123456789",
        "afp": "Provida",
        "prevision": "Fonasa",
        "fechaIngreso": "2020-01-01",
        "antecedentesPenales": false,
        "certificaciones": ["Scrum Master", "Oracle Certified Professional"]
      },
      {
        "id": 2,
        "nombreCompleto": "María Gómez",
        "cargo": "Diseñadora gráfica",
        "fechaTerminoContrato": null,
        "tipoContrato": "Indefinido",
        "salarioBase": 800000,
        "horarioTrabajo": "Lunes a viernes de 9:00 a 18:00",
        "telefono": "+56998765432",
        "email": "maria.gomez@empresa.com",
        "fechaNacimiento": "1992-04-05",
        "nacionalidad": "Colombiana",
        "rut": "23.456.789-0",
        "estadoCivil": "Casado(a)",
        "cargas": true,
        "cuentaBancaria": "987654321",
        "afp": "Habitat",
        "prevision": "Isapre",
        "fechaIngreso": "2018-03-01",
        "antecedentesPenales": false,
        "certificaciones": ["Adobe Certified Expert", "UX Designer"]
      },
      {
        "id": 3,
        "nombreCompleto": "Pedro González",
        "cargo": "Analista financiero",
        "fechaTerminoContrato": null,
        "tipoContrato": "Indefinido",
        "salarioBase": 1200000,
        "horarioTrabajo": "Lunes a viernes de 9:00 a 18:00",
        "telefono": "+56987654321",
        "email": "pedro.gonzalez@empresa.com",
        "fechaNacimiento": "1985-12-15",
        "nacionalidad": "Chilena",
        "rut": "16.789.123-4",
        "estadoCivil": "Casado(a)",
        "cargas": true,
        "cuentaBancaria": "654321987",
        "afp": "Cuprum",
        "prevision": "Isapre",
        "fechaIngreso": "2015-07-01",
        "antecedentesPenales": true,
        "certificaciones": ["Chartered Financial Analyst"]
      },
  ];

  let navigate = useNavigate(); 
  const verEmpleado = () =>{ 
    let path = `ver/empleado/`; 
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
              <th>Id</th>
              <th>Nombre</th>
              <th>Cargo</th>
              <th>Fecha de término de contrato</th>
              <th>Tipo de contrato</th>
              <th>Salario</th>
              <th>Celular</th>
              <th>Correo</th>
              <th>Nacimiento</th>
              <th>Previsión</th>
              <th>Cargas</th>
              <th>AFP</th>
            </tr>
          </thead>
          <tbody>
            {empleados.map((empleado) => (
              <tr key={empleado.id} onClick={verEmpleado}>
                <td>{empleado.id}</td>
                <td>{empleado.nombreCompleto}</td>
                <td>{empleado.cargo}</td>
                <td>{empleado.fechaTerminoContrato || "N/A"}</td>
                <td>{empleado.tipoContrato}</td>
                <td>${empleado.salarioBase.toLocaleString()}</td>
                <td>{empleado.telefono}</td>
                <td>{empleado.email}</td>
                <td>{new Date(empleado.fechaNacimiento).toLocaleDateString()}</td>
                <td>{empleado.prevision}</td>
                <td>{empleado.cargas ? "Sí" : "No"}</td>
                <td>{empleado.afp}</td>
              </tr>
            ))}
          </tbody>
        </Table>
      </div>
    </div>
  );
};

export default VerEmpleados;
