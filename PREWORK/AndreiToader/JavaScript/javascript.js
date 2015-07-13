function testIsNumber()
{
    var number = document.getElementById('number').value;
    if (isNaN(number) || number <1 || number > 10)
    {
        document.getElementById('whereToWrite').innerHTML = "Value is not a number";
    }
    else
    {
        document.getElementById("whereToWrite").innerHTML = "Value is a number";
    }
    
    /*var person = {
        firstName:"First name";
        lastName: "Last name";
        fullName:function () {
            return this.firstName + this.lastName;
        };
    };
    document.getElementById('whereToWrite').innerHTML = person.fullName();*/
}