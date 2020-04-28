
function validateForm() {
    let result = validatefName() & validatelName() & validateEmail() & validatePassword() & validateConfPassword();
    if (!result) {
        document.querySelector("#formFeedback").innerHTML = "There are errors. Please see above.";
        return false;
    } else {
        return true;
    }
}


function validatefName() {
    let fname = document.querySelector('#fName').value;
    let warning = '';

    if (!fname || fname.length < 2) {
        warning += 'Name is empty or too short.';
    } else if (name.length > 30) {
        warning += 'Name is too long.';
    }

    if (warning == '') {
        document.querySelector("#fNameLabel").classList.remove('red');
        document.querySelector("#fName").classList.remove('red-bg');
        document.querySelector("#fNameFeedback").innerHTML = '';
        return true;
    } else {
        document.querySelector("#fNameFeedback").innerHTML = warning;
        document.querySelector("#fNameLabel").classList.add('red');
        document.querySelector("#fName").classList.add('red-bg');
        return false;
    }

}

function validatelName() {
    let lname = document.querySelector("#lName").value;
    let warning = '';

    if (!lname || lname.length < 2) {
        warning += 'Name is empty of too short.';
    } else if (name.length > 30) {
        warning += 'Name is too long.';
    }

    if (warning == '') {
        document.querySelector("#lNameLabel").classList.remove('red');
        document.querySelector("#lName").classList.remove('red-bg');
        document.querySelector("#lNameFeedback").innerHTML = '';
        return true;
    } else {
        document.querySelector("#lNameFeedback").innerHTML = warning;
        document.querySelector("#lNameLabel").classList.add('red');
        document.querySelector("#lName").classList.add('red-bg');
        return false;
    }

}

function validateEmail(inputText) {
    let enteredEmail = document.querySelector("#Email").value;
    var mailformat = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
    let warning = '';

    if (!enteredEmail.match(mailformat)) {
        warning += 'Email not valid.';
    }

    if (warning == '') {
        document.querySelector("#emailLabel").classList.remove('red');
        document.querySelector("#Email").classList.remove('red-bg');
        document.querySelector("#EmailFeedback").innerHTML = '';
        return true;
    } else {
        document.querySelector("#EmailFeedback").innerHTML = warning;
        document.querySelector("#emailLabel").classList.add('red');
        document.querySelector("#Email").classList.add('red-bg');
        return false;
    }

}


function validatePassword() {

    console.log("Got to validate password.js. Yay.")

    let enteredPassword = document.querySelector("#pWord").value;
    var passwordPattern = /^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^\w\s]).{8,}$/;
    let warning = '';

    if (!enteredPassword.match(passwordPattern)) {
        warning += 'Password not valid.';
    }

    if (warning == '') {
        document.querySelector("#pWordLabel").classList.remove('red');
        document.querySelector("#pWord").classList.remove('red-bg');
        document.querySelector("#passwordFeedback").innerHTML = '';
        return true;
    } else {
        document.querySelector("#passwordFeedback").innerHTML = warning;
        document.querySelector("#pWordLabel").classList.add('red');
        document.querySelector("#pWord").classList.add('red-bg');
        return false;
    }

}


function validateConfPassword() {
    let enteredPassword2 = document.querySelector("#pWord").value;
    let enteredConfPassword = document.querySelector("#pWordConfirm").value;
    let warning = '';

    if (enteredPassword2 !== enteredConfPassword) {
        warning += 'Confirm-password does not match';
        return false;
    }
    else {
        return true;
    }
}



