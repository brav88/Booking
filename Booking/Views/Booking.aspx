<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="Booking.Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link rel="stylesheet"
        id="theme_link"
        href="https://cdnjs.cloudflare.com/ajax/libs/bootswatch/5.1.2/lux/bootstrap.min.css" />
    <link href="../css/resorts.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
                <div class="container-fluid">
                    <a class="navbar-brand" href="#">Booking.com</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>

                    <div class="collapse navbar-collapse" id="navbarColor01">
                        <ul class="navbar-nav me-auto">
                            <li class="nav-item">
                                <a class="nav-link" href="Booking.aspx">Resorts</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#offcanvasExample" data-bs-toggle="offcanvas" aria-controls="offcanvasExample">Login</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <asp:Repeater ID="repResorts" runat="server">
                <HeaderTemplate>
                    <div class="container">
                        <div class="row">
                </HeaderTemplate>
                <ItemTemplate>
                    <div id="cardResorts" class="card">
                        <h5 class="card-title"><%# Eval("Name")%></h5>
                        <img src="<%# Eval("Photo")%>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <p class="card-text"><%# Eval("Description")%></p>
                            <a href="Book.aspx?id=<%# Eval("Id")%>" class="btn btn-primary">Book! by $<%# Eval("Price")%> per night!</a>
                        </div>
                    </div>
                </ItemTemplate>
                <FooterTemplate>
                    </div>
                    </div>
                </FooterTemplate>
            </asp:Repeater>
        </div>

        <%--OFFCANVA--%>
        <div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasExample" aria-labelledby="offcanvasExampleLabel">
            <div id="offCanvaHeader" class="offcanvas-header">
                <h5 class="offcanvas-title" id="offcanvasExampleLabel">Login</h5>
                <button type="button" class="btn-close text-reset" data-bs-dismiss="offcanvas" aria-label="Close"></button>
            </div>
            <div class="offcanvas-body">
                <div class="card">
                    <div class="card-body">
                        <div class="form-group">
                            <label class="form-label mt-4">Login form</label>
                            <div class="form-floating mb-3">
                                <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com" />
                                <label for="floatingInput">Email address</label>
                            </div>
                            <div class="form-floating">
                                <input type="password" class="form-control" id="floatingPassword" placeholder="Password" />
                                <label for="floatingPassword">Password</label>
                            </div>
                        </div>
                    </div>
                    <div class="card-footer">
                        <button id="btnLogin" class="btn btn-primary" runat="server">Login</button>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
