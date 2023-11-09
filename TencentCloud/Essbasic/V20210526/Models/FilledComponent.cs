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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FilledComponent : AbstractModel
    {
        
        /// <summary>
        /// 填写控件ID
        /// </summary>
        [JsonProperty("ComponentId")]
        public string ComponentId{ get; set; }

        /// <summary>
        /// 控件名称
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// 此填写控件的填写状态
        ///  **0** : 此填写控件**未填写**
        /// **1** : 此填写控件**已填写**
        /// </summary>
        [JsonProperty("ComponentFillStatus")]
        public string ComponentFillStatus{ get; set; }

        /// <summary>
        /// 控件填写内容
        /// </summary>
        [JsonProperty("ComponentValue")]
        public string ComponentValue{ get; set; }

        /// <summary>
        /// 图片填充控件下载链接，如果是图片填充控件时，这里返回图片的下载链接。
        /// 
        /// 注: `链接不是永久链接,  默认有效期5分钟后, 到期后链接失效`
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentId", this.ComponentId);
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
            this.SetParamSimple(map, prefix + "ComponentFillStatus", this.ComponentFillStatus);
            this.SetParamSimple(map, prefix + "ComponentValue", this.ComponentValue);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
        }
    }
}

