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

    public class ProxyAddress : AbstractModel
    {
        
        /// <summary>
        /// <p>Proxy 接入地址 ID</p>
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// <p>Proxy 接入地址 IP</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>Proxy 接入地址端口</p>
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// <p>VPC ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网 ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>接入地址描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>是否开启连接池：0-未开启，1-开启</p>
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public bool? ConnectionPool{ get; set; }

        /// <summary>
        /// <p>路由列表</p>
        /// </summary>
        [JsonProperty("Routes")]
        public ProxyRoute[] Routes{ get; set; }

        /// <summary>
        /// <p>连接池大小</p>
        /// </summary>
        [JsonProperty("ConnectionPoolLimit")]
        public ulong? ConnectionPoolLimit{ get; set; }

        /// <summary>
        /// <p>读写分离开关。启用后 proxy 将读请求分发到只读节点，写请求仍走主节点。</p>
        /// </summary>
        [JsonProperty("RwSplitEnable")]
        public bool? RwSplitEnable{ get; set; }

        /// <summary>
        /// <p>权重模式</p><p>枚举值：</p><ul><li>system： 系统自动分配</li><li>custom： 用户自定义权重</li></ul>
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// <p>新增只读是否自动加入读写分离</p>
        /// </summary>
        [JsonProperty("RoAutoAdd")]
        public bool? RoAutoAdd{ get; set; }

        /// <summary>
        /// <p>延迟剔除开关</p>
        /// </summary>
        [JsonProperty("LatencyRemove")]
        public bool? LatencyRemove{ get; set; }

        /// <summary>
        /// <p>延迟剔除阈值</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("LatencyRemoveTime")]
        public ulong? LatencyRemoveTime{ get; set; }

        /// <summary>
        /// <p>最小保留路由数。在延迟/故障剔除时，至少保留的路由数量，防止所有节点被剔除导致服务不可用。</p>
        /// </summary>
        [JsonProperty("MinRouteNum")]
        public ulong? MinRouteNum{ get; set; }

        /// <summary>
        /// <p>只读全部异常时是否回切到主</p>
        /// </summary>
        [JsonProperty("FailOver")]
        public bool? FailOver{ get; set; }

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
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConnectionPool", this.ConnectionPool);
            this.SetParamArrayObj(map, prefix + "Routes.", this.Routes);
            this.SetParamSimple(map, prefix + "ConnectionPoolLimit", this.ConnectionPoolLimit);
            this.SetParamSimple(map, prefix + "RwSplitEnable", this.RwSplitEnable);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "RoAutoAdd", this.RoAutoAdd);
            this.SetParamSimple(map, prefix + "LatencyRemove", this.LatencyRemove);
            this.SetParamSimple(map, prefix + "LatencyRemoveTime", this.LatencyRemoveTime);
            this.SetParamSimple(map, prefix + "MinRouteNum", this.MinRouteNum);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "LoadBalancePolicy", this.LoadBalancePolicy);
        }
    }
}

