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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQClusterSpecInfo : AbstractModel
    {
        
        /// <summary>
        /// 集群规格名称
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// 峰值tps
        /// </summary>
        [JsonProperty("MaxTps")]
        public ulong? MaxTps{ get; set; }

        /// <summary>
        /// 最大队列数
        /// </summary>
        [JsonProperty("MaxQueueNum")]
        public ulong? MaxQueueNum{ get; set; }

        /// <summary>
        /// 最大交换机数
        /// </summary>
        [JsonProperty("MaxExchangeNum")]
        public ulong? MaxExchangeNum{ get; set; }

        /// <summary>
        /// 最大vhost数
        /// </summary>
        [JsonProperty("MaxVhostNum")]
        public ulong? MaxVhostNum{ get; set; }

        /// <summary>
        /// 最大连接数
        /// </summary>
        [JsonProperty("MaxConnNum")]
        public ulong? MaxConnNum{ get; set; }

        /// <summary>
        /// 最大用户数
        /// </summary>
        [JsonProperty("MaxUserNum")]
        public ulong? MaxUserNum{ get; set; }

        /// <summary>
        /// 峰值带宽，已废弃
        /// </summary>
        [JsonProperty("MaxBandWidth")]
        public ulong? MaxBandWidth{ get; set; }

        /// <summary>
        /// 公网带宽，已废弃
        /// </summary>
        [JsonProperty("PublicNetworkTps")]
        public ulong? PublicNetworkTps{ get; set; }

        /// <summary>
        /// 实例对应的功能列表，true表示支持，false 表示不支持
        /// </summary>
        [JsonProperty("Features")]
        public string Features{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "MaxTps", this.MaxTps);
            this.SetParamSimple(map, prefix + "MaxQueueNum", this.MaxQueueNum);
            this.SetParamSimple(map, prefix + "MaxExchangeNum", this.MaxExchangeNum);
            this.SetParamSimple(map, prefix + "MaxVhostNum", this.MaxVhostNum);
            this.SetParamSimple(map, prefix + "MaxConnNum", this.MaxConnNum);
            this.SetParamSimple(map, prefix + "MaxUserNum", this.MaxUserNum);
            this.SetParamSimple(map, prefix + "MaxBandWidth", this.MaxBandWidth);
            this.SetParamSimple(map, prefix + "PublicNetworkTps", this.PublicNetworkTps);
            this.SetParamSimple(map, prefix + "Features", this.Features);
        }
    }
}

