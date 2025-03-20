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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetWeChatBillDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// 拉取的日期（YYYY-MM-DD）。
        /// - 最大可追溯到365天前。
        /// - 当天6点后才能拉取前一天的数据。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 游标。
        /// - 用于分页。
        /// - 取第一页时传0，取后续页面时，传入本接口响应中返回的NextCursor字段的值。
        /// </summary>
        [JsonProperty("Cursor")]
        public ulong? Cursor{ get; set; }

        /// <summary>
        /// 需要拉取账单详情业务对应的RuleId。
        /// - 不传会返回所有RuleId数据。
        /// - 默认为空字符串。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Cursor", this.Cursor);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

