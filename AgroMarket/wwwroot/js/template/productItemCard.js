function renderProductItemCard(name,farmer,price,image){
    return `
<div class="row">
    <div class="col-lg-4">
         <div class="card" style="width:400px">
                <h6>${farmer}</h6>
            <img class="card-img-top" src="${image}" alt="Card image" style="width:100%">
            <div class="card-body">
                <div class="row">
                  <div><h5 class="card-title">${name} </h5></div>
                </div>
                <div class="row">
                    <h6>Rs.${price}</h6>
                </div>
              <button href="#" class="btn btn-primary">Add to Cart</button>
            </div>
          </div>
    </div>
</div>
`
}
