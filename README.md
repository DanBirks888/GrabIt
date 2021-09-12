
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

| Removes        | Description | Works |
| ------------- |:------------:| :----: |
| Https://www.github.com |Full Secure URL |  Yes  |
| Http://www.github.com  |Full Unsecure URL| Yes  |
| www.github.com         |Normal URL     |  Yes   |
| w w w.github.com       |Spaces In URL  |  Yes   |
| w.github.com          |Missing part of URL| Yes |
|https://wwwgithub.com | Missing dot URL | Yes |
|http://wwwgithub.com  | Missing dot URL | Yes |
|https//github.com     | Missing dot URL | Yes |
|http//github.com      | Missing Dot URL | Yes |
|wwwgithub.com         | Missing Dot URL | Yes |
___
