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

namespace TencentCloud.Hai.V20230812
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Hai.V20230812.Models;

   public class HaiClient : AbstractClient{

       private const string endpoint = "hai.tencentcloudapi.com";
       private const string version = "2023-08-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public HaiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public HaiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查询应用
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public async Task<DescribeApplicationsResponse> DescribeApplications(DescribeApplicationsRequest req)
        {
             JsonResponseModel<DescribeApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询应用
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public DescribeApplicationsResponse DescribeApplicationsSync(DescribeApplicationsRequest req)
        {
             JsonResponseModel<DescribeApplicationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例的网络配置及消耗情况
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNetworkStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceNetworkStatusResponse"/></returns>
        public async Task<DescribeInstanceNetworkStatusResponse> DescribeInstanceNetworkStatus(DescribeInstanceNetworkStatusRequest req)
        {
             JsonResponseModel<DescribeInstanceNetworkStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceNetworkStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceNetworkStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例的网络配置及消耗情况
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNetworkStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceNetworkStatusResponse"/></returns>
        public DescribeInstanceNetworkStatusResponse DescribeInstanceNetworkStatusSync(DescribeInstanceNetworkStatusRequest req)
        {
             JsonResponseModel<DescribeInstanceNetworkStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceNetworkStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceNetworkStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询场景
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public async Task<DescribeScenesResponse> DescribeScenes(DescribeScenesRequest req)
        {
             JsonResponseModel<DescribeScenesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScenes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScenesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询场景
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public DescribeScenesResponse DescribeScenesSync(DescribeScenesRequest req)
        {
             JsonResponseModel<DescribeScenesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScenes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScenesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务登录配置
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceLoginSettingsRequest"/></param>
        /// <returns><see cref="DescribeServiceLoginSettingsResponse"/></returns>
        public async Task<DescribeServiceLoginSettingsResponse> DescribeServiceLoginSettings(DescribeServiceLoginSettingsRequest req)
        {
             JsonResponseModel<DescribeServiceLoginSettingsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceLoginSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceLoginSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务登录配置
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceLoginSettingsRequest"/></param>
        /// <returns><see cref="DescribeServiceLoginSettingsResponse"/></returns>
        public DescribeServiceLoginSettingsResponse DescribeServiceLoginSettingsSync(DescribeServiceLoginSettingsRequest req)
        {
             JsonResponseModel<DescribeServiceLoginSettingsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceLoginSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceLoginSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquirePriceRunInstances) 用于实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRunInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRunInstancesResponse"/></returns>
        public async Task<InquirePriceRunInstancesResponse> InquirePriceRunInstances(InquirePriceRunInstancesRequest req)
        {
             JsonResponseModel<InquirePriceRunInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceRunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquirePriceRunInstances) 用于实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRunInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRunInstancesResponse"/></returns>
        public InquirePriceRunInstancesResponse InquirePriceRunInstancesSync(InquirePriceRunInstancesRequest req)
        {
             JsonResponseModel<InquirePriceRunInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceRunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (RunInstances) 用于创建一个或多个指定配置的实例。
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public async Task<RunInstancesResponse> RunInstances(RunInstancesRequest req)
        {
             JsonResponseModel<RunInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (RunInstances) 用于创建一个或多个指定配置的实例。
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public RunInstancesResponse RunInstancesSync(RunInstancesRequest req)
        {
             JsonResponseModel<RunInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (TerminateInstances) 用于主动退还实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public async Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (TerminateInstances) 用于主动退还实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
