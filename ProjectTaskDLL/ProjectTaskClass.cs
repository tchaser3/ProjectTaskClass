/* Title:           Project Task Class
 * Date:            2-7-18
 * Author:          Terry Holmes
 * 
 * Description:     This class is for Project Task */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace ProjectTaskDLL
{
    public class ProjectTaskClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        ProjectTaskDataSet aProjectTaskDataSet;
        ProjectTaskDataSetTableAdapters.projecttaskTableAdapter aProjectTaskTableAdapter;

        InsertProjectTaskEntryTableAdapters.QueriesTableAdapter aInsertProjectTaskTableAdapter;

        UpdateProjectTaskEntryTableAdapters.QueriesTableAdapter aUpdateProjectTaskTableAdapter;

        FindProjectWorkTaskDataSet aFindProjectWorkTaskDataSet;
        FindProjectWorkTaskDataSetTableAdapters.FindProjectWorkTaskTableAdapter aFindProjectWorkTaskTableAdapter;

        FindMDUDropBuryHoursDataSet aFindMDUDropBuryHoursDataSet;
        FindMDUDropBuryHoursDataSetTableAdapters.FindMDUDropBuryHoursTableAdapter aFindMDUDropBuryHoursTableAdapter;

        FindSpecificProjectWorkTaskDataSet aFindSpecificProjectWorkTaskDataSet;
        FindSpecificProjectWorkTaskDataSetTableAdapters.FindSpecificProjectWorkTaskTableAdapter aFindSpecificProjectWorkTaskTableAdapter;

        UpdateProjectTaskFootageEntryTableAdapters.QueriesTableAdapter aUpdateProjectTaskFootageTableAdapter;

        FindProjectTaskHoursByAssignedProjectIDDataSet aFindProjectTaskHoursByAssignedProjectIDDataSet;
        FindProjectTaskHoursByAssignedProjectIDDataSetTableAdapters.FindProjectTaskHoursByAssignedProjectIDTableAdapter aFindProjectTaskHoursByAssignedProjectIDTableAdapter;

        FindProjectTaskByTaskIDDataSet aFindProjectTaskByTaskIDDataSet;
        FindProjectTaskByTaskIDDataSetTableAdapters.FindProjectTaskByTaskIDTableAdapter aFindProjectTaskByTaskIDTableAdapter;

        UpdateProjectTaskIDEntryTableAdapters.QueriesTableAdapter aUpdateProjectTaskIDTableAdapter;

        FindTotalProjectTaskFootagesDataSet aFindTotalProjectTaskFootagesDataSet;
        FindTotalProjectTaskFootagesDataSetTableAdapters.FindTotalProjectTaskFootagesTableAdapter aFindTotalProjectTaskFootagesTableAdapter;

        FindProjectTasksForFootageDataSet aFindProjectTasksForFootageDataSet;
        FindProjectTasksForFootageDataSetTableAdapters.FindProjectTasksForFootageTableAdapter aFindProjectTasksForFootageTableAdapter;

        FindCompanyFootagesDataSet aFindCompanyFootagesDataSet;
        FindCompanyFootagesDataSetTableAdapters.FindCompanyFootagesTableAdapter aFindCompanyFootagesTableAdapter;

        FindProjectTaskForProductivityReportDataSet aFindProjectTaskForProductivityReportDataSet;
        FindProjectTaskForProductivityReportDataSetTableAdapters.FindProjectTaskForProductivityReportTableAdapter aFindProjectTaskForProductivityReportTableAdapter;

        FindProductionTaskForProductivityDataSet aFindProductionTaskForProductivityDataSet;
        FindProductionTaskForProductivityDataSetTableAdapters.FindProductionTaskForProductivityTableAdapter aFindProductionTaskForProductivityTableAdapter;

        FindProjectTaskForVoidingDataSet aFindProjectTaskForVoidingDataSet;
        FindProjectTaskForVoidingDataSetTableAdapters.FindProjectTaskForVoidingTableAdapter aFindProjectTaskForVoidingTableAdapter;

        public FindProjectTaskForVoidingDataSet FindProjectTaskForVoiding(int intEmployeeID, DateTime datTransactionDate)
        {
            try
            {
                aFindProjectTaskForVoidingDataSet = new FindProjectTaskForVoidingDataSet();
                aFindProjectTaskForVoidingTableAdapter = new FindProjectTaskForVoidingDataSetTableAdapters.FindProjectTaskForVoidingTableAdapter();
                aFindProjectTaskForVoidingTableAdapter.Fill(aFindProjectTaskForVoidingDataSet.FindProjectTaskForVoiding, intEmployeeID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Find Project Task For Voiding " + Ex.Message);
            }

            return aFindProjectTaskForVoidingDataSet;
        }
        public FindProductionTaskForProductivityDataSet FindProductionTaskForProductivity(int intEmployeeID)
        {
            try
            {
                aFindProductionTaskForProductivityDataSet = new FindProductionTaskForProductivityDataSet();
                aFindProductionTaskForProductivityTableAdapter = new FindProductionTaskForProductivityDataSetTableAdapters.FindProductionTaskForProductivityTableAdapter();
                aFindProductionTaskForProductivityTableAdapter.Fill(aFindProductionTaskForProductivityDataSet.FindProductionTaskForProductivity, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Find Production Task For Productivity " + Ex.Message);
            }

            return aFindProductionTaskForProductivityDataSet;
        }
        public FindProjectTaskForProductivityReportDataSet FindProjectTaskForProductivityReport(int intEmployeeID, int intProjectID, DateTime datTransactionDate)
        {
            try
            {
                aFindProjectTaskForProductivityReportDataSet = new FindProjectTaskForProductivityReportDataSet();
                aFindProjectTaskForProductivityReportTableAdapter = new FindProjectTaskForProductivityReportDataSetTableAdapters.FindProjectTaskForProductivityReportTableAdapter();
                aFindProjectTaskForProductivityReportTableAdapter.Fill(aFindProjectTaskForProductivityReportDataSet.FindProjectTaskForProductivityReport, intEmployeeID, intProjectID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Find Project Task For Productivity Report " + Ex.Message);
            }

            return aFindProjectTaskForProductivityReportDataSet;
        }
        public FindCompanyFootagesDataSet FindCompanyFootages(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindCompanyFootagesDataSet = new FindCompanyFootagesDataSet();
                aFindCompanyFootagesTableAdapter = new FindCompanyFootagesDataSetTableAdapters.FindCompanyFootagesTableAdapter();
                aFindCompanyFootagesTableAdapter.Fill(aFindCompanyFootagesDataSet.FindCompanyFootages, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Find Company Footages " + Ex.Message);
            }

            return aFindCompanyFootagesDataSet;
        }
        public FindProjectTasksForFootageDataSet FindProjectTasksForFootage(int intWorkTaskID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindProjectTasksForFootageDataSet = new FindProjectTasksForFootageDataSet();
                aFindProjectTasksForFootageTableAdapter = new FindProjectTasksForFootageDataSetTableAdapters.FindProjectTasksForFootageTableAdapter();
                aFindProjectTasksForFootageTableAdapter.Fill(aFindProjectTasksForFootageDataSet.FindProjectTasksForFootage, intWorkTaskID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Find Project Tasks For Footage " + Ex.Message);
            }

            return aFindProjectTasksForFootageDataSet;
        }

        public FindTotalProjectTaskFootagesDataSet FindTotalProjectTaskFootages(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindTotalProjectTaskFootagesDataSet = new FindTotalProjectTaskFootagesDataSet();
                aFindTotalProjectTaskFootagesTableAdapter = new FindTotalProjectTaskFootagesDataSetTableAdapters.FindTotalProjectTaskFootagesTableAdapter();
                aFindTotalProjectTaskFootagesTableAdapter.Fill(aFindTotalProjectTaskFootagesDataSet.FindTotalProjectTaskFootages, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class \\ Find Total Project Task Footages " + Ex.Message);                
            }

            return aFindTotalProjectTaskFootagesDataSet;
        }
        public bool UpdateProjectTaskID(int intTransactionID, int intTaskID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProjectTaskIDTableAdapter = new UpdateProjectTaskIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateProjectTaskIDTableAdapter.UpdateProjectTaskID(intTransactionID, intTaskID);
            }
            catch (Exception ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Update Project Task ID " + ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindProjectTaskByTaskIDDataSet FindProjectTaskByTaskID(int intTaskID)
        {
            try
            {
                aFindProjectTaskByTaskIDDataSet = new FindProjectTaskByTaskIDDataSet();
                aFindProjectTaskByTaskIDTableAdapter = new FindProjectTaskByTaskIDDataSetTableAdapters.FindProjectTaskByTaskIDTableAdapter();
                aFindProjectTaskByTaskIDTableAdapter.Fill(aFindProjectTaskByTaskIDDataSet.FindProjectTaskByTaskID, intTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Find Project Task By Task ID " + Ex.Message);
            }

            return aFindProjectTaskByTaskIDDataSet;
        }
        public FindProjectTaskHoursByAssignedProjectIDDataSet FindProjectTaskHoursByAssignedProjectID(string strAssignedProjectID)
        {
            try
            {
                aFindProjectTaskHoursByAssignedProjectIDDataSet = new FindProjectTaskHoursByAssignedProjectIDDataSet();
                aFindProjectTaskHoursByAssignedProjectIDTableAdapter = new FindProjectTaskHoursByAssignedProjectIDDataSetTableAdapters.FindProjectTaskHoursByAssignedProjectIDTableAdapter();
                aFindProjectTaskHoursByAssignedProjectIDTableAdapter.Fill(aFindProjectTaskHoursByAssignedProjectIDDataSet.FindProjectTaskHoursByAssignedProjectID, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Find Project Task Hours By Assigned Project ID " + Ex.Message);
            }

            return aFindProjectTaskHoursByAssignedProjectIDDataSet;
        }
        public bool UpdateProjectTaskFootage(int intTransactionID, int intFootage)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProjectTaskFootageTableAdapter = new UpdateProjectTaskFootageEntryTableAdapters.QueriesTableAdapter();
                aUpdateProjectTaskFootageTableAdapter.UpdateProjectTaskFootage(intTransactionID, intFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Find Project Task Footage " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindSpecificProjectWorkTaskDataSet FindSpecificProjectWorkTask(int intProjectID, int intWorkTaskID)
        {
            try
            {
                aFindSpecificProjectWorkTaskDataSet = new FindSpecificProjectWorkTaskDataSet();
                aFindSpecificProjectWorkTaskTableAdapter = new FindSpecificProjectWorkTaskDataSetTableAdapters.FindSpecificProjectWorkTaskTableAdapter();
                aFindSpecificProjectWorkTaskTableAdapter.Fill(aFindSpecificProjectWorkTaskDataSet.FindSpecificProjectWorkTask, intProjectID, intWorkTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Find Specific Project Work Tas " + Ex.Message);
            }

            return aFindSpecificProjectWorkTaskDataSet;
        }
        public FindMDUDropBuryHoursDataSet FindMDUDropBuryHours(int intProjectID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindMDUDropBuryHoursDataSet = new FindMDUDropBuryHoursDataSet();
                aFindMDUDropBuryHoursTableAdapter = new FindMDUDropBuryHoursDataSetTableAdapters.FindMDUDropBuryHoursTableAdapter();
                aFindMDUDropBuryHoursTableAdapter.Fill(aFindMDUDropBuryHoursDataSet.FindMDUDropBuryHours, intProjectID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Find MDU Drop Bury Hours " + Ex.Message);
            }

            return aFindMDUDropBuryHoursDataSet;
        }
        public FindProjectWorkTaskDataSet FindProjectWorkTask(int intProjectID, int intEmployeeID, int intWorkTaskID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindProjectWorkTaskDataSet = new FindProjectWorkTaskDataSet();
                aFindProjectWorkTaskTableAdapter = new FindProjectWorkTaskDataSetTableAdapters.FindProjectWorkTaskTableAdapter();
                aFindProjectWorkTaskTableAdapter.Fill(aFindProjectWorkTaskDataSet.FindProjectWorkTask, intProjectID, intEmployeeID, intWorkTaskID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Find Project Work Task " + Ex.Message);
            }

            return aFindProjectWorkTaskDataSet;
        }
        public bool UpdateProjectTask(int intTransactionID, int intProjectID, int intEmployeeID, int intWorkTaskID, decimal decFootagePieces, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProjectTaskTableAdapter = new UpdateProjectTaskEntryTableAdapters.QueriesTableAdapter();
                aUpdateProjectTaskTableAdapter.UpdateProjectTask(intTransactionID, intProjectID, intEmployeeID, intWorkTaskID, decFootagePieces, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Update Project Task " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertProjectTask(int intProjectID, int intEmployeeID, int intWorkTaskID, decimal decFootagePieces, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProjectTaskTableAdapter = new InsertProjectTaskEntryTableAdapters.QueriesTableAdapter();
                aInsertProjectTaskTableAdapter.InsertProjectTask(intProjectID, intEmployeeID, intWorkTaskID, decFootagePieces, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Insert Project Task " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProjectTaskDataSet GetProjectTaskInfo()
        {
            try
            {
                aProjectTaskDataSet = new ProjectTaskDataSet();
                aProjectTaskTableAdapter = new ProjectTaskDataSetTableAdapters.projecttaskTableAdapter();
                aProjectTaskTableAdapter.Fill(aProjectTaskDataSet.projecttask);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Get Project Task Info " + Ex.Message);
            }

            return aProjectTaskDataSet;
        }
        public void UpdateProjectTaskDB(ProjectTaskDataSet aProjectTaskDataSet)
        {
            try
            {
                aProjectTaskTableAdapter = new ProjectTaskDataSetTableAdapters.projecttaskTableAdapter();
                aProjectTaskTableAdapter.Update(aProjectTaskDataSet.projecttask);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Task Class // Update Project Task DB " + Ex.Message);
            }
        }
    }
}
