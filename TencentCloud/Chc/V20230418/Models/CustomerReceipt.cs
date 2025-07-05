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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomerReceipt : AbstractModel
    {
        
        /// <summary>
        /// 自提人员姓名
        /// </summary>
        [JsonProperty("PickUpStuff")]
        public string PickUpStuff{ get; set; }

        /// <summary>
        /// 自提人电话
        /// </summary>
        [JsonProperty("PickUpStuffContact")]
        public string PickUpStuffContact{ get; set; }

        /// <summary>
        /// 自提人证件号码
        /// </summary>
        [JsonProperty("PickUpStuffIDCard")]
        public string PickUpStuffIDCard{ get; set; }

        /// <summary>
        /// 自提时间
        /// </summary>
        [JsonProperty("PickUpTime")]
        public string PickUpTime{ get; set; }

        /// <summary>
        /// 证件类型，非必传，默认为IDENTITY_CARD。
        /// 对应关系如下：IDENTITY_CARD: 身份证,
        /// HONG_KONG_AND_MACAO_PASS: 港澳通行证',
        /// PASSPORT: 护照,
        /// DRIVING_LICENSE: 驾照,
        /// OTHER: 其他
        /// </summary>
        [JsonProperty("IDCardType")]
        public string IDCardType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PickUpStuff", this.PickUpStuff);
            this.SetParamSimple(map, prefix + "PickUpStuffContact", this.PickUpStuffContact);
            this.SetParamSimple(map, prefix + "PickUpStuffIDCard", this.PickUpStuffIDCard);
            this.SetParamSimple(map, prefix + "PickUpTime", this.PickUpTime);
            this.SetParamSimple(map, prefix + "IDCardType", this.IDCardType);
        }
    }
}

