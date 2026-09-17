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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceGovernanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>引擎所在的地域</p>
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }

        /// <summary>
        /// <p>服务治理引擎绑定的kubernetes集群信息</p>
        /// </summary>
        [JsonProperty("BoundK8SInfos")]
        public BoundK8SInfo[] BoundK8SInfos{ get; set; }

        /// <summary>
        /// <p>服务治理引擎绑定的网络信息</p>
        /// </summary>
        [JsonProperty("VpcInfos")]
        public VpcInfo[] VpcInfos{ get; set; }

        /// <summary>
        /// <p>当前实例鉴权是否开启</p>
        /// </summary>
        [JsonProperty("AuthOpen")]
        public bool? AuthOpen{ get; set; }

        /// <summary>
        /// <p>该实例支持的功能，鉴权就是 Auth</p>
        /// </summary>
        [JsonProperty("Features")]
        public string[] Features{ get; set; }

        /// <summary>
        /// <p>主账户名默认为 polaris，该值为主账户的默认密码</p>
        /// </summary>
        [JsonProperty("MainPassword")]
        public string MainPassword{ get; set; }

        /// <summary>
        /// <p>服务治理pushgateway引擎绑定的网络信息</p>
        /// </summary>
        [JsonProperty("PgwVpcInfos")]
        public VpcInfo[] PgwVpcInfos{ get; set; }

        /// <summary>
        /// <p>服务治理限流server引擎绑定的网络信息</p>
        /// </summary>
        [JsonProperty("LimiterVpcInfos")]
        public VpcInfo[] LimiterVpcInfos{ get; set; }

        /// <summary>
        /// <p>引擎关联CLS日志主题信息</p>
        /// </summary>
        [JsonProperty("CLSTopics")]
        public PolarisCLSTopicInfo[] CLSTopics{ get; set; }

        /// <summary>
        /// <p>子用户密码</p>
        /// </summary>
        [JsonProperty("SubPassword")]
        public string SubPassword{ get; set; }

        /// <summary>
        /// <p>是否允许变更</p>
        /// </summary>
        [JsonProperty("DisableMutation")]
        public bool? DisableMutation{ get; set; }

        /// <summary>
        /// <p>是否开启限流</p>
        /// </summary>
        [JsonProperty("MaxCapacityLimitEnabled")]
        public bool? MaxCapacityLimitEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineRegion", this.EngineRegion);
            this.SetParamArrayObj(map, prefix + "BoundK8SInfos.", this.BoundK8SInfos);
            this.SetParamArrayObj(map, prefix + "VpcInfos.", this.VpcInfos);
            this.SetParamSimple(map, prefix + "AuthOpen", this.AuthOpen);
            this.SetParamArraySimple(map, prefix + "Features.", this.Features);
            this.SetParamSimple(map, prefix + "MainPassword", this.MainPassword);
            this.SetParamArrayObj(map, prefix + "PgwVpcInfos.", this.PgwVpcInfos);
            this.SetParamArrayObj(map, prefix + "LimiterVpcInfos.", this.LimiterVpcInfos);
            this.SetParamArrayObj(map, prefix + "CLSTopics.", this.CLSTopics);
            this.SetParamSimple(map, prefix + "SubPassword", this.SubPassword);
            this.SetParamSimple(map, prefix + "DisableMutation", this.DisableMutation);
            this.SetParamSimple(map, prefix + "MaxCapacityLimitEnabled", this.MaxCapacityLimitEnabled);
        }
    }
}

