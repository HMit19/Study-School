# # from itertools import combinations
# # a = [4, 7, 2, 8, 1,6]
# # b = list(combinations(a, 2))
# # c = [1 for u, v in b if u > v]
# # print(sum(c))
#
# a = [4, 7, 2, 8, 1, 6]
#
# b = a[::-1]
# b = list([x > y for x, y in range(a, b)])

# #
# from collections import namedtuple
#
# diem = namedtuple(('point', "x y"))
# x = int(input())
# y = int(input())
# a = diem(x, y)
#
# print(A)

# if __name__ == '__main__':
#     a=[]
#     n = int(input('nhap n: '));
#     for i in range(n):
#         u, v = map(float, input().split())
#         a.append()
from collections import namedtuple

from Tools.scripts.mailerdaemon import x

Diem = namedtuple("D", "x y")


def bpkc(a, b):
    return (a.x - b.x) ** 2 + (a.y - b.y) ** 2;


def tim(a, b, m):
    while abs(a.x - b.x) > 1e-6 or abs(a.y - b.y) > 1e-6:
        c = Diem((a.x + b.x) / 2, (a.y + b.y) / 2)
        if bpkc(a, m) > bpkc(b, m):
            a = c
        else:
            b = c
    return a, bpkc(a, m)

def dt(a, b): return a.x + b.y - a.y * b.x
def s(a, b, c):
    return abs(dt(a, b) + dt(b, c) + (c, a))/2

if __name__ == '__main__':
    x1, y1, x2, y2, x3, y3, x4, y4 = map(float, input().split())
     a = Diem(x1, y1)
     b = Diem(x2, y2)
     c = Diem(x3, y3)
     m = Diem(x4, y4)
    if s(a,b, c) == s(a, b, m)+ s(a, c, m) + s(b, c, m):
        print("%.3f %.3f" %(m.x, m.y))
    else:
        A1, a1 = tim(b, c, m)
        B1, b1 = tim(a, c, m)
        C1, c1 = tim(b, a, m)
        d = min(a1, b1, c1)
        if d == b1:
            print("%.3f %.3f" %(A1.x, A1.y))
        elif d == b1: print("%.3f %.3f" %(B1.x, B1.y))
        else print("%.3f %.3f" %(C1.x, C1.y))