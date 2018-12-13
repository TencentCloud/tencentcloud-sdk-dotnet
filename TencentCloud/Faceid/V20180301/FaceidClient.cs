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

namespace TencentCloud.Faceid.V20180301
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Faceid.V20180301.Models;

   public class FaceidClient : AbstractClient{

       private const string endpoint = "faceid.tencentcloudapi.com";
       private const string version = "2018-03-01";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public FaceidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public FaceidClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 实名核身鉴权。用于获取一次核身流程的BizToken。如果是微信平台，会同时返回一个URL，用作微信平台的跳转。
        /// </summary>
        /// <param name="req">参考<see cref="DetectAuthRequest"/></param>
        /// <returns>参考<see cref="DetectAuthResponse"/>实例</returns>
        public async Task<DetectAuthResponse> DetectAuth(DetectAuthRequest req)
        {
             JsonResponseModel<DetectAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实名核身结果信息
        /// </summary>
        /// <param name="req">参考<see cref="GetDetectInfoRequest"/></param>
        /// <returns>参考<see cref="GetDetectInfoResponse"/>实例</returns>
        public async Task<GetDetectInfoResponse> GetDetectInfo(GetDetectInfoRequest req)
        {
             JsonResponseModel<GetDetectInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDetectInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDetectInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
