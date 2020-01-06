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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAlarmAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 告警项目。
        /// <li>Offline：防护软件离线</li>
        /// <li>Malware：发现木马文件</li>
        /// <li>NonlocalLogin：发现异地登录行为</li>
        /// <li>CrackSuccess：被暴力破解成功</li>
        /// </summary>
        [JsonProperty("Attribute")]
        public string Attribute{ get; set; }

        /// <summary>
        /// 告警项目属性。
        /// <li>CLOSE：关闭</li>
        /// <li>OPEN：打开</li>
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Attribute", this.Attribute);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

