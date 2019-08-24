#!/bin/env python
import requests

ip = 'http://192.168.0.108:8080'
addreses = [ ip + "/" ,
            ip + "/fibonacci",
            ip + "/fibonacci/20", ]


for item in addreses:
    print("-------------------------")
    r = requests.get(url = item)
    data = r.json()
    print(data.encode('utf-8'))
    pass
