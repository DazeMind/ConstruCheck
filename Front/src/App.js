import { BrowserRouter, Routes, Route } from "react-router-dom"
import Colaborador from './views/Colaborador'

function App() {
  return (
    <BrowserRouter>
      <Routes>
      <Route path="/" element={ <Colaborador/> } />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
