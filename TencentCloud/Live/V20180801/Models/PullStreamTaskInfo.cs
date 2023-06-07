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

    public class PullStreamTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 拉流任务Id。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 拉流源的类型：
        /// PullLivePushLive -直播，
        /// PullVodPushLive -点播，
        /// PullPicPushLive -图片。
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 拉流源url列表。
        /// SourceType为直播（PullLiveToLive）只可以填1个，
        /// SourceType为点播（PullVodToLive）可以填多个，上限10个。
        /// </summary>
        [JsonProperty("SourceUrls")]
        public string[] SourceUrls{ get; set; }

        /// <summary>
        /// 推流域名。
        /// 将拉到的源推到该域名。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 推流路径。
        /// 将拉到的源推到该路径。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 流名称。
        /// 将拉到的源推到该流名称。
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// 推流参数。
        /// 推流携带的自定义参数。
        /// </summary>
        [JsonProperty("PushArgs")]
        public string PushArgs{ get; set; }

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
        /// 任务创建所在地域：
        /// ap-beijing - 华北地区(北京)，
        /// ap-shanghai -华东地区(上海)，
        /// ap-guangzhou -华南地区(广州)，
        /// ap-mumbai - 印度，
        /// ap-hongkong - 香港，
        /// eu-frankfurt - 德国，
        /// ap-seoul - 韩国，
        /// ap-bangkok - 泰国，
        /// ap-singapore - 新加坡，
        /// na-siliconvalley - 美西，
        /// na-ashburn - 美东，
        /// ap-tokyo - 日本。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

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
        /// 
        /// 注意：拉流源为点播，该配置生效。
        /// </summary>
        [JsonProperty("VodRefreshType")]
        public string VodRefreshType{ get; set; }

        /// <summary>
        /// 任务创建时间。
        /// 使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务更新时间。
        /// 使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 创建任务的操作者。
        /// </summary>
        [JsonProperty("CreateBy")]
        public string CreateBy{ get; set; }

        /// <summary>
        /// 最后更新任务的操作者。
        /// </summary>
        [JsonProperty("UpdateBy")]
        public string UpdateBy{ get; set; }

        /// <summary>
        /// 回调地址。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 选择需要回调的事件：
        /// TaskStart：任务启动回调，
        /// TaskExit：任务停止回调，
        /// VodSourceFileStart：从点播源文件开始拉流回调，
        /// VodSourceFileFinish：从点播源文件拉流结束回调，
        /// ResetTaskConfig：任务更新回调。
        /// </summary>
        [JsonProperty("CallbackEvents")]
        public string[] CallbackEvents{ get; set; }

        /// <summary>
        /// 注意：该信息暂不返回。
        /// 最后一次回调信息。
        /// </summary>
        [JsonProperty("CallbackInfo")]
        public string CallbackInfo{ get; set; }

        /// <summary>
        /// 注意：该信息暂不返回。
        /// 错误信息。
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// 状态。
        /// enable：生效中。
        /// pause：暂停中。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 注意：该信息仅在查询单个任务时返回。
        /// 任务最新拉流信息。
        /// 包含：源 url，偏移时间，上报时间。
        /// </summary>
        [JsonProperty("RecentPullInfo")]
        public RecentPullInfo RecentPullInfo{ get; set; }

        /// <summary>
        /// 任务备注信息。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 备源类型：
        /// PullLivePushLive -直播，
        /// PullVodPushLive -点播。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupSourceType")]
        public string BackupSourceType{ get; set; }

        /// <summary>
        /// 备源URL。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupSourceUrl")]
        public string BackupSourceUrl{ get; set; }

        /// <summary>
        /// 水印信息列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WatermarkList")]
        public PullPushWatermarkInfo[] WatermarkList{ get; set; }

        /// <summary>
        /// 点播源是否启用本地推流模式，默认0，不启用。
        /// 0 - 不启用。
        /// 1 - 启用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VodLocalMode")]
        public long? VodLocalMode{ get; set; }

        /// <summary>
        /// 录制模板 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordTemplateId")]
        public string RecordTemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamArraySimple(map, prefix + "SourceUrls.", this.SourceUrls);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "PushArgs", this.PushArgs);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "VodLoopTimes", this.VodLoopTimes);
            this.SetParamSimple(map, prefix + "VodRefreshType", this.VodRefreshType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateBy", this.CreateBy);
            this.SetParamSimple(map, prefix + "UpdateBy", this.UpdateBy);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamArraySimple(map, prefix + "CallbackEvents.", this.CallbackEvents);
            this.SetParamSimple(map, prefix + "CallbackInfo", this.CallbackInfo);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "RecentPullInfo.", this.RecentPullInfo);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "BackupSourceType", this.BackupSourceType);
            this.SetParamSimple(map, prefix + "BackupSourceUrl", this.BackupSourceUrl);
            this.SetParamArrayObj(map, prefix + "WatermarkList.", this.WatermarkList);
            this.SetParamSimple(map, prefix + "VodLocalMode", this.VodLocalMode);
            this.SetParamSimple(map, prefix + "RecordTemplateId", this.RecordTemplateId);
        }
    }
}

