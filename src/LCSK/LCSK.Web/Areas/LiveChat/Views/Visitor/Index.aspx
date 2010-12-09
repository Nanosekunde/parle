﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<VisitorInitViewModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>LiveChat Starter Kit</title>

	<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>

	<style type="text/css">
	body 
	{
		color: Black;
		font-size: small;
		font-family: Verdana, Arial;
		padding: 0;
		margin: 0;
	}
	h2
	{
		float: right;
		vertical-align: middle;
		color: Orange;
		padding-right: 25px;
	}
	/* Styles for validation helpers
	-----------------------------------------------------------*/
	.field-validation-error
	{
		color: #ff0000;
	}

	.field-validation-valid
	{
		display: none;
	}

	.input-validation-error
	{
		border: 1px solid #ff0000;
		background-color: #ffeeee;
	}

	.validation-summary-errors
	{
		font-weight: bold;
		color: #ff0000;
	}

	.validation-summary-valid
	{
		display: none;
	}

	/* Styles for editor and display helpers
	----------------------------------------------------------*/
	.display-label,
	.editor-label,
	.display-field,
	.editor-field
	{
		margin: 0.5em 0;
	}

	.text-box
	{
		width: 30em;
	}

	.text-box.multi-line
	{
		height: 6.5em;
	}

	.tri-state
	{
		width: 6em;
	}

	</style>
</head>
<body>
    <div>
		<img src="/Content/LCSK/livechat_logo.jpg" alt="LCSK - Logo" style="float: left;" />
		<h2>LiveChat Starter Kit by Focus Centric inc.</h2>
	</div>

	<div style="clear: both;padding: 10px 10px 10px 10px;">
	<% if (Model.ChatOnline)
	{ %>

		<h3>Fill the form below to start a chat session with one of our representative</h3>

		<% using (Html.BeginForm())
	 { %>
		<%= Html.ValidationSummary("Some information are required") %>

		<fieldset>
			<legend>Request a chat session</legend>

			<div class="editor-label">
				<%= Html.LabelFor(x => x.NewChatRequest.Requester.Name) %>
			</div>
			<div class="editor-field">
				<%= Html.TextBoxFor(x => x.NewChatRequest.Requester.Name) %><%= Html.ValidationMessageFor(x => x.NewChatRequest.Requester.Name) %>
			</div>

			<div class="editor-label">
				<%= Html.LabelFor(x => x.NewChatRequest.Requester.Email) %>
			</div>
			<div class="editor-field">
				<%= Html.TextBoxFor(x => x.NewChatRequest.Requester.Email) %><%= Html.ValidationMessageFor(x => x.NewChatRequest.Requester.Email) %>
			</div>

			<div class="editor-label">
				<%= Html.Label("Choose a department") %>
			</div>
			<div class="editor-field">
				<%= Html.DropDownListFor(x => x.Departments, new SelectList(Model.Departments)) %>
			</div>

			<p>
				<input type="submit" value="Start Chat" />
			</p>

		</fieldset>

		<% } %>
	<% }
	else
	{ %>
		TODO, CHAT OFFLINE ADD A FORM AND SEND BY EMAIL
	<% } %>

	</div>
</body>
</html>
