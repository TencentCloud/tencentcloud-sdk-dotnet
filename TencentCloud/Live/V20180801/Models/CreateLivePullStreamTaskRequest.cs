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
        /// PullVodPushLive -点播。
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 拉流源 url 列表。
        /// SourceType 为直播（PullLivePushLive）只可以填1个，
        /// SourceType 为点播（PullVodPushLive）可以填多个，上限30个。
        /// 当前支持的文件格式：flv，mp4，hls。
        /// 当前支持的拉流协议：http，https，rtmp。
        /// 注意：
        /// 1. 建议优先使用 flv 文件，对于 mp4 未交织好的文件轮播推流易产生卡顿，可通过点播转码进行重新交织后再轮播。
        /// 2. 拒绝内网域名等攻击性拉流地址，如有使用，则做账号封禁处理。
        /// </summary>
        [JsonProperty("SourceUrls")]
        public string[] SourceUrls{ get; set; }

        /// <summary>
        /// 推流域名。
        /// 将拉取过来的流推到该域名。
        /// 注意：请使用已在云直播配置的推流域名。
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
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，注意：
        /// 1. 结束时间必须大于开始时间；
        /// 2. 结束时间和开始时间必须大于当前时间；
        /// 3. 结束时间 和 开始时间 间隔必须小于七天。
        /// 使用 UTC 格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
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
        /// 任务描述，限制 512 字节。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


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
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

