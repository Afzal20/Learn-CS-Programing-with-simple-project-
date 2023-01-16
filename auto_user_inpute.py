import pyautogui
import time

name = "KGF2"
ratings = "5 Stars"
releseYear = "2022"
Language = "Hindi"
Herro = "Yash"
Herroin = "Srinidhi Shetty"
villan = "Sanjay Dutt"
linksToDowenload = "https://www.youtube.com/watch?v=lbknedbzPG0" 
AavailableOnYoutub = "Yes"
movietype = "Theatrical"
country = "INDIA" 

details = [name, 
        ratings, 
        releseYear, 
        Language, 
        Herro, 
        Herroin, 
        villan, 
        linksToDowenload,
        AavailableOnYoutub,
        movietype,
        country
        ]

time.sleep(3)

for i in details:
    pyautogui.typewrite(i)
    pyautogui.press("enter")
