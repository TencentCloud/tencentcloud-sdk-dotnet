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

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// appid信息
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 资产来源
        /// 1公网 2内网
        /// </summary>
        [JsonProperty("InsSource")]
        public string InsSource{ get; set; }

        /// <summary>
        /// 资产类型
        ///  3是cvm实例,4是clb实例,5是eni实例,6是mysql,7是redis,8是NAT,9是VPN,10是ES,11是MARIADB,12是KAFKA 13 NATFW
        /// </summary>
        [JsonProperty("InsType")]
        public long? InsType{ get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 资产名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 漏洞数
        /// </summary>
        [JsonProperty("LeakNum")]
        public string LeakNum{ get; set; }

        /// <summary>
        /// 端口数
        /// </summary>
        [JsonProperty("PortNum")]
        public string PortNum{ get; set; }

        /// <summary>
        /// 内网ip
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 公网ip
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("RegionKey")]
        public string RegionKey{ get; set; }

        /// <summary>
        /// 资产路径
        /// </summary>
        [JsonProperty("ResourcePath")]
        public string[] ResourcePath{ get; set; }

        /// <summary>
        /// 扫描结果
        /// </summary>
        [JsonProperty("Server")]
        public string[] Server{ get; set; }

        /// <summary>
        /// 子网id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// vpc名称
        /// </summary>
        [JsonProperty("VPCName")]
        public string VPCName{ get; set; }

        /// <summary>
        /// vpcid信息
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "InsSource", this.InsSource);
            this.SetParamSimple(map, prefix + "InsType", this.InsType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "LeakNum", this.LeakNum);
            this.SetParamSimple(map, prefix + "PortNum", this.PortNum);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionKey", this.RegionKey);
            this.SetParamArraySimple(map, prefix + "ResourcePath.", this.ResourcePath);
            this.SetParamArraySimple(map, prefix + "Server.", this.Server);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VPCName", this.VPCName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
        }
    }
}

