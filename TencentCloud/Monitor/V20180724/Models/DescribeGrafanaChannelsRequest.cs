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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGrafanaChannelsRequest : AbstractModel
    {
        
        /// <summary>
        /// Grafana 实例 ID，例如：grafana-12345678
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 查询数量
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 告警通道名称，例如：test
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 告警通道 ID，例如：nchannel-abcd1234
        /// </summary>
        [JsonProperty("ChannelIds")]
        public string[] ChannelIds{ get; set; }

        /// <summary>
        /// 告警通道状态(不用填写，目前只有可用和删除状态，默认只能查询可用的告警通道)
        /// </summary>
        [JsonProperty("ChannelState")]
        public long? ChannelState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamArraySimple(map, prefix + "ChannelIds.", this.ChannelIds);
            this.SetParamSimple(map, prefix + "ChannelState", this.ChannelState);
        }
    }
}

