import s from "./Avthorization.module.css"
import btn from "../../components/main-components/Button.css"
import Icon from "../../components/main-components/icon/icon";
import {NavLink} from "react-router-dom";

function Authorizate (){
    return(
        <div className={s.Box}>
            <div className={s.Content}>
                <div className={s.compani}>
                    <Icon/>
                    <h2>Teamscorde</h2>
                </div>

                <input type="email" placeholder={"user@gmail.com"}/>
                <input type="password" placeholder={"Введите пароль"}/>
                <button className={`${btn.but} ${btn.Blue}`}><NavLink to="/Vhod">Войти</NavLink></button>
                <button className={`${btn.but} ${btn.Blue}`}> <NavLink to="/Registr">Зарегестрироваться</NavLink></button>
            </div>
        </div>
    )
}

export default Authorizate
