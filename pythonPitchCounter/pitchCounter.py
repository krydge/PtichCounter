def incrimentCounter(count):
    return count+1

def decrimentCounter(count):
    return count-1

def blit():
    for i in range (1,30):
        print()

def pitchCounter():
    count=0
    while True:
        blit()
        print ("pitch count : ")
        print (count)
        input("press enter to increse the counter")
        count=incrimentCounter(count)
    
pitchCounter()