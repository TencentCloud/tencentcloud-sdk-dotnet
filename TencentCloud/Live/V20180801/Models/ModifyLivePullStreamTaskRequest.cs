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

    public class ModifyLivePullStreamTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务Id。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 操作人姓名。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 拉流源url列表。
        /// SourceType为直播（PullLivePushLive）只可以填1个，
        /// SourceType为点播（PullVodPushLive）可以填多个，上限30个。
        /// </summary>
        [JsonProperty("SourceUrls")]
        public string[] SourceUrls{ get; set; }

        /// <summary>
        /// 开始时间。
        /// 使用UTC格式时间，
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
        /// 使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 点播拉流转推循环次数。
        /// -1：无限循环，直到任务结束。
        /// 0：不循环。
        /// >0：具体循环次数。次数和时间以先结束的为准。
        /// 注意：拉流源为点播，该配置生效。
        /// </summary>
        [JsonProperty("VodLoopTimes")]
        public long? VodLoopTimes{ get; set; }

        /// <summary>
        /// 点播更新SourceUrls后的播放方式：
        /// ImmediateNewSource：立即从更新的拉流源开始播放；
        /// ContinueBreakPoint：从上次断流url源的断点处继续，结束后再使用新的拉流源。
        /// 注意：拉流源为点播，该配置生效。
        /// </summary>
        [JsonProperty("VodRefreshType")]
        public string VodRefreshType{ get; set; }

        /// <summary>
        /// 任务状态：
        /// enable - 启用，
        /// pause - 暂停。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

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
        /// 自定义回调地址。
        /// 相关事件会回调到该地址。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 指定播放文件索引。
        /// 注意： 从1开始，不大于SourceUrls中文件个数。
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
        /// 任务备注。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamArraySimple(map, prefix + "SourceUrls.", this.SourceUrls);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "VodLoopTimes", this.VodLoopTimes);
            this.SetParamSimple(map, prefix + "VodRefreshType", this.VodRefreshType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "CallbackEvents.", this.CallbackEvents);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "FileIndex", this.FileIndex);
            this.SetParamSimple(map, prefix + "OffsetTime", this.OffsetTime);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

