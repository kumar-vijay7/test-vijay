var employee;
/*----Simple interest -------*/
function SimpleInterest(){
    var principle=prompt("Enter the Principle amout:");
    var rate=prompt("Enter the rate:");
    var time=prompt("Enter the time");
    var result=prompt("result", (principle*rate*time)/100)  ;
}
/*-------Simple interest--------------*/

/*-------area of circle start--------------*/
function Area(){
    var radius=prompt("Enter Radius:");
    var result=prompt("Area of Circle:",(3.14*radius*radius));
}
/*-------area of circle end--------------*/

/*----------palindrome check starts----------------*/
function Palindrome(){
    var string1=prompt("Enter the String:");
    string1=string1.toLowerCase();
    var size=string1.length;
    for(i=0;i<size;i++){
        if(string1[i]!==string1[size-1])
        {
            window.alert("Not a palindrome");
            break;
        }
        else{
            window.alert("Is a Palindrome");
            break;
        }
    }
}

/*------------------object copy---------------------------*/

function objectCopy(){
    var person={name:"vijay",Last:"Kumar"};
    var copyperson=Object.assign({},person);
    console.log("Person: "+person.name,person.Last);
    console.log("copyPerson: "+copyperson.name,copyperson.Last);
}
/*------------------object copy ends----------------------*/

function jsoncreate(){
    employee=[
        {name:'Vijay Kumar',Age:24,Salary:4000, Dob:'22-nov-1993'},
        {name:'Abhishek',Age:24, Salary:13000, Dob:'12-dec-1997'},
        {name:'Vishesh',Age:25,Salary:16000,Dob:'21-July-1996'},
        {name:'Sonal jha',Age:23,Salary:500,Dob:'5-aug-1998'}];
        
}
/*------------------palindrome check ends here--------------------------*/
function show(){
    jsondata=JSON.stringify(employee);
    document.getElementById("all").innerHTML=jsondata;
    
}

/*------------salary > 50000--------------*/
function salarygreater(){
    var result=employee.filter(function(item){
        return item.Salary>5000;
    })

    /*for(i=0;i<employee.length;i++){
        window.alert("hello")
        if(employee[i].Salary>5000){
            
          result+= employee[i].name+employee[i].Salary;
        }
        document.write
    }*/
    document.getElementById("less").innerHTML=JSON.stringify(result);
}

/*-------------------age group---------------*/
function agegroup(){
    var table;
    var emp = employee.reduce((r, a) => {
    r[a.Age] = [...r[a.Age] || [], a];
    return r;
    }, {});
    table = "<TABLE border=2px cellspacing=5><thead><tr><th>Group</th><th>NAME</th><th>AGE</th><th>SALARY</th><th>DOB</th></tr></thead>";
    for(var i in emp) 	{
        table+="<td rowspan="+(emp[i].length+1)+">"+i+"</td>";
        for( var e in emp[i])	{
             table+="<tr>";
             table+="<td>"+ emp[i][e].name+"</td>";
             table+="<td>"+ emp[i][e].Age+"</td>";
             table+="<td>"+ emp[i][e].Salary+"</td>";
             table+="<td>"+ emp[i][e].Dob+"</td>";
             table+="</tr>";
        }
    }
    table+="</TABLE>";
    document.getElementById("group").innerHTML = table;}

    /*-----incremetn------- */
    function increment() {
        var i;
        var table = "<TABLE border=2px cellspacing=5><thead><tr><th>NAME</th><th>AGE</th><th>SALARY</th><th>DOB</th></tr></thead>";
        for(i=0; i<employee.length;i++){
        if(employee[i].Salary<1000 && employee[i].Age>20) {
        employee[i].Salary *=5;
        table+="<tr>";
        table+="<td>"+ employee[i].name+"</td>";
        table+="<td>"+ employee[i].Age+"</td>";
        table+="<td>"+ employee[i].Salary+"</td>";
        table+="<td>"+ employee[i].Dob+"</td>";
        table+="</tr>";
        }
        }
        table+="</TABLE>";
        document.getElementById("increment").innerHTML = table;
        }
        
        