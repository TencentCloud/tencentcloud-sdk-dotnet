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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ToneWordInfo : AbstractModel
    {
        
        /// <summary>
        /// 首句超时时间，单位秒
        /// </summary>
        [JsonProperty("FirstSentenceTimeout")]
        public float? FirstSentenceTimeout{ get; set; }

        /// <summary>
        /// 承接语气词
        /// </summary>
        [JsonProperty("ZHToneWords")]
        public ZHToneWordsInfo ZHToneWords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FirstSentenceTimeout", this.FirstSentenceTimeout);
            this.SetParamObj(map, prefix + "ZHToneWords.", this.ZHToneWords);
        }
    }
}

