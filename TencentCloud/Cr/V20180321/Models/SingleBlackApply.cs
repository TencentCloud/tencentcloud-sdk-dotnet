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

namespace TencentCloud.Cr.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SingleBlackApply : AbstractModel
    {
        
        /// <summary>
        /// 黑名单类型，01代表手机号码。
        /// </summary>
        [JsonProperty("BlackType")]
        public string BlackType{ get; set; }

        /// <summary>
        /// 操作类型，A为新增，D为删除。
        /// </summary>
        [JsonProperty("OperationType")]
        public string OperationType{ get; set; }

        /// <summary>
        /// 黑名单值，BlackType为01时，填写11位手机号码。
        /// </summary>
        [JsonProperty("BlackValue")]
        public string BlackValue{ get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("BlackDescription")]
        public string BlackDescription{ get; set; }

        /// <summary>
        /// 黑名单生效截止日期，格式为YYYY-MM-DD，不填默认为永久。
        /// </summary>
        [JsonProperty("BlackValidDate")]
        public string BlackValidDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlackType", this.BlackType);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "BlackValue", this.BlackValue);
            this.SetParamSimple(map, prefix + "BlackDescription", this.BlackDescription);
            this.SetParamSimple(map, prefix + "BlackValidDate", this.BlackValidDate);
        }
    }
}

