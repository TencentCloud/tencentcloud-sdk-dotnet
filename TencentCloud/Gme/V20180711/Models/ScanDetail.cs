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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanDetail : AbstractModel
    {
        
        /// <summary>
        /// 违规场景，参照<a href="https://cloud.tencent.com/document/product/607/37622#Label_Value">Label</a>定义
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 该场景下概率[0.00,100.00],分值越大违规概率越高
        /// </summary>
        [JsonProperty("Rate")]
        public string Rate{ get; set; }

        /// <summary>
        /// 违规关键字
        /// </summary>
        [JsonProperty("KeyWord")]
        public string KeyWord{ get; set; }

        /// <summary>
        /// 关键字在音频的开始时间，从0开始的偏移量，单位为毫秒
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 关键字在音频的结束时间，从0开始的偏移量,，单位为毫秒
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
            this.SetParamSimple(map, prefix + "KeyWord", this.KeyWord);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

