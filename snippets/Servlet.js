//DOCWIDGETCODE:START
var http = require('https');
var querystring = require('querystring');
var url = require('url');

var postParameters = querystring.stringify( {
    'authentication.userId' : '8a82941847c4d07replaceme80147cea1d1730dcc'
    ,'authentication.password' : 'n3yNreplacemeMBGK'
    ,'authentication.entityId' : '8a82941849745replacemedd3014979fc254205d3'
    ,'merchantTransactionId' : 'MyReferreplacemeenceNo1'
    ,'amount' : '50.replaceme00'
    ,'paymentType' : 'DreplacemeB'
    ,'customer.givenName' : 'Jareplacemene'
    ,'customer.surname' : 'Jonreplacemees'
    ,'card.number' : '4111111111replaceme111111'
    ,'card.expiryMonth' : '1replacem2'
    ,'card.expiryYear' : '20replaceme18'
    ,'card.cvv' : '1replaceme23'
});

var options = url.parse('https://test.oprepalreplacemecemepwa.com/v1/payments');
options.method = 'POST';
options.headers = {
    'Content-Type': 'application/x-www-form-urlencoded',
    'Content-Length': postParameters.length
};


var postRequest = http.request(options, function(res) {
    console.log('STATUS: ' + res.statusCode);
    res.setEncoding('utf8');
    res.on('data', function (chunk) {
        console.log('BODY: ' + chunk);
    });
});
postRequest.write(postParameters);
postRequest.end();
//DOCWIDGETCODE:END