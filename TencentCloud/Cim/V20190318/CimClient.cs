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

namespace TencentCloud.Cim.V20190318
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cim.V20190318.Models;

   public class CimClient : AbstractClient{

       private const string endpoint = "cim.tencentcloudapi.com";
       private const string version = "2019-03-18";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CimClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CimClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 获取云通信IM中腾讯云账号对应的SDKAppID
        /// </summary>
        /// <param name="req"><see cref="DescribeSdkAppidRequest"/></param>
        /// <returns><see cref="DescribeSdkAppidResponse"/></returns>
        public async Task<DescribeSdkAppidResponse> DescribeSdkAppid(DescribeSdkAppidRequest req)
        {
             JsonResponseModel<DescribeSdkAppidResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSdkAppid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSdkAppidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSdkAppid接口的同步版本，获取云通信IM中腾讯云账号对应的SDKAppID
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSdkAppidRequest"/></param>
        /// <returns>参考<see cref="DescribeSdkAppidResponse"/>实例</returns>
        public DescribeSdkAppidResponse DescribeSdkAppidSync(DescribeSdkAppidRequest req)
        {
             JsonResponseModel<DescribeSdkAppidResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSdkAppid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSdkAppidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
