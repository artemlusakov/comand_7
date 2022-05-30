import s from "./Avthorization.module.css"

function Authorizate (){
    return(
        <div className={s.Box}>
            <div className={s.Content}>
                <div className={s.compani}>
                    <div className={s.img}></div>
                    <h2>Teamscorde</h2>
                </div>

                <input type="email" placeholder={"user@gmail.com"}/>
                <input type="password" placeholder={"Введите пароль"}/>
                <button>Войти</button>
            </div>
        </div>
    )
}

export default Authorizate
