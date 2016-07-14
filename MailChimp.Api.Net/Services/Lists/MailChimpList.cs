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
        public async Task<AbuseReport> GetSpecificAbuseReportAsync(string list_id, string report_id)
        {
            return await listAbuseReport.GetSpecificAbuseReportAsync(list_id, report_id);
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
        public async Task<dynamic> AddMember(MCMember member, string list_id)
        {
            return await listMembers.AddMember(member, list_id);
        }

        /// <summary>
        /// Update a list member
        /// <param name="member">Member to be updated in the list</param> 
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        public async Task<dynamic> UpdateMember(MCMember member, string list_id)
        {
            return await listMembers.UpdateMember(member, list_id);
        }

        /// <summary>
        /// Get information about members in a list
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        public async Task<RootMember> GetAllMemberInfoAsync(string list_id, int offset = 0, int count = 10)
        {
            return await listMembers.GetMemberInfoOfAListAsync(list_id, offset, count);
        }

        /// <summary>
        /// Get information about a specific list member
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        public async Task<MCMember> GetMemberInfoAsync(string list_id, string subscriber_hash)
        {
            return await listMembers.GetMemberInfoAsync(list_id, subscriber_hash);
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
        public async Task<dynamic> AddMergeField(MergeField mergeField, string list_id)
        {
          return await listMergeFields.AddMergeField(mergeField, list_id);
        }
      
        /// <summary>
        /// Update a list merge field
        /// <param name="mergeField">Merge field to update</param>
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        public async Task<dynamic> UpdateMergeField(MergeField mergeField, string list_id)
        {
            return await listMergeFields.UpdateMergeField(mergeField, list_id);
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

        #region Overview
        /// <summary>
        /// Get information about all lists
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
            string permissionReminderText, CampaignDefaults defaultValue, bool emailTypeOption = false,
            ListVisibility listVisibility = ListVisibility.pub)
        {
            return await listOverview.CreateListAsync(listName, contactForCampaignFotter, permissionReminderText, defaultValue, emailTypeOption, listVisibility);
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
        public async Task<dynamic> UpdateList(string list_id, string listName, Contact contactForCampaignFotter,
                                              string permissionReminderText, CampaignDefaults defaultValue,
                                              bool emailTypeOption = false,
                                              ListVisibility listVisibility = ListVisibility.pub)
        {
          return await listOverview.UpdateList(list_id, listName, contactForCampaignFotter, permissionReminderText, defaultValue, emailTypeOption, listVisibility);
        }

        #endregion Overview

        #region Segments
        /// <summary>
        /// Get information about all segments in a list
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        public async Task<RootSegment> GetAllSegmentAsync(string list_id)
        {
            return await listSegments.GetAllSegmentAsync(list_id);
        }

        /// <summary>
        /// Get information about a specific segment
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="segment_id">Unique id for the segment</param>
        /// </summary>
        public async Task<RootSegment> GetInfoForSpecificSegmentAsync(string list_id, string segment_id)
        {
            return await listSegments.GetInfoForSpecificSegmentAsync(list_id, segment_id);
        }

        /// <summary>
        /// Delete a segment
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteSegmentAsync(string list_id, string segment_id)
        {
            return await listSegments.DeleteSegmentAsync(list_id, segment_id);
        }
        #endregion Segments

    }
}
