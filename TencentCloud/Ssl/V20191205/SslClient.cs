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

namespace TencentCloud.Ssl.V20191205
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ssl.V20191205.Models;

   public class SslClient : AbstractClient{

       private const string endpoint = "ssl.tencentcloudapi.com";
       private const string version = "2019-12-05";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SslClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SslClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（ApplyCertificate）用于免费证书申请。
        /// </summary>
        /// <param name="req"><see cref="ApplyCertificateRequest"/></param>
        /// <returns><see cref="ApplyCertificateResponse"/></returns>
        public async Task<ApplyCertificateResponse> ApplyCertificate(ApplyCertificateRequest req)
        {
             JsonResponseModel<ApplyCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ApplyCertificate）用于免费证书申请。
        /// </summary>
        /// <param name="req"><see cref="ApplyCertificateRequest"/></param>
        /// <returns><see cref="ApplyCertificateResponse"/></returns>
        public ApplyCertificateResponse ApplyCertificateSync(ApplyCertificateRequest req)
        {
             JsonResponseModel<ApplyCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消证书订单。
        /// </summary>
        /// <param name="req"><see cref="CancelCertificateOrderRequest"/></param>
        /// <returns><see cref="CancelCertificateOrderResponse"/></returns>
        public async Task<CancelCertificateOrderResponse> CancelCertificateOrder(CancelCertificateOrderRequest req)
        {
             JsonResponseModel<CancelCertificateOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelCertificateOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelCertificateOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消证书订单。
        /// </summary>
        /// <param name="req"><see cref="CancelCertificateOrderRequest"/></param>
        /// <returns><see cref="CancelCertificateOrderResponse"/></returns>
        public CancelCertificateOrderResponse CancelCertificateOrderSync(CancelCertificateOrderRequest req)
        {
             JsonResponseModel<CancelCertificateOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelCertificateOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelCertificateOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckCertificateChain）用于检查证书链是否完整。
        /// </summary>
        /// <param name="req"><see cref="CheckCertificateChainRequest"/></param>
        /// <returns><see cref="CheckCertificateChainResponse"/></returns>
        public async Task<CheckCertificateChainResponse> CheckCertificateChain(CheckCertificateChainRequest req)
        {
             JsonResponseModel<CheckCertificateChainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckCertificateChain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckCertificateChainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckCertificateChain）用于检查证书链是否完整。
        /// </summary>
        /// <param name="req"><see cref="CheckCertificateChainRequest"/></param>
        /// <returns><see cref="CheckCertificateChainResponse"/></returns>
        public CheckCertificateChainResponse CheckCertificateChainSync(CheckCertificateChainRequest req)
        {
             JsonResponseModel<CheckCertificateChainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckCertificateChain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckCertificateChainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交证书订单。
        /// </summary>
        /// <param name="req"><see cref="CommitCertificateInformationRequest"/></param>
        /// <returns><see cref="CommitCertificateInformationResponse"/></returns>
        public async Task<CommitCertificateInformationResponse> CommitCertificateInformation(CommitCertificateInformationRequest req)
        {
             JsonResponseModel<CommitCertificateInformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CommitCertificateInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitCertificateInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交证书订单。
        /// </summary>
        /// <param name="req"><see cref="CommitCertificateInformationRequest"/></param>
        /// <returns><see cref="CommitCertificateInformationResponse"/></returns>
        public CommitCertificateInformationResponse CommitCertificateInformationSync(CommitCertificateInformationRequest req)
        {
             JsonResponseModel<CommitCertificateInformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CommitCertificateInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitCertificateInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CompleteCertificate）用于主动触发证书验证。仅非DNSPod和Wotrus品牌证书支持使用此接口。
        /// </summary>
        /// <param name="req"><see cref="CompleteCertificateRequest"/></param>
        /// <returns><see cref="CompleteCertificateResponse"/></returns>
        public async Task<CompleteCertificateResponse> CompleteCertificate(CompleteCertificateRequest req)
        {
             JsonResponseModel<CompleteCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompleteCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompleteCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CompleteCertificate）用于主动触发证书验证。仅非DNSPod和Wotrus品牌证书支持使用此接口。
        /// </summary>
        /// <param name="req"><see cref="CompleteCertificateRequest"/></param>
        /// <returns><see cref="CompleteCertificateResponse"/></returns>
        public CompleteCertificateResponse CompleteCertificateSync(CompleteCertificateRequest req)
        {
             JsonResponseModel<CompleteCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CompleteCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompleteCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCertificate）用于创建付费证书。
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public async Task<CreateCertificateResponse> CreateCertificate(CreateCertificateRequest req)
        {
             JsonResponseModel<CreateCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCertificate）用于创建付费证书。
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public CreateCertificateResponse CreateCertificateSync(CreateCertificateRequest req)
        {
             JsonResponseModel<CreateCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCertificate）用于删除证书。
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public async Task<DeleteCertificateResponse> DeleteCertificate(DeleteCertificateRequest req)
        {
             JsonResponseModel<DeleteCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCertificate）用于删除证书。
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public DeleteCertificateResponse DeleteCertificateSync(DeleteCertificateRequest req)
        {
             JsonResponseModel<DeleteCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除管理人
        /// </summary>
        /// <param name="req"><see cref="DeleteManagerRequest"/></param>
        /// <returns><see cref="DeleteManagerResponse"/></returns>
        public async Task<DeleteManagerResponse> DeleteManager(DeleteManagerRequest req)
        {
             JsonResponseModel<DeleteManagerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除管理人
        /// </summary>
        /// <param name="req"><see cref="DeleteManagerRequest"/></param>
        /// <returns><see cref="DeleteManagerResponse"/></returns>
        public DeleteManagerResponse DeleteManagerSync(DeleteManagerRequest req)
        {
             JsonResponseModel<DeleteManagerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCertificate）用于获取证书信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateRequest"/></param>
        /// <returns><see cref="DescribeCertificateResponse"/></returns>
        public async Task<DescribeCertificateResponse> DescribeCertificate(DescribeCertificateRequest req)
        {
             JsonResponseModel<DescribeCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCertificate）用于获取证书信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateRequest"/></param>
        /// <returns><see cref="DescribeCertificateResponse"/></returns>
        public DescribeCertificateResponse DescribeCertificateSync(DescribeCertificateRequest req)
        {
             JsonResponseModel<DescribeCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取证书详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public async Task<DescribeCertificateDetailResponse> DescribeCertificateDetail(DescribeCertificateDetailRequest req)
        {
             JsonResponseModel<DescribeCertificateDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificateDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取证书详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public DescribeCertificateDetailResponse DescribeCertificateDetailSync(DescribeCertificateDetailRequest req)
        {
             JsonResponseModel<DescribeCertificateDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificateDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户账号下有关证书的操作日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateOperateLogsRequest"/></param>
        /// <returns><see cref="DescribeCertificateOperateLogsResponse"/></returns>
        public async Task<DescribeCertificateOperateLogsResponse> DescribeCertificateOperateLogs(DescribeCertificateOperateLogsRequest req)
        {
             JsonResponseModel<DescribeCertificateOperateLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificateOperateLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateOperateLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户账号下有关证书的操作日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateOperateLogsRequest"/></param>
        /// <returns><see cref="DescribeCertificateOperateLogsResponse"/></returns>
        public DescribeCertificateOperateLogsResponse DescribeCertificateOperateLogsSync(DescribeCertificateOperateLogsRequest req)
        {
             JsonResponseModel<DescribeCertificateOperateLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificateOperateLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateOperateLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCertificates）用于获取证书列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public async Task<DescribeCertificatesResponse> DescribeCertificates(DescribeCertificatesRequest req)
        {
             JsonResponseModel<DescribeCertificatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCertificates）用于获取证书列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public DescribeCertificatesResponse DescribeCertificatesSync(DescribeCertificatesRequest req)
        {
             JsonResponseModel<DescribeCertificatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 证书查询关联资源
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployedResourcesRequest"/></param>
        /// <returns><see cref="DescribeDeployedResourcesResponse"/></returns>
        public async Task<DescribeDeployedResourcesResponse> DescribeDeployedResources(DescribeDeployedResourcesRequest req)
        {
             JsonResponseModel<DescribeDeployedResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeployedResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeployedResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 证书查询关联资源
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployedResourcesRequest"/></param>
        /// <returns><see cref="DescribeDeployedResourcesResponse"/></returns>
        public DescribeDeployedResourcesResponse DescribeDeployedResourcesSync(DescribeDeployedResourcesRequest req)
        {
             JsonResponseModel<DescribeDeployedResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeployedResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeployedResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询管理人详情
        /// </summary>
        /// <param name="req"><see cref="DescribeManagerDetailRequest"/></param>
        /// <returns><see cref="DescribeManagerDetailResponse"/></returns>
        public async Task<DescribeManagerDetailResponse> DescribeManagerDetail(DescribeManagerDetailRequest req)
        {
             JsonResponseModel<DescribeManagerDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeManagerDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeManagerDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询管理人详情
        /// </summary>
        /// <param name="req"><see cref="DescribeManagerDetailRequest"/></param>
        /// <returns><see cref="DescribeManagerDetailResponse"/></returns>
        public DescribeManagerDetailResponse DescribeManagerDetailSync(DescribeManagerDetailRequest req)
        {
             JsonResponseModel<DescribeManagerDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeManagerDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeManagerDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询管理人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeManagersRequest"/></param>
        /// <returns><see cref="DescribeManagersResponse"/></returns>
        public async Task<DescribeManagersResponse> DescribeManagers(DescribeManagersRequest req)
        {
             JsonResponseModel<DescribeManagersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeManagers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeManagersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询管理人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeManagersRequest"/></param>
        /// <returns><see cref="DescribeManagersResponse"/></returns>
        public DescribeManagersResponse DescribeManagersSync(DescribeManagersRequest req)
        {
             JsonResponseModel<DescribeManagersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeManagers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeManagersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获得权益包列表
        /// </summary>
        /// <param name="req"><see cref="DescribePackagesRequest"/></param>
        /// <returns><see cref="DescribePackagesResponse"/></returns>
        public async Task<DescribePackagesResponse> DescribePackages(DescribePackagesRequest req)
        {
             JsonResponseModel<DescribePackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获得权益包列表
        /// </summary>
        /// <param name="req"><see cref="DescribePackagesRequest"/></param>
        /// <returns><see cref="DescribePackagesResponse"/></returns>
        public DescribePackagesResponse DescribePackagesSync(DescribePackagesRequest req)
        {
             JsonResponseModel<DescribePackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DownloadCertificate）用于下载证书。
        /// </summary>
        /// <param name="req"><see cref="DownloadCertificateRequest"/></param>
        /// <returns><see cref="DownloadCertificateResponse"/></returns>
        public async Task<DownloadCertificateResponse> DownloadCertificate(DownloadCertificateRequest req)
        {
             JsonResponseModel<DownloadCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DownloadCertificate）用于下载证书。
        /// </summary>
        /// <param name="req"><see cref="DownloadCertificateRequest"/></param>
        /// <returns><see cref="DownloadCertificateResponse"/></returns>
        public DownloadCertificateResponse DownloadCertificateSync(DownloadCertificateRequest req)
        {
             JsonResponseModel<DownloadCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云资源托管
        /// </summary>
        /// <param name="req"><see cref="HostCertificateRequest"/></param>
        /// <returns><see cref="HostCertificateResponse"/></returns>
        public async Task<HostCertificateResponse> HostCertificate(HostCertificateRequest req)
        {
             JsonResponseModel<HostCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HostCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HostCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云资源托管
        /// </summary>
        /// <param name="req"><see cref="HostCertificateRequest"/></param>
        /// <returns><see cref="HostCertificateResponse"/></returns>
        public HostCertificateResponse HostCertificateSync(HostCertificateRequest req)
        {
             JsonResponseModel<HostCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "HostCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HostCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户传入证书id和备注来修改证书备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAliasRequest"/></param>
        /// <returns><see cref="ModifyCertificateAliasResponse"/></returns>
        public async Task<ModifyCertificateAliasResponse> ModifyCertificateAlias(ModifyCertificateAliasRequest req)
        {
             JsonResponseModel<ModifyCertificateAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCertificateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户传入证书id和备注来修改证书备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAliasRequest"/></param>
        /// <returns><see cref="ModifyCertificateAliasResponse"/></returns>
        public ModifyCertificateAliasResponse ModifyCertificateAliasSync(ModifyCertificateAliasRequest req)
        {
             JsonResponseModel<ModifyCertificateAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCertificateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改证书所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateProjectRequest"/></param>
        /// <returns><see cref="ModifyCertificateProjectResponse"/></returns>
        public async Task<ModifyCertificateProjectResponse> ModifyCertificateProject(ModifyCertificateProjectRequest req)
        {
             JsonResponseModel<ModifyCertificateProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCertificateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改证书所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateProjectRequest"/></param>
        /// <returns><see cref="ModifyCertificateProjectResponse"/></returns>
        public ModifyCertificateProjectResponse ModifyCertificateProjectSync(ModifyCertificateProjectRequest req)
        {
             JsonResponseModel<ModifyCertificateProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCertificateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceCertificate）用于重颁发证书。已申请的免费证书仅支持 RSA 算法、密钥对参数为2048的证书重颁发，并且目前仅支持1次重颁发。
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertificateRequest"/></param>
        /// <returns><see cref="ReplaceCertificateResponse"/></returns>
        public async Task<ReplaceCertificateResponse> ReplaceCertificate(ReplaceCertificateRequest req)
        {
             JsonResponseModel<ReplaceCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceCertificate）用于重颁发证书。已申请的免费证书仅支持 RSA 算法、密钥对参数为2048的证书重颁发，并且目前仅支持1次重颁发。
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertificateRequest"/></param>
        /// <returns><see cref="ReplaceCertificateResponse"/></returns>
        public ReplaceCertificateResponse ReplaceCertificateSync(ReplaceCertificateRequest req)
        {
             JsonResponseModel<ReplaceCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RevokeCertificate）用于吊销证书。
        /// </summary>
        /// <param name="req"><see cref="RevokeCertificateRequest"/></param>
        /// <returns><see cref="RevokeCertificateResponse"/></returns>
        public async Task<RevokeCertificateResponse> RevokeCertificate(RevokeCertificateRequest req)
        {
             JsonResponseModel<RevokeCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RevokeCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevokeCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RevokeCertificate）用于吊销证书。
        /// </summary>
        /// <param name="req"><see cref="RevokeCertificateRequest"/></param>
        /// <returns><see cref="RevokeCertificateResponse"/></returns>
        public RevokeCertificateResponse RevokeCertificateSync(RevokeCertificateRequest req)
        {
             JsonResponseModel<RevokeCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RevokeCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevokeCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新提交审核管理人
        /// </summary>
        /// <param name="req"><see cref="SubmitAuditManagerRequest"/></param>
        /// <returns><see cref="SubmitAuditManagerResponse"/></returns>
        public async Task<SubmitAuditManagerResponse> SubmitAuditManager(SubmitAuditManagerRequest req)
        {
             JsonResponseModel<SubmitAuditManagerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitAuditManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitAuditManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新提交审核管理人
        /// </summary>
        /// <param name="req"><see cref="SubmitAuditManagerRequest"/></param>
        /// <returns><see cref="SubmitAuditManagerResponse"/></returns>
        public SubmitAuditManagerResponse SubmitAuditManagerSync(SubmitAuditManagerRequest req)
        {
             JsonResponseModel<SubmitAuditManagerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SubmitAuditManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitAuditManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交证书资料。输入参数信息可以分多次提交，但提交的证书资料应最低限度保持完整。
        /// </summary>
        /// <param name="req"><see cref="SubmitCertificateInformationRequest"/></param>
        /// <returns><see cref="SubmitCertificateInformationResponse"/></returns>
        public async Task<SubmitCertificateInformationResponse> SubmitCertificateInformation(SubmitCertificateInformationRequest req)
        {
             JsonResponseModel<SubmitCertificateInformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitCertificateInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitCertificateInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交证书资料。输入参数信息可以分多次提交，但提交的证书资料应最低限度保持完整。
        /// </summary>
        /// <param name="req"><see cref="SubmitCertificateInformationRequest"/></param>
        /// <returns><see cref="SubmitCertificateInformationResponse"/></returns>
        public SubmitCertificateInformationResponse SubmitCertificateInformationSync(SubmitCertificateInformationRequest req)
        {
             JsonResponseModel<SubmitCertificateInformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SubmitCertificateInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitCertificateInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadCertificate）用于上传证书。
        /// </summary>
        /// <param name="req"><see cref="UploadCertificateRequest"/></param>
        /// <returns><see cref="UploadCertificateResponse"/></returns>
        public async Task<UploadCertificateResponse> UploadCertificate(UploadCertificateRequest req)
        {
             JsonResponseModel<UploadCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadCertificate）用于上传证书。
        /// </summary>
        /// <param name="req"><see cref="UploadCertificateRequest"/></param>
        /// <returns><see cref="UploadCertificateResponse"/></returns>
        public UploadCertificateResponse UploadCertificateSync(UploadCertificateRequest req)
        {
             JsonResponseModel<UploadCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadConfirmLetter）用于上传证书确认函。
        /// </summary>
        /// <param name="req"><see cref="UploadConfirmLetterRequest"/></param>
        /// <returns><see cref="UploadConfirmLetterResponse"/></returns>
        public async Task<UploadConfirmLetterResponse> UploadConfirmLetter(UploadConfirmLetterRequest req)
        {
             JsonResponseModel<UploadConfirmLetterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadConfirmLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadConfirmLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadConfirmLetter）用于上传证书确认函。
        /// </summary>
        /// <param name="req"><see cref="UploadConfirmLetterRequest"/></param>
        /// <returns><see cref="UploadConfirmLetterResponse"/></returns>
        public UploadConfirmLetterResponse UploadConfirmLetterSync(UploadConfirmLetterRequest req)
        {
             JsonResponseModel<UploadConfirmLetterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadConfirmLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadConfirmLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadRevokeLetter）用于上传证书吊销确认函。
        /// </summary>
        /// <param name="req"><see cref="UploadRevokeLetterRequest"/></param>
        /// <returns><see cref="UploadRevokeLetterResponse"/></returns>
        public async Task<UploadRevokeLetterResponse> UploadRevokeLetter(UploadRevokeLetterRequest req)
        {
             JsonResponseModel<UploadRevokeLetterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadRevokeLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadRevokeLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadRevokeLetter）用于上传证书吊销确认函。
        /// </summary>
        /// <param name="req"><see cref="UploadRevokeLetterRequest"/></param>
        /// <returns><see cref="UploadRevokeLetterResponse"/></returns>
        public UploadRevokeLetterResponse UploadRevokeLetterSync(UploadRevokeLetterRequest req)
        {
             JsonResponseModel<UploadRevokeLetterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadRevokeLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadRevokeLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新核验管理人
        /// </summary>
        /// <param name="req"><see cref="VerifyManagerRequest"/></param>
        /// <returns><see cref="VerifyManagerResponse"/></returns>
        public async Task<VerifyManagerResponse> VerifyManager(VerifyManagerRequest req)
        {
             JsonResponseModel<VerifyManagerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新核验管理人
        /// </summary>
        /// <param name="req"><see cref="VerifyManagerRequest"/></param>
        /// <returns><see cref="VerifyManagerResponse"/></returns>
        public VerifyManagerResponse VerifyManagerSync(VerifyManagerRequest req)
        {
             JsonResponseModel<VerifyManagerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
