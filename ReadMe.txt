Hello, my name is Nicholas Dobos, and welcome to my PeerMetrix interview project.

I hope you find that I have created a satisfactory API. 

First things first, I gotta go over some details you can use to get this up and running:

You're going to have to have a sql server instance, and add in your connection string. Then you will need to run the fixedrolename migration. Once that is done, 
you will need to add in some dummy data, starting with Roles. I created the three roles, User, Moderator, and Administrator that way. The reason you need to start
with roles is because it's the only ones without required foreign keys. Everything should speak for itself afterwards.

I'll add a couple of notes here:

Firstly, I don't really know how identity generally interacts with WebApis. It is my understanding that the API will be exposed to a
web app that will have users log in and out. I did not actually add identity as a dependency, but I did comment in some code that 
demonstrates how I envision that policy system would be. Data annotated policies required on the controllers that match the roles given.

Obviously, I ran out of time. I actually recorded the whole session so if you would like, you can take a look and hear my thought process
as I went through. I felt like this would be a more personal way to convey the way that I code. You can even see the problems I ran into!

I might have missed some of my resources that I used, especially towards the end, which is precisely why I wanted to include the 'video evidence'.

I hope that it doesn't seem like I did way too much for this, but this really felt like the best format to present the info. 

That being said, thank you for the opportunity.

Hope to hear from you soon,

-Nick
