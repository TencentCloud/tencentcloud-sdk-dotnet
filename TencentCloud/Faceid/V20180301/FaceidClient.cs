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
        /// 银行卡核验
        /// </summary>
        /// <param name="req">参考<see cref="BankCardVerificationRequest"/></param>
        /// <returns>参考<see cref="BankCardVerificationResponse"/>实例</returns>
        public async Task<BankCardVerificationResponse> BankCardVerification(BankCardVerificationRequest req)
        {
             JsonResponseModel<BankCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BankCardVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCardVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次开始核身前，需先调用本接口获取BizToken，用来串联核身流程，在核身完成后，用于获取验证结果信息。
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
        /// 使用动作活体检测模式前，需调用本接口获取动作顺序。
        /// </summary>
        /// <param name="req">参考<see cref="GetActionSequenceRequest"/></param>
        /// <returns>参考<see cref="GetActionSequenceResponse"/>实例</returns>
        public async Task<GetActionSequenceResponse> GetActionSequence(GetActionSequenceRequest req)
        {
             JsonResponseModel<GetActionSequenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetActionSequence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetActionSequenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成验证后，用BizToken调用本接口获取结果信息，BizToken生成后三天内（3\*24\*3,600秒）可多次拉取。
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

        /// <summary>
        /// 使用数字活体检测模式前，需调用本接口获取数字验证码。
        /// </summary>
        /// <param name="req">参考<see cref="GetLiveCodeRequest"/></param>
        /// <returns>参考<see cref="GetLiveCodeResponse"/>实例</returns>
        public async Task<GetLiveCodeResponse> GetLiveCode(GetLiveCodeRequest req)
        {
             JsonResponseModel<GetLiveCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetLiveCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLiveCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入姓名和身份证号，校验两者的真实性和一致性。
        /// </summary>
        /// <param name="req">参考<see cref="IdCardVerificationRequest"/></param>
        /// <returns>参考<see cref="IdCardVerificationResponse"/>实例</returns>
        public async Task<IdCardVerificationResponse> IdCardVerification(IdCardVerificationRequest req)
        {
             JsonResponseModel<IdCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IdCardVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IdCardVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入照片和身份信息，判断该照片与公安权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req">参考<see cref="ImageRecognitionRequest"/></param>
        /// <returns>参考<see cref="ImageRecognitionResponse"/>实例</returns>
        public async Task<ImageRecognitionResponse> ImageRecognition(ImageRecognitionRequest req)
        {
             JsonResponseModel<ImageRecognitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImageRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入视频和照片，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与上传照片是否属于同一个人。
        /// </summary>
        /// <param name="req">参考<see cref="LivenessCompareRequest"/></param>
        /// <returns>参考<see cref="LivenessCompareResponse"/>实例</returns>
        public async Task<LivenessCompareResponse> LivenessCompare(LivenessCompareRequest req)
        {
             JsonResponseModel<LivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LivenessCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入视频和身份信息，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与公安权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req">参考<see cref="LivenessRecognitionRequest"/></param>
        /// <returns>参考<see cref="LivenessRecognitionResponse"/>实例</returns>
        public async Task<LivenessRecognitionResponse> LivenessRecognition(LivenessRecognitionRequest req)
        {
             JsonResponseModel<LivenessRecognitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LivenessRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
