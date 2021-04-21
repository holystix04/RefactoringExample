# Refactoring Example in C#

## Description
You are asked to refactor the UserService class, and more specifically, its AddUser method. Assume that the code is sound in terms of
business logic and only focus on applying clean code principles. Keep in mind acronyms such as SOLID, KISS, DRY, and YAGNI. Additionally,
you MUST write at least one test that tests the "happy path" through the AddUser method.

Try to keep this exercise below 2 hours. If you still have things you can improve after the 2 hour mark, please write them down and commit
the list to your branch in a markdown file named <yourname>.md (for example jclark.md)


## Limitations
The Program.cs class in the LegacyApp.Consumer project SHALL NOT CHANGE AT ALL. This includes using statements. Assume that this codebase
is part of a greater system and any non-backwards compatible change will break the system. Any sort of change in that class will be viewed
as a system-breaking change.

You can change anything in the LegacyApp project except for the UserDataAccess class and its AddUser method. However, the UserDataAccess
class and it's AddUser method MUST stay static.
