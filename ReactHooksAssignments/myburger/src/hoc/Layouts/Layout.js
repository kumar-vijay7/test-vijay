import React,{useState} from 'react';
import {connect} from 'react-redux';
import Aux from '../Auxx/Auxx';
import './Layout.css';
import Toolbar from '../../components/Navigation/ToolBar/Toolbar';
import SideDrawer from '../../components/Navigation/SideDrawer/SideDrawer';

const layout = props =>{

    const [sideDrawerIsVisible,setSideDrawerIsVisible]=useState(false);
 const sideDrawerCloseHandler=()=>{
    setSideDrawerIsVisible(false);
 }

const  sideDrawerToggleHandler=()=>{
     setSideDrawerIsVisible(!sideDrawerIsVisible);
 }
return(
    <Aux>
        <Toolbar  
        isAuth={props.isAuthenticated}
        drawerToggleClicked={sideDrawerToggleHandler}/>
        <SideDrawer 
                isAuth={props.isAuthenticated}
        open={sideDrawerIsVisible} 
        closed={sideDrawerCloseHandler}/>
        <main className='Content' >
        {props.children}
        </main>
    </Aux>
    );
}

const mapStateTOProps=state=>{
    return{
        isAuthenticated:state.auth.token !==null
    };
};

export default connect(mapStateTOProps)(layout);