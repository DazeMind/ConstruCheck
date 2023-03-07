import React from 'react'
import { Link } from 'react-router-dom'

const Landing = () => {
  return (
    <div className='main'>
        <div className="container">
            <h1 className="title">Bienvenido a ConstruCheck</h1>
            <p className="info">¡Construcheck es la herramienta perfecta para los contratistas de construcción! Con Construcheck, podrás gestionar tus proyectos de construcción de manera fácil y eficiente, mantener un seguimiento claro y ordenado de los pagos de tus empleados y proveedores, y manejar la información de tus empleados y generar reportes detallados. Además, nuestro diseño intuitivo y amigable te permitirá acceder a todas las herramientas de manera sencilla y eficaz.</p>
            <p className="info"> ¡Únete hoy mismo a Construcheck y lleva tus proyectos de construcción al siguiente nivel!</p>
            <Link to="/register">
                <button className="btn" >¡Comienza ahora!</button>
            </Link>
        </div>  
    </div>
    )
}

export default Landing