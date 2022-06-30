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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FormField : AbstractModel
    {
        
        /// <summary>
        /// 控件填充value
        /// </summary>
        [JsonProperty("ComponentValue")]
        public string ComponentValue{ get; set; }

        /// <summary>
        /// 控件id
        /// </summary>
        [JsonProperty("ComponentId")]
        public string ComponentId{ get; set; }

        /// <summary>
        /// 控件名字，最大长度不超过30字符
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentValue", this.ComponentValue);
            this.SetParamSimple(map, prefix + "ComponentId", this.ComponentId);
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
        }
    }
}

