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

    public class GetFunctionResponse : AbstractModel
    {
        
        /// <summary>
        /// 函数的最后修改时间
        /// </summary>
        [JsonProperty("ModTime")]
        public string ModTime{ get; set; }

        /// <summary>
        /// 函数的代码
        /// </summary>
        [JsonProperty("CodeInfo")]
        public string CodeInfo{ get; set; }

        /// <summary>
        /// 函数的描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 函数的触发器列表
        /// </summary>
        [JsonProperty("Triggers")]
        public Trigger[] Triggers{ get; set; }

        /// <summary>
        /// 函数的入口
        /// </summary>
        [JsonProperty("Handler")]
        public string Handler{ get; set; }

        /// <summary>
        /// 函数代码大小
        /// </summary>
        [JsonProperty("CodeSize")]
        public long? CodeSize{ get; set; }

        /// <summary>
        /// 函数的超时时间
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 函数的版本
        /// </summary>
        [JsonProperty("FunctionVersion")]
        public string FunctionVersion{ get; set; }

        /// <summary>
        /// 函数的最大可用内存
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// 函数的运行环境
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// 函数的名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 函数的私有网络
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// 是否使用GPU
        /// </summary>
        [JsonProperty("UseGpu")]
        public string UseGpu{ get; set; }

        /// <summary>
        /// 函数的环境变量
        /// </summary>
        [JsonProperty("Environment")]
        public Environment Environment{ get; set; }

        /// <summary>
        /// 代码是否正确
        /// </summary>
        [JsonProperty("CodeResult")]
        public string CodeResult{ get; set; }

        /// <summary>
        /// 代码错误信息
        /// </summary>
        [JsonProperty("CodeError")]
        public string CodeError{ get; set; }

        /// <summary>
        /// 代码错误码
        /// </summary>
        [JsonProperty("ErrNo")]
        public long? ErrNo{ get; set; }

        /// <summary>
        /// 函数的命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 函数绑定的角色
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 是否自动安装依赖
        /// </summary>
        [JsonProperty("InstallDependency")]
        public string InstallDependency{ get; set; }

        /// <summary>
        /// 函数状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 日志投递到的Cls日志集
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// 日志投递到的Cls Topic
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// 函数ID
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// 函数的标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// EipConfig配置
        /// </summary>
        [JsonProperty("EipConfig")]
        public EipOutConfig EipConfig{ get; set; }

        /// <summary>
        /// 域名信息
        /// </summary>
        [JsonProperty("AccessInfo")]
        public AccessInfo AccessInfo{ get; set; }

        /// <summary>
        /// 函数类型，取值为HTTP或者Event
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 是否启用L5
        /// </summary>
        [JsonProperty("L5Enable")]
        public string L5Enable{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModTime", this.ModTime);
            this.SetParamSimple(map, prefix + "CodeInfo", this.CodeInfo);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Triggers.", this.Triggers);
            this.SetParamSimple(map, prefix + "Handler", this.Handler);
            this.SetParamSimple(map, prefix + "CodeSize", this.CodeSize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "FunctionVersion", this.FunctionVersion);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "UseGpu", this.UseGpu);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamSimple(map, prefix + "CodeResult", this.CodeResult);
            this.SetParamSimple(map, prefix + "CodeError", this.CodeError);
            this.SetParamSimple(map, prefix + "ErrNo", this.ErrNo);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "InstallDependency", this.InstallDependency);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "EipConfig.", this.EipConfig);
            this.SetParamObj(map, prefix + "AccessInfo.", this.AccessInfo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "L5Enable", this.L5Enable);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

