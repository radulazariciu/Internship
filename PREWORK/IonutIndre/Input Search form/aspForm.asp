<body>
Result is:
<%
response.write(request.form("fname"))
response.write(" " & request.form("lname"))
%>
</body>