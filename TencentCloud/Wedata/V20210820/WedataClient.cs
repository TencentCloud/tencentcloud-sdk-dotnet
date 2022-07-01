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

namespace TencentCloud.Wedata.V20210820
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Wedata.V20210820.Models;

   public class WedataClient : AbstractClient{

       private const string endpoint = "wedata.tencentcloudapi.com";
       private const string version = "2021-08-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WedataClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WedataClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查询任务实例的关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeRelatedInstancesResponse"/></returns>
        public async Task<DescribeRelatedInstancesResponse> DescribeRelatedInstances(DescribeRelatedInstancesRequest req)
        {
             JsonResponseModel<DescribeRelatedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRelatedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelatedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务实例的关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeRelatedInstancesResponse"/></returns>
        public DescribeRelatedInstancesResponse DescribeRelatedInstancesSync(DescribeRelatedInstancesRequest req)
        {
             JsonResponseModel<DescribeRelatedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRelatedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelatedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeTaskInstancesResponse"/></returns>
        public async Task<DescribeTaskInstancesResponse> DescribeTaskInstances(DescribeTaskInstancesRequest req)
        {
             JsonResponseModel<DescribeTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeTaskInstancesResponse"/></returns>
        public DescribeTaskInstancesResponse DescribeTaskInstancesSync(DescribeTaskInstancesRequest req)
        {
             JsonResponseModel<DescribeTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
