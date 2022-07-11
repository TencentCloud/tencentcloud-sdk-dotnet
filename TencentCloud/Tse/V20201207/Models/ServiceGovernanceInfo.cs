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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceGovernanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 引擎所在的地域
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }

        /// <summary>
        /// 服务治理引擎绑定的kubernetes集群信息
        /// </summary>
        [JsonProperty("BoundK8SInfos")]
        public BoundK8SInfo[] BoundK8SInfos{ get; set; }

        /// <summary>
        /// 服务治理引擎绑定的网络信息
        /// </summary>
        [JsonProperty("VpcInfos")]
        public VpcInfo[] VpcInfos{ get; set; }

        /// <summary>
        /// 当前实例鉴权是否开启
        /// </summary>
        [JsonProperty("AuthOpen")]
        public bool? AuthOpen{ get; set; }

        /// <summary>
        /// 该实例支持的功能，鉴权就是 Auth
        /// </summary>
        [JsonProperty("Features")]
        public string[] Features{ get; set; }

        /// <summary>
        /// 主账户名默认为 polaris，该值为主账户的默认密码
        /// </summary>
        [JsonProperty("MainPassword")]
        public string MainPassword{ get; set; }

        /// <summary>
        /// 服务治理pushgateway引擎绑定的网络信息
        /// </summary>
        [JsonProperty("PgwVpcInfos")]
        public VpcInfo[] PgwVpcInfos{ get; set; }


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
        }
    }
}

