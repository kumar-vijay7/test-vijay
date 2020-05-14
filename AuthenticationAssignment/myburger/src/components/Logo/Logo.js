import React from 'react';
import classes from './Logo.module.css';
import Logo from '../../assets/images/BurgerApp-Logo.png';

const logo=(props)=>(
<div className={classes.Logo}>
    <img src={Logo} alt='myburger' />
</div>
);

export default logo;