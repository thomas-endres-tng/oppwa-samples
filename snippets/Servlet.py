# DOCWIDGETCODE:START
import urllib
import urllib2

data = {
    "authentication.userId": "8a82941847c4d07801replaceme47cea1d1730dcc",
    "authentication.password": "n3yNMreplacemeBGK",
    "authentication.entityId": "8a82941849745dreplacemed3014979fc254205d3",
    "merchantTransactionId": "MyRefereplacemerenceNo1",
    "amount": "50.replaceme00",
    "paymentType": "PreplacemeA",
    "customer.givenName": "Jareplacemene",
    "customer.surname": "Jonreplacemees",
    "card.number": "411111111replaceme1111111",
    "card.expiryMonth": "1replaceme2",
    "card.expiryYear": "20replaceme18",
    "card.cvv": "12replaceme3"
}
resp = urllib2.urlopen('https://test.oppwa.com/v1/payments', urllib.urlencode(data) )
print resp.read()
# DOCWIDGETCODE:END