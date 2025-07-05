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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaCuttingOutForm : AbstractModel
    {
        
        /// <summary>
        /// 输出类型，可选值：
        /// Static：静态图；
        /// Dynamic：动态图；
        /// Sprite：雪碧图；
        /// Video：视频。
        /// 
        /// 注1：不同类型时，对应的 TargetInfo.Format 格式支持如下：
        /// Static：jpg、png；
        /// Dynamic：gif；
        /// Sprite：jpg、png；
        /// Video：mp4。
        /// 
        /// 注2：当 Type=Sprite时，TargetInfo指定的尺寸表示小图的大小，最终结果尺寸以输出为准。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 背景填充方式，可选值：
        /// White：白色填充；
        /// Black：黑色填充；
        /// Stretch：拉伸；
        /// Gaussian：高斯模糊；
        /// 默认White。
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// 【废弃】参考SpriteInfo
        /// </summary>
        [JsonProperty("SpriteRowCount")]
        public long? SpriteRowCount{ get; set; }

        /// <summary>
        /// 【废弃】参考SpriteInfo
        /// </summary>
        [JsonProperty("SpriteColumnCount")]
        public long? SpriteColumnCount{ get; set; }

        /// <summary>
        /// Type=Sprite时有效，表示雪碧图参数信息。
        /// </summary>
        [JsonProperty("SpriteInfo")]
        public SpriteImageInfo SpriteInfo{ get; set; }

        /// <summary>
        /// Type=Dynamic时有效，表示动图参数信息。
        /// </summary>
        [JsonProperty("DynamicInfo")]
        public DynamicImageInfo DynamicInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "SpriteRowCount", this.SpriteRowCount);
            this.SetParamSimple(map, prefix + "SpriteColumnCount", this.SpriteColumnCount);
            this.SetParamObj(map, prefix + "SpriteInfo.", this.SpriteInfo);
            this.SetParamObj(map, prefix + "DynamicInfo.", this.DynamicInfo);
        }
    }
}

