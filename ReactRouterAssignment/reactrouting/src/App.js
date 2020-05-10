import React, { Component } from 'react';
import {Redirect,Route,Switch,NavLink} from 'react-router-dom';
import Courses from './containers/Courses/Courses';
import Course from './containers/Course/Course';
import Users from './containers/Users/Users';
import Error from './UnknownComponent/NotFound';
import '../node_modules/bootstrap/dist/css/bootstrap.css';

{/* <ol style={{textAlign: 'left'}}>
<li>Ques1:Add Routes to load "Users" and "Courses" on different pages (by entering a URL, without Links)</li>

<li>Ques2:Add a simple navigation with two links => One leading to "Users", one leading to "Courses"</li>

<li>Ques3:Make the courses in "Courses" clickable by adding a link and load the 
"Course" component in the place of "Courses" (without passing any data for now)</li>
<li>Ques4:Pass the course ID to the "Course" page and output it there</li>
<li>Ques5:Pass the course title to the "Course" page - pass it as a param or score bonus points by passing it as query params (you need to manually parse them though!)</li>
<li>Ques6:Load the "Course" component as a nested component of "Courses"</li>
<li>Ques7:Add a 404 error page and render it for any unknown routes</li>
<li>Qes8:Redirect requests to /all-courses to /courses (=> Your "Courses" page)</li>
</ol> */}
class App extends Component {
  render () {
    return (
      <div className="container-fluid p-0">
        <nav className='navbar navbar-expand-lg navbar-light bg-light'>
          <ul className='navbar-nav mr-auto' >
           {/* Ques2: */}
            <li className='nav-item'>
            <NavLink 
            to='/users'
            className='nav-link'>Users</NavLink></li>
            <li>
            <NavLink 
            to='/courses'
            className="nav-link">Courses</NavLink></li>
          </ul>
        </nav>
        <Switch>
          <Route path='/' exact component={Courses}/>          
          <Route path='/users' component={Users}/>
          {/*Ques3:*/}
          <Route path='/courses' exact component={Courses}/>

{/*       i wrote this routing for the Ques 4,5   
          <Route path='/courses/course/:courseId' component={Course}/> */}
         
         {/* Ques8: */}
          <Redirect to='/courses' from ='/all-courses'/>
          {/* Ques7: */}
          <Route component={Error}/>
          
        </Switch>
        </div>
    );
  }
}

export default App;
