function renderCategorizedProductCard(categoryName){
    return `<section className="section-products">
        <div className="container" id="${categoryName}_card_wrapper">
            <div className="row justify-content-center text-center">
                <div className="col-md-8 col-lg-6">
                    <div className="header">
                        <h2 className="text-uppercase">${categoryName}</h2>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <hr/>`;
}