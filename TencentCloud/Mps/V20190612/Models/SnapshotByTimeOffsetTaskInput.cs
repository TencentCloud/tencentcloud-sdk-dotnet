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

    public class SnapshotByTimeOffsetTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 指定时间点截图模板 ID。
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 截图时间点列表，时间点支持 s、% 两种格式：
        /// <li>当字符串以 s 结尾，表示时间点单位为秒，如 3.5s 表示时间点为第3.5秒；</li>
        /// <li>当字符串以 % 结尾，表示时间点为视频时长的百分比大小，如10%表示时间点为视频前第10%的时间。</li>
        /// </summary>
        [JsonProperty("ExtTimeOffsetSet")]
        public string[] ExtTimeOffsetSet{ get; set; }

        /// <summary>
        /// 截图时间点列表，单位为<font color=red>秒</font>。此参数已不再建议使用，建议您使用 ExtTimeOffsetSet 参数。
        /// </summary>
        [JsonProperty("TimeOffsetSet")]
        public float?[] TimeOffsetSet{ get; set; }

        /// <summary>
        /// 水印列表，支持多张图片或文字水印，最大可支持 10 张。
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }

        /// <summary>
        /// 时间点截图后文件的目标存储，不填则继承上层的 OutputStorage 值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// 时间点截图后图片文件的输出路径，可以为相对路径或者绝对路径。
        /// 若需定义输出路径，路径需以`.{format}`结尾。变量名请参考 [文件名变量说明](https://cloud.tencent.com/document/product/862/37039)。
        /// 相对路径示例：
        /// <li>文件名_{变量名}.{format}</li>
        /// <li>文件名.{format}</li>
        /// 绝对路径示例：
        /// <li>/自定义路径/文件名_{变量名}.{format}</li>
        /// 如果不填，则默认为相对路径：`{inputName}_snapshotByTimeOffset_{definition}_{number}.{format}`。
        /// </summary>
        [JsonProperty("OutputObjectPath")]
        public string OutputObjectPath{ get; set; }

        /// <summary>
        /// 时间点截图后输出路径中的`{number}`变量的规则。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectNumberFormat")]
        public NumberFormat ObjectNumberFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamArraySimple(map, prefix + "ExtTimeOffsetSet.", this.ExtTimeOffsetSet);
            this.SetParamArraySimple(map, prefix + "TimeOffsetSet.", this.TimeOffsetSet);
            this.SetParamArrayObj(map, prefix + "WatermarkSet.", this.WatermarkSet);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputObjectPath", this.OutputObjectPath);
            this.SetParamObj(map, prefix + "ObjectNumberFormat.", this.ObjectNumberFormat);
        }
    }
}

