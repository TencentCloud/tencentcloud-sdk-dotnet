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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLivePullStreamTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 拉流源的类型：
        /// PullLivePushLive -直播，
        /// PullVodPushLive -点播，
        /// PullPicPushLive -图片。
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 拉流源 url 列表。
        /// SourceType 为直播（PullLivePushLive）只可以填1个，
        /// SourceType 为点播（PullVodPushLive）可以填多个，上限30个。
        /// 当前支持的文件格式：flv，mp4，hls。
        /// 当前支持的拉流协议：http，https，rtmp，rtmps，rtsp，srt。
        /// 注意：
        /// 1. 建议优先使用 flv 文件，对于 mp4 未交织好的文件轮播推流易产生卡顿，可通过点播转码进行重新交织后再轮播。
        /// 2. 拒绝内网域名等攻击性拉流地址，如有使用，则做账号封禁处理。
        /// 3. 源文件请保持时间戳正常交织递增，避免因源文件异常影响推流及播放。
        /// 4. 视频编码格式仅支持: H264, H265。
        /// 5. 音频编码格式仅支持: AAC。
        /// 6. 点播源请使用小文件，尽量时长保持在1小时内，较大文件打开和续播耗时较久，耗时超过15秒会有无法正常转推风险。
        /// 7. 避免使用低频存储的文件，该类文件因低频存储，拉取时容易出现慢速，影响拉转推质量。
        /// </summary>
        [JsonProperty("SourceUrls")]
        public string[] SourceUrls{ get; set; }

        /// <summary>
        /// 推流域名。
        /// 将拉取过来的流推到该域名。
        /// 注意：如果目标地址为非云直播，且样式不同于云直播，请使用 ToUrl 传入完整推流地址，详细用法请参考 ToUrl 参数说明。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 推流路径。
        /// 将拉取过来的流推到该路径。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 推流名称。
        /// 将拉取过来的流推到该流名称。
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// 开始时间。
        /// 使用 UTC 格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，注意：
        /// 1. 结束时间必须大于开始时间；
        /// 2. 结束时间必须大于当前时间；
        /// 3. 结束时间 和 开始时间 间隔必须小于七天。
        /// 使用 UTC 格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务操作人备注。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 推流参数。
        /// 推流时携带自定义参数。
        /// 示例：
        /// bak=1&test=2 。
        /// </summary>
        [JsonProperty("PushArgs")]
        public string PushArgs{ get; set; }

        /// <summary>
        /// 选择需要回调的事件（不填则回调全部）：
        /// TaskStart：任务启动回调，
        /// TaskExit：任务停止回调，
        /// VodSourceFileStart：从点播源文件开始拉流回调，
        /// VodSourceFileFinish：从点播源文件拉流结束回调，
        /// ResetTaskConfig：任务更新回调。
        /// 
        /// TaskAlarm: 用于告警事件通知，AlarmType 示例:
        /// PullFileUnstable - 文件拉取不稳定，
        /// PushStreamUnstable - 推流不稳定，
        /// PullFileFailed - 文件拉取出错，
        /// PushStreamFailed - 推流出现失败，
        /// FileEndEarly - 文件提前结束。
        /// </summary>
        [JsonProperty("CallbackEvents")]
        public string[] CallbackEvents{ get; set; }

        /// <summary>
        /// 点播拉流转推循环次数。默认：-1。
        /// -1：无限循环，直到任务结束。
        /// 0：不循环。
        /// >0：具体循环次数。次数和时间以先结束的为准。
        /// 注意：该配置仅对拉流源为点播时生效。
        /// </summary>
        [JsonProperty("VodLoopTimes")]
        public string VodLoopTimes{ get; set; }

        /// <summary>
        /// 点播更新SourceUrls后的播放方式：
        /// ImmediateNewSource：立即播放新的拉流源内容；
        /// ContinueBreakPoint：播放完当前正在播放的点播 url 后再使用新的拉流源播放。（旧拉流源未播放的点播 url 不会再播放）
        /// 
        /// 注意：该配置生效仅对变更前拉流源为点播时生效。
        /// </summary>
        [JsonProperty("VodRefreshType")]
        public string VodRefreshType{ get; set; }

        /// <summary>
        /// 自定义回调地址。
        /// 拉流转推任务相关事件会回调到该地址。
        /// 回调事件使用方法请查看：
        /// https://cloud.tencent.com/document/product/267/32744
        /// https://cloud.tencent.com/document/product/267/56208
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 其他参数。
        /// 示例: ignore_region  用于忽略传入地域, 内部按负载分配。
        /// </summary>
        [JsonProperty("ExtraCmd")]
        public string ExtraCmd{ get; set; }

        /// <summary>
        /// 自定义任务 ID。
        /// 注：
        /// 1. 该自定义 ID 为可选参数，如果传入，请确保该账号下传入的 ID 唯一。
        /// 2. 该自定义 ID 用于防止重复发起请求时产生重复任务。后面也可以用 SpecifyTaskId 来修改或删除任务。
        /// </summary>
        [JsonProperty("SpecifyTaskId")]
        public string SpecifyTaskId{ get; set; }

        /// <summary>
        /// 任务描述，限制 512 字节。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 完整目标 URL 地址。
        /// 用法注意：如果使用该参数来传完整目标地址，则 DomainName, AppName, StreamName 需要传入空字符串，任务将会使用该 ToUrl 参数指定的目标地址。
        /// 
        /// 使用该方式传入目标地址支持的协议有：
        /// rtmp、rtmps、rtsp、rtp、srt。
        /// 
        /// 注意：签名时间需要超过任务结束时间，避免因签名过期造成任务失败。
        /// </summary>
        [JsonProperty("ToUrl")]
        public string ToUrl{ get; set; }

        /// <summary>
        /// 指定播放文件索引。
        /// 注意： 1. 从1开始，不大于SourceUrls中文件个数。
        /// 2. 该偏移仅在首次轮播时有效。
        /// 3. 提前创建的任务指定的偏移最长有效期为24小时，24小时后未开始的任务偏移失效。
        /// </summary>
        [JsonProperty("FileIndex")]
        public long? FileIndex{ get; set; }

        /// <summary>
        /// 指定播放文件偏移。
        /// 注意：
        /// 1. 单位：秒，配合FileIndex使用。
        /// </summary>
        [JsonProperty("OffsetTime")]
        public long? OffsetTime{ get; set; }

        /// <summary>
        /// 备源的类型：
        /// PullLivePushLive -直播，
        /// PullVodPushLive -点播。
        /// 注意：
        /// 1. 仅当主源类型为直播源时，备源才会生效。
        /// 2. 主直播源拉流中断时，自动使用备源进行拉流。
        /// 3. 如果备源为点播文件时，则每次轮播完点播文件就检查主源是否恢复，如果主源恢复则自动切回到主源，否则继续拉备源。
        /// </summary>
        [JsonProperty("BackupSourceType")]
        public string BackupSourceType{ get; set; }

        /// <summary>
        /// 备源 URL。
        /// 只允许填一个备源 URL
        /// </summary>
        [JsonProperty("BackupSourceUrl")]
        public string BackupSourceUrl{ get; set; }

        /// <summary>
        /// 水印信息列表。
        /// 注意：
        /// 1. 最多支持4个不同位置的水印。
        /// 2. 水印图片 URL 请使用合法外网可访问地址。
        /// 3. 支持的水印图片格式：png，jpg，gif 等。
        /// </summary>
        [JsonProperty("WatermarkList")]
        public PullPushWatermarkInfo[] WatermarkList{ get; set; }

        /// <summary>
        /// 点播源是否启用本地推流模式，默认0，不启用。
        /// 0 - 不启用。
        /// 1 - 启用。
        /// 注意：启用本地模式后，会将源列表中的 MP4 文件进行本地下载，优先使用本地已下载文件进行推流，提高点播源推流稳定性。使用本地下载文件推流时，会产生增值费用。
        /// </summary>
        [JsonProperty("VodLocalMode")]
        public long? VodLocalMode{ get; set; }

        /// <summary>
        /// 录制模板 ID。
        /// </summary>
        [JsonProperty("RecordTemplateId")]
        public string RecordTemplateId{ get; set; }

        /// <summary>
        /// 新的目标地址，用于任务同时推两路场景。
        /// </summary>
        [JsonProperty("BackupToUrl")]
        public string BackupToUrl{ get; set; }

        /// <summary>
        /// 直播转码模板，使用云直播的转码功能进行转码后再转推出去。转码模板需在云直播控制台创建。
        /// </summary>
        [JsonProperty("TranscodeTemplateName")]
        public string TranscodeTemplateName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamArraySimple(map, prefix + "SourceUrls.", this.SourceUrls);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "PushArgs", this.PushArgs);
            this.SetParamArraySimple(map, prefix + "CallbackEvents.", this.CallbackEvents);
            this.SetParamSimple(map, prefix + "VodLoopTimes", this.VodLoopTimes);
            this.SetParamSimple(map, prefix + "VodRefreshType", this.VodRefreshType);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "ExtraCmd", this.ExtraCmd);
            this.SetParamSimple(map, prefix + "SpecifyTaskId", this.SpecifyTaskId);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "ToUrl", this.ToUrl);
            this.SetParamSimple(map, prefix + "FileIndex", this.FileIndex);
            this.SetParamSimple(map, prefix + "OffsetTime", this.OffsetTime);
            this.SetParamSimple(map, prefix + "BackupSourceType", this.BackupSourceType);
            this.SetParamSimple(map, prefix + "BackupSourceUrl", this.BackupSourceUrl);
            this.SetParamArrayObj(map, prefix + "WatermarkList.", this.WatermarkList);
            this.SetParamSimple(map, prefix + "VodLocalMode", this.VodLocalMode);
            this.SetParamSimple(map, prefix + "RecordTemplateId", this.RecordTemplateId);
            this.SetParamSimple(map, prefix + "BackupToUrl", this.BackupToUrl);
            this.SetParamSimple(map, prefix + "TranscodeTemplateName", this.TranscodeTemplateName);
        }
    }
}

