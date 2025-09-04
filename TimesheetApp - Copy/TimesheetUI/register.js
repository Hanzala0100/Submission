document.getElementById(`registerForm`).addEventListener(`submit`, async (e) => {
    e.preventDefault();

    const employee = {
        EmployeeName: document.getElementById(`name`).value,
        Email: document.getElementById(`email`).value,
        Department: document.getElementById(`department`).value,
        UserName: document.getElementById(`username`).value,
        PasswordHash: document.getElementById(`password`).value
    }

    fetch(`https://localhost:7131/api/Employee/AddEmployee`, {
        method: `Post`,
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(employee)
    })
        .then(response => {
            if (response.ok) {
                alert(`Registration successful!`);
            } else {
                alert(`Registration failed. Please try again.`);
            }
        })
        .catch(error => {
            console.error(`Error in registering employee`, error);
            alert(`An error occurred. Please try again`)
        });
});