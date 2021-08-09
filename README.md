# Unit2_Chapter20_Walkthrough

Section 1: Application Purpose
  The purpose of this application is to act as an organizational tool for the user. This is accomplished by allowing the user to 
  log upcomming events and include a detailed description about each event.
  
  Section 2: Current State Of Application
    The application currently allows a local user to add an event to a list, add details that specify the type of event, location and
    other small details. This information is then stored in a MySQL database on the local computer.
    
   Section 3: Future Improvements
    Future improvements of the application will include functionality to allow individual users to create an account and log into the app.
    This will allow the application to serve multiple users as opposed to just a single local user. 
    
     1)	Methods in the Person class should include
        a.	Register – to add the new user to a database and assign values to all of the necessary properties
        b.	Remove – to delete all user information if they decide to cancel their account.
        c.	A constructor to initialize the properties.
        Properties should include
        d.	Name
        e.	ID
        f.	Date Joined
        g.	Password
        h.	Additional security questions and answers 
        i.	A calendar Id and instance of the calendar class to link the two together in a one-to-one relationship 
    2)	A class would be required for the login page to authenticate the user’s information and validate the format. A view model would be required to verify that the information the user input for their account information is valid. 
        A class for administration would be needed to deal with account issues. 
        A calendar class would be required for each user to be able to access a personalized calendar. 

    3)	The Person class would have a one-to-many relationship with the Event class, as each person can be registered for multiple events at the same time.
        The person class would also have a one-to-one relationship with the calendar class, as each user would only have 1 calendar. 
