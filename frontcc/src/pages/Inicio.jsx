import React,{useState} from 'react'
import Sidebar from '../components/Sidebar'
import format from 'date-fns/format';
import OverlayTrigger from 'react-bootstrap/OverlayTrigger';
import Tooltip from 'react-bootstrap/Tooltip';
import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import Form from 'react-bootstrap/Form'


const Inicio = () => {

    const [lgShow, setLgShow] = useState(false);

    const renderTooltip = (props) => (
        <Tooltip id="button-tooltip" {...props}> Utilice el formulario diario para Actualizar el avance de su proyecto </Tooltip>
      );


    const fechaActual = format(new Date(), 'dd/MM/yy');
    const proyectoActivo = {
        id: 1,
        nombre: 'Plaza Santa rosa',
        dias: 20,
        semana: 3,
        valor: 1000,
        ganancia: 200,
        metrosActuales: 200,
        tareasPendientes: 2,
        tareasRealizada: 3,
        dinerorecibido: 300000,
        dinerogastado: 200000,
        trabajadores: 5,
        fechaInicio: '2023-03-01',
        fechaTermino: '2023-03-20',
    };

    const proyectosActivos = [proyectoActivo];

    return (
        <div className='main'>
            <Sidebar />
            <div className='container ms-5 mt-4'>
                <div className="p-4 mb-3 bg-body-tertiary rounded-3">
                    {proyectosActivos.map((proyecto) => (
                        <div key={proyecto.id}>
                            <div className="container-fluid ">
                                <div className="row justify-content-end">
                                    <div className="col-auto">
                                        <span className="fs-5 btn btn-outline-dark ">Día {proyecto.dias} {fechaActual} dias para finalizar ??</span>
                                    </div>
                                </div>
                                <h2 className="display-5 fw-bold ">{proyecto.nombre} (link ver mas)</h2>
                                <h4>Semana Nº: {proyecto.semana} del proyecto</h4>
                                <ul>estadistica de la semana
                                    <li>Metros avanzados: {proyecto.metrosActuales}</li>
                                    <li>Tareas realizadas: {proyecto.tareasRealizada}</li>
                                    <li>Tareas pendientes: {proyecto.tareasPendientes}</li>
                                    <li>Dinero recibido: {proyecto.dinerorecibido}</li>
                                    <li>Dinero gastado: {proyecto.dinerogastado}</li>
                                    <li>Trabajadores activo: {proyecto.trabajadores}</li>
                                </ul>
                                <p className="col-md-8 fs-4">
                                    Using a series of utilities, you can create this jumbotron, just like the one in previous versions of Bootstrap.
                                    Check out the examples below for how you can remix and restyle it to your liking.
                                </p>
                                <Button onClick={() => setLgShow(true)}>Finalizar día (formulario)</Button>
                                <Modal size="lg" show={lgShow} onHide={() => setLgShow(false)} aria-labelledby="dailyUpdate" >
                                    <Modal.Header closeButton>
                                    </Modal.Header>
                                    <Modal.Body>
                                        <Form>

                                        </Form>
                                    </Modal.Body>
                                </Modal>
  


                                <OverlayTrigger placement="right" delay={{ show: 100, hide: 400 }} overlay={renderTooltip}>
                                    <span class="ms-4 badge bg-info-subtle border border-info-subtle text-info-emphasis rounded-pill">Info</span>
                                </OverlayTrigger>
                            </div>
                        </div>
                    ))}
                </div>
                <div class="row align-items-md-stretch">
                    <div class="col-md-6">
                        <div class="h-100 p-5 text-bg-dark rounded-3">
                            <h2>Change the background</h2>
                            <h2>Estadisticas proyecto</h2>
                            <h2>Semana de proyecto</h2>
                            <h2>Finalizar dia formuilario</h2>
                            <h2>estadistica de la semana</h2>
                            <p>Swap the background-color utility and add a `.text-*` color utility to mix up the jumbotron look. Then, mix and match with additional component themes and more.</p>
                            <button class="btn btn-outline-light" type="button">Example button</button>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="h-100 p-5 bg-body-tertiary border rounded-3">
                            <h2>Add borders</h2>
                            <h2>Estadisticas Plata</h2>
                            <h2>Semana de proyecto</h2>
                            <h2>Finalizar dia formuilario</h2>
                            <h2>estadistica de la semana</h2>
                            <p>Or, keep it light and add a border for some added definition to the boundaries of your content. Be sure to look under the hood at the source HTML here as we've adjusted the alignment and sizing of both column's content for equal-height.</p>
                            <button class="btn btn-outline-secondary" type="button">Example button</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Inicio


