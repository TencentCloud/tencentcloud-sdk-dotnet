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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventFrame : AbstractModel
    {
        
        /// <summary>
        /// <p>绝对路径</p>
        /// </summary>
        [JsonProperty("AbsPath")]
        public string AbsPath{ get; set; }

        /// <summary>
        /// <p>列号</p>
        /// </summary>
        [JsonProperty("ColNo")]
        public long? ColNo{ get; set; }

        /// <summary>
        /// <p>文件名</p>
        /// </summary>
        [JsonProperty("Filename")]
        public string Filename{ get; set; }

        /// <summary>
        /// <p>函数名</p>
        /// </summary>
        [JsonProperty("Function")]
        public string Function{ get; set; }

        /// <summary>
        /// <p>行号</p>
        /// </summary>
        [JsonProperty("LineNo")]
        public long? LineNo{ get; set; }

        /// <summary>
        /// <p>是否应用内 0/1</p>
        /// </summary>
        [JsonProperty("InApp")]
        public long? InApp{ get; set; }

        /// <summary>
        /// <p>模块</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>包名</p>
        /// </summary>
        [JsonProperty("Package")]
        public string Package{ get; set; }

        /// <summary>
        /// <p>栈层级</p>
        /// </summary>
        [JsonProperty("StackLevel")]
        public long? StackLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AbsPath", this.AbsPath);
            this.SetParamSimple(map, prefix + "ColNo", this.ColNo);
            this.SetParamSimple(map, prefix + "Filename", this.Filename);
            this.SetParamSimple(map, prefix + "Function", this.Function);
            this.SetParamSimple(map, prefix + "LineNo", this.LineNo);
            this.SetParamSimple(map, prefix + "InApp", this.InApp);
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Package", this.Package);
            this.SetParamSimple(map, prefix + "StackLevel", this.StackLevel);
        }
    }
}

