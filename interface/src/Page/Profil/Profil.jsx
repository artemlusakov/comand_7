import React from 'react';
import s from "./Profil.module.css"

const Profil = () => {
    return (
        <div className={s.All_Component_Profil}>

            <div className={s.Info_Profil}>
                <div className={s.Profil_avatar_content}>
                    <div className={s.Profil_avatar}>
                        <img src="https://play-lh.googleusercontent.com/PCpXdqvUWfCW1mXhH1Y_98yBpgsWxuTSTofy3NGMo9yBTATDyzVkqU580bfSln50bFU" alt=""/>
                        <div className={s.Profil_name}>git</div>

                        <div className={s.info_user}>
                            <div>Возраст</div>
                            <div>Город</div>
                            <div>Пол</div>
                            <div></div>
                        </div>
                    </div>

                </div>

            </div>

            <div className={s.Content_Profil}>

            </div>
        </div>
    );
};

export default Profil;