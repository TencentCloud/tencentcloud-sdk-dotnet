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

    public class AigcVideoOutputConfig : AbstractModel
    {
        
        /// <summary>
        /// 存储模式。取值有： <li>Permanent：永久存储，生成的视频文件将存储到云点播，可在事件通知中获取到 FileId；</li> <li>Temporary：临时存储，生成的视频文件不会存储到云点播，可在事件通知中获取到临时访问的 URL；</li>
        /// 默认值：Temporary
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// 输出媒体文件名，最长 64 个字符。缺省由系统指定生成文件名。
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
        /// 生成视频的时长，单位：秒。<li>当 ModelName 是 Kling，可选值为 5、10，默认为 5；</li><li>当 ModelName 是 Jimeng，可选值为 5、10，默认为 5；</li><li>当 ModelName 是 Hailuo，可选值为 6、10，默认为 6；</li><li>当 ModelName 是 Vidu，可指定1-10；</li><li>当 ModelName 是 GV，可选值为 8，默认为 8；</li><li>当 ModelName 是 OS，可选值为 4、8、12，默认为 8；</li>
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 生成视频的分辨率。
        /// <li>当 ModelName 是 Kling，可选值为 720P、1080P，默认为 720P；</li>
        /// <li>当 ModelName 是 Hailuo，可选值为 768P、1080P，默认为 768P；</li>
        /// <li>当 ModelName 是 Jimeng，可选值为 1080P；</li>
        /// <li>当 ModelName 是 Vidu，可选值为 720P、1080P，默认为 720P；</li>
        /// <li>当 ModelName 是 GV，可选值为 720P、1080P，默认为 720P；</li>
        /// <li>当 ModelName 是 OS，可选值为 720P；</li>
        /// 说明：除模型可支持的分辨率外，还支持 2K、4K分辨率。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 指定所生成视频的宽高比。
        /// <li>当 ModelName 是 Kling，当文生视频时，则可选值为 16:9、9:16、 1:1，默认为16:9；</li>
        /// <li>当 ModelName 是 Jimeng，当文生视频时，则可选值为 16:9、4:3、1:1、3:4、9:16、21:9</li>
        /// <li>当 ModelName 是 Vidu，当文生视频时和使用参考图片生成时，则可选值为 16:9、9:16、4:3、3:4、1:1，其中仅版本q2支持4:3、3:4</li>
        /// <li>当 ModelName 是 GV，则可选值为 16:9、9:16，默认为 16:9；</li>
        /// <li>当 ModelName 是 OS，当文生视频时，则可选值为 16:9、9:16，默认为 16:9；</li>
        /// <li>当 ModelName 是 Hailuo，则暂不支持。</li>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// 是否生成音频。支持的模型包括 GV、OS。取值有： <li>Enabled：开启；</li> <li>Disabled：关闭；</li>
        /// 默认值：Enabled
        /// </summary>
        [JsonProperty("AudioGeneration")]
        public string AudioGeneration{ get; set; }

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
        /// 是否启用视频增强。取值有： <li>Enabled：开启；</li> <li>Disabled：关闭；</li> 
        /// 说明：
        /// 1. 对于选择的分辨率超过模型可生成分辨率时，默认会启用增强。
        /// 2. 对于模型可以直出的分辨率，也可以主动选择模型直出低分辨率，使用增强获得指定分辨率。
        /// </summary>
        [JsonProperty("EnhanceSwitch")]
        public string EnhanceSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "MediaName", this.MediaName);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "AudioGeneration", this.AudioGeneration);
            this.SetParamSimple(map, prefix + "PersonGeneration", this.PersonGeneration);
            this.SetParamSimple(map, prefix + "InputComplianceCheck", this.InputComplianceCheck);
            this.SetParamSimple(map, prefix + "OutputComplianceCheck", this.OutputComplianceCheck);
            this.SetParamSimple(map, prefix + "EnhanceSwitch", this.EnhanceSwitch);
        }
    }
}

