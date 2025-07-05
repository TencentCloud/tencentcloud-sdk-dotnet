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

    public class PlayerSession : AbstractModel
    {
        
        /// <summary>
        /// 玩家会话创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 游戏服务器会话运行的DNS标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DnsName")]
        public string DnsName{ get; set; }

        /// <summary>
        /// 舰队ID
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// 游戏服务器会话ID，最小长度1个ASCII字符，最大长度不超过256个ASCII字符
        /// </summary>
        [JsonProperty("GameServerSessionId")]
        public string GameServerSessionId{ get; set; }

        /// <summary>
        /// 游戏服务器会话运行的CVM地址
        /// </summary>
        [JsonProperty("IpAddress")]
        public string IpAddress{ get; set; }

        /// <summary>
        /// 玩家自定义数据，最大长度2048个ASCII字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlayerData")]
        public string PlayerData{ get; set; }

        /// <summary>
        /// 玩家ID，最大长度1024个ASCII字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlayerId")]
        public string PlayerId{ get; set; }

        /// <summary>
        /// 玩家会话ID
        /// </summary>
        [JsonProperty("PlayerSessionId")]
        public string PlayerSessionId{ get; set; }

        /// <summary>
        /// 端口号，最小值不小于1，最大值不超过60000
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 玩家会话的状态（RESERVED = 1,ACTIVE = 2,COMPLETED = 3,TIMEDOUT = 4）
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 玩家会话终止时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TerminationTime")]
        public string TerminationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "DnsName", this.DnsName);
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamSimple(map, prefix + "GameServerSessionId", this.GameServerSessionId);
            this.SetParamSimple(map, prefix + "IpAddress", this.IpAddress);
            this.SetParamSimple(map, prefix + "PlayerData", this.PlayerData);
            this.SetParamSimple(map, prefix + "PlayerId", this.PlayerId);
            this.SetParamSimple(map, prefix + "PlayerSessionId", this.PlayerSessionId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TerminationTime", this.TerminationTime);
        }
    }
}

