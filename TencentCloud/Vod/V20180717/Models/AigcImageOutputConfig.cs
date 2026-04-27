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

    public class AigcImageOutputConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>存储模式</p><p>枚举值：</p><ul><li>Temporary： 临时存储，生成的视频文件不会存储到云点播，可在事件通知中获取到临时访问的 URL，有效期 7 天</li><li>Permanent： 永久存储，生成的视频文件将存储到云点播，可在事件通知中获取到 FileId</li></ul><p>默认值：Temporary</p>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// <p>输出文件名，最长 64 个字符。缺省由系统指定生成文件名。</p>
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// <p>分类ID，用于对媒体进行分类管理，可通过 <a href="/document/product/266/7812">创建分类</a> 接口，创建分类，获得分类 ID。</p><li>默认值：0，表示其他分类。</li>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>输出文件的过期时间，超过该时间文件将被删除，默认为永久不过期，格式按照 ISO 8601标准表示，详见 <a href="https://cloud.tencent.com/document/product/266/11732#I">ISO 日期格式说明</a>。</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>生成图片的分辨率。各模型可选值：</p><ul><li>OG：1080P、2K、4K；</li><li>GG 2.5：1K、2K、4K，默认1K；</li><li>GG 3.0：1K、2K、4K，默认1K；</li><li>GG 3.1：512、1K、2K、4K，默认1K；</li><li>Kling 2.1：1k、2k，默认1k；</li><li>Kling 3.0：1k、2k，默认1k；</li><li>Kling 3.0-Omni：1k、2k、4k，默认1k；</li><li>Kling O1：1k、2k、4k，默认1k；</li><li>SI 4.0：1K、2K、4K，默认1K；</li><li>SI 4.5：2K、4K，默认2K；</li><li>SI 5.0-lite：2K、3K，默认2K；</li><li>Vidu q2：1080p、2K、4K，默认1080p；</li><li>Hunyuan 3.0：暂不支持本字段，可通过<code>ExtInfo</code>字段设置分辨率；</li><li>Qwen 0925：暂不支持本字段，可通过<code>ExtInfo</code>字段设置分辨率；</li></ul>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>指定所生成图片的宽高比。</p><ul><li>OG：1:1, 3:2, 2:3, 3:4, 4:3, 16:9, 9:16, 21:9, 9:21；</li><li>GG 2.5：1:1, 2:3, 3:2, 3:4, 4:3, 4:5, 5:4, 9:16, 16:9, 21:9；</li><li>GG 3.0：1:1, 2:3, 3:2, 3:4, 4:3, 4:5, 5:4, 9:16, 16:9, 21:9；</li><li>GG 3.1：1:1, 1:4, 1:8, 2:3, 3:2, 3:4, 4:1, 4:3, 4:5, 5:4, 8:1, 9:16, 16:9, 21:9；</li><li>Kling 2.1：16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9；</li><li>Kling 3.0：16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9；</li><li>Kling 3.0-Omni：16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9, auto；</li><li>Kling O1：16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9, auto；</li><li>Vidu q2：16:9、9:16、1:1、3:4、4:3、21:9、2:3、3:2；</li><li>SI 4.0：<strong>不支持</strong>此参数，可通过prompt指定16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9；</li><li>SI 4.5：<strong>不支持</strong>此参数，可通过prompt指定16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9；</li><li>SI 5.0-lite：<strong>不支持</strong>此参数，可通过prompt指定16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9；</li><li>Hunyuan 3.0：不支持；</li><li>Qwen 2.0：不支持；</li><li>Qwen 0925：不支持；</li></ul>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// <p>是否允许人物或人脸生成。取值有： <li>AllowAdult：允许生成成人；</li> <li>Disallowed：禁止在图片中包含人物或人脸；</li></p>
        /// </summary>
        [JsonProperty("PersonGeneration")]
        public string PersonGeneration{ get; set; }

        /// <summary>
        /// <p>是否开启输入内容的合规性检查。取值有： <li>Enabled：开启；</li> <li>Disabled：关闭；</li></p>
        /// </summary>
        [JsonProperty("InputComplianceCheck")]
        public string InputComplianceCheck{ get; set; }

        /// <summary>
        /// <p>是否开启输出内容的合规性检查。取值有： <li>Enabled：开启；</li> <li>Disabled：关闭；</li></p>
        /// </summary>
        [JsonProperty("OutputComplianceCheck")]
        public string OutputComplianceCheck{ get; set; }

        /// <summary>
        /// <p>生成图片张数。各模型可选值：</p><ul><li>Kling：可选值 1-9；</li><li>OG：可选值1-8；</li></ul><p><strong>其他模型不生效。</strong></p>
        /// </summary>
        [JsonProperty("OutputImageCount")]
        public ulong? OutputImageCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "MediaName", this.MediaName);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "PersonGeneration", this.PersonGeneration);
            this.SetParamSimple(map, prefix + "InputComplianceCheck", this.InputComplianceCheck);
            this.SetParamSimple(map, prefix + "OutputComplianceCheck", this.OutputComplianceCheck);
            this.SetParamSimple(map, prefix + "OutputImageCount", this.OutputImageCount);
        }
    }
}

