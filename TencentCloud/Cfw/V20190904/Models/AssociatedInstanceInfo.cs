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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssociatedInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>实例类型，3是cvm实例,4是clb实例,5是eni实例,6是云数据库</p>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// <p>私有网络ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>私有网络名称</p>
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// <p>公网IP</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>内网IP</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>关联安全组数量</p>
        /// </summary>
        [JsonProperty("SecurityGroupCount")]
        public ulong? SecurityGroupCount{ get; set; }

        /// <summary>
        /// <p>关联安全组规则数量</p>
        /// </summary>
        [JsonProperty("SecurityGroupRuleCount")]
        public ulong? SecurityGroupRuleCount{ get; set; }

        /// <summary>
        /// <p>关联数据库代理Id</p>
        /// </summary>
        [JsonProperty("CdbId")]
        public string CdbId{ get; set; }

        /// <summary>
        /// <p>容器服务集群ID</p>
        /// </summary>
        [JsonProperty("TkeClusterId")]
        public string TkeClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "SecurityGroupCount", this.SecurityGroupCount);
            this.SetParamSimple(map, prefix + "SecurityGroupRuleCount", this.SecurityGroupRuleCount);
            this.SetParamSimple(map, prefix + "CdbId", this.CdbId);
            this.SetParamSimple(map, prefix + "TkeClusterId", this.TkeClusterId);
        }
    }
}

