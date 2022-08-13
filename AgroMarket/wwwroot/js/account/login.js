function onLoginSuccess(data, status, xhr) {
    window.location.replace(data.url);
}
function onLoginFailure(xhr, status, error) {
    Swal.fire({
        title:"We have a problem",
        text:"Something went wrong. Please contact your admin",
        icon:"error",
    });
}