import React, { Component } from 'react';

class Course extends Component {
    state={
        courseTitle:''
    }
    

    componentDidMount(){
        this.parameterHandler();
    }

    componentDidUpdate(){
        this.parameterHandler();
    }

    parameterHandler=()=>{
        const query=new URLSearchParams(this.props.location.search);
        for(let param of query.entries()){
            if(this.state.courseTitle!==param[1]){
                this.setState({courseTitle:param[1]})
            }
        }
    }
    render () {
        console.log("in course");
        console.log(this.props);
        return (
            <div className="container border m-5">
                <h1>{this.state.courseTitle}</h1>
                <p>You selected the Course with ID :
                    <span className="text-danger pl-2   ">
                        {this.props.match.params.courseId}
                        </span></p>
            </div>
        );
    }
}

export default Course;