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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCustomizationRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID，登录控制台创建应用得到的AppID
        /// </summary>
        [JsonProperty("BizId")]
        public long? BizId{ get; set; }

        /// <summary>
        /// 文本文件的下载地址，服务会从该地址下载文件，目前仅支持腾讯云cos
        /// </summary>
        [JsonProperty("TextUrl")]
        public string TextUrl{ get; set; }

        /// <summary>
        /// 修改的模型ID
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "TextUrl", this.TextUrl);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
        }
    }
}

