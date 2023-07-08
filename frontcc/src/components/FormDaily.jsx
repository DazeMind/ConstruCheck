import React,{useState} from 'react'
// import {useNavigate} from "react-router-dom"
import axios from 'axios'
import Button from 'react-bootstrap/Button'
import Form from 'react-bootstrap/Form'

//const endpoint = 'https://api.checkub.cl/api/trabajador'
const endpoint = 'http://127.0.0.1:8000/api/'
const FormDaily = () => {

  const [nombre,setNombre] = useState('Juan Andres Perez Ramirez')
  const [diasTrabajados,setDiasTrabajados] = useState('')
  const [tarea,setTarea] = useState('No hay tarea asignada')
  const [metrosAvanzados,setMetrosAvanzados] = useState('')
  const [montoPagar,setMontoPagar] = useState('')
  const [metodoPago,setMetodoPago] = useState('')
  const [tipoCuenta,setTipoCuenta] = useState('')

  // const navigate = useNavigate()

  const store = async (e) =>{
    e.preventDefault()
    await axios.post(endpoint, {
      nombre: nombre,
       diasTrabajados: diasTrabajados,
       tarea: tarea,
       metrosAvanzados: metrosAvanzados,
       montoPagar: montoPagar,
       metodoPago: metodoPago,
       tipoCuenta: tipoCuenta
      })
      window.location.reload(true);
      alert('Guardado con exito') //Cambiar por un modal
  }

  return (
        <div className='card px-3 py-3 bordeform '>
          <Form onSubmit={store} className='row text-dark'>
            <fieldset enabled>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="nombre">Trabajador</Form.Label>
                  <Form.Control value={nombre} onChange={(e)=> setNombre(e.target.value)} id="nombre" placeholder=" Juan Andres Perez Ramirez ..." disabled/>
                </Form.Group>
              <div className='row'>              
                <Form.Group className="mb-3 col-12">
                  <Form.Label htmlFor="diasTrabajados">Dia asistido</Form.Label>
                  {['radio'].map((type) => (
                    <div key={`inline-${type}`} className="mb-3">
                    <Form.Check
                        inline
                        label="Si"
                        name="group1"
                        type={type}
                        id={`inline-${type}-1`}
                    />
                    <Form.Check
                        inline
                        label="No"
                        name="group1"
                        type={type}
                        id={`inline-${type}-2`}
                    />
                    </div>
                ))}                
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="diasTrabajados">¿Hubo avance?</Form.Label>
                  {['radio'].map((type) => (
                    <div key={`inline-${type}`} className="mb-3">
                    <Form.Check
                        inline
                        label="Si"
                        name="group2"
                        type={type}
                        id={`inline-${type}-1`}
                    />
                    <Form.Check
                        inline
                        label="No"
                        name="group2"
                        type={type}
                        id={`inline-${type}-2`}
                    />
                    </div>
                ))}                
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="metrosAvanzados">Metros avanzados</Form.Label>
                  <Form.Control value={metrosAvanzados} onChange={(e)=> setMetrosAvanzados(e.target.value)} id="metrosAvanzados" placeholder=" Cantidad de metros avanzados el dia de hoy ..." />
                </Form.Group>
              </div>
              <Button type="submit">Guardar</Button>
            </fieldset>
          </Form>
        </div>
  )
}

export default FormDaily






