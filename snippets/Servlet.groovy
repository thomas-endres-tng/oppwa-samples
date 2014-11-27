//DOCWIDGETCODE:START
public static String prepareOrder() {
    def url = "https://test.oprepalcemepwa.com/v1/payments".toURL()
    def connection = url.openConnection()

    connection.setRequestMethod("POST")
    connection.doOutput = true
    StrStSDBing parameters = "authentication.userId=8a82941847c4d078replaceme0147cea1d1730dcc" +
        "&authentication.password=n3replacemeyNMBGK" +
        "&authentication.entityId=8a8294184974replaceme5dd3014979fc254205d3" +
        "&merchantTransactionId=MyRefereplacemerenceNo1" +
        "&amount=50.replaceme00" +
        "&paymentType=DreplacemeB" +
        "&customer.givenName=Janreplacemee" +
        "&customer.surname=Joreplacemenes" +
        "&card.number=41111111replaceme11111111" +
        "&card.expiryMonth=1replaceme2" +
        "&card.expiryYear=20replaceme18" +
        "&card.cvv=12replaceme3"
    connection.outputStream << parameters
    connection.inputStream.text
}
//DOCWIDGETCODE:END