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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyDetail : AbstractModel
    {
        
        /// <summary>
        /// 用户折扣。
        /// </summary>
        [JsonProperty("UserDiscount")]
        public float? UserDiscount{ get; set; }

        /// <summary>
        /// 公共折扣。
        /// </summary>
        [JsonProperty("CommonDiscount")]
        public float? CommonDiscount{ get; set; }

        /// <summary>
        /// 最终折扣。
        /// </summary>
        [JsonProperty("FinalDiscount")]
        public float? FinalDiscount{ get; set; }

        /// <summary>
        /// 活动折扣。取值为null，表示无有效值，即没有折扣。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityDiscount")]
        public float? ActivityDiscount{ get; set; }

        /// <summary>
        /// 折扣类型。
        /// user：用户折扣; common：官网折扣; activity：活动折扣。 取值为null，表示无有效值，即没有折扣。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountType")]
        public string DiscountType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserDiscount", this.UserDiscount);
            this.SetParamSimple(map, prefix + "CommonDiscount", this.CommonDiscount);
            this.SetParamSimple(map, prefix + "FinalDiscount", this.FinalDiscount);
            this.SetParamSimple(map, prefix + "ActivityDiscount", this.ActivityDiscount);
            this.SetParamSimple(map, prefix + "DiscountType", this.DiscountType);
        }
    }
}

