from django.db import models

# Create your models here.
class User(models.Model):
    username = models.CharField(max_length=200)
    email = models.EmailField()
    fullname = models.CharField(max_length=200)
    role = models.CharField(max_length=200)