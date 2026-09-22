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

namespace TencentCloud.Databuddy.V20260715
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Databuddy.V20260715.Models;

   public class DatabuddyClient : AbstractClient{

       private const string endpoint = "databuddy.tencentcloudapi.com";
       private const string version = "2026-07-15";
       private const string sdkVersion = "SDK_NET_3.0.1511";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DatabuddyClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DatabuddyClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加控制台用户
        /// </summary>
        /// <param name="req"><see cref="AddConsoleUsersRequest"/></param>
        /// <returns><see cref="AddConsoleUsersResponse"/></returns>
        public Task<AddConsoleUsersResponse> AddConsoleUsers(AddConsoleUsersRequest req)
        {
            return InternalRequestAsync<AddConsoleUsersResponse>(req, "AddConsoleUsers");
        }

        /// <summary>
        /// 添加控制台用户
        /// </summary>
        /// <param name="req"><see cref="AddConsoleUsersRequest"/></param>
        /// <returns><see cref="AddConsoleUsersResponse"/></returns>
        public AddConsoleUsersResponse AddConsoleUsersSync(AddConsoleUsersRequest req)
        {
            return InternalRequestAsync<AddConsoleUsersResponse>(req, "AddConsoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建控制台用户组
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleGroupRequest"/></param>
        /// <returns><see cref="CreateConsoleGroupResponse"/></returns>
        public Task<CreateConsoleGroupResponse> CreateConsoleGroup(CreateConsoleGroupRequest req)
        {
            return InternalRequestAsync<CreateConsoleGroupResponse>(req, "CreateConsoleGroup");
        }

        /// <summary>
        /// 创建控制台用户组
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleGroupRequest"/></param>
        /// <returns><see cref="CreateConsoleGroupResponse"/></returns>
        public CreateConsoleGroupResponse CreateConsoleGroupSync(CreateConsoleGroupRequest req)
        {
            return InternalRequestAsync<CreateConsoleGroupResponse>(req, "CreateConsoleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在Studio（统一开发 IDE）的工作空间文件树中新建一个文件（Notebook/SQL/Python等），创建成功后返回文件的完整元信息。
        /// 
        /// **前置条件**
        /// 1. WorkspaceId 对应工作空间存在，且调用方为该工作空间成员；
        /// 2. ParentFolderPath 对应的父文件夹必须存在，且调用方对其有写权限（根目录传 `/`）；
        /// 3. FileName 在同一父文件夹下不能重名（含后缀比较）；
        /// 4. FileName 后缀必须与 FileType 匹配（`.ipynb`↔`NOTEBOOK_FILE`、`.sql`↔`SQL_FILE`）；
        /// 5. 需带文件内容创建时通过 Storage 传入（大文件走 COS 中转，小文件放 Storage.Content）。
        /// </summary>
        /// <param name="req"><see cref="CreateFileRequest"/></param>
        /// <returns><see cref="CreateFileResponse"/></returns>
        public Task<CreateFileResponse> CreateFile(CreateFileRequest req)
        {
            return InternalRequestAsync<CreateFileResponse>(req, "CreateFile");
        }

        /// <summary>
        /// 在Studio（统一开发 IDE）的工作空间文件树中新建一个文件（Notebook/SQL/Python等），创建成功后返回文件的完整元信息。
        /// 
        /// **前置条件**
        /// 1. WorkspaceId 对应工作空间存在，且调用方为该工作空间成员；
        /// 2. ParentFolderPath 对应的父文件夹必须存在，且调用方对其有写权限（根目录传 `/`）；
        /// 3. FileName 在同一父文件夹下不能重名（含后缀比较）；
        /// 4. FileName 后缀必须与 FileType 匹配（`.ipynb`↔`NOTEBOOK_FILE`、`.sql`↔`SQL_FILE`）；
        /// 5. 需带文件内容创建时通过 Storage 传入（大文件走 COS 中转，小文件放 Storage.Content）。
        /// </summary>
        /// <param name="req"><see cref="CreateFileRequest"/></param>
        /// <returns><see cref="CreateFileResponse"/></returns>
        public CreateFileResponse CreateFileSync(CreateFileRequest req)
        {
            return InternalRequestAsync<CreateFileResponse>(req, "CreateFile")
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
        /// 删除控制台用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteConsoleGroupsRequest"/></param>
        /// <returns><see cref="DeleteConsoleGroupsResponse"/></returns>
        public Task<DeleteConsoleGroupsResponse> DeleteConsoleGroups(DeleteConsoleGroupsRequest req)
        {
            return InternalRequestAsync<DeleteConsoleGroupsResponse>(req, "DeleteConsoleGroups");
        }

        /// <summary>
        /// 删除控制台用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteConsoleGroupsRequest"/></param>
        /// <returns><see cref="DeleteConsoleGroupsResponse"/></returns>
        public DeleteConsoleGroupsResponse DeleteConsoleGroupsSync(DeleteConsoleGroupsRequest req)
        {
            return InternalRequestAsync<DeleteConsoleGroupsResponse>(req, "DeleteConsoleGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将文件移入回收站（软删除），同时清理该文件的版本记录与执行结果快照。
        /// 
        /// **前置条件**
        /// 1. FileId 对应文件必须存在且为活跃状态；
        /// 2. 调用方对该文件有删除权限；
        /// 3. 文件未被工作流任务引用。
        /// 
        /// **错误码（Module 均为 `Studio`）**
        /// 
        /// | 错误码（Code） | InnerCode | 描述 | 处理建议 |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | 缺少 WorkspaceId | 请传入 WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | 缺少 FileId | 请传入 FileId  |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType 取值不支持 | FileType 取 FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | 文件不存在或已删除 | 请确认 FileId |
        /// | `ResourceInUse.FileReferencedByTask` | 1030204 | 文件被工作流任务引用，不允许删除 | 请先解除任务引用后再删除 |
        /// | `UnauthorizedOperation.FileDeleteDenied` | 1030303 | 对该文件无删除权限 | 请联系文件负责人或空间管理员授权 |
        /// | `InternalError` | 1030900 | 服务内部异常 | 请携带 RequestId 联系支持 |
        /// </summary>
        /// <param name="req"><see cref="DeleteFileRequest"/></param>
        /// <returns><see cref="DeleteFileResponse"/></returns>
        public Task<DeleteFileResponse> DeleteFile(DeleteFileRequest req)
        {
            return InternalRequestAsync<DeleteFileResponse>(req, "DeleteFile");
        }

        /// <summary>
        /// 将文件移入回收站（软删除），同时清理该文件的版本记录与执行结果快照。
        /// 
        /// **前置条件**
        /// 1. FileId 对应文件必须存在且为活跃状态；
        /// 2. 调用方对该文件有删除权限；
        /// 3. 文件未被工作流任务引用。
        /// 
        /// **错误码（Module 均为 `Studio`）**
        /// 
        /// | 错误码（Code） | InnerCode | 描述 | 处理建议 |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | 缺少 WorkspaceId | 请传入 WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | 缺少 FileId | 请传入 FileId  |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType 取值不支持 | FileType 取 FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | 文件不存在或已删除 | 请确认 FileId |
        /// | `ResourceInUse.FileReferencedByTask` | 1030204 | 文件被工作流任务引用，不允许删除 | 请先解除任务引用后再删除 |
        /// | `UnauthorizedOperation.FileDeleteDenied` | 1030303 | 对该文件无删除权限 | 请联系文件负责人或空间管理员授权 |
        /// | `InternalError` | 1030900 | 服务内部异常 | 请携带 RequestId 联系支持 |
        /// </summary>
        /// <param name="req"><see cref="DeleteFileRequest"/></param>
        /// <returns><see cref="DeleteFileResponse"/></returns>
        public DeleteFileResponse DeleteFileSync(DeleteFileRequest req)
        {
            return InternalRequestAsync<DeleteFileResponse>(req, "DeleteFile")
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
        /// 获取文件的元信息，可选包含文件内容，支持按版本读取历史快照。
        /// 
        /// **前置条件**
        /// 1. FileId 与 FilePath 二选一，至少传一个；同时传时以 FileId 为准；
        /// 2. 对应文件必须存在，且调用方对该文件有读权限；
        /// 3. 传 VersionId 时该版本必须存在。
        /// 
        /// **错误码（Module 均为 `Studio`）**
        /// 
        /// | 错误码（Code） | InnerCode | 描述 | 处理建议 |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | 缺少 WorkspaceId | 请传入 WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | FileId 与 FilePath 同时为空 | FileId 与 FilePath 二选一，至少传一个 |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType 取值不支持 | FileType 取 FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | 文件不存在或已删除 | 请确认 FileId 或 FilePath |
        /// | `ResourceNotFound.FileVersionNotFound` | 1030205 | 指定的文件版本不存在 | 请确认 VersionId，或调用 ListFileVersions 获取 |
        /// | `UnauthorizedOperation.FileReadDenied` | 1030304 | 对该文件无读权限 | 请联系文件负责人或空间管理员授权 |
        /// | `InternalError` | 1030900 | 服务内部异常 | 请携带 RequestId 联系支持 |
        /// </summary>
        /// <param name="req"><see cref="GetFileRequest"/></param>
        /// <returns><see cref="GetFileResponse"/></returns>
        public Task<GetFileResponse> GetFile(GetFileRequest req)
        {
            return InternalRequestAsync<GetFileResponse>(req, "GetFile");
        }

        /// <summary>
        /// 获取文件的元信息，可选包含文件内容，支持按版本读取历史快照。
        /// 
        /// **前置条件**
        /// 1. FileId 与 FilePath 二选一，至少传一个；同时传时以 FileId 为准；
        /// 2. 对应文件必须存在，且调用方对该文件有读权限；
        /// 3. 传 VersionId 时该版本必须存在。
        /// 
        /// **错误码（Module 均为 `Studio`）**
        /// 
        /// | 错误码（Code） | InnerCode | 描述 | 处理建议 |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | 缺少 WorkspaceId | 请传入 WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | FileId 与 FilePath 同时为空 | FileId 与 FilePath 二选一，至少传一个 |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType 取值不支持 | FileType 取 FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | 文件不存在或已删除 | 请确认 FileId 或 FilePath |
        /// | `ResourceNotFound.FileVersionNotFound` | 1030205 | 指定的文件版本不存在 | 请确认 VersionId，或调用 ListFileVersions 获取 |
        /// | `UnauthorizedOperation.FileReadDenied` | 1030304 | 对该文件无读权限 | 请联系文件负责人或空间管理员授权 |
        /// | `InternalError` | 1030900 | 服务内部异常 | 请携带 RequestId 联系支持 |
        /// </summary>
        /// <param name="req"><see cref="GetFileRequest"/></param>
        /// <returns><see cref="GetFileResponse"/></returns>
        public GetFileResponse GetFileSync(GetFileRequest req)
        {
            return InternalRequestAsync<GetFileResponse>(req, "GetFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取工作流详细信息
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRequest"/></param>
        /// <returns><see cref="GetWorkflowResponse"/></returns>
        public Task<GetWorkflowResponse> GetWorkflow(GetWorkflowRequest req)
        {
            return InternalRequestAsync<GetWorkflowResponse>(req, "GetWorkflow");
        }

        /// <summary>
        /// 获取工作流详细信息
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRequest"/></param>
        /// <returns><see cref="GetWorkflowResponse"/></returns>
        public GetWorkflowResponse GetWorkflowSync(GetWorkflowRequest req)
        {
            return InternalRequestAsync<GetWorkflowResponse>(req, "GetWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作流运行详情
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRunRequest"/></param>
        /// <returns><see cref="GetWorkflowRunResponse"/></returns>
        public Task<GetWorkflowRunResponse> GetWorkflowRun(GetWorkflowRunRequest req)
        {
            return InternalRequestAsync<GetWorkflowRunResponse>(req, "GetWorkflowRun");
        }

        /// <summary>
        /// 查询工作流运行详情
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRunRequest"/></param>
        /// <returns><see cref="GetWorkflowRunResponse"/></returns>
        public GetWorkflowRunResponse GetWorkflowRunSync(GetWorkflowRunRequest req)
        {
            return InternalRequestAsync<GetWorkflowRunResponse>(req, "GetWorkflowRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务运行详情
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowTaskRunRequest"/></param>
        /// <returns><see cref="GetWorkflowTaskRunResponse"/></returns>
        public Task<GetWorkflowTaskRunResponse> GetWorkflowTaskRun(GetWorkflowTaskRunRequest req)
        {
            return InternalRequestAsync<GetWorkflowTaskRunResponse>(req, "GetWorkflowTaskRun");
        }

        /// <summary>
        /// 查询任务运行详情
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowTaskRunRequest"/></param>
        /// <returns><see cref="GetWorkflowTaskRunResponse"/></returns>
        public GetWorkflowTaskRunResponse GetWorkflowTaskRunSync(GetWorkflowTaskRunRequest req)
        {
            return InternalRequestAsync<GetWorkflowTaskRunResponse>(req, "GetWorkflowTaskRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 终止工作流的运行
        /// </summary>
        /// <param name="req"><see cref="KillWorkflowRunRequest"/></param>
        /// <returns><see cref="KillWorkflowRunResponse"/></returns>
        public Task<KillWorkflowRunResponse> KillWorkflowRun(KillWorkflowRunRequest req)
        {
            return InternalRequestAsync<KillWorkflowRunResponse>(req, "KillWorkflowRun");
        }

        /// <summary>
        /// 终止工作流的运行
        /// </summary>
        /// <param name="req"><see cref="KillWorkflowRunRequest"/></param>
        /// <returns><see cref="KillWorkflowRunResponse"/></returns>
        public KillWorkflowRunResponse KillWorkflowRunSync(KillWorkflowRunRequest req)
        {
            return InternalRequestAsync<KillWorkflowRunResponse>(req, "KillWorkflowRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询控制台用户组成员列表
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupUsersRequest"/></param>
        /// <returns><see cref="ListConsoleGroupUsersResponse"/></returns>
        public Task<ListConsoleGroupUsersResponse> ListConsoleGroupUsers(ListConsoleGroupUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupUsersResponse>(req, "ListConsoleGroupUsers");
        }

        /// <summary>
        /// 查询控制台用户组成员列表
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupUsersRequest"/></param>
        /// <returns><see cref="ListConsoleGroupUsersResponse"/></returns>
        public ListConsoleGroupUsersResponse ListConsoleGroupUsersSync(ListConsoleGroupUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupUsersResponse>(req, "ListConsoleGroupUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询控制台用户组列表
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupsRequest"/></param>
        /// <returns><see cref="ListConsoleGroupsResponse"/></returns>
        public Task<ListConsoleGroupsResponse> ListConsoleGroups(ListConsoleGroupsRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupsResponse>(req, "ListConsoleGroups");
        }

        /// <summary>
        /// 查询控制台用户组列表
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupsRequest"/></param>
        /// <returns><see cref="ListConsoleGroupsResponse"/></returns>
        public ListConsoleGroupsResponse ListConsoleGroupsSync(ListConsoleGroupsRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupsResponse>(req, "ListConsoleGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询控制台角色列表
        /// </summary>
        /// <param name="req"><see cref="ListConsoleRolesRequest"/></param>
        /// <returns><see cref="ListConsoleRolesResponse"/></returns>
        public Task<ListConsoleRolesResponse> ListConsoleRoles(ListConsoleRolesRequest req)
        {
            return InternalRequestAsync<ListConsoleRolesResponse>(req, "ListConsoleRoles");
        }

        /// <summary>
        /// 查询控制台角色列表
        /// </summary>
        /// <param name="req"><see cref="ListConsoleRolesRequest"/></param>
        /// <returns><see cref="ListConsoleRolesResponse"/></returns>
        public ListConsoleRolesResponse ListConsoleRolesSync(ListConsoleRolesRequest req)
        {
            return InternalRequestAsync<ListConsoleRolesResponse>(req, "ListConsoleRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询控制台用户列表
        /// </summary>
        /// <param name="req"><see cref="ListConsoleUsersRequest"/></param>
        /// <returns><see cref="ListConsoleUsersResponse"/></returns>
        public Task<ListConsoleUsersResponse> ListConsoleUsers(ListConsoleUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleUsersResponse>(req, "ListConsoleUsers");
        }

        /// <summary>
        /// 查询控制台用户列表
        /// </summary>
        /// <param name="req"><see cref="ListConsoleUsersRequest"/></param>
        /// <returns><see cref="ListConsoleUsersResponse"/></returns>
        public ListConsoleUsersResponse ListConsoleUsersSync(ListConsoleUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleUsersResponse>(req, "ListConsoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 工作流运行列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowRunsRequest"/></param>
        /// <returns><see cref="ListWorkflowRunsResponse"/></returns>
        public Task<ListWorkflowRunsResponse> ListWorkflowRuns(ListWorkflowRunsRequest req)
        {
            return InternalRequestAsync<ListWorkflowRunsResponse>(req, "ListWorkflowRuns");
        }

        /// <summary>
        /// 工作流运行列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowRunsRequest"/></param>
        /// <returns><see cref="ListWorkflowRunsResponse"/></returns>
        public ListWorkflowRunsResponse ListWorkflowRunsSync(ListWorkflowRunsRequest req)
        {
            return InternalRequestAsync<ListWorkflowRunsResponse>(req, "ListWorkflowRuns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作流任务历史运行列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowTaskRunsRequest"/></param>
        /// <returns><see cref="ListWorkflowTaskRunsResponse"/></returns>
        public Task<ListWorkflowTaskRunsResponse> ListWorkflowTaskRuns(ListWorkflowTaskRunsRequest req)
        {
            return InternalRequestAsync<ListWorkflowTaskRunsResponse>(req, "ListWorkflowTaskRuns");
        }

        /// <summary>
        /// 查询工作流任务历史运行列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowTaskRunsRequest"/></param>
        /// <returns><see cref="ListWorkflowTaskRunsResponse"/></returns>
        public ListWorkflowTaskRunsResponse ListWorkflowTaskRunsSync(ListWorkflowTaskRunsRequest req)
        {
            return InternalRequestAsync<ListWorkflowTaskRunsResponse>(req, "ListWorkflowTaskRuns")
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
        /// <p>批量移除控制台用户（单次最多10个；前置校验任一不满足整体拒绝；执行阶段单个失败不中断后续删除，成败以 SuccessUins/FailItems 为准）</p>
        /// </summary>
        /// <param name="req"><see cref="RemoveConsoleUsersRequest"/></param>
        /// <returns><see cref="RemoveConsoleUsersResponse"/></returns>
        public Task<RemoveConsoleUsersResponse> RemoveConsoleUsers(RemoveConsoleUsersRequest req)
        {
            return InternalRequestAsync<RemoveConsoleUsersResponse>(req, "RemoveConsoleUsers");
        }

        /// <summary>
        /// <p>批量移除控制台用户（单次最多10个；前置校验任一不满足整体拒绝；执行阶段单个失败不中断后续删除，成败以 SuccessUins/FailItems 为准）</p>
        /// </summary>
        /// <param name="req"><see cref="RemoveConsoleUsersRequest"/></param>
        /// <returns><see cref="RemoveConsoleUsersResponse"/></returns>
        public RemoveConsoleUsersResponse RemoveConsoleUsersSync(RemoveConsoleUsersRequest req)
        {
            return InternalRequestAsync<RemoveConsoleUsersResponse>(req, "RemoveConsoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重跑工作流
        /// </summary>
        /// <param name="req"><see cref="RerunWorkflowRunRequest"/></param>
        /// <returns><see cref="RerunWorkflowRunResponse"/></returns>
        public Task<RerunWorkflowRunResponse> RerunWorkflowRun(RerunWorkflowRunRequest req)
        {
            return InternalRequestAsync<RerunWorkflowRunResponse>(req, "RerunWorkflowRun");
        }

        /// <summary>
        /// 重跑工作流
        /// </summary>
        /// <param name="req"><see cref="RerunWorkflowRunRequest"/></param>
        /// <returns><see cref="RerunWorkflowRunResponse"/></returns>
        public RerunWorkflowRunResponse RerunWorkflowRunSync(RerunWorkflowRunRequest req)
        {
            return InternalRequestAsync<RerunWorkflowRunResponse>(req, "RerunWorkflowRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运行工作流
        /// </summary>
        /// <param name="req"><see cref="RunWorkflowRequest"/></param>
        /// <returns><see cref="RunWorkflowResponse"/></returns>
        public Task<RunWorkflowResponse> RunWorkflow(RunWorkflowRequest req)
        {
            return InternalRequestAsync<RunWorkflowResponse>(req, "RunWorkflow");
        }

        /// <summary>
        /// 运行工作流
        /// </summary>
        /// <param name="req"><see cref="RunWorkflowRequest"/></param>
        /// <returns><see cref="RunWorkflowResponse"/></returns>
        public RunWorkflowResponse RunWorkflowSync(RunWorkflowRequest req)
        {
            return InternalRequestAsync<RunWorkflowResponse>(req, "RunWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑工作流Bundle信息
        /// 说明：本接口语义等同于规范动词清单中的 Detach，因兼容既有产品形态保留 Unbind 命名
        /// </summary>
        /// <param name="req"><see cref="UnbindWorkflowBundleRequest"/></param>
        /// <returns><see cref="UnbindWorkflowBundleResponse"/></returns>
        public Task<UnbindWorkflowBundleResponse> UnbindWorkflowBundle(UnbindWorkflowBundleRequest req)
        {
            return InternalRequestAsync<UnbindWorkflowBundleResponse>(req, "UnbindWorkflowBundle");
        }

        /// <summary>
        /// 解绑工作流Bundle信息
        /// 说明：本接口语义等同于规范动词清单中的 Detach，因兼容既有产品形态保留 Unbind 命名
        /// </summary>
        /// <param name="req"><see cref="UnbindWorkflowBundleRequest"/></param>
        /// <returns><see cref="UnbindWorkflowBundleResponse"/></returns>
        public UnbindWorkflowBundleResponse UnbindWorkflowBundleSync(UnbindWorkflowBundleRequest req)
        {
            return InternalRequestAsync<UnbindWorkflowBundleResponse>(req, "UnbindWorkflowBundle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改控制台用户组
        /// </summary>
        /// <param name="req"><see cref="UpdateConsoleGroupRequest"/></param>
        /// <returns><see cref="UpdateConsoleGroupResponse"/></returns>
        public Task<UpdateConsoleGroupResponse> UpdateConsoleGroup(UpdateConsoleGroupRequest req)
        {
            return InternalRequestAsync<UpdateConsoleGroupResponse>(req, "UpdateConsoleGroup");
        }

        /// <summary>
        /// 修改控制台用户组
        /// </summary>
        /// <param name="req"><see cref="UpdateConsoleGroupRequest"/></param>
        /// <returns><see cref="UpdateConsoleGroupResponse"/></returns>
        public UpdateConsoleGroupResponse UpdateConsoleGroupSync(UpdateConsoleGroupRequest req)
        {
            return InternalRequestAsync<UpdateConsoleGroupResponse>(req, "UpdateConsoleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改控制台用户角色
        /// </summary>
        /// <param name="req"><see cref="UpdateConsoleUsersRequest"/></param>
        /// <returns><see cref="UpdateConsoleUsersResponse"/></returns>
        public Task<UpdateConsoleUsersResponse> UpdateConsoleUsers(UpdateConsoleUsersRequest req)
        {
            return InternalRequestAsync<UpdateConsoleUsersResponse>(req, "UpdateConsoleUsers");
        }

        /// <summary>
        /// 修改控制台用户角色
        /// </summary>
        /// <param name="req"><see cref="UpdateConsoleUsersRequest"/></param>
        /// <returns><see cref="UpdateConsoleUsersResponse"/></returns>
        public UpdateConsoleUsersResponse UpdateConsoleUsersSync(UpdateConsoleUsersRequest req)
        {
            return InternalRequestAsync<UpdateConsoleUsersResponse>(req, "UpdateConsoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新文件内容与运行配置（计算资源、默认 catalog/schema、参数等），返回更新后的文件元信息。
        /// 
        /// **前置条件**
        /// 1. FileId 对应文件必须存在且为活跃状态；
        /// 2. 调用方对该文件有写权限；
        /// 3. 仅更新配置时不传 Storage；仅更新内容时不传 FileConfig；
        /// 4. FileConfig.ResourceId 非空时会校验资源类型与文件类型的匹配性。
        /// 
        /// **错误码（Module 均为 `Studio`）**
        /// 
        /// | 错误码（Code） | InnerCode | 描述 | 处理建议 |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | 缺少 WorkspaceId | 请传入 WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | 缺少 FileId | 请传入 FileId |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType 取值不支持 | FileType 取 FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `InvalidParameterValue.ResourceId` | 1030104 | 计算资源类型与文件类型不匹配 | Python/Notebook 选数据计算资源，SQL 选数据分析资源 |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | 文件不存在或已删除 | 请确认 FileId，或调用 GetFile 校验文件状态 |
        /// | `UnauthorizedOperation.FileWriteDenied` | 1030302 | 对该文件无写权限 | 请联系文件负责人或空间管理员授权 |
        /// | `FailedOperation.FileStorageUpdateFailed` | 1030401 | 文件内容写入存储失败 | 请稍后重试，持续失败请携带 RequestId 联系支持 |
        /// | `InternalError` | 1030900 | 服务内部异常 | 请携带 RequestId 联系支持 |
        /// </summary>
        /// <param name="req"><see cref="UpdateFileRequest"/></param>
        /// <returns><see cref="UpdateFileResponse"/></returns>
        public Task<UpdateFileResponse> UpdateFile(UpdateFileRequest req)
        {
            return InternalRequestAsync<UpdateFileResponse>(req, "UpdateFile");
        }

        /// <summary>
        /// 更新文件内容与运行配置（计算资源、默认 catalog/schema、参数等），返回更新后的文件元信息。
        /// 
        /// **前置条件**
        /// 1. FileId 对应文件必须存在且为活跃状态；
        /// 2. 调用方对该文件有写权限；
        /// 3. 仅更新配置时不传 Storage；仅更新内容时不传 FileConfig；
        /// 4. FileConfig.ResourceId 非空时会校验资源类型与文件类型的匹配性。
        /// 
        /// **错误码（Module 均为 `Studio`）**
        /// 
        /// | 错误码（Code） | InnerCode | 描述 | 处理建议 |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | 缺少 WorkspaceId | 请传入 WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | 缺少 FileId | 请传入 FileId |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType 取值不支持 | FileType 取 FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `InvalidParameterValue.ResourceId` | 1030104 | 计算资源类型与文件类型不匹配 | Python/Notebook 选数据计算资源，SQL 选数据分析资源 |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | 文件不存在或已删除 | 请确认 FileId，或调用 GetFile 校验文件状态 |
        /// | `UnauthorizedOperation.FileWriteDenied` | 1030302 | 对该文件无写权限 | 请联系文件负责人或空间管理员授权 |
        /// | `FailedOperation.FileStorageUpdateFailed` | 1030401 | 文件内容写入存储失败 | 请稍后重试，持续失败请携带 RequestId 联系支持 |
        /// | `InternalError` | 1030900 | 服务内部异常 | 请携带 RequestId 联系支持 |
        /// </summary>
        /// <param name="req"><see cref="UpdateFileRequest"/></param>
        /// <returns><see cref="UpdateFileResponse"/></returns>
        public UpdateFileResponse UpdateFileSync(UpdateFileRequest req)
        {
            return InternalRequestAsync<UpdateFileResponse>(req, "UpdateFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新工作流
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowRequest"/></param>
        /// <returns><see cref="UpdateWorkflowResponse"/></returns>
        public Task<UpdateWorkflowResponse> UpdateWorkflow(UpdateWorkflowRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowResponse>(req, "UpdateWorkflow");
        }

        /// <summary>
        /// 更新工作流
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowRequest"/></param>
        /// <returns><see cref="UpdateWorkflowResponse"/></returns>
        public UpdateWorkflowResponse UpdateWorkflowSync(UpdateWorkflowRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowResponse>(req, "UpdateWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
