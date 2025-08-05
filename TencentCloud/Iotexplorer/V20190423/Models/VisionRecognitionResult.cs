/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VisionRecognitionResult : AbstractModel
    {
        
        /// <summary>
        /// 任务状态（1：分析失败；2：下载/读取视频/图片失败；3：成功；4：执行中）
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 识别到的目标类型。可能取值：
        /// 
        /// - `person`：人
        /// - `vehicle`：车辆
        /// - `dog`：狗
        /// - `cat`：猫
        /// - `fire`：火焰
        /// - `smoke`：烟雾
        /// - `package`：快递包裹
        /// - `license_plate`：车牌
        /// </summary>
        [JsonProperty("DetectedClassifications")]
        public string[] DetectedClassifications{ get; set; }

        /// <summary>
        /// 摘要文本
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// 摘要文本（次选语言）
        /// </summary>
        [JsonProperty("AlternativeSummary")]
        public string AlternativeSummary{ get; set; }

        /// <summary>
        /// 错误码，可能取值：
        /// 
        /// - `DownloadFailed`：下载视频/图片文件失败
        /// - `ReadFailed`：读取视频/图片文件失败
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "DetectedClassifications.", this.DetectedClassifications);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "AlternativeSummary", this.AlternativeSummary);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
        }
    }
}

