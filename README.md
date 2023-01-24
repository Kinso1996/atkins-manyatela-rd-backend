# atkins-manyatela-rd-backend
This is the backend of the practical test

1. To use the API the database script with name atkins-manyatela-db.sql must be run first
 Curl request samples
 
 curl -X 'POST' \
  'https://localhost:7240/Math/MathResult?firstNumber=10&secondNumber=10&mathOperation=%2B' \
  -H 'accept: text/plain' \
  -d ''
  
  curl -X 'GET' \
  'https://localhost:7240/Math/HistoricalCalculations' \
  -H 'accept: text/plain'
