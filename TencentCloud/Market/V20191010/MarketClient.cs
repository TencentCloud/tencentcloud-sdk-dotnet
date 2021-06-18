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

namespace TencentCloud.Market.V20191010
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Market.V20191010.Models;

   public class MarketClient : AbstractClient{

       private const string endpoint = "market.tencentcloudapi.com";
       private const string version = "2019-10-10";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MarketClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MarketClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 计量商品用量提醒，用于服务商调用云服务，云服务向客户发送提醒信息
        /// </summary>
        /// <param name="req"><see cref="FlowProductRemindRequest"/></param>
        /// <returns><see cref="FlowProductRemindResponse"/></returns>
        public async Task<FlowProductRemindResponse> FlowProductRemind(FlowProductRemindRequest req)
        {
             JsonResponseModel<FlowProductRemindResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FlowProductRemind");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FlowProductRemindResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 计量商品用量提醒，用于服务商调用云服务，云服务向客户发送提醒信息
        /// </summary>
        /// <param name="req"><see cref="FlowProductRemindRequest"/></param>
        /// <returns><see cref="FlowProductRemindResponse"/></returns>
        public FlowProductRemindResponse FlowProductRemindSync(FlowProductRemindRequest req)
        {
             JsonResponseModel<FlowProductRemindResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FlowProductRemind");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FlowProductRemindResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类名称
        /// </summary>
        /// <param name="req"><see cref="GetCateTreeRequest"/></param>
        /// <returns><see cref="GetCateTreeResponse"/></returns>
        public async Task<GetCateTreeResponse> GetCateTree(GetCateTreeRequest req)
        {
             JsonResponseModel<GetCateTreeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCateTree");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCateTreeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类名称
        /// </summary>
        /// <param name="req"><see cref="GetCateTreeRequest"/></param>
        /// <returns><see cref="GetCateTreeResponse"/></returns>
        public GetCateTreeResponse GetCateTreeSync(GetCateTreeRequest req)
        {
             JsonResponseModel<GetCateTreeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCateTree");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCateTreeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口可以根据InstanceId查询实例的api的使用情况。
        /// </summary>
        /// <param name="req"><see cref="GetUsagePlanUsageAmountRequest"/></param>
        /// <returns><see cref="GetUsagePlanUsageAmountResponse"/></returns>
        public async Task<GetUsagePlanUsageAmountResponse> GetUsagePlanUsageAmount(GetUsagePlanUsageAmountRequest req)
        {
             JsonResponseModel<GetUsagePlanUsageAmountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUsagePlanUsageAmount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUsagePlanUsageAmountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口可以根据InstanceId查询实例的api的使用情况。
        /// </summary>
        /// <param name="req"><see cref="GetUsagePlanUsageAmountRequest"/></param>
        /// <returns><see cref="GetUsagePlanUsageAmountResponse"/></returns>
        public GetUsagePlanUsageAmountResponse GetUsagePlanUsageAmountSync(GetUsagePlanUsageAmountRequest req)
        {
             JsonResponseModel<GetUsagePlanUsageAmountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetUsagePlanUsageAmount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUsagePlanUsageAmountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
