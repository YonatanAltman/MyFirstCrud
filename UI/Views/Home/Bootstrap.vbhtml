
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Bootstrap</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
   
    <style>
        .main {
         
           height: 80vh;
        }
        .box{
            border: solid 1px darkblue;
            height:30px;
            float:left;
        }
        #progress{
            transition: width ease-in-out 0.7s;
        }
    </style>
</head>
<body>
    <div>
        <div class="container main">
            <h1>Bootstrap</h1>
            <div class="box col-12">
                BOX
            </div>
            <div class="box col-lg-4 col-md-6">
                BOX
            </div>
            <div class="box col-lg-4 col-md-12">
                BOX
            </div>



            <table class="table table-bordered table-hover">
                <thead class="table-dark">
                    <tr>
                        <th>Firstname</th>
                        <th>Lastname</th>
                        <th>Email</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>John</td>
                        <td>ddddd<span class="badge badge-danger">6</span></td>
                        <td>john@example.com</td>
                    </tr>
                    <tr>
                        <td>Mary</td>
                        <td><span class="badge badge-danger">Danger</span></td>
                        <td>mary@example.com</td>
                    </tr>
                    <tr>
                        <td>July</td>
                        <td><span class="badge badge-danger">Danger</span></td>
                        <td>july@example.com</td>
                    </tr>
                </tbody>
            </table>

            <div class="alert alert-success">
                <strong>Success!</strong> This alert box could indicate a successful or positive action.
            </div>

        </div>
        <button class="btn-danger">Click</button>

    </div>

    <div class="progress">
        <div class="progress-bar" id="progress" style="width:70%"></div>
    </div>
    <script>
        let percent = 101;
        setInterval(() => {
            console.log(percent);
            percent--;
            document.getElementById('progress').style.width = percent + '%';
        },200)


    </script>


    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

</body>
</html>
