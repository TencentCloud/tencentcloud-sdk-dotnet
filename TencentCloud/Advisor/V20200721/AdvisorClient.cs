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

namespace TencentCloud.Advisor.V20200721
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Advisor.V20200721.Models;

   public class AdvisorClient : AbstractClient{

       private const string endpoint = "advisor.tencentcloudapi.com";
       private const string version = "2020-07-21";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AdvisorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AdvisorClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用于查询评估项的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategiesRequest"/></param>
        /// <returns><see cref="DescribeStrategiesResponse"/></returns>
        public async Task<DescribeStrategiesResponse> DescribeStrategies(DescribeStrategiesRequest req)
        {
             JsonResponseModel<DescribeStrategiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStrategies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStrategiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询评估项的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategiesRequest"/></param>
        /// <returns><see cref="DescribeStrategiesResponse"/></returns>
        public DescribeStrategiesResponse DescribeStrategiesSync(DescribeStrategiesRequest req)
        {
             JsonResponseModel<DescribeStrategiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStrategies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStrategiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询评估项风险实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStrategyRisksRequest"/></param>
        /// <returns><see cref="DescribeTaskStrategyRisksResponse"/></returns>
        public async Task<DescribeTaskStrategyRisksResponse> DescribeTaskStrategyRisks(DescribeTaskStrategyRisksRequest req)
        {
             JsonResponseModel<DescribeTaskStrategyRisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskStrategyRisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStrategyRisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询评估项风险实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStrategyRisksRequest"/></param>
        /// <returns><see cref="DescribeTaskStrategyRisksResponse"/></returns>
        public DescribeTaskStrategyRisksResponse DescribeTaskStrategyRisksSync(DescribeTaskStrategyRisksRequest req)
        {
             JsonResponseModel<DescribeTaskStrategyRisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskStrategyRisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStrategyRisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
