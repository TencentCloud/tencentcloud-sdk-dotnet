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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpeedTestingStatistics : AbstractModel
    {
        
        /// <summary>
        /// 首屏时间，单位 ms。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstContentfulPaint")]
        public long? FirstContentfulPaint{ get; set; }

        /// <summary>
        /// 首屏完全渲染时间，单位 ms。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstMeaningfulPaint")]
        public long? FirstMeaningfulPaint{ get; set; }

        /// <summary>
        /// 整体下载速度，单位 KB/s。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OverallDownloadSpeed")]
        public float? OverallDownloadSpeed{ get; set; }

        /// <summary>
        /// 渲染时间，单位 ms。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RenderTime")]
        public long? RenderTime{ get; set; }

        /// <summary>
        /// 文档完成时间, 单位 ms。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DocumentFinishTime")]
        public long? DocumentFinishTime{ get; set; }

        /// <summary>
        /// 基础文档TCP连接时间，单位 ms。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TcpConnectionTime")]
        public long? TcpConnectionTime{ get; set; }

        /// <summary>
        /// 基础文档服务器响应时间，单位 ms。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseTime")]
        public long? ResponseTime{ get; set; }

        /// <summary>
        /// 基础文档下载时间，单位 ms。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileDownloadTime")]
        public long? FileDownloadTime{ get; set; }

        /// <summary>
        /// 整体性能，测试总时间，单位 ms。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadTime")]
        public long? LoadTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FirstContentfulPaint", this.FirstContentfulPaint);
            this.SetParamSimple(map, prefix + "FirstMeaningfulPaint", this.FirstMeaningfulPaint);
            this.SetParamSimple(map, prefix + "OverallDownloadSpeed", this.OverallDownloadSpeed);
            this.SetParamSimple(map, prefix + "RenderTime", this.RenderTime);
            this.SetParamSimple(map, prefix + "DocumentFinishTime", this.DocumentFinishTime);
            this.SetParamSimple(map, prefix + "TcpConnectionTime", this.TcpConnectionTime);
            this.SetParamSimple(map, prefix + "ResponseTime", this.ResponseTime);
            this.SetParamSimple(map, prefix + "FileDownloadTime", this.FileDownloadTime);
            this.SetParamSimple(map, prefix + "LoadTime", this.LoadTime);
        }
    }
}

