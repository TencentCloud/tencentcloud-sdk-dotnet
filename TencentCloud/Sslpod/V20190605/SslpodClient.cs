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

namespace TencentCloud.Sslpod.V20190605
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sslpod.V20190605.Models;

   public class SslpodClient : AbstractClient{

       private const string endpoint = "sslpod.tencentcloudapi.com";
       private const string version = "2019-06-05";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SslpodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SslpodClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 通过域名端口添加监控
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public async Task<CreateDomainResponse> CreateDomain(CreateDomainRequest req)
        {
             JsonResponseModel<CreateDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过域名端口添加监控
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public CreateDomainResponse CreateDomainSync(CreateDomainRequest req)
        {
             JsonResponseModel<CreateDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过域名ID删除监控的域名
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public async Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
             JsonResponseModel<DeleteDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过域名ID删除监控的域名
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public DeleteDomainResponse DeleteDomainSync(DeleteDomainRequest req)
        {
             JsonResponseModel<DeleteDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取仪表盘数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public async Task<DescribeDashboardResponse> DescribeDashboard(DescribeDashboardRequest req)
        {
             JsonResponseModel<DescribeDashboardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取仪表盘数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public DescribeDashboardResponse DescribeDashboardSync(DescribeDashboardRequest req)
        {
             JsonResponseModel<DescribeDashboardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名关联证书
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainCertsRequest"/></param>
        /// <returns><see cref="DescribeDomainCertsResponse"/></returns>
        public async Task<DescribeDomainCertsResponse> DescribeDomainCerts(DescribeDomainCertsRequest req)
        {
             JsonResponseModel<DescribeDomainCertsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名关联证书
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainCertsRequest"/></param>
        /// <returns><see cref="DescribeDomainCertsResponse"/></returns>
        public DescribeDomainCertsResponse DescribeDomainCertsSync(DescribeDomainCertsRequest req)
        {
             JsonResponseModel<DescribeDomainCertsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取账号下所有tag
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainTagsRequest"/></param>
        /// <returns><see cref="DescribeDomainTagsResponse"/></returns>
        public async Task<DescribeDomainTagsResponse> DescribeDomainTags(DescribeDomainTagsRequest req)
        {
             JsonResponseModel<DescribeDomainTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取账号下所有tag
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainTagsRequest"/></param>
        /// <returns><see cref="DescribeDomainTagsResponse"/></returns>
        public DescribeDomainTagsResponse DescribeDomainTagsSync(DescribeDomainTagsRequest req)
        {
             JsonResponseModel<DescribeDomainTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过searchType搜索已经添加的域名
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public async Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
             JsonResponseModel<DescribeDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过searchType搜索已经添加的域名
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
             JsonResponseModel<DescribeDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取通知额度信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNoticeInfoRequest"/></param>
        /// <returns><see cref="DescribeNoticeInfoResponse"/></returns>
        public async Task<DescribeNoticeInfoResponse> DescribeNoticeInfo(DescribeNoticeInfoRequest req)
        {
             JsonResponseModel<DescribeNoticeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNoticeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNoticeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取通知额度信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNoticeInfoRequest"/></param>
        /// <returns><see cref="DescribeNoticeInfoResponse"/></returns>
        public DescribeNoticeInfoResponse DescribeNoticeInfoSync(DescribeNoticeInfoRequest req)
        {
             JsonResponseModel<DescribeNoticeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNoticeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNoticeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改域名tag
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainTagsRequest"/></param>
        /// <returns><see cref="ModifyDomainTagsResponse"/></returns>
        public async Task<ModifyDomainTagsResponse> ModifyDomainTags(ModifyDomainTagsRequest req)
        {
             JsonResponseModel<ModifyDomainTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改域名tag
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainTagsRequest"/></param>
        /// <returns><see cref="ModifyDomainTagsResponse"/></returns>
        public ModifyDomainTagsResponse ModifyDomainTagsSync(ModifyDomainTagsRequest req)
        {
             JsonResponseModel<ModifyDomainTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 强制重新检测域名
        /// </summary>
        /// <param name="req"><see cref="RefreshDomainRequest"/></param>
        /// <returns><see cref="RefreshDomainResponse"/></returns>
        public async Task<RefreshDomainResponse> RefreshDomain(RefreshDomainRequest req)
        {
             JsonResponseModel<RefreshDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefreshDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 强制重新检测域名
        /// </summary>
        /// <param name="req"><see cref="RefreshDomainRequest"/></param>
        /// <returns><see cref="RefreshDomainResponse"/></returns>
        public RefreshDomainResponse RefreshDomainSync(RefreshDomainRequest req)
        {
             JsonResponseModel<RefreshDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefreshDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解析域名获得多个IP地址
        /// </summary>
        /// <param name="req"><see cref="ResolveDomainRequest"/></param>
        /// <returns><see cref="ResolveDomainResponse"/></returns>
        public async Task<ResolveDomainResponse> ResolveDomain(ResolveDomainRequest req)
        {
             JsonResponseModel<ResolveDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResolveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResolveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解析域名获得多个IP地址
        /// </summary>
        /// <param name="req"><see cref="ResolveDomainRequest"/></param>
        /// <returns><see cref="ResolveDomainResponse"/></returns>
        public ResolveDomainResponse ResolveDomainSync(ResolveDomainRequest req)
        {
             JsonResponseModel<ResolveDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResolveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResolveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
