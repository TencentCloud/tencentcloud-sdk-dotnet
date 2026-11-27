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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLiveAvatarCloneFigureRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>形象克隆场景类型</p><p>枚举值：</p><ul><li>PHOTO： 图生数字人</li><li>GREEN_SCREEN： 绿幕数字人</li><li>REAL_SHOT： 实景数字人</li></ul>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>克隆的形象的名字</p>
        /// </summary>
        [JsonProperty("FigureName")]
        public string FigureName{ get; set; }

        /// <summary>
        /// <p>克隆的形象的url</p>
        /// </summary>
        [JsonProperty("MaterialUrl")]
        public string MaterialUrl{ get; set; }

        /// <summary>
        /// <p>克隆的形象的性别</p><p>枚举值：</p><ul><li>MALE： 男</li><li>FEMALE： 女</li><li>UNKNOWN： 不知道</li></ul>
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// <p>授权pdf</p>
        /// </summary>
        [JsonProperty("IdentityWrittenUrl")]
        public string IdentityWrittenUrl{ get; set; }

        /// <summary>
        /// <p>授权视频</p>
        /// </summary>
        [JsonProperty("IdentityVideoUrl")]
        public string IdentityVideoUrl{ get; set; }

        /// <summary>
        /// <p>图生视频时，动作训练幅度大小</p><p>枚举值：</p><ul><li>0： 只有头部轻微动</li><li>1： 头部跟身体均动</li></ul>
        /// </summary>
        [JsonProperty("PhotoVersion")]
        public ulong? PhotoVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "FigureName", this.FigureName);
            this.SetParamSimple(map, prefix + "MaterialUrl", this.MaterialUrl);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "IdentityWrittenUrl", this.IdentityWrittenUrl);
            this.SetParamSimple(map, prefix + "IdentityVideoUrl", this.IdentityVideoUrl);
            this.SetParamSimple(map, prefix + "PhotoVersion", this.PhotoVersion);
        }
    }
}

