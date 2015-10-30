# MailChimp.Api.Net
MailChimp v3.0 .Net wrapper

As the name says **MailChimp.Api.Net** is a .Net wrapper that expose a very simple yet elegant wrapper around the MailChimp RESTful JSON API version 3.0 documented at https://kb.mailchimp.com/api 

If you think you've found a bug, create an issue. Pull requests are gladly accepted, but if you are planning to make big change you should discuss it to make sure we all are in the same page. 

Current Status:
====
Reports:
---
The Reports sections are good to go! 

- Reports Overview
- Campaign Advice
- Click Reports
- - Click Reports Members
- Domain Performance
- EepURL Reports
- Email Activity
- Location
- Sent To
- Sub-Reports
- Unsubscribes

Templates:
---
The Templates sections are good to go! 

Campaigns: 
---
- Right now you can READ and DELETE Campaign Info. However *Cancel a campaign* feature is not implemented yet.
- You can READ and DELETE Campaign feedback. However *Create Feedback* and *Edit Feedback* feature is not implemented yet.

Conversations:
====
- Conversation section is implemented except one feature. *Post a new conversation message* feature is not implemented yet.



HOW TO USE
===
You can download it via nuget package.

**PM> Install-Package MailChimp.Api.Net**

