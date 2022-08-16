function renderCartTableRow(item, price, stock) {
    return `
<tr>
	<td data-th="Product">
		<div class="row">
									
			<div class="col-sm-10">
				<h4 class="nomargin">${item}</h4>
			</div>
		</div>
	</td>
    <td data-th="Stock">${stock}</td>
	<td data-th="Price">${price}</td>
	<td data-th="Quantity">
		<input type="number" class="form-control text-center" value="1">
	</td>
	<td data-th="Subtotal" class="text-center">1.99</td>
	<td class="actions" data-th="">
								
		<button class="btn btn-danger btn-sm"><i class="fa fa-trash-o"></i></button>								
	</td>
</tr>
`
}