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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageOperation : AbstractModel
    {
        
        /// <summary>
        /// 图片处理类型。可选类型有：
        /// <li>Scale : 图片缩略处理。</li>
        /// <li>CenterCut : 图片裁剪处理。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 图片缩略处理，仅当 Type 为 Scale 时有效。
        /// </summary>
        [JsonProperty("Scale")]
        public ImageScale Scale{ get; set; }

        /// <summary>
        /// 图片裁剪处理，仅当 Type 为 CenterCut 时有效。
        /// </summary>
        [JsonProperty("CenterCut")]
        public ImageCenterCut CenterCut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Scale.", this.Scale);
            this.SetParamObj(map, prefix + "CenterCut.", this.CenterCut);
        }
    }
}

