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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCdbProxyAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>代理组 ID。可通过 <a href="https://cloud.tencent.com/document/api/236/90585">DescribeCdbProxyInfo</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// <p>权重分配模式，<br>系统自动分配：&quot;system&quot;， 自定义：&quot;custom&quot;</p>
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// <p>是否开启延迟剔除，取值：&quot;true&quot; | &quot;false&quot;</p>
        /// </summary>
        [JsonProperty("IsKickOut")]
        public bool? IsKickOut{ get; set; }

        /// <summary>
        /// <p>最小保留数量，最小取值：0</p>
        /// </summary>
        [JsonProperty("MinCount")]
        public ulong? MinCount{ get; set; }

        /// <summary>
        /// <p>延迟剔除阈值，最小取值：1，范围：1 - 10000，整数。</p>
        /// </summary>
        [JsonProperty("MaxDelay")]
        public ulong? MaxDelay{ get; set; }

        /// <summary>
        /// <p>是否开启故障转移，取值：&quot;true&quot; | &quot;false&quot;</p>
        /// </summary>
        [JsonProperty("FailOver")]
        public bool? FailOver{ get; set; }

        /// <summary>
        /// <p>是否自动添加RO，取值：&quot;true&quot; | &quot;false&quot;</p>
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public bool? AutoAddRo{ get; set; }

        /// <summary>
        /// <p>是否是只读，取值：&quot;true&quot; | &quot;false&quot;</p>
        /// </summary>
        [JsonProperty("ReadOnly")]
        public bool? ReadOnly{ get; set; }

        /// <summary>
        /// <p>是否开启事务分离，取值：&quot;true&quot; | &quot;false&quot;</p>
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// <p>读写权重分配</p>
        /// </summary>
        [JsonProperty("ProxyAllocation")]
        public ProxyAllocation[] ProxyAllocation{ get; set; }

        /// <summary>
        /// <p>私有网络 ID。可通过 <a href="https://cloud.tencent.com/document/product/236/15872">DescribeDBInstances</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>私有子网 ID。可通过 <a href="https://cloud.tencent.com/document/product/236/15872">DescribeDBInstances</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// <p>是否开启连接池。默认关闭。<br>注意：如需使用数据库代理连接池能力，MySQL 8.0 主实例的内核小版本要大于等于 MySQL 8.0 20230630。</p>
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public bool? ConnectionPool{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// <p>IP 地址。不填则默认为所选 VPC 下支持的随机一个 IP。</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>端口。默认值3306。</p>
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// <p>安全组</p>
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// <p>连接池类型。可选值 transaction（事务级别连接池），connection（会话级别连接池），ConnectionPool 为 true 时生效。默认值：connection。</p>
        /// </summary>
        [JsonProperty("ConnectionPoolType")]
        public string ConnectionPoolType{ get; set; }

        /// <summary>
        /// <p>是否开启自适应负载均衡。默认关闭。</p>
        /// </summary>
        [JsonProperty("AutoLoadBalance")]
        public bool? AutoLoadBalance{ get; set; }

        /// <summary>
        /// <p>接入模式。</p><p>枚举值：</p><ul><li>nearBy： 就近访问</li><li>balance： 均衡分配</li><li>direct_nearby： 纯网络转发就近访问</li><li>direct_balance： 纯网络转发均衡分配</li></ul><p>默认值：nearBy</p>
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "IsKickOut", this.IsKickOut);
            this.SetParamSimple(map, prefix + "MinCount", this.MinCount);
            this.SetParamSimple(map, prefix + "MaxDelay", this.MaxDelay);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamArrayObj(map, prefix + "ProxyAllocation.", this.ProxyAllocation);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "ConnectionPool", this.ConnectionPool);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "ConnectionPoolType", this.ConnectionPoolType);
            this.SetParamSimple(map, prefix + "AutoLoadBalance", this.AutoLoadBalance);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
        }
    }
}

