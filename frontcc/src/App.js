import { BrowserRouter, Routes, Route } from "react-router-dom"
import Cotizacion from "./pages/Cotizacion"
import Landing from "./pages/Landing"
import MisCotizaciones from "./pages/MisCotizaciones"

function App() {
  return (
    <BrowserRouter>
      <Routes>
      <Route path="/" element={ <Landing/> } />
      <Route path="/cotizar" element={ <Cotizacion/> } />
      <Route path="/miscotizaciones" element={ <MisCotizaciones/> } />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
