import math
from django.shortcuts import render
from WAPI.models import GeoPoint



def GetByID(id):
    result = GeoPoint(0,0,0)

    point1 = GeoPoint(1,51,37)
    point2 = GeoPoint(2,52,34)
    point3 = GeoPoint(3,53,35)
    point4 = GeoPoint(4,54,36)
    points = [point1,point2,point3,point4]

    for pt in points:
        if pt.ID == id:
            result = pt

    return result

from django.http import JsonResponse
def GetPointByID(request,id):
    point = GetByID(id)
    data = {'ID':point.ID, 'X':point.X, 'Y':point.Y}
    return JsonResponse(data)

from django.http import HttpResponse

def GetDistance(request,id,x,y):
    point = GetByID(id)
    distance = math.sqrt(point.X + point.Y * id)
    return HttpResponse(distance)