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

    public class UpdateVarRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用ID，获取方法参看如何获取   <a href="https://cloud.tencent.com/document/product/1759/109469#4eecb8c1-6ce4-45f5-8fa2-b269449d8efa">BotBizId</a>。</p>
        /// </summary>
        [JsonProperty("AppBizId")]
        public string AppBizId{ get; set; }

        /// <summary>
        /// <p>变量 ID。由 CreateVar 接口生成，通过 CreateVar / DescribeVar 返回结果获取。</p>
        /// </summary>
        [JsonProperty("VarId")]
        public string VarId{ get; set; }

        /// <summary>
        /// <p>变量名称，最大支持50个字符，英文字母开头，支持英文数字与下划线”_” 。</p>
        /// </summary>
        [JsonProperty("VarName")]
        public string VarName{ get; set; }

        /// <summary>
        /// <p>参数描述</p>
        /// </summary>
        [JsonProperty("VarDesc")]
        public string VarDesc{ get; set; }

        /// <summary>
        /// <p>变量类型</p><p>枚举值：</p><ul><li>STRING： 字符串</li><li>INT： 整形</li><li>BOOL： 布尔型</li><li>OBJECT： 对象</li><li>ARRAY_STRING： 字符串数组</li><li>ARRAY_INT： 整型数组</li><li>ARRAY_FLOAT： 浮点型数组</li><li>ARRAY_BOOL： 布尔型数组</li><li>ARRAY_OBJECT： 对象数组</li><li>FILE： 文件类型</li><li>DOCUMENT： 文档类型</li><li>IMAGE： 图片类型</li><li>AUDIO： 音频</li><li>VIDEO： 视频</li><li>ARRAY_FILE： 文件数组</li><li>ARRAY_DOCUMENT： 文档数组</li><li>ARRAY_IMAGE： 图片数组</li><li>ARRAY_AUDIO： 音频数组</li><li>ARRAY_VIDEO： 视频数组</li><li>SECRET： 秘钥</li><li>ARRAY_ARRAY： 多维数组</li></ul><p>默认值：STRING</p>
        /// </summary>
        [JsonProperty("VarType")]
        public string VarType{ get; set; }

        /// <summary>
        /// <p>自定义变量默认值，<code>VarDefaultValue</code>&nbsp;默认为空</p>
        /// </summary>
        [JsonProperty("VarDefaultValue")]
        public string VarDefaultValue{ get; set; }

        /// <summary>
        /// <p>自定义变量文件默认名称，<code>VarDefaultFileName</code> 默认为空</p>
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
            this.SetParamSimple(map, prefix + "VarId", this.VarId);
            this.SetParamSimple(map, prefix + "VarName", this.VarName);
            this.SetParamSimple(map, prefix + "VarDesc", this.VarDesc);
            this.SetParamSimple(map, prefix + "VarType", this.VarType);
            this.SetParamSimple(map, prefix + "VarDefaultValue", this.VarDefaultValue);
            this.SetParamSimple(map, prefix + "VarDefaultFileName", this.VarDefaultFileName);
            this.SetParamSimple(map, prefix + "VarModuleType", this.VarModuleType);
        }
    }
}

