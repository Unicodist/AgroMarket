window.addEventListener('load',()=>{
   $.get('/api/productapi/getlatestproducts',function (data){
      for (let i = 0; i < data.length; i++) {
         $('#categorized_proudct_wrapper').append(renderCategorizedProductCard(data[i].categoryName));
         for (let j = 0; j < data[i].products.length; j++) {
            let holderid = data[i].categoryName+'_card_wrapper';
            document.getElementById(holderid).innerHTML+=renderMyProductItemCard(data[i].products[j].name,data[i].products[j].price,data[i].products[j].image);
         }
      }
   });
});