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

---

## Coding
* Move at a certain speed every frame.
* Change direction upon nearing the edge of the play area.
* Also sometimes change direction based on random chance.
* Drop an apple every second.

![Chapter Diagram by Jeremy Gibson Bond](https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9780136619918/files/graphics/29fig10.jpg)

*Image by Jeremy Gibson Bond*

## Coding Cont'
* Dynamically add baskets
* Remove a basket when the player misses an apple
* Score
    * Set the current score
    * Set the High score when the current score > memory `HighScore`
    * Set the `HighScore` Value in the PlayerPrefs
    * Set a reset checkbox to reset the `HighScore`
___
###### This project was made in Unity 2020
