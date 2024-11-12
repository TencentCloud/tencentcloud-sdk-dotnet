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
       private const string sdkVersion = "SDK_NET_3.0.1122";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LiveClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 针对大型活动直播，通过对直播流设置延时来控制现场与观众播放画面的时间间隔，避免突发状况造成影响。
        /// 
        /// 注意：如果在推流前设置延播，需要提前5分钟设置，目前该接口只支持流粒度。
        /// </summary>
        /// <param name="req"><see cref="AddDelayLiveStreamRequest"/></param>
        /// <returns><see cref="AddDelayLiveStreamResponse"/></returns>
        public Task<AddDelayLiveStreamResponse> AddDelayLiveStream(AddDelayLiveStreamRequest req)
        {
            return InternalRequestAsync<AddDelayLiveStreamResponse>(req, "AddDelayLiveStream");
        }

        /// <summary>
        /// 针对大型活动直播，通过对直播流设置延时来控制现场与观众播放画面的时间间隔，避免突发状况造成影响。
        /// 
        /// 注意：如果在推流前设置延播，需要提前5分钟设置，目前该接口只支持流粒度。
        /// </summary>
        /// <param name="req"><see cref="AddDelayLiveStreamRequest"/></param>
        /// <returns><see cref="AddDelayLiveStreamResponse"/></returns>
        public AddDelayLiveStreamResponse AddDelayLiveStreamSync(AddDelayLiveStreamRequest req)
        {
            return InternalRequestAsync<AddDelayLiveStreamResponse>(req, "AddDelayLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加域名，一次只能提交一个域名。域名必须已备案。
        /// </summary>
        /// <param name="req"><see cref="AddLiveDomainRequest"/></param>
        /// <returns><see cref="AddLiveDomainResponse"/></returns>
        public Task<AddLiveDomainResponse> AddLiveDomain(AddLiveDomainRequest req)
        {
            return InternalRequestAsync<AddLiveDomainResponse>(req, "AddLiveDomain");
        }

        /// <summary>
        /// 添加域名，一次只能提交一个域名。域名必须已备案。
        /// </summary>
        /// <param name="req"><see cref="AddLiveDomainRequest"/></param>
        /// <returns><see cref="AddLiveDomainResponse"/></returns>
        public AddLiveDomainResponse AddLiveDomainSync(AddLiveDomainRequest req)
        {
            return InternalRequestAsync<AddLiveDomainResponse>(req, "AddLiveDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加水印，成功返回水印 ID 后，需要调用[CreateLiveWatermarkRule](/document/product/267/32629)接口将水印 ID 绑定到流使用。 水印数量上限 100，超过后需要先删除，再添加。
        /// </summary>
        /// <param name="req"><see cref="AddLiveWatermarkRequest"/></param>
        /// <returns><see cref="AddLiveWatermarkResponse"/></returns>
        public Task<AddLiveWatermarkResponse> AddLiveWatermark(AddLiveWatermarkRequest req)
        {
            return InternalRequestAsync<AddLiveWatermarkResponse>(req, "AddLiveWatermark");
        }

        /// <summary>
        /// 添加水印，成功返回水印 ID 后，需要调用[CreateLiveWatermarkRule](/document/product/267/32629)接口将水印 ID 绑定到流使用。 水印数量上限 100，超过后需要先删除，再添加。
        /// </summary>
        /// <param name="req"><see cref="AddLiveWatermarkRequest"/></param>
        /// <returns><see cref="AddLiveWatermarkResponse"/></returns>
        public AddLiveWatermarkResponse AddLiveWatermarkSync(AddLiveWatermarkRequest req)
        {
            return InternalRequestAsync<AddLiveWatermarkResponse>(req, "AddLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 验证用户是否拥有特定直播域名。
        /// </summary>
        /// <param name="req"><see cref="AuthenticateDomainOwnerRequest"/></param>
        /// <returns><see cref="AuthenticateDomainOwnerResponse"/></returns>
        public Task<AuthenticateDomainOwnerResponse> AuthenticateDomainOwner(AuthenticateDomainOwnerRequest req)
        {
            return InternalRequestAsync<AuthenticateDomainOwnerResponse>(req, "AuthenticateDomainOwner");
        }

        /// <summary>
        /// 验证用户是否拥有特定直播域名。
        /// </summary>
        /// <param name="req"><see cref="AuthenticateDomainOwnerRequest"/></param>
        /// <returns><see cref="AuthenticateDomainOwnerResponse"/></returns>
        public AuthenticateDomainOwnerResponse AuthenticateDomainOwnerSync(AuthenticateDomainOwnerRequest req)
        {
            return InternalRequestAsync<AuthenticateDomainOwnerResponse>(req, "AuthenticateDomainOwner")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用来取消混流。用法与 mix_streamv2.cancel_mix_stream 基本一致。
        /// </summary>
        /// <param name="req"><see cref="CancelCommonMixStreamRequest"/></param>
        /// <returns><see cref="CancelCommonMixStreamResponse"/></returns>
        public Task<CancelCommonMixStreamResponse> CancelCommonMixStream(CancelCommonMixStreamRequest req)
        {
            return InternalRequestAsync<CancelCommonMixStreamResponse>(req, "CancelCommonMixStream");
        }

        /// <summary>
        /// 该接口用来取消混流。用法与 mix_streamv2.cancel_mix_stream 基本一致。
        /// </summary>
        /// <param name="req"><see cref="CancelCommonMixStreamRequest"/></param>
        /// <returns><see cref="CancelCommonMixStreamResponse"/></returns>
        public CancelCommonMixStreamResponse CancelCommonMixStreamSync(CancelCommonMixStreamRequest req)
        {
            return InternalRequestAsync<CancelCommonMixStreamResponse>(req, "CancelCommonMixStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用来创建通用混流。用法与旧接口 mix_streamv2.start_mix_stream_advanced 基本一致。
        /// 注意：当前最多支持16路混流。
        /// 最佳实践：https://cloud.tencent.com/document/product/267/45566
        /// </summary>
        /// <param name="req"><see cref="CreateCommonMixStreamRequest"/></param>
        /// <returns><see cref="CreateCommonMixStreamResponse"/></returns>
        public Task<CreateCommonMixStreamResponse> CreateCommonMixStream(CreateCommonMixStreamRequest req)
        {
            return InternalRequestAsync<CreateCommonMixStreamResponse>(req, "CreateCommonMixStream");
        }

        /// <summary>
        /// 该接口用来创建通用混流。用法与旧接口 mix_streamv2.start_mix_stream_advanced 基本一致。
        /// 注意：当前最多支持16路混流。
        /// 最佳实践：https://cloud.tencent.com/document/product/267/45566
        /// </summary>
        /// <param name="req"><see cref="CreateCommonMixStreamRequest"/></param>
        /// <returns><see cref="CreateCommonMixStreamResponse"/></returns>
        public CreateCommonMixStreamResponse CreateCommonMixStreamSync(CreateCommonMixStreamRequest req)
        {
            return InternalRequestAsync<CreateCommonMixStreamResponse>(req, "CreateCommonMixStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建回调规则，需要先调用[CreateLiveCallbackTemplate](/document/product/267/32637)接口创建回调模板，将返回的模板id绑定到域名/路径进行使用。
        /// <br>回调协议相关文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackRuleResponse"/></returns>
        public Task<CreateLiveCallbackRuleResponse> CreateLiveCallbackRule(CreateLiveCallbackRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveCallbackRuleResponse>(req, "CreateLiveCallbackRule");
        }

        /// <summary>
        /// 创建回调规则，需要先调用[CreateLiveCallbackTemplate](/document/product/267/32637)接口创建回调模板，将返回的模板id绑定到域名/路径进行使用。
        /// <br>回调协议相关文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackRuleResponse"/></returns>
        public CreateLiveCallbackRuleResponse CreateLiveCallbackRuleSync(CreateLiveCallbackRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveCallbackRuleResponse>(req, "CreateLiveCallbackRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建回调模板，数量上限：50，成功返回模板id后，需要调用[CreateLiveCallbackRule](/document/product/267/32638)接口将模板 ID 绑定到域名/路径使用。
        /// <br>回调协议相关文档：[事件消息通知](/document/product/267/32744)。
        /// 注意：至少填写一个回调 URL。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackTemplateResponse"/></returns>
        public Task<CreateLiveCallbackTemplateResponse> CreateLiveCallbackTemplate(CreateLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveCallbackTemplateResponse>(req, "CreateLiveCallbackTemplate");
        }

        /// <summary>
        /// 创建回调模板，数量上限：50，成功返回模板id后，需要调用[CreateLiveCallbackRule](/document/product/267/32638)接口将模板 ID 绑定到域名/路径使用。
        /// <br>回调协议相关文档：[事件消息通知](/document/product/267/32744)。
        /// 注意：至少填写一个回调 URL。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveCallbackTemplateResponse"/></returns>
        public CreateLiveCallbackTemplateResponse CreateLiveCallbackTemplateSync(CreateLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveCallbackTemplateResponse>(req, "CreateLiveCallbackTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建直播垫片规则。
        /// </summary>
        /// <param name="req"><see cref="CreateLivePadRuleRequest"/></param>
        /// <returns><see cref="CreateLivePadRuleResponse"/></returns>
        public Task<CreateLivePadRuleResponse> CreateLivePadRule(CreateLivePadRuleRequest req)
        {
            return InternalRequestAsync<CreateLivePadRuleResponse>(req, "CreateLivePadRule");
        }

        /// <summary>
        /// 创建直播垫片规则。
        /// </summary>
        /// <param name="req"><see cref="CreateLivePadRuleRequest"/></param>
        /// <returns><see cref="CreateLivePadRuleResponse"/></returns>
        public CreateLivePadRuleResponse CreateLivePadRuleSync(CreateLivePadRuleRequest req)
        {
            return InternalRequestAsync<CreateLivePadRuleResponse>(req, "CreateLivePadRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建直播垫片模板。
        /// </summary>
        /// <param name="req"><see cref="CreateLivePadTemplateRequest"/></param>
        /// <returns><see cref="CreateLivePadTemplateResponse"/></returns>
        public Task<CreateLivePadTemplateResponse> CreateLivePadTemplate(CreateLivePadTemplateRequest req)
        {
            return InternalRequestAsync<CreateLivePadTemplateResponse>(req, "CreateLivePadTemplate");
        }

        /// <summary>
        /// 创建直播垫片模板。
        /// </summary>
        /// <param name="req"><see cref="CreateLivePadTemplateRequest"/></param>
        /// <returns><see cref="CreateLivePadTemplateResponse"/></returns>
        public CreateLivePadTemplateResponse CreateLivePadTemplateSync(CreateLivePadTemplateRequest req)
        {
            return InternalRequestAsync<CreateLivePadTemplateResponse>(req, "CreateLivePadTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建直播拉流任务。支持将外部已有的点播文件，或者直播源拉取过来转推到指定的目标地址。
        /// 注意：
        /// 1. 默认支持任务数上限200个，如有特殊需求，可通过提单到售后进行评估增加上限。
        /// 2. 源流视频编码目前只支持: H264, H265。其他编码格式建议先进行转码处理。
        /// 3. 源流音频编码目前只支持: AAC。其他编码格式建议先进行转码处理。
        /// 4. 可在控制台开启过期自动清理，避免过期任务占用任务数额度。
        /// 5. 拉流转推功能为计费增值服务，计费规则详情可参见[计费文档](https://cloud.tencent.com/document/product/267/53308)。
        /// 6. 拉流转推功能仅提供内容拉取与推送服务，请确保内容已获得授权并符合内容传播相关的法律法规。若内容有侵权或违规相关问题，云直播会停止相关的功能服务并保留追究法律责任的权利。
        /// </summary>
        /// <param name="req"><see cref="CreateLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="CreateLivePullStreamTaskResponse"/></returns>
        public Task<CreateLivePullStreamTaskResponse> CreateLivePullStreamTask(CreateLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<CreateLivePullStreamTaskResponse>(req, "CreateLivePullStreamTask");
        }

        /// <summary>
        /// 创建直播拉流任务。支持将外部已有的点播文件，或者直播源拉取过来转推到指定的目标地址。
        /// 注意：
        /// 1. 默认支持任务数上限200个，如有特殊需求，可通过提单到售后进行评估增加上限。
        /// 2. 源流视频编码目前只支持: H264, H265。其他编码格式建议先进行转码处理。
        /// 3. 源流音频编码目前只支持: AAC。其他编码格式建议先进行转码处理。
        /// 4. 可在控制台开启过期自动清理，避免过期任务占用任务数额度。
        /// 5. 拉流转推功能为计费增值服务，计费规则详情可参见[计费文档](https://cloud.tencent.com/document/product/267/53308)。
        /// 6. 拉流转推功能仅提供内容拉取与推送服务，请确保内容已获得授权并符合内容传播相关的法律法规。若内容有侵权或违规相关问题，云直播会停止相关的功能服务并保留追究法律责任的权利。
        /// </summary>
        /// <param name="req"><see cref="CreateLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="CreateLivePullStreamTaskResponse"/></returns>
        public CreateLivePullStreamTaskResponse CreateLivePullStreamTaskSync(CreateLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<CreateLivePullStreamTaskResponse>(req, "CreateLivePullStreamTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// - 使用前提
        ///   1. 录制文件存放于点播平台，所以用户如需使用录制功能，需首先自行开通点播服务。
        ///   2. 录制文件存放后相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，具体请参考 [对应文档](https://cloud.tencent.com/document/product/266/2838)。
        /// 
        /// - 模式说明
        ///   该接口支持两种录制模式：
        ///   1. 定时录制模式【默认模式】。
        ///     需要传入开始时间与结束时间，录制任务根据起止时间自动开始与结束。在所设置结束时间过期之前（且未调用StopLiveRecord提前终止任务），录制任务都是有效的，期间多次断流然后重推都会启动录制任务。
        ///   2. 实时视频录制模式。
        ///     忽略传入的开始时间，在录制任务创建后立即开始录制，录制时长支持最大为30分钟，如果传入的结束时间与当前时间差大于30分钟，则按30分钟计算，实时视频录制主要用于录制精彩视频场景，时长建议控制在5分钟以内。
        /// 
        /// - 注意事项
        ///   1. 调用接口超时设置应大于3秒，小于3秒重试以及按不同起止时间调用都有可能产生重复录制任务，进而导致额外录制费用。
        ///   2. 受限于音视频文件格式（FLV/MP4/HLS）对编码类型的支持，视频编码类型支持 H.264，音频编码类型支持 AAC。
        ///   3. 为避免恶意或非主观的频繁 API 请求，对定时录制模式最大创建任务数做了限制：其中，当天可以创建的最大任务数不超过4000（不含已删除的任务）；当前时刻并发运行的任务数不超过400。有超出此限制的需要提工单申请。
        ///   4. 此调用方式暂时不支持海外推流录制。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRequest"/></param>
        /// <returns><see cref="CreateLiveRecordResponse"/></returns>
        public Task<CreateLiveRecordResponse> CreateLiveRecord(CreateLiveRecordRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordResponse>(req, "CreateLiveRecord");
        }

        /// <summary>
        /// - 使用前提
        ///   1. 录制文件存放于点播平台，所以用户如需使用录制功能，需首先自行开通点播服务。
        ///   2. 录制文件存放后相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，具体请参考 [对应文档](https://cloud.tencent.com/document/product/266/2838)。
        /// 
        /// - 模式说明
        ///   该接口支持两种录制模式：
        ///   1. 定时录制模式【默认模式】。
        ///     需要传入开始时间与结束时间，录制任务根据起止时间自动开始与结束。在所设置结束时间过期之前（且未调用StopLiveRecord提前终止任务），录制任务都是有效的，期间多次断流然后重推都会启动录制任务。
        ///   2. 实时视频录制模式。
        ///     忽略传入的开始时间，在录制任务创建后立即开始录制，录制时长支持最大为30分钟，如果传入的结束时间与当前时间差大于30分钟，则按30分钟计算，实时视频录制主要用于录制精彩视频场景，时长建议控制在5分钟以内。
        /// 
        /// - 注意事项
        ///   1. 调用接口超时设置应大于3秒，小于3秒重试以及按不同起止时间调用都有可能产生重复录制任务，进而导致额外录制费用。
        ///   2. 受限于音视频文件格式（FLV/MP4/HLS）对编码类型的支持，视频编码类型支持 H.264，音频编码类型支持 AAC。
        ///   3. 为避免恶意或非主观的频繁 API 请求，对定时录制模式最大创建任务数做了限制：其中，当天可以创建的最大任务数不超过4000（不含已删除的任务）；当前时刻并发运行的任务数不超过400。有超出此限制的需要提工单申请。
        ///   4. 此调用方式暂时不支持海外推流录制。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRequest"/></param>
        /// <returns><see cref="CreateLiveRecordResponse"/></returns>
        public CreateLiveRecordResponse CreateLiveRecordSync(CreateLiveRecordRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordResponse>(req, "CreateLiveRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建录制规则，需要先调用[CreateLiveRecordTemplate](/document/product/267/32614)接口创建录制模板，将返回的模板id绑定到流使用。
        /// <br>录制相关文档：[直播录制](/document/product/267/32739)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRuleRequest"/></param>
        /// <returns><see cref="CreateLiveRecordRuleResponse"/></returns>
        public Task<CreateLiveRecordRuleResponse> CreateLiveRecordRule(CreateLiveRecordRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordRuleResponse>(req, "CreateLiveRecordRule");
        }

        /// <summary>
        /// 创建录制规则，需要先调用[CreateLiveRecordTemplate](/document/product/267/32614)接口创建录制模板，将返回的模板id绑定到流使用。
        /// <br>录制相关文档：[直播录制](/document/product/267/32739)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordRuleRequest"/></param>
        /// <returns><see cref="CreateLiveRecordRuleResponse"/></returns>
        public CreateLiveRecordRuleResponse CreateLiveRecordRuleSync(CreateLiveRecordRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordRuleResponse>(req, "CreateLiveRecordRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建录制模板，数量上限：50，成功返回模板id后，需要调用[CreateLiveRecordRule](/document/product/267/32615)接口，将模板id绑定到流进行使用。
        /// <br>录制相关文档：[直播录制](/document/product/267/32739)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveRecordTemplateResponse"/></returns>
        public Task<CreateLiveRecordTemplateResponse> CreateLiveRecordTemplate(CreateLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordTemplateResponse>(req, "CreateLiveRecordTemplate");
        }

        /// <summary>
        /// 创建录制模板，数量上限：50，成功返回模板id后，需要调用[CreateLiveRecordRule](/document/product/267/32615)接口，将模板id绑定到流进行使用。
        /// <br>录制相关文档：[直播录制](/document/product/267/32739)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveRecordTemplateResponse"/></returns>
        public CreateLiveRecordTemplateResponse CreateLiveRecordTemplateSync(CreateLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordTemplateResponse>(req, "CreateLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建截图规则，需要先调用[CreateLiveSnapshotTemplate](/document/product/267/32624)接口创建截图模板，然后将返回的模板 ID 绑定到流进行使用。
        /// <br>截图相关文档：[直播截图](/document/product/267/32737)。
        /// 注意：单个域名仅支持关联一个截图模板。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotRuleResponse"/></returns>
        public Task<CreateLiveSnapshotRuleResponse> CreateLiveSnapshotRule(CreateLiveSnapshotRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveSnapshotRuleResponse>(req, "CreateLiveSnapshotRule");
        }

        /// <summary>
        /// 创建截图规则，需要先调用[CreateLiveSnapshotTemplate](/document/product/267/32624)接口创建截图模板，然后将返回的模板 ID 绑定到流进行使用。
        /// <br>截图相关文档：[直播截图](/document/product/267/32737)。
        /// 注意：单个域名仅支持关联一个截图模板。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotRuleResponse"/></returns>
        public CreateLiveSnapshotRuleResponse CreateLiveSnapshotRuleSync(CreateLiveSnapshotRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveSnapshotRuleResponse>(req, "CreateLiveSnapshotRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建截图模板，数量上限：50，成功返回模板id后，需要调用[CreateLiveSnapshotRule](/document/product/267/32625)接口，将模板id绑定到流使用。
        /// <br>截图相关文档：[直播截图](/document/product/267/32737)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotTemplateResponse"/></returns>
        public Task<CreateLiveSnapshotTemplateResponse> CreateLiveSnapshotTemplate(CreateLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveSnapshotTemplateResponse>(req, "CreateLiveSnapshotTemplate");
        }

        /// <summary>
        /// 创建截图模板，数量上限：50，成功返回模板id后，需要调用[CreateLiveSnapshotRule](/document/product/267/32625)接口，将模板id绑定到流使用。
        /// <br>截图相关文档：[直播截图](/document/product/267/32737)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveSnapshotTemplateResponse"/></returns>
        public CreateLiveSnapshotTemplateResponse CreateLiveSnapshotTemplateSync(CreateLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveSnapshotTemplateResponse>(req, "CreateLiveSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用来创建直播流监播任务。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="CreateLiveStreamMonitorResponse"/></returns>
        public Task<CreateLiveStreamMonitorResponse> CreateLiveStreamMonitor(CreateLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<CreateLiveStreamMonitorResponse>(req, "CreateLiveStreamMonitor");
        }

        /// <summary>
        /// 该接口用来创建直播流监播任务。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="CreateLiveStreamMonitorResponse"/></returns>
        public CreateLiveStreamMonitorResponse CreateLiveStreamMonitorSync(CreateLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<CreateLiveStreamMonitorResponse>(req, "CreateLiveStreamMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建直播时移规则，需要先调用[CreateLiveTimeShiftTemplate](/document/product/267/86169)接口创建直播时移模板，将返回的模板id绑定到流使用。
        /// <br>直播时移相关文档：[直播时移](/document/product/267/86134)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTimeShiftRuleRequest"/></param>
        /// <returns><see cref="CreateLiveTimeShiftRuleResponse"/></returns>
        public Task<CreateLiveTimeShiftRuleResponse> CreateLiveTimeShiftRule(CreateLiveTimeShiftRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveTimeShiftRuleResponse>(req, "CreateLiveTimeShiftRule");
        }

        /// <summary>
        /// 创建直播时移规则，需要先调用[CreateLiveTimeShiftTemplate](/document/product/267/86169)接口创建直播时移模板，将返回的模板id绑定到流使用。
        /// <br>直播时移相关文档：[直播时移](/document/product/267/86134)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTimeShiftRuleRequest"/></param>
        /// <returns><see cref="CreateLiveTimeShiftRuleResponse"/></returns>
        public CreateLiveTimeShiftRuleResponse CreateLiveTimeShiftRuleSync(CreateLiveTimeShiftRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveTimeShiftRuleResponse>(req, "CreateLiveTimeShiftRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建直播时移模板。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveTimeShiftTemplateResponse"/></returns>
        public Task<CreateLiveTimeShiftTemplateResponse> CreateLiveTimeShiftTemplate(CreateLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveTimeShiftTemplateResponse>(req, "CreateLiveTimeShiftTemplate");
        }

        /// <summary>
        /// 创建直播时移模板。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveTimeShiftTemplateResponse"/></returns>
        public CreateLiveTimeShiftTemplateResponse CreateLiveTimeShiftTemplateSync(CreateLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveTimeShiftTemplateResponse>(req, "CreateLiveTimeShiftTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建转码规则，数量上限：50，需要先调用[CreateLiveTranscodeTemplate](/document/product/267/32646)接口创建转码模板，将返回的模板id绑定到流使用。
        /// <br>转码相关文档：[直播转封装及转码](/document/product/267/32736)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeRuleResponse"/></returns>
        public Task<CreateLiveTranscodeRuleResponse> CreateLiveTranscodeRule(CreateLiveTranscodeRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveTranscodeRuleResponse>(req, "CreateLiveTranscodeRule");
        }

        /// <summary>
        /// 创建转码规则，数量上限：50，需要先调用[CreateLiveTranscodeTemplate](/document/product/267/32646)接口创建转码模板，将返回的模板id绑定到流使用。
        /// <br>转码相关文档：[直播转封装及转码](/document/product/267/32736)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeRuleResponse"/></returns>
        public CreateLiveTranscodeRuleResponse CreateLiveTranscodeRuleSync(CreateLiveTranscodeRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveTranscodeRuleResponse>(req, "CreateLiveTranscodeRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建转码模板，数量上限：50，成功返回模板id后，需要调用[CreateLiveTranscodeRule](/document/product/267/32647)接口，将返回的模板id绑定到流使用。
        /// <br>转码相关文档：[直播转封装及转码](/document/product/267/32736)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeTemplateResponse"/></returns>
        public Task<CreateLiveTranscodeTemplateResponse> CreateLiveTranscodeTemplate(CreateLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveTranscodeTemplateResponse>(req, "CreateLiveTranscodeTemplate");
        }

        /// <summary>
        /// 创建转码模板，数量上限：50，成功返回模板id后，需要调用[CreateLiveTranscodeRule](/document/product/267/32647)接口，将返回的模板id绑定到流使用。
        /// <br>转码相关文档：[直播转封装及转码](/document/product/267/32736)。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveTranscodeTemplateResponse"/></returns>
        public CreateLiveTranscodeTemplateResponse CreateLiveTranscodeTemplateSync(CreateLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveTranscodeTemplateResponse>(req, "CreateLiveTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建水印规则，需要先调用[AddLiveWatermark](/document/product/267/30154)接口添加水印，将返回的水印id绑定到流使用。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="CreateLiveWatermarkRuleResponse"/></returns>
        public Task<CreateLiveWatermarkRuleResponse> CreateLiveWatermarkRule(CreateLiveWatermarkRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveWatermarkRuleResponse>(req, "CreateLiveWatermarkRule");
        }

        /// <summary>
        /// 创建水印规则，需要先调用[AddLiveWatermark](/document/product/267/30154)接口添加水印，将返回的水印id绑定到流使用。
        /// </summary>
        /// <param name="req"><see cref="CreateLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="CreateLiveWatermarkRuleResponse"/></returns>
        public CreateLiveWatermarkRuleResponse CreateLiveWatermarkRuleSync(CreateLiveWatermarkRuleRequest req)
        {
            return InternalRequestAsync<CreateLiveWatermarkRuleResponse>(req, "CreateLiveWatermarkRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建临时拉流转推任务，目前限制添加10条任务。
        /// 该接口已下线,请使用新接口 CreateLivePullStreamTask。
        /// 
        /// 注意：该接口用于创建临时拉流转推任务，
        /// 拉流源地址即 FromUrl 可以是腾讯或非腾讯数据源，
        /// 但转推目标地址即 ToUrl 目前限制为已注册的腾讯直播域名。
        /// </summary>
        /// <param name="req"><see cref="CreatePullStreamConfigRequest"/></param>
        /// <returns><see cref="CreatePullStreamConfigResponse"/></returns>
        public Task<CreatePullStreamConfigResponse> CreatePullStreamConfig(CreatePullStreamConfigRequest req)
        {
            return InternalRequestAsync<CreatePullStreamConfigResponse>(req, "CreatePullStreamConfig");
        }

        /// <summary>
        /// 创建临时拉流转推任务，目前限制添加10条任务。
        /// 该接口已下线,请使用新接口 CreateLivePullStreamTask。
        /// 
        /// 注意：该接口用于创建临时拉流转推任务，
        /// 拉流源地址即 FromUrl 可以是腾讯或非腾讯数据源，
        /// 但转推目标地址即 ToUrl 目前限制为已注册的腾讯直播域名。
        /// </summary>
        /// <param name="req"><see cref="CreatePullStreamConfigRequest"/></param>
        /// <returns><see cref="CreatePullStreamConfigResponse"/></returns>
        public CreatePullStreamConfigResponse CreatePullStreamConfigSync(CreatePullStreamConfigRequest req)
        {
            return InternalRequestAsync<CreatePullStreamConfigResponse>(req, "CreatePullStreamConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个在指定时间启动、结束的录制任务，并使用指定录制模板ID对应的配置进行录制。
        /// - 使用前提
        /// 1. 录制文件存放于点播平台或对象存储内，所以用户如需使用录制功能，需首先自行开通点播服务或对象存储服务。
        /// 2. 录制文件存放后相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，具体请参考[对应文档](https://cloud.tencent.com/document/product/266/2837)。
        /// - 注意事项
        /// 1. 断流会结束当前录制并生成录制文件。在结束时间到达之前任务仍然有效，期间只要正常推流都会正常录制，与是否多次推、断流无关。
        /// 2. 使用上避免创建时间段相互重叠的录制任务。若同一条流当前存在多个时段重叠的任务，为避免重复录制系统将启动最多3个录制任务。
        /// 3. 创建的录制任务记录在平台侧只保留3个月。
        /// 4. 当前录制任务管理API（[CreateRecordTask](https://cloud.tencent.com/document/product/267/45983)/[StopRecordTask](https://cloud.tencent.com/document/product/267/45981)/[DeleteRecordTask](https://cloud.tencent.com/document/product/267/45982)）与旧API（CreateLiveRecord/StopLiveRecord/DeleteLiveRecord）不兼容，两套接口不能混用。
        /// 5. 避免 创建录制任务 与 推流 操作同时进行，可能导致因录制任务未生效而引起任务延迟启动问题，两者操作间隔建议大于3秒。
        /// </summary>
        /// <param name="req"><see cref="CreateRecordTaskRequest"/></param>
        /// <returns><see cref="CreateRecordTaskResponse"/></returns>
        public Task<CreateRecordTaskResponse> CreateRecordTask(CreateRecordTaskRequest req)
        {
            return InternalRequestAsync<CreateRecordTaskResponse>(req, "CreateRecordTask");
        }

        /// <summary>
        /// 创建一个在指定时间启动、结束的录制任务，并使用指定录制模板ID对应的配置进行录制。
        /// - 使用前提
        /// 1. 录制文件存放于点播平台或对象存储内，所以用户如需使用录制功能，需首先自行开通点播服务或对象存储服务。
        /// 2. 录制文件存放后相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，具体请参考[对应文档](https://cloud.tencent.com/document/product/266/2837)。
        /// - 注意事项
        /// 1. 断流会结束当前录制并生成录制文件。在结束时间到达之前任务仍然有效，期间只要正常推流都会正常录制，与是否多次推、断流无关。
        /// 2. 使用上避免创建时间段相互重叠的录制任务。若同一条流当前存在多个时段重叠的任务，为避免重复录制系统将启动最多3个录制任务。
        /// 3. 创建的录制任务记录在平台侧只保留3个月。
        /// 4. 当前录制任务管理API（[CreateRecordTask](https://cloud.tencent.com/document/product/267/45983)/[StopRecordTask](https://cloud.tencent.com/document/product/267/45981)/[DeleteRecordTask](https://cloud.tencent.com/document/product/267/45982)）与旧API（CreateLiveRecord/StopLiveRecord/DeleteLiveRecord）不兼容，两套接口不能混用。
        /// 5. 避免 创建录制任务 与 推流 操作同时进行，可能导致因录制任务未生效而引起任务延迟启动问题，两者操作间隔建议大于3秒。
        /// </summary>
        /// <param name="req"><see cref="CreateRecordTaskRequest"/></param>
        /// <returns><see cref="CreateRecordTaskResponse"/></returns>
        public CreateRecordTaskResponse CreateRecordTaskSync(CreateRecordTaskRequest req)
        {
            return InternalRequestAsync<CreateRecordTaskResponse>(req, "CreateRecordTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个在指定时间启动、结束的截图任务，并使用指定截图模板ID对应的配置进行截图。
        /// - 注意事项
        /// 1. 断流会结束当前截图。在结束时间到达之前任务仍然有效，期间只要正常推流都会正常截图，与是否多次推、断流无关。
        /// 2. 使用上避免创建时间段相互重叠的截图任务。若同一条流当前存在多个时段重叠的任务，为避免重复系统将启动最多3个截图任务。
        /// 3. 创建的截图任务记录在平台侧只保留3个月。
        /// 4. 当前截图任务管理API（CreateScreenshotTask/StopScreenshotTask/DeleteScreenshotTask）与旧API（CreateLiveInstantSnapshot/StopLiveInstantSnapshot）不兼容，两套接口不能混用。
        /// 5. 避免 创建截图任务 与 推流 操作同时进行，可能导致因截图任务未生效而引起任务延迟启动问题，两者操作间隔建议大于3秒。
        /// </summary>
        /// <param name="req"><see cref="CreateScreenshotTaskRequest"/></param>
        /// <returns><see cref="CreateScreenshotTaskResponse"/></returns>
        public Task<CreateScreenshotTaskResponse> CreateScreenshotTask(CreateScreenshotTaskRequest req)
        {
            return InternalRequestAsync<CreateScreenshotTaskResponse>(req, "CreateScreenshotTask");
        }

        /// <summary>
        /// 创建一个在指定时间启动、结束的截图任务，并使用指定截图模板ID对应的配置进行截图。
        /// - 注意事项
        /// 1. 断流会结束当前截图。在结束时间到达之前任务仍然有效，期间只要正常推流都会正常截图，与是否多次推、断流无关。
        /// 2. 使用上避免创建时间段相互重叠的截图任务。若同一条流当前存在多个时段重叠的任务，为避免重复系统将启动最多3个截图任务。
        /// 3. 创建的截图任务记录在平台侧只保留3个月。
        /// 4. 当前截图任务管理API（CreateScreenshotTask/StopScreenshotTask/DeleteScreenshotTask）与旧API（CreateLiveInstantSnapshot/StopLiveInstantSnapshot）不兼容，两套接口不能混用。
        /// 5. 避免 创建截图任务 与 推流 操作同时进行，可能导致因截图任务未生效而引起任务延迟启动问题，两者操作间隔建议大于3秒。
        /// </summary>
        /// <param name="req"><see cref="CreateScreenshotTaskRequest"/></param>
        /// <returns><see cref="CreateScreenshotTaskResponse"/></returns>
        public CreateScreenshotTaskResponse CreateScreenshotTaskSync(CreateScreenshotTaskRequest req)
        {
            return InternalRequestAsync<CreateScreenshotTaskResponse>(req, "CreateScreenshotTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除回调规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackRuleResponse"/></returns>
        public Task<DeleteLiveCallbackRuleResponse> DeleteLiveCallbackRule(DeleteLiveCallbackRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveCallbackRuleResponse>(req, "DeleteLiveCallbackRule");
        }

        /// <summary>
        /// 删除回调规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackRuleResponse"/></returns>
        public DeleteLiveCallbackRuleResponse DeleteLiveCallbackRuleSync(DeleteLiveCallbackRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveCallbackRuleResponse>(req, "DeleteLiveCallbackRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除回调模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackTemplateResponse"/></returns>
        public Task<DeleteLiveCallbackTemplateResponse> DeleteLiveCallbackTemplate(DeleteLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveCallbackTemplateResponse>(req, "DeleteLiveCallbackTemplate");
        }

        /// <summary>
        /// 删除回调模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveCallbackTemplateResponse"/></returns>
        public DeleteLiveCallbackTemplateResponse DeleteLiveCallbackTemplateSync(DeleteLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveCallbackTemplateResponse>(req, "DeleteLiveCallbackTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除已添加的直播域名
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveDomainRequest"/></param>
        /// <returns><see cref="DeleteLiveDomainResponse"/></returns>
        public Task<DeleteLiveDomainResponse> DeleteLiveDomain(DeleteLiveDomainRequest req)
        {
            return InternalRequestAsync<DeleteLiveDomainResponse>(req, "DeleteLiveDomain");
        }

        /// <summary>
        /// 删除已添加的直播域名
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveDomainRequest"/></param>
        /// <returns><see cref="DeleteLiveDomainResponse"/></returns>
        public DeleteLiveDomainResponse DeleteLiveDomainSync(DeleteLiveDomainRequest req)
        {
            return InternalRequestAsync<DeleteLiveDomainResponse>(req, "DeleteLiveDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除直播垫片规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLivePadRuleRequest"/></param>
        /// <returns><see cref="DeleteLivePadRuleResponse"/></returns>
        public Task<DeleteLivePadRuleResponse> DeleteLivePadRule(DeleteLivePadRuleRequest req)
        {
            return InternalRequestAsync<DeleteLivePadRuleResponse>(req, "DeleteLivePadRule");
        }

        /// <summary>
        /// 删除直播垫片规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLivePadRuleRequest"/></param>
        /// <returns><see cref="DeleteLivePadRuleResponse"/></returns>
        public DeleteLivePadRuleResponse DeleteLivePadRuleSync(DeleteLivePadRuleRequest req)
        {
            return InternalRequestAsync<DeleteLivePadRuleResponse>(req, "DeleteLivePadRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除直播垫片模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteLivePadTemplateRequest"/></param>
        /// <returns><see cref="DeleteLivePadTemplateResponse"/></returns>
        public Task<DeleteLivePadTemplateResponse> DeleteLivePadTemplate(DeleteLivePadTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLivePadTemplateResponse>(req, "DeleteLivePadTemplate");
        }

        /// <summary>
        /// 删除直播垫片模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteLivePadTemplateRequest"/></param>
        /// <returns><see cref="DeleteLivePadTemplateResponse"/></returns>
        public DeleteLivePadTemplateResponse DeleteLivePadTemplateSync(DeleteLivePadTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLivePadTemplateResponse>(req, "DeleteLivePadTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除接口 CreateLivePullStreamTask 创建的拉流任务。
        /// 注意：
        /// 1. 入参中的 TaskId 为 CreateLivePullStreamTask 接口创建时返回的TaskId。
        /// 2. 也可通过 DescribeLivePullStreamTasks 进行查询创建的任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="DeleteLivePullStreamTaskResponse"/></returns>
        public Task<DeleteLivePullStreamTaskResponse> DeleteLivePullStreamTask(DeleteLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<DeleteLivePullStreamTaskResponse>(req, "DeleteLivePullStreamTask");
        }

        /// <summary>
        /// 删除接口 CreateLivePullStreamTask 创建的拉流任务。
        /// 注意：
        /// 1. 入参中的 TaskId 为 CreateLivePullStreamTask 接口创建时返回的TaskId。
        /// 2. 也可通过 DescribeLivePullStreamTasks 进行查询创建的任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="DeleteLivePullStreamTaskResponse"/></returns>
        public DeleteLivePullStreamTaskResponse DeleteLivePullStreamTaskSync(DeleteLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<DeleteLivePullStreamTaskResponse>(req, "DeleteLivePullStreamTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注：DeleteLiveRecord 接口仅用于删除录制任务记录，不具备停止录制的功能，也不能删除正在进行中的录制。如果需要停止录制任务，请使用终止录制[StopLiveRecord](/document/product/267/30146) 接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordResponse"/></returns>
        public Task<DeleteLiveRecordResponse> DeleteLiveRecord(DeleteLiveRecordRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordResponse>(req, "DeleteLiveRecord");
        }

        /// <summary>
        /// 注：DeleteLiveRecord 接口仅用于删除录制任务记录，不具备停止录制的功能，也不能删除正在进行中的录制。如果需要停止录制任务，请使用终止录制[StopLiveRecord](/document/product/267/30146) 接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordResponse"/></returns>
        public DeleteLiveRecordResponse DeleteLiveRecordSync(DeleteLiveRecordRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordResponse>(req, "DeleteLiveRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除录制规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordRuleResponse"/></returns>
        public Task<DeleteLiveRecordRuleResponse> DeleteLiveRecordRule(DeleteLiveRecordRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordRuleResponse>(req, "DeleteLiveRecordRule");
        }

        /// <summary>
        /// 删除录制规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordRuleResponse"/></returns>
        public DeleteLiveRecordRuleResponse DeleteLiveRecordRuleSync(DeleteLiveRecordRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordRuleResponse>(req, "DeleteLiveRecordRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除录制模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordTemplateResponse"/></returns>
        public Task<DeleteLiveRecordTemplateResponse> DeleteLiveRecordTemplate(DeleteLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordTemplateResponse>(req, "DeleteLiveRecordTemplate");
        }

        /// <summary>
        /// 删除录制模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordTemplateResponse"/></returns>
        public DeleteLiveRecordTemplateResponse DeleteLiveRecordTemplateSync(DeleteLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordTemplateResponse>(req, "DeleteLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除截图规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotRuleResponse"/></returns>
        public Task<DeleteLiveSnapshotRuleResponse> DeleteLiveSnapshotRule(DeleteLiveSnapshotRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveSnapshotRuleResponse>(req, "DeleteLiveSnapshotRule");
        }

        /// <summary>
        /// 删除截图规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotRuleResponse"/></returns>
        public DeleteLiveSnapshotRuleResponse DeleteLiveSnapshotRuleSync(DeleteLiveSnapshotRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveSnapshotRuleResponse>(req, "DeleteLiveSnapshotRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除截图模板
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotTemplateResponse"/></returns>
        public Task<DeleteLiveSnapshotTemplateResponse> DeleteLiveSnapshotTemplate(DeleteLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveSnapshotTemplateResponse>(req, "DeleteLiveSnapshotTemplate");
        }

        /// <summary>
        /// 删除截图模板
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveSnapshotTemplateResponse"/></returns>
        public DeleteLiveSnapshotTemplateResponse DeleteLiveSnapshotTemplateSync(DeleteLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveSnapshotTemplateResponse>(req, "DeleteLiveSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用来删除直播流监播任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="DeleteLiveStreamMonitorResponse"/></returns>
        public Task<DeleteLiveStreamMonitorResponse> DeleteLiveStreamMonitor(DeleteLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<DeleteLiveStreamMonitorResponse>(req, "DeleteLiveStreamMonitor");
        }

        /// <summary>
        /// 该接口用来删除直播流监播任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="DeleteLiveStreamMonitorResponse"/></returns>
        public DeleteLiveStreamMonitorResponse DeleteLiveStreamMonitorSync(DeleteLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<DeleteLiveStreamMonitorResponse>(req, "DeleteLiveStreamMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除直播时移规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTimeShiftRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveTimeShiftRuleResponse"/></returns>
        public Task<DeleteLiveTimeShiftRuleResponse> DeleteLiveTimeShiftRule(DeleteLiveTimeShiftRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveTimeShiftRuleResponse>(req, "DeleteLiveTimeShiftRule");
        }

        /// <summary>
        /// 删除直播时移规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTimeShiftRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveTimeShiftRuleResponse"/></returns>
        public DeleteLiveTimeShiftRuleResponse DeleteLiveTimeShiftRuleSync(DeleteLiveTimeShiftRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveTimeShiftRuleResponse>(req, "DeleteLiveTimeShiftRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除直播时移模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveTimeShiftTemplateResponse"/></returns>
        public Task<DeleteLiveTimeShiftTemplateResponse> DeleteLiveTimeShiftTemplate(DeleteLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveTimeShiftTemplateResponse>(req, "DeleteLiveTimeShiftTemplate");
        }

        /// <summary>
        /// 删除直播时移模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveTimeShiftTemplateResponse"/></returns>
        public DeleteLiveTimeShiftTemplateResponse DeleteLiveTimeShiftTemplateSync(DeleteLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveTimeShiftTemplateResponse>(req, "DeleteLiveTimeShiftTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除转码规则。
        /// DomainName+AppName+StreamName+TemplateId唯一标识单个转码规则，如需删除需要强匹配。其中TemplateId必填，其余参数为空时也需要传空字符串进行强匹配。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeRuleResponse"/></returns>
        public Task<DeleteLiveTranscodeRuleResponse> DeleteLiveTranscodeRule(DeleteLiveTranscodeRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveTranscodeRuleResponse>(req, "DeleteLiveTranscodeRule");
        }

        /// <summary>
        /// 删除转码规则。
        /// DomainName+AppName+StreamName+TemplateId唯一标识单个转码规则，如需删除需要强匹配。其中TemplateId必填，其余参数为空时也需要传空字符串进行强匹配。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeRuleResponse"/></returns>
        public DeleteLiveTranscodeRuleResponse DeleteLiveTranscodeRuleSync(DeleteLiveTranscodeRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveTranscodeRuleResponse>(req, "DeleteLiveTranscodeRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeTemplateResponse"/></returns>
        public Task<DeleteLiveTranscodeTemplateResponse> DeleteLiveTranscodeTemplate(DeleteLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveTranscodeTemplateResponse>(req, "DeleteLiveTranscodeTemplate");
        }

        /// <summary>
        /// 删除转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveTranscodeTemplateResponse"/></returns>
        public DeleteLiveTranscodeTemplateResponse DeleteLiveTranscodeTemplateSync(DeleteLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveTranscodeTemplateResponse>(req, "DeleteLiveTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除水印。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkResponse"/></returns>
        public Task<DeleteLiveWatermarkResponse> DeleteLiveWatermark(DeleteLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DeleteLiveWatermarkResponse>(req, "DeleteLiveWatermark");
        }

        /// <summary>
        /// 删除水印。
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkResponse"/></returns>
        public DeleteLiveWatermarkResponse DeleteLiveWatermarkSync(DeleteLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DeleteLiveWatermarkResponse>(req, "DeleteLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除水印规则
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkRuleResponse"/></returns>
        public Task<DeleteLiveWatermarkRuleResponse> DeleteLiveWatermarkRule(DeleteLiveWatermarkRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveWatermarkRuleResponse>(req, "DeleteLiveWatermarkRule");
        }

        /// <summary>
        /// 删除水印规则
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveWatermarkRuleRequest"/></param>
        /// <returns><see cref="DeleteLiveWatermarkRuleResponse"/></returns>
        public DeleteLiveWatermarkRuleResponse DeleteLiveWatermarkRuleSync(DeleteLiveWatermarkRuleRequest req)
        {
            return InternalRequestAsync<DeleteLiveWatermarkRuleResponse>(req, "DeleteLiveWatermarkRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除直播拉流配置。该接口已下线,请使用新接口 DeleteLivePullStreamTask。
        /// </summary>
        /// <param name="req"><see cref="DeletePullStreamConfigRequest"/></param>
        /// <returns><see cref="DeletePullStreamConfigResponse"/></returns>
        public Task<DeletePullStreamConfigResponse> DeletePullStreamConfig(DeletePullStreamConfigRequest req)
        {
            return InternalRequestAsync<DeletePullStreamConfigResponse>(req, "DeletePullStreamConfig");
        }

        /// <summary>
        /// 删除直播拉流配置。该接口已下线,请使用新接口 DeleteLivePullStreamTask。
        /// </summary>
        /// <param name="req"><see cref="DeletePullStreamConfigRequest"/></param>
        /// <returns><see cref="DeletePullStreamConfigResponse"/></returns>
        public DeletePullStreamConfigResponse DeletePullStreamConfigSync(DeletePullStreamConfigRequest req)
        {
            return InternalRequestAsync<DeletePullStreamConfigResponse>(req, "DeletePullStreamConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除录制任务配置。删除操作不影响正在运行当中的任务，仅对删除之后新的推流有效。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordTaskResponse"/></returns>
        public Task<DeleteRecordTaskResponse> DeleteRecordTask(DeleteRecordTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordTaskResponse>(req, "DeleteRecordTask");
        }

        /// <summary>
        /// 删除录制任务配置。删除操作不影响正在运行当中的任务，仅对删除之后新的推流有效。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordTaskResponse"/></returns>
        public DeleteRecordTaskResponse DeleteRecordTaskSync(DeleteRecordTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordTaskResponse>(req, "DeleteRecordTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除截图任务配置。删除操作不影响正在运行当中的任务，仅对删除之后新的推流有效。
        /// </summary>
        /// <param name="req"><see cref="DeleteScreenshotTaskRequest"/></param>
        /// <returns><see cref="DeleteScreenshotTaskResponse"/></returns>
        public Task<DeleteScreenshotTaskResponse> DeleteScreenshotTask(DeleteScreenshotTaskRequest req)
        {
            return InternalRequestAsync<DeleteScreenshotTaskResponse>(req, "DeleteScreenshotTask");
        }

        /// <summary>
        /// 删除截图任务配置。删除操作不影响正在运行当中的任务，仅对删除之后新的推流有效。
        /// </summary>
        /// <param name="req"><see cref="DeleteScreenshotTaskRequest"/></param>
        /// <returns><see cref="DeleteScreenshotTaskResponse"/></returns>
        public DeleteScreenshotTaskResponse DeleteScreenshotTaskSync(DeleteScreenshotTaskRequest req)
        {
            return InternalRequestAsync<DeleteScreenshotTaskResponse>(req, "DeleteScreenshotTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 输入某个时间点（1分钟维度），查询该时间点所有流的下行信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeAllStreamPlayInfoListResponse"/></returns>
        public Task<DescribeAllStreamPlayInfoListResponse> DescribeAllStreamPlayInfoList(DescribeAllStreamPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAllStreamPlayInfoListResponse>(req, "DescribeAllStreamPlayInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 输入某个时间点（1分钟维度），查询该时间点所有流的下行信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeAllStreamPlayInfoListResponse"/></returns>
        public DescribeAllStreamPlayInfoListResponse DescribeAllStreamPlayInfoListSync(DescribeAllStreamPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAllStreamPlayInfoListResponse>(req, "DescribeAllStreamPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 海外分区直播播放带宽和流量数据查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaBillBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribeAreaBillBandwidthAndFluxListResponse"/></returns>
        public Task<DescribeAreaBillBandwidthAndFluxListResponse> DescribeAreaBillBandwidthAndFluxList(DescribeAreaBillBandwidthAndFluxListRequest req)
        {
            return InternalRequestAsync<DescribeAreaBillBandwidthAndFluxListResponse>(req, "DescribeAreaBillBandwidthAndFluxList");
        }

        /// <summary>
        /// 海外分区直播播放带宽和流量数据查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaBillBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribeAreaBillBandwidthAndFluxListResponse"/></returns>
        public DescribeAreaBillBandwidthAndFluxListResponse DescribeAreaBillBandwidthAndFluxListSync(DescribeAreaBillBandwidthAndFluxListRequest req)
        {
            return InternalRequestAsync<DescribeAreaBillBandwidthAndFluxListResponse>(req, "DescribeAreaBillBandwidthAndFluxList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回正在直播中的流列表。适用于推流成功后查询在线流信息。
        /// 
        /// 注意：
        /// 1. 该接口仅提供辅助查询在线流列表功能，业务重要场景不可强依赖该接口。
        /// 2. 该接口仅适用于流数少于2万路的情况，对于流数较大用户请联系售后。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStreamListRequest"/></param>
        /// <returns><see cref="DescribeBackupStreamListResponse"/></returns>
        public Task<DescribeBackupStreamListResponse> DescribeBackupStreamList(DescribeBackupStreamListRequest req)
        {
            return InternalRequestAsync<DescribeBackupStreamListResponse>(req, "DescribeBackupStreamList");
        }

        /// <summary>
        /// 返回正在直播中的流列表。适用于推流成功后查询在线流信息。
        /// 
        /// 注意：
        /// 1. 该接口仅提供辅助查询在线流列表功能，业务重要场景不可强依赖该接口。
        /// 2. 该接口仅适用于流数少于2万路的情况，对于流数较大用户请联系售后。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStreamListRequest"/></param>
        /// <returns><see cref="DescribeBackupStreamListResponse"/></returns>
        public DescribeBackupStreamListResponse DescribeBackupStreamListSync(DescribeBackupStreamListRequest req)
        {
            return InternalRequestAsync<DescribeBackupStreamListResponse>(req, "DescribeBackupStreamList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播播放带宽和流量数据查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribeBillBandwidthAndFluxListResponse"/></returns>
        public Task<DescribeBillBandwidthAndFluxListResponse> DescribeBillBandwidthAndFluxList(DescribeBillBandwidthAndFluxListRequest req)
        {
            return InternalRequestAsync<DescribeBillBandwidthAndFluxListResponse>(req, "DescribeBillBandwidthAndFluxList");
        }

        /// <summary>
        /// 直播播放带宽和流量数据查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribeBillBandwidthAndFluxListResponse"/></returns>
        public DescribeBillBandwidthAndFluxListResponse DescribeBillBandwidthAndFluxListSync(DescribeBillBandwidthAndFluxListRequest req)
        {
            return InternalRequestAsync<DescribeBillBandwidthAndFluxListResponse>(req, "DescribeBillBandwidthAndFluxList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 用于查询回调事件。
        /// </summary>
        /// <param name="req"><see cref="DescribeCallbackRecordsListRequest"/></param>
        /// <returns><see cref="DescribeCallbackRecordsListResponse"/></returns>
        public Task<DescribeCallbackRecordsListResponse> DescribeCallbackRecordsList(DescribeCallbackRecordsListRequest req)
        {
            return InternalRequestAsync<DescribeCallbackRecordsListResponse>(req, "DescribeCallbackRecordsList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 用于查询回调事件。
        /// </summary>
        /// <param name="req"><see cref="DescribeCallbackRecordsListRequest"/></param>
        /// <returns><see cref="DescribeCallbackRecordsListResponse"/></returns>
        public DescribeCallbackRecordsListResponse DescribeCallbackRecordsListSync(DescribeCallbackRecordsListRequest req)
        {
            return InternalRequestAsync<DescribeCallbackRecordsListResponse>(req, "DescribeCallbackRecordsList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询并发录制路数，对慢直播和普通直播适用。
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentRecordStreamNumRequest"/></param>
        /// <returns><see cref="DescribeConcurrentRecordStreamNumResponse"/></returns>
        public Task<DescribeConcurrentRecordStreamNumResponse> DescribeConcurrentRecordStreamNum(DescribeConcurrentRecordStreamNumRequest req)
        {
            return InternalRequestAsync<DescribeConcurrentRecordStreamNumResponse>(req, "DescribeConcurrentRecordStreamNum");
        }

        /// <summary>
        /// 查询并发录制路数，对慢直播和普通直播适用。
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentRecordStreamNumRequest"/></param>
        /// <returns><see cref="DescribeConcurrentRecordStreamNumResponse"/></returns>
        public DescribeConcurrentRecordStreamNumResponse DescribeConcurrentRecordStreamNumSync(DescribeConcurrentRecordStreamNumRequest req)
        {
            return InternalRequestAsync<DescribeConcurrentRecordStreamNumResponse>(req, "DescribeConcurrentRecordStreamNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询直播转推计费带宽，查询时间范围最大支持3个月内的数据，时间跨度最长31天。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliverBandwidthListRequest"/></param>
        /// <returns><see cref="DescribeDeliverBandwidthListResponse"/></returns>
        public Task<DescribeDeliverBandwidthListResponse> DescribeDeliverBandwidthList(DescribeDeliverBandwidthListRequest req)
        {
            return InternalRequestAsync<DescribeDeliverBandwidthListResponse>(req, "DescribeDeliverBandwidthList");
        }

        /// <summary>
        /// 查询直播转推计费带宽，查询时间范围最大支持3个月内的数据，时间跨度最长31天。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliverBandwidthListRequest"/></param>
        /// <returns><see cref="DescribeDeliverBandwidthListResponse"/></returns>
        public DescribeDeliverBandwidthListResponse DescribeDeliverBandwidthListSync(DescribeDeliverBandwidthListRequest req)
        {
            return InternalRequestAsync<DescribeDeliverBandwidthListResponse>(req, "DescribeDeliverBandwidthList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取转推日志的URL。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliverLogDownListRequest"/></param>
        /// <returns><see cref="DescribeDeliverLogDownListResponse"/></returns>
        public Task<DescribeDeliverLogDownListResponse> DescribeDeliverLogDownList(DescribeDeliverLogDownListRequest req)
        {
            return InternalRequestAsync<DescribeDeliverLogDownListResponse>(req, "DescribeDeliverLogDownList");
        }

        /// <summary>
        /// 批量获取转推日志的URL。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliverLogDownListRequest"/></param>
        /// <returns><see cref="DescribeDeliverLogDownListResponse"/></returns>
        public DescribeDeliverLogDownListResponse DescribeDeliverLogDownListSync(DescribeDeliverLogDownListRequest req)
        {
            return InternalRequestAsync<DescribeDeliverLogDownListResponse>(req, "DescribeDeliverLogDownList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询按省份和运营商分组的下行播放数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupProIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeGroupProIspPlayInfoListResponse"/></returns>
        public Task<DescribeGroupProIspPlayInfoListResponse> DescribeGroupProIspPlayInfoList(DescribeGroupProIspPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeGroupProIspPlayInfoListResponse>(req, "DescribeGroupProIspPlayInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询按省份和运营商分组的下行播放数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupProIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeGroupProIspPlayInfoListResponse"/></returns>
        public DescribeGroupProIspPlayInfoListResponse DescribeGroupProIspPlayInfoListSync(DescribeGroupProIspPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeGroupProIspPlayInfoListResponse>(req, "DescribeGroupProIspPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询某段时间内5分钟粒度的各播放http状态码的个数。
        /// 备注：数据延迟1小时，如10:00-10:59点的数据12点才能查到。
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpStatusInfoListRequest"/></param>
        /// <returns><see cref="DescribeHttpStatusInfoListResponse"/></returns>
        public Task<DescribeHttpStatusInfoListResponse> DescribeHttpStatusInfoList(DescribeHttpStatusInfoListRequest req)
        {
            return InternalRequestAsync<DescribeHttpStatusInfoListResponse>(req, "DescribeHttpStatusInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询某段时间内5分钟粒度的各播放http状态码的个数。
        /// 备注：数据延迟1小时，如10:00-10:59点的数据12点才能查到。
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpStatusInfoListRequest"/></param>
        /// <returns><see cref="DescribeHttpStatusInfoListResponse"/></returns>
        public DescribeHttpStatusInfoListResponse DescribeHttpStatusInfoListSync(DescribeHttpStatusInfoListRequest req)
        {
            return InternalRequestAsync<DescribeHttpStatusInfoListResponse>(req, "DescribeHttpStatusInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取回调规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackRulesResponse"/></returns>
        public Task<DescribeLiveCallbackRulesResponse> DescribeLiveCallbackRules(DescribeLiveCallbackRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackRulesResponse>(req, "DescribeLiveCallbackRules");
        }

        /// <summary>
        /// 获取回调规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackRulesResponse"/></returns>
        public DescribeLiveCallbackRulesResponse DescribeLiveCallbackRulesSync(DescribeLiveCallbackRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackRulesResponse>(req, "DescribeLiveCallbackRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个回调模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplateResponse"/></returns>
        public Task<DescribeLiveCallbackTemplateResponse> DescribeLiveCallbackTemplate(DescribeLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackTemplateResponse>(req, "DescribeLiveCallbackTemplate");
        }

        /// <summary>
        /// 获取单个回调模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplateResponse"/></returns>
        public DescribeLiveCallbackTemplateResponse DescribeLiveCallbackTemplateSync(DescribeLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackTemplateResponse>(req, "DescribeLiveCallbackTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取回调模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplatesResponse"/></returns>
        public Task<DescribeLiveCallbackTemplatesResponse> DescribeLiveCallbackTemplates(DescribeLiveCallbackTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackTemplatesResponse>(req, "DescribeLiveCallbackTemplates");
        }

        /// <summary>
        /// 获取回调模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCallbackTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveCallbackTemplatesResponse"/></returns>
        public DescribeLiveCallbackTemplatesResponse DescribeLiveCallbackTemplatesSync(DescribeLiveCallbackTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveCallbackTemplatesResponse>(req, "DescribeLiveCallbackTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取证书信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertRequest"/></param>
        /// <returns><see cref="DescribeLiveCertResponse"/></returns>
        public Task<DescribeLiveCertResponse> DescribeLiveCert(DescribeLiveCertRequest req)
        {
            return InternalRequestAsync<DescribeLiveCertResponse>(req, "DescribeLiveCert");
        }

        /// <summary>
        /// 获取证书信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertRequest"/></param>
        /// <returns><see cref="DescribeLiveCertResponse"/></returns>
        public DescribeLiveCertResponse DescribeLiveCertSync(DescribeLiveCertRequest req)
        {
            return InternalRequestAsync<DescribeLiveCertResponse>(req, "DescribeLiveCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取证书信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertsRequest"/></param>
        /// <returns><see cref="DescribeLiveCertsResponse"/></returns>
        public Task<DescribeLiveCertsResponse> DescribeLiveCerts(DescribeLiveCertsRequest req)
        {
            return InternalRequestAsync<DescribeLiveCertsResponse>(req, "DescribeLiveCerts");
        }

        /// <summary>
        /// 获取证书信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveCertsRequest"/></param>
        /// <returns><see cref="DescribeLiveCertsResponse"/></returns>
        public DescribeLiveCertsResponse DescribeLiveCertsSync(DescribeLiveCertsRequest req)
        {
            return InternalRequestAsync<DescribeLiveCertsResponse>(req, "DescribeLiveCerts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播延播列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDelayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDelayInfoListResponse"/></returns>
        public Task<DescribeLiveDelayInfoListResponse> DescribeLiveDelayInfoList(DescribeLiveDelayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveDelayInfoListResponse>(req, "DescribeLiveDelayInfoList");
        }

        /// <summary>
        /// 获取直播延播列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDelayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDelayInfoListResponse"/></returns>
        public DescribeLiveDelayInfoListResponse DescribeLiveDelayInfoListSync(DescribeLiveDelayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveDelayInfoListResponse>(req, "DescribeLiveDelayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询直播域名信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainResponse"/></returns>
        public Task<DescribeLiveDomainResponse> DescribeLiveDomain(DescribeLiveDomainRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainResponse>(req, "DescribeLiveDomain");
        }

        /// <summary>
        /// 查询直播域名信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainResponse"/></returns>
        public DescribeLiveDomainResponse DescribeLiveDomainSync(DescribeLiveDomainRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainResponse>(req, "DescribeLiveDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取域名证书信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainCertRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainCertResponse"/></returns>
        public Task<DescribeLiveDomainCertResponse> DescribeLiveDomainCert(DescribeLiveDomainCertRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainCertResponse>(req, "DescribeLiveDomainCert");
        }

        /// <summary>
        /// 获取域名证书信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainCertRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainCertResponse"/></returns>
        public DescribeLiveDomainCertResponse DescribeLiveDomainCertSync(DescribeLiveDomainCertRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainCertResponse>(req, "DescribeLiveDomainCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询绑定证书的域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainCertBindingsRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainCertBindingsResponse"/></returns>
        public Task<DescribeLiveDomainCertBindingsResponse> DescribeLiveDomainCertBindings(DescribeLiveDomainCertBindingsRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainCertBindingsResponse>(req, "DescribeLiveDomainCertBindings");
        }

        /// <summary>
        /// 查询绑定证书的域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainCertBindingsRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainCertBindingsResponse"/></returns>
        public DescribeLiveDomainCertBindingsResponse DescribeLiveDomainCertBindingsSync(DescribeLiveDomainCertBindingsRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainCertBindingsResponse>(req, "DescribeLiveDomainCertBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询实时的域名维度下行播放数据，由于数据处理有耗时，接口默认查询4分钟前的准实时数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainPlayInfoListResponse"/></returns>
        public Task<DescribeLiveDomainPlayInfoListResponse> DescribeLiveDomainPlayInfoList(DescribeLiveDomainPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainPlayInfoListResponse>(req, "DescribeLiveDomainPlayInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询实时的域名维度下行播放数据，由于数据处理有耗时，接口默认查询4分钟前的准实时数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainPlayInfoListResponse"/></returns>
        public DescribeLiveDomainPlayInfoListResponse DescribeLiveDomainPlayInfoListSync(DescribeLiveDomainPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainPlayInfoListResponse>(req, "DescribeLiveDomainPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询直播域名 Referer 黑白名单配置。
        /// 由于 Referer 信息包含在 http 协议中，在开启配置后，播放协议为 rtmp 或 WebRTC 不会校验 Referer 配置，仍可正常播放。如需配置 Referer 鉴权建议使用 http-flv 或 http-hls 协议播放。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainRefererRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainRefererResponse"/></returns>
        public Task<DescribeLiveDomainRefererResponse> DescribeLiveDomainReferer(DescribeLiveDomainRefererRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainRefererResponse>(req, "DescribeLiveDomainReferer");
        }

        /// <summary>
        /// 查询直播域名 Referer 黑白名单配置。
        /// 由于 Referer 信息包含在 http 协议中，在开启配置后，播放协议为 rtmp 或 WebRTC 不会校验 Referer 配置，仍可正常播放。如需配置 Referer 鉴权建议使用 http-flv 或 http-hls 协议播放。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainRefererRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainRefererResponse"/></returns>
        public DescribeLiveDomainRefererResponse DescribeLiveDomainRefererSync(DescribeLiveDomainRefererRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainRefererResponse>(req, "DescribeLiveDomainReferer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据域名状态、类型等信息查询用户的域名信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainsRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainsResponse"/></returns>
        public Task<DescribeLiveDomainsResponse> DescribeLiveDomains(DescribeLiveDomainsRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainsResponse>(req, "DescribeLiveDomains");
        }

        /// <summary>
        /// 根据域名状态、类型等信息查询用户的域名信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveDomainsRequest"/></param>
        /// <returns><see cref="DescribeLiveDomainsResponse"/></returns>
        public DescribeLiveDomainsResponse DescribeLiveDomainsSync(DescribeLiveDomainsRequest req)
        {
            return InternalRequestAsync<DescribeLiveDomainsResponse>(req, "DescribeLiveDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取禁推流列表。
        /// 
        /// 注意：该接口仅作为直播辅助查询接口，重要业务场景不可强依赖该接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveForbidStreamListRequest"/></param>
        /// <returns><see cref="DescribeLiveForbidStreamListResponse"/></returns>
        public Task<DescribeLiveForbidStreamListResponse> DescribeLiveForbidStreamList(DescribeLiveForbidStreamListRequest req)
        {
            return InternalRequestAsync<DescribeLiveForbidStreamListResponse>(req, "DescribeLiveForbidStreamList");
        }

        /// <summary>
        /// 获取禁推流列表。
        /// 
        /// 注意：该接口仅作为直播辅助查询接口，重要业务场景不可强依赖该接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveForbidStreamListRequest"/></param>
        /// <returns><see cref="DescribeLiveForbidStreamListResponse"/></returns>
        public DescribeLiveForbidStreamListResponse DescribeLiveForbidStreamListSync(DescribeLiveForbidStreamListRequest req)
        {
            return InternalRequestAsync<DescribeLiveForbidStreamListResponse>(req, "DescribeLiveForbidStreamList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户套餐包总量、使用量、剩余量、包状态、购买时间和过期时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePackageInfoRequest"/></param>
        /// <returns><see cref="DescribeLivePackageInfoResponse"/></returns>
        public Task<DescribeLivePackageInfoResponse> DescribeLivePackageInfo(DescribeLivePackageInfoRequest req)
        {
            return InternalRequestAsync<DescribeLivePackageInfoResponse>(req, "DescribeLivePackageInfo");
        }

        /// <summary>
        /// 查询用户套餐包总量、使用量、剩余量、包状态、购买时间和过期时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePackageInfoRequest"/></param>
        /// <returns><see cref="DescribeLivePackageInfoResponse"/></returns>
        public DescribeLivePackageInfoResponse DescribeLivePackageInfoSync(DescribeLivePackageInfoRequest req)
        {
            return InternalRequestAsync<DescribeLivePackageInfoResponse>(req, "DescribeLivePackageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用该接口查询垫片流。垫片流状态更新存在一定延迟，可间隔30秒以上查询，避免频繁查询该接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePadProcessorListRequest"/></param>
        /// <returns><see cref="DescribeLivePadProcessorListResponse"/></returns>
        public Task<DescribeLivePadProcessorListResponse> DescribeLivePadProcessorList(DescribeLivePadProcessorListRequest req)
        {
            return InternalRequestAsync<DescribeLivePadProcessorListResponse>(req, "DescribeLivePadProcessorList");
        }

        /// <summary>
        /// 使用该接口查询垫片流。垫片流状态更新存在一定延迟，可间隔30秒以上查询，避免频繁查询该接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePadProcessorListRequest"/></param>
        /// <returns><see cref="DescribeLivePadProcessorListResponse"/></returns>
        public DescribeLivePadProcessorListResponse DescribeLivePadProcessorListSync(DescribeLivePadProcessorListRequest req)
        {
            return InternalRequestAsync<DescribeLivePadProcessorListResponse>(req, "DescribeLivePadProcessorList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播垫片规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePadRulesRequest"/></param>
        /// <returns><see cref="DescribeLivePadRulesResponse"/></returns>
        public Task<DescribeLivePadRulesResponse> DescribeLivePadRules(DescribeLivePadRulesRequest req)
        {
            return InternalRequestAsync<DescribeLivePadRulesResponse>(req, "DescribeLivePadRules");
        }

        /// <summary>
        /// 获取直播垫片规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePadRulesRequest"/></param>
        /// <returns><see cref="DescribeLivePadRulesResponse"/></returns>
        public DescribeLivePadRulesResponse DescribeLivePadRulesSync(DescribeLivePadRulesRequest req)
        {
            return InternalRequestAsync<DescribeLivePadRulesResponse>(req, "DescribeLivePadRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个直播垫片模板
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePadTemplateRequest"/></param>
        /// <returns><see cref="DescribeLivePadTemplateResponse"/></returns>
        public Task<DescribeLivePadTemplateResponse> DescribeLivePadTemplate(DescribeLivePadTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLivePadTemplateResponse>(req, "DescribeLivePadTemplate");
        }

        /// <summary>
        /// 获取单个直播垫片模板
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePadTemplateRequest"/></param>
        /// <returns><see cref="DescribeLivePadTemplateResponse"/></returns>
        public DescribeLivePadTemplateResponse DescribeLivePadTemplateSync(DescribeLivePadTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLivePadTemplateResponse>(req, "DescribeLivePadTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播垫片模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePadTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLivePadTemplatesResponse"/></returns>
        public Task<DescribeLivePadTemplatesResponse> DescribeLivePadTemplates(DescribeLivePadTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLivePadTemplatesResponse>(req, "DescribeLivePadTemplates");
        }

        /// <summary>
        /// 获取直播垫片模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePadTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLivePadTemplatesResponse"/></returns>
        public DescribeLivePadTemplatesResponse DescribeLivePadTemplatesSync(DescribeLivePadTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLivePadTemplatesResponse>(req, "DescribeLivePadTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询播放鉴权key。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePlayAuthKeyResponse"/></returns>
        public Task<DescribeLivePlayAuthKeyResponse> DescribeLivePlayAuthKey(DescribeLivePlayAuthKeyRequest req)
        {
            return InternalRequestAsync<DescribeLivePlayAuthKeyResponse>(req, "DescribeLivePlayAuthKey");
        }

        /// <summary>
        /// 查询播放鉴权key。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePlayAuthKeyResponse"/></returns>
        public DescribeLivePlayAuthKeyResponse DescribeLivePlayAuthKeySync(DescribeLivePlayAuthKeyRequest req)
        {
            return InternalRequestAsync<DescribeLivePlayAuthKeyResponse>(req, "DescribeLivePlayAuthKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询直播拉流任务状态信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePullStreamTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeLivePullStreamTaskStatusResponse"/></returns>
        public Task<DescribeLivePullStreamTaskStatusResponse> DescribeLivePullStreamTaskStatus(DescribeLivePullStreamTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeLivePullStreamTaskStatusResponse>(req, "DescribeLivePullStreamTaskStatus");
        }

        /// <summary>
        /// 查询直播拉流任务状态信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePullStreamTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeLivePullStreamTaskStatusResponse"/></returns>
        public DescribeLivePullStreamTaskStatusResponse DescribeLivePullStreamTaskStatusSync(DescribeLivePullStreamTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeLivePullStreamTaskStatusResponse>(req, "DescribeLivePullStreamTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询使用 CreateLivePullStreamTask 接口创建的直播拉流任务。
        /// 排序方式：默认按更新时间 倒序排列。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePullStreamTasksRequest"/></param>
        /// <returns><see cref="DescribeLivePullStreamTasksResponse"/></returns>
        public Task<DescribeLivePullStreamTasksResponse> DescribeLivePullStreamTasks(DescribeLivePullStreamTasksRequest req)
        {
            return InternalRequestAsync<DescribeLivePullStreamTasksResponse>(req, "DescribeLivePullStreamTasks");
        }

        /// <summary>
        /// 查询使用 CreateLivePullStreamTask 接口创建的直播拉流任务。
        /// 排序方式：默认按更新时间 倒序排列。
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePullStreamTasksRequest"/></param>
        /// <returns><see cref="DescribeLivePullStreamTasksResponse"/></returns>
        public DescribeLivePullStreamTasksResponse DescribeLivePullStreamTasksSync(DescribeLivePullStreamTasksRequest req)
        {
            return InternalRequestAsync<DescribeLivePullStreamTasksResponse>(req, "DescribeLivePullStreamTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询直播推流鉴权key
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePushAuthKeyResponse"/></returns>
        public Task<DescribeLivePushAuthKeyResponse> DescribeLivePushAuthKey(DescribeLivePushAuthKeyRequest req)
        {
            return InternalRequestAsync<DescribeLivePushAuthKeyResponse>(req, "DescribeLivePushAuthKey");
        }

        /// <summary>
        /// 查询直播推流鉴权key
        /// </summary>
        /// <param name="req"><see cref="DescribeLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="DescribeLivePushAuthKeyResponse"/></returns>
        public DescribeLivePushAuthKeyResponse DescribeLivePushAuthKeySync(DescribeLivePushAuthKeyRequest req)
        {
            return InternalRequestAsync<DescribeLivePushAuthKeyResponse>(req, "DescribeLivePushAuthKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取录制规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordRulesResponse"/></returns>
        public Task<DescribeLiveRecordRulesResponse> DescribeLiveRecordRules(DescribeLiveRecordRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordRulesResponse>(req, "DescribeLiveRecordRules");
        }

        /// <summary>
        /// 获取录制规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordRulesResponse"/></returns>
        public DescribeLiveRecordRulesResponse DescribeLiveRecordRulesSync(DescribeLiveRecordRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordRulesResponse>(req, "DescribeLiveRecordRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个录制模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplateResponse"/></returns>
        public Task<DescribeLiveRecordTemplateResponse> DescribeLiveRecordTemplate(DescribeLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplateResponse>(req, "DescribeLiveRecordTemplate");
        }

        /// <summary>
        /// 获取单个录制模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplateResponse"/></returns>
        public DescribeLiveRecordTemplateResponse DescribeLiveRecordTemplateSync(DescribeLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplateResponse>(req, "DescribeLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取录制模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplatesResponse"/></returns>
        public Task<DescribeLiveRecordTemplatesResponse> DescribeLiveRecordTemplates(DescribeLiveRecordTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplatesResponse>(req, "DescribeLiveRecordTemplates");
        }

        /// <summary>
        /// 获取录制模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplatesResponse"/></returns>
        public DescribeLiveRecordTemplatesResponse DescribeLiveRecordTemplatesSync(DescribeLiveRecordTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplatesResponse>(req, "DescribeLiveRecordTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取截图规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotRulesResponse"/></returns>
        public Task<DescribeLiveSnapshotRulesResponse> DescribeLiveSnapshotRules(DescribeLiveSnapshotRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotRulesResponse>(req, "DescribeLiveSnapshotRules");
        }

        /// <summary>
        /// 获取截图规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotRulesResponse"/></returns>
        public DescribeLiveSnapshotRulesResponse DescribeLiveSnapshotRulesSync(DescribeLiveSnapshotRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotRulesResponse>(req, "DescribeLiveSnapshotRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个截图模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplateResponse"/></returns>
        public Task<DescribeLiveSnapshotTemplateResponse> DescribeLiveSnapshotTemplate(DescribeLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotTemplateResponse>(req, "DescribeLiveSnapshotTemplate");
        }

        /// <summary>
        /// 获取单个截图模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplateResponse"/></returns>
        public DescribeLiveSnapshotTemplateResponse DescribeLiveSnapshotTemplateSync(DescribeLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotTemplateResponse>(req, "DescribeLiveSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取截图模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplatesResponse"/></returns>
        public Task<DescribeLiveSnapshotTemplatesResponse> DescribeLiveSnapshotTemplates(DescribeLiveSnapshotTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotTemplatesResponse>(req, "DescribeLiveSnapshotTemplates");
        }

        /// <summary>
        /// 获取截图模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveSnapshotTemplatesResponse"/></returns>
        public DescribeLiveSnapshotTemplatesResponse DescribeLiveSnapshotTemplatesSync(DescribeLiveSnapshotTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveSnapshotTemplatesResponse>(req, "DescribeLiveSnapshotTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询推断流事件。<br>
        /// 
        /// 注意：
        /// 1. 该接口提供离线推断流记录查询功能，不可作为重要业务场景强依赖接口。
        /// 2. 该接口可通过使用IsFilter进行过滤，返回推流历史记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamEventListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamEventListResponse"/></returns>
        public Task<DescribeLiveStreamEventListResponse> DescribeLiveStreamEventList(DescribeLiveStreamEventListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamEventListResponse>(req, "DescribeLiveStreamEventList");
        }

        /// <summary>
        /// 用于查询推断流事件。<br>
        /// 
        /// 注意：
        /// 1. 该接口提供离线推断流记录查询功能，不可作为重要业务场景强依赖接口。
        /// 2. 该接口可通过使用IsFilter进行过滤，返回推流历史记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamEventListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamEventListResponse"/></returns>
        public DescribeLiveStreamEventListResponse DescribeLiveStreamEventListSync(DescribeLiveStreamEventListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamEventListResponse>(req, "DescribeLiveStreamEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用来查询某个特定监播任务的配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamMonitorResponse"/></returns>
        public Task<DescribeLiveStreamMonitorResponse> DescribeLiveStreamMonitor(DescribeLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamMonitorResponse>(req, "DescribeLiveStreamMonitor");
        }

        /// <summary>
        /// 该接口用来查询某个特定监播任务的配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamMonitorResponse"/></returns>
        public DescribeLiveStreamMonitorResponse DescribeLiveStreamMonitorSync(DescribeLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamMonitorResponse>(req, "DescribeLiveStreamMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用来查询直播流监播任务配置的列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamMonitorListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamMonitorListResponse"/></returns>
        public Task<DescribeLiveStreamMonitorListResponse> DescribeLiveStreamMonitorList(DescribeLiveStreamMonitorListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamMonitorListResponse>(req, "DescribeLiveStreamMonitorList");
        }

        /// <summary>
        /// 该接口用来查询直播流监播任务配置的列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamMonitorListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamMonitorListResponse"/></returns>
        public DescribeLiveStreamMonitorListResponse DescribeLiveStreamMonitorListSync(DescribeLiveStreamMonitorListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamMonitorListResponse>(req, "DescribeLiveStreamMonitorList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回正在直播中的流列表。适用于推流成功后查询在线流信息。
        /// 
        /// 注意：
        /// 1. 该接口仅提供辅助查询在线流列表功能，业务重要场景不可强依赖该接口。
        /// 2. 该接口仅适用于流数少于2万路的情况，对于流数较大用户请联系售后。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamOnlineListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamOnlineListResponse"/></returns>
        public Task<DescribeLiveStreamOnlineListResponse> DescribeLiveStreamOnlineList(DescribeLiveStreamOnlineListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamOnlineListResponse>(req, "DescribeLiveStreamOnlineList");
        }

        /// <summary>
        /// 返回正在直播中的流列表。适用于推流成功后查询在线流信息。
        /// 
        /// 注意：
        /// 1. 该接口仅提供辅助查询在线流列表功能，业务重要场景不可强依赖该接口。
        /// 2. 该接口仅适用于流数少于2万路的情况，对于流数较大用户请联系售后。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamOnlineListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamOnlineListResponse"/></returns>
        public DescribeLiveStreamOnlineListResponse DescribeLiveStreamOnlineListSync(DescribeLiveStreamOnlineListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamOnlineListResponse>(req, "DescribeLiveStreamOnlineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回已经推过流的流列表。<br>
        /// 注意：分页最多支持查询1万条记录，可通过调整查询时间范围来获取更多数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPublishedListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPublishedListResponse"/></returns>
        public Task<DescribeLiveStreamPublishedListResponse> DescribeLiveStreamPublishedList(DescribeLiveStreamPublishedListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamPublishedListResponse>(req, "DescribeLiveStreamPublishedList");
        }

        /// <summary>
        /// 返回已经推过流的流列表。<br>
        /// 注意：分页最多支持查询1万条记录，可通过调整查询时间范围来获取更多数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPublishedListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPublishedListResponse"/></returns>
        public DescribeLiveStreamPublishedListResponse DescribeLiveStreamPublishedListSync(DescribeLiveStreamPublishedListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamPublishedListResponse>(req, "DescribeLiveStreamPublishedList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询所有实时流的推流信息，包括客户端IP，服务端IP，帧率，码率，域名，开始推流时间。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPushInfoListResponse"/></returns>
        public Task<DescribeLiveStreamPushInfoListResponse> DescribeLiveStreamPushInfoList(DescribeLiveStreamPushInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamPushInfoListResponse>(req, "DescribeLiveStreamPushInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询所有实时流的推流信息，包括客户端IP，服务端IP，帧率，码率，域名，开始推流时间。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamPushInfoListResponse"/></returns>
        public DescribeLiveStreamPushInfoListResponse DescribeLiveStreamPushInfoListSync(DescribeLiveStreamPushInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamPushInfoListResponse>(req, "DescribeLiveStreamPushInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回直播中、无推流或者禁播等状态。
        /// 
        /// 使用建议：
        /// 该接口提供实时流状态查询功能，鉴于网络抖动等一些不可抗因素，使用该接口作为判断主播是否开播等重要业务场景时，请参考以下使用建议。
        /// 1. 优先使用业务自身的房间开关播逻辑，判断主播是否在线，譬如客户端开播信令和主播在线心跳等。
        /// 2. 对于没有房间管理的直播场景，可以结合以下方案综合判断。
        /// 2.1 根据[推断流事件通知](/document/product/267/20388) 判断主播在线状态。
        /// 2.2 通过定时（间隔>1min）查询[直播中的流接口](/document/api/267/20472)，判断主播是否在线。
        /// 2.3 通过 本接口 查询直播流状态，判断主播是否在线。
        /// 2.4 以上任一方式判断为在线，都认为主播开播中，并且接口查询超时或解析异常时，也默认为在线，减少对业务的影响。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamStateRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamStateResponse"/></returns>
        public Task<DescribeLiveStreamStateResponse> DescribeLiveStreamState(DescribeLiveStreamStateRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamStateResponse>(req, "DescribeLiveStreamState");
        }

        /// <summary>
        /// 返回直播中、无推流或者禁播等状态。
        /// 
        /// 使用建议：
        /// 该接口提供实时流状态查询功能，鉴于网络抖动等一些不可抗因素，使用该接口作为判断主播是否开播等重要业务场景时，请参考以下使用建议。
        /// 1. 优先使用业务自身的房间开关播逻辑，判断主播是否在线，譬如客户端开播信令和主播在线心跳等。
        /// 2. 对于没有房间管理的直播场景，可以结合以下方案综合判断。
        /// 2.1 根据[推断流事件通知](/document/product/267/20388) 判断主播在线状态。
        /// 2.2 通过定时（间隔>1min）查询[直播中的流接口](/document/api/267/20472)，判断主播是否在线。
        /// 2.3 通过 本接口 查询直播流状态，判断主播是否在线。
        /// 2.4 以上任一方式判断为在线，都认为主播开播中，并且接口查询超时或解析异常时，也默认为在线，减少对业务的影响。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamStateRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamStateResponse"/></returns>
        public DescribeLiveStreamStateResponse DescribeLiveStreamStateSync(DescribeLiveStreamStateRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamStateResponse>(req, "DescribeLiveStreamState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供给客户对账，按天统计，维度：推流域名、时移文件时长（累加）、配置天数（不累加）、时移总时长（累加）。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftBillInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftBillInfoListResponse"/></returns>
        public Task<DescribeLiveTimeShiftBillInfoListResponse> DescribeLiveTimeShiftBillInfoList(DescribeLiveTimeShiftBillInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftBillInfoListResponse>(req, "DescribeLiveTimeShiftBillInfoList");
        }

        /// <summary>
        /// 提供给客户对账，按天统计，维度：推流域名、时移文件时长（累加）、配置天数（不累加）、时移总时长（累加）。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftBillInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftBillInfoListResponse"/></returns>
        public DescribeLiveTimeShiftBillInfoListResponse DescribeLiveTimeShiftBillInfoListSync(DescribeLiveTimeShiftBillInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftBillInfoListResponse>(req, "DescribeLiveTimeShiftBillInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播时移规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftRulesResponse"/></returns>
        public Task<DescribeLiveTimeShiftRulesResponse> DescribeLiveTimeShiftRules(DescribeLiveTimeShiftRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftRulesResponse>(req, "DescribeLiveTimeShiftRules");
        }

        /// <summary>
        /// 获取直播时移规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftRulesResponse"/></returns>
        public DescribeLiveTimeShiftRulesResponse DescribeLiveTimeShiftRulesSync(DescribeLiveTimeShiftRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftRulesResponse>(req, "DescribeLiveTimeShiftRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播时移模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftTemplatesResponse"/></returns>
        public Task<DescribeLiveTimeShiftTemplatesResponse> DescribeLiveTimeShiftTemplates(DescribeLiveTimeShiftTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftTemplatesResponse>(req, "DescribeLiveTimeShiftTemplates");
        }

        /// <summary>
        /// 获取直播时移模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTimeShiftTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveTimeShiftTemplatesResponse"/></returns>
        public DescribeLiveTimeShiftTemplatesResponse DescribeLiveTimeShiftTemplatesSync(DescribeLiveTimeShiftTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTimeShiftTemplatesResponse>(req, "DescribeLiveTimeShiftTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 支持查询某天或某段时间的转码详细信息。由于转码数据量较大，如果查询时间跨度太长可能会拉不到数据，可以尝试将查询时间范围缩小些再重试。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeDetailInfoResponse"/></returns>
        public Task<DescribeLiveTranscodeDetailInfoResponse> DescribeLiveTranscodeDetailInfo(DescribeLiveTranscodeDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeDetailInfoResponse>(req, "DescribeLiveTranscodeDetailInfo");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 支持查询某天或某段时间的转码详细信息。由于转码数据量较大，如果查询时间跨度太长可能会拉不到数据，可以尝试将查询时间范围缩小些再重试。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeDetailInfoResponse"/></returns>
        public DescribeLiveTranscodeDetailInfoResponse DescribeLiveTranscodeDetailInfoSync(DescribeLiveTranscodeDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeDetailInfoResponse>(req, "DescribeLiveTranscodeDetailInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取转码规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeRulesResponse"/></returns>
        public Task<DescribeLiveTranscodeRulesResponse> DescribeLiveTranscodeRules(DescribeLiveTranscodeRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeRulesResponse>(req, "DescribeLiveTranscodeRules");
        }

        /// <summary>
        /// 获取转码规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeRulesResponse"/></returns>
        public DescribeLiveTranscodeRulesResponse DescribeLiveTranscodeRulesSync(DescribeLiveTranscodeRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeRulesResponse>(req, "DescribeLiveTranscodeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个转码模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplateResponse"/></returns>
        public Task<DescribeLiveTranscodeTemplateResponse> DescribeLiveTranscodeTemplate(DescribeLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTemplateResponse>(req, "DescribeLiveTranscodeTemplate");
        }

        /// <summary>
        /// 获取单个转码模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplateResponse"/></returns>
        public DescribeLiveTranscodeTemplateResponse DescribeLiveTranscodeTemplateSync(DescribeLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTemplateResponse>(req, "DescribeLiveTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取转码模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplatesResponse"/></returns>
        public Task<DescribeLiveTranscodeTemplatesResponse> DescribeLiveTranscodeTemplates(DescribeLiveTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTemplatesResponse>(req, "DescribeLiveTranscodeTemplates");
        }

        /// <summary>
        /// 获取转码模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTemplatesResponse"/></returns>
        public DescribeLiveTranscodeTemplatesResponse DescribeLiveTranscodeTemplatesSync(DescribeLiveTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTemplatesResponse>(req, "DescribeLiveTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询转码总量数据，可查询近三个月内的数据。
        /// 注意：
        /// 如果是查询某一天内，则返回5分钟粒度数据；
        /// 如果是查询跨天或指定域名， 则返回1小时粒度数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTotalInfoRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTotalInfoResponse"/></returns>
        public Task<DescribeLiveTranscodeTotalInfoResponse> DescribeLiveTranscodeTotalInfo(DescribeLiveTranscodeTotalInfoRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTotalInfoResponse>(req, "DescribeLiveTranscodeTotalInfo");
        }

        /// <summary>
        /// 查询转码总量数据，可查询近三个月内的数据。
        /// 注意：
        /// 如果是查询某一天内，则返回5分钟粒度数据；
        /// 如果是查询跨天或指定域名， 则返回1小时粒度数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveTranscodeTotalInfoRequest"/></param>
        /// <returns><see cref="DescribeLiveTranscodeTotalInfoResponse"/></returns>
        public DescribeLiveTranscodeTotalInfoResponse DescribeLiveTranscodeTotalInfoSync(DescribeLiveTranscodeTotalInfoRequest req)
        {
            return InternalRequestAsync<DescribeLiveTranscodeTotalInfoResponse>(req, "DescribeLiveTranscodeTotalInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个水印信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkResponse"/></returns>
        public Task<DescribeLiveWatermarkResponse> DescribeLiveWatermark(DescribeLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarkResponse>(req, "DescribeLiveWatermark");
        }

        /// <summary>
        /// 获取单个水印信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkResponse"/></returns>
        public DescribeLiveWatermarkResponse DescribeLiveWatermarkSync(DescribeLiveWatermarkRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarkResponse>(req, "DescribeLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取水印规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkRulesResponse"/></returns>
        public Task<DescribeLiveWatermarkRulesResponse> DescribeLiveWatermarkRules(DescribeLiveWatermarkRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarkRulesResponse>(req, "DescribeLiveWatermarkRules");
        }

        /// <summary>
        /// 获取水印规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarkRulesRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarkRulesResponse"/></returns>
        public DescribeLiveWatermarkRulesResponse DescribeLiveWatermarkRulesSync(DescribeLiveWatermarkRulesRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarkRulesResponse>(req, "DescribeLiveWatermarkRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询水印列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarksRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarksResponse"/></returns>
        public Task<DescribeLiveWatermarksResponse> DescribeLiveWatermarks(DescribeLiveWatermarksRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarksResponse>(req, "DescribeLiveWatermarks");
        }

        /// <summary>
        /// 查询水印列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveWatermarksRequest"/></param>
        /// <returns><see cref="DescribeLiveWatermarksResponse"/></returns>
        public DescribeLiveWatermarksResponse DescribeLiveWatermarksSync(DescribeLiveWatermarksRequest req)
        {
            return InternalRequestAsync<DescribeLiveWatermarksResponse>(req, "DescribeLiveWatermarks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// P2P流数据查询接口，用来获取流量、卡播和起播信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveXP2PDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveXP2PDetailInfoListResponse"/></returns>
        public Task<DescribeLiveXP2PDetailInfoListResponse> DescribeLiveXP2PDetailInfoList(DescribeLiveXP2PDetailInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveXP2PDetailInfoListResponse>(req, "DescribeLiveXP2PDetailInfoList");
        }

        /// <summary>
        /// P2P流数据查询接口，用来获取流量、卡播和起播信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveXP2PDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribeLiveXP2PDetailInfoListResponse"/></returns>
        public DescribeLiveXP2PDetailInfoListResponse DescribeLiveXP2PDetailInfoListSync(DescribeLiveXP2PDetailInfoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveXP2PDetailInfoListResponse>(req, "DescribeLiveXP2PDetailInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取日志URL。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogDownloadListRequest"/></param>
        /// <returns><see cref="DescribeLogDownloadListResponse"/></returns>
        public Task<DescribeLogDownloadListResponse> DescribeLogDownloadList(DescribeLogDownloadListRequest req)
        {
            return InternalRequestAsync<DescribeLogDownloadListResponse>(req, "DescribeLogDownloadList");
        }

        /// <summary>
        /// 批量获取日志URL。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogDownloadListRequest"/></param>
        /// <returns><see cref="DescribeLogDownloadListResponse"/></returns>
        public DescribeLogDownloadListResponse DescribeLogDownloadListSync(DescribeLogDownloadListRequest req)
        {
            return InternalRequestAsync<DescribeLogDownloadListResponse>(req, "DescribeLogDownloadList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用来查询监播场次7天内的智能识别、断流、低帧率等信息的汇总报告。
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorReportRequest"/></param>
        /// <returns><see cref="DescribeMonitorReportResponse"/></returns>
        public Task<DescribeMonitorReportResponse> DescribeMonitorReport(DescribeMonitorReportRequest req)
        {
            return InternalRequestAsync<DescribeMonitorReportResponse>(req, "DescribeMonitorReport");
        }

        /// <summary>
        /// 用来查询监播场次7天内的智能识别、断流、低帧率等信息的汇总报告。
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorReportRequest"/></param>
        /// <returns><see cref="DescribeMonitorReportResponse"/></returns>
        public DescribeMonitorReportResponse DescribeMonitorReportSync(DescribeMonitorReportRequest req)
        {
            return InternalRequestAsync<DescribeMonitorReportResponse>(req, "DescribeMonitorReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询下行播放错误码信息，某段时间内1分钟粒度的各http错误码出现的次数，包括4xx，5xx。
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeDetailInfoListResponse"/></returns>
        public Task<DescribePlayErrorCodeDetailInfoListResponse> DescribePlayErrorCodeDetailInfoList(DescribePlayErrorCodeDetailInfoListRequest req)
        {
            return InternalRequestAsync<DescribePlayErrorCodeDetailInfoListResponse>(req, "DescribePlayErrorCodeDetailInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询下行播放错误码信息，某段时间内1分钟粒度的各http错误码出现的次数，包括4xx，5xx。
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeDetailInfoListResponse"/></returns>
        public DescribePlayErrorCodeDetailInfoListResponse DescribePlayErrorCodeDetailInfoListSync(DescribePlayErrorCodeDetailInfoListRequest req)
        {
            return InternalRequestAsync<DescribePlayErrorCodeDetailInfoListResponse>(req, "DescribePlayErrorCodeDetailInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询下行播放错误码信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeSumInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeSumInfoListResponse"/></returns>
        public Task<DescribePlayErrorCodeSumInfoListResponse> DescribePlayErrorCodeSumInfoList(DescribePlayErrorCodeSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribePlayErrorCodeSumInfoListResponse>(req, "DescribePlayErrorCodeSumInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询下行播放错误码信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePlayErrorCodeSumInfoListRequest"/></param>
        /// <returns><see cref="DescribePlayErrorCodeSumInfoListResponse"/></returns>
        public DescribePlayErrorCodeSumInfoListResponse DescribePlayErrorCodeSumInfoListSync(DescribePlayErrorCodeSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribePlayErrorCodeSumInfoListResponse>(req, "DescribePlayErrorCodeSumInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询某段时间内每个国家地区每个省份每个运营商的平均每秒流量，总流量，总请求数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProIspPlaySumInfoListRequest"/></param>
        /// <returns><see cref="DescribeProIspPlaySumInfoListResponse"/></returns>
        public Task<DescribeProIspPlaySumInfoListResponse> DescribeProIspPlaySumInfoList(DescribeProIspPlaySumInfoListRequest req)
        {
            return InternalRequestAsync<DescribeProIspPlaySumInfoListResponse>(req, "DescribeProIspPlaySumInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询某段时间内每个国家地区每个省份每个运营商的平均每秒流量，总流量，总请求数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProIspPlaySumInfoListRequest"/></param>
        /// <returns><see cref="DescribeProIspPlaySumInfoListResponse"/></returns>
        public DescribeProIspPlaySumInfoListResponse DescribeProIspPlaySumInfoListSync(DescribeProIspPlaySumInfoListRequest req)
        {
            return InternalRequestAsync<DescribeProIspPlaySumInfoListResponse>(req, "DescribeProIspPlaySumInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询某省份某运营商下行播放数据，包括带宽，流量，请求数，并发连接数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProvinceIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeProvinceIspPlayInfoListResponse"/></returns>
        public Task<DescribeProvinceIspPlayInfoListResponse> DescribeProvinceIspPlayInfoList(DescribeProvinceIspPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeProvinceIspPlayInfoListResponse>(req, "DescribeProvinceIspPlayInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询某省份某运营商下行播放数据，包括带宽，流量，请求数，并发连接数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProvinceIspPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeProvinceIspPlayInfoListResponse"/></returns>
        public DescribeProvinceIspPlayInfoListResponse DescribeProvinceIspPlayInfoListSync(DescribeProvinceIspPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeProvinceIspPlayInfoListResponse>(req, "DescribeProvinceIspPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询直播拉流配置。该接口已下线,请使用新接口 DescribeLivePullStreamTasks。
        /// </summary>
        /// <param name="req"><see cref="DescribePullStreamConfigsRequest"/></param>
        /// <returns><see cref="DescribePullStreamConfigsResponse"/></returns>
        public Task<DescribePullStreamConfigsResponse> DescribePullStreamConfigs(DescribePullStreamConfigsRequest req)
        {
            return InternalRequestAsync<DescribePullStreamConfigsResponse>(req, "DescribePullStreamConfigs");
        }

        /// <summary>
        /// 查询直播拉流配置。该接口已下线,请使用新接口 DescribeLivePullStreamTasks。
        /// </summary>
        /// <param name="req"><see cref="DescribePullStreamConfigsRequest"/></param>
        /// <returns><see cref="DescribePullStreamConfigsResponse"/></returns>
        public DescribePullStreamConfigsResponse DescribePullStreamConfigsSync(DescribePullStreamConfigsRequest req)
        {
            return InternalRequestAsync<DescribePullStreamConfigsResponse>(req, "DescribePullStreamConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询拉流转推任务的时长信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePullTransformPushInfoRequest"/></param>
        /// <returns><see cref="DescribePullTransformPushInfoResponse"/></returns>
        public Task<DescribePullTransformPushInfoResponse> DescribePullTransformPushInfo(DescribePullTransformPushInfoRequest req)
        {
            return InternalRequestAsync<DescribePullTransformPushInfoResponse>(req, "DescribePullTransformPushInfo");
        }

        /// <summary>
        /// 查询拉流转推任务的时长信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePullTransformPushInfoRequest"/></param>
        /// <returns><see cref="DescribePullTransformPushInfoResponse"/></returns>
        public DescribePullTransformPushInfoResponse DescribePullTransformPushInfoSync(DescribePullTransformPushInfoRequest req)
        {
            return InternalRequestAsync<DescribePullTransformPushInfoResponse>(req, "DescribePullTransformPushInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播推流带宽和流量数据查询。
        /// 推流计费会先取全球推流用量和全球播放用量进行比较，满足计费条件后再按各地区用量出账。详情参见[计费文档](https://cloud.tencent.com/document/product/267/34175)。
        /// </summary>
        /// <param name="req"><see cref="DescribePushBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribePushBandwidthAndFluxListResponse"/></returns>
        public Task<DescribePushBandwidthAndFluxListResponse> DescribePushBandwidthAndFluxList(DescribePushBandwidthAndFluxListRequest req)
        {
            return InternalRequestAsync<DescribePushBandwidthAndFluxListResponse>(req, "DescribePushBandwidthAndFluxList");
        }

        /// <summary>
        /// 直播推流带宽和流量数据查询。
        /// 推流计费会先取全球推流用量和全球播放用量进行比较，满足计费条件后再按各地区用量出账。详情参见[计费文档](https://cloud.tencent.com/document/product/267/34175)。
        /// </summary>
        /// <param name="req"><see cref="DescribePushBandwidthAndFluxListRequest"/></param>
        /// <returns><see cref="DescribePushBandwidthAndFluxListResponse"/></returns>
        public DescribePushBandwidthAndFluxListResponse DescribePushBandwidthAndFluxListSync(DescribePushBandwidthAndFluxListRequest req)
        {
            return InternalRequestAsync<DescribePushBandwidthAndFluxListResponse>(req, "DescribePushBandwidthAndFluxList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定时间段范围内启动和结束的录制任务列表。
        /// - 使用前提
        /// 1. 仅用于查询由 CreateRecordTask 接口创建的录制任务。
        /// 2. 不能查询被 DeleteRecordTask 接口删除以及已过期（平台侧保留3个月）的录制任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordTaskResponse"/></returns>
        public Task<DescribeRecordTaskResponse> DescribeRecordTask(DescribeRecordTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordTaskResponse>(req, "DescribeRecordTask");
        }

        /// <summary>
        /// 查询指定时间段范围内启动和结束的录制任务列表。
        /// - 使用前提
        /// 1. 仅用于查询由 CreateRecordTask 接口创建的录制任务。
        /// 2. 不能查询被 DeleteRecordTask 接口删除以及已过期（平台侧保留3个月）的录制任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordTaskResponse"/></returns>
        public DescribeRecordTaskResponse DescribeRecordTaskSync(DescribeRecordTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordTaskResponse>(req, "DescribeRecordTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用来查询直播增值业务--截图的张数
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenShotSheetNumListRequest"/></param>
        /// <returns><see cref="DescribeScreenShotSheetNumListResponse"/></returns>
        public Task<DescribeScreenShotSheetNumListResponse> DescribeScreenShotSheetNumList(DescribeScreenShotSheetNumListRequest req)
        {
            return InternalRequestAsync<DescribeScreenShotSheetNumListResponse>(req, "DescribeScreenShotSheetNumList");
        }

        /// <summary>
        /// 接口用来查询直播增值业务--截图的张数
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenShotSheetNumListRequest"/></param>
        /// <returns><see cref="DescribeScreenShotSheetNumListResponse"/></returns>
        public DescribeScreenShotSheetNumListResponse DescribeScreenShotSheetNumListSync(DescribeScreenShotSheetNumListRequest req)
        {
            return InternalRequestAsync<DescribeScreenShotSheetNumListResponse>(req, "DescribeScreenShotSheetNumList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定时间段范围内启动和结束的截图任务列表。
        /// - 使用前提
        /// 1. 仅用于查询由 CreateScreenshotTask接口创建的截图任务。
        /// 2. 不能查询被 DeleteScreenshotTask接口删除以及已过期（平台侧保留3个月）的截图任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenshotTaskRequest"/></param>
        /// <returns><see cref="DescribeScreenshotTaskResponse"/></returns>
        public Task<DescribeScreenshotTaskResponse> DescribeScreenshotTask(DescribeScreenshotTaskRequest req)
        {
            return InternalRequestAsync<DescribeScreenshotTaskResponse>(req, "DescribeScreenshotTask");
        }

        /// <summary>
        /// 查询指定时间段范围内启动和结束的截图任务列表。
        /// - 使用前提
        /// 1. 仅用于查询由 CreateScreenshotTask接口创建的截图任务。
        /// 2. 不能查询被 DeleteScreenshotTask接口删除以及已过期（平台侧保留3个月）的截图任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenshotTaskRequest"/></param>
        /// <returns><see cref="DescribeScreenshotTaskResponse"/></returns>
        public DescribeScreenshotTaskResponse DescribeScreenshotTaskSync(DescribeScreenshotTaskRequest req)
        {
            return InternalRequestAsync<DescribeScreenshotTaskResponse>(req, "DescribeScreenshotTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询天维度每条流的播放数据，包括总流量等。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamDayPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamDayPlayInfoListResponse"/></returns>
        public Task<DescribeStreamDayPlayInfoListResponse> DescribeStreamDayPlayInfoList(DescribeStreamDayPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamDayPlayInfoListResponse>(req, "DescribeStreamDayPlayInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询天维度每条流的播放数据，包括总流量等。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamDayPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamDayPlayInfoListResponse"/></returns>
        public DescribeStreamDayPlayInfoListResponse DescribeStreamDayPlayInfoListSync(DescribeStreamDayPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamDayPlayInfoListResponse>(req, "DescribeStreamDayPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询播放数据，支持按流名称查询详细播放数据，也可按播放域名查询详细总数据，数据延迟4分钟左右。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPlayInfoListResponse"/></returns>
        public Task<DescribeStreamPlayInfoListResponse> DescribeStreamPlayInfoList(DescribeStreamPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamPlayInfoListResponse>(req, "DescribeStreamPlayInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询播放数据，支持按流名称查询详细播放数据，也可按播放域名查询详细总数据，数据延迟4分钟左右。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPlayInfoListResponse"/></returns>
        public DescribeStreamPlayInfoListResponse DescribeStreamPlayInfoListSync(DescribeStreamPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamPlayInfoListResponse>(req, "DescribeStreamPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询流id的上行推流质量数据，包括音视频的帧率，码率，流逝时间，编码格式等。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPushInfoListResponse"/></returns>
        public Task<DescribeStreamPushInfoListResponse> DescribeStreamPushInfoList(DescribeStreamPushInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamPushInfoListResponse>(req, "DescribeStreamPushInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询流id的上行推流质量数据，包括音视频的帧率，码率，流逝时间，编码格式等。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPushInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPushInfoListResponse"/></returns>
        public DescribeStreamPushInfoListResponse DescribeStreamPushInfoListSync(DescribeStreamPushInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamPushInfoListResponse>(req, "DescribeStreamPushInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 前提调用 DescribeTimeShiftStreamList 获得请求必要参数。查询指定范围内的时移流录制详情，最大支持24小时范围查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeShiftRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeTimeShiftRecordDetailResponse"/></returns>
        public Task<DescribeTimeShiftRecordDetailResponse> DescribeTimeShiftRecordDetail(DescribeTimeShiftRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeTimeShiftRecordDetailResponse>(req, "DescribeTimeShiftRecordDetail");
        }

        /// <summary>
        /// 前提调用 DescribeTimeShiftStreamList 获得请求必要参数。查询指定范围内的时移流录制详情，最大支持24小时范围查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeShiftRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeTimeShiftRecordDetailResponse"/></returns>
        public DescribeTimeShiftRecordDetailResponse DescribeTimeShiftRecordDetailSync(DescribeTimeShiftRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeTimeShiftRecordDetailResponse>(req, "DescribeTimeShiftRecordDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某个时间范围内所有时移流列表。最大支持查询24小时内的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeShiftStreamListRequest"/></param>
        /// <returns><see cref="DescribeTimeShiftStreamListResponse"/></returns>
        public Task<DescribeTimeShiftStreamListResponse> DescribeTimeShiftStreamList(DescribeTimeShiftStreamListRequest req)
        {
            return InternalRequestAsync<DescribeTimeShiftStreamListResponse>(req, "DescribeTimeShiftStreamList");
        }

        /// <summary>
        /// 查询某个时间范围内所有时移流列表。最大支持查询24小时内的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeShiftStreamListRequest"/></param>
        /// <returns><see cref="DescribeTimeShiftStreamListResponse"/></returns>
        public DescribeTimeShiftStreamListResponse DescribeTimeShiftStreamListSync(DescribeTimeShiftStreamListRequest req)
        {
            return InternalRequestAsync<DescribeTimeShiftStreamListResponse>(req, "DescribeTimeShiftStreamList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询某段时间top n客户端ip汇总信息（暂支持top 1000）
        /// </summary>
        /// <param name="req"><see cref="DescribeTopClientIpSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeTopClientIpSumInfoListResponse"/></returns>
        public Task<DescribeTopClientIpSumInfoListResponse> DescribeTopClientIpSumInfoList(DescribeTopClientIpSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribeTopClientIpSumInfoListResponse>(req, "DescribeTopClientIpSumInfoList");
        }

        /// <summary>
        /// 该接口为监控数据接口，数据采集及统计方式与计费数据不同，仅供运营分析使用，不能用于计费对账参考。
        /// 查询某段时间top n客户端ip汇总信息（暂支持top 1000）
        /// </summary>
        /// <param name="req"><see cref="DescribeTopClientIpSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeTopClientIpSumInfoListResponse"/></returns>
        public DescribeTopClientIpSumInfoListResponse DescribeTopClientIpSumInfoListSync(DescribeTopClientIpSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribeTopClientIpSumInfoListResponse>(req, "DescribeTopClientIpSumInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询转码任务数。
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTaskNumRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTaskNumResponse"/></returns>
        public Task<DescribeTranscodeTaskNumResponse> DescribeTranscodeTaskNum(DescribeTranscodeTaskNumRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeTaskNumResponse>(req, "DescribeTranscodeTaskNum");
        }

        /// <summary>
        /// 查询转码任务数。
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTaskNumRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTaskNumResponse"/></returns>
        public DescribeTranscodeTaskNumResponse DescribeTranscodeTaskNumSync(DescribeTranscodeTaskNumRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeTaskNumResponse>(req, "DescribeTranscodeTaskNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播上行路数查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadStreamNumsRequest"/></param>
        /// <returns><see cref="DescribeUploadStreamNumsResponse"/></returns>
        public Task<DescribeUploadStreamNumsResponse> DescribeUploadStreamNums(DescribeUploadStreamNumsRequest req)
        {
            return InternalRequestAsync<DescribeUploadStreamNumsResponse>(req, "DescribeUploadStreamNums");
        }

        /// <summary>
        /// 直播上行路数查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadStreamNumsRequest"/></param>
        /// <returns><see cref="DescribeUploadStreamNumsResponse"/></returns>
        public DescribeUploadStreamNumsResponse DescribeUploadStreamNumsSync(DescribeUploadStreamNumsRequest req)
        {
            return InternalRequestAsync<DescribeUploadStreamNumsResponse>(req, "DescribeUploadStreamNums")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某时间段top n的域名或流id信息（暂支持top 1000）。
        /// </summary>
        /// <param name="req"><see cref="DescribeVisitTopSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeVisitTopSumInfoListResponse"/></returns>
        public Task<DescribeVisitTopSumInfoListResponse> DescribeVisitTopSumInfoList(DescribeVisitTopSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribeVisitTopSumInfoListResponse>(req, "DescribeVisitTopSumInfoList");
        }

        /// <summary>
        /// 查询某时间段top n的域名或流id信息（暂支持top 1000）。
        /// </summary>
        /// <param name="req"><see cref="DescribeVisitTopSumInfoListRequest"/></param>
        /// <returns><see cref="DescribeVisitTopSumInfoListResponse"/></returns>
        public DescribeVisitTopSumInfoListResponse DescribeVisitTopSumInfoListSync(DescribeVisitTopSumInfoListRequest req)
        {
            return InternalRequestAsync<DescribeVisitTopSumInfoListResponse>(req, "DescribeVisitTopSumInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 断开推流连接，但可以重新推流。
        /// 注：对已经不活跃的流，调用该断流接口时，接口返回成功。
        /// </summary>
        /// <param name="req"><see cref="DropLiveStreamRequest"/></param>
        /// <returns><see cref="DropLiveStreamResponse"/></returns>
        public Task<DropLiveStreamResponse> DropLiveStream(DropLiveStreamRequest req)
        {
            return InternalRequestAsync<DropLiveStreamResponse>(req, "DropLiveStream");
        }

        /// <summary>
        /// 断开推流连接，但可以重新推流。
        /// 注：对已经不活跃的流，调用该断流接口时，接口返回成功。
        /// </summary>
        /// <param name="req"><see cref="DropLiveStreamRequest"/></param>
        /// <returns><see cref="DropLiveStreamResponse"/></returns>
        public DropLiveStreamResponse DropLiveStreamSync(DropLiveStreamRequest req)
        {
            return InternalRequestAsync<DropLiveStreamResponse>(req, "DropLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用状态为停用的直播域名。
        /// </summary>
        /// <param name="req"><see cref="EnableLiveDomainRequest"/></param>
        /// <returns><see cref="EnableLiveDomainResponse"/></returns>
        public Task<EnableLiveDomainResponse> EnableLiveDomain(EnableLiveDomainRequest req)
        {
            return InternalRequestAsync<EnableLiveDomainResponse>(req, "EnableLiveDomain");
        }

        /// <summary>
        /// 启用状态为停用的直播域名。
        /// </summary>
        /// <param name="req"><see cref="EnableLiveDomainRequest"/></param>
        /// <returns><see cref="EnableLiveDomainResponse"/></returns>
        public EnableLiveDomainResponse EnableLiveDomainSync(EnableLiveDomainRequest req)
        {
            return InternalRequestAsync<EnableLiveDomainResponse>(req, "EnableLiveDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用择优调度。
        /// 注意：流维度的择优调度，当主备流结束后自动失效。
        /// </summary>
        /// <param name="req"><see cref="EnableOptimalSwitchingRequest"/></param>
        /// <returns><see cref="EnableOptimalSwitchingResponse"/></returns>
        public Task<EnableOptimalSwitchingResponse> EnableOptimalSwitching(EnableOptimalSwitchingRequest req)
        {
            return InternalRequestAsync<EnableOptimalSwitchingResponse>(req, "EnableOptimalSwitching");
        }

        /// <summary>
        /// 启用择优调度。
        /// 注意：流维度的择优调度，当主备流结束后自动失效。
        /// </summary>
        /// <param name="req"><see cref="EnableOptimalSwitchingRequest"/></param>
        /// <returns><see cref="EnableOptimalSwitchingResponse"/></returns>
        public EnableOptimalSwitchingResponse EnableOptimalSwitchingSync(EnableOptimalSwitchingRequest req)
        {
            return InternalRequestAsync<EnableOptimalSwitchingResponse>(req, "EnableOptimalSwitching")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止使用某个直播域名。
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveDomainRequest"/></param>
        /// <returns><see cref="ForbidLiveDomainResponse"/></returns>
        public Task<ForbidLiveDomainResponse> ForbidLiveDomain(ForbidLiveDomainRequest req)
        {
            return InternalRequestAsync<ForbidLiveDomainResponse>(req, "ForbidLiveDomain");
        }

        /// <summary>
        /// 停止使用某个直播域名。
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveDomainRequest"/></param>
        /// <returns><see cref="ForbidLiveDomainResponse"/></returns>
        public ForbidLiveDomainResponse ForbidLiveDomainSync(ForbidLiveDomainRequest req)
        {
            return InternalRequestAsync<ForbidLiveDomainResponse>(req, "ForbidLiveDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁止某条流的推送，可以预设某个时刻将流恢复。
        /// 注意：
        /// 1. 默认只要流名称正确，禁推就会生效。
        /// 2. 如需要推流域名+推流路径+流名称 强匹配生效禁推，需提单联系售后开启配置。
        /// 3. 如果配置了域名分组，需填写准确推流域名，才可断掉当前推流。
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveStreamRequest"/></param>
        /// <returns><see cref="ForbidLiveStreamResponse"/></returns>
        public Task<ForbidLiveStreamResponse> ForbidLiveStream(ForbidLiveStreamRequest req)
        {
            return InternalRequestAsync<ForbidLiveStreamResponse>(req, "ForbidLiveStream");
        }

        /// <summary>
        /// 禁止某条流的推送，可以预设某个时刻将流恢复。
        /// 注意：
        /// 1. 默认只要流名称正确，禁推就会生效。
        /// 2. 如需要推流域名+推流路径+流名称 强匹配生效禁推，需提单联系售后开启配置。
        /// 3. 如果配置了域名分组，需填写准确推流域名，才可断掉当前推流。
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveStreamRequest"/></param>
        /// <returns><see cref="ForbidLiveStreamResponse"/></returns>
        public ForbidLiveStreamResponse ForbidLiveStreamSync(ForbidLiveStreamRequest req)
        {
            return InternalRequestAsync<ForbidLiveStreamResponse>(req, "ForbidLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改回调模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveCallbackTemplateResponse"/></returns>
        public Task<ModifyLiveCallbackTemplateResponse> ModifyLiveCallbackTemplate(ModifyLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveCallbackTemplateResponse>(req, "ModifyLiveCallbackTemplate");
        }

        /// <summary>
        /// 修改回调模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveCallbackTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveCallbackTemplateResponse"/></returns>
        public ModifyLiveCallbackTemplateResponse ModifyLiveCallbackTemplateSync(ModifyLiveCallbackTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveCallbackTemplateResponse>(req, "ModifyLiveCallbackTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量绑定证书对应的播放域名，并更新启用状态。
        /// 新建自有证书将自动上传至腾讯云ssl。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveDomainCertBindingsRequest"/></param>
        /// <returns><see cref="ModifyLiveDomainCertBindingsResponse"/></returns>
        public Task<ModifyLiveDomainCertBindingsResponse> ModifyLiveDomainCertBindings(ModifyLiveDomainCertBindingsRequest req)
        {
            return InternalRequestAsync<ModifyLiveDomainCertBindingsResponse>(req, "ModifyLiveDomainCertBindings");
        }

        /// <summary>
        /// 批量绑定证书对应的播放域名，并更新启用状态。
        /// 新建自有证书将自动上传至腾讯云ssl。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveDomainCertBindingsRequest"/></param>
        /// <returns><see cref="ModifyLiveDomainCertBindingsResponse"/></returns>
        public ModifyLiveDomainCertBindingsResponse ModifyLiveDomainCertBindingsSync(ModifyLiveDomainCertBindingsRequest req)
        {
            return InternalRequestAsync<ModifyLiveDomainCertBindingsResponse>(req, "ModifyLiveDomainCertBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置直播域名 Referer 黑白名单。
        /// 由于 Referer 信息包含在 http 协议中，在开启配置后，播放协议为 rtmp 或 WebRTC 不会校验 Referer 配置，仍可正常播放。如需配置 Referer 鉴权建议使用 http-flv 或 http-hls 协议播放。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveDomainRefererRequest"/></param>
        /// <returns><see cref="ModifyLiveDomainRefererResponse"/></returns>
        public Task<ModifyLiveDomainRefererResponse> ModifyLiveDomainReferer(ModifyLiveDomainRefererRequest req)
        {
            return InternalRequestAsync<ModifyLiveDomainRefererResponse>(req, "ModifyLiveDomainReferer");
        }

        /// <summary>
        /// 设置直播域名 Referer 黑白名单。
        /// 由于 Referer 信息包含在 http 协议中，在开启配置后，播放协议为 rtmp 或 WebRTC 不会校验 Referer 配置，仍可正常播放。如需配置 Referer 鉴权建议使用 http-flv 或 http-hls 协议播放。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveDomainRefererRequest"/></param>
        /// <returns><see cref="ModifyLiveDomainRefererResponse"/></returns>
        public ModifyLiveDomainRefererResponse ModifyLiveDomainRefererSync(ModifyLiveDomainRefererRequest req)
        {
            return InternalRequestAsync<ModifyLiveDomainRefererResponse>(req, "ModifyLiveDomainReferer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改直播垫片模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePadTemplateRequest"/></param>
        /// <returns><see cref="ModifyLivePadTemplateResponse"/></returns>
        public Task<ModifyLivePadTemplateResponse> ModifyLivePadTemplate(ModifyLivePadTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLivePadTemplateResponse>(req, "ModifyLivePadTemplate");
        }

        /// <summary>
        /// 修改直播垫片模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePadTemplateRequest"/></param>
        /// <returns><see cref="ModifyLivePadTemplateResponse"/></returns>
        public ModifyLivePadTemplateResponse ModifyLivePadTemplateSync(ModifyLivePadTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLivePadTemplateResponse>(req, "ModifyLivePadTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改播放鉴权key
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePlayAuthKeyResponse"/></returns>
        public Task<ModifyLivePlayAuthKeyResponse> ModifyLivePlayAuthKey(ModifyLivePlayAuthKeyRequest req)
        {
            return InternalRequestAsync<ModifyLivePlayAuthKeyResponse>(req, "ModifyLivePlayAuthKey");
        }

        /// <summary>
        /// 修改播放鉴权key
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePlayAuthKeyResponse"/></returns>
        public ModifyLivePlayAuthKeyResponse ModifyLivePlayAuthKeySync(ModifyLivePlayAuthKeyRequest req)
        {
            return InternalRequestAsync<ModifyLivePlayAuthKeyResponse>(req, "ModifyLivePlayAuthKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改播放域名信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayDomainRequest"/></param>
        /// <returns><see cref="ModifyLivePlayDomainResponse"/></returns>
        public Task<ModifyLivePlayDomainResponse> ModifyLivePlayDomain(ModifyLivePlayDomainRequest req)
        {
            return InternalRequestAsync<ModifyLivePlayDomainResponse>(req, "ModifyLivePlayDomain");
        }

        /// <summary>
        /// 修改播放域名信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePlayDomainRequest"/></param>
        /// <returns><see cref="ModifyLivePlayDomainResponse"/></returns>
        public ModifyLivePlayDomainResponse ModifyLivePlayDomainSync(ModifyLivePlayDomainRequest req)
        {
            return InternalRequestAsync<ModifyLivePlayDomainResponse>(req, "ModifyLivePlayDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新直播拉流任务。 
        /// 1. 不支持修改拉流源类型，如需更换，请创建新任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="ModifyLivePullStreamTaskResponse"/></returns>
        public Task<ModifyLivePullStreamTaskResponse> ModifyLivePullStreamTask(ModifyLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<ModifyLivePullStreamTaskResponse>(req, "ModifyLivePullStreamTask");
        }

        /// <summary>
        /// 更新直播拉流任务。 
        /// 1. 不支持修改拉流源类型，如需更换，请创建新任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="ModifyLivePullStreamTaskResponse"/></returns>
        public ModifyLivePullStreamTaskResponse ModifyLivePullStreamTaskSync(ModifyLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<ModifyLivePullStreamTaskResponse>(req, "ModifyLivePullStreamTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改直播推流鉴权key
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePushAuthKeyResponse"/></returns>
        public Task<ModifyLivePushAuthKeyResponse> ModifyLivePushAuthKey(ModifyLivePushAuthKeyRequest req)
        {
            return InternalRequestAsync<ModifyLivePushAuthKeyResponse>(req, "ModifyLivePushAuthKey");
        }

        /// <summary>
        /// 修改直播推流鉴权key
        /// </summary>
        /// <param name="req"><see cref="ModifyLivePushAuthKeyRequest"/></param>
        /// <returns><see cref="ModifyLivePushAuthKeyResponse"/></returns>
        public ModifyLivePushAuthKeyResponse ModifyLivePushAuthKeySync(ModifyLivePushAuthKeyRequest req)
        {
            return InternalRequestAsync<ModifyLivePushAuthKeyResponse>(req, "ModifyLivePushAuthKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改录制模板配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordTemplateResponse"/></returns>
        public Task<ModifyLiveRecordTemplateResponse> ModifyLiveRecordTemplate(ModifyLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveRecordTemplateResponse>(req, "ModifyLiveRecordTemplate");
        }

        /// <summary>
        /// 修改录制模板配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordTemplateResponse"/></returns>
        public ModifyLiveRecordTemplateResponse ModifyLiveRecordTemplateSync(ModifyLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveRecordTemplateResponse>(req, "ModifyLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改截图模板配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveSnapshotTemplateResponse"/></returns>
        public Task<ModifyLiveSnapshotTemplateResponse> ModifyLiveSnapshotTemplate(ModifyLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveSnapshotTemplateResponse>(req, "ModifyLiveSnapshotTemplate");
        }

        /// <summary>
        /// 修改截图模板配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveSnapshotTemplateResponse"/></returns>
        public ModifyLiveSnapshotTemplateResponse ModifyLiveSnapshotTemplateSync(ModifyLiveSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveSnapshotTemplateResponse>(req, "ModifyLiveSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用来修改直播流监播任务的配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="ModifyLiveStreamMonitorResponse"/></returns>
        public Task<ModifyLiveStreamMonitorResponse> ModifyLiveStreamMonitor(ModifyLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<ModifyLiveStreamMonitorResponse>(req, "ModifyLiveStreamMonitor");
        }

        /// <summary>
        /// 该接口用来修改直播流监播任务的配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="ModifyLiveStreamMonitorResponse"/></returns>
        public ModifyLiveStreamMonitorResponse ModifyLiveStreamMonitorSync(ModifyLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<ModifyLiveStreamMonitorResponse>(req, "ModifyLiveStreamMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改直播时移模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveTimeShiftTemplateResponse"/></returns>
        public Task<ModifyLiveTimeShiftTemplateResponse> ModifyLiveTimeShiftTemplate(ModifyLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveTimeShiftTemplateResponse>(req, "ModifyLiveTimeShiftTemplate");
        }

        /// <summary>
        /// 修改直播时移模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveTimeShiftTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveTimeShiftTemplateResponse"/></returns>
        public ModifyLiveTimeShiftTemplateResponse ModifyLiveTimeShiftTemplateSync(ModifyLiveTimeShiftTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveTimeShiftTemplateResponse>(req, "ModifyLiveTimeShiftTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改转码模板配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveTranscodeTemplateResponse"/></returns>
        public Task<ModifyLiveTranscodeTemplateResponse> ModifyLiveTranscodeTemplate(ModifyLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveTranscodeTemplateResponse>(req, "ModifyLiveTranscodeTemplate");
        }

        /// <summary>
        /// 修改转码模板配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveTranscodeTemplateResponse"/></returns>
        public ModifyLiveTranscodeTemplateResponse ModifyLiveTranscodeTemplateSync(ModifyLiveTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveTranscodeTemplateResponse>(req, "ModifyLiveTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新拉流配置。该接口为已下线接口，请使用新接口 ModifyLivePullStreamTask。 
        /// </summary>
        /// <param name="req"><see cref="ModifyPullStreamConfigRequest"/></param>
        /// <returns><see cref="ModifyPullStreamConfigResponse"/></returns>
        public Task<ModifyPullStreamConfigResponse> ModifyPullStreamConfig(ModifyPullStreamConfigRequest req)
        {
            return InternalRequestAsync<ModifyPullStreamConfigResponse>(req, "ModifyPullStreamConfig");
        }

        /// <summary>
        /// 更新拉流配置。该接口为已下线接口，请使用新接口 ModifyLivePullStreamTask。 
        /// </summary>
        /// <param name="req"><see cref="ModifyPullStreamConfigRequest"/></param>
        /// <returns><see cref="ModifyPullStreamConfigResponse"/></returns>
        public ModifyPullStreamConfigResponse ModifyPullStreamConfigSync(ModifyPullStreamConfigRequest req)
        {
            return InternalRequestAsync<ModifyPullStreamConfigResponse>(req, "ModifyPullStreamConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改直播拉流配置的状态。该接口已下线,请使用新接口 ModifyLivePullStreamTask。
        /// </summary>
        /// <param name="req"><see cref="ModifyPullStreamStatusRequest"/></param>
        /// <returns><see cref="ModifyPullStreamStatusResponse"/></returns>
        public Task<ModifyPullStreamStatusResponse> ModifyPullStreamStatus(ModifyPullStreamStatusRequest req)
        {
            return InternalRequestAsync<ModifyPullStreamStatusResponse>(req, "ModifyPullStreamStatus");
        }

        /// <summary>
        /// 修改直播拉流配置的状态。该接口已下线,请使用新接口 ModifyLivePullStreamTask。
        /// </summary>
        /// <param name="req"><see cref="ModifyPullStreamStatusRequest"/></param>
        /// <returns><see cref="ModifyPullStreamStatusResponse"/></returns>
        public ModifyPullStreamStatusResponse ModifyPullStreamStatusSync(ModifyPullStreamStatusRequest req)
        {
            return InternalRequestAsync<ModifyPullStreamStatusResponse>(req, "ModifyPullStreamStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将正在运行的拉流转推任务进行重启。
        /// 注意：
        /// 1. 重启任务会造成推流中断。
        /// 2. 点播源任务的重启，会根据VodRefreshType决定是续播还是从头开始播。
        /// </summary>
        /// <param name="req"><see cref="RestartLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="RestartLivePullStreamTaskResponse"/></returns>
        public Task<RestartLivePullStreamTaskResponse> RestartLivePullStreamTask(RestartLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<RestartLivePullStreamTaskResponse>(req, "RestartLivePullStreamTask");
        }

        /// <summary>
        /// 将正在运行的拉流转推任务进行重启。
        /// 注意：
        /// 1. 重启任务会造成推流中断。
        /// 2. 点播源任务的重启，会根据VodRefreshType决定是续播还是从头开始播。
        /// </summary>
        /// <param name="req"><see cref="RestartLivePullStreamTaskRequest"/></param>
        /// <returns><see cref="RestartLivePullStreamTaskResponse"/></returns>
        public RestartLivePullStreamTaskResponse RestartLivePullStreamTaskSync(RestartLivePullStreamTaskRequest req)
        {
            return InternalRequestAsync<RestartLivePullStreamTaskResponse>(req, "RestartLivePullStreamTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消直播流设置的延时配置，恢复实时直播画面。
        /// </summary>
        /// <param name="req"><see cref="ResumeDelayLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeDelayLiveStreamResponse"/></returns>
        public Task<ResumeDelayLiveStreamResponse> ResumeDelayLiveStream(ResumeDelayLiveStreamRequest req)
        {
            return InternalRequestAsync<ResumeDelayLiveStreamResponse>(req, "ResumeDelayLiveStream");
        }

        /// <summary>
        /// 取消直播流设置的延时配置，恢复实时直播画面。
        /// </summary>
        /// <param name="req"><see cref="ResumeDelayLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeDelayLiveStreamResponse"/></returns>
        public ResumeDelayLiveStreamResponse ResumeDelayLiveStreamSync(ResumeDelayLiveStreamRequest req)
        {
            return InternalRequestAsync<ResumeDelayLiveStreamResponse>(req, "ResumeDelayLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复某条流的推流。
        /// </summary>
        /// <param name="req"><see cref="ResumeLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeLiveStreamResponse"/></returns>
        public Task<ResumeLiveStreamResponse> ResumeLiveStream(ResumeLiveStreamRequest req)
        {
            return InternalRequestAsync<ResumeLiveStreamResponse>(req, "ResumeLiveStream");
        }

        /// <summary>
        /// 恢复某条流的推流。
        /// </summary>
        /// <param name="req"><see cref="ResumeLiveStreamRequest"/></param>
        /// <returns><see cref="ResumeLiveStreamResponse"/></returns>
        public ResumeLiveStreamResponse ResumeLiveStreamSync(ResumeLiveStreamRequest req)
        {
            return InternalRequestAsync<ResumeLiveStreamResponse>(req, "ResumeLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用来启动直播流监播任务。
        /// </summary>
        /// <param name="req"><see cref="StartLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="StartLiveStreamMonitorResponse"/></returns>
        public Task<StartLiveStreamMonitorResponse> StartLiveStreamMonitor(StartLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<StartLiveStreamMonitorResponse>(req, "StartLiveStreamMonitor");
        }

        /// <summary>
        /// 该接口用来启动直播流监播任务。
        /// </summary>
        /// <param name="req"><see cref="StartLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="StartLiveStreamMonitorResponse"/></returns>
        public StartLiveStreamMonitorResponse StartLiveStreamMonitorSync(StartLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<StartLiveStreamMonitorResponse>(req, "StartLiveStreamMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用该接口停止垫片流。
        /// </summary>
        /// <param name="req"><see cref="StopLivePadProcessorRequest"/></param>
        /// <returns><see cref="StopLivePadProcessorResponse"/></returns>
        public Task<StopLivePadProcessorResponse> StopLivePadProcessor(StopLivePadProcessorRequest req)
        {
            return InternalRequestAsync<StopLivePadProcessorResponse>(req, "StopLivePadProcessor");
        }

        /// <summary>
        /// 使用该接口停止垫片流。
        /// </summary>
        /// <param name="req"><see cref="StopLivePadProcessorRequest"/></param>
        /// <returns><see cref="StopLivePadProcessorResponse"/></returns>
        public StopLivePadProcessorResponse StopLivePadProcessorSync(StopLivePadProcessorRequest req)
        {
            return InternalRequestAsync<StopLivePadProcessorResponse>(req, "StopLivePadProcessor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 说明：录制后的文件存放于点播平台。用户如需使用录制功能，需首先自行开通点播账号并确保账号可用。录制文件存放后，相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，请参考对应文档。
        /// </summary>
        /// <param name="req"><see cref="StopLiveRecordRequest"/></param>
        /// <returns><see cref="StopLiveRecordResponse"/></returns>
        public Task<StopLiveRecordResponse> StopLiveRecord(StopLiveRecordRequest req)
        {
            return InternalRequestAsync<StopLiveRecordResponse>(req, "StopLiveRecord");
        }

        /// <summary>
        /// 说明：录制后的文件存放于点播平台。用户如需使用录制功能，需首先自行开通点播账号并确保账号可用。录制文件存放后，相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，请参考对应文档。
        /// </summary>
        /// <param name="req"><see cref="StopLiveRecordRequest"/></param>
        /// <returns><see cref="StopLiveRecordResponse"/></returns>
        public StopLiveRecordResponse StopLiveRecordSync(StopLiveRecordRequest req)
        {
            return InternalRequestAsync<StopLiveRecordResponse>(req, "StopLiveRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用来停止直播流监播任务。
        /// </summary>
        /// <param name="req"><see cref="StopLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="StopLiveStreamMonitorResponse"/></returns>
        public Task<StopLiveStreamMonitorResponse> StopLiveStreamMonitor(StopLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<StopLiveStreamMonitorResponse>(req, "StopLiveStreamMonitor");
        }

        /// <summary>
        /// 该接口用来停止直播流监播任务。
        /// </summary>
        /// <param name="req"><see cref="StopLiveStreamMonitorRequest"/></param>
        /// <returns><see cref="StopLiveStreamMonitorResponse"/></returns>
        public StopLiveStreamMonitorResponse StopLiveStreamMonitorSync(StopLiveStreamMonitorRequest req)
        {
            return InternalRequestAsync<StopLiveStreamMonitorResponse>(req, "StopLiveStreamMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提前结束录制，中止运行中的录制任务并生成录制文件。任务被成功终止后，本次任务将不再启动。
        /// </summary>
        /// <param name="req"><see cref="StopRecordTaskRequest"/></param>
        /// <returns><see cref="StopRecordTaskResponse"/></returns>
        public Task<StopRecordTaskResponse> StopRecordTask(StopRecordTaskRequest req)
        {
            return InternalRequestAsync<StopRecordTaskResponse>(req, "StopRecordTask");
        }

        /// <summary>
        /// 提前结束录制，中止运行中的录制任务并生成录制文件。任务被成功终止后，本次任务将不再启动。
        /// </summary>
        /// <param name="req"><see cref="StopRecordTaskRequest"/></param>
        /// <returns><see cref="StopRecordTaskResponse"/></returns>
        public StopRecordTaskResponse StopRecordTaskSync(StopRecordTaskRequest req)
        {
            return InternalRequestAsync<StopRecordTaskResponse>(req, "StopRecordTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提前结束截图，中止运行中的截图任务。任务被成功终止后，本次任务将不再启动。
        /// </summary>
        /// <param name="req"><see cref="StopScreenshotTaskRequest"/></param>
        /// <returns><see cref="StopScreenshotTaskResponse"/></returns>
        public Task<StopScreenshotTaskResponse> StopScreenshotTask(StopScreenshotTaskRequest req)
        {
            return InternalRequestAsync<StopScreenshotTaskResponse>(req, "StopScreenshotTask");
        }

        /// <summary>
        /// 提前结束截图，中止运行中的截图任务。任务被成功终止后，本次任务将不再启动。
        /// </summary>
        /// <param name="req"><see cref="StopScreenshotTaskRequest"/></param>
        /// <returns><see cref="StopScreenshotTaskResponse"/></returns>
        public StopScreenshotTaskResponse StopScreenshotTaskSync(StopScreenshotTaskRequest req)
        {
            return InternalRequestAsync<StopScreenshotTaskResponse>(req, "StopScreenshotTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用该接口实现切换当前播放所使用的主备流。
        /// </summary>
        /// <param name="req"><see cref="SwitchBackupStreamRequest"/></param>
        /// <returns><see cref="SwitchBackupStreamResponse"/></returns>
        public Task<SwitchBackupStreamResponse> SwitchBackupStream(SwitchBackupStreamRequest req)
        {
            return InternalRequestAsync<SwitchBackupStreamResponse>(req, "SwitchBackupStream");
        }

        /// <summary>
        /// 调用该接口实现切换当前播放所使用的主备流。
        /// </summary>
        /// <param name="req"><see cref="SwitchBackupStreamRequest"/></param>
        /// <returns><see cref="SwitchBackupStreamResponse"/></returns>
        public SwitchBackupStreamResponse SwitchBackupStreamSync(SwitchBackupStreamRequest req)
        {
            return InternalRequestAsync<SwitchBackupStreamResponse>(req, "SwitchBackupStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑域名证书
        /// </summary>
        /// <param name="req"><see cref="UnBindLiveDomainCertRequest"/></param>
        /// <returns><see cref="UnBindLiveDomainCertResponse"/></returns>
        public Task<UnBindLiveDomainCertResponse> UnBindLiveDomainCert(UnBindLiveDomainCertRequest req)
        {
            return InternalRequestAsync<UnBindLiveDomainCertResponse>(req, "UnBindLiveDomainCert");
        }

        /// <summary>
        /// 解绑域名证书
        /// </summary>
        /// <param name="req"><see cref="UnBindLiveDomainCertRequest"/></param>
        /// <returns><see cref="UnBindLiveDomainCertResponse"/></returns>
        public UnBindLiveDomainCertResponse UnBindLiveDomainCertSync(UnBindLiveDomainCertRequest req)
        {
            return InternalRequestAsync<UnBindLiveDomainCertResponse>(req, "UnBindLiveDomainCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新水印。
        /// </summary>
        /// <param name="req"><see cref="UpdateLiveWatermarkRequest"/></param>
        /// <returns><see cref="UpdateLiveWatermarkResponse"/></returns>
        public Task<UpdateLiveWatermarkResponse> UpdateLiveWatermark(UpdateLiveWatermarkRequest req)
        {
            return InternalRequestAsync<UpdateLiveWatermarkResponse>(req, "UpdateLiveWatermark");
        }

        /// <summary>
        /// 更新水印。
        /// </summary>
        /// <param name="req"><see cref="UpdateLiveWatermarkRequest"/></param>
        /// <returns><see cref="UpdateLiveWatermarkResponse"/></returns>
        public UpdateLiveWatermarkResponse UpdateLiveWatermarkSync(UpdateLiveWatermarkRequest req)
        {
            return InternalRequestAsync<UpdateLiveWatermarkResponse>(req, "UpdateLiveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
