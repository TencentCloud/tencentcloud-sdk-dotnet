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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFileConfigWithDetailRespRequest : AbstractModel
    {
        
        /// <summary>
        /// 配置名称，最多支持60个字符，只能包含字母、数字及分隔符（“-”、“_”），且不能以分隔符开头或结尾。
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 配置项版本，只能包含小写字母、数字及分隔符("-"，".")，且必须以小写字母或数字开头、以小写字母或数字结尾，中间不能有连续的"-"或"."。
        /// </summary>
        [JsonProperty("ConfigVersion")]
        public string ConfigVersion{ get; set; }

        /// <summary>
        /// 配置项文件名，不超过60个字符，只能包含英文、数字、"-"（英文）、"_"（英文）、"."（英文）。
        /// </summary>
        [JsonProperty("ConfigFileName")]
        public string ConfigFileName{ get; set; }

        /// <summary>
        /// 配置项文件内容（原始内容编码需要 utf-8 格式，如果 ConfigFileCode 为 gbk，后台会进行转换）。
        /// </summary>
        [JsonProperty("ConfigFileValue")]
        public string ConfigFileValue{ get; set; }

        /// <summary>
        /// 配置项关联应用ID。该参数可以通过调用 [DescribeApplications](https://cloud.tencent.com/document/product/649/36090) 的返回值中的 ApplicationId 字段来获取或通过登录[控制台](https://console.cloud.tencent.com/tsf/app)查看；也可以调用[CreateApplication](https://cloud.tencent.com/document/product/649/36094)创建新的应用。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 发布路径。
        /// </summary>
        [JsonProperty("ConfigFilePath")]
        public string ConfigFilePath{ get; set; }

        /// <summary>
        /// 配置项版本描述，最多支持200个字符。
        /// </summary>
        [JsonProperty("ConfigVersionDesc")]
        public string ConfigVersionDesc{ get; set; }

        /// <summary>
        /// 配置项文件编码，utf-8 或 gbk。注：如果选择 gbk，需要新版本 tsf-consul-template （公有云虚拟机需要使用 1.32 tsf-agent，容器需要从文档中获取最新的 tsf-consul-template-docker.tar.gz）的支持。
        /// </summary>
        [JsonProperty("ConfigFileCode")]
        public string ConfigFileCode{ get; set; }

        /// <summary>
        /// 后置命令。
        /// </summary>
        [JsonProperty("ConfigPostCmd")]
        public string ConfigPostCmd{ get; set; }

        /// <summary>
        /// Base64编码的配置项
        /// </summary>
        [JsonProperty("EncodeWithBase64")]
        public bool? EncodeWithBase64{ get; set; }

        /// <summary>
        /// 需要绑定的数据集ID。该参数可以通过调用 [DescribePrograms](https://cloud.tencent.com/document/product/649/73477) 的返回值中的 ProgramId 字段来获取或通过登录[控制台](https://console.cloud.tencent.com/tsf/privilege?tab=program&roleId=role-yrle4doy)查看；也可以调用[CreateProgram](https://cloud.tencent.com/document/product/649/108544)创建新的数据集。
        /// </summary>
        [JsonProperty("ProgramIdList")]
        public string[] ProgramIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamSimple(map, prefix + "ConfigVersion", this.ConfigVersion);
            this.SetParamSimple(map, prefix + "ConfigFileName", this.ConfigFileName);
            this.SetParamSimple(map, prefix + "ConfigFileValue", this.ConfigFileValue);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ConfigFilePath", this.ConfigFilePath);
            this.SetParamSimple(map, prefix + "ConfigVersionDesc", this.ConfigVersionDesc);
            this.SetParamSimple(map, prefix + "ConfigFileCode", this.ConfigFileCode);
            this.SetParamSimple(map, prefix + "ConfigPostCmd", this.ConfigPostCmd);
            this.SetParamSimple(map, prefix + "EncodeWithBase64", this.EncodeWithBase64);
            this.SetParamArraySimple(map, prefix + "ProgramIdList.", this.ProgramIdList);
        }
    }
}

