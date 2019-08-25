const http = require('http');

let args = process.argv.slice(2);

const protocol = 'http://'
const ip = '192.168.0.108'
const port = 8080
const uri = 'fibonacci'
let fibonacciPosition  = args[0]

var url = protocol + ip + ':' + port + '/' +uri
if (fibonacciPosition){
	url += '/' + fibonacciPosition
}

http.get(url, (resp) => {
  let data = '';

  resp.on('data', (chunk) => {
    data += chunk;
  });

  resp.on('end', () => {
    console.log(JSON.parse(data));
  });

}).on("error", (err) => {
  console.log("Error: " + err.message);
});