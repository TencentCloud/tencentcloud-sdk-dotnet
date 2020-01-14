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

namespace TencentCloud.Live.V20180801
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Live.V20180801.Models;

   public class LiveClient : AbstractClient{

       private const string endpoint = "live.tencentcloudapi.com";
       private const string version = "2018-08-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LiveClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LiveClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 对流设置延播时间
        /// 注意：如果在推流前设置延播，需要提前5分钟设置。
        /// 目前该接口只支持流粒度的，域名及应用粒度功能支持当前开发中。
        /// </summary>
        /// <param name="req"><see cref="AddDelayLiveStreamRequest"/></param>
        /// <returns><see cref="AddDelayLiveStreamResponse"/></returns>
        public async Task<AddDelayLiveStreamResponse> AddDelayLiveStream(AddDelayLiveStreamRequest req)
        {
             JsonResponseModel<AddDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AddDelayLiveStream接口的同步版本，对流设置延播时间
        /// 注意：如果在推流前设置延播，需要提前5分钟设置。
        /// 目前该接口只支持流粒度的，域名及应用粒度功能支持当前开发中。
        /// </summary>
        /// <param name="req">参考<see cref="AddDelayLiveStreamRequest"/></param>
        /// <returns>参考<see cref="AddDelayLiveStreamResponse"/>实例</returns>
        public AddDelayLiveStreamResponse AddDelayLiveStreamSync(AddDelayLiveStreamRequest req)
        {
             JsonResponseModel<AddDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加域名，一次只能提交一个域名。域名必须已备案。
        /// </summary>
        /// <param name="req"><see cref="AddLiveDomainRequest"/></param>
        /// <returns><see cref="AddLiveDomainResponse"/></returns>
        public async Task<AddLiveDomainResponse> AddLiveDomain(AddLiveDomainRequest req)
        {
             JsonResponseModel<AddLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AddLiveDomain接口的同步版本，添加域名，一次只能提交一个域名。域名必须已备案。
        /// </summary>
        /// <param name="req">参考<see cref="AddLiveDomainRequest"/></param>
        /// <returns>参考<see cref="AddLiveDomainResponse"/>实例</returns>
        public AddLiveDomainResponse AddLiveDomainSync(AddLiveDomainRequest req)
        {
             JsonResponseModel<AddLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加水印，成功返回水印id后，需要调用[CreateLiveWatermarkRule](/document/product/267/32629)接口将水印id绑定到流使用。
        /// </summary>
        /// <param name="req"><see cref="AddLiveWatermarkRequest"/></param>
        /// <returns><see cref="AddLiveWatermarkResponse"/></returns>
        public async Task<AddLiveWatermarkResponse> AddLiveWatermark(AddLiveWatermarkRequest req)
        {
             JsonResponseModel<AddLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AddLiveWatermark接口的同步版本，添加水印，成功返回水印id后，需要调用[CreateLiveWatermarkRule](/document/product/267/32629)接口将水印id绑定到流使用。
        /// </summary>
        /// <param name="req">参考<see cref="AddLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="AddLiveWatermarkResponse"/>实例</returns>
        public AddLiveWatermarkResponse AddLiveWatermarkSync(AddLiveWatermarkRequest req)
        {
             JsonResponseModel<AddLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 域名绑定证书。
        /// 注意：需先调用添加证书接口进行证书添加。获取到证书Id后再调用该接口进行绑定。
        /// </summary>
        /// <param name="req"><see cref="BindLiveDomainCertRequest"/></param>
        /// <returns><see cref="BindLiveDomainCertResponse"/></returns>
        public async Task<BindLiveDomainCertResponse> BindLiveDomainCert(BindLiveDomainCertRequest req)
        {
             JsonResponseModel<BindLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BindLiveDomainCert接口的同步版本，域名绑定证书。
        /// 注意：需先调用添加证书接口进行证书添加。获取到证书Id后再调用该接口进行绑定。
        /// </summary>
        /// <param name="req">参考<see cref="BindLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="BindLiveDomainCertResponse"/>实例</returns>
        public BindLiveDomainCertResponse BindLiveDomainCertSync(BindLiveDomainCertRequest req)
        {
             JsonResponseModel<BindLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建回调规则，需要先调用[CreateLiveCallbackTemplate](/document/product/267/32637)接口创建回调模板，将返回的模板id绑定到域名/路径进行使用。
        /// <br>回调协议相关文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackRuleResponse"/></returns>
        public async Task<CreateLiveCallbackRuleResponse> CreateLiveCallbackRule(CreateLiveCallbackRuleRequest req)
        {
             JsonResponseModel<CreateLiveCallbackRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveCallbackRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCallbackRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLiveCallbackRule接口的同步版本，创建回调规则，需要先调用[CreateLiveCallbackTemplate](/document/product/267/32637)接口创建回调模板，将返回的模板id绑定到域名/路径进行使用。
        /// <br>回调协议相关文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveCallbackRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveCallbackRuleResponse"/>实例</returns>
        public CreateLiveCallbackRuleResponse CreateLiveCallbackRuleSync(CreateLiveCallbackRuleRequest req)
        {
             JsonResponseModel<CreateLiveCallbackRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveCallbackRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCallbackRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建回调模板，成功返回模板id后，需要调用[CreateLiveCallbackRule](/document/product/267/32638)接口将模板id绑定到域名/路径使用。
        /// <br>回调协议相关文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackTemplateResponse"/></returns>
        public async Task<CreateLiveCallbackTemplateResponse> CreateLiveCallbackTemplate(CreateLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<CreateLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLiveCallbackTemplate接口的同步版本，创建回调模板，成功返回模板id后，需要调用[CreateLiveCallbackRule](/document/product/267/32638)接口将模板id绑定到域名/路径使用。
        /// <br>回调协议相关文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveCallbackTemplateResponse"/>实例</returns>
        public CreateLiveCallbackTemplateResponse CreateLiveCallbackTemplateSync(CreateLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<CreateLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加证书
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCertRequest"/></param>
        /// <returns><see cref="CreateLiveCertResponse"/></returns>
        public async Task<CreateLiveCertResponse> CreateLiveCert(CreateLiveCertRequest req)
        {
             JsonResponseModel<CreateLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLiveCert接口的同步版本，添加证书
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveCertRequest"/></param>
        /// <returns>参考<see cref="CreateLiveCertResponse"/>实例</returns>
        public CreateLiveCertResponse CreateLiveCertSync(CreateLiveCertRequest req)
        {
             JsonResponseModel<CreateLiveCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// - 使用前提
        ///   1. 录制文件存放于点播平台，所以用户如需使用录制功能，需首先自行开通点播服务。
        ///   2. 录制文件存放后相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，具体请参考 [对应文档](https://cloud.tencent.com/document/product/266/2838)。
        /// 
        /// - 模式说明
        ///   该接口支持两种录制模式：
        ///   1. 定时录制模式【默认模式】。
        ///     需要传入开始时间与结束时间，录制任务根据时间自动开始与结束。
        ///   2. 实时视频录制模式。
        ///     忽略传入的开始时间，在录制任务创建后立即开始录制，录制时长支持最大为30分钟，如果传入的结束时间与当前时间差大于30分钟，则按30分钟计算，实时视频录制主要用于录制精彩视频场景，时长建议控制在5分钟以内。
        /// 
        /// - 注意事项
        ///   1. 调用接口超时设置应大于3秒，小于3秒重试以及频繁调用都有可能产生重复录制任务。
        ///   2. 受限于音视频文件格式（FLV/MP4/HLS）对编码类型的支持，视频编码类型支持 H.264，音频编码类型支持 AAC。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRequest"/></param>
        /// <returns><see cref="CreateLiveRecordResponse"/></returns>
        public async Task<CreateLiveRecordResponse> CreateLiveRecord(CreateLiveRecordRequest req)
        {
             JsonResponseModel<CreateLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLiveRecord接口的同步版本，- 使用前提
        ///   1. 录制文件存放于点播平台，所以用户如需使用录制功能，需首先自行开通点播服务。
        ///   2. 录制文件存放后相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，具体请参考 [对应文档](https://cloud.tencent.com/document/product/266/2838)。
        /// 
        /// - 模式说明
        ///   该接口支持两种录制模式：
        ///   1. 定时录制模式【默认模式】。
        ///     需要传入开始时间与结束时间，录制任务根据时间自动开始与结束。
        ///   2. 实时视频录制模式。
        ///     忽略传入的开始时间，在录制任务创建后立即开始录制，录制时长支持最大为30分钟，如果传入的结束时间与当前时间差大于30分钟，则按30分钟计算，实时视频录制主要用于录制精彩视频场景，时长建议控制在5分钟以内。
        /// 
        /// - 注意事项
        ///   1. 调用接口超时设置应大于3秒，小于3秒重试以及频繁调用都有可能产生重复录制任务。
        ///   2. 受限于音视频文件格式（FLV/MP4/HLS）对编码类型的支持，视频编码类型支持 H.264，音频编码类型支持 AAC。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveRecordRequest"/></param>
        /// <returns>参考<see cref="CreateLiveRecordResponse"/>实例</returns>
        public CreateLiveRecordResponse CreateLiveRecordSync(CreateLiveRecordRequest req)
        {
             JsonResponseModel<CreateLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建录制规则，需要先调用[CreateLiveRecordTemplate](/document/product/267/32614)接口创建录制模板，将返回的模板id绑定到流使用。
        /// <br>录制相关文档：[直播录制](/document/product/267/32739)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRuleRequest"/></param>
        /// <returns><see cref="CreateLiveRecordRuleResponse"/></returns>
        public async Task<CreateLiveRecordRuleResponse> CreateLiveRecordRule(CreateLiveRecordRuleRequest req)
        {
             JsonResponseModel<CreateLiveRecordRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveRecordRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLiveRecordRule接口的同步版本，创建录制规则，需要先调用[CreateLiveRecordTemplate](/document/product/267/32614)接口创建录制模板，将返回的模板id绑定到流使用。
        /// <br>录制相关文档：[直播录制](/document/product/267/32739)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveRecordRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveRecordRuleResponse"/>实例</returns>
        public CreateLiveRecordRuleResponse CreateLiveRecordRuleSync(CreateLiveRecordRuleRequest req)
        {
             JsonResponseModel<CreateLiveRecordRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveRecordRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建录制模板，成功返回模板id后，需要调用[CreateLiveRecordRule](/document/product/267/32615)接口，将模板id绑定到流进行使用。
        /// <br>录制相关文档：[直播录制](/document/product/267/32739)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveRecordTemplateResponse"/></returns>
        public async Task<CreateLiveRecordTemplateResponse> CreateLiveRecordTemplate(CreateLiveRecordTemplateRequest req)
        {
             JsonResponseModel<CreateLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLiveRecordTemplate接口的同步版本，创建录制模板，成功返回模板id后，需要调用[CreateLiveRecordRule](/document/product/267/32615)接口，将模板id绑定到流进行使用。
        /// <br>录制相关文档：[直播录制](/document/product/267/32739)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveRecordTemplateResponse"/>实例</returns>
        public CreateLiveRecordTemplateResponse CreateLiveRecordTemplateSync(CreateLiveRecordTemplateRequest req)
        {
             JsonResponseModel<CreateLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建截图规则，需要先调用[CreateLiveSnapshotTemplate](/document/product/267/32624)接口创建截图模板，然后将返回的模板id绑定到流进行使用。
        /// <br>截图相关文档：[直播截图](/document/product/267/32737)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotRuleResponse"/></returns>
        public async Task<CreateLiveSnapshotRuleResponse> CreateLiveSnapshotRule(CreateLiveSnapshotRuleRequest req)
        {
             JsonResponseModel<CreateLiveSnapshotRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveSnapshotRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveSnapshotRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLiveSnapshotRule接口的同步版本，创建截图规则，需要先调用[CreateLiveSnapshotTemplate](/document/product/267/32624)接口创建截图模板，然后将返回的模板id绑定到流进行使用。
        /// <br>截图相关文档：[直播截图](/document/product/267/32737)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveSnapshotRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveSnapshotRuleResponse"/>实例</returns>
        public CreateLiveSnapshotRuleResponse CreateLiveSnapshotRuleSync(CreateLiveSnapshotRuleRequest req)
        {
             JsonResponseModel<CreateLiveSnapshotRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveSnapshotRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveSnapshotRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建截图模板，成功返回模板id后，需要调用[CreateLiveSnapshotRule](/document/product/267/32625)接口，将模板id绑定到流使用。
        /// <br>截图相关文档：[直播截图](/document/product/267/32737)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotTemplateResponse"/></returns>
        public async Task<CreateLiveSnapshotTemplateResponse> CreateLiveSnapshotTemplate(CreateLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLiveSnapshotTemplate接口的同步版本，创建截图模板，成功返回模板id后，需要调用[CreateLiveSnapshotRule](/document/product/267/32625)接口，将模板id绑定到流使用。
        /// <br>截图相关文档：[直播截图](/document/product/267/32737)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveSnapshotTemplateResponse"/>实例</returns>
        public CreateLiveSnapshotTemplateResponse CreateLiveSnapshotTemplateSync(CreateLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建转码规则，需要先调用[CreateLiveTranscodeTemplate](/document/product/267/32646)接口创建转码模板，将返回的模板id绑定到流使用。
        /// <br>转码相关文档：[直播转封装及转码](/document/product/267/32736)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeRuleResponse"/></returns>
        public async Task<CreateLiveTranscodeRuleResponse> CreateLiveTranscodeRule(CreateLiveTranscodeRuleRequest req)
        {
             JsonResponseModel<CreateLiveTranscodeRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveTranscodeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveTranscodeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLiveTranscodeRule接口的同步版本，创建转码规则，需要先调用[CreateLiveTranscodeTemplate](/document/product/267/32646)接口创建转码模板，将返回的模板id绑定到流使用。
        /// <br>转码相关文档：[直播转封装及转码](/document/product/267/32736)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveTranscodeRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveTranscodeRuleResponse"/>实例</returns>
        public CreateLiveTranscodeRuleResponse CreateLiveTranscodeRuleSync(CreateLiveTranscodeRuleRequest req)
        {
             JsonResponseModel<CreateLiveTranscodeRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveTranscodeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveTranscodeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建转码模板，成功返回模板id后，需要调用[CreateLiveTranscodeRule](/document/product/267/32647)接口，将返回的模板id绑定到流使用。
        /// <br>转码相关文档：[直播转封装及转码](/document/product/267/32736)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeTemplateResponse"/></returns>
        public async Task<CreateLiveTranscodeTemplateResponse> CreateLiveTranscodeTemplate(CreateLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLiveTranscodeTemplate接口的同步版本，创建转码模板，成功返回模板id后，需要调用[CreateLiveTranscodeRule](/document/product/267/32647)接口，将返回的模板id绑定到流使用。
        /// <br>转码相关文档：[直播转封装及转码](/document/product/267/32736)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveTranscodeTemplateResponse"/>实例</returns>
        public CreateLiveTranscodeTemplateResponse CreateLiveTranscodeTemplateSync(CreateLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建水印规则，需要先调用[AddLiveWatermark](/document/product/267/30154)接口添加水印，将返回的水印id绑定到流使用。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="CreateLiveWatermarkRuleResponse"/></returns>
        public async Task<CreateLiveWatermarkRuleResponse> CreateLiveWatermarkRule(CreateLiveWatermarkRuleRequest req)
        {
             JsonResponseModel<CreateLiveWatermarkRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveWatermarkRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveWatermarkRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLiveWatermarkRule接口的同步版本，创建水印规则，需要先调用[AddLiveWatermark](/document/product/267/30154)接口添加水印，将返回的水印id绑定到流使用。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveWatermarkRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveWatermarkRuleResponse"/>实例</returns>
        public CreateLiveWatermarkRuleResponse CreateLiveWatermarkRuleSync(CreateLiveWatermarkRuleRequest req)
        {
             JsonResponseModel<CreateLiveWatermarkRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveWatermarkRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveWatermarkRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建临时拉流转推任务，目前限制添加10条任务。
        /// 
        /// 注意：该接口用于创建临时拉流转推任务，
        /// 拉流源地址即FromUrl 可以是腾讯或非腾讯数据源，
        /// 但转推目标地址即ToUrl 目前限制为已注册的腾讯直播域名。
        /// </summary>
        /// <param name="req"><see cref="CreatePullStreamConfigRequest"/></param>
        /// <returns><see cref="CreatePullStreamConfigResponse"/></returns>
        public async Task<CreatePullStreamConfigResponse> CreatePullStreamConfig(CreatePullStreamConfigRequest req)
        {
             JsonResponseModel<CreatePullStreamConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePullStreamConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePullStreamConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreatePullStreamConfig接口的同步版本，创建临时拉流转推任务，目前限制添加10条任务。
        /// 
        /// 注意：该接口用于创建临时拉流转推任务，
        /// 拉流源地址即FromUrl 可以是腾讯或非腾讯数据源，
        /// 但转推目标地址即ToUrl 目前限制为已注册的腾讯直播域名。
        /// </summary>
        /// <param name="req">参考<see cref="CreatePullStreamConfigRequest"/></param>
        /// <returns>参考<see cref="CreatePullStreamConfigResponse"/>实例</returns>
        public CreatePullStreamConfigResponse CreatePullStreamConfigSync(CreatePullStreamConfigRequest req)
        {
             JsonResponseModel<CreatePullStreamConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePullStreamConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePullStreamConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除回调规则
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackRuleResponse"/></returns>
        public async Task<DeleteLiveCallbackRuleResponse> DeleteLiveCallbackRule(DeleteLiveCallbackRuleRequest req)
        {
             JsonResponseModel<DeleteLiveCallbackRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveCallbackRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCallbackRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveCallbackRule接口的同步版本，删除回调规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveCallbackRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveCallbackRuleResponse"/>实例</returns>
        public DeleteLiveCallbackRuleResponse DeleteLiveCallbackRuleSync(DeleteLiveCallbackRuleRequest req)
        {
             JsonResponseModel<DeleteLiveCallbackRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveCallbackRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCallbackRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除回调模板
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackTemplateResponse"/></returns>
        public async Task<DeleteLiveCallbackTemplateResponse> DeleteLiveCallbackTemplate(DeleteLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveCallbackTemplate接口的同步版本，删除回调模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveCallbackTemplateResponse"/>实例</returns>
        public DeleteLiveCallbackTemplateResponse DeleteLiveCallbackTemplateSync(DeleteLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除域名对应的证书
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCertRequest"/></param>
        /// <returns><see cref="DeleteLiveCertResponse"/></returns>
        public async Task<DeleteLiveCertResponse> DeleteLiveCert(DeleteLiveCertRequest req)
        {
             JsonResponseModel<DeleteLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveCert接口的同步版本，删除域名对应的证书
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveCertRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveCertResponse"/>实例</returns>
        public DeleteLiveCertResponse DeleteLiveCertSync(DeleteLiveCertRequest req)
        {
             JsonResponseModel<DeleteLiveCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除已添加的直播域名
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveDomainRequest"/></param>
        /// <returns><see cref="DeleteLiveDomainResponse"/></returns>
        public async Task<DeleteLiveDomainResponse> DeleteLiveDomain(DeleteLiveDomainRequest req)
        {
             JsonResponseModel<DeleteLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveDomain接口的同步版本，删除已添加的直播域名
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveDomainRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveDomainResponse"/>实例</returns>
        public DeleteLiveDomainResponse DeleteLiveDomainSync(DeleteLiveDomainRequest req)
        {
             JsonResponseModel<DeleteLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注：DeleteLiveRecord 接口仅用于删除录制任务记录，不具备停止录制的功能，也不能删除正在进行中的录制。如果需要停止录制任务，请使用终止录制[StopLiveRecord](/document/product/267/30146) 接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordResponse"/></returns>
        public async Task<DeleteLiveRecordResponse> DeleteLiveRecord(DeleteLiveRecordRequest req)
        {
             JsonResponseModel<DeleteLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveRecord接口的同步版本，注：DeleteLiveRecord 接口仅用于删除录制任务记录，不具备停止录制的功能，也不能删除正在进行中的录制。如果需要停止录制任务，请使用终止录制[StopLiveRecord](/document/product/267/30146) 接口。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveRecordRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveRecordResponse"/>实例</returns>
        public DeleteLiveRecordResponse DeleteLiveRecordSync(DeleteLiveRecordRequest req)
        {
             JsonResponseModel<DeleteLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除录制规则
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordRuleResponse"/></returns>
        public async Task<DeleteLiveRecordRuleResponse> DeleteLiveRecordRule(DeleteLiveRecordRuleRequest req)
        {
             JsonResponseModel<DeleteLiveRecordRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveRecordRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveRecordRule接口的同步版本，删除录制规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveRecordRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveRecordRuleResponse"/>实例</returns>
        public DeleteLiveRecordRuleResponse DeleteLiveRecordRuleSync(DeleteLiveRecordRuleRequest req)
        {
             JsonResponseModel<DeleteLiveRecordRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveRecordRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除录制模板
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordTemplateResponse"/></returns>
        public async Task<DeleteLiveRecordTemplateResponse> DeleteLiveRecordTemplate(DeleteLiveRecordTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveRecordTemplate接口的同步版本，删除录制模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveRecordTemplateResponse"/>实例</returns>
        public DeleteLiveRecordTemplateResponse DeleteLiveRecordTemplateSync(DeleteLiveRecordTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除截图规则
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotRuleResponse"/></returns>
        public async Task<DeleteLiveSnapshotRuleResponse> DeleteLiveSnapshotRule(DeleteLiveSnapshotRuleRequest req)
        {
             JsonResponseModel<DeleteLiveSnapshotRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveSnapshotRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveSnapshotRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveSnapshotRule接口的同步版本，删除截图规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveSnapshotRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveSnapshotRuleResponse"/>实例</returns>
        public DeleteLiveSnapshotRuleResponse DeleteLiveSnapshotRuleSync(DeleteLiveSnapshotRuleRequest req)
        {
             JsonResponseModel<DeleteLiveSnapshotRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveSnapshotRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveSnapshotRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除截图模板
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotTemplateResponse"/></returns>
        public async Task<DeleteLiveSnapshotTemplateResponse> DeleteLiveSnapshotTemplate(DeleteLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveSnapshotTemplate接口的同步版本，删除截图模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveSnapshotTemplateResponse"/>实例</returns>
        public DeleteLiveSnapshotTemplateResponse DeleteLiveSnapshotTemplateSync(DeleteLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除转码规则
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeRuleResponse"/></returns>
        public async Task<DeleteLiveTranscodeRuleResponse> DeleteLiveTranscodeRule(DeleteLiveTranscodeRuleRequest req)
        {
             JsonResponseModel<DeleteLiveTranscodeRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveTranscodeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveTranscodeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveTranscodeRule接口的同步版本，删除转码规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveTranscodeRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveTranscodeRuleResponse"/>实例</returns>
        public DeleteLiveTranscodeRuleResponse DeleteLiveTranscodeRuleSync(DeleteLiveTranscodeRuleRequest req)
        {
             JsonResponseModel<DeleteLiveTranscodeRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveTranscodeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveTranscodeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除转码模板
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeTemplateResponse"/></returns>
        public async Task<DeleteLiveTranscodeTemplateResponse> DeleteLiveTranscodeTemplate(DeleteLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveTranscodeTemplate接口的同步版本，删除转码模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveTranscodeTemplateResponse"/>实例</returns>
        public DeleteLiveTranscodeTemplateResponse DeleteLiveTranscodeTemplateSync(DeleteLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除水印
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkResponse"/></returns>
        public async Task<DeleteLiveWatermarkResponse> DeleteLiveWatermark(DeleteLiveWatermarkRequest req)
        {
             JsonResponseModel<DeleteLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveWatermark接口的同步版本，删除水印
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveWatermarkResponse"/>实例</returns>
        public DeleteLiveWatermarkResponse DeleteLiveWatermarkSync(DeleteLiveWatermarkRequest req)
        {
             JsonResponseModel<DeleteLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除水印规则
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkRuleResponse"/></returns>
        public async Task<DeleteLiveWatermarkRuleResponse> DeleteLiveWatermarkRule(DeleteLiveWatermarkRuleRequest req)
        {
             JsonResponseModel<DeleteLiveWatermarkRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveWatermarkRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveWatermarkRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLiveWatermarkRule接口的同步版本，删除水印规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveWatermarkRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveWatermarkRuleResponse"/>实例</returns>
        public DeleteLiveWatermarkRuleResponse DeleteLiveWatermarkRuleSync(DeleteLiveWatermarkRuleRequest req)
        {
             JsonResponseModel<DeleteLiveWatermarkRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveWatermarkRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveWatermarkRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除直播拉流配置
        /// </summary>
        /// <param name="req"><see cref="DeletePullStreamConfigRequest"/></param>
        /// <returns><see cref="DeletePullStreamConfigResponse"/></returns>
        public async Task<DeletePullStreamConfigResponse> DeletePullStreamConfig(DeletePullStreamConfigRequest req)
        {
             JsonResponseModel<DeletePullStreamConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePullStreamConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePullStreamConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeletePullStreamConfig接口的同步版本，删除直播拉流配置
        /// </summary>
        /// <param name="req">参考<see cref="DeletePullStreamConfigRequest"/></param>
        /// <returns>参考<see cref="DeletePullStreamConfigResponse"/>实例</returns>
        public DeletePullStreamConfigResponse DeletePullStreamConfigSync(DeletePullStreamConfigRequest req)
        {
             JsonResponseModel<DeletePullStreamConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePullStreamConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePullStreamConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播计费带宽和流量数据查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribeBillBandwidthAndFluxListResponse"/></returns>
        public async Task<DescribeBillBandwidthAndFluxListResponse> DescribeBillBandwidthAndFluxList(DescribeBillBandwidthAndFluxListRequest req)
        {
             JsonResponseModel<DescribeBillBandwidthAndFluxListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillBandwidthAndFluxList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillBandwidthAndFluxListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBillBandwidthAndFluxList接口的同步版本，直播计费带宽和流量数据查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBillBandwidthAndFluxListRequest"/></param>
        /// <returns>参考<see cref="DescribeBillBandwidthAndFluxListResponse"/>实例</returns>
        public DescribeBillBandwidthAndFluxListResponse DescribeBillBandwidthAndFluxListSync(DescribeBillBandwidthAndFluxListRequest req)
        {
             JsonResponseModel<DescribeBillBandwidthAndFluxListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillBandwidthAndFluxList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillBandwidthAndFluxListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询按省份和运营商分组的下行播放数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupProIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeGroupProIspPlayInfoListResponse"/></returns>
        public async Task<DescribeGroupProIspPlayInfoListResponse> DescribeGroupProIspPlayInfoList(DescribeGroupProIspPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeGroupProIspPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupProIspPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupProIspPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeGroupProIspPlayInfoList接口的同步版本，查询按省份和运营商分组的下行播放数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeGroupProIspPlayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeGroupProIspPlayInfoListResponse"/>实例</returns>
        public DescribeGroupProIspPlayInfoListResponse DescribeGroupProIspPlayInfoListSync(DescribeGroupProIspPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeGroupProIspPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupProIspPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupProIspPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某段时间内5分钟粒度的各播放http状态码的个数。
        /// 备注：数据延迟1小时，如10:00-10:59点的数据12点才能查到。
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpStatusInfoListRequest"/></param>
        /// <returns><see cref="DescribeHttpStatusInfoListResponse"/></returns>
        public async Task<DescribeHttpStatusInfoListResponse> DescribeHttpStatusInfoList(DescribeHttpStatusInfoListRequest req)
        {
             JsonResponseModel<DescribeHttpStatusInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHttpStatusInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHttpStatusInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeHttpStatusInfoList接口的同步版本，查询某段时间内5分钟粒度的各播放http状态码的个数。
        /// 备注：数据延迟1小时，如10:00-10:59点的数据12点才能查到。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHttpStatusInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeHttpStatusInfoListResponse"/>实例</returns>
        public DescribeHttpStatusInfoListResponse DescribeHttpStatusInfoListSync(DescribeHttpStatusInfoListRequest req)
        {
             JsonResponseModel<DescribeHttpStatusInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHttpStatusInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHttpStatusInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取回调规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackRulesResponse"/></returns>
        public async Task<DescribeLiveCallbackRulesResponse> DescribeLiveCallbackRules(DescribeLiveCallbackRulesRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCallbackRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveCallbackRules接口的同步版本，获取回调规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCallbackRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCallbackRulesResponse"/>实例</returns>
        public DescribeLiveCallbackRulesResponse DescribeLiveCallbackRulesSync(DescribeLiveCallbackRulesRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveCallbackRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个回调模板
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplateResponse"/></returns>
        public async Task<DescribeLiveCallbackTemplateResponse> DescribeLiveCallbackTemplate(DescribeLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveCallbackTemplate接口的同步版本，获取单个回调模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCallbackTemplateResponse"/>实例</returns>
        public DescribeLiveCallbackTemplateResponse DescribeLiveCallbackTemplateSync(DescribeLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取回调模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplatesResponse"/></returns>
        public async Task<DescribeLiveCallbackTemplatesResponse> DescribeLiveCallbackTemplates(DescribeLiveCallbackTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCallbackTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveCallbackTemplates接口的同步版本，获取回调模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCallbackTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCallbackTemplatesResponse"/>实例</returns>
        public DescribeLiveCallbackTemplatesResponse DescribeLiveCallbackTemplatesSync(DescribeLiveCallbackTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveCallbackTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取证书信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertRequest"/></param>
        /// <returns><see cref="DescribeLiveCertResponse"/></returns>
        public async Task<DescribeLiveCertResponse> DescribeLiveCert(DescribeLiveCertRequest req)
        {
             JsonResponseModel<DescribeLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveCert接口的同步版本，获取证书信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCertRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCertResponse"/>实例</returns>
        public DescribeLiveCertResponse DescribeLiveCertSync(DescribeLiveCertRequest req)
        {
             JsonResponseModel<DescribeLiveCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取证书信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertsRequest"/></param>
        /// <returns><see cref="DescribeLiveCertsResponse"/></returns>
        public async Task<DescribeLiveCertsResponse> DescribeLiveCerts(DescribeLiveCertsRequest req)
        {
             JsonResponseModel<DescribeLiveCertsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveCerts接口的同步版本，获取证书信息列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCertsRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCertsResponse"/>实例</returns>
        public DescribeLiveCertsResponse DescribeLiveCertsSync(DescribeLiveCertsRequest req)
        {
             JsonResponseModel<DescribeLiveCertsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取直播延播列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDelayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDelayInfoListResponse"/></returns>
        public async Task<DescribeLiveDelayInfoListResponse> DescribeLiveDelayInfoList(DescribeLiveDelayInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveDelayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveDelayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDelayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveDelayInfoList接口的同步版本，获取直播延播列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveDelayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveDelayInfoListResponse"/>实例</returns>
        public DescribeLiveDelayInfoListResponse DescribeLiveDelayInfoListSync(DescribeLiveDelayInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveDelayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveDelayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDelayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询直播域名信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainResponse"/></returns>
        public async Task<DescribeLiveDomainResponse> DescribeLiveDomain(DescribeLiveDomainRequest req)
        {
             JsonResponseModel<DescribeLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveDomain接口的同步版本，查询直播域名信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveDomainRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveDomainResponse"/>实例</returns>
        public DescribeLiveDomainResponse DescribeLiveDomainSync(DescribeLiveDomainRequest req)
        {
             JsonResponseModel<DescribeLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名证书信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainCertRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainCertResponse"/></returns>
        public async Task<DescribeLiveDomainCertResponse> DescribeLiveDomainCert(DescribeLiveDomainCertRequest req)
        {
             JsonResponseModel<DescribeLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveDomainCert接口的同步版本，获取域名证书信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveDomainCertResponse"/>实例</returns>
        public DescribeLiveDomainCertResponse DescribeLiveDomainCertSync(DescribeLiveDomainCertRequest req)
        {
             JsonResponseModel<DescribeLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实时的域名维度下行播放数据，由于数据处理有耗时，接口默认查询4分钟前的准实时数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainPlayInfoListResponse"/></returns>
        public async Task<DescribeLiveDomainPlayInfoListResponse> DescribeLiveDomainPlayInfoList(DescribeLiveDomainPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveDomainPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveDomainPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveDomainPlayInfoList接口的同步版本，查询实时的域名维度下行播放数据，由于数据处理有耗时，接口默认查询4分钟前的准实时数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveDomainPlayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveDomainPlayInfoListResponse"/>实例</returns>
        public DescribeLiveDomainPlayInfoListResponse DescribeLiveDomainPlayInfoListSync(DescribeLiveDomainPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveDomainPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveDomainPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据域名状态、类型等信息查询用户的域名信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainsRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainsResponse"/></returns>
        public async Task<DescribeLiveDomainsResponse> DescribeLiveDomains(DescribeLiveDomainsRequest req)
        {
             JsonResponseModel<DescribeLiveDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveDomains接口的同步版本，根据域名状态、类型等信息查询用户的域名信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveDomainsRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveDomainsResponse"/>实例</returns>
        public DescribeLiveDomainsResponse DescribeLiveDomainsSync(DescribeLiveDomainsRequest req)
        {
             JsonResponseModel<DescribeLiveDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取禁推流列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveForbidStreamListRequest"/></param>
        /// <returns><see cref="DescribeLiveForbidStreamListResponse"/></returns>
        public async Task<DescribeLiveForbidStreamListResponse> DescribeLiveForbidStreamList(DescribeLiveForbidStreamListRequest req)
        {
             JsonResponseModel<DescribeLiveForbidStreamListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveForbidStreamList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveForbidStreamListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveForbidStreamList接口的同步版本，获取禁推流列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveForbidStreamListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveForbidStreamListResponse"/>实例</returns>
        public DescribeLiveForbidStreamListResponse DescribeLiveForbidStreamListSync(DescribeLiveForbidStreamListRequest req)
        {
             JsonResponseModel<DescribeLiveForbidStreamListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveForbidStreamList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveForbidStreamListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询播放鉴权key。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePlayAuthKeyResponse"/></returns>
        public async Task<DescribeLivePlayAuthKeyResponse> DescribeLivePlayAuthKey(DescribeLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLivePlayAuthKey接口的同步版本，查询播放鉴权key。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLivePlayAuthKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeLivePlayAuthKeyResponse"/>实例</returns>
        public DescribeLivePlayAuthKeyResponse DescribeLivePlayAuthKeySync(DescribeLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询直播推流鉴权key
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePushAuthKeyResponse"/></returns>
        public async Task<DescribeLivePushAuthKeyResponse> DescribeLivePushAuthKey(DescribeLivePushAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLivePushAuthKey接口的同步版本，查询直播推流鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLivePushAuthKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeLivePushAuthKeyResponse"/>实例</returns>
        public DescribeLivePushAuthKeyResponse DescribeLivePushAuthKeySync(DescribeLivePushAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取录制规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordRulesResponse"/></returns>
        public async Task<DescribeLiveRecordRulesResponse> DescribeLiveRecordRules(DescribeLiveRecordRulesRequest req)
        {
             JsonResponseModel<DescribeLiveRecordRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveRecordRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveRecordRules接口的同步版本，获取录制规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveRecordRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveRecordRulesResponse"/>实例</returns>
        public DescribeLiveRecordRulesResponse DescribeLiveRecordRulesSync(DescribeLiveRecordRulesRequest req)
        {
             JsonResponseModel<DescribeLiveRecordRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveRecordRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个录制模板
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplateResponse"/></returns>
        public async Task<DescribeLiveRecordTemplateResponse> DescribeLiveRecordTemplate(DescribeLiveRecordTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveRecordTemplate接口的同步版本，获取单个录制模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveRecordTemplateResponse"/>实例</returns>
        public DescribeLiveRecordTemplateResponse DescribeLiveRecordTemplateSync(DescribeLiveRecordTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取录制模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplatesResponse"/></returns>
        public async Task<DescribeLiveRecordTemplatesResponse> DescribeLiveRecordTemplates(DescribeLiveRecordTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveRecordTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveRecordTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveRecordTemplates接口的同步版本，获取录制模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveRecordTemplatesResponse"/>实例</returns>
        public DescribeLiveRecordTemplatesResponse DescribeLiveRecordTemplatesSync(DescribeLiveRecordTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveRecordTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveRecordTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取截图规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotRulesResponse"/></returns>
        public async Task<DescribeLiveSnapshotRulesResponse> DescribeLiveSnapshotRules(DescribeLiveSnapshotRulesRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveSnapshotRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveSnapshotRules接口的同步版本，获取截图规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveSnapshotRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveSnapshotRulesResponse"/>实例</returns>
        public DescribeLiveSnapshotRulesResponse DescribeLiveSnapshotRulesSync(DescribeLiveSnapshotRulesRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveSnapshotRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个截图模板
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplateResponse"/></returns>
        public async Task<DescribeLiveSnapshotTemplateResponse> DescribeLiveSnapshotTemplate(DescribeLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveSnapshotTemplate接口的同步版本，获取单个截图模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveSnapshotTemplateResponse"/>实例</returns>
        public DescribeLiveSnapshotTemplateResponse DescribeLiveSnapshotTemplateSync(DescribeLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取截图模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplatesResponse"/></returns>
        public async Task<DescribeLiveSnapshotTemplatesResponse> DescribeLiveSnapshotTemplates(DescribeLiveSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveSnapshotTemplates接口的同步版本，获取截图模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveSnapshotTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveSnapshotTemplatesResponse"/>实例</returns>
        public DescribeLiveSnapshotTemplatesResponse DescribeLiveSnapshotTemplatesSync(DescribeLiveSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询推断流事件。<br>
        /// 
        /// 注意：该接口可通过使用IsFilter进行过滤，返回推流历史记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamEventListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamEventListResponse"/></returns>
        public async Task<DescribeLiveStreamEventListResponse> DescribeLiveStreamEventList(DescribeLiveStreamEventListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveStreamEventList接口的同步版本，用于查询推断流事件。<br>
        /// 
        /// 注意：该接口可通过使用IsFilter进行过滤，返回推流历史记录。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamEventListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamEventListResponse"/>实例</returns>
        public DescribeLiveStreamEventListResponse DescribeLiveStreamEventListSync(DescribeLiveStreamEventListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveStreamEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回正在直播中的流列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamOnlineListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamOnlineListResponse"/></returns>
        public async Task<DescribeLiveStreamOnlineListResponse> DescribeLiveStreamOnlineList(DescribeLiveStreamOnlineListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamOnlineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamOnlineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamOnlineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveStreamOnlineList接口的同步版本，返回正在直播中的流列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamOnlineListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamOnlineListResponse"/>实例</returns>
        public DescribeLiveStreamOnlineListResponse DescribeLiveStreamOnlineListSync(DescribeLiveStreamOnlineListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamOnlineListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveStreamOnlineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamOnlineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回已经推过流的流列表。<br>
        /// 注意：分页最多支持查询1万条记录，可通过调整查询时间范围来获取更多数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPublishedListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPublishedListResponse"/></returns>
        public async Task<DescribeLiveStreamPublishedListResponse> DescribeLiveStreamPublishedList(DescribeLiveStreamPublishedListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamPublishedListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamPublishedList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamPublishedListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveStreamPublishedList接口的同步版本，返回已经推过流的流列表。<br>
        /// 注意：分页最多支持查询1万条记录，可通过调整查询时间范围来获取更多数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamPublishedListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamPublishedListResponse"/>实例</returns>
        public DescribeLiveStreamPublishedListResponse DescribeLiveStreamPublishedListSync(DescribeLiveStreamPublishedListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamPublishedListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveStreamPublishedList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamPublishedListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询所有实时流的推流信息，包括客户端IP，服务端IP，帧率，码率，域名，开始推流时间。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPushInfoListResponse"/></returns>
        public async Task<DescribeLiveStreamPushInfoListResponse> DescribeLiveStreamPushInfoList(DescribeLiveStreamPushInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamPushInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamPushInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamPushInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveStreamPushInfoList接口的同步版本，查询所有实时流的推流信息，包括客户端IP，服务端IP，帧率，码率，域名，开始推流时间。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamPushInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamPushInfoListResponse"/>实例</returns>
        public DescribeLiveStreamPushInfoListResponse DescribeLiveStreamPushInfoListSync(DescribeLiveStreamPushInfoListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamPushInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveStreamPushInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamPushInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回直播中、无推流或者禁播等状态
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamStateRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamStateResponse"/></returns>
        public async Task<DescribeLiveStreamStateResponse> DescribeLiveStreamState(DescribeLiveStreamStateRequest req)
        {
             JsonResponseModel<DescribeLiveStreamStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveStreamState接口的同步版本，返回直播中、无推流或者禁播等状态
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamStateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamStateResponse"/>实例</returns>
        public DescribeLiveStreamStateResponse DescribeLiveStreamStateSync(DescribeLiveStreamStateRequest req)
        {
             JsonResponseModel<DescribeLiveStreamStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveStreamState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持查询某天或某段时间的转码详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeDetailInfoResponse"/></returns>
        public async Task<DescribeLiveTranscodeDetailInfoResponse> DescribeLiveTranscodeDetailInfo(DescribeLiveTranscodeDetailInfoRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveTranscodeDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveTranscodeDetailInfo接口的同步版本，支持查询某天或某段时间的转码详细信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveTranscodeDetailInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveTranscodeDetailInfoResponse"/>实例</returns>
        public DescribeLiveTranscodeDetailInfoResponse DescribeLiveTranscodeDetailInfoSync(DescribeLiveTranscodeDetailInfoRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveTranscodeDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取转码规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeRulesResponse"/></returns>
        public async Task<DescribeLiveTranscodeRulesResponse> DescribeLiveTranscodeRules(DescribeLiveTranscodeRulesRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveTranscodeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveTranscodeRules接口的同步版本，获取转码规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveTranscodeRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveTranscodeRulesResponse"/>实例</returns>
        public DescribeLiveTranscodeRulesResponse DescribeLiveTranscodeRulesSync(DescribeLiveTranscodeRulesRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveTranscodeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个转码模板
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplateResponse"/></returns>
        public async Task<DescribeLiveTranscodeTemplateResponse> DescribeLiveTranscodeTemplate(DescribeLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveTranscodeTemplate接口的同步版本，获取单个转码模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveTranscodeTemplateResponse"/>实例</returns>
        public DescribeLiveTranscodeTemplateResponse DescribeLiveTranscodeTemplateSync(DescribeLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取转码模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplatesResponse"/></returns>
        public async Task<DescribeLiveTranscodeTemplatesResponse> DescribeLiveTranscodeTemplates(DescribeLiveTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveTranscodeTemplates接口的同步版本，获取转码模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveTranscodeTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveTranscodeTemplatesResponse"/>实例</returns>
        public DescribeLiveTranscodeTemplatesResponse DescribeLiveTranscodeTemplatesSync(DescribeLiveTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个水印信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkResponse"/></returns>
        public async Task<DescribeLiveWatermarkResponse> DescribeLiveWatermark(DescribeLiveWatermarkRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveWatermark接口的同步版本，获取单个水印信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveWatermarkResponse"/>实例</returns>
        public DescribeLiveWatermarkResponse DescribeLiveWatermarkSync(DescribeLiveWatermarkRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取水印规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkRulesResponse"/></returns>
        public async Task<DescribeLiveWatermarkRulesResponse> DescribeLiveWatermarkRules(DescribeLiveWatermarkRulesRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarkRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveWatermarkRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarkRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveWatermarkRules接口的同步版本，获取水印规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveWatermarkRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveWatermarkRulesResponse"/>实例</returns>
        public DescribeLiveWatermarkRulesResponse DescribeLiveWatermarkRulesSync(DescribeLiveWatermarkRulesRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarkRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveWatermarkRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarkRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询水印列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarksRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarksResponse"/></returns>
        public async Task<DescribeLiveWatermarksResponse> DescribeLiveWatermarks(DescribeLiveWatermarksRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveWatermarks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLiveWatermarks接口的同步版本，查询水印列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveWatermarksRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveWatermarksResponse"/>实例</returns>
        public DescribeLiveWatermarksResponse DescribeLiveWatermarksSync(DescribeLiveWatermarksRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveWatermarks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量获取日志URL。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogDownloadListRequest"/></param>
        /// <returns><see cref="DescribeLogDownloadListResponse"/></returns>
        public async Task<DescribeLogDownloadListResponse> DescribeLogDownloadList(DescribeLogDownloadListRequest req)
        {
             JsonResponseModel<DescribeLogDownloadListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogDownloadList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogDownloadListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLogDownloadList接口的同步版本，批量获取日志URL。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLogDownloadListRequest"/></param>
        /// <returns>参考<see cref="DescribeLogDownloadListResponse"/>实例</returns>
        public DescribeLogDownloadListResponse DescribeLogDownloadListSync(DescribeLogDownloadListRequest req)
        {
             JsonResponseModel<DescribeLogDownloadListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogDownloadList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogDownloadListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询下行播放错误码信息，某段时间内1分钟粒度的各http错误码出现的次数，包括4xx，5xx。
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeDetailInfoListResponse"/></returns>
        public async Task<DescribePlayErrorCodeDetailInfoListResponse> DescribePlayErrorCodeDetailInfoList(DescribePlayErrorCodeDetailInfoListRequest req)
        {
             JsonResponseModel<DescribePlayErrorCodeDetailInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePlayErrorCodeDetailInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayErrorCodeDetailInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePlayErrorCodeDetailInfoList接口的同步版本，查询下行播放错误码信息，某段时间内1分钟粒度的各http错误码出现的次数，包括4xx，5xx。
        /// 
        /// </summary>
        /// <param name="req">参考<see cref="DescribePlayErrorCodeDetailInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribePlayErrorCodeDetailInfoListResponse"/>实例</returns>
        public DescribePlayErrorCodeDetailInfoListResponse DescribePlayErrorCodeDetailInfoListSync(DescribePlayErrorCodeDetailInfoListRequest req)
        {
             JsonResponseModel<DescribePlayErrorCodeDetailInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePlayErrorCodeDetailInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayErrorCodeDetailInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询下行播放错误码信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeSumInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeSumInfoListResponse"/></returns>
        public async Task<DescribePlayErrorCodeSumInfoListResponse> DescribePlayErrorCodeSumInfoList(DescribePlayErrorCodeSumInfoListRequest req)
        {
             JsonResponseModel<DescribePlayErrorCodeSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePlayErrorCodeSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayErrorCodeSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePlayErrorCodeSumInfoList接口的同步版本，查询下行播放错误码信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePlayErrorCodeSumInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribePlayErrorCodeSumInfoListResponse"/>实例</returns>
        public DescribePlayErrorCodeSumInfoListResponse DescribePlayErrorCodeSumInfoListSync(DescribePlayErrorCodeSumInfoListRequest req)
        {
             JsonResponseModel<DescribePlayErrorCodeSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePlayErrorCodeSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayErrorCodeSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某段时间内每个国家地区每个省份每个运营商的平均每秒流量，总流量，总请求数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProIspPlaySumInfoListRequest"/></param>
        /// <returns><see cref="DescribeProIspPlaySumInfoListResponse"/></returns>
        public async Task<DescribeProIspPlaySumInfoListResponse> DescribeProIspPlaySumInfoList(DescribeProIspPlaySumInfoListRequest req)
        {
             JsonResponseModel<DescribeProIspPlaySumInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProIspPlaySumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProIspPlaySumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeProIspPlaySumInfoList接口的同步版本，查询某段时间内每个国家地区每个省份每个运营商的平均每秒流量，总流量，总请求数信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProIspPlaySumInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeProIspPlaySumInfoListResponse"/>实例</returns>
        public DescribeProIspPlaySumInfoListResponse DescribeProIspPlaySumInfoListSync(DescribeProIspPlaySumInfoListRequest req)
        {
             JsonResponseModel<DescribeProIspPlaySumInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProIspPlaySumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProIspPlaySumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某省份某运营商下行播放数据，包括带宽，流量，请求数，并发连接数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProvinceIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeProvinceIspPlayInfoListResponse"/></returns>
        public async Task<DescribeProvinceIspPlayInfoListResponse> DescribeProvinceIspPlayInfoList(DescribeProvinceIspPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeProvinceIspPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProvinceIspPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProvinceIspPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeProvinceIspPlayInfoList接口的同步版本，查询某省份某运营商下行播放数据，包括带宽，流量，请求数，并发连接数信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProvinceIspPlayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeProvinceIspPlayInfoListResponse"/>实例</returns>
        public DescribeProvinceIspPlayInfoListResponse DescribeProvinceIspPlayInfoListSync(DescribeProvinceIspPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeProvinceIspPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProvinceIspPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProvinceIspPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询直播拉流配置。
        /// </summary>
        /// <param name="req"><see cref="DescribePullStreamConfigsRequest"/></param>
        /// <returns><see cref="DescribePullStreamConfigsResponse"/></returns>
        public async Task<DescribePullStreamConfigsResponse> DescribePullStreamConfigs(DescribePullStreamConfigsRequest req)
        {
             JsonResponseModel<DescribePullStreamConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePullStreamConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePullStreamConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePullStreamConfigs接口的同步版本，查询直播拉流配置。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePullStreamConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribePullStreamConfigsResponse"/>实例</returns>
        public DescribePullStreamConfigsResponse DescribePullStreamConfigsSync(DescribePullStreamConfigsRequest req)
        {
             JsonResponseModel<DescribePullStreamConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePullStreamConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePullStreamConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询天维度每条流的播放数据，包括总流量等。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamDayPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamDayPlayInfoListResponse"/></returns>
        public async Task<DescribeStreamDayPlayInfoListResponse> DescribeStreamDayPlayInfoList(DescribeStreamDayPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamDayPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamDayPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamDayPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeStreamDayPlayInfoList接口的同步版本，查询天维度每条流的播放数据，包括总流量等。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeStreamDayPlayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeStreamDayPlayInfoListResponse"/>实例</returns>
        public DescribeStreamDayPlayInfoListResponse DescribeStreamDayPlayInfoListSync(DescribeStreamDayPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamDayPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamDayPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamDayPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询播放数据，支持按流名称查询详细播放数据，也可按播放域名查询详细总数据。
        /// 注意：按AppName查询，需要联系客服同学提单支持。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPlayInfoListResponse"/></returns>
        public async Task<DescribeStreamPlayInfoListResponse> DescribeStreamPlayInfoList(DescribeStreamPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeStreamPlayInfoList接口的同步版本，查询播放数据，支持按流名称查询详细播放数据，也可按播放域名查询详细总数据。
        /// 注意：按AppName查询，需要联系客服同学提单支持。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeStreamPlayInfoListResponse"/>实例</returns>
        public DescribeStreamPlayInfoListResponse DescribeStreamPlayInfoListSync(DescribeStreamPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流id的上行推流质量数据，包括音视频的帧率，码率，流逝时间，编码格式等。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPushInfoListResponse"/></returns>
        public async Task<DescribeStreamPushInfoListResponse> DescribeStreamPushInfoList(DescribeStreamPushInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamPushInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamPushInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPushInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeStreamPushInfoList接口的同步版本，查询流id的上行推流质量数据，包括音视频的帧率，码率，流逝时间，编码格式等。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeStreamPushInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeStreamPushInfoListResponse"/>实例</returns>
        public DescribeStreamPushInfoListResponse DescribeStreamPushInfoListSync(DescribeStreamPushInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamPushInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamPushInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPushInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某段时间top n客户端ip汇总信息（暂支持top 1000）
        /// </summary>
        /// <param name="req"><see cref="DescribeTopClientIpSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeTopClientIpSumInfoListResponse"/></returns>
        public async Task<DescribeTopClientIpSumInfoListResponse> DescribeTopClientIpSumInfoList(DescribeTopClientIpSumInfoListRequest req)
        {
             JsonResponseModel<DescribeTopClientIpSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopClientIpSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopClientIpSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTopClientIpSumInfoList接口的同步版本，查询某段时间top n客户端ip汇总信息（暂支持top 1000）
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTopClientIpSumInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeTopClientIpSumInfoListResponse"/>实例</returns>
        public DescribeTopClientIpSumInfoListResponse DescribeTopClientIpSumInfoListSync(DescribeTopClientIpSumInfoListRequest req)
        {
             JsonResponseModel<DescribeTopClientIpSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopClientIpSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopClientIpSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某时间段top n的域名或流id信息（暂支持top 1000）。
        /// </summary>
        /// <param name="req"><see cref="DescribeVisitTopSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeVisitTopSumInfoListResponse"/></returns>
        public async Task<DescribeVisitTopSumInfoListResponse> DescribeVisitTopSumInfoList(DescribeVisitTopSumInfoListRequest req)
        {
             JsonResponseModel<DescribeVisitTopSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVisitTopSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVisitTopSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeVisitTopSumInfoList接口的同步版本，查询某时间段top n的域名或流id信息（暂支持top 1000）。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVisitTopSumInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeVisitTopSumInfoListResponse"/>实例</returns>
        public DescribeVisitTopSumInfoListResponse DescribeVisitTopSumInfoListSync(DescribeVisitTopSumInfoListRequest req)
        {
             JsonResponseModel<DescribeVisitTopSumInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVisitTopSumInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVisitTopSumInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 断开推流连接，但可以重新推流
        /// </summary>
        /// <param name="req"><see cref="DropLiveStreamRequest"/></param>
        /// <returns><see cref="DropLiveStreamResponse"/></returns>
        public async Task<DropLiveStreamResponse> DropLiveStream(DropLiveStreamRequest req)
        {
             JsonResponseModel<DropLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DropLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DropLiveStream接口的同步版本，断开推流连接，但可以重新推流
        /// </summary>
        /// <param name="req">参考<see cref="DropLiveStreamRequest"/></param>
        /// <returns>参考<see cref="DropLiveStreamResponse"/>实例</returns>
        public DropLiveStreamResponse DropLiveStreamSync(DropLiveStreamRequest req)
        {
             JsonResponseModel<DropLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DropLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用状态为停用的直播域名
        /// </summary>
        /// <param name="req"><see cref="EnableLiveDomainRequest"/></param>
        /// <returns><see cref="EnableLiveDomainResponse"/></returns>
        public async Task<EnableLiveDomainResponse> EnableLiveDomain(EnableLiveDomainRequest req)
        {
             JsonResponseModel<EnableLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableLiveDomain接口的同步版本，启用状态为停用的直播域名
        /// </summary>
        /// <param name="req">参考<see cref="EnableLiveDomainRequest"/></param>
        /// <returns>参考<see cref="EnableLiveDomainResponse"/>实例</returns>
        public EnableLiveDomainResponse EnableLiveDomainSync(EnableLiveDomainRequest req)
        {
             JsonResponseModel<EnableLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止使用某个直播域名。
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveDomainRequest"/></param>
        /// <returns><see cref="ForbidLiveDomainResponse"/></returns>
        public async Task<ForbidLiveDomainResponse> ForbidLiveDomain(ForbidLiveDomainRequest req)
        {
             JsonResponseModel<ForbidLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForbidLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ForbidLiveDomain接口的同步版本，停止使用某个直播域名。
        /// </summary>
        /// <param name="req">参考<see cref="ForbidLiveDomainRequest"/></param>
        /// <returns>参考<see cref="ForbidLiveDomainResponse"/>实例</returns>
        public ForbidLiveDomainResponse ForbidLiveDomainSync(ForbidLiveDomainRequest req)
        {
             JsonResponseModel<ForbidLiveDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ForbidLiveDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁止某条流的推送，可以预设某个时刻将流恢复。
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveStreamRequest"/></param>
        /// <returns><see cref="ForbidLiveStreamResponse"/></returns>
        public async Task<ForbidLiveStreamResponse> ForbidLiveStream(ForbidLiveStreamRequest req)
        {
             JsonResponseModel<ForbidLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForbidLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ForbidLiveStream接口的同步版本，禁止某条流的推送，可以预设某个时刻将流恢复。
        /// </summary>
        /// <param name="req">参考<see cref="ForbidLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ForbidLiveStreamResponse"/>实例</returns>
        public ForbidLiveStreamResponse ForbidLiveStreamSync(ForbidLiveStreamRequest req)
        {
             JsonResponseModel<ForbidLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ForbidLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改回调模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveCallbackTemplateResponse"/></returns>
        public async Task<ModifyLiveCallbackTemplateResponse> ModifyLiveCallbackTemplate(ModifyLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLiveCallbackTemplate接口的同步版本，修改回调模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveCallbackTemplateResponse"/>实例</returns>
        public ModifyLiveCallbackTemplateResponse ModifyLiveCallbackTemplateSync(ModifyLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改证书
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveCertRequest"/></param>
        /// <returns><see cref="ModifyLiveCertResponse"/></returns>
        public async Task<ModifyLiveCertResponse> ModifyLiveCert(ModifyLiveCertRequest req)
        {
             JsonResponseModel<ModifyLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLiveCert接口的同步版本，修改证书
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveCertRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveCertResponse"/>实例</returns>
        public ModifyLiveCertResponse ModifyLiveCertSync(ModifyLiveCertRequest req)
        {
             JsonResponseModel<ModifyLiveCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改域名和证书绑定信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveDomainCertRequest"/></param>
        /// <returns><see cref="ModifyLiveDomainCertResponse"/></returns>
        public async Task<ModifyLiveDomainCertResponse> ModifyLiveDomainCert(ModifyLiveDomainCertRequest req)
        {
             JsonResponseModel<ModifyLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLiveDomainCert接口的同步版本，修改域名和证书绑定信息
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveDomainCertResponse"/>实例</returns>
        public ModifyLiveDomainCertResponse ModifyLiveDomainCertSync(ModifyLiveDomainCertRequest req)
        {
             JsonResponseModel<ModifyLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改播放鉴权key
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePlayAuthKeyResponse"/></returns>
        public async Task<ModifyLivePlayAuthKeyResponse> ModifyLivePlayAuthKey(ModifyLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLivePlayAuthKey接口的同步版本，修改播放鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLivePlayAuthKeyRequest"/></param>
        /// <returns>参考<see cref="ModifyLivePlayAuthKeyResponse"/>实例</returns>
        public ModifyLivePlayAuthKeyResponse ModifyLivePlayAuthKeySync(ModifyLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改播放域名信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayDomainRequest"/></param>
        /// <returns><see cref="ModifyLivePlayDomainResponse"/></returns>
        public async Task<ModifyLivePlayDomainResponse> ModifyLivePlayDomain(ModifyLivePlayDomainRequest req)
        {
             JsonResponseModel<ModifyLivePlayDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLivePlayDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePlayDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLivePlayDomain接口的同步版本，修改播放域名信息
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLivePlayDomainRequest"/></param>
        /// <returns>参考<see cref="ModifyLivePlayDomainResponse"/>实例</returns>
        public ModifyLivePlayDomainResponse ModifyLivePlayDomainSync(ModifyLivePlayDomainRequest req)
        {
             JsonResponseModel<ModifyLivePlayDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLivePlayDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePlayDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改直播推流鉴权key
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePushAuthKeyResponse"/></returns>
        public async Task<ModifyLivePushAuthKeyResponse> ModifyLivePushAuthKey(ModifyLivePushAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLivePushAuthKey接口的同步版本，修改直播推流鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLivePushAuthKeyRequest"/></param>
        /// <returns>参考<see cref="ModifyLivePushAuthKeyResponse"/>实例</returns>
        public ModifyLivePushAuthKeyResponse ModifyLivePushAuthKeySync(ModifyLivePushAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改录制模板配置
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordTemplateResponse"/></returns>
        public async Task<ModifyLiveRecordTemplateResponse> ModifyLiveRecordTemplate(ModifyLiveRecordTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLiveRecordTemplate接口的同步版本，修改录制模板配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveRecordTemplateResponse"/>实例</returns>
        public ModifyLiveRecordTemplateResponse ModifyLiveRecordTemplateSync(ModifyLiveRecordTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改截图模板配置
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveSnapshotTemplateResponse"/></returns>
        public async Task<ModifyLiveSnapshotTemplateResponse> ModifyLiveSnapshotTemplate(ModifyLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLiveSnapshotTemplate接口的同步版本，修改截图模板配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveSnapshotTemplateResponse"/>实例</returns>
        public ModifyLiveSnapshotTemplateResponse ModifyLiveSnapshotTemplateSync(ModifyLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改转码模板配置
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveTranscodeTemplateResponse"/></returns>
        public async Task<ModifyLiveTranscodeTemplateResponse> ModifyLiveTranscodeTemplate(ModifyLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLiveTranscodeTemplate接口的同步版本，修改转码模板配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveTranscodeTemplateResponse"/>实例</returns>
        public ModifyLiveTranscodeTemplateResponse ModifyLiveTranscodeTemplateSync(ModifyLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新拉流配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyPullStreamConfigRequest"/></param>
        /// <returns><see cref="ModifyPullStreamConfigResponse"/></returns>
        public async Task<ModifyPullStreamConfigResponse> ModifyPullStreamConfig(ModifyPullStreamConfigRequest req)
        {
             JsonResponseModel<ModifyPullStreamConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPullStreamConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPullStreamConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyPullStreamConfig接口的同步版本，更新拉流配置。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPullStreamConfigRequest"/></param>
        /// <returns>参考<see cref="ModifyPullStreamConfigResponse"/>实例</returns>
        public ModifyPullStreamConfigResponse ModifyPullStreamConfigSync(ModifyPullStreamConfigRequest req)
        {
             JsonResponseModel<ModifyPullStreamConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPullStreamConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPullStreamConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改直播拉流配置的状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyPullStreamStatusRequest"/></param>
        /// <returns><see cref="ModifyPullStreamStatusResponse"/></returns>
        public async Task<ModifyPullStreamStatusResponse> ModifyPullStreamStatus(ModifyPullStreamStatusRequest req)
        {
             JsonResponseModel<ModifyPullStreamStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPullStreamStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPullStreamStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyPullStreamStatus接口的同步版本，修改直播拉流配置的状态。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPullStreamStatusRequest"/></param>
        /// <returns>参考<see cref="ModifyPullStreamStatusResponse"/>实例</returns>
        public ModifyPullStreamStatusResponse ModifyPullStreamStatusSync(ModifyPullStreamStatusRequest req)
        {
             JsonResponseModel<ModifyPullStreamStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPullStreamStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPullStreamStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复延迟播放设置
        /// </summary>
        /// <param name="req"><see cref="ResumeDelayLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeDelayLiveStreamResponse"/></returns>
        public async Task<ResumeDelayLiveStreamResponse> ResumeDelayLiveStream(ResumeDelayLiveStreamRequest req)
        {
             JsonResponseModel<ResumeDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResumeDelayLiveStream接口的同步版本，恢复延迟播放设置
        /// </summary>
        /// <param name="req">参考<see cref="ResumeDelayLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ResumeDelayLiveStreamResponse"/>实例</returns>
        public ResumeDelayLiveStreamResponse ResumeDelayLiveStreamSync(ResumeDelayLiveStreamRequest req)
        {
             JsonResponseModel<ResumeDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复某条流的推流。
        /// </summary>
        /// <param name="req"><see cref="ResumeLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeLiveStreamResponse"/></returns>
        public async Task<ResumeLiveStreamResponse> ResumeLiveStream(ResumeLiveStreamRequest req)
        {
             JsonResponseModel<ResumeLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResumeLiveStream接口的同步版本，恢复某条流的推流。
        /// </summary>
        /// <param name="req">参考<see cref="ResumeLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ResumeLiveStreamResponse"/>实例</returns>
        public ResumeLiveStreamResponse ResumeLiveStreamSync(ResumeLiveStreamRequest req)
        {
             JsonResponseModel<ResumeLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 说明：录制后的文件存放于点播平台。用户如需使用录制功能，需首先自行开通点播账号并确保账号可用。录制文件存放后，相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，请参考对应文档。
        /// </summary>
        /// <param name="req"><see cref="StopLiveRecordRequest"/></param>
        /// <returns><see cref="StopLiveRecordResponse"/></returns>
        public async Task<StopLiveRecordResponse> StopLiveRecord(StopLiveRecordRequest req)
        {
             JsonResponseModel<StopLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StopLiveRecord接口的同步版本，说明：录制后的文件存放于点播平台。用户如需使用录制功能，需首先自行开通点播账号并确保账号可用。录制文件存放后，相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，请参考对应文档。
        /// </summary>
        /// <param name="req">参考<see cref="StopLiveRecordRequest"/></param>
        /// <returns>参考<see cref="StopLiveRecordResponse"/>实例</returns>
        public StopLiveRecordResponse StopLiveRecordSync(StopLiveRecordRequest req)
        {
             JsonResponseModel<StopLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑域名证书
        /// </summary>
        /// <param name="req"><see cref="UnBindLiveDomainCertRequest"/></param>
        /// <returns><see cref="UnBindLiveDomainCertResponse"/></returns>
        public async Task<UnBindLiveDomainCertResponse> UnBindLiveDomainCert(UnBindLiveDomainCertRequest req)
        {
             JsonResponseModel<UnBindLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UnBindLiveDomainCert接口的同步版本，解绑域名证书
        /// </summary>
        /// <param name="req">参考<see cref="UnBindLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="UnBindLiveDomainCertResponse"/>实例</returns>
        public UnBindLiveDomainCertResponse UnBindLiveDomainCertSync(UnBindLiveDomainCertRequest req)
        {
             JsonResponseModel<UnBindLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新水印
        /// </summary>
        /// <param name="req"><see cref="UpdateLiveWatermarkRequest"/></param>
        /// <returns><see cref="UpdateLiveWatermarkResponse"/></returns>
        public async Task<UpdateLiveWatermarkResponse> UpdateLiveWatermark(UpdateLiveWatermarkRequest req)
        {
             JsonResponseModel<UpdateLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateLiveWatermark接口的同步版本，更新水印
        /// </summary>
        /// <param name="req">参考<see cref="UpdateLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="UpdateLiveWatermarkResponse"/>实例</returns>
        public UpdateLiveWatermarkResponse UpdateLiveWatermarkSync(UpdateLiveWatermarkRequest req)
        {
             JsonResponseModel<UpdateLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
