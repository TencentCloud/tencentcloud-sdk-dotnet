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

    public class PeerConnection : AbstractModel
    {
        
        /// <summary>
        /// 本端VPC唯一ID。
        /// </summary>
        [JsonProperty("SourceVpcId")]
        public string SourceVpcId{ get; set; }

        /// <summary>
        /// 对端VPC唯一ID。
        /// </summary>
        [JsonProperty("PeerVpcId")]
        public string PeerVpcId{ get; set; }

        /// <summary>
        /// 对等连接唯一ID。
        /// </summary>
        [JsonProperty("PeeringConnectionId")]
        public string PeeringConnectionId{ get; set; }

        /// <summary>
        /// 对等连接名称。
        /// </summary>
        [JsonProperty("PeeringConnectionName")]
        public string PeeringConnectionName{ get; set; }

        /// <summary>
        /// 对等连接状态，PENDING，投放中；ACTIVE，使用中；REJECTED，已拒绝‘DELETED，已删除；FAILED，失败；EXPIRED，已过期；ISOLATED，隔离中。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 是否是新控制器，true: 是NewAfc；false:不是。
        /// </summary>
        [JsonProperty("IsNgw")]
        public bool? IsNgw{ get; set; }

        /// <summary>
        /// 对等连接带宽值。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 本端地域。
        /// </summary>
        [JsonProperty("SourceRegion")]
        public string SourceRegion{ get; set; }

        /// <summary>
        /// 对端地域。
        /// </summary>
        [JsonProperty("DestinationRegion")]
        public string DestinationRegion{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 本端APPID。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 对端APPID。
        /// </summary>
        [JsonProperty("PeerAppId")]
        public long? PeerAppId{ get; set; }

        /// <summary>
        /// 计费类型，POSTPAID_BY_DAY_MAX：日峰值计费；POSTPAID_BY_MONTH_95：月95计费。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 本端UIN。
        /// </summary>
        [JsonProperty("SourceUin")]
        public long? SourceUin{ get; set; }

        /// <summary>
        /// 对端UIN。
        /// </summary>
        [JsonProperty("DestinationUin")]
        public long? DestinationUin{ get; set; }

        /// <summary>
        /// 资源标签数据。
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// 服务分级：PT、AU、AG。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }

        /// <summary>
        /// 互通类型，VPC_PEER：VPC间互通；VPC_BM_PEER：VPC与黑石网络互通。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceVpcId", this.SourceVpcId);
            this.SetParamSimple(map, prefix + "PeerVpcId", this.PeerVpcId);
            this.SetParamSimple(map, prefix + "PeeringConnectionId", this.PeeringConnectionId);
            this.SetParamSimple(map, prefix + "PeeringConnectionName", this.PeeringConnectionName);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "IsNgw", this.IsNgw);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "SourceRegion", this.SourceRegion);
            this.SetParamSimple(map, prefix + "DestinationRegion", this.DestinationRegion);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PeerAppId", this.PeerAppId);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "SourceUin", this.SourceUin);
            this.SetParamSimple(map, prefix + "DestinationUin", this.DestinationUin);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "QosLevel", this.QosLevel);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

