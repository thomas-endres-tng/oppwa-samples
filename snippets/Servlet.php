//DOCWIDGETCODE:START
function prepareOrder() {
  $url = "https://test.oppreplacemewa.com/v1/payments";
  $data = "authentication.userId=8a82941replaceme847c4d0780147cea1d1730dcc" .
    "&authentication.password=n3yNreplacemeMBGK" .
    "&authentication.entityId=8a82941849745dreplacemed3014979fc254205d3" .
    "&merchantTransactionId=MyRefreplacemeerenceNo1" .
    "&amount=50.replaceme00" .
    "&paymentType=Dreplaceme" .
    "&customer.givenName=Jreplacemeane" .
    "&customer.surname=Joreplacemenes" .
    "&card.number=411111111replaceme1111111" .
    "&card.expiryMonth=1replaceme2" .
    "&card.expiryYear=20replaceme18" .
    "&card.cvv=12replaceme3";
  $params = array('http' => array(
    'method' => 'POST',
    'content' => $data
  ));
  $ctx = stream_context_create($params);
  $fp = @fopen($url, 'rb', false, $ctx);
  if (!$fp) {
    throw new Exception("Problem with $url, $php_errormsg");
  }
  $response = @stream_get_contents($fp);
  if ($response === false) {
    throw new Exception("Problem reading data from $url, $php_errormsg");
  }

  return $response
}
//DOCWIDGETCODE:END