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

namespace TencentCloud.Tds.V20220801
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tds.V20220801.Models;

   public class TdsClient : AbstractClient{

       private const string endpoint = "tds.tencentcloudapi.com";
       private const string version = "2022-08-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TdsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查询设备风险
        /// </summary>
        /// <param name="req"><see cref="DescribeFraudBaseRequest"/></param>
        /// <returns><see cref="DescribeFraudBaseResponse"/></returns>
        public async Task<DescribeFraudBaseResponse> DescribeFraudBase(DescribeFraudBaseRequest req)
        {
             JsonResponseModel<DescribeFraudBaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFraudBase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFraudBaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备风险
        /// </summary>
        /// <param name="req"><see cref="DescribeFraudBaseRequest"/></param>
        /// <returns><see cref="DescribeFraudBaseResponse"/></returns>
        public DescribeFraudBaseResponse DescribeFraudBaseSync(DescribeFraudBaseRequest req)
        {
             JsonResponseModel<DescribeFraudBaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFraudBase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFraudBaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备标识及风险
        /// </summary>
        /// <param name="req"><see cref="DescribeFraudPremiumRequest"/></param>
        /// <returns><see cref="DescribeFraudPremiumResponse"/></returns>
        public async Task<DescribeFraudPremiumResponse> DescribeFraudPremium(DescribeFraudPremiumRequest req)
        {
             JsonResponseModel<DescribeFraudPremiumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFraudPremium");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFraudPremiumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备标识及风险
        /// </summary>
        /// <param name="req"><see cref="DescribeFraudPremiumRequest"/></param>
        /// <returns><see cref="DescribeFraudPremiumResponse"/></returns>
        public DescribeFraudPremiumResponse DescribeFraudPremiumSync(DescribeFraudPremiumRequest req)
        {
             JsonResponseModel<DescribeFraudPremiumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFraudPremium");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFraudPremiumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备标识
        /// </summary>
        /// <param name="req"><see cref="DescribeTrustedIDRequest"/></param>
        /// <returns><see cref="DescribeTrustedIDResponse"/></returns>
        public async Task<DescribeTrustedIDResponse> DescribeTrustedID(DescribeTrustedIDRequest req)
        {
             JsonResponseModel<DescribeTrustedIDResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrustedID");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrustedIDResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备标识
        /// </summary>
        /// <param name="req"><see cref="DescribeTrustedIDRequest"/></param>
        /// <returns><see cref="DescribeTrustedIDResponse"/></returns>
        public DescribeTrustedIDResponse DescribeTrustedIDSync(DescribeTrustedIDRequest req)
        {
             JsonResponseModel<DescribeTrustedIDResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrustedID");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrustedIDResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
