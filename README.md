# **ClinicApp**

A health care system for a clinic. Created by the CS6232-G1 Team.

---

### Table of Contents

- [**Iteration 0**](#markdown-header-iteration-0-91top93)
- [**EERD for the Database**](#markdown-header-eerd-for-the-database-91top93)
- [**MockUp**](#markdown-header-mockup-91top93)
- [**Product Backlog**](#markdown-header-product-backlog-91top93)
- [**Team notes**](#markdown-header-team-notes-91top93)

---

# **Iteration 0** [\[Top\]](#markdown-header-clinicapp)
[Group Trello Board](https://bitbucket.org/cs6232g1/clinicapp/addon/trello/trello-board)

---

# **EERD for the Database** [\[Top\]](#markdown-header-clinicapp)

![g1_EER_SQL.png](https://bitbucket.org/repo/daB4z5K/images/1659154493-g1_EER_SQL.png)

SQL files to create the database and fill with dummy data are in [the repository](https://bitbucket.org/cs6232g1/clinicapp/src/master/DB/).

---

# **MockUp** [\[Top\]](#markdown-header-clinicapp)

![Login.jpg](https://bitbucket.org/repo/daB4z5K/images/3619841586-Login.jpg)
![Admin - Report.jpg](https://bitbucket.org/repo/daB4z5K/images/2809057245-Admin%20-%20Report.jpg)
![Admin -Nurse Information.jpg](https://bitbucket.org/repo/daB4z5K/images/2917518784-Admin%20-Nurse%20Information.jpg)
![Nurse- Make Appointments.jpg](https://bitbucket.org/repo/daB4z5K/images/2743592354-Nurse-%20Make%20Appointments.jpg)
![Nurse - Appointment Add-Update.jpg](https://bitbucket.org/repo/daB4z5K/images/943493607-Nurse%20-%20Appointment%20Add-Update.jpg)
![Nurse - Patient Information.jpg](https://bitbucket.org/repo/daB4z5K/images/3676928478-Nurse%20-%20Patient%20Information.jpg)
![Nurse- Patient Visit.jpg](https://bitbucket.org/repo/daB4z5K/images/320080998-Nurse-%20Patient%20Visit.jpg)
![Nurse - Patient Visit - Edit-View.jpg](https://bitbucket.org/repo/daB4z5K/images/1629364743-Nurse%20-%20Patient%20Visit%20-%20Edit-View.jpg)
![Search Dialog.jpg](https://bitbucket.org/repo/daB4z5K/images/2412613721-Search%20Dialog.jpg)
---

# ** Product Backlog ** [\[Top\]](#markdown-header-clinicapp)

Hosted on [Google Docs](https://docs.google.com/document/d/1r_GB-A6_4Gx2RRnQurWnJoBDfgpMOI6uDqbYLkceDa4/edit?ts=5c58798e)

* As a nurse or admin, I want to be able to log in with my username and password so that I can access the system
* As a nurse or admin, I want to be able to see that I am logged in as the correct  role so that I can tell that I have access to the correct information
* As a nurse, I want to be able to identify existing patients by DOB, or name (last name & first name) or a combination of DOB and last name
* As a nurse, I want to be able to set up an appointment for existing patients with a doctor on a specific date and time
* As a nurse, I want to be able to select clinic doctors from a dropdown menu when setting up appointments
* As a nurse, I want to be prompted to add a new patient after finding no matches when searching
* As a nurse, I want to be able to add a new patient's information to the system
* As a nurse, I want to be able to view patient appointment information so that I know what patients I will be seeing and what they are coming in for.
* As a nurse, I want to be able to search for a patient’s personal information and appointment information by date of birth so I can easily access their records
* As a nurse, I want to be able to search for a patient’s personal information and appointment information by last name and first name so I can easily access their records
* As a nurse, I want to be able to search for a patient’s personal information and appointment information by a combination of DOB and last name so I can easily access their records
* As a nurse, I want to be able to view appointment information if the appointment time has passed so that I can efficiently perform my follow up procedures. 
* As a nurse, I want to be able to edit the details of the appointment if it is not the appointment date yet so that I can properly care for the patient.
* As a nurse, I want to be able to update patient information
* As a nurse, I want to be able to delete a patient if there is no appointment associated with the patient
* As a nurse, I want to be able to view the visit information such as routine check results and any tests ordered so that I can retrieve the proper results. 
* As a nurse, I want to be able to edit the visit by entering test results and final diagnosis so that we can start treatment on the patient.
* As a nurse, I want to be able to order lab test for a patient
* As a nurse, I want to be able to choose the various lab tests available from a dropdown menu
* As a nurse, I want to be able to see the tests that have been ordered and make changes (remove or add tests to the list) 
* As a nurse, I want to be able to finalize a diagnosis so that it cannot be changed and records are kept secure and accurate. 
* As an administrator, I want to be able to search for a nurse’s personal information by date of birth so I can easily access their records
* As an administrator, I want to be able to search for a  nurse’s personal information by last name and first name so I can easily access their records
* As an administrator, I want to be able to search for a nurse’s personal information by a combination of DOB and last name so I can easily access their records
* As an administrator, I want to be prompted to add a nurse who is not found in the system
* As an administrator, I want to be able to add a person with the nurse role to the system
* As an administrator, I want to be able to update a nurse’s information in the system
* As an administrator, I want to be able to flag a nurse as active or inactive in the system
* As an administrator, I want to be able to generate a report in a tabular format. To do this I should be able to enter a start date and end date so that we can analyze the tests that are given among different age groups. Then, the report will show the following information: 
>* Test code
>* Test name
>* Total number of times the qualified test has been performed in the given date range
>* Total number of times all tests have been performed in the given date range
>* The percentage of the number of times the qualified test was performed out of the total test performed
>* The number of normal results for the qualified test in the date range
>* The number of abnormal results for the qualified test in the date range
>* The percentage of the total number of times that the test was performed on a patient in the age 18-29 (at the time the test was performed) over the total number of times that the test was performed in the date range. 
>* The percentage of the total number of times that the test was performed on a patient in the age 30-39 (at the time the test was performed) over the total number of times that the test was performed in the date range.
>* The percentage of all other age groups who took the test
* As an administrator, I want to be able to see this report sorted in order of the most performed to the least performed tests. If they have been performed the same number of times, then they should be sorted by test code in descending order so that I can efficiently analyze the data.
* As an administrator, I want to be able to update a nurses information
* As an administrator, I want to be able to view a nurses information
* As an administrator, I want to be able to create a new nurse

---

# **Team notes** [\[Top\]](#markdown-header-clinicapp)

### Team CS6232-G1 Members:

+ Jean Blakely (jblakel2@my.westga.edu)
+ James Johnson (jjohn144@my.westga.edu)
+ Joseph Marinelli (jmarine1@my.westga.edu)

### Notes

*3/3* - Luke: Updated the Wiki with formatting, links, and table of contents.

*2/21* - Jeannie: I continued work on the mockup.  Added just the very start of the stored procedure for later.

*2/21* - Joey: Made changes to backlog on this page to reflect the changes Jeannie made

*2/19* - Jeannie: I got sidetracked by HW5 and haven't worked much at all on the project.  I did make some additions to Joey's backlog on the shared google doc page (it's in red) based on some of the details I was noticing in the HW assignments.  I'm going to try to get back on the mockup.  Does anyone know what we need to do with the Issue Tracker (it's mentioned in Iteration0)?

*2/11* - Joey: Everything seems to be moving along smoothly. I will be working on pushing some more commits to the MathQuiz project tomorrow. I think all we  still have to do is put the links to the mockups and DB design on this wiki. I do not think Dr. Yang can see the Trello board under the boards section. I had to login through my trello account to see it. 

*2/6* - Luke: I created the EER and changed the TestOrdered table foreign key to reference Appointment rather than Visit. I also generated hundreds of lines of dummy data so we can play with actual queries when we're working on this DB.

*2/5* - Jeannie: I got a note from Dr Yang (ie our customer) saying that a single diagnosis per visit was just fine - so no need to add an extra diagnosis table.  I'll forward it to the trello board to keep track.

*2/5* - Jeannie: Joey, I did some work cloning, branching, modifying and then pushing your mathquiz repo.  Should we be doing our work in separate branches do you think?  I'm still a little shaky on merging stuff (and having things be x steps ahead).  If you want to do some back and forth with it, I'm happy to oblige.

*2/4* - Jeannie:  I fiddled around with some of the UI tools in LucidChart and started working on some mockups.  Very basic (and very unoriginal - stunningly similar to our homework project).  Thought it would get the ball rolling though and help to throw down some thoughts.  Posted the link on the Trello board.  The link should be an "invite" to edit - feel free to do that.