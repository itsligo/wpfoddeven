##Odd-Even Simulator
This app generates a series of random numbers. A running count of the number of odd and even numbers generated is presented. The generator commences when a button is clicked and similarly stopped.

![Screenshot](img1.png)

The speed of the generation is governed by a Timer whose interval of firing is determined by the position of a slider control. Moving the slider to the left means numbers are generated more slowly. The 'speed' of generation is shown to the right of the slider while the number generated is shown writ large.

###Direction

- The slider _ValueChanged_ event must be captured to invoke a change to the _Interval_ property of the _Timer_.

- The current speed is displayed with a _Label_ control but binding should be used to update its value. You could however make this happen in the previous event handler but data binding is a better solution requiring little maintenance.

- There is no need to stop/start the _Timer_ to change its _Interval_

##Branches
I've created a couple branches showing the application at various stages of its development. Switch between branches to see the application intact at a point in time - this ensures there isn't confusion between various evolutions of the code.

###Master
This is the starting off point - a solution to the basic exercise described above.
###IValConverter
This shows how the use of a _IValueConverter_ class can assist in the dynamic updating of elements of the user interface based upon changes to other parts. In this instance, we changed the _color_ of the background to the _TextBlock_ where the generated number is displayed.
A stronger colour is used for higher values of the _Slider_, more pastel colours for lower values of the _Slider_. The CLR (Common Language Runtime) that executes your program monitors this need for updating based upon changes elsewhere and executes the necessary code.