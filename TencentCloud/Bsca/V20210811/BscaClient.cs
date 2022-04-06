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

namespace TencentCloud.Bsca.V20210811
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bsca.V20210811.Models;

   public class BscaClient : AbstractClient{

       private const string endpoint = "bsca.tencentcloudapi.com";
       private const string version = "2021-08-11";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BscaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BscaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口(DescribeKBComponent)用于在知识库中查询开源组件信息。本接口根据用户输入的PURL在知识库中寻找对应的开源组件，其中Name为必填字段。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBComponentRequest"/></param>
        /// <returns><see cref="DescribeKBComponentResponse"/></returns>
        public async Task<DescribeKBComponentResponse> DescribeKBComponent(DescribeKBComponentRequest req)
        {
             JsonResponseModel<DescribeKBComponentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKBComponent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKBComponentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeKBComponent)用于在知识库中查询开源组件信息。本接口根据用户输入的PURL在知识库中寻找对应的开源组件，其中Name为必填字段。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBComponentRequest"/></param>
        /// <returns><see cref="DescribeKBComponentResponse"/></returns>
        public DescribeKBComponentResponse DescribeKBComponentSync(DescribeKBComponentRequest req)
        {
             JsonResponseModel<DescribeKBComponentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKBComponent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKBComponentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeKBComponentVulnerability)用于在知识库中查询开源组件的漏洞信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBComponentVulnerabilityRequest"/></param>
        /// <returns><see cref="DescribeKBComponentVulnerabilityResponse"/></returns>
        public async Task<DescribeKBComponentVulnerabilityResponse> DescribeKBComponentVulnerability(DescribeKBComponentVulnerabilityRequest req)
        {
             JsonResponseModel<DescribeKBComponentVulnerabilityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKBComponentVulnerability");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKBComponentVulnerabilityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeKBComponentVulnerability)用于在知识库中查询开源组件的漏洞信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBComponentVulnerabilityRequest"/></param>
        /// <returns><see cref="DescribeKBComponentVulnerabilityResponse"/></returns>
        public DescribeKBComponentVulnerabilityResponse DescribeKBComponentVulnerabilitySync(DescribeKBComponentVulnerabilityRequest req)
        {
             JsonResponseModel<DescribeKBComponentVulnerabilityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKBComponentVulnerability");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKBComponentVulnerabilityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeKBLicense)用于在知识库中查询许可证信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBLicenseRequest"/></param>
        /// <returns><see cref="DescribeKBLicenseResponse"/></returns>
        public async Task<DescribeKBLicenseResponse> DescribeKBLicense(DescribeKBLicenseRequest req)
        {
             JsonResponseModel<DescribeKBLicenseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKBLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKBLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeKBLicense)用于在知识库中查询许可证信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBLicenseRequest"/></param>
        /// <returns><see cref="DescribeKBLicenseResponse"/></returns>
        public DescribeKBLicenseResponse DescribeKBLicenseSync(DescribeKBLicenseRequest req)
        {
             JsonResponseModel<DescribeKBLicenseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKBLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKBLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeKBVulnerability)用于在知识库中查询漏洞详细信息，支持根据CVE ID查询或者根据Vul ID查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBVulnerabilityRequest"/></param>
        /// <returns><see cref="DescribeKBVulnerabilityResponse"/></returns>
        public async Task<DescribeKBVulnerabilityResponse> DescribeKBVulnerability(DescribeKBVulnerabilityRequest req)
        {
             JsonResponseModel<DescribeKBVulnerabilityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKBVulnerability");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKBVulnerabilityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeKBVulnerability)用于在知识库中查询漏洞详细信息，支持根据CVE ID查询或者根据Vul ID查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBVulnerabilityRequest"/></param>
        /// <returns><see cref="DescribeKBVulnerabilityResponse"/></returns>
        public DescribeKBVulnerabilityResponse DescribeKBVulnerabilitySync(DescribeKBVulnerabilityRequest req)
        {
             JsonResponseModel<DescribeKBVulnerabilityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKBVulnerability");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKBVulnerabilityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
