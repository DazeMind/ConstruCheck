import React,{useState} from 'react'
import Sidebar from '../../components/Sidebar'
// import {useNavigate} from "react-router-dom"
import axios from 'axios'
import Button from 'react-bootstrap/Button'
import Form from 'react-bootstrap/Form'

//const endpoint = 'https://api.checkub.cl/api/trabajador'
const endpoint = 'http://127.0.0.1:8000/api/'
const AgregarPagos = () => {

  const [nombre,setNombre] = useState('')
  const [diasTrabajados,setDiasTrabajados] = useState('')
  const [montoSugerido,setMontoSugerido] = useState('')
  const [montoPagar,setMontoPagar] = useState('')
  const [metodoPago,setMetodoPago] = useState('')
  const [tipoCuenta,setTipoCuenta] = useState('')

  // const navigate = useNavigate()

  const store = async (e) =>{
    e.preventDefault()
    await axios.post(endpoint, {
      nombre: nombre,
       diasTrabajados: diasTrabajados,
       montoSugerido: montoSugerido,
       montoPagar: montoPagar,
       metodoPago: metodoPago,
       tipoCuenta: tipoCuenta
      })
      window.location.reload(true);
      alert('Guardado con exito') //Cambiar por un modal
  }

  return (
    <div className='main'>
        <Sidebar />

      <div className='container mt-5'>
        <h1 className='my-3'>Agregar pago</h1>
        <div className='card px-3 py-3 bordeform '>
          <Form onSubmit={store} className='row text-dark'>
            <fieldset enabled>
            <Form.Group className="mb-3 col-12">
                  <Form.Label htmlFor="afp">Seleccione un trabajador</Form.Label>
                  <Form.Select value={nombre} onChange={(e)=> setNombre(e.target.value)} id="nombre" placeholder="ej: Jorge Marcelo Zepeda Cabrera ..." required>
                    <option>-- Seleccione una trabajador --</option>
                    <option value="UNO">ejemplo1</option>
                    <option value="CAPITAL">ejemplo2</option>
                    <option value="CUPRUM">ejemplo3</option>
                    <option value="HABITAT">ejemplo4</option>
                    <option value="MODELO">ejemplo6</option>
                  </Form.Select>
                </Form.Group>
              <div className='row'>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="diasTrabajados">Dias Trabajados</Form.Label>
                  <Form.Control value={diasTrabajados} onChange={(e)=> setDiasTrabajados(e.target.value)} type='text' placeholder='30' id="diasTrabajados" />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="montoSugerido">Monto a sugerido</Form.Label>
                  <Form.Control value={montoSugerido} onChange={(e)=> setMontoSugerido(e.target.value)} id="montoSugerido" placeholder=" valor del dia o cargo x dias trabajados ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="montoPagar">Ingrese monto a pagar</Form.Label>
                  <Form.Control value={montoPagar} onChange={(e)=> setMontoPagar(e.target.value)} id="montoPagar" placeholder="ej: monto que transferira ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="metodoPago">Seleccione metodo de pago</Form.Label>
                  <Form.Select id="metodoPago" value={metodoPago} onChange={(e)=> setMetodoPago(e.target.value)}>
                    <option>-- Seleccione una opción --</option>
                    <option value="fonasa">Transferencia</option>
                    <option value="isapre">Efectivo</option>
                  </Form.Select>
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="tipoCuenta">*si es transferencia* Seleccione cuenta</Form.Label>
                  <Form.Select id="tipoCuenta" value={tipoCuenta} onChange={(e)=> setTipoCuenta(e.target.value)}>
                    <option>-- Seleccione una opción --</option>
                    <option value="fonasa">Cuenta Rut:nombre empleado</option>
                    <option value="isapre">Cuenta Corriente: nombre empleado</option>
                    <option value="isapre">Cuenta Corriente2: nombre empleado</option>
                  </Form.Select>
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

export default AgregarPagos