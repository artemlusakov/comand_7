import s from "./Register.module.css"
import si from "../../components/main-components/css_components.module.css";
import Icon from "../../components/main-components/icon/icon";

function Registr (){
    return(
        <div className={s.Box}>
            <div className={s.Content}>
                <div className={s.compani}>
                    <Icon/>
                    Teamscorde
                </div>

                <input type="email" placeholder={"user@gmail.com"}/>
                <input type="password" placeholder={"Введите пароль"}/>
                <input type="password" placeholder={"Повторите пароль"}/>
                <button className={si.button_blue}>Зарегестрироватся</button>
            </div>
        </div>
    )
}

export default Registr
