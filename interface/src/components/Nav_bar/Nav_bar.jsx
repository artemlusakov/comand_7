import React from 'react';
import  {NavLink} from 'react-router-dom'
import s from "./Nav_bar.module.css"

const NavBar = () => {
    return (
        <div className={s.All_content_nav}>
            <div className={s.Logo}>
                Teamscord
            </div>

            <div className={s.Nav}>
            <div className={s.Navigate}>
                <NavLink to="/News">News</NavLink>
                <NavLink to="/Home">Home</NavLink>
                <NavLink to="/Home">Home</NavLink>
                <NavLink to="/Home">Home</NavLink>
            </div>

            <button className={s.Profil}></button>

            </div>
        </div>
    );
};

export default NavBar;