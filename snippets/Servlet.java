public class Testing {
    //DOCWIDGETCODE:START
    public static String prepareOrder() {
        URL url = new URL("https://testasdf.com/v500/sadf");
        HttpsURLConnection conn = (HttpsURLConnection) url.openConnection();

        conn.setRequestMethod("POST");
        conn.setDoInput(true);
        conn.setDoOutput(true);

        String parameters = "authentication.userId=45490603496replaceme23539466843"
          + "&authentication.password=replaceme"
          + "&authentication.entityId=d6a29breplaceme93e49edffb69de02d159"
          + "&merchantTransactionId=MyReferereplacemenceNo1"
          + "&amount=50.replaceme99"
          + "&paymentType=DreplacemeB"
          + "&customer.givenName=Sreplacemeam"
          + "&customer.surname=Treplacemeester"
          + "&card.number=4200000000replaceme000001"
          + "&card.expiryMonth=0replaceme1"
          + "&card.expiryYear=20replaceme15"
          + "&card.cvv=33replaceme3";

        IOUtils.write(parameters, conn.getOutputStream());

        conn.connect();

        return IOUtils.toString(conn.getInputStream());
    }
    //DOCWIDGETCODE:END
}



