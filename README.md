# FlySphere
## FlySphere: Vacation Rental Service

<p align="center">
  <a href="http://endless.horse">
    <img src=moon.gif alt="spinning-moon" />
  </a>
</p>

## Chapter 01: Preface 

FlySphere is a ‘Vacation Rental Service’ application for connecting travelers to have an easy and safe way of renting out a space or primarily homestays with multiple people to share, a shared space with private rooms, or the entire property for themselves with amazing standards of service to enjoy their vacations. It helps make sharing easy, enjoyable, and safe. The main objective is to provide interface to the user’s credentials, type of room/house for rent, reservation options along with ratings and reviews area by logging in to account. 

## Chapter 02: Design & Implementation 

The ‘FlySphere Vacation Rental Service’ is a desktop-based windows application that is developed using C# .NET platform and SQL database connection that focuses on the adaptation, simulation, and its construction. 

•	ThemeColor - Class: A ThemeColor static class is initially created which declares the properties for the primary and secondary colors. A list of list of string is created to store colors in HTML format. Moreover, a method to change the color of brightness is created to lighten or darken the color.

•	LoginForm: It displays label for username and password for the user and admin to login.

•	FormMainMenu - Form Design: The first windows application form takes place which provides user interface to the FlySphere’s main menu. A menu panel is added with necessary buttons to open the child forms. Random fields and layout elements are initialized in the main menu form constructor. Moreover, methods for selecting theme color, activating, deactivating, and displaying the buttons, opening child forms and to resetting the default values are created.

•	Children/Secondary Forms: Four main secondary forms are designed for Users, Rooms, Reservations and Reviews for the FlySphere user’s rental booking details. The code for these forms includes creation of method to load the theme color and then calling the above method in the constructor event.
