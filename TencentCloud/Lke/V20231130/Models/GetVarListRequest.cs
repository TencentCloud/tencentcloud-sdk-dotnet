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

    public class GetVarListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用ID，获取方法参看如何获取   <a href="https://cloud.tencent.com/document/product/1759/109469#4eecb8c1-6ce4-45f5-8fa2-b269449d8efa">BotBizId</a>。</p>
        /// </summary>
        [JsonProperty("AppBizId")]
        public string AppBizId{ get; set; }

        /// <summary>
        /// <p>变量ID数组</p>
        /// </summary>
        [JsonProperty("VarIds")]
        public string[] VarIds{ get; set; }

        /// <summary>
        /// <p>按变量名称关键词搜索</p>
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <p>起始偏移量（默认0），取值范围 &gt; 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>限定数量（默认15），取值范围 1-200</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>按变量类型过滤，默认查询所有类型(STRING,INT,FLOAT,BOOL,OBJECT,ARRAY_STRING,ARRAY_INT,ARRAY_FLOAT,ARRAY_BOOL,ARRAY_OBJECT,FILE,DOCUMENT,IMAGE,AUDIO)</p>
        /// </summary>
        [JsonProperty("VarType")]
        public string VarType{ get; set; }

        /// <summary>
        /// <p>是否需要内部变量, 在结果中包含平台预置的“内置自定义变量” (默认false)。</p><ul><li>当&nbsp;<code>NeedInternalVar = true</code>&nbsp;且&nbsp;<code>VarModuleType</code>&nbsp;为&nbsp;<code>AllVar</code>&nbsp;或&nbsp;<code>ApiVar</code>&nbsp;时，返回列表会在用户变量之前拼入内置变量，并同样支持&nbsp;<code>Keyword</code>&nbsp;<code>VarType</code>&nbsp;<code>VarIds</code>&nbsp;过滤。</li><li>其他<code>VarModuleType</code>下，该开关不生效。</li></ul>
        /// </summary>
        [JsonProperty("NeedInternalVar")]
        public bool? NeedInternalVar{ get; set; }

        /// <summary>
        /// <p>变量模块类型</p><p>枚举值：</p><ul><li>0： API参数</li><li>1： 环境参数</li><li>2： 应用参数</li><li>3： 系统参数</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("VarModuleType")]
        public long? VarModuleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppBizId", this.AppBizId);
            this.SetParamArraySimple(map, prefix + "VarIds.", this.VarIds);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "VarType", this.VarType);
            this.SetParamSimple(map, prefix + "NeedInternalVar", this.NeedInternalVar);
            this.SetParamSimple(map, prefix + "VarModuleType", this.VarModuleType);
        }
    }
}

