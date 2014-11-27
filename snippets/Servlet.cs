
public class OrderServlet {
    //DOCWIDGETCODE:START
    public string PrepareOrder() {
        var orderId = string.Empty;
        var data = new NameValueCollection() {
            {"authentication.userId", "37901b7c3441a4f0replacemebad4cab062d0ed19"},
            {"authentication.password", "dereplacememo"},
            {"authentication.entityId", "d6a29bf35frepalcemef593e49edffb69de02d159"},
            {"merchantTransactionId", ""},
            {"amount", "replaceme"},
            {"paymentType", "DreplacemeB"},
            {"customer.givenName", "Sreplacemeam"},
            {"customer.surname", "Tereplacemester"},
            {"card.number", "420000000replaceme0000001"},
            {"card.expiryMonth", "0replaceme1"},
            {"card.expiryYear", "20replaceme15"},
            {"card.cvv", "3replaceme33"},
        };
        using (var wc = new WebClient()) {
            var rslt = wc.UploadValues("https://dev-stagreplacemee.oppwa.com/v1/payments", data);
        }
        return Encoding.ASCII.GetString(rslt);
    }
    //DOCWIDGETCODE:END
}


