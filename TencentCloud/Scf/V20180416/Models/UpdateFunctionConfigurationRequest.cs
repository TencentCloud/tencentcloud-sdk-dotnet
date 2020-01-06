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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateFunctionConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// 要修改的函数名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 函数描述。最大支持 1000 个英文字母、数字、空格、逗号和英文句号，支持中文
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 函数运行时内存大小，默认为 128 M，可选范 128 M-1536 M
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// 函数最长执行时间，单位为秒，可选值范 1-300 秒，默认为 3 秒
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 函数运行环境，目前仅支持 Python2.7，Python3.6，Nodejs6.10，PHP5， PHP7，Golang1 和 Java8
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// 函数的环境变量
        /// </summary>
        [JsonProperty("Environment")]
        public Environment Environment{ get; set; }

        /// <summary>
        /// 函数所属命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 函数的私有网络配置
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// 函数绑定的角色
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 日志投递到的cls日志集ID
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// 日志投递到的cls Topic ID
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// 在更新时是否同步发布新版本，默认为：FALSE，不发布
        /// </summary>
        [JsonProperty("Publish")]
        public string Publish{ get; set; }

        /// <summary>
        /// 是否开启L5访问能力，TRUE 为开启，FALSE为关闭
        /// </summary>
        [JsonProperty("L5Enable")]
        public string L5Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "Publish", this.Publish);
            this.SetParamSimple(map, prefix + "L5Enable", this.L5Enable);
        }
    }
}

