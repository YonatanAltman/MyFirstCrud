@ModelType UI.FriendVM

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
    <h4>FriendVM</h4>

    <div>
        @Html.LabelFor(Function(m) m.Name)
        @Html.EditorFor(Function(m) m.Name)


    </div>

    <div>
        @Html.LabelFor(Function(m) m.Email)
        @Html.EditorFor(Function(m) m.Email)


    </div>

    <div>
        @Html.LabelFor(Function(m) m.Age)
        @Html.EditorFor(Function(m) m.Age)


    </div>

    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Create" class="btn btn-default" />
        </div>
    </div>
</div>
End Using


<form  ></form>

<div>
    @Html.ActionLink("Back to List", "Index")
</div>
<script src="~/Scripts/jquery-3.4.1.min.js"></script>
<script src="~/Scripts/jquery.validate.min.js"></script>
<script src="~/Scripts/jquery.validate.unobtrusive.min.js"></script>
