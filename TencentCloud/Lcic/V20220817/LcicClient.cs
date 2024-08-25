/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Lcic.V20220817
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lcic.V20220817.Models;

   public class LcicClient : AbstractClient{

       private const string endpoint = "lcic.tencentcloudapi.com";
       private const string version = "2022-08-17";
       private const string sdkVersion = "SDK_NET_3.0.1076";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LcicClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LcicClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 此接口用于添加成员列表到指定群组
        /// </summary>
        /// <param name="req"><see cref="AddGroupMemberRequest"/></param>
        /// <returns><see cref="AddGroupMemberResponse"/></returns>
        public Task<AddGroupMemberResponse> AddGroupMember(AddGroupMemberRequest req)
        {
            return InternalRequestAsync<AddGroupMemberResponse>(req, "AddGroupMember");
        }

        /// <summary>
        /// 此接口用于添加成员列表到指定群组
        /// </summary>
        /// <param name="req"><see cref="AddGroupMemberRequest"/></param>
        /// <returns><see cref="AddGroupMemberResponse"/></returns>
        public AddGroupMemberResponse AddGroupMemberSync(AddGroupMemberRequest req)
        {
            return InternalRequestAsync<AddGroupMemberResponse>(req, "AddGroupMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于批量添加成员列表到指定群组
        /// </summary>
        /// <param name="req"><see cref="BatchAddGroupMemberRequest"/></param>
        /// <returns><see cref="BatchAddGroupMemberResponse"/></returns>
        public Task<BatchAddGroupMemberResponse> BatchAddGroupMember(BatchAddGroupMemberRequest req)
        {
            return InternalRequestAsync<BatchAddGroupMemberResponse>(req, "BatchAddGroupMember");
        }

        /// <summary>
        /// 此接口用于批量添加成员列表到指定群组
        /// </summary>
        /// <param name="req"><see cref="BatchAddGroupMemberRequest"/></param>
        /// <returns><see cref="BatchAddGroupMemberResponse"/></returns>
        public BatchAddGroupMemberResponse BatchAddGroupMemberSync(BatchAddGroupMemberRequest req)
        {
            return InternalRequestAsync<BatchAddGroupMemberResponse>(req, "BatchAddGroupMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于批量创建群组
        /// </summary>
        /// <param name="req"><see cref="BatchCreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="BatchCreateGroupWithMembersResponse"/></returns>
        public Task<BatchCreateGroupWithMembersResponse> BatchCreateGroupWithMembers(BatchCreateGroupWithMembersRequest req)
        {
            return InternalRequestAsync<BatchCreateGroupWithMembersResponse>(req, "BatchCreateGroupWithMembers");
        }

        /// <summary>
        /// 此接口用于批量创建群组
        /// </summary>
        /// <param name="req"><see cref="BatchCreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="BatchCreateGroupWithMembersResponse"/></returns>
        public BatchCreateGroupWithMembersResponse BatchCreateGroupWithMembersSync(BatchCreateGroupWithMembersRequest req)
        {
            return InternalRequestAsync<BatchCreateGroupWithMembersResponse>(req, "BatchCreateGroupWithMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量创建房间接口
        /// </summary>
        /// <param name="req"><see cref="BatchCreateRoomRequest"/></param>
        /// <returns><see cref="BatchCreateRoomResponse"/></returns>
        public Task<BatchCreateRoomResponse> BatchCreateRoom(BatchCreateRoomRequest req)
        {
            return InternalRequestAsync<BatchCreateRoomResponse>(req, "BatchCreateRoom");
        }

        /// <summary>
        /// 批量创建房间接口
        /// </summary>
        /// <param name="req"><see cref="BatchCreateRoomRequest"/></param>
        /// <returns><see cref="BatchCreateRoomResponse"/></returns>
        public BatchCreateRoomResponse BatchCreateRoomSync(BatchCreateRoomRequest req)
        {
            return InternalRequestAsync<BatchCreateRoomResponse>(req, "BatchCreateRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于批量删除成员列表到指定群组列表
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteGroupMemberRequest"/></param>
        /// <returns><see cref="BatchDeleteGroupMemberResponse"/></returns>
        public Task<BatchDeleteGroupMemberResponse> BatchDeleteGroupMember(BatchDeleteGroupMemberRequest req)
        {
            return InternalRequestAsync<BatchDeleteGroupMemberResponse>(req, "BatchDeleteGroupMember");
        }

        /// <summary>
        /// 此接口用于批量删除成员列表到指定群组列表
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteGroupMemberRequest"/></param>
        /// <returns><see cref="BatchDeleteGroupMemberResponse"/></returns>
        public BatchDeleteGroupMemberResponse BatchDeleteGroupMemberSync(BatchDeleteGroupMemberRequest req)
        {
            return InternalRequestAsync<BatchDeleteGroupMemberResponse>(req, "BatchDeleteGroupMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除多个房间的录制文件
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteRecordRequest"/></param>
        /// <returns><see cref="BatchDeleteRecordResponse"/></returns>
        public Task<BatchDeleteRecordResponse> BatchDeleteRecord(BatchDeleteRecordRequest req)
        {
            return InternalRequestAsync<BatchDeleteRecordResponse>(req, "BatchDeleteRecord");
        }

        /// <summary>
        /// 批量删除多个房间的录制文件
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteRecordRequest"/></param>
        /// <returns><see cref="BatchDeleteRecordResponse"/></returns>
        public BatchDeleteRecordResponse BatchDeleteRecordSync(BatchDeleteRecordRequest req)
        {
            return InternalRequestAsync<BatchDeleteRecordResponse>(req, "BatchDeleteRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取文档详情
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeDocumentRequest"/></param>
        /// <returns><see cref="BatchDescribeDocumentResponse"/></returns>
        public Task<BatchDescribeDocumentResponse> BatchDescribeDocument(BatchDescribeDocumentRequest req)
        {
            return InternalRequestAsync<BatchDescribeDocumentResponse>(req, "BatchDescribeDocument");
        }

        /// <summary>
        /// 批量获取文档详情
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeDocumentRequest"/></param>
        /// <returns><see cref="BatchDescribeDocumentResponse"/></returns>
        public BatchDescribeDocumentResponse BatchDescribeDocumentSync(BatchDescribeDocumentRequest req)
        {
            return InternalRequestAsync<BatchDescribeDocumentResponse>(req, "BatchDescribeDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 如果批量注册的用户已存在，则会被覆盖。一次最多注册1000个用户。默认请求频率限制：10次/秒
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterRequest"/></param>
        /// <returns><see cref="BatchRegisterResponse"/></returns>
        public Task<BatchRegisterResponse> BatchRegister(BatchRegisterRequest req)
        {
            return InternalRequestAsync<BatchRegisterResponse>(req, "BatchRegister");
        }

        /// <summary>
        /// 如果批量注册的用户已存在，则会被覆盖。一次最多注册1000个用户。默认请求频率限制：10次/秒
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterRequest"/></param>
        /// <returns><see cref="BatchRegisterResponse"/></returns>
        public BatchRegisterResponse BatchRegisterSync(BatchRegisterRequest req)
        {
            return InternalRequestAsync<BatchRegisterResponse>(req, "BatchRegister")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定文档到房间
        /// </summary>
        /// <param name="req"><see cref="BindDocumentToRoomRequest"/></param>
        /// <returns><see cref="BindDocumentToRoomResponse"/></returns>
        public Task<BindDocumentToRoomResponse> BindDocumentToRoom(BindDocumentToRoomRequest req)
        {
            return InternalRequestAsync<BindDocumentToRoomResponse>(req, "BindDocumentToRoom");
        }

        /// <summary>
        /// 绑定文档到房间
        /// </summary>
        /// <param name="req"><see cref="BindDocumentToRoomRequest"/></param>
        /// <returns><see cref="BindDocumentToRoomResponse"/></returns>
        public BindDocumentToRoomResponse BindDocumentToRoomSync(BindDocumentToRoomRequest req)
        {
            return InternalRequestAsync<BindDocumentToRoomResponse>(req, "BindDocumentToRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建房间内可以使用的文档。
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public Task<CreateDocumentResponse> CreateDocument(CreateDocumentRequest req)
        {
            return InternalRequestAsync<CreateDocumentResponse>(req, "CreateDocument");
        }

        /// <summary>
        /// 创建房间内可以使用的文档。
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public CreateDocumentResponse CreateDocumentSync(CreateDocumentRequest req)
        {
            return InternalRequestAsync<CreateDocumentResponse>(req, "CreateDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口根据成员列表创建群组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="CreateGroupWithMembersResponse"/></returns>
        public Task<CreateGroupWithMembersResponse> CreateGroupWithMembers(CreateGroupWithMembersRequest req)
        {
            return InternalRequestAsync<CreateGroupWithMembersResponse>(req, "CreateGroupWithMembers");
        }

        /// <summary>
        /// 此接口根据成员列表创建群组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="CreateGroupWithMembersResponse"/></returns>
        public CreateGroupWithMembersResponse CreateGroupWithMembersSync(CreateGroupWithMembersRequest req)
        {
            return InternalRequestAsync<CreateGroupWithMembersResponse>(req, "CreateGroupWithMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口会聚合子群组创建联合群组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithSubGroupRequest"/></param>
        /// <returns><see cref="CreateGroupWithSubGroupResponse"/></returns>
        public Task<CreateGroupWithSubGroupResponse> CreateGroupWithSubGroup(CreateGroupWithSubGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupWithSubGroupResponse>(req, "CreateGroupWithSubGroup");
        }

        /// <summary>
        /// 此接口会聚合子群组创建联合群组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithSubGroupRequest"/></param>
        /// <returns><see cref="CreateGroupWithSubGroupResponse"/></returns>
        public CreateGroupWithSubGroupResponse CreateGroupWithSubGroupSync(CreateGroupWithSubGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupWithSubGroupResponse>(req, "CreateGroupWithSubGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建房间
        /// </summary>
        /// <param name="req"><see cref="CreateRoomRequest"/></param>
        /// <returns><see cref="CreateRoomResponse"/></returns>
        public Task<CreateRoomResponse> CreateRoom(CreateRoomRequest req)
        {
            return InternalRequestAsync<CreateRoomResponse>(req, "CreateRoom");
        }

        /// <summary>
        /// 创建房间
        /// </summary>
        /// <param name="req"><see cref="CreateRoomRequest"/></param>
        /// <returns><see cref="CreateRoomResponse"/></returns>
        public CreateRoomResponse CreateRoomSync(CreateRoomRequest req)
        {
            return InternalRequestAsync<CreateRoomResponse>(req, "CreateRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建巡课
        /// </summary>
        /// <param name="req"><see cref="CreateSupervisorRequest"/></param>
        /// <returns><see cref="CreateSupervisorResponse"/></returns>
        public Task<CreateSupervisorResponse> CreateSupervisor(CreateSupervisorRequest req)
        {
            return InternalRequestAsync<CreateSupervisorResponse>(req, "CreateSupervisor");
        }

        /// <summary>
        /// 创建巡课
        /// </summary>
        /// <param name="req"><see cref="CreateSupervisorRequest"/></param>
        /// <returns><see cref="CreateSupervisorResponse"/></returns>
        public CreateSupervisorResponse CreateSupervisorSync(CreateSupervisorRequest req)
        {
            return InternalRequestAsync<CreateSupervisorResponse>(req, "CreateSupervisor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除设置自定义元素。如果参数scenes为空则删除所有自定义元素，否则删除指定的scene自定义元素。
        /// </summary>
        /// <param name="req"><see cref="DeleteAppCustomContentRequest"/></param>
        /// <returns><see cref="DeleteAppCustomContentResponse"/></returns>
        public Task<DeleteAppCustomContentResponse> DeleteAppCustomContent(DeleteAppCustomContentRequest req)
        {
            return InternalRequestAsync<DeleteAppCustomContentResponse>(req, "DeleteAppCustomContent");
        }

        /// <summary>
        /// 删除设置自定义元素。如果参数scenes为空则删除所有自定义元素，否则删除指定的scene自定义元素。
        /// </summary>
        /// <param name="req"><see cref="DeleteAppCustomContentRequest"/></param>
        /// <returns><see cref="DeleteAppCustomContentResponse"/></returns>
        public DeleteAppCustomContentResponse DeleteAppCustomContentSync(DeleteAppCustomContentRequest req)
        {
            return InternalRequestAsync<DeleteAppCustomContentResponse>(req, "DeleteAppCustomContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除文档
        /// </summary>
        /// <param name="req"><see cref="DeleteDocumentRequest"/></param>
        /// <returns><see cref="DeleteDocumentResponse"/></returns>
        public Task<DeleteDocumentResponse> DeleteDocument(DeleteDocumentRequest req)
        {
            return InternalRequestAsync<DeleteDocumentResponse>(req, "DeleteDocument");
        }

        /// <summary>
        /// 删除文档
        /// </summary>
        /// <param name="req"><see cref="DeleteDocumentRequest"/></param>
        /// <returns><see cref="DeleteDocumentResponse"/></returns>
        public DeleteDocumentResponse DeleteDocumentSync(DeleteDocumentRequest req)
        {
            return InternalRequestAsync<DeleteDocumentResponse>(req, "DeleteDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于删除指定群组，支持批量操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup");
        }

        /// <summary>
        /// 此接口用于删除指定群组，支持批量操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于删除群组中指定成员
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupMemberRequest"/></param>
        /// <returns><see cref="DeleteGroupMemberResponse"/></returns>
        public Task<DeleteGroupMemberResponse> DeleteGroupMember(DeleteGroupMemberRequest req)
        {
            return InternalRequestAsync<DeleteGroupMemberResponse>(req, "DeleteGroupMember");
        }

        /// <summary>
        /// 此接口用于删除群组中指定成员
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupMemberRequest"/></param>
        /// <returns><see cref="DeleteGroupMemberResponse"/></returns>
        public DeleteGroupMemberResponse DeleteGroupMemberSync(DeleteGroupMemberRequest req)
        {
            return InternalRequestAsync<DeleteGroupMemberResponse>(req, "DeleteGroupMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定房间的录制文件
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public Task<DeleteRecordResponse> DeleteRecord(DeleteRecordRequest req)
        {
            return InternalRequestAsync<DeleteRecordResponse>(req, "DeleteRecord");
        }

        /// <summary>
        /// 删除指定房间的录制文件
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public DeleteRecordResponse DeleteRecordSync(DeleteRecordRequest req)
        {
            return InternalRequestAsync<DeleteRecordResponse>(req, "DeleteRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除房间
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomRequest"/></param>
        /// <returns><see cref="DeleteRoomResponse"/></returns>
        public Task<DeleteRoomResponse> DeleteRoom(DeleteRoomRequest req)
        {
            return InternalRequestAsync<DeleteRoomResponse>(req, "DeleteRoom");
        }

        /// <summary>
        /// 删除房间
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomRequest"/></param>
        /// <returns><see cref="DeleteRoomResponse"/></returns>
        public DeleteRoomResponse DeleteRoomSync(DeleteRoomRequest req)
        {
            return InternalRequestAsync<DeleteRoomResponse>(req, "DeleteRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除巡课
        /// </summary>
        /// <param name="req"><see cref="DeleteSupervisorRequest"/></param>
        /// <returns><see cref="DeleteSupervisorResponse"/></returns>
        public Task<DeleteSupervisorResponse> DeleteSupervisor(DeleteSupervisorRequest req)
        {
            return InternalRequestAsync<DeleteSupervisorResponse>(req, "DeleteSupervisor");
        }

        /// <summary>
        /// 删除巡课
        /// </summary>
        /// <param name="req"><see cref="DeleteSupervisorRequest"/></param>
        /// <returns><see cref="DeleteSupervisorResponse"/></returns>
        public DeleteSupervisorResponse DeleteSupervisorSync(DeleteSupervisorRequest req)
        {
            return InternalRequestAsync<DeleteSupervisorResponse>(req, "DeleteSupervisor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除已注册用户。注：如果该成员已被添加到群组，请先在群组中删除该成员。
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// 删除已注册用户。注：如果该成员已被添加到群组，请先在群组中删除该成员。
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取房间答题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAnswerListRequest"/></param>
        /// <returns><see cref="DescribeAnswerListResponse"/></returns>
        public Task<DescribeAnswerListResponse> DescribeAnswerList(DescribeAnswerListRequest req)
        {
            return InternalRequestAsync<DescribeAnswerListResponse>(req, "DescribeAnswerList");
        }

        /// <summary>
        /// 获取房间答题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAnswerListRequest"/></param>
        /// <returns><see cref="DescribeAnswerListResponse"/></returns>
        public DescribeAnswerListResponse DescribeAnswerListSync(DescribeAnswerListRequest req)
        {
            return InternalRequestAsync<DescribeAnswerListResponse>(req, "DescribeAnswerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAppDetailRequest"/></param>
        /// <returns><see cref="DescribeAppDetailResponse"/></returns>
        public Task<DescribeAppDetailResponse> DescribeAppDetail(DescribeAppDetailRequest req)
        {
            return InternalRequestAsync<DescribeAppDetailResponse>(req, "DescribeAppDetail");
        }

        /// <summary>
        /// 获取应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAppDetailRequest"/></param>
        /// <returns><see cref="DescribeAppDetailResponse"/></returns>
        public DescribeAppDetailResponse DescribeAppDetailSync(DescribeAppDetailRequest req)
        {
            return InternalRequestAsync<DescribeAppDetailResponse>(req, "DescribeAppDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前房间的成员列表，房间结束或过期后无法使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentMemberListRequest"/></param>
        /// <returns><see cref="DescribeCurrentMemberListResponse"/></returns>
        public Task<DescribeCurrentMemberListResponse> DescribeCurrentMemberList(DescribeCurrentMemberListRequest req)
        {
            return InternalRequestAsync<DescribeCurrentMemberListResponse>(req, "DescribeCurrentMemberList");
        }

        /// <summary>
        /// 获取当前房间的成员列表，房间结束或过期后无法使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentMemberListRequest"/></param>
        /// <returns><see cref="DescribeCurrentMemberListResponse"/></returns>
        public DescribeCurrentMemberListResponse DescribeCurrentMemberListSync(DescribeCurrentMemberListRequest req)
        {
            return InternalRequestAsync<DescribeCurrentMemberListResponse>(req, "DescribeCurrentMemberList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开发商信息获取
        /// </summary>
        /// <param name="req"><see cref="DescribeDeveloperRequest"/></param>
        /// <returns><see cref="DescribeDeveloperResponse"/></returns>
        public Task<DescribeDeveloperResponse> DescribeDeveloper(DescribeDeveloperRequest req)
        {
            return InternalRequestAsync<DescribeDeveloperResponse>(req, "DescribeDeveloper");
        }

        /// <summary>
        /// 开发商信息获取
        /// </summary>
        /// <param name="req"><see cref="DescribeDeveloperRequest"/></param>
        /// <returns><see cref="DescribeDeveloperResponse"/></returns>
        public DescribeDeveloperResponse DescribeDeveloperSync(DescribeDeveloperRequest req)
        {
            return InternalRequestAsync<DescribeDeveloperResponse>(req, "DescribeDeveloper")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取文档信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentRequest"/></param>
        /// <returns><see cref="DescribeDocumentResponse"/></returns>
        public Task<DescribeDocumentResponse> DescribeDocument(DescribeDocumentRequest req)
        {
            return InternalRequestAsync<DescribeDocumentResponse>(req, "DescribeDocument");
        }

        /// <summary>
        /// 获取文档信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentRequest"/></param>
        /// <returns><see cref="DescribeDocumentResponse"/></returns>
        public DescribeDocumentResponse DescribeDocumentSync(DescribeDocumentRequest req)
        {
            return InternalRequestAsync<DescribeDocumentResponse>(req, "DescribeDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 有新接口替换
        /// 
        /// 批量获取文档信息（已废弃，替代接口BatchDescribeDocument）
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentsRequest"/></param>
        /// <returns><see cref="DescribeDocumentsResponse"/></returns>
        public Task<DescribeDocumentsResponse> DescribeDocuments(DescribeDocumentsRequest req)
        {
            return InternalRequestAsync<DescribeDocumentsResponse>(req, "DescribeDocuments");
        }

        /// <summary>
        /// 有新接口替换
        /// 
        /// 批量获取文档信息（已废弃，替代接口BatchDescribeDocument）
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentsRequest"/></param>
        /// <returns><see cref="DescribeDocumentsResponse"/></returns>
        public DescribeDocumentsResponse DescribeDocumentsSync(DescribeDocumentsRequest req)
        {
            return InternalRequestAsync<DescribeDocumentsResponse>(req, "DescribeDocuments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口获取指定房间下课件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentsByRoomRequest"/></param>
        /// <returns><see cref="DescribeDocumentsByRoomResponse"/></returns>
        public Task<DescribeDocumentsByRoomResponse> DescribeDocumentsByRoom(DescribeDocumentsByRoomRequest req)
        {
            return InternalRequestAsync<DescribeDocumentsByRoomResponse>(req, "DescribeDocumentsByRoom");
        }

        /// <summary>
        /// 此接口获取指定房间下课件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentsByRoomRequest"/></param>
        /// <returns><see cref="DescribeDocumentsByRoomResponse"/></returns>
        public DescribeDocumentsByRoomResponse DescribeDocumentsByRoomSync(DescribeDocumentsByRoomRequest req)
        {
            return InternalRequestAsync<DescribeDocumentsByRoomResponse>(req, "DescribeDocumentsByRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于获取群组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public Task<DescribeGroupResponse> DescribeGroup(DescribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeGroupResponse>(req, "DescribeGroup");
        }

        /// <summary>
        /// 此接口用于获取群组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public DescribeGroupResponse DescribeGroupSync(DescribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeGroupResponse>(req, "DescribeGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取群组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupListRequest"/></param>
        /// <returns><see cref="DescribeGroupListResponse"/></returns>
        public Task<DescribeGroupListResponse> DescribeGroupList(DescribeGroupListRequest req)
        {
            return InternalRequestAsync<DescribeGroupListResponse>(req, "DescribeGroupList");
        }

        /// <summary>
        /// 获取群组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupListRequest"/></param>
        /// <returns><see cref="DescribeGroupListResponse"/></returns>
        public DescribeGroupListResponse DescribeGroupListSync(DescribeGroupListRequest req)
        {
            return InternalRequestAsync<DescribeGroupListResponse>(req, "DescribeGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于获取群组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupMemberListRequest"/></param>
        /// <returns><see cref="DescribeGroupMemberListResponse"/></returns>
        public Task<DescribeGroupMemberListResponse> DescribeGroupMemberList(DescribeGroupMemberListRequest req)
        {
            return InternalRequestAsync<DescribeGroupMemberListResponse>(req, "DescribeGroupMemberList");
        }

        /// <summary>
        /// 此接口用于获取群组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupMemberListRequest"/></param>
        /// <returns><see cref="DescribeGroupMemberListResponse"/></returns>
        public DescribeGroupMemberListResponse DescribeGroupMemberListSync(DescribeGroupMemberListRequest req)
        {
            return InternalRequestAsync<DescribeGroupMemberListResponse>(req, "DescribeGroupMemberList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取房间提问列表
        /// </summary>
        /// <param name="req"><see cref="DescribeQuestionListRequest"/></param>
        /// <returns><see cref="DescribeQuestionListResponse"/></returns>
        public Task<DescribeQuestionListResponse> DescribeQuestionList(DescribeQuestionListRequest req)
        {
            return InternalRequestAsync<DescribeQuestionListResponse>(req, "DescribeQuestionList");
        }

        /// <summary>
        /// 获取房间提问列表
        /// </summary>
        /// <param name="req"><see cref="DescribeQuestionListRequest"/></param>
        /// <returns><see cref="DescribeQuestionListResponse"/></returns>
        public DescribeQuestionListResponse DescribeQuestionListSync(DescribeQuestionListRequest req)
        {
            return InternalRequestAsync<DescribeQuestionListResponse>(req, "DescribeQuestionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 录制流查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordStreamRequest"/></param>
        /// <returns><see cref="DescribeRecordStreamResponse"/></returns>
        public Task<DescribeRecordStreamResponse> DescribeRecordStream(DescribeRecordStreamRequest req)
        {
            return InternalRequestAsync<DescribeRecordStreamResponse>(req, "DescribeRecordStream");
        }

        /// <summary>
        /// 录制流查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordStreamRequest"/></param>
        /// <returns><see cref="DescribeRecordStreamResponse"/></returns>
        public DescribeRecordStreamResponse DescribeRecordStreamSync(DescribeRecordStreamRequest req)
        {
            return InternalRequestAsync<DescribeRecordStreamResponse>(req, "DescribeRecordStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取房间配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public Task<DescribeRoomResponse> DescribeRoom(DescribeRoomRequest req)
        {
            return InternalRequestAsync<DescribeRoomResponse>(req, "DescribeRoom");
        }

        /// <summary>
        /// 获取房间配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public DescribeRoomResponse DescribeRoomSync(DescribeRoomRequest req)
        {
            return InternalRequestAsync<DescribeRoomResponse>(req, "DescribeRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据房间ID获取群组中被禁言的用户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomForbiddenUserRequest"/></param>
        /// <returns><see cref="DescribeRoomForbiddenUserResponse"/></returns>
        public Task<DescribeRoomForbiddenUserResponse> DescribeRoomForbiddenUser(DescribeRoomForbiddenUserRequest req)
        {
            return InternalRequestAsync<DescribeRoomForbiddenUserResponse>(req, "DescribeRoomForbiddenUser");
        }

        /// <summary>
        /// 根据房间ID获取群组中被禁言的用户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomForbiddenUserRequest"/></param>
        /// <returns><see cref="DescribeRoomForbiddenUserResponse"/></returns>
        public DescribeRoomForbiddenUserResponse DescribeRoomForbiddenUserSync(DescribeRoomForbiddenUserRequest req)
        {
            return InternalRequestAsync<DescribeRoomForbiddenUserResponse>(req, "DescribeRoomForbiddenUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取房间统计信息，仅可在房间结束后调用。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRoomStatisticsResponse"/></returns>
        public Task<DescribeRoomStatisticsResponse> DescribeRoomStatistics(DescribeRoomStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeRoomStatisticsResponse>(req, "DescribeRoomStatistics");
        }

        /// <summary>
        /// 获取房间统计信息，仅可在房间结束后调用。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRoomStatisticsResponse"/></returns>
        public DescribeRoomStatisticsResponse DescribeRoomStatisticsSync(DescribeRoomStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeRoomStatisticsResponse>(req, "DescribeRoomStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取课堂评分列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoreListRequest"/></param>
        /// <returns><see cref="DescribeScoreListResponse"/></returns>
        public Task<DescribeScoreListResponse> DescribeScoreList(DescribeScoreListRequest req)
        {
            return InternalRequestAsync<DescribeScoreListResponse>(req, "DescribeScoreList");
        }

        /// <summary>
        /// 获取课堂评分列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoreListRequest"/></param>
        /// <returns><see cref="DescribeScoreListResponse"/></returns>
        public DescribeScoreListResponse DescribeScoreListSync(DescribeScoreListRequest req)
        {
            return InternalRequestAsync<DescribeScoreListResponse>(req, "DescribeScoreList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于获取指定应用ID下用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSdkAppIdUsersRequest"/></param>
        /// <returns><see cref="DescribeSdkAppIdUsersResponse"/></returns>
        public Task<DescribeSdkAppIdUsersResponse> DescribeSdkAppIdUsers(DescribeSdkAppIdUsersRequest req)
        {
            return InternalRequestAsync<DescribeSdkAppIdUsersResponse>(req, "DescribeSdkAppIdUsers");
        }

        /// <summary>
        /// 此接口用于获取指定应用ID下用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSdkAppIdUsersRequest"/></param>
        /// <returns><see cref="DescribeSdkAppIdUsersResponse"/></returns>
        public DescribeSdkAppIdUsersResponse DescribeSdkAppIdUsersSync(DescribeSdkAppIdUsersRequest req)
        {
            return InternalRequestAsync<DescribeSdkAppIdUsersResponse>(req, "DescribeSdkAppIdUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取巡课列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSupervisorsRequest"/></param>
        /// <returns><see cref="DescribeSupervisorsResponse"/></returns>
        public Task<DescribeSupervisorsResponse> DescribeSupervisors(DescribeSupervisorsRequest req)
        {
            return InternalRequestAsync<DescribeSupervisorsResponse>(req, "DescribeSupervisors");
        }

        /// <summary>
        /// 获取巡课列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSupervisorsRequest"/></param>
        /// <returns><see cref="DescribeSupervisorsResponse"/></returns>
        public DescribeSupervisorsResponse DescribeSupervisorsSync(DescribeSupervisorsRequest req)
        {
            return InternalRequestAsync<DescribeSupervisorsResponse>(req, "DescribeSupervisors")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser");
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 结束房间的直播
        /// </summary>
        /// <param name="req"><see cref="EndRoomRequest"/></param>
        /// <returns><see cref="EndRoomResponse"/></returns>
        public Task<EndRoomResponse> EndRoom(EndRoomRequest req)
        {
            return InternalRequestAsync<EndRoomResponse>(req, "EndRoom");
        }

        /// <summary>
        /// 结束房间的直播
        /// </summary>
        /// <param name="req"><see cref="EndRoomRequest"/></param>
        /// <returns><see cref="EndRoomResponse"/></returns>
        public EndRoomResponse EndRoomSync(EndRoomRequest req)
        {
            return InternalRequestAsync<EndRoomResponse>(req, "EndRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁止指定房间中某些用户在一段时间内发言。
        /// 取消对某些用户的禁言。
        /// 被禁言用户退出房间之后再进入同一房间，禁言仍然有效。
        /// </summary>
        /// <param name="req"><see cref="ForbidSendMsgRequest"/></param>
        /// <returns><see cref="ForbidSendMsgResponse"/></returns>
        public Task<ForbidSendMsgResponse> ForbidSendMsg(ForbidSendMsgRequest req)
        {
            return InternalRequestAsync<ForbidSendMsgResponse>(req, "ForbidSendMsg");
        }

        /// <summary>
        /// 禁止指定房间中某些用户在一段时间内发言。
        /// 取消对某些用户的禁言。
        /// 被禁言用户退出房间之后再进入同一房间，禁言仍然有效。
        /// </summary>
        /// <param name="req"><see cref="ForbidSendMsgRequest"/></param>
        /// <returns><see cref="ForbidSendMsgResponse"/></returns>
        public ForbidSendMsgResponse ForbidSendMsgSync(ForbidSendMsgRequest req)
        {
            return InternalRequestAsync<ForbidSendMsgResponse>(req, "ForbidSendMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取房间事件,仅在课堂结束1小时内有效。
        /// </summary>
        /// <param name="req"><see cref="GetRoomEventRequest"/></param>
        /// <returns><see cref="GetRoomEventResponse"/></returns>
        public Task<GetRoomEventResponse> GetRoomEvent(GetRoomEventRequest req)
        {
            return InternalRequestAsync<GetRoomEventResponse>(req, "GetRoomEvent");
        }

        /// <summary>
        /// 获取房间事件,仅在课堂结束1小时内有效。
        /// </summary>
        /// <param name="req"><see cref="GetRoomEventRequest"/></param>
        /// <returns><see cref="GetRoomEventResponse"/></returns>
        public GetRoomEventResponse GetRoomEventSync(GetRoomEventRequest req)
        {
            return InternalRequestAsync<GetRoomEventResponse>(req, "GetRoomEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取房间历史消息(房间历史消息保存7天)
        /// </summary>
        /// <param name="req"><see cref="GetRoomMessageRequest"/></param>
        /// <returns><see cref="GetRoomMessageResponse"/></returns>
        public Task<GetRoomMessageResponse> GetRoomMessage(GetRoomMessageRequest req)
        {
            return InternalRequestAsync<GetRoomMessageResponse>(req, "GetRoomMessage");
        }

        /// <summary>
        /// 获取房间历史消息(房间历史消息保存7天)
        /// </summary>
        /// <param name="req"><see cref="GetRoomMessageRequest"/></param>
        /// <returns><see cref="GetRoomMessageResponse"/></returns>
        public GetRoomMessageResponse GetRoomMessageSync(GetRoomMessageRequest req)
        {
            return InternalRequestAsync<GetRoomMessageResponse>(req, "GetRoomMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取房间列表
        /// </summary>
        /// <param name="req"><see cref="GetRoomsRequest"/></param>
        /// <returns><see cref="GetRoomsResponse"/></returns>
        public Task<GetRoomsResponse> GetRooms(GetRoomsRequest req)
        {
            return InternalRequestAsync<GetRoomsResponse>(req, "GetRooms");
        }

        /// <summary>
        /// 获取房间列表
        /// </summary>
        /// <param name="req"><see cref="GetRoomsRequest"/></param>
        /// <returns><see cref="GetRoomsResponse"/></returns>
        public GetRoomsResponse GetRoomsSync(GetRoomsRequest req)
        {
            return InternalRequestAsync<GetRoomsResponse>(req, "GetRooms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取水印设置
        /// </summary>
        /// <param name="req"><see cref="GetWatermarkRequest"/></param>
        /// <returns><see cref="GetWatermarkResponse"/></returns>
        public Task<GetWatermarkResponse> GetWatermark(GetWatermarkRequest req)
        {
            return InternalRequestAsync<GetWatermarkResponse>(req, "GetWatermark");
        }

        /// <summary>
        /// 获取水印设置
        /// </summary>
        /// <param name="req"><see cref="GetWatermarkRequest"/></param>
        /// <returns><see cref="GetWatermarkResponse"/></returns>
        public GetWatermarkResponse GetWatermarkSync(GetWatermarkRequest req)
        {
            return InternalRequestAsync<GetWatermarkResponse>(req, "GetWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从房间里面踢出用户
        /// </summary>
        /// <param name="req"><see cref="KickUserFromRoomRequest"/></param>
        /// <returns><see cref="KickUserFromRoomResponse"/></returns>
        public Task<KickUserFromRoomResponse> KickUserFromRoom(KickUserFromRoomRequest req)
        {
            return InternalRequestAsync<KickUserFromRoomResponse>(req, "KickUserFromRoom");
        }

        /// <summary>
        /// 从房间里面踢出用户
        /// </summary>
        /// <param name="req"><see cref="KickUserFromRoomRequest"/></param>
        /// <returns><see cref="KickUserFromRoomResponse"/></returns>
        public KickUserFromRoomResponse KickUserFromRoomSync(KickUserFromRoomRequest req)
        {
            return InternalRequestAsync<KickUserFromRoomResponse>(req, "KickUserFromRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用源账号登录，源账号为注册时填入的originId
        /// </summary>
        /// <param name="req"><see cref="LoginOriginIdRequest"/></param>
        /// <returns><see cref="LoginOriginIdResponse"/></returns>
        public Task<LoginOriginIdResponse> LoginOriginId(LoginOriginIdRequest req)
        {
            return InternalRequestAsync<LoginOriginIdResponse>(req, "LoginOriginId");
        }

        /// <summary>
        /// 使用源账号登录，源账号为注册时填入的originId
        /// </summary>
        /// <param name="req"><see cref="LoginOriginIdRequest"/></param>
        /// <returns><see cref="LoginOriginIdResponse"/></returns>
        public LoginOriginIdResponse LoginOriginIdSync(LoginOriginIdRequest req)
        {
            return InternalRequestAsync<LoginOriginIdResponse>(req, "LoginOriginId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="req"><see cref="LoginUserRequest"/></param>
        /// <returns><see cref="LoginUserResponse"/></returns>
        public Task<LoginUserResponse> LoginUser(LoginUserRequest req)
        {
            return InternalRequestAsync<LoginUserResponse>(req, "LoginUser");
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="req"><see cref="LoginUserRequest"/></param>
        /// <returns><see cref="LoginUserResponse"/></returns>
        public LoginUserResponse LoginUserSync(LoginUserRequest req)
        {
            return InternalRequestAsync<LoginUserResponse>(req, "LoginUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改应用
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public Task<ModifyAppResponse> ModifyApp(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp");
        }

        /// <summary>
        /// 修改应用
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public ModifyAppResponse ModifyAppSync(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口修改群组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public Task<ModifyGroupResponse> ModifyGroup(ModifyGroupRequest req)
        {
            return InternalRequestAsync<ModifyGroupResponse>(req, "ModifyGroup");
        }

        /// <summary>
        /// 此接口修改群组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public ModifyGroupResponse ModifyGroupSync(ModifyGroupRequest req)
        {
            return InternalRequestAsync<ModifyGroupResponse>(req, "ModifyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改房间
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public Task<ModifyRoomResponse> ModifyRoom(ModifyRoomRequest req)
        {
            return InternalRequestAsync<ModifyRoomResponse>(req, "ModifyRoom");
        }

        /// <summary>
        /// 修改房间
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public ModifyRoomResponse ModifyRoomSync(ModifyRoomRequest req)
        {
            return InternalRequestAsync<ModifyRoomResponse>(req, "ModifyRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于修改用户配置，如头像，昵称/用户名等。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserProfileRequest"/></param>
        /// <returns><see cref="ModifyUserProfileResponse"/></returns>
        public Task<ModifyUserProfileResponse> ModifyUserProfile(ModifyUserProfileRequest req)
        {
            return InternalRequestAsync<ModifyUserProfileResponse>(req, "ModifyUserProfile");
        }

        /// <summary>
        /// 此接口用于修改用户配置，如头像，昵称/用户名等。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserProfileRequest"/></param>
        /// <returns><see cref="ModifyUserProfileResponse"/></returns>
        public ModifyUserProfileResponse ModifyUserProfileSync(ModifyUserProfileRequest req)
        {
            return InternalRequestAsync<ModifyUserProfileResponse>(req, "ModifyUserProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="req"><see cref="RegisterUserRequest"/></param>
        /// <returns><see cref="RegisterUserResponse"/></returns>
        public Task<RegisterUserResponse> RegisterUser(RegisterUserRequest req)
        {
            return InternalRequestAsync<RegisterUserResponse>(req, "RegisterUser");
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="req"><see cref="RegisterUserRequest"/></param>
        /// <returns><see cref="RegisterUserResponse"/></returns>
        public RegisterUserResponse RegisterUserSync(RegisterUserRequest req)
        {
            return InternalRequestAsync<RegisterUserResponse>(req, "RegisterUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1、按照指定身份发送消息，目前支持表情消息、图片消息、文本消息。
        /// </summary>
        /// <param name="req"><see cref="SendRoomNormalMessageRequest"/></param>
        /// <returns><see cref="SendRoomNormalMessageResponse"/></returns>
        public Task<SendRoomNormalMessageResponse> SendRoomNormalMessage(SendRoomNormalMessageRequest req)
        {
            return InternalRequestAsync<SendRoomNormalMessageResponse>(req, "SendRoomNormalMessage");
        }

        /// <summary>
        /// 1、按照指定身份发送消息，目前支持表情消息、图片消息、文本消息。
        /// </summary>
        /// <param name="req"><see cref="SendRoomNormalMessageRequest"/></param>
        /// <returns><see cref="SendRoomNormalMessageResponse"/></returns>
        public SendRoomNormalMessageResponse SendRoomNormalMessageSync(SendRoomNormalMessageRequest req)
        {
            return InternalRequestAsync<SendRoomNormalMessageResponse>(req, "SendRoomNormalMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// App 管理员可以通过该接口在群组中发送通知、公告等。目前仅支持文本消息。
        /// </summary>
        /// <param name="req"><see cref="SendRoomNotificationMessageRequest"/></param>
        /// <returns><see cref="SendRoomNotificationMessageResponse"/></returns>
        public Task<SendRoomNotificationMessageResponse> SendRoomNotificationMessage(SendRoomNotificationMessageRequest req)
        {
            return InternalRequestAsync<SendRoomNotificationMessageResponse>(req, "SendRoomNotificationMessage");
        }

        /// <summary>
        /// App 管理员可以通过该接口在群组中发送通知、公告等。目前仅支持文本消息。
        /// </summary>
        /// <param name="req"><see cref="SendRoomNotificationMessageRequest"/></param>
        /// <returns><see cref="SendRoomNotificationMessageResponse"/></returns>
        public SendRoomNotificationMessageResponse SendRoomNotificationMessageSync(SendRoomNotificationMessageRequest req)
        {
            return InternalRequestAsync<SendRoomNotificationMessageResponse>(req, "SendRoomNotificationMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置应用的自定义内容，包括应用图标，自定义的代码等。如果已存在，则为更新。更新js、css内容后，要生效也需要调用该接口
        /// </summary>
        /// <param name="req"><see cref="SetAppCustomContentRequest"/></param>
        /// <returns><see cref="SetAppCustomContentResponse"/></returns>
        public Task<SetAppCustomContentResponse> SetAppCustomContent(SetAppCustomContentRequest req)
        {
            return InternalRequestAsync<SetAppCustomContentResponse>(req, "SetAppCustomContent");
        }

        /// <summary>
        /// 设置应用的自定义内容，包括应用图标，自定义的代码等。如果已存在，则为更新。更新js、css内容后，要生效也需要调用该接口
        /// </summary>
        /// <param name="req"><see cref="SetAppCustomContentRequest"/></param>
        /// <returns><see cref="SetAppCustomContentResponse"/></returns>
        public SetAppCustomContentResponse SetAppCustomContentSync(SetAppCustomContentRequest req)
        {
            return InternalRequestAsync<SetAppCustomContentResponse>(req, "SetAppCustomContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置水印
        /// </summary>
        /// <param name="req"><see cref="SetWatermarkRequest"/></param>
        /// <returns><see cref="SetWatermarkResponse"/></returns>
        public Task<SetWatermarkResponse> SetWatermark(SetWatermarkRequest req)
        {
            return InternalRequestAsync<SetWatermarkResponse>(req, "SetWatermark");
        }

        /// <summary>
        /// 设置水印
        /// </summary>
        /// <param name="req"><see cref="SetWatermarkRequest"/></param>
        /// <returns><see cref="SetWatermarkResponse"/></returns>
        public SetWatermarkResponse SetWatermarkSync(SetWatermarkRequest req)
        {
            return InternalRequestAsync<SetWatermarkResponse>(req, "SetWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开始房间的直播。 说明：开始房间接口调用之前需要有用户进入课堂初始化课堂信息。
        /// </summary>
        /// <param name="req"><see cref="StartRoomRequest"/></param>
        /// <returns><see cref="StartRoomResponse"/></returns>
        public Task<StartRoomResponse> StartRoom(StartRoomRequest req)
        {
            return InternalRequestAsync<StartRoomResponse>(req, "StartRoom");
        }

        /// <summary>
        /// 开始房间的直播。 说明：开始房间接口调用之前需要有用户进入课堂初始化课堂信息。
        /// </summary>
        /// <param name="req"><see cref="StartRoomRequest"/></param>
        /// <returns><see cref="StartRoomResponse"/></returns>
        public StartRoomResponse StartRoomSync(StartRoomRequest req)
        {
            return InternalRequestAsync<StartRoomResponse>(req, "StartRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文档从房间解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindDocumentFromRoomRequest"/></param>
        /// <returns><see cref="UnbindDocumentFromRoomResponse"/></returns>
        public Task<UnbindDocumentFromRoomResponse> UnbindDocumentFromRoom(UnbindDocumentFromRoomRequest req)
        {
            return InternalRequestAsync<UnbindDocumentFromRoomResponse>(req, "UnbindDocumentFromRoom");
        }

        /// <summary>
        /// 文档从房间解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindDocumentFromRoomRequest"/></param>
        /// <returns><see cref="UnbindDocumentFromRoomResponse"/></returns>
        public UnbindDocumentFromRoomResponse UnbindDocumentFromRoomSync(UnbindDocumentFromRoomRequest req)
        {
            return InternalRequestAsync<UnbindDocumentFromRoomResponse>(req, "UnbindDocumentFromRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解禁从房间里面踢出的用户
        /// </summary>
        /// <param name="req"><see cref="UnblockKickedUserRequest"/></param>
        /// <returns><see cref="UnblockKickedUserResponse"/></returns>
        public Task<UnblockKickedUserResponse> UnblockKickedUser(UnblockKickedUserRequest req)
        {
            return InternalRequestAsync<UnblockKickedUserResponse>(req, "UnblockKickedUser");
        }

        /// <summary>
        /// 解禁从房间里面踢出的用户
        /// </summary>
        /// <param name="req"><see cref="UnblockKickedUserRequest"/></param>
        /// <returns><see cref="UnblockKickedUserResponse"/></returns>
        public UnblockKickedUserResponse UnblockKickedUserSync(UnblockKickedUserRequest req)
        {
            return InternalRequestAsync<UnblockKickedUserResponse>(req, "UnblockKickedUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
