import { BrowserRouter, Routes, Route } from "react-router-dom"
import Cotizacion from "./pages/cotizacion/Cotizacion"
import Landing from "./pages/Landing"
import MisCotizaciones from "./pages/cotizacion/MisCotizaciones"
import AgregarEmpleado from "./pages/empleados/AgregarEmpleado"
import AgregarPagos from "./pages/pagos/AgregarPagos"

function App() {
  return (
    <BrowserRouter>
      <Routes>
      <Route path="/" element={ <Landing/> } />
      <Route path="/cotizar" element={ <Cotizacion/> } />
      <Route path="/miscotizaciones" element={ <MisCotizaciones/> } />
      <Route path="/agregar/empleado" element={ <AgregarEmpleado/> } />
      <Route path="/agregar/pago" element={ <AgregarPagos/> } />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
