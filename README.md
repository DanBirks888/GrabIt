
# Grab It!
### An easy to use string manipulation library

## General

```c#
    public static string LowerCaseAndSpaceReplace(string input)
```
Method makes string lower case and removes all spaces
___
## URLs

#### Removes start of URLs

```c#
    public static string LinkShaver(string input)
```
This method is dependant on the user 

| Removes        | Description | Result |
| ------------- |:------------:| :----: |
| Https://www. |Full Secure URL |  Yes  |
| Http://www.  |Full Unsecure URL| Yes  |
| www.         |Normal URL     |  Yes   |
| w w w.       |Spaces In URL  |  Yes   |
| w.          |Missing part of URL| Yes |
| link.com     |Missing First dot| No  |
___
