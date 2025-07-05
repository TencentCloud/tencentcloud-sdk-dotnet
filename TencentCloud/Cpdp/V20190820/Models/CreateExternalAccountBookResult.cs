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

    public class CreateExternalAccountBookResult : AbstractModel
    {
        
        /// <summary>
        /// 处理状态。
        /// __SUCCESS__: 成功
        /// __FAILED__: 失败
        /// __PROCESSING__: 进行中。
        /// </summary>
        [JsonProperty("DealStatus")]
        public string DealStatus{ get; set; }

        /// <summary>
        /// 处理返回描述，例如失败原因等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DealMessage")]
        public string DealMessage{ get; set; }

        /// <summary>
        /// 渠道电子记账本ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelAccountBookId")]
        public string ChannelAccountBookId{ get; set; }

        /// <summary>
        /// 电子记账本对外收款的账户信息。为JSON格式字符串（成功状态下返回）。详情见附录-复杂类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CollectMoneyAccountInfo")]
        public string CollectMoneyAccountInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DealStatus", this.DealStatus);
            this.SetParamSimple(map, prefix + "DealMessage", this.DealMessage);
            this.SetParamSimple(map, prefix + "ChannelAccountBookId", this.ChannelAccountBookId);
            this.SetParamSimple(map, prefix + "CollectMoneyAccountInfo", this.CollectMoneyAccountInfo);
        }
    }
}

