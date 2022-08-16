function onCategoryAddSuccess(data,status,xhr){
    Swal.fire({
        title: "Done!",
        text: "Product added successfully\nYou will be redirected to the page",
        icon: "Success",
        timer:3000
    });
}
function onProductAddSuccess(data, status, xhr) {
    window.location.replace('/home/index');
}
function onAddProductBegin(xhr) {
    $('#productadd-submit-button').attr('disabled', 'disabled');
}
function onAddProductComplete(xhr, status) {
    $('#productadd-submit-button').removeAttr('disabled');
}
function onCategoryAddFailure(xhr, status, error) {
    Swal.fire({
        title: "We have a problem",
        text: "Something went wrong. Please contact your admin",
        icon: "error",
    });
}
function onAddCategoryBegin(xhr) {
    $('#add-submit-button').attr('disabled', 'disabled');
}
function onAddCategoryComplete(xhr, status) {
    $('#add-submit-button').removeAttr('disabled');
}