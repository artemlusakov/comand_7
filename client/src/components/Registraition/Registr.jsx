import s from "./Register.module.css"

function Registr (){
    return(
        <div className={s.Box}>
            <div className={s.Content}>
                <div className={s.time}>
                    <div className={s.img}></div>
                    <h2>Teamscorde</h2>
                </div>

                <input className={s.input} type="email" placeholder={"user@gmail.com"}/>
                <input className={s.input} type="password" placeholder={"Введите пароль"}/>
                <input className={s.input} type="password" placeholder={"Повторите пароль"}/>
                <button className={s.Btn}>Зарегестрироватся</button>
            </div>
        </div>
    )
}

export default Registr
