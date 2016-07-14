# <img src="https://learnwithshahriar.files.wordpress.com/2015/11/mailchimp-api-net.png" width="50" height="50" />MailChimp.Api.Net
MailChimp v3.0 .Net wrapper

## Status

![Build status](https://img.shields.io/badge/Build-Passing-brightgreen.svg)
![Nuget status](https://img.shields.io/badge/nuget-v1.2.0.8-blue.svg)
[![license](https://img.shields.io/github/license/mashape/apistatus.svg?maxAge=2592000)]()


As the name says **MailChimp.Api.Net** is a .Net wrapper that expose a very simple yet elegant wrapper around the MailChimp RESTful JSON API version 3.0 documented at https://kb.mailchimp.com/api 

Support
=====
Search issues(https://github.com/shahriarhossain/MailChimp.Api.Net/issues) and pull requests to see if your issue/request already exists. If it does, please leave a comment or a reaction. This helps me priortize what I work on next. Create a new issue if you can't find what you're looking for. :)

Current Status:
====
Reports:
---
The Reports sections are good to go!  You  can retrieve all sorts of mailChimp campaign report. 

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
- You can Create, Read, Delete, and Update Templates. Only issue is MailChimp API does not provide the HTML Property when Reading a Template
The work around is to assign the Template to a campaign and then you can get the campaign content. We have contacted MailChimp and they have responded 
but need some more convincing to include this property or another method to get the Template HTML / Content.

Lists:
---
- You can Create, Read, Delete, and Update Lists.
- You can Create, Read, Delete, and Update List Merge Fields
- You can Create, Read, Delete, and Update List Members as well as Member Merge Fields

Campaigns: 
---
- You can Create, Read, Delete, Send, Cancel a campaign. However, You can't Update the settings for a campaign yet!
- You can GET and SET campaign Content
- You can only GET and Delete campaign Feedback.right now. i.e. You can't add or update campaign Feedback.
- You can Get the send checklist for a campaign

Conversations:
---
- Conversation section is implemented except one feature. *Post a new conversation message* feature is not implemented yet.

Automation:
---
Right now you can do only following task: 
- You can Get a list of Automation
- You can Get a list of automated emails .
- You can View all subscribers removed from a workflow. 
Other feature involved with Automation will be implemented later.

HOW TO USE
===
You can download it via nuget package.

**PM> Install-Package MailChimp.Api.Net**

For details on how to use check the wiki https://github.com/shahriarhossain/MailChimp.Api.Net/wiki/Initial-Setup

