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

namespace TencentCloud.Essbasic.V20201222
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Essbasic.V20201222.Models;

   public class EssbasicClient : AbstractClient{

       private const string endpoint = "essbasic.tencentcloudapi.com";
       private const string version = "2020-12-22";
       private const string sdkVersion = "SDK_NET_3.0.1260";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EssbasicClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EssbasicClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 此接口（ArchiveFlow）用于流程的归档。
        /// 
        /// 注意：归档后的流程不可再进行发送、签署、拒签、撤回等一系列操作。
        /// </summary>
        /// <param name="req"><see cref="ArchiveFlowRequest"/></param>
        /// <returns><see cref="ArchiveFlowResponse"/></returns>
        public Task<ArchiveFlowResponse> ArchiveFlow(ArchiveFlowRequest req)
        {
            return InternalRequestAsync<ArchiveFlowResponse>(req, "ArchiveFlow");
        }

        /// <summary>
        /// 此接口（ArchiveFlow）用于流程的归档。
        /// 
        /// 注意：归档后的流程不可再进行发送、签署、拒签、撤回等一系列操作。
        /// </summary>
        /// <param name="req"><see cref="ArchiveFlowRequest"/></param>
        /// <returns><see cref="ArchiveFlowResponse"/></returns>
        public ArchiveFlowResponse ArchiveFlowSync(ArchiveFlowRequest req)
        {
            return InternalRequestAsync<ArchiveFlowResponse>(req, "ArchiveFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（CancelFlow）用于撤销正在进行中的流程。
        /// 
        /// 注：已归档流程不可完成撤销动作。
        /// </summary>
        /// <param name="req"><see cref="CancelFlowRequest"/></param>
        /// <returns><see cref="CancelFlowResponse"/></returns>
        public Task<CancelFlowResponse> CancelFlow(CancelFlowRequest req)
        {
            return InternalRequestAsync<CancelFlowResponse>(req, "CancelFlow");
        }

        /// <summary>
        /// 此接口（CancelFlow）用于撤销正在进行中的流程。
        /// 
        /// 注：已归档流程不可完成撤销动作。
        /// </summary>
        /// <param name="req"><see cref="CancelFlowRequest"/></param>
        /// <returns><see cref="CancelFlowResponse"/></returns>
        public CancelFlowResponse CancelFlowSync(CancelFlowRequest req)
        {
            return InternalRequestAsync<CancelFlowResponse>(req, "CancelFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡二要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard2EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard2EVerificationResponse"/></returns>
        public Task<CheckBankCard2EVerificationResponse> CheckBankCard2EVerification(CheckBankCard2EVerificationRequest req)
        {
            return InternalRequestAsync<CheckBankCard2EVerificationResponse>(req, "CheckBankCard2EVerification");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡二要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard2EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard2EVerificationResponse"/></returns>
        public CheckBankCard2EVerificationResponse CheckBankCard2EVerificationSync(CheckBankCard2EVerificationRequest req)
        {
            return InternalRequestAsync<CheckBankCard2EVerificationResponse>(req, "CheckBankCard2EVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡三要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard3EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard3EVerificationResponse"/></returns>
        public Task<CheckBankCard3EVerificationResponse> CheckBankCard3EVerification(CheckBankCard3EVerificationRequest req)
        {
            return InternalRequestAsync<CheckBankCard3EVerificationResponse>(req, "CheckBankCard3EVerification");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡三要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard3EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard3EVerificationResponse"/></returns>
        public CheckBankCard3EVerificationResponse CheckBankCard3EVerificationSync(CheckBankCard3EVerificationRequest req)
        {
            return InternalRequestAsync<CheckBankCard3EVerificationResponse>(req, "CheckBankCard3EVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡四要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard4EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard4EVerificationResponse"/></returns>
        public Task<CheckBankCard4EVerificationResponse> CheckBankCard4EVerification(CheckBankCard4EVerificationRequest req)
        {
            return InternalRequestAsync<CheckBankCard4EVerificationResponse>(req, "CheckBankCard4EVerification");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡四要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard4EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard4EVerificationResponse"/></returns>
        public CheckBankCard4EVerificationResponse CheckBankCard4EVerificationSync(CheckBankCard4EVerificationRequest req)
        {
            return InternalRequestAsync<CheckBankCard4EVerificationResponse>(req, "CheckBankCard4EVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡二/三/四要素
        /// 银行卡二要素(同CheckBankCard2EVerification): bank_card + name
        /// 银行卡三要素(同CheckBankCard3EVerification): bank_card + name + id_card_number
        /// 银行卡四要素(同CheckBankCard4EVerification): bank_card + name + id_card_number + mobile
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCardVerificationResponse"/></returns>
        public Task<CheckBankCardVerificationResponse> CheckBankCardVerification(CheckBankCardVerificationRequest req)
        {
            return InternalRequestAsync<CheckBankCardVerificationResponse>(req, "CheckBankCardVerification");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡二/三/四要素
        /// 银行卡二要素(同CheckBankCard2EVerification): bank_card + name
        /// 银行卡三要素(同CheckBankCard3EVerification): bank_card + name + id_card_number
        /// 银行卡四要素(同CheckBankCard4EVerification): bank_card + name + id_card_number + mobile
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCardVerificationResponse"/></returns>
        public CheckBankCardVerificationResponse CheckBankCardVerificationSync(CheckBankCardVerificationRequest req)
        {
            return InternalRequestAsync<CheckBankCardVerificationResponse>(req, "CheckBankCardVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台检测慧眼或腾讯电子签小程序人脸核身结果
        /// </summary>
        /// <param name="req"><see cref="CheckFaceIdentifyRequest"/></param>
        /// <returns><see cref="CheckFaceIdentifyResponse"/></returns>
        public Task<CheckFaceIdentifyResponse> CheckFaceIdentify(CheckFaceIdentifyRequest req)
        {
            return InternalRequestAsync<CheckFaceIdentifyResponse>(req, "CheckFaceIdentify");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台检测慧眼或腾讯电子签小程序人脸核身结果
        /// </summary>
        /// <param name="req"><see cref="CheckFaceIdentifyRequest"/></param>
        /// <returns><see cref="CheckFaceIdentifyResponse"/></returns>
        public CheckFaceIdentifyResponse CheckFaceIdentifySync(CheckFaceIdentifyRequest req)
        {
            return InternalRequestAsync<CheckFaceIdentifyResponse>(req, "CheckFaceIdentify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证姓名和身份证信息
        /// </summary>
        /// <param name="req"><see cref="CheckIdCardVerificationRequest"/></param>
        /// <returns><see cref="CheckIdCardVerificationResponse"/></returns>
        public Task<CheckIdCardVerificationResponse> CheckIdCardVerification(CheckIdCardVerificationRequest req)
        {
            return InternalRequestAsync<CheckIdCardVerificationResponse>(req, "CheckIdCardVerification");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证姓名和身份证信息
        /// </summary>
        /// <param name="req"><see cref="CheckIdCardVerificationRequest"/></param>
        /// <returns><see cref="CheckIdCardVerificationResponse"/></returns>
        public CheckIdCardVerificationResponse CheckIdCardVerificationSync(CheckIdCardVerificationRequest req)
        {
            return InternalRequestAsync<CheckIdCardVerificationResponse>(req, "CheckIdCardVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证手机号二要素
        /// </summary>
        /// <param name="req"><see cref="CheckMobileAndNameRequest"/></param>
        /// <returns><see cref="CheckMobileAndNameResponse"/></returns>
        public Task<CheckMobileAndNameResponse> CheckMobileAndName(CheckMobileAndNameRequest req)
        {
            return InternalRequestAsync<CheckMobileAndNameResponse>(req, "CheckMobileAndName");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证手机号二要素
        /// </summary>
        /// <param name="req"><see cref="CheckMobileAndNameRequest"/></param>
        /// <returns><see cref="CheckMobileAndNameResponse"/></returns>
        public CheckMobileAndNameResponse CheckMobileAndNameSync(CheckMobileAndNameRequest req)
        {
            return InternalRequestAsync<CheckMobileAndNameResponse>(req, "CheckMobileAndName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证手机号三要素
        /// </summary>
        /// <param name="req"><see cref="CheckMobileVerificationRequest"/></param>
        /// <returns><see cref="CheckMobileVerificationResponse"/></returns>
        public Task<CheckMobileVerificationResponse> CheckMobileVerification(CheckMobileVerificationRequest req)
        {
            return InternalRequestAsync<CheckMobileVerificationResponse>(req, "CheckMobileVerification");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证手机号三要素
        /// </summary>
        /// <param name="req"><see cref="CheckMobileVerificationRequest"/></param>
        /// <returns><see cref="CheckMobileVerificationResponse"/></returns>
        public CheckMobileVerificationResponse CheckMobileVerificationSync(CheckMobileVerificationRequest req)
        {
            return InternalRequestAsync<CheckMobileVerificationResponse>(req, "CheckMobileVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于确认验证码是否正确
        /// </summary>
        /// <param name="req"><see cref="CheckVerifyCodeMatchFlowIdRequest"/></param>
        /// <returns><see cref="CheckVerifyCodeMatchFlowIdResponse"/></returns>
        public Task<CheckVerifyCodeMatchFlowIdResponse> CheckVerifyCodeMatchFlowId(CheckVerifyCodeMatchFlowIdRequest req)
        {
            return InternalRequestAsync<CheckVerifyCodeMatchFlowIdResponse>(req, "CheckVerifyCodeMatchFlowId");
        }

        /// <summary>
        /// 此接口用于确认验证码是否正确
        /// </summary>
        /// <param name="req"><see cref="CheckVerifyCodeMatchFlowIdRequest"/></param>
        /// <returns><see cref="CheckVerifyCodeMatchFlowIdResponse"/></returns>
        public CheckVerifyCodeMatchFlowIdResponse CheckVerifyCodeMatchFlowIdSync(CheckVerifyCodeMatchFlowIdRequest req)
        {
            return InternalRequestAsync<CheckVerifyCodeMatchFlowIdResponse>(req, "CheckVerifyCodeMatchFlowId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼慧眼API签名
        /// </summary>
        /// <param name="req"><see cref="CreateFaceIdSignRequest"/></param>
        /// <returns><see cref="CreateFaceIdSignResponse"/></returns>
        public Task<CreateFaceIdSignResponse> CreateFaceIdSign(CreateFaceIdSignRequest req)
        {
            return InternalRequestAsync<CreateFaceIdSignResponse>(req, "CreateFaceIdSign");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼慧眼API签名
        /// </summary>
        /// <param name="req"><see cref="CreateFaceIdSignRequest"/></param>
        /// <returns><see cref="CreateFaceIdSignResponse"/></returns>
        public CreateFaceIdSignResponse CreateFaceIdSignSync(CreateFaceIdSignRequest req)
        {
            return InternalRequestAsync<CreateFaceIdSignResponse>(req, "CreateFaceIdSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（CreateFlowByFiles）用于通过PDF文件创建签署流程。
        /// 
        /// 注意：调用此接口前，请先调用多文件上传接口 (UploadFiles)，提前上传合同文件。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowByFilesRequest"/></param>
        /// <returns><see cref="CreateFlowByFilesResponse"/></returns>
        public Task<CreateFlowByFilesResponse> CreateFlowByFiles(CreateFlowByFilesRequest req)
        {
            return InternalRequestAsync<CreateFlowByFilesResponse>(req, "CreateFlowByFiles");
        }

        /// <summary>
        /// 此接口（CreateFlowByFiles）用于通过PDF文件创建签署流程。
        /// 
        /// 注意：调用此接口前，请先调用多文件上传接口 (UploadFiles)，提前上传合同文件。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowByFilesRequest"/></param>
        /// <returns><see cref="CreateFlowByFilesResponse"/></returns>
        public CreateFlowByFilesResponse CreateFlowByFilesSync(CreateFlowByFilesRequest req)
        {
            return InternalRequestAsync<CreateFlowByFilesResponse>(req, "CreateFlowByFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼H5人脸核身Url
        /// </summary>
        /// <param name="req"><see cref="CreateH5FaceIdUrlRequest"/></param>
        /// <returns><see cref="CreateH5FaceIdUrlResponse"/></returns>
        public Task<CreateH5FaceIdUrlResponse> CreateH5FaceIdUrl(CreateH5FaceIdUrlRequest req)
        {
            return InternalRequestAsync<CreateH5FaceIdUrlResponse>(req, "CreateH5FaceIdUrl");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼H5人脸核身Url
        /// </summary>
        /// <param name="req"><see cref="CreateH5FaceIdUrlRequest"/></param>
        /// <returns><see cref="CreateH5FaceIdUrlResponse"/></returns>
        public CreateH5FaceIdUrlResponse CreateH5FaceIdUrlSync(CreateH5FaceIdUrlRequest req)
        {
            return InternalRequestAsync<CreateH5FaceIdUrlResponse>(req, "CreateH5FaceIdUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（CreatePreviewSignUrl）用于生成生成预览签署URL。
        /// 
        /// 注：调用此接口前，请确保您已提前调用了发送流程接口（SendFlow）指定相关签署方。
        /// </summary>
        /// <param name="req"><see cref="CreatePreviewSignUrlRequest"/></param>
        /// <returns><see cref="CreatePreviewSignUrlResponse"/></returns>
        public Task<CreatePreviewSignUrlResponse> CreatePreviewSignUrl(CreatePreviewSignUrlRequest req)
        {
            return InternalRequestAsync<CreatePreviewSignUrlResponse>(req, "CreatePreviewSignUrl");
        }

        /// <summary>
        /// 此接口（CreatePreviewSignUrl）用于生成生成预览签署URL。
        /// 
        /// 注：调用此接口前，请确保您已提前调用了发送流程接口（SendFlow）指定相关签署方。
        /// </summary>
        /// <param name="req"><see cref="CreatePreviewSignUrlRequest"/></param>
        /// <returns><see cref="CreatePreviewSignUrlResponse"/></returns>
        public CreatePreviewSignUrlResponse CreatePreviewSignUrlSync(CreatePreviewSignUrlRequest req)
        {
            return InternalRequestAsync<CreatePreviewSignUrlResponse>(req, "CreatePreviewSignUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（CreateSeal）用于创建个人/企业印章。
        /// 
        /// 注意：使用FileId参数指定印章，需先调用多文件上传 (UploadFiles) 上传印章图片。
        /// </summary>
        /// <param name="req"><see cref="CreateSealRequest"/></param>
        /// <returns><see cref="CreateSealResponse"/></returns>
        public Task<CreateSealResponse> CreateSeal(CreateSealRequest req)
        {
            return InternalRequestAsync<CreateSealResponse>(req, "CreateSeal");
        }

        /// <summary>
        /// 此接口（CreateSeal）用于创建个人/企业印章。
        /// 
        /// 注意：使用FileId参数指定印章，需先调用多文件上传 (UploadFiles) 上传印章图片。
        /// </summary>
        /// <param name="req"><see cref="CreateSealRequest"/></param>
        /// <returns><see cref="CreateSealResponse"/></returns>
        public CreateSealResponse CreateSealSync(CreateSealRequest req)
        {
            return InternalRequestAsync<CreateSealResponse>(req, "CreateSeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（CreateServerFlowSign）用于静默签署文件。
        /// 
        /// 注：
        /// 1、此接口为白名单接口，调用前请提前与客服经理或邮件至e-contract@tencent.com进行联系。
        /// 2、仅合同发起者可使用流程静默签署能力。
        /// </summary>
        /// <param name="req"><see cref="CreateServerFlowSignRequest"/></param>
        /// <returns><see cref="CreateServerFlowSignResponse"/></returns>
        public Task<CreateServerFlowSignResponse> CreateServerFlowSign(CreateServerFlowSignRequest req)
        {
            return InternalRequestAsync<CreateServerFlowSignResponse>(req, "CreateServerFlowSign");
        }

        /// <summary>
        /// 此接口（CreateServerFlowSign）用于静默签署文件。
        /// 
        /// 注：
        /// 1、此接口为白名单接口，调用前请提前与客服经理或邮件至e-contract@tencent.com进行联系。
        /// 2、仅合同发起者可使用流程静默签署能力。
        /// </summary>
        /// <param name="req"><see cref="CreateServerFlowSignRequest"/></param>
        /// <returns><see cref="CreateServerFlowSignResponse"/></returns>
        public CreateServerFlowSignResponse CreateServerFlowSignSync(CreateServerFlowSignRequest req)
        {
            return InternalRequestAsync<CreateServerFlowSignResponse>(req, "CreateServerFlowSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（CreateSignUrl）用于生成指定用户的签署URL。
        /// 
        /// 注：调用此接口前，请确保您已提前调用了发送流程接口（SendFlow）指定相关签署方。
        /// </summary>
        /// <param name="req"><see cref="CreateSignUrlRequest"/></param>
        /// <returns><see cref="CreateSignUrlResponse"/></returns>
        public Task<CreateSignUrlResponse> CreateSignUrl(CreateSignUrlRequest req)
        {
            return InternalRequestAsync<CreateSignUrlResponse>(req, "CreateSignUrl");
        }

        /// <summary>
        /// 此接口（CreateSignUrl）用于生成指定用户的签署URL。
        /// 
        /// 注：调用此接口前，请确保您已提前调用了发送流程接口（SendFlow）指定相关签署方。
        /// </summary>
        /// <param name="req"><see cref="CreateSignUrlRequest"/></param>
        /// <returns><see cref="CreateSignUrlResponse"/></returns>
        public CreateSignUrlResponse CreateSignUrlSync(CreateSignUrlRequest req)
        {
            return InternalRequestAsync<CreateSignUrlResponse>(req, "CreateSignUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（CreateSubOrganization）用于在腾讯电子签内注册子机构。
        /// </summary>
        /// <param name="req"><see cref="CreateSubOrganizationRequest"/></param>
        /// <returns><see cref="CreateSubOrganizationResponse"/></returns>
        public Task<CreateSubOrganizationResponse> CreateSubOrganization(CreateSubOrganizationRequest req)
        {
            return InternalRequestAsync<CreateSubOrganizationResponse>(req, "CreateSubOrganization");
        }

        /// <summary>
        /// 此接口（CreateSubOrganization）用于在腾讯电子签内注册子机构。
        /// </summary>
        /// <param name="req"><see cref="CreateSubOrganizationRequest"/></param>
        /// <returns><see cref="CreateSubOrganizationResponse"/></returns>
        public CreateSubOrganizationResponse CreateSubOrganizationSync(CreateSubOrganizationRequest req)
        {
            return InternalRequestAsync<CreateSubOrganizationResponse>(req, "CreateSubOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（CreateSubOrganizationAndSeal）用于注册子机构，同时系统将为该子企业自动生成一个默认电子印章图片。
        /// 
        /// 注意：
        /// 1. 在后续的签署流程中，若未指定签署使用的印章ID，则默认调用自动生成的印章图片进行签署。
        /// 2. 此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="CreateSubOrganizationAndSealRequest"/></param>
        /// <returns><see cref="CreateSubOrganizationAndSealResponse"/></returns>
        public Task<CreateSubOrganizationAndSealResponse> CreateSubOrganizationAndSeal(CreateSubOrganizationAndSealRequest req)
        {
            return InternalRequestAsync<CreateSubOrganizationAndSealResponse>(req, "CreateSubOrganizationAndSeal");
        }

        /// <summary>
        /// 此接口（CreateSubOrganizationAndSeal）用于注册子机构，同时系统将为该子企业自动生成一个默认电子印章图片。
        /// 
        /// 注意：
        /// 1. 在后续的签署流程中，若未指定签署使用的印章ID，则默认调用自动生成的印章图片进行签署。
        /// 2. 此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="CreateSubOrganizationAndSealRequest"/></param>
        /// <returns><see cref="CreateSubOrganizationAndSealResponse"/></returns>
        public CreateSubOrganizationAndSealResponse CreateSubOrganizationAndSealSync(CreateSubOrganizationAndSealRequest req)
        {
            return InternalRequestAsync<CreateSubOrganizationAndSealResponse>(req, "CreateSubOrganizationAndSeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（CreateUser）用于注册腾讯电子签个人用户。
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// 此接口（CreateUser）用于注册腾讯电子签个人用户。
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 第三方应用可通过此接口（CreateUserAndSeal）注册腾讯电子签实名个人用户，同时系统将为该用户自动生成一个默认电子签名图片。
        /// 
        /// 注意：
        /// 1. 在后续的签署流程中，若未指定签署使用的印章ID，则默认调用自动生成的签名图片进行签署。
        /// 2. 此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="CreateUserAndSealRequest"/></param>
        /// <returns><see cref="CreateUserAndSealResponse"/></returns>
        public Task<CreateUserAndSealResponse> CreateUserAndSeal(CreateUserAndSealRequest req)
        {
            return InternalRequestAsync<CreateUserAndSealResponse>(req, "CreateUserAndSeal");
        }

        /// <summary>
        /// 第三方应用可通过此接口（CreateUserAndSeal）注册腾讯电子签实名个人用户，同时系统将为该用户自动生成一个默认电子签名图片。
        /// 
        /// 注意：
        /// 1. 在后续的签署流程中，若未指定签署使用的印章ID，则默认调用自动生成的签名图片进行签署。
        /// 2. 此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="CreateUserAndSealRequest"/></param>
        /// <returns><see cref="CreateUserAndSealResponse"/></returns>
        public CreateUserAndSealResponse CreateUserAndSealSync(CreateUserAndSealRequest req)
        {
            return InternalRequestAsync<CreateUserAndSealResponse>(req, "CreateUserAndSeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口 (DeleteSeal) 用于删除指定ID的印章。
        /// 
        /// 注意：默认印章不支持删除
        /// </summary>
        /// <param name="req"><see cref="DeleteSealRequest"/></param>
        /// <returns><see cref="DeleteSealResponse"/></returns>
        public Task<DeleteSealResponse> DeleteSeal(DeleteSealRequest req)
        {
            return InternalRequestAsync<DeleteSealResponse>(req, "DeleteSeal");
        }

        /// <summary>
        /// 此接口 (DeleteSeal) 用于删除指定ID的印章。
        /// 
        /// 注意：默认印章不支持删除
        /// </summary>
        /// <param name="req"><see cref="DeleteSealRequest"/></param>
        /// <returns><see cref="DeleteSealResponse"/></returns>
        public DeleteSealResponse DeleteSealSync(DeleteSealRequest req)
        {
            return InternalRequestAsync<DeleteSealResponse>(req, "DeleteSeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 第三方应用可通过此接口（DescribeCatalogApprovers）查询指定目录的参与者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCatalogApproversRequest"/></param>
        /// <returns><see cref="DescribeCatalogApproversResponse"/></returns>
        public Task<DescribeCatalogApproversResponse> DescribeCatalogApprovers(DescribeCatalogApproversRequest req)
        {
            return InternalRequestAsync<DescribeCatalogApproversResponse>(req, "DescribeCatalogApprovers");
        }

        /// <summary>
        /// 第三方应用可通过此接口（DescribeCatalogApprovers）查询指定目录的参与者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCatalogApproversRequest"/></param>
        /// <returns><see cref="DescribeCatalogApproversResponse"/></returns>
        public DescribeCatalogApproversResponse DescribeCatalogApproversSync(DescribeCatalogApproversRequest req)
        {
            return InternalRequestAsync<DescribeCatalogApproversResponse>(req, "DescribeCatalogApprovers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 第三方应用可通过此接口（DescribeCatalogSignComponents）拉取目录签署区
        /// </summary>
        /// <param name="req"><see cref="DescribeCatalogSignComponentsRequest"/></param>
        /// <returns><see cref="DescribeCatalogSignComponentsResponse"/></returns>
        public Task<DescribeCatalogSignComponentsResponse> DescribeCatalogSignComponents(DescribeCatalogSignComponentsRequest req)
        {
            return InternalRequestAsync<DescribeCatalogSignComponentsResponse>(req, "DescribeCatalogSignComponents");
        }

        /// <summary>
        /// 第三方应用可通过此接口（DescribeCatalogSignComponents）拉取目录签署区
        /// </summary>
        /// <param name="req"><see cref="DescribeCatalogSignComponentsRequest"/></param>
        /// <returns><see cref="DescribeCatalogSignComponentsResponse"/></returns>
        public DescribeCatalogSignComponentsResponse DescribeCatalogSignComponentsSync(DescribeCatalogSignComponentsRequest req)
        {
            return InternalRequestAsync<DescribeCatalogSignComponentsResponse>(req, "DescribeCatalogSignComponents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeCustomFlowIds）用于通过自定义流程id来查询对应的电子签流程id
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomFlowIdsRequest"/></param>
        /// <returns><see cref="DescribeCustomFlowIdsResponse"/></returns>
        public Task<DescribeCustomFlowIdsResponse> DescribeCustomFlowIds(DescribeCustomFlowIdsRequest req)
        {
            return InternalRequestAsync<DescribeCustomFlowIdsResponse>(req, "DescribeCustomFlowIds");
        }

        /// <summary>
        /// 此接口（DescribeCustomFlowIds）用于通过自定义流程id来查询对应的电子签流程id
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomFlowIdsRequest"/></param>
        /// <returns><see cref="DescribeCustomFlowIdsResponse"/></returns>
        public DescribeCustomFlowIdsResponse DescribeCustomFlowIdsSync(DescribeCustomFlowIdsRequest req)
        {
            return InternalRequestAsync<DescribeCustomFlowIdsResponse>(req, "DescribeCustomFlowIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeCustomFlowIdsByFlowId）用于根据流程id反查自定义流程id
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomFlowIdsByFlowIdRequest"/></param>
        /// <returns><see cref="DescribeCustomFlowIdsByFlowIdResponse"/></returns>
        public Task<DescribeCustomFlowIdsByFlowIdResponse> DescribeCustomFlowIdsByFlowId(DescribeCustomFlowIdsByFlowIdRequest req)
        {
            return InternalRequestAsync<DescribeCustomFlowIdsByFlowIdResponse>(req, "DescribeCustomFlowIdsByFlowId");
        }

        /// <summary>
        /// 此接口（DescribeCustomFlowIdsByFlowId）用于根据流程id反查自定义流程id
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomFlowIdsByFlowIdRequest"/></param>
        /// <returns><see cref="DescribeCustomFlowIdsByFlowIdResponse"/></returns>
        public DescribeCustomFlowIdsByFlowIdResponse DescribeCustomFlowIdsByFlowIdSync(DescribeCustomFlowIdsByFlowIdRequest req)
        {
            return InternalRequestAsync<DescribeCustomFlowIdsByFlowIdResponse>(req, "DescribeCustomFlowIdsByFlowId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼人脸核身照片
        /// </summary>
        /// <param name="req"><see cref="DescribeFaceIdPhotosRequest"/></param>
        /// <returns><see cref="DescribeFaceIdPhotosResponse"/></returns>
        public Task<DescribeFaceIdPhotosResponse> DescribeFaceIdPhotos(DescribeFaceIdPhotosRequest req)
        {
            return InternalRequestAsync<DescribeFaceIdPhotosResponse>(req, "DescribeFaceIdPhotos");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼人脸核身照片
        /// </summary>
        /// <param name="req"><see cref="DescribeFaceIdPhotosRequest"/></param>
        /// <returns><see cref="DescribeFaceIdPhotosResponse"/></returns>
        public DescribeFaceIdPhotosResponse DescribeFaceIdPhotosSync(DescribeFaceIdPhotosRequest req)
        {
            return InternalRequestAsync<DescribeFaceIdPhotosResponse>(req, "DescribeFaceIdPhotos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼人脸核身结果
        /// </summary>
        /// <param name="req"><see cref="DescribeFaceIdResultsRequest"/></param>
        /// <returns><see cref="DescribeFaceIdResultsResponse"/></returns>
        public Task<DescribeFaceIdResultsResponse> DescribeFaceIdResults(DescribeFaceIdResultsRequest req)
        {
            return InternalRequestAsync<DescribeFaceIdResultsResponse>(req, "DescribeFaceIdResults");
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼人脸核身结果
        /// </summary>
        /// <param name="req"><see cref="DescribeFaceIdResultsRequest"/></param>
        /// <returns><see cref="DescribeFaceIdResultsResponse"/></returns>
        public DescribeFaceIdResultsResponse DescribeFaceIdResultsSync(DescribeFaceIdResultsRequest req)
        {
            return InternalRequestAsync<DescribeFaceIdResultsResponse>(req, "DescribeFaceIdResults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据用户自定义id查询文件id
        /// </summary>
        /// <param name="req"><see cref="DescribeFileIdsByCustomIdsRequest"/></param>
        /// <returns><see cref="DescribeFileIdsByCustomIdsResponse"/></returns>
        public Task<DescribeFileIdsByCustomIdsResponse> DescribeFileIdsByCustomIds(DescribeFileIdsByCustomIdsRequest req)
        {
            return InternalRequestAsync<DescribeFileIdsByCustomIdsResponse>(req, "DescribeFileIdsByCustomIds");
        }

        /// <summary>
        /// 根据用户自定义id查询文件id
        /// </summary>
        /// <param name="req"><see cref="DescribeFileIdsByCustomIdsRequest"/></param>
        /// <returns><see cref="DescribeFileIdsByCustomIdsResponse"/></returns>
        public DescribeFileIdsByCustomIdsResponse DescribeFileIdsByCustomIdsSync(DescribeFileIdsByCustomIdsRequest req)
        {
            return InternalRequestAsync<DescribeFileIdsByCustomIdsResponse>(req, "DescribeFileIdsByCustomIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeFileUrls）用于获取签署文件下载的URL。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileUrlsRequest"/></param>
        /// <returns><see cref="DescribeFileUrlsResponse"/></returns>
        public Task<DescribeFileUrlsResponse> DescribeFileUrls(DescribeFileUrlsRequest req)
        {
            return InternalRequestAsync<DescribeFileUrlsResponse>(req, "DescribeFileUrls");
        }

        /// <summary>
        /// 此接口（DescribeFileUrls）用于获取签署文件下载的URL。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileUrlsRequest"/></param>
        /// <returns><see cref="DescribeFileUrlsResponse"/></returns>
        public DescribeFileUrlsResponse DescribeFileUrlsSync(DescribeFileUrlsRequest req)
        {
            return InternalRequestAsync<DescribeFileUrlsResponse>(req, "DescribeFileUrls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过此接口（DescribeFlow）可查询签署流程的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public Task<DescribeFlowResponse> DescribeFlow(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow");
        }

        /// <summary>
        /// 通过此接口（DescribeFlow）可查询签署流程的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public DescribeFlowResponse DescribeFlowSync(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 第三方应用可通过此接口（DescribeFlowApprovers）查询流程参与者信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowApproversRequest"/></param>
        /// <returns><see cref="DescribeFlowApproversResponse"/></returns>
        public Task<DescribeFlowApproversResponse> DescribeFlowApprovers(DescribeFlowApproversRequest req)
        {
            return InternalRequestAsync<DescribeFlowApproversResponse>(req, "DescribeFlowApprovers");
        }

        /// <summary>
        /// 第三方应用可通过此接口（DescribeFlowApprovers）查询流程参与者信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowApproversRequest"/></param>
        /// <returns><see cref="DescribeFlowApproversResponse"/></returns>
        public DescribeFlowApproversResponse DescribeFlowApproversSync(DescribeFlowApproversRequest req)
        {
            return InternalRequestAsync<DescribeFlowApproversResponse>(req, "DescribeFlowApprovers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询流程文件
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowFilesRequest"/></param>
        /// <returns><see cref="DescribeFlowFilesResponse"/></returns>
        public Task<DescribeFlowFilesResponse> DescribeFlowFiles(DescribeFlowFilesRequest req)
        {
            return InternalRequestAsync<DescribeFlowFilesResponse>(req, "DescribeFlowFiles");
        }

        /// <summary>
        /// 查询流程文件
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowFilesRequest"/></param>
        /// <returns><see cref="DescribeFlowFilesResponse"/></returns>
        public DescribeFlowFilesResponse DescribeFlowFilesSync(DescribeFlowFilesRequest req)
        {
            return InternalRequestAsync<DescribeFlowFilesResponse>(req, "DescribeFlowFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeSeals）用于查询指定ID的印章信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSealsRequest"/></param>
        /// <returns><see cref="DescribeSealsResponse"/></returns>
        public Task<DescribeSealsResponse> DescribeSeals(DescribeSealsRequest req)
        {
            return InternalRequestAsync<DescribeSealsResponse>(req, "DescribeSeals");
        }

        /// <summary>
        /// 此接口（DescribeSeals）用于查询指定ID的印章信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSealsRequest"/></param>
        /// <returns><see cref="DescribeSealsResponse"/></returns>
        public DescribeSealsResponse DescribeSealsSync(DescribeSealsRequest req)
        {
            return InternalRequestAsync<DescribeSealsResponse>(req, "DescribeSeals")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeSubOrganizations）用于查询子机构信息。
        /// 
        /// 注：此接口仅可查询您所属机构应用号创建的子机构信息，不可跨应用/跨机构查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubOrganizationsRequest"/></param>
        /// <returns><see cref="DescribeSubOrganizationsResponse"/></returns>
        public Task<DescribeSubOrganizationsResponse> DescribeSubOrganizations(DescribeSubOrganizationsRequest req)
        {
            return InternalRequestAsync<DescribeSubOrganizationsResponse>(req, "DescribeSubOrganizations");
        }

        /// <summary>
        /// 此接口（DescribeSubOrganizations）用于查询子机构信息。
        /// 
        /// 注：此接口仅可查询您所属机构应用号创建的子机构信息，不可跨应用/跨机构查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubOrganizationsRequest"/></param>
        /// <returns><see cref="DescribeSubOrganizationsResponse"/></returns>
        public DescribeSubOrganizationsResponse DescribeSubOrganizationsSync(DescribeSubOrganizationsRequest req)
        {
            return InternalRequestAsync<DescribeSubOrganizationsResponse>(req, "DescribeSubOrganizations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeUsers）用于查询应用号下的个人用户信息。
        /// 
        /// 注：此接口仅可查询您所属机构应用号创建的个人用户信息，不可跨应用/跨机构查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers");
        }

        /// <summary>
        /// 此接口（DescribeUsers）用于查询应用号下的个人用户信息。
        /// 
        /// 注：此接口仅可查询您所属机构应用号创建的个人用户信息，不可跨应用/跨机构查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public DescribeUsersResponse DescribeUsersSync(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过此接口（DestroyFlowFile）可删除指定流程中的合同文件。
        /// 
        /// 注：调用此接口前，请确保此流程已属于归档状态。您可通过查询流程信息接口（DescribeFlow）进行查询。
        /// </summary>
        /// <param name="req"><see cref="DestroyFlowFileRequest"/></param>
        /// <returns><see cref="DestroyFlowFileResponse"/></returns>
        public Task<DestroyFlowFileResponse> DestroyFlowFile(DestroyFlowFileRequest req)
        {
            return InternalRequestAsync<DestroyFlowFileResponse>(req, "DestroyFlowFile");
        }

        /// <summary>
        /// 通过此接口（DestroyFlowFile）可删除指定流程中的合同文件。
        /// 
        /// 注：调用此接口前，请确保此流程已属于归档状态。您可通过查询流程信息接口（DescribeFlow）进行查询。
        /// </summary>
        /// <param name="req"><see cref="DestroyFlowFileRequest"/></param>
        /// <returns><see cref="DestroyFlowFileResponse"/></returns>
        public DestroyFlowFileResponse DestroyFlowFileSync(DestroyFlowFileRequest req)
        {
            return InternalRequestAsync<DestroyFlowFileResponse>(req, "DestroyFlowFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成企业电子印章
        /// </summary>
        /// <param name="req"><see cref="GenerateOrganizationSealRequest"/></param>
        /// <returns><see cref="GenerateOrganizationSealResponse"/></returns>
        public Task<GenerateOrganizationSealResponse> GenerateOrganizationSeal(GenerateOrganizationSealRequest req)
        {
            return InternalRequestAsync<GenerateOrganizationSealResponse>(req, "GenerateOrganizationSeal");
        }

        /// <summary>
        /// 生成企业电子印章
        /// </summary>
        /// <param name="req"><see cref="GenerateOrganizationSealRequest"/></param>
        /// <returns><see cref="GenerateOrganizationSealResponse"/></returns>
        public GenerateOrganizationSealResponse GenerateOrganizationSealSync(GenerateOrganizationSealRequest req)
        {
            return InternalRequestAsync<GenerateOrganizationSealResponse>(req, "GenerateOrganizationSeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（GenerateUserSeal）用于生成个人签名图片。
        /// 
        /// 注意：
        /// 1. 个人签名由用户注册时预留的姓名信息生成，不支持自定义签名内容。
        /// 2. 个人用户仅支持拥有一个系统生成的电子签名。
        /// </summary>
        /// <param name="req"><see cref="GenerateUserSealRequest"/></param>
        /// <returns><see cref="GenerateUserSealResponse"/></returns>
        public Task<GenerateUserSealResponse> GenerateUserSeal(GenerateUserSealRequest req)
        {
            return InternalRequestAsync<GenerateUserSealResponse>(req, "GenerateUserSeal");
        }

        /// <summary>
        /// 此接口（GenerateUserSeal）用于生成个人签名图片。
        /// 
        /// 注意：
        /// 1. 个人签名由用户注册时预留的姓名信息生成，不支持自定义签名内容。
        /// 2. 个人用户仅支持拥有一个系统生成的电子签名。
        /// </summary>
        /// <param name="req"><see cref="GenerateUserSealRequest"/></param>
        /// <returns><see cref="GenerateUserSealResponse"/></returns>
        public GenerateUserSealResponse GenerateUserSealSync(GenerateUserSealRequest req)
        {
            return InternalRequestAsync<GenerateUserSealResponse>(req, "GenerateUserSeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口 (ModifyOrganizationDefaultSeal) 用于重新指定企业默认印章。
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationDefaultSealRequest"/></param>
        /// <returns><see cref="ModifyOrganizationDefaultSealResponse"/></returns>
        public Task<ModifyOrganizationDefaultSealResponse> ModifyOrganizationDefaultSeal(ModifyOrganizationDefaultSealRequest req)
        {
            return InternalRequestAsync<ModifyOrganizationDefaultSealResponse>(req, "ModifyOrganizationDefaultSeal");
        }

        /// <summary>
        /// 此接口 (ModifyOrganizationDefaultSeal) 用于重新指定企业默认印章。
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationDefaultSealRequest"/></param>
        /// <returns><see cref="ModifyOrganizationDefaultSealResponse"/></returns>
        public ModifyOrganizationDefaultSealResponse ModifyOrganizationDefaultSealSync(ModifyOrganizationDefaultSealRequest req)
        {
            return InternalRequestAsync<ModifyOrganizationDefaultSealResponse>(req, "ModifyOrganizationDefaultSeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（ModifySeal）用于修改指定印章ID的印章图片和名称。
        /// 
        /// 注：印章类型暂不支持修改，如需调整，请联系客服经理或通过创建印章接口（CreateSeal）进行创建新印章。
        /// </summary>
        /// <param name="req"><see cref="ModifySealRequest"/></param>
        /// <returns><see cref="ModifySealResponse"/></returns>
        public Task<ModifySealResponse> ModifySeal(ModifySealRequest req)
        {
            return InternalRequestAsync<ModifySealResponse>(req, "ModifySeal");
        }

        /// <summary>
        /// 此接口（ModifySeal）用于修改指定印章ID的印章图片和名称。
        /// 
        /// 注：印章类型暂不支持修改，如需调整，请联系客服经理或通过创建印章接口（CreateSeal）进行创建新印章。
        /// </summary>
        /// <param name="req"><see cref="ModifySealRequest"/></param>
        /// <returns><see cref="ModifySealResponse"/></returns>
        public ModifySealResponse ModifySealSync(ModifySealRequest req)
        {
            return InternalRequestAsync<ModifySealResponse>(req, "ModifySeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（ModifySubOrganizationInfo）用于更新子机构信息。
        /// 
        /// 注：若修改子机构名称或更新机构证件照片，需要重新通过子机构实名接口（VerifySubOrganization）进行重新实名。
        /// </summary>
        /// <param name="req"><see cref="ModifySubOrganizationInfoRequest"/></param>
        /// <returns><see cref="ModifySubOrganizationInfoResponse"/></returns>
        public Task<ModifySubOrganizationInfoResponse> ModifySubOrganizationInfo(ModifySubOrganizationInfoRequest req)
        {
            return InternalRequestAsync<ModifySubOrganizationInfoResponse>(req, "ModifySubOrganizationInfo");
        }

        /// <summary>
        /// 此接口（ModifySubOrganizationInfo）用于更新子机构信息。
        /// 
        /// 注：若修改子机构名称或更新机构证件照片，需要重新通过子机构实名接口（VerifySubOrganization）进行重新实名。
        /// </summary>
        /// <param name="req"><see cref="ModifySubOrganizationInfoRequest"/></param>
        /// <returns><see cref="ModifySubOrganizationInfoResponse"/></returns>
        public ModifySubOrganizationInfoResponse ModifySubOrganizationInfoSync(ModifySubOrganizationInfoRequest req)
        {
            return InternalRequestAsync<ModifySubOrganizationInfoResponse>(req, "ModifySubOrganizationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（ModifyUser）用于更新个人用户信息。
        /// 
        /// 注：若修改用户姓名，需要重新通过个人用户实名接口（VerifyUser）进行重新实名。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser");
        }

        /// <summary>
        /// 此接口（ModifyUser）用于更新个人用户信息。
        /// 
        /// 注：若修改用户姓名，需要重新通过个人用户实名接口（VerifyUser）进行重新实名。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口 (ModifyUserDefaultSeal) 用于重新指定个人默认印章。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserDefaultSealRequest"/></param>
        /// <returns><see cref="ModifyUserDefaultSealResponse"/></returns>
        public Task<ModifyUserDefaultSealResponse> ModifyUserDefaultSeal(ModifyUserDefaultSealRequest req)
        {
            return InternalRequestAsync<ModifyUserDefaultSealResponse>(req, "ModifyUserDefaultSeal");
        }

        /// <summary>
        /// 此接口 (ModifyUserDefaultSeal) 用于重新指定个人默认印章。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserDefaultSealRequest"/></param>
        /// <returns><see cref="ModifyUserDefaultSealResponse"/></returns>
        public ModifyUserDefaultSealResponse ModifyUserDefaultSealSync(ModifyUserDefaultSealRequest req)
        {
            return InternalRequestAsync<ModifyUserDefaultSealResponse>(req, "ModifyUserDefaultSeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（RejectFlow）用于用户拒绝签署合同流程。
        /// </summary>
        /// <param name="req"><see cref="RejectFlowRequest"/></param>
        /// <returns><see cref="RejectFlowResponse"/></returns>
        public Task<RejectFlowResponse> RejectFlow(RejectFlowRequest req)
        {
            return InternalRequestAsync<RejectFlowResponse>(req, "RejectFlow");
        }

        /// <summary>
        /// 此接口（RejectFlow）用于用户拒绝签署合同流程。
        /// </summary>
        /// <param name="req"><see cref="RejectFlowRequest"/></param>
        /// <returns><see cref="RejectFlowResponse"/></returns>
        public RejectFlowResponse RejectFlowSync(RejectFlowRequest req)
        {
            return InternalRequestAsync<RejectFlowResponse>(req, "RejectFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（SendFlow）用于指定签署者及签署内容，后续可通过生成签署接口（CreateSignUrl）获取签署url。
        /// </summary>
        /// <param name="req"><see cref="SendFlowRequest"/></param>
        /// <returns><see cref="SendFlowResponse"/></returns>
        public Task<SendFlowResponse> SendFlow(SendFlowRequest req)
        {
            return InternalRequestAsync<SendFlowResponse>(req, "SendFlow");
        }

        /// <summary>
        /// 此接口（SendFlow）用于指定签署者及签署内容，后续可通过生成签署接口（CreateSignUrl）获取签署url。
        /// </summary>
        /// <param name="req"><see cref="SendFlowRequest"/></param>
        /// <returns><see cref="SendFlowResponse"/></returns>
        public SendFlowResponse SendFlowSync(SendFlowRequest req)
        {
            return InternalRequestAsync<SendFlowResponse>(req, "SendFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发送流程并获取签署URL
        /// </summary>
        /// <param name="req"><see cref="SendFlowUrlRequest"/></param>
        /// <returns><see cref="SendFlowUrlResponse"/></returns>
        public Task<SendFlowUrlResponse> SendFlowUrl(SendFlowUrlRequest req)
        {
            return InternalRequestAsync<SendFlowUrlResponse>(req, "SendFlowUrl");
        }

        /// <summary>
        /// 发送流程并获取签署URL
        /// </summary>
        /// <param name="req"><see cref="SendFlowUrlRequest"/></param>
        /// <returns><see cref="SendFlowUrlResponse"/></returns>
        public SendFlowUrlResponse SendFlowUrlSync(SendFlowUrlRequest req)
        {
            return InternalRequestAsync<SendFlowUrlResponse>(req, "SendFlowUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于发送签署验证码
        /// </summary>
        /// <param name="req"><see cref="SendSignInnerVerifyCodeRequest"/></param>
        /// <returns><see cref="SendSignInnerVerifyCodeResponse"/></returns>
        public Task<SendSignInnerVerifyCodeResponse> SendSignInnerVerifyCode(SendSignInnerVerifyCodeRequest req)
        {
            return InternalRequestAsync<SendSignInnerVerifyCodeResponse>(req, "SendSignInnerVerifyCode");
        }

        /// <summary>
        /// 此接口用于发送签署验证码
        /// </summary>
        /// <param name="req"><see cref="SendSignInnerVerifyCodeRequest"/></param>
        /// <returns><see cref="SendSignInnerVerifyCodeResponse"/></returns>
        public SendSignInnerVerifyCodeResponse SendSignInnerVerifyCodeSync(SendSignInnerVerifyCodeRequest req)
        {
            return InternalRequestAsync<SendSignInnerVerifyCodeResponse>(req, "SendSignInnerVerifyCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（SignFlow）可用于对流程文件进行签署。
        /// </summary>
        /// <param name="req"><see cref="SignFlowRequest"/></param>
        /// <returns><see cref="SignFlowResponse"/></returns>
        public Task<SignFlowResponse> SignFlow(SignFlowRequest req)
        {
            return InternalRequestAsync<SignFlowResponse>(req, "SignFlow");
        }

        /// <summary>
        /// 此接口（SignFlow）可用于对流程文件进行签署。
        /// </summary>
        /// <param name="req"><see cref="SignFlowRequest"/></param>
        /// <returns><see cref="SignFlowResponse"/></returns>
        public SignFlowResponse SignFlowSync(SignFlowRequest req)
        {
            return InternalRequestAsync<SignFlowResponse>(req, "SignFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（UploadFiles）用于文件上传。
        /// </summary>
        /// <param name="req"><see cref="UploadFilesRequest"/></param>
        /// <returns><see cref="UploadFilesResponse"/></returns>
        public Task<UploadFilesResponse> UploadFiles(UploadFilesRequest req)
        {
            return InternalRequestAsync<UploadFilesResponse>(req, "UploadFiles");
        }

        /// <summary>
        /// 此接口（UploadFiles）用于文件上传。
        /// </summary>
        /// <param name="req"><see cref="UploadFilesRequest"/></param>
        /// <returns><see cref="UploadFilesResponse"/></returns>
        public UploadFilesResponse UploadFilesSync(UploadFilesRequest req)
        {
            return InternalRequestAsync<UploadFilesResponse>(req, "UploadFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（VerifySubOrganization）用于通过子机构的实名认证。
        /// 
        /// 注：此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="VerifySubOrganizationRequest"/></param>
        /// <returns><see cref="VerifySubOrganizationResponse"/></returns>
        public Task<VerifySubOrganizationResponse> VerifySubOrganization(VerifySubOrganizationRequest req)
        {
            return InternalRequestAsync<VerifySubOrganizationResponse>(req, "VerifySubOrganization");
        }

        /// <summary>
        /// 此接口（VerifySubOrganization）用于通过子机构的实名认证。
        /// 
        /// 注：此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="VerifySubOrganizationRequest"/></param>
        /// <returns><see cref="VerifySubOrganizationResponse"/></returns>
        public VerifySubOrganizationResponse VerifySubOrganizationSync(VerifySubOrganizationRequest req)
        {
            return InternalRequestAsync<VerifySubOrganizationResponse>(req, "VerifySubOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 第三方应用可通过此接口（VerifyUser）将腾讯电子签个人用户的实名认证状态设为通过。
        /// 
        /// 注：此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="VerifyUserRequest"/></param>
        /// <returns><see cref="VerifyUserResponse"/></returns>
        public Task<VerifyUserResponse> VerifyUser(VerifyUserRequest req)
        {
            return InternalRequestAsync<VerifyUserResponse>(req, "VerifyUser");
        }

        /// <summary>
        /// 第三方应用可通过此接口（VerifyUser）将腾讯电子签个人用户的实名认证状态设为通过。
        /// 
        /// 注：此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="VerifyUserRequest"/></param>
        /// <returns><see cref="VerifyUserResponse"/></returns>
        public VerifyUserResponse VerifyUserSync(VerifyUserRequest req)
        {
            return InternalRequestAsync<VerifyUserResponse>(req, "VerifyUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
