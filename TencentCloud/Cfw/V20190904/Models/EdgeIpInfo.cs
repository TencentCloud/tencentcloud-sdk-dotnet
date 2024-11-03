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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EdgeIpInfo : AbstractModel
    {
        
        /// <summary>
        /// 公网IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 公网 IP 类型 1 公网,2 弹性,3 弹性ipv6,4 anycastIP, 6 HighQualityEIP
        /// </summary>
        [JsonProperty("PublicIpType")]
        public long? PublicIpType{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 内网IP
        /// </summary>
        [JsonProperty("IntranetIp")]
        public string IntranetIp{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 风险端口数
        /// </summary>
        [JsonProperty("PortRiskCount")]
        public long? PortRiskCount{ get; set; }

        /// <summary>
        /// 最近扫描时间
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// 是否为region eip
        /// 0 不为region eip，不能选择串行
        /// 1 为region eip 可以选择串行
        /// </summary>
        [JsonProperty("IsRegionEip")]
        public long? IsRegionEip{ get; set; }

        /// <summary>
        /// EIP 所关联的VPC
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 0: 该地域暂未支持串行
        /// 1: 该用户未在该地域配置串行带宽
        /// 2: 该用户已在该地域配置串行带宽，可以开启串行开关
        /// </summary>
        [JsonProperty("IsSerialRegion")]
        public long? IsSerialRegion{ get; set; }

        /// <summary>
        /// 0: 不是公网CLB 可以开启串行开关
        /// 1: 是公网CLB 不可以开启串行开关
        /// </summary>
        [JsonProperty("IsPublicClb")]
        public long? IsPublicClb{ get; set; }

        /// <summary>
        /// 0: 开启开关时提示要创建私有连接。
        /// 1: 关闭该开关是提示删除私有连接。
        /// 如果大于 1: 关闭开关 、开启开关不需提示创建删除私有连接。
        /// </summary>
        [JsonProperty("EndpointBindEipNum")]
        public long? EndpointBindEipNum{ get; set; }

        /// <summary>
        /// 扫描深度
        /// </summary>
        [JsonProperty("ScanMode")]
        public string ScanMode{ get; set; }

        /// <summary>
        /// 扫描状态
        /// </summary>
        [JsonProperty("ScanStatus")]
        public long? ScanStatus{ get; set; }

        /// <summary>
        /// 开关状态
        /// 0 : 关闭
        /// 1 : 开启
        /// 2 : 开启中
        /// 3 : 关闭中
        /// 4 : 异常
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 私有连接ID
        /// </summary>
        [JsonProperty("EndpointId")]
        public string EndpointId{ get; set; }

        /// <summary>
        /// 私有连接IP
        /// </summary>
        [JsonProperty("EndpointIp")]
        public string EndpointIp{ get; set; }

        /// <summary>
        /// 0 : 旁路
        /// 1 : 串行
        /// 2 : 正在模式切换
        /// </summary>
        [JsonProperty("SwitchMode")]
        public ulong? SwitchMode{ get; set; }

        /// <summary>
        /// 开关权重
        /// </summary>
        [JsonProperty("SwitchWeight")]
        public long? SwitchWeight{ get; set; }

        /// <summary>
        /// 域名化CLB的域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// IP超量状态
        /// </summary>
        [JsonProperty("OverUsedStatus")]
        public long? OverUsedStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PublicIpType", this.PublicIpType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "IntranetIp", this.IntranetIp);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "PortRiskCount", this.PortRiskCount);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "IsRegionEip", this.IsRegionEip);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "IsSerialRegion", this.IsSerialRegion);
            this.SetParamSimple(map, prefix + "IsPublicClb", this.IsPublicClb);
            this.SetParamSimple(map, prefix + "EndpointBindEipNum", this.EndpointBindEipNum);
            this.SetParamSimple(map, prefix + "ScanMode", this.ScanMode);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EndpointId", this.EndpointId);
            this.SetParamSimple(map, prefix + "EndpointIp", this.EndpointIp);
            this.SetParamSimple(map, prefix + "SwitchMode", this.SwitchMode);
            this.SetParamSimple(map, prefix + "SwitchWeight", this.SwitchWeight);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "OverUsedStatus", this.OverUsedStatus);
        }
    }
}

