# Apple Picker

Chapter 29 of [Introduction to Game Design, Prototyping, and Development - Jeremy Gibson Bond](https://learning.oreilly.com/library/view/introduction-to-game/9780136619918/ch29.xhtml#ch29lev1sec2)

## The Apple Picker Prototype
Focusing on: 

* Moving a GameObject to follow the mouse
* Using Invoke() to call a function after a specified delay
* Time-based movement of GameObjects
* Randomizing the movement of GameObjects
* Displaying score and high score on screen
* Using PlayerPrefs to track high score across multiple games
* Using Physics Layers to specify which GameObjects will collide with others and much more!

---
## The AppleTreeMain scene

`AppleTree` GameObject - with a ridged body, and two other 3d objects to resemble a Tree.

* Leaves with a `Mat_Leaves` material
* Trunk with a `Mat_wood` material

`Apple` GameObject - with a ridged body and three other 3d objects to resemble a apple.

* Apple body with a `Mat_Apple` material
* 2 AppleLeaf's with a `Mat_apple` material

`Baket` GameObject as a 3d Cube - with a ridged body set to *Kinematic* and includes a `Mat_Basket` material


___
###### This project was made in Unity 2020