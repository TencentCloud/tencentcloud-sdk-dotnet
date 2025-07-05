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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCustomizationRequest : AbstractModel
    {
        
        /// <summary>
        /// 自学习模型名称，需在1-20字符之间
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 文本文件的下载地址，服务会从该地址下载文件，目前仅支持腾讯云cos
        /// </summary>
        [JsonProperty("TextUrl")]
        public string TextUrl{ get; set; }

        /// <summary>
        /// 自学习模型类型，填写8k或者16k
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("TagInfos")]
        [System.Obsolete]
        public string[] TagInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "TextUrl", this.TextUrl);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamArraySimple(map, prefix + "TagInfos.", this.TagInfos);
        }
    }
}

