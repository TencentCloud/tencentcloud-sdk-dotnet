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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputDescribeUserUsageCnt : AbstractModel
    {
        
        /// <summary>
        /// 当前付费模式，0 后付费 1 预付费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 后付费本月使用量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AfterPayModeThisMonthUsedCnt")]
        public long? AfterPayModeThisMonthUsedCnt{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 超出时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 后付费上月使用量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AfterPayModeLastMonthUsedCnt")]
        public long? AfterPayModeLastMonthUsedCnt{ get; set; }

        /// <summary>
        /// 预付费总量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeforePayModeTotalUsedCnt")]
        public long? BeforePayModeTotalUsedCnt{ get; set; }

        /// <summary>
        /// 预付费剩余用量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeforePayModeRemainUsedCnt")]
        public long? BeforePayModeRemainUsedCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "AfterPayModeThisMonthUsedCnt", this.AfterPayModeThisMonthUsedCnt);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AfterPayModeLastMonthUsedCnt", this.AfterPayModeLastMonthUsedCnt);
            this.SetParamSimple(map, prefix + "BeforePayModeTotalUsedCnt", this.BeforePayModeTotalUsedCnt);
            this.SetParamSimple(map, prefix + "BeforePayModeRemainUsedCnt", this.BeforePayModeRemainUsedCnt);
        }
    }
}

