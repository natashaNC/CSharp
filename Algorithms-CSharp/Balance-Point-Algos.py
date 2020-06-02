# Balance Point
# Write a function that returns whether the given array has a balance point between indices, where one side’s sum is equal to the other’s. Example: [1,2,3,4,10] → true (between indices 3 & 4), but [1,2,4,2,1] → false.

# Balance Index
# Here, a balance point is on an index, not between indices. Return the balance index where sums are equal on either side (exclude its own value). Return -1 if none exist. Ex.: [-2,5,7,0,3] → 2, but [9,9] → -1.

# http://pythontutor.com/visualize.html#mode=edit
# https://repl.it/~

def balanceIndex(Idx):
    left_side = 0
    right_side = 0
    for (i=0, i<=len(Idx-1), i++):
        for (j=0, j<Idx[i], j++):
            left_side += idx[j]
        for(k=len(Idx-1), k>Idx[i], i--):
            right_side += idx[k]
        if left_side == right_side:
            return Idx[i]
    
    return - 1
    
    print(balanceIndex([-2,5,7,0,3]))

