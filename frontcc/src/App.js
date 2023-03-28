import { BrowserRouter, Routes, Route } from "react-router-dom"
import Cotizacion from "./pages/cotizacion/Cotizacion"
import Landing from "./pages/Landing"
import MisCotizaciones from "./pages/cotizacion/MisCotizaciones"
import AgregarEmpleado from "./pages/empleados/AgregarEmpleado"
import AgregarPagos from "./pages/pagos/AgregarPagos"
import AgregarProyecto from "./pages/proyecto/AgregarProyecto"
import VerCotizacion from "./pages/cotizacion/VerCotizacion"
import VerEmpleados from "./pages/empleados/VerEmpleados"
import VerPagos from "./pages/pagos/VerPagos"
import Inicio from "./pages/Inicio"

function App() {
  return (
    <BrowserRouter>
      <Routes>
      <Route path="/" element={ <Landing/> } />
      <Route path="/inicio" element={ <Inicio/> } />
      <Route path="/cotizar" element={ <Cotizacion/> } />
      <Route path="/miscotizaciones" element={ <MisCotizaciones/> } />
      <Route path="/agregar/empleado" element={ <AgregarEmpleado/> } />
      <Route path="/agregar/pago" element={ <AgregarPagos/> } />
      <Route path="/agregar/proyecto" element={ <AgregarProyecto/> } />
      <Route path="/ver/cotizacion" element={ <VerCotizacion/> } />
      <Route path="/ver/empleados" element={ <VerEmpleados/> } />
      <Route path="/ver/pagos" element={ <VerPagos/> } />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
