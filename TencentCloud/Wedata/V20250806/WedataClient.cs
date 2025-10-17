/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Wedata.V20250806
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Wedata.V20250806.Models;

   public class WedataClient : AbstractClient{

       private const string endpoint = "wedata.tencentcloudapi.com";
       private const string version = "2025-08-06";
       private const string sdkVersion = "SDK_NET_3.0.1332";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WedataClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WedataClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 关联项目集群
        /// </summary>
        /// <param name="req"><see cref="AddCalcEnginesToProjectRequest"/></param>
        /// <returns><see cref="AddCalcEnginesToProjectResponse"/></returns>
        public Task<AddCalcEnginesToProjectResponse> AddCalcEnginesToProject(AddCalcEnginesToProjectRequest req)
        {
            return InternalRequestAsync<AddCalcEnginesToProjectResponse>(req, "AddCalcEnginesToProject");
        }

        /// <summary>
        /// 关联项目集群
        /// </summary>
        /// <param name="req"><see cref="AddCalcEnginesToProjectRequest"/></param>
        /// <returns><see cref="AddCalcEnginesToProjectResponse"/></returns>
        public AddCalcEnginesToProjectResponse AddCalcEnginesToProjectSync(AddCalcEnginesToProjectRequest req)
        {
            return InternalRequestAsync<AddCalcEnginesToProjectResponse>(req, "AddCalcEnginesToProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于将指定执行资源组绑定到项目
        /// </summary>
        /// <param name="req"><see cref="AssociateResourceGroupToProjectRequest"/></param>
        /// <returns><see cref="AssociateResourceGroupToProjectResponse"/></returns>
        public Task<AssociateResourceGroupToProjectResponse> AssociateResourceGroupToProject(AssociateResourceGroupToProjectRequest req)
        {
            return InternalRequestAsync<AssociateResourceGroupToProjectResponse>(req, "AssociateResourceGroupToProject");
        }

        /// <summary>
        /// 该接口用于将指定执行资源组绑定到项目
        /// </summary>
        /// <param name="req"><see cref="AssociateResourceGroupToProjectRequest"/></param>
        /// <returns><see cref="AssociateResourceGroupToProjectResponse"/></returns>
        public AssociateResourceGroupToProjectResponse AssociateResourceGroupToProjectSync(AssociateResourceGroupToProjectRequest req)
        {
            return InternalRequestAsync<AssociateResourceGroupToProjectResponse>(req, "AssociateResourceGroupToProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建代码文件
        /// </summary>
        /// <param name="req"><see cref="CreateCodeFileRequest"/></param>
        /// <returns><see cref="CreateCodeFileResponse"/></returns>
        public Task<CreateCodeFileResponse> CreateCodeFile(CreateCodeFileRequest req)
        {
            return InternalRequestAsync<CreateCodeFileResponse>(req, "CreateCodeFile");
        }

        /// <summary>
        /// 新建代码文件
        /// </summary>
        /// <param name="req"><see cref="CreateCodeFileRequest"/></param>
        /// <returns><see cref="CreateCodeFileResponse"/></returns>
        public CreateCodeFileResponse CreateCodeFileSync(CreateCodeFileRequest req)
        {
            return InternalRequestAsync<CreateCodeFileResponse>(req, "CreateCodeFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建代码文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateCodeFolderRequest"/></param>
        /// <returns><see cref="CreateCodeFolderResponse"/></returns>
        public Task<CreateCodeFolderResponse> CreateCodeFolder(CreateCodeFolderRequest req)
        {
            return InternalRequestAsync<CreateCodeFolderResponse>(req, "CreateCodeFolder");
        }

        /// <summary>
        /// 新建代码文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateCodeFolderRequest"/></param>
        /// <returns><see cref="CreateCodeFolderResponse"/></returns>
        public CreateCodeFolderResponse CreateCodeFolderSync(CreateCodeFolderRequest req)
        {
            return InternalRequestAsync<CreateCodeFolderResponse>(req, "CreateCodeFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据补录计划
        /// </summary>
        /// <param name="req"><see cref="CreateDataBackfillPlanRequest"/></param>
        /// <returns><see cref="CreateDataBackfillPlanResponse"/></returns>
        public Task<CreateDataBackfillPlanResponse> CreateDataBackfillPlan(CreateDataBackfillPlanRequest req)
        {
            return InternalRequestAsync<CreateDataBackfillPlanResponse>(req, "CreateDataBackfillPlan");
        }

        /// <summary>
        /// 创建数据补录计划
        /// </summary>
        /// <param name="req"><see cref="CreateDataBackfillPlanRequest"/></param>
        /// <returns><see cref="CreateDataBackfillPlanResponse"/></returns>
        public CreateDataBackfillPlanResponse CreateDataBackfillPlanSync(CreateDataBackfillPlanRequest req)
        {
            return InternalRequestAsync<CreateDataBackfillPlanResponse>(req, "CreateDataBackfillPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于在指定项目中创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public Task<CreateDataSourceResponse> CreateDataSource(CreateDataSourceRequest req)
        {
            return InternalRequestAsync<CreateDataSourceResponse>(req, "CreateDataSource");
        }

        /// <summary>
        /// 该接口用于在指定项目中创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public CreateDataSourceResponse CreateDataSourceSync(CreateDataSourceRequest req)
        {
            return InternalRequestAsync<CreateDataSourceResponse>(req, "CreateDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置告警规则
        /// </summary>
        /// <param name="req"><see cref="CreateOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="CreateOpsAlarmRuleResponse"/></returns>
        public Task<CreateOpsAlarmRuleResponse> CreateOpsAlarmRule(CreateOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<CreateOpsAlarmRuleResponse>(req, "CreateOpsAlarmRule");
        }

        /// <summary>
        /// 设置告警规则
        /// </summary>
        /// <param name="req"><see cref="CreateOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="CreateOpsAlarmRuleResponse"/></returns>
        public CreateOpsAlarmRuleResponse CreateOpsAlarmRuleSync(CreateOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<CreateOpsAlarmRuleResponse>(req, "CreateOpsAlarmRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建项目，创建时包含集群信息
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// 创建项目，创建时包含集群信息
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加项目用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateProjectMemberRequest"/></param>
        /// <returns><see cref="CreateProjectMemberResponse"/></returns>
        public Task<CreateProjectMemberResponse> CreateProjectMember(CreateProjectMemberRequest req)
        {
            return InternalRequestAsync<CreateProjectMemberResponse>(req, "CreateProjectMember");
        }

        /// <summary>
        /// 添加项目用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateProjectMemberRequest"/></param>
        /// <returns><see cref="CreateProjectMemberResponse"/></returns>
        public CreateProjectMemberResponse CreateProjectMemberSync(CreateProjectMemberRequest req)
        {
            return InternalRequestAsync<CreateProjectMemberResponse>(req, "CreateProjectMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资源文件
        /// </summary>
        /// <param name="req"><see cref="CreateResourceFileRequest"/></param>
        /// <returns><see cref="CreateResourceFileResponse"/></returns>
        public Task<CreateResourceFileResponse> CreateResourceFile(CreateResourceFileRequest req)
        {
            return InternalRequestAsync<CreateResourceFileResponse>(req, "CreateResourceFile");
        }

        /// <summary>
        /// 创建资源文件
        /// </summary>
        /// <param name="req"><see cref="CreateResourceFileRequest"/></param>
        /// <returns><see cref="CreateResourceFileResponse"/></returns>
        public CreateResourceFileResponse CreateResourceFileSync(CreateResourceFileRequest req)
        {
            return InternalRequestAsync<CreateResourceFileResponse>(req, "CreateResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资源文件文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateResourceFolderRequest"/></param>
        /// <returns><see cref="CreateResourceFolderResponse"/></returns>
        public Task<CreateResourceFolderResponse> CreateResourceFolder(CreateResourceFolderRequest req)
        {
            return InternalRequestAsync<CreateResourceFolderResponse>(req, "CreateResourceFolder");
        }

        /// <summary>
        /// 创建资源文件文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateResourceFolderRequest"/></param>
        /// <returns><see cref="CreateResourceFolderResponse"/></returns>
        public CreateResourceFolderResponse CreateResourceFolderSync(CreateResourceFolderRequest req)
        {
            return InternalRequestAsync<CreateResourceFolderResponse>(req, "CreateResourceFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于购买资源
        /// </summary>
        /// <param name="req"><see cref="CreateResourceGroupRequest"/></param>
        /// <returns><see cref="CreateResourceGroupResponse"/></returns>
        public Task<CreateResourceGroupResponse> CreateResourceGroup(CreateResourceGroupRequest req)
        {
            return InternalRequestAsync<CreateResourceGroupResponse>(req, "CreateResourceGroup");
        }

        /// <summary>
        /// 该接口用于购买资源
        /// </summary>
        /// <param name="req"><see cref="CreateResourceGroupRequest"/></param>
        /// <returns><see cref="CreateResourceGroupResponse"/></returns>
        public CreateResourceGroupResponse CreateResourceGroupSync(CreateResourceGroupRequest req)
        {
            return InternalRequestAsync<CreateResourceGroupResponse>(req, "CreateResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据探索脚本文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateSQLFolderRequest"/></param>
        /// <returns><see cref="CreateSQLFolderResponse"/></returns>
        public Task<CreateSQLFolderResponse> CreateSQLFolder(CreateSQLFolderRequest req)
        {
            return InternalRequestAsync<CreateSQLFolderResponse>(req, "CreateSQLFolder");
        }

        /// <summary>
        /// 创建数据探索脚本文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateSQLFolderRequest"/></param>
        /// <returns><see cref="CreateSQLFolderResponse"/></returns>
        public CreateSQLFolderResponse CreateSQLFolderSync(CreateSQLFolderRequest req)
        {
            return InternalRequestAsync<CreateSQLFolderResponse>(req, "CreateSQLFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增SQL脚本
        /// </summary>
        /// <param name="req"><see cref="CreateSQLScriptRequest"/></param>
        /// <returns><see cref="CreateSQLScriptResponse"/></returns>
        public Task<CreateSQLScriptResponse> CreateSQLScript(CreateSQLScriptRequest req)
        {
            return InternalRequestAsync<CreateSQLScriptResponse>(req, "CreateSQLScript");
        }

        /// <summary>
        /// 新增SQL脚本
        /// </summary>
        /// <param name="req"><see cref="CreateSQLScriptRequest"/></param>
        /// <returns><see cref="CreateSQLScriptResponse"/></returns>
        public CreateSQLScriptResponse CreateSQLScriptSync(CreateSQLScriptRequest req)
        {
            return InternalRequestAsync<CreateSQLScriptResponse>(req, "CreateSQLScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建任务接口
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask");
        }

        /// <summary>
        /// 创建任务接口
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public Task<CreateWorkflowResponse> CreateWorkflow(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow");
        }

        /// <summary>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public CreateWorkflowResponse CreateWorkflowSync(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowFolderRequest"/></param>
        /// <returns><see cref="CreateWorkflowFolderResponse"/></returns>
        public Task<CreateWorkflowFolderResponse> CreateWorkflowFolder(CreateWorkflowFolderRequest req)
        {
            return InternalRequestAsync<CreateWorkflowFolderResponse>(req, "CreateWorkflowFolder");
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowFolderRequest"/></param>
        /// <returns><see cref="CreateWorkflowFolderResponse"/></returns>
        public CreateWorkflowFolderResponse CreateWorkflowFolderSync(CreateWorkflowFolderRequest req)
        {
            return InternalRequestAsync<CreateWorkflowFolderResponse>(req, "CreateWorkflowFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除代码文件
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeFileRequest"/></param>
        /// <returns><see cref="DeleteCodeFileResponse"/></returns>
        public Task<DeleteCodeFileResponse> DeleteCodeFile(DeleteCodeFileRequest req)
        {
            return InternalRequestAsync<DeleteCodeFileResponse>(req, "DeleteCodeFile");
        }

        /// <summary>
        /// 删除代码文件
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeFileRequest"/></param>
        /// <returns><see cref="DeleteCodeFileResponse"/></returns>
        public DeleteCodeFileResponse DeleteCodeFileSync(DeleteCodeFileRequest req)
        {
            return InternalRequestAsync<DeleteCodeFileResponse>(req, "DeleteCodeFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据探索删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeFolderRequest"/></param>
        /// <returns><see cref="DeleteCodeFolderResponse"/></returns>
        public Task<DeleteCodeFolderResponse> DeleteCodeFolder(DeleteCodeFolderRequest req)
        {
            return InternalRequestAsync<DeleteCodeFolderResponse>(req, "DeleteCodeFolder");
        }

        /// <summary>
        /// 数据探索删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeFolderRequest"/></param>
        /// <returns><see cref="DeleteCodeFolderResponse"/></returns>
        public DeleteCodeFolderResponse DeleteCodeFolderSync(DeleteCodeFolderRequest req)
        {
            return InternalRequestAsync<DeleteCodeFolderResponse>(req, "DeleteCodeFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourceRequest"/></param>
        /// <returns><see cref="DeleteDataSourceResponse"/></returns>
        public Task<DeleteDataSourceResponse> DeleteDataSource(DeleteDataSourceRequest req)
        {
            return InternalRequestAsync<DeleteDataSourceResponse>(req, "DeleteDataSource");
        }

        /// <summary>
        /// 该接口用于删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourceRequest"/></param>
        /// <returns><see cref="DeleteDataSourceResponse"/></returns>
        public DeleteDataSourceResponse DeleteDataSourceSync(DeleteDataSourceRequest req)
        {
            return InternalRequestAsync<DeleteDataSourceResponse>(req, "DeleteDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// RegisterLineage
        /// </summary>
        /// <param name="req"><see cref="DeleteLineageRequest"/></param>
        /// <returns><see cref="DeleteLineageResponse"/></returns>
        public Task<DeleteLineageResponse> DeleteLineage(DeleteLineageRequest req)
        {
            return InternalRequestAsync<DeleteLineageResponse>(req, "DeleteLineage");
        }

        /// <summary>
        /// RegisterLineage
        /// </summary>
        /// <param name="req"><see cref="DeleteLineageRequest"/></param>
        /// <returns><see cref="DeleteLineageResponse"/></returns>
        public DeleteLineageResponse DeleteLineageSync(DeleteLineageRequest req)
        {
            return InternalRequestAsync<DeleteLineageResponse>(req, "DeleteLineage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除告警规则
        /// </summary>
        /// <param name="req"><see cref="DeleteOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="DeleteOpsAlarmRuleResponse"/></returns>
        public Task<DeleteOpsAlarmRuleResponse> DeleteOpsAlarmRule(DeleteOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<DeleteOpsAlarmRuleResponse>(req, "DeleteOpsAlarmRule");
        }

        /// <summary>
        /// 删除告警规则
        /// </summary>
        /// <param name="req"><see cref="DeleteOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="DeleteOpsAlarmRuleResponse"/></returns>
        public DeleteOpsAlarmRuleResponse DeleteOpsAlarmRuleSync(DeleteOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<DeleteOpsAlarmRuleResponse>(req, "DeleteOpsAlarmRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除项目用户
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectMemberRequest"/></param>
        /// <returns><see cref="DeleteProjectMemberResponse"/></returns>
        public Task<DeleteProjectMemberResponse> DeleteProjectMember(DeleteProjectMemberRequest req)
        {
            return InternalRequestAsync<DeleteProjectMemberResponse>(req, "DeleteProjectMember");
        }

        /// <summary>
        /// 删除项目用户
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectMemberRequest"/></param>
        /// <returns><see cref="DeleteProjectMemberResponse"/></returns>
        public DeleteProjectMemberResponse DeleteProjectMemberSync(DeleteProjectMemberRequest req)
        {
            return InternalRequestAsync<DeleteProjectMemberResponse>(req, "DeleteProjectMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理-删除资源文件
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFileRequest"/></param>
        /// <returns><see cref="DeleteResourceFileResponse"/></returns>
        public Task<DeleteResourceFileResponse> DeleteResourceFile(DeleteResourceFileRequest req)
        {
            return InternalRequestAsync<DeleteResourceFileResponse>(req, "DeleteResourceFile");
        }

        /// <summary>
        /// 资源管理-删除资源文件
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFileRequest"/></param>
        /// <returns><see cref="DeleteResourceFileResponse"/></returns>
        public DeleteResourceFileResponse DeleteResourceFileSync(DeleteResourceFileRequest req)
        {
            return InternalRequestAsync<DeleteResourceFileResponse>(req, "DeleteResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除资源文件文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFolderRequest"/></param>
        /// <returns><see cref="DeleteResourceFolderResponse"/></returns>
        public Task<DeleteResourceFolderResponse> DeleteResourceFolder(DeleteResourceFolderRequest req)
        {
            return InternalRequestAsync<DeleteResourceFolderResponse>(req, "DeleteResourceFolder");
        }

        /// <summary>
        /// 删除资源文件文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFolderRequest"/></param>
        /// <returns><see cref="DeleteResourceFolderResponse"/></returns>
        public DeleteResourceFolderResponse DeleteResourceFolderSync(DeleteResourceFolderRequest req)
        {
            return InternalRequestAsync<DeleteResourceFolderResponse>(req, "DeleteResourceFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于销毁资源
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public Task<DeleteResourceGroupResponse> DeleteResourceGroup(DeleteResourceGroupRequest req)
        {
            return InternalRequestAsync<DeleteResourceGroupResponse>(req, "DeleteResourceGroup");
        }

        /// <summary>
        /// 该接口用于销毁资源
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public DeleteResourceGroupResponse DeleteResourceGroupSync(DeleteResourceGroupRequest req)
        {
            return InternalRequestAsync<DeleteResourceGroupResponse>(req, "DeleteResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除SQL文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteSQLFolderRequest"/></param>
        /// <returns><see cref="DeleteSQLFolderResponse"/></returns>
        public Task<DeleteSQLFolderResponse> DeleteSQLFolder(DeleteSQLFolderRequest req)
        {
            return InternalRequestAsync<DeleteSQLFolderResponse>(req, "DeleteSQLFolder");
        }

        /// <summary>
        /// 删除SQL文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteSQLFolderRequest"/></param>
        /// <returns><see cref="DeleteSQLFolderResponse"/></returns>
        public DeleteSQLFolderResponse DeleteSQLFolderSync(DeleteSQLFolderRequest req)
        {
            return InternalRequestAsync<DeleteSQLFolderResponse>(req, "DeleteSQLFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除探索脚本
        /// </summary>
        /// <param name="req"><see cref="DeleteSQLScriptRequest"/></param>
        /// <returns><see cref="DeleteSQLScriptResponse"/></returns>
        public Task<DeleteSQLScriptResponse> DeleteSQLScript(DeleteSQLScriptRequest req)
        {
            return InternalRequestAsync<DeleteSQLScriptResponse>(req, "DeleteSQLScript");
        }

        /// <summary>
        /// 删除探索脚本
        /// </summary>
        /// <param name="req"><see cref="DeleteSQLScriptRequest"/></param>
        /// <returns><see cref="DeleteSQLScriptResponse"/></returns>
        public DeleteSQLScriptResponse DeleteSQLScriptSync(DeleteSQLScriptRequest req)
        {
            return InternalRequestAsync<DeleteSQLScriptResponse>(req, "DeleteSQLScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除编排空间任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public Task<DeleteTaskResponse> DeleteTask(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask");
        }

        /// <summary>
        /// 删除编排空间任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public DeleteTaskResponse DeleteTaskSync(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public Task<DeleteWorkflowResponse> DeleteWorkflow(DeleteWorkflowRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowResponse>(req, "DeleteWorkflow");
        }

        /// <summary>
        /// 删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public DeleteWorkflowResponse DeleteWorkflowSync(DeleteWorkflowRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowResponse>(req, "DeleteWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除数据开发文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowFolderRequest"/></param>
        /// <returns><see cref="DeleteWorkflowFolderResponse"/></returns>
        public Task<DeleteWorkflowFolderResponse> DeleteWorkflowFolder(DeleteWorkflowFolderRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowFolderResponse>(req, "DeleteWorkflowFolder");
        }

        /// <summary>
        /// 删除数据开发文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowFolderRequest"/></param>
        /// <returns><see cref="DeleteWorkflowFolderResponse"/></returns>
        public DeleteWorkflowFolderResponse DeleteWorkflowFolderSync(DeleteWorkflowFolderRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowFolderResponse>(req, "DeleteWorkflowFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用项目
        /// </summary>
        /// <param name="req"><see cref="DisableProjectRequest"/></param>
        /// <returns><see cref="DisableProjectResponse"/></returns>
        public Task<DisableProjectResponse> DisableProject(DisableProjectRequest req)
        {
            return InternalRequestAsync<DisableProjectResponse>(req, "DisableProject");
        }

        /// <summary>
        /// 禁用项目
        /// </summary>
        /// <param name="req"><see cref="DisableProjectRequest"/></param>
        /// <returns><see cref="DisableProjectResponse"/></returns>
        public DisableProjectResponse DisableProjectSync(DisableProjectRequest req)
        {
            return InternalRequestAsync<DisableProjectResponse>(req, "DisableProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于将指定执行资源组解除与项目的绑定
        /// </summary>
        /// <param name="req"><see cref="DissociateResourceGroupFromProjectRequest"/></param>
        /// <returns><see cref="DissociateResourceGroupFromProjectResponse"/></returns>
        public Task<DissociateResourceGroupFromProjectResponse> DissociateResourceGroupFromProject(DissociateResourceGroupFromProjectRequest req)
        {
            return InternalRequestAsync<DissociateResourceGroupFromProjectResponse>(req, "DissociateResourceGroupFromProject");
        }

        /// <summary>
        /// 该接口用于将指定执行资源组解除与项目的绑定
        /// </summary>
        /// <param name="req"><see cref="DissociateResourceGroupFromProjectRequest"/></param>
        /// <returns><see cref="DissociateResourceGroupFromProjectResponse"/></returns>
        public DissociateResourceGroupFromProjectResponse DissociateResourceGroupFromProjectSync(DissociateResourceGroupFromProjectRequest req)
        {
            return InternalRequestAsync<DissociateResourceGroupFromProjectResponse>(req, "DissociateResourceGroupFromProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用项目
        /// </summary>
        /// <param name="req"><see cref="EnableProjectRequest"/></param>
        /// <returns><see cref="EnableProjectResponse"/></returns>
        public Task<EnableProjectResponse> EnableProject(EnableProjectRequest req)
        {
            return InternalRequestAsync<EnableProjectResponse>(req, "EnableProject");
        }

        /// <summary>
        /// 启用项目
        /// </summary>
        /// <param name="req"><see cref="EnableProjectRequest"/></param>
        /// <returns><see cref="EnableProjectResponse"/></returns>
        public EnableProjectResponse EnableProjectSync(EnableProjectRequest req)
        {
            return InternalRequestAsync<EnableProjectResponse>(req, "EnableProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询告警信息详情
        /// </summary>
        /// <param name="req"><see cref="GetAlarmMessageRequest"/></param>
        /// <returns><see cref="GetAlarmMessageResponse"/></returns>
        public Task<GetAlarmMessageResponse> GetAlarmMessage(GetAlarmMessageRequest req)
        {
            return InternalRequestAsync<GetAlarmMessageResponse>(req, "GetAlarmMessage");
        }

        /// <summary>
        /// 查询告警信息详情
        /// </summary>
        /// <param name="req"><see cref="GetAlarmMessageRequest"/></param>
        /// <returns><see cref="GetAlarmMessageResponse"/></returns>
        public GetAlarmMessageResponse GetAlarmMessageSync(GetAlarmMessageRequest req)
        {
            return InternalRequestAsync<GetAlarmMessageResponse>(req, "GetAlarmMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看代码文件详情
        /// </summary>
        /// <param name="req"><see cref="GetCodeFileRequest"/></param>
        /// <returns><see cref="GetCodeFileResponse"/></returns>
        public Task<GetCodeFileResponse> GetCodeFile(GetCodeFileRequest req)
        {
            return InternalRequestAsync<GetCodeFileResponse>(req, "GetCodeFile");
        }

        /// <summary>
        /// 查看代码文件详情
        /// </summary>
        /// <param name="req"><see cref="GetCodeFileRequest"/></param>
        /// <returns><see cref="GetCodeFileResponse"/></returns>
        public GetCodeFileResponse GetCodeFileSync(GetCodeFileRequest req)
        {
            return InternalRequestAsync<GetCodeFileResponse>(req, "GetCodeFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取sql文件夹详情
        /// </summary>
        /// <param name="req"><see cref="GetCodeFolderRequest"/></param>
        /// <returns><see cref="GetCodeFolderResponse"/></returns>
        public Task<GetCodeFolderResponse> GetCodeFolder(GetCodeFolderRequest req)
        {
            return InternalRequestAsync<GetCodeFolderResponse>(req, "GetCodeFolder");
        }

        /// <summary>
        /// 获取sql文件夹详情
        /// </summary>
        /// <param name="req"><see cref="GetCodeFolderRequest"/></param>
        /// <returns><see cref="GetCodeFolderResponse"/></returns>
        public GetCodeFolderResponse GetCodeFolderSync(GetCodeFolderRequest req)
        {
            return InternalRequestAsync<GetCodeFolderResponse>(req, "GetCodeFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取补录计划详情
        /// </summary>
        /// <param name="req"><see cref="GetDataBackfillPlanRequest"/></param>
        /// <returns><see cref="GetDataBackfillPlanResponse"/></returns>
        public Task<GetDataBackfillPlanResponse> GetDataBackfillPlan(GetDataBackfillPlanRequest req)
        {
            return InternalRequestAsync<GetDataBackfillPlanResponse>(req, "GetDataBackfillPlan");
        }

        /// <summary>
        /// 获取补录计划详情
        /// </summary>
        /// <param name="req"><see cref="GetDataBackfillPlanRequest"/></param>
        /// <returns><see cref="GetDataBackfillPlanResponse"/></returns>
        public GetDataBackfillPlanResponse GetDataBackfillPlanSync(GetDataBackfillPlanRequest req)
        {
            return InternalRequestAsync<GetDataBackfillPlanResponse>(req, "GetDataBackfillPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查看指定数据源的详细信息
        /// </summary>
        /// <param name="req"><see cref="GetDataSourceRequest"/></param>
        /// <returns><see cref="GetDataSourceResponse"/></returns>
        public Task<GetDataSourceResponse> GetDataSource(GetDataSourceRequest req)
        {
            return InternalRequestAsync<GetDataSourceResponse>(req, "GetDataSource");
        }

        /// <summary>
        /// 该接口用于查看指定数据源的详细信息
        /// </summary>
        /// <param name="req"><see cref="GetDataSourceRequest"/></param>
        /// <returns><see cref="GetDataSourceResponse"/></returns>
        public GetDataSourceResponse GetDataSourceSync(GetDataSourceRequest req)
        {
            return InternalRequestAsync<GetDataSourceResponse>(req, "GetDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据源关联任务详情
        /// </summary>
        /// <param name="req"><see cref="GetDataSourceRelatedTasksRequest"/></param>
        /// <returns><see cref="GetDataSourceRelatedTasksResponse"/></returns>
        public Task<GetDataSourceRelatedTasksResponse> GetDataSourceRelatedTasks(GetDataSourceRelatedTasksRequest req)
        {
            return InternalRequestAsync<GetDataSourceRelatedTasksResponse>(req, "GetDataSourceRelatedTasks");
        }

        /// <summary>
        /// 数据源关联任务详情
        /// </summary>
        /// <param name="req"><see cref="GetDataSourceRelatedTasksRequest"/></param>
        /// <returns><see cref="GetDataSourceRelatedTasksResponse"/></returns>
        public GetDataSourceRelatedTasksResponse GetDataSourceRelatedTasksSync(GetDataSourceRelatedTasksRequest req)
        {
            return InternalRequestAsync<GetDataSourceRelatedTasksResponse>(req, "GetDataSourceRelatedTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据告警规则id/名称查询单个告警规则信息
        /// </summary>
        /// <param name="req"><see cref="GetOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="GetOpsAlarmRuleResponse"/></returns>
        public Task<GetOpsAlarmRuleResponse> GetOpsAlarmRule(GetOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<GetOpsAlarmRuleResponse>(req, "GetOpsAlarmRule");
        }

        /// <summary>
        /// 根据告警规则id/名称查询单个告警规则信息
        /// </summary>
        /// <param name="req"><see cref="GetOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="GetOpsAlarmRuleResponse"/></returns>
        public GetOpsAlarmRuleResponse GetOpsAlarmRuleSync(GetOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<GetOpsAlarmRuleResponse>(req, "GetOpsAlarmRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询运维中心异步操作详情
        /// </summary>
        /// <param name="req"><see cref="GetOpsAsyncJobRequest"/></param>
        /// <returns><see cref="GetOpsAsyncJobResponse"/></returns>
        public Task<GetOpsAsyncJobResponse> GetOpsAsyncJob(GetOpsAsyncJobRequest req)
        {
            return InternalRequestAsync<GetOpsAsyncJobResponse>(req, "GetOpsAsyncJob");
        }

        /// <summary>
        /// 查询运维中心异步操作详情
        /// </summary>
        /// <param name="req"><see cref="GetOpsAsyncJobRequest"/></param>
        /// <returns><see cref="GetOpsAsyncJobResponse"/></returns>
        public GetOpsAsyncJobResponse GetOpsAsyncJobSync(GetOpsAsyncJobRequest req)
        {
            return InternalRequestAsync<GetOpsAsyncJobResponse>(req, "GetOpsAsyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务详情
        /// </summary>
        /// <param name="req"><see cref="GetOpsTaskRequest"/></param>
        /// <returns><see cref="GetOpsTaskResponse"/></returns>
        public Task<GetOpsTaskResponse> GetOpsTask(GetOpsTaskRequest req)
        {
            return InternalRequestAsync<GetOpsTaskResponse>(req, "GetOpsTask");
        }

        /// <summary>
        /// 获取任务详情
        /// </summary>
        /// <param name="req"><see cref="GetOpsTaskRequest"/></param>
        /// <returns><see cref="GetOpsTaskResponse"/></returns>
        public GetOpsTaskResponse GetOpsTaskSync(GetOpsTaskRequest req)
        {
            return InternalRequestAsync<GetOpsTaskResponse>(req, "GetOpsTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务代码
        /// </summary>
        /// <param name="req"><see cref="GetOpsTaskCodeRequest"/></param>
        /// <returns><see cref="GetOpsTaskCodeResponse"/></returns>
        public Task<GetOpsTaskCodeResponse> GetOpsTaskCode(GetOpsTaskCodeRequest req)
        {
            return InternalRequestAsync<GetOpsTaskCodeResponse>(req, "GetOpsTaskCode");
        }

        /// <summary>
        /// 获取任务代码
        /// </summary>
        /// <param name="req"><see cref="GetOpsTaskCodeRequest"/></param>
        /// <returns><see cref="GetOpsTaskCodeResponse"/></returns>
        public GetOpsTaskCodeResponse GetOpsTaskCodeSync(GetOpsTaskCodeRequest req)
        {
            return InternalRequestAsync<GetOpsTaskCodeResponse>(req, "GetOpsTaskCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据工作流id，获取工作流调度详情。
        /// </summary>
        /// <param name="req"><see cref="GetOpsWorkflowRequest"/></param>
        /// <returns><see cref="GetOpsWorkflowResponse"/></returns>
        public Task<GetOpsWorkflowResponse> GetOpsWorkflow(GetOpsWorkflowRequest req)
        {
            return InternalRequestAsync<GetOpsWorkflowResponse>(req, "GetOpsWorkflow");
        }

        /// <summary>
        /// 根据工作流id，获取工作流调度详情。
        /// </summary>
        /// <param name="req"><see cref="GetOpsWorkflowRequest"/></param>
        /// <returns><see cref="GetOpsWorkflowResponse"/></returns>
        public GetOpsWorkflowResponse GetOpsWorkflowSync(GetOpsWorkflowRequest req)
        {
            return InternalRequestAsync<GetOpsWorkflowResponse>(req, "GetOpsWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目信息
        /// </summary>
        /// <param name="req"><see cref="GetProjectRequest"/></param>
        /// <returns><see cref="GetProjectResponse"/></returns>
        public Task<GetProjectResponse> GetProject(GetProjectRequest req)
        {
            return InternalRequestAsync<GetProjectResponse>(req, "GetProject");
        }

        /// <summary>
        /// 获取项目信息
        /// </summary>
        /// <param name="req"><see cref="GetProjectRequest"/></param>
        /// <returns><see cref="GetProjectResponse"/></returns>
        public GetProjectResponse GetProjectSync(GetProjectRequest req)
        {
            return InternalRequestAsync<GetProjectResponse>(req, "GetProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源文件详情
        /// </summary>
        /// <param name="req"><see cref="GetResourceFileRequest"/></param>
        /// <returns><see cref="GetResourceFileResponse"/></returns>
        public Task<GetResourceFileResponse> GetResourceFile(GetResourceFileRequest req)
        {
            return InternalRequestAsync<GetResourceFileResponse>(req, "GetResourceFile");
        }

        /// <summary>
        /// 获取资源文件详情
        /// </summary>
        /// <param name="req"><see cref="GetResourceFileRequest"/></param>
        /// <returns><see cref="GetResourceFileResponse"/></returns>
        public GetResourceFileResponse GetResourceFileSync(GetResourceFileRequest req)
        {
            return InternalRequestAsync<GetResourceFileResponse>(req, "GetResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查看指定执行资源组的监控指标
        /// </summary>
        /// <param name="req"><see cref="GetResourceGroupMetricsRequest"/></param>
        /// <returns><see cref="GetResourceGroupMetricsResponse"/></returns>
        public Task<GetResourceGroupMetricsResponse> GetResourceGroupMetrics(GetResourceGroupMetricsRequest req)
        {
            return InternalRequestAsync<GetResourceGroupMetricsResponse>(req, "GetResourceGroupMetrics");
        }

        /// <summary>
        /// 该接口用于查看指定执行资源组的监控指标
        /// </summary>
        /// <param name="req"><see cref="GetResourceGroupMetricsRequest"/></param>
        /// <returns><see cref="GetResourceGroupMetricsResponse"/></returns>
        public GetResourceGroupMetricsResponse GetResourceGroupMetricsSync(GetResourceGroupMetricsRequest req)
        {
            return InternalRequestAsync<GetResourceGroupMetricsResponse>(req, "GetResourceGroupMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取sql文件夹详情
        /// </summary>
        /// <param name="req"><see cref="GetSQLFolderRequest"/></param>
        /// <returns><see cref="GetSQLFolderResponse"/></returns>
        public Task<GetSQLFolderResponse> GetSQLFolder(GetSQLFolderRequest req)
        {
            return InternalRequestAsync<GetSQLFolderResponse>(req, "GetSQLFolder");
        }

        /// <summary>
        /// 获取sql文件夹详情
        /// </summary>
        /// <param name="req"><see cref="GetSQLFolderRequest"/></param>
        /// <returns><see cref="GetSQLFolderResponse"/></returns>
        public GetSQLFolderResponse GetSQLFolderSync(GetSQLFolderRequest req)
        {
            return InternalRequestAsync<GetSQLFolderResponse>(req, "GetSQLFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询脚本详情
        /// </summary>
        /// <param name="req"><see cref="GetSQLScriptRequest"/></param>
        /// <returns><see cref="GetSQLScriptResponse"/></returns>
        public Task<GetSQLScriptResponse> GetSQLScript(GetSQLScriptRequest req)
        {
            return InternalRequestAsync<GetSQLScriptResponse>(req, "GetSQLScript");
        }

        /// <summary>
        /// 查询脚本详情
        /// </summary>
        /// <param name="req"><see cref="GetSQLScriptRequest"/></param>
        /// <returns><see cref="GetSQLScriptResponse"/></returns>
        public GetSQLScriptResponse GetSQLScriptSync(GetSQLScriptRequest req)
        {
            return InternalRequestAsync<GetSQLScriptResponse>(req, "GetSQLScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表详情
        /// </summary>
        /// <param name="req"><see cref="GetTableRequest"/></param>
        /// <returns><see cref="GetTableResponse"/></returns>
        public Task<GetTableResponse> GetTable(GetTableRequest req)
        {
            return InternalRequestAsync<GetTableResponse>(req, "GetTable");
        }

        /// <summary>
        /// 查询表详情
        /// </summary>
        /// <param name="req"><see cref="GetTableRequest"/></param>
        /// <returns><see cref="GetTableResponse"/></returns>
        public GetTableResponse GetTableSync(GetTableRequest req)
        {
            return InternalRequestAsync<GetTableResponse>(req, "GetTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表所有字段列表
        /// </summary>
        /// <param name="req"><see cref="GetTableColumnsRequest"/></param>
        /// <returns><see cref="GetTableColumnsResponse"/></returns>
        public Task<GetTableColumnsResponse> GetTableColumns(GetTableColumnsRequest req)
        {
            return InternalRequestAsync<GetTableColumnsResponse>(req, "GetTableColumns");
        }

        /// <summary>
        /// 查询表所有字段列表
        /// </summary>
        /// <param name="req"><see cref="GetTableColumnsRequest"/></param>
        /// <returns><see cref="GetTableColumnsResponse"/></returns>
        public GetTableColumnsResponse GetTableColumnsSync(GetTableColumnsRequest req)
        {
            return InternalRequestAsync<GetTableColumnsResponse>(req, "GetTableColumns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建任务接口
        /// </summary>
        /// <param name="req"><see cref="GetTaskRequest"/></param>
        /// <returns><see cref="GetTaskResponse"/></returns>
        public Task<GetTaskResponse> GetTask(GetTaskRequest req)
        {
            return InternalRequestAsync<GetTaskResponse>(req, "GetTask");
        }

        /// <summary>
        /// 创建任务接口
        /// </summary>
        /// <param name="req"><see cref="GetTaskRequest"/></param>
        /// <returns><see cref="GetTaskResponse"/></returns>
        public GetTaskResponse GetTaskSync(GetTaskRequest req)
        {
            return InternalRequestAsync<GetTaskResponse>(req, "GetTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务代码
        /// </summary>
        /// <param name="req"><see cref="GetTaskCodeRequest"/></param>
        /// <returns><see cref="GetTaskCodeResponse"/></returns>
        public Task<GetTaskCodeResponse> GetTaskCode(GetTaskCodeRequest req)
        {
            return InternalRequestAsync<GetTaskCodeResponse>(req, "GetTaskCode");
        }

        /// <summary>
        /// 获取任务代码
        /// </summary>
        /// <param name="req"><see cref="GetTaskCodeRequest"/></param>
        /// <returns><see cref="GetTaskCodeResponse"/></returns>
        public GetTaskCodeResponse GetTaskCodeSync(GetTaskCodeRequest req)
        {
            return InternalRequestAsync<GetTaskCodeResponse>(req, "GetTaskCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调度实例详情
        /// </summary>
        /// <param name="req"><see cref="GetTaskInstanceRequest"/></param>
        /// <returns><see cref="GetTaskInstanceResponse"/></returns>
        public Task<GetTaskInstanceResponse> GetTaskInstance(GetTaskInstanceRequest req)
        {
            return InternalRequestAsync<GetTaskInstanceResponse>(req, "GetTaskInstance");
        }

        /// <summary>
        /// 调度实例详情
        /// </summary>
        /// <param name="req"><see cref="GetTaskInstanceRequest"/></param>
        /// <returns><see cref="GetTaskInstanceResponse"/></returns>
        public GetTaskInstanceResponse GetTaskInstanceSync(GetTaskInstanceRequest req)
        {
            return InternalRequestAsync<GetTaskInstanceResponse>(req, "GetTaskInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="GetTaskInstanceLogRequest"/></param>
        /// <returns><see cref="GetTaskInstanceLogResponse"/></returns>
        public Task<GetTaskInstanceLogResponse> GetTaskInstanceLog(GetTaskInstanceLogRequest req)
        {
            return InternalRequestAsync<GetTaskInstanceLogResponse>(req, "GetTaskInstanceLog");
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="GetTaskInstanceLogRequest"/></param>
        /// <returns><see cref="GetTaskInstanceLogResponse"/></returns>
        public GetTaskInstanceLogResponse GetTaskInstanceLogSync(GetTaskInstanceLogRequest req)
        {
            return InternalRequestAsync<GetTaskInstanceLogResponse>(req, "GetTaskInstanceLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取任务版本列表
        /// </summary>
        /// <param name="req"><see cref="GetTaskVersionRequest"/></param>
        /// <returns><see cref="GetTaskVersionResponse"/></returns>
        public Task<GetTaskVersionResponse> GetTaskVersion(GetTaskVersionRequest req)
        {
            return InternalRequestAsync<GetTaskVersionResponse>(req, "GetTaskVersion");
        }

        /// <summary>
        /// 拉取任务版本列表
        /// </summary>
        /// <param name="req"><see cref="GetTaskVersionRequest"/></param>
        /// <returns><see cref="GetTaskVersionResponse"/></returns>
        public GetTaskVersionResponse GetTaskVersionSync(GetTaskVersionRequest req)
        {
            return InternalRequestAsync<GetTaskVersionResponse>(req, "GetTaskVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取工作流信息
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRequest"/></param>
        /// <returns><see cref="GetWorkflowResponse"/></returns>
        public Task<GetWorkflowResponse> GetWorkflow(GetWorkflowRequest req)
        {
            return InternalRequestAsync<GetWorkflowResponse>(req, "GetWorkflow");
        }

        /// <summary>
        /// 获取工作流信息
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRequest"/></param>
        /// <returns><see cref="GetWorkflowResponse"/></returns>
        public GetWorkflowResponse GetWorkflowSync(GetWorkflowRequest req)
        {
            return InternalRequestAsync<GetWorkflowResponse>(req, "GetWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改项目用户角色
        /// </summary>
        /// <param name="req"><see cref="GrantMemberProjectRoleRequest"/></param>
        /// <returns><see cref="GrantMemberProjectRoleResponse"/></returns>
        public Task<GrantMemberProjectRoleResponse> GrantMemberProjectRole(GrantMemberProjectRoleRequest req)
        {
            return InternalRequestAsync<GrantMemberProjectRoleResponse>(req, "GrantMemberProjectRole");
        }

        /// <summary>
        /// 修改项目用户角色
        /// </summary>
        /// <param name="req"><see cref="GrantMemberProjectRoleRequest"/></param>
        /// <returns><see cref="GrantMemberProjectRoleResponse"/></returns>
        public GrantMemberProjectRoleResponse GrantMemberProjectRoleSync(GrantMemberProjectRoleRequest req)
        {
            return InternalRequestAsync<GrantMemberProjectRoleResponse>(req, "GrantMemberProjectRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例批量终止操作-异步操作
        /// </summary>
        /// <param name="req"><see cref="KillTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="KillTaskInstancesAsyncResponse"/></returns>
        public Task<KillTaskInstancesAsyncResponse> KillTaskInstancesAsync(KillTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<KillTaskInstancesAsyncResponse>(req, "KillTaskInstancesAsync");
        }

        /// <summary>
        /// 实例批量终止操作-异步操作
        /// </summary>
        /// <param name="req"><see cref="KillTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="KillTaskInstancesAsyncResponse"/></returns>
        public KillTaskInstancesAsyncResponse KillTaskInstancesAsyncSync(KillTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<KillTaskInstancesAsyncResponse>(req, "KillTaskInstancesAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取告警信息列表
        /// </summary>
        /// <param name="req"><see cref="ListAlarmMessagesRequest"/></param>
        /// <returns><see cref="ListAlarmMessagesResponse"/></returns>
        public Task<ListAlarmMessagesResponse> ListAlarmMessages(ListAlarmMessagesRequest req)
        {
            return InternalRequestAsync<ListAlarmMessagesResponse>(req, "ListAlarmMessages");
        }

        /// <summary>
        /// 获取告警信息列表
        /// </summary>
        /// <param name="req"><see cref="ListAlarmMessagesRequest"/></param>
        /// <returns><see cref="ListAlarmMessagesResponse"/></returns>
        public ListAlarmMessagesResponse ListAlarmMessagesSync(ListAlarmMessagesRequest req)
        {
            return InternalRequestAsync<ListAlarmMessagesResponse>(req, "ListAlarmMessages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产目录信息
        /// </summary>
        /// <param name="req"><see cref="ListCatalogRequest"/></param>
        /// <returns><see cref="ListCatalogResponse"/></returns>
        public Task<ListCatalogResponse> ListCatalog(ListCatalogRequest req)
        {
            return InternalRequestAsync<ListCatalogResponse>(req, "ListCatalog");
        }

        /// <summary>
        /// 获取资产目录信息
        /// </summary>
        /// <param name="req"><see cref="ListCatalogRequest"/></param>
        /// <returns><see cref="ListCatalogResponse"/></returns>
        public ListCatalogResponse ListCatalogSync(ListCatalogRequest req)
        {
            return InternalRequestAsync<ListCatalogResponse>(req, "ListCatalog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取文件夹内容
        /// </summary>
        /// <param name="req"><see cref="ListCodeFolderContentsRequest"/></param>
        /// <returns><see cref="ListCodeFolderContentsResponse"/></returns>
        public Task<ListCodeFolderContentsResponse> ListCodeFolderContents(ListCodeFolderContentsRequest req)
        {
            return InternalRequestAsync<ListCodeFolderContentsResponse>(req, "ListCodeFolderContents");
        }

        /// <summary>
        /// 获取文件夹内容
        /// </summary>
        /// <param name="req"><see cref="ListCodeFolderContentsRequest"/></param>
        /// <returns><see cref="ListCodeFolderContentsResponse"/></returns>
        public ListCodeFolderContentsResponse ListCodeFolderContentsSync(ListCodeFolderContentsRequest req)
        {
            return InternalRequestAsync<ListCodeFolderContentsResponse>(req, "ListCodeFolderContents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取表字段血缘信息
        /// </summary>
        /// <param name="req"><see cref="ListColumnLineageRequest"/></param>
        /// <returns><see cref="ListColumnLineageResponse"/></returns>
        public Task<ListColumnLineageResponse> ListColumnLineage(ListColumnLineageRequest req)
        {
            return InternalRequestAsync<ListColumnLineageResponse>(req, "ListColumnLineage");
        }

        /// <summary>
        /// 获取表字段血缘信息
        /// </summary>
        /// <param name="req"><see cref="ListColumnLineageRequest"/></param>
        /// <returns><see cref="ListColumnLineageResponse"/></returns>
        public ListColumnLineageResponse ListColumnLineageSync(ListColumnLineageRequest req)
        {
            return InternalRequestAsync<ListColumnLineageResponse>(req, "ListColumnLineage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单次补录的所有实例详情
        /// </summary>
        /// <param name="req"><see cref="ListDataBackfillInstancesRequest"/></param>
        /// <returns><see cref="ListDataBackfillInstancesResponse"/></returns>
        public Task<ListDataBackfillInstancesResponse> ListDataBackfillInstances(ListDataBackfillInstancesRequest req)
        {
            return InternalRequestAsync<ListDataBackfillInstancesResponse>(req, "ListDataBackfillInstances");
        }

        /// <summary>
        /// 获取单次补录的所有实例详情
        /// </summary>
        /// <param name="req"><see cref="ListDataBackfillInstancesRequest"/></param>
        /// <returns><see cref="ListDataBackfillInstancesResponse"/></returns>
        public ListDataBackfillInstancesResponse ListDataBackfillInstancesSync(ListDataBackfillInstancesRequest req)
        {
            return InternalRequestAsync<ListDataBackfillInstancesResponse>(req, "ListDataBackfillInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询指定项目中的数据源列表
        /// </summary>
        /// <param name="req"><see cref="ListDataSourcesRequest"/></param>
        /// <returns><see cref="ListDataSourcesResponse"/></returns>
        public Task<ListDataSourcesResponse> ListDataSources(ListDataSourcesRequest req)
        {
            return InternalRequestAsync<ListDataSourcesResponse>(req, "ListDataSources");
        }

        /// <summary>
        /// 该接口用于查询指定项目中的数据源列表
        /// </summary>
        /// <param name="req"><see cref="ListDataSourcesRequest"/></param>
        /// <returns><see cref="ListDataSourcesResponse"/></returns>
        public ListDataSourcesResponse ListDataSourcesSync(ListDataSourcesRequest req)
        {
            return InternalRequestAsync<ListDataSourcesResponse>(req, "ListDataSources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产数据库信息
        /// </summary>
        /// <param name="req"><see cref="ListDatabaseRequest"/></param>
        /// <returns><see cref="ListDatabaseResponse"/></returns>
        public Task<ListDatabaseResponse> ListDatabase(ListDatabaseRequest req)
        {
            return InternalRequestAsync<ListDatabaseResponse>(req, "ListDatabase");
        }

        /// <summary>
        /// 获取资产数据库信息
        /// </summary>
        /// <param name="req"><see cref="ListDatabaseRequest"/></param>
        /// <returns><see cref="ListDatabaseResponse"/></returns>
        public ListDatabaseResponse ListDatabaseSync(ListDatabaseRequest req)
        {
            return InternalRequestAsync<ListDatabaseResponse>(req, "ListDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务直接下游详情
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamOpsTasksRequest"/></param>
        /// <returns><see cref="ListDownstreamOpsTasksResponse"/></returns>
        public Task<ListDownstreamOpsTasksResponse> ListDownstreamOpsTasks(ListDownstreamOpsTasksRequest req)
        {
            return InternalRequestAsync<ListDownstreamOpsTasksResponse>(req, "ListDownstreamOpsTasks");
        }

        /// <summary>
        /// 获取任务直接下游详情
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamOpsTasksRequest"/></param>
        /// <returns><see cref="ListDownstreamOpsTasksResponse"/></returns>
        public ListDownstreamOpsTasksResponse ListDownstreamOpsTasksSync(ListDownstreamOpsTasksRequest req)
        {
            return InternalRequestAsync<ListDownstreamOpsTasksResponse>(req, "ListDownstreamOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例直接上游
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamTaskInstancesRequest"/></param>
        /// <returns><see cref="ListDownstreamTaskInstancesResponse"/></returns>
        public Task<ListDownstreamTaskInstancesResponse> ListDownstreamTaskInstances(ListDownstreamTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListDownstreamTaskInstancesResponse>(req, "ListDownstreamTaskInstances");
        }

        /// <summary>
        /// 获取实例直接上游
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamTaskInstancesRequest"/></param>
        /// <returns><see cref="ListDownstreamTaskInstancesResponse"/></returns>
        public ListDownstreamTaskInstancesResponse ListDownstreamTaskInstancesSync(ListDownstreamTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListDownstreamTaskInstancesResponse>(req, "ListDownstreamTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务直接下游详情
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamTasksRequest"/></param>
        /// <returns><see cref="ListDownstreamTasksResponse"/></returns>
        public Task<ListDownstreamTasksResponse> ListDownstreamTasks(ListDownstreamTasksRequest req)
        {
            return InternalRequestAsync<ListDownstreamTasksResponse>(req, "ListDownstreamTasks");
        }

        /// <summary>
        /// 获取任务直接下游详情
        /// </summary>
        /// <param name="req"><see cref="ListDownstreamTasksRequest"/></param>
        /// <returns><see cref="ListDownstreamTasksResponse"/></returns>
        public ListDownstreamTasksResponse ListDownstreamTasksSync(ListDownstreamTasksRequest req)
        {
            return InternalRequestAsync<ListDownstreamTasksResponse>(req, "ListDownstreamTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产血缘信息
        /// </summary>
        /// <param name="req"><see cref="ListLineageRequest"/></param>
        /// <returns><see cref="ListLineageResponse"/></returns>
        public Task<ListLineageResponse> ListLineage(ListLineageRequest req)
        {
            return InternalRequestAsync<ListLineageResponse>(req, "ListLineage");
        }

        /// <summary>
        /// 获取资产血缘信息
        /// </summary>
        /// <param name="req"><see cref="ListLineageRequest"/></param>
        /// <returns><see cref="ListLineageResponse"/></returns>
        public ListLineageResponse ListLineageSync(ListLineageRequest req)
        {
            return InternalRequestAsync<ListLineageResponse>(req, "ListLineage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询告警规则列表
        /// </summary>
        /// <param name="req"><see cref="ListOpsAlarmRulesRequest"/></param>
        /// <returns><see cref="ListOpsAlarmRulesResponse"/></returns>
        public Task<ListOpsAlarmRulesResponse> ListOpsAlarmRules(ListOpsAlarmRulesRequest req)
        {
            return InternalRequestAsync<ListOpsAlarmRulesResponse>(req, "ListOpsAlarmRules");
        }

        /// <summary>
        /// 查询告警规则列表
        /// </summary>
        /// <param name="req"><see cref="ListOpsAlarmRulesRequest"/></param>
        /// <returns><see cref="ListOpsAlarmRulesResponse"/></returns>
        public ListOpsAlarmRulesResponse ListOpsAlarmRulesSync(ListOpsAlarmRulesRequest req)
        {
            return InternalRequestAsync<ListOpsAlarmRulesResponse>(req, "ListOpsAlarmRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据项目id获取任务列表
        /// </summary>
        /// <param name="req"><see cref="ListOpsTasksRequest"/></param>
        /// <returns><see cref="ListOpsTasksResponse"/></returns>
        public Task<ListOpsTasksResponse> ListOpsTasks(ListOpsTasksRequest req)
        {
            return InternalRequestAsync<ListOpsTasksResponse>(req, "ListOpsTasks");
        }

        /// <summary>
        /// 根据项目id获取任务列表
        /// </summary>
        /// <param name="req"><see cref="ListOpsTasksRequest"/></param>
        /// <returns><see cref="ListOpsTasksResponse"/></returns>
        public ListOpsTasksResponse ListOpsTasksSync(ListOpsTasksRequest req)
        {
            return InternalRequestAsync<ListOpsTasksResponse>(req, "ListOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据项目ID获取项目下工作流
        /// </summary>
        /// <param name="req"><see cref="ListOpsWorkflowsRequest"/></param>
        /// <returns><see cref="ListOpsWorkflowsResponse"/></returns>
        public Task<ListOpsWorkflowsResponse> ListOpsWorkflows(ListOpsWorkflowsRequest req)
        {
            return InternalRequestAsync<ListOpsWorkflowsResponse>(req, "ListOpsWorkflows");
        }

        /// <summary>
        /// 根据项目ID获取项目下工作流
        /// </summary>
        /// <param name="req"><see cref="ListOpsWorkflowsRequest"/></param>
        /// <returns><see cref="ListOpsWorkflowsResponse"/></returns>
        public ListOpsWorkflowsResponse ListOpsWorkflowsSync(ListOpsWorkflowsRequest req)
        {
            return InternalRequestAsync<ListOpsWorkflowsResponse>(req, "ListOpsWorkflows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产血缘信息
        /// </summary>
        /// <param name="req"><see cref="ListProcessLineageRequest"/></param>
        /// <returns><see cref="ListProcessLineageResponse"/></returns>
        public Task<ListProcessLineageResponse> ListProcessLineage(ListProcessLineageRequest req)
        {
            return InternalRequestAsync<ListProcessLineageResponse>(req, "ListProcessLineage");
        }

        /// <summary>
        /// 获取资产血缘信息
        /// </summary>
        /// <param name="req"><see cref="ListProcessLineageRequest"/></param>
        /// <returns><see cref="ListProcessLineageResponse"/></returns>
        public ListProcessLineageResponse ListProcessLineageSync(ListProcessLineageRequest req)
        {
            return InternalRequestAsync<ListProcessLineageResponse>(req, "ListProcessLineage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的用户，分页返回
        /// </summary>
        /// <param name="req"><see cref="ListProjectMembersRequest"/></param>
        /// <returns><see cref="ListProjectMembersResponse"/></returns>
        public Task<ListProjectMembersResponse> ListProjectMembers(ListProjectMembersRequest req)
        {
            return InternalRequestAsync<ListProjectMembersResponse>(req, "ListProjectMembers");
        }

        /// <summary>
        /// 获取项目下的用户，分页返回
        /// </summary>
        /// <param name="req"><see cref="ListProjectMembersRequest"/></param>
        /// <returns><see cref="ListProjectMembersResponse"/></returns>
        public ListProjectMembersResponse ListProjectMembersSync(ListProjectMembersRequest req)
        {
            return InternalRequestAsync<ListProjectMembersResponse>(req, "ListProjectMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取角色列表信息
        /// </summary>
        /// <param name="req"><see cref="ListProjectRolesRequest"/></param>
        /// <returns><see cref="ListProjectRolesResponse"/></returns>
        public Task<ListProjectRolesResponse> ListProjectRoles(ListProjectRolesRequest req)
        {
            return InternalRequestAsync<ListProjectRolesResponse>(req, "ListProjectRoles");
        }

        /// <summary>
        /// 获取角色列表信息
        /// </summary>
        /// <param name="req"><see cref="ListProjectRolesRequest"/></param>
        /// <returns><see cref="ListProjectRolesResponse"/></returns>
        public ListProjectRolesResponse ListProjectRolesSync(ListProjectRolesRequest req)
        {
            return InternalRequestAsync<ListProjectRolesResponse>(req, "ListProjectRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 租户全局范围的项目列表，与用户查看范围无关.
        /// </summary>
        /// <param name="req"><see cref="ListProjectsRequest"/></param>
        /// <returns><see cref="ListProjectsResponse"/></returns>
        public Task<ListProjectsResponse> ListProjects(ListProjectsRequest req)
        {
            return InternalRequestAsync<ListProjectsResponse>(req, "ListProjects");
        }

        /// <summary>
        /// 租户全局范围的项目列表，与用户查看范围无关.
        /// </summary>
        /// <param name="req"><see cref="ListProjectsRequest"/></param>
        /// <returns><see cref="ListProjectsResponse"/></returns>
        public ListProjectsResponse ListProjectsSync(ListProjectsRequest req)
        {
            return InternalRequestAsync<ListProjectsResponse>(req, "ListProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源文件列表
        /// </summary>
        /// <param name="req"><see cref="ListResourceFilesRequest"/></param>
        /// <returns><see cref="ListResourceFilesResponse"/></returns>
        public Task<ListResourceFilesResponse> ListResourceFiles(ListResourceFilesRequest req)
        {
            return InternalRequestAsync<ListResourceFilesResponse>(req, "ListResourceFiles");
        }

        /// <summary>
        /// 获取资源文件列表
        /// </summary>
        /// <param name="req"><see cref="ListResourceFilesRequest"/></param>
        /// <returns><see cref="ListResourceFilesResponse"/></returns>
        public ListResourceFilesResponse ListResourceFilesSync(ListResourceFilesRequest req)
        {
            return InternalRequestAsync<ListResourceFilesResponse>(req, "ListResourceFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源文件文件夹列表
        /// </summary>
        /// <param name="req"><see cref="ListResourceFoldersRequest"/></param>
        /// <returns><see cref="ListResourceFoldersResponse"/></returns>
        public Task<ListResourceFoldersResponse> ListResourceFolders(ListResourceFoldersRequest req)
        {
            return InternalRequestAsync<ListResourceFoldersResponse>(req, "ListResourceFolders");
        }

        /// <summary>
        /// 查询资源文件文件夹列表
        /// </summary>
        /// <param name="req"><see cref="ListResourceFoldersRequest"/></param>
        /// <returns><see cref="ListResourceFoldersResponse"/></returns>
        public ListResourceFoldersResponse ListResourceFoldersSync(ListResourceFoldersRequest req)
        {
            return InternalRequestAsync<ListResourceFoldersResponse>(req, "ListResourceFolders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询执行资源组列表
        /// </summary>
        /// <param name="req"><see cref="ListResourceGroupsRequest"/></param>
        /// <returns><see cref="ListResourceGroupsResponse"/></returns>
        public Task<ListResourceGroupsResponse> ListResourceGroups(ListResourceGroupsRequest req)
        {
            return InternalRequestAsync<ListResourceGroupsResponse>(req, "ListResourceGroups");
        }

        /// <summary>
        /// 该接口用于查询执行资源组列表
        /// </summary>
        /// <param name="req"><see cref="ListResourceGroupsRequest"/></param>
        /// <returns><see cref="ListResourceGroupsResponse"/></returns>
        public ListResourceGroupsResponse ListResourceGroupsSync(ListResourceGroupsRequest req)
        {
            return InternalRequestAsync<ListResourceGroupsResponse>(req, "ListResourceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据探索文件夹树，包括文件夹下的脚本
        /// </summary>
        /// <param name="req"><see cref="ListSQLFolderContentsRequest"/></param>
        /// <returns><see cref="ListSQLFolderContentsResponse"/></returns>
        public Task<ListSQLFolderContentsResponse> ListSQLFolderContents(ListSQLFolderContentsRequest req)
        {
            return InternalRequestAsync<ListSQLFolderContentsResponse>(req, "ListSQLFolderContents");
        }

        /// <summary>
        /// 查询数据探索文件夹树，包括文件夹下的脚本
        /// </summary>
        /// <param name="req"><see cref="ListSQLFolderContentsRequest"/></param>
        /// <returns><see cref="ListSQLFolderContentsResponse"/></returns>
        public ListSQLFolderContentsResponse ListSQLFolderContentsSync(ListSQLFolderContentsRequest req)
        {
            return InternalRequestAsync<ListSQLFolderContentsResponse>(req, "ListSQLFolderContents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询SQL运行记录
        /// </summary>
        /// <param name="req"><see cref="ListSQLScriptRunsRequest"/></param>
        /// <returns><see cref="ListSQLScriptRunsResponse"/></returns>
        public Task<ListSQLScriptRunsResponse> ListSQLScriptRuns(ListSQLScriptRunsRequest req)
        {
            return InternalRequestAsync<ListSQLScriptRunsResponse>(req, "ListSQLScriptRuns");
        }

        /// <summary>
        /// 查询SQL运行记录
        /// </summary>
        /// <param name="req"><see cref="ListSQLScriptRunsRequest"/></param>
        /// <returns><see cref="ListSQLScriptRunsResponse"/></returns>
        public ListSQLScriptRunsResponse ListSQLScriptRunsSync(ListSQLScriptRunsRequest req)
        {
            return InternalRequestAsync<ListSQLScriptRunsResponse>(req, "ListSQLScriptRuns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产数据库Schema信息
        /// </summary>
        /// <param name="req"><see cref="ListSchemaRequest"/></param>
        /// <returns><see cref="ListSchemaResponse"/></returns>
        public Task<ListSchemaResponse> ListSchema(ListSchemaRequest req)
        {
            return InternalRequestAsync<ListSchemaResponse>(req, "ListSchema");
        }

        /// <summary>
        /// 获取资产数据库Schema信息
        /// </summary>
        /// <param name="req"><see cref="ListSchemaRequest"/></param>
        /// <returns><see cref="ListSchemaResponse"/></returns>
        public ListSchemaResponse ListSchemaSync(ListSchemaRequest req)
        {
            return InternalRequestAsync<ListSchemaResponse>(req, "ListSchema")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产表信息
        /// </summary>
        /// <param name="req"><see cref="ListTableRequest"/></param>
        /// <returns><see cref="ListTableResponse"/></returns>
        public Task<ListTableResponse> ListTable(ListTableRequest req)
        {
            return InternalRequestAsync<ListTableResponse>(req, "ListTable");
        }

        /// <summary>
        /// 获取资产表信息
        /// </summary>
        /// <param name="req"><see cref="ListTableRequest"/></param>
        /// <returns><see cref="ListTableResponse"/></returns>
        public ListTableResponse ListTableSync(ListTableRequest req)
        {
            return InternalRequestAsync<ListTableResponse>(req, "ListTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调度实例详情
        /// </summary>
        /// <param name="req"><see cref="ListTaskInstanceExecutionsRequest"/></param>
        /// <returns><see cref="ListTaskInstanceExecutionsResponse"/></returns>
        public Task<ListTaskInstanceExecutionsResponse> ListTaskInstanceExecutions(ListTaskInstanceExecutionsRequest req)
        {
            return InternalRequestAsync<ListTaskInstanceExecutionsResponse>(req, "ListTaskInstanceExecutions");
        }

        /// <summary>
        /// 调度实例详情
        /// </summary>
        /// <param name="req"><see cref="ListTaskInstanceExecutionsRequest"/></param>
        /// <returns><see cref="ListTaskInstanceExecutionsResponse"/></returns>
        public ListTaskInstanceExecutionsResponse ListTaskInstanceExecutionsSync(ListTaskInstanceExecutionsRequest req)
        {
            return InternalRequestAsync<ListTaskInstanceExecutionsResponse>(req, "ListTaskInstanceExecutions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="ListTaskInstancesRequest"/></param>
        /// <returns><see cref="ListTaskInstancesResponse"/></returns>
        public Task<ListTaskInstancesResponse> ListTaskInstances(ListTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListTaskInstancesResponse>(req, "ListTaskInstances");
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="ListTaskInstancesRequest"/></param>
        /// <returns><see cref="ListTaskInstancesResponse"/></returns>
        public ListTaskInstancesResponse ListTaskInstancesSync(ListTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListTaskInstancesResponse>(req, "ListTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务保存版本列表
        /// </summary>
        /// <param name="req"><see cref="ListTaskVersionsRequest"/></param>
        /// <returns><see cref="ListTaskVersionsResponse"/></returns>
        public Task<ListTaskVersionsResponse> ListTaskVersions(ListTaskVersionsRequest req)
        {
            return InternalRequestAsync<ListTaskVersionsResponse>(req, "ListTaskVersions");
        }

        /// <summary>
        /// 任务保存版本列表
        /// </summary>
        /// <param name="req"><see cref="ListTaskVersionsRequest"/></param>
        /// <returns><see cref="ListTaskVersionsResponse"/></returns>
        public ListTaskVersionsResponse ListTaskVersionsSync(ListTaskVersionsRequest req)
        {
            return InternalRequestAsync<ListTaskVersionsResponse>(req, "ListTaskVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务分页信息
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public Task<ListTasksResponse> ListTasks(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks");
        }

        /// <summary>
        /// 查询任务分页信息
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public ListTasksResponse ListTasksSync(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取所有主账号角色列表
        /// </summary>
        /// <param name="req"><see cref="ListTenantRolesRequest"/></param>
        /// <returns><see cref="ListTenantRolesResponse"/></returns>
        public Task<ListTenantRolesResponse> ListTenantRoles(ListTenantRolesRequest req)
        {
            return InternalRequestAsync<ListTenantRolesResponse>(req, "ListTenantRoles");
        }

        /// <summary>
        /// 获取所有主账号角色列表
        /// </summary>
        /// <param name="req"><see cref="ListTenantRolesRequest"/></param>
        /// <returns><see cref="ListTenantRolesResponse"/></returns>
        public ListTenantRolesResponse ListTenantRolesSync(ListTenantRolesRequest req)
        {
            return InternalRequestAsync<ListTenantRolesResponse>(req, "ListTenantRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务直接上游
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamOpsTasksRequest"/></param>
        /// <returns><see cref="ListUpstreamOpsTasksResponse"/></returns>
        public Task<ListUpstreamOpsTasksResponse> ListUpstreamOpsTasks(ListUpstreamOpsTasksRequest req)
        {
            return InternalRequestAsync<ListUpstreamOpsTasksResponse>(req, "ListUpstreamOpsTasks");
        }

        /// <summary>
        /// 获取任务直接上游
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamOpsTasksRequest"/></param>
        /// <returns><see cref="ListUpstreamOpsTasksResponse"/></returns>
        public ListUpstreamOpsTasksResponse ListUpstreamOpsTasksSync(ListUpstreamOpsTasksRequest req)
        {
            return InternalRequestAsync<ListUpstreamOpsTasksResponse>(req, "ListUpstreamOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例直接上游
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamTaskInstancesRequest"/></param>
        /// <returns><see cref="ListUpstreamTaskInstancesResponse"/></returns>
        public Task<ListUpstreamTaskInstancesResponse> ListUpstreamTaskInstances(ListUpstreamTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListUpstreamTaskInstancesResponse>(req, "ListUpstreamTaskInstances");
        }

        /// <summary>
        /// 获取实例直接上游
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamTaskInstancesRequest"/></param>
        /// <returns><see cref="ListUpstreamTaskInstancesResponse"/></returns>
        public ListUpstreamTaskInstancesResponse ListUpstreamTaskInstancesSync(ListUpstreamTaskInstancesRequest req)
        {
            return InternalRequestAsync<ListUpstreamTaskInstancesResponse>(req, "ListUpstreamTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务直接上游
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamTasksRequest"/></param>
        /// <returns><see cref="ListUpstreamTasksResponse"/></returns>
        public Task<ListUpstreamTasksResponse> ListUpstreamTasks(ListUpstreamTasksRequest req)
        {
            return InternalRequestAsync<ListUpstreamTasksResponse>(req, "ListUpstreamTasks");
        }

        /// <summary>
        /// 获取任务直接上游
        /// </summary>
        /// <param name="req"><see cref="ListUpstreamTasksRequest"/></param>
        /// <returns><see cref="ListUpstreamTasksResponse"/></returns>
        public ListUpstreamTasksResponse ListUpstreamTasksSync(ListUpstreamTasksRequest req)
        {
            return InternalRequestAsync<ListUpstreamTasksResponse>(req, "ListUpstreamTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文件夹列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowFoldersRequest"/></param>
        /// <returns><see cref="ListWorkflowFoldersResponse"/></returns>
        public Task<ListWorkflowFoldersResponse> ListWorkflowFolders(ListWorkflowFoldersRequest req)
        {
            return InternalRequestAsync<ListWorkflowFoldersResponse>(req, "ListWorkflowFolders");
        }

        /// <summary>
        /// 查询文件夹列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowFoldersRequest"/></param>
        /// <returns><see cref="ListWorkflowFoldersResponse"/></returns>
        public ListWorkflowFoldersResponse ListWorkflowFoldersSync(ListWorkflowFoldersRequest req)
        {
            return InternalRequestAsync<ListWorkflowFoldersResponse>(req, "ListWorkflowFolders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作流列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowsRequest"/></param>
        /// <returns><see cref="ListWorkflowsResponse"/></returns>
        public Task<ListWorkflowsResponse> ListWorkflows(ListWorkflowsRequest req)
        {
            return InternalRequestAsync<ListWorkflowsResponse>(req, "ListWorkflows");
        }

        /// <summary>
        /// 查询工作流列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowsRequest"/></param>
        /// <returns><see cref="ListWorkflowsResponse"/></returns>
        public ListWorkflowsResponse ListWorkflowsSync(ListWorkflowsRequest req)
        {
            return InternalRequestAsync<ListWorkflowsResponse>(req, "ListWorkflows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 异步批量暂停任务
        /// </summary>
        /// <param name="req"><see cref="PauseOpsTasksAsyncRequest"/></param>
        /// <returns><see cref="PauseOpsTasksAsyncResponse"/></returns>
        public Task<PauseOpsTasksAsyncResponse> PauseOpsTasksAsync(PauseOpsTasksAsyncRequest req)
        {
            return InternalRequestAsync<PauseOpsTasksAsyncResponse>(req, "PauseOpsTasksAsync");
        }

        /// <summary>
        /// 异步批量暂停任务
        /// </summary>
        /// <param name="req"><see cref="PauseOpsTasksAsyncRequest"/></param>
        /// <returns><see cref="PauseOpsTasksAsyncResponse"/></returns>
        public PauseOpsTasksAsyncResponse PauseOpsTasksAsyncSync(PauseOpsTasksAsyncRequest req)
        {
            return InternalRequestAsync<PauseOpsTasksAsyncResponse>(req, "PauseOpsTasksAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// RegisterLineage
        /// </summary>
        /// <param name="req"><see cref="RegisterLineageRequest"/></param>
        /// <returns><see cref="RegisterLineageResponse"/></returns>
        public Task<RegisterLineageResponse> RegisterLineage(RegisterLineageRequest req)
        {
            return InternalRequestAsync<RegisterLineageResponse>(req, "RegisterLineage");
        }

        /// <summary>
        /// RegisterLineage
        /// </summary>
        /// <param name="req"><see cref="RegisterLineageRequest"/></param>
        /// <returns><see cref="RegisterLineageResponse"/></returns>
        public RegisterLineageResponse RegisterLineageSync(RegisterLineageRequest req)
        {
            return InternalRequestAsync<RegisterLineageResponse>(req, "RegisterLineage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除项目用户角色
        /// </summary>
        /// <param name="req"><see cref="RemoveMemberProjectRoleRequest"/></param>
        /// <returns><see cref="RemoveMemberProjectRoleResponse"/></returns>
        public Task<RemoveMemberProjectRoleResponse> RemoveMemberProjectRole(RemoveMemberProjectRoleRequest req)
        {
            return InternalRequestAsync<RemoveMemberProjectRoleResponse>(req, "RemoveMemberProjectRole");
        }

        /// <summary>
        /// 删除项目用户角色
        /// </summary>
        /// <param name="req"><see cref="RemoveMemberProjectRoleRequest"/></param>
        /// <returns><see cref="RemoveMemberProjectRoleResponse"/></returns>
        public RemoveMemberProjectRoleResponse RemoveMemberProjectRoleSync(RemoveMemberProjectRoleRequest req)
        {
            return InternalRequestAsync<RemoveMemberProjectRoleResponse>(req, "RemoveMemberProjectRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例批量重跑-异步
        /// </summary>
        /// <param name="req"><see cref="RerunTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="RerunTaskInstancesAsyncResponse"/></returns>
        public Task<RerunTaskInstancesAsyncResponse> RerunTaskInstancesAsync(RerunTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<RerunTaskInstancesAsyncResponse>(req, "RerunTaskInstancesAsync");
        }

        /// <summary>
        /// 实例批量重跑-异步
        /// </summary>
        /// <param name="req"><see cref="RerunTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="RerunTaskInstancesAsyncResponse"/></returns>
        public RerunTaskInstancesAsyncResponse RerunTaskInstancesAsyncSync(RerunTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<RerunTaskInstancesAsyncResponse>(req, "RerunTaskInstancesAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运行SQL脚本
        /// </summary>
        /// <param name="req"><see cref="RunSQLScriptRequest"/></param>
        /// <returns><see cref="RunSQLScriptResponse"/></returns>
        public Task<RunSQLScriptResponse> RunSQLScript(RunSQLScriptRequest req)
        {
            return InternalRequestAsync<RunSQLScriptResponse>(req, "RunSQLScript");
        }

        /// <summary>
        /// 运行SQL脚本
        /// </summary>
        /// <param name="req"><see cref="RunSQLScriptRequest"/></param>
        /// <returns><see cref="RunSQLScriptResponse"/></returns>
        public RunSQLScriptResponse RunSQLScriptSync(RunSQLScriptRequest req)
        {
            return InternalRequestAsync<RunSQLScriptResponse>(req, "RunSQLScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例批量置成功-异步
        /// </summary>
        /// <param name="req"><see cref="SetSuccessTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="SetSuccessTaskInstancesAsyncResponse"/></returns>
        public Task<SetSuccessTaskInstancesAsyncResponse> SetSuccessTaskInstancesAsync(SetSuccessTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<SetSuccessTaskInstancesAsyncResponse>(req, "SetSuccessTaskInstancesAsync");
        }

        /// <summary>
        /// 实例批量置成功-异步
        /// </summary>
        /// <param name="req"><see cref="SetSuccessTaskInstancesAsyncRequest"/></param>
        /// <returns><see cref="SetSuccessTaskInstancesAsyncResponse"/></returns>
        public SetSuccessTaskInstancesAsyncResponse SetSuccessTaskInstancesAsyncSync(SetSuccessTaskInstancesAsyncRequest req)
        {
            return InternalRequestAsync<SetSuccessTaskInstancesAsyncResponse>(req, "SetSuccessTaskInstancesAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 异步批量启动任务
        /// </summary>
        /// <param name="req"><see cref="StartOpsTasksRequest"/></param>
        /// <returns><see cref="StartOpsTasksResponse"/></returns>
        public Task<StartOpsTasksResponse> StartOpsTasks(StartOpsTasksRequest req)
        {
            return InternalRequestAsync<StartOpsTasksResponse>(req, "StartOpsTasks");
        }

        /// <summary>
        /// 异步批量启动任务
        /// </summary>
        /// <param name="req"><see cref="StartOpsTasksRequest"/></param>
        /// <returns><see cref="StartOpsTasksResponse"/></returns>
        public StartOpsTasksResponse StartOpsTasksSync(StartOpsTasksRequest req)
        {
            return InternalRequestAsync<StartOpsTasksResponse>(req, "StartOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 异步批量下线任务
        /// </summary>
        /// <param name="req"><see cref="StopOpsTasksAsyncRequest"/></param>
        /// <returns><see cref="StopOpsTasksAsyncResponse"/></returns>
        public Task<StopOpsTasksAsyncResponse> StopOpsTasksAsync(StopOpsTasksAsyncRequest req)
        {
            return InternalRequestAsync<StopOpsTasksAsyncResponse>(req, "StopOpsTasksAsync");
        }

        /// <summary>
        /// 异步批量下线任务
        /// </summary>
        /// <param name="req"><see cref="StopOpsTasksAsyncRequest"/></param>
        /// <returns><see cref="StopOpsTasksAsyncResponse"/></returns>
        public StopOpsTasksAsyncResponse StopOpsTasksAsyncSync(StopOpsTasksAsyncRequest req)
        {
            return InternalRequestAsync<StopOpsTasksAsyncResponse>(req, "StopOpsTasksAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止运行SQL脚本
        /// </summary>
        /// <param name="req"><see cref="StopSQLScriptRunRequest"/></param>
        /// <returns><see cref="StopSQLScriptRunResponse"/></returns>
        public Task<StopSQLScriptRunResponse> StopSQLScriptRun(StopSQLScriptRunRequest req)
        {
            return InternalRequestAsync<StopSQLScriptRunResponse>(req, "StopSQLScriptRun");
        }

        /// <summary>
        /// 停止运行SQL脚本
        /// </summary>
        /// <param name="req"><see cref="StopSQLScriptRunRequest"/></param>
        /// <returns><see cref="StopSQLScriptRunResponse"/></returns>
        public StopSQLScriptRunResponse StopSQLScriptRunSync(StopSQLScriptRunRequest req)
        {
            return InternalRequestAsync<StopSQLScriptRunResponse>(req, "StopSQLScriptRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public Task<SubmitTaskResponse> SubmitTask(SubmitTaskRequest req)
        {
            return InternalRequestAsync<SubmitTaskResponse>(req, "SubmitTask");
        }

        /// <summary>
        /// 提交任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public SubmitTaskResponse SubmitTaskSync(SubmitTaskRequest req)
        {
            return InternalRequestAsync<SubmitTaskResponse>(req, "SubmitTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新代码文件
        /// </summary>
        /// <param name="req"><see cref="UpdateCodeFileRequest"/></param>
        /// <returns><see cref="UpdateCodeFileResponse"/></returns>
        public Task<UpdateCodeFileResponse> UpdateCodeFile(UpdateCodeFileRequest req)
        {
            return InternalRequestAsync<UpdateCodeFileResponse>(req, "UpdateCodeFile");
        }

        /// <summary>
        /// 更新代码文件
        /// </summary>
        /// <param name="req"><see cref="UpdateCodeFileRequest"/></param>
        /// <returns><see cref="UpdateCodeFileResponse"/></returns>
        public UpdateCodeFileResponse UpdateCodeFileSync(UpdateCodeFileRequest req)
        {
            return InternalRequestAsync<UpdateCodeFileResponse>(req, "UpdateCodeFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重命名代码文件夹
        /// </summary>
        /// <param name="req"><see cref="UpdateCodeFolderRequest"/></param>
        /// <returns><see cref="UpdateCodeFolderResponse"/></returns>
        public Task<UpdateCodeFolderResponse> UpdateCodeFolder(UpdateCodeFolderRequest req)
        {
            return InternalRequestAsync<UpdateCodeFolderResponse>(req, "UpdateCodeFolder");
        }

        /// <summary>
        /// 重命名代码文件夹
        /// </summary>
        /// <param name="req"><see cref="UpdateCodeFolderRequest"/></param>
        /// <returns><see cref="UpdateCodeFolderResponse"/></returns>
        public UpdateCodeFolderResponse UpdateCodeFolderSync(UpdateCodeFolderRequest req)
        {
            return InternalRequestAsync<UpdateCodeFolderResponse>(req, "UpdateCodeFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于更新数据源
        /// </summary>
        /// <param name="req"><see cref="UpdateDataSourceRequest"/></param>
        /// <returns><see cref="UpdateDataSourceResponse"/></returns>
        public Task<UpdateDataSourceResponse> UpdateDataSource(UpdateDataSourceRequest req)
        {
            return InternalRequestAsync<UpdateDataSourceResponse>(req, "UpdateDataSource");
        }

        /// <summary>
        /// 该接口用于更新数据源
        /// </summary>
        /// <param name="req"><see cref="UpdateDataSourceRequest"/></param>
        /// <returns><see cref="UpdateDataSourceResponse"/></returns>
        public UpdateDataSourceResponse UpdateDataSourceSync(UpdateDataSourceRequest req)
        {
            return InternalRequestAsync<UpdateDataSourceResponse>(req, "UpdateDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改告警规则
        /// </summary>
        /// <param name="req"><see cref="UpdateOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="UpdateOpsAlarmRuleResponse"/></returns>
        public Task<UpdateOpsAlarmRuleResponse> UpdateOpsAlarmRule(UpdateOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<UpdateOpsAlarmRuleResponse>(req, "UpdateOpsAlarmRule");
        }

        /// <summary>
        /// 修改告警规则
        /// </summary>
        /// <param name="req"><see cref="UpdateOpsAlarmRuleRequest"/></param>
        /// <returns><see cref="UpdateOpsAlarmRuleResponse"/></returns>
        public UpdateOpsAlarmRuleResponse UpdateOpsAlarmRuleSync(UpdateOpsAlarmRuleRequest req)
        {
            return InternalRequestAsync<UpdateOpsAlarmRuleResponse>(req, "UpdateOpsAlarmRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改任务负责人
        /// </summary>
        /// <param name="req"><see cref="UpdateOpsTasksOwnerRequest"/></param>
        /// <returns><see cref="UpdateOpsTasksOwnerResponse"/></returns>
        public Task<UpdateOpsTasksOwnerResponse> UpdateOpsTasksOwner(UpdateOpsTasksOwnerRequest req)
        {
            return InternalRequestAsync<UpdateOpsTasksOwnerResponse>(req, "UpdateOpsTasksOwner");
        }

        /// <summary>
        /// 修改任务负责人
        /// </summary>
        /// <param name="req"><see cref="UpdateOpsTasksOwnerRequest"/></param>
        /// <returns><see cref="UpdateOpsTasksOwnerResponse"/></returns>
        public UpdateOpsTasksOwnerResponse UpdateOpsTasksOwnerSync(UpdateOpsTasksOwnerRequest req)
        {
            return InternalRequestAsync<UpdateOpsTasksOwnerResponse>(req, "UpdateOpsTasksOwner")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改项目基础信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateProjectRequest"/></param>
        /// <returns><see cref="UpdateProjectResponse"/></returns>
        public Task<UpdateProjectResponse> UpdateProject(UpdateProjectRequest req)
        {
            return InternalRequestAsync<UpdateProjectResponse>(req, "UpdateProject");
        }

        /// <summary>
        /// 修改项目基础信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateProjectRequest"/></param>
        /// <returns><see cref="UpdateProjectResponse"/></returns>
        public UpdateProjectResponse UpdateProjectSync(UpdateProjectRequest req)
        {
            return InternalRequestAsync<UpdateProjectResponse>(req, "UpdateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新资源文件
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceFileRequest"/></param>
        /// <returns><see cref="UpdateResourceFileResponse"/></returns>
        public Task<UpdateResourceFileResponse> UpdateResourceFile(UpdateResourceFileRequest req)
        {
            return InternalRequestAsync<UpdateResourceFileResponse>(req, "UpdateResourceFile");
        }

        /// <summary>
        /// 更新资源文件
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceFileRequest"/></param>
        /// <returns><see cref="UpdateResourceFileResponse"/></returns>
        public UpdateResourceFileResponse UpdateResourceFileSync(UpdateResourceFileRequest req)
        {
            return InternalRequestAsync<UpdateResourceFileResponse>(req, "UpdateResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新资源文件夹
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceFolderRequest"/></param>
        /// <returns><see cref="UpdateResourceFolderResponse"/></returns>
        public Task<UpdateResourceFolderResponse> UpdateResourceFolder(UpdateResourceFolderRequest req)
        {
            return InternalRequestAsync<UpdateResourceFolderResponse>(req, "UpdateResourceFolder");
        }

        /// <summary>
        /// 更新资源文件夹
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceFolderRequest"/></param>
        /// <returns><see cref="UpdateResourceFolderResponse"/></returns>
        public UpdateResourceFolderResponse UpdateResourceFolderSync(UpdateResourceFolderRequest req)
        {
            return InternalRequestAsync<UpdateResourceFolderResponse>(req, "UpdateResourceFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于变配/续费资源
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceGroupRequest"/></param>
        /// <returns><see cref="UpdateResourceGroupResponse"/></returns>
        public Task<UpdateResourceGroupResponse> UpdateResourceGroup(UpdateResourceGroupRequest req)
        {
            return InternalRequestAsync<UpdateResourceGroupResponse>(req, "UpdateResourceGroup");
        }

        /// <summary>
        /// 该接口用于变配/续费资源
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceGroupRequest"/></param>
        /// <returns><see cref="UpdateResourceGroupResponse"/></returns>
        public UpdateResourceGroupResponse UpdateResourceGroupSync(UpdateResourceGroupRequest req)
        {
            return InternalRequestAsync<UpdateResourceGroupResponse>(req, "UpdateResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重命名SQL文件夹
        /// </summary>
        /// <param name="req"><see cref="UpdateSQLFolderRequest"/></param>
        /// <returns><see cref="UpdateSQLFolderResponse"/></returns>
        public Task<UpdateSQLFolderResponse> UpdateSQLFolder(UpdateSQLFolderRequest req)
        {
            return InternalRequestAsync<UpdateSQLFolderResponse>(req, "UpdateSQLFolder");
        }

        /// <summary>
        /// 重命名SQL文件夹
        /// </summary>
        /// <param name="req"><see cref="UpdateSQLFolderRequest"/></param>
        /// <returns><see cref="UpdateSQLFolderResponse"/></returns>
        public UpdateSQLFolderResponse UpdateSQLFolderSync(UpdateSQLFolderRequest req)
        {
            return InternalRequestAsync<UpdateSQLFolderResponse>(req, "UpdateSQLFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 保存探索脚本内容
        /// </summary>
        /// <param name="req"><see cref="UpdateSQLScriptRequest"/></param>
        /// <returns><see cref="UpdateSQLScriptResponse"/></returns>
        public Task<UpdateSQLScriptResponse> UpdateSQLScript(UpdateSQLScriptRequest req)
        {
            return InternalRequestAsync<UpdateSQLScriptResponse>(req, "UpdateSQLScript");
        }

        /// <summary>
        /// 保存探索脚本内容
        /// </summary>
        /// <param name="req"><see cref="UpdateSQLScriptRequest"/></param>
        /// <returns><see cref="UpdateSQLScriptResponse"/></returns>
        public UpdateSQLScriptResponse UpdateSQLScriptSync(UpdateSQLScriptRequest req)
        {
            return InternalRequestAsync<UpdateSQLScriptResponse>(req, "UpdateSQLScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建任务接口
        /// </summary>
        /// <param name="req"><see cref="UpdateTaskRequest"/></param>
        /// <returns><see cref="UpdateTaskResponse"/></returns>
        public Task<UpdateTaskResponse> UpdateTask(UpdateTaskRequest req)
        {
            return InternalRequestAsync<UpdateTaskResponse>(req, "UpdateTask");
        }

        /// <summary>
        /// 创建任务接口
        /// </summary>
        /// <param name="req"><see cref="UpdateTaskRequest"/></param>
        /// <returns><see cref="UpdateTaskResponse"/></returns>
        public UpdateTaskResponse UpdateTaskSync(UpdateTaskRequest req)
        {
            return InternalRequestAsync<UpdateTaskResponse>(req, "UpdateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新工作流（包括工作流基本信息与工作流参数）
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowRequest"/></param>
        /// <returns><see cref="UpdateWorkflowResponse"/></returns>
        public Task<UpdateWorkflowResponse> UpdateWorkflow(UpdateWorkflowRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowResponse>(req, "UpdateWorkflow");
        }

        /// <summary>
        /// 更新工作流（包括工作流基本信息与工作流参数）
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowRequest"/></param>
        /// <returns><see cref="UpdateWorkflowResponse"/></returns>
        public UpdateWorkflowResponse UpdateWorkflowSync(UpdateWorkflowRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowResponse>(req, "UpdateWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowFolderRequest"/></param>
        /// <returns><see cref="UpdateWorkflowFolderResponse"/></returns>
        public Task<UpdateWorkflowFolderResponse> UpdateWorkflowFolder(UpdateWorkflowFolderRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowFolderResponse>(req, "UpdateWorkflowFolder");
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowFolderRequest"/></param>
        /// <returns><see cref="UpdateWorkflowFolderResponse"/></returns>
        public UpdateWorkflowFolderResponse UpdateWorkflowFolderSync(UpdateWorkflowFolderRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowFolderResponse>(req, "UpdateWorkflowFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
