window.addEventListener('load',function (){
    $.get('/api/UserApi/getcurrentuser',function(data){
        console.log(data.name);
        $('#navbar_user_hyperlink').html(data.name);
    });
});
