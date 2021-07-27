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

namespace TencentCloud.Tse.V20201207
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tse.V20201207.Models;

   public class TseClient : AbstractClient{

       private const string endpoint = "tse.tencentcloudapi.com";
       private const string version = "2020-12-07";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TseClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查询微服务注册引擎实例访问地址
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstanceAccessAddressRequest"/></param>
        /// <returns><see cref="DescribeSREInstanceAccessAddressResponse"/></returns>
        public async Task<DescribeSREInstanceAccessAddressResponse> DescribeSREInstanceAccessAddress(DescribeSREInstanceAccessAddressRequest req)
        {
             JsonResponseModel<DescribeSREInstanceAccessAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSREInstanceAccessAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstanceAccessAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微服务注册引擎实例访问地址
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstanceAccessAddressRequest"/></param>
        /// <returns><see cref="DescribeSREInstanceAccessAddressResponse"/></returns>
        public DescribeSREInstanceAccessAddressResponse DescribeSREInstanceAccessAddressSync(DescribeSREInstanceAccessAddressRequest req)
        {
             JsonResponseModel<DescribeSREInstanceAccessAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSREInstanceAccessAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstanceAccessAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询微服务引擎实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstancesRequest"/></param>
        /// <returns><see cref="DescribeSREInstancesResponse"/></returns>
        public async Task<DescribeSREInstancesResponse> DescribeSREInstances(DescribeSREInstancesRequest req)
        {
             JsonResponseModel<DescribeSREInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSREInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询微服务引擎实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstancesRequest"/></param>
        /// <returns><see cref="DescribeSREInstancesResponse"/></returns>
        public DescribeSREInstancesResponse DescribeSREInstancesSync(DescribeSREInstancesRequest req)
        {
             JsonResponseModel<DescribeSREInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSREInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
