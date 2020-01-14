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

namespace TencentCloud.Cds.V20180420
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cds.V20180420.Models;

   public class CdsClient : AbstractClient{

       private const string endpoint = "cds.tencentcloudapi.com";
       private const string version = "2018-04-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口 (DescribeDbauditInstanceType) 用于查询可售卖的产品规格列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDbauditInstanceTypeRequest"/></param>
        /// <returns><see cref="DescribeDbauditInstanceTypeResponse"/></returns>
        public async Task<DescribeDbauditInstanceTypeResponse> DescribeDbauditInstanceType(DescribeDbauditInstanceTypeRequest req)
        {
             JsonResponseModel<DescribeDbauditInstanceTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDbauditInstanceType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbauditInstanceTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDbauditInstanceType接口的同步版本，本接口 (DescribeDbauditInstanceType) 用于查询可售卖的产品规格列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDbauditInstanceTypeRequest"/></param>
        /// <returns>参考<see cref="DescribeDbauditInstanceTypeResponse"/>实例</returns>
        public DescribeDbauditInstanceTypeResponse DescribeDbauditInstanceTypeSync(DescribeDbauditInstanceTypeRequest req)
        {
             JsonResponseModel<DescribeDbauditInstanceTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDbauditInstanceType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbauditInstanceTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeDbauditInstances) 用于查询数据安全审计实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDbauditInstancesRequest"/></param>
        /// <returns><see cref="DescribeDbauditInstancesResponse"/></returns>
        public async Task<DescribeDbauditInstancesResponse> DescribeDbauditInstances(DescribeDbauditInstancesRequest req)
        {
             JsonResponseModel<DescribeDbauditInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDbauditInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbauditInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDbauditInstances接口的同步版本，本接口 (DescribeDbauditInstances) 用于查询数据安全审计实例列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDbauditInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeDbauditInstancesResponse"/>实例</returns>
        public DescribeDbauditInstancesResponse DescribeDbauditInstancesSync(DescribeDbauditInstancesRequest req)
        {
             JsonResponseModel<DescribeDbauditInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDbauditInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbauditInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeDbauditUsedRegions) 用于查询可售卖地域列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDbauditUsedRegionsRequest"/></param>
        /// <returns><see cref="DescribeDbauditUsedRegionsResponse"/></returns>
        public async Task<DescribeDbauditUsedRegionsResponse> DescribeDbauditUsedRegions(DescribeDbauditUsedRegionsRequest req)
        {
             JsonResponseModel<DescribeDbauditUsedRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDbauditUsedRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbauditUsedRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDbauditUsedRegions接口的同步版本，本接口 (DescribeDbauditUsedRegions) 用于查询可售卖地域列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDbauditUsedRegionsRequest"/></param>
        /// <returns>参考<see cref="DescribeDbauditUsedRegionsResponse"/>实例</returns>
        public DescribeDbauditUsedRegionsResponse DescribeDbauditUsedRegionsSync(DescribeDbauditUsedRegionsRequest req)
        {
             JsonResponseModel<DescribeDbauditUsedRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDbauditUsedRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbauditUsedRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询数据安全审计产品实例价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceDbauditInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceDbauditInstanceResponse"/></returns>
        public async Task<InquiryPriceDbauditInstanceResponse> InquiryPriceDbauditInstance(InquiryPriceDbauditInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceDbauditInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceDbauditInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceDbauditInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceDbauditInstance接口的同步版本，用于查询数据安全审计产品实例价格
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceDbauditInstanceRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceDbauditInstanceResponse"/>实例</returns>
        public InquiryPriceDbauditInstanceResponse InquiryPriceDbauditInstanceSync(InquiryPriceDbauditInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceDbauditInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceDbauditInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceDbauditInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyDbauditInstancesRenewFlag) 用于修改数据安全审计产品实例续费标识
        /// </summary>
        /// <param name="req"><see cref="ModifyDbauditInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDbauditInstancesRenewFlagResponse"/></returns>
        public async Task<ModifyDbauditInstancesRenewFlagResponse> ModifyDbauditInstancesRenewFlag(ModifyDbauditInstancesRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDbauditInstancesRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDbauditInstancesRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDbauditInstancesRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDbauditInstancesRenewFlag接口的同步版本，本接口 (ModifyDbauditInstancesRenewFlag) 用于修改数据安全审计产品实例续费标识
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDbauditInstancesRenewFlagRequest"/></param>
        /// <returns>参考<see cref="ModifyDbauditInstancesRenewFlagResponse"/>实例</returns>
        public ModifyDbauditInstancesRenewFlagResponse ModifyDbauditInstancesRenewFlagSync(ModifyDbauditInstancesRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDbauditInstancesRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDbauditInstancesRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDbauditInstancesRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
