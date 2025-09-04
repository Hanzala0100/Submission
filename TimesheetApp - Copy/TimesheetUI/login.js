document.getElementById(`loginForm`).addEventListener(`submit`, async (e) => {
    e.preventDefault();

    const loginCredentials = {
        EmployeeId: document.getElementById(`employeeId`).value,
        UserName: document.getElementById(`username`).value,
        Password: document.getElementById(`password`).value
    }

    fetch(`https://localhost:7131/api/Auth/Login`, {
        method: `Post`,
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(loginCredentials)
    }).then(response => response.json())
        .then(data => {
            console.log("data: ", data.response.token);
            if (data.response.token && data.response.token.trim() !== "") {
                // console.log("token: ", data.token);
                cookieStore.set('authToken', data.response.token);
                alert(`Login successful!`);
                window.location.href = 'timesheet.html';
            } else {
                alert(`Login failed. Please check your credentials and try again.`);
            }
        })
        .catch(error => {
            console.error(`Error in login`, error);
            alert(`An error occurred. Please try again`)
        });
});