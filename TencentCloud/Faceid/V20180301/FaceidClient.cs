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
        /// BankCard2EVerification接口的同步版本，本接口用于校验姓名和银行卡号的真实性和一致性。
        /// </summary>
        /// <param name="req">参考<see cref="BankCard2EVerificationRequest"/></param>
        /// <returns>参考<see cref="BankCard2EVerificationResponse"/>实例</returns>
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
        /// BankCard4EVerification接口的同步版本，本接口用于输入银行卡号、姓名、开户证件号、开户手机号，校验信息的真实性和一致性。
        /// </summary>
        /// <param name="req">参考<see cref="BankCard4EVerificationRequest"/></param>
        /// <returns>参考<see cref="BankCard4EVerificationResponse"/>实例</returns>
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
        /// BankCardVerification接口的同步版本，本接口用于银行卡号、姓名、开户证件号信息的真实性和一致性。
        /// </summary>
        /// <param name="req">参考<see cref="BankCardVerificationRequest"/></param>
        /// <returns>参考<see cref="BankCardVerificationResponse"/>实例</returns>
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
        /// DetectAuth接口的同步版本，每次调用人脸核身SaaS化服务前，需先调用本接口获取BizToken，用来串联核身流程，在验证完成后，用于获取验证结果信息。
        /// </summary>
        /// <param name="req">参考<see cref="DetectAuthRequest"/></param>
        /// <returns>参考<see cref="DetectAuthResponse"/>实例</returns>
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
        /// GetActionSequence接口的同步版本，使用动作活体检测模式前，需调用本接口获取动作顺序。
        /// </summary>
        /// <param name="req">参考<see cref="GetActionSequenceRequest"/></param>
        /// <returns>参考<see cref="GetActionSequenceResponse"/>实例</returns>
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
        /// GetDetectInfo接口的同步版本，完成验证后，用BizToken调用本接口获取结果信息，BizToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req">参考<see cref="GetDetectInfoRequest"/></param>
        /// <returns>参考<see cref="GetDetectInfoResponse"/>实例</returns>
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
        /// GetLiveCode接口的同步版本，使用数字活体检测模式前，需调用本接口获取数字验证码。
        /// </summary>
        /// <param name="req">参考<see cref="GetLiveCodeRequest"/></param>
        /// <returns>参考<see cref="GetLiveCodeResponse"/>实例</returns>
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
        /// IdCardOCRVerification接口的同步版本，本接口用于校验姓名和身份证号的真实性和一致性，您可以通过输入姓名和身份证号或传入身份证人像面照片提供所需验证信息。
        /// </summary>
        /// <param name="req">参考<see cref="IdCardOCRVerificationRequest"/></param>
        /// <returns>参考<see cref="IdCardOCRVerificationResponse"/>实例</returns>
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
        /// IdCardVerification接口的同步版本，传入姓名和身份证号，校验两者的真实性和一致性。
        /// </summary>
        /// <param name="req">参考<see cref="IdCardVerificationRequest"/></param>
        /// <returns>参考<see cref="IdCardVerificationResponse"/>实例</returns>
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
        /// ImageRecognition接口的同步版本，传入照片和身份信息，判断该照片与公安权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req">参考<see cref="ImageRecognitionRequest"/></param>
        /// <returns>参考<see cref="ImageRecognitionResponse"/>实例</returns>
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
        /// Liveness接口的同步版本，活体检测
        /// </summary>
        /// <param name="req">参考<see cref="LivenessRequest"/></param>
        /// <returns>参考<see cref="LivenessResponse"/>实例</returns>
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
        /// LivenessCompare接口的同步版本，传入视频和照片，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与上传照片是否属于同一个人。
        /// </summary>
        /// <param name="req">参考<see cref="LivenessCompareRequest"/></param>
        /// <returns>参考<see cref="LivenessCompareResponse"/>实例</returns>
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
        /// LivenessRecognition接口的同步版本，传入视频和身份信息，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与公安权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req">参考<see cref="LivenessRecognitionRequest"/></param>
        /// <returns>参考<see cref="LivenessRecognitionResponse"/>实例</returns>
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
        /// 传入手机号或者姓名和身份证号，判断该信息是否已实名认证且年满18周岁。
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
        /// MinorsVerification接口的同步版本，传入手机号或者姓名和身份证号，判断该信息是否已实名认证且年满18周岁。
        /// </summary>
        /// <param name="req">参考<see cref="MinorsVerificationRequest"/></param>
        /// <returns>参考<see cref="MinorsVerificationResponse"/>实例</returns>
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
        /// MobileNetworkTimeVerification接口的同步版本，本接口用于查询手机号在网时长，输入手机号进行查询。
        /// </summary>
        /// <param name="req">参考<see cref="MobileNetworkTimeVerificationRequest"/></param>
        /// <returns>参考<see cref="MobileNetworkTimeVerificationResponse"/>实例</returns>
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
        /// MobileStatus接口的同步版本，本接口用于验证手机号的状态，您可以输入手机号进行查询。
        /// </summary>
        /// <param name="req">参考<see cref="MobileStatusRequest"/></param>
        /// <returns>参考<see cref="MobileStatusResponse"/>实例</returns>
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
        /// PhoneVerification接口的同步版本，本接口用于校验手机号、姓名和身份证号的真实性和一致性。
        /// </summary>
        /// <param name="req">参考<see cref="PhoneVerificationRequest"/></param>
        /// <returns>参考<see cref="PhoneVerificationResponse"/>实例</returns>
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
