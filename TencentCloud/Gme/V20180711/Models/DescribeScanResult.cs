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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScanResult : AbstractModel
    {
        
        /// <summary>
        /// 业务返回码
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// 数据唯一 ID
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// 检测完成的时间戳
        /// </summary>
        [JsonProperty("ScanFinishTime")]
        public ulong? ScanFinishTime{ get; set; }

        /// <summary>
        /// 是否违规
        /// </summary>
        [JsonProperty("HitFlag")]
        public bool? HitFlag{ get; set; }

        /// <summary>
        /// 是否为流
        /// </summary>
        [JsonProperty("Live")]
        public bool? Live{ get; set; }

        /// <summary>
        /// 业务返回描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// 检测结果，Code 为 0 时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanPiece")]
        public ScanPiece[] ScanPiece{ get; set; }

        /// <summary>
        /// 提交检测的时间戳
        /// </summary>
        [JsonProperty("ScanStartTime")]
        public ulong? ScanStartTime{ get; set; }

        /// <summary>
        /// 语音检测场景，对应请求时的 Scene
        /// </summary>
        [JsonProperty("Scenes")]
        public string[] Scenes{ get; set; }

        /// <summary>
        /// 语音检测任务 ID，由后台分配
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 文件或接流地址
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 检测任务执行结果状态，分别为：
        /// <li>Start: 任务开始</li>
        /// <li>Success: 成功结束</li>
        /// <li>Error: 异常</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "ScanFinishTime", this.ScanFinishTime);
            this.SetParamSimple(map, prefix + "HitFlag", this.HitFlag);
            this.SetParamSimple(map, prefix + "Live", this.Live);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamArrayObj(map, prefix + "ScanPiece.", this.ScanPiece);
            this.SetParamSimple(map, prefix + "ScanStartTime", this.ScanStartTime);
            this.SetParamArraySimple(map, prefix + "Scenes.", this.Scenes);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

