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
       private const string sdkVersion = "SDK_NET_3.0.1183";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CccClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 停止预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="AbortPredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="AbortPredictiveDialingCampaignResponse"/></returns>
        public Task<AbortPredictiveDialingCampaignResponse> AbortPredictiveDialingCampaign(AbortPredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<AbortPredictiveDialingCampaignResponse>(req, "AbortPredictiveDialingCampaign");
        }

        /// <summary>
        /// 停止预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="AbortPredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="AbortPredictiveDialingCampaignResponse"/></returns>
        public AbortPredictiveDialingCampaignResponse AbortPredictiveDialingCampaignSync(AbortPredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<AbortPredictiveDialingCampaignResponse>(req, "AbortPredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定号码外呼技能组
        /// </summary>
        /// <param name="req"><see cref="BindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="BindNumberCallOutSkillGroupResponse"/></returns>
        public Task<BindNumberCallOutSkillGroupResponse> BindNumberCallOutSkillGroup(BindNumberCallOutSkillGroupRequest req)
        {
            return InternalRequestAsync<BindNumberCallOutSkillGroupResponse>(req, "BindNumberCallOutSkillGroup");
        }

        /// <summary>
        /// 绑定号码外呼技能组
        /// </summary>
        /// <param name="req"><see cref="BindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="BindNumberCallOutSkillGroupResponse"/></returns>
        public BindNumberCallOutSkillGroupResponse BindNumberCallOutSkillGroupSync(BindNumberCallOutSkillGroupRequest req)
        {
            return InternalRequestAsync<BindNumberCallOutSkillGroupResponse>(req, "BindNumberCallOutSkillGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定座席所属技能组
        /// </summary>
        /// <param name="req"><see cref="BindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="BindStaffSkillGroupListResponse"/></returns>
        public Task<BindStaffSkillGroupListResponse> BindStaffSkillGroupList(BindStaffSkillGroupListRequest req)
        {
            return InternalRequestAsync<BindStaffSkillGroupListResponse>(req, "BindStaffSkillGroupList");
        }

        /// <summary>
        /// 绑定座席所属技能组
        /// </summary>
        /// <param name="req"><see cref="BindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="BindStaffSkillGroupListResponse"/></returns>
        public BindStaffSkillGroupListResponse BindStaffSkillGroupListSync(BindStaffSkillGroupListRequest req)
        {
            return InternalRequestAsync<BindStaffSkillGroupListResponse>(req, "BindStaffSkillGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于调用AI模型发起外呼通话，仅限自有电话号码使用，目前开通高级版座席**限时**免费体验。
        /// 
        /// 发起通话前，请先确认您的AI模型是否兼容 OpenAI、Azure 或 Minimax 协议，并前往模型服务商网站获取相关鉴权信息。 具体功能说明请参考文档 [腾讯云联络中心AI通话平台](https://cloud.tencent.com/document/product/679/112100)。
        /// </summary>
        /// <param name="req"><see cref="CreateAIAgentCallRequest"/></param>
        /// <returns><see cref="CreateAIAgentCallResponse"/></returns>
        public Task<CreateAIAgentCallResponse> CreateAIAgentCall(CreateAIAgentCallRequest req)
        {
            return InternalRequestAsync<CreateAIAgentCallResponse>(req, "CreateAIAgentCall");
        }

        /// <summary>
        /// 用于调用AI模型发起外呼通话，仅限自有电话号码使用，目前开通高级版座席**限时**免费体验。
        /// 
        /// 发起通话前，请先确认您的AI模型是否兼容 OpenAI、Azure 或 Minimax 协议，并前往模型服务商网站获取相关鉴权信息。 具体功能说明请参考文档 [腾讯云联络中心AI通话平台](https://cloud.tencent.com/document/product/679/112100)。
        /// </summary>
        /// <param name="req"><see cref="CreateAIAgentCallRequest"/></param>
        /// <returns><see cref="CreateAIAgentCallResponse"/></returns>
        public CreateAIAgentCallResponse CreateAIAgentCallSync(CreateAIAgentCallRequest req)
        {
            return InternalRequestAsync<CreateAIAgentCallResponse>(req, "CreateAIAgentCall")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于调用AI模型发起外呼通话，仅限自有电话号码使用，目前开通高级版座席**限时**免费体验。
        /// 
        /// 发起通话前，请先确认您的AI模型是否兼容 OpenAI、Azure 或 Minimax 协议，并前往模型服务商网站获取相关鉴权信息。 具体功能说明请参考文档 [腾讯云联络中心AI通话平台](https://cloud.tencent.com/document/product/679/112100)。
        /// </summary>
        /// <param name="req"><see cref="CreateAICallRequest"/></param>
        /// <returns><see cref="CreateAICallResponse"/></returns>
        public Task<CreateAICallResponse> CreateAICall(CreateAICallRequest req)
        {
            return InternalRequestAsync<CreateAICallResponse>(req, "CreateAICall");
        }

        /// <summary>
        /// 用于调用AI模型发起外呼通话，仅限自有电话号码使用，目前开通高级版座席**限时**免费体验。
        /// 
        /// 发起通话前，请先确认您的AI模型是否兼容 OpenAI、Azure 或 Minimax 协议，并前往模型服务商网站获取相关鉴权信息。 具体功能说明请参考文档 [腾讯云联络中心AI通话平台](https://cloud.tencent.com/document/product/679/112100)。
        /// </summary>
        /// <param name="req"><see cref="CreateAICallRequest"/></param>
        /// <returns><see cref="CreateAICallResponse"/></returns>
        public CreateAICallResponse CreateAICallSync(CreateAICallRequest req)
        {
            return InternalRequestAsync<CreateAICallResponse>(req, "CreateAICall")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建管理端访问链接
        /// </summary>
        /// <param name="req"><see cref="CreateAdminURLRequest"/></param>
        /// <returns><see cref="CreateAdminURLResponse"/></returns>
        public Task<CreateAdminURLResponse> CreateAdminURL(CreateAdminURLRequest req)
        {
            return InternalRequestAsync<CreateAdminURLResponse>(req, "CreateAdminURL");
        }

        /// <summary>
        /// 创建管理端访问链接
        /// </summary>
        /// <param name="req"><see cref="CreateAdminURLRequest"/></param>
        /// <returns><see cref="CreateAdminURLResponse"/></returns>
        public CreateAdminURLResponse CreateAdminURLSync(CreateAdminURLRequest req)
        {
            return InternalRequestAsync<CreateAdminURLResponse>(req, "CreateAdminURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建自动外呼任务
        /// </summary>
        /// <param name="req"><see cref="CreateAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="CreateAutoCalloutTaskResponse"/></returns>
        public Task<CreateAutoCalloutTaskResponse> CreateAutoCalloutTask(CreateAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<CreateAutoCalloutTaskResponse>(req, "CreateAutoCalloutTask");
        }

        /// <summary>
        /// 创建自动外呼任务
        /// </summary>
        /// <param name="req"><see cref="CreateAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="CreateAutoCalloutTaskResponse"/></returns>
        public CreateAutoCalloutTaskResponse CreateAutoCalloutTaskSync(CreateAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<CreateAutoCalloutTaskResponse>(req, "CreateAutoCalloutTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建技能组
        /// </summary>
        /// <param name="req"><see cref="CreateCCCSkillGroupRequest"/></param>
        /// <returns><see cref="CreateCCCSkillGroupResponse"/></returns>
        public Task<CreateCCCSkillGroupResponse> CreateCCCSkillGroup(CreateCCCSkillGroupRequest req)
        {
            return InternalRequestAsync<CreateCCCSkillGroupResponse>(req, "CreateCCCSkillGroup");
        }

        /// <summary>
        /// 新建技能组
        /// </summary>
        /// <param name="req"><see cref="CreateCCCSkillGroupRequest"/></param>
        /// <returns><see cref="CreateCCCSkillGroupResponse"/></returns>
        public CreateCCCSkillGroupResponse CreateCCCSkillGroupSync(CreateCCCSkillGroupRequest req)
        {
            return InternalRequestAsync<CreateCCCSkillGroupResponse>(req, "CreateCCCSkillGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建外呼会话，当前仅支持双呼，即先使用平台号码呼出到坐席手机上，坐席接听后，然后再外呼用户，而且由于运营商频率限制，坐席手机号必须先加白名单，避免频控导致外呼失败。
        /// </summary>
        /// <param name="req"><see cref="CreateCallOutSessionRequest"/></param>
        /// <returns><see cref="CreateCallOutSessionResponse"/></returns>
        public Task<CreateCallOutSessionResponse> CreateCallOutSession(CreateCallOutSessionRequest req)
        {
            return InternalRequestAsync<CreateCallOutSessionResponse>(req, "CreateCallOutSession");
        }

        /// <summary>
        /// 创建外呼会话，当前仅支持双呼，即先使用平台号码呼出到坐席手机上，坐席接听后，然后再外呼用户，而且由于运营商频率限制，坐席手机号必须先加白名单，避免频控导致外呼失败。
        /// </summary>
        /// <param name="req"><see cref="CreateCallOutSessionRequest"/></param>
        /// <returns><see cref="CreateCallOutSessionResponse"/></returns>
        public CreateCallOutSessionResponse CreateCallOutSessionSync(CreateCallOutSessionRequest req)
        {
            return InternalRequestAsync<CreateCallOutSessionResponse>(req, "CreateCallOutSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于无限频率地呼叫坐席手机
        /// </summary>
        /// <param name="req"><see cref="CreateCarrierPrivilegeNumberApplicantRequest"/></param>
        /// <returns><see cref="CreateCarrierPrivilegeNumberApplicantResponse"/></returns>
        public Task<CreateCarrierPrivilegeNumberApplicantResponse> CreateCarrierPrivilegeNumberApplicant(CreateCarrierPrivilegeNumberApplicantRequest req)
        {
            return InternalRequestAsync<CreateCarrierPrivilegeNumberApplicantResponse>(req, "CreateCarrierPrivilegeNumberApplicant");
        }

        /// <summary>
        /// 用于无限频率地呼叫坐席手机
        /// </summary>
        /// <param name="req"><see cref="CreateCarrierPrivilegeNumberApplicantRequest"/></param>
        /// <returns><see cref="CreateCarrierPrivilegeNumberApplicantResponse"/></returns>
        public CreateCarrierPrivilegeNumberApplicantResponse CreateCarrierPrivilegeNumberApplicantSync(CreateCarrierPrivilegeNumberApplicantRequest req)
        {
            return InternalRequestAsync<CreateCarrierPrivilegeNumberApplicantResponse>(req, "CreateCarrierPrivilegeNumberApplicant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建公司资质申请（1、首次使用接口，建议先在云联络中心控制台查看各个资料模板:https://console.cloud.tencent.com/ccc/enterprise/update。2、参数中图片Url建议使用腾讯云Cos存储的临时链接）
        /// </summary>
        /// <param name="req"><see cref="CreateCompanyApplyRequest"/></param>
        /// <returns><see cref="CreateCompanyApplyResponse"/></returns>
        public Task<CreateCompanyApplyResponse> CreateCompanyApply(CreateCompanyApplyRequest req)
        {
            return InternalRequestAsync<CreateCompanyApplyResponse>(req, "CreateCompanyApply");
        }

        /// <summary>
        /// 创建公司资质申请（1、首次使用接口，建议先在云联络中心控制台查看各个资料模板:https://console.cloud.tencent.com/ccc/enterprise/update。2、参数中图片Url建议使用腾讯云Cos存储的临时链接）
        /// </summary>
        /// <param name="req"><see cref="CreateCompanyApplyRequest"/></param>
        /// <returns><see cref="CreateCompanyApplyResponse"/></returns>
        public CreateCompanyApplyResponse CreateCompanyApplySync(CreateCompanyApplyRequest req)
        {
            return InternalRequestAsync<CreateCompanyApplyResponse>(req, "CreateCompanyApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建话机账号
        /// </summary>
        /// <param name="req"><see cref="CreateExtensionRequest"/></param>
        /// <returns><see cref="CreateExtensionResponse"/></returns>
        public Task<CreateExtensionResponse> CreateExtension(CreateExtensionRequest req)
        {
            return InternalRequestAsync<CreateExtensionResponse>(req, "CreateExtension");
        }

        /// <summary>
        /// 创建话机账号
        /// </summary>
        /// <param name="req"><see cref="CreateExtensionRequest"/></param>
        /// <returns><see cref="CreateExtensionResponse"/></returns>
        public CreateExtensionResponse CreateExtensionSync(CreateExtensionRequest req)
        {
            return InternalRequestAsync<CreateExtensionResponse>(req, "CreateExtension")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建关联 IVR 的会话，仅高级版支持，目前支持呼入和自动外呼两种 IVR 类型。收到请求后 TCCC 会先尝试呼通被叫，然后进入 IVR 流程。
        /// </summary>
        /// <param name="req"><see cref="CreateIVRSessionRequest"/></param>
        /// <returns><see cref="CreateIVRSessionResponse"/></returns>
        public Task<CreateIVRSessionResponse> CreateIVRSession(CreateIVRSessionRequest req)
        {
            return InternalRequestAsync<CreateIVRSessionResponse>(req, "CreateIVRSession");
        }

        /// <summary>
        /// 创建关联 IVR 的会话，仅高级版支持，目前支持呼入和自动外呼两种 IVR 类型。收到请求后 TCCC 会先尝试呼通被叫，然后进入 IVR 流程。
        /// </summary>
        /// <param name="req"><see cref="CreateIVRSessionRequest"/></param>
        /// <returns><see cref="CreateIVRSessionResponse"/></returns>
        public CreateIVRSessionResponse CreateIVRSessionSync(CreateIVRSessionRequest req)
        {
            return InternalRequestAsync<CreateIVRSessionResponse>(req, "CreateIVRSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建客户自携号码接入审核
        /// </summary>
        /// <param name="req"><see cref="CreateOwnNumberApplyRequest"/></param>
        /// <returns><see cref="CreateOwnNumberApplyResponse"/></returns>
        public Task<CreateOwnNumberApplyResponse> CreateOwnNumberApply(CreateOwnNumberApplyRequest req)
        {
            return InternalRequestAsync<CreateOwnNumberApplyResponse>(req, "CreateOwnNumberApply");
        }

        /// <summary>
        /// 创建客户自携号码接入审核
        /// </summary>
        /// <param name="req"><see cref="CreateOwnNumberApplyRequest"/></param>
        /// <returns><see cref="CreateOwnNumberApplyResponse"/></returns>
        public CreateOwnNumberApplyResponse CreateOwnNumberApplySync(CreateOwnNumberApplyRequest req)
        {
            return InternalRequestAsync<CreateOwnNumberApplyResponse>(req, "CreateOwnNumberApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="CreatePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="CreatePredictiveDialingCampaignResponse"/></returns>
        public Task<CreatePredictiveDialingCampaignResponse> CreatePredictiveDialingCampaign(CreatePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<CreatePredictiveDialingCampaignResponse>(req, "CreatePredictiveDialingCampaign");
        }

        /// <summary>
        /// 创建预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="CreatePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="CreatePredictiveDialingCampaignResponse"/></returns>
        public CreatePredictiveDialingCampaignResponse CreatePredictiveDialingCampaignSync(CreatePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<CreatePredictiveDialingCampaignResponse>(req, "CreatePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 SDK 登录 Token。
        /// </summary>
        /// <param name="req"><see cref="CreateSDKLoginTokenRequest"/></param>
        /// <returns><see cref="CreateSDKLoginTokenResponse"/></returns>
        public Task<CreateSDKLoginTokenResponse> CreateSDKLoginToken(CreateSDKLoginTokenRequest req)
        {
            return InternalRequestAsync<CreateSDKLoginTokenResponse>(req, "CreateSDKLoginToken");
        }

        /// <summary>
        /// 创建 SDK 登录 Token。
        /// </summary>
        /// <param name="req"><see cref="CreateSDKLoginTokenRequest"/></param>
        /// <returns><see cref="CreateSDKLoginTokenResponse"/></returns>
        public CreateSDKLoginTokenResponse CreateSDKLoginTokenSync(CreateSDKLoginTokenRequest req)
        {
            return InternalRequestAsync<CreateSDKLoginTokenResponse>(req, "CreateSDKLoginToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建客服账号。
        /// </summary>
        /// <param name="req"><see cref="CreateStaffRequest"/></param>
        /// <returns><see cref="CreateStaffResponse"/></returns>
        public Task<CreateStaffResponse> CreateStaff(CreateStaffRequest req)
        {
            return InternalRequestAsync<CreateStaffResponse>(req, "CreateStaff");
        }

        /// <summary>
        /// 创建客服账号。
        /// </summary>
        /// <param name="req"><see cref="CreateStaffRequest"/></param>
        /// <returns><see cref="CreateStaffResponse"/></returns>
        public CreateStaffResponse CreateStaffSync(CreateStaffRequest req)
        {
            return InternalRequestAsync<CreateStaffResponse>(req, "CreateStaff")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户数据签名
        /// </summary>
        /// <param name="req"><see cref="CreateUserSigRequest"/></param>
        /// <returns><see cref="CreateUserSigResponse"/></returns>
        public Task<CreateUserSigResponse> CreateUserSig(CreateUserSigRequest req)
        {
            return InternalRequestAsync<CreateUserSigResponse>(req, "CreateUserSig");
        }

        /// <summary>
        /// 创建用户数据签名
        /// </summary>
        /// <param name="req"><see cref="CreateUserSigRequest"/></param>
        /// <returns><see cref="CreateUserSigResponse"/></returns>
        public CreateUserSigResponse CreateUserSigSync(CreateUserSigRequest req)
        {
            return InternalRequestAsync<CreateUserSigResponse>(req, "CreateUserSig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除话机账号
        /// </summary>
        /// <param name="req"><see cref="DeleteExtensionRequest"/></param>
        /// <returns><see cref="DeleteExtensionResponse"/></returns>
        public Task<DeleteExtensionResponse> DeleteExtension(DeleteExtensionRequest req)
        {
            return InternalRequestAsync<DeleteExtensionResponse>(req, "DeleteExtension");
        }

        /// <summary>
        /// 删除话机账号
        /// </summary>
        /// <param name="req"><see cref="DeleteExtensionRequest"/></param>
        /// <returns><see cref="DeleteExtensionResponse"/></returns>
        public DeleteExtensionResponse DeleteExtensionSync(DeleteExtensionRequest req)
        {
            return InternalRequestAsync<DeleteExtensionResponse>(req, "DeleteExtension")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="DeletePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="DeletePredictiveDialingCampaignResponse"/></returns>
        public Task<DeletePredictiveDialingCampaignResponse> DeletePredictiveDialingCampaign(DeletePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<DeletePredictiveDialingCampaignResponse>(req, "DeletePredictiveDialingCampaign");
        }

        /// <summary>
        /// 删除预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="DeletePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="DeletePredictiveDialingCampaignResponse"/></returns>
        public DeletePredictiveDialingCampaignResponse DeletePredictiveDialingCampaignSync(DeletePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<DeletePredictiveDialingCampaignResponse>(req, "DeletePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除坐席信息
        /// </summary>
        /// <param name="req"><see cref="DeleteStaffRequest"/></param>
        /// <returns><see cref="DeleteStaffResponse"/></returns>
        public Task<DeleteStaffResponse> DeleteStaff(DeleteStaffRequest req)
        {
            return InternalRequestAsync<DeleteStaffResponse>(req, "DeleteStaff");
        }

        /// <summary>
        /// 删除坐席信息
        /// </summary>
        /// <param name="req"><see cref="DeleteStaffRequest"/></param>
        /// <returns><see cref="DeleteStaffResponse"/></returns>
        public DeleteStaffResponse DeleteStaffSync(DeleteStaffRequest req)
        {
            return InternalRequestAsync<DeleteStaffResponse>(req, "DeleteStaff")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 AI 通话内容提取结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeAICallExtractResultRequest"/></param>
        /// <returns><see cref="DescribeAICallExtractResultResponse"/></returns>
        public Task<DescribeAICallExtractResultResponse> DescribeAICallExtractResult(DescribeAICallExtractResultRequest req)
        {
            return InternalRequestAsync<DescribeAICallExtractResultResponse>(req, "DescribeAICallExtractResult");
        }

        /// <summary>
        /// 获取 AI 通话内容提取结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeAICallExtractResultRequest"/></param>
        /// <returns><see cref="DescribeAICallExtractResultResponse"/></returns>
        public DescribeAICallExtractResultResponse DescribeAICallExtractResultSync(DescribeAICallExtractResultRequest req)
        {
            return InternalRequestAsync<DescribeAICallExtractResultResponse>(req, "DescribeAICallExtractResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询生效运营商白名单规则
        /// </summary>
        /// <param name="req"><see cref="DescribeActiveCarrierPrivilegeNumberRequest"/></param>
        /// <returns><see cref="DescribeActiveCarrierPrivilegeNumberResponse"/></returns>
        public Task<DescribeActiveCarrierPrivilegeNumberResponse> DescribeActiveCarrierPrivilegeNumber(DescribeActiveCarrierPrivilegeNumberRequest req)
        {
            return InternalRequestAsync<DescribeActiveCarrierPrivilegeNumberResponse>(req, "DescribeActiveCarrierPrivilegeNumber");
        }

        /// <summary>
        /// 查询生效运营商白名单规则
        /// </summary>
        /// <param name="req"><see cref="DescribeActiveCarrierPrivilegeNumberRequest"/></param>
        /// <returns><see cref="DescribeActiveCarrierPrivilegeNumberResponse"/></returns>
        public DescribeActiveCarrierPrivilegeNumberResponse DescribeActiveCarrierPrivilegeNumberSync(DescribeActiveCarrierPrivilegeNumberRequest req)
        {
            return InternalRequestAsync<DescribeActiveCarrierPrivilegeNumberResponse>(req, "DescribeActiveCarrierPrivilegeNumber")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询自动外呼任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTaskResponse"/></returns>
        public Task<DescribeAutoCalloutTaskResponse> DescribeAutoCalloutTask(DescribeAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<DescribeAutoCalloutTaskResponse>(req, "DescribeAutoCalloutTask");
        }

        /// <summary>
        /// 查询自动外呼任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTaskResponse"/></returns>
        public DescribeAutoCalloutTaskResponse DescribeAutoCalloutTaskSync(DescribeAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<DescribeAutoCalloutTaskResponse>(req, "DescribeAutoCalloutTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量查询自动外呼任务
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTasksRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTasksResponse"/></returns>
        public Task<DescribeAutoCalloutTasksResponse> DescribeAutoCalloutTasks(DescribeAutoCalloutTasksRequest req)
        {
            return InternalRequestAsync<DescribeAutoCalloutTasksResponse>(req, "DescribeAutoCalloutTasks");
        }

        /// <summary>
        /// 批量查询自动外呼任务
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoCalloutTasksRequest"/></param>
        /// <returns><see cref="DescribeAutoCalloutTasksResponse"/></returns>
        public DescribeAutoCalloutTasksResponse DescribeAutoCalloutTasksSync(DescribeAutoCalloutTasksRequest req)
        {
            return InternalRequestAsync<DescribeAutoCalloutTasksResponse>(req, "DescribeAutoCalloutTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户购买信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCCBuyInfoListRequest"/></param>
        /// <returns><see cref="DescribeCCCBuyInfoListResponse"/></returns>
        public Task<DescribeCCCBuyInfoListResponse> DescribeCCCBuyInfoList(DescribeCCCBuyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeCCCBuyInfoListResponse>(req, "DescribeCCCBuyInfoList");
        }

        /// <summary>
        /// 获取用户购买信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCCBuyInfoListRequest"/></param>
        /// <returns><see cref="DescribeCCCBuyInfoListResponse"/></returns>
        public DescribeCCCBuyInfoListResponse DescribeCCCBuyInfoListSync(DescribeCCCBuyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeCCCBuyInfoListResponse>(req, "DescribeCCCBuyInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取呼入实时数据统计指标
        /// </summary>
        /// <param name="req"><see cref="DescribeCallInMetricsRequest"/></param>
        /// <returns><see cref="DescribeCallInMetricsResponse"/></returns>
        public Task<DescribeCallInMetricsResponse> DescribeCallInMetrics(DescribeCallInMetricsRequest req)
        {
            return InternalRequestAsync<DescribeCallInMetricsResponse>(req, "DescribeCallInMetrics");
        }

        /// <summary>
        /// 获取呼入实时数据统计指标
        /// </summary>
        /// <param name="req"><see cref="DescribeCallInMetricsRequest"/></param>
        /// <returns><see cref="DescribeCallInMetricsResponse"/></returns>
        public DescribeCallInMetricsResponse DescribeCallInMetricsSync(DescribeCallInMetricsRequest req)
        {
            return InternalRequestAsync<DescribeCallInMetricsResponse>(req, "DescribeCallInMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCarrierPrivilegeNumberApplicantsRequest"/></param>
        /// <returns><see cref="DescribeCarrierPrivilegeNumberApplicantsResponse"/></returns>
        public Task<DescribeCarrierPrivilegeNumberApplicantsResponse> DescribeCarrierPrivilegeNumberApplicants(DescribeCarrierPrivilegeNumberApplicantsRequest req)
        {
            return InternalRequestAsync<DescribeCarrierPrivilegeNumberApplicantsResponse>(req, "DescribeCarrierPrivilegeNumberApplicants");
        }

        /// <summary>
        /// 查询单状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCarrierPrivilegeNumberApplicantsRequest"/></param>
        /// <returns><see cref="DescribeCarrierPrivilegeNumberApplicantsResponse"/></returns>
        public DescribeCarrierPrivilegeNumberApplicantsResponse DescribeCarrierPrivilegeNumberApplicantsSync(DescribeCarrierPrivilegeNumberApplicantsRequest req)
        {
            return InternalRequestAsync<DescribeCarrierPrivilegeNumberApplicantsResponse>(req, "DescribeCarrierPrivilegeNumberApplicants")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定服务记录文本聊天内容，需要先使用查询在线客服记录（DescribeIMCdrs） API 获取服务记录 SessionId。
        /// 
        /// 文本聊天记录只保存了 1 年内的，1 年之前会自动清理。
        /// </summary>
        /// <param name="req"><see cref="DescribeChatMessagesRequest"/></param>
        /// <returns><see cref="DescribeChatMessagesResponse"/></returns>
        public Task<DescribeChatMessagesResponse> DescribeChatMessages(DescribeChatMessagesRequest req)
        {
            return InternalRequestAsync<DescribeChatMessagesResponse>(req, "DescribeChatMessages");
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
            return InternalRequestAsync<DescribeChatMessagesResponse>(req, "DescribeChatMessages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询公司资质申请列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCompanyListRequest"/></param>
        /// <returns><see cref="DescribeCompanyListResponse"/></returns>
        public Task<DescribeCompanyListResponse> DescribeCompanyList(DescribeCompanyListRequest req)
        {
            return InternalRequestAsync<DescribeCompanyListResponse>(req, "DescribeCompanyList");
        }

        /// <summary>
        /// 查询公司资质申请列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCompanyListRequest"/></param>
        /// <returns><see cref="DescribeCompanyListResponse"/></returns>
        public DescribeCompanyListResponse DescribeCompanyListSync(DescribeCompanyListRequest req)
        {
            return InternalRequestAsync<DescribeCompanyListResponse>(req, "DescribeCompanyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取话机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionRequest"/></param>
        /// <returns><see cref="DescribeExtensionResponse"/></returns>
        public Task<DescribeExtensionResponse> DescribeExtension(DescribeExtensionRequest req)
        {
            return InternalRequestAsync<DescribeExtensionResponse>(req, "DescribeExtension");
        }

        /// <summary>
        /// 获取话机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionRequest"/></param>
        /// <returns><see cref="DescribeExtensionResponse"/></returns>
        public DescribeExtensionResponse DescribeExtensionSync(DescribeExtensionRequest req)
        {
            return InternalRequestAsync<DescribeExtensionResponse>(req, "DescribeExtension")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询话机列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionsRequest"/></param>
        /// <returns><see cref="DescribeExtensionsResponse"/></returns>
        public Task<DescribeExtensionsResponse> DescribeExtensions(DescribeExtensionsRequest req)
        {
            return InternalRequestAsync<DescribeExtensionsResponse>(req, "DescribeExtensions");
        }

        /// <summary>
        /// 查询话机列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionsRequest"/></param>
        /// <returns><see cref="DescribeExtensionsResponse"/></returns>
        public DescribeExtensionsResponse DescribeExtensionsSync(DescribeExtensionsRequest req)
        {
            return InternalRequestAsync<DescribeExtensionsResponse>(req, "DescribeExtensions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取包括全媒体和文本会话两种类型的服务记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeIMCdrListRequest"/></param>
        /// <returns><see cref="DescribeIMCdrListResponse"/></returns>
        public Task<DescribeIMCdrListResponse> DescribeIMCdrList(DescribeIMCdrListRequest req)
        {
            return InternalRequestAsync<DescribeIMCdrListResponse>(req, "DescribeIMCdrList");
        }

        /// <summary>
        /// 获取包括全媒体和文本会话两种类型的服务记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeIMCdrListRequest"/></param>
        /// <returns><see cref="DescribeIMCdrListResponse"/></returns>
        public DescribeIMCdrListResponse DescribeIMCdrListSync(DescribeIMCdrListRequest req)
        {
            return InternalRequestAsync<DescribeIMCdrListResponse>(req, "DescribeIMCdrList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取包括全媒体和文本会话两种类型的服务记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeIMCdrsRequest"/></param>
        /// <returns><see cref="DescribeIMCdrsResponse"/></returns>
        public Task<DescribeIMCdrsResponse> DescribeIMCdrs(DescribeIMCdrsRequest req)
        {
            return InternalRequestAsync<DescribeIMCdrsResponse>(req, "DescribeIMCdrs");
        }

        /// <summary>
        /// 获取包括全媒体和文本会话两种类型的服务记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeIMCdrsRequest"/></param>
        /// <returns><see cref="DescribeIMCdrsResponse"/></returns>
        public DescribeIMCdrsResponse DescribeIMCdrsSync(DescribeIMCdrsRequest req)
        {
            return InternalRequestAsync<DescribeIMCdrsResponse>(req, "DescribeIMCdrs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询IVR音频文件列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIvrAudioListRequest"/></param>
        /// <returns><see cref="DescribeIvrAudioListResponse"/></returns>
        public Task<DescribeIvrAudioListResponse> DescribeIvrAudioList(DescribeIvrAudioListRequest req)
        {
            return InternalRequestAsync<DescribeIvrAudioListResponse>(req, "DescribeIvrAudioList");
        }

        /// <summary>
        /// 查询IVR音频文件列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIvrAudioListRequest"/></param>
        /// <returns><see cref="DescribeIvrAudioListResponse"/></returns>
        public DescribeIvrAudioListResponse DescribeIvrAudioListSync(DescribeIvrAudioListRequest req)
        {
            return InternalRequestAsync<DescribeIvrAudioListResponse>(req, "DescribeIvrAudioList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询号码列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNumbersRequest"/></param>
        /// <returns><see cref="DescribeNumbersResponse"/></returns>
        public Task<DescribeNumbersResponse> DescribeNumbers(DescribeNumbersRequest req)
        {
            return InternalRequestAsync<DescribeNumbersResponse>(req, "DescribeNumbers");
        }

        /// <summary>
        /// 查询号码列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNumbersRequest"/></param>
        /// <returns><see cref="DescribeNumbersResponse"/></returns>
        public DescribeNumbersResponse DescribeNumbersSync(DescribeNumbersRequest req)
        {
            return InternalRequestAsync<DescribeNumbersResponse>(req, "DescribeNumbers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前正在通话的会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribePSTNActiveSessionListRequest"/></param>
        /// <returns><see cref="DescribePSTNActiveSessionListResponse"/></returns>
        public Task<DescribePSTNActiveSessionListResponse> DescribePSTNActiveSessionList(DescribePSTNActiveSessionListRequest req)
        {
            return InternalRequestAsync<DescribePSTNActiveSessionListResponse>(req, "DescribePSTNActiveSessionList");
        }

        /// <summary>
        /// 获取当前正在通话的会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribePSTNActiveSessionListRequest"/></param>
        /// <returns><see cref="DescribePSTNActiveSessionListResponse"/></returns>
        public DescribePSTNActiveSessionListResponse DescribePSTNActiveSessionListSync(DescribePSTNActiveSessionListRequest req)
        {
            return InternalRequestAsync<DescribePSTNActiveSessionListResponse>(req, "DescribePSTNActiveSessionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingCampaignResponse"/></returns>
        public Task<DescribePredictiveDialingCampaignResponse> DescribePredictiveDialingCampaign(DescribePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingCampaignResponse>(req, "DescribePredictiveDialingCampaign");
        }

        /// <summary>
        /// 查询预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingCampaignResponse"/></returns>
        public DescribePredictiveDialingCampaignResponse DescribePredictiveDialingCampaignSync(DescribePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingCampaignResponse>(req, "DescribePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询预测式外呼任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingCampaignsRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingCampaignsResponse"/></returns>
        public Task<DescribePredictiveDialingCampaignsResponse> DescribePredictiveDialingCampaigns(DescribePredictiveDialingCampaignsRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingCampaignsResponse>(req, "DescribePredictiveDialingCampaigns");
        }

        /// <summary>
        /// 查询预测式外呼任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingCampaignsRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingCampaignsResponse"/></returns>
        public DescribePredictiveDialingCampaignsResponse DescribePredictiveDialingCampaignsSync(DescribePredictiveDialingCampaignsRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingCampaignsResponse>(req, "DescribePredictiveDialingCampaigns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询预测式外呼呼叫列表
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingSessionsRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingSessionsResponse"/></returns>
        public Task<DescribePredictiveDialingSessionsResponse> DescribePredictiveDialingSessions(DescribePredictiveDialingSessionsRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingSessionsResponse>(req, "DescribePredictiveDialingSessions");
        }

        /// <summary>
        /// 查询预测式外呼呼叫列表
        /// </summary>
        /// <param name="req"><see cref="DescribePredictiveDialingSessionsRequest"/></param>
        /// <returns><see cref="DescribePredictiveDialingSessionsResponse"/></returns>
        public DescribePredictiveDialingSessionsResponse DescribePredictiveDialingSessionsSync(DescribePredictiveDialingSessionsRequest req)
        {
            return InternalRequestAsync<DescribePredictiveDialingSessionsResponse>(req, "DescribePredictiveDialingSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取主被叫受保护的电话服务记录与录音
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectedTelCdrRequest"/></param>
        /// <returns><see cref="DescribeProtectedTelCdrResponse"/></returns>
        public Task<DescribeProtectedTelCdrResponse> DescribeProtectedTelCdr(DescribeProtectedTelCdrRequest req)
        {
            return InternalRequestAsync<DescribeProtectedTelCdrResponse>(req, "DescribeProtectedTelCdr");
        }

        /// <summary>
        /// 获取主被叫受保护的电话服务记录与录音
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectedTelCdrRequest"/></param>
        /// <returns><see cref="DescribeProtectedTelCdrResponse"/></returns>
        public DescribeProtectedTelCdrResponse DescribeProtectedTelCdrSync(DescribeProtectedTelCdrRequest req)
        {
            return InternalRequestAsync<DescribeProtectedTelCdrResponse>(req, "DescribeProtectedTelCdr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取技能组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillGroupInfoListRequest"/></param>
        /// <returns><see cref="DescribeSkillGroupInfoListResponse"/></returns>
        public Task<DescribeSkillGroupInfoListResponse> DescribeSkillGroupInfoList(DescribeSkillGroupInfoListRequest req)
        {
            return InternalRequestAsync<DescribeSkillGroupInfoListResponse>(req, "DescribeSkillGroupInfoList");
        }

        /// <summary>
        /// 获取技能组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillGroupInfoListRequest"/></param>
        /// <returns><see cref="DescribeSkillGroupInfoListResponse"/></returns>
        public DescribeSkillGroupInfoListResponse DescribeSkillGroupInfoListSync(DescribeSkillGroupInfoListRequest req)
        {
            return InternalRequestAsync<DescribeSkillGroupInfoListResponse>(req, "DescribeSkillGroupInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取坐席信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffInfoListRequest"/></param>
        /// <returns><see cref="DescribeStaffInfoListResponse"/></returns>
        public Task<DescribeStaffInfoListResponse> DescribeStaffInfoList(DescribeStaffInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStaffInfoListResponse>(req, "DescribeStaffInfoList");
        }

        /// <summary>
        /// 获取坐席信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffInfoListRequest"/></param>
        /// <returns><see cref="DescribeStaffInfoListResponse"/></returns>
        public DescribeStaffInfoListResponse DescribeStaffInfoListSync(DescribeStaffInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStaffInfoListResponse>(req, "DescribeStaffInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取坐席实时状态统计指标
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffStatusMetricsRequest"/></param>
        /// <returns><see cref="DescribeStaffStatusMetricsResponse"/></returns>
        public Task<DescribeStaffStatusMetricsResponse> DescribeStaffStatusMetrics(DescribeStaffStatusMetricsRequest req)
        {
            return InternalRequestAsync<DescribeStaffStatusMetricsResponse>(req, "DescribeStaffStatusMetrics");
        }

        /// <summary>
        /// 获取坐席实时状态统计指标
        /// </summary>
        /// <param name="req"><see cref="DescribeStaffStatusMetricsRequest"/></param>
        /// <returns><see cref="DescribeStaffStatusMetricsResponse"/></returns>
        public DescribeStaffStatusMetricsResponse DescribeStaffStatusMetricsSync(DescribeStaffStatusMetricsRequest req)
        {
            return InternalRequestAsync<DescribeStaffStatusMetricsResponse>(req, "DescribeStaffStatusMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按实例获取电话消耗统计
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCallInfoRequest"/></param>
        /// <returns><see cref="DescribeTelCallInfoResponse"/></returns>
        public Task<DescribeTelCallInfoResponse> DescribeTelCallInfo(DescribeTelCallInfoRequest req)
        {
            return InternalRequestAsync<DescribeTelCallInfoResponse>(req, "DescribeTelCallInfo");
        }

        /// <summary>
        /// 按实例获取电话消耗统计
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCallInfoRequest"/></param>
        /// <returns><see cref="DescribeTelCallInfoResponse"/></returns>
        public DescribeTelCallInfoResponse DescribeTelCallInfoSync(DescribeTelCallInfoRequest req)
        {
            return InternalRequestAsync<DescribeTelCallInfoResponse>(req, "DescribeTelCallInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取电话服务记录与录音
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCdrRequest"/></param>
        /// <returns><see cref="DescribeTelCdrResponse"/></returns>
        public Task<DescribeTelCdrResponse> DescribeTelCdr(DescribeTelCdrRequest req)
        {
            return InternalRequestAsync<DescribeTelCdrResponse>(req, "DescribeTelCdr");
        }

        /// <summary>
        /// 获取电话服务记录与录音
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCdrRequest"/></param>
        /// <returns><see cref="DescribeTelCdrResponse"/></returns>
        public DescribeTelCdrResponse DescribeTelCdrSync(DescribeTelCdrRequest req)
        {
            return InternalRequestAsync<DescribeTelCdrResponse>(req, "DescribeTelCdr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取会话录音转文本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTelRecordAsrRequest"/></param>
        /// <returns><see cref="DescribeTelRecordAsrResponse"/></returns>
        public Task<DescribeTelRecordAsrResponse> DescribeTelRecordAsr(DescribeTelRecordAsrRequest req)
        {
            return InternalRequestAsync<DescribeTelRecordAsrResponse>(req, "DescribeTelRecordAsr");
        }

        /// <summary>
        /// 拉取会话录音转文本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTelRecordAsrRequest"/></param>
        /// <returns><see cref="DescribeTelRecordAsrResponse"/></returns>
        public DescribeTelRecordAsrResponse DescribeTelRecordAsrSync(DescribeTelRecordAsrRequest req)
        {
            return InternalRequestAsync<DescribeTelRecordAsrResponse>(req, "DescribeTelRecordAsr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 PSTN 会话信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTelSessionRequest"/></param>
        /// <returns><see cref="DescribeTelSessionResponse"/></returns>
        public Task<DescribeTelSessionResponse> DescribeTelSession(DescribeTelSessionRequest req)
        {
            return InternalRequestAsync<DescribeTelSessionResponse>(req, "DescribeTelSession");
        }

        /// <summary>
        /// 获取 PSTN 会话信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTelSessionRequest"/></param>
        /// <returns><see cref="DescribeTelSessionResponse"/></returns>
        public DescribeTelSessionResponse DescribeTelSessionSync(DescribeTelSessionRequest req)
        {
            return InternalRequestAsync<DescribeTelSessionResponse>(req, "DescribeTelSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停用号码
        /// </summary>
        /// <param name="req"><see cref="DisableCCCPhoneNumberRequest"/></param>
        /// <returns><see cref="DisableCCCPhoneNumberResponse"/></returns>
        public Task<DisableCCCPhoneNumberResponse> DisableCCCPhoneNumber(DisableCCCPhoneNumberRequest req)
        {
            return InternalRequestAsync<DisableCCCPhoneNumberResponse>(req, "DisableCCCPhoneNumber");
        }

        /// <summary>
        /// 停用号码
        /// </summary>
        /// <param name="req"><see cref="DisableCCCPhoneNumberRequest"/></param>
        /// <returns><see cref="DisableCCCPhoneNumberResponse"/></returns>
        public DisableCCCPhoneNumberResponse DisableCCCPhoneNumberSync(DisableCCCPhoneNumberRequest req)
        {
            return InternalRequestAsync<DisableCCCPhoneNumberResponse>(req, "DisableCCCPhoneNumber")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 挂断电话
        /// </summary>
        /// <param name="req"><see cref="HangUpCallRequest"/></param>
        /// <returns><see cref="HangUpCallResponse"/></returns>
        public Task<HangUpCallResponse> HangUpCall(HangUpCallRequest req)
        {
            return InternalRequestAsync<HangUpCallResponse>(req, "HangUpCall");
        }

        /// <summary>
        /// 挂断电话
        /// </summary>
        /// <param name="req"><see cref="HangUpCallRequest"/></param>
        /// <returns><see cref="HangUpCallResponse"/></returns>
        public HangUpCallResponse HangUpCallSync(HangUpCallRequest req)
        {
            return InternalRequestAsync<HangUpCallResponse>(req, "HangUpCall")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改公司资质申请，只能修改状态为驳回或待审核的申请单。（1、首次使用接口，建议先在云联络中心控制台查看各个资料模板:https://console.cloud.tencent.com/ccc/enterprise/update。2、参数中图片Url建议使用腾讯云Cos存储的临时链接）
        /// </summary>
        /// <param name="req"><see cref="ModifyCompanyApplyRequest"/></param>
        /// <returns><see cref="ModifyCompanyApplyResponse"/></returns>
        public Task<ModifyCompanyApplyResponse> ModifyCompanyApply(ModifyCompanyApplyRequest req)
        {
            return InternalRequestAsync<ModifyCompanyApplyResponse>(req, "ModifyCompanyApply");
        }

        /// <summary>
        /// 修改公司资质申请，只能修改状态为驳回或待审核的申请单。（1、首次使用接口，建议先在云联络中心控制台查看各个资料模板:https://console.cloud.tencent.com/ccc/enterprise/update。2、参数中图片Url建议使用腾讯云Cos存储的临时链接）
        /// </summary>
        /// <param name="req"><see cref="ModifyCompanyApplyRequest"/></param>
        /// <returns><see cref="ModifyCompanyApplyResponse"/></returns>
        public ModifyCompanyApplyResponse ModifyCompanyApplySync(ModifyCompanyApplyRequest req)
        {
            return InternalRequestAsync<ModifyCompanyApplyResponse>(req, "ModifyCompanyApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改话机账号(绑定技能组、绑定坐席账号)
        /// </summary>
        /// <param name="req"><see cref="ModifyExtensionRequest"/></param>
        /// <returns><see cref="ModifyExtensionResponse"/></returns>
        public Task<ModifyExtensionResponse> ModifyExtension(ModifyExtensionRequest req)
        {
            return InternalRequestAsync<ModifyExtensionResponse>(req, "ModifyExtension");
        }

        /// <summary>
        /// 修改话机账号(绑定技能组、绑定坐席账号)
        /// </summary>
        /// <param name="req"><see cref="ModifyExtensionRequest"/></param>
        /// <returns><see cref="ModifyExtensionResponse"/></returns>
        public ModifyExtensionResponse ModifyExtensionSync(ModifyExtensionRequest req)
        {
            return InternalRequestAsync<ModifyExtensionResponse>(req, "ModifyExtension")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改客户自携号码审批单
        /// </summary>
        /// <param name="req"><see cref="ModifyOwnNumberApplyRequest"/></param>
        /// <returns><see cref="ModifyOwnNumberApplyResponse"/></returns>
        public Task<ModifyOwnNumberApplyResponse> ModifyOwnNumberApply(ModifyOwnNumberApplyRequest req)
        {
            return InternalRequestAsync<ModifyOwnNumberApplyResponse>(req, "ModifyOwnNumberApply");
        }

        /// <summary>
        /// 修改客户自携号码审批单
        /// </summary>
        /// <param name="req"><see cref="ModifyOwnNumberApplyRequest"/></param>
        /// <returns><see cref="ModifyOwnNumberApplyResponse"/></returns>
        public ModifyOwnNumberApplyResponse ModifyOwnNumberApplySync(ModifyOwnNumberApplyRequest req)
        {
            return InternalRequestAsync<ModifyOwnNumberApplyResponse>(req, "ModifyOwnNumberApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改客服账号
        /// </summary>
        /// <param name="req"><see cref="ModifyStaffRequest"/></param>
        /// <returns><see cref="ModifyStaffResponse"/></returns>
        public Task<ModifyStaffResponse> ModifyStaff(ModifyStaffRequest req)
        {
            return InternalRequestAsync<ModifyStaffResponse>(req, "ModifyStaff");
        }

        /// <summary>
        /// 修改客服账号
        /// </summary>
        /// <param name="req"><see cref="ModifyStaffRequest"/></param>
        /// <returns><see cref="ModifyStaffResponse"/></returns>
        public ModifyStaffResponse ModifyStaffSync(ModifyStaffRequest req)
        {
            return InternalRequestAsync<ModifyStaffResponse>(req, "ModifyStaff")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改座席的密码
        /// </summary>
        /// <param name="req"><see cref="ModifyStaffPasswordRequest"/></param>
        /// <returns><see cref="ModifyStaffPasswordResponse"/></returns>
        public Task<ModifyStaffPasswordResponse> ModifyStaffPassword(ModifyStaffPasswordRequest req)
        {
            return InternalRequestAsync<ModifyStaffPasswordResponse>(req, "ModifyStaffPassword");
        }

        /// <summary>
        /// 修改座席的密码
        /// </summary>
        /// <param name="req"><see cref="ModifyStaffPasswordRequest"/></param>
        /// <returns><see cref="ModifyStaffPasswordResponse"/></returns>
        public ModifyStaffPasswordResponse ModifyStaffPasswordSync(ModifyStaffPasswordRequest req)
        {
            return InternalRequestAsync<ModifyStaffPasswordResponse>(req, "ModifyStaffPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="PausePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="PausePredictiveDialingCampaignResponse"/></returns>
        public Task<PausePredictiveDialingCampaignResponse> PausePredictiveDialingCampaign(PausePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<PausePredictiveDialingCampaignResponse>(req, "PausePredictiveDialingCampaign");
        }

        /// <summary>
        /// 暂停预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="PausePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="PausePredictiveDialingCampaignResponse"/></returns>
        public PausePredictiveDialingCampaignResponse PausePredictiveDialingCampaignSync(PausePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<PausePredictiveDialingCampaignResponse>(req, "PausePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置话机注册密码
        /// </summary>
        /// <param name="req"><see cref="ResetExtensionPasswordRequest"/></param>
        /// <returns><see cref="ResetExtensionPasswordResponse"/></returns>
        public Task<ResetExtensionPasswordResponse> ResetExtensionPassword(ResetExtensionPasswordRequest req)
        {
            return InternalRequestAsync<ResetExtensionPasswordResponse>(req, "ResetExtensionPassword");
        }

        /// <summary>
        /// 重置话机注册密码
        /// </summary>
        /// <param name="req"><see cref="ResetExtensionPasswordRequest"/></param>
        /// <returns><see cref="ResetExtensionPasswordResponse"/></returns>
        public ResetExtensionPasswordResponse ResetExtensionPasswordSync(ResetExtensionPasswordRequest req)
        {
            return InternalRequestAsync<ResetExtensionPasswordResponse>(req, "ResetExtensionPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="ResumePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="ResumePredictiveDialingCampaignResponse"/></returns>
        public Task<ResumePredictiveDialingCampaignResponse> ResumePredictiveDialingCampaign(ResumePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<ResumePredictiveDialingCampaignResponse>(req, "ResumePredictiveDialingCampaign");
        }

        /// <summary>
        /// 恢复预测式外呼任务
        /// </summary>
        /// <param name="req"><see cref="ResumePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="ResumePredictiveDialingCampaignResponse"/></returns>
        public ResumePredictiveDialingCampaignResponse ResumePredictiveDialingCampaignSync(ResumePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<ResumePredictiveDialingCampaignResponse>(req, "ResumePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止自动外呼任务
        /// </summary>
        /// <param name="req"><see cref="StopAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="StopAutoCalloutTaskResponse"/></returns>
        public Task<StopAutoCalloutTaskResponse> StopAutoCalloutTask(StopAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<StopAutoCalloutTaskResponse>(req, "StopAutoCalloutTask");
        }

        /// <summary>
        /// 停止自动外呼任务
        /// </summary>
        /// <param name="req"><see cref="StopAutoCalloutTaskRequest"/></param>
        /// <returns><see cref="StopAutoCalloutTaskResponse"/></returns>
        public StopAutoCalloutTaskResponse StopAutoCalloutTaskSync(StopAutoCalloutTaskRequest req)
        {
            return InternalRequestAsync<StopAutoCalloutTaskResponse>(req, "StopAutoCalloutTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑号码外呼技能组
        /// </summary>
        /// <param name="req"><see cref="UnbindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="UnbindNumberCallOutSkillGroupResponse"/></returns>
        public Task<UnbindNumberCallOutSkillGroupResponse> UnbindNumberCallOutSkillGroup(UnbindNumberCallOutSkillGroupRequest req)
        {
            return InternalRequestAsync<UnbindNumberCallOutSkillGroupResponse>(req, "UnbindNumberCallOutSkillGroup");
        }

        /// <summary>
        /// 解绑号码外呼技能组
        /// </summary>
        /// <param name="req"><see cref="UnbindNumberCallOutSkillGroupRequest"/></param>
        /// <returns><see cref="UnbindNumberCallOutSkillGroupResponse"/></returns>
        public UnbindNumberCallOutSkillGroupResponse UnbindNumberCallOutSkillGroupSync(UnbindNumberCallOutSkillGroupRequest req)
        {
            return InternalRequestAsync<UnbindNumberCallOutSkillGroupResponse>(req, "UnbindNumberCallOutSkillGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑坐席所属技能组
        /// </summary>
        /// <param name="req"><see cref="UnbindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="UnbindStaffSkillGroupListResponse"/></returns>
        public Task<UnbindStaffSkillGroupListResponse> UnbindStaffSkillGroupList(UnbindStaffSkillGroupListRequest req)
        {
            return InternalRequestAsync<UnbindStaffSkillGroupListResponse>(req, "UnbindStaffSkillGroupList");
        }

        /// <summary>
        /// 解绑坐席所属技能组
        /// </summary>
        /// <param name="req"><see cref="UnbindStaffSkillGroupListRequest"/></param>
        /// <returns><see cref="UnbindStaffSkillGroupListResponse"/></returns>
        public UnbindStaffSkillGroupListResponse UnbindStaffSkillGroupListSync(UnbindStaffSkillGroupListRequest req)
        {
            return InternalRequestAsync<UnbindStaffSkillGroupListResponse>(req, "UnbindStaffSkillGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新技能组
        /// </summary>
        /// <param name="req"><see cref="UpdateCCCSkillGroupRequest"/></param>
        /// <returns><see cref="UpdateCCCSkillGroupResponse"/></returns>
        public Task<UpdateCCCSkillGroupResponse> UpdateCCCSkillGroup(UpdateCCCSkillGroupRequest req)
        {
            return InternalRequestAsync<UpdateCCCSkillGroupResponse>(req, "UpdateCCCSkillGroup");
        }

        /// <summary>
        /// 更新技能组
        /// </summary>
        /// <param name="req"><see cref="UpdateCCCSkillGroupRequest"/></param>
        /// <returns><see cref="UpdateCCCSkillGroupResponse"/></returns>
        public UpdateCCCSkillGroupResponse UpdateCCCSkillGroupSync(UpdateCCCSkillGroupRequest req)
        {
            return InternalRequestAsync<UpdateCCCSkillGroupResponse>(req, "UpdateCCCSkillGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务未启动前，更新预测式外呼任务。
        /// </summary>
        /// <param name="req"><see cref="UpdatePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="UpdatePredictiveDialingCampaignResponse"/></returns>
        public Task<UpdatePredictiveDialingCampaignResponse> UpdatePredictiveDialingCampaign(UpdatePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<UpdatePredictiveDialingCampaignResponse>(req, "UpdatePredictiveDialingCampaign");
        }

        /// <summary>
        /// 任务未启动前，更新预测式外呼任务。
        /// </summary>
        /// <param name="req"><see cref="UpdatePredictiveDialingCampaignRequest"/></param>
        /// <returns><see cref="UpdatePredictiveDialingCampaignResponse"/></returns>
        public UpdatePredictiveDialingCampaignResponse UpdatePredictiveDialingCampaignSync(UpdatePredictiveDialingCampaignRequest req)
        {
            return InternalRequestAsync<UpdatePredictiveDialingCampaignResponse>(req, "UpdatePredictiveDialingCampaign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传IVR中使用的音频文件，每日上传文件限制50个。（参数中音频文件Url建议使用腾讯云Cos存储的临时链接）
        /// </summary>
        /// <param name="req"><see cref="UploadIvrAudioRequest"/></param>
        /// <returns><see cref="UploadIvrAudioResponse"/></returns>
        public Task<UploadIvrAudioResponse> UploadIvrAudio(UploadIvrAudioRequest req)
        {
            return InternalRequestAsync<UploadIvrAudioResponse>(req, "UploadIvrAudio");
        }

        /// <summary>
        /// 上传IVR中使用的音频文件，每日上传文件限制50个。（参数中音频文件Url建议使用腾讯云Cos存储的临时链接）
        /// </summary>
        /// <param name="req"><see cref="UploadIvrAudioRequest"/></param>
        /// <returns><see cref="UploadIvrAudioResponse"/></returns>
        public UploadIvrAudioResponse UploadIvrAudioSync(UploadIvrAudioRequest req)
        {
            return InternalRequestAsync<UploadIvrAudioResponse>(req, "UploadIvrAudio")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
