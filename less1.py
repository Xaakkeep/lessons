price = [27,100,55,14]
count = [2,5,1,4]
i= 0
s = 0
while i< len(price):
    s = s + price[i] * count[i]
    i = i+1
print(s)