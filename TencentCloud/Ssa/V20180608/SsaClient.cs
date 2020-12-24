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

namespace TencentCloud.Ssa.V20180608
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ssa.V20180608.Models;

   public class SsaClient : AbstractClient{

       private const string endpoint = "ssa.tencentcloudapi.com";
       private const string version = "2018-06-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SsaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SsaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 资产安全页资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailResponse"/></returns>
        public async Task<DescribeAssetDetailResponse> DescribeAssetDetail(DescribeAssetDetailRequest req)
        {
             JsonResponseModel<DescribeAssetDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资产安全页资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailResponse"/></returns>
        public DescribeAssetDetailResponse DescribeAssetDetailSync(DescribeAssetDetailRequest req)
        {
             JsonResponseModel<DescribeAssetDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资产安全资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetListRequest"/></param>
        /// <returns><see cref="DescribeAssetListResponse"/></returns>
        public async Task<DescribeAssetListResponse> DescribeAssetList(DescribeAssetListRequest req)
        {
             JsonResponseModel<DescribeAssetListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资产安全资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetListRequest"/></param>
        /// <returns><see cref="DescribeAssetListResponse"/></returns>
        public DescribeAssetListResponse DescribeAssetListSync(DescribeAssetListRequest req)
        {
             JsonResponseModel<DescribeAssetListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资产测绘-测绘列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetsMappingListRequest"/></param>
        /// <returns><see cref="DescribeAssetsMappingListResponse"/></returns>
        public async Task<DescribeAssetsMappingListResponse> DescribeAssetsMappingList(DescribeAssetsMappingListRequest req)
        {
             JsonResponseModel<DescribeAssetsMappingListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetsMappingList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetsMappingListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资产测绘-测绘列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetsMappingListRequest"/></param>
        /// <returns><see cref="DescribeAssetsMappingListResponse"/></returns>
        public DescribeAssetsMappingListResponse DescribeAssetsMappingListSync(DescribeAssetsMappingListRequest req)
        {
             JsonResponseModel<DescribeAssetsMappingListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetsMappingList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetsMappingListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云安全配置管理资产组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConfigAssetListRequest"/></param>
        /// <returns><see cref="DescribeCheckConfigAssetListResponse"/></returns>
        public async Task<DescribeCheckConfigAssetListResponse> DescribeCheckConfigAssetList(DescribeCheckConfigAssetListRequest req)
        {
             JsonResponseModel<DescribeCheckConfigAssetListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCheckConfigAssetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckConfigAssetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云安全配置管理资产组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConfigAssetListRequest"/></param>
        /// <returns><see cref="DescribeCheckConfigAssetListResponse"/></returns>
        public DescribeCheckConfigAssetListResponse DescribeCheckConfigAssetListSync(DescribeCheckConfigAssetListRequest req)
        {
             JsonResponseModel<DescribeCheckConfigAssetListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCheckConfigAssetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckConfigAssetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云安全配置检查项详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConfigDetailRequest"/></param>
        /// <returns><see cref="DescribeCheckConfigDetailResponse"/></returns>
        public async Task<DescribeCheckConfigDetailResponse> DescribeCheckConfigDetail(DescribeCheckConfigDetailRequest req)
        {
             JsonResponseModel<DescribeCheckConfigDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCheckConfigDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckConfigDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云安全配置检查项详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConfigDetailRequest"/></param>
        /// <returns><see cref="DescribeCheckConfigDetailResponse"/></returns>
        public DescribeCheckConfigDetailResponse DescribeCheckConfigDetailSync(DescribeCheckConfigDetailRequest req)
        {
             JsonResponseModel<DescribeCheckConfigDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCheckConfigDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckConfigDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合规管理检查项详情
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceDetailRequest"/></param>
        /// <returns><see cref="DescribeComplianceDetailResponse"/></returns>
        public async Task<DescribeComplianceDetailResponse> DescribeComplianceDetail(DescribeComplianceDetailRequest req)
        {
             JsonResponseModel<DescribeComplianceDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComplianceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合规管理检查项详情
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceDetailRequest"/></param>
        /// <returns><see cref="DescribeComplianceDetailResponse"/></returns>
        public DescribeComplianceDetailResponse DescribeComplianceDetailSync(DescribeComplianceDetailRequest req)
        {
             JsonResponseModel<DescribeComplianceDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComplianceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合规管理总览页检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceListRequest"/></param>
        /// <returns><see cref="DescribeComplianceListResponse"/></returns>
        public async Task<DescribeComplianceListResponse> DescribeComplianceList(DescribeComplianceListRequest req)
        {
             JsonResponseModel<DescribeComplianceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComplianceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合规管理总览页检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceListRequest"/></param>
        /// <returns><see cref="DescribeComplianceListResponse"/></returns>
        public DescribeComplianceListResponse DescribeComplianceListSync(DescribeComplianceListRequest req)
        {
             JsonResponseModel<DescribeComplianceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComplianceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云配置检查项总览页检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigListRequest"/></param>
        /// <returns><see cref="DescribeConfigListResponse"/></returns>
        public async Task<DescribeConfigListResponse> DescribeConfigList(DescribeConfigListRequest req)
        {
             JsonResponseModel<DescribeConfigListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云配置检查项总览页检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigListRequest"/></param>
        /// <returns><see cref="DescribeConfigListResponse"/></returns>
        public DescribeConfigListResponse DescribeConfigListSync(DescribeConfigListRequest req)
        {
             JsonResponseModel<DescribeConfigListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEventDetailRequest"/></param>
        /// <returns><see cref="DescribeEventDetailResponse"/></returns>
        public async Task<DescribeEventDetailResponse> DescribeEventDetail(DescribeEventDetailRequest req)
        {
             JsonResponseModel<DescribeEventDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEventDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEventDetailRequest"/></param>
        /// <returns><see cref="DescribeEventDetailResponse"/></returns>
        public DescribeEventDetailResponse DescribeEventDetailSync(DescribeEventDetailRequest req)
        {
             JsonResponseModel<DescribeEventDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEventDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取泄露列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLeakDetectionListRequest"/></param>
        /// <returns><see cref="DescribeLeakDetectionListResponse"/></returns>
        public async Task<DescribeLeakDetectionListResponse> DescribeLeakDetectionList(DescribeLeakDetectionListRequest req)
        {
             JsonResponseModel<DescribeLeakDetectionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLeakDetectionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLeakDetectionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取泄露列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLeakDetectionListRequest"/></param>
        /// <returns><see cref="DescribeLeakDetectionListResponse"/></returns>
        public DescribeLeakDetectionListResponse DescribeLeakDetectionListSync(DescribeLeakDetectionListRequest req)
        {
             JsonResponseModel<DescribeLeakDetectionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLeakDetectionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLeakDetectionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSafetyEventListRequest"/></param>
        /// <returns><see cref="DescribeSafetyEventListResponse"/></returns>
        public async Task<DescribeSafetyEventListResponse> DescribeSafetyEventList(DescribeSafetyEventListRequest req)
        {
             JsonResponseModel<DescribeSafetyEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSafetyEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSafetyEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSafetyEventListRequest"/></param>
        /// <returns><see cref="DescribeSafetyEventListResponse"/></returns>
        public DescribeSafetyEventListResponse DescribeSafetyEventListSync(DescribeSafetyEventListRequest req)
        {
             JsonResponseModel<DescribeSafetyEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSafetyEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSafetyEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞管理页，获取漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulListRequest"/></param>
        /// <returns><see cref="DescribeVulListResponse"/></returns>
        public async Task<DescribeVulListResponse> DescribeVulList(DescribeVulListRequest req)
        {
             JsonResponseModel<DescribeVulListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞管理页，获取漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulListRequest"/></param>
        /// <returns><see cref="DescribeVulListResponse"/></returns>
        public DescribeVulListResponse DescribeVulListSync(DescribeVulListRequest req)
        {
             JsonResponseModel<DescribeVulListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询【通用字段】【泄露监测数据列表】
        /// </summary>
        /// <param name="req"><see cref="SaDivulgeDataQueryPubRequest"/></param>
        /// <returns><see cref="SaDivulgeDataQueryPubResponse"/></returns>
        public async Task<SaDivulgeDataQueryPubResponse> SaDivulgeDataQueryPub(SaDivulgeDataQueryPubRequest req)
        {
             JsonResponseModel<SaDivulgeDataQueryPubResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SaDivulgeDataQueryPub");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SaDivulgeDataQueryPubResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询【通用字段】【泄露监测数据列表】
        /// </summary>
        /// <param name="req"><see cref="SaDivulgeDataQueryPubRequest"/></param>
        /// <returns><see cref="SaDivulgeDataQueryPubResponse"/></returns>
        public SaDivulgeDataQueryPubResponse SaDivulgeDataQueryPubSync(SaDivulgeDataQueryPubRequest req)
        {
             JsonResponseModel<SaDivulgeDataQueryPubResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SaDivulgeDataQueryPub");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SaDivulgeDataQueryPubResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
