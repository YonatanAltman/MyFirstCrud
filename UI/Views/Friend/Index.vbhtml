@ModelType UI.FriendVM
@Code
    ViewData("Title") = "Index"
End Code

<h2>Friends!</h2>


<h1>@TempData("message")</h1>




<h1>@TempData("message").Name</h1>
