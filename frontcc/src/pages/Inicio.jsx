import React,{useState} from 'react'
import Sidebar from '../components/Sidebar'
import format from 'date-fns/format'
import OverlayTrigger from 'react-bootstrap/OverlayTrigger'
import Tooltip from 'react-bootstrap/Tooltip'
import Button from 'react-bootstrap/Button'
import Modal from 'react-bootstrap/Modal'
import FormDaily from '../components/FormDaily'
import Form from 'react-bootstrap/Form'
import { LineChart, Line,BarChart, Bar, XAxis, YAxis, CartesianGrid, Legend } from 'recharts';



const Inicio = () => {

    const ingresos = [
        { name: 'Enero', ingreso: 1500000, gasto: 1000000 },
        { name: 'Febrero', ingreso: 1000000, gasto: 650000 },
        { name: 'Marzo', ingreso: 3000000, gasto: 1250000},
        { name: 'Abril', ingreso: 2200000, gasto: 2000000},
        { name: 'Mayo', ingreso: 1800000, gasto: 1000000},
        { name: 'Junio', ingreso: 1450000, gasto: 750000},
        { name: 'Julio', ingreso: 4500000, gasto: 2000000},
      ];
    

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
        valor: 10000000,
        ganancia: 200,
        metrosActuales: 200,
        metrosTotales: 1000,
        metrosRestantes: 800,
        tareasPendientes: 2,
        tareasRealizada: 3,
        dinerorecibido: 300000,
        dinerogastado: 200000,
        ingresoActual: 600000,
        gastoActual: 500000,
        pagosEmpleados: 300000,
        gastoMateriales: 200000,
        difRecibir: 9400000,
        trabajadores: 5,
        fechaInicio: '2023-03-01',
        fechaTermino: '2023-03-20',
    };

    
const avance = [
    {
      name: "Trabajador 1",
      metros: 1000,
      total: 20
    },
    {
      name: "Trabajador 2",
      metros: 1500,
      total: 30
    },
    {
      name: "Trabajador 3",
      metros: 2000,
      total: 40
    },
    {
      name: "Total 4",
      metros: 2500,
      total: 50
    }
  ];

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
                                <h3 className="display-5 fw-bold ">{proyecto.nombre}</h3>
                                <h5 className='my-3'>Semana Nº: {proyecto.semana} del proyecto</h5>
                                <div className='row'>
                                        <div className="col-6">
                                            <BarChart
                                            width={550}
                                            height={300}
                                            data={ingresos}
                                            margin={{top: 5, right: 30, left: 20, bottom: 5}}>
                                            <CartesianGrid strokeDasharray="3 3" />
                                            <XAxis dataKey="name" />
                                            <YAxis />
                                            <Tooltip />
                                            <Legend />
                                            <Bar dataKey="ingreso" fill="#8884d8" />
                                            <Bar dataKey="gasto" fill="#82ca9d" stackId="a" ingresos={ingresos.map(item => ({ ...item, gasto: item.gasto * -1 }))} />
                                            </BarChart>
                                        </div>
                                        <div className="col-6">
                                            <LineChart width={600} height={300} data={avance} margin={{ top: 5, right: 30, left: 20, bottom: 5 }}>
                                            <XAxis dataKey="name" />
                                            <YAxis />
                                            <CartesianGrid stroke="#ccc" strokeDasharray="5 5" />
                                            <Tooltip />
                                            <Legend />
                                            <Line type="monotone" dataKey="trabajadores" stroke="#8884d8" activeDot={{ r: 8 }} />
                                            <Line type="monotone" dataKey="metros" stroke="#82ca9d" />
                                            </LineChart>
                                        </div>
                                </div>
                                <div className='mt-4'>
                                <Button onClick={() => setLgShow(true)} className>Finalizar día (formulario)</Button>
                                <Modal size="lg" show={lgShow} onHide={() => setLgShow(false)} aria-labelledby="dailyUpdate" >
                                    <Modal.Header closeButton>
                                    </Modal.Header>
                                    <Modal.Body>
                                        <FormDaily/>
                                    </Modal.Body>
                                </Modal>
                                <OverlayTrigger placement="right" delay={{ show: 100, hide: 400 }} overlay={renderTooltip}>
                                    <span class="ms-4 badge bg-info-subtle border border-info-subtle text-info-emphasis rounded-pill">Info</span>
                                </OverlayTrigger>
                                </div>
                                
                            </div>
                        </div>
                    ))}
                </div>
                <div class="row align-items-md-stretch">
                    <div class="col-md-6">
                        <div class="h-100 p-5 text-bg-dark rounded-3">
                            <h2>Tareas proyecto</h2>
                            <Form.Group className="mb-3 col-4">
                                <Form.Label htmlFor="diasTrabajados">Dia asistido</Form.Label>
                                {['checkbox'].map((type) => (
                                    <div key={`inline-${type}`} className="mb-3">
                                    <Form.Check
                                        inline
                                        label="Recibir Material"
                                        name="group1"
                                        type={type}
                                        id={`inline-${type}-1`}
                                    />
                                    <Form.Check
                                        inline
                                        label="Preparar cancha"
                                        name="group1"
                                        type={type}
                                        id={`inline-${type}-2`}
                                    />
                                    <Form.Check
                                        inline
                                        label="Iniciar Radier"
                                        name="group1"
                                        type={type}
                                        id={`inline-${type}-3`}
                                    />
                                    <Form.Check
                                        inline
                                        label="Finalizar Radier"
                                        name="group1"
                                        type={type}
                                        id={`inline-${type}-4`}
                                    />
                                    </div>
                                ))}                
                            </Form.Group>
                            <h2>Semana de proyecto</h2>
                            <h2>Finalizar dia formuilario</h2>
                            <h2>estadistica de la semana</h2>
                            <p>Swap the background-color utility and add a `.text-*` color utility to mix up the jumbotron look. Then, mix and match with additional component themes and more.</p>
                            <button class="btn btn-outline-light" type="button">Ver Más</button>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="h-100 p-5 bg-body-tertiary border rounded-3">
                        <h2>Estadisticas economicas</h2>
                        {proyectosActivos.map((proyecto) => (
                            <div key={proyecto.id}>
                                <h3>Valor del proyecto: ${proyecto.valor}</h3>
                                <h3>Ingreso Actual: ${proyecto.ingresoActual} </h3>
                                <h3>Falta por recibir: ${proyecto.difRecibir} </h3>
                                <h3>Gasto Actual: ${proyecto.gastoActual}</h3>
                                <h3>Pago a empleados: ${proyecto.pagosEmpleados} </h3>
                                <h3>Gastos en materiales: ${proyecto.gastoMateriales} </h3>
                            </div>
                        ))}
                            <p>Or, keep it light and add a border for some added definition to the boundaries of your content. Be sure to look under the hood at the source HTML here as we've adjusted the alignment and sizing of both column's content for equal-height.</p>
                            <button class="btn btn-outline-secondary" type="button">Ver Más</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Inicio


