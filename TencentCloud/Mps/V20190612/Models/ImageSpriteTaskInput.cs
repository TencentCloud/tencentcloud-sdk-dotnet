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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageSpriteTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 雪碧图模板 ID。
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 截取雪碧图后文件的目标存储，不填则继承上层的 OutputStorage 值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// 截取雪碧图后，雪碧图图片文件的输出路径，可以为相对路径或者绝对路径。如果不填，则默认为相对路径：`{inputName}_imageSprite_{definition}_{number}.{format}`。
        /// </summary>
        [JsonProperty("OutputObjectPath")]
        public string OutputObjectPath{ get; set; }

        /// <summary>
        /// 截取雪碧图后，Web VTT 文件的输出路径，只能为相对路径。如果不填，则默认为相对路径：`{inputName}_imageSprite_{definition}.{format}`。
        /// </summary>
        [JsonProperty("WebVttObjectName")]
        public string WebVttObjectName{ get; set; }

        /// <summary>
        /// 截取雪碧图后输出路径中的`{number}`变量的规则。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectNumberFormat")]
        public NumberFormat ObjectNumberFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputObjectPath", this.OutputObjectPath);
            this.SetParamSimple(map, prefix + "WebVttObjectName", this.WebVttObjectName);
            this.SetParamObj(map, prefix + "ObjectNumberFormat.", this.ObjectNumberFormat);
        }
    }
}

