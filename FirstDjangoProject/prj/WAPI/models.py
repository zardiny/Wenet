from django.db import models

class GeoPoint (): 
    def __init__(self,id,x,y):
        self.ID = id
        self.X = x
        self.Y = y
