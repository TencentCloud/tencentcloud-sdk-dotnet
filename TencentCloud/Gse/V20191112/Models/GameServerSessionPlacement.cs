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

    public class GameServerSessionPlacement : AbstractModel
    {
        
        /// <summary>
        /// 部署Id
        /// </summary>
        [JsonProperty("PlacementId")]
        public string PlacementId{ get; set; }

        /// <summary>
        /// 服务部署组名称
        /// </summary>
        [JsonProperty("GameServerSessionQueueName")]
        public string GameServerSessionQueueName{ get; set; }

        /// <summary>
        /// 玩家延迟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlayerLatencies")]
        public PlayerLatency[] PlayerLatencies{ get; set; }

        /// <summary>
        /// 服务部署状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 分配给正在运行游戏会话的实例的DNS标识符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DnsName")]
        public string DnsName{ get; set; }

        /// <summary>
        /// 游戏会话Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GameServerSessionId")]
        public string GameServerSessionId{ get; set; }

        /// <summary>
        /// 游戏会话名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GameServerSessionName")]
        public string GameServerSessionName{ get; set; }

        /// <summary>
        /// 服务部署区域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GameServerSessionRegion")]
        public string GameServerSessionRegion{ get; set; }

        /// <summary>
        /// 游戏属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GameProperties")]
        public GameProperty[] GameProperties{ get; set; }

        /// <summary>
        /// 游戏服务器允许同时连接到游戏会话的最大玩家数量，最小值1，最大值为玩家会话最大限额
        /// </summary>
        [JsonProperty("MaximumPlayerSessionCount")]
        public ulong? MaximumPlayerSessionCount{ get; set; }

        /// <summary>
        /// 游戏会话数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GameServerSessionData")]
        public string GameServerSessionData{ get; set; }

        /// <summary>
        /// 运行游戏会话的实例的IP地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpAddress")]
        public string IpAddress{ get; set; }

        /// <summary>
        /// 运行游戏会话的实例的端口号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 游戏匹配数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MatchmakerData")]
        public string MatchmakerData{ get; set; }

        /// <summary>
        /// 部署的玩家游戏数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlacedPlayerSessions")]
        public PlacedPlayerSession[] PlacedPlayerSessions{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlacementId", this.PlacementId);
            this.SetParamSimple(map, prefix + "GameServerSessionQueueName", this.GameServerSessionQueueName);
            this.SetParamArrayObj(map, prefix + "PlayerLatencies.", this.PlayerLatencies);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DnsName", this.DnsName);
            this.SetParamSimple(map, prefix + "GameServerSessionId", this.GameServerSessionId);
            this.SetParamSimple(map, prefix + "GameServerSessionName", this.GameServerSessionName);
            this.SetParamSimple(map, prefix + "GameServerSessionRegion", this.GameServerSessionRegion);
            this.SetParamArrayObj(map, prefix + "GameProperties.", this.GameProperties);
            this.SetParamSimple(map, prefix + "MaximumPlayerSessionCount", this.MaximumPlayerSessionCount);
            this.SetParamSimple(map, prefix + "GameServerSessionData", this.GameServerSessionData);
            this.SetParamSimple(map, prefix + "IpAddress", this.IpAddress);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "MatchmakerData", this.MatchmakerData);
            this.SetParamArrayObj(map, prefix + "PlacedPlayerSessions.", this.PlacedPlayerSessions);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

