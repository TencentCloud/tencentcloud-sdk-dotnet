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

    public class UnbindOpenBankExternalSubMerchantBankAccountResult : AbstractModel
    {
        
        /// <summary>
        /// 渠道申请编号。
        /// </summary>
        [JsonProperty("ChannelApplyId")]
        public string ChannelApplyId{ get; set; }

        /// <summary>
        /// 解绑状态。
        /// __SUCCESS__: 解绑成功
        /// __FAILED__: 解绑失败
        /// __PROCESSING__: 解绑中
        /// 注意：若返回解绑中，需要再次调用解绑结果查询接口查询结果。
        /// </summary>
        [JsonProperty("UnbindStatus")]
        public string UnbindStatus{ get; set; }

        /// <summary>
        /// 解绑返回描述, 例如失败原因等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnbindMessage")]
        public string UnbindMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelApplyId", this.ChannelApplyId);
            this.SetParamSimple(map, prefix + "UnbindStatus", this.UnbindStatus);
            this.SetParamSimple(map, prefix + "UnbindMessage", this.UnbindMessage);
        }
    }
}

