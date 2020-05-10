import React, { Component } from 'react';
import {Route,Link} from 'react-router-dom';

import './Courses.css';
import Course from '../Course/Course';

class Courses extends Component {
    state = {
        courses: [
            { id: 1, title: 'Angular - The Complete Guide' },
            { id: 2, title: 'Vue - The Complete Guide' },
            { id: 3, title: 'PWA - The Complete Guide' }
        ]
    }

    render () {
        console.log(this.props);
        let courses=<p>Something went Wrong!</p>;
        if(!this.state.error){
            courses=this.state.courses.map( course => {
                return(
                    <Link to= {{
/* Ques4:*/             pathname : this.props.match.url + '/course/' + course.id,
/* Ques5:*/             search : '?title=' + course.title}}
                         key={course.id}
                         >
                         <article className="Course" >{course.title}</article>
                    </Link>
                ); 
            } );
        }
        return (
            <div className='container mt-4'>
                <h1>Amazing Udemy Courses</h1>
                <section className="Courses">
                    {courses}
                </section>
{/*Ques6:*/}    <Route path={this.props.match.url + '/course/:courseId' } exact component={Course}/>

            </div>
        );
    }
}

export default Courses;