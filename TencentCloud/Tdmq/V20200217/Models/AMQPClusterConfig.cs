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

    public class AMQPClusterConfig : AbstractModel
    {
        
        /// <summary>
        /// 单Vhost TPS上限
        /// </summary>
        [JsonProperty("MaxTpsPerVHost")]
        public ulong? MaxTpsPerVHost{ get; set; }

        /// <summary>
        /// 单Vhost客户端连接数上限
        /// </summary>
        [JsonProperty("MaxConnNumPerVHost")]
        public ulong? MaxConnNumPerVHost{ get; set; }

        /// <summary>
        /// 最大Vhost数量
        /// </summary>
        [JsonProperty("MaxVHostNum")]
        public ulong? MaxVHostNum{ get; set; }

        /// <summary>
        /// 最大exchange数量
        /// </summary>
        [JsonProperty("MaxExchangeNum")]
        public ulong? MaxExchangeNum{ get; set; }

        /// <summary>
        /// 最大Queue数量
        /// </summary>
        [JsonProperty("MaxQueueNum")]
        public ulong? MaxQueueNum{ get; set; }

        /// <summary>
        /// 消息最大保留时间，以毫秒为单位
        /// </summary>
        [JsonProperty("MaxRetentionTime")]
        public ulong? MaxRetentionTime{ get; set; }

        /// <summary>
        /// 已使用Vhost数量
        /// </summary>
        [JsonProperty("UsedVHostNum")]
        public ulong? UsedVHostNum{ get; set; }

        /// <summary>
        /// 已使用exchange数量
        /// </summary>
        [JsonProperty("UsedExchangeNum")]
        public ulong? UsedExchangeNum{ get; set; }

        /// <summary>
        /// 已使用queue数量
        /// </summary>
        [JsonProperty("UsedQueueNum")]
        public ulong? UsedQueueNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxTpsPerVHost", this.MaxTpsPerVHost);
            this.SetParamSimple(map, prefix + "MaxConnNumPerVHost", this.MaxConnNumPerVHost);
            this.SetParamSimple(map, prefix + "MaxVHostNum", this.MaxVHostNum);
            this.SetParamSimple(map, prefix + "MaxExchangeNum", this.MaxExchangeNum);
            this.SetParamSimple(map, prefix + "MaxQueueNum", this.MaxQueueNum);
            this.SetParamSimple(map, prefix + "MaxRetentionTime", this.MaxRetentionTime);
            this.SetParamSimple(map, prefix + "UsedVHostNum", this.UsedVHostNum);
            this.SetParamSimple(map, prefix + "UsedExchangeNum", this.UsedExchangeNum);
            this.SetParamSimple(map, prefix + "UsedQueueNum", this.UsedQueueNum);
        }
    }
}

