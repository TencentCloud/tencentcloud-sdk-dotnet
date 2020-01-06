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

    public class CreateFunctionRequest : AbstractModel
    {
        
        /// <summary>
        /// 创建的函数名称，函数名称支持26个英文字母大小写、数字、连接符和下划线，第一个字符只能以字母开头，最后一个字符不能为连接符或者下划线，名称长度2-60
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 函数的代码. 注意：不能同时指定Cos与ZipFile
        /// </summary>
        [JsonProperty("Code")]
        public Code Code{ get; set; }

        /// <summary>
        /// 函数处理方法名称，名称格式支持 "文件名称.方法名称" 形式，文件名称和函数名称之间以"."隔开，文件名称和函数名称要求以字母开始和结尾，中间允许插入字母、数字、下划线和连接符，文件名称和函数名字的长度要求是 2-60 个字符
        /// </summary>
        [JsonProperty("Handler")]
        public string Handler{ get; set; }

        /// <summary>
        /// 函数描述,最大支持 1000 个英文字母、数字、空格、逗号、换行符和英文句号，支持中文
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 函数运行时内存大小，默认为 128M，可选范围 128MB-1536MB，并且以 128MB 为阶梯
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// 函数最长执行时间，单位为秒，可选值范围 1-300 秒，默认为 3 秒
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 函数的环境变量
        /// </summary>
        [JsonProperty("Environment")]
        public Environment Environment{ get; set; }

        /// <summary>
        /// 函数运行环境，目前仅支持 Python2.7，Python3.6，Nodejs6.10， PHP5， PHP7，Golang1 和 Java8，默认Python2.7
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// 函数的私有网络配置
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// 函数所属命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 函数绑定的角色
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 函数日志投递到的CLS LogsetID
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// 函数日志投递到的CLS TopicID
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// 函数类型，默认值为Event，创建触发器函数请填写Event，创建HTTP函数级服务请填写HTTP
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// CodeSource 代码来源，支持以下'ZipFile', 'Cos', 'Demo', 'TempCos', 'Git'之一，使用Git来源必须指定此字段
        /// </summary>
        [JsonProperty("CodeSource")]
        public string CodeSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamObj(map, prefix + "Code.", this.Code);
            this.SetParamSimple(map, prefix + "Handler", this.Handler);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CodeSource", this.CodeSource);
        }
    }
}

