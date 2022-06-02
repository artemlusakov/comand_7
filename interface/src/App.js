import './App.css';
import Authorizate from "./Page/Authorizate/Authorizate";
import Registr from "./Page/Registraition/Registr";
import {Routes, Route} from "react-router-dom";
import NavBar from "./components/Nav_bar/Nav_bar";
import Content from "./components/Content_box/Content";


function App() {
  return (
      <>
          <NavBar />

          <Routes>


              <Route expact path='/' element={<Authorizate/>}/>
              <Route path='/Registr' element={<Registr/>}/>


          </Routes>

          <Content/>
      </>
  );
}

export default App;
