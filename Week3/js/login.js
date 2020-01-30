function validate() {
    
    document.getElementById('user-name-error').style.visibility = 'hidden'
    document.getElementById('Password-error').style.visibility = 'hidden'

    let firstName = document.getElementById('UserName').value
    let lastName = document.getElementById('Password').value

    if (firstName == '') {
        document.getElementById('user-name-error').style.visibility = 'visible'
    }

    if (lastName == '') {
        document.getElementById('Password-error').style.visibility = 'visible'
    }
}