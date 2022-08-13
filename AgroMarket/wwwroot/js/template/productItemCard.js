function renderProductItemCard(name,farmer,price,image){
    return `
<style>
    .section-products .single-product:hover .part-1::before{
        background: url('${image}') no-repeat center;
    }
</style>
<div className="col-md-6 col-lg-4 col-xl-3">
        <div id="product-1" className="single-product">
            <div className="part-1">
                <span className="farmer-name">${farmer}</span>
                <ul>
                    <li><a href="#"><i className="fas fa-shopping-cart"></i></a></li>
                </ul>
            </div>
            <div className="part-2">
                <h3 className="product-title">${name}</h3>

                <h4 className="product-price">Rs.${price}</h4>
            </div>
        </div>
    </div>`
}