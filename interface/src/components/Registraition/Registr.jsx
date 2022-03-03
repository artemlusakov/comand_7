import s from "./Register.module.css"

function Registr (){
    return(
        <div className={s.Box}>
            <div className={s.Content}>
                <div className={s.compani}>
                    <div className={s.img}></div>
                    <h2>Teamscorde</h2>
                </div>

                <input type="email" placeholder={"user@gmail.com"}/>
                <input type="password" placeholder={"Введите пароль"}/>
                <input type="password" placeholder={"Повторите пароль"}/>
                <button>Зарегестрироватся</button>
            </div>
        </div>
    )
}

export default Registr
