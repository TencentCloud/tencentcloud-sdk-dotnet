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

namespace TencentCloud.Trdp.V20220726
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trdp.V20220726.Models;

   public class TrdpClient : AbstractClient{

       private const string endpoint = "trdp.tencentcloudapi.com";
       private const string version = "2022-07-26";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrdpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrdpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用户风险质量接口
        /// </summary>
        /// <param name="req"><see cref="EvaluateUserRiskRequest"/></param>
        /// <returns><see cref="EvaluateUserRiskResponse"/></returns>
        public async Task<EvaluateUserRiskResponse> EvaluateUserRisk(EvaluateUserRiskRequest req)
        {
             JsonResponseModel<EvaluateUserRiskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EvaluateUserRisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EvaluateUserRiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户风险质量接口
        /// </summary>
        /// <param name="req"><see cref="EvaluateUserRiskRequest"/></param>
        /// <returns><see cref="EvaluateUserRiskResponse"/></returns>
        public EvaluateUserRiskResponse EvaluateUserRiskSync(EvaluateUserRiskRequest req)
        {
             JsonResponseModel<EvaluateUserRiskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EvaluateUserRisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EvaluateUserRiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
