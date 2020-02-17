@ModelType IEnumerable(Of UI.Product)

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>CatalogID</th>
        <th>Name</th>
        <th>Price</th>
    </tr>

@For Each Product In Model
    @<tr>
        <td>@Product.CatalogID</td>
        <td>@Product.Name</td>
         <td>@Product.Price</td>
         <td>
             @Html.ActionLink("Edit", "Edit", New With {.id = Product.CatalogID})
             @Html.ActionLink("Details", "Details", New With {.id = Product.CatalogID})
    
         </td>
    </tr>
Next

</table>
