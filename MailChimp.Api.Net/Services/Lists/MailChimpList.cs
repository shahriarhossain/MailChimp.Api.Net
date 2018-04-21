using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;

namespace MailChimp.Api.Net.Services.Lists
{
  // ================================================================================================
  // AUTHOR      : Shahriar Hossain
  // PURPOSE     : MailChimp list is a powerful and flexible tool that helps you manage your contacts
  // ================================================================================================

  public class MailChimpList
  {
    private MCListsAbuseReports listAbuseReport;
    private MCListsActivity listActivity;
    private MCListsClient listClient;
    private MCListsGrowthHistory listGrowthHistory;
    private MCListsMembers listMembers;
    private MCListsMergeFields listMergeFields;
    private MCListsOverview listOverview;
    private MCListsSegments listSegments;
    private MCListsInterestCategories listInterestCategories;

    public MailChimpList()
    {
      listAbuseReport = new MCListsAbuseReports();
      listActivity = new MCListsActivity();
      listClient = new MCListsClient();
      listGrowthHistory = new MCListsGrowthHistory();

      listMembers = new MCListsMembers();
      listMergeFields = new MCListsMergeFields();
      listOverview = new MCListsOverview();
      listSegments = new MCListsSegments();
      listInterestCategories = new MCListsInterestCategories();
    }

    #region AbuseReport

    /// <summary>
    /// Get information about abuse reports
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootAbuseReport> GetAbuseReportsAsync(string list_id)
    {
      return await listAbuseReport.GetAbuseReportsAsync(list_id);
    }


    /// <summary>
    /// Get details about a specific abuse report
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="report_id">Id for the abuse report</param>
    /// </summary>
    public async Task<AbuseReport> GetAbuseReportAsync(string list_id, string report_id)
    {
      return await listAbuseReport.GetAbuseReportAsync(list_id, report_id);
    }

    #endregion AbuseReport

    #region Activity

    /// <summary>
    /// Get recent list activity
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootListsActivity> GetRecentActivityAsync(string list_id)
    {
      return await listActivity.GetRecentActivityAsync(list_id);
    }

    #endregion Activity

    #region Client

    /// <summary>
    /// Get top email clients
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootListsClient> GetTopEmailClientsAsync(string list_id)
    {
      return await listClient.GetTopEmailClientsAsync(list_id);
    }

    #endregion Client

    #region GrowthHistory

    /// <summary>
    /// Get list growth history data
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootListsGrowthHistory> GetGrowthHistoryAsync(string list_id)
    {
      return await listGrowthHistory.GetGrowthHistoryAsync(list_id);
    }

    /// <summary>
    /// Get list growth history by month
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="month">A specific month of list growth history.</param>
    /// </summary>
    public async Task<RootListsGrowth> GetGrowthHistoryByMonthAsync(string list_id, string month)
    {
      return await listGrowthHistory.GetGrowthHistoryByMonthAsync(list_id, month);
    }

    #endregion GrowthHistory

    #region Members

    /// <summary>
    /// Add a new list member
    /// <param name="member">Member to be added to the list</param>  
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<dynamic> AddMemberAsync(MCMember member, string list_id)
    {
      return await listMembers.AddMemberAsync(member, list_id);
    }

    /// <summary>
    /// Update a list member
    /// <param name="member">Member to be updated in the list</param> 
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<dynamic> UpdateMemberAsync(MCMember member, string list_id)
    {
      return await listMembers.UpdateMemberAsync(member, list_id);
    }

    /// <summary>
    /// Get information about members in a list
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="offset">The number of records from a collection to skip. Iterating over large collections with this parameter can be slow</param>
    /// <param name="count">The number of records to return.</param>
    /// </summary>
    public async Task<RootMember> GetAllMembersAsync(string list_id, int offset = 0, int count = 10)
    {
      return await listMembers.GetAllMembersAsync(list_id, offset, count);
    }

    /// <summary>
    /// Get information about a specific list member
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
    /// </summary>
    public async Task<MCMember> GetMemberAsync(string list_id, string subscriber_hash)
    {
      return await listMembers.GetMemberAsync(list_id, subscriber_hash);
    }

    /// <summary>
    /// Delete a list member
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteMemberAsync(string list_id, string subscriber_hash)
    {
      return await listMembers.DeleteMemberAsync(list_id, subscriber_hash);
    }

    #endregion Members

    #region MergeFields

    /// <summary>
    /// Add a new list merge field
    /// <param name="mergeField">The name of the merge field.</param>
    /// </summary>
    public async Task<dynamic> AddMergeFieldAsync(MergeField mergeField, string list_id)
    {
      return await listMergeFields.AddMergeFieldAsync(mergeField, list_id);
    }

