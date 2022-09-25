# # # from itertools import combinations
# # # a = [4, 7, 2, 8, 1,6]
# # # b = list(combinations(a, 2))
# # # c = [1 for u, v in b if u > v]
# # # print(sum(c))
# #
# # a = [4, 7, 2, 8, 1, 6]
# #
# # b = a[::-1]
# # b = list([x > y for x, y in range(a, b)])
#
# # #
# # from collections import namedtuple
# #
# # diem = namedtuple(('point', "x y"))
# # x = int(input())
# # y = int(input())
# # a = diem(x, y)
# #
# # print(A)
#
# # if __name__ == '__main__':
# #     a=[]
# #     n = int(input('nhap n: '));
# #     for i in range(n):
# #         u, v = map(float, input().split())
# #         a.append()
# from collections import namedtuple
#
# from Tools.scripts.mailerdaemon import x
#
# Diem = namedtuple("D", "x y")
#
#
# def bpkc(a, b):
#     return (a.x - b.x) ** 2 + (a.y - b.y) ** 2;
#
#
# def tim(a, b, m):
#     while abs(a.x - b.x) > 1e-6 or abs(a.y - b.y) > 1e-6:
#         c = Diem((a.x + b.x) / 2, (a.y + b.y) / 2)
#         if bpkc(a, m) > bpkc(b, m):
#             a = c
#         else:
#             b = c
#     return a, bpkc(a, m)
#
# def dt(a, b): return a.x + b.y - a.y * b.x
# def s(a, b, c):
#     return abs(dt(a, b) + dt(b, c) + (c, a))/2
#
# if __name__ == '__main__':
#     x1, y1, x2, y2, x3, y3, x4, y4 = map(float, input().split())
#      a = Diem(x1, y1)
#      b = Diem(x2, y2)
#      c = Diem(x3, y3)
#      m = Diem(x4, y4)
#     if s(a,b, c) == s(a, b, m)+ s(a, c, m) + s(b, c, m):
#         print("%.3f %.3f" %(m.x, m.y))
#     else:
#         A1, a1 = tim(b, c, m)
#         B1, b1 = tim(a, c, m)
#         C1, c1 = tim(b, a, m)
#         d = min(a1, b1, c1)
#         if d == b1:
#             print("%.3f %.3f" %(A1.x, A1.y))
#         elif d == b1: print("%.3f %.3f" %(B1.x, B1.y))
#         else print("%.3f %.3f" %(C1.x, C1.y))
import queue
# from queue import Queue, LifoQueue, PriorityQueue
# # Q = Queue()
# # Q = LifoQueue()
# Q = PriorityQueue()
# for x in ["1", "2", "3", "4", "5", "6", "7"] : Q.put(x)
# while not Q.empty(): print(Q.get(), end=" ")

# import  queue
# Q = queue.Queue()
# for x in [4, 7, 2, 8, 1]: Q.put(x)
# Q.queue[1] = 5
# Q.queue[-2] = 9
# # print(Q.queue[0])
# # print(Q.queue[-1])
# while Q.qsize() > 0: print(Q.get(), end=" ")

# import  queue
# Q = queue.Queue()
# for x in [1, 2, 3, 4]: Q.put((x, 1))
# n = int(input())
# while n>0:
#     z = Q.get()
#     if n <= z[1]:
#         print(z[0])
#         break
#     n -= z[1]
#     Q.put((z[0], z[1] * 2))
# print(*Q.get())

 # bài toán nối thanh kim loại python
# from queue import PriorityQueue
#
# n = int(input())
# a = input().split()
# Q = queue.PriorityQueue()
# for x in a: Q.put(int(x))
# t = 0
# while Q.qsize() > 1:
#     u = Q.get()
#     v = Q.get()
#     Q.put(u + v)
#     t += u + v
# print(t)

# PriorityQueue có tính chất
# 1. Lấy phần tử nhỏ nhất ra trước
# 2. Nếu có 2 phần tử có cùng giá trị thì lấy ra phần tử đầu tiên
# Để lấy ra giá trị lớn nhất trước thì đảo ngược giá trị của phần tử vd: -x
# phần tử trung vị là gì
# 1. Nếu số phần tử là số lẻ thì phần tử trung vị là phần tử ở giữa
# 2. Nếu số phần tử là số chẵn thì phần tử trung vị là phần tử ở giữa 2 phần tử ở giữa
# tìm trung vị bằng hàng đợi ưu tiên
# import  queue
# Q = queue.PriorityQueue()
# n = int(input())
# a = input().split()
# for x in a: Q.put(int(x))
# for i in range(n//2): Q.get()
# print(Q.get())

# tìm trung vị sử dụng hai hàng đợi ưu tiên
import  queue
Q1 = queue.PriorityQueue()
Q2 = queue.PriorityQueue()
n = int(input())
a = input().split()
for x in a:
    Q1.put(int(x))
    Q2.put(-Q1.get())
    if Q1.qsize() < Q2.qsize(): Q1.put(-Q2.get())
if Q1.qsize() > Q2.qsize(): print(Q1.get())
else: print((Q1.get() - Q2.get())/2)
