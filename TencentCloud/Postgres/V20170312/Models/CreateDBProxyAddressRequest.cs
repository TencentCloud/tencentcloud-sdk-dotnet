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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDBProxyAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID，指定要创建代理地址的目标实例</p>
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// <p>VPC ID，代理地址所属的私有网络</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网 ID，代理地址所属的子网</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>代理组 ID。不传则按实例自动查找其默认代理组</p>
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// <p>安全组 ID 列表，用于代理地址的网络安全控制</p>
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// <p>代理地址备注信息，最长 256 个字符</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>连接池开关。true：开启连接池；false：关闭连接池</p>
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public bool? ConnectionPool{ get; set; }

        /// <summary>
        /// <p>权重模式。取值：<ul><li>system：系统自动分配权重</li><li>custom：手动指定权重，需配合 ProxyAllocation 参数使用</li></ul></p>
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// <p>路由权重列表。WeightMode 为 custom 时必填。若WeightMode传system或不传 ，则传入的权重不生效，由系统分配默认权重。</p>
        /// </summary>
        [JsonProperty("ProxyAllocation")]
        public ProxyRoute[] ProxyAllocation{ get; set; }

        /// <summary>
        /// <p>是否自动将新增的只读实例加入读写分离。true：自动加入；false：不自动加入</p>
        /// </summary>
        [JsonProperty("RoAutoAdd")]
        public bool? RoAutoAdd{ get; set; }

        /// <summary>
        /// <p>延迟剔除开关。true：开启延迟剔除，当只读实例延迟超过阈值时自动剔除路由；false：关闭延迟剔除。开启时 LatencyRemoveTime 必填</p>
        /// </summary>
        [JsonProperty("LatencyRemove")]
        public bool? LatencyRemove{ get; set; }

        /// <summary>
        /// <p>延迟剔除阈值，单位秒，取值范围 [1, 10000]。LatencyRemove 为 true 时必填</p>
        /// </summary>
        [JsonProperty("LatencyRemoveTime")]
        public ulong? LatencyRemoveTime{ get; set; }

        /// <summary>
        /// <p>最小路由节点数，取值范围 [0, 256]。用于防止延迟剔除将所有节点剔除后的兜底策略</p>
        /// </summary>
        [JsonProperty("MinRouteNum")]
        public ulong? MinRouteNum{ get; set; }

        /// <summary>
        /// <p>负载均衡策略</p><p>枚举值：</p><ul><li>0： 按活跃连接数(默认)</li><li>1： 按请求数</li></ul>
        /// </summary>
        [JsonProperty("LoadBalancePolicy")]
        public long? LoadBalancePolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConnectionPool", this.ConnectionPool);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamArrayObj(map, prefix + "ProxyAllocation.", this.ProxyAllocation);
            this.SetParamSimple(map, prefix + "RoAutoAdd", this.RoAutoAdd);
            this.SetParamSimple(map, prefix + "LatencyRemove", this.LatencyRemove);
            this.SetParamSimple(map, prefix + "LatencyRemoveTime", this.LatencyRemoveTime);
            this.SetParamSimple(map, prefix + "MinRouteNum", this.MinRouteNum);
            this.SetParamSimple(map, prefix + "LoadBalancePolicy", this.LoadBalancePolicy);
        }
    }
}

