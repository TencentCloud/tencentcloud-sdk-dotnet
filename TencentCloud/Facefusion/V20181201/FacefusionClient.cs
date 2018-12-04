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

namespace TencentCloud.Facefusion.V20181201
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Facefusion.V20181201.Models;

   public class FacefusionClient : AbstractClient{

       private const string endpoint = "facefusion.tencentcloudapi.com";
       private const string version = "2018-12-01";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public FacefusionClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public FacefusionClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口用于人脸融合，用户上传人脸图片，获取与模板融合后的人脸图片。单个活动QPS限制50次/秒。
        /// </summary>
        /// <param name="req">参考<see cref="FaceFusionRequest"/></param>
        /// <returns>参考<see cref="FaceFusionResponse"/>实例</returns>
        public async Task<FaceFusionResponse> FaceFusion(FaceFusionRequest req)
        {
             JsonResponseModel<FaceFusionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FaceFusion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FaceFusionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
