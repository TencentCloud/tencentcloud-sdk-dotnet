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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonMixCropParams : AbstractModel
    {
        
        /// <summary>
        /// 裁剪的宽度。取值范围[0，2000]。
        /// </summary>
        [JsonProperty("CropWidth")]
        public float? CropWidth{ get; set; }

        /// <summary>
        /// 裁剪的高度。取值范围[0，2000]。
        /// </summary>
        [JsonProperty("CropHeight")]
        public float? CropHeight{ get; set; }

        /// <summary>
        /// 裁剪的起始X坐标。取值范围[0，2000]。
        /// </summary>
        [JsonProperty("CropStartLocationX")]
        public float? CropStartLocationX{ get; set; }

        /// <summary>
        /// 裁剪的起始Y坐标。取值范围[0，2000]。
        /// </summary>
        [JsonProperty("CropStartLocationY")]
        public float? CropStartLocationY{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CropWidth", this.CropWidth);
            this.SetParamSimple(map, prefix + "CropHeight", this.CropHeight);
            this.SetParamSimple(map, prefix + "CropStartLocationX", this.CropStartLocationX);
            this.SetParamSimple(map, prefix + "CropStartLocationY", this.CropStartLocationY);
        }
    }
}

