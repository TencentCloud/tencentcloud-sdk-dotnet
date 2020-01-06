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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterAdvancedSettings : AbstractModel
    {
        
        /// <summary>
        /// 是否启用IPVS
        /// </summary>
        [JsonProperty("IPVS")]
        public bool? IPVS{ get; set; }

        /// <summary>
        /// 是否启用集群节点自动扩缩容(创建集群流程不支持开启此功能)
        /// </summary>
        [JsonProperty("AsEnabled")]
        public bool? AsEnabled{ get; set; }

        /// <summary>
        /// 集群使用的runtime类型，包括"docker"和"containerd"两种类型，默认为"docker"
        /// </summary>
        [JsonProperty("ContainerRuntime")]
        public string ContainerRuntime{ get; set; }

        /// <summary>
        /// 集群中节点NodeName类型（包括 hostname,lan-ip两种形式，默认为lan-ip。如果开启了hostname模式，创建节点时需要设置HostName参数，并且InstanceName需要和HostName一致）
        /// </summary>
        [JsonProperty("NodeNameType")]
        public string NodeNameType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IPVS", this.IPVS);
            this.SetParamSimple(map, prefix + "AsEnabled", this.AsEnabled);
            this.SetParamSimple(map, prefix + "ContainerRuntime", this.ContainerRuntime);
            this.SetParamSimple(map, prefix + "NodeNameType", this.NodeNameType);
        }
    }
}

