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

namespace TencentCloud.Keewidb.V20220308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>产品版本。14：极速版。</p>
        /// </summary>
        [JsonProperty("TypeId")]
        public ulong? TypeId{ get; set; }

        /// <summary>
        /// <p>私有网络唯一ID。请登录控制台在私有网络列表查询，如：vpc-azlk3***。</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>私有网络所属子网唯一ID。请登录控制台在私有网络列表查询，如：subnet-8abje***。</p>
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// <p>计费模式。<ul><li>0：按量计费。</li><li>1：包年包月。</li></ul></p>
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// <p>实例数量，单次最大购买数量以查询产品售卖规格返回的数量为准。</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// <p>选择包年包月计费模式（BillingMode 设置为1）时，您需要选择购买实例的时长。单位：月，取值范围 [1,2,3,4,5,6,7,8,9,10,11,12,24,36]。按量计费（BillingMode 设置为0）实例该参数设置为1即可。</p>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>分片数量，支持选择3、5、6、8、9、10、12、15、16、18、20、21、24、25、27、30、32、33、35、36、39、40、42、45、48、50、51、54、55、56、57、60、63、64分片。</p>
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// <p>副本数。当前仅支持设置1个副本节点，即每一个分片仅包含1个主节点与1个副本节点，数据主从实时热备。</p>
        /// </summary>
        [JsonProperty("ReplicasNum")]
        public long? ReplicasNum{ get; set; }

        /// <summary>
        /// <p>实例内存容量，单位：GB。KeeWiDB 内存容量<b>MachineMemory</b>与持久内存容量<b>MemSize</b>为固定搭配，即2GB内存，固定分配8GB的持久内存，不可选择。具体信息，请参见<a href="https://cloud.tencent.com/document/product/1520/80808">产品规格</a>。</p>
        /// </summary>
        [JsonProperty("MachineMemory")]
        public long? MachineMemory{ get; set; }

        /// <summary>
        /// <p>实例所属的可用区ID。<ul><li>具体取值，请参见<a href="https://cloud.tencent.com/document/product/239/4106">地域和可用区</a>获取。</li><li>参数<b>ZoneId</b>和<b>ZoneName</b>至少配置其中一个。</li></ul></p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// <p>实例所属的可用区名称。<ul><li>具体取值，请参见<a href="https://cloud.tencent.com/document/product/239/4106">地域和可用区</a>获取。</li><li>参数<b>ZoneId</b>和<b>ZoneName</b>至少配置其中一个。</li></ul></p>
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// <p>创建实例的名称。仅支持长度小于60的中文、英文或者数字，短划线"-"、下划线"_"。</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>指明创建的实例是否需要支持免密访问。<ul><li>true：免密实例。</li><li>false：非免密实例，默认为非免密实例。此时，需要设置访问密码。</li></ul></p>
        /// </summary>
        [JsonProperty("NoAuth")]
        public bool? NoAuth{ get; set; }

        /// <summary>
        /// <p>实例访问密码。<ul><li>当参数<b>NoAuth</b>为<b>true</b>时，Password为无需设置，否则Password为必填参数。</li><li>密码复杂度要求：<ul><li>8-30个字符。</li><li>至少包含小写字母、大写字母、数字和字符 ()`~!@#$%^&amp;*-+=_|{}[]:;&lt;&gt;,.?/ 中的2种。</li><li>不能以"/"开头。</li></ul></li></ul></p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>自定义端口。默认为6379，范围[1024,65535]。</p>
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// <p>包年包月计费的续费模式。<ul><li>0：默认状态，指手动续费。</li><li>1：自动续费。</li><li>2：到期不再续费。</li></ul></p>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// <p>给实例设置安全组 ID 数组。</p>
        /// </summary>
        [JsonProperty("SecurityGroupIdList")]
        public string[] SecurityGroupIdList{ get; set; }

        /// <summary>
        /// <p>给实例绑定标签。</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>极速版，单分片持久化内存容量。KeeWiDB 内存容量<b>MachineMemory</b>与持久内存容量<b>MemSize</b>为固定搭配，即2GB内存，固定分配8GB的持久内存，不可选择。具体信息，请参见<a href="https://cloud.tencent.com/document/product/1520/80808">产品规格</a>。</p>单位：GB。
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// <p>每个分片硬盘的容量。单位：GB。每一缓存分片容量，对应的磁盘容量范围不同。具体信息，请参见<a href="https://cloud.tencent.com/document/product/1520/80808">产品规格</a>。</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// <p>计算 CPU 核数，可忽略不传。CPU 核数与内存为固定搭配，具体信息，请参见<a href="https://cloud.tencent.com/document/product/1520/80808">产品规格</a>。</p>
        /// </summary>
        [JsonProperty("MachineCpu")]
        public long? MachineCpu{ get; set; }

        /// <summary>
        /// <p>项目id，取值以用户账户&gt;用户账户相关接口查询&gt;项目列表返回的projectId为准。</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>数据压缩开关。<ul><li>ON：开启，默认开启压缩。</li><li>OFF：关闭。</li></ul></p>
        /// </summary>
        [JsonProperty("Compression")]
        public string Compression{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamSimple(map, prefix + "ReplicasNum", this.ReplicasNum);
            this.SetParamSimple(map, prefix + "MachineMemory", this.MachineMemory);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "NoAuth", this.NoAuth);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIdList.", this.SecurityGroupIdList);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "MachineCpu", this.MachineCpu);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Compression", this.Compression);
        }
    }
}

