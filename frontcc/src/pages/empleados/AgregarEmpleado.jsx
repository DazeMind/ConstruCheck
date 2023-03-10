import React,{useState} from 'react'
import Sidebar from '../../components/Sidebar'
// import {useNavigate} from "react-router-dom"
import axios from 'axios'
import Button from 'react-bootstrap/Button'
import Form from 'react-bootstrap/Form'

//const endpoint = 'https://api.checkub.cl/api/trabajador'
const endpoint = 'http://127.0.0.1:8000/api/trabajador'
const AgregarEmpleado = () => {

  const [nombre,setNombre] = useState('')
  const [rut,setRut] = useState('')
  const [nacimiento,setNacimiento] = useState('')
  const [correo,setCorreo] = useState('')
  const [afp,setAfp] = useState('')
  const [salud,setSalud] = useState('')
  const [carga,setCarga] = useState('')
  const [talla,setTalla] = useState('')
  const [cargo,setCargo] = useState('')
  const [sueldo,setSueldo] = useState('')

  // const navigate = useNavigate()

  const store = async (e) =>{
    e.preventDefault()
    await axios.post(endpoint, {
      nombre: nombre,
       rut: rut,
       nacimiento: nacimiento,
       correo: correo,
       afp: afp,
       salud: salud,
       carga: carga,
       talla: talla,
       cargo: cargo,
       sueldo: sueldo
      })
      window.location.reload(true);
      alert('Guardado con exito') //Cambiar por un modal
  }

  return (
    <div className='main'>
        <Sidebar />

      <div className='container mt-5'>
        <h1 className='my-3'>Agregar empleado</h1>
        <div className='card px-3 py-3 bordeform '>
          <Form onSubmit={store} className='row text-dark'>
            <fieldset enabled>
              <Form.Group className="mb-3 col-12">
                <Form.Label htmlFor="nombre">Ingrese nombre</Form.Label>
                <Form.Control value={nombre} onChange={(e)=> setNombre(e.target.value)} id="nombre" placeholder="ej: Jorge Marcelo Zepeda Cabrera ..." required/>
              </Form.Group>
              <div className='row'>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="rut">Ingrese rut</Form.Label>
                  <Form.Control value={rut} onChange={(e)=> setRut(e.target.value)} id="rut" placeholder="ej: 13874577-5 ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="nacimiento">Ingrese fecha de nacimiento</Form.Label>
                  <Form.Control value={nacimiento} onChange={(e)=> setNacimiento(e.target.value)} type='date' id="nacimiento" />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="correo">Ingrese correo</Form.Label>
                  <Form.Control value={correo} onChange={(e)=> setCorreo(e.target.value)} type="email" id="correo" placeholder="ej: correo@gmail.com ..." />
                </Form.Group>

                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="afp">Ingrese AFP</Form.Label>
                  <Form.Select id="afp" value={afp} onChange={(e)=> setAfp(e.target.value)}>
                    <option>-- Seleccione una opción --</option>
                    <option value="UNO">UNO</option>
                    <option value="CAPITAL">CAPITAL</option>
                    <option value="CUPRUM">CUPRUM</option>
                    <option value="HABITAT">HABITAT</option>
                    <option value="MODELO">MODELO</option>
                    <option value="PLANVITAL">PLANVITAL</option>
                    <option value="PROVIDA">PROVIDA</option>
                  </Form.Select>
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="salud">Ingrese Salud</Form.Label>
                  <Form.Select id="salud" value={salud} onChange={(e)=> setSalud(e.target.value)}>
                    <option>-- Seleccione una opción --</option>
                    <option value="fonasa">Fonasa</option>
                    <option value="isapre">Isapre</option>
                  </Form.Select>
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="carga">Ingrese carga (cantidad)</Form.Label>
                  <Form.Control value={carga} onChange={(e)=> setCarga(e.target.value)} id="carga" placeholder="ej: 0 ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="talla">Ingrese talla</Form.Label>
                  <Form.Control value={talla} onChange={(e)=> setTalla(e.target.value)} id="talla" placeholder="ej: 44 ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="cargo">Ingrese cargo</Form.Label>
                  <Form.Control value={cargo} onChange={(e)=> setCargo(e.target.value)} id="cargo" placeholder="ej: Jornal ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="sueldo">Ingrese sueldo</Form.Label>
                  <Form.Control value={sueldo} onChange={(e)=> setSueldo(e.target.value)} id="sueldo" placeholder="ej: 450000 ..." />
                </Form.Group>
              </div>
              <Button type="submit">Guardar</Button>
            </fieldset>
          </Form>
        </div>
      </div>

    </div>
  )
}

export default AgregarEmpleado