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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyGroupRwInfo : AbstractModel
    {
        
        /// <summary>
        /// 一致性类型 eventual-最终一致性,global-全局一致性,session-会话一致性
        /// </summary>
        [JsonProperty("ConsistencyType")]
        public string ConsistencyType{ get; set; }

        /// <summary>
        /// 一致性超时时间
        /// </summary>
        [JsonProperty("ConsistencyTimeOut")]
        public long? ConsistencyTimeOut{ get; set; }

        /// <summary>
        /// 权重模式 system-系统分配，custom-自定义
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// 是否开启故障转移
        /// </summary>
        [JsonProperty("FailOver")]
        public string FailOver{ get; set; }

        /// <summary>
        /// 是否自动添加只读实例，yes-是，no-不自动添加
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public string AutoAddRo{ get; set; }

        /// <summary>
        /// 实例权重数组
        /// </summary>
        [JsonProperty("InstanceWeights")]
        public ProxyInstanceWeight[] InstanceWeights{ get; set; }

        /// <summary>
        /// 是否开通读写节点，yse-是，no-否
        /// </summary>
        [JsonProperty("OpenRw")]
        public string OpenRw{ get; set; }

        /// <summary>
        /// 读写属性，可选值：READWRITE,READONLY
        /// </summary>
        [JsonProperty("RwType")]
        public string RwType{ get; set; }

        /// <summary>
        /// 事务拆分
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// 连接模式，可选值：balance，nearby
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// 是否将libra节点当作普通RO节点
        /// </summary>
        [JsonProperty("ApNodeAsRoNode")]
        public bool? ApNodeAsRoNode{ get; set; }

        /// <summary>
        /// libra节点故障，是否转发给其他节点
        /// </summary>
        [JsonProperty("ApQueryToOtherNode")]
        public bool? ApQueryToOtherNode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsistencyType", this.ConsistencyType);
            this.SetParamSimple(map, prefix + "ConsistencyTimeOut", this.ConsistencyTimeOut);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamArrayObj(map, prefix + "InstanceWeights.", this.InstanceWeights);
            this.SetParamSimple(map, prefix + "OpenRw", this.OpenRw);
            this.SetParamSimple(map, prefix + "RwType", this.RwType);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "ApNodeAsRoNode", this.ApNodeAsRoNode);
            this.SetParamSimple(map, prefix + "ApQueryToOtherNode", this.ApQueryToOtherNode);
        }
    }
}

