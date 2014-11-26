var https = require('https');
var querystring = require('querystring');

var projectName = 'docWidgets';
var userName = 'PAYON-AG';
var token = process.env.TOKEN;

var data = querystring.stringify({
    "circle-token": token
});

var options = {
    host: 'circleci.com',
    port: 443,
    path: '/api/v1/project/' + userName + '/' + projectName + '/tree/develop?' + data,
    method: 'POST',
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/x-www-form-urlencoded',
        'Content-Length': Buffer.byteLength(data)
    }
};

var req = https.request(options, function(res) {
    res.setEncoding('utf8');
    res.on('data', function (chunk) {
        console.log(JSON.stringify(JSON.parse(chunk), null, 2));
    });
});

req.write(data);
req.end();