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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOpenBankSubMerchantRateConfigureResult : AbstractModel
    {
        
        /// <summary>
        /// 处理状态 
        /// SUCCESS: 开通成功 
        /// FAILED: 开通失败
        /// PROCESSING: 开通中 
        /// 注意：若返回开通中，需要再次调用费率配置结果查询接口，查询结果。
        /// </summary>
        [JsonProperty("DealStatus")]
        public string DealStatus{ get; set; }

        /// <summary>
        /// 处理描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DealMessage")]
        public string DealMessage{ get; set; }

        /// <summary>
        /// 渠道产品费率序列号
        /// </summary>
        [JsonProperty("ChannelProductFeeNo")]
        public string ChannelProductFeeNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DealStatus", this.DealStatus);
            this.SetParamSimple(map, prefix + "DealMessage", this.DealMessage);
            this.SetParamSimple(map, prefix + "ChannelProductFeeNo", this.ChannelProductFeeNo);
        }
    }
}

