import React, { Component } from 'react';
import './Blog.css';
import { Route,NavLink,Switch } from 'react-router-dom';
import Posts from './Posts/Posts';
import asyncComponent from '../../Hoc/asyncComponent';
// import NewPost from './NewPost/NewPost';

const AsyncComponent=asyncComponent(()=>{
    return import('./NewPost/NewPost');
});


class Blog extends Component {
    state={
        auth:true
    }
    render () {
        return (
            <div className="Blog">
                <header>
                    <nav>
                        <ul>
                            <li><NavLink
                             to="/posts/"
                              exact>Posts</NavLink></li>
                            <li><NavLink to={{
                                pathname:'/new-post',
                                hash:'#submit',
                                search:'?quick-submit=true'
                            }}>New Post</NavLink></li>
                        </ul>
                    </nav>
                </header>
               {/* <Route path="/" exact render={()=><h1>Home</h1>}/>
               <Route path="/" render={()=><h1>Home 2</h1>}/>
                 */}
                 
                <Switch>
                {this.state.auth?<Route path="/new-post"  component={AsyncComponent} />:null};
                <Route path="/posts" component={Posts} />
                <Route render= {()=><h1>Not Found.....</h1>}/>
                </Switch>
                {/* <section>
                    <FullPost id={this.state.selectedPostId}/>
                </section>
                <section>
                    <NewPost />
                </section> */}
            </div>
        );
    }
}

export default Blog;