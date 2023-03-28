import React,{useState} from 'react'
import Sidebar from '../../components/Sidebar'
// import {useNavigate} from "react-router-dom"
import axios from 'axios'
import Button from 'react-bootstrap/Button'
import Form from 'react-bootstrap/Form'

//const endpoint = 'https://api.checkub.cl/api/trabajador'
const endpoint = 'http://127.0.0.1:8000/api/trabajador'
const AgregarProyecto = () => {

  const [nombre,setNombre] = useState('')
  const [valorProyecto,setValorProyecto] = useState('')
  const [fechaInicio,setFechaInicio] = useState('')
  const [fechaTermino,setFechaTermino] = useState('')
  const [metros,setMetros] = useState('')
  const [ubicacion,setUbicacion] = useState('')
  const [correo,setCorreo] = useState('')

  // const navigate = useNavigate()

  const store = async (e) =>{
    e.preventDefault()
    await axios.post(endpoint, {
      nombre: nombre,
      valorProyecto: valorProyecto,
      fechaInicio: fechaInicio,
      fechaTermino: fechaTermino,
      metros: metros,
      ubicacion: ubicacion,
      correo: correo
      })
      window.location.reload(true);
      alert('Guardado con exito') //Cambiar por un modal
  }

  return (
    <div className='main'>
        <Sidebar />

      <div className='container mt-5'>
        <h1 className='my-3'>Agregar proyecto</h1>
        <div className='card px-3 py-3 bordeform '>
          <Form onSubmit={store} className='row text-dark'>
            <fieldset enabled>
              <Form.Group className="mb-3 col-12">
                <Form.Label htmlFor="nombre">Ingrese nombre del proyecto</Form.Label>
                <Form.Control value={nombre} onChange={(e)=> setNombre(e.target.value)} id="nombre" placeholder="ej: Estadio Nacional Julio Martínez Prádanos ..." required/>
              </Form.Group>
              <div className='row'>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="ubicacion">Lugar del proyecto</Form.Label>
                  <Form.Control value={ubicacion} onChange={(e)=> setUbicacion(e.target.value)} id="ubicacion" placeholder="ej: Av. Grecia & Avenida Marathon, Ñuñoa ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="correo">Correo del interesado</Form.Label>
                  <Form.Control value={correo} onChange={(e)=> setCorreo(e.target.value)} id="correo" placeholder="ej: alcalde@gmail.com ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="fechaInicio">Ingrese fecha de inicio</Form.Label>
                  <Form.Control value={fechaInicio} onChange={(e)=> setFechaInicio(e.target.value)} type='date' id="fechaInicio" />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="fechaTermino">Ingrese fecha de termino</Form.Label>
                  <Form.Control value={fechaTermino} onChange={(e)=> setFechaTermino(e.target.value)} type='date' id="fechaTermino" />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="valorProyecto">Valor del proyecto</Form.Label>
                  <Form.Control value={valorProyecto} onChange={(e)=> setValorProyecto(e.target.value)} id="valorProyecto" placeholder="ej: 20.000.000 ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="metros">Ingrese metros²</Form.Label>
                  <Form.Control value={metros} onChange={(e)=> setMetros(e.target.value)} type="email" id="metros" placeholder="ej: 1200 ..." />
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

export default AgregarProyecto