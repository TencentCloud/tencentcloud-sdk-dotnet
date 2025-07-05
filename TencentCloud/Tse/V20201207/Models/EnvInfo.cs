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

    public class EnvInfo : AbstractModel
    {
        
        /// <summary>
        /// 环境名称
        /// </summary>
        [JsonProperty("EnvName")]
        public string EnvName{ get; set; }

        /// <summary>
        /// 环境对应的网络信息
        /// </summary>
        [JsonProperty("VpcInfos")]
        public VpcInfo[] VpcInfos{ get; set; }

        /// <summary>
        /// 云硬盘容量
        /// </summary>
        [JsonProperty("StorageCapacity")]
        public long? StorageCapacity{ get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Admin service 访问地址
        /// </summary>
        [JsonProperty("AdminServiceIp")]
        public string AdminServiceIp{ get; set; }

        /// <summary>
        /// Config service访问地址
        /// </summary>
        [JsonProperty("ConfigServiceIp")]
        public string ConfigServiceIp{ get; set; }

        /// <summary>
        /// 是否开启config-server公网
        /// </summary>
        [JsonProperty("EnableConfigInternet")]
        public bool? EnableConfigInternet{ get; set; }

        /// <summary>
        /// config-server公网访问地址
        /// </summary>
        [JsonProperty("ConfigInternetServiceIp")]
        public string ConfigInternetServiceIp{ get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [JsonProperty("SpecId")]
        public string SpecId{ get; set; }

        /// <summary>
        /// 环境的节点数
        /// </summary>
        [JsonProperty("EnvReplica")]
        public long? EnvReplica{ get; set; }

        /// <summary>
        /// 环境运行的节点数
        /// </summary>
        [JsonProperty("RunningCount")]
        public long? RunningCount{ get; set; }

        /// <summary>
        /// 环境别名
        /// </summary>
        [JsonProperty("AliasEnvName")]
        public string AliasEnvName{ get; set; }

        /// <summary>
        /// 环境描述
        /// </summary>
        [JsonProperty("EnvDesc")]
        public string EnvDesc{ get; set; }

        /// <summary>
        /// 客户端带宽
        /// </summary>
        [JsonProperty("ClientBandWidth")]
        public ulong? ClientBandWidth{ get; set; }

        /// <summary>
        /// 客户端内网开关
        /// </summary>
        [JsonProperty("EnableConfigIntranet")]
        public bool? EnableConfigIntranet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvName", this.EnvName);
            this.SetParamArrayObj(map, prefix + "VpcInfos.", this.VpcInfos);
            this.SetParamSimple(map, prefix + "StorageCapacity", this.StorageCapacity);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AdminServiceIp", this.AdminServiceIp);
            this.SetParamSimple(map, prefix + "ConfigServiceIp", this.ConfigServiceIp);
            this.SetParamSimple(map, prefix + "EnableConfigInternet", this.EnableConfigInternet);
            this.SetParamSimple(map, prefix + "ConfigInternetServiceIp", this.ConfigInternetServiceIp);
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "EnvReplica", this.EnvReplica);
            this.SetParamSimple(map, prefix + "RunningCount", this.RunningCount);
            this.SetParamSimple(map, prefix + "AliasEnvName", this.AliasEnvName);
            this.SetParamSimple(map, prefix + "EnvDesc", this.EnvDesc);
            this.SetParamSimple(map, prefix + "ClientBandWidth", this.ClientBandWidth);
            this.SetParamSimple(map, prefix + "EnableConfigIntranet", this.EnableConfigIntranet);
        }
    }
}

