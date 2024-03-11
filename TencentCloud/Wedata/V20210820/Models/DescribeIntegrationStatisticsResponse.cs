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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIntegrationStatisticsResponse : AbstractModel
    {
        
        /// <summary>
        /// 总任务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalTask")]
        public long? TotalTask{ get; set; }

        /// <summary>
        /// 生产态任务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProdTask")]
        public long? ProdTask{ get; set; }

        /// <summary>
        /// 开发态任务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DevTask")]
        public long? DevTask{ get; set; }

        /// <summary>
        /// 总读取条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalReadRecords")]
        public long? TotalReadRecords{ get; set; }

        /// <summary>
        /// 总写入条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalWriteRecords")]
        public long? TotalWriteRecords{ get; set; }

        /// <summary>
        /// 总脏数据条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalErrorRecords")]
        public long? TotalErrorRecords{ get; set; }

        /// <summary>
        /// 总告警事件数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalAlarmEvent")]
        public long? TotalAlarmEvent{ get; set; }

        /// <summary>
        /// 当天读取增长条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncreaseReadRecords")]
        public long? IncreaseReadRecords{ get; set; }

        /// <summary>
        /// 当天写入增长条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncreaseWriteRecords")]
        public long? IncreaseWriteRecords{ get; set; }

        /// <summary>
        /// 当天脏数据增长条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncreaseErrorRecords")]
        public long? IncreaseErrorRecords{ get; set; }

        /// <summary>
        /// 当天告警事件增长数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncreaseAlarmEvent")]
        public long? IncreaseAlarmEvent{ get; set; }

        /// <summary>
        /// 告警事件统计
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmEvent")]
        public string AlarmEvent{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalTask", this.TotalTask);
            this.SetParamSimple(map, prefix + "ProdTask", this.ProdTask);
            this.SetParamSimple(map, prefix + "DevTask", this.DevTask);
            this.SetParamSimple(map, prefix + "TotalReadRecords", this.TotalReadRecords);
            this.SetParamSimple(map, prefix + "TotalWriteRecords", this.TotalWriteRecords);
            this.SetParamSimple(map, prefix + "TotalErrorRecords", this.TotalErrorRecords);
            this.SetParamSimple(map, prefix + "TotalAlarmEvent", this.TotalAlarmEvent);
            this.SetParamSimple(map, prefix + "IncreaseReadRecords", this.IncreaseReadRecords);
            this.SetParamSimple(map, prefix + "IncreaseWriteRecords", this.IncreaseWriteRecords);
            this.SetParamSimple(map, prefix + "IncreaseErrorRecords", this.IncreaseErrorRecords);
            this.SetParamSimple(map, prefix + "IncreaseAlarmEvent", this.IncreaseAlarmEvent);
            this.SetParamSimple(map, prefix + "AlarmEvent", this.AlarmEvent);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

