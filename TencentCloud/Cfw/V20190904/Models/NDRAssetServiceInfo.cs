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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NDRAssetServiceInfo : AbstractModel
    {
        
        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 服务IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 服务端口
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// IP版本 
        /// "0": IPv4
        /// "1": IPv6
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }

        /// <summary>
        /// IP类型
        /// "0": 公网IP
        /// "1": EIP
        /// "-1": 内网IP
        /// </summary>
        [JsonProperty("IpType")]
        public string IpType{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("AssetService")]
        public string AssetService{ get; set; }

        /// <summary>
        /// 服务版本
        /// </summary>
        [JsonProperty("AssetVersion")]
        public string AssetVersion{ get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("AssetCategory")]
        public string AssetCategory{ get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 识别来源
        /// "0": 流量识别
        /// "1": 云资产实例
        /// </summary>
        [JsonProperty("IdentificationSource")]
        public string IdentificationSource{ get; set; }

        /// <summary>
        /// 首次识别时间
        /// </summary>
        [JsonProperty("FirstIdentificationTime")]
        public string FirstIdentificationTime{ get; set; }

        /// <summary>
        /// 最近识别时间
        /// </summary>
        [JsonProperty("LatestIdentificationTime")]
        public string LatestIdentificationTime{ get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        [JsonProperty("ServerAddr")]
        public string ServerAddr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "IpType", this.IpType);
            this.SetParamSimple(map, prefix + "AssetService", this.AssetService);
            this.SetParamSimple(map, prefix + "AssetVersion", this.AssetVersion);
            this.SetParamSimple(map, prefix + "AssetCategory", this.AssetCategory);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "IdentificationSource", this.IdentificationSource);
            this.SetParamSimple(map, prefix + "FirstIdentificationTime", this.FirstIdentificationTime);
            this.SetParamSimple(map, prefix + "LatestIdentificationTime", this.LatestIdentificationTime);
            this.SetParamSimple(map, prefix + "ServerAddr", this.ServerAddr);
        }
    }
}

