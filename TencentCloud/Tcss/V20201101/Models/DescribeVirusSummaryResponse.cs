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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVirusSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 最近的一次扫描任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 木马影响容器个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskContainerCnt")]
        public ulong? RiskContainerCnt{ get; set; }

        /// <summary>
        /// 待处理风险个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

        /// <summary>
        /// 病毒库更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirusDataBaseModifyTime")]
        public string VirusDataBaseModifyTime{ get; set; }

        /// <summary>
        /// 木马影响容器个数较昨日增长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskContainerIncrease")]
        public long? RiskContainerIncrease{ get; set; }

        /// <summary>
        /// 待处理风险个数较昨日增长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskIncrease")]
        public long? RiskIncrease{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "RiskContainerCnt", this.RiskContainerCnt);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "VirusDataBaseModifyTime", this.VirusDataBaseModifyTime);
            this.SetParamSimple(map, prefix + "RiskContainerIncrease", this.RiskContainerIncrease);
            this.SetParamSimple(map, prefix + "RiskIncrease", this.RiskIncrease);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

