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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RelieveInfo : AbstractModel
    {
        
        /// <summary>
        /// 解除理由，长度不能超过200，只能由中文、字母、数字、中文标点和英文标点组成(不支持表情)。
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 解除后仍然有效的条款，保留条款，长度不能超过200，只能由中文、字母、数字、中文标点和英文标点组成(不支持表情)。
        /// </summary>
        [JsonProperty("RemainInForceItem")]
        public string RemainInForceItem{ get; set; }

        /// <summary>
        /// 原合同事项处理-费用结算，长度不能超过200，只能由中文、字母、数字、中文标点和英文标点组成(不支持表情)。
        /// </summary>
        [JsonProperty("OriginalExpenseSettlement")]
        public string OriginalExpenseSettlement{ get; set; }

        /// <summary>
        /// 原合同事项处理-其他事项，长度不能超过200，只能由中文、字母、数字、中文标点和英文标点组成(不支持表情)。
        /// </summary>
        [JsonProperty("OriginalOtherSettlement")]
        public string OriginalOtherSettlement{ get; set; }

        /// <summary>
        /// 其他约定（如约定的与解除协议存在冲突的，以【其他约定】为准），最大支持200个字，只能由中文、字母、数字、中文标点和英文标点组成(不支持表情)。
        /// </summary>
        [JsonProperty("OtherDeals")]
        public string OtherDeals{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "RemainInForceItem", this.RemainInForceItem);
            this.SetParamSimple(map, prefix + "OriginalExpenseSettlement", this.OriginalExpenseSettlement);
            this.SetParamSimple(map, prefix + "OriginalOtherSettlement", this.OriginalOtherSettlement);
            this.SetParamSimple(map, prefix + "OtherDeals", this.OtherDeals);
        }
    }
}

