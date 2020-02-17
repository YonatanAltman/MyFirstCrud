@ModelType IEnumerable(Of UI.Product)

<style>
    img {
        height: 100px
    }

    tbody tr:hover {
        cursor: pointer;
        background-color: rgba(0, 255, 255,0.4);
    }
    a{
        text-decoration:none;
       
        font-size:large;
    }
</style>
<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <thead>


        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.CatalogID)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Name)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Price)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Image)
            </th>
            <th>

            </th>
        </tr>
    </thead>
    <tbody>

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
                    <img src="@product.Image" alt="@product.Name" />


                </td>
                <td>
                    @Html.ActionLink("😈", "Edit", New With {.id = product.CatalogID}) |
                    @Html.ActionLink("😨", "Delete", New With {.id = product.CatalogID})
                </td>
            </tr>


        Next
    </tbody>
</table>
