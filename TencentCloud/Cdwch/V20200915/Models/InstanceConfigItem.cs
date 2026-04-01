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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceConfigItem : AbstractModel
    {
        
        /// <summary>
        /// <p>key</p>
        /// </summary>
        [JsonProperty("ConfKey")]
        public string ConfKey{ get; set; }

        /// <summary>
        /// <p>value</p>
        /// </summary>
        [JsonProperty("ConfValue")]
        public string ConfValue{ get; set; }

        /// <summary>
        /// <p>add/delete/update</p>
        /// </summary>
        [JsonProperty("ModifyType")]
        public string ModifyType{ get; set; }

        /// <summary>
        /// <p>是否需要重启</p>
        /// </summary>
        [JsonProperty("NeedRestart")]
        public bool? NeedRestart{ get; set; }

        /// <summary>
        /// <p>修改前的值</p>
        /// </summary>
        [JsonProperty("OriginalConfValue")]
        public string OriginalConfValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfKey", this.ConfKey);
            this.SetParamSimple(map, prefix + "ConfValue", this.ConfValue);
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamSimple(map, prefix + "OriginalConfValue", this.OriginalConfValue);
        }
    }
}

