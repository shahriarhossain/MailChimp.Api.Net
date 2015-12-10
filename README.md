# MailChimp.Api.Net
MailChimp v3.0 .Net wrapper

As the name says **MailChimp.Api.Net** is a .Net wrapper that expose a very simple yet elegant wrapper around the MailChimp RESTful JSON API version 3.0 documented at https://kb.mailchimp.com/api 

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
- You can Create, Read, Delete, Send, Cancel a campaign. However, You can't Update the settings for a campaign yet!
- You can GET and SET campaign Content
- You can only GET and Delete campaign Feedback.right now. i.e. You can't add or update campaign Feedback.
- You can Get the send checklist for a campaign

Conversations:
====
- Conversation section is implemented except one feature. *Post a new conversation message* feature is not implemented yet.

Automation:
===
Right now you can do only following task: 
- You can Get a list of Automation
- You can Get a list of automated emails .
- You can View all subscribers removed from a workflow. 
Other feature involved with Automation will be implemented later.

HOW TO USE
===
You can download it via nuget package.

**PM> Install-Package MailChimp.Api.Net**

