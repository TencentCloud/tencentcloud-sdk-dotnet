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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitPythonTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源组Id
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 脚本内容
        /// </summary>
        [JsonProperty("ScriptContent")]
        public string ScriptContent{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 脚本类型
        /// </summary>
        [JsonProperty("ScriptType")]
        public string ScriptType{ get; set; }

        /// <summary>
        /// 脚本名称(PYTHON2/PYTHON3)
        /// </summary>
        [JsonProperty("ScriptName")]
        public string ScriptName{ get; set; }

        /// <summary>
        /// 脚本文件路径
        /// </summary>
        [JsonProperty("ScriptPath")]
        public string ScriptPath{ get; set; }

        /// <summary>
        /// 高级运行参数
        /// </summary>
        [JsonProperty("RunParams")]
        public string RunParams{ get; set; }

        /// <summary>
        /// 脚本ID
        /// </summary>
        [JsonProperty("ScriptId")]
        public string ScriptId{ get; set; }

        /// <summary>
        /// 脚本内容是否base64加密
        /// </summary>
        [JsonProperty("ScriptEncryption")]
        public bool? ScriptEncryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ScriptContent", this.ScriptContent);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ScriptType", this.ScriptType);
            this.SetParamSimple(map, prefix + "ScriptName", this.ScriptName);
            this.SetParamSimple(map, prefix + "ScriptPath", this.ScriptPath);
            this.SetParamSimple(map, prefix + "RunParams", this.RunParams);
            this.SetParamSimple(map, prefix + "ScriptId", this.ScriptId);
            this.SetParamSimple(map, prefix + "ScriptEncryption", this.ScriptEncryption);
        }
    }
}

