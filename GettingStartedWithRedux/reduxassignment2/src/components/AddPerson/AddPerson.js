import React,{useState} from 'react';

import './AddPerson.css';

const addPerson = (props) => 
{   
    const [name,setName]=useState('');
    const [age,setAge]=useState('');


    return (
    <div className="AddPerson">
    <label>Name:</label><input type="text" placeholder="Name" onChange={(event=>setName(event.target.value))} value={name}/><br/>
    <label>Age:</label><input type="number" placeholder="Age" onChange={(event=>setAge(event.target.value))} value={age}/>
    <button onClick={()=>props.personAdded(name,age)}>Add Person</button>
    </div>
)
};

export default addPerson;