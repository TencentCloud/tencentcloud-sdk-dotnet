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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PeakPointsItem : AbstractModel
    {
        
        /// <summary>
        /// 秒级别时间戳
        /// </summary>
        [JsonProperty("Time")]
        public ulong? Time{ get; set; }

        /// <summary>
        /// QPS
        /// </summary>
        [JsonProperty("Access")]
        public ulong? Access{ get; set; }

        /// <summary>
        /// 上行带宽峰值，单位B
        /// </summary>
        [JsonProperty("Up")]
        public ulong? Up{ get; set; }

        /// <summary>
        /// 下行带宽峰值，单位B
        /// </summary>
        [JsonProperty("Down")]
        public ulong? Down{ get; set; }

        /// <summary>
        /// Web攻击次数
        /// </summary>
        [JsonProperty("Attack")]
        public ulong? Attack{ get; set; }

        /// <summary>
        /// CC攻击次数
        /// </summary>
        [JsonProperty("Cc")]
        public ulong? Cc{ get; set; }

        /// <summary>
        /// Bot qps
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BotAccess")]
        public ulong? BotAccess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Access", this.Access);
            this.SetParamSimple(map, prefix + "Up", this.Up);
            this.SetParamSimple(map, prefix + "Down", this.Down);
            this.SetParamSimple(map, prefix + "Attack", this.Attack);
            this.SetParamSimple(map, prefix + "Cc", this.Cc);
            this.SetParamSimple(map, prefix + "BotAccess", this.BotAccess);
        }
    }
}

