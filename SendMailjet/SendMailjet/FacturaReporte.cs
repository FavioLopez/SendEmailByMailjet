using System;
using System.Collections.Generic;
using System.Text;

namespace SendMailjet
{
    public class FacturaReporte
    {
        public string factura()
        {
            string razonSocial = "razon social";
            string Direccion = "Direccion";
            string Contacto = "Contacto";
            string Nit = "Nit";
            string NroFactura = "NroFactura";
            string NroAutorizacion = "Nroaut";
            string TipoFactura = "tipofac";
            string Fecha = "fecha";
            string cliente = "cliente";
            string nitCiCli = "nit";
            string Detalle = "";
            string literal = "lit";
            string total = "total";
            string CodControl = "CodControl";
            string FechaLimiteEmision = "FechaLimiteEmision";
            string QR = "QR";
            string ActPrincipal = "ActPrincipal";
            string ActSecun = "ActSecun";
            string Leyenda = "leyendaa";
            string factura =
                "<!DOCTYPE HTML>" +
                "<html><head><meta http-equiv='Content-Type' content='text/html; charset=utf-8' /><title>Factura</title></head><body><div id='container'>" +
                "<div class='cabecera'><div style='float: left;width: 50%;'>"+
                "<div class='logocontainer'><img src = '[LOGO]' class='logo' /></div>"+
                "<div class='direccion'><p>"+ razonSocial + "<br>" + Direccion + "<br>" + Contacto + "<br>Tarija - Bolivia</p></div></div>" +
                "<div style = 'float: left;width: 50%;padding-top: 10px;' >" +
                "<div class='nitempresa'>"+
                "<table>" +
                "<tr>" +
                "<td>" +
                "<span>NIT:</span>" +
                "</td>" +
                "<td><p>" + Nit + "</p></td></tr>" +
                "<tr>" +
                "<td>" +
                "<span>Nº FACTURA:</span></td>" +
                "<td><p>" + NroFactura + "</p></td></tr>" +
                "<tr><td><span>Nº AUTORIZACIÓN:</span></td>" +
                "<td><p>" + NroAutorizacion + "</p></td></tr></table>" +
                "</div></div></div>" +
                "<div style = 'float: left;width: 100%;' ><h1> FACTURA </h1><h2>" + TipoFactura + "</h2></div>" +
                "<div class='cliente'><div style = 'float: left;width: 60%;' ><p> Fecha:&nbsp;&nbsp;&nbsp;" + Fecha + "</p>" +
                "<p>Nombre:&nbsp;&nbsp;&nbsp;"+ cliente + "</p></div>" +
                "<div style = 'float: left;width: 40%;''>NIT/CI:&nbsp;&nbsp;&nbsp;"+nitCiCli+"</div></div><div class='detalle'>" +
                "<table border = 1 cellspacing=0 cellpadding=2 bordercolor='#000000' style='border: 1px solid;'>" +
                "<thead><tr><th>DESCRIPCION</th><th>CANTIDAD</th><th>P/U</th><th>SUBTOTAL</th></tr></thead>" +
                "<tbody>"+ Detalle + "</tbody></table></div>" +
                "<table border = 1 cellspacing=0 cellpadding=2 bordercolor='#000000' style='border: 1px solid;'>" +
                "<tbody><tr style='background-color: #EBE9E9;' ><td> Son:&nbsp;&nbsp;&nbsp;"+ literal +"</td><td style='text-align:right;background-color:darkgray;font-weight:bold;' > TOTAL Bs.</td>" +
                "<td style='text-align:right'>"+ total +"</ td ></tr></tbody></table>" +
                "<div class='pie' style='float: left; width: 100%;'><div style='float: left; width: 69%;padding-top:10px;'><div style='bottom: 10px;'>" +
                "<p>Codigo de control:&nbsp;&nbsp;&nbsp;"+CodControl+"</p></div>  <br />" +
                "<div style=''><p> Fecha limite de emision:&nbsp;&nbsp;&nbsp;"+FechaLimiteEmision+"</p></div></div>" +
                "<div class='qr' style='float: left; width: 30%;'><img src = '"+ QR + "' /></div></div>" +
                "<p class='leyenda'>Actividad Principal: "+ActPrincipal+" - Actividad Secundaria: "+ActSecun+"<br><br>"+Leyenda+"</p></div></body></html>" +
                "<style>" +
                "@page {size: A5 landscape;margin: 0px;}body {font-size: 9pt;font-family: sans-serif;height: 148.5mm;width: 210mm;margin: 0;}#container {height: 145mm;width: 210mm;border: 1px solid black;padding: 5px;padding-right: 5px;}.cabecera{top: 10px;width: 99 %;padding: 0;}.logo{width: 60px;height: 60px;padding-left: 10px;padding-top: 10px;}.logocontainer{float: left;}.direccion{float: left;margin-left: 10px;padding-left: 10px;margin-top: 7px;}.nitempresa{border: 1px solid black;width: 300px;float: right;padding-right: 5px;margin-right: 0px;border-collapse: separate;border-radius: 5px;}.nitempresa p{margin: 0;padding-top: 0px;padding-bottom: 0px;}.nitempresa table{border: 0px;}.nitempresa table tr td p {font-size: 8pt;font-weight: bold;width: 80px;}span{font-size: 8pt;font-weight: bold;}h1{text-align: center;font-size: 15pt;margin: 0;padding-top: 0px;padding-bottom: 0px;}h2{font-size: 12pt;text-align: center;font-weight: normal;margin: 0;padding-top: 0px;padding-bottom: 0px;}.cliente{border: 1px solid black;float: left;width: 98%;border-radius: 5px;padding: 5px;border-collapse: separate;margin-right: 5px;position: relative;}.cliente div p {margin: 0;padding-top: 3px;padding-bottom: 3px;}.detalle{padding: 10px;float: left;width: 100 %;padding: 0px;margin-top: 5px;height: 200px;overflow-y: hidden;overflow-x: hidden;}table{border: 1px solid black;padding: 0px;width: 99%;border-collapse: collapse;}table thead{background-color: #EBE9E9;}.pie{top: 10px;bottom: 0px;}.pie div div {border: 1px solid black;padding-left: 5px;top: 0px;}.pie div div p {margin: 0;padding-top: 5px;padding-bottom: 5px;}.qr{text-align: right;margin-right: 5px;margin-top: 5px;}.qr img{width: 100px;height: 100px;}.leyenda{font-size: 8pt;text-align: center;}.tdnumal{text-align: right;}" +
                "</style> ";
            return factura;
        }
    }
}
