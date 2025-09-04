let token = '';

cookieStore.get('authToken')
    .then(cookie => {
        if (cookie && cookie.value) {
            token = cookie.value;
            loadTimesheets();
        } else {
            alert('Not logged in');
            window.location.href = 'login.html';
        }
    });

document.getElementById(`timesheetForm`).addEventListener(`submit`, async (e) => {

    e.preventDefault();

    const timesheet = {
        ProjectName: document.getElementById(`projectName`).value,
        TaskDate: document.getElementById(`taskDate`).value,
        HoursWorked: document.getElementById(`hours`).value,
        TaskDescription: document.getElementById(`description`).value,
    }
    fetch(`https://localhost:7131/api/Timesheet/AddTimesheet`, {
        method: `Post`,
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${token}`
        },
        body: JSON.stringify(timesheet)
    })
        .then(response => {
            if (response.ok) {
                alert(`Timesheet Added successfully`);
                document.getElementById(`timesheetForm`).reset();
                loadTimesheets();
            }
            else {
                alert(`Failed to add new timesheet. Please try again`);
            }
        })
        .catch(error => {
            console.error(`Error submitting timesheet: `, error);
            alert(`An error occurred. Please try again.`);
        });
});

function loadTimesheets() {
    fetch(`https://localhost:7131/api/Timesheet/GetTimesheetByEmployeeId`, {
        method: 'GET',
        headers: {
            'Authorization': `Bearer ${token}`
        }
    })
        .then(response => response.json())
        .then(data => {
            const tableBody = document.getElementById('timesheetBody');
            tableBody.innerHTML = '';

            data.forEach(entry => {
                tableBody.innerHTML += `
                <tr style="text-align: center;">
                    <td>${entry.employeeId}</td>
                    <td>${entry.projectName}</td>
                    <td>${new Date(entry.taskDate).toLocaleDateString()}</td>
                    <td>${entry.hoursWorked}</td>
                    <td>${entry.taskDescription}</td>
                    <td>
                        <button onclick="editEntry(${entry.timesheetId})" class="btn btn-sm btn-warning">Edit</button>
                        <button onclick="deleteEntry(${entry.timesheetId})" class="btn btn-sm btn-danger">Delete</button>
                    </td>
                </tr>
            `;
            });
        })
        .catch(error => {
            console.error('Error loading timesheets:', error);
        });
}
