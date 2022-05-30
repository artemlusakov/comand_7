import './App.css';
import Authorizate from "./components/Authorizate/Authorizate";
import Registr from "./components/Registraition/Registr";
import {Routes, Route} from "react-router-dom";
import NavBar from "./components/Nav_bar/Nav_bar";

function App() {
  return (
      <>
          <NavBar />

          <Routes>


              <Route expact path='/' element={<Authorizate/>}/>
              <Route path='/Registr' element={<Registr/>}/>

          </Routes>
      </>
  );
}

export default App;
