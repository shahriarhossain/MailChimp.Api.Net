using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Services.Reports;
using MailChimp.Api.Net.Services.Templates;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Services.Campaigns;
using MailChimp.Api.Net.Domain.Campaigns;
using Newtonsoft.Json;
using MailChimp.Api.Net.Domain;
using MailChimp.Api.Net.Domain.Lists.Post;
using System.IO;
using MailChimp.Api.Net.Helper;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Services.Lists;
using System.Diagnostics;
using MailChimp.Api.Net.Domain.BatchOperation;
using Newtonsoft.Json.Converters;
using MailChimp.Api.Net.Services.BatchOperation;
using MailChimp.Api.Net.Services;
using SharpCompress.Reader;
using SharpCompress.Common;
using System.Threading;

namespace MailChimp.Api.Net
{
  public class Program
  {
    private static void Main(string[] args)
    {
      MailChimpReports reports = new MailChimpReports();

      try
      {
        //var x = reports.getoverviewbycampaign("3709ea682b").result;
        //var x2 = reports.getoverviewbycampaign("e6e1eb2be8").result;
        //var x3 = reports.getadvice("e6e1eb2be8").result;
        //var x4 = reports.getclickdetails("e6e1eb2be8").result;
        //var x5 = reports.getclickdetailbylinkid("e6e1eb2be8", "6defea2fac").result;
        //var x6 = reports.getalllsubscribersinfo("e6e1eb2be8", "6defea2fac").result;

        ////subscriber_hash= the md5 hash of the lowercase version of the list member’s email address
        //// var x7 =reports.Getsubscriberinfo("e6e1eb2be8", "e6e1eb2be8", string subscriber_hash);
        //var x8 = reports.getdomainperformance("e6e1eb2be8").result;
        //var x9 = reports.geteepurlactivity("e6e1eb2be8").result;
        //var x10 = reports.getemailactivity("e6e1eb2be8").result;
        //// var x11 = reports.getemailactivitybysubscriber("e6e1eb2be8",);
        //var x12 = reports.gettoplocation("e6e1eb2be8").result;
        //var x13 = reports.getrecipientsinfo("e6e1eb2be8").result;
        ////   var x14= reports.Getcampaignrecipient("e6e1eb2be8");
        //var x15 = reports.getreportforchildcampaign("e6e1eb2be8").result;
        //var x16 = reports.getunsubscriberlist("e6e1eb2be8").result;
        //  var x17 =getunsubscriberinfo("e6e1eb2be8", string subscriber_hash)

        //var k = reports.getoverview().result;
        //var clickdetails = reports.getclickdetails("3709ea682b").result;

        //var x = reports.getoverviewbycampaign("3709ea682b").result;
        //var performance = x.timeseries;
        //List<Timesery> listOfPerfmance = performance.ToList<Timesery>();
        //var templates = new MailChimpTemplates();

        //var z = reports.GetOverviewByCampaign("3709ea682b").Result;

        //  var f = templates.GetTemplates().Result;

        //var k = templates.DeleteATemplate("18085").Result;
        //var kk = templates.GetTemplate("18085").Result;

        #region CampaignCreation

        //MailChimpCampaigns campaign = new MailChimpCampaigns();
        //MCCampaignsOverview overview = new MCCampaignsOverview();

        //Recipients recipients = new Recipients()
        //{
        //    list_id = "0a84a63afc"
        //};

        //Settings campaignSettings = new Settings()
        //{
        //    subject_line = "Schedule Mail Subject ",
        //    title = "Schedule Mail!!! ",
        //    from_name = "Shahriar Hossain",
        //    reply_to = "shossain@desme.com",
        //    template_id = 18073,
        //    authenticate = true,
        //    auto_footer = false
        //};
        //Tracking campaignTracking = new Tracking()
        //{
        //    opens = true,
        //    html_clicks = true,
        //    text_clicks = true
        //};

        //ResultWrapper<Campaign> campaignCreationResult = overview.CreateCampaign(Enum.CampaignType.regular, recipients, campaignSettings, campaignTracking).Result;

        //if (campaignCreationResult.HasError == false)
        //{
        //    ContentTemplate template = new ContentTemplate()
        //    {
        //        id = "18073"
        //    };

        //    ContentSetting cSetting = new ContentSetting();
        //    string path = @"C:\Users\Wahid\Documents\Visual Studio 2012\Projects\MailChimp.Api.Net\MailChimp.Api.Net\EmailTemplates\raw_email_01.txt";
        //    FileParser parser = new FileParser();
        //    cSetting.html = parser.EmailParser(path);

        //    MCCampaignContent campaignContent = new MCCampaignContent();
        //    var setContentStatus = campaignContent.SetCampaignContent(campaignCreationResult.Result.id, cSetting).Result;

        //    MCCampaignsCheckList mccheckList = new MCCampaignsCheckList();
        //    var checkListResult = mccheckList.GetCampaignContent(campaignCreationResult.Result.id).Result;

        //    if (checkListResult.is_ready)
        //    {
        //        var sendStatus = overview.SendCampaign(campaignCreationResult.Result.id).Result;
        //    }
        //}
        //else
        //{
        //    String.Format("Best of Luck :p !");
        //}

        #endregion CampaignCreation

        #region Add single people to a List

        //MailChimpList lists = new MailChimpList();
        //MCMember member = new MCMember()
        //{
        //    email_address = String.Format("SHAHRIARTEST@desme.com"),
        //    email_type = "html",
        //    language = "English",
        //    status = SubscriberStatus.subscribed.ToString()
        //};
        //var x = lists.AddMember(member, "0a84a63afc").Result;

        #endregion Add people to List

        #region Add multiple members in list with single call

        //RootBatch batchObj = new RootBatch();
        //MCMember member = new MCMember();
        //for (int i = 828; i < 833; i++)
        //{
        //    member.email_address = String.Format("Rifat{0}@test.com", i);
        //    member.email_type = "html";
        //    member.language = "English";
        //    member.status = SubscriberStatus.subscribed.ToString();

        //    var settings = new JsonSerializerSettings
        //    {
        //        NullValueHandling = NullValueHandling.Ignore,

        //        Converters = new List<JsonConverter> 
        //        { 
        //            new IsoDateTimeConverter()
        //            {
        //                DateTimeFormat= "yyyy-MM-dd HH:mm:ss"
        //            }
        //        }
        //    };

        //    var myContentJson = JsonConvert.SerializeObject(member, settings);

        //    SingleOperation singleOpt = new SingleOperation();
        //    singleOpt.method = "POST";
        //    singleOpt.path = String.Format("/{0}/{1}/{2}", TargetTypes.lists, "0a84a63afc", SubTargetType.members);
        //    singleOpt.operation_id = String.Format("{0}", i);
        //    singleOpt.body = myContentJson;

        //    batchObj.operations.Add(singleOpt);
        //}

        //MailChimpBatch goBatch = new MailChimpBatch();
        //var batchResult = goBatch.PostBatchOperation(batchObj).Result;
        //Thread.Sleep(9000);

        #endregion Add multiple members in list with single call

        #region Get Batch Result for By ID

        //var batchId = batchResult.Result.id;
        //string newFileName = "";
        //if (batchId != null)
        //{
        //    var result = goBatch.GetBatchReport(batchId).Result;
        //    Thread.Sleep(2000);

        //    if (result.errored_operations > 0)
        //    {
        //        string detailsReportForIssueTrackingURL = result.response_body_url.ToString();
        //        newFileName = @"E:\" + batchId + ".tar.gz";
        //        FileDownloader.download(detailsReportForIssueTrackingURL, newFileName);
        //    }
        //    else
        //    {
        //        string detailSuccessReportURL = result.response_body_url.ToString();
        //    }
        //}

        #endregion Get Batch Result for By ID

        #region decompress tar.gz

        //string logDirectory = @"E:\MailChimpLog";
        //string extractedFileName = "";
        //if (!String.IsNullOrWhiteSpace(newFileName))
        //{
        //  while (true)
        //  {
        //    if (File.Exists(newFileName))
        //    {
        //      using (Stream stream = File.OpenRead(newFileName))
        //      {
        //        var reader = ReaderFactory.Open(stream);
        //        while (reader.MoveToNextEntry())
        //        {
        //          if (!reader.Entry.IsDirectory)
        //          {
        //            extractedFileName = reader.Entry.Key;
        //            extractedFileName = extractedFileName.Substring(2);
        //            reader.WriteEntryToDirectory(logDirectory, ExtractOptions.ExtractFullPath | ExtractOptions.Overwrite);
        //          }
        //        }
        //      }
        //      string expectedFileName = String.Format("{0}.json", batchId);

        //      System.IO.File.Move(
        //          Path.Combine(logDirectory, extractedFileName),
        //          Path.Combine(logDirectory, expectedFileName));
        //      break;
        //    }
        //  }
        //}

        #endregion decompress tar.gz

        #region CreateNewList

        MailChimpList myList = new MailChimpList();
        Contact ct = new Contact()
          {
            city = "Dhaka",
            address1 = "This is address1",
            address2 = "This is address2",
            company = "desme",
            country = "Bangladesh",
            phone = "017777",
            state = "NA",
            zip = "96000"
          };

        CampaignDefaults cd = new CampaignDefaults()
          {
            from_email = "Shossain@desme.com",
            from_name = "Shahriar",
            language = "English",
            subject = "This is a subject"
          };

        Random r = new Random();
        var listResult =
          myList.CreateListAsync("myTmpList#" + r.Next(0, 100), ct, "You gave me permission ", cd, false, ListVisibility.prv)
                .Result;

        #region Create Merge Field              

        Thread.Sleep(2000);

        MergeField mergeField = new MergeField
          {
            name = "Company",
            tag = "CNAME",
            type = MergeFieldType.text,
            default_value = "",
            list_id = listResult.Result.id
          };

        var mergeFieldResult = myList.AddMergeFieldAsync(mergeField, listResult.Result.id).Result;

        MergeField mergeFieldUpdate = new MergeField
          {
            name = "Company Name",
            tag = "CNAME",
            type = MergeFieldType.text,
            default_value = "",
            list_id = listResult.Result.id,
            merge_id = mergeFieldResult.Result.merge_id,
            display_order = 3,
            help_text = "Company Name",
            @public = true
          };

        var mergeFieldUpdateResult = myList.UpdateMergeFieldAsync(mergeFieldUpdate, listResult.Result.id);

        if (mergeFieldUpdateResult != null)
        {
        }

        MCMember member = new MCMember()
          {
            email_address = String.Format("SHAHRIARTEST@desme.com"),
            email_type = "html",
            language = "English",
            status = SubscriberStatus.subscribed.ToString(),
            merge_fields = new Dictionary<string, object>
              {
                {"FNAME", "first"},
                {"LNAME", "last"},
                {"CNAME", "company"}
              }
          };
        var memberAddResult = myList.AddMemberAsync(member, listResult.Result.id).Result;

        if (!memberAddResult.HasError)
        {
          MCMember updateMember = new MCMember()
            {
              email_address = String.Format("SHAHRIARTEST@desme.com"),
              email_type = "html",
              language = "English",
              status = SubscriberStatus.subscribed.ToString(),
              id = memberAddResult.Result.id,
              merge_fields = new Dictionary<string, object>
                {
                  {"FNAME", "FIRST"},
                  {"LNAME", "LAST"},
                  {"CNAME", "Company Name"}
                }
            };
          var memberUpdateResult = myList.UpdateMemberAsync(updateMember, listResult.Result.id).Result;

          if (!memberUpdateResult.HasError)
          {
          }
        }

        #endregion

        #endregion CreateNewList

        #region CampaignScheduler

        //MailChimpCampaigns campaign = new MailChimpCampaigns();
        //MCCampaignsOverview overview = new MCCampaignsOverview();

        //Recipients recipients = new Recipients()
        //{
        //    list_id = "0a84a63afc"
        //};

        //Settings campaignSettings = new Settings()
        //{
        //    subject_line = "Schedule Mail Subject ",
        //    title = "Schedule Mail!!! ",
        //    from_name = "Shahriar Hossain",
        //    reply_to = "shossain@desme.com",
        //    template_id = 18073,
        //    authenticate = true,
        //    auto_footer = false
        //};
        //Tracking campaignTracking = new Tracking()
        //{
        //    opens = true,
        //    html_clicks = true,
        //    text_clicks = true
        //};

        //ResultWrapper<Campaign> campaignCreationResult = overview.CreateCampaign(Enum.CampaignType.regular, recipients, campaignSettings, campaignTracking).Result;

        //if (campaignCreationResult.HasError == false)
        //{
        //    ContentTemplate template = new ContentTemplate()
        //    {
        //        id = "18073"
        //    };

        //    ContentSetting cSetting = new ContentSetting();
        //    string path = @"C:\Users\Wahid\Documents\Visual Studio 2012\Projects\MailChimp.Api.Net\MailChimp.Api.Net\EmailTemplates\raw_email_01.txt";
        //    FileParser parser = new FileParser();
        //    cSetting.html = parser.EmailParser(path);

        //    MCCampaignContent campaignContent = new MCCampaignContent();
        //    var setContentStatus = campaignContent.SetCampaignContent(campaignCreationResult.Result.id, cSetting).Result;

        //    MCCampaignsCheckList mccheckList = new MCCampaignsCheckList();
        //    var checkListResult = mccheckList.GetCampaignContent(campaignCreationResult.Result.id).Result;

        //    if (checkListResult.is_ready)
        //    {
        //        DateTime dt = new DateTime(2016, 01, 29, 10, 28, 00, DateTimeKind.Utc);

        //        var schedule = campaign.ScheduleCampaign(campaignCreationResult.Result.id, dt).Result;
        //    }
        //}
        //else
        //{
        //    String.Format("Best of Luck :p !");
        //}

        #endregion CampaignScheduler

        Console.Read();
      }
      catch (Exception ex)
      {
        throw ex;
      }


      Console.Read();
    }
  }
}