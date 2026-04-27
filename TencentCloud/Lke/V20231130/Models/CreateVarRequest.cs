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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVarRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用ID，获取方法参看如何获取   <a href="https://cloud.tencent.com/document/product/1759/109469#4eecb8c1-6ce4-45f5-8fa2-b269449d8efa">BotBizId</a>。</p>
        /// </summary>
        [JsonProperty("AppBizId")]
        public string AppBizId{ get; set; }

        /// <summary>
        /// <p>变量名称，不允许重复，最大支持50个字符，英文字母开头，支持英文数字与下划线”_”。</p>
        /// </summary>
        [JsonProperty("VarName")]
        public string VarName{ get; set; }

        /// <summary>
        /// <p>变量描述，最大支持120个字符</p>
        /// </summary>
        [JsonProperty("VarDesc")]
        public string VarDesc{ get; set; }

        /// <summary>
        /// <p>变量类型定义，支持类型如下：(STRING,INT,FLOAT,BOOL,OBJECT,ARRAY_STRING,ARRAY_INT,ARRAY_FLOAT,ARRAY_BOOL,ARRAY_OBJECT,FILE,DOCUMENT,IMAGE,AUDIO);传输过程是json字符串，标签中仅支持&quot;STRING&quot;类型使用</p>
        /// </summary>
        [JsonProperty("VarType")]
        public string VarType{ get; set; }

        /// <summary>
        /// <p>自定义变量默认值，<code>VarDefaultValue</code>xa0默认为空</p>
        /// </summary>
        [JsonProperty("VarDefaultValue")]
        public string VarDefaultValue{ get; set; }

        /// <summary>
        /// <p>自定义变量文件默认名称，<code>VarDefaultFileName</code>默认为空</p>
        /// </summary>
        [JsonProperty("VarDefaultFileName")]
        public string VarDefaultFileName{ get; set; }

        /// <summary>
        /// <p>变量模块类型</p><p>枚举值：</p><ul><li>0： API参数</li><li>1： 环境参数</li><li>2： 应用参数</li><li>3： 系统参数</li></ul>
        /// </summary>
        [JsonProperty("VarModuleType")]
        public ulong? VarModuleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppBizId", this.AppBizId);
            this.SetParamSimple(map, prefix + "VarName", this.VarName);
            this.SetParamSimple(map, prefix + "VarDesc", this.VarDesc);
            this.SetParamSimple(map, prefix + "VarType", this.VarType);
            this.SetParamSimple(map, prefix + "VarDefaultValue", this.VarDefaultValue);
            this.SetParamSimple(map, prefix + "VarDefaultFileName", this.VarDefaultFileName);
            this.SetParamSimple(map, prefix + "VarModuleType", this.VarModuleType);
        }
    }
}

