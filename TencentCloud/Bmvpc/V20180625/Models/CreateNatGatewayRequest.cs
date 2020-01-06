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

namespace TencentCloud.Bmvpc.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNatGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// 转发模式，其中0表示IP方式，1表示网段方式；通过cidr方式可支持更多的IP接入到NAT网关
        /// </summary>
        [JsonProperty("ForwardMode")]
        public string ForwardMode{ get; set; }

        /// <summary>
        /// 私有网络ID，例如：vpc-kd7d06of
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// NAT名称
        /// </summary>
        [JsonProperty("NatName")]
        public string NatName{ get; set; }

        /// <summary>
        /// 并发连接数规格；取值为1000000、3000000、10000000，分别对应小型、中型、大型NAT网关
        /// </summary>
        [JsonProperty("MaxConcurrent")]
        public ulong? MaxConcurrent{ get; set; }

        /// <summary>
        /// 子网ID列表，子网下全部IP将加入NAT，不区分网关转发方式
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 部分IP信息，子网下只有该部分IP将加入NAT，仅当网关转发模式为IP方式有效；IpInfoSet和SubnetIds中的子网ID不能同时存在
        /// </summary>
        [JsonProperty("IpInfoSet")]
        public IpInfo[] IpInfoSet{ get; set; }

        /// <summary>
        /// 已分配的EIP列表, AssignedEips和AutoAllocEipNum至少输入一个
        /// </summary>
        [JsonProperty("AssignedEips")]
        public string[] AssignedEips{ get; set; }

        /// <summary>
        /// 新建EIP数目，系统将会按您的要求生产该数目个数EIP, AssignedEips和AutoAllocEipNum至少输入一个
        /// </summary>
        [JsonProperty("AutoAllocEipNum")]
        public ulong? AutoAllocEipNum{ get; set; }

        /// <summary>
        /// 独占标识，取值为0和1，默认值为0；0和1分别表示创建共享型NAT网关和独占NAT型网关；由于同一个VPC网络内，指向NAT集群的默认路由只有一条，因此VPC内只能创建一种类型NAT网关；创建独占型NAT网关时，需联系对应架构师进行独占NAT集群搭建，否则无法创建独占型NAT网关。
        /// </summary>
        [JsonProperty("Exclusive")]
        public ulong? Exclusive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ForwardMode", this.ForwardMode);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NatName", this.NatName);
            this.SetParamSimple(map, prefix + "MaxConcurrent", this.MaxConcurrent);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArrayObj(map, prefix + "IpInfoSet.", this.IpInfoSet);
            this.SetParamArraySimple(map, prefix + "AssignedEips.", this.AssignedEips);
            this.SetParamSimple(map, prefix + "AutoAllocEipNum", this.AutoAllocEipNum);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
        }
    }
}

