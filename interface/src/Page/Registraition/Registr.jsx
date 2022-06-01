import s from "./Register.module.css"
import btn from "../../components/main-components/Button.css";
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
                <button className={`${btn.but} ${btn.Blue} ${btn.size_normal}`}>Зарегестрироватся</button>
            </div>
        </div>
    )
}

export default Registr
