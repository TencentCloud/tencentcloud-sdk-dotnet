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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulDefenceHost : AbstractModel
    {
        
        /// <summary>
        /// 主机名称/超级节点名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 主机ip即内网ip
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// 主机QUUID/超级节点ID
        /// </summary>
        [JsonProperty("HostID")]
        public string HostID{ get; set; }

        /// <summary>
        /// 插件状态，正常：SUCCESS，异常：FAIL， NO_DEFENDED:未防御
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 外网ip
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// 首次开启时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 节点类型[NORMAL:普通节点|SUPER:超级节点]
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 超级节点子网名称
        /// </summary>
        [JsonProperty("NodeSubNetName")]
        public string NodeSubNetName{ get; set; }

        /// <summary>
        /// 超级节点子网网段
        /// </summary>
        [JsonProperty("NodeSubNetCIDR")]
        public string NodeSubNetCIDR{ get; set; }

        /// <summary>
        /// 超级节点子网ID
        /// </summary>
        [JsonProperty("NodeSubNetID")]
        public string NodeSubNetID{ get; set; }

        /// <summary>
        /// 超级节点唯一ID
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// 超级节点ID
        /// </summary>
        [JsonProperty("NodeID")]
        public string NodeID{ get; set; }

        /// <summary>
        /// Pod Ip
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// Pod 名称
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeSubNetName", this.NodeSubNetName);
            this.SetParamSimple(map, prefix + "NodeSubNetCIDR", this.NodeSubNetCIDR);
            this.SetParamSimple(map, prefix + "NodeSubNetID", this.NodeSubNetID);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "NodeID", this.NodeID);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
        }
    }
}

