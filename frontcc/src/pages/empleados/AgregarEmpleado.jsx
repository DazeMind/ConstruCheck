import {React,useState} from 'react'
import Sidebar from '../../components/Sidebar'
import axios from 'axios'
import Button from 'react-bootstrap/Button'
import Form from 'react-bootstrap/Form'
import moment from 'moment'

//const endpoint = 'https://api.checkub.cl/api/empleados'
const endpoint = 'http://localhost:3500/api/empleados'
const AgregarEmpleado = () => {

  function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
      return false;
    }
    return true;
  }

  const [name,setName] = useState('')
  const [rut,setRut] = useState('')
  const [D_O_B,setBirthday] = useState('')
  const [email,setEmail] = useState('')
  const [afp,setAfp] = useState('')
  const [salud,setSalud] = useState('')
  const [pago,setPago] = useState('')
  const [carga,setCarga] = useState('')
  const [talla,setTalla] = useState('')
  const [cargo,setCargo] = useState('')
  const [sueldo,setSueldo] = useState('')
  // const [ecivil,setECivil] = useState('')
  const [banco,setBanco] = useState('')
  const [tipo_cuenta,setTipoCuenta] = useState('')
  const [n_cuenta,setNCuenta] = useState('')
  const [celular,setCelular] = useState('')
  

  // const navigate = useNavigate()

  const validateBirthday = () => {
    const minAge = 15
    const minDate = moment().subtract(minAge, 'years')
    return moment(D_O_B).isBefore(minDate, 'day')
  }

  const store = async (e) =>{
    e.preventDefault()
    if (!validateBirthday()) {
      alert('El empleado debe tener al menos 15 años de edad')
      return
    }
    try {
      await axios.post(endpoint, {
        Worker_name: name,
        rut: rut,
        D_O_B: D_O_B,
        email: email,
        afp: afp,
        salud: salud,
        carga: carga,
        talla: talla,
        cargo: cargo,
        sueldo: sueldo,
        pago: pago,
        // ecivil: ecivil,
        banco: banco,
        tipo_cuenta: tipo_cuenta,
        n_cuenta: n_cuenta,
        celular: celular
      })
      window.location.reload(true);
      alert('Guardado con exito') //Cambiar por un modal
    } catch (error) {
      alert('Hubo un error al registrar el empleado')
    }
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
                <Form.Label htmlFor="name">Ingrese nombre completo</Form.Label>
                <Form.Control value={name} onChange={(e)=> setName(e.target.value)} id="name" placeholder="ej: juan Pedro Gomez Gonzales  ..." required/>
              </Form.Group>
              <div className='row'>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="rut">Ingrese rut </Form.Label>
                  <Form.Control value={rut} onChange={(e)=> setRut(e.target.value)} id="rut" onKeyPress={(e) => isNumberKey(e)} placeholder="ej: 13874577-5 ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="D_O_B">Ingrese fecha de nacimiento</Form.Label>
                  <Form.Control value={D_O_B} onChange={(e)=> setBirthday(e.target.value)} type='date' id="D_O_B" />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="email">Ingrese correo</Form.Label>
                  <Form.Control value={email} onChange={(e)=> setEmail(e.target.value)} type="email" id="email" placeholder="ej: correo@gmail.com ..." />
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="correo">Ingrese celular</Form.Label>
                  <Form.Control value={celular} onChange={(e)=> setCelular(e.target.value)} type="text" id="celular" placeholder="ej: 9 12345678 ..." />
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
                  <Form.Label htmlFor="pago">Seleccione ciclo de pago</Form.Label>
                  <Form.Select id="pago" value={pago} onChange={(e)=> setPago(e.target.value)}>
                    <option>-- Seleccione una opción --</option>
                    <option value="Diario">Diario</option>
                    <option value="Semanal">Semanal</option>
                    <option value="Quincenal">Quincenal</option>
                    <option value="Mensual">Mensual</option>
                    <option value="Metros">------------------</option>
                    <option value="MetrosM">Mensual (Pago por metros realizados)</option>
                    <option value="MetrosQ">Quincenal (Pago por metros realizados)</option>
                    <option value="MetrosS">Semanal (Pago por metros realizados)</option>
                    <option value="MetrosD">Diario (Pago por metros realizados)</option>

                  </Form.Select>
                </Form.Group>
                <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="sueldo">Ingrese sueldo</Form.Label>
                  <Form.Control value={sueldo} onChange={(e)=> setSueldo(e.target.value)} id="sueldo" onKeyPress={(e) => isNumberKey(e)} placeholder="ej: 450000 ..." />
                </Form.Group>
                {/* <Form.Group className="mb-3 col-6">
                  <Form.Label htmlFor="salud">Seleccione estado civil</Form.Label>
                  <Form.Select id="ecivil" value={ecivil} onChange={(e)=> setECivil(e.target.value)}>
                    <option>-- Seleccione una opción --</option>
                    <option value="Soltero(a)">Soltero(a)</option>
                    <option value="Casado(a)">Casado(a)</option>
                    <option value="Viudo(a)">Viudo(a)</option>
                    <option value="Divorciado(a)">Divorciado(a)</option>
                  </Form.Select>
                </Form.Group> */}
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
                  <Form.Label htmlFor="tipo_cuenta">Seleccione tipo de cuenta</Form.Label>
                  <Form.Select id="tipo_cuenta" value={tipo_cuenta} onChange={(e)=> setTipoCuenta(e.target.value)}>
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
                  <Form.Label htmlFor="n_cuenta">Ingrese numero de cuenta</Form.Label>
                  <Form.Control value={n_cuenta} onChange={(e)=> setNCuenta(e.target.value)} id="n_cuenta" onKeyPress={(e) => isNumberKey(e)} placeholder="ej: 12345678 ..." />
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