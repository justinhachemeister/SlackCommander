# SlackCommander

Useful (?) slash commands and miscellaneous integrations for Slack.


## Slash commands 

`/whois [e-mail or Twitter handle]`

Performs a lookup and sends a brief summary of who the person behind the e-mail 
address or Twitter handle is to the current channel. Requires a 
[FullContact](http://www.fullcontact.com/developer/person-api/) API key
(the free tier currently includes 250 lookups per month).

**Example:**

    /whois @SlackHQ

SlackCommander responds to the current channel with something similar to this:

![SlackCommander /whois example response](https://raw.githubusercontent.com/Hihaj/SlackCommander/master/whois-result.png)


## Misc. integrations

- **MailChimp webhook for new subscribers** - automatically posts a notification
  to a preconfigured Slack channel about the new list signup + initiates a whois 
  lookup (which is also posted to the channel when complete).