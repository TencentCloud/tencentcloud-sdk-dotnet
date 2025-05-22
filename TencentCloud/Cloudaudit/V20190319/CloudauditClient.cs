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

namespace TencentCloud.Cloudaudit.V20190319
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudaudit.V20190319.Models;

   public class CloudauditClient : AbstractClient{

       private const string endpoint = "cloudaudit.tencentcloudapi.com";
       private const string version = "2019-03-19";
       private const string sdkVersion = "SDK_NET_3.0.1246";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudauditClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CloudauditClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建操作审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="CreateAuditTrackRequest"/></param>
        /// <returns><see cref="CreateAuditTrackResponse"/></returns>
        public Task<CreateAuditTrackResponse> CreateAuditTrack(CreateAuditTrackRequest req)
        {
            return InternalRequestAsync<CreateAuditTrackResponse>(req, "CreateAuditTrack");
        }

        /// <summary>
        /// 创建操作审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="CreateAuditTrackRequest"/></param>
        /// <returns><see cref="CreateAuditTrackResponse"/></returns>
        public CreateAuditTrackResponse CreateAuditTrackSync(CreateAuditTrackRequest req)
        {
            return InternalRequestAsync<CreateAuditTrackResponse>(req, "CreateAuditTrack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建操作审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="CreateEventsAuditTrackRequest"/></param>
        /// <returns><see cref="CreateEventsAuditTrackResponse"/></returns>
        public Task<CreateEventsAuditTrackResponse> CreateEventsAuditTrack(CreateEventsAuditTrackRequest req)
        {
            return InternalRequestAsync<CreateEventsAuditTrackResponse>(req, "CreateEventsAuditTrack");
        }

        /// <summary>
        /// 创建操作审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="CreateEventsAuditTrackRequest"/></param>
        /// <returns><see cref="CreateEventsAuditTrackResponse"/></returns>
        public CreateEventsAuditTrackResponse CreateEventsAuditTrackSync(CreateEventsAuditTrackRequest req)
        {
            return InternalRequestAsync<CreateEventsAuditTrackResponse>(req, "CreateEventsAuditTrack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除操作审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditTrackRequest"/></param>
        /// <returns><see cref="DeleteAuditTrackResponse"/></returns>
        public Task<DeleteAuditTrackResponse> DeleteAuditTrack(DeleteAuditTrackRequest req)
        {
            return InternalRequestAsync<DeleteAuditTrackResponse>(req, "DeleteAuditTrack");
        }

        /// <summary>
        /// 删除操作审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditTrackRequest"/></param>
        /// <returns><see cref="DeleteAuditTrackResponse"/></returns>
        public DeleteAuditTrackResponse DeleteAuditTrackSync(DeleteAuditTrackRequest req)
        {
            return InternalRequestAsync<DeleteAuditTrackResponse>(req, "DeleteAuditTrack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询跟踪集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRequest"/></param>
        /// <returns><see cref="DescribeAuditResponse"/></returns>
        public Task<DescribeAuditResponse> DescribeAudit(DescribeAuditRequest req)
        {
            return InternalRequestAsync<DescribeAuditResponse>(req, "DescribeAudit");
        }

        /// <summary>
        /// 查询跟踪集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRequest"/></param>
        /// <returns><see cref="DescribeAuditResponse"/></returns>
        public DescribeAuditResponse DescribeAuditSync(DescribeAuditRequest req)
        {
            return InternalRequestAsync<DescribeAuditResponse>(req, "DescribeAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询操作审计跟踪集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTrackRequest"/></param>
        /// <returns><see cref="DescribeAuditTrackResponse"/></returns>
        public Task<DescribeAuditTrackResponse> DescribeAuditTrack(DescribeAuditTrackRequest req)
        {
            return InternalRequestAsync<DescribeAuditTrackResponse>(req, "DescribeAuditTrack");
        }

        /// <summary>
        /// 查询操作审计跟踪集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTrackRequest"/></param>
        /// <returns><see cref="DescribeAuditTrackResponse"/></returns>
        public DescribeAuditTrackResponse DescribeAuditTrackSync(DescribeAuditTrackRequest req)
        {
            return InternalRequestAsync<DescribeAuditTrackResponse>(req, "DescribeAuditTrack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询操作审计跟踪集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTracksRequest"/></param>
        /// <returns><see cref="DescribeAuditTracksResponse"/></returns>
        public Task<DescribeAuditTracksResponse> DescribeAuditTracks(DescribeAuditTracksRequest req)
        {
            return InternalRequestAsync<DescribeAuditTracksResponse>(req, "DescribeAuditTracks");
        }

        /// <summary>
        /// 查询操作审计跟踪集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTracksRequest"/></param>
        /// <returns><see cref="DescribeAuditTracksResponse"/></returns>
        public DescribeAuditTracksResponse DescribeAuditTracksSync(DescribeAuditTracksRequest req)
        {
            return InternalRequestAsync<DescribeAuditTracksResponse>(req, "DescribeAuditTracks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询操作审计日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public Task<DescribeEventsResponse> DescribeEvents(DescribeEventsRequest req)
        {
            return InternalRequestAsync<DescribeEventsResponse>(req, "DescribeEvents");
        }

        /// <summary>
        /// 查询操作审计日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public DescribeEventsResponse DescribeEventsSync(DescribeEventsRequest req)
        {
            return InternalRequestAsync<DescribeEventsResponse>(req, "DescribeEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AttributeKey的有效取值范围
        /// </summary>
        /// <param name="req"><see cref="GetAttributeKeyRequest"/></param>
        /// <returns><see cref="GetAttributeKeyResponse"/></returns>
        public Task<GetAttributeKeyResponse> GetAttributeKey(GetAttributeKeyRequest req)
        {
            return InternalRequestAsync<GetAttributeKeyResponse>(req, "GetAttributeKey");
        }

        /// <summary>
        /// 查询AttributeKey的有效取值范围
        /// </summary>
        /// <param name="req"><see cref="GetAttributeKeyRequest"/></param>
        /// <returns><see cref="GetAttributeKeyResponse"/></returns>
        public GetAttributeKeyResponse GetAttributeKeySync(GetAttributeKeyRequest req)
        {
            return InternalRequestAsync<GetAttributeKeyResponse>(req, "GetAttributeKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户可创建跟踪集的数量
        /// </summary>
        /// <param name="req"><see cref="InquireAuditCreditRequest"/></param>
        /// <returns><see cref="InquireAuditCreditResponse"/></returns>
        public Task<InquireAuditCreditResponse> InquireAuditCredit(InquireAuditCreditRequest req)
        {
            return InternalRequestAsync<InquireAuditCreditResponse>(req, "InquireAuditCredit");
        }

        /// <summary>
        /// 查询用户可创建跟踪集的数量
        /// </summary>
        /// <param name="req"><see cref="InquireAuditCreditRequest"/></param>
        /// <returns><see cref="InquireAuditCreditResponse"/></returns>
        public InquireAuditCreditResponse InquireAuditCreditSync(InquireAuditCreditRequest req)
        {
            return InternalRequestAsync<InquireAuditCreditResponse>(req, "InquireAuditCredit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询跟踪集概要
        /// </summary>
        /// <param name="req"><see cref="ListAuditsRequest"/></param>
        /// <returns><see cref="ListAuditsResponse"/></returns>
        public Task<ListAuditsResponse> ListAudits(ListAuditsRequest req)
        {
            return InternalRequestAsync<ListAuditsResponse>(req, "ListAudits");
        }

        /// <summary>
        /// 查询跟踪集概要
        /// </summary>
        /// <param name="req"><see cref="ListAuditsRequest"/></param>
        /// <returns><see cref="ListAuditsResponse"/></returns>
        public ListAuditsResponse ListAuditsSync(ListAuditsRequest req)
        {
            return InternalRequestAsync<ListAuditsResponse>(req, "ListAudits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询操作审计支持的cmq的可用区
        /// </summary>
        /// <param name="req"><see cref="ListCmqEnableRegionRequest"/></param>
        /// <returns><see cref="ListCmqEnableRegionResponse"/></returns>
        public Task<ListCmqEnableRegionResponse> ListCmqEnableRegion(ListCmqEnableRegionRequest req)
        {
            return InternalRequestAsync<ListCmqEnableRegionResponse>(req, "ListCmqEnableRegion");
        }

        /// <summary>
        /// 查询操作审计支持的cmq的可用区
        /// </summary>
        /// <param name="req"><see cref="ListCmqEnableRegionRequest"/></param>
        /// <returns><see cref="ListCmqEnableRegionResponse"/></returns>
        public ListCmqEnableRegionResponse ListCmqEnableRegionSync(ListCmqEnableRegionRequest req)
        {
            return InternalRequestAsync<ListCmqEnableRegionResponse>(req, "ListCmqEnableRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询操作审计支持的cos可用区
        /// </summary>
        /// <param name="req"><see cref="ListCosEnableRegionRequest"/></param>
        /// <returns><see cref="ListCosEnableRegionResponse"/></returns>
        public Task<ListCosEnableRegionResponse> ListCosEnableRegion(ListCosEnableRegionRequest req)
        {
            return InternalRequestAsync<ListCosEnableRegionResponse>(req, "ListCosEnableRegion");
        }

        /// <summary>
        /// 查询操作审计支持的cos可用区
        /// </summary>
        /// <param name="req"><see cref="ListCosEnableRegionRequest"/></param>
        /// <returns><see cref="ListCosEnableRegionResponse"/></returns>
        public ListCosEnableRegionResponse ListCosEnableRegionSync(ListCosEnableRegionRequest req)
        {
            return InternalRequestAsync<ListCosEnableRegionResponse>(req, "ListCosEnableRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据地域获取KMS密钥别名
        /// </summary>
        /// <param name="req"><see cref="ListKeyAliasByRegionRequest"/></param>
        /// <returns><see cref="ListKeyAliasByRegionResponse"/></returns>
        public Task<ListKeyAliasByRegionResponse> ListKeyAliasByRegion(ListKeyAliasByRegionRequest req)
        {
            return InternalRequestAsync<ListKeyAliasByRegionResponse>(req, "ListKeyAliasByRegion");
        }

        /// <summary>
        /// 根据地域获取KMS密钥别名
        /// </summary>
        /// <param name="req"><see cref="ListKeyAliasByRegionRequest"/></param>
        /// <returns><see cref="ListKeyAliasByRegionResponse"/></returns>
        public ListKeyAliasByRegionResponse ListKeyAliasByRegionSync(ListKeyAliasByRegionRequest req)
        {
            return InternalRequestAsync<ListKeyAliasByRegionResponse>(req, "ListKeyAliasByRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于对操作日志进行检索，便于用户进行查询相关的操作信息。
        /// </summary>
        /// <param name="req"><see cref="LookUpEventsRequest"/></param>
        /// <returns><see cref="LookUpEventsResponse"/></returns>
        public Task<LookUpEventsResponse> LookUpEvents(LookUpEventsRequest req)
        {
            return InternalRequestAsync<LookUpEventsResponse>(req, "LookUpEvents");
        }

        /// <summary>
        /// 用于对操作日志进行检索，便于用户进行查询相关的操作信息。
        /// </summary>
        /// <param name="req"><see cref="LookUpEventsRequest"/></param>
        /// <returns><see cref="LookUpEventsResponse"/></returns>
        public LookUpEventsResponse LookUpEventsSync(LookUpEventsRequest req)
        {
            return InternalRequestAsync<LookUpEventsResponse>(req, "LookUpEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改操作审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditTrackRequest"/></param>
        /// <returns><see cref="ModifyAuditTrackResponse"/></returns>
        public Task<ModifyAuditTrackResponse> ModifyAuditTrack(ModifyAuditTrackRequest req)
        {
            return InternalRequestAsync<ModifyAuditTrackResponse>(req, "ModifyAuditTrack");
        }

        /// <summary>
        /// 修改操作审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditTrackRequest"/></param>
        /// <returns><see cref="ModifyAuditTrackResponse"/></returns>
        public ModifyAuditTrackResponse ModifyAuditTrackSync(ModifyAuditTrackRequest req)
        {
            return InternalRequestAsync<ModifyAuditTrackResponse>(req, "ModifyAuditTrack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改操作审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="ModifyEventsAuditTrackRequest"/></param>
        /// <returns><see cref="ModifyEventsAuditTrackResponse"/></returns>
        public Task<ModifyEventsAuditTrackResponse> ModifyEventsAuditTrack(ModifyEventsAuditTrackRequest req)
        {
            return InternalRequestAsync<ModifyEventsAuditTrackResponse>(req, "ModifyEventsAuditTrack");
        }

        /// <summary>
        /// 修改操作审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="ModifyEventsAuditTrackRequest"/></param>
        /// <returns><see cref="ModifyEventsAuditTrackResponse"/></returns>
        public ModifyEventsAuditTrackResponse ModifyEventsAuditTrackSync(ModifyEventsAuditTrackRequest req)
        {
            return InternalRequestAsync<ModifyEventsAuditTrackResponse>(req, "ModifyEventsAuditTrack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启跟踪集
        /// </summary>
        /// <param name="req"><see cref="StartLoggingRequest"/></param>
        /// <returns><see cref="StartLoggingResponse"/></returns>
        public Task<StartLoggingResponse> StartLogging(StartLoggingRequest req)
        {
            return InternalRequestAsync<StartLoggingResponse>(req, "StartLogging");
        }

        /// <summary>
        /// 开启跟踪集
        /// </summary>
        /// <param name="req"><see cref="StartLoggingRequest"/></param>
        /// <returns><see cref="StartLoggingResponse"/></returns>
        public StartLoggingResponse StartLoggingSync(StartLoggingRequest req)
        {
            return InternalRequestAsync<StartLoggingResponse>(req, "StartLogging")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭跟踪集
        /// </summary>
        /// <param name="req"><see cref="StopLoggingRequest"/></param>
        /// <returns><see cref="StopLoggingResponse"/></returns>
        public Task<StopLoggingResponse> StopLogging(StopLoggingRequest req)
        {
            return InternalRequestAsync<StopLoggingResponse>(req, "StopLogging");
        }

        /// <summary>
        /// 关闭跟踪集
        /// </summary>
        /// <param name="req"><see cref="StopLoggingRequest"/></param>
        /// <returns><see cref="StopLoggingResponse"/></returns>
        public StopLoggingResponse StopLoggingSync(StopLoggingRequest req)
        {
            return InternalRequestAsync<StopLoggingResponse>(req, "StopLogging")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 参数要求：
        /// 1、如果IsCreateNewBucket的值存在的话，cosRegion和cosBucketName都是必填参数。
        /// 2、如果IsEnableCmqNotify的值是1的话，IsCreateNewQueue、CmqRegion和CmqQueueName都是必填参数。
        /// 3、如果IsEnableCmqNotify的值是0的话，IsCreateNewQueue、CmqRegion和CmqQueueName都不能传。
        /// 4、如果IsEnableKmsEncry的值是1的话，KmsRegion和KeyId属于必填项
        /// </summary>
        /// <param name="req"><see cref="UpdateAuditRequest"/></param>
        /// <returns><see cref="UpdateAuditResponse"/></returns>
        public Task<UpdateAuditResponse> UpdateAudit(UpdateAuditRequest req)
        {
            return InternalRequestAsync<UpdateAuditResponse>(req, "UpdateAudit");
        }

        /// <summary>
        /// 参数要求：
        /// 1、如果IsCreateNewBucket的值存在的话，cosRegion和cosBucketName都是必填参数。
        /// 2、如果IsEnableCmqNotify的值是1的话，IsCreateNewQueue、CmqRegion和CmqQueueName都是必填参数。
        /// 3、如果IsEnableCmqNotify的值是0的话，IsCreateNewQueue、CmqRegion和CmqQueueName都不能传。
        /// 4、如果IsEnableKmsEncry的值是1的话，KmsRegion和KeyId属于必填项
        /// </summary>
        /// <param name="req"><see cref="UpdateAuditRequest"/></param>
        /// <returns><see cref="UpdateAuditResponse"/></returns>
        public UpdateAuditResponse UpdateAuditSync(UpdateAuditRequest req)
        {
            return InternalRequestAsync<UpdateAuditResponse>(req, "UpdateAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
