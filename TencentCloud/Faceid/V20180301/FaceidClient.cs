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
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FaceidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FaceidClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口用于校验姓名和银行卡号的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard2EVerificationRequest"/></param>
        /// <returns><see cref="BankCard2EVerificationResponse"/></returns>
        public async Task<BankCard2EVerificationResponse> BankCard2EVerification(BankCard2EVerificationRequest req)
        {
             JsonResponseModel<BankCard2EVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BankCard2EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCard2EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验姓名和银行卡号的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard2EVerificationRequest"/></param>
        /// <returns><see cref="BankCard2EVerificationResponse"/></returns>
        public BankCard2EVerificationResponse BankCard2EVerificationSync(BankCard2EVerificationRequest req)
        {
             JsonResponseModel<BankCard2EVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BankCard2EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCard2EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于输入银行卡号、姓名、开户证件号、开户手机号，校验信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard4EVerificationRequest"/></param>
        /// <returns><see cref="BankCard4EVerificationResponse"/></returns>
        public async Task<BankCard4EVerificationResponse> BankCard4EVerification(BankCard4EVerificationRequest req)
        {
             JsonResponseModel<BankCard4EVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BankCard4EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCard4EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于输入银行卡号、姓名、开户证件号、开户手机号，校验信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard4EVerificationRequest"/></param>
        /// <returns><see cref="BankCard4EVerificationResponse"/></returns>
        public BankCard4EVerificationResponse BankCard4EVerificationSync(BankCard4EVerificationRequest req)
        {
             JsonResponseModel<BankCard4EVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BankCard4EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCard4EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于银行卡号、姓名、开户证件号信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCardVerificationRequest"/></param>
        /// <returns><see cref="BankCardVerificationResponse"/></returns>
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
        /// 本接口用于银行卡号、姓名、开户证件号信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCardVerificationRequest"/></param>
        /// <returns><see cref="BankCardVerificationResponse"/></returns>
        public BankCardVerificationResponse BankCardVerificationSync(BankCardVerificationRequest req)
        {
             JsonResponseModel<BankCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BankCardVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCardVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 银行卡基础信息查询
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardInformationRequest"/></param>
        /// <returns><see cref="CheckBankCardInformationResponse"/></returns>
        public async Task<CheckBankCardInformationResponse> CheckBankCardInformation(CheckBankCardInformationRequest req)
        {
             JsonResponseModel<CheckBankCardInformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckBankCardInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCardInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 银行卡基础信息查询
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardInformationRequest"/></param>
        /// <returns><see cref="CheckBankCardInformationResponse"/></returns>
        public CheckBankCardInformationResponse CheckBankCardInformationSync(CheckBankCardInformationRequest req)
        {
             JsonResponseModel<CheckBankCardInformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckBankCardInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCardInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入身份证人像面照片，识别身份证照片上的信息，并将姓名、身份证号、身份证人像照片与公安权威库的证件照进行比对，是否属于同一个人，从而验证身份证信息的真实性。
        /// </summary>
        /// <param name="req"><see cref="CheckIdCardInformationRequest"/></param>
        /// <returns><see cref="CheckIdCardInformationResponse"/></returns>
        public async Task<CheckIdCardInformationResponse> CheckIdCardInformation(CheckIdCardInformationRequest req)
        {
             JsonResponseModel<CheckIdCardInformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckIdCardInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIdCardInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入身份证人像面照片，识别身份证照片上的信息，并将姓名、身份证号、身份证人像照片与公安权威库的证件照进行比对，是否属于同一个人，从而验证身份证信息的真实性。
        /// </summary>
        /// <param name="req"><see cref="CheckIdCardInformationRequest"/></param>
        /// <returns><see cref="CheckIdCardInformationResponse"/></returns>
        public CheckIdCardInformationResponse CheckIdCardInformationSync(CheckIdCardInformationRequest req)
        {
             JsonResponseModel<CheckIdCardInformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckIdCardInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIdCardInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验手机号和姓名的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="CheckPhoneAndNameRequest"/></param>
        /// <returns><see cref="CheckPhoneAndNameResponse"/></returns>
        public async Task<CheckPhoneAndNameResponse> CheckPhoneAndName(CheckPhoneAndNameRequest req)
        {
             JsonResponseModel<CheckPhoneAndNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckPhoneAndName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckPhoneAndNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验手机号和姓名的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="CheckPhoneAndNameRequest"/></param>
        /// <returns><see cref="CheckPhoneAndNameResponse"/></returns>
        public CheckPhoneAndNameResponse CheckPhoneAndNameSync(CheckPhoneAndNameRequest req)
        {
             JsonResponseModel<CheckPhoneAndNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckPhoneAndName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckPhoneAndNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用人脸核身SaaS化服务前，需先调用本接口获取BizToken，用来串联核身流程，在验证完成后，用于获取验证结果信息。
        /// </summary>
        /// <param name="req"><see cref="DetectAuthRequest"/></param>
        /// <returns><see cref="DetectAuthResponse"/></returns>
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
        /// 每次调用人脸核身SaaS化服务前，需先调用本接口获取BizToken，用来串联核身流程，在验证完成后，用于获取验证结果信息。
        /// </summary>
        /// <param name="req"><see cref="DetectAuthRequest"/></param>
        /// <returns><see cref="DetectAuthResponse"/></returns>
        public DetectAuthResponse DetectAuthSync(DetectAuthRequest req)
        {
             JsonResponseModel<DetectAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectAuth");
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
        /// <param name="req"><see cref="GetActionSequenceRequest"/></param>
        /// <returns><see cref="GetActionSequenceResponse"/></returns>
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
        /// 使用动作活体检测模式前，需调用本接口获取动作顺序。
        /// </summary>
        /// <param name="req"><see cref="GetActionSequenceRequest"/></param>
        /// <returns><see cref="GetActionSequenceResponse"/></returns>
        public GetActionSequenceResponse GetActionSequenceSync(GetActionSequenceRequest req)
        {
             JsonResponseModel<GetActionSequenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetActionSequence");
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
        /// <param name="req"><see cref="GetDetectInfoRequest"/></param>
        /// <returns><see cref="GetDetectInfoResponse"/></returns>
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
        /// 完成验证后，用BizToken调用本接口获取结果信息，BizToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetDetectInfoRequest"/></param>
        /// <returns><see cref="GetDetectInfoResponse"/></returns>
        public GetDetectInfoResponse GetDetectInfoSync(GetDetectInfoRequest req)
        {
             JsonResponseModel<GetDetectInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDetectInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDetectInfoResponse>>(strResp);
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
        /// <param name="req"><see cref="GetDetectInfoEnhancedRequest"/></param>
        /// <returns><see cref="GetDetectInfoEnhancedResponse"/></returns>
        public async Task<GetDetectInfoEnhancedResponse> GetDetectInfoEnhanced(GetDetectInfoEnhancedRequest req)
        {
             JsonResponseModel<GetDetectInfoEnhancedResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDetectInfoEnhanced");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDetectInfoEnhancedResponse>>(strResp);
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
        /// <param name="req"><see cref="GetDetectInfoEnhancedRequest"/></param>
        /// <returns><see cref="GetDetectInfoEnhancedResponse"/></returns>
        public GetDetectInfoEnhancedResponse GetDetectInfoEnhancedSync(GetDetectInfoEnhancedRequest req)
        {
             JsonResponseModel<GetDetectInfoEnhancedResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDetectInfoEnhanced");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDetectInfoEnhancedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成验证后，用FaceIdToken调用本接口获取结果信息，FaceIdToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdResultRequest"/></param>
        /// <returns><see cref="GetFaceIdResultResponse"/></returns>
        public async Task<GetFaceIdResultResponse> GetFaceIdResult(GetFaceIdResultRequest req)
        {
             JsonResponseModel<GetFaceIdResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFaceIdResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFaceIdResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成验证后，用FaceIdToken调用本接口获取结果信息，FaceIdToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdResultRequest"/></param>
        /// <returns><see cref="GetFaceIdResultResponse"/></returns>
        public GetFaceIdResultResponse GetFaceIdResultSync(GetFaceIdResultRequest req)
        {
             JsonResponseModel<GetFaceIdResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFaceIdResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFaceIdResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用人脸核身SDK服务前，需先调用本接口获取SDKToken，用来串联核身流程，在验证完成后，用于获取验证结果信息，该token仅能核身一次。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdTokenRequest"/></param>
        /// <returns><see cref="GetFaceIdTokenResponse"/></returns>
        public async Task<GetFaceIdTokenResponse> GetFaceIdToken(GetFaceIdTokenRequest req)
        {
             JsonResponseModel<GetFaceIdTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFaceIdToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFaceIdTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用人脸核身SDK服务前，需先调用本接口获取SDKToken，用来串联核身流程，在验证完成后，用于获取验证结果信息，该token仅能核身一次。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdTokenRequest"/></param>
        /// <returns><see cref="GetFaceIdTokenResponse"/></returns>
        public GetFaceIdTokenResponse GetFaceIdTokenSync(GetFaceIdTokenRequest req)
        {
             JsonResponseModel<GetFaceIdTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFaceIdToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFaceIdTokenResponse>>(strResp);
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
        /// <param name="req"><see cref="GetLiveCodeRequest"/></param>
        /// <returns><see cref="GetLiveCodeResponse"/></returns>
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
        /// 使用数字活体检测模式前，需调用本接口获取数字验证码。
        /// </summary>
        /// <param name="req"><see cref="GetLiveCodeRequest"/></param>
        /// <returns><see cref="GetLiveCodeResponse"/></returns>
        public GetLiveCodeResponse GetLiveCodeSync(GetLiveCodeRequest req)
        {
             JsonResponseModel<GetLiveCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetLiveCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLiveCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取微信实名认证结果
        /// </summary>
        /// <param name="req"><see cref="GetRealNameAuthResultRequest"/></param>
        /// <returns><see cref="GetRealNameAuthResultResponse"/></returns>
        public async Task<GetRealNameAuthResultResponse> GetRealNameAuthResult(GetRealNameAuthResultRequest req)
        {
             JsonResponseModel<GetRealNameAuthResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRealNameAuthResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRealNameAuthResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取微信实名认证结果
        /// </summary>
        /// <param name="req"><see cref="GetRealNameAuthResultRequest"/></param>
        /// <returns><see cref="GetRealNameAuthResultResponse"/></returns>
        public GetRealNameAuthResultResponse GetRealNameAuthResultSync(GetRealNameAuthResultRequest req)
        {
             JsonResponseModel<GetRealNameAuthResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRealNameAuthResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRealNameAuthResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输入姓名和身份证号验证与微信实名的信息是否一致
        /// </summary>
        /// <param name="req"><see cref="GetRealNameAuthTokenRequest"/></param>
        /// <returns><see cref="GetRealNameAuthTokenResponse"/></returns>
        public async Task<GetRealNameAuthTokenResponse> GetRealNameAuthToken(GetRealNameAuthTokenRequest req)
        {
             JsonResponseModel<GetRealNameAuthTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRealNameAuthToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRealNameAuthTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输入姓名和身份证号验证与微信实名的信息是否一致
        /// </summary>
        /// <param name="req"><see cref="GetRealNameAuthTokenRequest"/></param>
        /// <returns><see cref="GetRealNameAuthTokenResponse"/></returns>
        public GetRealNameAuthTokenResponse GetRealNameAuthTokenSync(GetRealNameAuthTokenRequest req)
        {
             JsonResponseModel<GetRealNameAuthTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRealNameAuthToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRealNameAuthTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验姓名和身份证号的真实性和一致性，您可以通过输入姓名和身份证号或传入身份证人像面照片提供所需验证信息。
        /// </summary>
        /// <param name="req"><see cref="IdCardOCRVerificationRequest"/></param>
        /// <returns><see cref="IdCardOCRVerificationResponse"/></returns>
        public async Task<IdCardOCRVerificationResponse> IdCardOCRVerification(IdCardOCRVerificationRequest req)
        {
             JsonResponseModel<IdCardOCRVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IdCardOCRVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IdCardOCRVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验姓名和身份证号的真实性和一致性，您可以通过输入姓名和身份证号或传入身份证人像面照片提供所需验证信息。
        /// </summary>
        /// <param name="req"><see cref="IdCardOCRVerificationRequest"/></param>
        /// <returns><see cref="IdCardOCRVerificationResponse"/></returns>
        public IdCardOCRVerificationResponse IdCardOCRVerificationSync(IdCardOCRVerificationRequest req)
        {
             JsonResponseModel<IdCardOCRVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IdCardOCRVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IdCardOCRVerificationResponse>>(strResp);
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
        /// <param name="req"><see cref="IdCardVerificationRequest"/></param>
        /// <returns><see cref="IdCardVerificationResponse"/></returns>
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
        /// 传入姓名和身份证号，校验两者的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="IdCardVerificationRequest"/></param>
        /// <returns><see cref="IdCardVerificationResponse"/></returns>
        public IdCardVerificationResponse IdCardVerificationSync(IdCardVerificationRequest req)
        {
             JsonResponseModel<IdCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IdCardVerification");
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
        /// <param name="req"><see cref="ImageRecognitionRequest"/></param>
        /// <returns><see cref="ImageRecognitionResponse"/></returns>
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
        /// 传入照片和身份信息，判断该照片与公安权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="ImageRecognitionRequest"/></param>
        /// <returns><see cref="ImageRecognitionResponse"/></returns>
        public ImageRecognitionResponse ImageRecognitionSync(ImageRecognitionRequest req)
        {
             JsonResponseModel<ImageRecognitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImageRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 活体检测
        /// </summary>
        /// <param name="req"><see cref="LivenessRequest"/></param>
        /// <returns><see cref="LivenessResponse"/></returns>
        public async Task<LivenessResponse> Liveness(LivenessRequest req)
        {
             JsonResponseModel<LivenessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Liveness");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 活体检测
        /// </summary>
        /// <param name="req"><see cref="LivenessRequest"/></param>
        /// <returns><see cref="LivenessResponse"/></returns>
        public LivenessResponse LivenessSync(LivenessRequest req)
        {
             JsonResponseModel<LivenessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Liveness");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessResponse>>(strResp);
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
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
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
        /// 传入视频和照片，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与上传照片是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
        public LivenessCompareResponse LivenessCompareSync(LivenessCompareRequest req)
        {
             JsonResponseModel<LivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LivenessCompare");
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
        /// <param name="req"><see cref="LivenessRecognitionRequest"/></param>
        /// <returns><see cref="LivenessRecognitionResponse"/></returns>
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

        /// <summary>
        /// 传入视频和身份信息，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与公安权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="LivenessRecognitionRequest"/></param>
        /// <returns><see cref="LivenessRecognitionResponse"/></returns>
        public LivenessRecognitionResponse LivenessRecognitionSync(LivenessRecognitionRequest req)
        {
             JsonResponseModel<LivenessRecognitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LivenessRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 未成年人守护接口是通过传入手机号或姓名和身份证号，结合权威数据源和腾讯健康守护可信模型，判断该信息是否真实且年满18周岁。腾讯健康守护可信模型覆盖了上十亿手机库源，覆盖率高、准确率高，如果不在库中的手机号，还可以通过姓名+身份证进行兜底验证。
        /// </summary>
        /// <param name="req"><see cref="MinorsVerificationRequest"/></param>
        /// <returns><see cref="MinorsVerificationResponse"/></returns>
        public async Task<MinorsVerificationResponse> MinorsVerification(MinorsVerificationRequest req)
        {
             JsonResponseModel<MinorsVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MinorsVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MinorsVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 未成年人守护接口是通过传入手机号或姓名和身份证号，结合权威数据源和腾讯健康守护可信模型，判断该信息是否真实且年满18周岁。腾讯健康守护可信模型覆盖了上十亿手机库源，覆盖率高、准确率高，如果不在库中的手机号，还可以通过姓名+身份证进行兜底验证。
        /// </summary>
        /// <param name="req"><see cref="MinorsVerificationRequest"/></param>
        /// <returns><see cref="MinorsVerificationResponse"/></returns>
        public MinorsVerificationResponse MinorsVerificationSync(MinorsVerificationRequest req)
        {
             JsonResponseModel<MinorsVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MinorsVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MinorsVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询手机号在网时长，输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileNetworkTimeVerificationRequest"/></param>
        /// <returns><see cref="MobileNetworkTimeVerificationResponse"/></returns>
        public async Task<MobileNetworkTimeVerificationResponse> MobileNetworkTimeVerification(MobileNetworkTimeVerificationRequest req)
        {
             JsonResponseModel<MobileNetworkTimeVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MobileNetworkTimeVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MobileNetworkTimeVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询手机号在网时长，输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileNetworkTimeVerificationRequest"/></param>
        /// <returns><see cref="MobileNetworkTimeVerificationResponse"/></returns>
        public MobileNetworkTimeVerificationResponse MobileNetworkTimeVerificationSync(MobileNetworkTimeVerificationRequest req)
        {
             JsonResponseModel<MobileNetworkTimeVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MobileNetworkTimeVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MobileNetworkTimeVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于验证手机号的状态，您可以输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileStatusRequest"/></param>
        /// <returns><see cref="MobileStatusResponse"/></returns>
        public async Task<MobileStatusResponse> MobileStatus(MobileStatusRequest req)
        {
             JsonResponseModel<MobileStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MobileStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MobileStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于验证手机号的状态，您可以输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileStatusRequest"/></param>
        /// <returns><see cref="MobileStatusResponse"/></returns>
        public MobileStatusResponse MobileStatusSync(MobileStatusRequest req)
        {
             JsonResponseModel<MobileStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MobileStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MobileStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验手机号、姓名和身份证号的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationRequest"/></param>
        /// <returns><see cref="PhoneVerificationResponse"/></returns>
        public async Task<PhoneVerificationResponse> PhoneVerification(PhoneVerificationRequest req)
        {
             JsonResponseModel<PhoneVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PhoneVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PhoneVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验手机号、姓名和身份证号的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationRequest"/></param>
        /// <returns><see cref="PhoneVerificationResponse"/></returns>
        public PhoneVerificationResponse PhoneVerificationSync(PhoneVerificationRequest req)
        {
             JsonResponseModel<PhoneVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PhoneVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PhoneVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
