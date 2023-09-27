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

namespace TencentCloud.Essbasic.V20210526
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Essbasic.V20210526.Models;

   public class EssbasicClient : AbstractClient{

       private const string endpoint = "essbasic.tencentcloudapi.com";
       private const string version = "2021-05-26";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EssbasicClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 指定需要批量撤销的签署流程Id，批量撤销合同
        /// 客户指定需要撤销的签署流程Id，最多100个，超过100不处理；
        /// 
        /// 可以撤回：未全部签署完成
        ///  不可以撤回：已全部签署完成、已拒签、已过期、已撤回、拒绝填写、已解除等合同状态。
        /// 
        /// **满足撤销条件的合同会发起异步撤销流程，不满足撤销条件的合同返回失败原因。**
        /// 
        /// **合同撤销成功后，会通过合同状态为 CANCEL 的回调消息通知调用方 [具体可参考回调消息](https://qian.tencent.com/developers/scenes/partner/callback_data_types#-%E5%90%88%E5%90%8C%E7%8A%B6%E6%80%81%E9%80%9A%E7%9F%A5---flowstatuschange)**
        /// 
        /// **注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人**
        /// </summary>
        /// <param name="req"><see cref="ChannelBatchCancelFlowsRequest"/></param>
        /// <returns><see cref="ChannelBatchCancelFlowsResponse"/></returns>
        public async Task<ChannelBatchCancelFlowsResponse> ChannelBatchCancelFlows(ChannelBatchCancelFlowsRequest req)
        {
             JsonResponseModel<ChannelBatchCancelFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelBatchCancelFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelBatchCancelFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定需要批量撤销的签署流程Id，批量撤销合同
        /// 客户指定需要撤销的签署流程Id，最多100个，超过100不处理；
        /// 
        /// 可以撤回：未全部签署完成
        ///  不可以撤回：已全部签署完成、已拒签、已过期、已撤回、拒绝填写、已解除等合同状态。
        /// 
        /// **满足撤销条件的合同会发起异步撤销流程，不满足撤销条件的合同返回失败原因。**
        /// 
        /// **合同撤销成功后，会通过合同状态为 CANCEL 的回调消息通知调用方 [具体可参考回调消息](https://qian.tencent.com/developers/scenes/partner/callback_data_types#-%E5%90%88%E5%90%8C%E7%8A%B6%E6%80%81%E9%80%9A%E7%9F%A5---flowstatuschange)**
        /// 
        /// **注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人**
        /// </summary>
        /// <param name="req"><see cref="ChannelBatchCancelFlowsRequest"/></param>
        /// <returns><see cref="ChannelBatchCancelFlowsResponse"/></returns>
        public ChannelBatchCancelFlowsResponse ChannelBatchCancelFlowsSync(ChannelBatchCancelFlowsRequest req)
        {
             JsonResponseModel<ChannelBatchCancelFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelBatchCancelFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelBatchCancelFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤销签署流程接口，可以撤回：未全部签署完成；不可以撤回（终态）：已全部签署完成、已拒签、已过期、已撤回。
        /// 注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人
        /// </summary>
        /// <param name="req"><see cref="ChannelCancelFlowRequest"/></param>
        /// <returns><see cref="ChannelCancelFlowResponse"/></returns>
        public async Task<ChannelCancelFlowResponse> ChannelCancelFlow(ChannelCancelFlowRequest req)
        {
             JsonResponseModel<ChannelCancelFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCancelFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCancelFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤销签署流程接口，可以撤回：未全部签署完成；不可以撤回（终态）：已全部签署完成、已拒签、已过期、已撤回。
        /// 注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人
        /// </summary>
        /// <param name="req"><see cref="ChannelCancelFlowRequest"/></param>
        /// <returns><see cref="ChannelCancelFlowResponse"/></returns>
        public ChannelCancelFlowResponse ChannelCancelFlowSync(ChannelCancelFlowRequest req)
        {
             JsonResponseModel<ChannelCancelFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCancelFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCancelFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCancelMultiFlowSignQRCode）用于取消一码多扫二维码。该接口对传入的二维码ID，若还在有效期内，可以提前失效。
        /// </summary>
        /// <param name="req"><see cref="ChannelCancelMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="ChannelCancelMultiFlowSignQRCodeResponse"/></returns>
        public async Task<ChannelCancelMultiFlowSignQRCodeResponse> ChannelCancelMultiFlowSignQRCode(ChannelCancelMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<ChannelCancelMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCancelMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCancelMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCancelMultiFlowSignQRCode）用于取消一码多扫二维码。该接口对传入的二维码ID，若还在有效期内，可以提前失效。
        /// </summary>
        /// <param name="req"><see cref="ChannelCancelMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="ChannelCancelMultiFlowSignQRCodeResponse"/></returns>
        public ChannelCancelMultiFlowSignQRCodeResponse ChannelCancelMultiFlowSignQRCodeSync(ChannelCancelMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<ChannelCancelMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCancelMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCancelMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCancelUserAutoSignEnableUrl）用来撤销发送给个人用户的自动签开通链接，撤销后对应的个人用户开通链接失效。若个人用户已经完成开通，将无法撤销。（处方单场景专用，使用此接口请与客户经理确认）
        /// </summary>
        /// <param name="req"><see cref="ChannelCancelUserAutoSignEnableUrlRequest"/></param>
        /// <returns><see cref="ChannelCancelUserAutoSignEnableUrlResponse"/></returns>
        public async Task<ChannelCancelUserAutoSignEnableUrlResponse> ChannelCancelUserAutoSignEnableUrl(ChannelCancelUserAutoSignEnableUrlRequest req)
        {
             JsonResponseModel<ChannelCancelUserAutoSignEnableUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCancelUserAutoSignEnableUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCancelUserAutoSignEnableUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCancelUserAutoSignEnableUrl）用来撤销发送给个人用户的自动签开通链接，撤销后对应的个人用户开通链接失效。若个人用户已经完成开通，将无法撤销。（处方单场景专用，使用此接口请与客户经理确认）
        /// </summary>
        /// <param name="req"><see cref="ChannelCancelUserAutoSignEnableUrlRequest"/></param>
        /// <returns><see cref="ChannelCancelUserAutoSignEnableUrlResponse"/></returns>
        public ChannelCancelUserAutoSignEnableUrlResponse ChannelCancelUserAutoSignEnableUrlSync(ChannelCancelUserAutoSignEnableUrlRequest req)
        {
             JsonResponseModel<ChannelCancelUserAutoSignEnableUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCancelUserAutoSignEnableUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCancelUserAutoSignEnableUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定需要批量撤销的签署流程Id，获取批量撤销链接 - 不建议使用此接口，可使用ChannelBatchCancelFlows
        /// 客户指定需要撤销的签署流程Id，最多100个，超过100不处理；
        /// 接口调用成功返回批量撤销合同的链接，通过链接跳转到电子签小程序完成批量撤销;
        /// 
        /// 可以撤回：未全部签署完成
        ///  不可以撤回：已全部签署完成、已拒签、已过期、已撤回、拒绝填写、已解除等合同状态。
        /// 
        /// 注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateBatchCancelFlowUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateBatchCancelFlowUrlResponse"/></returns>
        public async Task<ChannelCreateBatchCancelFlowUrlResponse> ChannelCreateBatchCancelFlowUrl(ChannelCreateBatchCancelFlowUrlRequest req)
        {
             JsonResponseModel<ChannelCreateBatchCancelFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateBatchCancelFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateBatchCancelFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定需要批量撤销的签署流程Id，获取批量撤销链接 - 不建议使用此接口，可使用ChannelBatchCancelFlows
        /// 客户指定需要撤销的签署流程Id，最多100个，超过100不处理；
        /// 接口调用成功返回批量撤销合同的链接，通过链接跳转到电子签小程序完成批量撤销;
        /// 
        /// 可以撤回：未全部签署完成
        ///  不可以撤回：已全部签署完成、已拒签、已过期、已撤回、拒绝填写、已解除等合同状态。
        /// 
        /// 注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateBatchCancelFlowUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateBatchCancelFlowUrlResponse"/></returns>
        public ChannelCreateBatchCancelFlowUrlResponse ChannelCreateBatchCancelFlowUrlSync(ChannelCreateBatchCancelFlowUrlRequest req)
        {
             JsonResponseModel<ChannelCreateBatchCancelFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateBatchCancelFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateBatchCancelFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，创建小程序批量签署链接，个人/企业员工点击此链接即可跳转小程序进行批量签署。
        /// 请确保生成链接时候的身份信息和签署合同参与方的信息保持一致。
        /// 
        /// 注：
        /// - 参与人点击链接后需短信验证码才能查看合同内容。
        /// - 企业用户批量签署，需要传OrganizationName（参与方所在企业名称）参数生成签署链接，`请确保此企业已完成腾讯电子签企业认证`。
        /// - 个人批量签署，签名区`仅支持手写签名`。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateBatchSignUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateBatchSignUrlResponse"/></returns>
        public async Task<ChannelCreateBatchSignUrlResponse> ChannelCreateBatchSignUrl(ChannelCreateBatchSignUrlRequest req)
        {
             JsonResponseModel<ChannelCreateBatchSignUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateBatchSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateBatchSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，创建小程序批量签署链接，个人/企业员工点击此链接即可跳转小程序进行批量签署。
        /// 请确保生成链接时候的身份信息和签署合同参与方的信息保持一致。
        /// 
        /// 注：
        /// - 参与人点击链接后需短信验证码才能查看合同内容。
        /// - 企业用户批量签署，需要传OrganizationName（参与方所在企业名称）参数生成签署链接，`请确保此企业已完成腾讯电子签企业认证`。
        /// - 个人批量签署，签名区`仅支持手写签名`。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateBatchSignUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateBatchSignUrlResponse"/></returns>
        public ChannelCreateBatchSignUrlResponse ChannelCreateBatchSignUrlSync(ChannelCreateBatchSignUrlRequest req)
        {
             JsonResponseModel<ChannelCreateBatchSignUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateBatchSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateBatchSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCreateBoundFlows）用于子客领取合同，经办人需要有相应的角色，合同不能重复领取。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateBoundFlowsRequest"/></param>
        /// <returns><see cref="ChannelCreateBoundFlowsResponse"/></returns>
        public async Task<ChannelCreateBoundFlowsResponse> ChannelCreateBoundFlows(ChannelCreateBoundFlowsRequest req)
        {
             JsonResponseModel<ChannelCreateBoundFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateBoundFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateBoundFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCreateBoundFlows）用于子客领取合同，经办人需要有相应的角色，合同不能重复领取。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateBoundFlowsRequest"/></param>
        /// <returns><see cref="ChannelCreateBoundFlowsResponse"/></returns>
        public ChannelCreateBoundFlowsResponse ChannelCreateBoundFlowsSync(ChannelCreateBoundFlowsRequest req)
        {
             JsonResponseModel<ChannelCreateBoundFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateBoundFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateBoundFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传了word、excel、图片文件后，通过该接口发起文件转换任务，将word、excel、图片文件转换为pdf文件。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateConvertTaskApiRequest"/></param>
        /// <returns><see cref="ChannelCreateConvertTaskApiResponse"/></returns>
        public async Task<ChannelCreateConvertTaskApiResponse> ChannelCreateConvertTaskApi(ChannelCreateConvertTaskApiRequest req)
        {
             JsonResponseModel<ChannelCreateConvertTaskApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateConvertTaskApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateConvertTaskApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传了word、excel、图片文件后，通过该接口发起文件转换任务，将word、excel、图片文件转换为pdf文件。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateConvertTaskApiRequest"/></param>
        /// <returns><see cref="ChannelCreateConvertTaskApiResponse"/></returns>
        public ChannelCreateConvertTaskApiResponse ChannelCreateConvertTaskApiSync(ChannelCreateConvertTaskApiRequest req)
        {
             JsonResponseModel<ChannelCreateConvertTaskApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateConvertTaskApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateConvertTaskApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ChannelCreateEmbedWebUrl）用于创建常规模块嵌入web的链接
        /// 本接口支持创建：创建印章，创建模板，修改模板，预览模板，预览合同流程的web链接
        /// 进入web连接后与当前控制台操作保持一致
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateEmbedWebUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateEmbedWebUrlResponse"/></returns>
        public async Task<ChannelCreateEmbedWebUrlResponse> ChannelCreateEmbedWebUrl(ChannelCreateEmbedWebUrlRequest req)
        {
             JsonResponseModel<ChannelCreateEmbedWebUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateEmbedWebUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateEmbedWebUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ChannelCreateEmbedWebUrl）用于创建常规模块嵌入web的链接
        /// 本接口支持创建：创建印章，创建模板，修改模板，预览模板，预览合同流程的web链接
        /// 进入web连接后与当前控制台操作保持一致
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateEmbedWebUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateEmbedWebUrlResponse"/></returns>
        public ChannelCreateEmbedWebUrlResponse ChannelCreateEmbedWebUrlSync(ChannelCreateEmbedWebUrlRequest req)
        {
             JsonResponseModel<ChannelCreateEmbedWebUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateEmbedWebUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateEmbedWebUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（ChannelCreateFlowByFiles）用于通过文件创建签署流程。此接口静默签能力不可直接使用，请联系客户经理申请使用
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowByFilesRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowByFilesResponse"/></returns>
        public async Task<ChannelCreateFlowByFilesResponse> ChannelCreateFlowByFiles(ChannelCreateFlowByFilesRequest req)
        {
             JsonResponseModel<ChannelCreateFlowByFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateFlowByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（ChannelCreateFlowByFiles）用于通过文件创建签署流程。此接口静默签能力不可直接使用，请联系客户经理申请使用
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowByFilesRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowByFilesResponse"/></returns>
        public ChannelCreateFlowByFilesResponse ChannelCreateFlowByFilesSync(ChannelCreateFlowByFilesRequest req)
        {
             JsonResponseModel<ChannelCreateFlowByFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateFlowByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（ChannelCreateFlowGroupByFiles）用于通过多文件创建合同组签署流程。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowGroupByFilesRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowGroupByFilesResponse"/></returns>
        public async Task<ChannelCreateFlowGroupByFilesResponse> ChannelCreateFlowGroupByFiles(ChannelCreateFlowGroupByFilesRequest req)
        {
             JsonResponseModel<ChannelCreateFlowGroupByFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateFlowGroupByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowGroupByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（ChannelCreateFlowGroupByFiles）用于通过多文件创建合同组签署流程。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowGroupByFilesRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowGroupByFilesResponse"/></returns>
        public ChannelCreateFlowGroupByFilesResponse ChannelCreateFlowGroupByFilesSync(ChannelCreateFlowGroupByFilesRequest req)
        {
             JsonResponseModel<ChannelCreateFlowGroupByFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateFlowGroupByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowGroupByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（ChannelCreateFlowGroupByTemplates）用于通过多模板创建合同组签署流程。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowGroupByTemplatesRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowGroupByTemplatesResponse"/></returns>
        public async Task<ChannelCreateFlowGroupByTemplatesResponse> ChannelCreateFlowGroupByTemplates(ChannelCreateFlowGroupByTemplatesRequest req)
        {
             JsonResponseModel<ChannelCreateFlowGroupByTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateFlowGroupByTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowGroupByTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（ChannelCreateFlowGroupByTemplates）用于通过多模板创建合同组签署流程。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowGroupByTemplatesRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowGroupByTemplatesResponse"/></returns>
        public ChannelCreateFlowGroupByTemplatesResponse ChannelCreateFlowGroupByTemplatesSync(ChannelCreateFlowGroupByTemplatesRequest req)
        {
             JsonResponseModel<ChannelCreateFlowGroupByTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateFlowGroupByTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowGroupByTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定需要批量催办的签署流程Id，批量催办合同，最多100个；接口失败后返回错误信息
        /// 注意:
        /// 该接口不可直接调用，请联系客户经理申请使用
        /// 仅能催办当前状态为“待签署”的签署人，且只能催办一次
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowRemindsRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowRemindsResponse"/></returns>
        public async Task<ChannelCreateFlowRemindsResponse> ChannelCreateFlowReminds(ChannelCreateFlowRemindsRequest req)
        {
             JsonResponseModel<ChannelCreateFlowRemindsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateFlowReminds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowRemindsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定需要批量催办的签署流程Id，批量催办合同，最多100个；接口失败后返回错误信息
        /// 注意:
        /// 该接口不可直接调用，请联系客户经理申请使用
        /// 仅能催办当前状态为“待签署”的签署人，且只能催办一次
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowRemindsRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowRemindsResponse"/></returns>
        public ChannelCreateFlowRemindsResponse ChannelCreateFlowRemindsSync(ChannelCreateFlowRemindsRequest req)
        {
             JsonResponseModel<ChannelCreateFlowRemindsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateFlowReminds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowRemindsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交企业流程审批结果
        /// 目前存在两种审核操作，签署审核，发起审核
        /// 签署审核：通过接口（CreateFlowsByTemplates或ChannelCreateFlowByFiles或ChannelCreatePrepareFlow）发起签署流程后，若指定了参数 NeedSignReview 为true,则可以调用此接口，指定operate=SignReview，提交企业内部签署审批结果；若签署流程状态正常，且本企业存在签署方未签署，同一签署流程可以多次提交签署审批结果，签署时的最后一个“审批结果”有效
        /// 
        /// 发起审核：通过接口ChannelCreatePrepareFlow指定发起后需要审核，则可以通过调用此接口，指定operate=CreateReview，提交企业内部审批结果，可多次提交，当通过后，后续提交结果无效
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowSignReviewRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowSignReviewResponse"/></returns>
        public async Task<ChannelCreateFlowSignReviewResponse> ChannelCreateFlowSignReview(ChannelCreateFlowSignReviewRequest req)
        {
             JsonResponseModel<ChannelCreateFlowSignReviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateFlowSignReview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowSignReviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交企业流程审批结果
        /// 目前存在两种审核操作，签署审核，发起审核
        /// 签署审核：通过接口（CreateFlowsByTemplates或ChannelCreateFlowByFiles或ChannelCreatePrepareFlow）发起签署流程后，若指定了参数 NeedSignReview 为true,则可以调用此接口，指定operate=SignReview，提交企业内部签署审批结果；若签署流程状态正常，且本企业存在签署方未签署，同一签署流程可以多次提交签署审批结果，签署时的最后一个“审批结果”有效
        /// 
        /// 发起审核：通过接口ChannelCreatePrepareFlow指定发起后需要审核，则可以通过调用此接口，指定operate=CreateReview，提交企业内部审批结果，可多次提交，当通过后，后续提交结果无效
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowSignReviewRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowSignReviewResponse"/></returns>
        public ChannelCreateFlowSignReviewResponse ChannelCreateFlowSignReviewSync(ChannelCreateFlowSignReviewRequest req)
        {
             JsonResponseModel<ChannelCreateFlowSignReviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateFlowSignReview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowSignReviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建个人签署H5签署链接，请联系客户经理申请使用<br/>
        /// 该接口用于发起合同后，生成C端签署人的签署链接<br/>
        /// 注意：该接口目前签署人类型仅支持个人签署方（PERSON）<br/>
        /// 注意：该接口可生成签署链接的C端签署人必须仅有手写签名和时间类型的签署控件<br/>
        /// 注意：该接口返回的签署链接是用于APP集成的场景，支持APP打开或浏览器直接打开，不支持微信小程序嵌入。微信小程序请使用小程序跳转或半屏弹窗的方式<br/>
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowSignUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowSignUrlResponse"/></returns>
        public async Task<ChannelCreateFlowSignUrlResponse> ChannelCreateFlowSignUrl(ChannelCreateFlowSignUrlRequest req)
        {
             JsonResponseModel<ChannelCreateFlowSignUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateFlowSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建个人签署H5签署链接，请联系客户经理申请使用<br/>
        /// 该接口用于发起合同后，生成C端签署人的签署链接<br/>
        /// 注意：该接口目前签署人类型仅支持个人签署方（PERSON）<br/>
        /// 注意：该接口可生成签署链接的C端签署人必须仅有手写签名和时间类型的签署控件<br/>
        /// 注意：该接口返回的签署链接是用于APP集成的场景，支持APP打开或浏览器直接打开，不支持微信小程序嵌入。微信小程序请使用小程序跳转或半屏弹窗的方式<br/>
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowSignUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowSignUrlResponse"/></returns>
        public ChannelCreateFlowSignUrlResponse ChannelCreateFlowSignUrlSync(ChannelCreateFlowSignUrlRequest req)
        {
             JsonResponseModel<ChannelCreateFlowSignUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateFlowSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCreateMultiFlowSignQRCode）用于创建一码多扫流程签署二维码。 适用场景：无需填写签署人信息，可通过模板id生成签署二维码，签署人可通过扫描二维码补充签署信息进行实名签署。常用于提前不知道签署人的身份信息场景，例如：劳务工招工、大批量员工入职等场景。
        /// 
        /// **本接口适用于发起方没有填写控件的 B2C或者单C模板**
        /// 
        /// **若是B2C模板,还要满足以下任意一个条件**
        /// 
        /// - 模板中配置的签署顺序是无序
        /// - B端企业的签署方式是静默签署
        /// - B端企业是非首位签署
        /// 
        /// 通过一码多扫二维码发起的合同，合同涉及到的回调消息可参考文档[合同发起及签署相关回调
        /// ]( https://qian.tencent.com/developers/partner/callback_types_contracts_sign)
        /// 
        /// 用户通过签署二维码发起合同时，因企业额度不足导致失败 会触发签署二维码相关回调,具体参考文档[签署二维码相关回调](https://qian.tencent.com/developers/partner/callback_types_commons#%E7%AD%BE%E7%BD%B2%E4%BA%8C%E7%BB%B4%E7%A0%81%E7%9B%B8%E5%85%B3%E5%9B%9E%E8%B0%83)
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="ChannelCreateMultiFlowSignQRCodeResponse"/></returns>
        public async Task<ChannelCreateMultiFlowSignQRCodeResponse> ChannelCreateMultiFlowSignQRCode(ChannelCreateMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<ChannelCreateMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCreateMultiFlowSignQRCode）用于创建一码多扫流程签署二维码。 适用场景：无需填写签署人信息，可通过模板id生成签署二维码，签署人可通过扫描二维码补充签署信息进行实名签署。常用于提前不知道签署人的身份信息场景，例如：劳务工招工、大批量员工入职等场景。
        /// 
        /// **本接口适用于发起方没有填写控件的 B2C或者单C模板**
        /// 
        /// **若是B2C模板,还要满足以下任意一个条件**
        /// 
        /// - 模板中配置的签署顺序是无序
        /// - B端企业的签署方式是静默签署
        /// - B端企业是非首位签署
        /// 
        /// 通过一码多扫二维码发起的合同，合同涉及到的回调消息可参考文档[合同发起及签署相关回调
        /// ]( https://qian.tencent.com/developers/partner/callback_types_contracts_sign)
        /// 
        /// 用户通过签署二维码发起合同时，因企业额度不足导致失败 会触发签署二维码相关回调,具体参考文档[签署二维码相关回调](https://qian.tencent.com/developers/partner/callback_types_commons#%E7%AD%BE%E7%BD%B2%E4%BA%8C%E7%BB%B4%E7%A0%81%E7%9B%B8%E5%85%B3%E5%9B%9E%E8%B0%83)
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="ChannelCreateMultiFlowSignQRCodeResponse"/></returns>
        public ChannelCreateMultiFlowSignQRCodeResponse ChannelCreateMultiFlowSignQRCodeSync(ChannelCreateMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<ChannelCreateMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成渠道子客编辑企业信息二维码
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateOrganizationModifyQrCodeRequest"/></param>
        /// <returns><see cref="ChannelCreateOrganizationModifyQrCodeResponse"/></returns>
        public async Task<ChannelCreateOrganizationModifyQrCodeResponse> ChannelCreateOrganizationModifyQrCode(ChannelCreateOrganizationModifyQrCodeRequest req)
        {
             JsonResponseModel<ChannelCreateOrganizationModifyQrCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateOrganizationModifyQrCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateOrganizationModifyQrCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成渠道子客编辑企业信息二维码
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateOrganizationModifyQrCodeRequest"/></param>
        /// <returns><see cref="ChannelCreateOrganizationModifyQrCodeResponse"/></returns>
        public ChannelCreateOrganizationModifyQrCodeResponse ChannelCreateOrganizationModifyQrCodeSync(ChannelCreateOrganizationModifyQrCodeRequest req)
        {
             JsonResponseModel<ChannelCreateOrganizationModifyQrCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateOrganizationModifyQrCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateOrganizationModifyQrCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建预发起合同
        /// 通过此接口指定：合同，签署人，填写控件信息，生成预创建合同链接，点击后跳转到web页面完成合同创建并发起
        /// 可指定合同信息不可更改，签署人信息不可更改
        /// 合同发起后，填写及签署流程与现有操作流程一致
        /// 注意：目前仅支持模板发起
        /// </summary>
        /// <param name="req"><see cref="ChannelCreatePrepareFlowRequest"/></param>
        /// <returns><see cref="ChannelCreatePrepareFlowResponse"/></returns>
        public async Task<ChannelCreatePrepareFlowResponse> ChannelCreatePrepareFlow(ChannelCreatePrepareFlowRequest req)
        {
             JsonResponseModel<ChannelCreatePrepareFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreatePrepareFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreatePrepareFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建预发起合同
        /// 通过此接口指定：合同，签署人，填写控件信息，生成预创建合同链接，点击后跳转到web页面完成合同创建并发起
        /// 可指定合同信息不可更改，签署人信息不可更改
        /// 合同发起后，填写及签署流程与现有操作流程一致
        /// 注意：目前仅支持模板发起
        /// </summary>
        /// <param name="req"><see cref="ChannelCreatePrepareFlowRequest"/></param>
        /// <returns><see cref="ChannelCreatePrepareFlowResponse"/></returns>
        public ChannelCreatePrepareFlowResponse ChannelCreatePrepareFlowSync(ChannelCreatePrepareFlowRequest req)
        {
             JsonResponseModel<ChannelCreatePrepareFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreatePrepareFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreatePrepareFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ChannelCreatePreparedPersonalEsign）用于创建导入个人印章（处方单场景专用，使用此接口请与客户经理确认）。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreatePreparedPersonalEsignRequest"/></param>
        /// <returns><see cref="ChannelCreatePreparedPersonalEsignResponse"/></returns>
        public async Task<ChannelCreatePreparedPersonalEsignResponse> ChannelCreatePreparedPersonalEsign(ChannelCreatePreparedPersonalEsignRequest req)
        {
             JsonResponseModel<ChannelCreatePreparedPersonalEsignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreatePreparedPersonalEsign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreatePreparedPersonalEsignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ChannelCreatePreparedPersonalEsign）用于创建导入个人印章（处方单场景专用，使用此接口请与客户经理确认）。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreatePreparedPersonalEsignRequest"/></param>
        /// <returns><see cref="ChannelCreatePreparedPersonalEsignResponse"/></returns>
        public ChannelCreatePreparedPersonalEsignResponse ChannelCreatePreparedPersonalEsignSync(ChannelCreatePreparedPersonalEsignRequest req)
        {
             JsonResponseModel<ChannelCreatePreparedPersonalEsignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreatePreparedPersonalEsign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreatePreparedPersonalEsignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起解除协议，主要应用场景为：基于一份已经签署的合同，进行解除操作。
        /// 合同发起人必须在电子签已经进行实名。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateReleaseFlowRequest"/></param>
        /// <returns><see cref="ChannelCreateReleaseFlowResponse"/></returns>
        public async Task<ChannelCreateReleaseFlowResponse> ChannelCreateReleaseFlow(ChannelCreateReleaseFlowRequest req)
        {
             JsonResponseModel<ChannelCreateReleaseFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateReleaseFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateReleaseFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起解除协议，主要应用场景为：基于一份已经签署的合同，进行解除操作。
        /// 合同发起人必须在电子签已经进行实名。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateReleaseFlowRequest"/></param>
        /// <returns><see cref="ChannelCreateReleaseFlowResponse"/></returns>
        public ChannelCreateReleaseFlowResponse ChannelCreateReleaseFlowSync(ChannelCreateReleaseFlowRequest req)
        {
             JsonResponseModel<ChannelCreateReleaseFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateReleaseFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateReleaseFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCreateRole）用来创建企业自定义角色。
        /// 
        /// 适用场景1：创建当前企业的自定义角色，并且创建时不进行权限的设置（PermissionGroups 参数不传），角色中的权限内容可通过接口 ChannelModifyRole 完成更新。
        /// 
        /// 适用场景2：创建当前企业的自定义角色，并且创建时进行权限的设置（PermissionGroups 参数要传），权限树内容 PermissionGroups 可参考接口 ChannelDescribeRoles 的输出。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateRoleRequest"/></param>
        /// <returns><see cref="ChannelCreateRoleResponse"/></returns>
        public async Task<ChannelCreateRoleResponse> ChannelCreateRole(ChannelCreateRoleRequest req)
        {
             JsonResponseModel<ChannelCreateRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCreateRole）用来创建企业自定义角色。
        /// 
        /// 适用场景1：创建当前企业的自定义角色，并且创建时不进行权限的设置（PermissionGroups 参数不传），角色中的权限内容可通过接口 ChannelModifyRole 完成更新。
        /// 
        /// 适用场景2：创建当前企业的自定义角色，并且创建时进行权限的设置（PermissionGroups 参数要传），权限树内容 PermissionGroups 可参考接口 ChannelDescribeRoles 的输出。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateRoleRequest"/></param>
        /// <returns><see cref="ChannelCreateRoleResponse"/></returns>
        public ChannelCreateRoleResponse ChannelCreateRoleSync(ChannelCreateRoleRequest req)
        {
             JsonResponseModel<ChannelCreateRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将指定印章授权给第三方平台子客企业下的某些员工
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateSealPolicyRequest"/></param>
        /// <returns><see cref="ChannelCreateSealPolicyResponse"/></returns>
        public async Task<ChannelCreateSealPolicyResponse> ChannelCreateSealPolicy(ChannelCreateSealPolicyRequest req)
        {
             JsonResponseModel<ChannelCreateSealPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateSealPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateSealPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将指定印章授权给第三方平台子客企业下的某些员工
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateSealPolicyRequest"/></param>
        /// <returns><see cref="ChannelCreateSealPolicyResponse"/></returns>
        public ChannelCreateSealPolicyResponse ChannelCreateSealPolicySync(ChannelCreateSealPolicyRequest req)
        {
             JsonResponseModel<ChannelCreateSealPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateSealPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateSealPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口获取个人用户开启自动签的跳转链接
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateUserAutoSignEnableUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateUserAutoSignEnableUrlResponse"/></returns>
        public async Task<ChannelCreateUserAutoSignEnableUrlResponse> ChannelCreateUserAutoSignEnableUrl(ChannelCreateUserAutoSignEnableUrlRequest req)
        {
             JsonResponseModel<ChannelCreateUserAutoSignEnableUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateUserAutoSignEnableUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateUserAutoSignEnableUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口获取个人用户开启自动签的跳转链接
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateUserAutoSignEnableUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateUserAutoSignEnableUrlResponse"/></returns>
        public ChannelCreateUserAutoSignEnableUrlResponse ChannelCreateUserAutoSignEnableUrlSync(ChannelCreateUserAutoSignEnableUrlRequest req)
        {
             JsonResponseModel<ChannelCreateUserAutoSignEnableUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateUserAutoSignEnableUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateUserAutoSignEnableUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，绑定员工角色，支持以电子签userId、客户系统userId两种方式调用。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateUserRolesRequest"/></param>
        /// <returns><see cref="ChannelCreateUserRolesResponse"/></returns>
        public async Task<ChannelCreateUserRolesResponse> ChannelCreateUserRoles(ChannelCreateUserRolesRequest req)
        {
             JsonResponseModel<ChannelCreateUserRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateUserRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateUserRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，绑定员工角色，支持以电子签userId、客户系统userId两种方式调用。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateUserRolesRequest"/></param>
        /// <returns><see cref="ChannelCreateUserRolesResponse"/></returns>
        public ChannelCreateUserRolesResponse ChannelCreateUserRolesSync(ChannelCreateUserRolesRequest req)
        {
             JsonResponseModel<ChannelCreateUserRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateUserRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateUserRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用来创建嵌入式页面个性化主题配置（例如是否展示电子签logo、定义主题色等），该接口配合其他所有可嵌入页面接口使用
        /// 创建配置对当前第三方应用全局生效，如果多次调用，会以最后一次的配置为准
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateWebThemeConfigRequest"/></param>
        /// <returns><see cref="ChannelCreateWebThemeConfigResponse"/></returns>
        public async Task<ChannelCreateWebThemeConfigResponse> ChannelCreateWebThemeConfig(ChannelCreateWebThemeConfigRequest req)
        {
             JsonResponseModel<ChannelCreateWebThemeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateWebThemeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateWebThemeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用来创建嵌入式页面个性化主题配置（例如是否展示电子签logo、定义主题色等），该接口配合其他所有可嵌入页面接口使用
        /// 创建配置对当前第三方应用全局生效，如果多次调用，会以最后一次的配置为准
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateWebThemeConfigRequest"/></param>
        /// <returns><see cref="ChannelCreateWebThemeConfigResponse"/></returns>
        public ChannelCreateWebThemeConfigResponse ChannelCreateWebThemeConfigSync(ChannelCreateWebThemeConfigRequest req)
        {
             JsonResponseModel<ChannelCreateWebThemeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateWebThemeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateWebThemeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelDeleteRole）用来删除企业自定义角色。
        /// 
        /// 注意：系统角色不可删除。
        /// </summary>
        /// <param name="req"><see cref="ChannelDeleteRoleRequest"/></param>
        /// <returns><see cref="ChannelDeleteRoleResponse"/></returns>
        public async Task<ChannelDeleteRoleResponse> ChannelDeleteRole(ChannelDeleteRoleRequest req)
        {
             JsonResponseModel<ChannelDeleteRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelDeleteRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDeleteRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelDeleteRole）用来删除企业自定义角色。
        /// 
        /// 注意：系统角色不可删除。
        /// </summary>
        /// <param name="req"><see cref="ChannelDeleteRoleRequest"/></param>
        /// <returns><see cref="ChannelDeleteRoleResponse"/></returns>
        public ChannelDeleteRoleResponse ChannelDeleteRoleSync(ChannelDeleteRoleRequest req)
        {
             JsonResponseModel<ChannelDeleteRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelDeleteRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDeleteRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，删除员工绑定的角色，支持以电子签userId、客户系统userId两种方式调用。
        /// </summary>
        /// <param name="req"><see cref="ChannelDeleteRoleUsersRequest"/></param>
        /// <returns><see cref="ChannelDeleteRoleUsersResponse"/></returns>
        public async Task<ChannelDeleteRoleUsersResponse> ChannelDeleteRoleUsers(ChannelDeleteRoleUsersRequest req)
        {
             JsonResponseModel<ChannelDeleteRoleUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelDeleteRoleUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDeleteRoleUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，删除员工绑定的角色，支持以电子签userId、客户系统userId两种方式调用。
        /// </summary>
        /// <param name="req"><see cref="ChannelDeleteRoleUsersRequest"/></param>
        /// <returns><see cref="ChannelDeleteRoleUsersResponse"/></returns>
        public ChannelDeleteRoleUsersResponse ChannelDeleteRoleUsersSync(ChannelDeleteRoleUsersRequest req)
        {
             JsonResponseModel<ChannelDeleteRoleUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelDeleteRoleUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDeleteRoleUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定印章下多个授权信息
        /// </summary>
        /// <param name="req"><see cref="ChannelDeleteSealPoliciesRequest"/></param>
        /// <returns><see cref="ChannelDeleteSealPoliciesResponse"/></returns>
        public async Task<ChannelDeleteSealPoliciesResponse> ChannelDeleteSealPolicies(ChannelDeleteSealPoliciesRequest req)
        {
             JsonResponseModel<ChannelDeleteSealPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelDeleteSealPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDeleteSealPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定印章下多个授权信息
        /// </summary>
        /// <param name="req"><see cref="ChannelDeleteSealPoliciesRequest"/></param>
        /// <returns><see cref="ChannelDeleteSealPoliciesResponse"/></returns>
        public ChannelDeleteSealPoliciesResponse ChannelDeleteSealPoliciesSync(ChannelDeleteSealPoliciesRequest req)
        {
             JsonResponseModel<ChannelDeleteSealPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelDeleteSealPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDeleteSealPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业员工列表
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeEmployeesRequest"/></param>
        /// <returns><see cref="ChannelDescribeEmployeesResponse"/></returns>
        public async Task<ChannelDescribeEmployeesResponse> ChannelDescribeEmployees(ChannelDescribeEmployeesRequest req)
        {
             JsonResponseModel<ChannelDescribeEmployeesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelDescribeEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业员工列表
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeEmployeesRequest"/></param>
        /// <returns><see cref="ChannelDescribeEmployeesResponse"/></returns>
        public ChannelDescribeEmployeesResponse ChannelDescribeEmployeesSync(ChannelDescribeEmployeesRequest req)
        {
             JsonResponseModel<ChannelDescribeEmployeesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelDescribeEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流程填写控件内容，可以根据流程Id查询该流程相关联的填写控件信息和填写内容。 注意：使用此接口前，需要在【企业应用管理】-【应用集成】-【第三方应用管理】中开通【下载应用内全量合同文件及内容数据】功能。
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeFlowComponentsRequest"/></param>
        /// <returns><see cref="ChannelDescribeFlowComponentsResponse"/></returns>
        public async Task<ChannelDescribeFlowComponentsResponse> ChannelDescribeFlowComponents(ChannelDescribeFlowComponentsRequest req)
        {
             JsonResponseModel<ChannelDescribeFlowComponentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelDescribeFlowComponents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeFlowComponentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流程填写控件内容，可以根据流程Id查询该流程相关联的填写控件信息和填写内容。 注意：使用此接口前，需要在【企业应用管理】-【应用集成】-【第三方应用管理】中开通【下载应用内全量合同文件及内容数据】功能。
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeFlowComponentsRequest"/></param>
        /// <returns><see cref="ChannelDescribeFlowComponentsResponse"/></returns>
        public ChannelDescribeFlowComponentsResponse ChannelDescribeFlowComponentsSync(ChannelDescribeFlowComponentsRequest req)
        {
             JsonResponseModel<ChannelDescribeFlowComponentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelDescribeFlowComponents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeFlowComponentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询子客企业电子印章，需要操作者具有管理印章权限
        /// 客户指定需要获取的印章数量和偏移量，数量最多100，超过100按100处理；入参InfoType控制印章是否携带授权人信息，为1则携带，为0则返回的授权人信息为空数组。接口调用成功返回印章的信息列表还有企业印章的总数，只返回启用的印章。
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeOrganizationSealsRequest"/></param>
        /// <returns><see cref="ChannelDescribeOrganizationSealsResponse"/></returns>
        public async Task<ChannelDescribeOrganizationSealsResponse> ChannelDescribeOrganizationSeals(ChannelDescribeOrganizationSealsRequest req)
        {
             JsonResponseModel<ChannelDescribeOrganizationSealsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelDescribeOrganizationSeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeOrganizationSealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询子客企业电子印章，需要操作者具有管理印章权限
        /// 客户指定需要获取的印章数量和偏移量，数量最多100，超过100按100处理；入参InfoType控制印章是否携带授权人信息，为1则携带，为0则返回的授权人信息为空数组。接口调用成功返回印章的信息列表还有企业印章的总数，只返回启用的印章。
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeOrganizationSealsRequest"/></param>
        /// <returns><see cref="ChannelDescribeOrganizationSealsResponse"/></returns>
        public ChannelDescribeOrganizationSealsResponse ChannelDescribeOrganizationSealsSync(ChannelDescribeOrganizationSealsRequest req)
        {
             JsonResponseModel<ChannelDescribeOrganizationSealsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelDescribeOrganizationSeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeOrganizationSealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询企业角色列表，法人的角色是系统保留角色，不会返回，按照角色创建时间升序排列
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeRolesRequest"/></param>
        /// <returns><see cref="ChannelDescribeRolesResponse"/></returns>
        public async Task<ChannelDescribeRolesResponse> ChannelDescribeRoles(ChannelDescribeRolesRequest req)
        {
             JsonResponseModel<ChannelDescribeRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelDescribeRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询企业角色列表，法人的角色是系统保留角色，不会返回，按照角色创建时间升序排列
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeRolesRequest"/></param>
        /// <returns><see cref="ChannelDescribeRolesResponse"/></returns>
        public ChannelDescribeRolesResponse ChannelDescribeRolesSync(ChannelDescribeRolesRequest req)
        {
             JsonResponseModel<ChannelDescribeRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelDescribeRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口查询个人用户自动签开启状态
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeUserAutoSignStatusRequest"/></param>
        /// <returns><see cref="ChannelDescribeUserAutoSignStatusResponse"/></returns>
        public async Task<ChannelDescribeUserAutoSignStatusResponse> ChannelDescribeUserAutoSignStatus(ChannelDescribeUserAutoSignStatusRequest req)
        {
             JsonResponseModel<ChannelDescribeUserAutoSignStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelDescribeUserAutoSignStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeUserAutoSignStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口查询个人用户自动签开启状态
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeUserAutoSignStatusRequest"/></param>
        /// <returns><see cref="ChannelDescribeUserAutoSignStatusResponse"/></returns>
        public ChannelDescribeUserAutoSignStatusResponse ChannelDescribeUserAutoSignStatusSync(ChannelDescribeUserAutoSignStatusRequest req)
        {
             JsonResponseModel<ChannelDescribeUserAutoSignStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelDescribeUserAutoSignStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeUserAutoSignStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口关闭个人的自动签功能
        /// </summary>
        /// <param name="req"><see cref="ChannelDisableUserAutoSignRequest"/></param>
        /// <returns><see cref="ChannelDisableUserAutoSignResponse"/></returns>
        public async Task<ChannelDisableUserAutoSignResponse> ChannelDisableUserAutoSign(ChannelDisableUserAutoSignRequest req)
        {
             JsonResponseModel<ChannelDisableUserAutoSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelDisableUserAutoSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDisableUserAutoSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口关闭个人的自动签功能
        /// </summary>
        /// <param name="req"><see cref="ChannelDisableUserAutoSignRequest"/></param>
        /// <returns><see cref="ChannelDisableUserAutoSignResponse"/></returns>
        public ChannelDisableUserAutoSignResponse ChannelDisableUserAutoSignSync(ChannelDisableUserAutoSignRequest req)
        {
             JsonResponseModel<ChannelDisableUserAutoSignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelDisableUserAutoSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDisableUserAutoSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转换任务的状态。转换任务Id通过发起转换任务接口（ChannelCreateConvertTaskApi）获取。
        /// 注意：大文件转换所需的时间可能会比较长。
        /// </summary>
        /// <param name="req"><see cref="ChannelGetTaskResultApiRequest"/></param>
        /// <returns><see cref="ChannelGetTaskResultApiResponse"/></returns>
        public async Task<ChannelGetTaskResultApiResponse> ChannelGetTaskResultApi(ChannelGetTaskResultApiRequest req)
        {
             JsonResponseModel<ChannelGetTaskResultApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelGetTaskResultApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelGetTaskResultApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转换任务的状态。转换任务Id通过发起转换任务接口（ChannelCreateConvertTaskApi）获取。
        /// 注意：大文件转换所需的时间可能会比较长。
        /// </summary>
        /// <param name="req"><see cref="ChannelGetTaskResultApiRequest"/></param>
        /// <returns><see cref="ChannelGetTaskResultApiResponse"/></returns>
        public ChannelGetTaskResultApiResponse ChannelGetTaskResultApiSync(ChannelGetTaskResultApiRequest req)
        {
             JsonResponseModel<ChannelGetTaskResultApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelGetTaskResultApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelGetTaskResultApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelModifyRole）用来更新企业自定义角色。
        /// 
        /// 适用场景1：更新当前企业的自定义角色的名称或描述等其他信息，更新时不进行权限的设置（PermissionGroups 参数不传）。
        /// 
        /// 适用场景2：更新当前企业的自定义角色的权限信息，更新时进行权限的设置（PermissionGroups 参数要传），权限树内容 PermissionGroups 可参考接口 ChannelDescribeRoles 的输出。
        /// </summary>
        /// <param name="req"><see cref="ChannelModifyRoleRequest"/></param>
        /// <returns><see cref="ChannelModifyRoleResponse"/></returns>
        public async Task<ChannelModifyRoleResponse> ChannelModifyRole(ChannelModifyRoleRequest req)
        {
             JsonResponseModel<ChannelModifyRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelModifyRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelModifyRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelModifyRole）用来更新企业自定义角色。
        /// 
        /// 适用场景1：更新当前企业的自定义角色的名称或描述等其他信息，更新时不进行权限的设置（PermissionGroups 参数不传）。
        /// 
        /// 适用场景2：更新当前企业的自定义角色的权限信息，更新时进行权限的设置（PermissionGroups 参数要传），权限树内容 PermissionGroups 可参考接口 ChannelDescribeRoles 的输出。
        /// </summary>
        /// <param name="req"><see cref="ChannelModifyRoleRequest"/></param>
        /// <returns><see cref="ChannelModifyRoleResponse"/></returns>
        public ChannelModifyRoleResponse ChannelModifyRoleSync(ChannelModifyRoleRequest req)
        {
             JsonResponseModel<ChannelModifyRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelModifyRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelModifyRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ChannelUpdateSealStatus）用于第三方应用平台为子客企业更新印章状态
        /// </summary>
        /// <param name="req"><see cref="ChannelUpdateSealStatusRequest"/></param>
        /// <returns><see cref="ChannelUpdateSealStatusResponse"/></returns>
        public async Task<ChannelUpdateSealStatusResponse> ChannelUpdateSealStatus(ChannelUpdateSealStatusRequest req)
        {
             JsonResponseModel<ChannelUpdateSealStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelUpdateSealStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelUpdateSealStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ChannelUpdateSealStatus）用于第三方应用平台为子客企业更新印章状态
        /// </summary>
        /// <param name="req"><see cref="ChannelUpdateSealStatusRequest"/></param>
        /// <returns><see cref="ChannelUpdateSealStatusResponse"/></returns>
        public ChannelUpdateSealStatusResponse ChannelUpdateSealStatusSync(ChannelUpdateSealStatusRequest req)
        {
             JsonResponseModel<ChannelUpdateSealStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelUpdateSealStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelUpdateSealStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对流程的合同文件进行数字签名验证，判断文件是否被篡改。
        /// </summary>
        /// <param name="req"><see cref="ChannelVerifyPdfRequest"/></param>
        /// <returns><see cref="ChannelVerifyPdfResponse"/></returns>
        public async Task<ChannelVerifyPdfResponse> ChannelVerifyPdf(ChannelVerifyPdfRequest req)
        {
             JsonResponseModel<ChannelVerifyPdfResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelVerifyPdf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelVerifyPdfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对流程的合同文件进行数字签名验证，判断文件是否被篡改。
        /// </summary>
        /// <param name="req"><see cref="ChannelVerifyPdfRequest"/></param>
        /// <returns><see cref="ChannelVerifyPdfResponse"/></returns>
        public ChannelVerifyPdfResponse ChannelVerifyPdfSync(ChannelVerifyPdfRequest req)
        {
             JsonResponseModel<ChannelVerifyPdfResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelVerifyPdf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelVerifyPdfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建出证报告，返回报告 ID。需要配合出证套餐才能调用。
        /// 出证需要一定时间，建议调用创建出证24小时之后再通过DescribeChannelFlowEvidenceReport进行查询。
        /// </summary>
        /// <param name="req"><see cref="CreateChannelFlowEvidenceReportRequest"/></param>
        /// <returns><see cref="CreateChannelFlowEvidenceReportResponse"/></returns>
        public async Task<CreateChannelFlowEvidenceReportResponse> CreateChannelFlowEvidenceReport(CreateChannelFlowEvidenceReportRequest req)
        {
             JsonResponseModel<CreateChannelFlowEvidenceReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateChannelFlowEvidenceReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateChannelFlowEvidenceReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建出证报告，返回报告 ID。需要配合出证套餐才能调用。
        /// 出证需要一定时间，建议调用创建出证24小时之后再通过DescribeChannelFlowEvidenceReport进行查询。
        /// </summary>
        /// <param name="req"><see cref="CreateChannelFlowEvidenceReportRequest"/></param>
        /// <returns><see cref="CreateChannelFlowEvidenceReportResponse"/></returns>
        public CreateChannelFlowEvidenceReportResponse CreateChannelFlowEvidenceReportSync(CreateChannelFlowEvidenceReportRequest req)
        {
             JsonResponseModel<CreateChannelFlowEvidenceReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateChannelFlowEvidenceReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateChannelFlowEvidenceReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateConsoleLoginUrl）用于创建第三方平台子客企业控制台Web/移动登录链接。支持web控制台、电子签小程序和H5链接。登录链接是进入子客控制台的唯一入口。
        /// 链接访问后，会根据企业的和员工的状态（企业根据ProxyOrganizationOpenId参数，员工根据OpenId参数判断），进入不同的流程，主要情况分类如下：
        /// 1. 若子客企业未激活，会进入企业激活流程，首次参与激活流程的经办人会成为超管。
        /// 2. 若子客企业已激活，员工未激活，则会进入经办人激活流程。
        /// 3. 若子客企业、经办人均已完成认证，则会直接进入子客Web控制台。
        /// 
        /// 如果是企业激活流程，需要注意如下情况：
        /// 
        /// 1. 若在激活过程中，更换用户OpenID重新生成链接，之前的认证会被清理。因此不要在认证过程中多人同时操作，导致认证过程互相影响。
        /// 2. 若您认证中发现信息有误需要重新认证，可以通过更换OpenID重新生成链接的方式，来清理掉已有的流程。
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleLoginUrlRequest"/></param>
        /// <returns><see cref="CreateConsoleLoginUrlResponse"/></returns>
        public async Task<CreateConsoleLoginUrlResponse> CreateConsoleLoginUrl(CreateConsoleLoginUrlRequest req)
        {
             JsonResponseModel<CreateConsoleLoginUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConsoleLoginUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsoleLoginUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateConsoleLoginUrl）用于创建第三方平台子客企业控制台Web/移动登录链接。支持web控制台、电子签小程序和H5链接。登录链接是进入子客控制台的唯一入口。
        /// 链接访问后，会根据企业的和员工的状态（企业根据ProxyOrganizationOpenId参数，员工根据OpenId参数判断），进入不同的流程，主要情况分类如下：
        /// 1. 若子客企业未激活，会进入企业激活流程，首次参与激活流程的经办人会成为超管。
        /// 2. 若子客企业已激活，员工未激活，则会进入经办人激活流程。
        /// 3. 若子客企业、经办人均已完成认证，则会直接进入子客Web控制台。
        /// 
        /// 如果是企业激活流程，需要注意如下情况：
        /// 
        /// 1. 若在激活过程中，更换用户OpenID重新生成链接，之前的认证会被清理。因此不要在认证过程中多人同时操作，导致认证过程互相影响。
        /// 2. 若您认证中发现信息有误需要重新认证，可以通过更换OpenID重新生成链接的方式，来清理掉已有的流程。
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleLoginUrlRequest"/></param>
        /// <returns><see cref="CreateConsoleLoginUrlResponse"/></returns>
        public CreateConsoleLoginUrlResponse CreateConsoleLoginUrlSync(CreateConsoleLoginUrlRequest req)
        {
             JsonResponseModel<CreateConsoleLoginUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConsoleLoginUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsoleLoginUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（CreateFlowsByTemplates）用于使用模板批量创建签署流程。当前可批量发起合同（签署流程）数量为1-20个。
        /// 如若在模板中配置了动态表格, 上传的附件必须为A4大小
        /// 合同发起人必须在电子签已经进行实名。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowsByTemplatesRequest"/></param>
        /// <returns><see cref="CreateFlowsByTemplatesResponse"/></returns>
        public async Task<CreateFlowsByTemplatesResponse> CreateFlowsByTemplates(CreateFlowsByTemplatesRequest req)
        {
             JsonResponseModel<CreateFlowsByTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowsByTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowsByTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（CreateFlowsByTemplates）用于使用模板批量创建签署流程。当前可批量发起合同（签署流程）数量为1-20个。
        /// 如若在模板中配置了动态表格, 上传的附件必须为A4大小
        /// 合同发起人必须在电子签已经进行实名。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowsByTemplatesRequest"/></param>
        /// <returns><see cref="CreateFlowsByTemplatesResponse"/></returns>
        public CreateFlowsByTemplatesResponse CreateFlowsByTemplatesSync(CreateFlowsByTemplatesRequest req)
        {
             JsonResponseModel<CreateFlowsByTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowsByTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowsByTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过图片为子客企业代创建印章，图片最大5MB
        /// </summary>
        /// <param name="req"><see cref="CreateSealByImageRequest"/></param>
        /// <returns><see cref="CreateSealByImageResponse"/></returns>
        public async Task<CreateSealByImageResponse> CreateSealByImage(CreateSealByImageRequest req)
        {
             JsonResponseModel<CreateSealByImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSealByImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSealByImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过图片为子客企业代创建印章，图片最大5MB
        /// </summary>
        /// <param name="req"><see cref="CreateSealByImageRequest"/></param>
        /// <returns><see cref="CreateSealByImageResponse"/></returns>
        public CreateSealByImageResponse CreateSealByImageSync(CreateSealByImageRequest req)
        {
             JsonResponseModel<CreateSealByImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSealByImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSealByImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建跳转小程序查看或签署的链接。
        /// 
        /// 跳转小程序的几种方式：主要是设置不同的EndPoint
        /// 1. 通过链接Url直接跳转到小程序，不需要返回
        /// 设置EndPoint为WEIXINAPP，得到链接打开即可。（与短信提醒用户签署形式一样）。
        /// 
        /// 2. 通过链接Url打开H5引导页-->点击跳转到小程序-->签署完退出小程序-->回到H5引导页-->跳转到指定JumpUrl
        /// 设置EndPoint为CHANNEL，指定JumpUrl，得到链接打开即可。
        /// 
        /// 3. 客户App直接跳转到小程序-->小程序签署完成-->返回App
        /// 跳转到小程序的实现，参考官方文档
        /// https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/launchApp.html
        /// 其中小程序的原始Id，请联系<对接技术人员>获取，或者查看小程序信息自助获取。
        /// 使用CreateSignUrls，设置EndPoint为APP，得到path。
        /// 
        /// 4. 客户小程序直接跳到电子签小程序-->签署完成退出电子签小程序-->回到客户小程序
        /// 跳转到小程序的实现，参考官方文档（分为全屏、半屏两种方式）
        /// 全屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html）
        /// 半屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html）
        /// 其中小程序的原始Id，请联系<对接技术人员>获取，或者查看小程序信息自助获取。
        /// 使用CreateSignUrls，设置EndPoint为APP，得到path。
        /// 
        /// 其中小程序的原始Id如下，或者查看小程序信息自助获取。
        /// 
        /// | 小程序 | AppID | 原始ID |
        /// | ------------ | ------------ | ------------ |
        /// | 腾讯电子签（正式版） | wxa023b292fd19d41d | gh_da88f6188665 |
        /// | 腾讯电子签Demo | wx371151823f6f3edf | gh_39a5d3de69fa |
        /// </summary>
        /// <param name="req"><see cref="CreateSignUrlsRequest"/></param>
        /// <returns><see cref="CreateSignUrlsResponse"/></returns>
        public async Task<CreateSignUrlsResponse> CreateSignUrls(CreateSignUrlsRequest req)
        {
             JsonResponseModel<CreateSignUrlsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSignUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建跳转小程序查看或签署的链接。
        /// 
        /// 跳转小程序的几种方式：主要是设置不同的EndPoint
        /// 1. 通过链接Url直接跳转到小程序，不需要返回
        /// 设置EndPoint为WEIXINAPP，得到链接打开即可。（与短信提醒用户签署形式一样）。
        /// 
        /// 2. 通过链接Url打开H5引导页-->点击跳转到小程序-->签署完退出小程序-->回到H5引导页-->跳转到指定JumpUrl
        /// 设置EndPoint为CHANNEL，指定JumpUrl，得到链接打开即可。
        /// 
        /// 3. 客户App直接跳转到小程序-->小程序签署完成-->返回App
        /// 跳转到小程序的实现，参考官方文档
        /// https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/launchApp.html
        /// 其中小程序的原始Id，请联系<对接技术人员>获取，或者查看小程序信息自助获取。
        /// 使用CreateSignUrls，设置EndPoint为APP，得到path。
        /// 
        /// 4. 客户小程序直接跳到电子签小程序-->签署完成退出电子签小程序-->回到客户小程序
        /// 跳转到小程序的实现，参考官方文档（分为全屏、半屏两种方式）
        /// 全屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html）
        /// 半屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html）
        /// 其中小程序的原始Id，请联系<对接技术人员>获取，或者查看小程序信息自助获取。
        /// 使用CreateSignUrls，设置EndPoint为APP，得到path。
        /// 
        /// 其中小程序的原始Id如下，或者查看小程序信息自助获取。
        /// 
        /// | 小程序 | AppID | 原始ID |
        /// | ------------ | ------------ | ------------ |
        /// | 腾讯电子签（正式版） | wxa023b292fd19d41d | gh_da88f6188665 |
        /// | 腾讯电子签Demo | wx371151823f6f3edf | gh_39a5d3de69fa |
        /// </summary>
        /// <param name="req"><see cref="CreateSignUrlsRequest"/></param>
        /// <returns><see cref="CreateSignUrlsResponse"/></returns>
        public CreateSignUrlsResponse CreateSignUrlsSync(CreateSignUrlsRequest req)
        {
             JsonResponseModel<CreateSignUrlsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSignUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询出证报告，返回报告 URL。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelFlowEvidenceReportRequest"/></param>
        /// <returns><see cref="DescribeChannelFlowEvidenceReportResponse"/></returns>
        public async Task<DescribeChannelFlowEvidenceReportResponse> DescribeChannelFlowEvidenceReport(DescribeChannelFlowEvidenceReportRequest req)
        {
             JsonResponseModel<DescribeChannelFlowEvidenceReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeChannelFlowEvidenceReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChannelFlowEvidenceReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询出证报告，返回报告 URL。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelFlowEvidenceReportRequest"/></param>
        /// <returns><see cref="DescribeChannelFlowEvidenceReportResponse"/></returns>
        public DescribeChannelFlowEvidenceReportResponse DescribeChannelFlowEvidenceReportSync(DescribeChannelFlowEvidenceReportRequest req)
        {
             JsonResponseModel<DescribeChannelFlowEvidenceReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeChannelFlowEvidenceReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChannelFlowEvidenceReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业扩展服务授权信息，企业经办人需要是企业超管或者法人
        /// </summary>
        /// <param name="req"><see cref="DescribeExtendedServiceAuthInfoRequest"/></param>
        /// <returns><see cref="DescribeExtendedServiceAuthInfoResponse"/></returns>
        public async Task<DescribeExtendedServiceAuthInfoResponse> DescribeExtendedServiceAuthInfo(DescribeExtendedServiceAuthInfoRequest req)
        {
             JsonResponseModel<DescribeExtendedServiceAuthInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExtendedServiceAuthInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtendedServiceAuthInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业扩展服务授权信息，企业经办人需要是企业超管或者法人
        /// </summary>
        /// <param name="req"><see cref="DescribeExtendedServiceAuthInfoRequest"/></param>
        /// <returns><see cref="DescribeExtendedServiceAuthInfoResponse"/></returns>
        public DescribeExtendedServiceAuthInfoResponse DescribeExtendedServiceAuthInfoSync(DescribeExtendedServiceAuthInfoRequest req)
        {
             JsonResponseModel<DescribeExtendedServiceAuthInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExtendedServiceAuthInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtendedServiceAuthInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeFlowDetailInfo）用于查询合同(签署流程)的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeFlowDetailInfoResponse"/></returns>
        public async Task<DescribeFlowDetailInfoResponse> DescribeFlowDetailInfo(DescribeFlowDetailInfoRequest req)
        {
             JsonResponseModel<DescribeFlowDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeFlowDetailInfo）用于查询合同(签署流程)的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeFlowDetailInfoResponse"/></returns>
        public DescribeFlowDetailInfoResponse DescribeFlowDetailInfoSync(DescribeFlowDetailInfoRequest req)
        {
             JsonResponseModel<DescribeFlowDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据签署流程信息批量获取资源下载链接，可以下载签署中、签署完的合同，需合作企业先进行授权。
        /// 此接口直接返回下载的资源的url，与接口GetDownloadFlowUrl跳转到控制台的下载方式不同。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUrlsByFlowsRequest"/></param>
        /// <returns><see cref="DescribeResourceUrlsByFlowsResponse"/></returns>
        public async Task<DescribeResourceUrlsByFlowsResponse> DescribeResourceUrlsByFlows(DescribeResourceUrlsByFlowsRequest req)
        {
             JsonResponseModel<DescribeResourceUrlsByFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceUrlsByFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceUrlsByFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据签署流程信息批量获取资源下载链接，可以下载签署中、签署完的合同，需合作企业先进行授权。
        /// 此接口直接返回下载的资源的url，与接口GetDownloadFlowUrl跳转到控制台的下载方式不同。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUrlsByFlowsRequest"/></param>
        /// <returns><see cref="DescribeResourceUrlsByFlowsResponse"/></returns>
        public DescribeResourceUrlsByFlowsResponse DescribeResourceUrlsByFlowsSync(DescribeResourceUrlsByFlowsRequest req)
        {
             JsonResponseModel<DescribeResourceUrlsByFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceUrlsByFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceUrlsByFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口（DescribeTemplates）查询该第三方平台子客企业在电子签拥有的有效模板，不包括第三方平台模板。
        /// 
        /// > **适用场景** 
        /// >
        /// >  该接口常用来配合“使用模板创建签署流程”接口作为前置的接口使用。 
        /// >  一个模板通常会包含以下结构信息
        /// >- 模板基本信息
        /// >- 发起方参与信息Promoter、签署参与方 Recipients，后者会在模板发起合同时用于指定参与方
        /// >- 填写控件 Components
        /// >- 签署控件 SignComponents
        /// >- 生成模板的文件基础信息 FileInfos
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTemplatesResponse"/></returns>
        public async Task<DescribeTemplatesResponse> DescribeTemplates(DescribeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口（DescribeTemplates）查询该第三方平台子客企业在电子签拥有的有效模板，不包括第三方平台模板。
        /// 
        /// > **适用场景** 
        /// >
        /// >  该接口常用来配合“使用模板创建签署流程”接口作为前置的接口使用。 
        /// >  一个模板通常会包含以下结构信息
        /// >- 模板基本信息
        /// >- 发起方参与信息Promoter、签署参与方 Recipients，后者会在模板发起合同时用于指定参与方
        /// >- 填写控件 Components
        /// >- 签署控件 SignComponents
        /// >- 生成模板的文件基础信息 FileInfos
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTemplatesResponse"/></returns>
        public DescribeTemplatesResponse DescribeTemplatesSync(DescribeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeUsage）用于获取第三方平台所有合作企业流量消耗情况。
        ///  注: 此接口每日限频50次，若要扩大限制次数,请提前与客服经理或邮件至e-contract@tencent.com进行联系。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageRequest"/></param>
        /// <returns><see cref="DescribeUsageResponse"/></returns>
        public async Task<DescribeUsageResponse> DescribeUsage(DescribeUsageRequest req)
        {
             JsonResponseModel<DescribeUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeUsage）用于获取第三方平台所有合作企业流量消耗情况。
        ///  注: 此接口每日限频50次，若要扩大限制次数,请提前与客服经理或邮件至e-contract@tencent.com进行联系。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageRequest"/></param>
        /// <returns><see cref="DescribeUsageResponse"/></returns>
        public DescribeUsageResponse DescribeUsageSync(DescribeUsageRequest req)
        {
             JsonResponseModel<DescribeUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（GetDownloadFlowUrl）用于创建电子签批量下载地址，让合作企业进入控制台直接下载，支持客户合同（流程）按照自定义文件夹形式 分类下载。
        /// 当前接口限制最多合同（流程）50个.
        /// 返回的链接只能使用一次
        /// </summary>
        /// <param name="req"><see cref="GetDownloadFlowUrlRequest"/></param>
        /// <returns><see cref="GetDownloadFlowUrlResponse"/></returns>
        public async Task<GetDownloadFlowUrlResponse> GetDownloadFlowUrl(GetDownloadFlowUrlRequest req)
        {
             JsonResponseModel<GetDownloadFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDownloadFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDownloadFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（GetDownloadFlowUrl）用于创建电子签批量下载地址，让合作企业进入控制台直接下载，支持客户合同（流程）按照自定义文件夹形式 分类下载。
        /// 当前接口限制最多合同（流程）50个.
        /// 返回的链接只能使用一次
        /// </summary>
        /// <param name="req"><see cref="GetDownloadFlowUrlRequest"/></param>
        /// <returns><see cref="GetDownloadFlowUrlResponse"/></returns>
        public GetDownloadFlowUrlResponse GetDownloadFlowUrlSync(GetDownloadFlowUrlRequest req)
        {
             JsonResponseModel<GetDownloadFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDownloadFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDownloadFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改（操作）企业扩展服务 ，企业经办人需要是企业超管或者法人。
        /// 
        /// 跳转小程序的几种方式：主要是设置不同的EndPoint
        /// 1. 通过链接Url直接跳转到小程序，不需要返回
        /// 设置EndPoint为WEIXINAPP，得到链接打开即可。
        /// 
        /// 2. 客户App直接跳转到小程序-->腾讯电子签小程序操作完成-->返回App
        /// 跳转到小程序的实现，参考官方文档
        /// https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/launchApp.html
        /// 其中小程序的原始Id，请联系<对接技术人员>获取，或者查看小程序信息自助获取。
        /// 设置EndPoint为APP，得到path。
        /// 
        /// 4. 客户小程序直接跳到电子签小程序-->腾讯电子签小程序操作完成--->回到客户小程序
        /// 跳转到小程序的实现，参考官方文档（分为全屏、半屏两种方式）
        /// 全屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html）
        /// 半屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html）
        /// 其中小程序的原始Id，请联系<对接技术人员>获取，或者查看小程序信息自助获取。
        /// 设置EndPoint为APP，得到path。
        /// 
        /// 其中小程序的原始Id如下，或者查看小程序信息自助获取。
        /// 
        /// | 小程序 | AppID | 原始ID |
        /// | ------------ | ------------ | ------------ |
        /// | 腾讯电子签（正式版） | wxa023b292fd19d41d | gh_da88f6188665 |
        /// | 腾讯电子签Demo | wx371151823f6f3edf | gh_39a5d3de69fa |
        /// </summary>
        /// <param name="req"><see cref="ModifyExtendedServiceRequest"/></param>
        /// <returns><see cref="ModifyExtendedServiceResponse"/></returns>
        public async Task<ModifyExtendedServiceResponse> ModifyExtendedService(ModifyExtendedServiceRequest req)
        {
             JsonResponseModel<ModifyExtendedServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyExtendedService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyExtendedServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改（操作）企业扩展服务 ，企业经办人需要是企业超管或者法人。
        /// 
        /// 跳转小程序的几种方式：主要是设置不同的EndPoint
        /// 1. 通过链接Url直接跳转到小程序，不需要返回
        /// 设置EndPoint为WEIXINAPP，得到链接打开即可。
        /// 
        /// 2. 客户App直接跳转到小程序-->腾讯电子签小程序操作完成-->返回App
        /// 跳转到小程序的实现，参考官方文档
        /// https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/launchApp.html
        /// 其中小程序的原始Id，请联系<对接技术人员>获取，或者查看小程序信息自助获取。
        /// 设置EndPoint为APP，得到path。
        /// 
        /// 4. 客户小程序直接跳到电子签小程序-->腾讯电子签小程序操作完成--->回到客户小程序
        /// 跳转到小程序的实现，参考官方文档（分为全屏、半屏两种方式）
        /// 全屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html）
        /// 半屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html）
        /// 其中小程序的原始Id，请联系<对接技术人员>获取，或者查看小程序信息自助获取。
        /// 设置EndPoint为APP，得到path。
        /// 
        /// 其中小程序的原始Id如下，或者查看小程序信息自助获取。
        /// 
        /// | 小程序 | AppID | 原始ID |
        /// | ------------ | ------------ | ------------ |
        /// | 腾讯电子签（正式版） | wxa023b292fd19d41d | gh_da88f6188665 |
        /// | 腾讯电子签Demo | wx371151823f6f3edf | gh_39a5d3de69fa |
        /// </summary>
        /// <param name="req"><see cref="ModifyExtendedServiceRequest"/></param>
        /// <returns><see cref="ModifyExtendedServiceResponse"/></returns>
        public ModifyExtendedServiceResponse ModifyExtendedServiceSync(ModifyExtendedServiceRequest req)
        {
             JsonResponseModel<ModifyExtendedServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyExtendedService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyExtendedServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（OperateChannelTemplate）用于针对第三方应用平台模板库中的模板对子客企业可见性的查询和设置。
        /// 
        /// > **使用场景**
        /// >
        /// >  1：查询 OperateType=SELECT
        /// > - 查询第三方应用平台模板库的可见性以及授权的子客列表。
        /// >
        /// >  2：修改部分子客授权 OperateType=UPDATE
        /// > - 对子客企业进行模板库中模板可见性的进行修改操作。
        /// >- 当模板未发布时，可以修改可见性AuthTag（part/all），当模板发布后，不可做此修改
        /// > - 若模板已发布且可见性AuthTag是part，可以通过ProxyOrganizationOpenIds增加子客的授权范围。如果是自动领取的模板，增加授权范围后会自动下发。
        /// >
        /// >  3：取消部分子客授权 OperateType=DELETE
        /// > - 对子客企业进行模板库中模板可见性的进行删除操作。
        /// > - 主要对于手动领取的模板，去除授权后子客在模板库中看不到，就无法再领取了。但是已经领取过成为自有模板的不会同步删除。
        /// > - 对于自动领取的模板，由于已经下发，更改授权不会影响。
        /// > - 如果要同步删除子客自有模板库中的模板，请使用OperateType=UPDATE+Available参数处理。
        /// </summary>
        /// <param name="req"><see cref="OperateChannelTemplateRequest"/></param>
        /// <returns><see cref="OperateChannelTemplateResponse"/></returns>
        public async Task<OperateChannelTemplateResponse> OperateChannelTemplate(OperateChannelTemplateRequest req)
        {
             JsonResponseModel<OperateChannelTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OperateChannelTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OperateChannelTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（OperateChannelTemplate）用于针对第三方应用平台模板库中的模板对子客企业可见性的查询和设置。
        /// 
        /// > **使用场景**
        /// >
        /// >  1：查询 OperateType=SELECT
        /// > - 查询第三方应用平台模板库的可见性以及授权的子客列表。
        /// >
        /// >  2：修改部分子客授权 OperateType=UPDATE
        /// > - 对子客企业进行模板库中模板可见性的进行修改操作。
        /// >- 当模板未发布时，可以修改可见性AuthTag（part/all），当模板发布后，不可做此修改
        /// > - 若模板已发布且可见性AuthTag是part，可以通过ProxyOrganizationOpenIds增加子客的授权范围。如果是自动领取的模板，增加授权范围后会自动下发。
        /// >
        /// >  3：取消部分子客授权 OperateType=DELETE
        /// > - 对子客企业进行模板库中模板可见性的进行删除操作。
        /// > - 主要对于手动领取的模板，去除授权后子客在模板库中看不到，就无法再领取了。但是已经领取过成为自有模板的不会同步删除。
        /// > - 对于自动领取的模板，由于已经下发，更改授权不会影响。
        /// > - 如果要同步删除子客自有模板库中的模板，请使用OperateType=UPDATE+Available参数处理。
        /// </summary>
        /// <param name="req"><see cref="OperateChannelTemplateRequest"/></param>
        /// <returns><see cref="OperateChannelTemplateResponse"/></returns>
        public OperateChannelTemplateResponse OperateChannelTemplateSync(OperateChannelTemplateRequest req)
        {
             JsonResponseModel<OperateChannelTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OperateChannelTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OperateChannelTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口 (PrepareFlows) 用于创建待发起文件
        /// 用户通过该接口进入签署流程发起的确认页面，进行发起信息二次确认， 如果确认则进行正常发起。
        /// 目前该接口只支持B2C，不建议使用，将会废弃。
        /// </summary>
        /// <param name="req"><see cref="PrepareFlowsRequest"/></param>
        /// <returns><see cref="PrepareFlowsResponse"/></returns>
        public async Task<PrepareFlowsResponse> PrepareFlows(PrepareFlowsRequest req)
        {
             JsonResponseModel<PrepareFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PrepareFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PrepareFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口 (PrepareFlows) 用于创建待发起文件
        /// 用户通过该接口进入签署流程发起的确认页面，进行发起信息二次确认， 如果确认则进行正常发起。
        /// 目前该接口只支持B2C，不建议使用，将会废弃。
        /// </summary>
        /// <param name="req"><see cref="PrepareFlowsRequest"/></param>
        /// <returns><see cref="PrepareFlowsResponse"/></returns>
        public PrepareFlowsResponse PrepareFlowsSync(PrepareFlowsRequest req)
        {
             JsonResponseModel<PrepareFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PrepareFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PrepareFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganization）用于同步第三方平台子客企业信息，包括企业名称，企业营业执照，企业统一社会信用代码和法人姓名等，便于子客企业在企业激活过程中无需手动上传营业执照或补充企业信息。注意：
        /// 1. 需要在子客企业激活前调用该接口，如果您的企业已经提交企业信息或者企业已经激活，同步的企业信息将不会生效。
        /// 2. 如果您同时传递了营业执照信息和企业名称等信息，在认证过程中将以营业执照中的企业信息为准，请注意企业信息需要和营业执照信息对应。
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationResponse"/></returns>
        public async Task<SyncProxyOrganizationResponse> SyncProxyOrganization(SyncProxyOrganizationRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncProxyOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganization）用于同步第三方平台子客企业信息，包括企业名称，企业营业执照，企业统一社会信用代码和法人姓名等，便于子客企业在企业激活过程中无需手动上传营业执照或补充企业信息。注意：
        /// 1. 需要在子客企业激活前调用该接口，如果您的企业已经提交企业信息或者企业已经激活，同步的企业信息将不会生效。
        /// 2. 如果您同时传递了营业执照信息和企业名称等信息，在认证过程中将以营业执照中的企业信息为准，请注意企业信息需要和营业执照信息对应。
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationResponse"/></returns>
        public SyncProxyOrganizationResponse SyncProxyOrganizationSync(SyncProxyOrganizationRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncProxyOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganizationOperators）用于同步 第三方平台子客企业经办人列表，主要是同步经办人的离职状态。子客Web控制台的组织架构管理，是依赖于第三方应用平台的，无法针对员工做新增/更新/离职等操作。 
        /// 若经办人信息有误，或者需要修改，也可以先将之前的经办人做离职操作，然后重新使用控制台链接CreateConsoleLoginUrl让经办人重新实名。
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationOperatorsRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationOperatorsResponse"/></returns>
        public async Task<SyncProxyOrganizationOperatorsResponse> SyncProxyOrganizationOperators(SyncProxyOrganizationOperatorsRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationOperatorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncProxyOrganizationOperators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationOperatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganizationOperators）用于同步 第三方平台子客企业经办人列表，主要是同步经办人的离职状态。子客Web控制台的组织架构管理，是依赖于第三方应用平台的，无法针对员工做新增/更新/离职等操作。 
        /// 若经办人信息有误，或者需要修改，也可以先将之前的经办人做离职操作，然后重新使用控制台链接CreateConsoleLoginUrl让经办人重新实名。
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationOperatorsRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationOperatorsResponse"/></returns>
        public SyncProxyOrganizationOperatorsResponse SyncProxyOrganizationOperatorsSync(SyncProxyOrganizationOperatorsRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationOperatorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncProxyOrganizationOperators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationOperatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（UploadFiles）用于文件上传。
        /// 其中上传的文件，图片类型(png/jpg/jpeg)大小限制为5M，其他大小限制为60M。
        /// 调用时需要设置Domain, 正式环境为 file.ess.tencent.cn。
        /// 代码示例：
        /// HttpProfile httpProfile = new HttpProfile();
        /// httpProfile.setEndpoint("file.test.ess.tencent.cn");
        /// </summary>
        /// <param name="req"><see cref="UploadFilesRequest"/></param>
        /// <returns><see cref="UploadFilesResponse"/></returns>
        public async Task<UploadFilesResponse> UploadFiles(UploadFilesRequest req)
        {
             JsonResponseModel<UploadFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（UploadFiles）用于文件上传。
        /// 其中上传的文件，图片类型(png/jpg/jpeg)大小限制为5M，其他大小限制为60M。
        /// 调用时需要设置Domain, 正式环境为 file.ess.tencent.cn。
        /// 代码示例：
        /// HttpProfile httpProfile = new HttpProfile();
        /// httpProfile.setEndpoint("file.test.ess.tencent.cn");
        /// </summary>
        /// <param name="req"><see cref="UploadFilesRequest"/></param>
        /// <returns><see cref="UploadFilesResponse"/></returns>
        public UploadFilesResponse UploadFilesSync(UploadFilesRequest req)
        {
             JsonResponseModel<UploadFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
