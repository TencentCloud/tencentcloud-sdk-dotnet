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

    public class EdgeClusterAdvancedSettings : AbstractModel
    {
        
        /// <summary>
        /// 集群自定义参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraArgs")]
        public EdgeClusterExtraArgs ExtraArgs{ get; set; }

        /// <summary>
        /// 运行时类型，支持"docker"和"containerd"，默认为docker
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// 集群kube-proxy转发模式，支持"iptables"和"ipvs"，默认为iptables
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyMode")]
        public string ProxyMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ExtraArgs.", this.ExtraArgs);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamSimple(map, prefix + "ProxyMode", this.ProxyMode);
        }
    }
}

