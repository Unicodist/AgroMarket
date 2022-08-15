window.addEventListener('load',()=>{
   $.get('/api/productapi/getlatestproducts',function (data){
      console.log(data);
   });
});