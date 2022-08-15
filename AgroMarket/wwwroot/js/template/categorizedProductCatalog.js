function renderCategorizedProductCard(categoryname,carddetails){
    return
    `<section className="section-products">
        <div className="container">
            <div className="row justify-content-center text-center">
                <div className="col-md-8 col-lg-6">
                    <div className="header">
                        <h2 className="text-uppercase">${categoryname}</h2>
                    </div>
                </div>
            </div>
            <div className="row">
                <div id="crops_card_holder" className="col-md-6 col-lg-4 col-xl-3">
                    <div class="row">
                        <div class="card" style="width:400px">
                        <img class="card-img-top" src="${image}" alt="Card image" style="width:100%">
                        <div class="card-body">
                            <div class="row">
                              <div><h5 class="card-title">${name} </h5></div>
                            </div>
                            <div class="row">
                                <h6>Rs.${price}</h6>
                            </div>
                          <a href="#" class="btn btn-primary">Add to Cart</a>
                        </div>
                      </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <hr/>`
}