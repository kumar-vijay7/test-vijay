
import React from 'react';
import classes from './Navigationitems.module.css';
import NavigationItem from './NavigationItem/NavigationItem';

const navigationItems=()=>(

    <ul className={classes.NavigationItems}>
       
            <NavigationItem link='/' exact active>Buger Builder</NavigationItem>
            <NavigationItem link='/orders' >Orders</NavigationItem>
    </ul>
);

export default navigationItems;