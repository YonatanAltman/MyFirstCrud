@ModelType IEnumerable(Of UI.Product)


<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            Catalog ID
        </th>
        <th>
            Name
        </th>
        <th>
            Price
        </th>
        <th>

        </th>
    </tr>

    @For Each product In Model
        @<tr>
            <td>
                @product.CatalogID

            </td>
            <td>
                @product.Name

            </td>
            <td>
                @product.Price

            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = product.CatalogID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = product.CatalogID})
            </td>
        </tr>
    Next

</table>
