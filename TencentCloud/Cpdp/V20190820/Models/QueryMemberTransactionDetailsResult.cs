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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryMemberTransactionDetailsResult : AbstractModel
    {
        
        /// <summary>
        /// 本次交易返回查询结果记录数。
        /// </summary>
        [JsonProperty("ResultCount")]
        public ulong? ResultCount{ get; set; }

        /// <summary>
        /// 符合业务查询条件的记录总数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 结束标志。
        /// __0__：否
        /// __1__：是
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndFlag")]
        public string EndFlag{ get; set; }

        /// <summary>
        /// 会员间交易信息数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranItemArray")]
        public MemberTransactionItem[] TranItemArray{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResultCount", this.ResultCount);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "EndFlag", this.EndFlag);
            this.SetParamArrayObj(map, prefix + "TranItemArray.", this.TranItemArray);
        }
    }
}

