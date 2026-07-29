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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StaticConfig : AbstractModel
    {
        
        /// <summary>
        /// 框架类型：vue、react、nextjs 等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Framework")]
        public string Framework{ get; set; }

        /// <summary>
        /// Node.js 版本，默认 20
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeJsVersion")]
        public string NodeJsVersion{ get; set; }

        /// <summary>
        /// 访问路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppPath")]
        public string AppPath{ get; set; }

        /// <summary>
        /// 构建目录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BuildPath")]
        public string BuildPath{ get; set; }

        /// <summary>
        /// ZIP 文件地址（BuildType=ZIP/TEMPLATE 时使用）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZipFileUrl")]
        public string ZipFileUrl{ get; set; }

        /// <summary>
        /// COS 时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosTimestamp")]
        public string CosTimestamp{ get; set; }

        /// <summary>
        /// COS 文件后缀
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosSuffix")]
        public string CosSuffix{ get; set; }

        /// <summary>
        /// 代码源平台：github、gitlab、gitee
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeSource")]
        public string CodeSource{ get; set; }

        /// <summary>
        /// 代码仓库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeRepo")]
        public string CodeRepo{ get; set; }

        /// <summary>
        /// 代码分支
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeBranch")]
        public string CodeBranch{ get; set; }

        /// <summary>
        /// 构建参数 JSON 字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StaticCmd")]
        public StaticCmd StaticCmd{ get; set; }

        /// <summary>
        /// 构建环境变量 JSON 字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StaticEnv")]
        public StaticEnvironment StaticEnv{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Framework", this.Framework);
            this.SetParamSimple(map, prefix + "NodeJsVersion", this.NodeJsVersion);
            this.SetParamSimple(map, prefix + "AppPath", this.AppPath);
            this.SetParamSimple(map, prefix + "BuildPath", this.BuildPath);
            this.SetParamSimple(map, prefix + "ZipFileUrl", this.ZipFileUrl);
            this.SetParamSimple(map, prefix + "CosTimestamp", this.CosTimestamp);
            this.SetParamSimple(map, prefix + "CosSuffix", this.CosSuffix);
            this.SetParamSimple(map, prefix + "CodeSource", this.CodeSource);
            this.SetParamSimple(map, prefix + "CodeRepo", this.CodeRepo);
            this.SetParamSimple(map, prefix + "CodeBranch", this.CodeBranch);
            this.SetParamObj(map, prefix + "StaticCmd.", this.StaticCmd);
            this.SetParamObj(map, prefix + "StaticEnv.", this.StaticEnv);
        }
    }
}

