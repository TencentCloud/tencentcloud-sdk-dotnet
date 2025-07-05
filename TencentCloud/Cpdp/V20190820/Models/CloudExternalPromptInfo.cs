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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudExternalPromptInfo : AbstractModel
    {
        
        /// <summary>
        /// 优惠商品信息类型。
        /// </summary>
        [JsonProperty("ExternalPromptType")]
        public string ExternalPromptType{ get; set; }

        /// <summary>
        /// 优惠商品信息数据。
        /// </summary>
        [JsonProperty("ExternalPromptValue")]
        public string ExternalPromptValue{ get; set; }

        /// <summary>
        /// 优惠商品名称。
        /// </summary>
        [JsonProperty("ExternalPromptName")]
        public string ExternalPromptName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExternalPromptType", this.ExternalPromptType);
            this.SetParamSimple(map, prefix + "ExternalPromptValue", this.ExternalPromptValue);
            this.SetParamSimple(map, prefix + "ExternalPromptName", this.ExternalPromptName);
        }
    }
}

