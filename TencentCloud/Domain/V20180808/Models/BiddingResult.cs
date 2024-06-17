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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BiddingResult : AbstractModel
    {
        
        /// <summary>
        /// business_id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessID")]
        public string BusinessID{ get; set; }

        /// <summary>
        /// 域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 当前价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentPrice")]
        public ulong? CurrentPrice{ get; set; }

        /// <summary>
        /// 当前用户昵称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentNickname")]
        public string CurrentNickname{ get; set; }

        /// <summary>
        /// 我的出价
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BiddingPrice")]
        public ulong? BiddingPrice{ get; set; }

        /// <summary>
        /// 竞价保证金
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BiddingBondPrice")]
        public ulong? BiddingBondPrice{ get; set; }

        /// <summary>
        /// 竞价结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BiddingEndTime")]
        public string BiddingEndTime{ get; set; }

        /// <summary>
        /// 竞价标识，1 领先，2 落后
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BiddingFlag")]
        public ulong? BiddingFlag{ get; set; }

        /// <summary>
        /// 出价次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BiddingNum")]
        public ulong? BiddingNum{ get; set; }

        /// <summary>
        /// 2 竞价中  3 等待出价 4 竞价失败 10 竞价持有者赎回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessID", this.BusinessID);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "CurrentPrice", this.CurrentPrice);
            this.SetParamSimple(map, prefix + "CurrentNickname", this.CurrentNickname);
            this.SetParamSimple(map, prefix + "BiddingPrice", this.BiddingPrice);
            this.SetParamSimple(map, prefix + "BiddingBondPrice", this.BiddingBondPrice);
            this.SetParamSimple(map, prefix + "BiddingEndTime", this.BiddingEndTime);
            this.SetParamSimple(map, prefix + "BiddingFlag", this.BiddingFlag);
            this.SetParamSimple(map, prefix + "BiddingNum", this.BiddingNum);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

