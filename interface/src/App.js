import './App.css';
import Authorizate from "./Page/Authorizate/Authorizate";
import Registr from "./Page/Registraition/Registr";
import {Routes, Route} from "react-router-dom";
import NavBar from "./components/Nav_bar/Nav_bar";
import Content from "./components/Content_box/Content";
import Profil from "./Page/Profil/Profil";
import User from "./Page/UsersState/User";


function App() {
  return (
      <>
          <NavBar />

          <Routes>


              <Route expact path='/' element={<Authorizate/>}/>
              <Route path='/Registr' element={<Registr/>}/>
              <Route path='/Profil' element={<Profil/>}/>
              <Route path='/User' element={<User/>}/>

          </Routes>

          <Content/>
      </>
  );
}

export default App;
