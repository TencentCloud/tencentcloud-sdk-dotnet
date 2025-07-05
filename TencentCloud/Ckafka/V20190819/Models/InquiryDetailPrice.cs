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

    public class InquiryDetailPrice : AbstractModel
    {
        
        /// <summary>
        /// 额外内网带宽价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthPrice")]
        public InquiryBasePrice BandwidthPrice{ get; set; }

        /// <summary>
        /// 硬盘价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskPrice")]
        public InquiryBasePrice DiskPrice{ get; set; }

        /// <summary>
        /// 额外分区价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PartitionPrice")]
        public InquiryBasePrice PartitionPrice{ get; set; }

        /// <summary>
        /// 额外Topic价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicPrice")]
        public InquiryBasePrice TopicPrice{ get; set; }

        /// <summary>
        /// 实例套餐价格
        /// </summary>
        [JsonProperty("InstanceTypePrice")]
        public InquiryBasePrice InstanceTypePrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BandwidthPrice.", this.BandwidthPrice);
            this.SetParamObj(map, prefix + "DiskPrice.", this.DiskPrice);
            this.SetParamObj(map, prefix + "PartitionPrice.", this.PartitionPrice);
            this.SetParamObj(map, prefix + "TopicPrice.", this.TopicPrice);
            this.SetParamObj(map, prefix + "InstanceTypePrice.", this.InstanceTypePrice);
        }
    }
}

