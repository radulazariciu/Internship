﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MovieProductItemSelector.ascx.cs" Inherits="EPiServer.Commerce.Sample.Templates.Sample.Units.ProductDetail.Movies.MovieProductItemSelector" %>
<%@ Register Src="../SharedModules/AddToCart.ascx" TagName="AddToCart" TagPrefix="product" %>
<%@ Register Src="../SharedModules/ProductPromotions.ascx" TagName="ProductPromotions" TagPrefix="product" %>
<%@ Register Src="../SharedModules/ProductWarehouseInfo.ascx" TagName="ProductWarehouseInfo" TagPrefix="product" %>
<%@ Register Src="../SharedModules/ProductInfoPricing/ProductPriceDetails.ascx" TagName="ProductPriceDetails" TagPrefix="product" %>

<div class="well">
    <product:ProductPriceDetails runat="server" ID="ProductPriceDetails"></product:ProductPriceDetails>
    <hr />
    <asp:DropDownList ID="mediatypes" CssClass="span2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="attribute_SelectedIndexChanged"></asp:DropDownList>
    <hr />
    <product:ProductPromotions runat="server" ID="ProductPromotions"></product:ProductPromotions>    
    <product:AddToCart runat="server" ID="AddToCart"></product:AddToCart>
    <hr />
    <ul class="unstyled">
         <product:ProductWarehouseInfo runat="server" ID="ProductWarehouseInfo"></product:ProductWarehouseInfo>
    </ul>
</div>
