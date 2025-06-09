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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVarRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("AppBizId")]
        public string AppBizId{ get; set; }

        /// <summary>
        /// 变量名称，不允许重复，最大支持50个字符
        /// </summary>
        [JsonProperty("VarName")]
        public string VarName{ get; set; }

        /// <summary>
        /// 变量描述，最大支持120个字符
        /// </summary>
        [JsonProperty("VarDesc")]
        public string VarDesc{ get; set; }

        /// <summary>
        /// 变量类型定义，支持类型如下：(STRING,INT,FLOAT,BOOL,OBJECT,ARRAY_STRING,ARRAY_INT,ARRAY_FLOAT,ARRAY_BOOL,ARRAY_OBJECT,FILE,DOCUMENT,IMAGE,AUDIO);传输过程是json字符串，标签中仅支持"STRING"类型使用
        /// </summary>
        [JsonProperty("VarType")]
        public string VarType{ get; set; }

        /// <summary>
        /// 自定义变量默认值
        /// </summary>
        [JsonProperty("VarDefaultValue")]
        public string VarDefaultValue{ get; set; }

        /// <summary>
        /// 自定义变量文件默认名称
        /// </summary>
        [JsonProperty("VarDefaultFileName")]
        public string VarDefaultFileName{ get; set; }


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
        }
    }
}

