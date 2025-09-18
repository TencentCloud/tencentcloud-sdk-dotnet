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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddCustomizedConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 配置名字
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 配置类型，取值范围["CLB", "SERVER", "LOCATION"]，分别表示CLB配置，server配置，location配置。
        /// </summary>
        [JsonProperty("ConfigType")]
        public string ConfigType{ get; set; }

        /// <summary>
        /// 配置内容
        /// </summary>
        [JsonProperty("ConfigContent")]
        public string ConfigContent{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamSimple(map, prefix + "ConfigType", this.ConfigType);
            this.SetParamSimple(map, prefix + "ConfigContent", this.ConfigContent);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

