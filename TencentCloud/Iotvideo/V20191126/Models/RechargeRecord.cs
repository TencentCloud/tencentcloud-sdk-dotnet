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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RechargeRecord : AbstractModel
    {
        
        /// <summary>
        /// 流水记录号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaterId")]
        public long? WaterId{ get; set; }

        /// <summary>
        /// 充值前的余额，单位0.01元。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BalanceBeforeRecharge")]
        public long? BalanceBeforeRecharge{ get; set; }

        /// <summary>
        /// 充值金额，单位0.01元。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Money")]
        public long? Money{ get; set; }

        /// <summary>
        /// 充值时间, UTC值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateTime")]
        public long? OperateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WaterId", this.WaterId);
            this.SetParamSimple(map, prefix + "BalanceBeforeRecharge", this.BalanceBeforeRecharge);
            this.SetParamSimple(map, prefix + "Money", this.Money);
            this.SetParamSimple(map, prefix + "OperateTime", this.OperateTime);
        }
    }
}

