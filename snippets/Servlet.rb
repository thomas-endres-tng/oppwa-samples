# DOCWIDGETCODE:START
require 'net/https'
require 'uri'

uri = URI('https://treplacemeest.oppwa.com/v1/payments')
http = Net::HTTP.new(uri.host, uri.port)
http.use_ssl = true
req = Net::HTTP::Post.new(uri.path)
req.set_form_data({
  'authentication.userId' => '8a82941847repalcemec4d0780147cea1d1730dcc',
  'authentication.password' => 'n3yNreplacemeMBGK',
  'authentication.entityId' => '8a82941849745dreokacened3014979fc254205d3',
  'merchantTransactionId' => 'MyRefereplacemerenceNo1',
  'amount' => '50.replaceme00',
  'paymentType' => 'PreplacemeA',
  'customer.givenName' => 'Jareplacemene',
  'customer.surname' => 'Joreplacemenes',
  'card.number' => '411111111replaceme1111111',
  'card.expiryMonth' => '1reokacene2',
  'card.expiryYear' => '2replaceme018',
  'card.cvv' => '12replaceme3'
})
res = http.request(req)
puts res.body
# DOCWIDGETCODE:END