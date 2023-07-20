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

    public class ScreenInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 统计标示 0：全部、1：当前天、2：昨天
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CountTag")]
        public ulong? CountTag{ get; set; }

        /// <summary>
        /// 总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// 运行中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningNum")]
        public ulong? RunningNum{ get; set; }

        /// <summary>
        /// 等待运行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaitRunningNum")]
        public ulong? WaitRunningNum{ get; set; }

        /// <summary>
        /// 等待上游
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyNum")]
        public ulong? DependencyNum{ get; set; }

        /// <summary>
        /// 等待事件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaitEventNum")]
        public string WaitEventNum{ get; set; }

        /// <summary>
        /// 正在终止
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StoppingNum")]
        public ulong? StoppingNum{ get; set; }

        /// <summary>
        /// 成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SucceedNum")]
        public ulong? SucceedNum{ get; set; }

        /// <summary>
        /// 失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedNum")]
        public ulong? FailedNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CountTag", this.CountTag);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "RunningNum", this.RunningNum);
            this.SetParamSimple(map, prefix + "WaitRunningNum", this.WaitRunningNum);
            this.SetParamSimple(map, prefix + "DependencyNum", this.DependencyNum);
            this.SetParamSimple(map, prefix + "WaitEventNum", this.WaitEventNum);
            this.SetParamSimple(map, prefix + "StoppingNum", this.StoppingNum);
            this.SetParamSimple(map, prefix + "SucceedNum", this.SucceedNum);
            this.SetParamSimple(map, prefix + "FailedNum", this.FailedNum);
        }
    }
}

