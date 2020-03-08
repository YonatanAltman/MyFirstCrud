<link href="~/Content/Home/home.css" rel="stylesheet" />

<div class="card">
    <div class="card-body col-12">
        <h5 class="card-title">Search Pets</h5>
        <form action="/"  id="form">

            <div class="form-group col-lg-3 col-md-4">
                <label for="from">From Price</label>
                <input type="number" name="fromPrice" class="form-control" value="0" />
            </div>

            <div class="form-group col-lg-3 col-md-4">
                <label for="from">To Price</label>
                <input type="number" name="toPrice" class="form-control" value="100" />
            </div>

       

            <button class="btn-default" id="btn-submit" type="submit">Search</button>
        </form>
    </div>
</div>
<div class="row">
    <div class="col-12">
        <div>

            <table class="table">
                <thead class="thead-dark">
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">First</th>
                        <th scope="col">Last</th>
                        <th scope="col">Handle</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope="row">1</th>
                        <td>Mark</td>
                        <td>Otto</td>
                        <td>mdo</td>
                    </tr>
                    <tr>
                        <th scope="row">2</th>
                        <td>Jacob</td>
                        <td>Thornton</td>
                        <td>fat</td>
                    </tr>
                    <tr>
                        <th scope="row">3</th>
                        <td>Larry</td>
                        <td>the Bird</td>
                        <td>twitter</td>
                    </tr>
                </tbody>
            </table>

        </div>
    </div>
    
    
</div>
