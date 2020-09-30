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
        /// 本接口 ( CheckBatchStatus ) 用于检查批量任务状态 。
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
        /// 本接口 ( CheckBatchStatus ) 用于检查批量任务状态 。
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

    }
}
