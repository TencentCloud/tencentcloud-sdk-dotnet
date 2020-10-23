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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceExtend : AbstractModel
    {
        
        /// <summary>
        /// 实例信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Instance")]
        public Instance Instance{ get; set; }

        /// <summary>
        /// 实例状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 健康进程数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthyProcessCnt")]
        public long? HealthyProcessCnt{ get; set; }

        /// <summary>
        /// 活跃进程数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActiveProcessCnt")]
        public long? ActiveProcessCnt{ get; set; }

        /// <summary>
        /// 当前游戏会话总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GameSessionCnt")]
        public long? GameSessionCnt{ get; set; }

        /// <summary>
        /// 最大游戏会话数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxGameSessionCnt")]
        public long? MaxGameSessionCnt{ get; set; }

        /// <summary>
        /// 当前玩家会话数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlayerSessionCnt")]
        public long? PlayerSessionCnt{ get; set; }

        /// <summary>
        /// 最大玩家会话数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxPlayerSessionCnt")]
        public long? MaxPlayerSessionCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Instance.", this.Instance);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "HealthyProcessCnt", this.HealthyProcessCnt);
            this.SetParamSimple(map, prefix + "ActiveProcessCnt", this.ActiveProcessCnt);
            this.SetParamSimple(map, prefix + "GameSessionCnt", this.GameSessionCnt);
            this.SetParamSimple(map, prefix + "MaxGameSessionCnt", this.MaxGameSessionCnt);
            this.SetParamSimple(map, prefix + "PlayerSessionCnt", this.PlayerSessionCnt);
            this.SetParamSimple(map, prefix + "MaxPlayerSessionCnt", this.MaxPlayerSessionCnt);
        }
    }
}

