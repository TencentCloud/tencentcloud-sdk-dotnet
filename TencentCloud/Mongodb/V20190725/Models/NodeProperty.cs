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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeProperty : AbstractModel
    {
        
        /// <summary>
        /// <p>节点所在的可用区。</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>节点名称。</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>节点访问地址。</p>
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>节点公网访问外网地址(IP或域名，示例为IP方式)。</p>
        /// </summary>
        [JsonProperty("WanServiceAddress")]
        public string WanServiceAddress{ get; set; }

        /// <summary>
        /// <p>节点角色。</p><ul><li>PRIMARY：主节点。</li><li>SECONDARY：从节点。</li><li>READONLY：只读节点。</li><li>ARBITER：仲裁节点。</li></ul>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>节点是否为 Hidden 节点。</p><ul><li>true：Hidden 节点。</li><li>false：非 Hidden 节点。</li></ul>
        /// </summary>
        [JsonProperty("Hidden")]
        public bool? Hidden{ get; set; }

        /// <summary>
        /// <p>节点状态。</p><ul><li>NORMAL：正常运行中。</li><li>STARTUP：正在启动。</li><li>STARTUP2：正在启动，处理中间数据。</li><li>RECOVERING：恢复中，暂不可用。</li><li>DOWN：已掉线。</li><li>UNKNOWN：未知状态。</li><li>ROLLBACK：回滚中。</li><li>REMOVED：已移除。</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>主从同步延迟时间，单位：秒。</p>
        /// </summary>
        [JsonProperty("SlaveDelay")]
        public long? SlaveDelay{ get; set; }

        /// <summary>
        /// <p>节点优先级。其取值范围为[0,100]，数值越高，优先级越高。</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>节点投票权。</p><ul><li>1：具有投票权。</li><li>0：无投票权。</li></ul>
        /// </summary>
        [JsonProperty("Votes")]
        public long? Votes{ get; set; }

        /// <summary>
        /// <p>节点标签。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public NodeTag[] Tags{ get; set; }

        /// <summary>
        /// <p>副本集 ID。</p>
        /// </summary>
        [JsonProperty("ReplicateSetId")]
        public string ReplicateSetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "WanServiceAddress", this.WanServiceAddress);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Hidden", this.Hidden);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SlaveDelay", this.SlaveDelay);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Votes", this.Votes);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ReplicateSetId", this.ReplicateSetId);
        }
    }
}

