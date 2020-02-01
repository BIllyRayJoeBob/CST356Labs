var students = '{"Students":[{"ID":"918000001","email":"billyray.bob@school.edu"},{"ID":"918000002","email":"phong.nguyen@school.edu"},{"ID":"918000003","email":"lucas.cordova@school.edu"},{"ID":"918000004","email":"gerald.aden@school.edu"},{"ID":"918000005","email":"pramod.govindan@school.edu"}]}'


function getStudents(students)
{
    return JSON.parse(students);
}


function displayStudents(JSONstudents)
{
    //Accessing the inner JSON "Students" field
    JSONstudents = JSONstudents.Students;

    // Build an HTML string from the JSON elements.
    var studentTable = "";    
    for(i=0; i< JSONstudents.length; ++i)
    {
        var ID = JSONstudents[i].ID;
        var email = JSONstudents[i].email;
        studentTable += "<tr><th>"+ID+"</th><th>"+email+"</th>";
    }

    //Take the completed string and insert it into the HTML by overwriting the HTML id.
    document.getElementById("student-list").innerHTML = studentTable;
}

//call this in the HTML
function initializeStudentTable(){
    displayStudents(getStudents(students));
}


