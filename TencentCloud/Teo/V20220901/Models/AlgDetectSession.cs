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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlgDetectSession : AbstractModel
    {
        
        /// <summary>
        /// 操作名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 校验方式，默认update_detect，取值有：
        /// <li>detect：仅校验；</li>
        /// <li>update_detect：更新Cookie并校验。</li>
        /// </summary>
        [JsonProperty("DetectMode")]
        public string DetectMode{ get; set; }

        /// <summary>
        /// 会话速率和周期特征校验开关，默认off，取值有：
        /// <li>off：关闭；</li>
        /// <li>on：打开。</li>
        /// </summary>
        [JsonProperty("SessionAnalyzeSwitch")]
        public string SessionAnalyzeSwitch{ get; set; }

        /// <summary>
        /// 校验结果为未携带Cookie或Cookie已过期的统计周期。单位为秒，默认10，取值：5～3600。
        /// </summary>
        [JsonProperty("InvalidStatTime")]
        public long? InvalidStatTime{ get; set; }

        /// <summary>
        /// 校验结果为未携带Cookie或Cookie已过期的触发阈值。单位为次，默认300，取值：1～100000000。
        /// </summary>
        [JsonProperty("InvalidThreshold")]
        public long? InvalidThreshold{ get; set; }

        /// <summary>
        /// Cookie校验校验结果。
        /// </summary>
        [JsonProperty("AlgDetectResults")]
        public AlgDetectResult[] AlgDetectResults{ get; set; }

        /// <summary>
        /// 会话速率和周期特征校验结果。
        /// </summary>
        [JsonProperty("SessionBehaviors")]
        public AlgDetectResult[] SessionBehaviors{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DetectMode", this.DetectMode);
            this.SetParamSimple(map, prefix + "SessionAnalyzeSwitch", this.SessionAnalyzeSwitch);
            this.SetParamSimple(map, prefix + "InvalidStatTime", this.InvalidStatTime);
            this.SetParamSimple(map, prefix + "InvalidThreshold", this.InvalidThreshold);
            this.SetParamArrayObj(map, prefix + "AlgDetectResults.", this.AlgDetectResults);
            this.SetParamArrayObj(map, prefix + "SessionBehaviors.", this.SessionBehaviors);
        }
    }
}

