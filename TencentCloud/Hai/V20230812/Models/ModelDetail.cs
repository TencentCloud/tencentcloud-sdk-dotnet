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

namespace TencentCloud.Hai.V20230812.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>模型名称</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>模型ID</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>应用描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>官方社区链接</p>
        /// </summary>
        [JsonProperty("CommunityUrl")]
        public string CommunityUrl{ get; set; }

        /// <summary>
        /// <p>最佳实践链接</p>
        /// </summary>
        [JsonProperty("GuideUrl")]
        public string GuideUrl{ get; set; }

        /// <summary>
        /// <p>模型状态</p>
        /// </summary>
        [JsonProperty("ModelState")]
        public string ModelState{ get; set; }

        /// <summary>
        /// <p>应用对应的标签，如机器学习</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>配置环境</p>
        /// </summary>
        [JsonProperty("ConfigEnvironment")]
        public string ConfigEnvironment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CommunityUrl", this.CommunityUrl);
            this.SetParamSimple(map, prefix + "GuideUrl", this.GuideUrl);
            this.SetParamSimple(map, prefix + "ModelState", this.ModelState);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ConfigEnvironment", this.ConfigEnvironment);
        }
    }
}

