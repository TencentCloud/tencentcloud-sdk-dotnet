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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FleetUtilization : AbstractModel
    {
        
        /// <summary>
        /// 游戏会话数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActiveGameServerSessionCount")]
        public ulong? ActiveGameServerSessionCount{ get; set; }

        /// <summary>
        /// 活跃进程数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActiveServerProcessCount")]
        public ulong? ActiveServerProcessCount{ get; set; }

        /// <summary>
        /// 当前游戏玩家数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentPlayerSessionCount")]
        public ulong? CurrentPlayerSessionCount{ get; set; }

        /// <summary>
        /// 服务部署 Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// 最大玩家会话数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaximumPlayerSessionCount")]
        public ulong? MaximumPlayerSessionCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActiveGameServerSessionCount", this.ActiveGameServerSessionCount);
            this.SetParamSimple(map, prefix + "ActiveServerProcessCount", this.ActiveServerProcessCount);
            this.SetParamSimple(map, prefix + "CurrentPlayerSessionCount", this.CurrentPlayerSessionCount);
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamSimple(map, prefix + "MaximumPlayerSessionCount", this.MaximumPlayerSessionCount);
        }
    }
}

