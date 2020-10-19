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

namespace TencentCloud.Domain.V20180808
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Domain.V20180808.Models;

   public class DomainClient : AbstractClient{

       private const string endpoint = "domain.tencentcloudapi.com";
       private const string version = "2018-08-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DomainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DomainClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口 ( BatchModifyDomainInfo ) 用于批量域名信息修改 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyDomainInfoRequest"/></param>
        /// <returns><see cref="BatchModifyDomainInfoResponse"/></returns>
        public async Task<BatchModifyDomainInfoResponse> BatchModifyDomainInfo(BatchModifyDomainInfoRequest req)
        {
             JsonResponseModel<BatchModifyDomainInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyDomainInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyDomainInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( BatchModifyDomainInfo ) 用于批量域名信息修改 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyDomainInfoRequest"/></param>
        /// <returns><see cref="BatchModifyDomainInfoResponse"/></returns>
        public BatchModifyDomainInfoResponse BatchModifyDomainInfoSync(BatchModifyDomainInfoRequest req)
        {
             JsonResponseModel<BatchModifyDomainInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyDomainInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyDomainInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CheckBatchStatus ) 用于查询批量操作日志状态 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="CheckBatchStatusRequest"/></param>
        /// <returns><see cref="CheckBatchStatusResponse"/></returns>
        public async Task<CheckBatchStatusResponse> CheckBatchStatus(CheckBatchStatusRequest req)
        {
             JsonResponseModel<CheckBatchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckBatchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBatchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CheckBatchStatus ) 用于查询批量操作日志状态 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="CheckBatchStatusRequest"/></param>
        /// <returns><see cref="CheckBatchStatusResponse"/></returns>
        public CheckBatchStatusResponse CheckBatchStatusSync(CheckBatchStatusRequest req)
        {
             JsonResponseModel<CheckBatchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckBatchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBatchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查域名是否可以注册。
        /// </summary>
        /// <param name="req"><see cref="CheckDomainRequest"/></param>
        /// <returns><see cref="CheckDomainResponse"/></returns>
        public async Task<CheckDomainResponse> CheckDomain(CheckDomainRequest req)
        {
             JsonResponseModel<CheckDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查域名是否可以注册。
        /// </summary>
        /// <param name="req"><see cref="CheckDomainRequest"/></param>
        /// <returns><see cref="CheckDomainResponse"/></returns>
        public CheckDomainResponse CheckDomainSync(CheckDomainRequest req)
        {
             JsonResponseModel<CheckDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CreateDomainBatch ) 用于批量注册域名 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainBatchRequest"/></param>
        /// <returns><see cref="CreateDomainBatchResponse"/></returns>
        public async Task<CreateDomainBatchResponse> CreateDomainBatch(CreateDomainBatchRequest req)
        {
             JsonResponseModel<CreateDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CreateDomainBatch ) 用于批量注册域名 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainBatchRequest"/></param>
        /// <returns><see cref="CreateDomainBatchResponse"/></returns>
        public CreateDomainBatchResponse CreateDomainBatchSync(CreateDomainBatchRequest req)
        {
             JsonResponseModel<CreateDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CreateTemplate ) 用于添加域名信息模板 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="CreateTemplateRequest"/></param>
        /// <returns><see cref="CreateTemplateResponse"/></returns>
        public async Task<CreateTemplateResponse> CreateTemplate(CreateTemplateRequest req)
        {
             JsonResponseModel<CreateTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CreateTemplate ) 用于添加域名信息模板 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="CreateTemplateRequest"/></param>
        /// <returns><see cref="CreateTemplateResponse"/></returns>
        public CreateTemplateResponse CreateTemplateSync(CreateTemplateRequest req)
        {
             JsonResponseModel<CreateTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( DeleteTemplate ) 用于删除域名信息模板。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="DeleteTemplateRequest"/></param>
        /// <returns><see cref="DeleteTemplateResponse"/></returns>
        public async Task<DeleteTemplateResponse> DeleteTemplate(DeleteTemplateRequest req)
        {
             JsonResponseModel<DeleteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( DeleteTemplate ) 用于删除域名信息模板。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="DeleteTemplateRequest"/></param>
        /// <returns><see cref="DeleteTemplateResponse"/></returns>
        public DeleteTemplateResponse DeleteTemplateSync(DeleteTemplateRequest req)
        {
             JsonResponseModel<DeleteTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (  DescribeDomainBaseInfo) 获取域名基础信息。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainBaseInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainBaseInfoResponse"/></returns>
        public async Task<DescribeDomainBaseInfoResponse> DescribeDomainBaseInfo(DescribeDomainBaseInfoRequest req)
        {
             JsonResponseModel<DescribeDomainBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (  DescribeDomainBaseInfo) 获取域名基础信息。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainBaseInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainBaseInfoResponse"/></returns>
        public DescribeDomainBaseInfoResponse DescribeDomainBaseInfoSync(DescribeDomainBaseInfoRequest req)
        {
             JsonResponseModel<DescribeDomainBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (  DescribeDomainNameList ) 获取域名列表。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainNameListRequest"/></param>
        /// <returns><see cref="DescribeDomainNameListResponse"/></returns>
        public async Task<DescribeDomainNameListResponse> DescribeDomainNameList(DescribeDomainNameListRequest req)
        {
             JsonResponseModel<DescribeDomainNameListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainNameList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainNameListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (  DescribeDomainNameList ) 获取域名列表。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainNameListRequest"/></param>
        /// <returns><see cref="DescribeDomainNameListResponse"/></returns>
        public DescribeDomainNameListResponse DescribeDomainNameListSync(DescribeDomainNameListRequest req)
        {
             JsonResponseModel<DescribeDomainNameListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainNameList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainNameListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照域名后缀获取对应的价格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPriceListRequest"/></param>
        /// <returns><see cref="DescribeDomainPriceListResponse"/></returns>
        public async Task<DescribeDomainPriceListResponse> DescribeDomainPriceList(DescribeDomainPriceListRequest req)
        {
             JsonResponseModel<DescribeDomainPriceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainPriceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainPriceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照域名后缀获取对应的价格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPriceListRequest"/></param>
        /// <returns><see cref="DescribeDomainPriceListResponse"/></returns>
        public DescribeDomainPriceListResponse DescribeDomainPriceListSync(DescribeDomainPriceListRequest req)
        {
             JsonResponseModel<DescribeDomainPriceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainPriceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainPriceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeTemplateList) 用于获取模板列表。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public async Task<DescribeTemplateListResponse> DescribeTemplateList(DescribeTemplateListRequest req)
        {
             JsonResponseModel<DescribeTemplateListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeTemplateList) 用于获取模板列表。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public DescribeTemplateListResponse DescribeTemplateListSync(DescribeTemplateListRequest req)
        {
             JsonResponseModel<DescribeTemplateListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( ModifyDomainDNSBatch) 用于批量修改域名DNS信息 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainDNSBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainDNSBatchResponse"/></returns>
        public async Task<ModifyDomainDNSBatchResponse> ModifyDomainDNSBatch(ModifyDomainDNSBatchRequest req)
        {
             JsonResponseModel<ModifyDomainDNSBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainDNSBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainDNSBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( ModifyDomainDNSBatch) 用于批量修改域名DNS信息 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainDNSBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainDNSBatchResponse"/></returns>
        public ModifyDomainDNSBatchResponse ModifyDomainDNSBatchSync(ModifyDomainDNSBatchRequest req)
        {
             JsonResponseModel<ModifyDomainDNSBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainDNSBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainDNSBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( ModifyDomainOwnerBatch) 用于域名批量账号间转移 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainOwnerBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainOwnerBatchResponse"/></returns>
        public async Task<ModifyDomainOwnerBatchResponse> ModifyDomainOwnerBatch(ModifyDomainOwnerBatchRequest req)
        {
             JsonResponseModel<ModifyDomainOwnerBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainOwnerBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainOwnerBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( ModifyDomainOwnerBatch) 用于域名批量账号间转移 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainOwnerBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainOwnerBatchResponse"/></returns>
        public ModifyDomainOwnerBatchResponse ModifyDomainOwnerBatchSync(ModifyDomainOwnerBatchRequest req)
        {
             JsonResponseModel<ModifyDomainOwnerBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainOwnerBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainOwnerBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( RenewDomainBatch ) 用于批量续费域名 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="RenewDomainBatchRequest"/></param>
        /// <returns><see cref="RenewDomainBatchResponse"/></returns>
        public async Task<RenewDomainBatchResponse> RenewDomainBatch(RenewDomainBatchRequest req)
        {
             JsonResponseModel<RenewDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( RenewDomainBatch ) 用于批量续费域名 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="RenewDomainBatchRequest"/></param>
        /// <returns><see cref="RenewDomainBatchResponse"/></returns>
        public RenewDomainBatchResponse RenewDomainBatchSync(RenewDomainBatchRequest req)
        {
             JsonResponseModel<RenewDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( SetDomainAutoRenew ) 用于设置域名自动续费。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="SetDomainAutoRenewRequest"/></param>
        /// <returns><see cref="SetDomainAutoRenewResponse"/></returns>
        public async Task<SetDomainAutoRenewResponse> SetDomainAutoRenew(SetDomainAutoRenewRequest req)
        {
             JsonResponseModel<SetDomainAutoRenewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetDomainAutoRenew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDomainAutoRenewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( SetDomainAutoRenew ) 用于设置域名自动续费。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="SetDomainAutoRenewRequest"/></param>
        /// <returns><see cref="SetDomainAutoRenewResponse"/></returns>
        public SetDomainAutoRenewResponse SetDomainAutoRenewSync(SetDomainAutoRenewRequest req)
        {
             JsonResponseModel<SetDomainAutoRenewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetDomainAutoRenew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDomainAutoRenewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( TransferInDomainBatch ) 用于批量转入域名 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="TransferInDomainBatchRequest"/></param>
        /// <returns><see cref="TransferInDomainBatchResponse"/></returns>
        public async Task<TransferInDomainBatchResponse> TransferInDomainBatch(TransferInDomainBatchRequest req)
        {
             JsonResponseModel<TransferInDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransferInDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferInDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( TransferInDomainBatch ) 用于批量转入域名 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="TransferInDomainBatchRequest"/></param>
        /// <returns><see cref="TransferInDomainBatchResponse"/></returns>
        public TransferInDomainBatchResponse TransferInDomainBatchSync(TransferInDomainBatchRequest req)
        {
             JsonResponseModel<TransferInDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TransferInDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferInDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( TransferInDomainBatch ) 用于批量禁止域名转移 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="TransferProhibitionBatchRequest"/></param>
        /// <returns><see cref="TransferProhibitionBatchResponse"/></returns>
        public async Task<TransferProhibitionBatchResponse> TransferProhibitionBatch(TransferProhibitionBatchRequest req)
        {
             JsonResponseModel<TransferProhibitionBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransferProhibitionBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferProhibitionBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( TransferInDomainBatch ) 用于批量禁止域名转移 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="TransferProhibitionBatchRequest"/></param>
        /// <returns><see cref="TransferProhibitionBatchResponse"/></returns>
        public TransferProhibitionBatchResponse TransferProhibitionBatchSync(TransferProhibitionBatchRequest req)
        {
             JsonResponseModel<TransferProhibitionBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TransferProhibitionBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferProhibitionBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( UpdateProhibitionBatch ) 用于批量设置禁止域名更新 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="UpdateProhibitionBatchRequest"/></param>
        /// <returns><see cref="UpdateProhibitionBatchResponse"/></returns>
        public async Task<UpdateProhibitionBatchResponse> UpdateProhibitionBatch(UpdateProhibitionBatchRequest req)
        {
             JsonResponseModel<UpdateProhibitionBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateProhibitionBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProhibitionBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( UpdateProhibitionBatch ) 用于批量设置禁止域名更新 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="UpdateProhibitionBatchRequest"/></param>
        /// <returns><see cref="UpdateProhibitionBatchResponse"/></returns>
        public UpdateProhibitionBatchResponse UpdateProhibitionBatchSync(UpdateProhibitionBatchRequest req)
        {
             JsonResponseModel<UpdateProhibitionBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateProhibitionBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProhibitionBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( UploadImage ) 用于上传资质照片 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="UploadImageRequest"/></param>
        /// <returns><see cref="UploadImageResponse"/></returns>
        public async Task<UploadImageResponse> UploadImage(UploadImageRequest req)
        {
             JsonResponseModel<UploadImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( UploadImage ) 用于上传资质照片 。
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="UploadImageRequest"/></param>
        /// <returns><see cref="UploadImageResponse"/></returns>
        public UploadImageResponse UploadImageSync(UploadImageRequest req)
        {
             JsonResponseModel<UploadImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
