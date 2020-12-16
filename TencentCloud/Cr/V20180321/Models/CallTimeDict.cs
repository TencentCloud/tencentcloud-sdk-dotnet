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

    public class CallTimeDict : AbstractModel
    {
        
        /// <summary>
        /// 周一
        /// </summary>
        [JsonProperty("Monday")]
        public CallTimeInfo Monday{ get; set; }

        /// <summary>
        /// 周二
        /// </summary>
        [JsonProperty("Tuesday")]
        public CallTimeInfo Tuesday{ get; set; }

        /// <summary>
        /// 周三
        /// </summary>
        [JsonProperty("Wednesday")]
        public CallTimeInfo Wednesday{ get; set; }

        /// <summary>
        /// 周四
        /// </summary>
        [JsonProperty("Thursday")]
        public CallTimeInfo Thursday{ get; set; }

        /// <summary>
        /// 周五
        /// </summary>
        [JsonProperty("Friday")]
        public CallTimeInfo Friday{ get; set; }

        /// <summary>
        /// 周六
        /// </summary>
        [JsonProperty("Saturday")]
        public CallTimeInfo Saturday{ get; set; }

        /// <summary>
        /// 周日
        /// </summary>
        [JsonProperty("Sunday")]
        public CallTimeInfo Sunday{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Monday.", this.Monday);
            this.SetParamObj(map, prefix + "Tuesday.", this.Tuesday);
            this.SetParamObj(map, prefix + "Wednesday.", this.Wednesday);
            this.SetParamObj(map, prefix + "Thursday.", this.Thursday);
            this.SetParamObj(map, prefix + "Friday.", this.Friday);
            this.SetParamObj(map, prefix + "Saturday.", this.Saturday);
            this.SetParamObj(map, prefix + "Sunday.", this.Sunday);
        }
    }
}

