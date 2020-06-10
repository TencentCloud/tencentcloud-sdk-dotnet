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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateNotebookLifecycleScriptRequest : AbstractModel
    {
        
        /// <summary>
        /// notebook生命周期脚本名称
        /// </summary>
        [JsonProperty("NotebookLifecycleScriptsName")]
        public string NotebookLifecycleScriptsName{ get; set; }

        /// <summary>
        /// 创建脚本，base64编码
        /// base64后的脚本长度不能超过16384个字符
        /// </summary>
        [JsonProperty("CreateScript")]
        public string CreateScript{ get; set; }

        /// <summary>
        /// 启动脚本，base64编码
        /// base64后的脚本长度不能超过16384个字符
        /// </summary>
        [JsonProperty("StartScript")]
        public string StartScript{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotebookLifecycleScriptsName", this.NotebookLifecycleScriptsName);
            this.SetParamSimple(map, prefix + "CreateScript", this.CreateScript);
            this.SetParamSimple(map, prefix + "StartScript", this.StartScript);
        }
    }
}

