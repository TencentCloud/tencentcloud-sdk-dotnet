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

    public class ImageProcessOutputConfig : AbstractModel
    {
        
        /// <summary>
        /// 输出图片的宽高比。可以配合ImageWidth 和 ImageHeight 使用，规则如下：
        /// 
        /// 1. 仅指定 AspectRatio 时，根据原图输入进行自适应调整。
        /// 2. 指定 AspectRatio 和 ImageWidth 时，ImageHeight  由两者计算得出，反亦是如此。
        /// 3. 当AspectRatio、ImageWidth、ImageHeight 同时指定的时候，优先使用ImageWidth、ImageHeight。
        /// 
        /// 可取值：1:1、3:2、2:3、3:4、4:3、4:5、5:4、9:16、16:9、21:9
        /// 
        /// 支持该参数 ScheduleId: 30010(扩图)
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// 图片输出高度，单位：像素。
        /// </summary>
        [JsonProperty("ImageHeight")]
        public long? ImageHeight{ get; set; }

        /// <summary>
        /// 图片输出宽度，单位：像素。
        /// </summary>
        [JsonProperty("ImageWidth")]
        public long? ImageWidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
        }
    }
}

