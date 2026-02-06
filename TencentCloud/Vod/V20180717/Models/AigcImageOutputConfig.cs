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
        /// 生成图片的分辨率。
        /// 
        /// * GEM 2.5 可选值：1K、2K、4K，默认1K；
        /// * GEM 3.0 可选值：1K、2K、4K，默认1K；
        /// * Vidu q2 可选值：1080p、2K、4K，默认1080p；
        /// * Kling 2.1 可选值：1k、2k，默认1k；
        /// * Hunyuan 3.0 可选值：720P、1080P、2K、4K。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 指定所生成图片的宽高比。
        /// <li>当 ModelName 是 GEM，可选值是 1:1、3:2、2:3、3:4、4:3、4:5、5:4、9:16、16:9 和 21:9；</li>
        /// <li>当 ModelName 是 Qwen，则暂不支持。</li>
        /// <li>当 ModelName 是 Hunyuan，可选值16:9、9:16、1:1、4:3、3:4、3:2、2:3、21:9。</li>
        /// <li>当 ModelName 是 Vidu，可选值16:9、9:16、1:1、3:4、4:3、21:9、2:3、3:2。</li>
        /// <li>当 ModelName 是 Kling，可选值16:9、9:16、1:1、4:3、3:4、3:2、2:3、21:9。</li>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// 是否允许人物或人脸生成。取值有： <li>AllowAdult：允许生成成人；</li> <li>Disallowed：禁止在图片中包含人物或人脸；</li> 
        /// </summary>
        [JsonProperty("PersonGeneration")]
        public string PersonGeneration{ get; set; }

        /// <summary>
        /// 是否开启输入内容的合规性检查。取值有： <li>Enabled：开启；</li> <li>Disabled：关闭；</li> 
        /// </summary>
        [JsonProperty("InputComplianceCheck")]
        public string InputComplianceCheck{ get; set; }

        /// <summary>
        /// 是否开启输出内容的合规性检查。取值有： <li>Enabled：开启；</li> <li>Disabled：关闭；</li> 
        /// </summary>
        [JsonProperty("OutputComplianceCheck")]
        public string OutputComplianceCheck{ get; set; }


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
        }
    }
}

