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

    public class TrafficPackage : AbstractModel
    {
        
        /// <summary>
        /// 流量包唯一ID
        /// </summary>
        [JsonProperty("TrafficPackageId")]
        public string TrafficPackageId{ get; set; }

        /// <summary>
        /// 流量包名称
        /// </summary>
        [JsonProperty("TrafficPackageName")]
        public string TrafficPackageName{ get; set; }

        /// <summary>
        /// 流量包总量，单位GB
        /// </summary>
        [JsonProperty("TotalAmount")]
        public float? TotalAmount{ get; set; }

        /// <summary>
        /// 流量包剩余量，单位GB
        /// </summary>
        [JsonProperty("RemainingAmount")]
        public float? RemainingAmount{ get; set; }

        /// <summary>
        /// 流量包状态，可能的值有: AVAILABLE-可用状态， EXPIRED-已过期， EXHAUSTED-已用完， REFUNDED-已退还， DELETED-已删除
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 流量包创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 流量包截止时间
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// 已使用的流量，单位GB
        /// </summary>
        [JsonProperty("UsedAmount")]
        public float? UsedAmount{ get; set; }

        /// <summary>
        /// 流量包标签
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// 区分闲时流量包与全时流量包
        /// </summary>
        [JsonProperty("DeductType")]
        public string DeductType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficPackageId", this.TrafficPackageId);
            this.SetParamSimple(map, prefix + "TrafficPackageName", this.TrafficPackageName);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
            this.SetParamSimple(map, prefix + "RemainingAmount", this.RemainingAmount);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "UsedAmount", this.UsedAmount);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "DeductType", this.DeductType);
        }
    }
}

