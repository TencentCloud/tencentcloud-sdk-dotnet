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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// 暂不支持，默认值off。
        /// </summary>
        [JsonProperty("AiStatus")]
        public string AiStatus{ get; set; }

        /// <summary>
        /// 废弃字段。
        /// </summary>
        [JsonProperty("Appid")]
        public string Appid{ get; set; }

        /// <summary>
        /// 策略等级，取值有:
        /// <li>low ：宽松 ；</li>
        /// <li>middle ：适中 ；</li>
        /// <li>high : 严格。 </li>
        /// </summary>
        [JsonProperty("PlyLevel")]
        public string PlyLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AiStatus", this.AiStatus);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "PlyLevel", this.PlyLevel);
        }
    }
}

