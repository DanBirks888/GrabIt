
# Grab It!

:ok_hand: :ok_hand: :ok_hand: :ok_hand: :ok_hand:
### Easy use String manipulation library

## General

```c#
    public static string LowerCaseAndSpaceReplace(string input)
```
Don't let messy strings get into your params! <br>
It does what it says on the tin! :baby_bottle:
___
## URLs

#### Removes start of URLs

```c#
    public static string LinkShaver(string input)
```
Some individuals really struggling to copy and paste links correctly!<br>
Never fear! LinkShaver() is here! :bowtie:

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

## Etiquette

#### Removes Profanity

```c#
    public static string ProfanityFilter(string rant, Dictionary<string, string> dict)
```
No one likes a dirty mouth! :unamused: But no need to silence them! <br>
Pass a Dictionary with the Key as the naughty word and the value as a cute alternative! :blush:

|Key |Value |
|---|--- |
| :angry:naughtyWord :angry:| :angel:NiceWord :angel:|