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

    public class ProcessImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片处理的文件输入信息。
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// 图片处理输出文件的目标存储。不填则继承 InputInfo 中的存储位置。
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// 图片处理生成的文件输出的路径。如果不填表示与 InputInfo 中文件所在的目录一致。如果是目录，如`/image/201907/`，表示继承原文件名输出到该目录。
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// 输出路径，可以为相对路径或者绝对路径。
        /// 若需定义输出路径，路径需以`.{format}`结尾。变量名请参考 [文件名变量说明](https://cloud.tencent.com/document/product/862/37039)。
        /// 相对路径示例：
        /// <li>文件名_{变量名}.{format}</li>
        /// <li>文件名.{format}</li>
        /// 绝对路径示例：
        /// <li>/自定义路径/文件名_{变量名}.{format}</li>
        /// 如果不填，则默认为相对路径：{inputName}.{format}。
        /// </summary>
        [JsonProperty("OutputPath")]
        public string OutputPath{ get; set; }

        /// <summary>
        /// 图片处理参数。
        /// </summary>
        [JsonProperty("ImageTask")]
        public ImageTaskInput ImageTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamSimple(map, prefix + "OutputPath", this.OutputPath);
            this.SetParamObj(map, prefix + "ImageTask.", this.ImageTask);
        }
    }
}

