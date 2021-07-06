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
        /// 绑定坐席所属技能组
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
        /// 绑定坐席所属技能组
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
        /// 包括具体聊天内容
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
        /// 包括具体聊天内容
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
        /// 包括全媒体和文本两种类型
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
        /// 包括全媒体和文本两种类型
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
        /// 废弃接口下架
        /// 
        /// 获取坐席用户列表（废弃）
        /// </summary>
        /// <param name="req"><see cref="DescribeSeatUserListRequest"/></param>
        /// <returns><see cref="DescribeSeatUserListResponse"/></returns>
        public async Task<DescribeSeatUserListResponse> DescribeSeatUserList(DescribeSeatUserListRequest req)
        {
             JsonResponseModel<DescribeSeatUserListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSeatUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSeatUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 废弃接口下架
        /// 
        /// 获取坐席用户列表（废弃）
        /// </summary>
        /// <param name="req"><see cref="DescribeSeatUserListRequest"/></param>
        /// <returns><see cref="DescribeSeatUserListResponse"/></returns>
        public DescribeSeatUserListResponse DescribeSeatUserListSync(DescribeSeatUserListRequest req)
        {
             JsonResponseModel<DescribeSeatUserListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSeatUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSeatUserListResponse>>(strResp);
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
