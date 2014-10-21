<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Harita.aspx.cs" Inherits="Proje3.Harita" %>

<!DOCTYPE html>
<html>
  <head>
  <title>Akıllı Durak Sistemi</title>
    <style type="text/css">
      html { height: 100% }
      body { height: 100%; margin: 0; padding: 0 }
      #map-canvas { height: 99%;
            width: 791px;
        }
        .style1
        {
            color:Yellow;
            width: 130%;
            height: 354px;
            background-color:Teal;
        }
        .style3
        {
            width: 723px;
            height: 671px;
        }
        .style5
        {
            width: 96%;
            height: 74px;
        }
        .style6
        {
            width: 109px;
        }
        .style9
        {
            width: 723px;
            height: 31px;
        }
        .style12
        {
            width: 381px;
            height: 55px;
        }
        .style14
        {
            width: 381px;
            height: 31px;
        }
        .style20
        {
            height: 100%;
            width: 381px;
        }
        .style21
        {
            width: 381px;
            height: 100%;
        }
        .style25
        {
            width: 381px;
            height: 33px;
        }
        
        
        .style26
        {
            width: 198px;
        }
        
        
        .style27
        {
            height: 76px;
        }
        .style28
        {
            width: 723px;
            height: 76px;
        }
        .style29
        {
            width: 381px;
            height: 76px;
        }
        
        
        </style>
    <script type="text/javascript"
          src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCHFCPQrVg4hwQzU1OLO_9KpDbqMk3re5I&sensor=false">
    </script>


    <script type="text/javascript">
        function show_popup() {
            var p = window.createPopup()
            var pbody = p.document.body
            pbody.style.backgroundColor = "lime"
            pbody.style.border = "solid black 1px"
            pbody.innerHTML = "This is a pop-up! Click outside to close."
            p.show(150, 150, 200, 50, document.body)
            alert("hata");
        }
    </script>

    
    <script type="text/javascript">
        function HaritaGoster() {
            var mapOptions = {
                center: new google.maps.LatLng(40.75, 29.97),
                zoom: 12
            };
        var map = new google.maps.Map(document.getElementById("map-canvas"),
            mapOptions);
        }
        google.maps.event.addDomListener(window, 'load', HaritaGoster);
    </script>
    
    <script type="text/javascript">
        function YolCiz24() {
            var mapOptions = {
                center: new google.maps.LatLng(40.75, 29.97),
                zoom: 10
            };
            var map = new google.maps.Map(document.getElementById("map-canvas"),
            mapOptions);

            var directionsDisplay = new google.maps.DirectionsRenderer();
            directionsDisplay.setMap(map);
            

            var request = {

                origin: new google.maps.LatLng(40.740555, 29.941729),
                destination: new google.maps.LatLng(40.824129, 29.920663),
                travelMode: google.maps.DirectionsTravelMode.DRIVING,
                
                waypoints: [
            { location: new google.maps.LatLng(40.750504, 29.94881) },
            { location: new google.maps.LatLng(40.763162, 29.976098) },
            { location: new google.maps.LatLng(40.764692, 29.970335) },
            { location: new google.maps.LatLng(40.773894, 29.97122) },
            { location: new google.maps.LatLng(40.78204, 29.968621) },
            { location: new google.maps.LatLng(40.802838, 29.969874) },
            { location: new google.maps.LatLng(40.799898, 29.949035) }
            

        ]
            };

            var service = new google.maps.DirectionsService();
            service.route(request, function (result, status) {
                if (status == google.maps.DirectionsStatus.OK) {
                    directionsDisplay.setDirections(result);
                }
            });
            return false;
        }
    //    google.maps.event.addDomListener(window, 'load', YolCiz24);
    
    </script>
    <script type="text/javascript">
        function YolCiz23() {
            var mapOptions = {
                center: new google.maps.LatLng(40.75, 29.97),
                zoom: 10
            };
            var map = new google.maps.Map(document.getElementById("map-canvas"),
            mapOptions);

            var directionsDisplay = new google.maps.DirectionsRenderer();
            directionsDisplay.setMap(map);

            var request = {

                origin: new google.maps.LatLng(40.764716, 29.982083),
                destination: new google.maps.LatLng(40.824129, 29.920663),
                travelMode: google.maps.DirectionsTravelMode.DRIVING,
                waypoints: [


            { location: new google.maps.LatLng(40.764692, 29.970335) },
            { location: new google.maps.LatLng(40.773894, 29.97122) },
            { location: new google.maps.LatLng(40.78204, 29.968621) },
            { location: new google.maps.LatLng(40.802838, 29.969874) },
            { location: new google.maps.LatLng(40.799898, 29.949035) },
            { location: new google.maps.LatLng(40.817552, 29.918807) },
            { location: new google.maps.LatLng(40.824129, 29.920663) }


        ]
            };

            var service = new google.maps.DirectionsService();
            service.route(request, function (result, status) {
                if (status == google.maps.DirectionsStatus.OK) {
                    directionsDisplay.setDirections(result);
                }
            });
            return false;
        }
        //    google.maps.event.addDomListener(window, 'load', YolCiz24);
    
    </script>



    <script type="text/javascript">
        function DuragaGit(durak_x,durak_y) 
        {
            var mapOptions = {
                center: new google.maps.LatLng(durak_x,durak_y),
                zoom: 19
            };
            var map = new google.maps.Map(document.getElementById("map-canvas"),
            mapOptions);
            var directionsDisplay = new google.maps.DirectionsRenderer();
            directionsDisplay.setMap(map);
            return false;
        }
    //    google.maps.event.addDomListener(window, 'load', DuragaGit);
    </script>

  </head>

  <body>
      
      
      <form id="form1" runat="server">
      
      <table class="style1">
          <tr>
              <td class="style9" rowspan="2">
                  <table class="style5">
                      <tr>
                          <td class="style6">
                              <asp:Label ID="Label1" runat="server" Text="Hat Adı Seçiniz"></asp:Label>
                          </td>
                          <td>
                              
                              
                              
                              <asp:DropDownList ID="DropDownList1" runat="server" 
                                  onselectedindexchanged="DropDownList1_SelectedIndexChanged" Height="39px" 
                                  Width="364px">
                                  <asp:ListItem Value="0" Selected="True">HAT SEÇİNİZ...</asp:ListItem>
                                  <asp:ListItem Value="23">23   YAHYA KAPTAN - UMUTTEPE</asp:ListItem>
                                  <asp:ListItem Value="24">24   SANAYİ - YAHYA KAPTAN - UMUTTEPE</asp:ListItem>
                              </asp:DropDownList>
                              
                              
                              
                              <asp:Button ID="btnGoster" runat="server" Text="Göster" Width="100px" 
                                  onclick="btnGoster_Click" style="margin-left: 0px" Height="35px" />
                              
                              
                              
                          </td>
                      </tr>
                      <tr>
                          <td class="style6">
                              &nbsp;</td>
                          <td class="style26">
                              <asp:Button ID="btnYoluGoster24" runat="server" Height="35px" 
                                  onclick="btnYoluGoster24_Click" Text="Yol" Width="50px"
                                  OnClientClick="return YolCiz24()" />
                              <asp:Button ID="btnYoluGoster23" runat="server" Height="35px" 
                                  onclick="btnYoluGoster23_Click" Text="Yol" Width="50px" 
                                  OnClientClick="return YolCiz23()" />
                              <asp:Button ID="btnHat" runat="server" Text="HatDetay" Width="73px" 
                                  Height="35px" onclick="btnHat_Click" />
                          </td>
                      </tr>
                  </table>
              </td>
              <td class="style14">
              
              
                  &nbsp;&nbsp;
              
              
                  <asp:Label ID="lbl1" runat="server" Text="Durak 1"></asp:Label>
                  &nbsp;&nbsp;
                  <asp:Label ID="lbl2" runat="server" Text="Durak 2"></asp:Label>
                  &nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Label ID="lbl3" runat="server" Text="Durak 3"></asp:Label>
                  &nbsp;&nbsp;
                  <asp:Label ID="lbl4" runat="server" Text="Durak 4"></asp:Label>
                  &nbsp;&nbsp;&nbsp;
                  <asp:Label ID="lbl5" runat="server" Text="Durak 5"></asp:Label>
              
                  </td>
              
          </tr>
          <tr>
              <td class="style25">
              
                  <asp:ImageButton ID="ibDurak1" runat="server" Height="65px" 
                      ImageUrl="~/Barkodlar/Durak1.png" Width="65px" onclick="ibDurak1_Click" OnClientClick="return DuragaGit(40.799947,29.947044)" />
                  <asp:ImageButton ID="ibDurak2" runat="server" Height="65px" 
                      ImageUrl="~/Barkodlar/Durak2.png" Width="65px" onclick="ibDurak2_Click" OnClientClick="return DuragaGit(40.799898,29.948976)" />
                  <asp:ImageButton ID="ibDurak3" runat="server" Height="65px" 
                      ImageUrl="~/Barkodlar/Durak3.png" Width="65px" onclick="ibDurak3_Click" OnClientClick="return DuragaGit(40.800524,29.952259)" />
                  <asp:ImageButton ID="ibDurak4" runat="server" Height="65px" 
                      ImageUrl="~/Barkodlar/Durak4.png" Width="65px" onclick="ibDurak4_Click" OnClientClick="return DuragaGit(40.800564,29.955831)" />
                  <asp:ImageButton ID="ibDurak5" runat="server" Height="65px" 
                      ImageUrl="~/Barkodlar/Durak5.png" Width="65px" onclick="ibDurak5_Click" OnClientClick="return DuragaGit(40.801815,29.958814)" />
                      
                  </td>
              
          </tr>
          <tr>
              <td class="style3" rowspan="4">
                  <div id="map-canvas"/>
                 &nbsp; </td>
                    
              <td class="style20">
                  
              
                  <asp:ListBox ID="lb24gidis" runat="server" DataSourceID="SqlDataSource24Gidis" 
                      DataTextField="DurakAdi" DataValueField="DurakID" Height="182px" 
                      Width="350px" BackColor="#00FF99" Font-Overline="True" 
                      Font-Underline="True" 
                      onselectedindexchanged="lb24gidis_SelectedIndexChanged">
                  </asp:ListBox>
                  <asp:SqlDataSource ID="SqlDataSource24Gidis" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:AkilliDurakConnectionString3 %>" 
                      SelectCommand="SELECT * FROM [Duraklar24] ORDER BY [DurakID]">
                  </asp:SqlDataSource>
                 
                  <asp:ListBox ID="lb23gidis" runat="server" DataSourceID="SqlDataSource23Gidis" 
                      DataTextField="DurakAdi" DataValueField="DurakID" Height="180px" 
                      Width="350px" BackColor="#00FF99" 
                      onselectedindexchanged="lb23gidis_SelectedIndexChanged">
                  </asp:ListBox>
                  <asp:SqlDataSource ID="SqlDataSource23Gidis" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:AkilliDurakConnectionString3 %>" 
                      SelectCommand="SELECT * FROM [Duraklar23] ORDER BY [DurakID]">
                  </asp:SqlDataSource>
                  
              
          </tr>
                    
              <tr>
                    
              <td class="style21">
                  <asp:ListBox ID="lb24donus" runat="server" datasourceid="SqlDataSource24Donus" 
                      DataTextField="DurakAdi" DataValueField="DurakID" Height="180px" 
                      Width="350px" BackColor="#00FF99" 
                      onselectedindexchanged="lb24donus_SelectedIndexChanged" 
                      AppendDataBoundItems="True" ClientIDMode="AutoID" DataMember="DefaultView"  >
                  </asp:ListBox>
                  <asp:SqlDataSource ID="SqlDataSource24Donus" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:AkilliDurakConnectionString3 %>" 
                      SelectCommand="SELECT * FROM [Duraklar24] ORDER BY [DurakID] DESC">
                  </asp:SqlDataSource>
                  <asp:ListBox ID="lb23donus" runat="server" datasourceid="SqlDataSource23Donus" 
                      DataTextField="DurakAdi" DataValueField="DurakID" Height="180px" 
                      Width="350px" BackColor="#00FF99" 
                      onselectedindexchanged="lb23donus_SelectedIndexChanged">
                  </asp:ListBox>
                  <asp:SqlDataSource ID="SqlDataSource23Donus" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:AkilliDurakConnectionString3 %>" 
                      SelectCommand="SELECT * FROM [Duraklar23] ORDER BY [DurakID] DESC">
                  </asp:SqlDataSource>
                  
              
          </tr>
                    
              
              <tr>
                    
              <td class="style12">
                  &nbsp;<asp:Button 
                      ID="btnSaat" runat="server" Text="Hareket Saatleri" 
                      Width="200px" onclick="btnSaat_Click" Height="29px" />
                  
              
                  &nbsp;&nbsp;</tr>
                    
              
              <tr>
                    
              <td class="style12">
                  <asp:ListBox ID="ListBoxSaat" runat="server" Height="100%" 
                      style="margin-top: 0px" Width="100%" BackColor="#00FF99"></asp:ListBox>
                  <br />
                  <asp:Label ID="lblHatlar" runat="server" BorderStyle="Double" Height="16px" 
                      ToolTip="Bu duraktan geçen diğer hatlar" Width="82px"></asp:Label>
                  
              
          </tr>
                    
              
          <tr>
              <td class="style28">
                  </td>
              <td class="style29">
                  </td>
              <td class="style27">
                  </td>
          </tr>
      </table>
      
      </form>
      

  </body>
</html>