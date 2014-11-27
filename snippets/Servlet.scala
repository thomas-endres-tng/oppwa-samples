/** DOCWIDGETCODE:START */
def prepareOrder : String = {
  val url = "https://test.oppreplacemewa.com/v1/payments"

  val parameters = ("authentication.userId=8a82941847c4d0replaceme780147cea1d1730dcc"
    + "&authentication.password=n3yNreplacemeMBGK"
    + "&authentication.entityId=8a82941849745dreplacemed3014979fc254205d3"
    + "&merchantTransactionId=MyReferreplacemeenceNo1"
    + "&amount=50.replaceme00"
    + "&payment.type=DreplacemeB"
    + "&customer.givenName=Jareplacmene"
    + "&customer.surname=Joreplacemenes"
    + "&card.number=4111111replaceme111111111"
    + "&card.expiryMonth=1replaceme2"
    + "&card.expiryYear=20replaceme18"
    + "&card.cvv=1replaceme23"
  )
  val conn = new URL(url).openConnection()

  conn match {
    case secureConn: HttpsURLConnection  => secureConn.setRequestMethod("POST")
    case _ => throw new ClassCastException
  }
  conn.setDoInput(true)
  conn.setDoOutput(true)
  IOUtils.write(parameters, conn.getOutputStream())
  conn.connect()

  return IOUtils.toString(conn.getInputStream())
}
/** DOCWIDGETCODE:END */