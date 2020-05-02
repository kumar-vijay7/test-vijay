import React, { Component } from 'react';
import TableRow from './TableRow';


class App extends Component {
  constructor(props){
    super(props);
    this.state={
      fruitItems:[],
      input:'',
      isValid:false,
      newFruit:{
        fruitName:'',
        fruitQuantity:''
      }
    }
  }  

  addFruit=(e)=>{
    e.preventDefault();

    const newFruit=this.state.newFruit;
    if(newFruit.fruitName!==''){
      const items=[...this.state.fruitItems,newFruit];
      this.setState({
        fruitItems:items,
        newFruit:{
          fruitName:'',
          fruitQuantity:''
          
        },
        input:''
      })
    }
    

  }
  deleteFruit=fruitName=>{
    const filteredItems=this.state.fruitItems.filter(item=>
      item.fruitName!==fruitName);
      this.setState({
        fruitItems:filteredItems
      })
  }
  handleInput=(e)=>{
    let input=e.target.value;
    let fruitname=input.split('-')[0];
    let fquantity=input.split('-')[1];
      this.setState({
        input:e.target.value,
        newFruit:{
          fruitName:fruitname,
          fruitQuantity:fquantity
        }
      })
  }
  render() {
    return (
      <div className="container w-50 m-5 p-5 shadow ">
       <header>
         <form id="fruit-list" onSubmit={this.addFruit}>
           <div className="input-group w-50 container">
          <input type="text"  className="form-control w-25" placeholder="FruitName-Quantity" value={this.state.input} onChange={this.handleInput}></input>
        <span className="input-group-btn">
        <button type="submit" className="btn btn-primary">Submit</button></span>
        </div>
         </form>
          <p>{this.state.fruitItems.fruitName}</p>
          <table className="table table-bordered">
            <thead className="thead-dark">
              <tr>
                <th scope="col">Fruit Name</th>
                <th scope="col">Quantity</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              <TableRow fruitItems={this.state.fruitItems} deleteFruit={this.deleteFruit}/>
            </tbody>
          </table>
       </header>
      </div>
    );
  }
}

export default App;
