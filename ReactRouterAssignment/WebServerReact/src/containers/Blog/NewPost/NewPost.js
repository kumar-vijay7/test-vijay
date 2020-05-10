import React, { Component } from 'react';
import {Redirect} from 'react-router-dom';
import './NewPost.css';
import Axios from 'axios';

class NewPost extends Component {
    state = {
        title: '',
        content: '',
        author: 'Max',
        submitted:false
    }

    componentDidMount(){
        console.log(this.props);
    }

    postDataHandler=()=>{
        const postData={
            title:this.state.title,
            body:this.state.content,
            author:this.state.author
        };
        Axios.post('/posts',postData)
             .then(reponse=>{
                 console.log(reponse);
                 this.setState({submitted:true});
                 alert("Sucessfully Inserted..");

             })
    }

    render () {
        let redirect=null;
        if(this.state.submitted){
            redirect=<Redirect to="/posts"/>;
        }
        return (
            <div className="NewPost">
                {redirect}
                <h1>Add a Post</h1>
                <label>Title</label>
                <input type="text" value={this.state.title} onChange={(event) => this.setState({title: event.target.value})} />
                <label>Content</label>
                <textarea rows="4" value={this.state.content} onChange={(event) => this.setState({content: event.target.value})} />
                <label>Author</label>
                <select value={this.state.author} onChange={(event) => this.setState({author: event.target.value})}>
                    <option value="Abhishek">Abhishek</option>
                    <option value="Vijay">Vijay Kumar</option>
                </select>
                <button onClick={this.postDataHandler}>Add Post</button>
            </div>
        );
    }
}

export default NewPost;