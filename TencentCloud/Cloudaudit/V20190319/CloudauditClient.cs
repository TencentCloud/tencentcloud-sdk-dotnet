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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudauditClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 创建跟踪集
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRequest"/></param>
        /// <returns><see cref="CreateAuditResponse"/></returns>
        public async Task<CreateAuditResponse> CreateAudit(CreateAuditRequest req)
        {
             JsonResponseModel<CreateAuditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateAudit接口的同步版本，创建跟踪集
        /// </summary>
        /// <param name="req">参考<see cref="CreateAuditRequest"/></param>
        /// <returns>参考<see cref="CreateAuditResponse"/>实例</returns>
        public CreateAuditResponse CreateAuditSync(CreateAuditRequest req)
        {
             JsonResponseModel<CreateAuditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除跟踪集
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRequest"/></param>
        /// <returns><see cref="DeleteAuditResponse"/></returns>
        public async Task<DeleteAuditResponse> DeleteAudit(DeleteAuditRequest req)
        {
             JsonResponseModel<DeleteAuditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteAudit接口的同步版本，删除跟踪集
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAuditRequest"/></param>
        /// <returns>参考<see cref="DeleteAuditResponse"/>实例</returns>
        public DeleteAuditResponse DeleteAuditSync(DeleteAuditRequest req)
        {
             JsonResponseModel<DeleteAuditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询跟踪集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRequest"/></param>
        /// <returns><see cref="DescribeAuditResponse"/></returns>
        public async Task<DescribeAuditResponse> DescribeAudit(DescribeAuditRequest req)
        {
             JsonResponseModel<DescribeAuditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeAudit接口的同步版本，查询跟踪集详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAuditRequest"/></param>
        /// <returns>参考<see cref="DescribeAuditResponse"/>实例</returns>
        public DescribeAuditResponse DescribeAuditSync(DescribeAuditRequest req)
        {
             JsonResponseModel<DescribeAuditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询AttributeKey的有效取值范围
        /// </summary>
        /// <param name="req"><see cref="GetAttributeKeyRequest"/></param>
        /// <returns><see cref="GetAttributeKeyResponse"/></returns>
        public async Task<GetAttributeKeyResponse> GetAttributeKey(GetAttributeKeyRequest req)
        {
             JsonResponseModel<GetAttributeKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAttributeKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAttributeKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetAttributeKey接口的同步版本，查询AttributeKey的有效取值范围
        /// </summary>
        /// <param name="req">参考<see cref="GetAttributeKeyRequest"/></param>
        /// <returns>参考<see cref="GetAttributeKeyResponse"/>实例</returns>
        public GetAttributeKeyResponse GetAttributeKeySync(GetAttributeKeyRequest req)
        {
             JsonResponseModel<GetAttributeKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAttributeKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAttributeKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户可创建跟踪集的数量
        /// </summary>
        /// <param name="req"><see cref="InquireAuditCreditRequest"/></param>
        /// <returns><see cref="InquireAuditCreditResponse"/></returns>
        public async Task<InquireAuditCreditResponse> InquireAuditCredit(InquireAuditCreditRequest req)
        {
             JsonResponseModel<InquireAuditCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquireAuditCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquireAuditCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquireAuditCredit接口的同步版本，查询用户可创建跟踪集的数量
        /// </summary>
        /// <param name="req">参考<see cref="InquireAuditCreditRequest"/></param>
        /// <returns>参考<see cref="InquireAuditCreditResponse"/>实例</returns>
        public InquireAuditCreditResponse InquireAuditCreditSync(InquireAuditCreditRequest req)
        {
             JsonResponseModel<InquireAuditCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquireAuditCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquireAuditCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询跟踪集概要
        /// </summary>
        /// <param name="req"><see cref="ListAuditsRequest"/></param>
        /// <returns><see cref="ListAuditsResponse"/></returns>
        public async Task<ListAuditsResponse> ListAudits(ListAuditsRequest req)
        {
             JsonResponseModel<ListAuditsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAudits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuditsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListAudits接口的同步版本，查询跟踪集概要
        /// </summary>
        /// <param name="req">参考<see cref="ListAuditsRequest"/></param>
        /// <returns>参考<see cref="ListAuditsResponse"/>实例</returns>
        public ListAuditsResponse ListAuditsSync(ListAuditsRequest req)
        {
             JsonResponseModel<ListAuditsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAudits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuditsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云审计支持的cmq的可用区
        /// </summary>
        /// <param name="req"><see cref="ListCmqEnableRegionRequest"/></param>
        /// <returns><see cref="ListCmqEnableRegionResponse"/></returns>
        public async Task<ListCmqEnableRegionResponse> ListCmqEnableRegion(ListCmqEnableRegionRequest req)
        {
             JsonResponseModel<ListCmqEnableRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListCmqEnableRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListCmqEnableRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListCmqEnableRegion接口的同步版本，查询云审计支持的cmq的可用区
        /// </summary>
        /// <param name="req">参考<see cref="ListCmqEnableRegionRequest"/></param>
        /// <returns>参考<see cref="ListCmqEnableRegionResponse"/>实例</returns>
        public ListCmqEnableRegionResponse ListCmqEnableRegionSync(ListCmqEnableRegionRequest req)
        {
             JsonResponseModel<ListCmqEnableRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListCmqEnableRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListCmqEnableRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云审计支持的cos可用区
        /// </summary>
        /// <param name="req"><see cref="ListCosEnableRegionRequest"/></param>
        /// <returns><see cref="ListCosEnableRegionResponse"/></returns>
        public async Task<ListCosEnableRegionResponse> ListCosEnableRegion(ListCosEnableRegionRequest req)
        {
             JsonResponseModel<ListCosEnableRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListCosEnableRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListCosEnableRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListCosEnableRegion接口的同步版本，查询云审计支持的cos可用区
        /// </summary>
        /// <param name="req">参考<see cref="ListCosEnableRegionRequest"/></param>
        /// <returns>参考<see cref="ListCosEnableRegionResponse"/>实例</returns>
        public ListCosEnableRegionResponse ListCosEnableRegionSync(ListCosEnableRegionRequest req)
        {
             JsonResponseModel<ListCosEnableRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListCosEnableRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListCosEnableRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对操作日志进行检索，便于用户进行查询相关的操作信息。
        /// </summary>
        /// <param name="req"><see cref="LookUpEventsRequest"/></param>
        /// <returns><see cref="LookUpEventsResponse"/></returns>
        public async Task<LookUpEventsResponse> LookUpEvents(LookUpEventsRequest req)
        {
             JsonResponseModel<LookUpEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LookUpEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LookUpEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// LookUpEvents接口的同步版本，用于对操作日志进行检索，便于用户进行查询相关的操作信息。
        /// </summary>
        /// <param name="req">参考<see cref="LookUpEventsRequest"/></param>
        /// <returns>参考<see cref="LookUpEventsResponse"/>实例</returns>
        public LookUpEventsResponse LookUpEventsSync(LookUpEventsRequest req)
        {
             JsonResponseModel<LookUpEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LookUpEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LookUpEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启跟踪集
        /// </summary>
        /// <param name="req"><see cref="StartLoggingRequest"/></param>
        /// <returns><see cref="StartLoggingResponse"/></returns>
        public async Task<StartLoggingResponse> StartLogging(StartLoggingRequest req)
        {
             JsonResponseModel<StartLoggingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartLogging");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartLoggingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StartLogging接口的同步版本，开启跟踪集
        /// </summary>
        /// <param name="req">参考<see cref="StartLoggingRequest"/></param>
        /// <returns>参考<see cref="StartLoggingResponse"/>实例</returns>
        public StartLoggingResponse StartLoggingSync(StartLoggingRequest req)
        {
             JsonResponseModel<StartLoggingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartLogging");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartLoggingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭跟踪集
        /// </summary>
        /// <param name="req"><see cref="StopLoggingRequest"/></param>
        /// <returns><see cref="StopLoggingResponse"/></returns>
        public async Task<StopLoggingResponse> StopLogging(StopLoggingRequest req)
        {
             JsonResponseModel<StopLoggingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopLogging");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLoggingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StopLogging接口的同步版本，关闭跟踪集
        /// </summary>
        /// <param name="req">参考<see cref="StopLoggingRequest"/></param>
        /// <returns>参考<see cref="StopLoggingResponse"/>实例</returns>
        public StopLoggingResponse StopLoggingSync(StopLoggingRequest req)
        {
             JsonResponseModel<StopLoggingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopLogging");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLoggingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 参数要求：
        /// 1、如果IsCreateNewBucket的值存在的话，cosRegion和cosBucketName都是必填参数。
        /// 2、如果IsEnableCmqNotify的值是1的话，IsCreateNewQueue、CmqRegion和CmqQueueName都是必填参数。
        /// 3、如果IsEnableCmqNotify的值是0的话，IsCreateNewQueue、CmqRegion和CmqQueueName都不能传。
        /// </summary>
        /// <param name="req"><see cref="UpdateAuditRequest"/></param>
        /// <returns><see cref="UpdateAuditResponse"/></returns>
        public async Task<UpdateAuditResponse> UpdateAudit(UpdateAuditRequest req)
        {
             JsonResponseModel<UpdateAuditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateAudit接口的同步版本，参数要求：
        /// 1、如果IsCreateNewBucket的值存在的话，cosRegion和cosBucketName都是必填参数。
        /// 2、如果IsEnableCmqNotify的值是1的话，IsCreateNewQueue、CmqRegion和CmqQueueName都是必填参数。
        /// 3、如果IsEnableCmqNotify的值是0的话，IsCreateNewQueue、CmqRegion和CmqQueueName都不能传。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateAuditRequest"/></param>
        /// <returns>参考<see cref="UpdateAuditResponse"/>实例</returns>
        public UpdateAuditResponse UpdateAuditSync(UpdateAuditRequest req)
        {
             JsonResponseModel<UpdateAuditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
