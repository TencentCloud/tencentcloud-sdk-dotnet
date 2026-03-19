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
        /// 服务元数据信息，如服务名
        /// </summary>
        [JsonProperty("ServiceMetaData")]
        public ServiceMetaData ServiceMetaData{ get; set; }

        /// <summary>
        /// 资源相关信息
        /// </summary>
        [JsonProperty("ComputeInfo")]
        public ComputeInfo ComputeInfo{ get; set; }

        /// <summary>
        /// 服务部署信息
        /// </summary>
        [JsonProperty("DeploymentConfigs")]
        public DeploymentConfig[] DeploymentConfigs{ get; set; }

        /// <summary>
        /// 服务超参数配置
        /// </summary>
        [JsonProperty("HyperParam")]
        public HyperParam HyperParam{ get; set; }

        /// <summary>
        /// 网络设置
        /// </summary>
        [JsonProperty("NetworkSetting")]
        public NetworkSetting NetworkSetting{ get; set; }


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
        }
    }
}

