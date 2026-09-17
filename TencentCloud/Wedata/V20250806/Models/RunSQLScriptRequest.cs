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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunSQLScriptRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 脚本id。如果不填则需要传入 ScriptConfig、ScriptContent，此时为免脚本临时运行模式，服务端不保存脚本
        /// </summary>
        [JsonProperty("ScriptId")]
        public string ScriptId{ get; set; }

        /// <summary>
        /// 脚本配置。免脚本临时运行模式（未传 ScriptId）下必填，其中 DatasourceId 必填、ExecutorGroupId 选填（缺省时使用项目管理-数据分析配置中的执行资源组）；传入 ScriptId 时本字段被忽略，配置取自已保存的脚本
        /// </summary>
        [JsonProperty("ScriptConfig")]
        public SQLScriptConfig ScriptConfig{ get; set; }

        /// <summary>
        /// 脚本内容，支持传递代码原文或者 Base64 编码，服务端自动识别。传 ScriptId 时不传则执行已保存的全量脚本内容；免脚本临时运行模式下必填。注意：若原文恰好由 Base64 字符集组成且长度为 4 的倍数（如 descTBLS），会被识别为已编码，此类内容请显式 Base64 编码后传入
        /// </summary>
        [JsonProperty("ScriptContent")]
        public string ScriptContent{ get; set; }

        /// <summary>
        /// 高级运行参数，支持传递 JSON 格式原文或者 Base64 编码，服务端自动识别。示例：{"executorNum":1} 或 eyJleGVjdXRvck51bSI6MX0=
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ScriptId", this.ScriptId);
            this.SetParamObj(map, prefix + "ScriptConfig.", this.ScriptConfig);
            this.SetParamSimple(map, prefix + "ScriptContent", this.ScriptContent);
            this.SetParamSimple(map, prefix + "Params", this.Params);
        }
    }
}

