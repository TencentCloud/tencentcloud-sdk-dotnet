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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoRaFrequencyEntry : AbstractModel
    {
        
        /// <summary>
        /// 频点唯一ID
        /// </summary>
        [JsonProperty("FreqId")]
        public string FreqId{ get; set; }

        /// <summary>
        /// 频点名称
        /// </summary>
        [JsonProperty("FreqName")]
        public string FreqName{ get; set; }

        /// <summary>
        /// 频点描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 数据上行信道
        /// </summary>
        [JsonProperty("ChannelsDataUp")]
        public ulong?[] ChannelsDataUp{ get; set; }

        /// <summary>
        /// 数据下行信道RX1
        /// </summary>
        [JsonProperty("ChannelsDataRX1")]
        public ulong?[] ChannelsDataRX1{ get; set; }

        /// <summary>
        /// 数据下行信道RX2
        /// </summary>
        [JsonProperty("ChannelsDataRX2")]
        public ulong?[] ChannelsDataRX2{ get; set; }

        /// <summary>
        /// 入网上行信道
        /// </summary>
        [JsonProperty("ChannelsJoinUp")]
        public ulong?[] ChannelsJoinUp{ get; set; }

        /// <summary>
        /// 入网下行RX1信道
        /// </summary>
        [JsonProperty("ChannelsJoinRX1")]
        public ulong?[] ChannelsJoinRX1{ get; set; }

        /// <summary>
        /// 入网下行RX2信道
        /// </summary>
        [JsonProperty("ChannelsJoinRX2")]
        public ulong?[] ChannelsJoinRX2{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FreqId", this.FreqId);
            this.SetParamSimple(map, prefix + "FreqName", this.FreqName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "ChannelsDataUp.", this.ChannelsDataUp);
            this.SetParamArraySimple(map, prefix + "ChannelsDataRX1.", this.ChannelsDataRX1);
            this.SetParamArraySimple(map, prefix + "ChannelsDataRX2.", this.ChannelsDataRX2);
            this.SetParamArraySimple(map, prefix + "ChannelsJoinUp.", this.ChannelsJoinUp);
            this.SetParamArraySimple(map, prefix + "ChannelsJoinRX1.", this.ChannelsJoinRX1);
            this.SetParamArraySimple(map, prefix + "ChannelsJoinRX2.", this.ChannelsJoinRX2);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

