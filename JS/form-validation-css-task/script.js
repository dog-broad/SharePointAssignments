document.getElementById("contactusForm").addEventListener("submit", function (e) {
    e.preventDefault();

    let form = e.target;
    let requiredFields = ["idTxt", "fnameTxt", "lnameTxt", "depTxt", "startDateTxt", "salaryTxt", "pwd", "cpwd"];
    let allFilled = true;

    requiredFields.forEach(field => {
        if (form[field].value.trim() === "") {
            alert(`Please fill in the ${field} field.`);
            allFilled = false;
        }
    });

    if (!allFilled) return;

    if (form.pwd.value !== form.cpwd.value) {
        alert("Passwords do not match!");
        return;
    }

    let output = document.getElementById("output");
    output.innerHTML = `
        <h3>Submitted Data</h3>
        <p><strong>Emp ID:</strong> ${form.idTxt.value}</p>
        <p><strong>First Name:</strong> ${form.fnameTxt.value}</p>
        <p><strong>Last Name:</strong> ${form.lnameTxt.value}</p>
        <p><strong>Dept No:</strong> ${form.depTxt.value}</p>
        <p><strong>Start Date:</strong> ${form.startDateTxt.value}</p>
        <p><strong>Salary:</strong> ${form.salaryTxt.value}</p>
        <p><strong>Gender:</strong> ${form.gender.value}</p>
        <p><strong>Field:</strong> ${[...form.querySelectorAll('input[name="vehicle"]:checked')].map(e => e.value)}</p>
        <p><strong>Comment:</strong> ${form.queryText.value}</p>
        <p><strong>Selected Car:</strong> ${form.cars.value}</p>
    `;
});
