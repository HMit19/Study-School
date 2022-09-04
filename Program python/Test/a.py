# from itertools import combinations
# a = [4, 7, 2, 8, 1,6]
# b = list(combinations(a, 2))
# c = [1 for u, v in b if u > v]
# print(sum(c))

a = [4, 7, 2, 8, 1, 6]

b = a[::-1]
b = list([x > y for x, y in range(a, b)])
