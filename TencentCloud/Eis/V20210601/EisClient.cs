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

namespace TencentCloud.Eis.V20210601
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Eis.V20210601.Models;

   public class EisClient : AbstractClient{

       private const string endpoint = "eis.tencentcloudapi.com";
       private const string version = "2021-06-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 获取运行时详情
        /// </summary>
        /// <param name="req"><see cref="GetRuntimeMCRequest"/></param>
        /// <returns><see cref="GetRuntimeMCResponse"/></returns>
        public async Task<GetRuntimeMCResponse> GetRuntimeMC(GetRuntimeMCRequest req)
        {
             JsonResponseModel<GetRuntimeMCResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRuntimeMC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRuntimeMCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取运行时详情
        /// </summary>
        /// <param name="req"><see cref="GetRuntimeMCRequest"/></param>
        /// <returns><see cref="GetRuntimeMCResponse"/></returns>
        public GetRuntimeMCResponse GetRuntimeMCSync(GetRuntimeMCRequest req)
        {
             JsonResponseModel<GetRuntimeMCResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRuntimeMC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRuntimeMCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取运行时资源监控详情，cpu，memory，bandwidth
        /// </summary>
        /// <param name="req"><see cref="GetRuntimeResourceMonitorMetricMCRequest"/></param>
        /// <returns><see cref="GetRuntimeResourceMonitorMetricMCResponse"/></returns>
        public async Task<GetRuntimeResourceMonitorMetricMCResponse> GetRuntimeResourceMonitorMetricMC(GetRuntimeResourceMonitorMetricMCRequest req)
        {
             JsonResponseModel<GetRuntimeResourceMonitorMetricMCResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRuntimeResourceMonitorMetricMC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRuntimeResourceMonitorMetricMCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取运行时资源监控详情，cpu，memory，bandwidth
        /// </summary>
        /// <param name="req"><see cref="GetRuntimeResourceMonitorMetricMCRequest"/></param>
        /// <returns><see cref="GetRuntimeResourceMonitorMetricMCResponse"/></returns>
        public GetRuntimeResourceMonitorMetricMCResponse GetRuntimeResourceMonitorMetricMCSync(GetRuntimeResourceMonitorMetricMCRequest req)
        {
             JsonResponseModel<GetRuntimeResourceMonitorMetricMCResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRuntimeResourceMonitorMetricMC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRuntimeResourceMonitorMetricMCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回用户可用的运行时列表，发布应用时返回的运行时环境，仅shared和private运行时，无sandbox运行时，并且只有running/scaling状态的
        /// </summary>
        /// <param name="req"><see cref="ListDeployableRuntimesMCRequest"/></param>
        /// <returns><see cref="ListDeployableRuntimesMCResponse"/></returns>
        public async Task<ListDeployableRuntimesMCResponse> ListDeployableRuntimesMC(ListDeployableRuntimesMCRequest req)
        {
             JsonResponseModel<ListDeployableRuntimesMCResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListDeployableRuntimesMC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDeployableRuntimesMCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回用户可用的运行时列表，发布应用时返回的运行时环境，仅shared和private运行时，无sandbox运行时，并且只有running/scaling状态的
        /// </summary>
        /// <param name="req"><see cref="ListDeployableRuntimesMCRequest"/></param>
        /// <returns><see cref="ListDeployableRuntimesMCResponse"/></returns>
        public ListDeployableRuntimesMCResponse ListDeployableRuntimesMCSync(ListDeployableRuntimesMCRequest req)
        {
             JsonResponseModel<ListDeployableRuntimesMCResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListDeployableRuntimesMC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDeployableRuntimesMCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取运行时部署的应用实例列表
        /// </summary>
        /// <param name="req"><see cref="ListRuntimeDeployedInstancesMCRequest"/></param>
        /// <returns><see cref="ListRuntimeDeployedInstancesMCResponse"/></returns>
        public async Task<ListRuntimeDeployedInstancesMCResponse> ListRuntimeDeployedInstancesMC(ListRuntimeDeployedInstancesMCRequest req)
        {
             JsonResponseModel<ListRuntimeDeployedInstancesMCResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListRuntimeDeployedInstancesMC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRuntimeDeployedInstancesMCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取运行时部署的应用实例列表
        /// </summary>
        /// <param name="req"><see cref="ListRuntimeDeployedInstancesMCRequest"/></param>
        /// <returns><see cref="ListRuntimeDeployedInstancesMCResponse"/></returns>
        public ListRuntimeDeployedInstancesMCResponse ListRuntimeDeployedInstancesMCSync(ListRuntimeDeployedInstancesMCRequest req)
        {
             JsonResponseModel<ListRuntimeDeployedInstancesMCResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListRuntimeDeployedInstancesMC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRuntimeDeployedInstancesMCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回用户的运行时列表，运行时管理主页使用，包含沙箱、共享运行时及独立运行时环境，不包含已经删除的运行时
        /// </summary>
        /// <param name="req"><see cref="ListRuntimesMCRequest"/></param>
        /// <returns><see cref="ListRuntimesMCResponse"/></returns>
        public async Task<ListRuntimesMCResponse> ListRuntimesMC(ListRuntimesMCRequest req)
        {
             JsonResponseModel<ListRuntimesMCResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListRuntimesMC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRuntimesMCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回用户的运行时列表，运行时管理主页使用，包含沙箱、共享运行时及独立运行时环境，不包含已经删除的运行时
        /// </summary>
        /// <param name="req"><see cref="ListRuntimesMCRequest"/></param>
        /// <returns><see cref="ListRuntimesMCResponse"/></returns>
        public ListRuntimesMCResponse ListRuntimesMCSync(ListRuntimesMCRequest req)
        {
             JsonResponseModel<ListRuntimesMCResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListRuntimesMC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRuntimesMCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
