/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVpcPeeringConnectionRequest : AbstractModel
    {
        
        /// <summary>
        /// 本端VPC唯一ID。
        /// </summary>
        [JsonProperty("SourceVpcId")]
        public string SourceVpcId{ get; set; }

        /// <summary>
        /// 对等连接名称。
        /// </summary>
        [JsonProperty("PeeringConnectionName")]
        public string PeeringConnectionName{ get; set; }

        /// <summary>
        /// 对端VPC唯一ID。
        /// </summary>
        [JsonProperty("DestinationVpcId")]
        public string DestinationVpcId{ get; set; }

        /// <summary>
        /// 对端用户UIN。
        /// </summary>
        [JsonProperty("DestinationUin")]
        public string DestinationUin{ get; set; }

        /// <summary>
        /// 对端地域。
        /// </summary>
        [JsonProperty("DestinationRegion")]
        public string DestinationRegion{ get; set; }

        /// <summary>
        /// 带宽上限，单位Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 互通类型，VPC_PEER：VPC间互通；VPC_BM_PEER：VPC与黑石网络互通。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 计费模式，日峰值POSTPAID_BY_DAY_MAX，月95POSTPAID_BY_MONTH_95。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 服务分级：PT、AU、AG。
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }

        /// <summary>
        /// 标签键值对
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceVpcId", this.SourceVpcId);
            this.SetParamSimple(map, prefix + "PeeringConnectionName", this.PeeringConnectionName);
            this.SetParamSimple(map, prefix + "DestinationVpcId", this.DestinationVpcId);
            this.SetParamSimple(map, prefix + "DestinationUin", this.DestinationUin);
            this.SetParamSimple(map, prefix + "DestinationRegion", this.DestinationRegion);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "QosLevel", this.QosLevel);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

