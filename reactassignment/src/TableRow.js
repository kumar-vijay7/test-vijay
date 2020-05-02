import React from 'react';
function  TableRow(props){
    const items=props.fruitItems;
    const tablerows=items.map(item=>{
        return (
            
            <tr>
                <td>{item.fruitName}</td>
                <td>{item.fruitQuantity}</td>
                <td className="text-center"><button className="btn btn-danger" onClick={()=>{
                    props.deleteFruit(item.fruitName);
                }}>Delete</button></td>
            </tr>
        );
    })
    return tablerows
}

export default TableRow;