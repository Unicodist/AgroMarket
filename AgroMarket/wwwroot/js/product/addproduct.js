function onCategoryAddSuccess(data,status,xhr){
    window.location.replace(data.url);
}

function onCategoryAddFailure(xhr, status, error) {
    Swal.fire({
        title: "We have a problem",
        text: "Something went wrong. Please contact your admin",
        icon: "error",
    });
}
function onAddCategoryBegin(xhr) {
    console.log(xhr)
    $('#add-submit-button').attr('disabled', 'disabled');
}
function onAddCategoryComplete(xhr, status) {
    $('#add-submit-button').removeAttr('disabled');
}