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
        public long? UserDiscount{ get; set; }

        /// <summary>
        /// 公共折扣。
        /// </summary>
        [JsonProperty("CommonDiscount")]
        public long? CommonDiscount{ get; set; }

        /// <summary>
        /// 最终折扣。
        /// </summary>
        [JsonProperty("FinalDiscount")]
        public long? FinalDiscount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserDiscount", this.UserDiscount);
            this.SetParamSimple(map, prefix + "CommonDiscount", this.CommonDiscount);
            this.SetParamSimple(map, prefix + "FinalDiscount", this.FinalDiscount);
        }
    }
}

