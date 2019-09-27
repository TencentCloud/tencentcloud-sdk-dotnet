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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public LiveClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public LiveClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 对流设置延播时间
        /// 注意：如果在推流前设置延播，需要提前5分钟设置。
        /// 目前该接口只支持流粒度的，域名及应用粒度功能支持当前开发中。
        /// </summary>
        /// <param name="req">参考<see cref="AddDelayLiveStreamRequest"/></param>
        /// <returns>参考<see cref="AddDelayLiveStreamResponse"/>实例</returns>
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
        /// 添加域名，一次只能提交一个域名。域名必须已备案。
        /// </summary>
        /// <param name="req">参考<see cref="AddLiveDomainRequest"/></param>
        /// <returns>参考<see cref="AddLiveDomainResponse"/>实例</returns>
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
        /// 添加水印，成功返回水印id后，需要调用[CreateLiveWatermarkRule](/document/product/267/32629)接口将水印id绑定到流使用。
        /// </summary>
        /// <param name="req">参考<see cref="AddLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="AddLiveWatermarkResponse"/>实例</returns>
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
        /// 域名绑定证书
        /// </summary>
        /// <param name="req">参考<see cref="BindLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="BindLiveDomainCertResponse"/>实例</returns>
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
        /// 创建回调规则，需要先调用[CreateLiveCallbackTemplate](/document/product/267/32637)接口创建回调模板，将返回的模板id绑定到域名/路径进行使用。
        /// <br>回调协议相关文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveCallbackRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveCallbackRuleResponse"/>实例</returns>
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
        /// 创建回调模板，成功返回模板id后，需要调用[CreateLiveCallbackRule](/document/product/267/32638)接口将模板id绑定到域名/路径使用。
        /// <br>回调协议相关文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveCallbackTemplateResponse"/>实例</returns>
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
        /// 添加证书
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveCertRequest"/></param>
        /// <returns>参考<see cref="CreateLiveCertResponse"/>实例</returns>
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
        /// <param name="req">参考<see cref="CreateLiveRecordRequest"/></param>
        /// <returns>参考<see cref="CreateLiveRecordResponse"/>实例</returns>
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
        /// 创建录制规则，需要先调用[CreateLiveRecordTemplate](/document/product/267/32614)接口创建录制模板，将返回的模板id绑定到流使用。
        /// <br>录制相关文档：[直播录制](/document/product/267/32739)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveRecordRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveRecordRuleResponse"/>实例</returns>
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
        /// 创建录制模板，成功返回模板id后，需要调用[CreateLiveRecordRule](/document/product/267/32615)接口，将模板id绑定到流进行使用。
        /// <br>录制相关文档：[直播录制](/document/product/267/32739)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveRecordTemplateResponse"/>实例</returns>
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
        /// 创建截图规则，需要先调用[CreateLiveSnapshotTemplate](/document/product/267/32624)接口创建截图模板，然后将返回的模板id绑定到流进行使用。
        /// <br>截图相关文档：[直播截图](/document/product/267/32737)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveSnapshotRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveSnapshotRuleResponse"/>实例</returns>
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
        /// 创建截图模板，成功返回模板id后，需要调用[CreateLiveSnapshotRule](/document/product/267/32625)接口，将模板id绑定到流使用。
        /// <br>截图相关文档：[直播截图](/document/product/267/32737)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveSnapshotTemplateResponse"/>实例</returns>
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
        /// 创建转码规则，需要先调用[CreateLiveTranscodeTemplate](/document/product/267/32646)接口创建转码模板，将返回的模板id绑定到流使用。
        /// <br>转码相关文档：[直播转封装及转码](/document/product/267/32736)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveTranscodeRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveTranscodeRuleResponse"/>实例</returns>
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
        /// 创建转码模板，成功返回模板id后，需要调用[CreateLiveTranscodeRule](/document/product/267/32647)接口，将返回的模板id绑定到流使用。
        /// <br>转码相关文档：[直播转封装及转码](/document/product/267/32736)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveTranscodeTemplateResponse"/>实例</returns>
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
        /// 创建水印规则，需要先调用[AddLiveWatermark](/document/product/267/30154)接口添加水印，将返回的水印id绑定到流使用。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveWatermarkRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveWatermarkRuleResponse"/>实例</returns>
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
        /// 创建临时拉流转推任务，目前限制添加10条任务。
        /// 
        /// 注意：该接口用于创建临时拉流转推任务，
        /// 拉流源地址即FromUrl 可以是腾讯或非腾讯数据源，
        /// 但转推目标地址即ToUrl 目前限制为已注册的腾讯直播域名。
        /// </summary>
        /// <param name="req">参考<see cref="CreatePullStreamConfigRequest"/></param>
        /// <returns>参考<see cref="CreatePullStreamConfigResponse"/>实例</returns>
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
        /// 删除回调规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveCallbackRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveCallbackRuleResponse"/>实例</returns>
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
        /// 删除回调模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveCallbackTemplateResponse"/>实例</returns>
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
        /// 删除域名对应的证书
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveCertRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveCertResponse"/>实例</returns>
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
        /// 删除已添加的直播域名
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveDomainRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveDomainResponse"/>实例</returns>
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
        /// 用于删除录制任务。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveRecordRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveRecordResponse"/>实例</returns>
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
        /// 删除录制规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveRecordRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveRecordRuleResponse"/>实例</returns>
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
        /// 删除录制模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveRecordTemplateResponse"/>实例</returns>
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
        /// 删除截图规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveSnapshotRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveSnapshotRuleResponse"/>实例</returns>
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
        /// 删除截图模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveSnapshotTemplateResponse"/>实例</returns>
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
        /// 删除转码规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveTranscodeRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveTranscodeRuleResponse"/>实例</returns>
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
        /// 删除转码模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveTranscodeTemplateResponse"/>实例</returns>
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
        /// 删除水印
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveWatermarkResponse"/>实例</returns>
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
        /// 删除水印规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveWatermarkRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveWatermarkRuleResponse"/>实例</returns>
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
        /// 删除直播拉流配置
        /// </summary>
        /// <param name="req">参考<see cref="DeletePullStreamConfigRequest"/></param>
        /// <returns>参考<see cref="DeletePullStreamConfigResponse"/>实例</returns>
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
        /// 直播计费带宽和流量数据查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBillBandwidthAndFluxListRequest"/></param>
        /// <returns>参考<see cref="DescribeBillBandwidthAndFluxListResponse"/>实例</returns>
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
        /// 查询按省份和运营商分组的下行播放数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeGroupProIspPlayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeGroupProIspPlayInfoListResponse"/>实例</returns>
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
        /// 查询某段时间内5分钟粒度的各播放http状态码的个数。
        /// 备注：数据延迟1小时，如10:00-10:59点的数据12点才能查到。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHttpStatusInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeHttpStatusInfoListResponse"/>实例</returns>
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
        /// 获取回调规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCallbackRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCallbackRulesResponse"/>实例</returns>
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
        /// 获取单个回调模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCallbackTemplateResponse"/>实例</returns>
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
        /// 获取回调模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCallbackTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCallbackTemplatesResponse"/>实例</returns>
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
        /// 获取证书信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCertRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCertResponse"/>实例</returns>
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
        /// 获取证书信息列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCertsRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCertsResponse"/>实例</returns>
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
        /// 获取直播延播列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveDelayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveDelayInfoListResponse"/>实例</returns>
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
        /// 查询直播域名信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveDomainRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveDomainResponse"/>实例</returns>
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
        /// 获取域名证书信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveDomainCertResponse"/>实例</returns>
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
        /// 查询实时的域名维度下行播放数据，由于数据处理有耗时，接口默认查询4分钟前的准实时数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveDomainPlayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveDomainPlayInfoListResponse"/>实例</returns>
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
        /// 根据域名状态、类型等信息查询用户的域名信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveDomainsRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveDomainsResponse"/>实例</returns>
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
        /// 获取禁推流列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveForbidStreamListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveForbidStreamListResponse"/>实例</returns>
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
        /// 查询播放鉴权key。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLivePlayAuthKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeLivePlayAuthKeyResponse"/>实例</returns>
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
        /// 查询直播推流鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLivePushAuthKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeLivePushAuthKeyResponse"/>实例</returns>
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
        /// 获取录制规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveRecordRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveRecordRulesResponse"/>实例</returns>
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
        /// 获取单个录制模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveRecordTemplateResponse"/>实例</returns>
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
        /// 获取录制模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveRecordTemplatesResponse"/>实例</returns>
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
        /// 获取截图规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveSnapshotRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveSnapshotRulesResponse"/>实例</returns>
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
        /// 获取单个截图模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveSnapshotTemplateResponse"/>实例</returns>
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
        /// 获取截图模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveSnapshotTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveSnapshotTemplatesResponse"/>实例</returns>
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
        /// 用于查询推断流事件。<br>
        /// 
        /// 注意：该接口可通过使用IsFilter进行过滤，返回推流历史记录。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamEventListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamEventListResponse"/>实例</returns>
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
        /// 查询在线推流信息列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamOnlineInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamOnlineInfoResponse"/>实例</returns>
        public async Task<DescribeLiveStreamOnlineInfoResponse> DescribeLiveStreamOnlineInfo(DescribeLiveStreamOnlineInfoRequest req)
        {
             JsonResponseModel<DescribeLiveStreamOnlineInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamOnlineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamOnlineInfoResponse>>(strResp);
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
        /// <param name="req">参考<see cref="DescribeLiveStreamOnlineListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamOnlineListResponse"/>实例</returns>
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
        /// 返回已经推过流的流列表。<br>
        /// 注意：分页最多支持查询1万条记录，可通过调整查询时间范围来获取更多数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamPublishedListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamPublishedListResponse"/>实例</returns>
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
        /// 查询所有实时流的推流信息，包括客户端IP，服务端IP，帧率，码率，域名，开始推流时间。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamPushInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamPushInfoListResponse"/>实例</returns>
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
        /// 返回直播中、无推流或者禁播等状态
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamStateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamStateResponse"/>实例</returns>
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
        /// 支持查询某天的转码详细信息。
        /// 注意：当前只支持查询近30天内某天的详细数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveTranscodeDetailInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveTranscodeDetailInfoResponse"/>实例</returns>
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
        /// 获取转码规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveTranscodeRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveTranscodeRulesResponse"/>实例</returns>
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
        /// 获取单个转码模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveTranscodeTemplateResponse"/>实例</returns>
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
        /// 获取转码模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveTranscodeTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveTranscodeTemplatesResponse"/>实例</returns>
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
        /// 获取单个水印信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveWatermarkResponse"/>实例</returns>
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
        /// 获取水印规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveWatermarkRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveWatermarkRulesResponse"/>实例</returns>
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
        /// 查询水印列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveWatermarksRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveWatermarksResponse"/>实例</returns>
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
        /// 批量获取日志URL。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLogDownloadListRequest"/></param>
        /// <returns>参考<see cref="DescribeLogDownloadListResponse"/>实例</returns>
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
        /// 查询下行播放错误码信息，某段时间内1分钟粒度的各http错误码出现的次数，包括4xx，5xx。
        /// 
        /// </summary>
        /// <param name="req">参考<see cref="DescribePlayErrorCodeDetailInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribePlayErrorCodeDetailInfoListResponse"/>实例</returns>
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
        /// 查询下行播放错误码信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePlayErrorCodeSumInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribePlayErrorCodeSumInfoListResponse"/>实例</returns>
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
        /// 查询某段时间内每个省份每个运营商的平均每秒流量，总流量，总请求数信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProIspPlaySumInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeProIspPlaySumInfoListResponse"/>实例</returns>
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
        /// 查询某省份某运营商下行播放数据，包括带宽，流量，请求数，并发连接数信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProvinceIspPlayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeProvinceIspPlayInfoListResponse"/>实例</returns>
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
        /// 查询拉流配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribePullStreamConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribePullStreamConfigsResponse"/>实例</returns>
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
        /// 查询天维度每条流的播放数据，包括总流量等。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeStreamDayPlayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeStreamDayPlayInfoListResponse"/>实例</returns>
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
        /// 查询播放数据，支持按流名称查询详细播放数据，也可按播放域名查询详细总数据。
        /// 注意：按AppName查询，需要联系客服同学提单支持。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeStreamPlayInfoListResponse"/>实例</returns>
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
        /// 查询流id的上行推流质量数据，包括音视频的帧率，码率，流逝时间，编码格式等。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeStreamPushInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeStreamPushInfoListResponse"/>实例</returns>
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
        /// 查询某段时间top n客户端ip汇总信息（暂支持top 1000）
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTopClientIpSumInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeTopClientIpSumInfoListResponse"/>实例</returns>
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
        /// 查询某时间段top n的域名或流id信息（暂支持top 1000）。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVisitTopSumInfoListRequest"/></param>
        /// <returns>参考<see cref="DescribeVisitTopSumInfoListResponse"/>实例</returns>
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
        /// 断开推流连接，但可以重新推流
        /// </summary>
        /// <param name="req">参考<see cref="DropLiveStreamRequest"/></param>
        /// <returns>参考<see cref="DropLiveStreamResponse"/>实例</returns>
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
        /// 启用状态为停用的直播域名
        /// </summary>
        /// <param name="req">参考<see cref="EnableLiveDomainRequest"/></param>
        /// <returns>参考<see cref="EnableLiveDomainResponse"/>实例</returns>
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
        /// 停止使用某个直播域名。
        /// </summary>
        /// <param name="req">参考<see cref="ForbidLiveDomainRequest"/></param>
        /// <returns>参考<see cref="ForbidLiveDomainResponse"/>实例</returns>
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
        /// 禁止某条流的推送，可以预设某个时刻将流恢复。
        /// </summary>
        /// <param name="req">参考<see cref="ForbidLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ForbidLiveStreamResponse"/>实例</returns>
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
        /// 修改回调模板
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveCallbackTemplateResponse"/>实例</returns>
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
        /// 修改证书
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveCertRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveCertResponse"/>实例</returns>
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
        /// 修改域名和证书绑定信息
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveDomainCertResponse"/>实例</returns>
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
        /// 修改播放鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLivePlayAuthKeyRequest"/></param>
        /// <returns>参考<see cref="ModifyLivePlayAuthKeyResponse"/>实例</returns>
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
        /// 修改播放域名信息
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLivePlayDomainRequest"/></param>
        /// <returns>参考<see cref="ModifyLivePlayDomainResponse"/>实例</returns>
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
        /// 修改直播推流鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLivePushAuthKeyRequest"/></param>
        /// <returns>参考<see cref="ModifyLivePushAuthKeyResponse"/>实例</returns>
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
        /// 修改录制模板配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveRecordTemplateResponse"/>实例</returns>
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
        /// 修改截图模板配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveSnapshotTemplateResponse"/>实例</returns>
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
        /// 修改转码模板配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveTranscodeTemplateResponse"/>实例</returns>
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
        /// 更新拉流配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPullStreamConfigRequest"/></param>
        /// <returns>参考<see cref="ModifyPullStreamConfigResponse"/>实例</returns>
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
        /// 修改直播拉流配置状态
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPullStreamStatusRequest"/></param>
        /// <returns>参考<see cref="ModifyPullStreamStatusResponse"/>实例</returns>
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
        /// 恢复延迟播放设置
        /// </summary>
        /// <param name="req">参考<see cref="ResumeDelayLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ResumeDelayLiveStreamResponse"/>实例</returns>
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
        /// 恢复某条流的推送。
        /// </summary>
        /// <param name="req">参考<see cref="ResumeLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ResumeLiveStreamResponse"/>实例</returns>
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
        /// 说明：录制后的文件存放于点播平台。用户如需使用录制功能，需首先自行开通点播账号并确保账号可用。录制文件存放后，相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，请参考对应文档。
        /// </summary>
        /// <param name="req">参考<see cref="StopLiveRecordRequest"/></param>
        /// <returns>参考<see cref="StopLiveRecordResponse"/>实例</returns>
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
        /// 解绑域名证书
        /// </summary>
        /// <param name="req">参考<see cref="UnBindLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="UnBindLiveDomainCertResponse"/>实例</returns>
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
        /// 更新水印
        /// </summary>
        /// <param name="req">参考<see cref="UpdateLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="UpdateLiveWatermarkResponse"/>实例</returns>
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

    }
}
