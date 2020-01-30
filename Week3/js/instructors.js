var instructors = '{"Instructors":[{"FirstName":"Billy Ray","MiddleName":"Joe", "LastName":"Bob"},{"FirstName":"Phong","MiddleName":"", "LastName":"Nguyen"},{"FirstName":"Lucas","MiddleName":"", "LastName":"Cordova"},{"FirstName":"Gerald","MiddleName":"", "LastName":"Aden"},{"FirstName":"Pramod","MiddleName":"", "LastName":"Govindan"}]}'


function getTeachers(instructors)
{
    return JSON.parse(instructors);
}


function displayInstructors(JSONIntructors)
{
    //Accessing the inner JSON "Students" field
    JSONIntructors = JSONIntructors.Instructors;

    // Build and HTML string from the JSON file
    var teacherTable = "";
    for(i=0; i< JSONIntructors.length; ++i)
    {
        var first = JSONIntructors[i].FirstName;
        var middle = JSONIntructors[i].MiddleName;
        var last = JSONIntructors[i].LastName;

        teacherTable += "<tr><th>"+first+"</th><th>"+middle+"</th><th>"+last+"</th>";
    }

    //Take the completed string and insert it into the HTML by overwriting the HTML id.
    document.getElementById("teacher-list").innerHTML = teacherTable;
}


//call this in the HTML
function initializeIntructorTable(){
    displayInstructors(getTeachers(instructors));
}

