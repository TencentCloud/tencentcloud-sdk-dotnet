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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTawInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 片区Id，(至少大于0)
        /// </summary>
        [JsonProperty("AreaId")]
        public long? AreaId{ get; set; }

        /// <summary>
        /// 计费类型, (1=后付费)
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// 数据保存时间，(至少大于0)
        /// </summary>
        [JsonProperty("DataRetentionDays")]
        public long? DataRetentionDays{ get; set; }

        /// <summary>
        /// 实例名称，(最大长度不超过255字节)
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 实例描述，(最大长度不超过1024字节)
        /// </summary>
        [JsonProperty("InstanceDesc")]
        public string InstanceDesc{ get; set; }

        /// <summary>
        /// 每天数据上报量，（不作量级限制）
        /// </summary>
        [JsonProperty("CountNum")]
        public string CountNum{ get; set; }

        /// <summary>
        /// 数据存储时长计费
        /// </summary>
        [JsonProperty("PeriodRetain")]
        public string PeriodRetain{ get; set; }

        /// <summary>
        /// 实例购买渠道("cdn" 等)
        /// </summary>
        [JsonProperty("BuyingChannel")]
        public string BuyingChannel{ get; set; }

        /// <summary>
        /// 预付费资源包类型(仅预付费需要)
        /// </summary>
        [JsonProperty("ResourcePackageType")]
        public ulong? ResourcePackageType{ get; set; }

        /// <summary>
        /// 预付费资源包数量(仅预付费需要)
        /// </summary>
        [JsonProperty("ResourcePackageNum")]
        public ulong? ResourcePackageNum{ get; set; }

        /// <summary>
        /// 实例类型 1:原web相关类型 2:app端类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AreaId", this.AreaId);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "DataRetentionDays", this.DataRetentionDays);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "InstanceDesc", this.InstanceDesc);
            this.SetParamSimple(map, prefix + "CountNum", this.CountNum);
            this.SetParamSimple(map, prefix + "PeriodRetain", this.PeriodRetain);
            this.SetParamSimple(map, prefix + "BuyingChannel", this.BuyingChannel);
            this.SetParamSimple(map, prefix + "ResourcePackageType", this.ResourcePackageType);
            this.SetParamSimple(map, prefix + "ResourcePackageNum", this.ResourcePackageNum);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
        }
    }
}

