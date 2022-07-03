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

    public class ModifyFlexPayeeAccountRightStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 收款用户ID
        /// </summary>
        [JsonProperty("PayeeId")]
        public string PayeeId{ get; set; }

        /// <summary>
        /// 账户权益类型
        /// SETTLEMENT:结算权益
        /// PAYMENT:付款权益
        /// </summary>
        [JsonProperty("AccountRightType")]
        public string AccountRightType{ get; set; }

        /// <summary>
        /// 账户权益状态
        /// ENABLE:启用
        /// DISABLE:停用
        /// </summary>
        [JsonProperty("AccountRightStatus")]
        public string AccountRightStatus{ get; set; }

        /// <summary>
        /// 环境类型
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// __test__:测试环境
        /// 缺省默认为生产环境
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayeeId", this.PayeeId);
            this.SetParamSimple(map, prefix + "AccountRightType", this.AccountRightType);
            this.SetParamSimple(map, prefix + "AccountRightStatus", this.AccountRightStatus);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

