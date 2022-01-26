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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCustomPersonRequest : AbstractModel
    {
        
        /// <summary>
        /// 自定义人物姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 自定义人物简要信息(仅用于标记，不支持检索)
        /// </summary>
        [JsonProperty("BasicInfo")]
        public string BasicInfo{ get; set; }

        /// <summary>
        /// 自定义分类ID，如不存在接口会报错
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// 自定义人物图片URL，可支持任意地址，推荐使用COS
        /// </summary>
        [JsonProperty("ImageURL")]
        public string ImageURL{ get; set; }

        /// <summary>
        /// 原始图片base64编码后的数据
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "BasicInfo", this.BasicInfo);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "ImageURL", this.ImageURL);
            this.SetParamSimple(map, prefix + "Image", this.Image);
        }
    }
}

