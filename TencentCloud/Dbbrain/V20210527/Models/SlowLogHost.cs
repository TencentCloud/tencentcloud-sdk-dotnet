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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowLogHost : AbstractModel
    {
        
        /// <summary>
        /// 来源地址。
        /// </summary>
        [JsonProperty("UserHost")]
        public string UserHost{ get; set; }

        /// <summary>
        /// 该来源地址的慢日志数目占总数目的比例，单位%。
        /// </summary>
        [JsonProperty("Ratio")]
        public float? Ratio{ get; set; }

        /// <summary>
        /// 该来源地址的慢日志数目。
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserHost", this.UserHost);
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
            this.SetParamSimple(map, prefix + "Count", this.Count);
        }
    }
}

