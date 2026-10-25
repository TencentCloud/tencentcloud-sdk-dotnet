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
       private const string sdkVersion = "SDK_NET_3.0.1526";

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
        /// 添加控制台用户，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="AddConsoleUsersRequest"/></param>
        /// <returns><see cref="AddConsoleUsersResponse"/></returns>
        public Task<AddConsoleUsersResponse> AddConsoleUsers(AddConsoleUsersRequest req)
        {
            return InternalRequestAsync<AddConsoleUsersResponse>(req, "AddConsoleUsers");
        }

        /// <summary>
        /// 添加控制台用户，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="AddConsoleUsersRequest"/></param>
        /// <returns><see cref="AddConsoleUsersResponse"/></returns>
        public AddConsoleUsersResponse AddConsoleUsersSync(AddConsoleUsersRequest req)
        {
            return InternalRequestAsync<AddConsoleUsersResponse>(req, "AddConsoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加工作空间用户组
        /// </summary>
        /// <param name="req"><see cref="AddWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="AddWorkspaceGroupsResponse"/></returns>
        public Task<AddWorkspaceGroupsResponse> AddWorkspaceGroups(AddWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<AddWorkspaceGroupsResponse>(req, "AddWorkspaceGroups");
        }

        /// <summary>
        /// 添加工作空间用户组
        /// </summary>
        /// <param name="req"><see cref="AddWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="AddWorkspaceGroupsResponse"/></returns>
        public AddWorkspaceGroupsResponse AddWorkspaceGroupsSync(AddWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<AddWorkspaceGroupsResponse>(req, "AddWorkspaceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户组
        /// </summary>
        /// <param name="req"><see cref="AddWorkspaceUsersRequest"/></param>
        /// <returns><see cref="AddWorkspaceUsersResponse"/></returns>
        public Task<AddWorkspaceUsersResponse> AddWorkspaceUsers(AddWorkspaceUsersRequest req)
        {
            return InternalRequestAsync<AddWorkspaceUsersResponse>(req, "AddWorkspaceUsers");
        }

        /// <summary>
        /// 创建用户组
        /// </summary>
        /// <param name="req"><see cref="AddWorkspaceUsersRequest"/></param>
        /// <returns><see cref="AddWorkspaceUsersResponse"/></returns>
        public AddWorkspaceUsersResponse AddWorkspaceUsersSync(AddWorkspaceUsersRequest req)
        {
            return InternalRequestAsync<AddWorkspaceUsersResponse>(req, "AddWorkspaceUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据目录接口
        /// </summary>
        /// <param name="req"><see cref="CreateCatalogRequest"/></param>
        /// <returns><see cref="CreateCatalogResponse"/></returns>
        public Task<CreateCatalogResponse> CreateCatalog(CreateCatalogRequest req)
        {
            return InternalRequestAsync<CreateCatalogResponse>(req, "CreateCatalog");
        }

        /// <summary>
        /// 创建数据目录接口
        /// </summary>
        /// <param name="req"><see cref="CreateCatalogRequest"/></param>
        /// <returns><see cref="CreateCatalogResponse"/></returns>
        public CreateCatalogResponse CreateCatalogSync(CreateCatalogRequest req)
        {
            return InternalRequestAsync<CreateCatalogResponse>(req, "CreateCatalog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建控制台用户组，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleGroupRequest"/></param>
        /// <returns><see cref="CreateConsoleGroupResponse"/></returns>
        public Task<CreateConsoleGroupResponse> CreateConsoleGroup(CreateConsoleGroupRequest req)
        {
            return InternalRequestAsync<CreateConsoleGroupResponse>(req, "CreateConsoleGroup");
        }

        /// <summary>
        /// 创建控制台用户组，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
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
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public Task<CreateFolderResponse> CreateFolder(CreateFolderRequest req)
        {
            return InternalRequestAsync<CreateFolderResponse>(req, "CreateFolder");
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public CreateFolderResponse CreateFolderSync(CreateFolderRequest req)
        {
            return InternalRequestAsync<CreateFolderResponse>(req, "CreateFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建存储位置
        /// 使用场景：在数据湖仓库中创建新的存储位置
        /// </summary>
        /// <param name="req"><see cref="CreateLocationRequest"/></param>
        /// <returns><see cref="CreateLocationResponse"/></returns>
        public Task<CreateLocationResponse> CreateLocation(CreateLocationRequest req)
        {
            return InternalRequestAsync<CreateLocationResponse>(req, "CreateLocation");
        }

        /// <summary>
        /// 创建存储位置
        /// 使用场景：在数据湖仓库中创建新的存储位置
        /// </summary>
        /// <param name="req"><see cref="CreateLocationRequest"/></param>
        /// <returns><see cref="CreateLocationResponse"/></returns>
        public CreateLocationResponse CreateLocationSync(CreateLocationRequest req)
        {
            return InternalRequestAsync<CreateLocationResponse>(req, "CreateLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建模型接口
        /// </summary>
        /// <param name="req"><see cref="CreateModelRequest"/></param>
        /// <returns><see cref="CreateModelResponse"/></returns>
        public Task<CreateModelResponse> CreateModel(CreateModelRequest req)
        {
            return InternalRequestAsync<CreateModelResponse>(req, "CreateModel");
        }

        /// <summary>
        /// 创建模型接口
        /// </summary>
        /// <param name="req"><see cref="CreateModelRequest"/></param>
        /// <returns><see cref="CreateModelResponse"/></returns>
        public CreateModelResponse CreateModelSync(CreateModelRequest req)
        {
            return InternalRequestAsync<CreateModelResponse>(req, "CreateModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建模型版本
        /// </summary>
        /// <param name="req"><see cref="CreateModelVersionRequest"/></param>
        /// <returns><see cref="CreateModelVersionResponse"/></returns>
        public Task<CreateModelVersionResponse> CreateModelVersion(CreateModelVersionRequest req)
        {
            return InternalRequestAsync<CreateModelVersionResponse>(req, "CreateModelVersion");
        }

        /// <summary>
        /// 创建模型版本
        /// </summary>
        /// <param name="req"><see cref="CreateModelVersionRequest"/></param>
        /// <returns><see cref="CreateModelVersionResponse"/></returns>
        public CreateModelVersionResponse CreateModelVersionSync(CreateModelVersionRequest req)
        {
            return InternalRequestAsync<CreateModelVersionResponse>(req, "CreateModelVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建schema
        /// </summary>
        /// <param name="req"><see cref="CreateSchemaRequest"/></param>
        /// <returns><see cref="CreateSchemaResponse"/></returns>
        public Task<CreateSchemaResponse> CreateSchema(CreateSchemaRequest req)
        {
            return InternalRequestAsync<CreateSchemaResponse>(req, "CreateSchema");
        }

        /// <summary>
        /// 创建schema
        /// </summary>
        /// <param name="req"><see cref="CreateSchemaRequest"/></param>
        /// <returns><see cref="CreateSchemaResponse"/></returns>
        public CreateSchemaResponse CreateSchemaSync(CreateSchemaRequest req)
        {
            return InternalRequestAsync<CreateSchemaResponse>(req, "CreateSchema")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据卷接口
        /// </summary>
        /// <param name="req"><see cref="CreateVolumeRequest"/></param>
        /// <returns><see cref="CreateVolumeResponse"/></returns>
        public Task<CreateVolumeResponse> CreateVolume(CreateVolumeRequest req)
        {
            return InternalRequestAsync<CreateVolumeResponse>(req, "CreateVolume");
        }

        /// <summary>
        /// 创建数据卷接口
        /// </summary>
        /// <param name="req"><see cref="CreateVolumeRequest"/></param>
        /// <returns><see cref="CreateVolumeResponse"/></returns>
        public CreateVolumeResponse CreateVolumeSync(CreateVolumeRequest req)
        {
            return InternalRequestAsync<CreateVolumeResponse>(req, "CreateVolume")
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
        /// 创建工作空间，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRequest"/></param>
        /// <returns><see cref="CreateWorkspaceResponse"/></returns>
        public Task<CreateWorkspaceResponse> CreateWorkspace(CreateWorkspaceRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceResponse>(req, "CreateWorkspace");
        }

        /// <summary>
        /// 创建工作空间，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRequest"/></param>
        /// <returns><see cref="CreateWorkspaceResponse"/></returns>
        public CreateWorkspaceResponse CreateWorkspaceSync(CreateWorkspaceRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceResponse>(req, "CreateWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建工作空间角色
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRoleRequest"/></param>
        /// <returns><see cref="CreateWorkspaceRoleResponse"/></returns>
        public Task<CreateWorkspaceRoleResponse> CreateWorkspaceRole(CreateWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceRoleResponse>(req, "CreateWorkspaceRole");
        }

        /// <summary>
        /// 创建工作空间角色
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRoleRequest"/></param>
        /// <returns><see cref="CreateWorkspaceRoleResponse"/></returns>
        public CreateWorkspaceRoleResponse CreateWorkspaceRoleSync(CreateWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceRoleResponse>(req, "CreateWorkspaceRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除catalog
        /// </summary>
        /// <param name="req"><see cref="DeleteCatalogRequest"/></param>
        /// <returns><see cref="DeleteCatalogResponse"/></returns>
        public Task<DeleteCatalogResponse> DeleteCatalog(DeleteCatalogRequest req)
        {
            return InternalRequestAsync<DeleteCatalogResponse>(req, "DeleteCatalog");
        }

        /// <summary>
        /// 删除catalog
        /// </summary>
        /// <param name="req"><see cref="DeleteCatalogRequest"/></param>
        /// <returns><see cref="DeleteCatalogResponse"/></returns>
        public DeleteCatalogResponse DeleteCatalogSync(DeleteCatalogRequest req)
        {
            return InternalRequestAsync<DeleteCatalogResponse>(req, "DeleteCatalog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除控制台用户组，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="DeleteConsoleGroupsRequest"/></param>
        /// <returns><see cref="DeleteConsoleGroupsResponse"/></returns>
        public Task<DeleteConsoleGroupsResponse> DeleteConsoleGroups(DeleteConsoleGroupsRequest req)
        {
            return InternalRequestAsync<DeleteConsoleGroupsResponse>(req, "DeleteConsoleGroups");
        }

        /// <summary>
        /// 删除控制台用户组，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
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
        /// 删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteFolderRequest"/></param>
        /// <returns><see cref="DeleteFolderResponse"/></returns>
        public Task<DeleteFolderResponse> DeleteFolder(DeleteFolderRequest req)
        {
            return InternalRequestAsync<DeleteFolderResponse>(req, "DeleteFolder");
        }

        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteFolderRequest"/></param>
        /// <returns><see cref="DeleteFolderResponse"/></returns>
        public DeleteFolderResponse DeleteFolderSync(DeleteFolderRequest req)
        {
            return InternalRequestAsync<DeleteFolderResponse>(req, "DeleteFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除存储位置
        /// 使用场景：删除指定的存储位置
        /// 前置条件：存储位置名称必须存在
        /// 错误码：MetaLakeNotFound - 存储位置不存在
        /// </summary>
        /// <param name="req"><see cref="DeleteLocationRequest"/></param>
        /// <returns><see cref="DeleteLocationResponse"/></returns>
        public Task<DeleteLocationResponse> DeleteLocation(DeleteLocationRequest req)
        {
            return InternalRequestAsync<DeleteLocationResponse>(req, "DeleteLocation");
        }

        /// <summary>
        /// 删除存储位置
        /// 使用场景：删除指定的存储位置
        /// 前置条件：存储位置名称必须存在
        /// 错误码：MetaLakeNotFound - 存储位置不存在
        /// </summary>
        /// <param name="req"><see cref="DeleteLocationRequest"/></param>
        /// <returns><see cref="DeleteLocationResponse"/></returns>
        public DeleteLocationResponse DeleteLocationSync(DeleteLocationRequest req)
        {
            return InternalRequestAsync<DeleteLocationResponse>(req, "DeleteLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除模型
        /// </summary>
        /// <param name="req"><see cref="DeleteModelRequest"/></param>
        /// <returns><see cref="DeleteModelResponse"/></returns>
        public Task<DeleteModelResponse> DeleteModel(DeleteModelRequest req)
        {
            return InternalRequestAsync<DeleteModelResponse>(req, "DeleteModel");
        }

        /// <summary>
        /// 删除模型
        /// </summary>
        /// <param name="req"><see cref="DeleteModelRequest"/></param>
        /// <returns><see cref="DeleteModelResponse"/></returns>
        public DeleteModelResponse DeleteModelSync(DeleteModelRequest req)
        {
            return InternalRequestAsync<DeleteModelResponse>(req, "DeleteModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除schema
        /// </summary>
        /// <param name="req"><see cref="DeleteSchemaRequest"/></param>
        /// <returns><see cref="DeleteSchemaResponse"/></returns>
        public Task<DeleteSchemaResponse> DeleteSchema(DeleteSchemaRequest req)
        {
            return InternalRequestAsync<DeleteSchemaResponse>(req, "DeleteSchema");
        }

        /// <summary>
        /// 删除schema
        /// </summary>
        /// <param name="req"><see cref="DeleteSchemaRequest"/></param>
        /// <returns><see cref="DeleteSchemaResponse"/></returns>
        public DeleteSchemaResponse DeleteSchemaSync(DeleteSchemaRequest req)
        {
            return InternalRequestAsync<DeleteSchemaResponse>(req, "DeleteSchema")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除table
        /// </summary>
        /// <param name="req"><see cref="DeleteTableRequest"/></param>
        /// <returns><see cref="DeleteTableResponse"/></returns>
        public Task<DeleteTableResponse> DeleteTable(DeleteTableRequest req)
        {
            return InternalRequestAsync<DeleteTableResponse>(req, "DeleteTable");
        }

        /// <summary>
        /// 删除table
        /// </summary>
        /// <param name="req"><see cref="DeleteTableRequest"/></param>
        /// <returns><see cref="DeleteTableResponse"/></returns>
        public DeleteTableResponse DeleteTableSync(DeleteTableRequest req)
        {
            return InternalRequestAsync<DeleteTableResponse>(req, "DeleteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除view
        /// </summary>
        /// <param name="req"><see cref="DeleteViewRequest"/></param>
        /// <returns><see cref="DeleteViewResponse"/></returns>
        public Task<DeleteViewResponse> DeleteView(DeleteViewRequest req)
        {
            return InternalRequestAsync<DeleteViewResponse>(req, "DeleteView");
        }

        /// <summary>
        /// 删除view
        /// </summary>
        /// <param name="req"><see cref="DeleteViewRequest"/></param>
        /// <returns><see cref="DeleteViewResponse"/></returns>
        public DeleteViewResponse DeleteViewSync(DeleteViewRequest req)
        {
            return InternalRequestAsync<DeleteViewResponse>(req, "DeleteView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除数据卷
        /// </summary>
        /// <param name="req"><see cref="DeleteVolumeRequest"/></param>
        /// <returns><see cref="DeleteVolumeResponse"/></returns>
        public Task<DeleteVolumeResponse> DeleteVolume(DeleteVolumeRequest req)
        {
            return InternalRequestAsync<DeleteVolumeResponse>(req, "DeleteVolume");
        }

        /// <summary>
        /// 删除数据卷
        /// </summary>
        /// <param name="req"><see cref="DeleteVolumeRequest"/></param>
        /// <returns><see cref="DeleteVolumeResponse"/></returns>
        public DeleteVolumeResponse DeleteVolumeSync(DeleteVolumeRequest req)
        {
            return InternalRequestAsync<DeleteVolumeResponse>(req, "DeleteVolume")
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
        /// 删除工作空间
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkspaceRequest"/></param>
        /// <returns><see cref="DeleteWorkspaceResponse"/></returns>
        public Task<DeleteWorkspaceResponse> DeleteWorkspace(DeleteWorkspaceRequest req)
        {
            return InternalRequestAsync<DeleteWorkspaceResponse>(req, "DeleteWorkspace");
        }

        /// <summary>
        /// 删除工作空间
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkspaceRequest"/></param>
        /// <returns><see cref="DeleteWorkspaceResponse"/></returns>
        public DeleteWorkspaceResponse DeleteWorkspaceSync(DeleteWorkspaceRequest req)
        {
            return InternalRequestAsync<DeleteWorkspaceResponse>(req, "DeleteWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除工作空间角色
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkspaceRoleRequest"/></param>
        /// <returns><see cref="DeleteWorkspaceRoleResponse"/></returns>
        public Task<DeleteWorkspaceRoleResponse> DeleteWorkspaceRole(DeleteWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<DeleteWorkspaceRoleResponse>(req, "DeleteWorkspaceRole");
        }

        /// <summary>
        /// 删除工作空间角色
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkspaceRoleRequest"/></param>
        /// <returns><see cref="DeleteWorkspaceRoleResponse"/></returns>
        public DeleteWorkspaceRoleResponse DeleteWorkspaceRoleSync(DeleteWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<DeleteWorkspaceRoleResponse>(req, "DeleteWorkspaceRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询catalog详情
        /// </summary>
        /// <param name="req"><see cref="GetCatalogRequest"/></param>
        /// <returns><see cref="GetCatalogResponse"/></returns>
        public Task<GetCatalogResponse> GetCatalog(GetCatalogRequest req)
        {
            return InternalRequestAsync<GetCatalogResponse>(req, "GetCatalog");
        }

        /// <summary>
        /// 查询catalog详情
        /// </summary>
        /// <param name="req"><see cref="GetCatalogRequest"/></param>
        /// <returns><see cref="GetCatalogResponse"/></returns>
        public GetCatalogResponse GetCatalogSync(GetCatalogRequest req)
        {
            return InternalRequestAsync<GetCatalogResponse>(req, "GetCatalog")
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
        /// 获取文件夹详情
        /// </summary>
        /// <param name="req"><see cref="GetFolderRequest"/></param>
        /// <returns><see cref="GetFolderResponse"/></returns>
        public Task<GetFolderResponse> GetFolder(GetFolderRequest req)
        {
            return InternalRequestAsync<GetFolderResponse>(req, "GetFolder");
        }

        /// <summary>
        /// 获取文件夹详情
        /// </summary>
        /// <param name="req"><see cref="GetFolderRequest"/></param>
        /// <returns><see cref="GetFolderResponse"/></returns>
        public GetFolderResponse GetFolderSync(GetFolderRequest req)
        {
            return InternalRequestAsync<GetFolderResponse>(req, "GetFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询存储位置详情
        /// 使用场景：根据存储位置名获取单个存储位置的详细信息
        /// 前置条件：存储位置名称必须存在
        /// 错误码：MetaLakeNotFound - 存储位置不存在
        /// </summary>
        /// <param name="req"><see cref="GetLocationRequest"/></param>
        /// <returns><see cref="GetLocationResponse"/></returns>
        public Task<GetLocationResponse> GetLocation(GetLocationRequest req)
        {
            return InternalRequestAsync<GetLocationResponse>(req, "GetLocation");
        }

        /// <summary>
        /// 查询存储位置详情
        /// 使用场景：根据存储位置名获取单个存储位置的详细信息
        /// 前置条件：存储位置名称必须存在
        /// 错误码：MetaLakeNotFound - 存储位置不存在
        /// </summary>
        /// <param name="req"><see cref="GetLocationRequest"/></param>
        /// <returns><see cref="GetLocationResponse"/></returns>
        public GetLocationResponse GetLocationSync(GetLocationRequest req)
        {
            return InternalRequestAsync<GetLocationResponse>(req, "GetLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模型详情
        /// </summary>
        /// <param name="req"><see cref="GetModelRequest"/></param>
        /// <returns><see cref="GetModelResponse"/></returns>
        public Task<GetModelResponse> GetModel(GetModelRequest req)
        {
            return InternalRequestAsync<GetModelResponse>(req, "GetModel");
        }

        /// <summary>
        /// 获取模型详情
        /// </summary>
        /// <param name="req"><see cref="GetModelRequest"/></param>
        /// <returns><see cref="GetModelResponse"/></returns>
        public GetModelResponse GetModelSync(GetModelRequest req)
        {
            return InternalRequestAsync<GetModelResponse>(req, "GetModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模型版本详情
        /// </summary>
        /// <param name="req"><see cref="GetModelVersionRequest"/></param>
        /// <returns><see cref="GetModelVersionResponse"/></returns>
        public Task<GetModelVersionResponse> GetModelVersion(GetModelVersionRequest req)
        {
            return InternalRequestAsync<GetModelVersionResponse>(req, "GetModelVersion");
        }

        /// <summary>
        /// 获取模型版本详情
        /// </summary>
        /// <param name="req"><see cref="GetModelVersionRequest"/></param>
        /// <returns><see cref="GetModelVersionResponse"/></returns>
        public GetModelVersionResponse GetModelVersionSync(GetModelVersionRequest req)
        {
            return InternalRequestAsync<GetModelVersionResponse>(req, "GetModelVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询schema详情
        /// </summary>
        /// <param name="req"><see cref="GetSchemaRequest"/></param>
        /// <returns><see cref="GetSchemaResponse"/></returns>
        public Task<GetSchemaResponse> GetSchema(GetSchemaRequest req)
        {
            return InternalRequestAsync<GetSchemaResponse>(req, "GetSchema");
        }

        /// <summary>
        /// 查询schema详情
        /// </summary>
        /// <param name="req"><see cref="GetSchemaRequest"/></param>
        /// <returns><see cref="GetSchemaResponse"/></returns>
        public GetSchemaResponse GetSchemaSync(GetSchemaRequest req)
        {
            return InternalRequestAsync<GetSchemaResponse>(req, "GetSchema")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询table详情
        /// </summary>
        /// <param name="req"><see cref="GetTableRequest"/></param>
        /// <returns><see cref="GetTableResponse"/></returns>
        public Task<GetTableResponse> GetTable(GetTableRequest req)
        {
            return InternalRequestAsync<GetTableResponse>(req, "GetTable");
        }

        /// <summary>
        /// 查询table详情
        /// </summary>
        /// <param name="req"><see cref="GetTableRequest"/></param>
        /// <returns><see cref="GetTableResponse"/></returns>
        public GetTableResponse GetTableSync(GetTableRequest req)
        {
            return InternalRequestAsync<GetTableResponse>(req, "GetTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取表的元数据。使用场景：根据表的全名列表（catalogName.schemaName.tableName）批量获取表的详细元数据信息。前置条件：需要有对应workspace的读权限，仅返回当前workspace有权限的catalog下的表。权限校验：通过getAuthedCatalogNames获取有权限的catalogName进行过滤，不在权限范围内的表会被静默跳过。限制：FullNames最大支持20个表全名
        /// </summary>
        /// <param name="req"><see cref="GetTablesRequest"/></param>
        /// <returns><see cref="GetTablesResponse"/></returns>
        public Task<GetTablesResponse> GetTables(GetTablesRequest req)
        {
            return InternalRequestAsync<GetTablesResponse>(req, "GetTables");
        }

        /// <summary>
        /// 批量获取表的元数据。使用场景：根据表的全名列表（catalogName.schemaName.tableName）批量获取表的详细元数据信息。前置条件：需要有对应workspace的读权限，仅返回当前workspace有权限的catalog下的表。权限校验：通过getAuthedCatalogNames获取有权限的catalogName进行过滤，不在权限范围内的表会被静默跳过。限制：FullNames最大支持20个表全名
        /// </summary>
        /// <param name="req"><see cref="GetTablesRequest"/></param>
        /// <returns><see cref="GetTablesResponse"/></returns>
        public GetTablesResponse GetTablesSync(GetTablesRequest req)
        {
            return InternalRequestAsync<GetTablesResponse>(req, "GetTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询view详情
        /// </summary>
        /// <param name="req"><see cref="GetViewRequest"/></param>
        /// <returns><see cref="GetViewResponse"/></returns>
        public Task<GetViewResponse> GetView(GetViewRequest req)
        {
            return InternalRequestAsync<GetViewResponse>(req, "GetView");
        }

        /// <summary>
        /// 查询view详情
        /// </summary>
        /// <param name="req"><see cref="GetViewRequest"/></param>
        /// <returns><see cref="GetViewResponse"/></returns>
        public GetViewResponse GetViewSync(GetViewRequest req)
        {
            return InternalRequestAsync<GetViewResponse>(req, "GetView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模型详情
        /// </summary>
        /// <param name="req"><see cref="GetVolumeRequest"/></param>
        /// <returns><see cref="GetVolumeResponse"/></returns>
        public Task<GetVolumeResponse> GetVolume(GetVolumeRequest req)
        {
            return InternalRequestAsync<GetVolumeResponse>(req, "GetVolume");
        }

        /// <summary>
        /// 获取模型详情
        /// </summary>
        /// <param name="req"><see cref="GetVolumeRequest"/></param>
        /// <returns><see cref="GetVolumeResponse"/></returns>
        public GetVolumeResponse GetVolumeSync(GetVolumeRequest req)
        {
            return InternalRequestAsync<GetVolumeResponse>(req, "GetVolume")
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
        /// 查询工作空间详情
        /// </summary>
        /// <param name="req"><see cref="GetWorkspaceRequest"/></param>
        /// <returns><see cref="GetWorkspaceResponse"/></returns>
        public Task<GetWorkspaceResponse> GetWorkspace(GetWorkspaceRequest req)
        {
            return InternalRequestAsync<GetWorkspaceResponse>(req, "GetWorkspace");
        }

        /// <summary>
        /// 查询工作空间详情
        /// </summary>
        /// <param name="req"><see cref="GetWorkspaceRequest"/></param>
        /// <returns><see cref="GetWorkspaceResponse"/></returns>
        public GetWorkspaceResponse GetWorkspaceSync(GetWorkspaceRequest req)
        {
            return InternalRequestAsync<GetWorkspaceResponse>(req, "GetWorkspace")
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
        /// 分页查询数据目录名称列表
        /// </summary>
        /// <param name="req"><see cref="ListCatalogNamesRequest"/></param>
        /// <returns><see cref="ListCatalogNamesResponse"/></returns>
        public Task<ListCatalogNamesResponse> ListCatalogNames(ListCatalogNamesRequest req)
        {
            return InternalRequestAsync<ListCatalogNamesResponse>(req, "ListCatalogNames");
        }

        /// <summary>
        /// 分页查询数据目录名称列表
        /// </summary>
        /// <param name="req"><see cref="ListCatalogNamesRequest"/></param>
        /// <returns><see cref="ListCatalogNamesResponse"/></returns>
        public ListCatalogNamesResponse ListCatalogNamesSync(ListCatalogNamesRequest req)
        {
            return InternalRequestAsync<ListCatalogNamesResponse>(req, "ListCatalogNames")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页获取数据目录列表
        /// </summary>
        /// <param name="req"><see cref="ListCatalogsRequest"/></param>
        /// <returns><see cref="ListCatalogsResponse"/></returns>
        public Task<ListCatalogsResponse> ListCatalogs(ListCatalogsRequest req)
        {
            return InternalRequestAsync<ListCatalogsResponse>(req, "ListCatalogs");
        }

        /// <summary>
        /// 分页获取数据目录列表
        /// </summary>
        /// <param name="req"><see cref="ListCatalogsRequest"/></param>
        /// <returns><see cref="ListCatalogsResponse"/></returns>
        public ListCatalogsResponse ListCatalogsSync(ListCatalogsRequest req)
        {
            return InternalRequestAsync<ListCatalogsResponse>(req, "ListCatalogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询控制台用户组成员列表，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupUsersRequest"/></param>
        /// <returns><see cref="ListConsoleGroupUsersResponse"/></returns>
        public Task<ListConsoleGroupUsersResponse> ListConsoleGroupUsers(ListConsoleGroupUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupUsersResponse>(req, "ListConsoleGroupUsers");
        }

        /// <summary>
        /// 查询控制台用户组成员列表，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupUsersRequest"/></param>
        /// <returns><see cref="ListConsoleGroupUsersResponse"/></returns>
        public ListConsoleGroupUsersResponse ListConsoleGroupUsersSync(ListConsoleGroupUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupUsersResponse>(req, "ListConsoleGroupUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询控制台用户组列表，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupsRequest"/></param>
        /// <returns><see cref="ListConsoleGroupsResponse"/></returns>
        public Task<ListConsoleGroupsResponse> ListConsoleGroups(ListConsoleGroupsRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupsResponse>(req, "ListConsoleGroups");
        }

        /// <summary>
        /// 查询控制台用户组列表，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupsRequest"/></param>
        /// <returns><see cref="ListConsoleGroupsResponse"/></returns>
        public ListConsoleGroupsResponse ListConsoleGroupsSync(ListConsoleGroupsRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupsResponse>(req, "ListConsoleGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询控制台角色列表，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="ListConsoleRolesRequest"/></param>
        /// <returns><see cref="ListConsoleRolesResponse"/></returns>
        public Task<ListConsoleRolesResponse> ListConsoleRoles(ListConsoleRolesRequest req)
        {
            return InternalRequestAsync<ListConsoleRolesResponse>(req, "ListConsoleRoles");
        }

        /// <summary>
        /// 查询控制台角色列表，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="ListConsoleRolesRequest"/></param>
        /// <returns><see cref="ListConsoleRolesResponse"/></returns>
        public ListConsoleRolesResponse ListConsoleRolesSync(ListConsoleRolesRequest req)
        {
            return InternalRequestAsync<ListConsoleRolesResponse>(req, "ListConsoleRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询控制台用户列表，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="ListConsoleUsersRequest"/></param>
        /// <returns><see cref="ListConsoleUsersResponse"/></returns>
        public Task<ListConsoleUsersResponse> ListConsoleUsers(ListConsoleUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleUsersResponse>(req, "ListConsoleUsers");
        }

        /// <summary>
        /// 查询控制台用户列表，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="ListConsoleUsersRequest"/></param>
        /// <returns><see cref="ListConsoleUsersResponse"/></returns>
        public ListConsoleUsersResponse ListConsoleUsersSync(ListConsoleUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleUsersResponse>(req, "ListConsoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询特征表列表
        /// </summary>
        /// <param name="req"><see cref="ListFeatureTablesRequest"/></param>
        /// <returns><see cref="ListFeatureTablesResponse"/></returns>
        public Task<ListFeatureTablesResponse> ListFeatureTables(ListFeatureTablesRequest req)
        {
            return InternalRequestAsync<ListFeatureTablesResponse>(req, "ListFeatureTables");
        }

        /// <summary>
        /// 查询特征表列表
        /// </summary>
        /// <param name="req"><see cref="ListFeatureTablesRequest"/></param>
        /// <returns><see cref="ListFeatureTablesResponse"/></returns>
        public ListFeatureTablesResponse ListFeatureTablesSync(ListFeatureTablesRequest req)
        {
            return InternalRequestAsync<ListFeatureTablesResponse>(req, "ListFeatureTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取文件夹和文件列表
        /// </summary>
        /// <param name="req"><see cref="ListFilesRequest"/></param>
        /// <returns><see cref="ListFilesResponse"/></returns>
        public Task<ListFilesResponse> ListFiles(ListFilesRequest req)
        {
            return InternalRequestAsync<ListFilesResponse>(req, "ListFiles");
        }

        /// <summary>
        /// 获取文件夹和文件列表
        /// </summary>
        /// <param name="req"><see cref="ListFilesRequest"/></param>
        /// <returns><see cref="ListFilesResponse"/></returns>
        public ListFilesResponse ListFilesSync(ListFilesRequest req)
        {
            return InternalRequestAsync<ListFilesResponse>(req, "ListFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询存储位置列表
        /// 使用场景：分页查询数据湖仓库中的存储位置详情列表，支持模式匹配和快照分页
        /// </summary>
        /// <param name="req"><see cref="ListLocationsRequest"/></param>
        /// <returns><see cref="ListLocationsResponse"/></returns>
        public Task<ListLocationsResponse> ListLocations(ListLocationsRequest req)
        {
            return InternalRequestAsync<ListLocationsResponse>(req, "ListLocations");
        }

        /// <summary>
        /// 分页查询存储位置列表
        /// 使用场景：分页查询数据湖仓库中的存储位置详情列表，支持模式匹配和快照分页
        /// </summary>
        /// <param name="req"><see cref="ListLocationsRequest"/></param>
        /// <returns><see cref="ListLocationsResponse"/></returns>
        public ListLocationsResponse ListLocationsSync(ListLocationsRequest req)
        {
            return InternalRequestAsync<ListLocationsResponse>(req, "ListLocations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页获取模型信息
        /// </summary>
        /// <param name="req"><see cref="ListModelsRequest"/></param>
        /// <returns><see cref="ListModelsResponse"/></returns>
        public Task<ListModelsResponse> ListModels(ListModelsRequest req)
        {
            return InternalRequestAsync<ListModelsResponse>(req, "ListModels");
        }

        /// <summary>
        /// 分页获取模型信息
        /// </summary>
        /// <param name="req"><see cref="ListModelsRequest"/></param>
        /// <returns><see cref="ListModelsResponse"/></returns>
        public ListModelsResponse ListModelsSync(ListModelsRequest req)
        {
            return InternalRequestAsync<ListModelsResponse>(req, "ListModels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询数据库名称列表
        /// </summary>
        /// <param name="req"><see cref="ListSchemaNamesRequest"/></param>
        /// <returns><see cref="ListSchemaNamesResponse"/></returns>
        public Task<ListSchemaNamesResponse> ListSchemaNames(ListSchemaNamesRequest req)
        {
            return InternalRequestAsync<ListSchemaNamesResponse>(req, "ListSchemaNames");
        }

        /// <summary>
        /// 分页查询数据库名称列表
        /// </summary>
        /// <param name="req"><see cref="ListSchemaNamesRequest"/></param>
        /// <returns><see cref="ListSchemaNamesResponse"/></returns>
        public ListSchemaNamesResponse ListSchemaNamesSync(ListSchemaNamesRequest req)
        {
            return InternalRequestAsync<ListSchemaNamesResponse>(req, "ListSchemaNames")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取schema列表
        /// </summary>
        /// <param name="req"><see cref="ListSchemasRequest"/></param>
        /// <returns><see cref="ListSchemasResponse"/></returns>
        public Task<ListSchemasResponse> ListSchemas(ListSchemasRequest req)
        {
            return InternalRequestAsync<ListSchemasResponse>(req, "ListSchemas");
        }

        /// <summary>
        /// 获取schema列表
        /// </summary>
        /// <param name="req"><see cref="ListSchemasRequest"/></param>
        /// <returns><see cref="ListSchemasResponse"/></returns>
        public ListSchemasResponse ListSchemasSync(ListSchemasRequest req)
        {
            return InternalRequestAsync<ListSchemasResponse>(req, "ListSchemas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询数据表名称列表
        /// </summary>
        /// <param name="req"><see cref="ListTableNamesRequest"/></param>
        /// <returns><see cref="ListTableNamesResponse"/></returns>
        public Task<ListTableNamesResponse> ListTableNames(ListTableNamesRequest req)
        {
            return InternalRequestAsync<ListTableNamesResponse>(req, "ListTableNames");
        }

        /// <summary>
        /// 分页查询数据表名称列表
        /// </summary>
        /// <param name="req"><see cref="ListTableNamesRequest"/></param>
        /// <returns><see cref="ListTableNamesResponse"/></returns>
        public ListTableNamesResponse ListTableNamesSync(ListTableNamesRequest req)
        {
            return InternalRequestAsync<ListTableNamesResponse>(req, "ListTableNames")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取table列表
        /// </summary>
        /// <param name="req"><see cref="ListTablesRequest"/></param>
        /// <returns><see cref="ListTablesResponse"/></returns>
        public Task<ListTablesResponse> ListTables(ListTablesRequest req)
        {
            return InternalRequestAsync<ListTablesResponse>(req, "ListTables");
        }

        /// <summary>
        /// 获取table列表
        /// </summary>
        /// <param name="req"><see cref="ListTablesRequest"/></param>
        /// <returns><see cref="ListTablesResponse"/></returns>
        public ListTablesResponse ListTablesSync(ListTablesRequest req)
        {
            return InternalRequestAsync<ListTablesResponse>(req, "ListTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询视图名称列表
        /// </summary>
        /// <param name="req"><see cref="ListViewNamesRequest"/></param>
        /// <returns><see cref="ListViewNamesResponse"/></returns>
        public Task<ListViewNamesResponse> ListViewNames(ListViewNamesRequest req)
        {
            return InternalRequestAsync<ListViewNamesResponse>(req, "ListViewNames");
        }

        /// <summary>
        /// 分页查询视图名称列表
        /// </summary>
        /// <param name="req"><see cref="ListViewNamesRequest"/></param>
        /// <returns><see cref="ListViewNamesResponse"/></returns>
        public ListViewNamesResponse ListViewNamesSync(ListViewNamesRequest req)
        {
            return InternalRequestAsync<ListViewNamesResponse>(req, "ListViewNames")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取view列表
        /// </summary>
        /// <param name="req"><see cref="ListViewsRequest"/></param>
        /// <returns><see cref="ListViewsResponse"/></returns>
        public Task<ListViewsResponse> ListViews(ListViewsRequest req)
        {
            return InternalRequestAsync<ListViewsResponse>(req, "ListViews");
        }

        /// <summary>
        /// 获取view列表
        /// </summary>
        /// <param name="req"><see cref="ListViewsRequest"/></param>
        /// <returns><see cref="ListViewsResponse"/></returns>
        public ListViewsResponse ListViewsSync(ListViewsRequest req)
        {
            return InternalRequestAsync<ListViewsResponse>(req, "ListViews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页获取数据卷信息
        /// </summary>
        /// <param name="req"><see cref="ListVolumesRequest"/></param>
        /// <returns><see cref="ListVolumesResponse"/></returns>
        public Task<ListVolumesResponse> ListVolumes(ListVolumesRequest req)
        {
            return InternalRequestAsync<ListVolumesResponse>(req, "ListVolumes");
        }

        /// <summary>
        /// 分页获取数据卷信息
        /// </summary>
        /// <param name="req"><see cref="ListVolumesRequest"/></param>
        /// <returns><see cref="ListVolumesResponse"/></returns>
        public ListVolumesResponse ListVolumesSync(ListVolumesRequest req)
        {
            return InternalRequestAsync<ListVolumesResponse>(req, "ListVolumes")
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
        /// 查询工作空间用户组用户列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkspaceGroupUsersRequest"/></param>
        /// <returns><see cref="ListWorkspaceGroupUsersResponse"/></returns>
        public Task<ListWorkspaceGroupUsersResponse> ListWorkspaceGroupUsers(ListWorkspaceGroupUsersRequest req)
        {
            return InternalRequestAsync<ListWorkspaceGroupUsersResponse>(req, "ListWorkspaceGroupUsers");
        }

        /// <summary>
        /// 查询工作空间用户组用户列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkspaceGroupUsersRequest"/></param>
        /// <returns><see cref="ListWorkspaceGroupUsersResponse"/></returns>
        public ListWorkspaceGroupUsersResponse ListWorkspaceGroupUsersSync(ListWorkspaceGroupUsersRequest req)
        {
            return InternalRequestAsync<ListWorkspaceGroupUsersResponse>(req, "ListWorkspaceGroupUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作空间用户组列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="ListWorkspaceGroupsResponse"/></returns>
        public Task<ListWorkspaceGroupsResponse> ListWorkspaceGroups(ListWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<ListWorkspaceGroupsResponse>(req, "ListWorkspaceGroups");
        }

        /// <summary>
        /// 查询工作空间用户组列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="ListWorkspaceGroupsResponse"/></returns>
        public ListWorkspaceGroupsResponse ListWorkspaceGroupsSync(ListWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<ListWorkspaceGroupsResponse>(req, "ListWorkspaceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作空间用户列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkspaceUsersRequest"/></param>
        /// <returns><see cref="ListWorkspaceUsersResponse"/></returns>
        public Task<ListWorkspaceUsersResponse> ListWorkspaceUsers(ListWorkspaceUsersRequest req)
        {
            return InternalRequestAsync<ListWorkspaceUsersResponse>(req, "ListWorkspaceUsers");
        }

        /// <summary>
        /// 查询工作空间用户列表
        /// </summary>
        /// <param name="req"><see cref="ListWorkspaceUsersRequest"/></param>
        /// <returns><see cref="ListWorkspaceUsersResponse"/></returns>
        public ListWorkspaceUsersResponse ListWorkspaceUsersSync(ListWorkspaceUsersRequest req)
        {
            return InternalRequestAsync<ListWorkspaceUsersResponse>(req, "ListWorkspaceUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作空间列表，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="ListWorkspacesRequest"/></param>
        /// <returns><see cref="ListWorkspacesResponse"/></returns>
        public Task<ListWorkspacesResponse> ListWorkspaces(ListWorkspacesRequest req)
        {
            return InternalRequestAsync<ListWorkspacesResponse>(req, "ListWorkspaces");
        }

        /// <summary>
        /// 查询工作空间列表，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="ListWorkspacesRequest"/></param>
        /// <returns><see cref="ListWorkspacesResponse"/></returns>
        public ListWorkspacesResponse ListWorkspacesSync(ListWorkspacesRequest req)
        {
            return InternalRequestAsync<ListWorkspacesResponse>(req, "ListWorkspaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p>批量移除控制台用户（单次最多10个；前置校验任一不满足整体拒绝；执行阶段单个失败不中断后续删除，成败以 SuccessUins/FailItems 为准），该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。</p>
        /// </summary>
        /// <param name="req"><see cref="RemoveConsoleUsersRequest"/></param>
        /// <returns><see cref="RemoveConsoleUsersResponse"/></returns>
        public Task<RemoveConsoleUsersResponse> RemoveConsoleUsers(RemoveConsoleUsersRequest req)
        {
            return InternalRequestAsync<RemoveConsoleUsersResponse>(req, "RemoveConsoleUsers");
        }

        /// <summary>
        /// <p>批量移除控制台用户（单次最多10个；前置校验任一不满足整体拒绝；执行阶段单个失败不中断后续删除，成败以 SuccessUins/FailItems 为准），该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。</p>
        /// </summary>
        /// <param name="req"><see cref="RemoveConsoleUsersRequest"/></param>
        /// <returns><see cref="RemoveConsoleUsersResponse"/></returns>
        public RemoveConsoleUsersResponse RemoveConsoleUsersSync(RemoveConsoleUsersRequest req)
        {
            return InternalRequestAsync<RemoveConsoleUsersResponse>(req, "RemoveConsoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移除工作空间用户组
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="RemoveWorkspaceGroupsResponse"/></returns>
        public Task<RemoveWorkspaceGroupsResponse> RemoveWorkspaceGroups(RemoveWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<RemoveWorkspaceGroupsResponse>(req, "RemoveWorkspaceGroups");
        }

        /// <summary>
        /// 移除工作空间用户组
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="RemoveWorkspaceGroupsResponse"/></returns>
        public RemoveWorkspaceGroupsResponse RemoveWorkspaceGroupsSync(RemoveWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<RemoveWorkspaceGroupsResponse>(req, "RemoveWorkspaceGroups")
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
        /// 资产统一搜索
        /// </summary>
        /// <param name="req"><see cref="SearchAssetRequest"/></param>
        /// <returns><see cref="SearchAssetResponse"/></returns>
        public Task<SearchAssetResponse> SearchAsset(SearchAssetRequest req)
        {
            return InternalRequestAsync<SearchAssetResponse>(req, "SearchAsset");
        }

        /// <summary>
        /// 资产统一搜索
        /// </summary>
        /// <param name="req"><see cref="SearchAssetRequest"/></param>
        /// <returns><see cref="SearchAssetResponse"/></returns>
        public SearchAssetResponse SearchAssetSync(SearchAssetRequest req)
        {
            return InternalRequestAsync<SearchAssetResponse>(req, "SearchAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动计算资源
        /// </summary>
        /// <param name="req"><see cref="StartComputeRequest"/></param>
        /// <returns><see cref="StartComputeResponse"/></returns>
        public Task<StartComputeResponse> StartCompute(StartComputeRequest req)
        {
            return InternalRequestAsync<StartComputeResponse>(req, "StartCompute");
        }

        /// <summary>
        /// 启动计算资源
        /// </summary>
        /// <param name="req"><see cref="StartComputeRequest"/></param>
        /// <returns><see cref="StartComputeResponse"/></returns>
        public StartComputeResponse StartComputeSync(StartComputeRequest req)
        {
            return InternalRequestAsync<StartComputeResponse>(req, "StartCompute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止计算资源
        /// </summary>
        /// <param name="req"><see cref="StopComputeRequest"/></param>
        /// <returns><see cref="StopComputeResponse"/></returns>
        public Task<StopComputeResponse> StopCompute(StopComputeRequest req)
        {
            return InternalRequestAsync<StopComputeResponse>(req, "StopCompute");
        }

        /// <summary>
        /// 停止计算资源
        /// </summary>
        /// <param name="req"><see cref="StopComputeRequest"/></param>
        /// <returns><see cref="StopComputeResponse"/></returns>
        public StopComputeResponse StopComputeSync(StopComputeRequest req)
        {
            return InternalRequestAsync<StopComputeResponse>(req, "StopCompute")
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
        /// 修改数据目录信息
        /// 使用场景：修改数据目录的注释，按需传入NewComment字段
        /// 前置条件：数据目录必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateCatalogRequest"/></param>
        /// <returns><see cref="UpdateCatalogResponse"/></returns>
        public Task<UpdateCatalogResponse> UpdateCatalog(UpdateCatalogRequest req)
        {
            return InternalRequestAsync<UpdateCatalogResponse>(req, "UpdateCatalog");
        }

        /// <summary>
        /// 修改数据目录信息
        /// 使用场景：修改数据目录的注释，按需传入NewComment字段
        /// 前置条件：数据目录必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateCatalogRequest"/></param>
        /// <returns><see cref="UpdateCatalogResponse"/></returns>
        public UpdateCatalogResponse UpdateCatalogSync(UpdateCatalogRequest req)
        {
            return InternalRequestAsync<UpdateCatalogResponse>(req, "UpdateCatalog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改控制台用户组，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="UpdateConsoleGroupRequest"/></param>
        /// <returns><see cref="UpdateConsoleGroupResponse"/></returns>
        public Task<UpdateConsoleGroupResponse> UpdateConsoleGroup(UpdateConsoleGroupRequest req)
        {
            return InternalRequestAsync<UpdateConsoleGroupResponse>(req, "UpdateConsoleGroup");
        }

        /// <summary>
        /// 修改控制台用户组，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="UpdateConsoleGroupRequest"/></param>
        /// <returns><see cref="UpdateConsoleGroupResponse"/></returns>
        public UpdateConsoleGroupResponse UpdateConsoleGroupSync(UpdateConsoleGroupRequest req)
        {
            return InternalRequestAsync<UpdateConsoleGroupResponse>(req, "UpdateConsoleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改控制台用户角色，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="UpdateConsoleUsersRequest"/></param>
        /// <returns><see cref="UpdateConsoleUsersResponse"/></returns>
        public Task<UpdateConsoleUsersResponse> UpdateConsoleUsers(UpdateConsoleUsersRequest req)
        {
            return InternalRequestAsync<UpdateConsoleUsersResponse>(req, "UpdateConsoleUsers");
        }

        /// <summary>
        /// 修改控制台用户角色，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
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
        /// 更新文件夹（支持重命名+移动）
        /// </summary>
        /// <param name="req"><see cref="UpdateFolderRequest"/></param>
        /// <returns><see cref="UpdateFolderResponse"/></returns>
        public Task<UpdateFolderResponse> UpdateFolder(UpdateFolderRequest req)
        {
            return InternalRequestAsync<UpdateFolderResponse>(req, "UpdateFolder");
        }

        /// <summary>
        /// 更新文件夹（支持重命名+移动）
        /// </summary>
        /// <param name="req"><see cref="UpdateFolderRequest"/></param>
        /// <returns><see cref="UpdateFolderResponse"/></returns>
        public UpdateFolderResponse UpdateFolderSync(UpdateFolderRequest req)
        {
            return InternalRequestAsync<UpdateFolderResponse>(req, "UpdateFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改函数信息
        /// 使用场景：修改函数的注释，按需传入NewComment字段
        /// 前置条件：函数必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionRequest"/></param>
        /// <returns><see cref="UpdateFunctionResponse"/></returns>
        public Task<UpdateFunctionResponse> UpdateFunction(UpdateFunctionRequest req)
        {
            return InternalRequestAsync<UpdateFunctionResponse>(req, "UpdateFunction");
        }

        /// <summary>
        /// 修改函数信息
        /// 使用场景：修改函数的注释，按需传入NewComment字段
        /// 前置条件：函数必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionRequest"/></param>
        /// <returns><see cref="UpdateFunctionResponse"/></returns>
        public UpdateFunctionResponse UpdateFunctionSync(UpdateFunctionRequest req)
        {
            return InternalRequestAsync<UpdateFunctionResponse>(req, "UpdateFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改存储位置
        /// 使用场景：修改存储位置的名称、描述或属性信息
        /// 前置条件：存储位置名称必须存在
        /// 错误码：MetaLakeNotFound - 存储位置不存在
        /// </summary>
        /// <param name="req"><see cref="UpdateLocationRequest"/></param>
        /// <returns><see cref="UpdateLocationResponse"/></returns>
        public Task<UpdateLocationResponse> UpdateLocation(UpdateLocationRequest req)
        {
            return InternalRequestAsync<UpdateLocationResponse>(req, "UpdateLocation");
        }

        /// <summary>
        /// 修改存储位置
        /// 使用场景：修改存储位置的名称、描述或属性信息
        /// 前置条件：存储位置名称必须存在
        /// 错误码：MetaLakeNotFound - 存储位置不存在
        /// </summary>
        /// <param name="req"><see cref="UpdateLocationRequest"/></param>
        /// <returns><see cref="UpdateLocationResponse"/></returns>
        public UpdateLocationResponse UpdateLocationSync(UpdateLocationRequest req)
        {
            return InternalRequestAsync<UpdateLocationResponse>(req, "UpdateLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模型信息
        /// 使用场景：修改模型的名称或注释，按需传入NewName/NewComment字段
        /// 前置条件：模型必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateModelRequest"/></param>
        /// <returns><see cref="UpdateModelResponse"/></returns>
        public Task<UpdateModelResponse> UpdateModel(UpdateModelRequest req)
        {
            return InternalRequestAsync<UpdateModelResponse>(req, "UpdateModel");
        }

        /// <summary>
        /// 修改模型信息
        /// 使用场景：修改模型的名称或注释，按需传入NewName/NewComment字段
        /// 前置条件：模型必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateModelRequest"/></param>
        /// <returns><see cref="UpdateModelResponse"/></returns>
        public UpdateModelResponse UpdateModelSync(UpdateModelRequest req)
        {
            return InternalRequestAsync<UpdateModelResponse>(req, "UpdateModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模型版本信息
        /// 使用场景：修改模型版本的别名或注释，按需传入对应字段
        /// 前置条件：模型版本必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateModelVersionRequest"/></param>
        /// <returns><see cref="UpdateModelVersionResponse"/></returns>
        public Task<UpdateModelVersionResponse> UpdateModelVersion(UpdateModelVersionRequest req)
        {
            return InternalRequestAsync<UpdateModelVersionResponse>(req, "UpdateModelVersion");
        }

        /// <summary>
        /// 修改模型版本信息
        /// 使用场景：修改模型版本的别名或注释，按需传入对应字段
        /// 前置条件：模型版本必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateModelVersionRequest"/></param>
        /// <returns><see cref="UpdateModelVersionResponse"/></returns>
        public UpdateModelVersionResponse UpdateModelVersionSync(UpdateModelVersionRequest req)
        {
            return InternalRequestAsync<UpdateModelVersionResponse>(req, "UpdateModelVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改schema信息
        /// 使用场景：修改schema的注释，按需传入NewComment字段
        /// 前置条件：schema必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateSchemaRequest"/></param>
        /// <returns><see cref="UpdateSchemaResponse"/></returns>
        public Task<UpdateSchemaResponse> UpdateSchema(UpdateSchemaRequest req)
        {
            return InternalRequestAsync<UpdateSchemaResponse>(req, "UpdateSchema");
        }

        /// <summary>
        /// 修改schema信息
        /// 使用场景：修改schema的注释，按需传入NewComment字段
        /// 前置条件：schema必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateSchemaRequest"/></param>
        /// <returns><see cref="UpdateSchemaResponse"/></returns>
        public UpdateSchemaResponse UpdateSchemaSync(UpdateSchemaRequest req)
        {
            return InternalRequestAsync<UpdateSchemaResponse>(req, "UpdateSchema")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改表信息
        /// 使用场景：修改表的名称或注释，按需传入NewName/NewComment字段
        /// 前置条件：表必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateTableRequest"/></param>
        /// <returns><see cref="UpdateTableResponse"/></returns>
        public Task<UpdateTableResponse> UpdateTable(UpdateTableRequest req)
        {
            return InternalRequestAsync<UpdateTableResponse>(req, "UpdateTable");
        }

        /// <summary>
        /// 修改表信息
        /// 使用场景：修改表的名称或注释，按需传入NewName/NewComment字段
        /// 前置条件：表必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateTableRequest"/></param>
        /// <returns><see cref="UpdateTableResponse"/></returns>
        public UpdateTableResponse UpdateTableSync(UpdateTableRequest req)
        {
            return InternalRequestAsync<UpdateTableResponse>(req, "UpdateTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改表字段描述
        /// 使用场景：修改表中一个或多个字段的注释
        /// 前置条件：用户需对目标表有写权限；字段名必须存在于目标表中
        /// </summary>
        /// <param name="req"><see cref="UpdateTableColumnRequest"/></param>
        /// <returns><see cref="UpdateTableColumnResponse"/></returns>
        public Task<UpdateTableColumnResponse> UpdateTableColumn(UpdateTableColumnRequest req)
        {
            return InternalRequestAsync<UpdateTableColumnResponse>(req, "UpdateTableColumn");
        }

        /// <summary>
        /// 修改表字段描述
        /// 使用场景：修改表中一个或多个字段的注释
        /// 前置条件：用户需对目标表有写权限；字段名必须存在于目标表中
        /// </summary>
        /// <param name="req"><see cref="UpdateTableColumnRequest"/></param>
        /// <returns><see cref="UpdateTableColumnResponse"/></returns>
        public UpdateTableColumnResponse UpdateTableColumnSync(UpdateTableColumnRequest req)
        {
            return InternalRequestAsync<UpdateTableColumnResponse>(req, "UpdateTableColumn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改视图信息
        /// 使用场景：修改视图的名称或注释，按需传入NewName/NewComment字段
        /// 前置条件：视图必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateViewRequest"/></param>
        /// <returns><see cref="UpdateViewResponse"/></returns>
        public Task<UpdateViewResponse> UpdateView(UpdateViewRequest req)
        {
            return InternalRequestAsync<UpdateViewResponse>(req, "UpdateView");
        }

        /// <summary>
        /// 修改视图信息
        /// 使用场景：修改视图的名称或注释，按需传入NewName/NewComment字段
        /// 前置条件：视图必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateViewRequest"/></param>
        /// <returns><see cref="UpdateViewResponse"/></returns>
        public UpdateViewResponse UpdateViewSync(UpdateViewRequest req)
        {
            return InternalRequestAsync<UpdateViewResponse>(req, "UpdateView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改数据卷信息
        /// 使用场景：修改数据卷的名称或注释，按需传入NewName/NewComment字段
        /// 前置条件：数据卷必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateVolumeRequest"/></param>
        /// <returns><see cref="UpdateVolumeResponse"/></returns>
        public Task<UpdateVolumeResponse> UpdateVolume(UpdateVolumeRequest req)
        {
            return InternalRequestAsync<UpdateVolumeResponse>(req, "UpdateVolume");
        }

        /// <summary>
        /// 修改数据卷信息
        /// 使用场景：修改数据卷的名称或注释，按需传入NewName/NewComment字段
        /// 前置条件：数据卷必须存在
        /// </summary>
        /// <param name="req"><see cref="UpdateVolumeRequest"/></param>
        /// <returns><see cref="UpdateVolumeResponse"/></returns>
        public UpdateVolumeResponse UpdateVolumeSync(UpdateVolumeRequest req)
        {
            return InternalRequestAsync<UpdateVolumeResponse>(req, "UpdateVolume")
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

        /// <summary>
        /// 修改工作空间，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceResponse"/></returns>
        public Task<UpdateWorkspaceResponse> UpdateWorkspace(UpdateWorkspaceRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceResponse>(req, "UpdateWorkspace");
        }

        /// <summary>
        /// 修改工作空间，该接口为控制台级接口，仅支持在中心地域调用：国内站请传入 ap-guangzhou，国际站请传入 ap-singapore；其他地域调用将返回 UnsupportedRegion。
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceResponse"/></returns>
        public UpdateWorkspaceResponse UpdateWorkspaceSync(UpdateWorkspaceRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceResponse>(req, "UpdateWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新工作空间用户组角色
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceGroupsRolesRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceGroupsRolesResponse"/></returns>
        public Task<UpdateWorkspaceGroupsRolesResponse> UpdateWorkspaceGroupsRoles(UpdateWorkspaceGroupsRolesRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceGroupsRolesResponse>(req, "UpdateWorkspaceGroupsRoles");
        }

        /// <summary>
        /// 更新工作空间用户组角色
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceGroupsRolesRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceGroupsRolesResponse"/></returns>
        public UpdateWorkspaceGroupsRolesResponse UpdateWorkspaceGroupsRolesSync(UpdateWorkspaceGroupsRolesRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceGroupsRolesResponse>(req, "UpdateWorkspaceGroupsRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新工作空间角色
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceRoleRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceRoleResponse"/></returns>
        public Task<UpdateWorkspaceRoleResponse> UpdateWorkspaceRole(UpdateWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceRoleResponse>(req, "UpdateWorkspaceRole");
        }

        /// <summary>
        /// 更新工作空间角色
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceRoleRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceRoleResponse"/></returns>
        public UpdateWorkspaceRoleResponse UpdateWorkspaceRoleSync(UpdateWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceRoleResponse>(req, "UpdateWorkspaceRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改工作空间用户角色
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceUsersRolesRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceUsersRolesResponse"/></returns>
        public Task<UpdateWorkspaceUsersRolesResponse> UpdateWorkspaceUsersRoles(UpdateWorkspaceUsersRolesRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceUsersRolesResponse>(req, "UpdateWorkspaceUsersRoles");
        }

        /// <summary>
        /// 修改工作空间用户角色
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceUsersRolesRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceUsersRolesResponse"/></returns>
        public UpdateWorkspaceUsersRolesResponse UpdateWorkspaceUsersRolesSync(UpdateWorkspaceUsersRolesRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceUsersRolesResponse>(req, "UpdateWorkspaceUsersRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
