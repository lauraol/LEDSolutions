<%@ Page Language="cs" AutoEventWireup="false"  CodeBehind="default.aspx.cs" %>


<!DOCTYPE html>
<html lang="pt">
    <head runat="server">
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="/css/style.css">
        <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@200&display=swap" rel="stylesheet">   
        <title>LED Soluções</title>
    </head>

    <body>
        <div class="menu">
           <header>
                <nav>
                    <div class="menu">
                        <ul>
                            <li><a href="default.aspx">Home</a> 
                            <li><a href="quem-somos.html">Quem Somos</a></li>
                            <li> <a href="contato.aspx">Contato</a> </li>
                        </ul>
            
                    </div>
                </nav>
            
            </header>
        </div> 

        <div class="wrapper">
            <div class="info">
               <div class="texto">
                    <h1>Fale com a gente!</h1>
                    <p>Se interessou pelos nossos serviços? preencha o formulário abaixo com as informações necessárias. Assim, nosso time qualificado poderá te enviar um orçamento e explicar mais detalhadamente sobre os processos!</p>
               </div>
            </div>

            <div class="ilustra">
                <img src="sac.jpg" alt="duas pessoas fazendo transação de carteira online">
            </div> 
        </div>

      <form id="form1" runat="server">
            
               <div class="formulario"> <table class="formulario-contato">
                    <tr class="nome">
                        <td>Nome Completo</td>
                        <td><asp:TextBox ID="txtName" runat="server" placeholder="Jane Doe" CssClass="td"></asp:TextBox></td>
                    </tr>

                    <tr class="email">
                        <td>E-mail</td>
                        <td><asp:TextBox ID="txtEmail" runat="server" placeholder="jane@doe.com" TextMode="Email" CssClass="td"></asp:TextBox></td>
                    </tr>
                    <tr class="telefone">
                        <td>Telefone</td>
                        <td><asp:TextBox ID="txtPhone" runat="server" placeholder="11 123567890" CssClass="td"></asp:TextBox></td>
                    </tr>
                  
                    <tr>
                        <td class="wrapper-botao"></td>
                        <td ><asp:Button runat="server" Text="Enviar!" class="botao-submit" OnClick="btnReg_Click" /></td>
                    </tr>

                </table>
                
            </form>
        </div>
    </body>

    <footer>

    </footer>
</html>