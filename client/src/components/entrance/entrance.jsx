import s from "./entrance.module.css"

function Entrance ( )  {
    return (
        <div className={s.Box}>
            <div className={s.Content}>
                <div className={s.time}>
                    <div className={s.img}></div>
                    <h2>Teamscorde</h2>
                </div>

                <input className={s.input} type="email" placeholder={"user@gmail.com"}/>
                <input className={s.input} type="password" placeholder={"Введите пароль"}/>

                <button className={s.Btn}>Забыли пароль?</button>
                <div className={s.Box_Btn}>
                    <button className={s.Greane}>Войти</button>
                    <button >Зарегистрироваться</button>
                </div>

            </div>
        </div>
    )
}

export default Entrance
