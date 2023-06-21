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

    public class TaskStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// 当前使用的源 URL。
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// 点播源任务的轮播次数。
        /// </summary>
        [JsonProperty("LoopedTimes")]
        public long? LoopedTimes{ get; set; }

        /// <summary>
        /// 点播源的播放偏移，单位：秒。
        /// </summary>
        [JsonProperty("OffsetTime")]
        public long? OffsetTime{ get; set; }

        /// <summary>
        /// 最新心跳上报时间。UTC时间，例如：
        /// 2022-02-11T10:00:00Z。
        /// 注意：UTC时间与北京时间相差八小时。
        /// </summary>
        [JsonProperty("ReportTime")]
        public string ReportTime{ get; set; }

        /// <summary>
        /// 实际运行状态：
        /// active - 活跃，
        /// inactive - 不活跃。
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

        /// <summary>
        /// 点播源的文件时长，单位：秒。
        /// </summary>
        [JsonProperty("FileDuration")]
        public long? FileDuration{ get; set; }

        /// <summary>
        /// 下一进度点播文件 URL。
        /// </summary>
        [JsonProperty("NextFileUrl")]
        public string NextFileUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "LoopedTimes", this.LoopedTimes);
            this.SetParamSimple(map, prefix + "OffsetTime", this.OffsetTime);
            this.SetParamSimple(map, prefix + "ReportTime", this.ReportTime);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamSimple(map, prefix + "FileDuration", this.FileDuration);
            this.SetParamSimple(map, prefix + "NextFileUrl", this.NextFileUrl);
        }
    }
}

