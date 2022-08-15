function onSignupSuccess(data, status, xhr) {
    window.location.replace('/account/login');
}
function onSignupBegin(xhr) {
    console.log(xhr)
    $('#signup-submit-button').attr('disabled', 'disabled');
}
function onSignupComplete(xhr, status) {
    $('#signup-submit-button').removeAttr('disabled');
}