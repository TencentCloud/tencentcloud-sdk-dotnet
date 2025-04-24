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
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/267/38543#I)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，注意：
        /// 1. 结束时间必须大于开始时间；
        /// 2. 结束时间和开始时间必须大于当前时间；
        /// 3. 结束时间 和 开始时间 间隔必须小于30天。
        /// 使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/267/38543#I)。
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
        /// 指定任务 ID 修改任务。
        /// 
        /// 注意：该自定义任务 ID 只有在创建任务时指定了，才可在此处修改时使用。否则请使用系统返回的任务 ID。
        /// </summary>
        [JsonProperty("SpecifyTaskId")]
        public string SpecifyTaskId{ get; set; }

        /// <summary>
        /// 目标 Url。
        /// 换目标地址，会断流重推到新地址。
        /// </summary>
        [JsonProperty("ToUrl")]
        public string ToUrl{ get; set; }

        /// <summary>
        /// 任务备注。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 备源的类型：
        /// PullLivePushLive -直播，
        /// PullVodPushLive -点播。
        /// 注意：
        /// 1. 仅当主源类型为直播源时，备源才会生效。
        /// 2. 将该参数置为空，则可将任务去除备源信息。
        /// 3. 主直播源拉流中断时，自动使用备源进行拉流。
        /// 4. 如果备源为点播文件时，则每次轮播完点播文件就检查主源是否恢复，如果主源恢复则自动切回到主源，否则继续拉备源。
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
        /// 3. 支持的水印图片格式：png，jpg等。
        /// 4. 轮播任务修改水印后，轮播到下一个文件时新水印生效。
        /// 5. 直播源任务修改水印后，水印立即生效。
        /// 6. 清除水印时，需携带该水印列表参数，内容为空数组。
        /// 7. 暂不支持动图水印。
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
        /// 新的目标地址。传空值，则取消该地址的推流。
        /// 传入新值，则替换原有地址。
        /// </summary>
        [JsonProperty("BackupToUrl")]
        public string BackupToUrl{ get; set; }

        /// <summary>
        /// 点播垫片文件地址。注意：用于在主源拉不到时自动兜底到垫片文件，切到垫片文件后，每次播完垫片会尝试拉主源，如果主源恢复则自动切回主源。可根据需要的轮询检查时长来传入对应时长的垫片文件。
        /// </summary>
        [JsonProperty("BackupVodUrl")]
        public string BackupVodUrl{ get; set; }


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
            this.SetParamSimple(map, prefix + "SpecifyTaskId", this.SpecifyTaskId);
            this.SetParamSimple(map, prefix + "ToUrl", this.ToUrl);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "BackupSourceType", this.BackupSourceType);
            this.SetParamSimple(map, prefix + "BackupSourceUrl", this.BackupSourceUrl);
            this.SetParamArrayObj(map, prefix + "WatermarkList.", this.WatermarkList);
            this.SetParamSimple(map, prefix + "VodLocalMode", this.VodLocalMode);
            this.SetParamSimple(map, prefix + "BackupToUrl", this.BackupToUrl);
            this.SetParamSimple(map, prefix + "BackupVodUrl", this.BackupVodUrl);
        }
    }
}

