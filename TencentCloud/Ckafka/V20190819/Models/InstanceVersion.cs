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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceVersion : AbstractModel
    {
        
        /// <summary>
        /// ckafka集群实例版本
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// broker版本信息
        /// </summary>
        [JsonProperty("CurBrokerVersion")]
        public string CurBrokerVersion{ get; set; }

        /// <summary>
        /// 最新版本信息
        /// </summary>
        [JsonProperty("LatestBrokerVersion")]
        public LatestBrokerVersion[] LatestBrokerVersion{ get; set; }

        /// <summary>
        /// 允许跨大版本内核升级
        /// </summary>
        [JsonProperty("AllowUpgradeHighVersion")]
        public bool? AllowUpgradeHighVersion{ get; set; }

        /// <summary>
        /// 允许升级的大版本
        /// </summary>
        [JsonProperty("HighVersionSet")]
        public string[] HighVersionSet{ get; set; }

        /// <summary>
        /// 允许小版本号配置自动删除消费者组
        /// </summary>
        [JsonProperty("AllowAutoDeleteTimestamp")]
        public bool? AllowAutoDeleteTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamSimple(map, prefix + "CurBrokerVersion", this.CurBrokerVersion);
            this.SetParamArrayObj(map, prefix + "LatestBrokerVersion.", this.LatestBrokerVersion);
            this.SetParamSimple(map, prefix + "AllowUpgradeHighVersion", this.AllowUpgradeHighVersion);
            this.SetParamArraySimple(map, prefix + "HighVersionSet.", this.HighVersionSet);
            this.SetParamSimple(map, prefix + "AllowAutoDeleteTimestamp", this.AllowAutoDeleteTimestamp);
        }
    }
}

