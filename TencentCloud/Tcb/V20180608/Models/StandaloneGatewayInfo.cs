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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StandaloneGatewayInfo : AbstractModel
    {
        
        /// <summary>
        /// 独立网关名称
        /// </summary>
        [JsonProperty("GatewayName")]
        public string GatewayName{ get; set; }

        /// <summary>
        /// CPU核心数
        /// </summary>
        [JsonProperty("CPU")]
        public float? CPU{ get; set; }

        /// <summary>
        /// 内存大小，单位MB
        /// </summary>
        [JsonProperty("Mem")]
        public ulong? Mem{ get; set; }

        /// <summary>
        /// 套餐包版本名称
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// 网关别名
        /// </summary>
        [JsonProperty("GatewayAlias")]
        public string GatewayAlias{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID列表
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 网关描述
        /// </summary>
        [JsonProperty("GatewayDesc")]
        public string GatewayDesc{ get; set; }

        /// <summary>
        /// 网关状态
        /// </summary>
        [JsonProperty("GateWayStatus")]
        public string GateWayStatus{ get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        [JsonProperty("ServiceInfo")]
        public BackendServiceInfo ServiceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayName", this.GatewayName);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamSimple(map, prefix + "GatewayAlias", this.GatewayAlias);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "GatewayDesc", this.GatewayDesc);
            this.SetParamSimple(map, prefix + "GateWayStatus", this.GateWayStatus);
            this.SetParamObj(map, prefix + "ServiceInfo.", this.ServiceInfo);
        }
    }
}

