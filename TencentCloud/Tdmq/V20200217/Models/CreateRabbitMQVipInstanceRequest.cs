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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRabbitMQVipInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// 私有网络ID，形如 vpc-xxx。有效的 VpcId 可通过登录[私有网络](https://console.cloud.tencent.com/vpc/vpc?rid=1)控制台查询；也可以调用接口 [DescribeVpcEx](https://cloud.tencent.com/document/api/215/1372)，从接口返回中的 unVpcId 字段获取。若在创建子机时 VpcId 与 SubnetId 同时传入 DEFAULT，则强制使用默认 vpc 网络。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络子网 ID，形如 subnet-xxx。有效的私有网络子网 ID 可通过登录[子网控制台](https://console.cloud.tencent.com/vpc/subnet?rid=1)查询；也可以调用接口 [DescribeSubnets](https://cloud.tencent.com/document/api/215/15784)，从接口返回中的 unSubnetId 字段获取。若在创建子机时 SubnetId 与 VpcId 同时传入 DEFAULT，则强制使用默认 vpc 网络。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群的节点规格，需要输入对应的规格标识：
        /// 2C8G：rabbit-vip-basic-2c8g
        /// 4C16G：rabbit-vip-basic-4c16g
        /// 8C32G：rabbit-vip-basic-8c32g
        /// 16C32G：rabbit-vip-basic-4
        /// 16C64G：rabbit-vip-basic-16c64g
        /// 2C4G：rabbit-vip-basic-5
        /// 4C8G：rabbit-vip-basic-1
        /// 8C16G（已售罄）：rabbit-vip-basic-2
        /// 不传默认为 4C8G：rabbit-vip-basic-1
        /// </summary>
        [JsonProperty("NodeSpec")]
        public string NodeSpec{ get; set; }

        /// <summary>
        /// 节点数量,多可用区最少为3节点。不传默认单可用区为1,多可用区为3
        /// </summary>
        [JsonProperty("NodeNum")]
        public long? NodeNum{ get; set; }

        /// <summary>
        /// 单节点存储规格,不传默认为200G
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// 是否开启默认镜像队列，true 表示为开启，false 表示为不开启。不传默认为 false
        /// </summary>
        [JsonProperty("EnableCreateDefaultHaMirrorQueue")]
        public bool? EnableCreateDefaultHaMirrorQueue{ get; set; }

        /// <summary>
        /// 仅预付费集群（PayMode 参数为 1 时）使用该参数，表示是否自动续费，true 表示打开自动续费。不传默认为 true
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public bool? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 购买时长,不传默认为1(月)
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 付费方式，0 为后付费，即按量计费；1 为预付费，即包年包月。默认包年包月
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 集群版本，不传默认为 3.8.30，可选值为 3.8.30 和 3.11.8
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// 是否国际站请求，默认 false
        /// </summary>
        [JsonProperty("IsIntl")]
        public bool? IsIntl{ get; set; }

        /// <summary>
        /// 资源标签列表
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// 公网带宽大小，单位 Mbps
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// 是否打开公网接入，不传默认为false
        /// </summary>
        [JsonProperty("EnablePublicAccess")]
        public bool? EnablePublicAccess{ get; set; }

        /// <summary>
        /// 是否打开集群删除保护，不传默认为 false
        /// </summary>
        [JsonProperty("EnableDeletionProtection")]
        public bool? EnableDeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "NodeSpec", this.NodeSpec);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "EnableCreateDefaultHaMirrorQueue", this.EnableCreateDefaultHaMirrorQueue);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "IsIntl", this.IsIntl);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "EnablePublicAccess", this.EnablePublicAccess);
            this.SetParamSimple(map, prefix + "EnableDeletionProtection", this.EnableDeletionProtection);
        }
    }
}

