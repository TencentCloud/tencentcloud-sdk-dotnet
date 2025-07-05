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

    public class RabbitMQBindingListInfo : AbstractModel
    {
        
        /// <summary>
        /// 路由关系id
        /// </summary>
        [JsonProperty("BindingId")]
        public long? BindingId{ get; set; }

        /// <summary>
        /// VhostName
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// 源exchange名称
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 目标类型,queue或exchange
        /// </summary>
        [JsonProperty("DestinationType")]
        public string DestinationType{ get; set; }

        /// <summary>
        /// 目标资源名称
        /// </summary>
        [JsonProperty("Destination")]
        public string Destination{ get; set; }

        /// <summary>
        /// 绑定key
        /// </summary>
        [JsonProperty("RoutingKey")]
        public string RoutingKey{ get; set; }

        /// <summary>
        /// 源exchange类型
        /// </summary>
        [JsonProperty("SourceExchangeType")]
        public string SourceExchangeType{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [JsonProperty("CreateTs")]
        public ulong? CreateTs{ get; set; }

        /// <summary>
        /// 修改时间时间戳
        /// </summary>
        [JsonProperty("ModifyTs")]
        public ulong? ModifyTs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BindingId", this.BindingId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "DestinationType", this.DestinationType);
            this.SetParamSimple(map, prefix + "Destination", this.Destination);
            this.SetParamSimple(map, prefix + "RoutingKey", this.RoutingKey);
            this.SetParamSimple(map, prefix + "SourceExchangeType", this.SourceExchangeType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "CreateTs", this.CreateTs);
            this.SetParamSimple(map, prefix + "ModifyTs", this.ModifyTs);
        }
    }
}

