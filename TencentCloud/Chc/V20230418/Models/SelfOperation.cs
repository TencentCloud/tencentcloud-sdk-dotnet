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

    public class SelfOperation : AbstractModel
    {
        
        /// <summary>
        /// 联系人员电话
        /// </summary>
        [JsonProperty("StuffContact")]
        public string StuffContact{ get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("StuffIDCard")]
        public string StuffIDCard{ get; set; }

        /// <summary>
        /// 人员姓名
        /// </summary>
        [JsonProperty("StuffName")]
        public string StuffName{ get; set; }

        /// <summary>
        /// 上门时间
        /// </summary>
        [JsonProperty("OperationTime")]
        public string OperationTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "StuffContact", this.StuffContact);
            this.SetParamSimple(map, prefix + "StuffIDCard", this.StuffIDCard);
            this.SetParamSimple(map, prefix + "StuffName", this.StuffName);
            this.SetParamSimple(map, prefix + "OperationTime", this.OperationTime);
            this.SetParamSimple(map, prefix + "IDCardType", this.IDCardType);
        }
    }
}

