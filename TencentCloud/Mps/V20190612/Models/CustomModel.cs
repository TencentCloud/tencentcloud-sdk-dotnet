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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomModel : AbstractModel
    {
        
        /// <summary>
        /// <p>性别</p><p>枚举值：</p><ul><li>male： 男性</li><li>female： 女性</li><li>any： 不限</li></ul>
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// <p>年龄范围</p><p>枚举值：</p><ul><li>teen： 青年</li><li>young_adult： 成年</li><li>middle_aged： 中年</li><li>mature： 成熟</li></ul>
        /// </summary>
        [JsonProperty("Age")]
        public string Age{ get; set; }

        /// <summary>
        /// <p>外貌</p><p>枚举值：</p><ul><li>caucasian： 白人</li><li>asian： 亚裔</li><li>latino： 拉丁裔</li><li>african： 非裔</li><li>middle_eastern： 中东</li></ul>
        /// </summary>
        [JsonProperty("Appearance")]
        public string Appearance{ get; set; }

        /// <summary>
        /// <p>身材</p><p>枚举值：</p><ul><li>slim： 苗条</li><li>standard： 标准</li><li>athletic： 健壮</li><li>chubby： 丰满</li></ul>
        /// </summary>
        [JsonProperty("BodyType")]
        public string BodyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Appearance", this.Appearance);
            this.SetParamSimple(map, prefix + "BodyType", this.BodyType);
        }
    }
}

