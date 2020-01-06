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

namespace TencentCloud.Ds.V20180523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SignKeyword : AbstractModel
    {
        
        /// <summary>
        /// 关键字
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// X轴偏移坐标
        /// </summary>
        [JsonProperty("OffsetCoordX")]
        public string OffsetCoordX{ get; set; }

        /// <summary>
        /// Y轴偏移坐标
        /// </summary>
        [JsonProperty("OffsetCoordY")]
        public string OffsetCoordY{ get; set; }

        /// <summary>
        /// 签章图片宽度
        /// </summary>
        [JsonProperty("ImageWidth")]
        public string ImageWidth{ get; set; }

        /// <summary>
        /// 签章图片高度
        /// </summary>
        [JsonProperty("ImageHeight")]
        public string ImageHeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "OffsetCoordX", this.OffsetCoordX);
            this.SetParamSimple(map, prefix + "OffsetCoordY", this.OffsetCoordY);
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
        }
    }
}

