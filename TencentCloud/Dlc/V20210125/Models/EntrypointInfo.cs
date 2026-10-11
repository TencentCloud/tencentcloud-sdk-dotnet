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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EntrypointInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>SQL 语句文本，须为 Base64 编码的 UTF-8 文本。仅 SPARK_SQL 模式可传且必填（解码后 ≤1MB）；SPARK_BATCH 模式禁止传。</p>
        /// </summary>
        [JsonProperty("Statement")]
        public string Statement{ get; set; }

        /// <summary>
        /// <p>作业文件路径（JAR/Python），须匹配配置的路径前缀白名单。以 .py 结尾判定为 Python 入口（EntryPoint 禁传），否则为 JAR 入口（EntryPoint 必填）。</p>
        /// </summary>
        [JsonProperty("EntryFile")]
        public string EntryFile{ get; set; }

        /// <summary>
        /// <p>入口类名（main class 全限定名）。JAR 入口（EntryFile 非 .py 结尾）必填；Python 入口（.py 结尾）禁传；SPARK_SQL 模式禁止传。</p>
        /// </summary>
        [JsonProperty("EntryPoint")]
        public string EntryPoint{ get; set; }

        /// <summary>
        /// <p>主方法参数列表（JSON 数组字符串），仅 SPARK_BATCH 模式可传；SPARK_SQL 模式禁止传。</p>
        /// </summary>
        [JsonProperty("MainArgs")]
        public string MainArgs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Statement", this.Statement);
            this.SetParamSimple(map, prefix + "EntryFile", this.EntryFile);
            this.SetParamSimple(map, prefix + "EntryPoint", this.EntryPoint);
            this.SetParamSimple(map, prefix + "MainArgs", this.MainArgs);
        }
    }
}

