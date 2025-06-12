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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TImeCycle : AbstractModel
    {
        
        /// <summary>
        /// 按周期扩容时，是否选择周一扩容。
        /// 说明：取值 true，表示选择，取值 false，表示不选择。
        /// </summary>
        [JsonProperty("Monday")]
        public bool? Monday{ get; set; }

        /// <summary>
        /// 按周期扩容时，是否选择周二扩容。
        /// 说明：取值 true，表示选择，取值 false，表示不选择。
        /// </summary>
        [JsonProperty("Tuesday")]
        public bool? Tuesday{ get; set; }

        /// <summary>
        /// 按周期扩容时，是否选择周三扩容。
        /// 说明：取值 true，表示选择，取值 false，表示不选择。
        /// </summary>
        [JsonProperty("Wednesday")]
        public bool? Wednesday{ get; set; }

        /// <summary>
        /// 按周期扩容时，是否选择周四扩容。
        /// 说明：取值 true，表示选择，取值 false，表示不选择。
        /// </summary>
        [JsonProperty("Thursday")]
        public bool? Thursday{ get; set; }

        /// <summary>
        /// 按周期扩容时，是否选择周五扩容。
        /// 说明：取值 true，表示选择，取值 false，表示不选择。
        /// </summary>
        [JsonProperty("Friday")]
        public bool? Friday{ get; set; }

        /// <summary>
        /// 按周期扩容时，是否选择周六扩容。
        /// 说明：取值 true，表示选择，取值 false，表示不选择。
        /// </summary>
        [JsonProperty("Saturday")]
        public bool? Saturday{ get; set; }

        /// <summary>
        /// 按周期扩容时，是否选择周日扩容。
        /// 说明：取值 true，表示选择，取值 false，表示不选择。
        /// </summary>
        [JsonProperty("Sunday")]
        public bool? Sunday{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Monday", this.Monday);
            this.SetParamSimple(map, prefix + "Tuesday", this.Tuesday);
            this.SetParamSimple(map, prefix + "Wednesday", this.Wednesday);
            this.SetParamSimple(map, prefix + "Thursday", this.Thursday);
            this.SetParamSimple(map, prefix + "Friday", this.Friday);
            this.SetParamSimple(map, prefix + "Saturday", this.Saturday);
            this.SetParamSimple(map, prefix + "Sunday", this.Sunday);
        }
    }
}

