function renderMyProductItemCard(name,price, image,productid) {
    return ` <div class="row">
    <div class="card" style="width:400px">
    <img class="card-img-top" src="${image}" alt="Card image" style="width:100%">
    <div class="card-body"> 
        <div class="row">
          <div><h5 class="card-title">${name} </h5></div>
        </div>
        <div class="row">
            <h6>Rs.${price}</h6>
        </div>
      <a onclick="addToCart(${productid})" class="btn btn-primary">Add to Cart</a>
    </div>
  </div>
</div>`;
}