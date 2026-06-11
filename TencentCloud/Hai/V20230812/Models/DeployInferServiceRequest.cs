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

namespace TencentCloud.Hai.V20230812.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployInferServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>服务元数据信息，如服务名</p>
        /// </summary>
        [JsonProperty("ServiceMetaData")]
        public ServiceMetaData ServiceMetaData{ get; set; }

        /// <summary>
        /// <p>资源相关信息</p>
        /// </summary>
        [JsonProperty("ComputeInfo")]
        public ComputeInfo ComputeInfo{ get; set; }

        /// <summary>
        /// <p>服务部署信息</p>
        /// </summary>
        [JsonProperty("DeploymentConfigs")]
        public DeploymentConfig[] DeploymentConfigs{ get; set; }

        /// <summary>
        /// <p>服务超参数配置</p>
        /// </summary>
        [JsonProperty("HyperParam")]
        public HyperParam HyperParam{ get; set; }

        /// <summary>
        /// <p>网络设置</p>
        /// </summary>
        [JsonProperty("NetworkSetting")]
        public NetworkSetting NetworkSetting{ get; set; }

        /// <summary>
        /// <p>安全类型</p><p>枚举值：</p><ul><li>STANDARD： 标准推理</li><li>CONFIDENTIAL： 可信推理</li></ul>
        /// </summary>
        [JsonProperty("SecurityType")]
        public string SecurityType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ServiceMetaData.", this.ServiceMetaData);
            this.SetParamObj(map, prefix + "ComputeInfo.", this.ComputeInfo);
            this.SetParamArrayObj(map, prefix + "DeploymentConfigs.", this.DeploymentConfigs);
            this.SetParamObj(map, prefix + "HyperParam.", this.HyperParam);
            this.SetParamObj(map, prefix + "NetworkSetting.", this.NetworkSetting);
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
        }
    }
}

