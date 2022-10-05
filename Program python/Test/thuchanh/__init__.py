# if __name__ == '__main__':
#     D, K = [], []
#     n = int(input())
#     for i in range(n):
#         ten, diem, khoa = input().rsplit(' ', 2)
#         D.append((ten, diem)) if khoa == "DDT" else K.append((ten, diem))
#     D.sort(key=lambda x: x[1], reverse=True)
#     print("Giai nhat :%s" % D[0][0])
#     print("Giai nhi :%s" % D[1][0])
#     print("Giai ba :%s" % D[2][0])
#     k = max(K, key=lambda x: x[1])
#     print("Giai giao luu :%s" % k[0])

# import  collections
# n = int(input())
# SV = collections.namedtuple('SV', input() + )
# A =[]
# for i in range(n):
#     x = input()


# hậu tố ba lan
# import queue
#
# S = queue.LifoQueue()
# out = ""
# UT = {"+": 1, "-": 1, "*": 2, "/": 2, "^": 3}
# for c in input():
#     if ('0' <= c <= '9'):
#         out += c
#     elif c == '(':
#         S.put(c)
#     elif c == ')':
#         while S.queue[-1] != '(':
#             out += S.get()
#         S.get()
#     else:
#         while not S.empty() and S.queue[-1] != '(' and UT[S.queue[-1]] >= UT[c]:
#             out += S.get()
#         S.put(c)
# while not S.empty():
#     out += S.get()
# print(out)


# biểu thức cộng Trừ
# import queue
# S = queue.LifoQueue()
# list = []
# for i in input():

import queue

if __name__ == '__main__':
    n = int(input())
    S = queue.LifoQueue()
    S.put((-1, 1e9))
    for i, x, in enumerate(input().split()):
        x = int(x)
        while S.queue[-1][1] <= x:
            S.get()
            while S.queue[-1][1] <= x:
                S.get()
            print(S.queue[-1][0], end=' ')
            S.put((i, x))
