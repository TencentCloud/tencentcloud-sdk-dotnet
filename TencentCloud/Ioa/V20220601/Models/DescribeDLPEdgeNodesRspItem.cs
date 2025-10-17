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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDLPEdgeNodesRspItem : AbstractModel
    {
        
        /// <summary>
        /// 自增id，数据库中唯一
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 节点分组唯一id
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [JsonProperty("EdgeNodeId")]
        public string EdgeNodeId{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("EdgeNodeName")]
        public string EdgeNodeName{ get; set; }

        /// <summary>
        /// 是否活跃/连通
        /// </summary>
        [JsonProperty("IsActive")]
        public bool? IsActive{ get; set; }

        /// <summary>
        /// 节点分组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 节点IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 节点版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 是否支持升级连接器
        /// </summary>
        [JsonProperty("IsUpgradeEnable")]
        public bool? IsUpgradeEnable{ get; set; }

        /// <summary>
        /// 升级状态: 0(升级中) , 1(升级失败) 或 2(升级成功)
        /// </summary>
        [JsonProperty("UpgradeStatus")]
        public long? UpgradeStatus{ get; set; }

        /// <summary>
        /// 升级状态描述
        /// </summary>
        [JsonProperty("UpgradeDescription")]
        public string UpgradeDescription{ get; set; }

        /// <summary>
        /// 规则版本
        /// </summary>
        [JsonProperty("RuleVersion")]
        public string RuleVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "EdgeNodeId", this.EdgeNodeId);
            this.SetParamSimple(map, prefix + "EdgeNodeName", this.EdgeNodeName);
            this.SetParamSimple(map, prefix + "IsActive", this.IsActive);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "IsUpgradeEnable", this.IsUpgradeEnable);
            this.SetParamSimple(map, prefix + "UpgradeStatus", this.UpgradeStatus);
            this.SetParamSimple(map, prefix + "UpgradeDescription", this.UpgradeDescription);
            this.SetParamSimple(map, prefix + "RuleVersion", this.RuleVersion);
        }
    }
}

