import s from "./Avthorization.module.css"
import si from "../../components/main-components/css_components.module.css"
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
                <button className={si.button_blue}>Войти</button>
                <button className={si.button_blue}> <NavLink to="/Registr">Зарегестрироваться</NavLink></button>
            </div>
        </div>
    )
}

export default Authorizate
