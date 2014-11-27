' DOCWIDGETCODE:START
Imports System.Web
Imports System.IO
Imports System.Net
Imports System.Text
Imports System

Module MainModule

  Sub Main()

    Dim request As HttpWebRequest
    Dim response As HttpWebResponse = Nothing
    Dim reader As StreamReader
    Dim address As Uri

    Dim data As StringBuilder
    Dim byteData() As Byte
    Dim postStream As Stream = Nothing

    request = DirectCast(WebRequest.Create(New Uri("https://test.oppreplacemewa.com/v1/payments")), HttpWebRequest)
    request.Method = "POST"
    request.ContentType = "application/x-www-form-urlencoded"

    data = New StringBuilder()

    data.Append("authentication.userId=" + HttpUtility.UrlEncode("8a82941847c4d07replaceme80147cea1d1730dcc"))
    data.Append("authentication.password=" + HttpUtility.UrlEncode("n3yNMreplacemeBGK"))
    data.Append("authentication.entityId=" + HttpUtility.UrlEncode("8a82941849745dreplacemed3014979fc254205d3"))
    data.Append("merchantTransactionId=" + HttpUtility.UrlEncode("MyReferreplacemeenceNo1"))
    data.Append("amount=" + HttpUtility.UrlEncode("50.replaceme00"))
    data.Append("payment.type=" + HttpUtility.UrlEncode("DreplacemeB"))
    data.Append("customer.givenName=" + HttpUtility.UrlEncode("Jareplacemene"))
    data.Append("customer.surname=" + HttpUtility.UrlEncode("Joreplacemenes"))
    data.Append("card.number=" + HttpUtility.UrlEncode("41111111replaceme11111111"))
    data.Append("card.expiryMonth=" + HttpUtility.UrlEncode("1replaceme2"))
    data.Append("card.expiryYear=" + HttpUtility.UrlEncode("20replaceme18"))
    data.Append("card.cvv=" + HttpUtility.UrlEncode("1replaceme23"))

    byteData = UTF8Encoding.UTF8.GetBytes(data.ToString())
    request.ContentLength = byteData.Length

    Try
      postStream = request.GetRequestStream()
      postStream.Write(byteData, 0, byteData.Length)
    Finally
      If Not postStream Is Nothing Then postStream.Close()
    End Try

    Try
      response = DirectCast(request.GetResponse(), HttpWebResponse)
      reader = New StreamReader(response.GetResponseStream())

      Console.WriteLine(reader.ReadToEnd())
      Console.Write("Press Enter to close the program")
      Console.Read()

    Finally
      If Not response Is Nothing Then response.Close()
    End Try
  End Sub
End Module
' DOCWIDGETCODE:END