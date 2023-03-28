import React,{useState} from 'react'
import Sidebar from '../../components/Sidebar'
import axios from 'axios'
import Button from 'react-bootstrap/Button'
import Form from 'react-bootstrap/Form'

//const endpoint = 'https://api.checkub.cl/api/trabajador'
const endpoint = 'http://127.0.0.1:8000/api/trabajador'
const AgregarEmpleado = () => {

  function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
      return false;
    }
    return true;
  }

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
  const [ecivil,setECivil] = useState('')
  const [banco,setBanco] = useState('')
  const [tipoCuenta,setTipoCuenta] = useState('')
  const [NCuenta,setNCuenta] = useState('')
  const [celular,setCelular] = useState('')
  

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
      sueldo: sueldo,
      ecivil: ecivil,
      banco: banco,
      tipocuenta: tipoCuenta,
      NCuenta: NCuenta,
      celular: celular
      })
      window.location.reload(true);
      alert('Guardado con exito') //Cambiar por un modal
  }
  // "fechaTerminoContrato": null,
  // "tipoContrato": "Indefinido",
  // "horarioTrabajo": "Lunes a viernes de 9:00 a 18:00",
  // "fechaIngreso": "2015-07-01",
  // "antecedentesPenales": true,
  // "certificaciones": ["Chartered Financial Analyst"]
  return (
    <div className='main'>
        <Sidebar />

      <div className='container mt-5'>
        <h1 className='my-3'>Agregar empleado</h1>
        <div className='card px-3 py-3 bordeform '>
          <Form onSubmit={store} className='row text-dark'>
            <fieldset enabled>
              <Form.Group className="mb-3 col-12">
                <Form.Label htmlFor="nombre">Ingrese nombre completo</Form.Label>
                <Form.Control value={nombre} onChange={(e)=> setNombre(e.target.value)} id="nombre" placeholder="ej: juan Pedro Gomez Gonzales  ..." required/>
              </Form.Group>
              <div className='row'>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="rut">Ingrese rut </Form.Label>
                  <Form.Control value={rut} onChange={(e)=> setRut(e.target.value)} id="rut" onKeyPress={(e) => isNumberKey(e)} placeholder="ej: 13874577-5 ..." />
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
                  <Form.Label htmlFor="correo">Ingrese celular</Form.Label>
                  <Form.Control value={celular} onChange={(e)=> setCelular(e.target.value)} type="email" id="celular" placeholder="ej: 9 12345678 ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="afp">Seleccione AFP</Form.Label>
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
                  <Form.Label htmlFor="salud">Seleccione prevision</Form.Label>
                  <Form.Select id="salud" value={salud} onChange={(e)=> setSalud(e.target.value)}>
                    <option>-- Seleccione una opción --</option>
                    <option value="fonasa">Fonasa</option>
                    <option value="isapre">Isapre</option>
                  </Form.Select>
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="carga">Ingrese carga (cantidad)</Form.Label>
                  <Form.Control value={carga} onChange={(e)=> setCarga(e.target.value)} id="carga" onKeyPress={(e) => isNumberKey(e)} placeholder="ej: 0 ..." />
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
                  <Form.Label htmlFor="sueldo">Ingrese sueldo (mensual)</Form.Label>
                  <Form.Control value={sueldo} onChange={(e)=> setSueldo(e.target.value)} id="sueldo" onKeyPress={(e) => isNumberKey(e)} placeholder="ej: 450000 ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="salud">Seleccione estado civil</Form.Label>
                  <Form.Select id="ecivil" value={ecivil} onChange={(e)=> setECivil(e.target.value)}>
                    <option>-- Seleccione una opción --</option>
                    <option value="Soltero(a)">Soltero(a)</option>
                    <option value="Casado(a)">Casado(a)</option>
                    <option value="Viudo(a)">Viudo(a)</option>
                    <option value="Divorciado(a)">Divorciado(a)</option>
                  </Form.Select>
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                    <Form.Label htmlFor="salud">Seleccione banco</Form.Label>
                    <Form.Select id="banco" value={banco} onChange={(e)=> setBanco(e.target.value)}>
                      <option>-- Seleccione una opción --</option>
                      <option value="BancoEstado">BancoEstado</option>
                      <option value="Banco de Chile">Banco de Chile</option>
                      <option value="Banco Santander Chile">Banco Santander Chile</option>
                      <option value="Banco de Crédito e Inversiones (BCI)">Banco de Crédito e Inversiones (BCI)</option>
                      <option value="Banco BICE">Banco BICE</option>
                      <option value="Banco Internacional">Banco Internacional</option>
                      <option value="Banco Consorcio">Banco Consorcio</option>
                      <option value="Banco Itaú Chile">Banco Itaú Chile</option>
                      <option value="Banco Security">Banco Security</option>
                      <option value="Banco Falabella">Banco Falabella</option>
                      <option value="Banco Ripley">Banco Ripley</option>
                      <option value="Scotiabank Chile">Scotiabank Chile</option>
                      <option value="HSBC Bank (Chile)">HSBC Bank (Chile)</option>
                      <option value="Banco BBVA Chile">Banco BBVA Chile</option>
                      <option value="Banco del Desarrollo">Banco del Desarrollo</option>
                      <option value="Banco Penta">Banco Penta</option>
                      <option value="Coopeuch">Coopeuch</option>
                      <option value="Caja Los Andes">Caja Los Andes</option>
                      <option value="Banco Security Servicios Financieros">Banco Security Servicios Financieros</option>
                      <option value="Banco BTG Pactual Chile">Banco BTG Pactual Chile</option>
                      <option value="Banco Paris">Banco Paris</option>
                      <option value="Banco Consorcio Servicios Financieros">Banco Consorcio Servicios Financieros</option>
                      <option value="Banco Edwards Citi">Banco Edwards Citi</option>
                      <option value="Banco BCI Nova">Banco BCI Nova</option>
                      <option value="Banco Rabobank International Chile">Banco Rabobank International Chile</option>
                    </Form.Select>
                  </Form.Group>
                  <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="tipoCuenta">Seleccione tipo de cuenta</Form.Label>
                  <Form.Select id="tipoCuenta" value={tipoCuenta} onChange={(e)=> setTipoCuenta(e.target.value)}>
                    <option>-- Seleccione una opción --</option>
                    <option value="Cuenta vista">Cuenta vista</option>
                    <option value="Cuenta corriente">Cuenta corriente</option>
                    <option value="Cuenta de ahorro">Cuenta de ahorro</option>
                    <option value="Cuenta de inversión">Cuenta de inversión</option>
                    <option value="Cuenta de ahorro programado">Cuenta de ahorro programado</option>
                    <option value="Cuenta de ahorro para la vivienda">Cuenta de ahorro para la vivienda</option>
                    <option value="Cuenta de ahorro para la educación">Cuenta de ahorro para la educación</option>
                  </Form.Select>
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="NCuenta">Ingrese numero de cuenta</Form.Label>
                  <Form.Control value={NCuenta} onChange={(e)=> setNCuenta(e.target.value)} id="NCuenta" onKeyPress={(e) => isNumberKey(e)} placeholder="ej: 12345678 ..." />
                </Form.Group>
              </div>    
              <Button variant="primary" type="submit" className='my-3'>Agregar empleado</Button>
            </fieldset>
          </Form>
        </div>
      </div>
   
    </div>
  )
}
export default AgregarEmpleado