    /// <summary>
    /// Update a list merge field
    /// <param name="mergeField">Merge field to update</param>
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<dynamic> UpdateMergeFieldAsync(MergeField mergeField, string list_id)
    {
      return await listMergeFields.UpdateMergeFieldAsync(mergeField, list_id);
    }

    /// <summary>
    /// Get all merge fields for a list
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootMergeField> GetAllMergeFieldsAsync(string list_id)
    {
      return await listMergeFields.GetAllMergeFieldsAsync(list_id);
    }

    /// <summary>
    /// Get a specific merge field
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="merge_id">The id for the merge field</param>
    /// </summary>
    public async Task<MergeField> GetMergeFieldAsync(string list_id, string merge_id)
    {
      return await listMergeFields.GetMergeFieldAsync(list_id, merge_id);
    }

    /// <summary>
    /// Delete a merge field
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="merge_id">The id for the merge field</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteMergeFieldAsync(string list_id, string merge_id)
    {
      return await listMergeFields.DeleteMergeFieldAsync(list_id, merge_id);
    }

    #endregion MergeFields

    #region interest categories
    /// <summary>
    /// Create a new interest category
    /// <param name="title">The text description of this category. This field appears on signup forms and is often phrased as a question</param>
    /// <param name="display_order">The order that the categories are displayed in the list. Lower numbers display first</param>
    /// <param name="type">Determines how this category’s interests are displayed on signup forms</param>
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<dynamic> CreateInterestCategoryAsync(string title, int display_order, InterestCategoryType type, string list_id)
    {
      return await listInterestCategories.CreateInterestCategoryAsync(title, display_order, type, list_id);
    }

    /// <summary>
    /// Update a specific interest category.
    /// <param name="title">The text description of this category. This field appears on signup forms and is often phrased as a question</param>
    /// <param name="display_order">The order that the categories are displayed in the list. Lower numbers display first</param>
    /// <param name="type">Determines how this category’s interests are displayed on signup forms</param>
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">The unique id for the interest category.</param>
    /// </summary>
    public async Task<dynamic> UpdateInterestCategoryAsync(string title, int display_order, InterestCategoryType type, string list_id, string interest_category_id)
    {
      return
        await listInterestCategories.UpdateInterestCategoryAsync(title, display_order, type, list_id, interest_category_id);
    }

    /// <summary>
    /// Get all interest categories for a list
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootListsInterestCategory> GetAllInterestCategoriesAsync(string list_id)
    {
      return await listInterestCategories.GetAllInterestCategoriesAsync(list_id);
    }

    /// <summary>
    /// Get a specific interest category
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="merge_id">The id for the interest category</param>
    /// </summary>
    public async Task<InterestCategory> GetInterestCategoryAsync(string list_id, string merge_id)
    {
      return await listInterestCategories.GetInterestCategoryAsync(list_id, merge_id);
    }

    /// <summary>
    /// Delete a interest category
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">Unique id for the interest category</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteInterestCategoryAsync(string list_id, string interest_category_id)
    {
      return await listInterestCategories.DeleteInterestCategoryAsync(list_id, interest_category_id);
    }


    #endregion

    #region intereste category interests
    /// <summary>
    /// Create a new interest or ‘group name’ for a specific category.
    /// <param name="name">The name of the interest. This can be shown publicly on a subscription form</param>
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">	The unique id for the interest category</param>
    /// </summary>
    public async Task<dynamic> CreateInterestCategoryInterestAsync(string name, string list_id, string interest_category_id)
    {
      return await listInterestCategories.CreateInterestCategoryInterestAsync(name, list_id, interest_category_id);
    }

    /// <summary>
    /// Update interests or ‘group names’ for a specific category
    /// <param name="name">	The name of the interest. This can be shown publicly on a subscription form</param>
    /// <param name="display_order">The display order for interests.</param>
    /// <param name="list_id">The unique id for the list</param>
    /// <param name="subscriber_count">The number of subscribers associated with this interest.</param>
    /// <param name="interest_category_id">The unique id for the interest category</param>
    /// <param name="interest_id">	The specific interest or ‘group name’</param>
    /// </summary>
    public async Task<dynamic> UpdateInterestCategoryInterestAsync(string name, int display_order, int subscriber_count, string list_id, string interest_category_id, string interest_id)
    {
      return await listInterestCategories.UpdateInterestCategoryInterestAsync(name, display_order, subscriber_count, list_id,
                                                              interest_category_id, interest_id);
    }

    /// <summary>
    /// Get all interests in a specific category
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">Unique id for the interest category</param>
    /// </summary>
    public async Task<RootInterest> GetAllInterestCategoryInterestsAsync(string list_id, string interest_category_id)
    {
      return await listInterestCategories.GetAllInterestCategoryInterestsAsync(list_id, interest_category_id);
    }

