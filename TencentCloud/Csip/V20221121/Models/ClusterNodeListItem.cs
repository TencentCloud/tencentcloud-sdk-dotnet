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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterNodeListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>资产 ID</p>
        /// </summary>
        [JsonProperty("AssetId")]
        [System.Obsolete]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>节点id</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>节点名称</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>公网ip</p>
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// <p>内网ip</p>
        /// </summary>
        [JsonProperty("InternalIP")]
        public string InternalIP{ get; set; }

        /// <summary>
        /// <p>节点类型</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>核数</p>
        /// </summary>
        [JsonProperty("CoresCount")]
        public long? CoresCount{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>运行状态</p>
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

        /// <summary>
        /// <p>是否为新资产</p>
        /// </summary>
        [JsonProperty("IsNew")]
        public bool? IsNew{ get; set; }

        /// <summary>
        /// <p>节点唯一 ID</p>
        /// </summary>
        [JsonProperty("UniqueID")]
        public string UniqueID{ get; set; }

        /// <summary>
        /// <p>客户端状态</p><p>枚举值：</p><ul><li>ONLINE： 在线</li><li>OFFLINE： 离线</li><li>UNINSTALL： 未安装</li></ul>
        /// </summary>
        [JsonProperty("ClientStatus")]
        public string ClientStatus{ get; set; }

        /// <summary>
        /// <p>节点实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "InternalIP", this.InternalIP);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "CoresCount", this.CoresCount);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamSimple(map, prefix + "UniqueID", this.UniqueID);
            this.SetParamSimple(map, prefix + "ClientStatus", this.ClientStatus);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

