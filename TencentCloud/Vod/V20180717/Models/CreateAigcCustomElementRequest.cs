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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAigcCustomElementRequest : AbstractModel
    {
        
        /// <summary>
        /// 主体名称。不能超过20个字符
        /// </summary>
        [JsonProperty("ElementName")]
        public string ElementName{ get; set; }

        /// <summary>
        /// 主体描述。
        /// 
        /// 不能超过100个字符。
        /// </summary>
        [JsonProperty("ElementDescription")]
        public string ElementDescription{ get; set; }

        /// <summary>
        /// 主体正面参考图。
        /// 支持传入图片URL（确保可访问）
        /// 图片格式支持.jpg / .jpeg / .png
        /// 图片文件大小不能超过10MB，图片宽高尺寸不小于300px，图片宽高比要在1:2.5 ~ 2.5:1之间。
        /// </summary>
        [JsonProperty("ElementFrontalImage")]
        public string ElementFrontalImage{ get; set; }

        /// <summary>
        /// 主体其他参考列表  可通过上传多张、不同角度的主体参考图来定义主体外观 至少上传1张参考图，至多上传3张参考图。
        /// </summary>
        [JsonProperty("ElementReferList")]
        public ElementReferInfo[] ElementReferList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ElementName", this.ElementName);
            this.SetParamSimple(map, prefix + "ElementDescription", this.ElementDescription);
            this.SetParamSimple(map, prefix + "ElementFrontalImage", this.ElementFrontalImage);
            this.SetParamArrayObj(map, prefix + "ElementReferList.", this.ElementReferList);
        }
    }
}

