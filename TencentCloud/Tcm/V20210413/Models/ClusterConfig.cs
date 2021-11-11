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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterConfig : AbstractModel
    {
        
        /// <summary>
        /// 自动注入SideCar的NameSpace
        /// </summary>
        [JsonProperty("AutoInjectionNamespaceList")]
        public string[] AutoInjectionNamespaceList{ get; set; }

        /// <summary>
        /// Ingress配置列表
        /// </summary>
        [JsonProperty("IngressGatewayList")]
        public IngressGateway[] IngressGatewayList{ get; set; }

        /// <summary>
        /// Egress配置列表
        /// </summary>
        [JsonProperty("EgressGatewayList")]
        public EgressGateway[] EgressGatewayList{ get; set; }

        /// <summary>
        /// Istiod配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Istiod")]
        public IstiodConfig Istiod{ get; set; }

        /// <summary>
        /// 部署配置
        /// </summary>
        [JsonProperty("DeployConfig")]
        public DeployConfig DeployConfig{ get; set; }

        /// <summary>
        /// 自动注入命名空间状态列表
        /// </summary>
        [JsonProperty("AutoInjectionNamespaceStateList")]
        public AutoInjectionNamespaceState[] AutoInjectionNamespaceStateList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AutoInjectionNamespaceList.", this.AutoInjectionNamespaceList);
            this.SetParamArrayObj(map, prefix + "IngressGatewayList.", this.IngressGatewayList);
            this.SetParamArrayObj(map, prefix + "EgressGatewayList.", this.EgressGatewayList);
            this.SetParamObj(map, prefix + "Istiod.", this.Istiod);
            this.SetParamObj(map, prefix + "DeployConfig.", this.DeployConfig);
            this.SetParamArrayObj(map, prefix + "AutoInjectionNamespaceStateList.", this.AutoInjectionNamespaceStateList);
        }
    }
}

