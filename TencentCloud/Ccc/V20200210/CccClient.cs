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

namespace TencentCloud.Ccc.V20200210
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ccc.V20200210.Models;

   public class CccClient : AbstractClient{

       private const string endpoint = "ccc.tencentcloudapi.com";
       private const string version = "2020-02-10";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CccClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CccClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 绑定号码外呼技能组
        /// </summary>
        /// <param name="req"><see cref="BindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="BindNumberCallOutSkillGroupResponse"/></returns>
        public async Task<BindNumberCallOutSkillGroupResponse> BindNumberCallOutSkillGroup(BindNumberCallOutSkillGroupRequest req)
        {
             JsonResponseModel<BindNumberCallOutSkillGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindNumberCallOutSkillGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindNumberCallOutSkillGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定号码外呼技能组
        /// </summary>
        /// <param name="req"><see cref="BindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="BindNumberCallOutSkillGroupResponse"/></returns>
        public BindNumberCallOutSkillGroupResponse BindNumberCallOutSkillGroupSync(BindNumberCallOutSkillGroupRequest req)
        {
             JsonResponseModel<BindNumberCallOutSkillGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindNumberCallOutSkillGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindNumberCallOutSkillGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定座席所属技能组
        /// </summary>
        /// <param name="req"><see cref="BindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="BindStaffSkillGroupListResponse"/></returns>
        public async Task<BindStaffSkillGroupListResponse> BindStaffSkillGroupList(BindStaffSkillGroupListRequest req)
        {
             JsonResponseModel<BindStaffSkillGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindStaffSkillGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindStaffSkillGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定座席所属技能组
        /// </summary>
        /// <param name="req"><see cref="BindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="BindStaffSkillGroupListResponse"/></returns>
        public BindStaffSkillGroupListResponse BindStaffSkillGroupListSync(BindStaffSkillGroupListRequest req)
        {
             JsonResponseModel<BindStaffSkillGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindStaffSkillGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindStaffSkillGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建管理端访问链接
        /// </summary>
        /// <param name="req"><see cref="CreateAdminURLRequest"/></param>
        /// <returns><see cref="CreateAdminURLResponse"/></returns>
        public async Task<CreateAdminURLResponse> CreateAdminURL(CreateAdminURLRequest req)
        {
             JsonResponseModel<CreateAdminURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAdminURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAdminURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建管理端访问链接
        /// </summary>
        /// <param name="req"><see cref="CreateAdminURLRequest"/></param>
        /// <returns><see cref="CreateAdminURLResponse"/></returns>
        public CreateAdminURLResponse CreateAdminURLSync(CreateAdminURLRequest req)
        {
             JsonResponseModel<CreateAdminURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAdminURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAdminURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自动外呼任务
        /// </summary>
        /// <param name="req"><see cref="CreateAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="CreateAutoCalloutTaskResponse"/></returns>
        public async Task<CreateAutoCalloutTaskResponse> CreateAutoCalloutTask(CreateAutoCalloutTaskRequest req)
        {
             JsonResponseModel<CreateAutoCalloutTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAutoCalloutTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoCalloutTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自动外呼任务
        /// </summary>
        /// <param name="req"><see cref="CreateAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="CreateAutoCalloutTaskResponse"/></returns>
        public CreateAutoCalloutTaskResponse CreateAutoCalloutTaskSync(CreateAutoCalloutTaskRequest req)
        {
             JsonResponseModel<CreateAutoCalloutTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAutoCalloutTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoCalloutTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建技能组
        /// </summary>
        /// <param name="req"><see cref="CreateCCCSkillGroupRequest"/></param>
        /// <returns><see cref="CreateCCCSkillGroupResponse"/></returns>
        public async Task<CreateCCCSkillGroupResponse> CreateCCCSkillGroup(CreateCCCSkillGroupRequest req)
        {
             JsonResponseModel<CreateCCCSkillGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCCCSkillGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCCSkillGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建技能组
        /// </summary>
        /// <param name="req"><see cref="CreateCCCSkillGroupRequest"/></param>
        /// <returns><see cref="CreateCCCSkillGroupResponse"/></returns>
        public CreateCCCSkillGroupResponse CreateCCCSkillGroupSync(CreateCCCSkillGroupRequest req)
        {
             JsonResponseModel<CreateCCCSkillGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCCCSkillGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCCSkillGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建外呼会话，当前仅支持双呼，即先使用平台号码呼出到坐席手机上，坐席接听后，然后再外呼用户，而且由于运营商频率限制，坐席手机号必须先加白名单，避免频控导致外呼失败。
        /// </summary>
        /// <param name="req"><see cref="CreateCallOutSessionRequest"/></param>
        /// <returns><see cref="CreateCallOutSessionResponse"/></returns>
        public async Task<CreateCallOutSessionResponse> CreateCallOutSession(CreateCallOutSessionRequest req)
        {
             JsonResponseModel<CreateCallOutSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCallOutSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCallOutSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建外呼会话，当前仅支持双呼，即先使用平台号码呼出到坐席手机上，坐席接听后，然后再外呼用户，而且由于运营商频率限制，坐席手机号必须先加白名单，避免频控导致外呼失败。
        /// </summary>
        /// <param name="req"><see cref="CreateCallOutSessionRequest"/></param>
        /// <returns><see cref="CreateCallOutSessionResponse"/></returns>
        public CreateCallOutSessionResponse CreateCallOutSessionSync(CreateCallOutSessionRequest req)
        {
             JsonResponseModel<CreateCallOutSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCallOutSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCallOutSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于无限频率地呼叫坐席手机
        /// </summary>
        /// <param name="req"><see cref="CreateCarrierPrivilegeNumberApplicantRequest"/></param>
        /// <returns><see cref="CreateCarrierPrivilegeNumberApplicantResponse"/></returns>
        public async Task<CreateCarrierPrivilegeNumberApplicantResponse> CreateCarrierPrivilegeNumberApplicant(CreateCarrierPrivilegeNumberApplicantRequest req)
        {
             JsonResponseModel<CreateCarrierPrivilegeNumberApplicantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCarrierPrivilegeNumberApplicant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCarrierPrivilegeNumberApplicantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于无限频率地呼叫坐席手机
        /// </summary>
        /// <param name="req"><see cref="CreateCarrierPrivilegeNumberApplicantRequest"/></param>
        /// <returns><see cref="CreateCarrierPrivilegeNumberApplicantResponse"/></returns>
        public CreateCarrierPrivilegeNumberApplicantResponse CreateCarrierPrivilegeNumberApplicantSync(CreateCarrierPrivilegeNumberApplicantRequest req)
        {
             JsonResponseModel<CreateCarrierPrivilegeNumberApplicantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCarrierPrivilegeNumberApplicant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCarrierPrivilegeNumberApplicantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建话机账号
        /// </summary>
        /// <param name="req"><see cref="CreateExtensionRequest"/></param>
        /// <returns><see cref="CreateExtensionResponse"/></returns>
        public async Task<CreateExtensionResponse> CreateExtension(CreateExtensionRequest req)
        {
             JsonResponseModel<CreateExtensionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateExtension");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExtensionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建话机账号
        /// </summary>
        /// <param name="req"><see cref="CreateExtensionRequest"/></param>
        /// <returns><see cref="CreateExtensionResponse"/></returns>
        public CreateExtensionResponse CreateExtensionSync(CreateExtensionRequest req)
        {
             JsonResponseModel<CreateExtensionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateExtension");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExtensionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 SDK 登录 Token。
        /// </summary>
        /// <param name="req"><see cref="CreateSDKLoginTokenRequest"/></param>
        /// <returns><see cref="CreateSDKLoginTokenResponse"/></returns>
        public async Task<CreateSDKLoginTokenResponse> CreateSDKLoginToken(CreateSDKLoginTokenRequest req)
        {
             JsonResponseModel<CreateSDKLoginTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSDKLoginToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSDKLoginTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 SDK 登录 Token。
        /// </summary>
        /// <param name="req"><see cref="CreateSDKLoginTokenRequest"/></param>
        /// <returns><see cref="CreateSDKLoginTokenResponse"/></returns>
        public CreateSDKLoginTokenResponse CreateSDKLoginTokenSync(CreateSDKLoginTokenRequest req)
        {
             JsonResponseModel<CreateSDKLoginTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSDKLoginToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSDKLoginTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建客服账号。
        /// </summary>
        /// <param name="req"><see cref="CreateStaffRequest"/></param>
        /// <returns><see cref="CreateStaffResponse"/></returns>
        public async Task<CreateStaffResponse> CreateStaff(CreateStaffRequest req)
        {
             JsonResponseModel<CreateStaffResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStaff");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStaffResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建客服账号。
        /// </summary>
        /// <param name="req"><see cref="CreateStaffRequest"/></param>
        /// <returns><see cref="CreateStaffResponse"/></returns>
        public CreateStaffResponse CreateStaffSync(CreateStaffRequest req)
        {
             JsonResponseModel<CreateStaffResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStaff");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStaffResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户数据签名
        /// </summary>
        /// <param name="req"><see cref="CreateUserSigRequest"/></param>
        /// <returns><see cref="CreateUserSigResponse"/></returns>
        public async Task<CreateUserSigResponse> CreateUserSig(CreateUserSigRequest req)
        {
             JsonResponseModel<CreateUserSigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserSig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserSigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户数据签名
        /// </summary>
        /// <param name="req"><see cref="CreateUserSigRequest"/></param>
        /// <returns><see cref="CreateUserSigResponse"/></returns>
        public CreateUserSigResponse CreateUserSigSync(CreateUserSigRequest req)
        {
             JsonResponseModel<CreateUserSigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUserSig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserSigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除话机账号
        /// </summary>
        /// <param name="req"><see cref="DeleteExtensionRequest"/></param>
        /// <returns><see cref="DeleteExtensionResponse"/></returns>
        public async Task<DeleteExtensionResponse> DeleteExtension(DeleteExtensionRequest req)
        {
             JsonResponseModel<DeleteExtensionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteExtension");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteExtensionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除话机账号
        /// </summary>
        /// <param name="req"><see cref="DeleteExtensionRequest"/></param>
        /// <returns><see cref="DeleteExtensionResponse"/></returns>
        public DeleteExtensionResponse DeleteExtensionSync(DeleteExtensionRequest req)
        {
             JsonResponseModel<DeleteExtensionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteExtension");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteExtensionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除坐席信息
        /// </summary>
        /// <param name="req"><see cref="DeleteStaffRequest"/></param>
        /// <returns><see cref="DeleteStaffResponse"/></returns>
        public async Task<DeleteStaffResponse> DeleteStaff(DeleteStaffRequest req)
        {
             JsonResponseModel<DeleteStaffResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStaff");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStaffResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除坐席信息
        /// </summary>
        /// <param name="req"><see cref="DeleteStaffRequest"/></param>
        /// <returns><see cref="DeleteStaffResponse"/></returns>
        public DeleteStaffResponse DeleteStaffSync(DeleteStaffRequest req)
        {
             JsonResponseModel<DeleteStaffResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStaff");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStaffResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询生效运营商白名单规则
        /// </summary>
        /// <param name="req"><see cref="DescribeActiveCarrierPrivilegeNumberRequest"/></param>
        /// <returns><see cref="DescribeActiveCarrierPrivilegeNumberResponse"/></returns>
        public async Task<DescribeActiveCarrierPrivilegeNumberResponse> DescribeActiveCarrierPrivilegeNumber(DescribeActiveCarrierPrivilegeNumberRequest req)
        {
             JsonResponseModel<DescribeActiveCarrierPrivilegeNumberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeActiveCarrierPrivilegeNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeActiveCarrierPrivilegeNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询生效运营商白名单规则
        /// </summary>
        /// <param name="req"><see cref="DescribeActiveCarrierPrivilegeNumberRequest"/></param>
        /// <returns><see cref="DescribeActiveCarrierPrivilegeNumberResponse"/></returns>
        public DescribeActiveCarrierPrivilegeNumberResponse DescribeActiveCarrierPrivilegeNumberSync(DescribeActiveCarrierPrivilegeNumberRequest req)
        {
             JsonResponseModel<DescribeActiveCarrierPrivilegeNumberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeActiveCarrierPrivilegeNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeActiveCarrierPrivilegeNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自动外呼任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTaskResponse"/></returns>
        public async Task<DescribeAutoCalloutTaskResponse> DescribeAutoCalloutTask(DescribeAutoCalloutTaskRequest req)
        {
             JsonResponseModel<DescribeAutoCalloutTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoCalloutTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoCalloutTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自动外呼任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTaskResponse"/></returns>
        public DescribeAutoCalloutTaskResponse DescribeAutoCalloutTaskSync(DescribeAutoCalloutTaskRequest req)
        {
             JsonResponseModel<DescribeAutoCalloutTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoCalloutTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoCalloutTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量查询自动任务外呼
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTasksRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTasksResponse"/></returns>
        public async Task<DescribeAutoCalloutTasksResponse> DescribeAutoCalloutTasks(DescribeAutoCalloutTasksRequest req)
        {
             JsonResponseModel<DescribeAutoCalloutTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoCalloutTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoCalloutTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量查询自动任务外呼
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTasksRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTasksResponse"/></returns>
        public DescribeAutoCalloutTasksResponse DescribeAutoCalloutTasksSync(DescribeAutoCalloutTasksRequest req)
        {
             JsonResponseModel<DescribeAutoCalloutTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoCalloutTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoCalloutTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户购买信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCCBuyInfoListRequest"/></param>
        /// <returns><see cref="DescribeCCCBuyInfoListResponse"/></returns>
        public async Task<DescribeCCCBuyInfoListResponse> DescribeCCCBuyInfoList(DescribeCCCBuyInfoListRequest req)
        {
             JsonResponseModel<DescribeCCCBuyInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCCBuyInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCCBuyInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户购买信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCCBuyInfoListRequest"/></param>
        /// <returns><see cref="DescribeCCCBuyInfoListResponse"/></returns>
        public DescribeCCCBuyInfoListResponse DescribeCCCBuyInfoListSync(DescribeCCCBuyInfoListRequest req)
        {
             JsonResponseModel<DescribeCCCBuyInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCCBuyInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCCBuyInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取呼入实时数据统计指标
        /// </summary>
        /// <param name="req"><see cref="DescribeCallInMetricsRequest"/></param>
        /// <returns><see cref="DescribeCallInMetricsResponse"/></returns>
        public async Task<DescribeCallInMetricsResponse> DescribeCallInMetrics(DescribeCallInMetricsRequest req)
        {
             JsonResponseModel<DescribeCallInMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCallInMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallInMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取呼入实时数据统计指标
        /// </summary>
        /// <param name="req"><see cref="DescribeCallInMetricsRequest"/></param>
        /// <returns><see cref="DescribeCallInMetricsResponse"/></returns>
        public DescribeCallInMetricsResponse DescribeCallInMetricsSync(DescribeCallInMetricsRequest req)
        {
             JsonResponseModel<DescribeCallInMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCallInMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallInMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCarrierPrivilegeNumberApplicantsRequest"/></param>
        /// <returns><see cref="DescribeCarrierPrivilegeNumberApplicantsResponse"/></returns>
        public async Task<DescribeCarrierPrivilegeNumberApplicantsResponse> DescribeCarrierPrivilegeNumberApplicants(DescribeCarrierPrivilegeNumberApplicantsRequest req)
        {
             JsonResponseModel<DescribeCarrierPrivilegeNumberApplicantsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCarrierPrivilegeNumberApplicants");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCarrierPrivilegeNumberApplicantsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCarrierPrivilegeNumberApplicantsRequest"/></param>
        /// <returns><see cref="DescribeCarrierPrivilegeNumberApplicantsResponse"/></returns>
        public DescribeCarrierPrivilegeNumberApplicantsResponse DescribeCarrierPrivilegeNumberApplicantsSync(DescribeCarrierPrivilegeNumberApplicantsRequest req)
        {
             JsonResponseModel<DescribeCarrierPrivilegeNumberApplicantsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCarrierPrivilegeNumberApplicants");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCarrierPrivilegeNumberApplicantsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定服务记录文本聊天内容，需要先使用查询在线客服记录（DescribeIMCdrs） API 获取服务记录 SessionId。
        /// 
        /// 文本聊天记录只保存了 1 年内的，1 年之前会自动清理。
        /// </summary>
        /// <param name="req"><see cref="DescribeChatMessagesRequest"/></param>
        /// <returns><see cref="DescribeChatMessagesResponse"/></returns>
        public async Task<DescribeChatMessagesResponse> DescribeChatMessages(DescribeChatMessagesRequest req)
        {
             JsonResponseModel<DescribeChatMessagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeChatMessages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChatMessagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定服务记录文本聊天内容，需要先使用查询在线客服记录（DescribeIMCdrs） API 获取服务记录 SessionId。
        /// 
        /// 文本聊天记录只保存了 1 年内的，1 年之前会自动清理。
        /// </summary>
        /// <param name="req"><see cref="DescribeChatMessagesRequest"/></param>
        /// <returns><see cref="DescribeChatMessagesResponse"/></returns>
        public DescribeChatMessagesResponse DescribeChatMessagesSync(DescribeChatMessagesRequest req)
        {
             JsonResponseModel<DescribeChatMessagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeChatMessages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChatMessagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取话机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionRequest"/></param>
        /// <returns><see cref="DescribeExtensionResponse"/></returns>
        public async Task<DescribeExtensionResponse> DescribeExtension(DescribeExtensionRequest req)
        {
             JsonResponseModel<DescribeExtensionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExtension");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtensionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取话机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionRequest"/></param>
        /// <returns><see cref="DescribeExtensionResponse"/></returns>
        public DescribeExtensionResponse DescribeExtensionSync(DescribeExtensionRequest req)
        {
             JsonResponseModel<DescribeExtensionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExtension");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtensionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询话机列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionsRequest"/></param>
        /// <returns><see cref="DescribeExtensionsResponse"/></returns>
        public async Task<DescribeExtensionsResponse> DescribeExtensions(DescribeExtensionsRequest req)
        {
             JsonResponseModel<DescribeExtensionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExtensions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtensionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询话机列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionsRequest"/></param>
        /// <returns><see cref="DescribeExtensionsResponse"/></returns>
        public DescribeExtensionsResponse DescribeExtensionsSync(DescribeExtensionsRequest req)
        {
             JsonResponseModel<DescribeExtensionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExtensions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtensionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取包括全媒体和文本会话两种类型的服务记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeIMCdrsRequest"/></param>
        /// <returns><see cref="DescribeIMCdrsResponse"/></returns>
        public async Task<DescribeIMCdrsResponse> DescribeIMCdrs(DescribeIMCdrsRequest req)
        {
             JsonResponseModel<DescribeIMCdrsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIMCdrs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIMCdrsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取包括全媒体和文本会话两种类型的服务记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeIMCdrsRequest"/></param>
        /// <returns><see cref="DescribeIMCdrsResponse"/></returns>
        public DescribeIMCdrsResponse DescribeIMCdrsSync(DescribeIMCdrsRequest req)
        {
             JsonResponseModel<DescribeIMCdrsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIMCdrs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIMCdrsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询号码列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNumbersRequest"/></param>
        /// <returns><see cref="DescribeNumbersResponse"/></returns>
        public async Task<DescribeNumbersResponse> DescribeNumbers(DescribeNumbersRequest req)
        {
             JsonResponseModel<DescribeNumbersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNumbers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNumbersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询号码列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNumbersRequest"/></param>
        /// <returns><see cref="DescribeNumbersResponse"/></returns>
        public DescribeNumbersResponse DescribeNumbersSync(DescribeNumbersRequest req)
        {
             JsonResponseModel<DescribeNumbersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNumbers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNumbersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前正在通话的会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribePSTNActiveSessionListRequest"/></param>
        /// <returns><see cref="DescribePSTNActiveSessionListResponse"/></returns>
        public async Task<DescribePSTNActiveSessionListResponse> DescribePSTNActiveSessionList(DescribePSTNActiveSessionListRequest req)
        {
             JsonResponseModel<DescribePSTNActiveSessionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePSTNActiveSessionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePSTNActiveSessionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前正在通话的会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribePSTNActiveSessionListRequest"/></param>
        /// <returns><see cref="DescribePSTNActiveSessionListResponse"/></returns>
        public DescribePSTNActiveSessionListResponse DescribePSTNActiveSessionListSync(DescribePSTNActiveSessionListRequest req)
        {
             JsonResponseModel<DescribePSTNActiveSessionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePSTNActiveSessionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePSTNActiveSessionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主被叫受保护的电话服务记录与录音
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectedTelCdrRequest"/></param>
        /// <returns><see cref="DescribeProtectedTelCdrResponse"/></returns>
        public async Task<DescribeProtectedTelCdrResponse> DescribeProtectedTelCdr(DescribeProtectedTelCdrRequest req)
        {
             JsonResponseModel<DescribeProtectedTelCdrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProtectedTelCdr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProtectedTelCdrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主被叫受保护的电话服务记录与录音
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectedTelCdrRequest"/></param>
        /// <returns><see cref="DescribeProtectedTelCdrResponse"/></returns>
        public DescribeProtectedTelCdrResponse DescribeProtectedTelCdrSync(DescribeProtectedTelCdrRequest req)
        {
             JsonResponseModel<DescribeProtectedTelCdrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProtectedTelCdr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProtectedTelCdrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取技能组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillGroupInfoListRequest"/></param>
        /// <returns><see cref="DescribeSkillGroupInfoListResponse"/></returns>
        public async Task<DescribeSkillGroupInfoListResponse> DescribeSkillGroupInfoList(DescribeSkillGroupInfoListRequest req)
        {
             JsonResponseModel<DescribeSkillGroupInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSkillGroupInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSkillGroupInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取技能组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillGroupInfoListRequest"/></param>
        /// <returns><see cref="DescribeSkillGroupInfoListResponse"/></returns>
        public DescribeSkillGroupInfoListResponse DescribeSkillGroupInfoListSync(DescribeSkillGroupInfoListRequest req)
        {
             JsonResponseModel<DescribeSkillGroupInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSkillGroupInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSkillGroupInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取坐席信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffInfoListRequest"/></param>
        /// <returns><see cref="DescribeStaffInfoListResponse"/></returns>
        public async Task<DescribeStaffInfoListResponse> DescribeStaffInfoList(DescribeStaffInfoListRequest req)
        {
             JsonResponseModel<DescribeStaffInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStaffInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStaffInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取坐席信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffInfoListRequest"/></param>
        /// <returns><see cref="DescribeStaffInfoListResponse"/></returns>
        public DescribeStaffInfoListResponse DescribeStaffInfoListSync(DescribeStaffInfoListRequest req)
        {
             JsonResponseModel<DescribeStaffInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStaffInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStaffInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取坐席实时状态统计指标
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffStatusMetricsRequest"/></param>
        /// <returns><see cref="DescribeStaffStatusMetricsResponse"/></returns>
        public async Task<DescribeStaffStatusMetricsResponse> DescribeStaffStatusMetrics(DescribeStaffStatusMetricsRequest req)
        {
             JsonResponseModel<DescribeStaffStatusMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStaffStatusMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStaffStatusMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取坐席实时状态统计指标
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffStatusMetricsRequest"/></param>
        /// <returns><see cref="DescribeStaffStatusMetricsResponse"/></returns>
        public DescribeStaffStatusMetricsResponse DescribeStaffStatusMetricsSync(DescribeStaffStatusMetricsRequest req)
        {
             JsonResponseModel<DescribeStaffStatusMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStaffStatusMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStaffStatusMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按实例获取电话消耗统计
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCallInfoRequest"/></param>
        /// <returns><see cref="DescribeTelCallInfoResponse"/></returns>
        public async Task<DescribeTelCallInfoResponse> DescribeTelCallInfo(DescribeTelCallInfoRequest req)
        {
             JsonResponseModel<DescribeTelCallInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTelCallInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTelCallInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按实例获取电话消耗统计
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCallInfoRequest"/></param>
        /// <returns><see cref="DescribeTelCallInfoResponse"/></returns>
        public DescribeTelCallInfoResponse DescribeTelCallInfoSync(DescribeTelCallInfoRequest req)
        {
             JsonResponseModel<DescribeTelCallInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTelCallInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTelCallInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取电话服务记录与录音
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCdrRequest"/></param>
        /// <returns><see cref="DescribeTelCdrResponse"/></returns>
        public async Task<DescribeTelCdrResponse> DescribeTelCdr(DescribeTelCdrRequest req)
        {
             JsonResponseModel<DescribeTelCdrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTelCdr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTelCdrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取电话服务记录与录音
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCdrRequest"/></param>
        /// <returns><see cref="DescribeTelCdrResponse"/></returns>
        public DescribeTelCdrResponse DescribeTelCdrSync(DescribeTelCdrRequest req)
        {
             JsonResponseModel<DescribeTelCdrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTelCdr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTelCdrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取 PSTN 会话信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTelSessionRequest"/></param>
        /// <returns><see cref="DescribeTelSessionResponse"/></returns>
        public async Task<DescribeTelSessionResponse> DescribeTelSession(DescribeTelSessionRequest req)
        {
             JsonResponseModel<DescribeTelSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTelSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTelSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取 PSTN 会话信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTelSessionRequest"/></param>
        /// <returns><see cref="DescribeTelSessionResponse"/></returns>
        public DescribeTelSessionResponse DescribeTelSessionSync(DescribeTelSessionRequest req)
        {
             JsonResponseModel<DescribeTelSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTelSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTelSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停用号码
        /// </summary>
        /// <param name="req"><see cref="DisableCCCPhoneNumberRequest"/></param>
        /// <returns><see cref="DisableCCCPhoneNumberResponse"/></returns>
        public async Task<DisableCCCPhoneNumberResponse> DisableCCCPhoneNumber(DisableCCCPhoneNumberRequest req)
        {
             JsonResponseModel<DisableCCCPhoneNumberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableCCCPhoneNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCCCPhoneNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停用号码
        /// </summary>
        /// <param name="req"><see cref="DisableCCCPhoneNumberRequest"/></param>
        /// <returns><see cref="DisableCCCPhoneNumberResponse"/></returns>
        public DisableCCCPhoneNumberResponse DisableCCCPhoneNumberSync(DisableCCCPhoneNumberRequest req)
        {
             JsonResponseModel<DisableCCCPhoneNumberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableCCCPhoneNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCCCPhoneNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 挂断电话
        /// </summary>
        /// <param name="req"><see cref="HangUpCallRequest"/></param>
        /// <returns><see cref="HangUpCallResponse"/></returns>
        public async Task<HangUpCallResponse> HangUpCall(HangUpCallRequest req)
        {
             JsonResponseModel<HangUpCallResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HangUpCall");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HangUpCallResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 挂断电话
        /// </summary>
        /// <param name="req"><see cref="HangUpCallRequest"/></param>
        /// <returns><see cref="HangUpCallResponse"/></returns>
        public HangUpCallResponse HangUpCallSync(HangUpCallRequest req)
        {
             JsonResponseModel<HangUpCallResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "HangUpCall");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HangUpCallResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改话机账号(绑定技能组、绑定坐席账号)
        /// </summary>
        /// <param name="req"><see cref="ModifyExtensionRequest"/></param>
        /// <returns><see cref="ModifyExtensionResponse"/></returns>
        public async Task<ModifyExtensionResponse> ModifyExtension(ModifyExtensionRequest req)
        {
             JsonResponseModel<ModifyExtensionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyExtension");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyExtensionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改话机账号(绑定技能组、绑定坐席账号)
        /// </summary>
        /// <param name="req"><see cref="ModifyExtensionRequest"/></param>
        /// <returns><see cref="ModifyExtensionResponse"/></returns>
        public ModifyExtensionResponse ModifyExtensionSync(ModifyExtensionRequest req)
        {
             JsonResponseModel<ModifyExtensionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyExtension");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyExtensionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改客服账号
        /// </summary>
        /// <param name="req"><see cref="ModifyStaffRequest"/></param>
        /// <returns><see cref="ModifyStaffResponse"/></returns>
        public async Task<ModifyStaffResponse> ModifyStaff(ModifyStaffRequest req)
        {
             JsonResponseModel<ModifyStaffResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStaff");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStaffResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改客服账号
        /// </summary>
        /// <param name="req"><see cref="ModifyStaffRequest"/></param>
        /// <returns><see cref="ModifyStaffResponse"/></returns>
        public ModifyStaffResponse ModifyStaffSync(ModifyStaffRequest req)
        {
             JsonResponseModel<ModifyStaffResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStaff");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStaffResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置话机注册密码
        /// </summary>
        /// <param name="req"><see cref="ResetExtensionPasswordRequest"/></param>
        /// <returns><see cref="ResetExtensionPasswordResponse"/></returns>
        public async Task<ResetExtensionPasswordResponse> ResetExtensionPassword(ResetExtensionPasswordRequest req)
        {
             JsonResponseModel<ResetExtensionPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetExtensionPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetExtensionPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置话机注册密码
        /// </summary>
        /// <param name="req"><see cref="ResetExtensionPasswordRequest"/></param>
        /// <returns><see cref="ResetExtensionPasswordResponse"/></returns>
        public ResetExtensionPasswordResponse ResetExtensionPasswordSync(ResetExtensionPasswordRequest req)
        {
             JsonResponseModel<ResetExtensionPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetExtensionPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetExtensionPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止自动外呼任务
        /// </summary>
        /// <param name="req"><see cref="StopAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="StopAutoCalloutTaskResponse"/></returns>
        public async Task<StopAutoCalloutTaskResponse> StopAutoCalloutTask(StopAutoCalloutTaskRequest req)
        {
             JsonResponseModel<StopAutoCalloutTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopAutoCalloutTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopAutoCalloutTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止自动外呼任务
        /// </summary>
        /// <param name="req"><see cref="StopAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="StopAutoCalloutTaskResponse"/></returns>
        public StopAutoCalloutTaskResponse StopAutoCalloutTaskSync(StopAutoCalloutTaskRequest req)
        {
             JsonResponseModel<StopAutoCalloutTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopAutoCalloutTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopAutoCalloutTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑号码外呼技能组
        /// </summary>
        /// <param name="req"><see cref="UnbindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="UnbindNumberCallOutSkillGroupResponse"/></returns>
        public async Task<UnbindNumberCallOutSkillGroupResponse> UnbindNumberCallOutSkillGroup(UnbindNumberCallOutSkillGroupRequest req)
        {
             JsonResponseModel<UnbindNumberCallOutSkillGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindNumberCallOutSkillGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindNumberCallOutSkillGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑号码外呼技能组
        /// </summary>
        /// <param name="req"><see cref="UnbindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="UnbindNumberCallOutSkillGroupResponse"/></returns>
        public UnbindNumberCallOutSkillGroupResponse UnbindNumberCallOutSkillGroupSync(UnbindNumberCallOutSkillGroupRequest req)
        {
             JsonResponseModel<UnbindNumberCallOutSkillGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindNumberCallOutSkillGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindNumberCallOutSkillGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑坐席所属技能组
        /// </summary>
        /// <param name="req"><see cref="UnbindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="UnbindStaffSkillGroupListResponse"/></returns>
        public async Task<UnbindStaffSkillGroupListResponse> UnbindStaffSkillGroupList(UnbindStaffSkillGroupListRequest req)
        {
             JsonResponseModel<UnbindStaffSkillGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindStaffSkillGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindStaffSkillGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑坐席所属技能组
        /// </summary>
        /// <param name="req"><see cref="UnbindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="UnbindStaffSkillGroupListResponse"/></returns>
        public UnbindStaffSkillGroupListResponse UnbindStaffSkillGroupListSync(UnbindStaffSkillGroupListRequest req)
        {
             JsonResponseModel<UnbindStaffSkillGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindStaffSkillGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindStaffSkillGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
