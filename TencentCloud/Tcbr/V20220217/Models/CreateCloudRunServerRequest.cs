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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudRunServerRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境Id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// 部署信息
        /// </summary>
        [JsonProperty("DeployInfo")]
        public DeployParam DeployInfo{ get; set; }

        /// <summary>
        /// 服务配置信息(已废弃)
        /// </summary>
        [JsonProperty("ServerConfig")]
        public ServerBaseConfig ServerConfig{ get; set; }

        /// <summary>
        /// 服务配置信息
        /// </summary>
        [JsonProperty("Items")]
        public DiffConfigItem[] Items{ get; set; }

        /// <summary>
        /// vpc 信息
        /// </summary>
        [JsonProperty("VpcInfo")]
        public CreateVpcInfo VpcInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamObj(map, prefix + "DeployInfo.", this.DeployInfo);
            this.SetParamObj(map, prefix + "ServerConfig.", this.ServerConfig);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamObj(map, prefix + "VpcInfo.", this.VpcInfo);
        }
    }
}

