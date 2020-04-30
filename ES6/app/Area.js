
let areaOfCircle=(radius)=>{
    return 3.14*radius*radius;
}

let areOfRectangle = (length,breadth) =>{
    return length * breadth;
}

let areaOfCylinder = (height,radius) =>{
    return 2*3.14*height + 2*3.14*radius*radius;
}


export {areaOfCircle,areaOfCylinder,areOfRectangle};