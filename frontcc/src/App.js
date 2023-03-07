import { BrowserRouter, Routes, Route } from "react-router-dom"
import Cotizacion from "./pages/Cotizacion"
import Landing from "./pages/Landing"

function App() {
  return (
    <BrowserRouter>
      <Routes>
      <Route path="/" element={ <Landing/> } />
      <Route path="/cotizacion" element={ <Cotizacion/> } />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