    /// <summary>
    /// Get interests in a specific category
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">Unique id for the interest category</param>
    /// <param name="interest_id">The specific interest or ‘group name</param>
    /// </summary>
    public async Task<RootInterest> GetInterestCategoryInterestAsync(string list_id, string interest_category_id, string interest_id)
    {
      return await listInterestCategories.GetInterestCategoryInterestAsync(list_id, interest_category_id, interest_id);
    }

    /// <summary>
    /// Delete interests in a specific category
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">Unique id for the interest category</param>
    /// <param name="interest_id">The specific interest or ‘group name</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteInterestCategoryInterestAsync(string list_id, string interest_category_id, string interest_id)
    {
      return await listInterestCategories.DeleteInterestCategoryInterestAsync(list_id, interest_category_id, interest_id);
    }
    #endregion

    #region Overview

    /// <summary>
    /// Get information about all lists
    /// <param name="offset">The number of records from a collection to skip. Iterating over large collections with this parameter can be slow</param>
    /// <param name="count">The number of records to return.</param>   
    /// </summary>
    public async Task<RootMCLists> GetAllListsAsync(int offset = 0, int count = 10)
    {
      return await listOverview.GetAllListsAsync(offset, count);
    }

    /// <summary>
    /// Get information about a specific list
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<MCLists> GetListAsync(string list_id)
    {
      return await listOverview.GetListAsync(list_id);
    }

    /// <summary>
    /// Delete a list
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteListAsync(string list_id)
    {
      return await listOverview.DeleteListAsync(list_id);
    }

    /// <summary>
    /// Create a new list
    /// <param name="listName">The name of the list </param>
    /// <param name="contactForCampaignFotter">Contact information displayed in campaign footers to comply with international spam laws</param>
    /// <param name="permissionReminderText">The permission reminder for the list</param>
    /// <param name="defaultValue">Default values for campaigns created for this list</param>
    /// <param name="emailTypeOption">Whether the list supports multiple formats for emails.</param>
    /// <param name="listVisibility">Whether this list is public or private</param>
    /// </summary>
    public async Task<dynamic> CreateListAsync(string listName, Contact contactForCampaignFotter,
                                          string permissionReminderText, CampaignDefaults defaultValue,
                                          bool emailTypeOption = false,
                                          ListVisibility listVisibility = ListVisibility.pub)
    {
      return
        await
        listOverview.CreateListAsync(listName, contactForCampaignFotter, permissionReminderText, defaultValue,
                                emailTypeOption, listVisibility);
    }

    /// <summary>
    /// Update a list
    /// <param name="list_id">Unique id for the list</param> 
    /// <param name="listName">The name of the list </param>
    /// <param name="contactForCampaignFotter">Contact information displayed in campaign footers to comply with international spam laws</param>
    /// <param name="permissionReminderText">The permission reminder for the list</param>
    /// <param name="defaultValue">Default values for campaigns created for this list</param>
    /// <param name="emailTypeOption">Whether the list supports multiple formats for emails.</param>
    /// <param name="listVisibility">Whether this list is public or private</param>
    /// </summary>
    public async Task<dynamic> UpdateListAsync(string list_id, string listName, Contact contactForCampaignFotter,
                                          string permissionReminderText, CampaignDefaults defaultValue,
                                          bool emailTypeOption = false,
                                          ListVisibility listVisibility = ListVisibility.pub)
    {
      return
        await
        listOverview.UpdateListAsync(list_id, listName, contactForCampaignFotter, permissionReminderText, defaultValue,
                                emailTypeOption, listVisibility);
    }

    #endregion Overview

    #region Segments
    /// <summary>
    /// Create a new segment in a specific list
    /// <param name="name">The name of the segment.</param>
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="static_segment">An array of emails to be used for a static segment. Any emails provided that are not present on the list will be ignored. Passing an empty array will create a static segment without any subscribers. This field cannot be provided with the options field.</param>
    /// </summary>
    public async Task<Segment> AddSegmentAsync(string name, string list_id, List<string> static_segment)
    {
      return await listSegments.AddSegmentAsync(name, list_id, static_segment);
    }


    /// <summary>
    /// Get information about all segments in a list
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootSegment> GetAllSegmentAsync(string list_id)
    {
      return await listSegments.GetAllSegmentsAsync(list_id);
    }

    /// <summary>
    /// Get information about a specific segment
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="segment_id">Unique id for the segment</param>
    /// </summary>
    public async Task<RootSegment> GetSegmentInfoAsync(string list_id, string segment_id)
    {
      return await listSegments.GetSegmentInfoAsync(list_id, segment_id);
    }

    /// <summary>
    /// Delete a segment
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="segment_id">The segment id to delete</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteSegmentAsync(string list_id, string segment_id)
    {
      return await listSegments.DeleteSegmentAsync(list_id, segment_id);
    }

    #endregion Segments
  }
}