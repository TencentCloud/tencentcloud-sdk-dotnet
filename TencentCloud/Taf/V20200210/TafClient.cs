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

namespace TencentCloud.Taf.V20200210
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Taf.V20200210.Models;

   public class TafClient : AbstractClient{

       private const string endpoint = "taf.tencentcloudapi.com";
       private const string version = "2020-02-10";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TafClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TafClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 流量反欺诈-KOL欺诈识别
        /// </summary>
        /// <param name="req"><see cref="DetectFraudKOLRequest"/></param>
        /// <returns><see cref="DetectFraudKOLResponse"/></returns>
        public async Task<DetectFraudKOLResponse> DetectFraudKOL(DetectFraudKOLRequest req)
        {
             JsonResponseModel<DetectFraudKOLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectFraudKOL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectFraudKOLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 流量反欺诈-KOL欺诈识别
        /// </summary>
        /// <param name="req"><see cref="DetectFraudKOLRequest"/></param>
        /// <returns><see cref="DetectFraudKOLResponse"/></returns>
        public DetectFraudKOLResponse DetectFraudKOLSync(DetectFraudKOLRequest req)
        {
             JsonResponseModel<DetectFraudKOLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectFraudKOL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectFraudKOLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 流量反欺诈-虚假TA识别
        /// </summary>
        /// <param name="req"><see cref="EnhanceTaDegreeRequest"/></param>
        /// <returns><see cref="EnhanceTaDegreeResponse"/></returns>
        public async Task<EnhanceTaDegreeResponse> EnhanceTaDegree(EnhanceTaDegreeRequest req)
        {
             JsonResponseModel<EnhanceTaDegreeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnhanceTaDegree");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnhanceTaDegreeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 流量反欺诈-虚假TA识别
        /// </summary>
        /// <param name="req"><see cref="EnhanceTaDegreeRequest"/></param>
        /// <returns><see cref="EnhanceTaDegreeResponse"/></returns>
        public EnhanceTaDegreeResponse EnhanceTaDegreeSync(EnhanceTaDegreeRequest req)
        {
             JsonResponseModel<EnhanceTaDegreeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnhanceTaDegree");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnhanceTaDegreeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 流量反欺诈-流量验准定制版
        /// </summary>
        /// <param name="req"><see cref="RecognizeCustomizedAudienceRequest"/></param>
        /// <returns><see cref="RecognizeCustomizedAudienceResponse"/></returns>
        public async Task<RecognizeCustomizedAudienceResponse> RecognizeCustomizedAudience(RecognizeCustomizedAudienceRequest req)
        {
             JsonResponseModel<RecognizeCustomizedAudienceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecognizeCustomizedAudience");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeCustomizedAudienceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 流量反欺诈-流量验准定制版
        /// </summary>
        /// <param name="req"><see cref="RecognizeCustomizedAudienceRequest"/></param>
        /// <returns><see cref="RecognizeCustomizedAudienceResponse"/></returns>
        public RecognizeCustomizedAudienceResponse RecognizeCustomizedAudienceSync(RecognizeCustomizedAudienceRequest req)
        {
             JsonResponseModel<RecognizeCustomizedAudienceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecognizeCustomizedAudience");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeCustomizedAudienceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该服务已不再对外提供能力
        /// 
        /// 筛选敏感易骚扰人群
        /// </summary>
        /// <param name="req"><see cref="RecognizeEffectiveFlowRequest"/></param>
        /// <returns><see cref="RecognizeEffectiveFlowResponse"/></returns>
        public async Task<RecognizeEffectiveFlowResponse> RecognizeEffectiveFlow(RecognizeEffectiveFlowRequest req)
        {
             JsonResponseModel<RecognizeEffectiveFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecognizeEffectiveFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeEffectiveFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该服务已不再对外提供能力
        /// 
        /// 筛选敏感易骚扰人群
        /// </summary>
        /// <param name="req"><see cref="RecognizeEffectiveFlowRequest"/></param>
        /// <returns><see cref="RecognizeEffectiveFlowResponse"/></returns>
        public RecognizeEffectiveFlowResponse RecognizeEffectiveFlowSync(RecognizeEffectiveFlowRequest req)
        {
             JsonResponseModel<RecognizeEffectiveFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecognizeEffectiveFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeEffectiveFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 流量反欺诈-流量验准高级版
        /// </summary>
        /// <param name="req"><see cref="RecognizePreciseTargetAudienceRequest"/></param>
        /// <returns><see cref="RecognizePreciseTargetAudienceResponse"/></returns>
        public async Task<RecognizePreciseTargetAudienceResponse> RecognizePreciseTargetAudience(RecognizePreciseTargetAudienceRequest req)
        {
             JsonResponseModel<RecognizePreciseTargetAudienceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecognizePreciseTargetAudience");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizePreciseTargetAudienceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 流量反欺诈-流量验准高级版
        /// </summary>
        /// <param name="req"><see cref="RecognizePreciseTargetAudienceRequest"/></param>
        /// <returns><see cref="RecognizePreciseTargetAudienceResponse"/></returns>
        public RecognizePreciseTargetAudienceResponse RecognizePreciseTargetAudienceSync(RecognizePreciseTargetAudienceRequest req)
        {
             JsonResponseModel<RecognizePreciseTargetAudienceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecognizePreciseTargetAudience");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizePreciseTargetAudienceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 流量反欺诈-流量验准
        /// </summary>
        /// <param name="req"><see cref="RecognizeTargetAudienceRequest"/></param>
        /// <returns><see cref="RecognizeTargetAudienceResponse"/></returns>
        public async Task<RecognizeTargetAudienceResponse> RecognizeTargetAudience(RecognizeTargetAudienceRequest req)
        {
             JsonResponseModel<RecognizeTargetAudienceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecognizeTargetAudience");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeTargetAudienceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 流量反欺诈-流量验准
        /// </summary>
        /// <param name="req"><see cref="RecognizeTargetAudienceRequest"/></param>
        /// <returns><see cref="RecognizeTargetAudienceResponse"/></returns>
        public RecognizeTargetAudienceResponse RecognizeTargetAudienceSync(RecognizeTargetAudienceRequest req)
        {
             JsonResponseModel<RecognizeTargetAudienceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecognizeTargetAudience");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeTargetAudienceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 流量安选产品，短信发送接口
        /// </summary>
        /// <param name="req"><see cref="SendTrafficSecuritySmsMessageRequest"/></param>
        /// <returns><see cref="SendTrafficSecuritySmsMessageResponse"/></returns>
        public async Task<SendTrafficSecuritySmsMessageResponse> SendTrafficSecuritySmsMessage(SendTrafficSecuritySmsMessageRequest req)
        {
             JsonResponseModel<SendTrafficSecuritySmsMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendTrafficSecuritySmsMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendTrafficSecuritySmsMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 流量安选产品，短信发送接口
        /// </summary>
        /// <param name="req"><see cref="SendTrafficSecuritySmsMessageRequest"/></param>
        /// <returns><see cref="SendTrafficSecuritySmsMessageResponse"/></returns>
        public SendTrafficSecuritySmsMessageResponse SendTrafficSecuritySmsMessageSync(SendTrafficSecuritySmsMessageRequest req)
        {
             JsonResponseModel<SendTrafficSecuritySmsMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendTrafficSecuritySmsMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendTrafficSecuritySmsMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
