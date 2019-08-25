#!/bin/env python
import requests
import pprint

ip = 'http://192.168.0.108:8080'
addreses = [ ip + "/" ,
            ip + "/fibonacci",
            ip + "/fibonacci/20",
            ip + "/data" ]

pp = pprint.PrettyPrinter(indent= 4)
for item in addreses:
    print("-------------------------")
    r = requests.get(url = item)
    data = r.json()
    if isinstance(data, list):
        pp.pprint(data)    
    else:
        print(data.encode('utf-8'))
    pass
