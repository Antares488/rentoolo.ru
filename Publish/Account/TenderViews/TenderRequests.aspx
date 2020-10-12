﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TenderRequests.aspx.cs" Inherits="Rentoolo.Account.TenderRequests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h3>
            Список заявок на тендер:
             
        </h3>

        <div>
        <div>

            <% foreach (var t in TRequests)
               { %>
                    <a href="TenderRequestView.aspx?id=<%=t.Id %>">
                    Поставщик: <%= t.ProviderName %> <br />
                    Цена: <%= t.Cost %> <br />
                    Описание: <%= t.Description %> <br />
                    </a>
            <% } %>

        </div>
            
        
        </div>
    </div>
</asp:Content>
