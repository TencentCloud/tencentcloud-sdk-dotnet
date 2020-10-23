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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CaptchaTicketDataRes : AbstractModel
    {
        
        /// <summary>
        /// 票据验证总量返回
        /// </summary>
        [JsonProperty("TicketAmountArray")]
        public TicketAmountUnit[] TicketAmountArray{ get; set; }

        /// <summary>
        /// 票据验证通过量返回
        /// </summary>
        [JsonProperty("TicketThroughArray")]
        public TicketThroughUnit[] TicketThroughArray{ get; set; }

        /// <summary>
        /// 票据验证拦截量返回
        /// </summary>
        [JsonProperty("TicketInterceptArray")]
        public TicketInterceptUnit[] TicketInterceptArray{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TicketAmountArray.", this.TicketAmountArray);
            this.SetParamArrayObj(map, prefix + "TicketThroughArray.", this.TicketThroughArray);
            this.SetParamArrayObj(map, prefix + "TicketInterceptArray.", this.TicketInterceptArray);
        }
    }
}

