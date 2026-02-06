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

    public class SceneAigcImageOutputConfig : AbstractModel
    {
        
        /// <summary>
        /// 存储模式。取值有： <li>Permanent：永久存储，生成的图片文件将存储到云点播，可在事件通知中获取到 FileId；</li> <li>Temporary：临时存储，生成的图片文件不会存储到云点播，可在事件通知中获取到临时访问的 URL；</li>
        /// 默认值：Temporary
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// 输出文件名，最长 64 个字符。缺省由系统指定生成文件名。
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// 分类ID，用于对媒体进行分类管理，可通过 [创建分类](/document/product/266/7812) 接口，创建分类，获得分类 ID。
        /// <li>默认值：0，表示其他分类。</li>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// 输出文件的过期时间，超过该时间文件将被删除，默认为永久不过期，格式按照 ISO 8601标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 指定所生成图片的宽高比。输入格式为 W:H。
        /// 本字段在以下场景有效：
        /// * 生商品图场景，可选值为：1:1、3:2、2:3、3:4、4:3、4:5、5:4、16:9、9:16、21:9
        /// * AI扩图场景。可选值为：1:1、3:2、2:3、3:4、4:3、4:5、5:4、9:16、16:9、21:9，可以配合 ImageWidth 和 ImageHeight 使用，规则如下： 
        ///     1. 仅指定 AspectRatio 时，根据原图输入进行自适应调整。
        ///     2. 指定 AspectRatio 和 ImageWidth 时，ImageHeight  由两者计算得出，反亦是如此。
        ///     3. 当AspectRatio、ImageWidth、ImageHeight 同时指定的时候，优先使用ImageWidth、ImageHeight。
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// 输出图片编码格式参数。**仅AI换衣场景有效。**
        /// </summary>
        [JsonProperty("EncodeConfig")]
        public ImageSceneAigcEncodeConfig EncodeConfig{ get; set; }

        /// <summary>
        /// 输出图像宽度，**仅AI扩图场景有效**。
        /// </summary>
        [JsonProperty("ImageWidth")]
        public ulong? ImageWidth{ get; set; }

        /// <summary>
        /// 输出图像高度，**仅AI扩图场景有效**。
        /// </summary>
        [JsonProperty("ImageHeight")]
        public ulong? ImageHeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "MediaName", this.MediaName);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamObj(map, prefix + "EncodeConfig.", this.EncodeConfig);
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
        }
    }
}

