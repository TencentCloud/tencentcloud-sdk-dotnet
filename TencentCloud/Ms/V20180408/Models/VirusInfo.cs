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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VirusInfo : AbstractModel
    {
        
        /// <summary>
        /// 软件安全类型，分别为0-未知、 1-安全软件、2-风险软件、3-病毒软件
        /// </summary>
        [JsonProperty("SafeType")]
        public long? SafeType{ get; set; }

        /// <summary>
        /// 病毒名称， utf8编码，非病毒时值为空
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// 病毒描述，utf8编码，非病毒时值为空
        /// </summary>
        [JsonProperty("VirusDesc")]
        public string VirusDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SafeType", this.SafeType);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "VirusDesc", this.VirusDesc);
        }
    }
}

