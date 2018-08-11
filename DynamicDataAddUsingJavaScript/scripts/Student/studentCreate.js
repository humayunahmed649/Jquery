

$(document).ready(function () {
    $("#departmentDD").change(function() {
        var selectedDepartmentId = $("#departmentDD").val();
        var jsonData = { departmentId: selectedDepartmentId }
        $.ajax({
            url: "/Course/GetByDepartment",
            data: jsonData,
            type: "POST",
            success: function(response) {
                $("#courseDD").empty();
                var options = "<option> Select--------</option>";
                $.each(response, function(key, value) {
                    options += "<option value'" + value.Id + "'>" + value.Name + "</option>";
                });
                $("#courseDD").append(options);
            },
            error: function(response) {
                alert("Some thing went worng");
            }
        });
    });
    $("#addButton").click(function () {
        var semester = getSemesterFrom();
        var tableBody = $("#tblBody");

        var tr = "<tr>" + "<td>" + semester.DepartmentName + "</td><td>" + semester.CourseName + "</td>" + "<td>" + semester.SemesterName + "</td>" + "</tr>";
        tableBody.append(tr);
    });
});


function getSemesterFrom() {
 
    var departmentId = $("#departmentDD").val();
    var courseId = $("#courseDD").val();
    var departmentName = $("#departmentDD option:selected").text();
    var courseName = $("#courseDD option:selected").text();
    var semesterName = $("#semesterName").val();
    return {DepartmentId:departmentId,CourseId:courseId,DepartmentName:departmentName,CourseName:courseName,SemesterName:semesterName}   
}
